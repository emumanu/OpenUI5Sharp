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
			/// Helps the user to sort, filter, or group data within a (master) {@link sap.m.List} or a {@link sap.m.Table}. The dialog is triggered by icon buttons in the table toolbar. Each button shows a dropdown list icon.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>ViewSettingsDialog</code> is a composite control, consisting of a modal {@link sap.m.Popover} and several internal lists. There are three different tabs (Sort, Group, Filter) in the dialog that can be activated by filling the respective associations. If only one association is filled, the other tabs are automatically hidden. The selected options can be used to create sorters and filters for the table.
			/// 
			/// <b>Note:</b> If the app does not offer all three sorting, filtering, and grouping operations, but only one of these (such as sort), we recommend placing the icon button directly in the toolbar. Do not place sort, filter, or group buttons in the footer toolbar if they refer to a table. Place group, sort, and filter buttons in the footer toolbar if they refer to a master list.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// <i>When to use?</i> <ul><li>If you need to allow the user to sort line items in a manageable list or table (up to 20 columns)</li> <li>If you need to offer custom filter settings in a manageable list or table (up to 20 columns)</li> <li>If you need to allow the user to group line items in a manageable list or table (up to 20 columns)</li></ul>
			/// 
			/// <i>When not to use?</i> <ul><li>If you have complex tables (more than 20 columns)</li> <li>If you need to rearrange columns within your table (use the {@link sap.m.TablePersoDialog} instead)</li> <li>If you need very specific sort, filter, or column sorting options within complex tables (use the {@link sap.m.P13nDialog} instead)</li></ul>
			/// 
			/// <h3>Responsive behavior</h3>
			/// 
			/// The popover dialog appears as a modal window on desktop and tablet screen sizes, but full screen on smartphones.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ViewSettingsDialog")]
			public partial class ViewSettingsDialog : sap.ui.core.Control
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
					/// Defines the title of the dialog. If not set and there is only one active tab, the dialog uses the default "View" or "Sort", "Group", "Filter" respectively.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Determines whether the sort order is descending or ascending (default).
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sortDescending;

					/// <summary>
					/// Determines whether the group order is descending or ascending (default).
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> groupDescending;

					/// <summary>
					/// Provides a string filter operator which is used when the user searches items in filter details page. Possible operators are: <code>AnyWordStartsWith</code>, <code>Contains</code>, <code>StartsWith</code>, <code>Equals</code>. This property will be ignored if a custom callback is provided through <code>setFilterSearchCallback</code> method.
					/// </summary>
					public Union<sap.m.StringFilterOperator, string, sap.ui.@base.ManagedObject.BindPropertyInfo> filterSearchOperator;

					/// <summary>
					/// The list of items with key and value that can be sorted over (for example, a list of columns for a table).
					/// </summary>
					public Union<sap.m.ViewSettingsItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> sortItems;

					/// <summary>
					/// The list of items with key and value that can be grouped on (for example, a list of columns for a table).
					/// </summary>
					public Union<sap.m.ViewSettingsItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> groupItems;

					/// <summary>
					/// The list of items with key and value that can be filtered on (for example, a list of columns for a table). A filterItem is associated with one or more detail filters.
					/// 
					/// <b>Note:</b> It is recommended to use the <code>sap.m.ViewSettingsFilterItem</code> as it fits best at the filter page.
					/// </summary>
					public Union<sap.m.ViewSettingsItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> filterItems;

					/// <summary>
					/// The list of preset filter items that allows the selection of more complex or custom filters. These entries are displayed at the top of the filter tab.
					/// </summary>
					public Union<sap.m.ViewSettingsItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> presetFilterItems;

					/// <summary>
					/// The list of all the custom tabs.
					/// </summary>
					public Union<sap.m.ViewSettingsCustomTab[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> customTabs;

					/// <summary>
					/// The sort item that is selected. It can be set by either passing a key or the item itself to the function setSelectedSortItem.
					/// </summary>
					public Union<sap.m.ViewSettingsItem, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedSortItem;

					/// <summary>
					/// The group item that is selected. It can be set by either passing a key or the item itself to the function setSelectedGroupItem. By default 'None' is selected. You can restore back to 'None' by setting this association to empty value.
					/// </summary>
					public Union<sap.m.ViewSettingsItem, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedGroupItem;

					/// <summary>
					/// The preset filter item that is selected. It can be set by either passing a key or the item itself to the function setSelectedPresetFilterItem. Note that either a preset filter OR multiple detail filters can be active at the same time.
					/// </summary>
					public Union<sap.m.ViewSettingsItem, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedPresetFilterItem;

					/// <summary>
					/// Indicates that the user has pressed the OK button and the selected sort, group, and filter settings should be applied to the data on this page. </br></br><b>Note:</b> Custom tabs are not converted to event parameters automatically. For custom tabs, you have to read the state of your controls inside the callback of this event.
					/// </summary>
					public sap.m.ViewSettingsDialog.ConfirmDelegate confirm;

					/// <summary>
					/// Called when the Cancel button is pressed. It can be used to set the state of custom filter controls.
					/// </summary>
					public sap.ui.@base.EventDelegate cancel;

					/// <summary>
					/// Called when the reset filters button is pressed. It can be used to clear the state of custom filter controls.
					/// </summary>
					public sap.ui.@base.EventDelegate resetFilters;

					/// <summary>
					/// Fired when the filter detail page is opened.
					/// </summary>
					public sap.m.ViewSettingsDialog.FilterDetailPageOpenedDelegate filterDetailPageOpened;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ConfirmInfo
				{
					/// <summary>
					/// The selected sort item.
					/// </summary>
					public sap.m.ViewSettingsItem sortItem;

					/// <summary>
					/// The selected sort order (true = descending, false = ascending).
					/// </summary>
					public bool sortDescending;

					/// <summary>
					/// The selected group item.
					/// </summary>
					public sap.m.ViewSettingsItem groupItem;

					/// <summary>
					/// The selected group order (true = descending, false = ascending).
					/// </summary>
					public bool groupDescending;

					/// <summary>
					/// The selected preset filter item.
					/// </summary>
					public sap.m.ViewSettingsItem presetFilterItem;

					/// <summary>
					/// The selected filters in an array of ViewSettingsItem.
					/// </summary>
					public sap.m.ViewSettingsItem[] filterItems;

					/// <summary>
					/// The selected filter items in an object notation format: { key: boolean }. If a custom control filter was displayed (for example, the user clicked on the filter item), the value for its key is set to true to indicate that there has been an interaction with the control.
					/// </summary>
					public object filterKeys;

					/// <summary>
					/// The selected filter items in an object notation format: { parentKey: { key: boolean, key2: boolean, ... }, ...}. If a custom control filter was displayed (for example, the user clicked on the filter item), the value for its key is set to true to indicate that there has been an interaction with the control.
					/// </summary>
					public object filterCompoundKeys;

					/// <summary>
					/// The selected filter items in a string format to display in the control's header bar in format "Filtered by: key (subkey1, subkey2, subkey3)".
					/// </summary>
					public string filterString;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class FilterDetailPageOpenedInfo
				{
					/// <summary>
					/// The filter item for which the details are opened.
					/// </summary>
					public sap.m.ViewSettingsFilterItem parentFilterItem;

				}

				#endregion

				#region Delegates

				public delegate void ConfirmDelegate(sap.ui.@base.Event<sap.m.ViewSettingsDialog.ConfirmInfo> oEvent, object oData);

				public delegate void FilterDetailPageOpenedDelegate(sap.ui.@base.Event<sap.m.ViewSettingsDialog.FilterDetailPageOpenedInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ViewSettingsDialog</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ViewSettingsDialog(string sId, sap.m.ViewSettingsDialog.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ViewSettingsDialog</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ViewSettingsDialog(string sId);

				/// <summary>
				/// Constructor for a new <code>ViewSettingsDialog</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ViewSettingsDialog();

				/// <summary>
				/// Constructor for a new <code>ViewSettingsDialog</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ViewSettingsDialog(sap.m.ViewSettingsDialog.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Defines the title of the dialog. If not set and there is only one active tab, the dialog uses the default "View" or "Sort", "Group", "Filter" respectively.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets the title of the internal dialog.
				/// </summary>
				/// <param name="sTitle">The title text for the dialog</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog setTitle(string sTitle);

				#endregion

				#region Methods for Property sortDescending

				/// <summary>
				/// Gets current value of property {@link #getSortDescending sortDescending}.
				/// 
				/// Determines whether the sort order is descending or ascending (default).
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>sortDescending</code></returns>
				public extern virtual bool getSortDescending();

				/// <summary>
				/// Sets a new value for property {@link #getSortDescending sortDescending}.
				/// 
				/// Determines whether the sort order is descending or ascending (default).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bSortDescending">New value for property <code>sortDescending</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog setSortDescending(bool bSortDescending);

				#endregion

				#region Methods for Property groupDescending

				/// <summary>
				/// Gets current value of property {@link #getGroupDescending groupDescending}.
				/// 
				/// Determines whether the group order is descending or ascending (default).
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>groupDescending</code></returns>
				public extern virtual bool getGroupDescending();

				/// <summary>
				/// Sets a new value for property {@link #getGroupDescending groupDescending}.
				/// 
				/// Determines whether the group order is descending or ascending (default).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bGroupDescending">New value for property <code>groupDescending</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog setGroupDescending(bool bGroupDescending);

				#endregion

				#region Methods for Property filterSearchOperator

				/// <summary>
				/// Gets current value of property {@link #getFilterSearchOperator filterSearchOperator}.
				/// 
				/// Provides a string filter operator which is used when the user searches items in filter details page. Possible operators are: <code>AnyWordStartsWith</code>, <code>Contains</code>, <code>StartsWith</code>, <code>Equals</code>. This property will be ignored if a custom callback is provided through <code>setFilterSearchCallback</code> method.
				/// 
				/// Default value is <code>StartsWith</code>.
				/// </summary>
				/// <returns>Value of property <code>filterSearchOperator</code></returns>
				public extern virtual sap.m.StringFilterOperator getFilterSearchOperator();

				/// <summary>
				/// Sets a new value for property {@link #getFilterSearchOperator filterSearchOperator}.
				/// 
				/// Provides a string filter operator which is used when the user searches items in filter details page. Possible operators are: <code>AnyWordStartsWith</code>, <code>Contains</code>, <code>StartsWith</code>, <code>Equals</code>. This property will be ignored if a custom callback is provided through <code>setFilterSearchCallback</code> method.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>StartsWith</code>.
				/// </summary>
				/// <param name="sFilterSearchOperator">New value for property <code>filterSearchOperator</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog setFilterSearchOperator(sap.m.StringFilterOperator sFilterSearchOperator);

				#endregion

				#region Methods for Aggregation sortItems

				/// <summary>
				/// Gets content of aggregation {@link #getSortItems sortItems}.
				/// 
				/// The list of items with key and value that can be sorted over (for example, a list of columns for a table).
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ViewSettingsItem[] getSortItems();

				/// <summary>
				/// Destroys all the sortItems in the aggregation {@link #getSortItems sortItems}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog destroySortItems();

				/// <summary>
				/// Inserts a sortItem into the aggregation {@link #getSortItems sortItems}.
				/// </summary>
				/// <param name="oSortItem">The sortItem to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the sortItem should be inserted at; for a negative value of <code>iIndex</code>, the sortItem is inserted at position 0; for a value greater than the current size of the aggregation, the sortItem is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog insertSortItem(sap.m.ViewSettingsItem oSortItem, int iIndex);

				/// <summary>
				/// Adds a sort item and sets the association to reflect the selected state.
				/// </summary>
				/// <param name="oItem">The item to be added to the aggregation</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog addSortItem(sap.m.ViewSettingsItem oItem);

				/// <summary>
				/// Removes a sortItem from the aggregation {@link #getSortItems sortItems}.
				/// </summary>
				/// <param name="vSortItem">The sortItem to remove or its index or id</param>
				/// <returns>The removed sortItem or <code>null</code></returns>
				public extern virtual sap.m.ViewSettingsItem removeSortItem(Union<int, string, sap.m.ViewSettingsItem> vSortItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.ViewSettingsItem</code> in the aggregation {@link #getSortItems sortItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oSortItem">The sortItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfSortItem(sap.m.ViewSettingsItem oSortItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getSortItems sortItems}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ViewSettingsItem[] removeAllSortItems();

				/// <summary>
				/// Binds aggregation {@link #getSortItems sortItems} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog bindSortItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getSortItems sortItems} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog unbindSortItems();

				#endregion

				#region Methods for Aggregation groupItems

				/// <summary>
				/// Gets content of aggregation {@link #getGroupItems groupItems}.
				/// 
				/// The list of items with key and value that can be grouped on (for example, a list of columns for a table).
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ViewSettingsItem[] getGroupItems();

				/// <summary>
				/// Destroys all the groupItems in the aggregation {@link #getGroupItems groupItems}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog destroyGroupItems();

				/// <summary>
				/// Inserts a groupItem into the aggregation {@link #getGroupItems groupItems}.
				/// </summary>
				/// <param name="oGroupItem">The groupItem to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the groupItem should be inserted at; for a negative value of <code>iIndex</code>, the groupItem is inserted at position 0; for a value greater than the current size of the aggregation, the groupItem is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog insertGroupItem(sap.m.ViewSettingsItem oGroupItem, int iIndex);

				/// <summary>
				/// Adds a group item and sets the association to reflect the selected state.
				/// </summary>
				/// <param name="oItem">The item to be added to the group items</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog addGroupItem(sap.m.ViewSettingsItem oItem);

				/// <summary>
				/// Removes a groupItem from the aggregation {@link #getGroupItems groupItems}.
				/// </summary>
				/// <param name="vGroupItem">The groupItem to remove or its index or id</param>
				/// <returns>The removed groupItem or <code>null</code></returns>
				public extern virtual sap.m.ViewSettingsItem removeGroupItem(Union<int, string, sap.m.ViewSettingsItem> vGroupItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.ViewSettingsItem</code> in the aggregation {@link #getGroupItems groupItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oGroupItem">The groupItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfGroupItem(sap.m.ViewSettingsItem oGroupItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getGroupItems groupItems}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ViewSettingsItem[] removeAllGroupItems();

				/// <summary>
				/// Binds aggregation {@link #getGroupItems groupItems} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog bindGroupItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getGroupItems groupItems} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog unbindGroupItems();

				#endregion

				#region Methods for Aggregation filterItems

				/// <summary>
				/// Gets content of aggregation {@link #getFilterItems filterItems}.
				/// 
				/// The list of items with key and value that can be filtered on (for example, a list of columns for a table). A filterItem is associated with one or more detail filters.
				/// 
				/// <b>Note:</b> It is recommended to use the <code>sap.m.ViewSettingsFilterItem</code> as it fits best at the filter page.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ViewSettingsItem[] getFilterItems();

				/// <summary>
				/// Destroys all the filterItems in the aggregation {@link #getFilterItems filterItems}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog destroyFilterItems();

				/// <summary>
				/// Inserts a filterItem into the aggregation {@link #getFilterItems filterItems}.
				/// </summary>
				/// <param name="oFilterItem">The filterItem to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the filterItem should be inserted at; for a negative value of <code>iIndex</code>, the filterItem is inserted at position 0; for a value greater than the current size of the aggregation, the filterItem is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog insertFilterItem(sap.m.ViewSettingsItem oFilterItem, int iIndex);

				/// <summary>
				/// Adds some filterItem to the aggregation {@link #getFilterItems filterItems}.
				/// </summary>
				/// <param name="oFilterItem">The filterItem to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog addFilterItem(sap.m.ViewSettingsItem oFilterItem);

				/// <summary>
				/// Removes a filter Item and resets the remembered page if it was the filter detail page of the removed filter.
				/// </summary>
				/// <param name="vFilterItem">The filter item's index, or the item itself, or its id</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog removeFilterItem(Union<int, sap.m.ViewSettingsFilterItem, string> vFilterItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.ViewSettingsItem</code> in the aggregation {@link #getFilterItems filterItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oFilterItem">The filterItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfFilterItem(sap.m.ViewSettingsItem oFilterItem);

				/// <summary>
				/// Removes all filter Items and resets the remembered page if it was a filter detail page and all of its filter items are being removed.
				/// </summary>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog removeAllFilterItems();

				/// <summary>
				/// Binds aggregation {@link #getFilterItems filterItems} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog bindFilterItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getFilterItems filterItems} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog unbindFilterItems();

				#endregion

				#region Methods for Aggregation presetFilterItems

				/// <summary>
				/// Gets content of aggregation {@link #getPresetFilterItems presetFilterItems}.
				/// 
				/// The list of preset filter items that allows the selection of more complex or custom filters. These entries are displayed at the top of the filter tab.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ViewSettingsItem[] getPresetFilterItems();

				/// <summary>
				/// Destroys all the presetFilterItems in the aggregation {@link #getPresetFilterItems presetFilterItems}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog destroyPresetFilterItems();

				/// <summary>
				/// Inserts a presetFilterItem into the aggregation {@link #getPresetFilterItems presetFilterItems}.
				/// </summary>
				/// <param name="oPresetFilterItem">The presetFilterItem to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the presetFilterItem should be inserted at; for a negative value of <code>iIndex</code>, the presetFilterItem is inserted at position 0; for a value greater than the current size of the aggregation, the presetFilterItem is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog insertPresetFilterItem(sap.m.ViewSettingsItem oPresetFilterItem, int iIndex);

				/// <summary>
				/// Adds a preset filter item and sets the association to reflect the selected state.
				/// </summary>
				/// <param name="oItem">The selected item or a string with the key</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog addPresetFilterItem(sap.m.ViewSettingsItem oItem);

				/// <summary>
				/// Removes a presetFilterItem from the aggregation {@link #getPresetFilterItems presetFilterItems}.
				/// </summary>
				/// <param name="vPresetFilterItem">The presetFilterItem to remove or its index or id</param>
				/// <returns>The removed presetFilterItem or <code>null</code></returns>
				public extern virtual sap.m.ViewSettingsItem removePresetFilterItem(Union<int, string, sap.m.ViewSettingsItem> vPresetFilterItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.ViewSettingsItem</code> in the aggregation {@link #getPresetFilterItems presetFilterItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oPresetFilterItem">The presetFilterItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfPresetFilterItem(sap.m.ViewSettingsItem oPresetFilterItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getPresetFilterItems presetFilterItems}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ViewSettingsItem[] removeAllPresetFilterItems();

				/// <summary>
				/// Binds aggregation {@link #getPresetFilterItems presetFilterItems} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog bindPresetFilterItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getPresetFilterItems presetFilterItems} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog unbindPresetFilterItems();

				#endregion

				#region Methods for Aggregation customTabs

				/// <summary>
				/// Gets content of aggregation {@link #getCustomTabs customTabs}.
				/// 
				/// The list of all the custom tabs.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ViewSettingsCustomTab[] getCustomTabs();

				/// <summary>
				/// Destroys all the customTabs in the aggregation {@link #getCustomTabs customTabs}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog destroyCustomTabs();

				/// <summary>
				/// Inserts a customTab into the aggregation {@link #getCustomTabs customTabs}.
				/// </summary>
				/// <param name="oCustomTab">The customTab to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the customTab should be inserted at; for a negative value of <code>iIndex</code>, the customTab is inserted at position 0; for a value greater than the current size of the aggregation, the customTab is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog insertCustomTab(sap.m.ViewSettingsCustomTab oCustomTab, int iIndex);

				/// <summary>
				/// Overwrites the aggregation setter in order to have ID validation logic as some strings are reserved for the predefined tabs.
				/// </summary>
				/// <param name="oCustomTab">The custom tab to be added</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog addCustomTab(object oCustomTab);

				/// <summary>
				/// Removes a customTab from the aggregation {@link #getCustomTabs customTabs}.
				/// </summary>
				/// <param name="vCustomTab">The customTab to remove or its index or id</param>
				/// <returns>The removed customTab or <code>null</code></returns>
				public extern virtual sap.m.ViewSettingsCustomTab removeCustomTab(Union<int, string, sap.m.ViewSettingsCustomTab> vCustomTab);

				/// <summary>
				/// Checks for the provided <code>sap.m.ViewSettingsCustomTab</code> in the aggregation {@link #getCustomTabs customTabs}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oCustomTab">The customTab whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfCustomTab(sap.m.ViewSettingsCustomTab oCustomTab);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getCustomTabs customTabs}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ViewSettingsCustomTab[] removeAllCustomTabs();

				/// <summary>
				/// Binds aggregation {@link #getCustomTabs customTabs} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog bindCustomTabs(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getCustomTabs customTabs} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog unbindCustomTabs();

				#endregion

				#region Methods for Association selectedSortItem

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedSortItem selectedSortItem}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedSortItem();

				/// <summary>
				/// Sets the selected sort item (either by key or by item).
				/// </summary>
				/// <param name="vItemOrKey">The selected item or the item's key string</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog setSelectedSortItem(Union<sap.m.ViewSettingsItem, string> vItemOrKey);

				#endregion

				#region Methods for Association selectedGroupItem

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedGroupItem selectedGroupItem}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedGroupItem();

				/// <summary>
				/// Sets the selected group item (either by key or by item).
				/// </summary>
				/// <param name="vItemOrKey">The selected item or the item's key string</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog setSelectedGroupItem(Union<sap.m.ViewSettingsItem, string> vItemOrKey);

				#endregion

				#region Methods for Association selectedPresetFilterItem

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedPresetFilterItem selectedPresetFilterItem}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedPresetFilterItem();

				/// <summary>
				/// Sets the selected preset filter item.
				/// </summary>
				/// <param name="vItemOrKey">The selected item or the item's key string</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog setSelectedPresetFilterItem(Union<sap.m.ViewSettingsItem, string> vItemOrKey);

				#endregion

				#region Methods for Event confirm

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Indicates that the user has pressed the OK button and the selected sort, group, and filter settings should be applied to the data on this page. </br></br><b>Note:</b> Custom tabs are not converted to event parameters automatically. For custom tabs, you have to read the state of your controls inside the callback of this event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachConfirm(object oData, sap.m.ViewSettingsDialog.ConfirmDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Indicates that the user has pressed the OK button and the selected sort, group, and filter settings should be applied to the data on this page. </br></br><b>Note:</b> Custom tabs are not converted to event parameters automatically. For custom tabs, you have to read the state of your controls inside the callback of this event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachConfirm(object oData, sap.m.ViewSettingsDialog.ConfirmDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Indicates that the user has pressed the OK button and the selected sort, group, and filter settings should be applied to the data on this page. </br></br><b>Note:</b> Custom tabs are not converted to event parameters automatically. For custom tabs, you have to read the state of your controls inside the callback of this event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachConfirm(sap.m.ViewSettingsDialog.ConfirmDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Indicates that the user has pressed the OK button and the selected sort, group, and filter settings should be applied to the data on this page. </br></br><b>Note:</b> Custom tabs are not converted to event parameters automatically. For custom tabs, you have to read the state of your controls inside the callback of this event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachConfirm(sap.m.ViewSettingsDialog.ConfirmDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:confirm confirm} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog detachConfirm(sap.m.ViewSettingsDialog.ConfirmDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:confirm confirm} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog fireConfirm(sap.m.ViewSettingsDialog.ConfirmInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:confirm confirm} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog fireConfirm();

				#endregion

				#region Methods for Event cancel

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Called when the Cancel button is pressed. It can be used to set the state of custom filter controls.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Called when the Cancel button is pressed. It can be used to set the state of custom filter controls.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Called when the Cancel button is pressed. It can be used to set the state of custom filter controls.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachCancel(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Called when the Cancel button is pressed. It can be used to set the state of custom filter controls.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:cancel cancel} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog detachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:cancel cancel} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog fireCancel(object mParameters);

				/// <summary>
				/// Fires event {@link #event:cancel cancel} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog fireCancel();

				#endregion

				#region Methods for Event resetFilters

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:resetFilters resetFilters} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Called when the reset filters button is pressed. It can be used to clear the state of custom filter controls.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachResetFilters(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:resetFilters resetFilters} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Called when the reset filters button is pressed. It can be used to clear the state of custom filter controls.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachResetFilters(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:resetFilters resetFilters} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Called when the reset filters button is pressed. It can be used to clear the state of custom filter controls.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachResetFilters(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:resetFilters resetFilters} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Called when the reset filters button is pressed. It can be used to clear the state of custom filter controls.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachResetFilters(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:resetFilters resetFilters} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog detachResetFilters(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:resetFilters resetFilters} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog fireResetFilters(object mParameters);

				/// <summary>
				/// Fires event {@link #event:resetFilters resetFilters} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog fireResetFilters();

				#endregion

				#region Methods for Event filterDetailPageOpened

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterDetailPageOpened filterDetailPageOpened} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Fired when the filter detail page is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachFilterDetailPageOpened(object oData, sap.m.ViewSettingsDialog.FilterDetailPageOpenedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterDetailPageOpened filterDetailPageOpened} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Fired when the filter detail page is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachFilterDetailPageOpened(object oData, sap.m.ViewSettingsDialog.FilterDetailPageOpenedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterDetailPageOpened filterDetailPageOpened} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Fired when the filter detail page is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachFilterDetailPageOpened(sap.m.ViewSettingsDialog.FilterDetailPageOpenedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterDetailPageOpened filterDetailPageOpened} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsDialog</code> itself.
				/// 
				/// Fired when the filter detail page is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog attachFilterDetailPageOpened(sap.m.ViewSettingsDialog.FilterDetailPageOpenedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:filterDetailPageOpened filterDetailPageOpened} event of this <code>sap.m.ViewSettingsDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog detachFilterDetailPageOpened(sap.m.ViewSettingsDialog.FilterDetailPageOpenedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:filterDetailPageOpened filterDetailPageOpened} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog fireFilterDetailPageOpened(sap.m.ViewSettingsDialog.FilterDetailPageOpenedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:filterDetailPageOpened filterDetailPageOpened} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog fireFilterDetailPageOpened();

				#endregion

				#region Other methods

				/// <summary>
				/// Forward method to the inner dialog method: addStyleClass.
				/// </summary>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog addStyleClass();

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Forward method to the inner dialog method: getDomRef.
				/// </summary>
				/// <returns>The Element's DOM Element sub DOM Element or null</returns>
				public extern virtual dom.HTMLElement getDomRef();

				/// <summary>
				/// Returns a metadata object for class sap.m.ViewSettingsDialog.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Gets the selected filter object in format { parent_key: { key: boolean, key2: boolean, ...}, ... }.
				/// </summary>
				/// <returns>An object with item and sub-item keys</returns>
				public extern virtual object getSelectedFilterCompoundKeys();

				/// <summary>
				/// Returns the selected filters as an array of ViewSettingsItems.
				/// 
				/// It can be used to create matching sorters and filters to apply the selected settings to the data.
				/// </summary>
				/// <returns>An array of selected filter items</returns>
				public extern virtual sap.m.ViewSettingsItem[] getSelectedFilterItems();

				/// <summary>
				/// Gets the selected filter object in format {key: boolean}.
				/// 
				/// It can be used to create matching sorters and filters to apply the selected settings to the data.
				/// </summary>
				/// <returns>An object with item and sub-item keys</returns>
				[Obsolete("Deprecated since 1.42. replaced by <code>getSelectedFilterCompoundKeys</code> method")]
				public extern virtual object getSelectedFilterKeys();

				/// <summary>
				/// Gets the filter string in format: "filter name (subfilter1 name, subfilter2 name, ...), ...". For custom and preset filters it will only add the filter name to the resulting string.
				/// </summary>
				/// <returns>The selected filter string</returns>
				public extern virtual string getSelectedFilterString();

				/// <summary>
				/// Forward method to the inner dialog method: hasStyleClass.
				/// </summary>
				/// <returns>true if the class is set, false otherwise</returns>
				public extern virtual bool hasStyleClass();

				/// <summary>
				/// Opens the ViewSettingsDialog relative to the parent control.
				/// </summary>
				/// <param name="sPageId">The ID of the initial page to be opened in the dialog. The available values are "sort", "group", "filter" or IDs of custom tabs.</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog open(string sPageId);

				/// <summary>
				/// Opens the ViewSettingsDialog relative to the parent control.
				/// </summary>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog open();

				/// <summary>
				/// Forward method to the inner dialog method: removeStyleClass.
				/// </summary>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog removeStyleClass();

				/// <summary>
				/// Forward the busy state setting to the internal dialog instance. Needed because of the not-bullet proof implementation of setBusy in sap.ui.core.Control
				/// </summary>
				/// <param name="bBusy">The busy state flag</param>
				/// <returns>this Instance for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog setBusy(bool bBusy);

				/// <summary>
				/// Sets a callback that will check the ViewSettingsItem's text against the search query. If a callback is set, <code>filterSearchOperator</code> property will be ignored, as it serves the same purpose.
				/// </summary>
				/// <param name="fnTest">A function that accepts two parameters fnTest({string} query, {string} value) and returns boolean if the value satisfies the query.</param>
				/// <returns>this instance for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog setFilterSearchCallback(object fnTest);

				/// <summary>
				/// Sets the selected filter object in format { parent_key: { key: boolean, key2: boolean, ...}, ... }.
				/// </summary>
				/// <param name="oSelectedFilterKeys">A configuration object with filter item and sub item keys in the format: { parent_key: { key: boolean, key2: boolean, ...}, ... }. Setting boolean to true will set the filter to true, false or omitting an entry will set the filter to false. It can be used to set the dialog state based on presets.</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog setSelectedFilterCompoundKeys(object oSelectedFilterKeys);

				/// <summary>
				/// Sets the selected filter object in format {key: boolean}. <b>Note:</b> Do not use duplicated item keys with this method.
				/// </summary>
				/// <param name="oSelectedFilterKeys">A configuration object with filter item and sub item keys in the format: { key: boolean }. Setting boolean to true will set the filter to true, false or omitting an entry will set the filter to false. It can be used to set the dialog state based on presets.</param>
				/// <returns>this pointer for chaining</returns>
				[Obsolete("Deprecated since 1.42. replaced by <code>setSelectedFilterCompoundKeys</code> method")]
				public extern virtual sap.m.ViewSettingsDialog setSelectedFilterKeys(object oSelectedFilterKeys);

				/// <summary>
				/// Forward method to the inner dialog method: toggleStyleClass.
				/// </summary>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsDialog toggleStyleClass();

				#endregion

				#endregion

			}
		}
	}
}
