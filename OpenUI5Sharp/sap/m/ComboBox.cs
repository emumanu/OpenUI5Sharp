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
			/// A drop-down list for selecting and filtering values. <h3>Overview</h3> The control represents a drop-down menu with a list of the available options and a text input field to narrow down the options. <h3>Structure</h3> The combo-box consists of the following elements: <ul> <li> Input field - displays the selected option or a custom user entry. Users can type to narrow down the list or enter their own value.</li> <li> Drop-down arrow - expands\collapses the option list.</li> <li> Option list - the list of available options.</li> </ul> By setting the <code>showSecondaryValues</code> property, the combo box can display an additional value for each option (if there is one). Filtering is done only on the first option. <h3>Usage</h3> <h4>When to use:</h4> <ul> <li>You need to select only one item in a long list of options (between 13 and 200) or your custom user input.</li> </ul> <h4>When not to use:</h4> <ul> <li>You need to select between only two options. Use a {@link sap.m.Switch switch} control instead.</li> <li>You need to select between 12 options. Use a {@link sap.m.Select select} control instead.</li> <li>You need to select between more than 200 options. Use a {@link sap.m.Input input} control with value help instead.</li> </ul> <h3>Responsive Behavior</h3> <ul> <li>The width of the option list adapts to its content. The minimum width is the input field plus the drop-down arrow.</li> <li>There is no horizontal scrolling in the option list. Entries in the list that are too long will be truncated.</li> <li>On phone devices the combo box option list opens a dialog.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ComboBox")]
			public partial class ComboBox : sap.m.ComboBoxBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ComboBoxBase.Settings
				{
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
					/// Indicates whether the text values of the <code>additionalText</code> property of a {@link sap.ui.core.ListItem} are shown.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSecondaryValues;

					/// <summary>
					/// Indicates whether the filter should check in both the <code>text</code> and the <code>additionalText</code> property of the {@link sap.ui.core.ListItem} for the suggestion.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> filterSecondaryValues;

					/// <summary>
					/// Sets or retrieves the selected item from the aggregation named items.
					/// </summary>
					public Union<sap.ui.core.Item, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedItem;

					/// <summary>
					/// This event is fired when the value in the text input field is changed in combination with one of the following actions:
					/// 
					/// <ul> <li>The focus leaves the text input field</li> <li>The <i>Enter</i> key is pressed</li> </ul>
					/// 
					/// In addition, this event is also fired when an item in the list is selected.
					/// </summary>
					public sap.m.ComboBox.ChangeDelegate change;

					/// <summary>
					/// This event is fired when the user types something that matches with an item in the list; it is also fired when the user presses on a list item, or when navigating via keyboard.
					/// </summary>
					public sap.m.SelectionChangeDelegate selectionChange;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ChangeInfo
				{
					/// <summary>
					/// The new <code>value</code> of the <code>control</code>
					/// </summary>
					public string value;

					/// <summary>
					/// Indicates whether the change event was caused by selecting an item in the list
					/// </summary>
					public bool itemPressed;

				}

				#endregion

				#region Delegates

				public delegate void ChangeDelegate(sap.ui.@base.Event<sap.m.ComboBox.ChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ComboBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ComboBox(string sId, sap.m.ComboBox.Settings mSettings);

				/// <summary>
				/// Constructor for a new ComboBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ComboBox(string sId);

				/// <summary>
				/// Constructor for a new ComboBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ComboBox();

				/// <summary>
				/// Constructor for a new ComboBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ComboBox(sap.m.ComboBox.Settings mSettings);

				#endregion

				#region Methods

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
				/// Sets the <code>selectedKey</code> property.
				/// 
				/// Default value is an empty string <code>""</code> or <code>undefined</code>.
				/// </summary>
				/// <param name="sKey">New value for property <code>selectedKey</code>. If the provided <code>sKey</code> is an empty string <code>""</code> or <code>undefined</code>, the selection is cleared. If duplicate keys exist, the first item matching the key is selected.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.ComboBox setSelectedKey(string sKey);

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
				/// <param name="vItem">New value for property <code>selectedItemId</code>. If the provided <code>vItem</code> is an empty string <code>""</code> or <code>undefined</code>, the selection is cleared. If the ID has no corresponding aggregated item, the selected item is not changed.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.ComboBox setSelectedItemId(string vItem);

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
				public extern virtual sap.m.ComboBox setShowSecondaryValues(bool bShowSecondaryValues);

				#endregion

				#region Methods for Property filterSecondaryValues

				/// <summary>
				/// Gets current value of property {@link #getFilterSecondaryValues filterSecondaryValues}.
				/// 
				/// Indicates whether the filter should check in both the <code>text</code> and the <code>additionalText</code> property of the {@link sap.ui.core.ListItem} for the suggestion.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>filterSecondaryValues</code></returns>
				public extern virtual bool getFilterSecondaryValues();

				/// <summary>
				/// Sets a new value for property {@link #getFilterSecondaryValues filterSecondaryValues}.
				/// 
				/// Indicates whether the filter should check in both the <code>text</code> and the <code>additionalText</code> property of the {@link sap.ui.core.ListItem} for the suggestion.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bFilterSecondaryValues">New value for property <code>filterSecondaryValues</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox setFilterSecondaryValues(bool bFilterSecondaryValues);

				#endregion

				#region Methods for Association selectedItem

				/// <summary>
				/// Gets the selected item object from the aggregation named <code>items</code>.
				/// </summary>
				/// <returns>The current target of the <code>selectedItem</code> association, or <code>null</code>.</returns>
				public extern virtual sap.ui.core.Item getSelectedItem();

				/// <summary>
				/// Sets the <code>selectedItem</code> association.
				/// 
				/// Default value is <code>null</code>.
				/// </summary>
				/// <param name="vItem">New value for the <code>selectedItem</code> association. If an ID of a <code>sap.ui.core.Item</code> is given, the item with this ID becomes the <code>selectedItem</code> association. Alternatively, a <code>sap.ui.core.Item</code> instance may be given or <code>null</code> to clear the selection.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.ComboBox setSelectedItem(Union<string, sap.ui.core.Item> vItem);

				#endregion

				#region Methods for Event change

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.ComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBox</code> itself.
				/// 
				/// This event is fired when the value in the text input field is changed in combination with one of the following actions:
				/// 
				/// <ul> <li>The focus leaves the text input field</li> <li>The <i>Enter</i> key is pressed</li> </ul>
				/// 
				/// In addition, this event is also fired when an item in the list is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ComboBox</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox attachChange(object oData, sap.m.ComboBox.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.ComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBox</code> itself.
				/// 
				/// This event is fired when the value in the text input field is changed in combination with one of the following actions:
				/// 
				/// <ul> <li>The focus leaves the text input field</li> <li>The <i>Enter</i> key is pressed</li> </ul>
				/// 
				/// In addition, this event is also fired when an item in the list is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox attachChange(object oData, sap.m.ComboBox.ChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.ComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBox</code> itself.
				/// 
				/// This event is fired when the value in the text input field is changed in combination with one of the following actions:
				/// 
				/// <ul> <li>The focus leaves the text input field</li> <li>The <i>Enter</i> key is pressed</li> </ul>
				/// 
				/// In addition, this event is also fired when an item in the list is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox attachChange(sap.m.ComboBox.ChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.ComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBox</code> itself.
				/// 
				/// This event is fired when the value in the text input field is changed in combination with one of the following actions:
				/// 
				/// <ul> <li>The focus leaves the text input field</li> <li>The <i>Enter</i> key is pressed</li> </ul>
				/// 
				/// In addition, this event is also fired when an item in the list is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ComboBox</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox attachChange(sap.m.ComboBox.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.m.ComboBox</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox detachChange(sap.m.ComboBox.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox fireChange(sap.m.ComboBox.ChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox fireChange();

				#endregion

				#region Methods for Event selectionChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.ComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBox</code> itself.
				/// 
				/// This event is fired when the user types something that matches with an item in the list; it is also fired when the user presses on a list item, or when navigating via keyboard.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ComboBox</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox attachSelectionChange(object oData, sap.m.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.ComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBox</code> itself.
				/// 
				/// This event is fired when the user types something that matches with an item in the list; it is also fired when the user presses on a list item, or when navigating via keyboard.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox attachSelectionChange(object oData, sap.m.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.ComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBox</code> itself.
				/// 
				/// This event is fired when the user types something that matches with an item in the list; it is also fired when the user presses on a list item, or when navigating via keyboard.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox attachSelectionChange(sap.m.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.ComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBox</code> itself.
				/// 
				/// This event is fired when the user types something that matches with an item in the list; it is also fired when the user presses on a list item, or when navigating via keyboard.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ComboBox</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox attachSelectionChange(sap.m.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:selectionChange selectionChange} event of this <code>sap.m.ComboBox</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox detachSelectionChange(sap.m.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox fireSelectionChange(sap.m.SelectionChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBox fireSelectionChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Clears the selection.
				/// </summary>
				public extern override void clearSelection();

				/// <summary>
				/// Creates a picker popup container where the selection should take place.
				/// 
				/// To be overwritten by subclasses.
				/// </summary>
				/// <param name="sPickerType">The type of the picker</param>
				/// <returns>The picker popup to be used.</returns>
				public extern virtual Union<sap.m.Popover, sap.m.Dialog> createPicker(string sPickerType);

				/// <summary>
				/// Creates a new subclass of class sap.m.ComboBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ComboBoxBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ComboBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ComboBoxBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ComboBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ComboBoxBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Gets the default selected item from the aggregation named <code>items</code>.
				/// </summary>
				/// <returns>Null, as there is no default selected item</returns>
				public extern virtual object getDefaultSelectedItem();

				/// <summary>
				/// Gets aggregation <code>items</code>.
				/// 
				/// <b>Note</b>: This is the default aggregation.
				/// </summary>
				/// <returns>The Item array</returns>
				public extern override sap.ui.core.Item[] getItems();

				/// <summary>
				/// Returns a metadata object for class sap.m.ComboBox.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// This event handler is called before the picker popup is opened.
				/// </summary>
				public extern virtual void onBeforeOpen();

				/// <summary>
				/// Removes an item from the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="vItem">The item to be removed or its index or ID.</param>
				/// <returns>The removed item or <code>null</code>.</returns>
				public extern override sap.ui.core.Item removeItem(Union<int, string, sap.ui.core.Item> vItem);

				/// <summary>
				/// Sets the start and end positions of the current text selection.
				/// </summary>
				/// <param name="iSelectionStart">The index of the first selected character.</param>
				/// <param name="iSelectionEnd">The index of the character after the last selected character.</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.ComboBox selectText(int iSelectionStart, int iSelectionEnd);

				/// <summary>
				/// Synchronizes the <code>selectedItem</code> association and the <code>selectedItemId</code> property.
				/// </summary>
				public extern virtual void synchronizeSelection();

				#endregion

				#endregion

			}
		}
	}
}
