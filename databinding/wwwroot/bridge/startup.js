sap.ui.getCore().attachInit(function () {
    var oProductModel = new sap.ui.model.json.JSONModel(null);
    oProductModel.loadData("./bridge/model/Products.json");
    sap.ui.getCore().setModel(oProductModel, "products");

    // Create a JSON model from an object literal
    var oModel = new sap.ui.model.json.JSONModel({ firstName: "Harry", lastName: "Hawk", enabled: true, address: { street: "Dietmar-Hopp-Allee 16", city: "Walldorf", zip: "69190", country: "Germany" }, salesToDate: 12345.6789, priceThreshold: 20, currencyCode: "EUR" });

    // Assign the model object to the SAPUI5 core
    sap.ui.getCore().setModel(oModel);

    // Create a resource bundle for language specific texts
    var oResourceModel = new sap.ui.model.resource.ResourceModel({ bundleName: "sap.ui.demo.db.i18n.i18n" });

    // Assign the model object to the SAPUI5 core using the name "i18n"
    sap.ui.getCore().setModel(oResourceModel, "i18n");

    // Create view
    var oView = new sap.ui.core.mvc.XMLView({ viewName: "sap.ui.demo.db.view.App" });

    // Register the view with the message manager
    sap.ui.getCore().getMessageManager().registerObject(oView, true);

    // Insert the view into the DOM
    oView.placeAt("content");
});

Bridge.assembly("DatabindingClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.db.startup");
});
