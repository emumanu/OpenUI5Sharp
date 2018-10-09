Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("manu.toolpageapp.fv.model.Models", {
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"a":2,"n":"DefineScript","is":true,"t":8,"sn":"DefineScript","rt":System.Void},{"v":true,"a":2,"n":"createDeviceModel","t":8,"sn":"createDeviceModel","rt":sap.ui.model.Model},{"a":2,"n":"Device","t":4,"rt":sap.ui.Device,"sn":"Device"}]}; },
        fields: {
            Device: null
        },
        methods: {
            createDeviceModel: function () {
                var oModel = new sap.ui.model.json.JSONModel(this.Device);
                oModel.setDefaultBindingMode(sap.ui.model.BindingMode.OneWay);
                return oModel;
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/ui/Device", "sap/ui/model/json/JSONModel"], System.String), function (Device) {
    var newObj = UI5.Glue.CreateRawClassObject(manu.toolpageapp.fv.model.Models);
    newObj.Device = Device;
    return newObj;
});
