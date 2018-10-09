using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;

namespace RoutingClientScripts
{
    [FileName("controller/employee/Employee.controller.js")]
    [Name("sap.ui.demo.nav.controller.employee.Employee")]
    public class EmployeeController : BaseController
    {
        [Init(InitPosition.Top)]
        public static void ScriptTop()
        {
            jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
            jQuery.sap.declare(new { modName = nameof(EmployeeController), type = "controller" });
        }

        public EmployeeController(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
            var oRouter = this.getRouter();
            oRouter.getRoute("employee").attachMatched(_onRouteMatched);
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
        }

        public void _onRouteMatched(sap.ui.@base.Event<sap.ui.core.routing.Route.MatchedInfo> oEvent, object oData)
        {
            var oArgs = oEvent.getParameterFor(p => p.arguments);
            var oView = this.getView();
            var employeeId = oArgs["employeeId"];

            oView.bindElement(new sap.ui.core.Element.BindElementInfo() {
                path = $"/Employees({employeeId})",
				events = new 
                {
                    change = (sap.ui.model.Binding.ChangeDelegate)(this._onBindingChange),
					dataRequested = (sap.ui.@base.EventDelegate)((oEvt, unused) => {
                        oView.setBusy(true);
                    }),
					dataReceived = (sap.ui.@base.EventDelegate)((oEvt, unused) => {
                        oView.setBusy(false);
                    }),
                }
            });
        }
        public void _onBindingChange(sap.ui.@base.Event<sap.ui.model.Binding.ChangeInfo> oEvent, object oData)
        {
            // No data for the binding
            if (this.getView().getBindingContext() == null) {
                this.getRouter().getTargets().display("notFound");
            }
        }

        public void onShowResume(sap.ui.@base.Event oEvent, object oData)
        {
            var oCtx = this.getView().getElementBinding().getBoundContext();

            this.getRouter().navTo("employeeResume", new {
                employeeId = oCtx.For<Employee>().getPropertyFor(e => e.EmployeeID, false)
            });
        }
    }
}
