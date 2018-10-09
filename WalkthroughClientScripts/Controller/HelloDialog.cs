using Bridge;
using System;
using System.Linq;
using UI5;

namespace WalkthroughClientScripts
{
    [FileName("controller/HelloDialog.js")]
    [Name("sap.ui.demo.walkthrough.controller.HelloDialog")]
    public class HelloDialog : sap.ui.@base.ManagedObject
    {
        public sap.ui.core.mvc.View oView;

        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                "sap/ui/base/ManagedObject"
            },
            new Func<object>(
                () => {
                    var newObj = Glue.CreateRawClassObject<HelloDialog>();
                    return sap.ui.@base.ManagedObject.extend(nameof(HelloDialog), newObj);
                }
            ));
        }

        public HelloDialog(sap.ui.core.mvc.View oView) : base(oView)
        {
            this.oView = oView;
        }

        public void exit()
        {
            Bridge.Script.Delete(oView);
        }

        public void open()
        {
            sap.m.Dialog oDialog = oView.byId<sap.m.Dialog>("helloDialog");

            // create dialog lazily
            if (oDialog == null) {
                object oFragmentController = new {
                    onCloseDialog = (sap.ui.@base.EventDelegate)((oEvent, oData) => {
                        oDialog.close();
                    })
                };

                // create dialog via fragment factory
                oDialog = sap.ui.xmlfragment(
                    oView.getId(), 
                    "sap.ui.demo.walkthrough.view.HelloDialog", 
                    oFragmentController.As<sap.ui.core.mvc.Controller>()
                ).As<sap.m.Dialog>();
                // connect dialog to the root view of this component (models, lifecycle)
                oView.addDependent(oDialog);

                // forward compact/cozy style into dialog
                jQuery.sap.syncStyleClass(oView.getController<App>().getOwnerComponent<Component>().getContentDensityClass(), oView, oDialog);
            };

            oDialog.open();
        }
    }
}
