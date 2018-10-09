Bridge.assembly("RoutingClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.nav.Component", {
        inherits: [sap.ui.core.UIComponent],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String,System.Object],"pi":[{"n":"sId","pt":System.String,"ps":0},{"n":"mSettings","pt":System.Object,"ps":1}],"sn":"ctor"},{"a":2,"n":"Script","is":true,"t":8,"sn":"Script","rt":System.Void},{"ov":true,"a":2,"n":"init","t":8,"sn":"init","rt":System.Void},{"a":2,"n":"metadata","is":true,"t":4,"rt":System.Object,"sn":"metadata"}]}; },
        statics: {
            fields: {
                metadata: null
            },
            ctors: {
                init: function () {
                    this.metadata = { manifest: "json" };
                }
            }
        },
        ctors: {
            ctor: function (sId, mSettings) {
                this.$initialize();
                sap.ui.core.UIComponent.call(this, sId, mSettings);
            }
        },
        methods: {
            init: function () {
                // call the init function of the parent
                sap.ui.core.UIComponent.prototype.init.call(this);

                // create the views based on the url/hash
                this.getRouter().initialize();
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/ui/core/UIComponent"], System.String), function (UIComponent) {
    var newObj = UI5.Glue.CreateRawClassObject(sap.ui.demo.nav.Component);
    return sap.ui.core.UIComponent.extend("sap.ui.demo.nav.Component", newObj);
});
