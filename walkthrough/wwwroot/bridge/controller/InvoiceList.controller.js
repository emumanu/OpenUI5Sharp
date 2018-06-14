Bridge.assembly("WalkthroughClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.walkthrough.controller.InvoiceList", {
        inherits: [sap.ui.core.mvc.Controller],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String],"pi":[{"n":"sName","pt":System.String,"ps":0}],"sn":"ctor"},{"a":2,"n":"Script","is":true,"t":8,"sn":"Script","rt":System.Void},{"a":2,"n":"onFilterInvoices","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onFilterInvoices","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void},{"a":2,"n":"onPress","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onPress","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"formatter","t":4,"rt":WalkthroughClientScripts.Formatter,"sn":"formatter"}]}; },
        fields: {
            formatter: null
        },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                sap.ui.core.mvc.Controller.call(this, sName);
            }
        },
        methods: {
            onInit: function () {
                var oViewModel = new sap.ui.model.json.JSONModel({ currency: "EUR" });

                this.getView().setModel(oViewModel, "view");
            },
            onFilterInvoices: function (oEvent, oData) {
                var $t, $t1, $t2;
                // build filter array
                var aFilter = new (System.Collections.Generic.List$1(sap.ui.model.Filter)).ctor();
                var sQuery = sapuibaseExtensions.getParameterFor(Bridge.global.System.Object, System.String, oEvent, ($t = { ntype: 38, t: System.Object, n: "p" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"query","t":4,"rt":System.String,"sn":"query"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) })));
                if (sQuery != null) {
                    aFilter.add(new sap.ui.model.Filter("ProductName", sap.ui.model.FilterOperator.Contains, sQuery));
                }

                // filter binding
                var oList = this.byId("invoiceList");
                var oBinding = oList.getBinding("items");
                oBinding.filter(aFilter.ToArray());
            },
            onPress: function (oEvent, oData) {
                var oItem = oEvent.getSource();
                var oRouter = sap.ui.core.UIComponent.getRouterFor(this);
                oRouter.navTo("detail", { invoicePath: encodeURIComponent(oItem.getBindingContext("invoice").getPath()) });
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/ui/core/mvc/Controller", "sap/ui/model/json/JSONModel", "sap/ui/demo/walkthrough/model/formatter", "sap/ui/model/Filter", "sap/ui/model/FilterOperator"], System.String), function (Controller, JSONModel, Formatter, Filter, FilterOperator) {
    var newObj = Glue.CreateRawClassObject(sap.ui.demo.walkthrough.controller.InvoiceList);
    newObj.formatter = Formatter;
    return sap.ui.core.mvc.Controller.extend("sap.ui.demo.walkthrough.controller.InvoiceList", newObj);
});
