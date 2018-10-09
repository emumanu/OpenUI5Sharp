jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
jQuery.sap.declare({ modName: "sap.ui.demo.nav.controller.NotFound", type: "controller" });

Bridge.assembly("RoutingClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.nav.controller.NotFound", {
        inherits: [sap.ui.demo.nav.controller.BaseController],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String],"pi":[{"n":"sName","pt":System.String,"ps":0}],"sn":"ctor"},{"a":2,"n":"ScriptTop","is":true,"t":8,"sn":"ScriptTop","rt":System.Void},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void},{"ov":true,"a":2,"n":"onNavBack","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onNavBack","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"_oData","t":4,"rt":System.Object,"sn":"_oData"}]}; },
        fields: {
            _oData: null
        },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                sap.ui.demo.nav.controller.BaseController.ctor.call(this, sName);
            }
        },
        methods: {
            onInit: function () {
                var oRouter = this.getRouter();
                var oTarget = oRouter.getTarget("notFound");
                oTarget.attachDisplay(Bridge.fn.bind(this, function (oEvent, oData) {
                    var $t, $t1, $t2;
                    this._oData = sapuibaseExtensions.getParameterFor(System.Object, System.Object, oEvent, ($t = { ntype: 38, t: System.Object, n: "p" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"data","t":4,"rt":System.Object,"sn":"data"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) })));
                }));
            },
            onNavBack: function (oEvent, oData) {
                var oHistory = sap.ui.core.routing.History.getInstance();
                var sPreviousHash = oHistory.getPreviousHash();

                if (Bridge.hasValue(sPreviousHash)) {
                    window.history.go(-1);
                } else {
                    this.getRouter().navTo("appHome", { }, true);
                }

                // in some cases we could display a certain target when the back button is pressed
                if ((this._oData != null) && (this._oData.fromTarget != null)) {
                    this.getRouter().getTargets().display(this._oData.fromTarget);
                    delete this._oData.fromTarget;
                    return;
                }

                // call the parent's onNavBack
                sap.ui.demo.nav.controller.BaseController.prototype.onNavBack.call(this, oEvent, oData);
            }
        }
    });
});
