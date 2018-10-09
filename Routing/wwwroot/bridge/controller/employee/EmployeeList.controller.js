jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
jQuery.sap.declare({ modName: "sap.ui.demo.nav.controller.employee.EmployeeList", type: "controller" });

Bridge.assembly("RoutingClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.nav.controller.employee.EmployeeList", {
        inherits: [sap.ui.demo.nav.controller.BaseController],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String],"pi":[{"n":"sName","pt":System.String,"ps":0}],"sn":"ctor"},{"a":2,"n":"ScriptTop","is":true,"t":8,"sn":"ScriptTop","rt":System.Void},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void},{"a":2,"n":"onListItemPressed","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onListItemPressed","rt":System.Void,"p":[sap.ui.base.Event,System.Object]}]}; },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                sap.ui.demo.nav.controller.BaseController.ctor.call(this, sName);
            }
        },
        methods: {
            onInit: function () { },
            onListItemPressed: function (oEvent, oData) {
                var $t, $t1, $t2;
                var oItem = oEvent.getSource();
                var oCtx = oItem.getBindingContext();
                this.getRouter().navTo("employee", { employeeId: sapuimodelContextExtensions.getPropertyFor(System.Object, System.Int32, oCtx, ($t = { ntype: 38, t: System.Object, n: "e" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"EmployeeID","t":16,"rt":System.Int32,"g":{"td":System.Object,"a":2,"n":"get_EmployeeID","t":8,"rt":System.Int32,"fg":"EmployeeID","box":function ($v) { return Bridge.box($v, System.Int32);}},"s":{"td":System.Object,"a":2,"n":"set_EmployeeID","t":8,"p":[System.Int32],"rt":System.Void,"fs":"EmployeeID"},"fn":"EmployeeID"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) })), false) });
            }
        }
    });
});
