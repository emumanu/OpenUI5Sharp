using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using Bridge;
using UI5;

namespace UI5.Metadata
{
    [FileName("openui5sharp.js")]
    public static partial class TypedMetadata
    {
        public static sap.ui.@base.ManagedObject.EventInfo CreateUI5EventInfo<T>()
        {
            var paramDict = new Map<sap.ui.@base.ManagedObject.ParameterInfo>();

            // copies non static fields
            // TODO: nested fields
            foreach (FieldInfo field in typeof(T).GetFields().Where(f => !f.IsStatic)) {
                paramDict[field.ScriptName] = new sap.ui.@base.ManagedObject.ParameterInfo() {
                    type = GetUI5Type(field.FieldType)
                };
            };

            sap.ui.@base.ManagedObject.EventInfo evt = new sap.ui.@base.ManagedObject.EventInfo() {
                parameters = paramDict
            };

            return evt;
        }

        public static string GetUI5Type(Type fieldType)
        {
            string result = fieldType.Name;

            var primitiveTypes = new Dictionary<Type, Func<string>> {
                { typeof(string), () => result = "string" },
                { typeof(bool), () => result = "boolean" },
                { typeof(int), () => result = "int" },
                { typeof(float), () => result = "float" },
                { typeof(object), () => result = "object" },
                // TODO: what to do with any???
            };

            if (primitiveTypes.ContainsKey(fieldType)) {
                primitiveTypes[fieldType]();
            } else {
                // TODO: log
            }

            return result;
        }
    }
}
