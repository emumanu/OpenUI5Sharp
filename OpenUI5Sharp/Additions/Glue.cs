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

        public static T CreateRawClassObject<T>()
        {
            Type type = typeof(T);
            T obj = Activator.GetPrototype<T>();

            // copies static fields. This is needed to get the metadata values working, as non static
            // fields have default values after calling Activator.GetPrototype<T>()
            foreach (FieldInfo field in type.GetFields().Where(f => f.IsStatic)) {
                obj[field.ScriptName] = field.GetValue(null);
            };
            
            return obj;
        }
    }
}
