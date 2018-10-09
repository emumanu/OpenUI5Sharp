using Bridge;
using System;
using System.Linq;
using UI5;

namespace RoutingClientScripts
{
    [FileName("controller/Home.controller.js")]
    [Name("sap.ui.demo.nav.controller.Home")]
    public class HomeController : BaseController
    {
        [Init(InitPosition.Top)]
        public static void ScriptTop()
        {
            jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
            jQuery.sap.declare(new { modName = nameof(HomeController), type = "controller" });
        }

        public HomeController(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
        }

        public void onDisplayNotFound(sap.ui.@base.Event oEvent, object oData)
        {
            //display the "notFound" target without changing the hash
            this.getRouter().getTargets().display("notFound", new { fromTarget = "home" });
        }

        public void onNavToEmployees(sap.ui.@base.Event oEvent, object oData)
        {
            this.getRouter().navTo("employeeList");
        }

        public void onNavToEmployeeOverview(sap.ui.@base.Event oEvent, object oData)
        {
            this.getRouter().navTo("employeeOverview");
        }
    }
}
