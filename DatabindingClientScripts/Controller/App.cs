using Bridge;
using System;
using System.Linq;
using UI5;

namespace DatabindingClientScripts
{
    [FileName("controller/App.controller.js")]
    [Name("sap.ui.demo.db.controller.App")]
    public class App : sap.ui.core.mvc.Controller
    {
        protected sap.ui.core.Element _oProductSimple;
        protected sap.ui.core.Element _oProductExtended;

        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                    "sap/ui/core/mvc/Controller",
                    "sap/ui/model/type/Currency"
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

        public string formatMail(string sFirstName, string sLastName)
        {
            var oBundle = (jQuery.sap.util.ResourceBundle)this.getView().getModel<sap.ui.model.resource.ResourceModel>("i18n").getResourceBundle();
            return sap.m.URLHelper.normalizeEmail($"{sFirstName}.{sLastName}@example.com",
                oBundle.getText("mailSubject", new string[] { sFirstName }),
                oBundle.getText("mailBody"));
        }

        public string formatStockValue(float fUnitPrice, int iStockLevel, string sCurrCode)
        {
            var sBrowserLocale = sap.ui.getCore().getConfiguration().getLanguage();
            var oLocale = new sap.ui.core.Locale(sBrowserLocale);
            var localizedCurrencyFormat = sap.ui.core.format.NumberFormat.getCurrencyInstance(oLocale);
            return localizedCurrencyFormat.format(new object[] { fUnitPrice * iStockLevel, sCurrCode });
        }

        public void onItemSelected(sap.ui.@base.Event oEvent, object oData)
        {
            var oSelectedItem = oEvent.getSource<sap.m.ObjectListItem>();
            var oContext = oSelectedItem.getBindingContext("products");
            var sPath = oContext.getPath();
            var oProductDetailPanel = this.byId("productDetailsPanel");
            oProductDetailPanel.bindElement(new sap.ui.core.Element.BindElementInfo {
                path = sPath,
                model = "products"
            });
        }

        public sap.ui.core.Element productListFactory(string sId, sap.ui.model.Context oContext)
        {
            sap.ui.core.Element oUIControl = null;

            // Decide based on the data which fragment to show
            if (oContext.getProperty<int>("UnitsInStock") == 0 && oContext.getProperty<bool>("Discontinued")) {
                // The item is discontinued, so use a StandardListItem
                if (this._oProductSimple == null) {
                    this._oProductSimple = (sap.ui.core.Control)sap.ui.xmlfragment(sId, "sap.ui.demo.db.view.ProductSimple", this);
                }
                oUIControl = _oProductSimple.clone();
            } else {
                // The item is available, so we will create an ObjectListItem
                if (this._oProductExtended == null) {
                    this._oProductExtended = (sap.ui.core.Control)sap.ui.xmlfragment(sId, "sap.ui.demo.db.view.ProductExtended", this);
                }
                oUIControl = this._oProductExtended.clone();

                // The item is temporarily out of stock, so we will add a status
                if (oContext.getProperty<int>("UnitsInStock") < 1) {
                    oUIControl.As<sap.m.ObjectListItem>().addAttribute(new sap.m.ObjectAttribute(new sap.m.ObjectAttribute.Settings() {
                        text = new sap.ui.@base.ManagedObject.BindPropertyInfo() {
                            path = "i18n>outOfStock"
                        }
                    }));
                }
            }

            return oUIControl;
        }
    }

    [ObjectLiteral]
    public class ProductList
    {
        public Product[] Products { get; set; }
    }

    [ObjectLiteral]
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
