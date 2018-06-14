using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			public static partial class routing
			{
				[External]
				[Namespace(false)]
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
					/// Instantiates a SAPUI5 mobile Router see {@link sap.ui.core.routing.Router} for the constructor arguments The difference to the {@link sap.ui.core.routing.Router} are the properties viewLevel, transition and transitionParameters you can specify in every Route or Target created by this router.
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
					/// The alternative way of defining routes is an Object.<br/> If you choose this way, the name attribute is the name of the property. <pre>
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
					/// { viewType : "XML" }
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
					/// Since the xmlTarget does not specify its viewType, XML is taken from the config object. The jsTarget is specifying it, so the viewType will be JS.<br/></param>
					/// <param name="oOwner">the Component of all the views that will be created by this Router,<br/> will get forwarded to the {@link sap.ui.core.routing.Views#constructor}.<br/> If you are using the componentMetadata to define your routes you should skip this parameter.<br/></param>
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
					public extern Router(Union<sap.ui.core.routing.Route.RouteConfig, sap.ui.core.routing.Route.RouteConfig[]> oRoutes, sap.m.routing.Router.RouterConfig oConfig, sap.ui.core.UIComponent oOwner, Map<sap.m.routing.Targets.TargetInfo> oTargetsConfig);

					/// <summary>
					/// Instantiates a SAPUI5 mobile Router see {@link sap.ui.core.routing.Router} for the constructor arguments The difference to the {@link sap.ui.core.routing.Router} are the properties viewLevel, transition and transitionParameters you can specify in every Route or Target created by this router.
					/// </summary>
					/// <param name="oConfig">Default values for route configuration - also takes the same parameters as {@link sap.ui.core.routing.Target#constructor}.<br/> This config will be used for routes and for targets, used in the router<br/> Eg: if the config object specifies : <pre>
					/// <code>
					/// { viewType : "XML" }
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
					/// Since the xmlTarget does not specify its viewType, XML is taken from the config object. The jsTarget is specifying it, so the viewType will be JS.<br/></param>
					/// <param name="oOwner">the Component of all the views that will be created by this Router,<br/> will get forwarded to the {@link sap.ui.core.routing.Views#constructor}.<br/> If you are using the componentMetadata to define your routes you should skip this parameter.<br/></param>
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
					public extern Router(sap.m.routing.Router.RouterConfig oConfig, sap.ui.core.UIComponent oOwner, Map<sap.m.routing.Targets.TargetInfo> oTargetsConfig);

					/// <summary>
					/// Instantiates a SAPUI5 mobile Router see {@link sap.ui.core.routing.Router} for the constructor arguments The difference to the {@link sap.ui.core.routing.Router} are the properties viewLevel, transition and transitionParameters you can specify in every Route or Target created by this router.
					/// </summary>
					/// <param name="oOwner">the Component of all the views that will be created by this Router,<br/> will get forwarded to the {@link sap.ui.core.routing.Views#constructor}.<br/> If you are using the componentMetadata to define your routes you should skip this parameter.<br/></param>
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
					public extern Router(sap.ui.core.UIComponent oOwner, Map<sap.m.routing.Targets.TargetInfo> oTargetsConfig);

					/// <summary>
					/// Instantiates a SAPUI5 mobile Router see {@link sap.ui.core.routing.Router} for the constructor arguments The difference to the {@link sap.ui.core.routing.Router} are the properties viewLevel, transition and transitionParameters you can specify in every Route or Target created by this router.
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
					public extern Router(Map<sap.m.routing.Targets.TargetInfo> oTargetsConfig);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.m.routing.Router with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.routing.Router.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.routing.Router with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.routing.Router.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.routing.Router with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.routing.Router.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.m.routing.Router.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the TargetHandler instance.
					/// </summary>
					/// <returns>the TargetHandler instance</returns>
					public extern virtual sap.m.routing.TargetHandler getTargetHandler();

					#endregion

				}
			}
		}
	}
}
