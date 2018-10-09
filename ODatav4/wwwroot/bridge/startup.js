sap.ui.getCore().attachInit(function () {
    sap.ui.require(System.Array.init(["sap/ui/core/tutorial/root/mockserver", "sap/m/Shell", "sap/ui/core/ComponentContainer"], System.String), function (mockserver) {
        // Requests to the service are intercepted and fake responses returned.
        // Comment this out to connect to the real service.
        mockserver.start();

        new sap.m.Shell({ app: new sap.ui.core.ComponentContainer({ height: "100%", component: sap.ui.component({ name: "sap.ui.core.tutorial.odatav4", manifestFirst: true, id: "odatav4" }) }) }).placeAt("content");
    });
});

Bridge.assembly("ODatav4ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.core.tutorial.odatav4.startup");
});
