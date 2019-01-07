using System;
using Bridge;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace UI5.Tests
{
    /// <summary>
    /// Base class for Integration steps for OPA Tests
    /// </summary>
    [FileName("openui5sharp-test.js")]
    [Name("UI5.Tests.BaseIntegrationPage")]
    public partial class BaseIntegrationPage : sap.ui.test.Opa5
    {
        public static sap.ui.test.Opa5 Opa5;

        public BaseIntegrationPage(sap.ui.test.Opa5 Opa5)
        {
            BaseIntegrationPage.Opa5 = Opa5;
        }

        /// <summary>
        /// Method that creates an object instance with some methods that have an associated attribute
        /// </summary>
        /// <param name="attributeType">attribute used to filter the methods to return</param>
        /// <returns>A new instance with the requested methods</returns>
        public virtual object GetInstanceWithMethods(Type attributeType)
        {
            Type type = this.GetType();
            object obj = new object();

            // copies fields
            foreach (FieldInfo field in type.GetFields()) {
                obj[field.ScriptName] = this[field.ScriptName];
            };

            // copies methods with the requested attribute
            foreach (MethodInfo method in type.GetMethods().Where(m => m.GetCustomAttributes(attributeType).Length > 0)) {
                obj[method.ScriptName] = this[method.ScriptName];
            };

            return obj;
        }

        /// <summary>
        /// Creates a page object based on this instance of the integration page
        /// </summary>
        /// <returns>An object with the actions and assertions set to new object instances that have only the methods with OpaAaction and OpaAssertion respectively</returns>
        public virtual CreatePageObjectsInfo GetPageObject()
        {
            return new CreatePageObjectsInfo() {
                actions = GetInstanceWithMethods(typeof(OpaActionAttribute)),
                assertions = GetInstanceWithMethods(typeof(OpaAssertionAttribute))
            };
        }

        [Init(InitPosition.Top)]
        public static void IncludeDependencies()
        {
            sap.ui.require(new string[] { "sap/ui/test/Opa5" });
        }
    }
}