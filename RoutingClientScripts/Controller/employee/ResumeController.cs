using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;

namespace RoutingClientScripts
{
    [FileName("controller/employee/Resume.controller.js")]
    [Name("sap.ui.demo.nav.controller.employee.Resume")]
    public class ResumeController : BaseController
    {
        [ObjectLiteral]
        public class ViewModel
        {
            public string selectedTabKey;
        }

        public static object[] _aValidTabKeys = new string[] { "Info", "Projects", "Hobbies", "Notes" };

        [Init(InitPosition.Top)]
        public static void ScriptTop()
        {
            jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
            jQuery.sap.require("sap/ui/model/json/JSONModel");

            jQuery.sap.declare(new { modName = nameof(ResumeController), type = "controller" });
        }

        public ResumeController(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
            var oRouter = this.getRouter();
            oRouter.getRoute("employeeResume").attachMatched(_onRouteMatched);

            this.getView().setModel(new sap.ui.model.json.JSONModel(new ViewModel()), "view");
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

            var oQuery = oArgs["?query"];
            if (!Glue.IsNullOrUndefined(oQuery) && _aValidTabKeys.Contains(oQuery["tab"])) {
                oView.getModelFor<ViewModel>("view").setPropertyFor(m => m.selectedTabKey, oQuery["tab"]);

                // support lazy loading for the hobbies and notes tab
                if (oQuery["tab"].As<string>() == "Hobbies" || oQuery["tab"].As<string>() == "Notes") {
                    // the target is either "resumeTabHobbies" or "resumeTabNotes"
                    this.getRouter().getTargets().display("resumeTab" + oQuery["tab"]);
                }
            } else {
                // the default query param should be visible at all time
                this.getRouter().navTo("employeeResume", new {
                    employeeId = oArgs["employeeId"],
					query = new {
                        tab = _aValidTabKeys[0]
                    }
                },true /*no history*/);
            }
        }

        public void _onBindingChange(sap.ui.@base.Event<sap.ui.model.Binding.ChangeInfo> oEvent, object oData)
        {
            // No data for the binding
            if (this.getView().getBindingContext() == null) {
                this.getRouter().getTargets().display("notFound");
            }
        }

        public void onTabSelect(sap.ui.@base.Event oEvent, object oData)
        {
            var oCtx = this.getView().getBindingContext();
            this.getRouter().navTo("employeeResume", new {
                employeeId = oCtx.For<Employee>().getPropertyFor(e => e.EmployeeID, false),
                query = new {
                    tab = oEvent.getParameter("selectedKey")
                }
            }, true /*without history*/);
        }


    }
}
