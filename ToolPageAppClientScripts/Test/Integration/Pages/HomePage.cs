using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using UI5;
using UI5.Tests;
using Retyped;

namespace ClientScripts.Test.Integration
{
    [FileName("test/integration/pages/Home.js")]
    public class OnTheHomePage : BaseIntegrationPage
    {
        public string sViewName;

        [Init(InitPosition.Bottom)]
        public static void RequireScript()
        {
            sap.ui.require(new string[] {
                    "sap/ui/test/Opa5",
                    "manu/toolpageapp/fv/test/integration/pages/Common",
                },
                (new Action<sap.ui.test.Opa5, Common>((Opa5, Common) => {
                    var map = new Map<CreatePageObjectsInfo>();

                    OnTheHomePage testPage = new OnTheHomePage(Opa5);
                    testPage.sViewName = "Home";

                    CreatePageObjectsInfo cpo = testPage.GetPageObject();
                    cpo.baseClass = Common;
                    map.Set<OnTheHomePage>(cpo);

                    createPageObjects(map);
                })
            ));
        }

        public OnTheHomePage(sap.ui.test.Opa5 Opa5) : base(Opa5)
        {
        }

        [OpaAssertion]
        public virtual jquery.JQueryPromise<object> iShouldSeeTheHomeView()
        {
            return this.waitFor(new WaitForOptions() {
                viewName = sViewName,
                success = (Action<object>)((object obj) => {
                    Opa5.assert.ok(sViewName, "The home view was displayed");
                }),
                errorMessage = "The home view was not displayed"
            });
        }
    }
}
