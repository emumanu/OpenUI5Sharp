using Bridge;
using System;
using System.Linq;
using UI5;

namespace WalkthroughClientScripts
{
    [Reflectable(false)]
    [FileName("startup.js")]
    [Name("sap.ui.demo.walkthrough.startup")]
    public class Startup
    {
        [Init(InitPosition.Top)]
        public static void StartupScript()
        {
            sap.ui.getCore().attachInit(() => {
                new sap.m.Shell(new sap.m.Shell.Settings() {
                    app = new sap.ui.core.ComponentContainer(new sap.ui.core.ComponentContainer.Settings() {
                        name = "sap.ui.demo.walkthrough",
                        settings = new sap.ui.core.UIComponent.Settings() {
                            id = "walkthrough"
                        }
                    })
                }).placeAt("content");
            });
        }
    }
}