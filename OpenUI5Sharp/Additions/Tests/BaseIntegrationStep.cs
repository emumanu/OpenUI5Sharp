using System;
using Bridge;

namespace OpenUI5Sharp
{
    /// <summary>
    /// Base class for Integration steps for OPA Tests
    /// </summary>
    [FileName("openui5sharp-test.js")]
    [Priority(1000)]
    public partial class BaseIntegrationStep : sap.ui.test.Opa5
    {
        public static sap.ui.test.Opa5 Opa5;

        [Init(InitPosition.Top)]
        public static void Script()
        {
            sap.ui.require(new string[] { "sap/ui/test/Opa5" });
        }
    }
}