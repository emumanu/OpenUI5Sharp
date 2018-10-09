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
			/// The <code>sap.m.SelectList</code> displays a list of items that allows the user to select an item.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.SelectList")]
			public partial class SelectList : sap.ui.core.Control
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
					/// Indicates whether the user can change the selection.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

					/// <summary>
					/// Sets the width of the control.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Sets the maximum width of the control.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxWidth;

					/// <summary>
					/// Key of the selected item.
					/// 
					/// <b>Note: </b> If duplicate keys exist, the first item matching the key is used.
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
					/// Defines the keyboard navigation mode.
					/// 
					/// <b>Note:</b> The <code>sap.m.SelectListKeyboardNavigationMode.None</code> enumeration value, is only intended for use in some composite controls that handles keyboard navigation by themselves.
					/// </summary>
					public Union<sap.m.SelectListKeyboardNavigationMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> keyboardNavigationMode;

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
					/// This event is fired when the selection has changed.
					/// 
					/// <b>Note: </b> The selection can be changed by pressing a non-selected item or via keyboard and after the enter or space key is pressed.
					/// </summary>
					public sap.m.SelectionChangeDelegate selectionChange;

					/// <summary>
					/// This event is fired when an item is pressed.
					/// </summary>
					public sap.m.ItemSelectDelegate itemPress;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>sap.m.SelectList</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				/// <param name="mSettings">Initial settings for the new control.</param>
				public extern SelectList(string sId, sap.m.SelectList.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>sap.m.SelectList</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				public extern SelectList(string sId);

				/// <summary>
				/// Constructor for a new <code>sap.m.SelectList</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern SelectList();

				/// <summary>
				/// Constructor for a new <code>sap.m.SelectList</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control.</param>
				public extern SelectList(sap.m.SelectList.Settings mSettings);

				#endregion

				#region Methods

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
				public extern virtual sap.m.SelectList setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Sets the width of the control.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Sets the width of the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property maxWidth

				/// <summary>
				/// Gets current value of property {@link #getMaxWidth maxWidth}.
				/// 
				/// Sets the maximum width of the control.
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
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sMaxWidth">New value for property <code>maxWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList setMaxWidth(sap.ui.core.CSSSize sMaxWidth);

				#endregion

				#region Methods for Property selectedKey

				/// <summary>
				/// Gets current value of property {@link #getSelectedKey selectedKey}.
				/// 
				/// Key of the selected item.
				/// 
				/// <b>Note: </b> If duplicate keys exist, the first item matching the key is used.
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
				/// <param name="sKey">New value for property <code>selectedKey</code>.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.SelectList setSelectedKey(string sKey);

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
				/// Sets property <code>selectedItemId</code>.
				/// 
				/// Default value is an empty string <code>""</code> or <code>undefined</code>.
				/// </summary>
				/// <param name="vItem">New value for property <code>selectedItemId</code>.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.SelectList setSelectedItemId(string vItem);

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
				public extern virtual sap.m.SelectList setShowSecondaryValues(bool bShowSecondaryValues);

				#endregion

				#region Methods for Property keyboardNavigationMode

				/// <summary>
				/// Gets current value of property {@link #getKeyboardNavigationMode keyboardNavigationMode}.
				/// 
				/// Defines the keyboard navigation mode.
				/// 
				/// <b>Note:</b> The <code>sap.m.SelectListKeyboardNavigationMode.None</code> enumeration value, is only intended for use in some composite controls that handles keyboard navigation by themselves.
				/// 
				/// Default value is <code>Delimited</code>.
				/// </summary>
				/// <returns>Value of property <code>keyboardNavigationMode</code></returns>
				public extern virtual sap.m.SelectListKeyboardNavigationMode getKeyboardNavigationMode();

				/// <summary>
				/// Sets a new value for property {@link #getKeyboardNavigationMode keyboardNavigationMode}.
				/// 
				/// Defines the keyboard navigation mode.
				/// 
				/// <b>Note:</b> The <code>sap.m.SelectListKeyboardNavigationMode.None</code> enumeration value, is only intended for use in some composite controls that handles keyboard navigation by themselves.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Delimited</code>.
				/// </summary>
				/// <param name="sKeyboardNavigationMode">New value for property <code>keyboardNavigationMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList setKeyboardNavigationMode(sap.m.SelectListKeyboardNavigationMode sKeyboardNavigationMode);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// Defines the items contained within this control.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Item[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation named <code>items</code>.
				/// </summary>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.SelectList destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList insertItem(sap.ui.core.Item oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList addItem(sap.ui.core.Item oItem);

				/// <summary>
				/// Removes an item from the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id.</param>
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
				public extern virtual sap.m.SelectList bindItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList unbindItems();

				#endregion

				#region Methods for Association selectedItem

				/// <summary>
				/// Gets the selected item object from the aggregation named <code>items</code>.
				/// </summary>
				/// <returns>The current target of the <code>selectedItem</code> association, or null.</returns>
				public extern virtual sap.ui.core.Item getSelectedItem();

				/// <summary>
				/// Sets the <code>selectedItem</code> association.
				/// </summary>
				/// <param name="vItem">New value for the <code>selectedItem</code> association. If an ID of a <code>sap.ui.core.Item</code> is given, the item with this ID becomes the <code>selectedItem</code> association. Alternatively, a <code>sap.ui.core.Item</code> instance may be given or <code>null</code> to clear the selection.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.SelectList setSelectedItem(Union<string, sap.ui.core.Item> vItem);

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
				public extern virtual sap.m.SelectList addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event selectionChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.SelectList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectList</code> itself.
				/// 
				/// This event is fired when the selection has changed.
				/// 
				/// <b>Note: </b> The selection can be changed by pressing a non-selected item or via keyboard and after the enter or space key is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectList</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList attachSelectionChange(object oData, sap.m.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.SelectList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectList</code> itself.
				/// 
				/// This event is fired when the selection has changed.
				/// 
				/// <b>Note: </b> The selection can be changed by pressing a non-selected item or via keyboard and after the enter or space key is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList attachSelectionChange(object oData, sap.m.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.SelectList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectList</code> itself.
				/// 
				/// This event is fired when the selection has changed.
				/// 
				/// <b>Note: </b> The selection can be changed by pressing a non-selected item or via keyboard and after the enter or space key is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList attachSelectionChange(sap.m.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.SelectList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectList</code> itself.
				/// 
				/// This event is fired when the selection has changed.
				/// 
				/// <b>Note: </b> The selection can be changed by pressing a non-selected item or via keyboard and after the enter or space key is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectList</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList attachSelectionChange(sap.m.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:selectionChange selectionChange} event of this <code>sap.m.SelectList</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList detachSelectionChange(sap.m.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList fireSelectionChange(sap.m.SelectionChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList fireSelectionChange();

				#endregion

				#region Methods for Event itemPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPress itemPress} event of this <code>sap.m.SelectList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectList</code> itself.
				/// 
				/// This event is fired when an item is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectList</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList attachItemPress(object oData, sap.m.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPress itemPress} event of this <code>sap.m.SelectList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectList</code> itself.
				/// 
				/// This event is fired when an item is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList attachItemPress(object oData, sap.m.ItemSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPress itemPress} event of this <code>sap.m.SelectList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectList</code> itself.
				/// 
				/// This event is fired when an item is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList attachItemPress(sap.m.ItemSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPress itemPress} event of this <code>sap.m.SelectList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectList</code> itself.
				/// 
				/// This event is fired when an item is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectList</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList attachItemPress(sap.m.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemPress itemPress} event of this <code>sap.m.SelectList</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList detachItemPress(sap.m.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:itemPress itemPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList fireItemPress(sap.m.ItemSelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:itemPress itemPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectList fireItemPress();

				#endregion

				#region Other methods

				/// <summary>
				/// Clear the selection.
				/// </summary>
				public extern virtual void clearSelection();

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Retrieves the default selected item from the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="aItems"></param>
				/// <returns></returns>
				public extern virtual sap.ui.core.Item getDefaultSelectedItem(sap.ui.core.Item[] aItems);

				/// <summary>
				/// Retrieves the default selected item from the aggregation named <code>items</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Item getDefaultSelectedItem();

				/// <summary>
				/// Gets the enabled items from the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="aItems">items to filter</param>
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
				/// Gets the item from the aggregation named <code>items</code> at the given 0-based index.
				/// </summary>
				/// <param name="iIndex">Index of the item to return.</param>
				/// <returns>Item at the given index, or null if none.</returns>
				public extern virtual sap.ui.core.Item getItemAt(int iIndex);

				/// <summary>
				/// Gets the item with the given key from the aggregation named <code>items</code>.
				/// 
				/// <b>Note: </b> If duplicate keys exists, the first item matching the key is returned.
				/// </summary>
				/// <param name="sKey">An item key that specifies the item to retrieve.</param>
				/// <returns>The matched item or null</returns>
				public extern virtual sap.ui.core.Item getItemByKey(string sKey);

				/// <summary>
				/// Gets the enabled items from the aggregation named <code>items</code>.
				/// </summary>
				/// <returns>The last item, or null if there are no items.</returns>
				public extern virtual sap.ui.core.Item getLastItem();

				/// <summary>
				/// Returns a metadata object for class sap.m.SelectList.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Updates and synchronizes <code>selectedItem</code> association, <code>selectedItemId</code> and <code>selectedKey</code> properties.
				/// </summary>
				/// <param name="vItem"></param>
				public extern virtual void setSelection(Union<string, sap.ui.core.Item> vItem);

				#endregion

				#endregion

			}
		}
	}
}
