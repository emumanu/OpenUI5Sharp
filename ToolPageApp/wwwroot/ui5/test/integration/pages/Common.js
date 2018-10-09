Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("manu.toolpageapp.fv.test.integration.pages.Common", {
        inherits: [sap.ui.test.Opa5],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"a":2,"n":"DefineScript","is":true,"t":8,"sn":"DefineScript","rt":System.Void},{"v":true,"a":2,"n":"getFrameUrl","t":8,"pi":[{"n":"sHash","pt":System.String,"ps":0},{"n":"sUrlParameters","pt":System.String,"ps":1}],"sn":"getFrameUrl","rt":System.String,"p":[System.String,System.String]},{"v":true,"a":2,"n":"iLookAtTheScreen","t":8,"sn":"iLookAtTheScreen","rt":manu.toolpageapp.fv.test.integration.pages.Common},{"v":true,"a":2,"n":"iStartTheApp","t":8,"pi":[{"n":"oOptions","dv":null,"o":true,"pt":System.Object,"ps":0}],"sn":"iStartTheApp","rt":System.Void,"p":[System.Object]}]}; },
        methods: {
            getFrameUrl: function (sHash, sUrlParameters) {
                var sUrl = jQuery.sap.getResourcePath("manu/toolpageapp/fv/app");
                if (sHash == null) {
                    sHash = "";
                }
                sUrlParameters = (sUrlParameters != null) ? "?" + (sUrlParameters || "") : "";

                if (sHash.length > 0) {
                    sHash = "#" + ((System.String.indexOf(sHash, "/") === 0 ? sHash.substr(1) : sHash) || "");
                } else {
                    sHash = "";
                }

                return (sUrl || "") + (sUrlParameters || "") + (sHash || "");
            },
            iStartTheApp: function (oOptions) {
                if (oOptions === void 0) { oOptions = null; }
                if (oOptions == null) {
                    oOptions = { };
                }
                // Start the app with a minimal delay to make tests run fast but still async to discover basic timing issues
                this.iStartMyAppInAFrame(this.getFrameUrl(Bridge.cast(oOptions.hash, System.String), "serverDelay=50"));
            },
            iLookAtTheScreen: function () {
                return this;
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/ui/test/Opa5"], System.String), function () {
    var newObj = UI5.Glue.CreateRawClassObject(manu.toolpageapp.fv.test.integration.pages.Common);
    return sap.ui.base.Object.extend("manu.toolpageapp.fv.test.integration.pages.Common", newObj);
});
