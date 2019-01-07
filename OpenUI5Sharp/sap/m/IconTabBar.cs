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
			/// The IconTabBar represents a collection of tabs with associated content. <h3>Overview</h3> The IconTabBar can be used for navigation within an object, or as a filter. Different types of IconTabBar are used based on the contents. <ul> <li>Filter - There is only one main content for all tabs. The main content can be filtered, based on the selected tab.</li> <li>Normal tab bar - The contents of each tab are independent from each other.</li> <li>Combination of the above - There can be both filtered and independent contents.</li> </ul> <h3>Structure</h3> The IconTabBar can hold two types of entities {@link sap.m.IconTabFilter sap.m.IconTabFilter} and {@link sap.m.IconTabSeparator sap.m.IconTabSeparator}
			/// 
			/// The IconTabBarFilter holds all information on an item - text, icon and count.
			/// 
			/// The IconTabBarSeparator holds an icon that can be used to show a process that runs from item to item. <h3>Usage</h3> <h4>Text only</h4> Uses text labels as tabs with optional counter <ul> <li>Used when there are no suitable icons for all items.</li> <li>Used when longer labels are needed.</li> <li>If <code>headerMode</code> property is set to <code>Inline</code> the text and the count are displayed in one line.</li> <li><code>UpperCase</code> is disabled.</li> <li>Use title case.</li> </ul> <h4>Icon Tabs</h4> Round tabs with optional counter and label <ul> <li>Used when there are unique icons for all items.</li> <li>Only shorter labels are possible.</li> <li>Provide labels for all icons or for none. Do not mix these.</li> </ul> <h4>Tabs as filters</h4> Tabs with filtered content from the same set of items <ul> <li>Provide an <i>"All"</i> tab to show all items without filtering.</li> <li>Use counters to show the number of items in each filter.</li> </ul> <h4>Tabs as process steps</h4> Tabs show a single step in a process <ul> <li>Use an arrow (e.g. triple-chevron) as a separator to connect the steps.</li> <li>Use counters to show the number of items in each filter.</li> </ul> <h3>Responsive Behavior</h3> <ul> <li>Text-only tabs are never truncated.</li> <li>Use the <code>expandable</code> property to specify whether users can collapse the tab container (default = true).</li> <li>On desktop, tabs can be dragged and dropped (property <code>enableTabReordering</code>).</li> <li>If you have a large number of tabs, you can scroll through them with the arrows. Additionally all tabs are available in an overflow button (property <code>showOverflowSelectList</code>).</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.IconTabBar")]
			public partial class IconTabBar : sap.ui.core.Control, sap.m.ObjectHeaderContainer
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
					/// Defines whether the current selection should be visualized.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSelection;

					/// <summary>
					/// Defines if the tabs are collapsible and expandable.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expandable;

					/// <summary>
					/// Indicates if the actual tab content is expanded or not.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expanded;

					/// <summary>
					/// Key of the selected tab item.
					/// 
					/// If the key has no corresponding aggregated item, no changes will apply. If duplicate keys exists the first item matching the key is used.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedKey;

					/// <summary>
					/// Determines whether the text of the icon tab filter (not the count) is displayed in uppercase.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> upperCase;

					/// <summary>
					/// Determines whether the IconTabBar height is stretched to the maximum possible height of its parent container. As a prerequisite, the height of the parent container must be defined as a fixed value.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> stretchContentHeight;

					/// <summary>
					/// Determines whether the IconTabBar content fits to the full area. The paddings are removed if it's set to false.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> applyContentPadding;

					/// <summary>
					/// Specifies the background color of the IconTabBar.
					/// 
					/// Depending on the theme, you can change the state of the background color to "Solid", "Translucent", or "Transparent". Default is "Solid".
					/// </summary>
					public Union<sap.m.BackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

					/// <summary>
					/// Specifies the header mode. <b>Note:</b> The Inline mode works only if no icons are set.
					/// </summary>
					public Union<sap.m.IconTabHeaderMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerMode;

					/// <summary>
					/// Specifies if the overflow select list is displayed.
					/// 
					/// The overflow select list represents a list, where all tab filters are displayed, so the user can select specific tab filter easier.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showOverflowSelectList;

					/// <summary>
					/// Specifies the background color of the header.
					/// 
					/// Depending on the theme, you can change the state of the background color to "Solid", "Translucent", or "Transparent". Default is "Solid".
					/// </summary>
					public Union<sap.m.BackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerBackgroundDesign;

					/// <summary>
					/// Specifies whether tab reordering is enabled. Relevant only for desktop devices. The {@link sap.m.IconTabSeparator sap.m.IconTabSeparator} cannot be dragged and dropped Items can be moved around {@link sap.m.IconTabSeparator sap.m.IconTabSeparator}
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableTabReordering;

					/// <summary>
					/// Specifies the visual density mode of the tabs.
					/// 
					/// The values that can be applied are <code>Cozy</code>, <code>Compact</code> and <code>Inherit</code>. <code>Cozy</code> and <code>Compact</code> render the control in one of these modes independent of the global density settings. The <code>Inherit</code> value follows the global density settings which are applied. For compatibility reasons, the default value is <code>Cozy</code>.
					/// </summary>
					public Union<sap.m.IconTabDensityMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> tabDensityMode;

					/// <summary>
					/// The items displayed in the IconTabBar.
					/// </summary>
					public Union<sap.m.IconTab[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// Represents the contents displayed below the IconTabBar. If there are multiple contents, they are rendered after each other. The developer has to manage to display the right one or use the content aggregation inside the IconTabFilter (which will be displayed instead if it is set).
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					/// <summary>
					/// Fires when an item is selected.
					/// </summary>
					public sap.m.IconTabBar.SelectDelegate select;

					/// <summary>
					/// Indicates that the tab will expand or collapse.
					/// </summary>
					public sap.m.IconTabBar.ExpandDelegate expand;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ExpandInfo
				{
					/// <summary>
					/// If the tab will expand, this is true.
					/// </summary>
					public bool expand;

					/// <summary>
					/// If the tab will collapse, this is true.
					/// </summary>
					public bool collapse;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SelectInfo
				{
					/// <summary>
					/// The selected item
					/// </summary>
					public sap.m.IconTabFilter item;

					/// <summary>
					/// The key of the selected item
					/// </summary>
					public string key;

					/// <summary>
					/// The selected item
					/// </summary>
					public sap.m.IconTabFilter selectedItem;

					/// <summary>
					/// The key of the selected item
					/// </summary>
					public string selectedKey;

				}

				#endregion

				#region Delegates

				public delegate void ExpandDelegate(sap.ui.@base.Event<sap.m.IconTabBar.ExpandInfo> oEvent, object oData);

				public delegate void SelectDelegate(sap.ui.@base.Event<sap.m.IconTabBar.SelectInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new IconTabBar.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern IconTabBar(string sId, sap.m.IconTabBar.Settings mSettings);

				/// <summary>
				/// Constructor for a new IconTabBar.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern IconTabBar(string sId);

				/// <summary>
				/// Constructor for a new IconTabBar.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern IconTabBar();

				/// <summary>
				/// Constructor for a new IconTabBar.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern IconTabBar(sap.m.IconTabBar.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property showSelection

				/// <summary>
				/// Reflector for the internal header's showSelection property.
				/// </summary>
				/// <returns>The current property value.</returns>
				public extern virtual bool getShowSelection();

				/// <summary>
				/// Reflector for the internal header's showSelection property.
				/// </summary>
				/// <param name="bValue">the new value.</param>
				/// <returns>this IconTabBar reference for chaining.</returns>
				public extern virtual sap.m.IconTabBar setShowSelection(bool bValue);

				#endregion

				#region Methods for Property expandable

				/// <summary>
				/// Gets current value of property {@link #getExpandable expandable}.
				/// 
				/// Defines if the tabs are collapsible and expandable.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>expandable</code></returns>
				public extern virtual bool getExpandable();

				/// <summary>
				/// Sets the tabs as collapsible and expandable without re-rendering the control.
				/// </summary>
				/// <param name="bExpandable">New parameter value.</param>
				/// <returns>this IconTabBar reference for chaining.</returns>
				public extern virtual sap.m.IconTabBar setExpandable(bool bExpandable);

				#endregion

				#region Methods for Property expanded

				/// <summary>
				/// Gets current value of property {@link #getExpanded expanded}.
				/// 
				/// Indicates if the actual tab content is expanded or not.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>expanded</code></returns>
				public extern virtual bool getExpanded();

				/// <summary>
				/// Sets the tab content as expanded.
				/// </summary>
				/// <param name="bExpanded">New parameter value.</param>
				/// <returns>this IconTabBar reference for chaining.</returns>
				public extern virtual sap.m.IconTabBar setExpanded(bool bExpanded);

				#endregion

				#region Methods for Property selectedKey

				/// <summary>
				/// Reflector for the internal header's selectedKey property.
				/// </summary>
				/// <returns>The current property value.</returns>
				public extern virtual string getSelectedKey();

				/// <summary>
				/// Reflector for the internal header's selectedKey property.
				/// </summary>
				/// <param name="sValue">The new value.</param>
				/// <returns>this Pointer for chaining.</returns>
				public extern virtual sap.m.IconTabBar setSelectedKey(string sValue);

				#endregion

				#region Methods for Property upperCase

				/// <summary>
				/// Gets current value of property {@link #getUpperCase upperCase}.
				/// 
				/// Determines whether the text of the icon tab filter (not the count) is displayed in uppercase.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>upperCase</code></returns>
				public extern virtual bool getUpperCase();

				/// <summary>
				/// Sets a new value for property {@link #getUpperCase upperCase}.
				/// 
				/// Determines whether the text of the icon tab filter (not the count) is displayed in uppercase.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bUpperCase">New value for property <code>upperCase</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar setUpperCase(bool bUpperCase);

				#endregion

				#region Methods for Property stretchContentHeight

				/// <summary>
				/// Gets current value of property {@link #getStretchContentHeight stretchContentHeight}.
				/// 
				/// Determines whether the IconTabBar height is stretched to the maximum possible height of its parent container. As a prerequisite, the height of the parent container must be defined as a fixed value.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>stretchContentHeight</code></returns>
				public extern virtual bool getStretchContentHeight();

				/// <summary>
				/// Sets a new value for property {@link #getStretchContentHeight stretchContentHeight}.
				/// 
				/// Determines whether the IconTabBar height is stretched to the maximum possible height of its parent container. As a prerequisite, the height of the parent container must be defined as a fixed value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bStretchContentHeight">New value for property <code>stretchContentHeight</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar setStretchContentHeight(bool bStretchContentHeight);

				#endregion

				#region Methods for Property applyContentPadding

				/// <summary>
				/// Gets current value of property {@link #getApplyContentPadding applyContentPadding}.
				/// 
				/// Determines whether the IconTabBar content fits to the full area. The paddings are removed if it's set to false.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>applyContentPadding</code></returns>
				public extern virtual bool getApplyContentPadding();

				/// <summary>
				/// Sets a new value for property {@link #getApplyContentPadding applyContentPadding}.
				/// 
				/// Determines whether the IconTabBar content fits to the full area. The paddings are removed if it's set to false.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bApplyContentPadding">New value for property <code>applyContentPadding</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar setApplyContentPadding(bool bApplyContentPadding);

				#endregion

				#region Methods for Property backgroundDesign

				/// <summary>
				/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Specifies the background color of the IconTabBar.
				/// 
				/// Depending on the theme, you can change the state of the background color to "Solid", "Translucent", or "Transparent". Default is "Solid".
				/// 
				/// Default value is <code>Solid</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundDesign</code></returns>
				public extern virtual sap.m.BackgroundDesign getBackgroundDesign();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Specifies the background color of the IconTabBar.
				/// 
				/// Depending on the theme, you can change the state of the background color to "Solid", "Translucent", or "Transparent". Default is "Solid".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Solid</code>.
				/// </summary>
				/// <param name="sBackgroundDesign">New value for property <code>backgroundDesign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar setBackgroundDesign(sap.m.BackgroundDesign sBackgroundDesign);

				#endregion

				#region Methods for Property headerMode

				/// <summary>
				/// Gets current value of property {@link #getHeaderMode headerMode}.
				/// 
				/// Specifies the header mode. <b>Note:</b> The Inline mode works only if no icons are set.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <returns>Value of property <code>headerMode</code></returns>
				public extern virtual sap.m.IconTabHeaderMode getHeaderMode();

				/// <summary>
				/// Sets the header mode.
				/// </summary>
				/// <param name="mode">New parameter value.</param>
				/// <returns>this IconTabBar reference for chaining.</returns>
				public extern virtual sap.m.IconTabBar setHeaderMode(sap.m.IconTabHeaderMode mode);

				#endregion

				#region Methods for Property showOverflowSelectList

				/// <summary>
				/// Gets current value of property {@link #getShowOverflowSelectList showOverflowSelectList}.
				/// 
				/// Specifies if the overflow select list is displayed.
				/// 
				/// The overflow select list represents a list, where all tab filters are displayed, so the user can select specific tab filter easier.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showOverflowSelectList</code></returns>
				public extern virtual bool getShowOverflowSelectList();

				/// <summary>
				/// Sets the showOverflowSelectList property.
				/// </summary>
				/// <param name="value">New value for showOverflowSelectList.</param>
				/// <returns>this IconTabBar reference for chaining.</returns>
				public extern virtual sap.m.IconTabBar setShowOverflowSelectList(bool value);

				#endregion

				#region Methods for Property headerBackgroundDesign

				/// <summary>
				/// Gets current value of property {@link #getHeaderBackgroundDesign headerBackgroundDesign}.
				/// 
				/// Specifies the background color of the header.
				/// 
				/// Depending on the theme, you can change the state of the background color to "Solid", "Translucent", or "Transparent". Default is "Solid".
				/// 
				/// Default value is <code>Solid</code>.
				/// </summary>
				/// <returns>Value of property <code>headerBackgroundDesign</code></returns>
				public extern virtual sap.m.BackgroundDesign getHeaderBackgroundDesign();

				/// <summary>
				/// Sets the header background design.
				/// </summary>
				/// <param name="headerBackgroundDesign">New parameter value.</param>
				/// <returns>this IconTabBar reference for chaining.</returns>
				public extern virtual sap.m.IconTabBar setHeaderBackgroundDesign(sap.m.BackgroundDesign headerBackgroundDesign);

				#endregion

				#region Methods for Property enableTabReordering

				/// <summary>
				/// Gets current value of property {@link #getEnableTabReordering enableTabReordering}.
				/// 
				/// Specifies whether tab reordering is enabled. Relevant only for desktop devices. The {@link sap.m.IconTabSeparator sap.m.IconTabSeparator} cannot be dragged and dropped Items can be moved around {@link sap.m.IconTabSeparator sap.m.IconTabSeparator}
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableTabReordering</code></returns>
				public extern virtual bool getEnableTabReordering();

				/// <summary>
				/// Sets the enableTabReordering property.
				/// </summary>
				/// <param name="value">New value for enableTabReordering.</param>
				/// <returns>this IconTabBar reference for chaining.</returns>
				public extern virtual sap.m.IconTabBar setEnableTabReordering(bool value);

				#endregion

				#region Methods for Property tabDensityMode

				/// <summary>
				/// Gets current value of property {@link #getTabDensityMode tabDensityMode}.
				/// 
				/// Specifies the visual density mode of the tabs.
				/// 
				/// The values that can be applied are <code>Cozy</code>, <code>Compact</code> and <code>Inherit</code>. <code>Cozy</code> and <code>Compact</code> render the control in one of these modes independent of the global density settings. The <code>Inherit</code> value follows the global density settings which are applied. For compatibility reasons, the default value is <code>Cozy</code>.
				/// 
				/// Default value is <code>Cozy</code>.
				/// </summary>
				/// <returns>Value of property <code>tabDensityMode</code></returns>
				public extern virtual sap.m.IconTabDensityMode getTabDensityMode();

				/// <summary>
				/// Sets the tab density mode.
				/// </summary>
				/// <param name="mode">New parameter value.</param>
				/// <returns>this IconTabBar reference for chaining.</returns>
				public extern virtual sap.m.IconTabBar setTabDensityMode(sap.m.IconTabHeaderMode mode);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// The items displayed in the IconTabBar.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IconTab[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar insertItem(sap.m.IconTab oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar addItem(sap.m.IconTab oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.m.IconTab removeItem(Union<int, string, sap.m.IconTab> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.IconTab</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.IconTab oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.IconTab[] removeAllItems();

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// Represents the contents displayed below the IconTabBar. If there are multiple contents, they are rendered after each other. The developer has to manage to display the right one or use the content aggregation inside the IconTabFilter (which will be displayed instead if it is set).
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar addContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes a content from the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="vContent">The content to remove or its index or id</param>
				/// <returns>The removed content or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oContent">The content whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getContent content}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllContent();

				#endregion

				#region Methods for Aggregation _header

				#endregion

				#region Methods for Event select

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.IconTabBar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabBar</code> itself.
				/// 
				/// Fires when an item is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.IconTabBar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar attachSelect(object oData, sap.m.IconTabBar.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.IconTabBar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabBar</code> itself.
				/// 
				/// Fires when an item is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar attachSelect(object oData, sap.m.IconTabBar.SelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.IconTabBar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabBar</code> itself.
				/// 
				/// Fires when an item is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar attachSelect(sap.m.IconTabBar.SelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.IconTabBar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabBar</code> itself.
				/// 
				/// Fires when an item is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.IconTabBar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar attachSelect(sap.m.IconTabBar.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.m.IconTabBar</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar detachSelect(sap.m.IconTabBar.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar fireSelect(sap.m.IconTabBar.SelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar fireSelect();

				#endregion

				#region Methods for Event expand

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:expand expand} event of this <code>sap.m.IconTabBar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabBar</code> itself.
				/// 
				/// Indicates that the tab will expand or collapse.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.IconTabBar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar attachExpand(object oData, sap.m.IconTabBar.ExpandDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:expand expand} event of this <code>sap.m.IconTabBar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabBar</code> itself.
				/// 
				/// Indicates that the tab will expand or collapse.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar attachExpand(object oData, sap.m.IconTabBar.ExpandDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:expand expand} event of this <code>sap.m.IconTabBar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabBar</code> itself.
				/// 
				/// Indicates that the tab will expand or collapse.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar attachExpand(sap.m.IconTabBar.ExpandDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:expand expand} event of this <code>sap.m.IconTabBar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabBar</code> itself.
				/// 
				/// Indicates that the tab will expand or collapse.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.IconTabBar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar attachExpand(sap.m.IconTabBar.ExpandDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:expand expand} event of this <code>sap.m.IconTabBar</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar detachExpand(sap.m.IconTabBar.ExpandDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:expand expand} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar fireExpand(sap.m.IconTabBar.ExpandInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:expand expand} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabBar fireExpand();

				#endregion

				#region Other methods

				/// <summary>
				/// Clones the IconTabBar.
				/// </summary>
				/// <returns>The cloned IconTabBar.</returns>
				public extern virtual sap.m.IconTabBar clone();

				/// <summary>
				/// Creates a new subclass of class sap.m.IconTabBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.IconTabBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.IconTabBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.IconTabBar.
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
