Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("ClientScripts.Test.Integration.OnTheHomePage", {
        inherits: [UI5.Tests.BaseIntegrationPage],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[sap.ui.test.Opa5],"pi":[{"n":"Opa5","pt":sap.ui.test.Opa5,"ps":0}],"sn":"ctor"},{"a":2,"n":"RequireScript","is":true,"t":8,"sn":"RequireScript","rt":System.Void},{"at":[new UI5.Tests.OpaAssertionAttribute()],"v":true,"a":2,"n":"iShouldSeeTheHomeView","t":8,"sn":"iShouldSeeTheHomeView","rt":Bridge.virtualc("JQueryPromise")},{"a":2,"n":"sViewName","t":4,"rt":System.String,"sn":"sViewName"}]}; },
        fields: {
            sViewName: null
        },
        ctors: {
            ctor: function (Opa5) {
                this.$initialize();
                UI5.Tests.BaseIntegrationPage.ctor.call(this, Opa5);
            }
        },
        methods: {
            iShouldSeeTheHomeView: function () {
                return this.waitFor({ viewName: this.sViewName, success: Bridge.fn.bind(this, function (obj) {
                    UI5.Tests.BaseIntegrationPage.Opa5.assert.ok(this.sViewName, "The home view was displayed");
                }), errorMessage: "The home view was not displayed" });
            }
        }
    });
});

sap.ui.require(System.Array.init(["sap/ui/test/Opa5", "manu/toolpageapp/fv/test/integration/pages/Common"], System.String), (function (Opa5, Common) {
    var map = { };

    var testPage = new ClientScripts.Test.Integration.OnTheHomePage(Opa5);
    testPage.sViewName = "Home";

    var cpo = testPage.GetPageObject();
    cpo.baseClass = Common;
    map['ClientScripts.Test.Integration.OnTheHomePage'] = cpo;

    sap.ui.test.Opa5.createPageObjects(map);
}));
