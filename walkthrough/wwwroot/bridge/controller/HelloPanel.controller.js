Bridge.assembly("WalkthroughClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.walkthrough.controller.HelloPanel", {
        inherits: [sap.ui.core.mvc.Controller],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String],"pi":[{"n":"sName","pt":System.String,"ps":0}],"sn":"ctor"},{"a":2,"n":"Script","is":true,"t":8,"sn":"Script","rt":System.Void},{"a":2,"n":"onOpenDialog","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onOpenDialog","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"onShowHello","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onShowHello","rt":System.Void,"p":[sap.ui.base.Event,System.Object]}]}; },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                sap.ui.core.mvc.Controller.call(this, sName);
            }
        },
        methods: {
            onShowHello: function (oEvent, oData) {
                var $t, $t1, $t2, $t3;
                // read msg from i18n model
                var oBundle = this.getView().getModel("i18n").getResourceBundle();
                var sRecipient = sapuimodelModelExtensions.getPropertyFor(Bridge.global.System.Object, System.String, this.getView().getModel(), ($t = { ntype: 38, t: System.Object, n: "m" }, ($t3 = ($t2 = {"td":System.Object,"a":2,"n":"name","t":4,"rt":System.String,"sn":"name"}, { ntype: 23, t: $t2.rt, expression: ($t1 = {"td":System.Object,"a":2,"n":"recipient","t":4,"rt":System.Object,"sn":"recipient"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), member: $t2 }), { ntype: 18, t: Function, rt: $t3.t, body: $t3, p: Bridge.toList([$t]) })));
                var sMsg = oBundle.getText("helloMsg", System.Array.init([sRecipient], System.String));
                // show message
                sap.m.MessageToast.show(sMsg);
            },
            onOpenDialog: function (oEvent, oData) {
                this.getOwnerComponent().openHelloDialog();
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/ui/core/mvc/Controller", "sap/m/MessageToast"], System.String), function () {
    var newObj = Glue.CreateRawClassObject(sap.ui.demo.walkthrough.controller.HelloPanel);
    return sap.ui.core.mvc.Controller.extend("sap.ui.demo.walkthrough.controller.HelloPanel", newObj);
});
