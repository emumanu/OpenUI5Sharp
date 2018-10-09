jQuery.sap.require("sap/ui/core/mvc/Controller");
jQuery.sap.require("sap/ui/core/routing/History");
jQuery.sap.declare({ modName: "sap.ui.demo.nav.controller.BaseController", type: "controller" });

/**
 * @version 1.0.0.0
 * @copyright Copyright ©  2018
 * @compiler Bridge.NET 17.4.0
 */
Bridge.assembly("RoutingClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.nav.controller.BaseController", {
        inherits: [sap.ui.core.mvc.Controller],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String],"pi":[{"n":"sName","pt":System.String,"ps":0}],"sn":"ctor"},{"a":2,"n":"ScriptTop","is":true,"t":8,"sn":"ScriptTop","rt":System.Void},{"a":2,"n":"getRouter","t":8,"sn":"getRouter","rt":sap.ui.core.routing.Router},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void},{"v":true,"a":2,"n":"onNavBack","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onNavBack","rt":System.Void,"p":[sap.ui.base.Event,System.Object]}]}; },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                sap.ui.core.mvc.Controller.call(this, sName);
            }
        },
        methods: {
            onInit: function () { },
            getRouter: function () {
                return sap.ui.core.UIComponent.getRouterFor(this);
            },
            onNavBack: function (oEvent, oData) {
                var oHistory = sap.ui.core.routing.History.getInstance();
                var sPreviousHash = oHistory.getPreviousHash();

                if (Bridge.hasValue(sPreviousHash)) {
                    window.history.go(-1);
                } else {
                    this.getRouter().navTo("appHome", { }, true);
                }
            }
        }
    });
});
