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
			/// <summary>
			/// Base type for <code>panels</code> aggregation in <code>P13nDialog</code> control.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class P13nPanel : sap.ui.core.Control
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Control.Settings
				{
					/// <summary>
					/// Title text appears in the panel.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

					/// <summary>
					/// Large title text appears e.g. in dialog header in case that only one panel is shown.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> titleLarge;

					/// <summary>
					/// Panel type for generic use. Due to extensibility reason the type of <code>type</code> property should be <code>string</code>. So it is feasible to add a custom panel without expanding the type.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> type;

					/// <summary>
					/// Enables the vertical Scrolling on the <code>P13nDialog</code> when the panel is shown.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> verticalScrolling;

					/// <summary>
					/// Callback method which is called in order to validate end user entry.
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> validationExecutor;

					/// <summary>
					/// Callback method which is called in order to register for validation result.
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> validationListener;

					/// <summary>
					/// Callback which notifies a change on this panel.
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> changeNotifier;

					/// <summary>
					/// Defines personalization items (e.g. columns in the <code>P13nColumnsPanel</code>).
					/// </summary>
					public Union<sap.m.P13nItem[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// Due to performance the data of the panel can be requested in lazy mode e.g. when the panel is displayed
					/// </summary>
					public sap.ui.@base.EventDelegate beforeNavigationTo;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nPanel(string sId, sap.m.P13nPanel.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nPanel(string sId);

				/// <summary>
				/// Constructor for a new P13nPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nPanel();

				/// <summary>
				/// Constructor for a new P13nPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nPanel(sap.m.P13nPanel.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Title text appears in the panel.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Title text appears in the panel.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel setTitle(string sTitle);

				#endregion

				#region Methods for Property titleLarge

				/// <summary>
				/// Gets current value of property {@link #getTitleLarge titleLarge}.
				/// 
				/// Large title text appears e.g. in dialog header in case that only one panel is shown.
				/// </summary>
				/// <returns>Value of property <code>titleLarge</code></returns>
				public extern virtual string getTitleLarge();

				/// <summary>
				/// Sets a new value for property {@link #getTitleLarge titleLarge}.
				/// 
				/// Large title text appears e.g. in dialog header in case that only one panel is shown.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitleLarge">New value for property <code>titleLarge</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel setTitleLarge(string sTitleLarge);

				#endregion

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// Panel type for generic use. Due to extensibility reason the type of <code>type</code> property should be <code>string</code>. So it is feasible to add a custom panel without expanding the type.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual string getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// Panel type for generic use. Due to extensibility reason the type of <code>type</code> property should be <code>string</code>. So it is feasible to add a custom panel without expanding the type.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel setType(string sType);

				#endregion

				#region Methods for Property verticalScrolling

				/// <summary>
				/// Gets current value of property {@link #getVerticalScrolling verticalScrolling}.
				/// 
				/// Enables the vertical Scrolling on the <code>P13nDialog</code> when the panel is shown.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>verticalScrolling</code></returns>
				public extern virtual bool getVerticalScrolling();

				/// <summary>
				/// Sets a new value for property {@link #getVerticalScrolling verticalScrolling}.
				/// 
				/// Enables the vertical Scrolling on the <code>P13nDialog</code> when the panel is shown.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVerticalScrolling">New value for property <code>verticalScrolling</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel setVerticalScrolling(bool bVerticalScrolling);

				#endregion

				#region Methods for Property validationExecutor

				/// <summary>
				/// Gets current value of property {@link #getValidationExecutor validationExecutor}.
				/// 
				/// Callback method which is called in order to validate end user entry.
				/// </summary>
				/// <returns>Value of property <code>validationExecutor</code></returns>
				public extern virtual object getValidationExecutor();

				/// <summary>
				/// Sets a new value for property {@link #getValidationExecutor validationExecutor}.
				/// 
				/// Callback method which is called in order to validate end user entry.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oValidationExecutor">New value for property <code>validationExecutor</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel setValidationExecutor(object oValidationExecutor);

				#endregion

				#region Methods for Property validationListener

				/// <summary>
				/// Gets current value of property {@link #getValidationListener validationListener}.
				/// 
				/// Callback method which is called in order to register for validation result.
				/// </summary>
				/// <returns>Value of property <code>validationListener</code></returns>
				public extern virtual object getValidationListener();

				/// <summary>
				/// Sets a new value for property {@link #getValidationListener validationListener}.
				/// 
				/// Callback method which is called in order to register for validation result.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oValidationListener">New value for property <code>validationListener</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel setValidationListener(object oValidationListener);

				#endregion

				#region Methods for Property changeNotifier

				/// <summary>
				/// Gets current value of property {@link #getChangeNotifier changeNotifier}.
				/// 
				/// Callback which notifies a change on this panel.
				/// </summary>
				/// <returns>Value of property <code>changeNotifier</code></returns>
				public extern virtual object getChangeNotifier();

				/// <summary>
				/// Sets a new value for property {@link #getChangeNotifier changeNotifier}.
				/// 
				/// Callback which notifies a change on this panel.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oChangeNotifier">New value for property <code>changeNotifier</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel setChangeNotifier(object oChangeNotifier);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// Defines personalization items (e.g. columns in the <code>P13nColumnsPanel</code>).
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.P13nItem[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel insertItem(sap.m.P13nItem oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel addItem(sap.m.P13nItem oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.m.P13nItem removeItem(Union<int, string, sap.m.P13nItem> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.P13nItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.P13nItem oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.P13nItem[] removeAllItems();

				/// <summary>
				/// Binds aggregation {@link #getItems items} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel bindItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel unbindItems();

				#endregion

				#region Methods for Event beforeNavigationTo

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeNavigationTo beforeNavigationTo} event of this <code>sap.m.P13nPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nPanel</code> itself.
				/// 
				/// Due to performance the data of the panel can be requested in lazy mode e.g. when the panel is displayed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel attachBeforeNavigationTo(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeNavigationTo beforeNavigationTo} event of this <code>sap.m.P13nPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nPanel</code> itself.
				/// 
				/// Due to performance the data of the panel can be requested in lazy mode e.g. when the panel is displayed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel attachBeforeNavigationTo(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeNavigationTo beforeNavigationTo} event of this <code>sap.m.P13nPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nPanel</code> itself.
				/// 
				/// Due to performance the data of the panel can be requested in lazy mode e.g. when the panel is displayed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel attachBeforeNavigationTo(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeNavigationTo beforeNavigationTo} event of this <code>sap.m.P13nPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nPanel</code> itself.
				/// 
				/// Due to performance the data of the panel can be requested in lazy mode e.g. when the panel is displayed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel attachBeforeNavigationTo(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeNavigationTo beforeNavigationTo} event of this <code>sap.m.P13nPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel detachBeforeNavigationTo(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeNavigationTo beforeNavigationTo} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel fireBeforeNavigationTo(object mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeNavigationTo beforeNavigationTo} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nPanel fireBeforeNavigationTo();

				#endregion

				#region Other methods

				/// <summary>
				/// This method defines the point in time before the panel becomes active.
				/// </summary>
				public extern virtual void beforeNavigationTo();

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nPanel.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// This method can be overwritten by subclass in order to return a payload for Ok action
				/// </summary>
				[Obsolete("Deprecated since 1.50. replaced by the event of the respective inherited control, for example {@link sap.m.P13nColumnsPanel.html#changeColumnsItems} of <code>P13nColumnsPanel</code> control.")]
				/// <returns>Object which describes the state after Ok has been pressed</returns>
				public extern virtual object getOkPayload();

				/// <summary>
				/// This method can be overwritten by subclass in order to return a payload for Reset action
				/// </summary>
				public extern virtual void getResetPayload();

				/// <summary>
				/// This method can be overwritten by subclass in order to cleanup after navigation, e.g. to remove invalid content on the panel.
				/// </summary>
				public extern virtual void onAfterNavigationFrom();

				/// <summary>
				/// This method can be overwritten by subclass in order to prevent navigation to another panel. This could be the case if some content on the panel is considered 'invalid'.
				/// </summary>
				/// <returns>true if it is allowed to navigate away from this panel, false if it is not allowed</returns>
				public extern virtual bool onBeforeNavigationFrom();

				#endregion

				#endregion

			}
		}
	}
}
