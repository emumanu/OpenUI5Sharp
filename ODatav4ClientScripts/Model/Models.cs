using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Metadata;
using System.Collections.Generic;

namespace ODatav4ClientScripts
{
    [FileName("Model/models.js")]
    [Name("sap.ui.core.tutorial.odata4.model.Models")]
    public class Models
    {
        public object Device;

        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                    "sap/ui/model/json/JSONModel",
                    "sap/ui/Device"
                },
                new Func<sap.ui.model.json.JSONModel, object, object>(
                    (Model, Device) => {
                        Models newObj = Glue.CreateRawClassObject<Models>();
                        newObj.Device = Device;
                        return newObj;
                    }
                )
            );
        }

        public Models()
        {
        }

        public virtual sap.ui.model.Model createDeviceModel()
        {
            var oModel = new sap.ui.model.json.JSONModel(Device);
            oModel.setDefaultBindingMode(sap.ui.model.BindingMode.OneWay);
            return oModel;
        }
    }
}