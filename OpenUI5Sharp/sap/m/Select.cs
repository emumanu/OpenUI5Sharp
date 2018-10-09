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
			/// The <code>sap.m.Select</code> control provides a list of items that allows users to select an item.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Select")]
			public partial class Select : sap.ui.core.Control, sap.ui.core.IFormContent
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
					/// The name to be used in the HTML code (for example, for HTML forms that send data to the server via submit).
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

					/// <summary>
					/// Indicates whether the user can change the selection.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

					/// <summary>
					/// Sets the width of the field. By default, the field width is automatically adjusted to the size of its content and the default width of the field is calculated based on the widest list item in the dropdown list. If the width defined is smaller than its content, only the field width is changed whereas the dropdown list keeps the width of its content. If the dropdown list is wider than the visual viewport, it is truncated and an ellipsis is displayed for each item. For phones, the width of the dropdown list is always the same as the viewport.
					/// 
					/// <b>Note:</b> This property is ignored if the <code>autoAdjustWidth</code> property is set to <code>true</code>.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Sets the maximum width of the control.
					/// 
					/// <b>Note:</b> This property is ignored if the <code>autoAdjustWidth</code> property is set to <code>true</code>.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxWidth;

					/// <summary>
					/// Key of the selected item.
					/// 
					/// <b>Note:</b> If duplicate keys exist, the first item matching the key is used.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedKey;

					/// <summary>
					/// ID of the selected item.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedItemId;

					/// <summary>
					/// The URI to the icon that will be displayed only when using the <code>IconOnly</code> type.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// Type of a select. Possible values <code>Default</code>, <code>IconOnly</code>.
					/// </summary>
					public Union<sap.m.SelectType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					/// <summary>
					/// Indicates whether the width of the input field is determined by the selected item's content.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> autoAdjustWidth;

					/// <summary>
					/// Sets the horizontal alignment of the text within the input field.
					/// </summary>
					public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textAlign;

					/// <summary>
					/// Specifies the direction of the text within the input field with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

					/// <summary>
					/// Visualizes the validation state of the control, e.g. <code>Error</code>, <code>Warning</code>, <code>Success</code>.
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

					/// <summary>
					/// Defines the text of the value state message popup. If this is not specified, a default text is shown from the resource bundle.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueStateText;

					/// <summary>
					/// Indicates whether the text values of the <code>additionalText</code> property of a {@link sap.ui.core.ListItem} are shown.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSecondaryValues;

					/// <summary>
					/// Indicates whether the selection is restricted to one of the items in the list. <b>Note:</b> We strongly recommend that you always set this property to <code>false</code> and bind the <code>selectedKey</code> property to the desired value for better interoperability with data binding.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> forceSelection;

					/// <summary>
					/// Defines the items contained within this control.
					/// </summary>
					public Union<sap.ui.core.Item[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// Sets or retrieves the selected item from the aggregation named items.
					/// </summary>
					public Union<sap.ui.core.Item, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedItem;

					/// <summary>
					/// Association to controls / IDs which label this control (see WAI-ARIA attribute <code>aria-labelledby</code>).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// This event is fired when the value in the selection field is changed in combination with one of the following actions: <ul> <li>The focus leaves the selection field</li> <li>The <i>Enter</i> key is pressed</li> <li>The item is pressed</li> </ul>
					/// </summary>
					public sap.m.SelectionChangeDelegate change;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>sap.m.Select</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				/// <param name="mSettings">Initial settings for the new control.</param>
				public extern Select(string sId, sap.m.Select.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>sap.m.Select</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				public extern Select(string sId);

				/// <summary>
				/// Constructor for a new <code>sap.m.Select</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Select();

				/// <summary>
				/// Constructor for a new <code>sap.m.Select</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control.</param>
				public extern Select(sap.m.Select.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property name

				/// <summary>
				/// Gets current value of property {@link #getName name}.
				/// 
				/// The name to be used in the HTML code (for example, for HTML forms that send data to the server via submit).
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>name</code></returns>
				public extern virtual string getName();

				/// <summary>
				/// Sets a new value for property {@link #getName name}.
				/// 
				/// The name to be used in the HTML code (for example, for HTML forms that send data to the server via submit).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sName">New value for property <code>name</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setName(string sName);

				#endregion

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Indicates whether the user can change the selection.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Indicates whether the user can change the selection.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Sets the width of the field. By default, the field width is automatically adjusted to the size of its content and the default width of the field is calculated based on the widest list item in the dropdown list. If the width defined is smaller than its content, only the field width is changed whereas the dropdown list keeps the width of its content. If the dropdown list is wider than the visual viewport, it is truncated and an ellipsis is displayed for each item. For phones, the width of the dropdown list is always the same as the viewport.
				/// 
				/// <b>Note:</b> This property is ignored if the <code>autoAdjustWidth</code> property is set to <code>true</code>.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Sets the width of the field. By default, the field width is automatically adjusted to the size of its content and the default width of the field is calculated based on the widest list item in the dropdown list. If the width defined is smaller than its content, only the field width is changed whereas the dropdown list keeps the width of its content. If the dropdown list is wider than the visual viewport, it is truncated and an ellipsis is displayed for each item. For phones, the width of the dropdown list is always the same as the viewport.
				/// 
				/// <b>Note:</b> This property is ignored if the <code>autoAdjustWidth</code> property is set to <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property maxWidth

				/// <summary>
				/// Gets current value of property {@link #getMaxWidth maxWidth}.
				/// 
				/// Sets the maximum width of the control.
				/// 
				/// <b>Note:</b> This property is ignored if the <code>autoAdjustWidth</code> property is set to <code>true</code>.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>maxWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getMaxWidth();

				/// <summary>
				/// Sets a new value for property {@link #getMaxWidth maxWidth}.
				/// 
				/// Sets the maximum width of the control.
				/// 
				/// <b>Note:</b> This property is ignored if the <code>autoAdjustWidth</code> property is set to <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sMaxWidth">New value for property <code>maxWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setMaxWidth(sap.ui.core.CSSSize sMaxWidth);

				#endregion

				#region Methods for Property selectedKey

				/// <summary>
				/// Gets current value of property {@link #getSelectedKey selectedKey}.
				/// 
				/// Key of the selected item.
				/// 
				/// <b>Note:</b> If duplicate keys exist, the first item matching the key is used.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>selectedKey</code></returns>
				public extern virtual string getSelectedKey();

				/// <summary>
				/// Sets property <code>selectedKey</code>.
				/// 
				/// Default value is an empty string <code>""</code> or <code>undefined</code>.
				/// </summary>
				/// <param name="sKey">New value for property <code>selectedKey</code>. If the <code>forceSelection</code> property is set to <code>true</code> and the provided <code>sKey</code> is an empty string <code>""</code> or <code>undefined</code>, the value of <code>sKey</code> is changed to match the <code>key</code> of the first enabled item and the first enabled item is selected (if any items exist).
				/// 
				/// In the case that an item has the default key value, it is selected instead. If duplicate keys exist, the first item matching the key is selected.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Select setSelectedKey(string sKey);

				#endregion

				#region Methods for Property selectedItemId

				/// <summary>
				/// Gets current value of property {@link #getSelectedItemId selectedItemId}.
				/// 
				/// ID of the selected item.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>selectedItemId</code></returns>
				public extern virtual string getSelectedItemId();

				/// <summary>
				/// Sets the <code>selectedItemId</code> property.
				/// 
				/// Default value is an empty string <code>""</code> or <code>undefined</code>.
				/// </summary>
				/// <param name="vItem">New value for property <code>selectedItemId</code>. If the provided <code>vItem</code> has a default value, the first enabled item will be selected (if any items exist).</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Select setSelectedItemId(string vItem);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// The URI to the icon that will be displayed only when using the <code>IconOnly</code> type.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// The URI to the icon that will be displayed only when using the <code>IconOnly</code> type.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// Type of a select. Possible values <code>Default</code>, <code>IconOnly</code>.
				/// 
				/// Default value is <code>Default</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.m.SelectType getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// Type of a select. Possible values <code>Default</code>, <code>IconOnly</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Default</code>.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setType(sap.m.SelectType sType);

				#endregion

				#region Methods for Property autoAdjustWidth

				/// <summary>
				/// Gets current value of property {@link #getAutoAdjustWidth autoAdjustWidth}.
				/// 
				/// Indicates whether the width of the input field is determined by the selected item's content.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>autoAdjustWidth</code></returns>
				public extern virtual bool getAutoAdjustWidth();

				/// <summary>
				/// Sets a new value for property {@link #getAutoAdjustWidth autoAdjustWidth}.
				/// 
				/// Indicates whether the width of the input field is determined by the selected item's content.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bAutoAdjustWidth">New value for property <code>autoAdjustWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setAutoAdjustWidth(bool bAutoAdjustWidth);

				#endregion

				#region Methods for Property textAlign

				/// <summary>
				/// Gets current value of property {@link #getTextAlign textAlign}.
				/// 
				/// Sets the horizontal alignment of the text within the input field.
				/// 
				/// Default value is <code>Initial</code>.
				/// </summary>
				/// <returns>Value of property <code>textAlign</code></returns>
				public extern virtual sap.ui.core.TextAlign getTextAlign();

				/// <summary>
				/// Sets a new value for property {@link #getTextAlign textAlign}.
				/// 
				/// Sets the horizontal alignment of the text within the input field.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Initial</code>.
				/// </summary>
				/// <param name="sTextAlign">New value for property <code>textAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setTextAlign(sap.ui.core.TextAlign sTextAlign);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Specifies the direction of the text within the input field with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Specifies the direction of the text within the input field with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Property valueState

				/// <summary>
				/// Gets current value of property {@link #getValueState valueState}.
				/// 
				/// Visualizes the validation state of the control, e.g. <code>Error</code>, <code>Warning</code>, <code>Success</code>.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>valueState</code></returns>
				public extern virtual sap.ui.core.ValueState getValueState();

				/// <summary>
				/// Sets a new value for property {@link #getValueState valueState}.
				/// 
				/// Visualizes the validation state of the control, e.g. <code>Error</code>, <code>Warning</code>, <code>Success</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sValueState">New value for property <code>valueState</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setValueState(sap.ui.core.ValueState sValueState);

				#endregion

				#region Methods for Property valueStateText

				/// <summary>
				/// Gets current value of property {@link #getValueStateText valueStateText}.
				/// 
				/// Defines the text of the value state message popup. If this is not specified, a default text is shown from the resource bundle.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>valueStateText</code></returns>
				public extern virtual string getValueStateText();

				/// <summary>
				/// Sets a new value for property {@link #getValueStateText valueStateText}.
				/// 
				/// Defines the text of the value state message popup. If this is not specified, a default text is shown from the resource bundle.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sValueStateText">New value for property <code>valueStateText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setValueStateText(string sValueStateText);

				#endregion

				#region Methods for Property showSecondaryValues

				/// <summary>
				/// Gets current value of property {@link #getShowSecondaryValues showSecondaryValues}.
				/// 
				/// Indicates whether the text values of the <code>additionalText</code> property of a {@link sap.ui.core.ListItem} are shown.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showSecondaryValues</code></returns>
				public extern virtual bool getShowSecondaryValues();

				/// <summary>
				/// Sets a new value for property {@link #getShowSecondaryValues showSecondaryValues}.
				/// 
				/// Indicates whether the text values of the <code>additionalText</code> property of a {@link sap.ui.core.ListItem} are shown.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowSecondaryValues">New value for property <code>showSecondaryValues</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setShowSecondaryValues(bool bShowSecondaryValues);

				#endregion

				#region Methods for Property forceSelection

				/// <summary>
				/// Gets current value of property {@link #getForceSelection forceSelection}.
				/// 
				/// Indicates whether the selection is restricted to one of the items in the list. <b>Note:</b> We strongly recommend that you always set this property to <code>false</code> and bind the <code>selectedKey</code> property to the desired value for better interoperability with data binding.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>forceSelection</code></returns>
				public extern virtual bool getForceSelection();

				/// <summary>
				/// Sets a new value for property {@link #getForceSelection forceSelection}.
				/// 
				/// Indicates whether the selection is restricted to one of the items in the list. <b>Note:</b> We strongly recommend that you always set this property to <code>false</code> and bind the <code>selectedKey</code> property to the desired value for better interoperability with data binding.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bForceSelection">New value for property <code>forceSelection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select setForceSelection(bool bForceSelection);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets aggregation <code>items</code>.
				/// 
				/// <b>Note</b>: This is the default aggregation.
				/// </summary>
				/// <returns>The controls in the <code>items</code> aggregation</returns>
				public extern virtual sap.ui.core.Item[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation named <code>items</code>.
				/// </summary>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Select destroyItems();

				/// <summary>
				/// Inserts an item into the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="oItem">The item to be inserted; if empty, nothing is inserted.</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Select insertItem(sap.ui.core.Item oItem, int iIndex);

				/// <summary>
				/// Adds an item to the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="oItem">The item to be added; if empty, nothing is added.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Select addItem(sap.ui.core.Item oItem);

				/// <summary>
				/// Removes an item from the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="vItem">The item to be removed or its index or ID.</param>
				/// <returns>The removed item or null.</returns>
				public extern virtual sap.ui.core.Item removeItem(Union<int, string, sap.ui.core.Item> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Item</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.ui.core.Item oItem);

				/// <summary>
				/// Removes all the items in the aggregation named <code>items</code>. Additionally unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed items (might be empty).</returns>
				public extern virtual sap.ui.core.Item[] removeAllItems();

				/// <summary>
				/// Binds aggregation {@link #getItems items} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select bindItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select unbindItems();

				#endregion

				#region Methods for Aggregation picker

				#endregion

				#region Methods for Aggregation _pickerHeader

				#endregion

				#region Methods for Association selectedItem

				/// <summary>
				/// Gets the selected item object from the aggregation named <code>items</code>.
				/// </summary>
				/// <returns>The current target of the <code>selectedItem</code> association, or null.</returns>
				public extern virtual sap.ui.core.Item getSelectedItem();

				/// <summary>
				/// Sets the <code>selectedItem</code> association.
				/// 
				/// Default value is <code>null</code>.
				/// </summary>
				/// <param name="vItem">New value for the <code>selectedItem</code> association. If an ID of a <code>sap.ui.core.Item</code> is given, the item with this ID becomes the <code>selectedItem</code> association. Alternatively, a <code>sap.ui.core.Item</code> instance may be given or <code>null</code>. If the value of <code>null</code> is provided, the first enabled item will be selected (if any items exist).</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Select setSelectedItem(Union<string, sap.ui.core.Item> vItem);

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
				public extern virtual sap.m.Select addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event change

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Select</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Select</code> itself.
				/// 
				/// This event is fired when the value in the selection field is changed in combination with one of the following actions: <ul> <li>The focus leaves the selection field</li> <li>The <i>Enter</i> key is pressed</li> <li>The item is pressed</li> </ul>
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Select</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select attachChange(object oData, sap.m.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Select</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Select</code> itself.
				/// 
				/// This event is fired when the value in the selection field is changed in combination with one of the following actions: <ul> <li>The focus leaves the selection field</li> <li>The <i>Enter</i> key is pressed</li> <li>The item is pressed</li> </ul>
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select attachChange(object oData, sap.m.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Select</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Select</code> itself.
				/// 
				/// This event is fired when the value in the selection field is changed in combination with one of the following actions: <ul> <li>The focus leaves the selection field</li> <li>The <i>Enter</i> key is pressed</li> <li>The item is pressed</li> </ul>
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select attachChange(sap.m.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Select</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Select</code> itself.
				/// 
				/// This event is fired when the value in the selection field is changed in combination with one of the following actions: <ul> <li>The focus leaves the selection field</li> <li>The <i>Enter</i> key is pressed</li> <li>The item is pressed</li> </ul>
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Select</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select attachChange(sap.m.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.m.Select</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select detachChange(sap.m.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select fireChange(sap.m.SelectionChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Select fireChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Closes the control's picker popup.
				/// </summary>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Select close();

				/// <summary>
				/// Creates a picker popup container where the selection should take place.
				/// </summary>
				/// <param name="sPickerType">The picker type</param>
				/// <returns>The <code>sap.m.Popover</code> or <code>sap.m.Dialog</code> instance</returns>
				public extern virtual sap.ui.core.Control createPicker(string sPickerType);

				/// <summary>
				/// Creates a new subclass of class sap.m.Select with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Select with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Select with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns the <code>sap.m.Select</code> accessibility information.
				/// </summary>
				/// <returns>The <code>sap.m.Select</code> accessibility information</returns>
				public extern virtual object getAccessibilityInfo();

				/// <summary>
				/// Gets the enabled items from the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="aItems">Items to filter.</param>
				/// <returns>An array containing the enabled items.</returns>
				public extern virtual sap.ui.core.Item[] getEnabledItems(sap.ui.core.Item[] aItems);

				/// <summary>
				/// Gets the enabled items from the aggregation named <code>items</code>.
				/// </summary>
				/// <returns>An array containing the enabled items.</returns>
				public extern virtual sap.ui.core.Item[] getEnabledItems();

				/// <summary>
				/// Gets the first item from the aggregation named <code>items</code>.
				/// </summary>
				/// <returns>The first item, or null if there are no items.</returns>
				public extern virtual sap.ui.core.Item getFirstItem();

				/// <summary>
				/// Returns the DOMNode Id to be used for the "labelFor" attribute of the label.
				/// 
				/// By default, this is the Id of the control itself.
				/// </summary>
				/// <returns>Id to be used for the <code>labelFor</code></returns>
				public extern override string getIdForLabel();

				/// <summary>
				/// Gets the item from the aggregation named <code>items</code> at the given 0-based index.
				/// </summary>
				/// <param name="iIndex">Index of the item to return.</param>
				/// <returns>Item at the given index, or null if none.</returns>
				public extern virtual sap.ui.core.Item getItemAt(int iIndex);

				/// <summary>
				/// Gets the item with the given key from the aggregation named <code>items</code>.
				/// 
				/// <b>Note: </b> If duplicate keys exist, the first item matching the key is returned.
				/// </summary>
				/// <param name="sKey">An item key that specifies the item to be retrieved.</param>
				/// <returns>The <code>sap.ui.core.Item</code> instance or <code>null</code> if thre is no such item</returns>
				public extern virtual sap.ui.core.Item getItemByKey(string sKey);

				/// <summary>
				/// Gets the last item from the aggregation named <code>items</code>.
				/// </summary>
				/// <returns>The last item, or null if there are no items.</returns>
				public extern virtual sap.ui.core.Item getLastItem();

				/// <summary>
				/// Returns a metadata object for class sap.m.Select.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Indicates whether the control's picker popup is opened.
				/// </summary>
				/// <returns>Indicates whether the picker popup is currently open (this includes opening and closing animations).</returns>
				public extern virtual bool isOpen();

				/// <summary>
				/// Open the control's picker popup.
				/// </summary>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Select open();

				#endregion

				#region Methods of sap.ui.core.IFormContent Interface

				/// <summary>
				/// In the <code>Form</code> control all content controls are positioned on a grid cell base. By default the controls use the full width of the used grid cell. But for some controls (like image controls), this is not the desired behavior. In this case the control must keep its original width.
				/// </summary>
				/// <returns>true if the <code>Form</code> is not allowed to adjust the width of the control to use the cell's width</returns>
				public extern static bool getFormDoNotAdjustWidth();

				#endregion

				#endregion

			}
		}
	}
}
