jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
jQuery.sap.declare({ modName: "sap.ui.demo.nav.controller.employee.Employee", type: "controller" });

Bridge.assembly("RoutingClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.nav.controller.employee.Employee", {
        inherits: [sap.ui.demo.nav.controller.BaseController],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String],"pi":[{"n":"sName","pt":System.String,"ps":0}],"sn":"ctor"},{"a":2,"n":"ScriptTop","is":true,"t":8,"sn":"ScriptTop","rt":System.Void},{"a":2,"n":"_onBindingChange","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"_onBindingChange","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"_onRouteMatched","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"_onRouteMatched","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void},{"a":2,"n":"onShowResume","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onShowResume","rt":System.Void,"p":[sap.ui.base.Event,System.Object]}]}; },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                sap.ui.demo.nav.controller.BaseController.ctor.call(this, sName);
            }
        },
        methods: {
            onInit: function () {
                var oRouter = this.getRouter();
                oRouter.getRoute("employee").attachMatched(Bridge.fn.cacheBind(this, this._onRouteMatched));
                // Hint: we don't want to do it this way
                /* 
                			oRouter.attachRouteMatched(function (oEvent){
                				var sRouteName, oArgs, oView;
                				sRouteName = oEvent.getParameter("name");
                				if (sRouteName === "employee"){
                					this._onRouteMatched(oEvent);
                				}
                			}, this);
                			*/
            },
            _onRouteMatched: function (oEvent, oData) {
                var $t, $t1, $t2;
                var oArgs = sapuibaseExtensions.getParameterFor(System.Object, System.Object, oEvent, ($t = { ntype: 38, t: System.Object, n: "p" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"arguments","t":4,"rt":System.Object,"sn":"arguments"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) })));
                var oView = this.getView();
                var employeeId = oArgs.employeeId;

                oView.bindElement({ path: System.String.format("/Employees({0})", [employeeId]), events: { change: Bridge.fn.cacheBind(this, this._onBindingChange), dataRequested: function (oEvt, unused) {
                    oView.setBusy(true);
                }, dataReceived: function (oEvt, unused) {
                    oView.setBusy(false);
                } } });
            },
            _onBindingChange: function (oEvent, oData) {
                // No data for the binding
                if (this.getView().getBindingContext() == null) {
                    this.getRouter().getTargets().display("notFound");
                }
            },
            onShowResume: function (oEvent, oData) {
                var $t, $t1, $t2;
                var oCtx = this.getView().getElementBinding().getBoundContext();

                this.getRouter().navTo("employeeResume", { employeeId: sapuimodelContextExtensions.getPropertyFor(System.Object, System.Int32, oCtx, ($t = { ntype: 38, t: System.Object, n: "e" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"EmployeeID","t":16,"rt":System.Int32,"g":{"td":System.Object,"a":2,"n":"get_EmployeeID","t":8,"rt":System.Int32,"fg":"EmployeeID","box":function ($v) { return Bridge.box($v, System.Int32);}},"s":{"td":System.Object,"a":2,"n":"set_EmployeeID","t":8,"p":[System.Int32],"rt":System.Void,"fs":"EmployeeID"},"fn":"EmployeeID"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) })), false) });
            }
        }
    });
});
