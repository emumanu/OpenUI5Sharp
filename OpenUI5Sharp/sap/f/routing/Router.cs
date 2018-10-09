using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class f
		{
			public static partial class routing
			{
				/// <summary>
				/// See {@link sap.ui.core.routing.Router} for the constructor arguments.
				/// 
				/// The <code>sap.f.routing.Router</code> is intended to be used with {@link sap.f.FlexibleColumnLayout} as a root control.
				/// 
				/// The difference to the {@link sap.ui.core.routing.Router} are the properties viewLevel, transition and transitionParameters you can specify in every Route or Target created by this router.
				/// 
				/// Additionally, the <code>layout</code> property can be specified in every Route, in which case it will be applied to the root control.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.f.routing.Router")]
				public partial class Router : sap.ui.core.routing.Router
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class RouterConfig
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

						/// <summary>
						/// The name of a view that will be created. To place the view into a Control use the controlAggregation and controlId. Views will only be created once per viewName. <pre>
						/// <code>
						/// {
						///     targets: {
						///         // If display("masterWelcome") is called, the master view will be placed in the 'MasterPages' of a control with the id splitContainter
						///         masterWelcome: {
						///             viewName: "Welcome",
						///             controlId: "splitContainer",
						///             controlAggregation: "masterPages"
						///         },
						///         // If display("detailWelcome") is called after the masterWelcome, the view will be removed from the master pages and added to the detail pages, since the same instance is used. Also the controls inside of the view will have the same state.
						///         detailWelcome: {
						///             // same view here, that's why the same instance is used
						///             viewName: "Welcome",
						///             controlId: "splitContainer",
						///             controlAggregation: "detailPages"
						///         }
						///     }
						/// }
						/// </code>
						/// </pre>
						/// 
						/// If you want to have a second instance of the welcome view you can use the following:
						/// 
						/// <pre>
						/// <code>
						/// // Some code you execute before you display the taget named 'detailWelcome':
						/// var oView = sap.ui.view(({ viewName : "Welcome", type : sap.ui.core.mvc.ViewType.XML});
						/// oTargets.getViews().setView("WelcomeWithAlias", oView)
						/// 
						/// {
						///     targets: {
						///         // If display("masterWelcome") is called, the master viewName will be placed in the 'MasterPages' of a control with the id splitContainter
						///         masterWelcome: {
						///             viewName: "Welcome",
						///             controlId: "splitContainer",
						///             controlAggregation: "masterPages"
						///         },
						///         // If display("detailWelcome") is called after the masterWelcome, a second instance with an own controller instance will be added in the detail pages.
						///         detailWelcome: {
						///             // same viewName here, that's why the same instance is used
						///             viewName: "WelcomeWithAlias",
						///             controlId: "splitContainer",
						///             controlAggregation: "detailPages"
						///         }
						///     }
						/// }
						/// </code>
						/// </pre>
						/// </summary>
						public string viewName;

						/// <summary>
						/// The id of the created view. This is will be prefixed with the id of the component set to the views instance provided in oOptions.views. For details see {@link sap.ui.core.routing.Views#getView}.
						/// </summary>
						public string viewId;

						/// <summary>
						/// The id of the control where you want to place the view created by this target. The view of the target will be put into this container Control, using the controlAggregation property. You have to specify both properties or the target will not be able to place itself. An example for containers are {@link sap.ui.ux3.Shell} with the aggregation 'content' or a {@link sap.m.NavContainer} with the aggregation 'pages'.
						/// </summary>
						public string controlId;

						/// <summary>
						/// The name of an aggregation of the controlId, that contains views. Eg: a {@link sap.m.NavContainer} has an aggregation 'pages', another Example is the {@link sap.ui.ux3.Shell} it has 'content'.
						/// </summary>
						public string controlAggregation;

						/// <summary>
						/// Defines a boolean that can be passed to specify if the aggregation should be cleared - all items will be removed - before adding the View to it. When using a {@link sap.ui.ux3.Shell} this should be true. For a {@link sap.m.NavContainer} it should be false. When you use the {@link sap.f.routing.Router} the default will be false.
						/// </summary>
						public bool clearControlAggregation;

						/// <summary>
						/// If you are having an application that has a logical order of views (eg: a create account process, first provide user data, then review and confirm them). You always want to show a backwards transition if a navigation from the confirm to the userData page takes place. Therefore you may use the viewLevel. The viewLevel has to be an integer. The user data page should have a lower number than the confirm page. These levels should represent the user process of your application and they do not have to match the container structure of your Targets. If the user navigates between views with the same viewLevel, a forward transition is taken. If you pass a direction into the display function, the viewLevel will be ignored.<br/> <b>Example:</b></br> <pre>
						/// <code>
						///     {
						///         targets: {
						///             startPage: {
						///                 viewLevel: 0
						///                 // more properties
						///             },
						///             userData: {
						///                 viewLevel: 1
						///                 // more properties
						///             },
						///             confirmRegistration: {
						///                 viewLevel: 2
						///                 // more properties
						///             },
						///             settings: {
						///                 //no view level here
						///             }
						///         }
						///     }
						/// </code>
						/// </pre>
						/// 
						/// Currently the 'userData' target is displayed. <ul> <li> If we navigate to 'startPage' the navContainer will show a backwards navigation, since the viewLevel is lower. </li> <li> If we navigate to 'userData' the navContainer will show a forwards navigation, since the viewLevel is higher. </li> <li> If we navigate to 'settings' the navContainer will show a forwards navigation, since the viewLevel is not defined and cannot be compared. </li> </ul>
						/// </summary>
						public int viewLevel;

						/// <summary>
						/// define which transition of the {@link sap.m.NavContainer} will be applied when navigating. If it is not defined, the nav container will take its default transition.
						/// </summary>
						public string transition;

						/// <summary>
						/// define the transitionParameters of the {@link sap.m.NavContainer}
						/// </summary>
						public string transitionParameters;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Instantiates a <code>sap.f.routing.Router</code>.
					/// </summary>
					/// <param name="oRoutes">may contain many Route configurations as {@link sap.ui.core.routing.Route#constructor}.</param>
					/// <param name="oConfig">configuration object for the route</param>
					/// <param name="oOwner">the Component of all the views that will be created by this Router, will get forwarded to the {@link sap.ui.core.routing.Views#constructor}. If you are using the componentMetadata to define your routes you should skip this parameter.</param>
					/// <param name="oTargetsConfig">a new target, the key severs as a name. An example: <pre>
					/// <code>
					/// {
					///     targets: {
					///         welcome: {
					///             viewName: "Welcome",
					///             viewType: "XML",
					///             ....
					///             // Other target parameters
					///         },
					///         goodbye: {
					///             viewName: "Bye",
					///             viewType: "JS",
					///             ....
					///             // Other target parameters
					///         }
					///     }
					/// }
					/// </code>
					/// </pre>
					/// 
					/// This will create two targets named 'welcome' and 'goodbye' you can display both of them or one of them using the {@link #display} function.</param>
					public extern Router(Union<sap.ui.core.routing.Route.RouteConfig, sap.ui.core.routing.Route.RouteConfig[]> oRoutes, sap.f.routing.Router.RouterConfig oConfig, sap.ui.core.UIComponent oOwner, Map<sap.m.RoutingRouterConfig> oTargetsConfig);

					/// <summary>
					/// Instantiates a <code>sap.f.routing.Router</code>.
					/// </summary>
					/// <param name="oConfig">configuration object for the route</param>
					/// <param name="oOwner">the Component of all the views that will be created by this Router, will get forwarded to the {@link sap.ui.core.routing.Views#constructor}. If you are using the componentMetadata to define your routes you should skip this parameter.</param>
					/// <param name="oTargetsConfig">a new target, the key severs as a name. An example: <pre>
					/// <code>
					/// {
					///     targets: {
					///         welcome: {
					///             viewName: "Welcome",
					///             viewType: "XML",
					///             ....
					///             // Other target parameters
					///         },
					///         goodbye: {
					///             viewName: "Bye",
					///             viewType: "JS",
					///             ....
					///             // Other target parameters
					///         }
					///     }
					/// }
					/// </code>
					/// </pre>
					/// 
					/// This will create two targets named 'welcome' and 'goodbye' you can display both of them or one of them using the {@link #display} function.</param>
					public extern Router(sap.f.routing.Router.RouterConfig oConfig, sap.ui.core.UIComponent oOwner, Map<sap.m.RoutingRouterConfig> oTargetsConfig);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.f.routing.Router with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.routing.Router.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.f.routing.Router with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.routing.Router.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.f.routing.Router with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.routing.Router.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.f.routing.Router.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the TargetHandler instance.
					/// </summary>
					/// <returns>the TargetHandler instance</returns>
					public extern virtual sap.f.routing.TargetHandler getTargetHandler();

					#endregion

				}
			}
		}
	}
}
