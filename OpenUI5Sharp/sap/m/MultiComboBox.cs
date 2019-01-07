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
			/// The MultiComboBox control provides a list box with items and a text field allowing the user to either type a value directly into the control or choose from the list of existing items.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MultiComboBox")]
			public partial class MultiComboBox : sap.m.ComboBoxBase
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
					/// Keys of the selected items. If the key has no corresponding item, no changes will apply. If duplicate keys exists the first item matching the key is used.
					/// </summary>
					public Union<string[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedKeys;

					/// <summary>
					/// Provides getter and setter for the selected items from the aggregation named items.
					/// </summary>
					public Union<sap.ui.core.Item, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedItems;

					/// <summary>
					/// Event is fired when selection of an item is changed. Note: please do not use the "change" event inherited from sap.m.InputBase
					/// </summary>
					public sap.m.MultiComboBox.SelectionChangeDelegate selectionChange;

					/// <summary>
					/// Event is fired when user has finished a selection of items in a list box and list box has been closed.
					/// </summary>
					public sap.m.MultiComboBox.SelectionFinishDelegate selectionFinish;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SelectionChangeInfo
				{
					/// <summary>
					/// Item which selection is changed
					/// </summary>
					public sap.ui.core.Item changedItem;

					/// <summary>
					/// Selection state: true if item is selected, false if item is not selected
					/// </summary>
					public bool selected;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SelectionFinishInfo
				{
					/// <summary>
					/// The selected items which are selected after list box has been closed.
					/// </summary>
					public sap.ui.core.Item[] selectedItems;

				}

				#endregion

				#region Delegates

				public delegate void SelectionChangeDelegate(sap.ui.@base.Event<sap.m.MultiComboBox.SelectionChangeInfo> oEvent, object oData);

				public delegate void SelectionFinishDelegate(sap.ui.@base.Event<sap.m.MultiComboBox.SelectionFinishInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new MultiComboBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern MultiComboBox(string sId, sap.m.MultiComboBox.Settings mSettings);

				/// <summary>
				/// Constructor for a new MultiComboBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern MultiComboBox(string sId);

				/// <summary>
				/// Constructor for a new MultiComboBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern MultiComboBox();

				/// <summary>
				/// Constructor for a new MultiComboBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern MultiComboBox(sap.m.MultiComboBox.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property selectedKeys

				/// <summary>
				/// Gets current value of property {@link #getSelectedKeys selectedKeys}.
				/// 
				/// Keys of the selected items. If the key has no corresponding item, no changes will apply. If duplicate keys exists the first item matching the key is used.
				/// 
				/// Default value is <code>[]</code>.
				/// </summary>
				/// <returns>Value of property <code>selectedKeys</code></returns>
				public extern virtual string[] getSelectedKeys();

				/// <summary>
				/// Sets a new value for property {@link #getSelectedKeys selectedKeys}.
				/// 
				/// Keys of the selected items. If the key has no corresponding item, no changes will apply. If duplicate keys exists the first item matching the key is used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>[]</code>.
				/// </summary>
				/// <param name="sSelectedKeys">New value for property <code>selectedKeys</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox setSelectedKeys(string[] sSelectedKeys);

				/// <summary>
				/// Sets a new value for property {@link #getSelectedKeys selectedKeys}.
				/// 
				/// Keys of the selected items. If the key has no corresponding item, no changes will apply. If duplicate keys exists the first item matching the key is used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>[]</code>.
				/// </summary>
				/// <param name="sSelectedKeys">New value for property <code>selectedKeys</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox setSelectedKeys(object[] sSelectedKeys);

				#endregion

				#region Methods for Association selectedItems

				/// <summary>
				/// Retrieves the selected item objects from the association named <code>selectedItems</code>.
				/// </summary>
				/// <returns>Array of sap.ui.core.Item instances. The current target of the <code>selectedItems</code> association.</returns>
				public extern virtual sap.ui.core.Item[] getSelectedItems();

				/// <summary>
				/// Adds some item <code>oItem</code> to the association named <code>selectedItems</code>.
				/// </summary>
				/// <param name="oItem">The selected item to add; if empty, nothing is added.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.MultiComboBox addSelectedItem(sap.ui.core.Item oItem);

				/// <summary>
				/// Removes an selectedItem from the association named {@link #getSelectedItems selectedItems}.
				/// </summary>
				/// <param name="vSelectedItem">The selectedItem to be removed or its index or ID</param>
				/// <returns>The removed selectedItem or <code>null</code></returns>
				public extern virtual sap.ui.core.ID removeSelectedItem(Union<int, sap.ui.core.ID, sap.ui.core.Item> vSelectedItem);

				/// <summary>
				/// Removes all the controls in the association named {@link #getSelectedItems selectedItems}.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.ID[] removeAllSelectedItems();

				#endregion

				#region Methods for Event selectionChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.MultiComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiComboBox</code> itself.
				/// 
				/// Event is fired when selection of an item is changed. Note: please do not use the "change" event inherited from sap.m.InputBase
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MultiComboBox</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox attachSelectionChange(object oData, sap.m.MultiComboBox.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.MultiComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiComboBox</code> itself.
				/// 
				/// Event is fired when selection of an item is changed. Note: please do not use the "change" event inherited from sap.m.InputBase
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox attachSelectionChange(object oData, sap.m.MultiComboBox.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.MultiComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiComboBox</code> itself.
				/// 
				/// Event is fired when selection of an item is changed. Note: please do not use the "change" event inherited from sap.m.InputBase
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox attachSelectionChange(sap.m.MultiComboBox.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.MultiComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiComboBox</code> itself.
				/// 
				/// Event is fired when selection of an item is changed. Note: please do not use the "change" event inherited from sap.m.InputBase
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MultiComboBox</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox attachSelectionChange(sap.m.MultiComboBox.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:selectionChange selectionChange} event of this <code>sap.m.MultiComboBox</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox detachSelectionChange(sap.m.MultiComboBox.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox fireSelectionChange(sap.m.MultiComboBox.SelectionChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox fireSelectionChange();

				#endregion

				#region Methods for Event selectionFinish

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionFinish selectionFinish} event of this <code>sap.m.MultiComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiComboBox</code> itself.
				/// 
				/// Event is fired when user has finished a selection of items in a list box and list box has been closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MultiComboBox</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox attachSelectionFinish(object oData, sap.m.MultiComboBox.SelectionFinishDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionFinish selectionFinish} event of this <code>sap.m.MultiComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiComboBox</code> itself.
				/// 
				/// Event is fired when user has finished a selection of items in a list box and list box has been closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox attachSelectionFinish(object oData, sap.m.MultiComboBox.SelectionFinishDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionFinish selectionFinish} event of this <code>sap.m.MultiComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiComboBox</code> itself.
				/// 
				/// Event is fired when user has finished a selection of items in a list box and list box has been closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox attachSelectionFinish(sap.m.MultiComboBox.SelectionFinishDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionFinish selectionFinish} event of this <code>sap.m.MultiComboBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiComboBox</code> itself.
				/// 
				/// Event is fired when user has finished a selection of items in a list box and list box has been closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MultiComboBox</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox attachSelectionFinish(sap.m.MultiComboBox.SelectionFinishDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:selectionFinish selectionFinish} event of this <code>sap.m.MultiComboBox</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox detachSelectionFinish(sap.m.MultiComboBox.SelectionFinishDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:selectionFinish selectionFinish} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox fireSelectionFinish(sap.m.MultiComboBox.SelectionFinishInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:selectionFinish selectionFinish} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiComboBox fireSelectionFinish();

				#endregion

				#region Other methods

				/// <summary>
				/// Adds selected items. Only items with valid keys are added as selected.
				/// </summary>
				/// <param name="aKeys">An array of item keys that identifies the items to be added as selected</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.MultiComboBox addSelectedKeys(string[] aKeys);

				/// <summary>
				/// Adds selected items. Only items with valid keys are added as selected.
				/// </summary>
				/// <param name="aKeys">An array of item keys that identifies the items to be added as selected</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.MultiComboBox addSelectedKeys(object[] aKeys);

				/// <summary>
				/// Clear the selection.
				/// </summary>
				public extern override void clearSelection();

				/// <summary>
				/// Create an instance type of <code>sap.m.List</code>.
				/// </summary>
				public extern virtual void createList();

				/// <summary>
				/// Creates a picker. To be overwritten by subclasses.
				/// </summary>
				/// <param name="sPickerType">The picker type</param>
				/// <returns>The picker pop-up to be used</returns>
				public extern virtual Union<sap.m.Popover, sap.m.Dialog> createPicker(string sPickerType);

				/// <summary>
				/// Destroys all the items in the aggregation named <code>items</code>.
				/// </summary>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.MultiComboBox destroyItems();

				/// <summary>
				/// Creates a new subclass of class sap.m.MultiComboBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ComboBoxBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MultiComboBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ComboBoxBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MultiComboBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ComboBoxBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <returns>Current accessibility state of the control</returns>
				public extern override object getAccessibilityInfo();

				/// <summary>
				/// Gets the enabled items from the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="aItems">Items to filter.</param>
				/// <returns>An array containing the enabled items.</returns>
				public extern override sap.ui.core.Item[] getEnabledItems(sap.ui.core.Item[] aItems);

				/// <summary>
				/// Gets the enabled items from the aggregation named <code>items</code>.
				/// </summary>
				/// <returns>An array containing the enabled items.</returns>
				public extern override sap.ui.core.Item[] getEnabledItems();

				/// <summary>
				/// Gets the item with the given key from the aggregation named <code>items</code>.<br> <b>Note:</b> If duplicate keys exist, the first item matching the key is returned.
				/// </summary>
				/// <param name="sKey">An item key that specifies the item to retrieve.</param>
				/// <returns>The matching item</returns>
				public extern override sap.ui.core.Item getItemByKey(string sKey);

				/// <summary>
				/// Returns a metadata object for class sap.m.MultiComboBox.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Inserts an item into the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted.</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.MultiComboBox insertItem(sap.ui.core.Item oItem, int iIndex);

				/// <summary>
				/// This hook method is called after the MultiComboBox's Pop-up is rendered.
				/// </summary>
				public extern virtual void onAfterRenderingPicker();

				/// <summary>
				/// This hook method is called before the MultiComboBox's Pop-up is rendered.
				/// </summary>
				public extern virtual void onBeforeRenderingPicker();

				/// <summary>
				/// Removes all the items in the aggregation named <code>items</code>.
				/// </summary>
				/// <returns>An array of sap.ui.core.Item of the removed items (might be empty).</returns>
				public extern override sap.ui.core.Item[] removeAllItems();

				/// <summary>
				/// Removes an item from the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="oItem">The item to remove or its index or id.</param>
				/// <returns>The removed item or null.</returns>
				public extern virtual sap.ui.core.Item removeItem(Union<int, string, sap.ui.core.Item> oItem);

				/// <summary>
				/// Removes selected items. Only items with valid keys are removed.
				/// </summary>
				/// <param name="aKeys">An array of item keys that identifies the items to be removed</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.MultiComboBox removeSelectedKeys(string[] aKeys);

				/// <summary>
				/// Removes selected items. Only items with valid keys are removed.
				/// </summary>
				/// <param name="aKeys">An array of item keys that identifies the items to be removed</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.MultiComboBox removeSelectedKeys(object[] aKeys);

				/// <summary>
				/// Setter for association <code>selectedItems</code>.
				/// </summary>
				/// <param name="aItems">new values for association <code>selectedItems</code>. Array of sap.ui.core.Item Id which becomes the new target of this <code>selectedItems</code> association. Alternatively, an array of sap.ui.core.Item instance may be given or null.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.MultiComboBox setSelectedItems(Union<string[], sap.ui.core.Item[]> aItems);

				#endregion

				#endregion

			}
		}
	}
}
