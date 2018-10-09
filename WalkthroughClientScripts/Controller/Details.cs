using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;
using System.Collections.Generic;

namespace WalkthroughClientScripts
{
    [FileName("controller/Detail.controller.js")]
    [Name("sap.ui.demo.walkthrough.controller.Detail")]
    public class Detail : sap.ui.core.mvc.Controller
    {
        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                    "sap/ui/core/mvc/Controller",
                    "sap/ui/core/routing/History",
                    "sap/m/MessageToast",
                    "sap/ui/model/json/JSONModel"
                },
                new Func<object>(
                    () => {
                        var newObj = Glue.CreateRawClassObject<Detail>();
                        return sap.ui.core.mvc.Controller.extend(nameof(Detail), newObj);
                    }
                )
            );
        }

        public Detail(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
            var oViewModel = new sap.ui.model.json.JSONModel(new {
                currency = "EUR"
            });
			this.getView().setModel(oViewModel, "view");

        var oRouter = sap.ui.core.UIComponent.getRouterFor(this);
            oRouter.getRoute("detail").attachPatternMatched(_onObjectMatched);
        }

        public void _onObjectMatched(sap.ui.@base.Event<sap.ui.core.routing.Route.PatternMatchedInfo> oEvent, object oData)
        {
            this.byId<ProductRating>("rating").reset();
            this.getView().bindElement(new sap.ui.core.Element.BindElementInfo() {
                path = Bridge.Script.DecodeURIComponent((string)oEvent.getParameterFor(p => p.arguments)["invoicePath"]),
				model = "invoice"
            });
        }

        public void onRatingChange(sap.ui.@base.Event oEvent, object oData)
        {
            var fValue = oEvent.getParameter("value");
            var oResourceBundle = (jQuery.sap.util.ResourceBundle)this.getView().getModel<sap.ui.model.resource.ResourceModel>("i18n").getResourceBundle();
            sap.m.MessageToast.show(oResourceBundle.getText("ratingConfirmation", new object[] { fValue }));
        }

        public void onNavBack(sap.ui.@base.Event oEvent, object oData)
        {
            var oHistory = sap.ui.core.routing.History.getInstance();
            var sPreviousHash = oHistory.getPreviousHash();

            if (!ReferenceEquals(sPreviousHash, Bridge.Script.Undefined)) {
                Retyped.dom.window.history.go(-1);
            } else {
                var oRouter = sap.ui.core.UIComponent.getRouterFor(this);
                oRouter.navTo("overview", new { }, true);
            }
        }
    }
}
