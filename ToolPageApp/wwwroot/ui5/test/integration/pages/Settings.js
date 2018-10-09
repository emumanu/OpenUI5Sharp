Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("ClientScripts.Test.Integration.OnTheSettingsPage", {
        inherits: [UI5.Tests.BaseIntegrationPage],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[sap.ui.test.Opa5],"pi":[{"n":"Opa5","pt":sap.ui.test.Opa5,"ps":0}],"sn":"ctor"},{"a":2,"n":"RequireScript","is":true,"t":8,"sn":"RequireScript","rt":System.Void},{"at":[new UI5.Tests.OpaActionAttribute()],"v":true,"a":2,"n":"iPressTheCancelButton","t":8,"sn":"iPressTheCancelButton","rt":Bridge.virtualc("JQueryPromise")},{"at":[new UI5.Tests.OpaActionAttribute()],"v":true,"a":2,"n":"iPressTheOrderSettingsItem","t":8,"sn":"iPressTheOrderSettingsItem","rt":Bridge.virtualc("JQueryPromise")},{"at":[new UI5.Tests.OpaActionAttribute()],"v":true,"a":2,"n":"iPressTheSaveButton","t":8,"sn":"iPressTheSaveButton","rt":Bridge.virtualc("JQueryPromise")},{"at":[new UI5.Tests.OpaAssertionAttribute()],"v":true,"a":2,"n":"iShouldSeeDetailSettingsView","t":8,"sn":"iShouldSeeDetailSettingsView","rt":Bridge.virtualc("JQueryPromise")},{"at":[new UI5.Tests.OpaAssertionAttribute()],"v":true,"a":2,"n":"iShouldSeeMasterSettingsView","t":8,"sn":"iShouldSeeMasterSettingsView","rt":Bridge.virtualc("JQueryPromise")},{"at":[new UI5.Tests.OpaAssertionAttribute()],"v":true,"a":2,"n":"iShouldSeeMessageToast","t":8,"sn":"iShouldSeeMessageToast","rt":Bridge.virtualc("JQueryPromise")},{"a":2,"n":"sViewName1","t":4,"rt":System.String,"sn":"sViewName1"},{"a":2,"n":"sViewName2","t":4,"rt":System.String,"sn":"sViewName2"}]}; },
        fields: {
            sViewName1: null,
            sViewName2: null
        },
        ctors: {
            ctor: function (Opa5) {
                this.$initialize();
                UI5.Tests.BaseIntegrationPage.ctor.call(this, Opa5);
            }
        },
        methods: {
            iPressTheOrderSettingsItem: function () {
                return this.waitFor({ controlType: "sap.m.StandardListItem", viewNamespace: "manu.toolpageapp.fv.view.settings", viewName: this.sViewName1, matchers: new sap.ui.test.matchers.BindingPath({ modelName: "side", path: "/masterSettings/1" }), actions: new sap.ui.test.actions.Press(), errorMessage: "Did not find the order settings item on the master settings page" });
            },
            iPressTheSaveButton: function () {
                return this.waitFor({ id: "save", viewNamespace: "manu.toolpageapp.fv.view.settings", viewName: this.sViewName2, actions: new sap.ui.test.actions.Press(), errorMessage: "Did not find the save button on the detail settings page" });
            },
            iPressTheCancelButton: function () {
                return this.waitFor({ id: "cancel", viewNamespace: "manu.toolpageapp.fv.view.settings", viewName: this.sViewName2, actions: new sap.ui.test.actions.Press(), errorMessage: "Did not find the cancel button on the detail settings page" });
            },
            iShouldSeeMasterSettingsView: function () {
                return this.waitFor({ viewNamespace: "manu.toolpageapp.fv.view.settings", viewName: this.sViewName1, success: Bridge.fn.bind(this, function (obj) {
                    UI5.Tests.BaseIntegrationPage.Opa5.assert.ok(this.sViewName1, "The master settings view was displayed");
                }), errorMessage: "The master settings view was not displayed" });
            },
            iShouldSeeDetailSettingsView: function () {
                return this.waitFor({ viewNamespace: "manu.toolpageapp.fv.view.settings", viewName: this.sViewName2, success: Bridge.fn.bind(this, function (obj) {
                    UI5.Tests.BaseIntegrationPage.Opa5.assert.ok(this.sViewName2, "The detail Settings view was displayed");
                }), errorMessage: "The detail settings view was not displayed" });
            },
            iShouldSeeMessageToast: function () {
                return this.waitFor({ pollingInterval: 100, check: function () {
                    return sap.ui.test.Opa5.getJQuery()(".sapMMessageToast").length !== 0;
                }, success: function (obj) {
                    UI5.Tests.BaseIntegrationPage.Opa5.assert.ok("The message toast was displayed");
                }, errorMessage: "The message toast was not displayed" });
            }
        }
    });
});

sap.ui.require(System.Array.init(["sap/ui/test/Opa5", "manu/toolpageapp/fv/test/integration/pages/Common", "sap/ui/test/matchers/BindingPath", "sap/ui/test/actions/Press"], System.String), (function (Opa5, Common) {
    var map = { };

    var testPage = new ClientScripts.Test.Integration.OnTheSettingsPage(Opa5);
    testPage.sViewName1 = "MasterSettings";
    testPage.sViewName2 = "DetailSettings";

    var cpo = testPage.GetPageObject();
    cpo.baseClass = Common;
    map['ClientScripts.Test.Integration.OnTheSettingsPage'] = cpo;

    sap.ui.test.Opa5.createPageObjects(map);
}));
