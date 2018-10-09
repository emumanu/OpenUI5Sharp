using Bridge;
using System;
using System.Linq;
using UI5;

namespace WalkthroughClientScripts
{
    [FileName("model/formatter.js")]
    public class Formatter
    {
        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
            },
            new Func<object>(
                () => {
                    return  Glue.CreateRawClassObject<Formatter>();
                }
            ));
        }

        public Formatter()
        {
        }

        public string statusText(string sStatus)
        {
            // WTF is it whit getView???
            var resourceBundle = (jQuery.sap.util.ResourceBundle)(this.As<sap.ui.core.mvc.Controller>().getView().getModel<sap.ui.model.resource.ResourceModel>("i18n").getResourceBundle());
            switch (sStatus) {
                case "A":
                    return resourceBundle.getText("invoiceStatusA");
                case "B":
                    return resourceBundle.getText("invoiceStatusB");
                case "C":
                    return resourceBundle.getText("invoiceStatusC");
                default:
                    return sStatus;
            }
        }
    }
}
