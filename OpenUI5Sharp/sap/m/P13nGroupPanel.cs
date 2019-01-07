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
			/// <summary>
			/// The P13nGroupPanel control is used to define group-specific settings for table personalization.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.P13nGroupPanel")]
			public partial class P13nGroupPanel : sap.m.P13nPanel
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.P13nPanel.Settings
				{
					/// <summary>
					/// Defines the maximum number of groups.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxGroups;

					/// <summary>
					/// Defines if <code>mediaQuery</code> or <code>ContainerResize</code> is used for a layout update. If <code>ConditionPanel</code> is used in a dialog, the property must be set to true.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> containerQuery;

					/// <summary>
					/// Can be used to control the layout behavior. Default is "" which will automatically change the layout. With "Desktop", "Table" or "Phone" you can set a fixed layout.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> layoutMode;

					/// <summary>
					/// Defined group items.
					/// </summary>
					public Union<sap.m.P13nGroupItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> groupItems;

					/// <summary>
					/// Event raised if a <code>GroupItem</code> has been added.
					/// </summary>
					public sap.m.P13nGroupPanel.GroupItemDelegate addGroupItem;

					/// <summary>
					/// Event raised if a <code>GroupItem</code> has been removed.
					/// </summary>
					public sap.m.P13nRemoveItemDelegate removeGroupItem;

					/// <summary>
					/// Event raised if a <code>GroupItem</code> has been updated.
					/// </summary>
					public sap.m.P13nGroupPanel.GroupItemDelegate updateGroupItem;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class GroupItemInfo
				{
					public string id;

					public int index;

					public string key;

					public sap.m.P13nGroupItem groupItemData;

				}

				#endregion

				#region Delegates

				public delegate void GroupItemDelegate(sap.ui.@base.Event<sap.m.P13nGroupPanel.GroupItemInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nGroupPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nGroupPanel(string sId, sap.m.P13nGroupPanel.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nGroupPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nGroupPanel(string sId);

				/// <summary>
				/// Constructor for a new P13nGroupPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nGroupPanel();

				/// <summary>
				/// Constructor for a new P13nGroupPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nGroupPanel(sap.m.P13nGroupPanel.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property maxGroups

				/// <summary>
				/// Gets current value of property {@link #getMaxGroups maxGroups}.
				/// 
				/// Defines the maximum number of groups.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <returns>Value of property <code>maxGroups</code></returns>
				public extern virtual string getMaxGroups();

				/// <summary>
				/// Sets a new value for property {@link #getMaxGroups maxGroups}.
				/// 
				/// Defines the maximum number of groups.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <param name="sMaxGroups">New value for property <code>maxGroups</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel setMaxGroups(string sMaxGroups);

				#endregion

				#region Methods for Property containerQuery

				/// <summary>
				/// Gets current value of property {@link #getContainerQuery containerQuery}.
				/// 
				/// Defines if <code>mediaQuery</code> or <code>ContainerResize</code> is used for a layout update. If <code>ConditionPanel</code> is used in a dialog, the property must be set to true.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>containerQuery</code></returns>
				public extern virtual bool getContainerQuery();

				/// <summary>
				/// Sets a new value for property {@link #getContainerQuery containerQuery}.
				/// 
				/// Defines if <code>mediaQuery</code> or <code>ContainerResize</code> is used for a layout update. If <code>ConditionPanel</code> is used in a dialog, the property must be set to true.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bContainerQuery">New value for property <code>containerQuery</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel setContainerQuery(bool bContainerQuery);

				#endregion

				#region Methods for Property layoutMode

				/// <summary>
				/// Gets current value of property {@link #getLayoutMode layoutMode}.
				/// 
				/// Can be used to control the layout behavior. Default is "" which will automatically change the layout. With "Desktop", "Table" or "Phone" you can set a fixed layout.
				/// </summary>
				/// <returns>Value of property <code>layoutMode</code></returns>
				public extern virtual string getLayoutMode();

				/// <summary>
				/// Sets a new value for property {@link #getLayoutMode layoutMode}.
				/// 
				/// Can be used to control the layout behavior. Default is "" which will automatically change the layout. With "Desktop", "Table" or "Phone" you can set a fixed layout.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sLayoutMode">New value for property <code>layoutMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel setLayoutMode(string sLayoutMode);

				#endregion

				#region Methods for Aggregation content

				#endregion

				#region Methods for Aggregation groupItems

				/// <summary>
				/// Gets content of aggregation {@link #getGroupItems groupItems}.
				/// 
				/// Defined group items.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.P13nGroupItem[] getGroupItems();

				/// <summary>
				/// Destroys all the groupItems in the aggregation {@link #getGroupItems groupItems}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel destroyGroupItems();

				/// <summary>
				/// Inserts a groupItem into the aggregation {@link #getGroupItems groupItems}.
				/// </summary>
				/// <param name="oGroupItem">The groupItem to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the groupItem should be inserted at; for a negative value of <code>iIndex</code>, the groupItem is inserted at position 0; for a value greater than the current size of the aggregation, the groupItem is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel insertGroupItem(sap.m.P13nGroupItem oGroupItem, int iIndex);

				/// <summary>
				/// Adds some groupItem to the aggregation {@link #getGroupItems groupItems}.
				/// </summary>
				/// <param name="oGroupItem">The groupItem to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel addGroupItem(sap.m.P13nGroupItem oGroupItem);

				/// <summary>
				/// Removes a groupItem from the aggregation {@link #getGroupItems groupItems}.
				/// </summary>
				/// <param name="vGroupItem">The groupItem to remove or its index or id</param>
				/// <returns>The removed groupItem or <code>null</code></returns>
				public extern virtual sap.m.P13nGroupItem removeGroupItem(Union<int, string, sap.m.P13nGroupItem> vGroupItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.P13nGroupItem</code> in the aggregation {@link #getGroupItems groupItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oGroupItem">The groupItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfGroupItem(sap.m.P13nGroupItem oGroupItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getGroupItems groupItems}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.P13nGroupItem[] removeAllGroupItems();

				/// <summary>
				/// Binds aggregation {@link #getGroupItems groupItems} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel bindGroupItems(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getGroupItems groupItems} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel unbindGroupItems();

				#endregion

				#region Methods for Event addGroupItem

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addGroupItem addGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been added.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nGroupPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachAddGroupItem(object oData, sap.m.P13nGroupPanel.GroupItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addGroupItem addGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been added.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachAddGroupItem(object oData, sap.m.P13nGroupPanel.GroupItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addGroupItem addGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been added.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachAddGroupItem(sap.m.P13nGroupPanel.GroupItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addGroupItem addGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been added.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nGroupPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachAddGroupItem(sap.m.P13nGroupPanel.GroupItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:addGroupItem addGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel detachAddGroupItem(sap.m.P13nGroupPanel.GroupItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:addGroupItem addGroupItem} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel fireAddGroupItem(sap.m.P13nGroupPanel.GroupItemInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:addGroupItem addGroupItem} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel fireAddGroupItem();

				#endregion

				#region Methods for Event removeGroupItem

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeGroupItem removeGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been removed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nGroupPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachRemoveGroupItem(object oData, sap.m.P13nRemoveItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeGroupItem removeGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been removed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachRemoveGroupItem(object oData, sap.m.P13nRemoveItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeGroupItem removeGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been removed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachRemoveGroupItem(sap.m.P13nRemoveItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeGroupItem removeGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been removed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nGroupPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachRemoveGroupItem(sap.m.P13nRemoveItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:removeGroupItem removeGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel detachRemoveGroupItem(sap.m.P13nRemoveItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:removeGroupItem removeGroupItem} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel fireRemoveGroupItem(sap.m.P13nRemoveItemInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:removeGroupItem removeGroupItem} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel fireRemoveGroupItem();

				#endregion

				#region Methods for Event updateGroupItem

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateGroupItem updateGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been updated.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nGroupPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachUpdateGroupItem(object oData, sap.m.P13nGroupPanel.GroupItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateGroupItem updateGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been updated.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachUpdateGroupItem(object oData, sap.m.P13nGroupPanel.GroupItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateGroupItem updateGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been updated.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachUpdateGroupItem(sap.m.P13nGroupPanel.GroupItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateGroupItem updateGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nGroupPanel</code> itself.
				/// 
				/// Event raised if a <code>GroupItem</code> has been updated.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nGroupPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel attachUpdateGroupItem(sap.m.P13nGroupPanel.GroupItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:updateGroupItem updateGroupItem} event of this <code>sap.m.P13nGroupPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel detachUpdateGroupItem(sap.m.P13nGroupPanel.GroupItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:updateGroupItem updateGroupItem} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel fireUpdateGroupItem(sap.m.P13nGroupPanel.GroupItemInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:updateGroupItem updateGroupItem} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupPanel fireUpdateGroupItem();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nGroupPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nGroupPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nGroupPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nGroupPanel.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Removes all invalid group conditions.
				/// </summary>
				public extern virtual void removeInvalidConditions();

				/// <summary>
				/// Removes all errors/warning states from of all group conditions.
				/// </summary>
				public extern virtual void removeValidationErrors();

				/// <summary>
				/// Setter for the supported operations array.
				/// </summary>
				/// <param name="aOperations">array of operations <code>[sap.m.P13nConditionOperation.BT, sap.m.P13nConditionOperation.EQ]</code></param>
				public extern virtual void setOperations(object[] aOperations);

				/// <summary>
				/// Checks if the entered or modified conditions are correct, marks invalid fields yellow (Warning) and opens a popup message dialog to let the user know that some values are not correct or missing.
				/// </summary>
				/// <returns><code>True</code> if all conditions are valid, <code>false</code> otherwise.</returns>
				public extern virtual bool validateConditions();

				#endregion

				#endregion

			}
		}
	}
}
