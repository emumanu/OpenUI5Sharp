using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;
using System.Collections.Generic;

namespace ClientScripts
{
    [FileName("controller/Home.controller.js")]
    [Name("manu.toolpageapp.fv.controller.Home")]
    public class HomeController : BaseController
    {
        public object formatter;
        public sap.ui.Device Device;

        [Init(InitPosition.Top)]
        public static void RequireScript()
        {
            jQuery.sap.require("manu/toolpageapp/fv/controller/BaseController");
        }

        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "manu/toolpageapp/fv/model/formatter",
                    "sap/ui/Device",
                    "sap/ui/model/json/JSONModel"
                },
                new Func<object, sap.ui.Device, object>(
                    (Formatter, Device) => {
                        HomeController newObj = Glue.CreateRawClassObject<HomeController>();
                        newObj.formatter = Formatter;
                        newObj.Device = Device;
                        return BaseController.extend(nameof(HomeController), newObj);
                    }
                )
            );
        }

        public HomeController(Union<string, object[]> sName) : base(sName)
        {
        }

        public override void onInit()
        {
            var oViewModel = new sap.ui.model.json.JSONModel(new HomeViewModel() {
                isPhone = Device.system.phone
            });
			this.setModel(oViewModel, "view");
            Device.media.attachHandler((sap.ui.Device.Media.MediaRangeChangeInfo oDevice) => {
                this.getModelFor<HomeViewModel>("view").setPropertyFor(p => p.isPhone, oDevice.name == "Phone");
            });
        }
    }
}