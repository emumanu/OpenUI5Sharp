/**
 * @version 1.0.0.0
 * @copyright Copyright ©  2018
 * @compiler Bridge.NET 17.4.0
 */
Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("manu.toolpageapp.fv.controller.BaseController", {
        inherits: [sap.ui.core.mvc.Controller],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.Object],"pi":[{"n":"sName","pt":System.Object,"ps":0}],"sn":"ctor"},{"a":2,"n":"DefineScript","is":true,"t":8,"sn":"DefineScript","rt":System.Void},{"v":true,"a":2,"n":"getModel","t":8,"pi":[{"n":"sName","pt":System.String,"ps":0}],"tpc":1,"tprm":["T"],"sn":"getModel","rt":System.Object,"p":[System.String]},{"v":true,"a":2,"n":"getModelFor","t":8,"pi":[{"n":"sName","pt":System.String,"ps":0}],"tpc":1,"tprm":["T"],"sn":"getModelFor","rt":sap.ui.model.Model,"p":[System.String]},{"v":true,"a":2,"n":"getRouter","t":8,"sn":"getRouter","rt":sap.ui.core.routing.Router},{"v":true,"a":2,"n":"setModel","t":8,"pi":[{"n":"oModel","pt":sap.ui.model.Model,"ps":0},{"n":"sName","pt":System.String,"ps":1}],"sn":"setModel","rt":System.Void,"p":[sap.ui.model.Model,System.String]}]}; },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                sap.ui.core.mvc.Controller.call(this, sName);
            }
        },
        methods: {
            /**
             * Convenience method for accessing the router
             *
             * @instance
             * @public
             * @this manu.toolpageapp.fv.controller.BaseController
             * @memberof manu.toolpageapp.fv.controller.BaseController
             * @return  {sap.ui.core.routing.Router}        the router for this component
             */
            getRouter: function () {
                return sap.ui.core.UIComponent.getRouterFor(this);
            },
            /**
             * Convenience method for getting the view model by name
             *
             * @instance
             * @public
             * @this manu.toolpageapp.fv.controller.BaseController
             * @memberof manu.toolpageapp.fv.controller.BaseController
             * @param   {Function}    T        
             * @param   {string}      sName    the model name
             * @return  {T}                    the model instance
             */
            getModel: function (T, sName) {
                return this.getView().getModel(sName);
            },
            /**
             * Convenience method for getting the strongly view model by name
             *
             * @instance
             * @public
             * @this manu.toolpageapp.fv.controller.BaseController
             * @memberof manu.toolpageapp.fv.controller.BaseController
             * @param   {Function}              T        
             * @param   {string}                sName    the model name
             * @return  {sap.ui.model.Model}             the model instance
             */
            getModelFor: function (T, sName) {
                return this.getView().getModel(sName);
            },
            /**
             * Convenience method for setting the view model.
             *
             * @instance
             * @public
             * @this manu.toolpageapp.fv.controller.BaseController
             * @memberof manu.toolpageapp.fv.controller.BaseController
             * @param   {sap.ui.model.Model}    oModel    the model name
             * @param   {string}                sName     the model name
             * @return  {void}
             */
            setModel: function (oModel, sName) {
                this.getView().setModel(oModel, sName);
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/ui/core/mvc/Controller"], System.String), function () {
    var newObj = UI5.Glue.CreateRawClassObject(manu.toolpageapp.fv.controller.BaseController);
    return sap.ui.core.mvc.Controller.extend("manu.toolpageapp.fv.controller.BaseController", newObj);
});
