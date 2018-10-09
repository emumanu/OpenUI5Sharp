using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using UI5;
using UI5.Tests;
using Retyped;

namespace ClientScripts.Test.Integration
{
    [FileName("test/integration/pages/Settings.js")]
    public class OnTheSettingsPage : BaseIntegrationPage
    {
        public string sViewName1;
        public string sViewName2;

        [Init(InitPosition.Bottom)]
        public static void RequireScript()
        {
            sap.ui.require(new string[] {
                    "sap/ui/test/Opa5",
                    "manu/toolpageapp/fv/test/integration/pages/Common",
                    "sap/ui/test/matchers/BindingPath",
                    "sap/ui/test/actions/Press"
                },
                (new Action<sap.ui.test.Opa5, Common>((Opa5, Common) => {
                    var map = new Map<CreatePageObjectsInfo>();

                    OnTheSettingsPage testPage = new OnTheSettingsPage(Opa5);
                    testPage.sViewName1 = "MasterSettings";
                    testPage.sViewName2 = "DetailSettings";

                    CreatePageObjectsInfo cpo = testPage.GetPageObject();
                    cpo.baseClass = Common;
                    map.Set<OnTheSettingsPage>(cpo);

                    createPageObjects(map);
                })
            ));
        }

        public OnTheSettingsPage(sap.ui.test.Opa5 Opa5) : base(Opa5)
        {
        }

        [OpaAction]
        public virtual jquery.JQueryPromise<object> iPressTheOrderSettingsItem()
        {
            return this.waitFor(new WaitForOptions() {
                controlType = "sap.m.StandardListItem",
				viewNamespace = "manu.toolpageapp.fv.view.settings",
				viewName = sViewName1,
				matchers = new sap.ui.test.matchers.BindingPath(new sap.ui.test.matchers.BindingPath.Settings {
                    modelName = "side",
                    path = "/masterSettings/1"
                }),
				actions = new sap.ui.test.actions.Press(),
				errorMessage = "Did not find the order settings item on the master settings page"
            });
        }

        [OpaAction]
        public virtual jquery.JQueryPromise<object> iPressTheSaveButton()
        {
            return this.waitFor(new WaitForOptions() {
                id = "save",
                viewNamespace = "manu.toolpageapp.fv.view.settings",
                viewName = sViewName2,
                actions = new sap.ui.test.actions.Press(),
                errorMessage = "Did not find the save button on the detail settings page"
            });
        }

        [OpaAction]
        public virtual jquery.JQueryPromise<object> iPressTheCancelButton()
        {
            return this.waitFor(new WaitForOptions() {
                id = "cancel",
                viewNamespace = "manu.toolpageapp.fv.view.settings",
                viewName = sViewName2,
                actions = new sap.ui.test.actions.Press(),
                errorMessage = "Did not find the cancel button on the detail settings page"
            });
        }

        [OpaAssertion]
        public virtual jquery.JQueryPromise<object> iShouldSeeMasterSettingsView()
        {
            return this.waitFor(new WaitForOptions() {
                viewNamespace = "manu.toolpageapp.fv.view.settings",
                viewName = sViewName1,
                success = (Action<object>)((object obj) => {
                    Opa5.assert.ok(sViewName1, "The master settings view was displayed");
                }),
                errorMessage = "The master settings view was not displayed"
            });
        }

        [OpaAssertion]
        public virtual jquery.JQueryPromise<object> iShouldSeeDetailSettingsView()
        {
            return this.waitFor(new WaitForOptions() {
				viewNamespace = "manu.toolpageapp.fv.view.settings",
				viewName = sViewName2,
                success = (Action<object>)((object obj) => {
                    Opa5.assert.ok(sViewName2, "The detail Settings view was displayed");
                }),
				errorMessage = "The detail settings view was not displayed"
			});
    	}

        [OpaAssertion]
        public virtual jquery.JQueryPromise<object> iShouldSeeMessageToast()
        {
            return this.waitFor(new WaitForOptions() {
    			//increase opa's polling because the message toast is only shown for a brief moment
				pollingInterval = 100,
				check = (Func<bool>)(() => {
                    return getJQuery().As<jquery.JQueryStatic<dom.HTMLElement>>().select(".sapMMessageToast").length != 0;
                }),
                success = (Action<object>)((object obj) => {
                    Opa5.assert.ok("The message toast was displayed");
                }),
                errorMessage = "The message toast was not displayed"
			});
		}
    }
}
