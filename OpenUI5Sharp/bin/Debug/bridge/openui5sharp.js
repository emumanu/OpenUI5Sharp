/**
 * A C# Wrapper for UI5 thanks to Bridge.net
 * @version 1.2
 * @copyright Copyright © 2019 Manuel Abadia
 * @compiler Bridge.NET 17.4.0
 */
Bridge.assembly("OpenUI5Sharp", function ($asm, globals) {
    "use strict";

    Bridge.define("UI5.Extensions.ExpressionEvaluator", {
        $metadata : function () { return {"att":1048961,"a":2,"s":true,"m":[{"a":2,"n":"GetPath","is":true,"t":8,"pi":[{"n":"pathExpression","pt":System.Object,"ps":0},{"n":"separator","dv":"/","o":true,"pt":System.String,"ps":1}],"tpc":1,"tprm":["T"],"sn":"GetPath","rt":System.String,"p":[System.Object,System.String]}]}; },
        statics: {
            methods: {
                GetPath: function (T, pathExpression, separator) {
                    var $t;
                    if (separator === void 0) { separator = "/"; }
                    if (pathExpression == null) {
                        throw new System.ArgumentNullException.$ctor1("pathExpression");
                    }

                    var me;
                    switch (pathExpression.body.ntype) {
                        case 10: 
                        case 11: 
                            var ue = ($t = pathExpression.body, Bridge.as($t, Bridge.hasValue($t) && ([4,10,11,28,29,30,34,40,44,49,54,60,62,77,78,79,80,82,83,84].indexOf($t.ntype) >= 0)));
                            me = ($t = ((ue != null) ? ue.operand : null), Bridge.as($t, Bridge.hasValue($t) && ($t.ntype === 23)));
                            break;
                        default: 
                            me = ($t = pathExpression.body, Bridge.as($t, Bridge.hasValue($t) && ($t.ntype === 23)));
                            break;
                    }

                    var path = new (System.Collections.Generic.List$1(System.String)).ctor();

                    while (me != null) {
                        path.add(me.member.n);
                        me = ($t = me.expression, Bridge.as($t, Bridge.hasValue($t) && ($t.ntype === 23)));
                    }

                    path.Reverse();
                    return Bridge.toArray(path).join(separator);
                }
            }
        }
    });

    Bridge.define("UI5.Extensions.BaseExtensions", {
        $metadata : function () { return {"att":1048961,"a":2,"s":true,"m":[{"a":2,"n":"getParameterFor","is":true,"t":8,"pi":[{"n":"event","pt":sap.ui.base.Event,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1}],"tpc":2,"tprm":["TParameter","TValue"],"sn":"getParameterFor","rt":System.Object,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"getParametersFor","is":true,"t":8,"pi":[{"n":"event","pt":sap.ui.base.Event,"ps":0}],"tpc":1,"tprm":["TParameter"],"sn":"getParametersFor","rt":System.Object,"p":[sap.ui.base.Event]}]}; },
        statics: {
            methods: {
                /**
                 * Returns the value of the parameter with the given expression.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.BaseExtensions
                 * @memberof UI5.Extensions.BaseExtensions
                 * @param   {Function}             TParameter        
                 * @param   {Function}             TValue            
                 * @param   {sap.ui.base.Event}    event             the event to extend
                 * @param   {System.Object}        pathExpression    the path/name of the property
                 * @return  {TValue}                                 The value for the parameter
                 */
                getParameterFor: function (TParameter, TValue, event, pathExpression) {
                    var sPropertyName = UI5.Extensions.ExpressionEvaluator.GetPath(Function, pathExpression);
                    return event.getParameter(sPropertyName);
                },
                /**
                 * Returns all parameter values of the event.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.BaseExtensions
                 * @memberof UI5.Extensions.BaseExtensions
                 * @param   {Function}             TParameter    
                 * @param   {sap.ui.base.Event}    event
                 * @return  {TParameter}                         All parameters of the event
                 */
                getParametersFor: function (TParameter, event) {
                    return event.getParameters();
                }
            }
        }
    });

    Bridge.define("sapuimodelContextTypedExtensions", {
        $metadata : function () { return {"att":1048961,"a":2,"s":true,"m":[{"a":2,"n":"getPropertyFor","is":true,"t":8,"pi":[{"n":"context","pt":sap.ui.model.Context,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":2}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getPropertyFor","rt":System.Object,"p":[sap.ui.model.Context,System.Object,System.Boolean]}]}; },
        statics: {
            methods: {
                /**
                 * Gets the property with the given relative binding path
                 *
                 * @static
                 * @public
                 * @this sapuimodelContextTypedExtensions
                 * @memberof sapuimodelContextTypedExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Context}    context           the context to extend
                 * @param   {System.Object}           pathExpression    the binding path
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                    the property value
                 */
                getPropertyFor: function (TModel, TValue, context, pathExpression, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, UI5.Extensions.ExpressionEvaluator.GetPath(Function, pathExpression));
                    return context.getProperty(sPropertyName);
                }
            }
        }
    });

    Bridge.define("UI5.Extensions.ModelExtensions", {
        $metadata : function () { return {"att":1048961,"a":2,"s":true,"m":[{"a":2,"n":"getOriginalPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":2}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getOriginalPropertyFor$2","rt":System.Object,"p":[sap.ui.model.Model,System.Object,System.Boolean]},{"a":2,"n":"getOriginalPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.json.JSONModel,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":2}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getOriginalPropertyFor","rt":System.Object,"p":[sap.ui.model.json.JSONModel,System.Object,System.Boolean]},{"a":2,"n":"getOriginalPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"oContext","pt":sap.ui.model.Context,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getOriginalPropertyFor$3","rt":System.Object,"p":[sap.ui.model.Model,System.Object,sap.ui.model.Context,System.Boolean]},{"a":2,"n":"getOriginalPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.json.JSONModel,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"oContext","pt":sap.ui.model.Context,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getOriginalPropertyFor$1","rt":System.Object,"p":[sap.ui.model.json.JSONModel,System.Object,sap.ui.model.Context,System.Boolean]},{"a":1,"n":"getOriginalPropertyForInternal","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":2}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getOriginalPropertyForInternal","rt":System.Object,"p":[sap.ui.model.Model,System.Object,System.Boolean]},{"a":1,"n":"getOriginalPropertyForInternal","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"oContext","pt":sap.ui.model.Context,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getOriginalPropertyForInternal$1","rt":System.Object,"p":[sap.ui.model.Model,System.Object,sap.ui.model.Context,System.Boolean]},{"a":2,"n":"getPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":2}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getPropertyFor$2","rt":System.Object,"p":[sap.ui.model.Model,System.Object,System.Boolean]},{"a":2,"n":"getPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.json.JSONModel,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":2}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getPropertyFor","rt":System.Object,"p":[sap.ui.model.json.JSONModel,System.Object,System.Boolean]},{"a":2,"n":"getPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"oContext","pt":sap.ui.model.Context,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getPropertyFor$3","rt":System.Object,"p":[sap.ui.model.Model,System.Object,sap.ui.model.Context,System.Boolean]},{"a":2,"n":"getPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.json.JSONModel,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"oContext","pt":sap.ui.model.Context,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getPropertyFor$1","rt":System.Object,"p":[sap.ui.model.json.JSONModel,System.Object,sap.ui.model.Context,System.Boolean]},{"a":1,"n":"getPropertyForInternal","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":2}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getPropertyForInternal","rt":System.Object,"p":[sap.ui.model.Model,System.Object,System.Boolean]},{"a":1,"n":"getPropertyForInternal","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"oContext","pt":sap.ui.model.Context,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getPropertyForInternal$1","rt":System.Object,"p":[sap.ui.model.Model,System.Object,sap.ui.model.Context,System.Boolean]},{"a":2,"n":"setPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyFor$3","rt":System.Boolean,"p":[sap.ui.model.Model,System.Object,System.Object,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":2,"n":"setPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.json.JSONModel,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyFor","rt":System.Boolean,"p":[sap.ui.model.json.JSONModel,System.Object,System.Object,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":2,"n":"setPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"oContext","pt":sap.ui.model.Context,"ps":3},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":4}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyFor$4","rt":System.Boolean,"p":[sap.ui.model.Model,System.Object,System.Object,sap.ui.model.Context,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":2,"n":"setPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.json.JSONModel,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"oContext","pt":sap.ui.model.Context,"ps":3},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":4}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyFor$1","rt":System.Boolean,"p":[sap.ui.model.json.JSONModel,System.Object,System.Object,sap.ui.model.Context,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":2,"n":"setPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"oContext","pt":sap.ui.model.Context,"ps":3},{"n":"bAsyncUpdate","pt":System.Boolean,"ps":4},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":5}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyFor$5","rt":System.Boolean,"p":[sap.ui.model.Model,System.Object,System.Object,sap.ui.model.Context,System.Boolean,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":2,"n":"setPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.json.JSONModel,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"oContext","pt":sap.ui.model.Context,"ps":3},{"n":"bAsyncUpdate","pt":System.Boolean,"ps":4},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":5}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyFor$2","rt":System.Boolean,"p":[sap.ui.model.json.JSONModel,System.Object,System.Object,sap.ui.model.Context,System.Boolean,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":1,"n":"setPropertyForInternal","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyForInternal","rt":System.Boolean,"p":[sap.ui.model.Model,System.Object,System.Object,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":1,"n":"setPropertyForInternal","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"oContext","pt":sap.ui.model.Context,"ps":3},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":4}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyForInternal$1","rt":System.Boolean,"p":[sap.ui.model.Model,System.Object,System.Object,sap.ui.model.Context,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":1,"n":"setPropertyForInternal","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"oContext","pt":sap.ui.model.Context,"ps":3},{"n":"bAsyncUpdate","pt":System.Boolean,"ps":4},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":5}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyForInternal$2","rt":System.Boolean,"p":[sap.ui.model.Model,System.Object,System.Object,sap.ui.model.Context,System.Boolean,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}}]}; },
        statics: {
            methods: {
                /**
                 * Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Model}      model             the model to extend
                 * @param   {System.Object}           pathExpression    the path/name of the property
                 * @param   {sap.ui.model.Context}    oContext          the context if available to access the property value
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                    Value the value of the property
                 */
                getOriginalPropertyFor$3: function (TModel, TValue, model, pathExpression, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.getOriginalPropertyForInternal$1(TModel, TValue, model, pathExpression, oContext, absolutePath);
                },
                /**
                 * Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}                       TModel            
                 * @param   {Function}                       TValue            
                 * @param   {sap.ui.model.json.JSONModel}    model             the model to extend
                 * @param   {System.Object}                  pathExpression    the path/name of the property
                 * @param   {sap.ui.model.Context}           oContext          the context if available to access the property value
                 * @param   {boolean}                        absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                           Value the value of the property
                 */
                getOriginalPropertyFor$1: function (TModel, TValue, model, pathExpression, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.getOriginalPropertyForInternal$1(TModel, TValue, model, pathExpression, oContext, absolutePath);
                },
                /**
                 * Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}              TModel            
                 * @param   {Function}              TValue            
                 * @param   {sap.ui.model.Model}    model             the model to extend
                 * @param   {System.Object}         pathExpression    the path/name of the property
                 * @param   {boolean}               absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                  Value the value of the property
                 */
                getOriginalPropertyFor$2: function (TModel, TValue, model, pathExpression, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.getOriginalPropertyForInternal(TModel, TValue, model, pathExpression, absolutePath);
                },
                /**
                 * Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}                       TModel            
                 * @param   {Function}                       TValue            
                 * @param   {sap.ui.model.json.JSONModel}    model             the model to extend
                 * @param   {System.Object}                  pathExpression    the path/name of the property
                 * @param   {boolean}                        absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                           Value the value of the property
                 */
                getOriginalPropertyFor: function (TModel, TValue, model, pathExpression, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.getOriginalPropertyForInternal(TModel, TValue, model, pathExpression, absolutePath);
                },
                getOriginalPropertyForInternal$1: function (TModel, TValue, model, pathExpression, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, UI5.Extensions.ExpressionEvaluator.GetPath(Function, pathExpression));
                    return model.getOriginalProperty(sPropertyName, oContext);
                },
                getOriginalPropertyForInternal: function (TModel, TValue, model, pathExpression, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, UI5.Extensions.ExpressionEvaluator.GetPath(Function, pathExpression));
                    return model.getOriginalProperty(sPropertyName);
                },
                /**
                 * Implement in inheriting classes
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Model}      model             the model to extend
                 * @param   {System.Object}           pathExpression    the path to where to read the attribute value
                 * @param   {sap.ui.model.Context}    oContext          the context with which the path should be resolved
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                    Returns the value for the property with the given sPropertyName
                 */
                getPropertyFor$3: function (TModel, TValue, model, pathExpression, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.getPropertyForInternal$1(TModel, TValue, model, pathExpression, oContext, absolutePath);
                },
                /**
                 * Implement in inheriting classes
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}                       TModel            
                 * @param   {Function}                       TValue            
                 * @param   {sap.ui.model.json.JSONModel}    model             the model to extend
                 * @param   {System.Object}                  pathExpression    the path to where to read the attribute value
                 * @param   {sap.ui.model.Context}           oContext          the context with which the path should be resolved
                 * @param   {boolean}                        absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                           Returns the value for the property with the given sPropertyName
                 */
                getPropertyFor$1: function (TModel, TValue, model, pathExpression, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.getPropertyForInternal$1(TModel, TValue, model, pathExpression, oContext, absolutePath);
                },
                /**
                 * Implement in inheriting classes
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}              TModel            
                 * @param   {Function}              TValue            
                 * @param   {sap.ui.model.Model}    model             the model to extend
                 * @param   {System.Object}         pathExpression    the path to where to read the attribute value
                 * @param   {boolean}               absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                  Returns the value for the property with the given sPropertyName
                 */
                getPropertyFor$2: function (TModel, TValue, model, pathExpression, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.getPropertyForInternal(TModel, TValue, model, pathExpression, absolutePath);
                },
                /**
                 * Implement in inheriting classes
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}                       TModel            
                 * @param   {Function}                       TValue            
                 * @param   {sap.ui.model.json.JSONModel}    model             the model to extend
                 * @param   {System.Object}                  pathExpression    the path to where to read the attribute value
                 * @param   {boolean}                        absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                           Returns the value for the property with the given sPropertyName
                 */
                getPropertyFor: function (TModel, TValue, model, pathExpression, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.getPropertyForInternal(TModel, TValue, model, pathExpression, absolutePath);
                },
                getPropertyForInternal$1: function (TModel, TValue, model, pathExpression, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, UI5.Extensions.ExpressionEvaluator.GetPath(Function, pathExpression));
                    return model.getProperty(sPropertyName, oContext);
                },
                getPropertyForInternal: function (TModel, TValue, model, pathExpression, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, UI5.Extensions.ExpressionEvaluator.GetPath(Function, pathExpression));
                    return model.getProperty(sPropertyName);
                },
                /**
                 * Sets a new value for the given property <pre><code>sPropertyName</code></pre> in the model. If the model value changed all interested parties are informed.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Model}      model             the model to extend
                 * @param   {System.Object}           pathExpression    path of the property to set
                 * @param   {TValue}                  value             value to set the property to
                 * @param   {sap.ui.model.Context}    oContext          the context which will be used to set the property
                 * @param   {boolean}                 bAsyncUpdate      whether to update other bindings dependent on this property asynchronously
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {boolean}                                   true if the value was set correctly and false if errors occurred like the entry was not found.
                 */
                setPropertyFor$5: function (TModel, TValue, model, pathExpression, value, oContext, bAsyncUpdate, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.setPropertyForInternal$2(TModel, TValue, model, pathExpression, value, oContext, bAsyncUpdate, absolutePath);
                },
                /**
                 * Sets a new value for the given property <pre><code>sPropertyName</code></pre> in the model. If the model value changed all interested parties are informed.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}                       TModel            
                 * @param   {Function}                       TValue            
                 * @param   {sap.ui.model.json.JSONModel}    model             the model to extend
                 * @param   {System.Object}                  pathExpression    path of the property to set
                 * @param   {TValue}                         value             value to set the property to
                 * @param   {sap.ui.model.Context}           oContext          the context which will be used to set the property
                 * @param   {boolean}                        bAsyncUpdate      whether to update other bindings dependent on this property asynchronously
                 * @param   {boolean}                        absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {boolean}                                          true if the value was set correctly and false if errors occurred like the entry was not found.
                 */
                setPropertyFor$2: function (TModel, TValue, model, pathExpression, value, oContext, bAsyncUpdate, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.setPropertyForInternal$2(TModel, TValue, model, pathExpression, value, oContext, bAsyncUpdate, absolutePath);
                },
                /**
                 * Sets a new value for the given property <pre><code>sPropertyName</code></pre> in the model. If the model value changed all interested parties are informed.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Model}      model             the model to extend
                 * @param   {System.Object}           pathExpression    path of the property to set
                 * @param   {TValue}                  value             value to set the property to
                 * @param   {sap.ui.model.Context}    oContext          the context which will be used to set the property
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {boolean}                                   true if the value was set correctly and false if errors occurred like the entry was not found.
                 */
                setPropertyFor$4: function (TModel, TValue, model, pathExpression, value, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.setPropertyForInternal$1(TModel, TValue, model, pathExpression, value, oContext, absolutePath);
                },
                /**
                 * Sets a new value for the given property <pre><code>sPropertyName</code></pre> in the model. If the model value changed all interested parties are informed.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}                       TModel            
                 * @param   {Function}                       TValue            
                 * @param   {sap.ui.model.json.JSONModel}    model             the model to extend
                 * @param   {System.Object}                  pathExpression    path of the property to set
                 * @param   {TValue}                         value             value to set the property to
                 * @param   {sap.ui.model.Context}           oContext          the context which will be used to set the property
                 * @param   {boolean}                        absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {boolean}                                          true if the value was set correctly and false if errors occurred like the entry was not found.
                 */
                setPropertyFor$1: function (TModel, TValue, model, pathExpression, value, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.setPropertyForInternal$1(TModel, TValue, model, pathExpression, value, oContext, absolutePath);
                },
                /**
                 * Sets a new value for the given property <pre><code>sPropertyName</code></pre> in the model. If the model value changed all interested parties are informed.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}              TModel            
                 * @param   {Function}              TValue            
                 * @param   {sap.ui.model.Model}    model             the model to extend
                 * @param   {System.Object}         pathExpression    path of the property to set
                 * @param   {TValue}                value             value to set the property to
                 * @param   {boolean}               absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {boolean}                                 true if the value was set correctly and false if errors occurred like the entry was not found.
                 */
                setPropertyFor$3: function (TModel, TValue, model, pathExpression, value, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.setPropertyForInternal(TModel, TValue, model, pathExpression, value, absolutePath);
                },
                /**
                 * Sets a new value for the given property <pre><code>sPropertyName</code></pre> in the model. If the model value changed all interested parties are informed.
                 *
                 * @static
                 * @public
                 * @this UI5.Extensions.ModelExtensions
                 * @memberof UI5.Extensions.ModelExtensions
                 * @param   {Function}                       TModel            
                 * @param   {Function}                       TValue            
                 * @param   {sap.ui.model.json.JSONModel}    model             the model to extend
                 * @param   {System.Object}                  pathExpression    path of the property to set
                 * @param   {TValue}                         value             value to set the property to
                 * @param   {boolean}                        absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {boolean}                                          true if the value was set correctly and false if errors occurred like the entry was not found.
                 */
                setPropertyFor: function (TModel, TValue, model, pathExpression, value, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    return UI5.Extensions.ModelExtensions.setPropertyForInternal(TModel, TValue, model, pathExpression, value, absolutePath);
                },
                setPropertyForInternal$2: function (TModel, TValue, model, pathExpression, value, oContext, bAsyncUpdate, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, UI5.Extensions.ExpressionEvaluator.GetPath(Function, pathExpression));
                    return model.setProperty(sPropertyName, value, oContext, bAsyncUpdate);
                },
                setPropertyForInternal$1: function (TModel, TValue, model, pathExpression, value, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, UI5.Extensions.ExpressionEvaluator.GetPath(Function, pathExpression));
                    return model.setProperty(sPropertyName, value, oContext);
                },
                setPropertyForInternal: function (TModel, TValue, model, pathExpression, value, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, UI5.Extensions.ExpressionEvaluator.GetPath(Function, pathExpression));
                    return model.setProperty(sPropertyName, value);
                }
            }
        }
    });

    Bridge.define("UI5.Glue", {
        $metadata : function () { return {"att":1048961,"a":2,"s":true,"m":[{"a":2,"n":"CopyToGlobalScope","is":true,"t":8,"pi":[{"n":"typeName","pt":System.String,"ps":0},{"n":"obj","pt":System.Object,"ps":1}],"tpc":1,"tprm":["T"],"sn":"CopyToGlobalScope","rt":System.Void,"p":[System.String,System.Object]},{"a":2,"n":"CreateAndExtendUI5Class","is":true,"t":8,"tpc":1,"tprm":["T"],"sn":"CreateAndExtendUI5Class","rt":System.Object},{"a":2,"n":"CreateClassInGlobalScope","is":true,"t":8,"tpc":1,"tprm":["T"],"sn":"CreateClassInGlobalScope","rt":System.Object},{"a":2,"n":"CreateInScope","is":true,"t":8,"pi":[{"n":"className","pt":System.String,"ps":0}],"tpc":0,"def":function (className) { return eval(className.replace(/\./g, '_') + ' = window'); },"rt":System.Void,"p":[System.String]},{"a":2,"n":"CreateRawClassObject","is":true,"t":8,"pi":[{"n":"isUI5Class","dv":true,"o":true,"pt":System.Boolean,"ps":0}],"tpc":1,"tprm":["T"],"sn":"CreateRawClassObject","rt":System.Object,"p":[System.Boolean]},{"a":2,"n":"CreateUI5CompatClass","is":true,"t":8,"tpc":1,"tprm":["T"],"sn":"CreateUI5CompatClass","rt":System.Object},{"a":2,"n":"CreateUI5CompatScope","is":true,"t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0}],"tpc":0,"def":function (obj) { return eval(Bridge.Reflection.getTypeFullName(obj).replace(/\./g, '_') + ' = obj'); },"rt":System.Void,"p":[System.Object]},{"a":2,"n":"ExtendUI5Class","is":true,"t":8,"pi":[{"n":"rawClass","pt":System.Object,"ps":0}],"tpc":1,"tprm":["T"],"sn":"ExtendUI5Class","rt":System.Object,"p":[System.Object]},{"a":1,"n":"GetWindow","is":true,"t":8,"tpc":0,"def":function () { return window; },"rt":System.Object},{"a":2,"n":"IsNullOrUndefined","is":true,"t":8,"pi":[{"n":"val","pt":System.Object,"ps":0}],"sn":"IsNullOrUndefined","rt":System.Boolean,"p":[System.Object],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":1,"n":"SetPrototypeToObject","is":true,"t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0}],"tpc":0,"def":function (obj) { return Object.setPrototypeOf(obj, Object); },"rt":System.Void,"p":[System.Object]},{"a":2,"n":"ToBoolean","is":true,"t":8,"pi":[{"n":"val","pt":System.Object,"ps":0}],"sn":"ToBoolean","rt":System.Boolean,"p":[System.Object],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}}]}; },
        statics: {
            methods: {
                /**
                 * Checks if the value passed is null of undefined
                 *
                 * @static
                 * @public
                 * @this UI5.Glue
                 * @memberof UI5.Glue
                 * @param   {System.Object}    val    the value to check
                 * @return  {boolean}                 true if val is null or undefined; false otherwise
                 */
                IsNullOrUndefined: function (val) {
                    return ((val == null) || (Bridge.referenceEquals(val, undefined)));
                },
                /**
                 * The value passed if it is a boolean or can be converted to boolean
                 *
                 * @static
                 * @public
                 * @this UI5.Glue
                 * @memberof UI5.Glue
                 * @param   {System.Object}    val    the value
                 * @return  {boolean}                 true if val or can be converted to a boolean; false otherwise
                 */
                ToBoolean: function (val) {
                    if (UI5.Glue.IsNullOrUndefined(val)) {
                        return false;
                    }

                    if (Bridge.is(val, System.String)) {
                        return Bridge.referenceEquals(Bridge.cast(val, System.String), "true");
                    }

                    return !!val;
                },
                CreateRawClassObject: function (T, isUI5Class) {
                    var $t;
                    if (isUI5Class === void 0) { isUI5Class = true; }
                    var type = T;
                    var obj = T.prototype;
                    var baseType = Bridge.Reflection.getBaseType(type);

                    $t = Bridge.getEnumerator(System.Linq.Enumerable.from(Bridge.Reflection.getMembers(type, 4, 28)).where(function (f) {
                            return (f.is || false);
                        }));
                    try {
                        while ($t.moveNext()) {
                            var field = $t.Current;
                            obj[field.sn] = Bridge.Reflection.fieldAccess(field, null);
                        }
                    } finally {
                        if (Bridge.is($t, System.IDisposable)) {
                            $t.System$IDisposable$Dispose();
                        }
                    }
                    ;

                    if (isUI5Class) {
                        Object.setPrototypeOf(obj, Object);
                        obj.$UI5SharpBaseType = baseType;
                    } else {
                        UI5.Glue.CopyToGlobalScope(T, Bridge.Reflection.getTypeFullName(type), obj);
                    }

                    return obj;
                },
                CreateUI5CompatClass: function (T) {
                    var type = T;
                    var classObj = T.prototype;
                    var baseType = Bridge.Reflection.getBaseType(type);

                    Object.setPrototypeOf(classObj, Object);
                    classObj.$UI5SharpBaseType = baseType;

                    return classObj;
                },
                CreateClassInGlobalScope: function (T) {
                    var type = T;
                    var classObj = T.prototype;
                    UI5.Glue.CopyToGlobalScope(T, Bridge.Reflection.getTypeFullName(type), classObj);
                    return classObj;
                },
                CopyToGlobalScope: function (T, typeName, obj) {
                    var $t;
                    var context = window;

                    var parts = System.String.split(typeName, [46].map(function (i) {{ return String.fromCharCode(i); }}));
                    var lastPart = Bridge.cast(parts.pop(), System.String);

                    $t = Bridge.getEnumerator(parts);
                    try {
                        while ($t.moveNext()) {
                            var part = $t.Current;
                            if (context[part] === null || (!context[part] === undefined && ((!Bridge.referenceEquals((typeof context[part]), "object")) && (!Bridge.referenceEquals((typeof context[part]), "function"))))) {
                                throw new System.InvalidOperationException.$ctor1(System.String.format("Could not set object-path for {0}, path segment {1} already exists.", typeName, part));
                            }

                            if (context[part] === undefined) {
                                context[part] = { };
                            }

                            context = context[part];
                        }
                    } finally {
                        if (Bridge.is($t, System.IDisposable)) {
                            $t.System$IDisposable$Dispose();
                        }
                    }

                    context[lastPart] = obj.ctor;
                },
                ExtendUI5Class: function (T, rawClass) {
                    var type = T;
                    var fullTypeName = Bridge.Reflection.getTypeFullName(type);
                    var baseType = rawClass.$UI5SharpBaseType;
                    return baseType.extend(fullTypeName, rawClass);
                },
                CreateAndExtendUI5Class: function (T) {
                    var obj = UI5.Glue.CreateUI5CompatClass(T);
                    return UI5.Glue.ExtendUI5Class(T, obj);
                }
            }
        }
    });

    Bridge.define("UI5.Metadata.TypedMetadata", {
        $metadata : function () { return {"att":1048961,"a":2,"s":true,"m":[{"a":2,"n":"CreateUI5EventInfo","is":true,"t":8,"tpc":1,"tprm":["T"],"sn":"CreateUI5EventInfo","rt":System.Object},{"a":2,"n":"GetUI5Type","is":true,"t":8,"pi":[{"n":"fieldType","pt":Function,"ps":0}],"sn":"GetUI5Type","rt":System.String,"p":[Function]}]}; },
        statics: {
            methods: {
                CreateUI5EventInfo: function (T) {
                    var $t;
                    var paramDict = { };

                    $t = Bridge.getEnumerator(System.Linq.Enumerable.from(Bridge.Reflection.getMembers(T, 4, 28)).where(function (f) {
                            return !(f.is || false);
                        }));
                    try {
                        while ($t.moveNext()) {
                            var field = $t.Current;
                            paramDict[field.sn] = { type: UI5.Metadata.TypedMetadata.GetUI5Type(field.rt) };
                        }
                    } finally {
                        if (Bridge.is($t, System.IDisposable)) {
                            $t.System$IDisposable$Dispose();
                        }
                    }
                    ;

                    var evt = { parameters: paramDict };

                    return evt;
                },
                GetUI5Type: function (fieldType) {
                    var result = Bridge.Reflection.getTypeName(fieldType);

                    var primitiveTypes = function (_o1) {
                            _o1.add(System.String, function () {
                                return (result = "string");
                            });
                            _o1.add(System.Boolean, function () {
                                return (result = "boolean");
                            });
                            _o1.add(System.Int32, function () {
                                return (result = "int");
                            });
                            _o1.add(System.Single, function () {
                                return (result = "float");
                            });
                            _o1.add(System.Object, function () {
                                return (result = "object");
                            });
                            return _o1;
                        }(new (System.Collections.Generic.Dictionary$2(Function,Function))());

                    if (primitiveTypes.containsKey(fieldType)) {
                        primitiveTypes.get(fieldType)();
                    } else {
                    }

                    return result;
                }
            }
        }
    });
});
