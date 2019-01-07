# OpenUI5Sharp

[![Built with Bridge.NET](https://img.shields.io/badge/built%20with-Bridge.NET-blue.svg)](http://bridge.net/)

OpenUI5Sharp is a C# Wrapper for [OpenUI5](https://github.com/SAP/openui5), that uses [Bridge.net](https://bridge.net/) to generate Javascript code, allowing you to generate OpenUI5 code using C#. OpenUI5Sharp also adds some features like typed object literals, typed parameters and other improvements thanks to the C# & Bridge combination.

## Current Status
The current wrapper is based on OpenUI5 1.58.4 using Bridge.net 17.4.0 and the latest Retyped packages for libraries used by OpenUI5 (JQuery, QUnit, Sinon...).

OpenUI5 is quite large but all the libraries have been converted. 

The following tutorials from the [documentation](https://openui5.hana.ondemand.com/#/topic/8b49fc198bf04b2d9800fc37fecbb218) are fully working and are available in the [samples](https://github.com/emumanu/OpenUI5Sharp-samples) as a reference on how to use OpenUI5Sharp:
  - Walkthrough (including unit and integration testing)
  - Data Binding
  - OData V4
  - Navigation and Routing

Also, the Shop Administration Tool demo application is fully working.

## XSD Schemas
SAP does **not** produces valid XSD schemas to have intellisense when editing XML views in Visual Studio or other editors that support XSD schemas. As it is really painful to work without valid XSD schemas, you can find my non official XSD schemas that work properly with Visual Studio 2017 in the folder XSDSchemas. However, keep in mind that OpenUI5 aggregations and associations **do not** work with a namespace different than the parent object making XML views sometimes invalid. In any case, having the XSD schema is a big help. 

A custom Visual Studio plugin will be needed to handle the validation properly (and also for things like binding expressions support, non sequencial schema elements, method generation, etc) but that is out of the scope of this project.

## Examples
You can use OpenUI5Sharp with its more than 800 strongly typed object literals and its more than 200 strongly typed events and delegates, extra features like `getPropertyFor`, `setPropertyFor`, `getParameterFor`, etc by adding openui5sharp.min.js (20 KB to the page) and including the OpenUI5Sharp assembly to a project that uses Bridge.net.

![Example of OpenUI5Sharp in action](https://raw.githubusercontent.com/emumanu/OpenUI5Sharp/master/openui5sharp.jpg)

Take a look at the samples in the repository. They are straight conversions from the tutorials/demos of OpenUI5. There are two projects per tutorial. One is a web application and the other is the C# project that creates the realted client scripts using OpenUI5Sharp and Bridge.
However, this samples only scratch the surface of what you can do with OpenUI5Sharp. The true potential of OpenUI5Sharp can be achieved with dynamically generated XML Views using `ASP.NET`, `OData v4`, etc.

For those who want to see some sample code without downloading anything, here you have 3 pieces of code, first in Javascript using OpenUI5 and then in C# using OpenUI5Sharp.

This OpenUI5 javascript handler:

```js
confirm: function (oEvent) {
    var oSortItem = oEvent.getParameter("sortItem");
    this._oRouterArgs.query.sortField = oSortItem.getKey();
    this._oRouterArgs.query.sortDescending = oEvent.getParameter("sortDescending");
    delete this._oRouterArgs.query.showDialog;
    oRouter.navTo("employeeOverview", this._oRouterArgs, true /*without history*/);
}
```
converts to this strongly typed event handler, where the parameters are retrieved using expressions and not string constants:

```csharp
void confirm(sap.ui.@base.Event<sap.m.ViewSettingsDialog.ConfirmInfo> oEvent, object oData)
{
    var oSortItem = oEvent.getParameterFor(e => e.sortItem);
    this._oRouterArgs.sortField = oSortItem.getKey();
    this._oRouterArgs.sortDescending = oEvent.getParameterFor(e => e.sortDescending);
    this._oRouterArgs.showDialog = false;
    oRouter.navTo("employeeOverview", new { query = this._oRouterArgs }, true /*without history*/);
}
```

This javascript code gets/sets properties of a JSONModel:

```js
onSort : function () {
	var oView = this.getView(),
		aStates = [undefined, "asc", "desc"],
		aStateTextIds = ["sortNone", "sortAscending", "sortDescending"],
		sMessage,
		iOrder = oView.getModel("appView").getProperty("/order");

	iOrder = (iOrder + 1) % aStates.length;
	var sOrder = aStates[iOrder];

	oView.getModel("appView").setProperty("/order", iOrder);
	oView.byId("peopleList").getBinding("items").sort(sOrder && new Sorter("LastName", sOrder === "desc"));

	sMessage = this._getText("sortMessage", [this._getText(aStateTextIds[iOrder])]);
	MessageToast.show(sMessage);
},
```
The equivalent code in OpenUI5Sharp uses a strongly typed JSONModel with no magic strings and type conversions for the properties:

```csharp
public void onSort()
{
    var oView = this.getView();
    string[] aStates = new string[] { null, "asc", "desc" };
    string[] aStateTextIds = new string[] { "sortNone", "sortAscending", "sortDescending" };
    string sMessage;
    int iOrder = oView.getModelFor<ViewModel>("appView").getPropertyFor(m => m.order);

    iOrder = (iOrder + 1) % aStates.Length;
    var sOrder = aStates[iOrder];

    oView.getModelFor<ViewModel>("appView").setPropertyFor(m => m.order, iOrder);
    if (sOrder != null) {
        oView.byId("peopleList").getBinding<sap.ui.model.odata.v4.ODataListBinding>("items").sort(new sap.ui.model.Sorter("LastName", sOrder == "desc"));
    } else {
        oView.byId("peopleList").getBinding<sap.ui.model.odata.v4.ODataListBinding>("items").sort();
    }

    sMessage = this._getText("sortMessage", new string[] { this._getText(aStateTextIds[iOrder]) });
    sap.m.MessageToast.show(sMessage);
}
```

The following javascript uses object literals for the metadata:

```js
sap.ui.define([
    "sap/ui/core/Control",
    "sap/m/RatingIndicator",
    "sap/m/Label",
    "sap/m/Button"

], function (Control, RatingIndicator, Label, Button) {
    "use strict";
    return Control.extend("sap.ui.demo.walkthrough.control.ProductRating", {
        metadata: {
            properties: {
                value: { type: "float", defaultValue: 0 }
            },
            aggregations: {
                _rating: { type: "sap.m.RatingIndicator", multiple: false, visibility: "hidden" },
                _label: { type: "sap.m.Label", multiple: false, visibility: "hidden" },
                _button: { type: "sap.m.Button", multiple: false, visibility: "hidden" }
            },
            events: {
                change: {
                    parameters: {
                        value: { type: "int" }
                    }
                }
            }
        },
        init: function () {
            this.setAggregation("_rating", new RatingIndicator({
                value: this.getValue(),
                iconSize: "2rem",
                visualMode: "Half",
                liveChange: this._onRate.bind(this)
            }));
            this.setAggregation("_label", new Label({
                text: "{i18n>productRatingLabelInitial}"
            }).addStyleClass("sapUiSmallMargin"));
            this.setAggregation("_button", new Button({
                text: "{i18n>productRatingButton}",
                press: this._onSubmit.bind(this)
            }).addStyleClass("sapUiTinyMarginTopBottom"));
        },
```
The equivalent code in OpenUI5Sharp uses strongly typed metadata and strongly typed settings:

```csharp
[FileName("control/ProductRating.js")]
[Name("sap.ui.demo.walkthrough.control.ProductRating")]
public class ProductRating : sap.ui.core.Control
{
        
    [Constructor("{}")]
    public class RatingInfo
    {
        public float value;
    }

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
                    var metadata = new Metadata() {
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
                    var newObj = Glue.CreateRawClassObject<ProductRating>(metadata);
                    return sap.ui.core.Control.extend(nameof(ProductRating), newObj);
                }
            )
        );
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
```

Also notice that event parameters are generated automatically from the class `RatingInfo`.

## History

2019/01/07 - v1.2.0 - Beta 2 version. 

What's new in this release:
- Updated OpenUI5 verstion to 1.58.4.
- Added strongly typed parameters to binding aggregations and bind properties related methods.
- Added lots of strongly typed parameters to sap.m.P13n*.
- Added proper inheritance chain for metadata classes.
- Switched from jquery.JQueryPromise<object> to es5.Promise<object>, as it is a lot easier to work with.
- Better Bridge class to OpenUI5 class conversion.
- The samples are move to their own [repository](https://github.com/emumanu/OpenUI5Sharp-samples)
- Lots of minor improvements.

This is the last version with manual dependency resolution. The next version of OpenUI5Sharp will use Bridge.net modules with automatic dependency resolution and will not require a modified bridge.js file.
Also, OpenUI5Sharp will have an associated nuget package for easier integration.

2018/10/09 - v1.1.0 - Beta 1 version. 

What's new in this release:
- Added support for the rest of OpenUI5 libraries.
- Renamed the parent namespace to UI5 in case some day SAPUI5Sharp gets released.
- Added Shop Administration Tool demo application.
- A lot of minor fixes and API improvements.
- Improved unit and integration test support.

2018/06/15 - v1.0.0 - Initial version.

## Contact

OpenUI5Sharp is developed by Manuel Abadía.

You can contact me creating a new issue or sending me an email to [my github username] @ gmail DOT com

## License

This project is licensed under the GPL3 License. See the LICENSE file for details.
