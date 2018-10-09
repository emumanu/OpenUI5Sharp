using Bridge;
using System;
using System.Linq;
using UI5;

namespace RoutingClientScripts
{

    [Reflectable(false)]
    [FileName("startup.js")]
    [Name("sap.ui.demo.nav.startup")]
    public class Startup
    {
        [Init(InitPosition.Top)]
        public static void StartupScript()
        {
            sap.ui.getCore().attachInit(() => {
                sap.ui.require(new string[] {
                     "sap/ui/demo/nav/root/mockserver",
                     "sap/m/Shell",
                     "sap/ui/core/ComponentContainer"
                }, new Action<Mockup>(
                    (Mockup mockserver) => {
                        mockserver.init();

                        new sap.m.Shell(new sap.m.Shell.Settings() {
                            app = new sap.ui.core.ComponentContainer(new sap.ui.core.ComponentContainer.Settings() {
                                name = "sap.ui.demo.nav",
                                settings = new sap.ui.core.UIComponent.Settings() {
                                    id = "nav"
                                }
                            })
                        }).placeAt("content");
                    }
                ));
            });
        }
    }

    [External]
    [Name("sap.ui.demo.nav.root.mockserver")]
    public class Mockup
    {
        public extern void init();
    }
}