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
			/// The NotificationListItemGroup control is used for grouping {@link sap.m.NotificationListItem notification items} of the same type. <h4>Behavior</h4> The group handles specific behavior for different usecases: <ul> <li><code>autoPriority</code> - sets the group priority to the highest priority of an item in the group.</li> <li><code>enableCollapseButtonWhenEmpty</code> - displays a collapse button for an empty group.</li> <li><code>showEmptyGroup</code> - determines if the header/footer of an empty group is displayed.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class NotificationListGroup : sap.m.NotificationListBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.NotificationListBase.Settings
				{
					/// <summary>
					/// Determines if the group is collapsed or expanded.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> collapsed;

					/// <summary>
					/// Determines if the group will automatically set the priority based on the highest priority of its notifications or get its priority from the developer.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> autoPriority;

					/// <summary>
					/// Determines if the group header/footer of the empty group will be always shown. By default groups with 0 notifications are not shown.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showEmptyGroup;

					/// <summary>
					/// Determines if the collapse/expand button should be enabled for an empty group.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enableCollapseButtonWhenEmpty;

					/// <summary>
					/// The NotificationListItems inside the group.
					/// </summary>
					public Union<sap.m.NotificationListItem[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// This event is called when collapse property value is changed
					/// </summary>
					public sap.m.NotificationListGroup.OnCollapseDelegate onCollapse;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class OnCollapseInfo
				{
					/// <summary>
					/// Indicates exact collapse direction
					/// </summary>
					public bool collapsed;

				}

				#endregion

				#region Delegates

				public delegate void OnCollapseDelegate(sap.ui.@base.Event<sap.m.NotificationListGroup.OnCollapseInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new NotificationListGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern NotificationListGroup(string sId, sap.m.NotificationListGroup.Settings mSettings);

				/// <summary>
				/// Constructor for a new NotificationListGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern NotificationListGroup(string sId);

				/// <summary>
				/// Constructor for a new NotificationListGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern NotificationListGroup();

				/// <summary>
				/// Constructor for a new NotificationListGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern NotificationListGroup(sap.m.NotificationListGroup.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property collapsed

				/// <summary>
				/// Gets current value of property {@link #getCollapsed collapsed}.
				/// 
				/// Determines if the group is collapsed or expanded.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>collapsed</code></returns>
				public extern virtual bool getCollapsed();

				/// <summary>
				/// Overwrites the setter for collapsed property.
				/// </summary>
				/// <param name="Collapsed">Collapsed indicator.</param>
				/// <returns>this NotificationListGroup reference for chaining.</returns>
				public extern virtual sap.m.NotificationListGroup setCollapsed(bool Collapsed);

				#endregion

				#region Methods for Property autoPriority

				/// <summary>
				/// Gets current value of property {@link #getAutoPriority autoPriority}.
				/// 
				/// Determines if the group will automatically set the priority based on the highest priority of its notifications or get its priority from the developer.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>autoPriority</code></returns>
				public extern virtual bool getAutoPriority();

				/// <summary>
				/// Sets a new value for property {@link #getAutoPriority autoPriority}.
				/// 
				/// Determines if the group will automatically set the priority based on the highest priority of its notifications or get its priority from the developer.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bAutoPriority">New value for property <code>autoPriority</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup setAutoPriority(bool bAutoPriority);

				#endregion

				#region Methods for Property showEmptyGroup

				/// <summary>
				/// Gets current value of property {@link #getShowEmptyGroup showEmptyGroup}.
				/// 
				/// Determines if the group header/footer of the empty group will be always shown. By default groups with 0 notifications are not shown.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showEmptyGroup</code></returns>
				public extern virtual bool getShowEmptyGroup();

				/// <summary>
				/// Sets a new value for property {@link #getShowEmptyGroup showEmptyGroup}.
				/// 
				/// Determines if the group header/footer of the empty group will be always shown. By default groups with 0 notifications are not shown.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowEmptyGroup">New value for property <code>showEmptyGroup</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup setShowEmptyGroup(bool bShowEmptyGroup);

				#endregion

				#region Methods for Property enableCollapseButtonWhenEmpty

				/// <summary>
				/// Gets current value of property {@link #getEnableCollapseButtonWhenEmpty enableCollapseButtonWhenEmpty}.
				/// 
				/// Determines if the collapse/expand button should be enabled for an empty group.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableCollapseButtonWhenEmpty</code></returns>
				public extern virtual bool getEnableCollapseButtonWhenEmpty();

				/// <summary>
				/// Sets a new value for property {@link #getEnableCollapseButtonWhenEmpty enableCollapseButtonWhenEmpty}.
				/// 
				/// Determines if the collapse/expand button should be enabled for an empty group.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableCollapseButtonWhenEmpty">New value for property <code>enableCollapseButtonWhenEmpty</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup setEnableCollapseButtonWhenEmpty(bool bEnableCollapseButtonWhenEmpty);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// The NotificationListItems inside the group.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.NotificationListItem[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup insertItem(sap.m.NotificationListItem oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup addItem(sap.m.NotificationListItem oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.m.NotificationListItem removeItem(Union<int, string, sap.m.NotificationListItem> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.NotificationListItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.NotificationListItem oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.NotificationListItem[] removeAllItems();

				#endregion

				#region Methods for Aggregation _ariaDetailsText

				#endregion

				#region Methods for Event onCollapse

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:onCollapse onCollapse} event of this <code>sap.m.NotificationListGroup</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NotificationListGroup</code> itself.
				/// 
				/// This event is called when collapse property value is changed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.NotificationListGroup</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup attachOnCollapse(object oData, sap.m.NotificationListGroup.OnCollapseDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:onCollapse onCollapse} event of this <code>sap.m.NotificationListGroup</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NotificationListGroup</code> itself.
				/// 
				/// This event is called when collapse property value is changed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup attachOnCollapse(object oData, sap.m.NotificationListGroup.OnCollapseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:onCollapse onCollapse} event of this <code>sap.m.NotificationListGroup</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NotificationListGroup</code> itself.
				/// 
				/// This event is called when collapse property value is changed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup attachOnCollapse(sap.m.NotificationListGroup.OnCollapseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:onCollapse onCollapse} event of this <code>sap.m.NotificationListGroup</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NotificationListGroup</code> itself.
				/// 
				/// This event is called when collapse property value is changed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.NotificationListGroup</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup attachOnCollapse(sap.m.NotificationListGroup.OnCollapseDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:onCollapse onCollapse} event of this <code>sap.m.NotificationListGroup</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup detachOnCollapse(sap.m.NotificationListGroup.OnCollapseDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:onCollapse onCollapse} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup fireOnCollapse(sap.m.NotificationListGroup.OnCollapseInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:onCollapse onCollapse} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListGroup fireOnCollapse();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.NotificationListGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.NotificationListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.NotificationListGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.NotificationListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.NotificationListGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.NotificationListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.NotificationListGroup.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Sets up the initial values of the control.
				/// </summary>
				public extern override void init();

				/// <summary>
				/// Overwrites the onBeforeRendering.
				/// </summary>
				public extern override void onBeforeRendering();

				#endregion

				#endregion

			}
		}
	}
}
