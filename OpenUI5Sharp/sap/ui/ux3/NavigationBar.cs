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
			public static partial class ux3
			{
				/// <summary>
				/// Provides enhanced navigation capabilities and is the parent control of NavigationItem. It is displayed in the form of a horizontal line with switching markers depending on the currently selected item. The size of an item which is currently chosen by the user is enlarged. In the case that a large number of items are defined for the bar, this is made transparent to the user by showing symbols for scrolling options (forwards and backwards) to see the next or previous items.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.NavigationBar")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.IconTabBar</code>, <code>sap.m.TabContainer</code> or <code>sap.uxap.ObjectPageLayout</code> control.")]
				public partial class NavigationBar : sap.ui.core.Control
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
						/// Defines whether the navigation bar shall have top-level appearance
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> toplevelVariant;

						/// <summary>
						/// Sets the appearance of the menu items in the overflow menu to uppercase
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> overflowItemsToUpperCase;

						/// <summary>
						/// If the navigation items need to have a different parent than the NavigationBar, alternatively the associatedItems association can be used. The NavigationBar follows the approach to use the items aggregation. If this aggregation is empty, associatedItems is used.
						/// </summary>
						public Union<sap.ui.ux3.NavigationItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

						/// <summary>
						/// The selected NavigationItem.
						/// </summary>
						public Union<sap.ui.ux3.NavigationItem, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedItem;

						/// <summary>
						/// This association is ignored as long as the items aggregation is used; and supposed to be used alternatively when the items should be aggregated by other entities.
						/// </summary>
						public Union<sap.ui.ux3.NavigationItem, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> associatedItems;

						/// <summary>
						/// Event is fired when an item is selected by the user
						/// </summary>
						public sap.ui.ux3.NavigationBar.SelectDelegate select;

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
						/// The ID of the newly selected NavigationItem.
						/// </summary>
						public string itemId;

						/// <summary>
						/// The newly selected NavigationItem.
						/// </summary>
						public sap.ui.ux3.NavigationItem item;

					}

					#endregion

					#region Delegates

					public delegate void SelectDelegate(sap.ui.@base.Event<sap.ui.ux3.NavigationBar.SelectInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new NavigationBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern NavigationBar(string sId, sap.ui.ux3.NavigationBar.Settings mSettings);

					/// <summary>
					/// Constructor for a new NavigationBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern NavigationBar(string sId);

					/// <summary>
					/// Constructor for a new NavigationBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern NavigationBar();

					/// <summary>
					/// Constructor for a new NavigationBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern NavigationBar(sap.ui.ux3.NavigationBar.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property toplevelVariant

					/// <summary>
					/// Gets current value of property {@link #getToplevelVariant toplevelVariant}.
					/// 
					/// Defines whether the navigation bar shall have top-level appearance
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>toplevelVariant</code></returns>
					public extern virtual bool getToplevelVariant();

					/// <summary>
					/// Sets a new value for property {@link #getToplevelVariant toplevelVariant}.
					/// 
					/// Defines whether the navigation bar shall have top-level appearance
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bToplevelVariant">New value for property <code>toplevelVariant</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationBar setToplevelVariant(bool bToplevelVariant);

					#endregion

					#region Methods for Property overflowItemsToUpperCase

					/// <summary>
					/// Gets current value of property {@link #getOverflowItemsToUpperCase overflowItemsToUpperCase}.
					/// 
					/// Sets the appearance of the menu items in the overflow menu to uppercase
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>overflowItemsToUpperCase</code></returns>
					public extern virtual bool getOverflowItemsToUpperCase();

					/// <summary>
					/// Sets a new value for property {@link #getOverflowItemsToUpperCase overflowItemsToUpperCase}.
					/// 
					/// Sets the appearance of the menu items in the overflow menu to uppercase
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bOverflowItemsToUpperCase">New value for property <code>overflowItemsToUpperCase</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationBar setOverflowItemsToUpperCase(bool bOverflowItemsToUpperCase);

					#endregion

					#region Methods for Aggregation items

					/// <summary>
					/// Gets content of aggregation {@link #getItems items}.
					/// 
					/// If the navigation items need to have a different parent than the NavigationBar, alternatively the associatedItems association can be used. The NavigationBar follows the approach to use the items aggregation. If this aggregation is empty, associatedItems is used.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.NavigationItem[] getItems();

					/// <summary>
					/// Destroys all the items in the aggregation {@link #getItems items}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationBar destroyItems();

					/// <summary>
					/// Inserts a item into the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationBar insertItem(sap.ui.ux3.NavigationItem oItem, int iIndex);

					/// <summary>
					/// Adds some item to the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationBar addItem(sap.ui.ux3.NavigationItem oItem);

					/// <summary>
					/// Removes a item from the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="vItem">The item to remove or its index or id</param>
					/// <returns>The removed item or <code>null</code></returns>
					public extern virtual sap.ui.ux3.NavigationItem removeItem(Union<int, string, sap.ui.ux3.NavigationItem> vItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.NavigationItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oItem">The item whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfItem(sap.ui.ux3.NavigationItem oItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getItems items}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.NavigationItem[] removeAllItems();

					#endregion

					#region Methods for Aggregation overflowMenu

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
					public extern virtual sap.ui.ux3.NavigationBar setSelectedItem(Union<sap.ui.core.ID, sap.ui.ux3.NavigationItem> oSelectedItem);

					#endregion

					#region Methods for Association associatedItems

					/// <summary>
					/// Returns array of IDs of the elements which are the current targets of the association {@link #getAssociatedItems associatedItems}.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID[] getAssociatedItems();

					/// <summary>
					/// Adds some associatedItem into the association {@link #getAssociatedItems associatedItems}.
					/// </summary>
					/// <param name="vAssociatedItem">The associatedItems to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationBar addAssociatedItem(Union<sap.ui.core.ID, sap.ui.ux3.NavigationItem> vAssociatedItem);

					/// <summary>
					/// Removes an associatedItem from the association named {@link #getAssociatedItems associatedItems}.
					/// </summary>
					/// <param name="vAssociatedItem">The associatedItem to be removed or its index or ID</param>
					/// <returns>The removed associatedItem or <code>null</code></returns>
					public extern virtual sap.ui.core.ID removeAssociatedItem(Union<int, sap.ui.core.ID, sap.ui.ux3.NavigationItem> vAssociatedItem);

					/// <summary>
					/// Removes all the controls in the association named {@link #getAssociatedItems associatedItems}.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ID[] removeAllAssociatedItems();

					#endregion

					#region Methods for Event select

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.ux3.NavigationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NavigationBar</code> itself.
					/// 
					/// Event is fired when an item is selected by the user
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.NavigationBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationBar attachSelect(object oData, sap.ui.ux3.NavigationBar.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.ux3.NavigationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NavigationBar</code> itself.
					/// 
					/// Event is fired when an item is selected by the user
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationBar attachSelect(object oData, sap.ui.ux3.NavigationBar.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.ux3.NavigationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NavigationBar</code> itself.
					/// 
					/// Event is fired when an item is selected by the user
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationBar attachSelect(sap.ui.ux3.NavigationBar.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.ux3.NavigationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NavigationBar</code> itself.
					/// 
					/// Event is fired when an item is selected by the user
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.NavigationBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationBar attachSelect(sap.ui.ux3.NavigationBar.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.ux3.NavigationBar</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationBar detachSelect(sap.ui.ux3.NavigationBar.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireSelect(sap.ui.ux3.NavigationBar.SelectInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireSelect();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.NavigationBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.NavigationBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.NavigationBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.NavigationBar.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns whether there is a selectedItem set which is actually present in the items aggregation; or, if the aggregation is empty, in the associatedItems association.
					/// </summary>
					/// <returns></returns>
					public extern virtual bool isSelectedItemValid();

					/// <summary>
					/// Replaces the currently associated items with the ones in the given array
					/// </summary>
					/// <param name="aItems">The items to associate</param>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.NavigationBar setAssociatedItems(sap.ui.ux3.NavigationItem[] aItems);

					#endregion

					#endregion

				}
			}
		}
	}
}
