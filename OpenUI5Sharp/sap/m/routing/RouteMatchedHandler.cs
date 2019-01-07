using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			public static partial class routing
			{
				/// <summary>
				/// This class will attach to the Events of a provided router and add the views created by it to a {@link sap.m.SplitContainer} or a {@link sap.m.NavContainer} Control, if this is the target control of the route.</br> If the targetControl is no {@link sap.m.SplitContainer} or a {@link sap.m.NavContainer}, It will only close the dialogs, according to the property value.</br> </br> When a navigation is triggered, this class will try to determine the transition of the pages based on the history.</br> Eg: if a user presses browser back, it will show a backwards animation.</br> </br> The navigation on the container takes place in the RoutePatternMatched event of the Router. If you register on the RouteMatched event of the Router, the visual navigation did not take place yet.</br> </br> Since it is hard to detect if a user has pressed browser back, this transitions will not be reliable, for example if someone bookmarked a detail page, and wants to navigate to a masterPage.</br> If you want this case to always show a backwards transition, you should specify a "viewLevel" property on your Route.</br> The viewLevel has to be an integer. The Master should have a lower number than the detail.</br> These levels should represent the user process of your application and they do not have to match the container structure of your Routes.</br> If the user navigates between views with the same viewLevel, the history is asked for the direction.</br> </br> You can specify a property "transition" in a route to define which transition will be applied when navigating. If it is not defined, the nav container will take its default transition. </br> You can also specify "transitionParameters" on a Route, to give the transition parameters.</br> </br> preservePageInSplitContainer is deprecated since 1.28 since Targets make this parameter obsolete. If you want to preserve the current view when navigating, but you want to navigate to it when nothing is displayed in the navContainer, you can set preservePageInSplitContainer = true</br> When the route that has this flag directly matches the pattern, the view will still be switched by the splitContainer. </br>
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.m.routing.RouteMatchedHandler")]
				[Obsolete("Deprecated since 1.28. use {@link sap.m.routing.Router} or {@link sap.m.routing.Targets} instead. The functionality of the routematched handler is built in into these two classes, there is no need to create this anymore.")]
				public partial class RouteMatchedHandler : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Instantiates a RouteMatchedHandler.
					/// </summary>
					/// <param name="router">A router that creates views</br></param>
					/// <param name="closeDialogs">the default is true - will close all open dialogs before navigating, if set to true. If set to false it will just navigate without closing dialogs.</param>
					public extern RouteMatchedHandler(sap.ui.core.routing.Router router, bool closeDialogs);

					#endregion

					#region Methods

					/// <summary>
					/// Removes the routeMatchedHandler from the Router
					/// </summary>
					/// <returns>for chaining</returns>
					public extern virtual sap.m.routing.RouteMatchedHandler destroy();

					/// <summary>
					/// Creates a new subclass of class sap.m.routing.RouteMatchedHandler with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.routing.RouteMatchedHandler with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.routing.RouteMatchedHandler with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Gets if a navigation should close dialogs
					/// </summary>
					/// <returns>a flag indication if dialogs will be closed</returns>
					public extern virtual bool getCloseDialogs();

					/// <summary>
					/// Returns a metadata object for class sap.m.routing.RouteMatchedHandler.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Sets if a navigation should close dialogs
					/// </summary>
					/// <param name="bCloseDialogs">close dialogs if true</param>
					/// <returns>for chaining</returns>
					public extern virtual sap.m.routing.RouteMatchedHandler setCloseDialogs(bool bCloseDialogs);

					#endregion

				}
			}
		}
	}
}
