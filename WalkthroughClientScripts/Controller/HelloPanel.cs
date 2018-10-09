using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;

namespace WalkthroughClientScripts
{
    [FileName("controller/HelloPanel.controller.js")]
    [Name("sap.ui.demo.walkthrough.controller.HelloPanel")]
    public class HelloPanel : sap.ui.core.mvc.Controller
    {
        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                    "sap/ui/core/mvc/Controller",
                    "sap/m/MessageToast"
                },
                new Func<object>(
                    () => {
                        var newObj = Glue.CreateRawClassObject<HelloPanel>();
                        return sap.ui.core.mvc.Controller.extend(nameof(HelloPanel), newObj);
                    }
                )
            );
        }

        public HelloPanel(string sName) : base(sName)
        {
        }

        public void onShowHello(sap.ui.@base.Event oEvent, object oData)
        {
            // read msg from i18n model
            var oBundle = (jQuery.sap.util.ResourceBundle)this.getView().getModel<sap.ui.model.resource.ResourceModel>("i18n").getResourceBundle();
            string sRecipient = this.getView().getModelFor<Component.ViewModel>().getPropertyFor(m => m.recipient.name);
            var sMsg = oBundle.getText("helloMsg", new string[] { sRecipient });
            // show message
            sap.m.MessageToast.show(sMsg);
        }

        public void onOpenDialog(sap.ui.@base.Event oEvent, object oData)
        {
            this.getOwnerComponent<Component>().openHelloDialog();
        }
    }
}
