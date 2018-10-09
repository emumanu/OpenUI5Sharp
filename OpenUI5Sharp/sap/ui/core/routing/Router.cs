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
					[Name("sap.ui.core.routing.Router")]
					public partial class Router : sap.ui.@base.EventProvider
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class BypassedInfo
						{
							/// <summary>
							/// the current URL hash which did not match any route
							/// </summary>
							public string hash;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class TitleChangedInfo
						{
							/// <summary>
							/// The current displayed title
							/// </summary>
							public string title;

							/// <summary>
							/// An array which contains the history of previous titles
							/// </summary>
							public object[] history;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class RouterConfig
						{
							/// <summary>
							/// @since 1.34. Whether the views which are loaded within this router instance asyncly. The default value is set to false.
							/// </summary>
							public bool async;

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
							/// The type of the view that is going to be created. These are the supported types: {@link sap.ui.core.mvc.ViewType}. You always have to provide a viewType except if you are using {@link sap.ui.core.routing.Views#setView}.
							/// </summary>
							public string viewType;

							/// <summary>
							/// A prefix that will be prepended in front of the viewName.<br/> <b>Example:</b> viewName is set to "myView" and viewPath is set to "myApp" - the created viewName will be "myApp.myView".
							/// </summary>
							public string viewPath;

							/// <summary>
							/// The id of the created view. This is will be prefixed with the id of the component set to the views instance provided in oOptions.views. For details see {@link sap.ui.core.routing.Views#getView}.
							/// </summary>
							public string viewId;

							/// <summary>
							/// The id of the parent of the controlId - This should be the id of the view that contains your controlId, since the target control will be retrieved by calling the {@link sap.ui.core.mvc.View#byId} function of the targetParent. By default, this will be the view created by a component, so you do not have to provide this parameter. If you are using children, the view created by the parent of the child is taken. You only need to specify this, if you are not using a Targets instance created by a component and you should give the id of root view of your application to this property.
							/// </summary>
							public string targetParent;

							/// <summary>
							/// The id of the control where you want to place the view created by this target. The view of the target will be put into this container Control, using the controlAggregation property. You have to specify both properties or the target will not be able to place itself. An example for containers are {@link sap.ui.ux3.Shell} with the aggregation 'content' or a {@link sap.m.NavContainer} with the aggregation 'pages'.
							/// </summary>
							public string controlId;

							/// <summary>
							/// The name of an aggregation of the controlId, that contains views. Eg: a {@link sap.m.NavContainer} has an aggregation 'pages', another Example is the {@link sap.ui.ux3.Shell} it has 'content'.
							/// </summary>
							public string controlAggregation;

							/// <summary>
							/// Defines a boolean that can be passed to specify if the aggregation should be cleared - all items will be removed - before adding the View to it. When using a {@link sap.ui.ux3.Shell} this should be true. For a {@link sap.m.NavContainer} it should be false. When you use the {@link sap.m.routing.Router} the default will be false.
							/// </summary>
							public bool clearControlAggregation;

							/// <summary>
							/// A reference to another target, using the name of the target. If you display a target that has a parent, the parent will also be displayed. Also the control you specify with the controlId parameter, will be searched inside of the view of the parent not in the rootView, provided in the config. The control will be searched using the byId function of a view. When it is not found, the global id is checked. <br/> The main usecase for the parent property is placing a view inside a smaller container of a view, which is also created by targets. This is useful for lazy loading views, only if the user really navigates to this part of your application. <br/> <b>Example:</b> Our aim is to lazy load a tab of an IconTabBar (a control that displays a view initially and when a user clicks on it the view changes). It's a perfect candidate to lazy load something inside of it. <br/> <b>Example app structure:</b><br/> We have a rootView that is returned by the createContent function of our UIComponent. This view contains an sap.m.App control with the id 'myApp' <pre>
							/// <code>
							/// &lt;View xmlns="sap.m"&gt;
							///     &lt;App id="myApp"/&gt;
							/// &lt;/View&gt;
							/// </code>
							/// </pre> an xml view called 'Detail' <pre>
							/// <code>
							/// &lt;View xmlns="sap.m"&gt;
							///     &lt;IconTabBar&gt;
							///         &lt;items&gt;
							///             &lt;IconTabFilter&gt;
							///                 &lt;!-- content of our first tab --&gt;
							///             &lt;IconTabFilter&gt;
							///             &lt;IconTabFilter id="mySecondTab"&gt;
							///                 &lt;!-- nothing here, since we will lazy load this one with a target --&gt;
							///             &lt;IconTabFilter&gt;
							///         &lt;/items&gt;
							///     &lt;/IconTabBar&gt;
							/// &lt;/View&gt;
							/// </code>
							/// </pre> and a view called 'SecondTabContent', this one contains our content we want to have lazy loaded. Now we need to create our Targets instance with a config matching our app: <pre>
							/// <code>
							///     new Targets({
							///         //Creates our views except for root, we created this one before - when using a component you
							///         views: new Views(),
							///         config: {
							///             // all of our views have that type
							///             viewType: 'XML',
							///             // a reference to the app control in the rootView created by our UIComponent
							///             controlId: 'myApp',
							///             // An app has a pages aggregation where the views need to be put into
							///             controlAggregation: 'pages'
							///         },
							///         targets: {
							///             detail: {
							///                 viewName: 'Detail'
							///             },
							///             secondTabContent: {
							///                 // A reference to the detail target defined above
							///                 parent: 'detail',
							///                 // A reference to the second Tab container in the Detail view. Here the target does not look in the rootView, it looks in the Parent view (Detail).
							///                 controlId: 'mySecondTab',
							///                 // An IconTabFilter has an aggregation called content so we need to overwrite the pages set in the config as default.
							///                 controlAggregation: 'content',
							///                 // A view containing the content
							///                 viewName: 'SecondTabContent'
							///             }
							///         }
							///     });
							/// </code>
							/// </pre>
							/// 
							/// Now if we call <code> oTargets.display("secondTabContent") </code>, 2 views will be created: Detail and SecondTabContent. The 'Detail' view will be put into the pages aggregation of the App. And afterwards the 'SecondTabContent' view will be put into the content Aggregation of the second IconTabFilter. So a parent will always be created before the target referencing it.
							/// </summary>
							public string parent;

						}

						#endregion

						#region Delegates

						public delegate void BypassedDelegate(sap.ui.@base.Event<sap.ui.core.routing.Router.BypassedInfo> oEvent, object oData);

						public delegate void TitleChangedDelegate(sap.ui.@base.Event<sap.ui.core.routing.Router.TitleChangedInfo> oEvent, object oData);

						#endregion

						#region Constructor

						/// <summary>
						/// Instantiates a SAPUI5 Router
						/// </summary>
						/// <param name="oRoutes">may contain many Route configurations as {@link sap.ui.core.routing.Route#constructor}.<br/> Each of the routes contained in the array/object will be added to the router.<br/>
						/// 
						/// One way of defining routes is an array: <pre>
						/// [
						///     //Will create a route called 'firstRouter' you can later use this name in navTo to navigate to this route
						///     {
						///         name: "firstRoute"
						///         pattern : "usefulPattern"
						///     },
						///     //Will create a route called 'anotherRoute'
						///     {
						///         name: "anotherRoute"
						///         pattern : "anotherPattern"
						///     }
						/// ]
						/// </pre>
						/// 
						/// The alternative way of defining routes is an Object. If you choose this way, the name attribute is the name of the property. <pre>
						/// {
						///     //Will create a route called 'firstRouter' you can later use this name in navTo to navigate to this route
						///     firstRoute : {
						///         pattern : "usefulPattern"
						///     },
						///     //Will create a route called 'anotherRoute'
						///     anotherRoute : {
						///         pattern : "anotherPattern"
						///     }
						/// }
						/// </pre> The values that may be provided are the same as in {@link sap.ui.core.routing.Route#constructor}</param>
						/// <param name="oConfig">Default values for route configuration - also takes the same parameters as {@link sap.ui.core.routing.Target#constructor}.<br/> This config will be used for routes and for targets, used in the router<br/> Eg: if the config object specifies : <pre>
						/// <code>
						/// {
						///     viewType : "XML"
						/// }
						/// </code>
						/// </pre> The targets look like this: <pre>
						/// {
						///     xmlTarget : {
						///         ...
						///     },
						///     jsTarget : {
						///         viewType : "JS"
						///         ...
						///     }
						/// }
						/// </pre> Then the effective config will look like this: <pre>
						/// {
						///     xmlTarget : {
						///         viewType : "XML"
						///         ...
						///     },
						///     jsTarget : {
						///         viewType : "JS"
						///         ...
						///     }
						/// }
						/// </pre>
						/// 
						/// Since the xmlTarget does not specify its viewType, XML is taken from the config object. The jsTarget is specifying it, so the viewType will be JS.</param>
						/// <param name="oOwner">the Component of all the views that will be created by this Router,<br/> will get forwarded to the {@link sap.ui.core.routing.Views#constructor}.<br/> If you are using the componentMetadata to define your routes you should skip this parameter.</param>
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
						public extern Router(Union<sap.ui.core.routing.Route.RouteConfig, sap.ui.core.routing.Route.RouteConfig[]> oRoutes, sap.ui.core.routing.Router.RouterConfig oConfig, sap.ui.core.UIComponent oOwner, Map<sap.ui.core.routing.Targets.TargetInfo> oTargetsConfig);

						/// <summary>
						/// Instantiates a SAPUI5 Router
						/// </summary>
						/// <param name="oConfig">Default values for route configuration - also takes the same parameters as {@link sap.ui.core.routing.Target#constructor}.<br/> This config will be used for routes and for targets, used in the router<br/> Eg: if the config object specifies : <pre>
						/// <code>
						/// {
						///     viewType : "XML"
						/// }
						/// </code>
						/// </pre> The targets look like this: <pre>
						/// {
						///     xmlTarget : {
						///         ...
						///     },
						///     jsTarget : {
						///         viewType : "JS"
						///         ...
						///     }
						/// }
						/// </pre> Then the effective config will look like this: <pre>
						/// {
						///     xmlTarget : {
						///         viewType : "XML"
						///         ...
						///     },
						///     jsTarget : {
						///         viewType : "JS"
						///         ...
						///     }
						/// }
						/// </pre>
						/// 
						/// Since the xmlTarget does not specify its viewType, XML is taken from the config object. The jsTarget is specifying it, so the viewType will be JS.</param>
						/// <param name="oOwner">the Component of all the views that will be created by this Router,<br/> will get forwarded to the {@link sap.ui.core.routing.Views#constructor}.<br/> If you are using the componentMetadata to define your routes you should skip this parameter.</param>
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
						public extern Router(sap.ui.core.routing.Router.RouterConfig oConfig, sap.ui.core.UIComponent oOwner, Map<sap.ui.core.routing.Targets.TargetInfo> oTargetsConfig);

						/// <summary>
						/// Instantiates a SAPUI5 Router
						/// </summary>
						/// <param name="oOwner">the Component of all the views that will be created by this Router,<br/> will get forwarded to the {@link sap.ui.core.routing.Views#constructor}.<br/> If you are using the componentMetadata to define your routes you should skip this parameter.</param>
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
						public extern Router(sap.ui.core.UIComponent oOwner, Map<sap.ui.core.routing.Targets.TargetInfo> oTargetsConfig);

						/// <summary>
						/// Instantiates a SAPUI5 Router
						/// </summary>
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
						public extern Router(Map<sap.ui.core.routing.Targets.TargetInfo> oTargetsConfig);

						#endregion

						#region Methods

						#region Methods for event beforeRouteMatched

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'beforeRouteMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this router is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachBeforeRouteMatched(object oData, sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'beforeRouteMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachBeforeRouteMatched(object oData, sap.ui.core.routing.Route.MatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'beforeRouteMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachBeforeRouteMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'beforeRouteMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this router is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachBeforeRouteMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'beforeRouteMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router detachBeforeRouteMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Fire event beforeRouteMatched to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router fireBeforeRouteMatched(sap.ui.core.routing.Route.MatchedInfo mArguments);

						/// <summary>
						/// Fire event beforeRouteMatched to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router fireBeforeRouteMatched();

						#endregion

						#region Methods for event bypassed

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'bypassed' event of this <code>sap.ui.core.routing.Router</code>.<br/> The event will get fired, if none of the routes of the routes is matching. <br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this router is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachBypassed(object oData, sap.ui.core.routing.Router.BypassedDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'bypassed' event of this <code>sap.ui.core.routing.Router</code>.<br/> The event will get fired, if none of the routes of the routes is matching. <br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachBypassed(object oData, sap.ui.core.routing.Router.BypassedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'bypassed' event of this <code>sap.ui.core.routing.Router</code>.<br/> The event will get fired, if none of the routes of the routes is matching. <br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachBypassed(sap.ui.core.routing.Router.BypassedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'bypassed' event of this <code>sap.ui.core.routing.Router</code>.<br/> The event will get fired, if none of the routes of the routes is matching. <br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this router is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachBypassed(sap.ui.core.routing.Router.BypassedDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'bypassed' event of this <code>sap.ui.core.routing.Router</code>.<br/> The event will get fired, if none of the routes of the routes is matching. <br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router detachBypassed(sap.ui.core.routing.Router.BypassedDelegate fnFunction, object oListener);

						/// <summary>
						/// Fire event bypassed to attached listeners. The event will get fired, if none of the routes of the routes is matching. <br/>
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router fireBypassed(sap.ui.core.routing.Router.BypassedInfo mArguments);

						/// <summary>
						/// Fire event bypassed to attached listeners. The event will get fired, if none of the routes of the routes is matching. <br/>
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router fireBypassed();

						#endregion

						#region Methods for event routeMatched

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'routeMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this router is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachRouteMatched(object oData, sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'routeMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachRouteMatched(object oData, sap.ui.core.routing.Route.MatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'routeMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachRouteMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'routeMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this router is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachRouteMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'routeMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router detachRouteMatched(sap.ui.core.routing.Route.MatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Fire event routeMatched to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router fireRouteMatched(sap.ui.core.routing.Route.MatchedInfo mArguments);

						/// <summary>
						/// Fire event routeMatched to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router fireRouteMatched();

						#endregion

						#region Methods for event routePatternMatched

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'routePatternMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/> This event is similar to route matched. But it will only fire for the route that has a matching pattern, not for its parent Routes <br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this router is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachRoutePatternMatched(object oData, sap.ui.core.routing.Route.PatternMatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'routePatternMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/> This event is similar to route matched. But it will only fire for the route that has a matching pattern, not for its parent Routes <br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachRoutePatternMatched(object oData, sap.ui.core.routing.Route.PatternMatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'routePatternMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/> This event is similar to route matched. But it will only fire for the route that has a matching pattern, not for its parent Routes <br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachRoutePatternMatched(sap.ui.core.routing.Route.PatternMatchedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'routePatternMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/> This event is similar to route matched. But it will only fire for the route that has a matching pattern, not for its parent Routes <br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this router is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachRoutePatternMatched(sap.ui.core.routing.Route.PatternMatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'routePatternMatched' event of this <code>sap.ui.core.routing.Router</code>.<br/> This event is similar to route matched. But it will only fire for the route that has a matching pattern, not for its parent Routes <br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router detachRoutePatternMatched(sap.ui.core.routing.Route.PatternMatchedDelegate fnFunction, object oListener);

						/// <summary>
						/// Fire event routePatternMatched to attached listeners. This event is similar to route matched. But it will only fire for the route that has a matching pattern, not for its parent Routes <br/>
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router fireRoutePatternMatched(sap.ui.core.routing.Route.PatternMatchedInfo mArguments);

						/// <summary>
						/// Fire event routePatternMatched to attached listeners. This event is similar to route matched. But it will only fire for the route that has a matching pattern, not for its parent Routes <br/>
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router fireRoutePatternMatched();

						#endregion

						#region Methods for event titleChanged

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'titleChanged' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachTitleChanged(object oData, sap.ui.core.routing.Router.TitleChangedDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'titleChanged' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachTitleChanged(object oData, sap.ui.core.routing.Router.TitleChangedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'titleChanged' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachTitleChanged(sap.ui.core.routing.Router.TitleChangedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'titleChanged' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router attachTitleChanged(sap.ui.core.routing.Router.TitleChangedDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'titleChanged' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Router detachTitleChanged(sap.ui.core.routing.Router.TitleChangedDelegate fnFunction, object oListener);

						#endregion

						#region Other methods

						/// <summary>
						/// Adds a route to the router
						/// </summary>
						/// <param name="oConfig">configuration object for the route @see sap.ui.core.routing.Route#constructor</param>
						/// <param name="oParent">The parent route - if a parent route is given, the routeMatched event of this route will also trigger the route matched of the parent and it will also create the view of the parent (if provided).</param>
						public extern virtual void addRoute(object oConfig, sap.ui.core.routing.Route oParent);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'viewCreated' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this router is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						[Obsolete("Deprecated since 1.28. use {@link #getViews} instead.")]
						public extern virtual sap.ui.core.routing.Router attachViewCreated(object oData, object fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'viewCreated' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						[Obsolete("Deprecated since 1.28. use {@link #getViews} instead.")]
						public extern virtual sap.ui.core.routing.Router attachViewCreated(object oData, object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'viewCreated' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						[Obsolete("Deprecated since 1.28. use {@link #getViews} instead.")]
						public extern virtual sap.ui.core.routing.Router attachViewCreated(object fnFunction);

						/// <summary>
						/// Removes the router from the hash changer @see sap.ui.core.routing.HashChanger
						/// </summary>
						/// <returns>this for chaining.</returns>
						public extern virtual sap.ui.core.routing.Router destroy();

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'viewCreated' event of this <code>sap.ui.core.routing.Router</code>.<br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						[Obsolete("Deprecated since 1.28. use {@link #getViews} instead.")]
						public extern virtual sap.ui.core.routing.Router detachViewCreated(object fnFunction, object oListener);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Router with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Router with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Router with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Fire event viewCreated to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						[Obsolete("Deprecated since 1.28. use {@link #getViews} instead.")]
						public extern virtual sap.ui.core.routing.Router fireViewCreated(object mArguments);

						/// <summary>
						/// Fire event viewCreated to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						[Obsolete("Deprecated since 1.28. use {@link #getViews} instead.")]
						public extern virtual sap.ui.core.routing.Router fireViewCreated();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.routing.Router.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Returns the Route with a name, if no route is found undefined is returned
						/// </summary>
						/// <param name="sName">Name of the route</param>
						/// <returns>the route with the provided name or undefined.</returns>
						public extern virtual sap.ui.core.routing.Route getRoute(string sName);

						/// <summary>
						/// Get a registered router
						/// </summary>
						/// <param name="sName">Name of the router</param>
						/// <returns>The router with the specified name, else undefined</returns>
						public extern static sap.ui.core.routing.Router getRouter(string sName);

						/// <summary>
						/// Returns the instance of Targets, if you pass a targets config to the router
						/// </summary>
						/// <returns>The instance of targets, the router uses to place views or undefined if you did not specify the targets parameter in the router's constructor.</returns>
						public extern virtual sap.ui.core.routing.Targets getTargets();

						/// <summary>
						/// Returns the title history.
						/// 
						/// History entry example: <code> { title: "TITLE", // The displayed title hash: "HASH" // The url hash isHome: "true/false" // The app home indicator } </code>
						/// </summary>
						/// <returns>An array which contains the history entries.</returns>
						public extern virtual object[] getTitleHistory();

						/// <summary>
						/// Returns the URL for the route and replaces the placeholders with the values in oParameters
						/// </summary>
						/// <param name="sName">Name of the route</param>
						/// <param name="oParameters">Parameters for the route</param>
						/// <returns>the unencoded pattern with interpolated arguments</returns>
						public extern virtual string getURL(string sName, object oParameters);

						/// <summary>
						/// Returns the URL for the route and replaces the placeholders with the values in oParameters
						/// </summary>
						/// <param name="sName">Name of the route</param>
						/// <returns>the unencoded pattern with interpolated arguments</returns>
						public extern virtual string getURL(string sName);

						/// <summary>
						/// Returns a cached view for a given name or creates it if it does not yet exists
						/// </summary>
						/// <param name="sViewName">Name of the view</param>
						/// <param name="sViewType">Type of the view</param>
						/// <param name="sViewId">Optional view id</param>
						/// <returns>the view instance</returns>
						[Obsolete("Deprecated since 1.28.1. use {@link #getViews} instead.")]
						public extern virtual sap.ui.core.mvc.View getView(string sViewName, string sViewType, string sViewId);

						/// <summary>
						/// Returns the views instance created by the router
						/// </summary>
						/// <returns>the Views instance</returns>
						public extern virtual sap.ui.core.routing.Views getViews();

						/// <summary>
						/// Attaches the router to the hash changer @see sap.ui.core.routing.HashChanger
						/// </summary>
						/// <param name="bIgnoreInitialHash">@since 1.48.0 whether the current url hash shouldn't be parsed after the router is initialized</param>
						/// <returns>this for chaining.</returns>
						public extern virtual sap.ui.core.routing.Router initialize(bool bIgnoreInitialHash = false);

						/// <summary>
						/// Navigates to a specific route defining a set of parameters. The Parameters will be URI encoded - the characters ; , / ? : @ & = + $ are reserved and will not be encoded. If you want to use special characters in your oParameters, you have to encode them (encodeURIComponent).
						/// 
						/// IF the given route name can't be found, an error message is logged to the console and the hash will be changed to empty string.
						/// </summary>
						/// <param name="sName">Name of the route</param>
						/// <param name="oParameters">Parameters for the route</param>
						/// <param name="bReplace">If set to <code>true</code>, the hash is replaced, and there will be no entry in the browser history, if set to <code>false</code>, the hash is set and the entry is stored in the browser history.</param>
						/// <returns>this for chaining.</returns>
						public extern virtual sap.ui.core.routing.Router navTo(string sName, object oParameters, bool bReplace = false);

						/// <summary>
						/// Navigates to a specific route defining a set of parameters. The Parameters will be URI encoded - the characters ; , / ? : @ & = + $ are reserved and will not be encoded. If you want to use special characters in your oParameters, you have to encode them (encodeURIComponent).
						/// 
						/// IF the given route name can't be found, an error message is logged to the console and the hash will be changed to empty string.
						/// </summary>
						/// <param name="sName">Name of the route</param>
						/// <param name="oParameters">Parameters for the route</param>
						/// <returns>this for chaining.</returns>
						public extern virtual sap.ui.core.routing.Router navTo(string sName, object oParameters);

						/// <summary>
						/// Navigates to a specific route defining a set of parameters. The Parameters will be URI encoded - the characters ; , / ? : @ & = + $ are reserved and will not be encoded. If you want to use special characters in your oParameters, you have to encode them (encodeURIComponent).
						/// 
						/// IF the given route name can't be found, an error message is logged to the console and the hash will be changed to empty string.
						/// </summary>
						/// <param name="sName">Name of the route</param>
						/// <returns>this for chaining.</returns>
						public extern virtual sap.ui.core.routing.Router navTo(string sName);

						/// <summary>
						/// Will trigger routing events + place targets for routes matching the string
						/// </summary>
						/// <param name="sNewHash">a new hash</param>
						public extern virtual void parse(string sNewHash);

						/// <summary>
						/// Registers the router to access it from another context. Use sap.ui.routing.Router.getRouter() to receive the instance
						/// </summary>
						/// <param name="sName">Name of the router</param>
						public extern virtual void register(string sName);

						/// <summary>
						/// Adds or overwrites a view in the viewcache of the router, the viewname serves as a key
						/// </summary>
						/// <param name="sViewName">Name of the view</param>
						/// <param name="oView">the view instance</param>
						/// <returns>@since 1.28 the this pointer for chaining</returns>
						[Obsolete("Deprecated since 1.28. use {@link #getViews} instead.")]
						public extern virtual sap.ui.core.routing.Router setView(string sViewName, sap.ui.core.mvc.View oView);

						/// <summary>
						/// Stops to listen to the hashChange of the browser.</br> If you want the router to start again, call initialize again.
						/// </summary>
						/// <returns>this for chaining.</returns>
						public extern virtual sap.ui.core.routing.Router stop();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
