using Bridge;
using System;
using System.Linq;
using UI5;

namespace RoutingClientScripts
{
    [FileName("controller/BaseController.js")]
    [Name("sap.ui.demo.nav.controller.BaseController")]
    public class BaseController : sap.ui.core.mvc.Controller
    {
        [Init(InitPosition.Top)]
        public static void ScriptTop()
        {
            jQuery.sap.require("sap/ui/core/mvc/Controller");
            jQuery.sap.require("sap/ui/core/routing/History");
            jQuery.sap.declare(new { modName = "sap.ui.demo.nav.controller.BaseController", type = "controller" });
        }

        public BaseController(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
        }

        public sap.ui.core.routing.Router getRouter()
        {
            return sap.ui.core.UIComponent.getRouterFor(this);
        }

        public virtual void onNavBack(sap.ui.@base.Event oEvent, object oData)
        {
            var oHistory = sap.ui.core.routing.History.getInstance();
            var sPreviousHash = oHistory.getPreviousHash();

            if (Bridge.Script.HasValue(sPreviousHash)) {
                Retyped.dom.window.history.go(-1);
            } else {
                this.getRouter().navTo("appHome", new {}, true /*no history*/);
            }
        }
    }
}
