jQuery.sap.require("sap.ui.qunit.qunit-css");
jQuery.sap.require("sap.ui.thirdparty.qunit");
jQuery.sap.require("sap.ui.qunit.qunit-junit");
QUnit.config.autostart = false;

Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("ClientScripts.Test.Integration.AllJourneys", {
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"a":2,"n":"DefineScript","is":true,"t":8,"sn":"DefineScript","rt":System.Void},{"a":2,"n":"RequireScript","is":true,"t":8,"sn":"RequireScript","rt":System.Void}]}; }
    });
});

sap.ui.define(System.Array.init(["sap/ui/test/Opa5", "manu/toolpageapp/fv/test/integration/pages/Common", "sap/ui/test/opaQunit", "manu/toolpageapp/fv/test/integration/pages/App", "manu/toolpageapp/fv/test/integration/pages/Settings", "manu/toolpageapp/fv/test/integration/pages/Statistics", "manu/toolpageapp/fv/test/integration/pages/Home"], System.String), function (Opa5, Common) {
    sap.ui.test.Opa5.extendConfig({ arrangements: new manu.toolpageapp.fv.test.integration.pages.Common(), viewNamespace: "manu.toolpageapp.fv.view." });

    sap.ui.require(System.Array.init(["manu/toolpageapp/fv/test/integration/NavigationJourney"], System.String), function () {
        QUnit.start();
    });
});
