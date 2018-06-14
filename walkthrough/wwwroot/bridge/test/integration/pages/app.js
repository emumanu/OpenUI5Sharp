/**
 * @version 1.0.0.0
 * @copyright Copyright ©  2018
 * @compiler Bridge.NET 17.1.1
 */
Bridge.assembly("WalkthroughClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("WalkthroughClientScripts.Tests.onTheAppPageAction", {
        inherits: [OpenUI5Sharp.BaseIntegrationStep],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"v":true,"a":2,"n":"iPressTheSayHelloWithDialogButton","t":8,"sn":"iPressTheSayHelloWithDialogButton","rt":Bridge.virtualc("JQueryPromise")}]}; },
        methods: {
            iPressTheSayHelloWithDialogButton: function () {
                return this.waitFor({ controlType: "sap.m.Button", success: function (aButtons) {
                    var $t;
                    ($t = aButtons)[0].$().trigger("tap");
                }, errorMessage: "Did not find the helloDialogButton button on the app page" });
            }
        }
    });

    Bridge.define("WalkthroughClientScripts.Tests.onTheAppPageAssertion", {
        inherits: [OpenUI5Sharp.BaseIntegrationStep],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"v":true,"a":2,"n":"iShouldSeeTheHelloDialog","t":8,"sn":"iShouldSeeTheHelloDialog","rt":Bridge.virtualc("JQueryPromise")}]}; },
        methods: {
            iShouldSeeTheHelloDialog: function () {
                return this.waitFor({ controlType: "sap.m.Dialog", success: function (obj) {
                    OpenUI5Sharp.BaseIntegrationStep.Opa5.assert.ok(true, "The dialog is open");
                }, errorMessage: "Did not find the helloDialogButton button on the app page" });
            }
        }
    });

    Bridge.define("WalkthroughClientScripts.Tests.AppTests", {
        inherits: [sap.ui.test.Opa5],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"a":2,"n":"Script","is":true,"t":8,"sn":"Script","rt":System.Void}]}; }
    });
});

sap.ui.require(System.Array.init(["sap/ui/test/Opa5"], System.String), (function (Opa5) {
    OpenUI5Sharp.BaseIntegrationStep.Opa5 = Opa5;

    sap.ui.test.Opa5.createPageObjects(function (_o1) {
        _o1["onTheAppPage"] = { actions: Glue.CreateRawClassObject(WalkthroughClientScripts.Tests.onTheAppPageAction), assertions: Glue.CreateRawClassObject(WalkthroughClientScripts.Tests.onTheAppPageAssertion) };
        return _o1;
    }({ }));
}));
