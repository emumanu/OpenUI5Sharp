using Bridge;
using System;
using System.Linq;
using UI5;

namespace ClientScripts
{
    [Reflectable(false)]
    [FileName("startup.js")]
    [Name("manu.toolpageapp.fv.startup")]
    public class Startup
    {
        [Init(InitPosition.Top)]
        public static void StartupScript()
        {
            sap.ui.getCore().attachInit(() => {
                sap.ui.require(new string[] {
                    "sap/ui/core/ComponentContainer"
                }, new Action(() => {
                    new sap.ui.core.ComponentContainer(new sap.ui.core.ComponentContainer.Settings() {
                        name = "manu.toolpageapp.fv",
                        height = "100%",
                        settings = new sap.ui.core.UIComponent.Settings() {
                            id ="FVCContainer"
                        }
                    }).placeAt("content");
                }));
            });
        }
    }
}