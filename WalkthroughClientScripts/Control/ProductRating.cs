using Bridge;
using System;
using System.Linq;
using UI5;
using System.Collections.Generic;
using UI5.Metadata;

namespace WalkthroughClientScripts
{
    [FileName("control/ProductRating.js")]
    [Name("sap.ui.demo.walkthrough.control.ProductRating")]
    public class ProductRating : sap.ui.core.Control
    {
        [Constructor("{}")]
        //[ObjectLiteral]
        public class RatingInfo
        {
            public float value;
        }

        public static Metadata metadata = new Metadata() {
            properties = new Map<Union<string, PropertyInfo>>() {
                { "value", new PropertyInfo() { type = "float", defaultValue = 0 }}
            },
            aggregations = new Map<Union<string, AggregationInfo>>() {
                { "_rating", new AggregationInfo() { type = "sap.m.RatingIndicator", multiple = false, visibility = "hidden" }},
                { "_label", new AggregationInfo() { type = "sap.m.Label", multiple = false, visibility = "hidden" }},
                { "_button", new AggregationInfo() { type = "sap.m.Button", multiple = false, visibility = "hidden" }}
            },
            events = new Map<Union<string, EventInfo>>() {
                { "change", TypedMetadata.CreateUI5EventInfo<RatingInfo>() }
            }
        };

        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                    "sap/ui/core/Control",
                    "sap/m/RatingIndicator",
                    "sap/m/Label",
                    "sap/m/Button"
                },
                new Func<object>(
                    () => {
                        var newObj = Glue.CreateRawClassObject<ProductRating>();
                        return sap.ui.core.Control.extend(nameof(ProductRating), newObj);
                    }
                )
            );
        }

        public ProductRating(string sId, sap.ui.core.Control.Settings mSettings) : base(sId, mSettings)
        {
        }

        public override void init()
        {
            this.setAggregation("_rating", new sap.m.RatingIndicator(new sap.m.RatingIndicator.Settings() {
                value = this.getProperty<float>("value"),
                iconSize = "2rem",
                visualMode = "Half",
                liveChange = _onRate,
            }));
            this.setAggregation("_label", new sap.m.Label(new sap.m.Label.Settings() {
                text = "{i18n>productRatingLabelInitial}"
            }).addStyleClass("sapUiSmallMargin"));
            this.setAggregation("_button", new sap.m.Button(new sap.m.Button.Settings() {
                text = "{i18n>productRatingButton}",
                press = _onSubmit
            }).addStyleClass("sapUiTinyMarginTopBottom"));
        }

        public virtual void setValue(float fValue)
        {
            this.setProperty("value", fValue, true);
            this.getAggregation<sap.m.RatingIndicator>("_rating").setValue(fValue);
        }

		public virtual void reset()
        {
            var oResourceBundle = (jQuery.sap.util.ResourceBundle)this.getModel<sap.ui.model.resource.ResourceModel>("i18n").getResourceBundle();

            this.setValue(0);
            this.getAggregation<sap.m.Label>("_label").setDesign(sap.m.LabelDesign.Standard);
            this.getAggregation<sap.m.RatingIndicator>("_rating").setEnabled(true);
            this.getAggregation<sap.m.Label>("_label").setText(oResourceBundle.getText("productRatingLabelInitial"));
            this.getAggregation<sap.m.RatingIndicator>("_button").setEnabled(true);
        }

        public virtual void _onRate(sap.ui.@base.Event oEvent, object oData)
        {
            var oResourceBundle = (jQuery.sap.util.ResourceBundle)this.getModel<sap.ui.model.resource.ResourceModel>("i18n").getResourceBundle();
            float fValue = oEvent.getParameter("value").As<float>();

            this.setProperty("value", fValue, true);

            this.getAggregation<sap.m.Label>("_label").setText(oResourceBundle.getText("productRatingLabelIndicator", new object[] { fValue, oEvent.getSource<sap.m.RatingIndicator>().getMaxValue() }));
            this.getAggregation<sap.m.Label>("_label").setDesign(sap.m.LabelDesign.Bold);
        }

        public virtual void _onSubmit(sap.ui.@base.Event oEvent, object oData)
        {
            var oResourceBundle = (jQuery.sap.util.ResourceBundle)this.getModel<sap.ui.model.resource.ResourceModel>("i18n").getResourceBundle();

            this.getAggregation<sap.m.RatingIndicator>("_rating").setEnabled(false);
            this.getAggregation<sap.m.Label>("_label").setText(oResourceBundle.getText("productRatingLabelFinal"));
            this.getAggregation<sap.m.Button>("_button").setEnabled(false);
            this.fireEvent<RatingInfo>("change", new RatingInfo {
                value = this.getProperty<float>("value")
            });
        }

        public void renderer(sap.ui.core.RenderManager oRM, sap.ui.core.Control oControl)
        {
            oRM.write("<div");
            oRM.writeControlData(oControl);
            oRM.addClass("myAppDemoWTProductRating");
            oRM.writeClasses();
            oRM.write(">");
            oRM.renderControl(oControl.getAggregation<sap.ui.core.Control>("_rating"));
            oRM.renderControl(oControl.getAggregation<sap.ui.core.Control>("_label"));
            oRM.renderControl(oControl.getAggregation<sap.ui.core.Control>("_button"));
            oRM.write("</div>");
        }
    }
}
