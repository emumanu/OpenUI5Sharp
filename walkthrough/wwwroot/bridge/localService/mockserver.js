Bridge.assembly("WalkthroughClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("WalkthroughClientScripts.Tests.MockServer", {
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"a":2,"n":"Script","is":true,"t":8,"sn":"Script","rt":System.Void},{"v":true,"a":2,"n":"init","t":8,"sn":"init","rt":System.Void}]}; },
        methods: {
            init: function () {
                var $t;
                var oMockServer = new sap.ui.core.util.MockServer({ rootUri: "https://cors-anywhere.herokuapp.com/services.odata.org/V2/Northwind/Northwind.svc/" });

                var oUriParameters = jQuery.sap.getUriParameters(Bridge.cast(undefined, System.String));

                // configure mock server with a delay
                sap.ui.core.util.MockServer.config({ autoRespond: true, autoRespondAfter: ($t = (oUriParameters.get("serverDelay")), $t != null ? $t : 1000) });

                // simulate
                var sPath = jQuery.sap.getModulePath("sap.ui.demo.walkthrough.localService");
                oMockServer.simulate((sPath || "") + "/metadata.xml", { sMockdataBaseUrl: (sPath || "") + "/mockdata" });

                // start
                oMockServer.start();
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/ui/core/util/MockServer"], System.String), function () {
    var newObj = UI5.Glue.CreateRawClassObject(WalkthroughClientScripts.Tests.MockServer);
    return newObj;
});
