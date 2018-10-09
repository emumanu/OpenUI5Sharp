using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Metadata;
using System.Collections.Generic;

namespace RoutingClientScripts
{
    [FileName("Component.js")]
    [Name("sap.ui.demo.nav.Component")]
    public class Component : sap.ui.core.UIComponent
    {
        public static Metadata metadata = new Metadata() {
            manifest = "json"
        };

        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                   "sap/ui/core/UIComponent",
                },
                new Func<sap.ui.core.UIComponent, object>(
                    (UIComponent) => {
                        Component newObj = Glue.CreateRawClassObject<Component>();
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