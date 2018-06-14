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
			/// An abstract class for combo boxes.
			/// </summary>
			[External]
			[Namespace(false)]
			public abstract partial class ComboBoxBase : sap.m.ComboBoxTextField
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ComboBoxTextField.Settings
				{
					/// <summary>
					/// Defines the items contained within this control.
					/// </summary>
					public Union<sap.ui.core.Item[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// This event is fired when the end user clicks the combo box button to open the dropdown list and the data used to display items is not already loaded. Alternatively, it is fired after the user moves the cursor to the combo box text field and perform an action that requires data to be loaded. For example, pressing F4 to open the dropdown list or typing something in the text field fires the event.
					/// 
					/// <b>Note:</b> Use this feature in performance critical scenarios only. Loading the data lazily (on demand) to defer initialization has several implications for the end user experience. For example, the busy indicator has to be shown while the items are being loaded and assistive technology software also has to announce the state changes (which may be confusing for some screen reader users).
					/// 
					/// <b>Note</b>: Currently the <code>sap.m.MultiComboBox</code> does not support this event.
					/// </summary>
					public sap.ui.@base.EventDelegate loadItems;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>sap.m.ComboBoxBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				/// <param name="mSettings">Initial settings for the new control.</param>
				public extern ComboBoxBase(string sId, sap.m.ComboBoxBase.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>sap.m.ComboBoxBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				public extern ComboBoxBase(string sId);

				/// <summary>
				/// Constructor for a new <code>sap.m.ComboBoxBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ComboBoxBase();

				/// <summary>
				/// Constructor for a new <code>sap.m.ComboBoxBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control.</param>
				public extern ComboBoxBase(sap.m.ComboBoxBase.Settings mSettings);

				#endregion

				#region Methods

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
				public extern virtual sap.m.ComboBox destroyItems();

				/// <summary>
				/// Inserts an item into the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="oItem">The item to be inserted; if empty, nothing is inserted.</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.ComboBoxBase insertItem(sap.ui.core.Item oItem, int iIndex);

				/// <summary>
				/// Adds an item to the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="oItem">The item to be added; if empty, nothing is added.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.ComboBoxBase addItem(sap.ui.core.Item oItem);

				/// <summary>
				/// Removes an item from the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or ID.</param>
				/// <returns>The removed item or null.</returns>
				public extern virtual sap.ui.core.Item removeItem(Union<int, string, sap.ui.core.Item> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Item</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.ui.core.Item oItem);

				/// <summary>
				/// Removes all the controls in the aggregation named <code>items</code>. Additionally unregisters them from the hosting UIArea and clears the selection.
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
				public extern virtual sap.m.ComboBoxBase bindItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBoxBase unbindItems();

				#endregion

				#region Methods for Aggregation picker

				/// <summary>
				/// Gets the control's picker popup.
				/// </summary>
				/// <returns>The picker instance, creating it if necessary by calling the <code>createPicker()</code> method.</returns>
				public extern virtual Union<sap.m.Dialog, sap.m.Popover> getPicker();

				#endregion

				#region Methods for Event loadItems

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loadItems loadItems} event of this <code>sap.m.ComboBoxBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBoxBase</code> itself.
				/// 
				/// This event is fired when the end user clicks the combo box button to open the dropdown list and the data used to display items is not already loaded. Alternatively, it is fired after the user moves the cursor to the combo box text field and perform an action that requires data to be loaded. For example, pressing F4 to open the dropdown list or typing something in the text field fires the event.
				/// 
				/// <b>Note:</b> Use this feature in performance critical scenarios only. Loading the data lazily (on demand) to defer initialization has several implications for the end user experience. For example, the busy indicator has to be shown while the items are being loaded and assistive technology software also has to announce the state changes (which may be confusing for some screen reader users).
				/// 
				/// <b>Note</b>: Currently the <code>sap.m.MultiComboBox</code> does not support this event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ComboBoxBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBoxBase attachLoadItems(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loadItems loadItems} event of this <code>sap.m.ComboBoxBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBoxBase</code> itself.
				/// 
				/// This event is fired when the end user clicks the combo box button to open the dropdown list and the data used to display items is not already loaded. Alternatively, it is fired after the user moves the cursor to the combo box text field and perform an action that requires data to be loaded. For example, pressing F4 to open the dropdown list or typing something in the text field fires the event.
				/// 
				/// <b>Note:</b> Use this feature in performance critical scenarios only. Loading the data lazily (on demand) to defer initialization has several implications for the end user experience. For example, the busy indicator has to be shown while the items are being loaded and assistive technology software also has to announce the state changes (which may be confusing for some screen reader users).
				/// 
				/// <b>Note</b>: Currently the <code>sap.m.MultiComboBox</code> does not support this event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBoxBase attachLoadItems(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loadItems loadItems} event of this <code>sap.m.ComboBoxBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBoxBase</code> itself.
				/// 
				/// This event is fired when the end user clicks the combo box button to open the dropdown list and the data used to display items is not already loaded. Alternatively, it is fired after the user moves the cursor to the combo box text field and perform an action that requires data to be loaded. For example, pressing F4 to open the dropdown list or typing something in the text field fires the event.
				/// 
				/// <b>Note:</b> Use this feature in performance critical scenarios only. Loading the data lazily (on demand) to defer initialization has several implications for the end user experience. For example, the busy indicator has to be shown while the items are being loaded and assistive technology software also has to announce the state changes (which may be confusing for some screen reader users).
				/// 
				/// <b>Note</b>: Currently the <code>sap.m.MultiComboBox</code> does not support this event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBoxBase attachLoadItems(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loadItems loadItems} event of this <code>sap.m.ComboBoxBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ComboBoxBase</code> itself.
				/// 
				/// This event is fired when the end user clicks the combo box button to open the dropdown list and the data used to display items is not already loaded. Alternatively, it is fired after the user moves the cursor to the combo box text field and perform an action that requires data to be loaded. For example, pressing F4 to open the dropdown list or typing something in the text field fires the event.
				/// 
				/// <b>Note:</b> Use this feature in performance critical scenarios only. Loading the data lazily (on demand) to defer initialization has several implications for the end user experience. For example, the busy indicator has to be shown while the items are being loaded and assistive technology software also has to announce the state changes (which may be confusing for some screen reader users).
				/// 
				/// <b>Note</b>: Currently the <code>sap.m.MultiComboBox</code> does not support this event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ComboBoxBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBoxBase attachLoadItems(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:loadItems loadItems} event of this <code>sap.m.ComboBoxBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBoxBase detachLoadItems(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:loadItems loadItems} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBoxBase fireLoadItems(object mParameters);

				/// <summary>
				/// Fires event {@link #event:loadItems loadItems} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBoxBase fireLoadItems();

				#endregion

				#region Other methods

				/// <summary>
				/// Clears the selection. To be overwritten by subclasses.
				/// </summary>
				public extern virtual void clearSelection();

				/// <summary>
				/// Closes the control's picker popup.
				/// </summary>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.ComboBoxBase close();

				/// <summary>
				/// Creates a picker popup container where the selection should take place. To be overwritten by subclasses.
				/// </summary>
				/// <param name="sPickerType">The picker type</param>
				public extern virtual void createPicker(string sPickerType);

				/// <summary>
				/// Creates an instance of <code>sap.m.Bar</code>.
				/// </summary>
				/// <returns>Picker's header</returns>
				public extern virtual sap.m.Bar createPickerHeader();

				/// <summary>
				/// Creates a new subclass of class sap.m.ComboBoxBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ComboBoxTextField.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ComboBoxBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ComboBoxTextField.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ComboBoxBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ComboBoxTextField.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

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
				/// Gets the item from the aggregation named <code>items</code> at the given 0-based index.
				/// </summary>
				/// <param name="iIndex">Index of the item to return.</param>
				/// <returns>Item at the given index, or null if none.</returns>
				public extern virtual sap.ui.core.Item getItemAt(int iIndex);

				/// <summary>
				/// Gets the item with the given key from the aggregation named <code>items</code>.
				/// 
				/// <b>Note:</b> If duplicate keys exist, the first item matching the key is returned.
				/// </summary>
				/// <param name="sKey">An item key that specifies the item to retrieve.</param>
				/// <returns>The matching item</returns>
				public extern virtual sap.ui.core.Item getItemByKey(string sKey);

				/// <summary>
				/// Gets the last item from the aggregation named <code>items</code>.
				/// </summary>
				/// <returns>The last item, or null if there are no items.</returns>
				public extern virtual sap.ui.core.Item getLastItem();

				/// <summary>
				/// Gets the <code>list</code>.
				/// </summary>
				/// <returns>The list instance object or <code>null</code>.</returns>
				public extern virtual sap.m.SelectList getList();

				/// <summary>
				/// Returns a metadata object for class sap.m.ComboBoxBase.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Gets the ID of the hidden label
				/// </summary>
				/// <returns>Id of hidden text</returns>
				public extern virtual string getPickerInvisibleTextId();

				/// <summary>
				/// Gets the control's input from the picker.
				/// </summary>
				/// <returns>Picker's input for filtering the list</returns>
				public extern virtual Union<sap.m.ComboBoxTextField, sap.m.Input> getPickerTextField();

				/// <summary>
				/// Gets the property <code>_sPickerType</code>
				/// </summary>
				/// <returns>The picker type</returns>
				public extern virtual string getPickerType();

				/// <summary>
				/// Determines whether the control has content or not.
				/// </summary>
				/// <returns>True if the control has content</returns>
				public extern virtual bool hasContent();

				/// <summary>
				/// Indicates whether the control's picker popup is open.
				/// </summary>
				/// <returns>Determines whether the control's picker popup is currently open (this includes opening and closing animations).</returns>
				public extern virtual bool isOpen();

				/// <summary>
				/// Opens the control's picker popup.
				/// </summary>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.ComboBoxBase open();

				/// <summary>
				/// Sets the property <code>_sPickerType</code>.
				/// </summary>
				/// <param name="sPickerType">The picker type</param>
				public extern virtual void setPickerType(string sPickerType);

				#endregion

				#endregion

			}
		}
	}
}
