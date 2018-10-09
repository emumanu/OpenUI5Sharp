using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;

namespace RoutingClientScripts
{
    [FileName("controller/App.controller.js")]
    [Name("sap.ui.demo.nav.controller.App")]
    public class AppController : BaseController
    {

        [Init(InitPosition.Top)]
        public static void ScriptTop()
        {
            jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
            jQuery.sap.declare(new { modName = nameof(AppController), type = "controller" });
        }

        public AppController(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
            // This is ONLY for being used within the tutorial.
            // The default log level of the current running environment may be higher than INFO,
            // in order to see the debug info in the console, the log level needs to be explicitly
            // set to INFO here.
            // But for application development, the log level doesn't need to be set again in the code.
            jQuery.sap.log.setLevel(jQuery.sap.log.Level.INFO);

            var oRouter = this.getRouter();

            oRouter.attachBypassed((oEvent, oData) => {
                var sHash = oEvent.getParameterFor(p => p.hash);
                // do something here, i.e. send logging data to the backend for analysis
                // telling what resource the user tried to access...
                jQuery.sap.log.info($"Sorry, but the hash {sHash} is invalid.", "The resource was not found.");
            });

            oRouter.attachRouteMatched((oEvent, oData) => {
                var sRouteName = oEvent.getParameterFor(p => p.name);
                // do something, i.e. send usage statistics to backend
                // in order to improve our app and the user experience (Build-Measure-Learn cycle)
                jQuery.sap.log.info($"User accessed route {sRouteName}, timestamp = { DateTime.Now }");
            });
        }
    }
}
