using Bridge;
using System;
using System.Linq;
using UI5;

namespace ODatav4ClientScripts
{
    [Reflectable(false)]
    [FileName("startup.js")]
    [Name("sap.ui.core.tutorial.odatav4.startup")]
    public class Startup
    {
        [Init(InitPosition.Top)]
        public static void StartupScript()
        {
            sap.ui.getCore().attachInit(() => {
                sap.ui.require(new string[] {
                    "sap/ui/core/tutorial/root/mockserver",
                    "sap/m/Shell",
                    "sap/ui/core/ComponentContainer"
                }, new Action<Mockup>(
                    (Mockup mockserver) => {
                        // Requests to the service are intercepted and fake responses returned.
                        // Comment this out to connect to the real service.
                        mockserver.start();

                        new sap.m.Shell(new sap.m.Shell.Settings() {
                            app = new sap.ui.core.ComponentContainer(new sap.ui.core.ComponentContainer.Settings() {
                                height = "100%",
                                component = (sap.ui.core.UIComponent)sap.ui.component(new sap.ui.ComponentConfig() {
                                    name = "sap.ui.core.tutorial.odatav4",
                                    manifestFirst = true,
                                    id = "odatav4"
                                })
                            })
                        }).placeAt("content");
                    }
                ));
            });
        }
    }

    [External]
    [Name("sap.ui.core.tutorial.root.mockserver")]
    public class Mockup
    {
        public extern void start();
    }
}