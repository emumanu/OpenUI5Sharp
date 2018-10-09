Bridge.assembly("WalkthroughClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("WalkthroughClientScripts.Formatter", {
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"sn":"ctor"},{"a":2,"n":"Script","is":true,"t":8,"sn":"Script","rt":System.Void},{"a":2,"n":"statusText","t":8,"pi":[{"n":"sStatus","pt":System.String,"ps":0}],"sn":"statusText","rt":System.String,"p":[System.String]}]}; },
        ctors: {
            ctor: function () {
                this.$initialize();
            }
        },
        methods: {
            statusText: function (sStatus) {
                // WTF is it whit getView???
                var resourceBundle = this.getView().getModel("i18n").getResourceBundle();
                switch (sStatus) {
                    case "A": 
                        return resourceBundle.getText("invoiceStatusA");
                    case "B": 
                        return resourceBundle.getText("invoiceStatusB");
                    case "C": 
                        return resourceBundle.getText("invoiceStatusC");
                    default: 
                        return sStatus;
                }
            }
        }
    });
});

sap.ui.define(System.Array.init([], System.String), function () {
    return UI5.Glue.CreateRawClassObject(WalkthroughClientScripts.Formatter);
});
