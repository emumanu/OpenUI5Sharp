using Bridge;
using System;
using System.Linq;
using UI5;

namespace RoutingClientScripts
{
    [FileName("controller/employee/overview/EmployeeOverview.controller.js")]
    [Name("sap.ui.demo.nav.controller.employee.overview.EmployeeOverview")]
    public class EmployeeOverviewController : BaseController
    {
        [Init(InitPosition.Top)]
        public static void ScriptTop()
        {
            jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
            jQuery.sap.declare(new { modName = nameof(EmployeeController), type = "controller" });
        }

        public EmployeeOverviewController(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
        }
    }
}
