using System;
using Bridge;
using System.Reflection;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace UI5
{
    [FileName("openui5sharp.js")]
    public static partial class Glue
    {
        /// <summary>Checks if the value passed is null of undefined</summary>
        /// <param name="val">the value to check</param>
        /// <returns>true if val is null or undefined; false otherwise</returns>
        public static bool IsNullOrUndefined(object val)
        {
            return ((val == null) || (val == Script.Undefined));
        }

        /// <summary>The value passed if it is a boolean or can be converted to boolean</summary>
        /// <param name="val">the value</param>
        /// <returns>true if val or can be converted to a boolean; false otherwise</returns>
        public static bool ToBoolean(object val)
        {
            if (IsNullOrUndefined(val)) {
                return false;
            }

            if (val is string) {
                return (string)val == "true";
            }

            return Script.Boolean(val);
        }

        public static T CreateRawClassObject<T>(bool isUI5Class = true) //where T : sap.ui.@base.Object
        {
            Type type = typeof(T);
            T obj = Activator.GetPrototype<T>();
            Type baseType = type.BaseType;

            // copies static fields. This is needed to get the metadata values working, as non static
            // fields have default values after calling Activator.GetPrototype<T>()
            foreach (FieldInfo field in type.GetFields().Where(f => f.IsStatic)) {
                obj[field.ScriptName] = field.GetValue(null);
            };

            if (isUI5Class) {
                SetPrototypeToObject(obj);
                obj["$UI5SharpBaseType"] = baseType;
            } else {
                CopyToGlobalScope(type.FullName, obj);
            }

            return obj;
        }

        public static T CreateUI5CompatClass<T>()
        {
            Type type = typeof(T);
            T classObj = Activator.GetPrototype<T>();
            Type baseType = type.BaseType;

            SetPrototypeToObject(classObj);
            classObj["$UI5SharpBaseType"] = baseType;

            return classObj;
        }

        public static T CreateClassInGlobalScope<T>()
        {
            Type type = typeof(T);
            T classObj = Activator.GetPrototype<T>();
            CopyToGlobalScope(type.FullName, classObj);
            return classObj;
        }

        public static void CopyToGlobalScope<T>(string typeName, T obj)
        {
            var context = GetWindow();

            string[] parts = typeName.Split('.');
            string lastPart = (string)parts.Pop();

            // ensures object exists
            foreach (var part in parts) {
                if (Script.IsNull(context[part]) ||
                    (!Script.IsUndefined(context[part]) && ((Script.TypeOf(context[part]) != "object") && (Script.TypeOf(context[part]) != "function")))) {
                    throw new InvalidOperationException($"Could not set object-path for {typeName}, path segment {part} already exists.");
                }

                if (Script.IsUndefined(context[part])) {
                    context[part] = new object();
                }

                context = context[part];
            }

            context[lastPart] = obj["ctor"];
        }

        [Template("window")]
        private static extern object GetWindow();

        public static T ExtendUI5Class<T>(T rawClass) where T : sap.ui.@base.Object
        {
            Type type = typeof(T);
            string fullTypeName = type.FullName;
            dynamic baseType = rawClass["$UI5SharpBaseType"];
            return baseType.extend(fullTypeName, rawClass);
        }

        public static T CreateAndExtendUI5Class<T>() where T : sap.ui.@base.Object
        {
            T obj = CreateUI5CompatClass<T>();
            return ExtendUI5Class<T>(obj);
        }

        [Template("eval(Bridge.Reflection.getTypeFullName({obj}).replace(/\\./g, '_') + ' = {obj}')")]
        public static extern void CreateUI5CompatScope(object obj);

        [Template("eval({className}.replace(/\\./g, '_') + ' = window')")]
        public static extern void CreateInScope(string className);

        [Template("Object.setPrototypeOf({obj}, Object)")]
        private static extern void SetPrototypeToObject(object obj);
    }
}
