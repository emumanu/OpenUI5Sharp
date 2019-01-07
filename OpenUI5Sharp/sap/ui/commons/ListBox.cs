using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class commons
			{
				/// <summary>
				/// Provides a list of items from which users can choose an item. For the design of the list box, features such as defining the list box height, fixing the number of visible items, choosing one item to be the item that is marked by default when the list box is shown, or a scroll bar for large list boxes are available.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ListBox")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.List</code> control.")]
				public partial class ListBox : sap.ui.core.Control
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
						/// Determines whether the ListBox is interactive or not. Can be used to disable interaction with mouse or keyboard.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

						/// <summary>
						/// Determines whether the ListBox is enabled or not. Can be used to disable interaction with mouse or keyboard. Disabled controls have another color display depending on custom settings.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Determines whether multiple selection is allowed.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> allowMultiSelect;

						/// <summary>
						/// Control width as common CSS-size (px or % as unit, for example).
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Control height as common CSS-size (px or % as unit, for example). The setting overrides any definitions made for the setVisibleItems() method.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Scroll bar position from the top. Setting the scrollTop property and calling scrollToIndex are two operations influencing the same "physical" property, so the last call "wins".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollTop;

						/// <summary>
						/// Determines whether the icons of the list items shall also be displayed. Enabling icons requires some space to be reserved for them. Displaying icons can also influence the width and height of a single item, which affects the overall height of the ListBox when defined in number of items. Note that the number of icons that can be displayed in the ListBox depends on the size of the icons themselves and of the total ListBox height.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayIcons;

						/// <summary>
						/// Determines whether the text values from the additionalText property (see sap.ui.core.ListItems) shall be displayed.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displaySecondaryValues;

						/// <summary>
						/// Determines the text alignment in the primary ListBox column.
						/// </summary>
						public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueTextAlign;

						/// <summary>
						/// Determines the text alignment in the secondary ListBox text column (if available).
						/// </summary>
						public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> secondaryValueTextAlign;

						/// <summary>
						/// Determines the minimum width of the ListBox. If not set, there is no minimum width.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minWidth;

						/// <summary>
						/// Determines the maximum width of the ListBox. If not set, there is no maximum width.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxWidth;

						/// <summary>
						/// The ListBox height in number of items that are initially displayed without scrolling. This setting overwrites height settings in terms of CSS size that have been made. When the items have different heights, the height of the first item is used for all other item height calculations. Note that if there are one or more separators between the visible ListBox items, the displayed items might not relate 1:1 to the initially specified number of items. When the value is retrieved, it equals the previously set value if it was set; otherwise, it will be the number of items completely fitting into the ListBox without scrolling in the case the control was already rendered. Note that if the control was not rendered, the behavior will be undefined, it may return -1 or any other number.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleItems;

						/// <summary>
						/// Aggregation of items to be displayed. Must be either of type sap.ui.core.ListItem or sap.ui.core.SeparatorItem.
						/// </summary>
						public Union<sap.ui.core.Item[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

						/// <summary>
						/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

						/// <summary>
						/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Event is fired when selection is changed by user interaction.
						/// </summary>
						public sap.ui.commons.ListBox.SelectDelegate select;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SelectInfo
					{
						/// <summary>
						/// ID of the ListBox which triggered the event.
						/// </summary>
						public string id;

						/// <summary>
						/// The currently selected index of the ListBox. In the case of multiple selection, this is exactly one of the selected indices - the one whose selection has triggered the selection change. To get all currently selected indices, use selectedIndices.
						/// </summary>
						public int selectedIndex;

						/// <summary>
						/// The currently selected item of the ListBox. In the case of multiple selection, this is exactly one of the selected items - the one whose selection has triggered the selection change.
						/// </summary>
						public sap.ui.core.Item selectedItem;

						/// <summary>
						/// Array containing the indices which are selected.
						/// </summary>
						public int[] selectedIndices;

					}

					#endregion

					#region Delegates

					public delegate void SelectDelegate(sap.ui.@base.Event<sap.ui.commons.ListBox.SelectInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ListBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ListBox(string sId, sap.ui.commons.ListBox.Settings mSettings);

					/// <summary>
					/// Constructor for a new ListBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern ListBox(string sId);

					/// <summary>
					/// Constructor for a new ListBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ListBox();

					/// <summary>
					/// Constructor for a new ListBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ListBox(sap.ui.commons.ListBox.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property editable

					/// <summary>
					/// Gets current value of property {@link #getEditable editable}.
					/// 
					/// Determines whether the ListBox is interactive or not. Can be used to disable interaction with mouse or keyboard.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>editable</code></returns>
					public extern virtual bool getEditable();

					/// <summary>
					/// Sets a new value for property {@link #getEditable editable}.
					/// 
					/// Determines whether the ListBox is interactive or not. Can be used to disable interaction with mouse or keyboard.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEditable">New value for property <code>editable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox setEditable(bool bEditable);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Determines whether the ListBox is enabled or not. Can be used to disable interaction with mouse or keyboard. Disabled controls have another color display depending on custom settings.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// Determines whether the ListBox is enabled or not. Can be used to disable interaction with mouse or keyboard. Disabled controls have another color display depending on custom settings.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property allowMultiSelect

					/// <summary>
					/// Gets current value of property {@link #getAllowMultiSelect allowMultiSelect}.
					/// 
					/// Determines whether multiple selection is allowed.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>allowMultiSelect</code></returns>
					public extern virtual bool getAllowMultiSelect();

					/// <summary>
					/// Sets a new value for property {@link #getAllowMultiSelect allowMultiSelect}.
					/// 
					/// Determines whether multiple selection is allowed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bAllowMultiSelect">New value for property <code>allowMultiSelect</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox setAllowMultiSelect(bool bAllowMultiSelect);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Control width as common CSS-size (px or % as unit, for example).
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets the width of this ListBox in CSS units.
					/// </summary>
					/// <param name="sWidth">New width for the ListBox.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Control height as common CSS-size (px or % as unit, for example). The setting overrides any definitions made for the setVisibleItems() method.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets the height of this ListBox in CSS units.
					/// </summary>
					/// <param name="sHeight">New height for the ListBox.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property scrollTop

					/// <summary>
					/// Returns how many pixels the ListBox contents are currently scrolled down.
					/// </summary>
					/// <returns>Vertical scroll position.</returns>
					public extern virtual int getScrollTop();

					/// <summary>
					/// Positions the ListBox contents so that they are scrolled-down by the given number of pixels.
					/// </summary>
					/// <param name="iScrollTop">Vertical scroll position in pixels.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox setScrollTop(int iScrollTop);

					#endregion

					#region Methods for Property displayIcons

					/// <summary>
					/// Gets current value of property {@link #getDisplayIcons displayIcons}.
					/// 
					/// Determines whether the icons of the list items shall also be displayed. Enabling icons requires some space to be reserved for them. Displaying icons can also influence the width and height of a single item, which affects the overall height of the ListBox when defined in number of items. Note that the number of icons that can be displayed in the ListBox depends on the size of the icons themselves and of the total ListBox height.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>displayIcons</code></returns>
					public extern virtual bool getDisplayIcons();

					/// <summary>
					/// Sets a new value for property {@link #getDisplayIcons displayIcons}.
					/// 
					/// Determines whether the icons of the list items shall also be displayed. Enabling icons requires some space to be reserved for them. Displaying icons can also influence the width and height of a single item, which affects the overall height of the ListBox when defined in number of items. Note that the number of icons that can be displayed in the ListBox depends on the size of the icons themselves and of the total ListBox height.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bDisplayIcons">New value for property <code>displayIcons</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox setDisplayIcons(bool bDisplayIcons);

					#endregion

					#region Methods for Property displaySecondaryValues

					/// <summary>
					/// Gets current value of property {@link #getDisplaySecondaryValues displaySecondaryValues}.
					/// 
					/// Determines whether the text values from the additionalText property (see sap.ui.core.ListItems) shall be displayed.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>displaySecondaryValues</code></returns>
					public extern virtual bool getDisplaySecondaryValues();

					/// <summary>
					/// Sets a new value for property {@link #getDisplaySecondaryValues displaySecondaryValues}.
					/// 
					/// Determines whether the text values from the additionalText property (see sap.ui.core.ListItems) shall be displayed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bDisplaySecondaryValues">New value for property <code>displaySecondaryValues</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox setDisplaySecondaryValues(bool bDisplaySecondaryValues);

					#endregion

					#region Methods for Property valueTextAlign

					/// <summary>
					/// Gets current value of property {@link #getValueTextAlign valueTextAlign}.
					/// 
					/// Determines the text alignment in the primary ListBox column.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <returns>Value of property <code>valueTextAlign</code></returns>
					public extern virtual sap.ui.core.TextAlign getValueTextAlign();

					/// <summary>
					/// Sets a new value for property {@link #getValueTextAlign valueTextAlign}.
					/// 
					/// Determines the text alignment in the primary ListBox column.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <param name="sValueTextAlign">New value for property <code>valueTextAlign</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox setValueTextAlign(sap.ui.core.TextAlign sValueTextAlign);

					#endregion

					#region Methods for Property secondaryValueTextAlign

					/// <summary>
					/// Gets current value of property {@link #getSecondaryValueTextAlign secondaryValueTextAlign}.
					/// 
					/// Determines the text alignment in the secondary ListBox text column (if available).
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <returns>Value of property <code>secondaryValueTextAlign</code></returns>
					public extern virtual sap.ui.core.TextAlign getSecondaryValueTextAlign();

					/// <summary>
					/// Sets a new value for property {@link #getSecondaryValueTextAlign secondaryValueTextAlign}.
					/// 
					/// Determines the text alignment in the secondary ListBox text column (if available).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <param name="sSecondaryValueTextAlign">New value for property <code>secondaryValueTextAlign</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox setSecondaryValueTextAlign(sap.ui.core.TextAlign sSecondaryValueTextAlign);

					#endregion

					#region Methods for Property minWidth

					/// <summary>
					/// Gets current value of property {@link #getMinWidth minWidth}.
					/// 
					/// Determines the minimum width of the ListBox. If not set, there is no minimum width.
					/// </summary>
					/// <returns>Value of property <code>minWidth</code></returns>
					public extern virtual sap.ui.core.CSSSize getMinWidth();

					/// <summary>
					/// Sets a new value for property {@link #getMinWidth minWidth}.
					/// 
					/// Determines the minimum width of the ListBox. If not set, there is no minimum width.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMinWidth">New value for property <code>minWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox setMinWidth(sap.ui.core.CSSSize sMinWidth);

					#endregion

					#region Methods for Property maxWidth

					/// <summary>
					/// Gets current value of property {@link #getMaxWidth maxWidth}.
					/// 
					/// Determines the maximum width of the ListBox. If not set, there is no maximum width.
					/// </summary>
					/// <returns>Value of property <code>maxWidth</code></returns>
					public extern virtual sap.ui.core.CSSSize getMaxWidth();

					/// <summary>
					/// Sets a new value for property {@link #getMaxWidth maxWidth}.
					/// 
					/// Determines the maximum width of the ListBox. If not set, there is no maximum width.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMaxWidth">New value for property <code>maxWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox setMaxWidth(sap.ui.core.CSSSize sMaxWidth);

					#endregion

					#region Methods for Property visibleItems

					/// <summary>
					/// Returns the number of visible items.
					/// </summary>
					/// <returns>Number of visible items.</returns>
					public extern virtual int getVisibleItems();

					/// <summary>
					/// Makes the ListBox render with a height that allows it to display exactly the given number of items.
					/// </summary>
					/// <param name="iItemCount">The number of items that should fit into the ListBox without scrolling.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox setVisibleItems(int iItemCount);

					#endregion

					#region Methods for Aggregation items

					/// <summary>
					/// Gets content of aggregation {@link #getItems items}.
					/// 
					/// Aggregation of items to be displayed. Must be either of type sap.ui.core.ListItem or sap.ui.core.SeparatorItem.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Item[] getItems();

					/// <summary>
					/// Destroys all the items in the aggregation {@link #getItems items}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox destroyItems();

					/// <summary>
					/// Inserts a item into the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox insertItem(sap.ui.core.Item oItem, int iIndex);

					/// <summary>
					/// Adds some item to the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox addItem(sap.ui.core.Item oItem);

					/// <summary>
					/// Removes a item from the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="vItem">The item to remove or its index or id</param>
					/// <returns>The removed item or <code>null</code></returns>
					public extern virtual sap.ui.core.Item removeItem(Union<int, string, sap.ui.core.Item> vItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Item</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oItem">The item whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfItem(sap.ui.core.Item oItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getItems items}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Item[] removeAllItems();

					#endregion

					#region Methods for Association ariaDescribedBy

					/// <summary>
					/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID[] getAriaDescribedBy();

					/// <summary>
					/// Adds some ariaDescribedBy into the association {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <param name="vAriaDescribedBy">The ariaDescribedBy to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

					/// <summary>
					/// Removes an ariaDescribedBy from the association named {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <param name="vAriaDescribedBy">The ariaDescribedBy to be removed or its index or ID</param>
					/// <returns>The removed ariaDescribedBy or <code>null</code></returns>
					public extern virtual sap.ui.core.ID removeAriaDescribedBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

					/// <summary>
					/// Removes all the controls in the association named {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ID[] removeAllAriaDescribedBy();

					#endregion

					#region Methods for Association ariaLabelledBy

					/// <summary>
					/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID[] getAriaLabelledBy();

					/// <summary>
					/// Adds some ariaLabelledBy into the association {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <param name="vAriaLabelledBy">The ariaLabelledBy to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

					/// <summary>
					/// Removes an ariaLabelledBy from the association named {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <param name="vAriaLabelledBy">The ariaLabelledBy to be removed or its index or ID</param>
					/// <returns>The removed ariaLabelledBy or <code>null</code></returns>
					public extern virtual sap.ui.core.ID removeAriaLabelledBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

					/// <summary>
					/// Removes all the controls in the association named {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ID[] removeAllAriaLabelledBy();

					#endregion

					#region Methods for Event select

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.ListBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ListBox</code> itself.
					/// 
					/// Event is fired when selection is changed by user interaction.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.ListBox</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox attachSelect(object oData, sap.ui.commons.ListBox.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.ListBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ListBox</code> itself.
					/// 
					/// Event is fired when selection is changed by user interaction.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox attachSelect(object oData, sap.ui.commons.ListBox.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.ListBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ListBox</code> itself.
					/// 
					/// Event is fired when selection is changed by user interaction.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox attachSelect(sap.ui.commons.ListBox.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.ListBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ListBox</code> itself.
					/// 
					/// Event is fired when selection is changed by user interaction.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.ListBox</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox attachSelect(sap.ui.commons.ListBox.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.commons.ListBox</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox detachSelect(sap.ui.commons.ListBox.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox fireSelect(sap.ui.commons.ListBox.SelectInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ListBox fireSelect();

					#endregion

					#region Other methods

					/// <summary>
					/// Adds the given index to current selection. When multiple selection is disabled, this replaces the current selection. When the given index is invalid, the call is ignored.
					/// </summary>
					/// <param name="iSelectedIndex">Index to add to selection..</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox addSelectedIndex(int iSelectedIndex);

					/// <summary>
					/// Adds the given indices to selection. Any invalid indices are ignored.
					/// </summary>
					/// <param name="aSelectedIndices">Indices of the items that shall additionally be selected.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox addSelectedIndices(int[] aSelectedIndices);

					/// <summary>
					/// Removes complete selection.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox clearSelection();

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ListBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ListBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ListBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.ListBox.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Zero-based index of selected item. Index value for no selection is -1. When multiple selection is enabled and multiple items are selected, the method returns the first selected item.
					/// </summary>
					/// <returns>Selected index</returns>
					public extern virtual int getSelectedIndex();

					/// <summary>
					/// Zero-based indices of selected items, wrapped in an array. An empty array means "no selection".
					/// </summary>
					/// <returns>Array of selected indices.</returns>
					public extern virtual int[] getSelectedIndices();

					/// <summary>
					/// Returns selected item. When no item is selected, "null" is returned. When multi-selection is enabled and multiple items are selected, only the first selected item is returned.
					/// </summary>
					/// <returns>Selected item</returns>
					public extern virtual sap.ui.core.Item getSelectedItem();

					/// <summary>
					/// Returns an array containing the selected items. In the case of no selection, an empty array is returned.
					/// </summary>
					/// <returns>Selected items.</returns>
					public extern virtual sap.ui.core.Item[] getSelectedItems();

					/// <summary>
					/// Returns the keys of the selected items in an array. If a selected item does not have a key, the respective array entry will be undefined.
					/// </summary>
					/// <returns>Array with selected keys.</returns>
					public extern virtual string[] getSelectedKeys();

					/// <summary>
					/// Returns whether the given index is selected.
					/// </summary>
					/// <param name="iIndex">Index which is checked for selection state.</param>
					/// <returns>Whether index is selected.</returns>
					public extern virtual bool isIndexSelected(int iIndex);

					/// <summary>
					/// Removes the given index from this selection. When the index is invalid or not selected, the call is ignored.
					/// </summary>
					/// <param name="iIndex">Index that shall be removed from selection.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox removeSelectedIndex(int iIndex);

					/// <summary>
					/// If the ListBox has a scroll bar because the number of items is larger than the number of visible items, this method scrolls to the item with the given index. If there are enough items, this item will then appear at the topmost visible position in the ListBox. If bLazy is true, it only scrolls as far as required to make the item visible. Setting the scrollTop property and calling scrollToIndex are two operations influencing the same "physical" property, so the last call "wins".
					/// </summary>
					/// <param name="iIndex">The index to which the ListBox should scroll.</param>
					/// <param name="bLazy">If set to true, the ListBox only scrolls if the item is not completely visible, and it scrolls for exactly the space to make it fully visible. If set to false, the item is scrolled to the top position (if possible).</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox scrollToIndex(int iIndex, bool bLazy);

					/// <summary>
					/// Allows setting the list items as array for this instance of ListBox.
					/// </summary>
					/// <param name="aItems">The items to set for this ListBox.</param>
					/// <param name="bDestroyItems">Optional boolean parameter to indicate that the formerly set items should be destroyed, instead of just removed.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox setItems(sap.ui.core.ListItem[] aItems, bool bDestroyItems);

					/// <summary>
					/// Sets the zero-based index of the currently selected item. This method removes any previous selections. When the given index is invalid, the call is ignored.
					/// </summary>
					/// <param name="iSelectedIndex">Index to be selected.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox setSelectedIndex(int iSelectedIndex);

					/// <summary>
					/// Zero-based indices of selected items, wrapped in an array. An empty array means "no selection". When multiple selection is disabled and multiple items are given, the selection is set to the index of the first valid index in the given array. Any invalid indices are ignored. The previous selection is in any case replaced.
					/// </summary>
					/// <param name="aSelectedIndices">Indices of the items to be selected.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox setSelectedIndices(int[] aSelectedIndices);

					/// <summary>
					/// Keys of the items to be selected, wrapped in an array. An empty array means no selection. When multiple selection is disabled, and multiple keys are given, the selection is set to the item with the first valid key in the given array. Any invalid keys are ignored. The previous selection is replaced in any case.
					/// </summary>
					/// <param name="aSelectedKeys">The keys of the items to be selected.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox setSelectedKeys(string[] aSelectedKeys);

					/// <summary>
					/// Keys of the items to be selected, wrapped in an array. An empty array means no selection. When multiple selection is disabled, and multiple keys are given, the selection is set to the item with the first valid key in the given array. Any invalid keys are ignored. The previous selection is replaced in any case.
					/// </summary>
					/// <param name="aSelectedKeys">The keys of the items to be selected.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ListBox setSelectedKeys(object[] aSelectedKeys);

					#endregion

					#endregion

				}
			}
		}
	}
}
