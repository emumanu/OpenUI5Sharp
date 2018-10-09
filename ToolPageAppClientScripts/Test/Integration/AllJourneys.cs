using Bridge;
using System;
using System.Linq;
using UI5;
using System.Collections.Generic;
using static Retyped.qunit;
using static Retyped.sinon.Sinon;

namespace ClientScripts.Test.Integration
{
    [FileName("test/integration/allJourneys.js")]
    public class AllJourneys
    {
        [Init(InitPosition.Top)]
        public static void RequireScript()
        {
            jQuery.sap.require("sap.ui.qunit.qunit-css");
            jQuery.sap.require("sap.ui.thirdparty.qunit");
            jQuery.sap.require("sap.ui.qunit.qunit-junit");
            QUnit.config.autostart = false;
        }

        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "sap/ui/test/Opa5",
                    "manu/toolpageapp/fv/test/integration/pages/Common",
                    "sap/ui/test/opaQunit",
                    "manu/toolpageapp/fv/test/integration/pages/App",
                    "manu/toolpageapp/fv/test/integration/pages/Settings",
                    "manu/toolpageapp/fv/test/integration/pages/Statistics",
                    "manu/toolpageapp/fv/test/integration/pages/Home"
                },
                new Action<sap.ui.test.Opa5, object>((Opa5, Common) => {
                    sap.ui.test.Opa5.extendConfig(new sap.ui.test.Opa5Config {
                        arrangements = new Common(),
                        viewNamespace = "manu.toolpageapp.fv.view."
                    });

                    sap.ui.require(new string[] {
                            "manu/toolpageapp/fv/test/integration/NavigationJourney"
                        },
                        new Action(() => {
                            QUnit.start();
                        })
                    );
                })
            );
        }
   }
}