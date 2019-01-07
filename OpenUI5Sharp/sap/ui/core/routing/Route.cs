using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				public static partial class routing
				{
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.routing.Route")]
					public partial class Route : sap.ui.@base.EventProvider
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class MatchedInfo
						{
							/// <summary>
							/// The name of the route
							/// </summary>
							public string name;

							/// <summary>
							/// A key-value pair object which contains the arguments defined in the route resolved with the corresponding information from the current URL hash
							/// </summary>
							public object arguments;

							/// <summary>
							/// The configuration object of the route
							/// </summary>
							public object config;

							/// <summary>
							/// The nested route instance of this route. The event is fired on this route because the pattern in the nested route is matched with the current URL hash. This parameter can be used to decide whether the current route is matched because of its nested child route. For more information about nested child route please refer to the documentation of oConfig.parent in {@link sap.ui.core.routing.Route#constructor}
							/// </summary>
							public sap.ui.core.routing.Route nestedRoute;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class PatternMatchedInfo
						{
							/// <summary>
							/// The name of the route
							/// </summary>
							public string name;

							/// <summary>
							/// A key-value pair object which contains the arguments defined in the route resolved with the corresponding information from the current URL hash
							/// </summary>
							public object arguments;

							/// <summary>
							/// The configuration object of the route
							/// </summary>
							public object config;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class RouteConfig
						{
							/// <summary>
							/// the name of the route - it will be used to retrieve the route from the router, it needs to be unique per router instance.</li>
							/// </summary>
							public string name;

							/// <summary>
							/// the url pattern where it needs to match again. A pattern may consist of the following: <ul> <li> hardcoded parts: "pattern" : "product/settings" - this pattern will only match if the hash of the browser is product/settings and no arguments will be passed to the events of the route.</br> </li> <li> mandatory parameters: "pattern" : "product/{id}" - {id} is a mandatory parameter, e. g. the following hashes would match: product/5, product/3. The pattenMatched event will get 5 or 3 passed as id in its arguments.The hash product/ will not match.</br> </li> <li> optional parameters: "pattern" : "product/{id}/detail/:detailId:" - :detailId: is an optional parameter, e. g. the following hashes would match: product/5/detail, product/3/detail/2</br> </li> <li> query parameters: "pattern" : "product{?query}" // {?query} allows you to pass queries with any parameters, e. g. the following hashes would match: product?first=firstValue, product?first=firstValue&second=secondValue</br> </li> <li> rest as string parameters: "pattern" : ":all*:" - this pattern will define an optional variable that will pass the whole hash as string to the routing events. It may be used to define a catchall route, e. g. the following hashes would match: foo, product/5/3, product/5/detail/3/foo. You can also combine it with the other variables but make sure a variable with a * is the last one.</br> </ul>
							/// </summary>
							public string pattern;

							/// <summary>
							/// @since 1.27: default: false - By default only the first route matching the hash, will fire events. If greedy is turned on for a route its events will be fired even if another route has already matched.
							/// </summary>
							public bool greedy;

							/// <summary>
							/// @since 1.32 This property contains the information about the route which nests this route in the form: "[componentName:]routeName". The nesting routes pattern will be prefixed to this routes pattern and hence the nesting route also matches if this one matches.
							/// </summary>
							public string parent;

							/// <summary>
							/// one or multiple name of targets {@link sap.ui.core.routing.Targets}. As soon as the route matches, the target will be displayed. All the deprecated parameters are ignored, if a target is used.
							/// </summary>
							public Union<string, string[]> target;

							/// <summary>
							/// @deprecated since 1.28 - use target.viewName. The name of a view that will be created, the first time this route will be matched. To place the view into a Control use the targetAggregation and targetControl. Views will only be created once per Router.</li>
							/// </summary>
							public string view;

							/// <summary>
							/// @deprecated since 1.28 - use target.viewType. The type of the view that is going to be created. eg: "XML", "JS"</li>
							/// </summary>
							public string viewType;

							/// <summary>
							/// @deprecated since 1.28 - use target.viewPath. A prefix that will be prepended in front of the view eg: view is set to "myView" and viewPath is set to "myApp" - the created view will be "myApp.myView".</li>
							/// </summary>
							public string viewPath;

							/// <summary>
							/// @deprecated since 1.28 - use config.rootView (only available in the config). the id of the parent of the targetControl - This should be the id view your targetControl is located in. By default, this will be the view created by a component, or if the Route is a subroute the view of the parent route is taken. You only need to specify this, if you are not using a router created by a component on your top level routes.</li>
							/// </summary>
							public string targetParent;

							/// <summary>
							/// @deprecated since 1.28 - use target.controlId. Views will be put into a container Control, this might be a {@link sap.ui.ux3.Shell} control or a {@link sap.m.NavContainer} if working with mobile, or any other container. The id of this control has to be put in here.</li>
							/// </summary>
							public string targetControl;

							/// <summary>
							/// @deprecated since 1.28 - use target.controlAggregation. The name of an aggregation of the targetControl, that contains views. Eg: a {@link sap.m.NavContainer} has an aggregation "pages", another Example is the {@link sap.ui.ux3.Shell} it has "content".</li>
							/// </summary>
							public string targetAggregation;

							/// <summary>
							/// @deprecated since 1.28 - use target.clearControlAggregation. Default is false. Defines a boolean that can be passed to specify if the aggregation should be cleared before adding the View to it. When using a {@link sap.ui.ux3.Shell} this should be true. For a {@link sap.m.NavContainer} it should be false.</li>
							/// </summary>
							public bool clearTarget;

							/// <summary>
							/// @deprecated since 1.28 - use targets.parent. one or multiple routeconfigs taking all of these parameters again. If a subroute is hit, it will fire tge routeMatched event for all its parents. The routePatternMatched event will only be fired for the subroute not the parents. The routing will also display all the targets of the subroutes and its parents.
							/// </summary>
							public object subroutes;

						}

						#endregion

						#region Delegates

						public delegate void MatchedDelegate(sap.ui.@base.Event<sap.ui.core.routing.Route.MatchedInfo> oEvent, object oData);

						public delegate void PatternMatchedDelegate(sap.ui.@base.Event<sap.ui.core.routing.Route.PatternMatchedInfo> oEvent, object oData);

						#endregion

						#region Constructor

						/// <summary>
						/// Instantiates an SAPUI5 Route
						/// </summary>
						/// <param name="The">router instance, the route will be added to.</param>
						/// <param name="oConfig">configuration object for the route</param>
						/// <param name="oParent">The parent route - if a parent route is given, the routeMatched event of this route will also trigger the route matched of the parent and it will also create the view of the parent(if provided).</param>
						public extern Route(sap.ui.core.routing.Router The, sap.ui.core.routing.Route.RouteConfig oConfig, sap.ui.core.routing.Route oParent);

						/// <summary>
						/// Instantiates an SAPUI5 Route
						/// </summary>
						/// <param name="The">router instance, the route will be added to.</param>
						/// <param name="oConfig">configuration object for the route</param>
						public extern Route(sap.ui.core.routing.Router The, sap.ui.core.routing.Route.RouteConfig oConfig);

						#endregion

						#region Methods

						#region Methods for event beforeMatched

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'beforeMatched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this route is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachBeforeMatched(object oData, sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'beforeMatched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachBeforeMatched(object oData, sap.ui.core.routing.Route.MatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'beforeMatched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachBeforeMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'beforeMatched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this route is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachBeforeMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'beforeMatched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route detachBeforeMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Fire event beforeMatched to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router fireBeforeMatched(sap.ui.core.routing.Route.MatchedInfo mArguments);

						/// <summary>
						/// Fire event beforeMatched to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router fireBeforeMatched();

						#endregion

						#region Methods for event matched

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'matched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this route is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachMatched(object oData, sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'matched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachMatched(object oData, sap.ui.core.routing.Route.MatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'matched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'matched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this route is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'matched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route detachMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						#endregion

						#region Methods for event patternMatched

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'patternMatched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this route is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachPatternMatched(object oData, sap.ui.core.routing.Route.PatternMatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'patternMatched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachPatternMatched(object oData, sap.ui.core.routing.Route.PatternMatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'patternMatched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachPatternMatched(sap.ui.core.routing.Route.PatternMatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'patternMatched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this route is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route attachPatternMatched(sap.ui.core.routing.Route.PatternMatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'patternMatched' event of this <code>sap.ui.core.routing.Route</code>.<br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Route detachPatternMatched(sap.ui.core.routing.Route.PatternMatchedDelegate fnFunction, object oListener);

						#endregion

						#region Other methods

						/// <summary>
						/// Destroys a route
						/// </summary>
						/// <returns>this for chaining.</returns>
						public extern virtual sap.ui.core.routing.Route destroy();

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Route with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Route with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Route with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.routing.Route.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Returns the pattern of the route. If there are multiple patterns, the first pattern is returned
						/// </summary>
						/// <returns>the routes pattern</returns>
						public extern virtual string getPattern();

						/// <summary>
						/// Returns the URL for the route and replaces the placeholders with the values in oParameters
						/// </summary>
						/// <param name="oParameters">Parameters for the route</param>
						/// <returns>the unencoded pattern with interpolated arguments</returns>
						public extern virtual string getURL(object oParameters);

						/// <summary>
						/// Returns whether the given hash can be matched by the Route
						/// </summary>
						/// <param name="hash">which will be tested by the Route</param>
						/// <returns>whether the hash can be matched</returns>
						public extern virtual bool match(string hash);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
