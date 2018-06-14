using System;
using Bridge;
using System.Reflection;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
    [Namespace(false)]
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

        public static object GetDefaultValue(Type type)
        {
            object output = null;

            if (type.IsValueType) {
                output = Activator.CreateInstance(type);
            }

            return output;
        }

        public static T CreateRawClassObject<T>(object metadata = null, object renderer = null, Type[] ctorParamTypes = null)
        {
            Type type = typeof(T);
            object obj = new object();

            // adds the metadata if present
            if (metadata != null) {
                obj["metadata"] = metadata;
            }

            // adds the renderer if present
            if (renderer != null) {
                obj["renderer"] = renderer;
            }

            ConstructorInfo constructor = null;

            // if there is no constructor specified, gets the one and only constructor
            if (ctorParamTypes == null) {
                constructor = type.GetConstructors().Single();
            } else {
                // otherwise, find a matching constructor
                constructor = type.GetConstructor(ctorParamTypes);
                if (constructor == null) {
                    throw new InvalidOperationException($"Error, there is no constructor with parameter type(s) {String.Join(", ", ctorParamTypes.Select(t => t.FullName))} for type {type.FullName}");
                }
            }

            // copies non static fields
            foreach (FieldInfo field in type.GetFields().Where(f => !f.IsStatic)) {
                obj[field.ScriptName] = GetDefaultValue(field.FieldType);
            };

            // copies non static methods
            foreach (MethodInfo method in type.GetMethods().Where(m => !m.IsStatic)) {
                obj[method.ScriptName] = method.DeclaringType.Prototype.ToDynamic()[method.ScriptName];
            };

            // adds the constructor if present
            if (constructor != null) {
                obj["constructor"] = constructor.DeclaringType.Prototype.ToDynamic()[constructor.ScriptName];
                obj["$initialize"] = (Action)(() => {});
            }

            return obj.As<T>();
        }
    }
}
