using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Metadata;
using System.Collections.Generic;

namespace WalkthroughClientScripts
{
    [FileName("Component.js")]
    [Name("sap.ui.demo.walkthrough.Component")]
    public class Component : sap.ui.core.UIComponent
    {
        public static Metadata metadata = new Metadata() {
            routing = new ComponentRouting() {
                config = new ComponentRouterConfig() {
                    routerClass = "sap.m.routing.Router",
                    viewType = "XML",
                    viewPath = "sap.ui.demo.walkthrough.view",
                    controlId = "app",
                    controlAggregation = "pages",
                    async = true
                },
                routes = new sap.ui.core.routing.Route.RouteConfig[] {
                                    new sap.ui.core.routing.Route.RouteConfig() {
                                        name = "overview",
                                        pattern = "",
                                        target = "overview"
                                    },
                                    new sap.ui.core.routing.Route.RouteConfig() {
                                        name = "detail",
                                        pattern = "detail/{invoicePath}",
                                        target = "detail"
                                    }
                                },
                targets = new Map<sap.ui.core.routing.Targets.TargetInfo>() {
                                    { "overview",
                                        new sap.ui.core.routing.Targets.TargetInfo() {
                                            viewId = "overview",
                                            viewName = "Overview"
                                        }
                                    },
                                    { "detail",
                                        new sap.ui.core.routing.Targets.TargetInfo() {
                                            viewId = "detail",
                                            viewName = "Detail"
                                        }
                                    }
                                }
            },
            rootView = new sap.ui.ViewInfo() {
                viewName = "sap.ui.demo.walkthrough.view.App",
                type = sap.ui.core.mvc.ViewType.XML,
                async = true,
                id = "app"
            },
            //contentDensities = new {
            //    compact = true,
            //    cozy = true
            //}
        };

        [ObjectLiteral]
        public class ViewModel
        {
            [ObjectLiteral]
            public class ViewModelRecipient
            {
                public string name;
            }

            public ViewModelRecipient recipient;
        }

        public string _sContentDensityClass = null;
        public HelloDialog helloDialog = null;

        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                    "sap/ui/Device",
                    "sap/ui/core/UIComponent",
                    "sap/ui/model/json/JSONModel",
                    "sap/ui/model/resource/ResourceModel",
                    "sap/ui/demo/walkthrough/controller/HelloDialog"
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

            // set data model
            var oData = new ViewModel() {
                recipient = new ViewModel.ViewModelRecipient {
                    name = "World"
                }
            };
            var oModel = new sap.ui.model.json.JSONModel(oData);
            this.setModel(oModel);

            // set i18n model
            var i18nModel = new sap.ui.model.resource.ResourceModel(new sap.ui.model.resource.ResourceModel.ResourceModelInfo() {
                bundleName = "sap.ui.demo.walkthrough.i18n.i18n"
            });
            this.setModel(i18nModel, "i18n");

            // set invoice model
            //var invoiceModel = new sap.ui.model.odata.v2.ODataModel("https://cors-anywhere.herokuapp.com/services.odata.org/V2/Northwind/Northwind.svc/");
            var invoiceModel = new sap.ui.model.json.JSONModel("/invoices.json");
            this.setModel(invoiceModel, "invoice");

            // set device model
            var oDeviceModel = new sap.ui.model.json.JSONModel(jQuery.sap.getObject("sap.ui.Device"));
            oDeviceModel.setDefaultBindingMode(sap.ui.model.BindingMode.OneWay);
            this.setModel(oDeviceModel, "device");

            // set dialog
            helloDialog = new HelloDialog(this.getRootControl<sap.ui.core.mvc.View>());

            // initialize the routing stuff
            this.getRouter().initialize();
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

        public override void exit()
        {
            helloDialog.destroy();
            Bridge.Script.Delete(helloDialog);
        }

        public void openHelloDialog()
        {
            helloDialog.open();
        }
    }
}