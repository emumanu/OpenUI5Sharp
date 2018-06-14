/**
 * OpenUI5Sharp
 * @version 1.0.0.0
 * @copyright Copyright © 2018 Manuel Abadia
 * @compiler Bridge.NET 17.1.1
 */
Bridge.assembly("OpenUI5Sharp", function ($asm, globals) {
    "use strict";

    Bridge.define("ExpressionEvaluator", {
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

    Bridge.define("sapuibaseExtensions", {
        $metadata : function () { return {"att":1048961,"a":2,"s":true,"m":[{"a":2,"n":"getParameterFor","is":true,"t":8,"pi":[{"n":"event","pt":sap.ui.base.Event,"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1}],"tpc":2,"tprm":["TParameter","TValue"],"sn":"getParameterFor","rt":System.Object,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"getParametersFor","is":true,"t":8,"pi":[{"n":"event","pt":sap.ui.base.Event,"ps":0}],"tpc":1,"tprm":["TParameter"],"sn":"getParametersFor","rt":System.Object,"p":[sap.ui.base.Event]}]}; },
        statics: {
            methods: {
                /**
                 * Returns the value of the parameter with the given expression.
                 *
                 * @static
                 * @public
                 * @this sapuibaseExtensions
                 * @memberof sapuibaseExtensions
                 * @param   {Function}             TParameter        
                 * @param   {Function}             TValue            
                 * @param   {sap.ui.base.Event}    event             the event to extend
                 * @param   {System.Object}        pathExpression    the path/name of the property
                 * @return  {TValue}                                 The value for the parameter
                 */
                getParameterFor: function (TParameter, TValue, event, pathExpression) {
                    var sPropertyName = ExpressionEvaluator.GetPath(Bridge.global.Function, pathExpression);
                    return event.getParameter(sPropertyName);
                },
                /**
                 * Returns all parameter values of the event.
                 *
                 * @static
                 * @public
                 * @this sapuibaseExtensions
                 * @memberof sapuibaseExtensions
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

    Bridge.define("sapuimodelContextExtensions", {
        $metadata : function () { return {"att":1048961,"a":2,"s":true,"m":[{"a":2,"n":"getPropertyFor","is":true,"t":8,"pi":[{"n":"context","pt":sap.ui.model.Context$1(System.Object),"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":2}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getPropertyFor","rt":System.Object,"p":[sap.ui.model.Context$1(System.Object),System.Object,System.Boolean]}]}; },
        statics: {
            methods: {
                /**
                 * Gets the property with the given relative binding path
                 *
                 * @static
                 * @public
                 * @this sapuimodelContextExtensions
                 * @memberof sapuimodelContextExtensions
                 * @param   {Function}                  TModel            
                 * @param   {Function}                  TValue            
                 * @param   {sap.ui.model.Context$1}    context           the context to extend
                 * @param   {System.Object}             pathExpression    the binding path
                 * @param   {boolean}                   absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                      the property value
                 */
                getPropertyFor: function (TModel, TValue, context, pathExpression, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, ExpressionEvaluator.GetPath(Bridge.global.Function, pathExpression));
                    return context.getProperty(sPropertyName);
                }
            }
        }
    });

    Bridge.define("sapuimodelModelExtensions", {
        $metadata : function () { return {"att":1048961,"a":2,"s":true,"m":[{"a":2,"n":"getOriginalPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model$1(System.Object),"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":2}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getOriginalPropertyFor","rt":System.Object,"p":[sap.ui.model.Model$1(System.Object),System.Object,System.Boolean]},{"a":2,"n":"getOriginalPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model$1(System.Object),"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"oContext","pt":sap.ui.model.Context,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getOriginalPropertyFor$1","rt":System.Object,"p":[sap.ui.model.Model$1(System.Object),System.Object,sap.ui.model.Context,System.Boolean]},{"a":2,"n":"getPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model$1(System.Object),"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":2}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getPropertyFor","rt":System.Object,"p":[sap.ui.model.Model$1(System.Object),System.Object,System.Boolean]},{"a":2,"n":"getPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model$1(System.Object),"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"oContext","pt":sap.ui.model.Context,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"getPropertyFor$1","rt":System.Object,"p":[sap.ui.model.Model$1(System.Object),System.Object,sap.ui.model.Context,System.Boolean]},{"a":2,"n":"setPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model$1(System.Object),"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":3}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyFor","rt":System.Boolean,"p":[sap.ui.model.Model$1(System.Object),System.Object,System.Object,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":2,"n":"setPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model$1(System.Object),"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"oContext","pt":sap.ui.model.Context,"ps":3},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":4}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyFor$1","rt":System.Boolean,"p":[sap.ui.model.Model$1(System.Object),System.Object,System.Object,sap.ui.model.Context,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":2,"n":"setPropertyFor","is":true,"t":8,"pi":[{"n":"model","pt":sap.ui.model.Model$1(System.Object),"ps":0},{"n":"pathExpression","pt":System.Object,"ps":1},{"n":"value","pt":System.Object,"ps":2},{"n":"oContext","pt":sap.ui.model.Context,"ps":3},{"n":"bAsyncUpdate","pt":System.Boolean,"ps":4},{"n":"absolutePath","dv":true,"o":true,"pt":System.Boolean,"ps":5}],"tpc":2,"tprm":["TModel","TValue"],"sn":"setPropertyFor$2","rt":System.Boolean,"p":[sap.ui.model.Model$1(System.Object),System.Object,System.Object,sap.ui.model.Context,System.Boolean,System.Boolean],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}}]}; },
        statics: {
            methods: {
                /**
                 * Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
                 *
                 * @static
                 * @public
                 * @this sapuimodelModelExtensions
                 * @memberof sapuimodelModelExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Model$1}    model             the model to extend
                 * @param   {System.Object}           pathExpression    the path/name of the property
                 * @param   {sap.ui.model.Context}    oContext          the context if available to access the property value
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                    Value the value of the property
                 */
                getOriginalPropertyFor$1: function (TModel, TValue, model, pathExpression, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, ExpressionEvaluator.GetPath(Bridge.global.Function, pathExpression));
                    return model.getOriginalProperty(sPropertyName, oContext);
                },
                /**
                 * Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
                 *
                 * @static
                 * @public
                 * @this sapuimodelModelExtensions
                 * @memberof sapuimodelModelExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Model$1}    model             the model to extend
                 * @param   {System.Object}           pathExpression    the path/name of the property
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                    Value the value of the property
                 */
                getOriginalPropertyFor: function (TModel, TValue, model, pathExpression, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, ExpressionEvaluator.GetPath(Bridge.global.Function, pathExpression));
                    return model.getOriginalProperty(sPropertyName);
                },
                /**
                 * Implement in inheriting classes
                 *
                 * @static
                 * @public
                 * @this sapuimodelModelExtensions
                 * @memberof sapuimodelModelExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Model$1}    model             the model to extend
                 * @param   {System.Object}           pathExpression    the path to where to read the attribute value
                 * @param   {sap.ui.model.Context}    oContext          the context with which the path should be resolved
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                    Returns the value for the property with the given sPropertyName
                 */
                getPropertyFor$1: function (TModel, TValue, model, pathExpression, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, ExpressionEvaluator.GetPath(Bridge.global.Function, pathExpression));
                    return model.getProperty(sPropertyName, oContext);
                },
                /**
                 * Implement in inheriting classes
                 *
                 * @static
                 * @public
                 * @this sapuimodelModelExtensions
                 * @memberof sapuimodelModelExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Model$1}    model             the model to extend
                 * @param   {System.Object}           pathExpression    the path to where to read the attribute value
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {TValue}                                    Returns the value for the property with the given sPropertyName
                 */
                getPropertyFor: function (TModel, TValue, model, pathExpression, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, ExpressionEvaluator.GetPath(Bridge.global.Function, pathExpression));
                    return model.getProperty(sPropertyName);
                },
                /**
                 * Sets a new value for the given property <pre><code>sPropertyName</code></pre> in the model. If the model value changed all interested parties are informed.
                 *
                 * @static
                 * @public
                 * @this sapuimodelModelExtensions
                 * @memberof sapuimodelModelExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Model$1}    model             the model to extend
                 * @param   {System.Object}           pathExpression    path of the property to set
                 * @param   {TValue}                  value             value to set the property to
                 * @param   {sap.ui.model.Context}    oContext          the context which will be used to set the property
                 * @param   {boolean}                 bAsyncUpdate      whether to update other bindings dependent on this property asynchronously
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {boolean}                                   true if the value was set correctly and false if errors occurred like the entry was not found.
                 */
                setPropertyFor$2: function (TModel, TValue, model, pathExpression, value, oContext, bAsyncUpdate, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, ExpressionEvaluator.GetPath(Bridge.global.Function, pathExpression));
                    return model.setProperty(sPropertyName, value, oContext, bAsyncUpdate);
                },
                /**
                 * Sets a new value for the given property <pre><code>sPropertyName</code></pre> in the model. If the model value changed all interested parties are informed.
                 *
                 * @static
                 * @public
                 * @this sapuimodelModelExtensions
                 * @memberof sapuimodelModelExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Model$1}    model             the model to extend
                 * @param   {System.Object}           pathExpression    path of the property to set
                 * @param   {TValue}                  value             value to set the property to
                 * @param   {sap.ui.model.Context}    oContext          the context which will be used to set the property
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {boolean}                                   true if the value was set correctly and false if errors occurred like the entry was not found.
                 */
                setPropertyFor$1: function (TModel, TValue, model, pathExpression, value, oContext, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, ExpressionEvaluator.GetPath(Bridge.global.Function, pathExpression));
                    return model.setProperty(sPropertyName, value, oContext);
                },
                /**
                 * Sets a new value for the given property <pre><code>sPropertyName</code></pre> in the model. If the model value changed all interested parties are informed.
                 *
                 * @static
                 * @public
                 * @this sapuimodelModelExtensions
                 * @memberof sapuimodelModelExtensions
                 * @param   {Function}                TModel            
                 * @param   {Function}                TValue            
                 * @param   {sap.ui.model.Model$1}    model             the model to extend
                 * @param   {System.Object}           pathExpression    path of the property to set
                 * @param   {TValue}                  value             value to set the property to
                 * @param   {boolean}                 absolutePath      true if the generated path should be absolute; false otherwise
                 * @return  {boolean}                                   true if the value was set correctly and false if errors occurred like the entry was not found.
                 */
                setPropertyFor: function (TModel, TValue, model, pathExpression, value, absolutePath) {
                    if (absolutePath === void 0) { absolutePath = true; }
                    var pref = absolutePath ? "/" : "";
                    var sPropertyName = System.String.format("{0}{1}", pref, ExpressionEvaluator.GetPath(Bridge.global.Function, pathExpression));
                    return model.setProperty(sPropertyName, value);
                }
            }
        }
    });

    Bridge.define("Glue", {
        $metadata : function () { return {"att":1048961,"a":2,"s":true,"m":[{"a":2,"n":"CreateRawClassObject","is":true,"t":8,"pi":[{"n":"metadata","dv":null,"o":true,"pt":System.Object,"ps":0},{"n":"renderer","dv":null,"o":true,"pt":System.Object,"ps":1},{"n":"ctorParamTypes","dv":null,"o":true,"pt":System.Array.type(Function),"ps":2}],"tpc":1,"tprm":["T"],"sn":"CreateRawClassObject","rt":System.Object,"p":[System.Object,System.Object,System.Array.type(Function)]},{"a":2,"n":"GetDefaultValue","is":true,"t":8,"pi":[{"n":"type","pt":Function,"ps":0}],"sn":"GetDefaultValue","rt":System.Object,"p":[Function]},{"a":2,"n":"IsNullOrUndefined","is":true,"t":8,"pi":[{"n":"val","pt":System.Object,"ps":0}],"sn":"IsNullOrUndefined","rt":System.Boolean,"p":[System.Object],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":2,"n":"ToBoolean","is":true,"t":8,"pi":[{"n":"val","pt":System.Object,"ps":0}],"sn":"ToBoolean","rt":System.Boolean,"p":[System.Object],"box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}}]}; },
        statics: {
            methods: {
                /**
                 * Checks if the value passed is null of undefined
                 *
                 * @static
                 * @public
                 * @this Glue
                 * @memberof Glue
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
                 * @this Glue
                 * @memberof Glue
                 * @param   {System.Object}    val    the value
                 * @return  {boolean}                 true if val or can be converted to a boolean; false otherwise
                 */
                ToBoolean: function (val) {
                    if (Glue.IsNullOrUndefined(val)) {
                        return false;
                    }

                    if (Bridge.is(val, System.String)) {
                        return Bridge.referenceEquals(Bridge.cast(val, System.String), "true");
                    }

                    return !!val;
                },
                GetDefaultValue: function (type) {
                    var output = null;

                    if (Bridge.Reflection.isValueType(type)) {
                        output = Bridge.createInstance(type);
                    }

                    return output;
                },
                CreateRawClassObject: function (T, metadata, renderer, ctorParamTypes) {
                    var $t, $t1;
                    if (metadata === void 0) { metadata = null; }
                    if (renderer === void 0) { renderer = null; }
                    if (ctorParamTypes === void 0) { ctorParamTypes = null; }
                    var type = T;
                    var obj = { };

                    // adds the metadata if present
                    if (metadata != null) {
                        obj.metadata = metadata;
                    }

                    // adds the renderer if present
                    if (renderer != null) {
                        obj.renderer = renderer;
                    }

                    var $constructor = null;

                    // if there is no constructor specified, gets the one and only constructor
                    if (ctorParamTypes == null) {
                        $constructor = System.Linq.Enumerable.from(Bridge.Reflection.getMembers(type, 1, 28)).single();
                    } else {
                        // otherwise, find a matching constructor
                        $constructor = Bridge.Reflection.getMembers(type, 1, 284, null, ctorParamTypes);
                        if ($constructor == null) {
                            throw new System.InvalidOperationException.$ctor1(System.String.format("Error, there is no constructor with parameter type(s) {0} for type {1}", Bridge.toArray(System.Linq.Enumerable.from(ctorParamTypes).select(function (t) {
                                            return Bridge.Reflection.getTypeFullName(t);
                                        })).join(", "), Bridge.Reflection.getTypeFullName(type)));
                        }
                    }

                    // copies non static fields
                    $t = Bridge.getEnumerator(System.Linq.Enumerable.from(Bridge.Reflection.getMembers(type, 4, 28)).where(function (f) {
                            return !(f.is || false);
                        }));
                    try {
                        while ($t.moveNext()) {
                            var field = $t.Current;
                            obj[field.sn] = Glue.GetDefaultValue(field.rt);
                        }
                    } finally {
                        if (Bridge.is($t, System.IDisposable)) {
                            $t.System$IDisposable$Dispose();
                        }
                    };

                    // copies non static methods
                    $t1 = Bridge.getEnumerator(System.Linq.Enumerable.from(Bridge.Reflection.getMembers(type, 8, 28)).where(function (m) {
                            return !(m.is || false);
                        }));
                    try {
                        while ($t1.moveNext()) {
                            var method = $t1.Current;
                            obj[method.sn] = method.td.prototype[method.sn];
                        }
                    } finally {
                        if (Bridge.is($t1, System.IDisposable)) {
                            $t1.System$IDisposable$Dispose();
                        }
                    };

                    // adds the constructor if present
                    if ($constructor != null) {
                        obj.constructor = $constructor.td.prototype[$constructor.sn];
                        obj.$initialize = function () { };
                    }

                    return obj;
                }
            }
        }
    });

    Bridge.define("TypedMetadata", {
        $metadata : function () { return {"att":1048961,"a":2,"s":true,"m":[{"a":2,"n":"CreateUI5EventInfo","is":true,"t":8,"tpc":1,"tprm":["T"],"sn":"CreateUI5EventInfo","rt":System.Object},{"a":2,"n":"GetUI5Type","is":true,"t":8,"pi":[{"n":"fieldType","pt":Function,"ps":0}],"sn":"GetUI5Type","rt":System.String,"p":[Function]}]}; },
        statics: {
            methods: {
                CreateUI5EventInfo: function (T) {
                    var $t;
                    var paramDict = { };

                    // copies non static fields
                    // TODO: nested fields
                    $t = Bridge.getEnumerator(System.Linq.Enumerable.from(Bridge.Reflection.getMembers(T, 4, 28)).where(function (f) {
                            return !(f.is || false);
                        }));
                    try {
                        while ($t.moveNext()) {
                            var field = $t.Current;
                            paramDict[field.sn] = { type: TypedMetadata.GetUI5Type(field.rt) };
                        }
                    } finally {
                        if (Bridge.is($t, System.IDisposable)) {
                            $t.System$IDisposable$Dispose();
                        }
                    };

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
                        // TODO: log
                    }

                    return result;
                }
            }
        }
    });
});
