using Bridge;
using System;
using System.Linq;
using UI5;

namespace WalkthroughClientScripts
{
    [FileName("controller/App.controller.js")]
    [Name("sap.ui.demo.walkthrough.controller.App")]
    public class App : sap.ui.core.mvc.Controller
    {
        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                    "sap/ui/core/mvc/Controller",
                },
                new Func<object>(
                    () => {
                        var newObj = Glue.CreateRawClassObject<App>();
                        return sap.ui.core.mvc.Controller.extend(nameof(App), newObj);
                    }
                )
            );
        }

        public App(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
            this.getView().addStyleClass(this.getOwnerComponent<Component>().getContentDensityClass());
        }

        public void onOpenDialog()
        {
            this.getOwnerComponent<Component>().openHelloDialog();
        }
    }
}
