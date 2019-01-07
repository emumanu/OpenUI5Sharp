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
			/// The P13nFilterPanel control is used to define filter-specific settings for table personalization.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.P13nFilterPanel")]
			public partial class P13nFilterPanel : sap.m.P13nPanel
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
					/// Defines the maximum number of include filters.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxIncludes;

					/// <summary>
					/// Defines the maximum number of exclude filters.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxExcludes;

					/// <summary>
					/// Defines if the <code>mediaQuery</code> or a <code>ContainerResize</code> is used for layout update. If the <code>ConditionPanel</code> is used in a dialog, the property must be set to <code>true</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> containerQuery;

					/// <summary>
					/// Can be used to control the layout behavior. Default is "" which will automatically change the layout. With "Desktop", "Table" or"Phone" you can set a fixed layout.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> layoutMode;

					/// <summary>
					/// Defines filter items.
					/// </summary>
					public Union<sap.m.P13nFilterItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> filterItems;

					/// <summary>
					/// Event raised if a filter item has been added.
					/// </summary>
					public sap.m.P13nFilterPanel.FilterItemDelegate addFilterItem;

					/// <summary>
					/// Event raised if a filter item has been removed.
					/// </summary>
					public sap.m.P13nRemoveItemDelegate removeFilterItem;

					/// <summary>
					/// Event raised if a filter item has been updated.
					/// </summary>
					public sap.m.P13nFilterPanel.FilterItemDelegate updateFilterItem;

					/// <summary>
					/// Event raised if a filter item has been changed. reason can be added, updated or removed.
					/// </summary>
					public sap.m.P13nFilterPanel.FilterItemChangedDelegate filterItemChanged;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class FilterItemInfo
				{
					public string id;

					public int index;

					public string key;

					public sap.m.P13nFilterItem filterItemData;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class FilterItemChangedInfo
				{
					/// <summary>
					/// reason for the changeFilterItem event. Value can be added, updated or removed.
					/// </summary>
					public string reason;

					/// <summary>
					/// key of the changed filterItem
					/// </summary>
					public string key;

					/// <summary>
					/// index of the changed filterItem
					/// </summary>
					public int index;

					/// <summary>
					/// JSON object of the changed filterItem instance (in case of reason=="removed" the itemData parameter does not exist)
					/// </summary>
					public object itemData;

				}

				#endregion

				#region Delegates

				public delegate void FilterItemDelegate(sap.ui.@base.Event<sap.m.P13nFilterPanel.FilterItemInfo> oEvent, object oData);

				public delegate void FilterItemChangedDelegate(sap.ui.@base.Event<sap.m.P13nFilterPanel.FilterItemChangedInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nFilterPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nFilterPanel(string sId, sap.m.P13nFilterPanel.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nFilterPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nFilterPanel(string sId);

				/// <summary>
				/// Constructor for a new P13nFilterPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nFilterPanel();

				/// <summary>
				/// Constructor for a new P13nFilterPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nFilterPanel(sap.m.P13nFilterPanel.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property maxIncludes

				/// <summary>
				/// Gets current value of property {@link #getMaxIncludes maxIncludes}.
				/// 
				/// Defines the maximum number of include filters.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <returns>Value of property <code>maxIncludes</code></returns>
				public extern virtual string getMaxIncludes();

				/// <summary>
				/// Sets a new value for property {@link #getMaxIncludes maxIncludes}.
				/// 
				/// Defines the maximum number of include filters.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <param name="sMaxIncludes">New value for property <code>maxIncludes</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel setMaxIncludes(string sMaxIncludes);

				#endregion

				#region Methods for Property maxExcludes

				/// <summary>
				/// Gets current value of property {@link #getMaxExcludes maxExcludes}.
				/// 
				/// Defines the maximum number of exclude filters.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <returns>Value of property <code>maxExcludes</code></returns>
				public extern virtual string getMaxExcludes();

				/// <summary>
				/// Sets a new value for property {@link #getMaxExcludes maxExcludes}.
				/// 
				/// Defines the maximum number of exclude filters.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <param name="sMaxExcludes">New value for property <code>maxExcludes</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel setMaxExcludes(string sMaxExcludes);

				#endregion

				#region Methods for Property containerQuery

				/// <summary>
				/// Gets current value of property {@link #getContainerQuery containerQuery}.
				/// 
				/// Defines if the <code>mediaQuery</code> or a <code>ContainerResize</code> is used for layout update. If the <code>ConditionPanel</code> is used in a dialog, the property must be set to <code>true</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>containerQuery</code></returns>
				public extern virtual bool getContainerQuery();

				/// <summary>
				/// Sets a new value for property {@link #getContainerQuery containerQuery}.
				/// 
				/// Defines if the <code>mediaQuery</code> or a <code>ContainerResize</code> is used for layout update. If the <code>ConditionPanel</code> is used in a dialog, the property must be set to <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bContainerQuery">New value for property <code>containerQuery</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel setContainerQuery(bool bContainerQuery);

				#endregion

				#region Methods for Property layoutMode

				/// <summary>
				/// Gets current value of property {@link #getLayoutMode layoutMode}.
				/// 
				/// Can be used to control the layout behavior. Default is "" which will automatically change the layout. With "Desktop", "Table" or"Phone" you can set a fixed layout.
				/// </summary>
				/// <returns>Value of property <code>layoutMode</code></returns>
				public extern virtual string getLayoutMode();

				/// <summary>
				/// Sets a new value for property {@link #getLayoutMode layoutMode}.
				/// 
				/// Can be used to control the layout behavior. Default is "" which will automatically change the layout. With "Desktop", "Table" or"Phone" you can set a fixed layout.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sLayoutMode">New value for property <code>layoutMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel setLayoutMode(string sLayoutMode);

				#endregion

				#region Methods for Aggregation content

				#endregion

				#region Methods for Aggregation filterItems

				/// <summary>
				/// Gets content of aggregation {@link #getFilterItems filterItems}.
				/// 
				/// Defines filter items.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.P13nFilterItem[] getFilterItems();

				/// <summary>
				/// Destroys all the filterItems in the aggregation {@link #getFilterItems filterItems}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel destroyFilterItems();

				/// <summary>
				/// Inserts a filterItem into the aggregation {@link #getFilterItems filterItems}.
				/// </summary>
				/// <param name="oFilterItem">The filterItem to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the filterItem should be inserted at; for a negative value of <code>iIndex</code>, the filterItem is inserted at position 0; for a value greater than the current size of the aggregation, the filterItem is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel insertFilterItem(sap.m.P13nFilterItem oFilterItem, int iIndex);

				/// <summary>
				/// Adds some filterItem to the aggregation {@link #getFilterItems filterItems}.
				/// </summary>
				/// <param name="oFilterItem">The filterItem to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel addFilterItem(sap.m.P13nFilterItem oFilterItem);

				/// <summary>
				/// Removes a filterItem from the aggregation {@link #getFilterItems filterItems}.
				/// </summary>
				/// <param name="vFilterItem">The filterItem to remove or its index or id</param>
				/// <returns>The removed filterItem or <code>null</code></returns>
				public extern virtual sap.m.P13nFilterItem removeFilterItem(Union<int, string, sap.m.P13nFilterItem> vFilterItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.P13nFilterItem</code> in the aggregation {@link #getFilterItems filterItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oFilterItem">The filterItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfFilterItem(sap.m.P13nFilterItem oFilterItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getFilterItems filterItems}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.P13nFilterItem[] removeAllFilterItems();

				/// <summary>
				/// Binds aggregation {@link #getFilterItems filterItems} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel bindFilterItems(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getFilterItems filterItems} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel unbindFilterItems();

				#endregion

				#region Methods for Event addFilterItem

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addFilterItem addFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been added.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nFilterPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachAddFilterItem(object oData, sap.m.P13nFilterPanel.FilterItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addFilterItem addFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been added.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachAddFilterItem(object oData, sap.m.P13nFilterPanel.FilterItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addFilterItem addFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been added.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachAddFilterItem(sap.m.P13nFilterPanel.FilterItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addFilterItem addFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been added.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nFilterPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachAddFilterItem(sap.m.P13nFilterPanel.FilterItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:addFilterItem addFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel detachAddFilterItem(sap.m.P13nFilterPanel.FilterItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:addFilterItem addFilterItem} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel fireAddFilterItem(sap.m.P13nFilterPanel.FilterItemInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:addFilterItem addFilterItem} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel fireAddFilterItem();

				#endregion

				#region Methods for Event removeFilterItem

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeFilterItem removeFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been removed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nFilterPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachRemoveFilterItem(object oData, sap.m.P13nRemoveItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeFilterItem removeFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been removed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachRemoveFilterItem(object oData, sap.m.P13nRemoveItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeFilterItem removeFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been removed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachRemoveFilterItem(sap.m.P13nRemoveItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeFilterItem removeFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been removed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nFilterPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachRemoveFilterItem(sap.m.P13nRemoveItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:removeFilterItem removeFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel detachRemoveFilterItem(sap.m.P13nRemoveItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:removeFilterItem removeFilterItem} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel fireRemoveFilterItem(sap.m.P13nRemoveItemInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:removeFilterItem removeFilterItem} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel fireRemoveFilterItem();

				#endregion

				#region Methods for Event updateFilterItem

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateFilterItem updateFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been updated.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nFilterPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachUpdateFilterItem(object oData, sap.m.P13nFilterPanel.FilterItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateFilterItem updateFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been updated.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachUpdateFilterItem(object oData, sap.m.P13nFilterPanel.FilterItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateFilterItem updateFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been updated.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachUpdateFilterItem(sap.m.P13nFilterPanel.FilterItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateFilterItem updateFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been updated.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nFilterPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachUpdateFilterItem(sap.m.P13nFilterPanel.FilterItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:updateFilterItem updateFilterItem} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel detachUpdateFilterItem(sap.m.P13nFilterPanel.FilterItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:updateFilterItem updateFilterItem} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel fireUpdateFilterItem(sap.m.P13nFilterPanel.FilterItemInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:updateFilterItem updateFilterItem} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel fireUpdateFilterItem();

				#endregion

				#region Methods for Event filterItemChanged

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterItemChanged filterItemChanged} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been changed. reason can be added, updated or removed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nFilterPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachFilterItemChanged(object oData, sap.m.P13nFilterPanel.FilterItemChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterItemChanged filterItemChanged} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been changed. reason can be added, updated or removed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachFilterItemChanged(object oData, sap.m.P13nFilterPanel.FilterItemChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterItemChanged filterItemChanged} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been changed. reason can be added, updated or removed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachFilterItemChanged(sap.m.P13nFilterPanel.FilterItemChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterItemChanged filterItemChanged} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nFilterPanel</code> itself.
				/// 
				/// Event raised if a filter item has been changed. reason can be added, updated or removed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nFilterPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel attachFilterItemChanged(sap.m.P13nFilterPanel.FilterItemChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:filterItemChanged filterItemChanged} event of this <code>sap.m.P13nFilterPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel detachFilterItemChanged(sap.m.P13nFilterPanel.FilterItemChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:filterItemChanged filterItemChanged} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel fireFilterItemChanged(sap.m.P13nFilterPanel.FilterItemChangedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:filterItemChanged filterItemChanged} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterPanel fireFilterItemChanged();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nFilterPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nFilterPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nFilterPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns the array of conditions.
				/// </summary>
				/// <returns>array of Conditions</returns>
				public extern virtual sap.m.P13nCondition[] getConditions();

				/// <summary>
				/// Getter for the exclude operations.
				/// </summary>
				/// <param name="sType">the type for which the operations are defined</param>
				/// <returns>array of operations [<code>sap.m.P13nConditionOperation.BT</code>, <code>sap.m.P13nConditionOperation.EQ</code>]</returns>
				public extern virtual sap.m.P13nConditionOperation[] getExcludeOperations(string sType);

				/// <summary>
				/// Getter for the include operations.
				/// </summary>
				/// <param name="sType">for which the operations are defined</param>
				/// <returns>array of operations [<code>sap.m.P13nConditionOperation.BT</code>, <code>sap.m.P13nConditionOperation.EQ</code>]</returns>
				public extern virtual sap.m.P13nConditionOperation getIncludeOperations(string sType);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nFilterPanel.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Removes all invalid conditions.
				/// </summary>
				public extern virtual void removeInvalidConditions();

				/// <summary>
				/// Removes all errors and warnings states from of all filter conditions.
				/// </summary>
				public extern virtual void removeValidationErrors();

				/// <summary>
				/// Sets the array of conditions.
				/// </summary>
				/// <param name="aConditions">the complete list of conditions</param>
				/// <returns>this for chaining</returns>
				public extern virtual sap.m.P13nFilterPanel setConditions(object[] aConditions);

				/// <summary>
				/// Setter for the supported exclude operations array.
				/// </summary>
				/// <param name="aOperation">array of operations [<code>sap.m.P13nConditionOperation.BT</code>, <code>sap.m.P13nConditionOperation.EQ</code>]</param>
				/// <param name="sType">the type for which the operations are defined</param>
				public extern virtual void setExcludeOperations(sap.m.P13nConditionOperation[] aOperation, string sType);

				/// <summary>
				/// Setter for the supported Include operations array.
				/// </summary>
				/// <param name="aOperation">array of operations [<code>sap.m.P13nConditionOperation.BT</code>, <code>sap.m.P13nConditionOperation.EQ</code>]</param>
				/// <param name="sType">the type for which the operations are defined</param>
				public extern virtual void setIncludeOperations(sap.m.P13nConditionOperation[] aOperation, string sType);

				/// <summary>
				/// Checks if the entered and modified conditions are correct, marks invalid fields in yellow (warning).
				/// </summary>
				/// <returns><code>True</code> if all conditions are valid, <code>false</code> otherwise.</returns>
				public extern virtual bool validateConditions();

				#endregion

				#endregion

			}
		}
	}
}
