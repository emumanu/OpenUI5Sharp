using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using static Retyped.qunit;
using UI5;
using UI5.Tests;
using Retyped;

namespace WalkthroughClientScripts.Tests
{
    [FileName("test/integration/pages/app.js")]
    public class OnTheAppPage : BaseIntegrationPage
    {
        [Init(InitPosition.Bottom)]
        public static void RequireScript()
        {
            sap.ui.require(new string[] {
                    "sap/ui/test/Opa5"
                },
                (new Action<sap.ui.test.Opa5>((Opa5) => {
                    var map = new Map<CreatePageObjectsInfo>();

                    OnTheAppPage testPage = new OnTheAppPage(Opa5);
                    map.Set<OnTheAppPage>(testPage.GetPageObject());

                    createPageObjects(map);
                }))
            );
        }

        public OnTheAppPage(sap.ui.test.Opa5 Opa5) : base(Opa5)
        {
        }

        [OpaAction]
        public virtual jquery.JQueryPromise<object> iPressTheSayHelloWithDialogButton()
        {
            return this.waitFor(new WaitForOptions() {
                controlType = "sap.m.Button",
                success = (Action<sap.ui.core.Element[]>)((sap.ui.core.Element[] aButtons) => {
                    aButtons[0].dollar().trigger("tap");
                }),
                errorMessage = "Did not find the helloDialogButton button on the app page"
            });
        }

        [OpaAssertion]
        public virtual jquery.JQueryPromise<object> iShouldSeeTheHelloDialog()
        {
            return this.waitFor(new WaitForOptions() {
                controlType = "sap.m.Dialog",
                success = (Action<object>)((object obj) => {
                    Opa5.assert.ok(true, "The dialog is open");
                }),
                errorMessage = "Did not find the helloDialogButton button on the app page"
            });
        }
    }
}