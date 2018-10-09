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
					[Name("sap.ui.core.routing.Targets")]
					public partial class Targets : sap.ui.@base.EventProvider
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class DisplayInfo
						{
							/// <summary>
							/// The view that got displayed.
							/// </summary>
							public object view;

							/// <summary>
							/// The control that now contains the view in the controlAggregation
							/// </summary>
							public object control;

							/// <summary>
							/// The options object passed to the constructor {@link sap.ui.core.routing.Targets#constructor}
							/// </summary>
							public object config;

							/// <summary>
							/// The name of the target firing the event
							/// </summary>
							public object name;

							/// <summary>
							/// The data passed into the {@link sap.ui.core.routing.Targets#display} function
							/// </summary>
							public object data;

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
							/// The name of the displayed target
							/// </summary>
							public string name;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class TargetInfo
						{
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

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class TargetsOptions
						{
							/// <summary>
							/// the views instance will create the views of all the targets defined, so if 2 targets have the same viewName, the same instance of the view will be displayed.
							/// </summary>
							public sap.ui.core.routing.Views views;

							/// <summary>
							/// this config allows all the values oOptions.targets.anyName allows, these will be the default values for properties used in the target.<br/> For example if you are only using xmlViews in your app you can specify viewType="XML" so you don't have to repeat this in every target.<br/> If a target specifies viewType="JS", the JS will be stronger than the XML here is an example.
							/// 
							/// <pre>
							/// <code>
							/// {
							///     config: {
							///         viewType : "XML"
							///     }
							///     targets : {
							///         xmlTarget : {
							///             ...
							///         },
							///         jsTarget : {
							///             viewType : "JS"
							///             ...
							///         }
							///     }
							/// }
							/// </code>
							/// </pre> Then the effective config that will be used looks like this: <pre>
							/// <code>
							/// {
							///     xmlTarget : {
							///         // coming from the defaults
							///         viewType : "XML"
							///         ...
							///     },
							///     jsTarget : {
							///        // XML is overwritten by the "JS" of the targets property
							///        viewType : "JS"
							///       ...
							///     }
							/// }
							/// </code>
							/// </pre>
							/// </summary>
							public sap.m.RoutingTargetsConfig config;

							/// <summary>
							/// One or multiple targets in a map.
							/// </summary>
							public Map<sap.ui.core.routing.Targets.TargetInfo> targets;

						}

						#endregion

						#region Delegates

						public delegate void DisplayDelegate(sap.ui.@base.Event<sap.ui.core.routing.Targets.DisplayInfo> oEvent, object oData);

						public delegate void TitleChangedDelegate(sap.ui.@base.Event<sap.ui.core.routing.Targets.TitleChangedInfo> oEvent, object oData);

						#endregion

						#region Constructor

						/// <summary>
						/// Provides a convenient way for placing views into the correct containers of your application. The main benefit of Targets is lazy loading: you do not have to create the views until you really need them. If you are using the mobile library, please use {@link sap.m.routing.Targets} instead of this class.
						/// </summary>
						/// <param name="oOptions"></param>
						public extern Targets(sap.ui.core.routing.Targets.TargetsOptions oOptions);

						#endregion

						#region Methods

						#region Methods for event display

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'display' event of this <code>sap.ui.core.routing.Targets</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets attachDisplay(object oData, sap.ui.core.routing.Targets.DisplayDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'display' event of this <code>sap.ui.core.routing.Targets</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets attachDisplay(object oData, sap.ui.core.routing.Targets.DisplayDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'display' event of this <code>sap.ui.core.routing.Targets</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets attachDisplay(sap.ui.core.routing.Targets.DisplayDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'display' event of this <code>sap.ui.core.routing.Targets</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets attachDisplay(sap.ui.core.routing.Targets.DisplayDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'display' event of this <code>sap.ui.core.routing.Targets</code>.<br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets detachDisplay(sap.ui.core.routing.Targets.DisplayDelegate fnFunction, object oListener);

						/// <summary>
						/// Fire event created to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets fireDisplay(sap.ui.core.routing.Targets.DisplayInfo mArguments);

						/// <summary>
						/// Fire event created to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets fireDisplay();

						#endregion

						#region Methods for event titleChanged

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'titleChanged' event of this <code>sap.ui.core.routing.Targets</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets attachTitleChanged(object oData, sap.ui.core.routing.Targets.TitleChangedDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'titleChanged' event of this <code>sap.ui.core.routing.Targets</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets attachTitleChanged(object oData, sap.ui.core.routing.Targets.TitleChangedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'titleChanged' event of this <code>sap.ui.core.routing.Targets</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets attachTitleChanged(sap.ui.core.routing.Targets.TitleChangedDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'titleChanged' event of this <code>sap.ui.core.routing.Targets</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets attachTitleChanged(sap.ui.core.routing.Targets.TitleChangedDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'titleChanged' event of this <code>sap.ui.core.routing.Targets</code>.<br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets detachTitleChanged(sap.ui.core.routing.Targets.TitleChangedDelegate fnFunction, object oListener);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a target by using the given name and options. If there's already a target with the same name exists, the existing target is kept from being overwritten and an error log will be written to the development console.
						/// </summary>
						/// <param name="sName">the name of a target</param>
						/// <param name="oTarget">the options of a target. The option names are the same as the ones in "oOptions.targets.anyName" of {@link #constructor}.</param>
						/// <returns>Targets itself for method chaining</returns>
						public extern virtual sap.ui.core.routing.Targets addTarget(string sName, object oTarget);

						/// <summary>
						/// Destroys the targets instance and all created targets. Does not destroy the views instance passed to the constructor. It has to be destroyed separately.
						/// </summary>
						/// <returns>this for chaining.</returns>
						public extern virtual sap.ui.core.routing.Targets destroy();

						/// <summary>
						/// Creates a view and puts it in an aggregation of the specified control.
						/// </summary>
						/// <param name="vTargets">the key of the target as specified in the {@link #constructor}. To display multiple targets you may also pass an array of keys.</param>
						/// <param name="oData">an object that will be passed to the display event in the data property. If the target has parents, the data will also be passed to them.</param>
						/// <param name="sTitleTarget">the name of the target from which the title option is taken for firing the {@link sap.ui.core.routing.Targets#event:titleChanged titleChanged} event</param>
						/// <returns>this pointer for chaining or a Promise</returns>
						public extern virtual Union<sap.ui.core.routing.Targets, jquery.JQueryPromise<object>> display(Union<string, string[]> vTargets, object oData, string sTitleTarget);

						/// <summary>
						/// Creates a view and puts it in an aggregation of the specified control.
						/// </summary>
						/// <param name="vTargets">the key of the target as specified in the {@link #constructor}. To display multiple targets you may also pass an array of keys.</param>
						/// <param name="oData">an object that will be passed to the display event in the data property. If the target has parents, the data will also be passed to them.</param>
						/// <returns>this pointer for chaining or a Promise</returns>
						public extern virtual Union<sap.ui.core.routing.Targets, jquery.JQueryPromise<object>> display(Union<string, string[]> vTargets, object oData);

						/// <summary>
						/// Creates a view and puts it in an aggregation of the specified control.
						/// </summary>
						/// <param name="vTargets">the key of the target as specified in the {@link #constructor}. To display multiple targets you may also pass an array of keys.</param>
						/// <returns>this pointer for chaining or a Promise</returns>
						public extern virtual Union<sap.ui.core.routing.Targets, jquery.JQueryPromise<object>> display(Union<string, string[]> vTargets);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Targets with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Targets with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Targets with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.routing.Targets.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Returns a target by its name (if you pass myTarget: { view: "myView" }) in the config myTarget is the name.
						/// </summary>
						/// <param name="vName">the name of a single target or the name of multiple targets</param>
						/// <returns>The target with the coresponding name or undefined. If an array way passed as name this will return an array with all found targets. Non existing targets will not be returned but will log an error.</returns>
						public extern virtual Union<sap.ui.core.routing.Target, sap.ui.core.routing.Target[]> getTarget(Union<string, string[]> vName);

						/// <summary>
						/// Returns the views instance passed to the constructor
						/// </summary>
						/// <returns>the views instance</returns>
						public extern virtual sap.ui.core.routing.Views getViews();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
