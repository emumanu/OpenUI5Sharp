using Bridge;
using System;
using System.Linq;
using UI5;
using System.Collections.Generic;

namespace ClientScripts
{
    [FileName("Component.js")]
    [Name("manu.toolpageapp.fv.Component")]
    public class Component : sap.ui.core.UIComponent
    {
        public static Metadata metadata = new Metadata() {
            manifest = "json"
        };

        public string _sContentDensityClass = null;

        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "sap/ui/core/UIComponent",
                    "manu/toolpageapp/fv/model/models",
                    "sap/ui/model/resource/ResourceModel"
                },
                new Func<object>(
                    () => {
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

            // set the device model
            this.setModel(new Models().createDeviceModel(), "device");
        }

        public virtual void myNavBack()
        {
            var oHistory = sap.ui.core.routing.History.getInstance();
            var oPrevHash = oHistory.getPreviousHash();
            if (oPrevHash != null) {
                Retyped.dom.window.history.go(-1);
            } else {
                this.getRouter().navTo("masterSettings", new {}, true);
            }
        }

        public virtual string getContentDensityClass()
        {
            if (_sContentDensityClass == null) {
                if (!sap.ui.Device.Singleton.support.touch) {
                    _sContentDensityClass = "sapUiSizeCompact";
                } else {
                    _sContentDensityClass = "sapUiSizeCozy";
                }
            }
            return _sContentDensityClass;
        }
    }
}