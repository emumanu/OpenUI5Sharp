jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
jQuery.sap.declare({ modName: "sap.ui.demo.nav.controller.App", type: "controller" });

Bridge.assembly("RoutingClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.nav.controller.App", {
        inherits: [sap.ui.demo.nav.controller.BaseController],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String],"pi":[{"n":"sName","pt":System.String,"ps":0}],"sn":"ctor"},{"a":2,"n":"ScriptTop","is":true,"t":8,"sn":"ScriptTop","rt":System.Void},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void}]}; },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                sap.ui.demo.nav.controller.BaseController.ctor.call(this, sName);
            }
        },
        methods: {
            onInit: function () {
                // This is ONLY for being used within the tutorial.
                // The default log level of the current running environment may be higher than INFO,
                // in order to see the debug info in the console, the log level needs to be explicitly
                // set to INFO here.
                // But for application development, the log level doesn't need to be set again in the code.
                jQuery.sap.log.setLevel(jQuery.sap.log.Level.INFO);

                var oRouter = this.getRouter();

                oRouter.attachBypassed(function (oEvent, oData) {
                    var $t, $t1, $t2;
                    var sHash = sapuibaseExtensions.getParameterFor(System.Object, System.String, oEvent, ($t = { ntype: 38, t: System.Object, n: "p" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"hash","t":4,"rt":System.String,"sn":"hash"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) })));
                    // do something here, i.e. send logging data to the backend for analysis
                    // telling what resource the user tried to access...
                    jQuery.sap.log.info(System.String.format("Sorry, but the hash {0} is invalid.", [sHash]), "The resource was not found.");
                });

                oRouter.attachRouteMatched(function (oEvent, oData) {
                    var $t, $t1, $t2;
                    var sRouteName = sapuibaseExtensions.getParameterFor(System.Object, System.String, oEvent, ($t = { ntype: 38, t: System.Object, n: "p" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"name","t":4,"rt":System.String,"sn":"name"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) })));
                    // do something, i.e. send usage statistics to backend
                    // in order to improve our app and the user experience (Build-Measure-Learn cycle)
                    jQuery.sap.log.info(System.String.format("User accessed route {0}, timestamp = {1}", sRouteName, System.DateTime.getNow()));
                });
            }
        }
    });
});
