sap.ui.getCore().attachInit(function () {
    sap.ui.require(System.Array.init(["sap/ui/core/ComponentContainer"], System.String), function () {
        new sap.ui.core.ComponentContainer({ name: "manu.toolpageapp.fv", height: "100%", settings: { id: "FVCContainer" } }).placeAt("content");
    });
});

Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("manu.toolpageapp.fv.startup");
});
