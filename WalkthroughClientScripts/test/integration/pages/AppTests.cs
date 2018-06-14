using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using static Retyped.qunit;
using OpenUI5Sharp;
using Retyped;

namespace WalkthroughClientScripts.Tests
{
    [FileName("test/integration/pages/app.js")]
    public class onTheAppPageAction : BaseIntegrationStep
    {
        public virtual jquery.JQueryPromise<object> iPressTheSayHelloWithDialogButton()
        {
            return this.waitFor(new WaitForOptions() {
                controlType = "sap.m.Button",
                success = (Action<object>)((object aButtons) => {
                    aButtons.As<sap.ui.core.Element[]>()[0].dollar().trigger("tap");
                }),
                errorMessage = "Did not find the helloDialogButton button on the app page"
            });
        }
    }

    [FileName("test/integration/pages/app.js")]
    public class onTheAppPageAssertion : BaseIntegrationStep
    {
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

    [FileName("test/integration/pages/App.js")]
    public class AppTests : sap.ui.test.Opa5
    {
        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.require(new string[] {
                    "sap/ui/test/Opa5"
                },
                (new Action<sap.ui.test.Opa5>((Opa5) => {
                    BaseIntegrationStep.Opa5 = Opa5;

                sap.ui.test.Opa5.createPageObjects(
                        new Map<CreatePageObjectsInfo>() {
                            {
                                "onTheAppPage",
                                new CreatePageObjectsInfo() {
                                    actions = Glue.CreateRawClassObject<onTheAppPageAction>(),
                                    assertions= Glue.CreateRawClassObject<onTheAppPageAssertion>()
                                }
                            }
                        }
                    );
                }))
            );
        }
    }
}