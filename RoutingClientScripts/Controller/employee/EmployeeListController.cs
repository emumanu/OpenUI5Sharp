using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;

namespace RoutingClientScripts
{
    [FileName("controller/employee/EmployeeList.controller.js")]
    [Name("sap.ui.demo.nav.controller.employee.EmployeeList")]
    public class EmployeeListController : BaseController
    {
        [Init(InitPosition.Top)]
        public static void ScriptTop()
        {
            jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
            jQuery.sap.declare(new { modName = nameof(EmployeeListController), type = "controller" });
        }

        public EmployeeListController(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
        }

        public void onListItemPressed(sap.ui.@base.Event oEvent, object oData)
        {
            var oItem = oEvent.getSource<sap.m.StandardListItem>();
            var oCtx = oItem.getBindingContext();
            this.getRouter().navTo("employee", new {
                employeeId = oCtx.For<Employee>().getPropertyFor(e => e.EmployeeID, false)
            });
        }
    }
}
