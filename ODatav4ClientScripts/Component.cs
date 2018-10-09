using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Metadata;
using System.Collections.Generic;

namespace ODatav4ClientScripts
{
    [FileName("Component.js")]
    [Name("sap.ui.core.tutorial.odatav4.Component")]
    public class Component : sap.ui.core.UIComponent
    {
        public static Metadata metadata = new Metadata() {
            manifest = "json"
        };

        public Models models;

        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                   "sap/ui/core/UIComponent",
                    "sap/ui/core/tutorial/odatav4/model/models"
                },
                new Func<sap.ui.core.UIComponent, Models, object>(
                    (UIComponent, models) => {
                        Component newObj = Glue.CreateRawClassObject<Component>();
                        newObj.models = models;
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

            // set the device model
            this.setModel(models.createDeviceModel(), "device");
        }
    }
}