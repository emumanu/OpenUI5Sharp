Bridge.assembly("WalkthroughClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.walkthrough.controller.Detail", {
        inherits: [sap.ui.core.mvc.Controller],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String],"pi":[{"n":"sName","pt":System.String,"ps":0}],"sn":"ctor"},{"a":2,"n":"Script","is":true,"t":8,"sn":"Script","rt":System.Void},{"a":2,"n":"_onObjectMatched","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"_onObjectMatched","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void},{"a":2,"n":"onNavBack","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onNavBack","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"onRatingChange","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onRatingChange","rt":System.Void,"p":[sap.ui.base.Event,System.Object]}]}; },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                sap.ui.core.mvc.Controller.call(this, sName);
            }
        },
        methods: {
            onInit: function () {
                var oViewModel = new sap.ui.model.json.JSONModel({ currency: "EUR" });
                this.getView().setModel(oViewModel, "view");

                var oRouter = sap.ui.core.UIComponent.getRouterFor(this);
                oRouter.getRoute("detail").attachPatternMatched(Bridge.fn.cacheBind(this, this._onObjectMatched));
            },
            _onObjectMatched: function (oEvent, oData) {
                var $t, $t1, $t2;
                this.byId("rating").reset();
                this.getView().bindElement({ path: decodeURIComponent(Bridge.cast(sapuibaseExtensions.getParameterFor(System.Object, System.Object, oEvent, ($t = { ntype: 38, t: System.Object, n: "p" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"arguments","t":4,"rt":System.Object,"sn":"arguments"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) }))).invoicePath, System.String)), model: "invoice" });
            },
            onRatingChange: function (oEvent, oData) {
                var fValue = oEvent.getParameter("value");
                var oResourceBundle = this.getView().getModel("i18n").getResourceBundle();
                sap.m.MessageToast.show(oResourceBundle.getText("ratingConfirmation", System.Array.init([fValue], System.Object)));
            },
            onNavBack: function (oEvent, oData) {
                var oHistory = sap.ui.core.routing.History.getInstance();
                var sPreviousHash = oHistory.getPreviousHash();

                if (!Bridge.referenceEquals(sPreviousHash, undefined)) {
                    window.history.go(-1);
                } else {
                    var oRouter = sap.ui.core.UIComponent.getRouterFor(this);
                    oRouter.navTo("overview", { }, true);
                }
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/ui/core/mvc/Controller", "sap/ui/core/routing/History", "sap/m/MessageToast", "sap/ui/model/json/JSONModel"], System.String), function () {
    var newObj = UI5.Glue.CreateRawClassObject(sap.ui.demo.walkthrough.controller.Detail);
    return sap.ui.core.mvc.Controller.extend("sap.ui.demo.walkthrough.controller.Detail", newObj);
});
