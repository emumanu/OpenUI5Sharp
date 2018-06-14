sap.ui.require(System.Array.init(["sap/ui/test/Opa5"], System.String));

Bridge.assembly("OpenUI5Sharp", function ($asm, globals) {
    "use strict";

    var sinon;

    /** @namespace OpenUI5Sharp */

    /**
     * Base class for Integration steps for OPA Tests
     *
     * @public
     * @class OpenUI5Sharp.BaseIntegrationStep
     * @augments sap.ui.test.Opa5
     */
    Bridge.define("OpenUI5Sharp.BaseIntegrationStep", {
        inherits: [sap.ui.test.Opa5],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"a":2,"n":"Script","is":true,"t":8,"sn":"Script","rt":System.Void},{"a":2,"n":"Opa5","is":true,"t":4,"rt":sap.ui.test.Opa5,"sn":"Opa5"}]}; },
        statics: {
            fields: {
                Opa5: null
            }
        }
    });

    /**
     * Base class for Unit Tests with Qunit and SinonJS
     *
     * @public
     * @class OpenUI5Sharp.BaseUnitTest
     */
    Bridge.define("OpenUI5Sharp.BaseUnitTest", {
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"v":true,"a":2,"n":"clock","t":8,"sn":"clock","rt":Bridge.virtualc("sinon.SinonFakeTimers")},{"v":true,"a":2,"n":"clock","t":8,"pi":[{"n":"timers","ip":true,"pt":System.Array.type(System.String),"ps":0}],"sn":"clock","rt":Bridge.virtualc("sinon.SinonFakeTimers"),"p":[System.Array.type(System.String)]},{"v":true,"a":2,"n":"clock","t":8,"pi":[{"n":"now","pt":System.Double,"ps":0},{"n":"timers","ip":true,"pt":System.Array.type(System.String),"ps":1}],"sn":"clock","rt":Bridge.virtualc("sinon.SinonFakeTimers"),"p":[System.Double,System.Array.type(System.String)]},{"v":true,"a":2,"n":"mock","t":8,"sn":"mock","rt":Bridge.virtualc("sinon.SinonMock")},{"v":true,"a":2,"n":"mock","t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0}],"sn":"mock","rt":Bridge.virtualc("sinon.SinonMock"),"p":[System.Object]},{"v":true,"a":2,"n":"sandbox","t":8,"sn":"sandbox","rt":Bridge.virtualc("sinon.SinonSandbox")},{"v":true,"a":2,"n":"spy","t":8,"sn":"spy","rt":Bridge.virtualc("sinon.SinonSpy")},{"v":true,"a":2,"n":"spy","t":8,"pi":[{"n":"func","pt":System.Object,"ps":0}],"sn":"spy","rt":Bridge.virtualc("sinon.SinonSpy"),"p":[System.Object]},{"v":true,"a":2,"n":"spy","t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0},{"n":"method","pt":System.String,"ps":1}],"sn":"spy","rt":Bridge.virtualc("sinon.SinonSpy"),"p":[System.Object,System.String]},{"v":true,"a":2,"n":"stub","t":8,"sn":"stub","rt":Bridge.virtualc("sinon.SinonStub")},{"v":true,"a":2,"n":"stub","t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0}],"sn":"stub","rt":Bridge.virtualc("sinon.SinonStub"),"p":[System.Object]},{"v":true,"a":2,"n":"stub","t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0},{"n":"method","pt":System.String,"ps":1}],"sn":"stub","rt":Bridge.virtualc("sinon.SinonStub"),"p":[System.Object,System.String]},{"v":true,"a":2,"n":"stub","t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0},{"n":"method","pt":System.String,"ps":1},{"n":"func","pt":System.Object,"ps":2}],"sn":"stub","rt":Bridge.virtualc("sinon.SinonStub"),"p":[System.Object,System.String,System.Object]}]}; }
    });
});
