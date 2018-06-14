using Bridge;
using System;
using System.Linq;
using OpenUI5Sharp;
using OpenUI5Sharp.Metadata;
using System.Collections.Generic;

namespace RoutingClientScripts
{
    [FileName("Component.js")]
    [Name("sap.ui.demo.nav.Component")]
    public class Component : sap.ui.core.UIComponent
    {
        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                   "sap/ui/core/UIComponent",
                },
                new Func<sap.ui.core.UIComponent, object>(
                    (UIComponent) => {
                        var metadata = new Metadata() {
                            manifest = "json"
                        };

                        Component newObj = Glue.CreateRawClassObject<Component>(metadata);
                        return sap.ui.core.UIComponent.extend(nameof(Component), newObj);
                    }
                )
            );
        }

        public Component(string sId, sap.ui.core.UIComponent.Settings mSettings) : base(sId, mSettings)
        {
        }

        public override void init()
        {
            // call the init function of the parent
            base.init();

            // create the views based on the url/hash
            this.getRouter().initialize();
        }
    }
}