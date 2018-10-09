using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;

namespace RoutingClientScripts
{
    [FileName("controller/NotFound.controller.js")]
    [Name("sap.ui.demo.nav.controller.NotFound")]
    public class NotFoundController : BaseController
    {
        public object _oData;

        [Init(InitPosition.Top)]
        public static void ScriptTop()
        {
            jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
            jQuery.sap.declare(new { modName = nameof(NotFoundController), type = "controller" });
        }

        public NotFoundController(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
            var oRouter = this.getRouter();
            var oTarget = (sap.ui.core.routing.Target)oRouter.getTarget("notFound");
            oTarget.attachDisplay((oEvent, oData) => {
                this._oData = oEvent.getParameterFor(p => p.data);
            });
        }

        public override void onNavBack(sap.ui.@base.Event oEvent, object oData)
        {
            var oHistory = sap.ui.core.routing.History.getInstance();
            var sPreviousHash = oHistory.getPreviousHash();

            if (Bridge.Script.HasValue(sPreviousHash)) {
                Retyped.dom.window.history.go(-1);
            } else {
                this.getRouter().navTo("appHome", new { }, true /*no history*/);
            }

            // in some cases we could display a certain target when the back button is pressed
            if ((this._oData != null) && (this._oData["fromTarget"] != null)) {
                this.getRouter().getTargets().display((string)this._oData["fromTarget"]);
                Script.Delete(this._oData["fromTarget"]);
                return;
            }

            // call the parent's onNavBack
            base.onNavBack(oEvent, oData);
        }
    }
}
