using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;
using System.Collections.Generic;

namespace ClientScripts
{
    [FileName("controller/settings/MasterSettings.controller.js")]
    [Name("manu.toolpageapp.fv.controller.settings.MasterSettings")]
    public class MasterSettingsController : BaseController
    {
        public object formatter;

        [Init(InitPosition.Top)]
        public static void RequireScript()
        {
            jQuery.sap.require("manu/toolpageapp/fv/controller/BaseController");
        }

        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "sap/m/MessageToast",
                    "sap/ui/model/json/JSONModel"
                },
                new Func<object, object>(
                    (Formatter) => {
                        MasterSettingsController newObj = Glue.CreateRawClassObject<MasterSettingsController>();
                        return BaseController.extend(nameof(MasterSettingsController), newObj);
                    }
                )
            );
        }

        public MasterSettingsController(Union<string, object[]> sName) : base(sName)
        {
        }

        public override void onInit()
        {
            var oViewModel = new sap.ui.model.json.JSONModel(new UserLoginInfo() {
                    currenUser = "Administrator",
                    lastLogin = DateTime.Now.AddDays(-1)
            });
			this.setModel(oViewModel, "view");
        }

        public virtual void onMasterPressed(sap.ui.@base.Event<sap.m.ListBase.ItemPressInfo> oEvent, object oData)
        {
            var oContext = oEvent.getParameter<sap.m.StandardListItem>("listItem").getBindingContext("side").For<Mastersetting>();
            oContext.getModelFor().setPropertyFor(p => p.selected, true, oContext, false);
            var sSelectedMasterElement = oContext.getPropertyFor(p => p.title, false);
            string sKey = oContext.getPropertyFor(p => p.key, false);
            switch (sSelectedMasterElement) {
                case "System Settings": {
                    this.getRouter().navTo(sKey);
                    break;
                }
                default: {
                    sap.m.MessageToast.show(sSelectedMasterElement + " was pressed");
                    break;
                }
            }
        }

        public virtual void onSavePressed(sap.ui.@base.Event oEvent, object oData)
        {
            sap.m.MessageToast.show("Save was pressed");
        }

        public virtual void onCancelPressed(sap.ui.@base.Event oEvent, object oData)
        {
            sap.m.MessageToast.show("Cancel was pressed");
        }

        public virtual void onNavButtonPress(sap.ui.@base.Event oEvent, object oData)
        {
            this.getOwnerComponent<Component>().myNavBack();
        }
    }
}
