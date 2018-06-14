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
			/// A container control for managing multiple tabs, allowing the user to open and edit different items simultaneously.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The control contains a <code>TabStrip</code> area where the user can choose which tab to view/edit. When the open tabs are more than what can be displayed on the screen, there is an overflow mechanism. To access the tabs hidden in the overflow area, the user has to either use the overflow button (left or right arrow) to scroll them horizontally or the overflow overview button (down arrow) and view all open items as a list.
			/// 
			/// Each tab has a title and a <i>Close Tab</i> button. The title is truncated, if it's longer than 25 characters. On desktop, the <i>Close Tab</i> button is displayed on the currently active tab and for the other tabs it appears on mouse hover. On mobile devices, the <i>Close Tab</i> buttons are always visible.
			/// 
			/// To show that the open items have unsaved changes, the corresponding tabs can display an asterisk (*) after the title as a visual indication that the item is not saved. This is managed by the app developer using {@link sap.m.TabContainerItem TabContainerItem}'s <code>modified</code> property.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// The <code>TabContainer</code> can have an <i>Add New Tab</i> button, which appears as a '+' icon on the top-right area of the control. When the user clicks or taps this button, the <code>addNewButtonPress</code> event is fired.
			/// 
			/// <h3>Responsive behavior</h3>
			/// 
			/// The <code>TabContainer</code> is a full-page container that takes 100% of its parent width and height. As the control is expected to occupy the whole parent, it should be the only child of its parent.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class TabContainer : sap.ui.core.Control
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
					/// Defines whether an <i>Add New Tab</i> button is displayed in the <code>TabStrip</code>.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showAddNewButton;

					/// <summary>
					/// The items displayed in the <code>TabContainer</code>.
					/// </summary>
					public Union<sap.m.TabContainerItem[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// Sets or retrieves the selected item from the <code>items</code> aggregation.
					/// </summary>
					public Union<sap.m.TabContainerItem, sap.ui.core.ID, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> selectedItem;

					/// <summary>
					/// Fired when an item is closed.
					/// </summary>
					public sap.m.TabContainer.ItemDelegate itemClose;

					/// <summary>
					/// Fired when an item is pressed.
					/// </summary>
					public sap.m.TabContainer.ItemDelegate itemSelect;

					/// <summary>
					/// Fired when the <i>Add New Tab</i> button is pressed.
					/// </summary>
					public sap.ui.@base.EventDelegate addNewButtonPress;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ItemInfo
				{
					/// <summary>
					/// The item to be closed.
					/// </summary>
					public sap.m.TabContainerItem item;

				}

				#endregion

				#region Delegates

				public delegate void ItemDelegate(sap.ui.@base.Event<sap.m.TabContainer.ItemInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>TabContainer</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TabContainer(string sId, sap.m.TabContainer.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>TabContainer</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern TabContainer(string sId);

				/// <summary>
				/// Constructor for a new <code>TabContainer</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern TabContainer();

				/// <summary>
				/// Constructor for a new <code>TabContainer</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TabContainer(sap.m.TabContainer.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property showAddNewButton

				/// <summary>
				/// Gets current value of property {@link #getShowAddNewButton showAddNewButton}.
				/// 
				/// Defines whether an <i>Add New Tab</i> button is displayed in the <code>TabStrip</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showAddNewButton</code></returns>
				public extern virtual bool getShowAddNewButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowAddNewButton showAddNewButton}.
				/// 
				/// Defines whether an <i>Add New Tab</i> button is displayed in the <code>TabStrip</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowAddNewButton">New value for property <code>showAddNewButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer setShowAddNewButton(bool bShowAddNewButton);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// The items displayed in the <code>TabContainer</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.TabContainerItem[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer insertItem(sap.m.TabContainerItem oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer addItem(sap.m.TabContainerItem oItem);

				/// <summary>
				/// Removes an item from the aggregation named <code>items</code>.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or ID</param>
				/// <returns>The removed item or null</returns>
				public extern virtual sap.m.TabContainerItem removeItem(Union<int, string, sap.m.TabContainerItem> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.TabContainerItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.TabContainerItem oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.TabContainerItem[] removeAllItems();

				/// <summary>
				/// Binds aggregation {@link #getItems items} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer bindItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer unbindItems();

				#endregion

				#region Methods for Aggregation _addNewButton

				#endregion

				#region Methods for Aggregation _tabStrip

				#endregion

				#region Methods for Association selectedItem

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedItem selectedItem}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedItem();

				/// <summary>
				/// Sets the associated {@link #getSelectedItem selectedItem}.
				/// </summary>
				/// <param name="oSelectedItem">ID of an element which becomes the new target of this selectedItem association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer setSelectedItem(Union<sap.ui.core.ID, sap.m.TabContainerItem> oSelectedItem);

				#endregion

				#region Methods for Event itemClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemClose itemClose} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when an item is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TabContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachItemClose(object oData, sap.m.TabContainer.ItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemClose itemClose} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when an item is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachItemClose(object oData, sap.m.TabContainer.ItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemClose itemClose} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when an item is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachItemClose(sap.m.TabContainer.ItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemClose itemClose} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when an item is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TabContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachItemClose(sap.m.TabContainer.ItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemClose itemClose} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer detachItemClose(sap.m.TabContainer.ItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:itemClose itemClose} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireItemClose(sap.m.TabContainer.ItemInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:itemClose itemClose} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireItemClose();

				#endregion

				#region Methods for Event itemSelect

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when an item is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TabContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachItemSelect(object oData, sap.m.TabContainer.ItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when an item is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachItemSelect(object oData, sap.m.TabContainer.ItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when an item is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachItemSelect(sap.m.TabContainer.ItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when an item is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TabContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachItemSelect(sap.m.TabContainer.ItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemSelect itemSelect} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer detachItemSelect(sap.m.TabContainer.ItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:itemSelect itemSelect} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireItemSelect(sap.m.TabContainer.ItemInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:itemSelect itemSelect} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireItemSelect();

				#endregion

				#region Methods for Event addNewButtonPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addNewButtonPress addNewButtonPress} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when the <i>Add New Tab</i> button is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TabContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachAddNewButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addNewButtonPress addNewButtonPress} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when the <i>Add New Tab</i> button is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachAddNewButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addNewButtonPress addNewButtonPress} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when the <i>Add New Tab</i> button is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachAddNewButtonPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addNewButtonPress addNewButtonPress} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainer</code> itself.
				/// 
				/// Fired when the <i>Add New Tab</i> button is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TabContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer attachAddNewButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:addNewButtonPress addNewButtonPress} event of this <code>sap.m.TabContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer detachAddNewButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:addNewButtonPress addNewButtonPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer fireAddNewButtonPress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:addNewButtonPress addNewButtonPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainer fireAddNewButtonPress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.TabContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TabContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TabContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.TabContainer.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
