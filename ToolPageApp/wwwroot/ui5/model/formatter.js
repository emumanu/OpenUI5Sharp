Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("manu.toolpageapp.fv.model.Formatter", {
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"a":2,"n":"DefineScript","is":true,"t":8,"sn":"DefineScript","rt":System.Void},{"v":true,"a":2,"n":"srcImageValue","t":8,"pi":[{"n":"bIsPhone","pt":System.Boolean,"ps":0}],"sn":"srcImageValue","rt":System.String,"p":[System.Boolean]}]}; },
        methods: {
            /**
             * Gets the path to the image based on the device
             *
             * @instance
             * @public
             * @this manu.toolpageapp.fv.model.Formatter
             * @memberof manu.toolpageapp.fv.model.Formatter
             * @param   {boolean}    bIsPhone    the value to be checked
             * @return  {string}                 path to image
             */
            srcImageValue: function (bIsPhone) {
                var sImageSrc = "";
                if (!bIsPhone) {
                    sImageSrc = "/images/homeImage.jpg";
                } else {
                    sImageSrc = "/images/homeImage_small.jpg";
                }
                return sImageSrc;
            }
        }
    });
});

sap.ui.define(System.Array.init([], System.String), function () {
    var newObj = UI5.Glue.CreateRawClassObject(manu.toolpageapp.fv.model.Formatter);
    return newObj;
});
