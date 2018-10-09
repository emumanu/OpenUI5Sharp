using Bridge;
using System;
using System.Linq;
using UI5;
using System.Collections.Generic;

namespace ClientScripts
{
    [FileName("model/models.js")]
    [Name("manu.toolpageapp.fv.model.Models")]
    public class Models
    {
        public sap.ui.Device Device;

        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "sap/ui/Device",
                    "sap/ui/model/json/JSONModel"
                },
                new Func<sap.ui.Device, object>(
                    (Device) => {
                        Models newObj = Glue.CreateRawClassObject<Models>();
                        newObj.Device = Device;
                        return newObj;
                    }
                )
            );
        }

        public virtual sap.ui.model.Model<sap.ui.Device> createDeviceModel()
        {
            var oModel = new sap.ui.model.json.JSONModel(Device);
            oModel.setDefaultBindingMode(sap.ui.model.BindingMode.OneWay);
            return oModel.As<sap.ui.model.Model<sap.ui.Device>>();
        }
    }
}