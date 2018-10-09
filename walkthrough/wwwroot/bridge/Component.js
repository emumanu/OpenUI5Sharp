Bridge.assembly("WalkthroughClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.walkthrough.Component", {
        inherits: [sap.ui.core.UIComponent],
        $metadata : function () { return {"nested":[System.Object],"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String,System.Object],"pi":[{"n":"sId","pt":System.String,"ps":0},{"n":"mSettings","pt":System.Object,"ps":1}],"sn":"ctor"},{"a":2,"n":"Script","is":true,"t":8,"sn":"Script","rt":System.Void},{"ov":true,"a":2,"n":"exit","t":8,"sn":"exit","rt":System.Void},{"v":true,"a":2,"n":"getContentDensityClass","t":8,"sn":"getContentDensityClass","rt":System.String},{"ov":true,"a":2,"n":"init","t":8,"sn":"init","rt":System.Void},{"a":2,"n":"openHelloDialog","t":8,"sn":"openHelloDialog","rt":System.Void},{"a":2,"n":"_sContentDensityClass","t":4,"rt":System.String,"sn":"_sContentDensityClass"},{"a":2,"n":"helloDialog","t":4,"rt":sap.ui.demo.walkthrough.controller.HelloDialog,"sn":"helloDialog"},{"a":2,"n":"metadata","is":true,"t":4,"rt":System.Object,"sn":"metadata"}]}; },
        statics: {
            fields: {
                metadata: null
            },
            ctors: {
                init: function () {
                    this.metadata = { routing: { config: { routerClass: "sap.m.routing.Router", viewType: "XML", viewPath: "sap.ui.demo.walkthrough.view", controlId: "app", controlAggregation: "pages", async: true }, routes: System.Array.init([{ name: "overview", pattern: "", target: "overview" }, { name: "detail", pattern: "detail/{invoicePath}", target: "detail" }], System.Object), targets: function (_o1) {
                            _o1["overview"] = { viewId: "overview", viewName: "Overview" };
                            _o1["detail"] = { viewId: "detail", viewName: "Detail" };
                            return _o1;
                        }({ }) }, rootView: { viewName: "sap.ui.demo.walkthrough.view.App", type: sap.ui.core.mvc.ViewType.XML, async: true, id: "app" } };
                }
            }
        },
        fields: {
            _sContentDensityClass: null,
            helloDialog: null
        },
        ctors: {
            ctor: function (sId, mSettings) {
                this.$initialize();
                sap.ui.core.UIComponent.call(this, sId, mSettings);
            }
        },
        methods: {
            init: function () {
                // call the init function of the parent
                sap.ui.core.UIComponent.prototype.init.call(this);

                // set data model
                var oData = { recipient: { name: "World" } };
                var oModel = new sap.ui.model.json.JSONModel(oData);
                this.setModel(oModel);

                // set i18n model
                var i18nModel = new sap.ui.model.resource.ResourceModel({ bundleName: "sap.ui.demo.walkthrough.i18n.i18n" });
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
                this.helloDialog = new sap.ui.demo.walkthrough.controller.HelloDialog(this.getRootControl());

                // initialize the routing stuff
                this.getRouter().initialize();
            },
            getContentDensityClass: function () {
                if (this._sContentDensityClass == null) {
                    if (!sap.ui.Device.support.touch) {
                        this._sContentDensityClass = "sapUiSizeCompact";
                    } else {
                        this._sContentDensityClass = "sapUiSizeCozy";
                    }
                }
                return this._sContentDensityClass;
            },
            exit: function () {
                this.helloDialog.destroy();
                delete this.helloDialog;
            },
            openHelloDialog: function () {
                this.helloDialog.open();
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/ui/Device", "sap/ui/core/UIComponent", "sap/ui/model/json/JSONModel", "sap/ui/model/resource/ResourceModel", "sap/ui/demo/walkthrough/controller/HelloDialog"], System.String), function () {
    var newObj = UI5.Glue.CreateRawClassObject(sap.ui.demo.walkthrough.Component);
    return sap.ui.core.UIComponent.extend("sap.ui.demo.walkthrough.Component", newObj);
});
