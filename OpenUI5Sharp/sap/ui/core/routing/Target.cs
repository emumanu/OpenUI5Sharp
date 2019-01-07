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
					[Name("sap.ui.core.routing.Target")]
					public partial class Target : sap.ui.@base.EventProvider
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
							/// The options object passed to the constructor {@link sap.ui.core.routing.Target#constructor}
							/// </summary>
							public object config;

							/// <summary>
							/// The data passed into the {@link sap.ui.core.routing.Target#display} function
							/// </summary>
							public object data;

						}

						#endregion

						#region Delegates

						public delegate void DisplayDelegate(sap.ui.@base.Event<sap.ui.core.routing.Target.DisplayInfo> oEvent, object oData);

						#endregion

						#region Constructor

						/// <summary>
						/// Provides a convenient way for placing views into the correct containers of your application.<br/> The main benefit of Targets is lazy loading: you do not have to create the views until you really need them.<br/> <b>Don't call this constructor directly</b>, use {@link sap.ui.core.routing.Targets} instead, it will create instances of a Target.<br/> If you are using the mobile library, please use the {@link sap.m.routing.Targets} constructor, please read the documentation there.<br/>
						/// </summary>
						/// <param name="oOptions">all of the parameters defined in {@link sap.m.routing.Targets#constructor} are accepted here, except for children you need to specify the parent.</param>
						/// <param name="oCache">All views required by this target will get created by the views instance using {@link sap.ui.core.routing.Views#getView}</param>
						/// <param name="oParent">the parent of this target. Will also get displayed, if you display this target. In the config you have the fill the children property {@link sap.m.routing.Targets#constructor}</param>
						public extern Target(object oOptions, object oCache, sap.ui.core.routing.Target oParent);

						/// <summary>
						/// Provides a convenient way for placing views into the correct containers of your application.<br/> The main benefit of Targets is lazy loading: you do not have to create the views until you really need them.<br/> <b>Don't call this constructor directly</b>, use {@link sap.ui.core.routing.Targets} instead, it will create instances of a Target.<br/> If you are using the mobile library, please use the {@link sap.m.routing.Targets} constructor, please read the documentation there.<br/>
						/// </summary>
						/// <param name="oOptions">all of the parameters defined in {@link sap.m.routing.Targets#constructor} are accepted here, except for children you need to specify the parent.</param>
						/// <param name="oCache">All views required by this target will get created by the views instance using {@link sap.ui.core.routing.Views#getView}</param>
						public extern Target(object oOptions, object oCache);

						#endregion

						#region Methods

						#region Methods for event display

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'display' event of this <code>sap.ui.core.routing.Target</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Target attachDisplay(object oData, sap.ui.core.routing.Target.DisplayDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'display' event of this <code>sap.ui.core.routing.Target</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Target attachDisplay(object oData, sap.ui.core.routing.Target.DisplayDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'display' event of this <code>sap.ui.core.routing.Target</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Target attachDisplay(sap.ui.core.routing.Target.DisplayDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'display' event of this <code>sap.ui.core.routing.Target</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Target attachDisplay(sap.ui.core.routing.Target.DisplayDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'display' event of this <code>sap.ui.core.routing.Target</code>.<br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Target detachDisplay(sap.ui.core.routing.Target.DisplayDelegate fnFunction, object oListener);

						/// <summary>
						/// Fire event created to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Target fireDisplay(sap.ui.core.routing.Target.DisplayInfo mArguments);

						/// <summary>
						/// Fire event created to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Target fireDisplay();

						#endregion

						#region Other methods

						/// <summary>
						/// This function is called between the target view is loaded and the view is added to the container.
						/// 
						/// This function can be used for applying modification on the view or the container to make the rerendering occur together with the later aggregation change.
						/// </summary>
						/// <param name="mArguments"></param>
						public extern virtual void _beforePlacingViewIntoContainer(object mArguments);

						/// <summary>
						/// Destroys the target, will be called by {@link sap.m.routing.Targets} don't call this directly.
						/// </summary>
						/// <returns>this for chaining.</returns>
						public extern virtual sap.ui.core.routing.Target destroy();

						/// <summary>
						/// Creates a view and puts it in an aggregation of a control that has been defined in the {@link sap.ui.core.routing.Target#constructor}.
						/// </summary>
						/// <param name="vData">an object that will be passed to the display event in the data property. If the target has parents, the data will also be passed to them.</param>
						/// <returns>resolves with {name: *, view: *, control: *} if the target can be successfully displayed otherwise it resolves with {name: *, error: *}</returns>
						public extern virtual es5.Promise<object> display(object vData);

						/// <summary>
						/// Creates a view and puts it in an aggregation of a control that has been defined in the {@link sap.ui.core.routing.Target#constructor}.
						/// </summary>
						/// <returns>resolves with {name: *, view: *, control: *} if the target can be successfully displayed otherwise it resolves with {name: *, error: *}</returns>
						public extern virtual es5.Promise<object> display();

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Target with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Target with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Target with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.routing.Target.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
