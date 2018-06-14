jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
jQuery.sap.declare({ modName: "sap.ui.demo.nav.controller.Home", type: "controller" });

Bridge.assembly("RoutingClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.nav.controller.Home", {
        inherits: [sap.ui.demo.nav.controller.BaseController],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String],"pi":[{"n":"sName","pt":System.String,"ps":0}],"sn":"ctor"},{"a":2,"n":"ScriptTop","is":true,"t":8,"sn":"ScriptTop","rt":System.Void},{"a":2,"n":"onDisplayNotFound","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onDisplayNotFound","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void},{"a":2,"n":"onNavToEmployeeOverview","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onNavToEmployeeOverview","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"onNavToEmployees","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onNavToEmployees","rt":System.Void,"p":[sap.ui.base.Event,System.Object]}]}; },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                sap.ui.demo.nav.controller.BaseController.ctor.call(this, sName);
            }
        },
        methods: {
            onInit: function () { },
            onDisplayNotFound: function (oEvent, oData) {
                //display the "notFound" target without changing the hash
                this.getRouter().getTargets().display("notFound", { fromTarget: "home" });
            },
            onNavToEmployees: function (oEvent, oData) {
                this.getRouter().navTo("employeeList");
            },
            onNavToEmployeeOverview: function (oEvent, oData) {
                this.getRouter().navTo("employeeOverview");
            }
        }
    });
});
