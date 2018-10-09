using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;
using System.Collections.Generic;

namespace WalkthroughClientScripts
{
    [FileName("controller/InvoiceList.controller.js")]
    [Name("sap.ui.demo.walkthrough.controller.InvoiceList")]
    public class InvoiceList : sap.ui.core.mvc.Controller
    {
        public Formatter formatter;

        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                    "sap/ui/core/mvc/Controller",
                    "sap/ui/model/json/JSONModel",
                    "sap/ui/demo/walkthrough/model/formatter",
                    "sap/ui/model/Filter",
                    "sap/ui/model/FilterOperator"
                },
                new Func<sap.ui.core.mvc.Controller, sap.ui.model.json.JSONModel, Formatter, sap.ui.model.Filter, sap.ui.model.FilterOperator, object>(
                    (Controller, JSONModel, Formatter, Filter, FilterOperator) => {
                        var newObj = Glue.CreateRawClassObject<InvoiceList>();
                        newObj.formatter = Formatter;
                        return sap.ui.core.mvc.Controller.extend(nameof(InvoiceList), newObj);
                    }
                )
            );
        }

        public InvoiceList(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
            var oViewModel = new sap.ui.model.json.JSONModel(new {
                currency = "EUR"
            });

            this.getView().setModel(oViewModel, "view");
        }

        public void onFilterInvoices(sap.ui.@base.Event<sap.m.SearchField.SearchInfo> oEvent, object oData)
        {
            // build filter array
            List<sap.ui.model.Filter> aFilter = new List<sap.ui.model.Filter>();
            string sQuery = oEvent.getParameterFor(p => p.query);
            if (sQuery != null) {
                aFilter.Add(new sap.ui.model.Filter("ProductName", sap.ui.model.FilterOperator.Contains, sQuery));
            }

            // filter binding
            sap.m.Table oList = this.byId<sap.m.Table>("invoiceList");
            var oBinding = oList.getBinding<sap.ui.model.ListBinding>("items");
            oBinding.filter(aFilter.ToArray());
        }

        public void onPress(sap.ui.@base.Event oEvent, object oData)
        {
            sap.m.ObjectListItem oItem = oEvent.getSource<sap.m.ObjectListItem>();
            var oRouter = sap.ui.core.UIComponent.getRouterFor(this);
            oRouter.navTo("detail", new {
                invoicePath = Bridge.Script.EncodeURIComponent(oItem.getBindingContext("invoice").getPath())
           });
        }
    }
}
