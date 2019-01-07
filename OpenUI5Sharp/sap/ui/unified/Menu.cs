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
			public static partial class unified
			{
				/// <summary>
				/// A menu is an interactive element which provides a choice of different actions to the user. These actions (items) can also be organized in submenus. Like other dialog-like controls, the menu is not rendered within the control hierarchy. Instead it can be opened at a specified position via a function call.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.Menu")]
				public partial class Menu : sap.ui.core.Control, sap.ui.core.IContextMenu
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
						/// When a menu is disabled none of its items can be selected by the user. The enabled property of an item (@link sap.ui.unified.MenuItemBase#getEnabled) has no effect when the menu of the item is disabled.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Accessible label / description of the menu for assistive technologies like screenreaders.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescription;

						/// <summary>
						/// The maximum number of items which are displayed before an overflow mechanism takes effect. A value smaller than 1 means an infinite number of visible items. The overall height of the menu is limited by the height of the screen. If the maximum possible height is reached, an overflow takes effect, even if the maximum number of visible items is not yet reached.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxVisibleItems;

						/// <summary>
						/// The keyboard can be used to navigate through the items of a menu. Beside the arrow keys for single steps and the <i>Home</i> / <i>End</i> keys for jumping to the first / last item, the <i>Page Up</i> / <i>Page Down</i> keys can be used to jump an arbitrary number of items up or down. This number can be defined via the <code>pageSize</code> property. For values smaller than 1, paging behaves in a similar way to when using the <i>Home</i> / <i>End</i> keys. If the value equals 1, the paging behavior is similar to that of the arrow keys.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> pageSize;

						/// <summary>
						/// The available actions to be displayed as items of the menu.
						/// </summary>
						public Union<sap.ui.unified.MenuItemBase[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

						/// <summary>
						/// Reference to accessible labels (ids of existing DOM elements or controls) for assistive technologies like screenreaders.
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Fired on the root menu of a menu hierarchy whenever a user selects an item within the menu or within one of its direct or indirect submenus. <b>Note:</b> There is also a select event available for each single menu item. This event and the event of the menu items are redundant.
						/// </summary>
						public sap.ui.unified.Menu.SelectDelegate itemSelect;

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
						/// The action (item) which was selected by the user.
						/// </summary>
						public sap.ui.unified.MenuItemBase item;

					}

					#endregion

					#region Delegates

					public delegate void SelectDelegate(sap.ui.@base.Event<sap.ui.unified.Menu.SelectInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Menu control.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Menu(string sId, sap.ui.unified.Menu.Settings mSettings);

					/// <summary>
					/// Constructor for a new Menu control.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					public extern Menu(string sId);

					/// <summary>
					/// Constructor for a new Menu control.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Menu();

					/// <summary>
					/// Constructor for a new Menu control.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Menu(sap.ui.unified.Menu.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// When a menu is disabled none of its items can be selected by the user. The enabled property of an item (@link sap.ui.unified.MenuItemBase#getEnabled) has no effect when the menu of the item is disabled.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// When a menu is disabled none of its items can be selected by the user. The enabled property of an item (@link sap.ui.unified.MenuItemBase#getEnabled) has no effect when the menu of the item is disabled.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property ariaDescription

					/// <summary>
					/// Gets current value of property {@link #getAriaDescription ariaDescription}.
					/// 
					/// Accessible label / description of the menu for assistive technologies like screenreaders.
					/// </summary>
					/// <returns>Value of property <code>ariaDescription</code></returns>
					[Obsolete("Deprecated since 1.27.0. replaced by <code>ariaLabelledBy</code> association")]
					public extern virtual string getAriaDescription();

					/// <summary>
					/// Sets a new value for property {@link #getAriaDescription ariaDescription}.
					/// 
					/// Accessible label / description of the menu for assistive technologies like screenreaders.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sAriaDescription">New value for property <code>ariaDescription</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.27.0. replaced by <code>ariaLabelledBy</code> association")]
					public extern virtual sap.ui.unified.Menu setAriaDescription(string sAriaDescription);

					#endregion

					#region Methods for Property maxVisibleItems

					/// <summary>
					/// Gets current value of property {@link #getMaxVisibleItems maxVisibleItems}.
					/// 
					/// The maximum number of items which are displayed before an overflow mechanism takes effect. A value smaller than 1 means an infinite number of visible items. The overall height of the menu is limited by the height of the screen. If the maximum possible height is reached, an overflow takes effect, even if the maximum number of visible items is not yet reached.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>maxVisibleItems</code></returns>
					public extern virtual int getMaxVisibleItems();

					/// <summary>
					/// Sets a new value for property {@link #getMaxVisibleItems maxVisibleItems}.
					/// 
					/// The maximum number of items which are displayed before an overflow mechanism takes effect. A value smaller than 1 means an infinite number of visible items. The overall height of the menu is limited by the height of the screen. If the maximum possible height is reached, an overflow takes effect, even if the maximum number of visible items is not yet reached.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iMaxVisibleItems">New value for property <code>maxVisibleItems</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu setMaxVisibleItems(int iMaxVisibleItems);

					#endregion

					#region Methods for Property pageSize

					/// <summary>
					/// Gets current value of property {@link #getPageSize pageSize}.
					/// 
					/// The keyboard can be used to navigate through the items of a menu. Beside the arrow keys for single steps and the <i>Home</i> / <i>End</i> keys for jumping to the first / last item, the <i>Page Up</i> / <i>Page Down</i> keys can be used to jump an arbitrary number of items up or down. This number can be defined via the <code>pageSize</code> property. For values smaller than 1, paging behaves in a similar way to when using the <i>Home</i> / <i>End</i> keys. If the value equals 1, the paging behavior is similar to that of the arrow keys.
					/// 
					/// Default value is <code>5</code>.
					/// </summary>
					/// <returns>Value of property <code>pageSize</code></returns>
					public extern virtual int getPageSize();

					/// <summary>
					/// Sets a new value for property {@link #getPageSize pageSize}.
					/// 
					/// The keyboard can be used to navigate through the items of a menu. Beside the arrow keys for single steps and the <i>Home</i> / <i>End</i> keys for jumping to the first / last item, the <i>Page Up</i> / <i>Page Down</i> keys can be used to jump an arbitrary number of items up or down. This number can be defined via the <code>pageSize</code> property. For values smaller than 1, paging behaves in a similar way to when using the <i>Home</i> / <i>End</i> keys. If the value equals 1, the paging behavior is similar to that of the arrow keys.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>5</code>.
					/// </summary>
					/// <param name="iPageSize">New value for property <code>pageSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu setPageSize(int iPageSize);

					#endregion

					#region Methods for Aggregation items

					/// <summary>
					/// Gets content of aggregation {@link #getItems items}.
					/// 
					/// The available actions to be displayed as items of the menu.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.MenuItemBase[] getItems();

					/// <summary>
					/// Destroys all the items in the aggregation {@link #getItems items}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu destroyItems();

					/// <summary>
					/// Inserts a item into the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu insertItem(sap.ui.unified.MenuItemBase oItem, int iIndex);

					/// <summary>
					/// Adds some item to the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu addItem(sap.ui.unified.MenuItemBase oItem);

					/// <summary>
					/// Removes a item from the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="vItem">The item to remove or its index or id</param>
					/// <returns>The removed item or <code>null</code></returns>
					public extern virtual sap.ui.unified.MenuItemBase removeItem(Union<int, string, sap.ui.unified.MenuItemBase> vItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.unified.MenuItemBase</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oItem">The item whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfItem(sap.ui.unified.MenuItemBase oItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getItems items}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.unified.MenuItemBase[] removeAllItems();

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
					public extern virtual sap.ui.unified.Menu addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

					#region Methods for Event itemSelect

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.ui.unified.Menu</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Menu</code> itself.
					/// 
					/// Fired on the root menu of a menu hierarchy whenever a user selects an item within the menu or within one of its direct or indirect submenus. <b>Note:</b> There is also a select event available for each single menu item. This event and the event of the menu items are redundant.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.Menu</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu attachItemSelect(object oData, sap.ui.unified.Menu.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.ui.unified.Menu</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Menu</code> itself.
					/// 
					/// Fired on the root menu of a menu hierarchy whenever a user selects an item within the menu or within one of its direct or indirect submenus. <b>Note:</b> There is also a select event available for each single menu item. This event and the event of the menu items are redundant.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu attachItemSelect(object oData, sap.ui.unified.Menu.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.ui.unified.Menu</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Menu</code> itself.
					/// 
					/// Fired on the root menu of a menu hierarchy whenever a user selects an item within the menu or within one of its direct or indirect submenus. <b>Note:</b> There is also a select event available for each single menu item. This event and the event of the menu items are redundant.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu attachItemSelect(sap.ui.unified.Menu.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.ui.unified.Menu</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Menu</code> itself.
					/// 
					/// Fired on the root menu of a menu hierarchy whenever a user selects an item within the menu or within one of its direct or indirect submenus. <b>Note:</b> There is also a select event available for each single menu item. This event and the event of the menu items are redundant.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.Menu</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu attachItemSelect(sap.ui.unified.Menu.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemSelect itemSelect} event of this <code>sap.ui.unified.Menu</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu detachItemSelect(sap.ui.unified.Menu.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:itemSelect itemSelect} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu fireItemSelect(sap.ui.unified.Menu.SelectInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:itemSelect itemSelect} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Menu fireItemSelect();

					#endregion

					#region Other methods

					/// <summary>
					/// Closes the menu.
					/// </summary>
					public extern virtual void close();

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Menu with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Menu with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Menu with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.Menu.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Opens the menu at the specified position.
					/// 
					/// The position of the menu is defined relative to an element in the visible DOM by specifying the docking location of the menu and of the related element.
					/// 
					/// See {@link sap.ui.core.Popup#open Popup#open} for further details about popup positioning.
					/// </summary>
					/// <param name="bWithKeyboard">Indicates whether or not the first item shall be highlighted when the menu is opened (keyboard case)</param>
					/// <param name="oOpenerRef">The element which will get the focus back again after the menu was closed</param>
					/// <param name="my">The reference docking location of the menu for positioning the menu on the screen</param>
					/// <param name="at">The 'of' element's reference docking location for positioning the menu on the screen</param>
					/// <param name="of">The menu is positioned relatively to this element based on the given dock locations</param>
					/// <param name="offset">The offset relative to the docking point, specified as a string with space-separated pixel values (e.g. "0 10" to move the popup 10 pixels to the right)</param>
					/// <param name="collision">The collision defines how the position of the menu should be adjusted in case it overflows the window in some direction</param>
					public extern virtual void open(bool bWithKeyboard, Union<sap.ui.core.Element, Retyped.dom.HTMLElement> oOpenerRef, sap.ui.core.Dock my, sap.ui.core.Dock at, Union<sap.ui.core.Element, Retyped.dom.HTMLElement> of, string offset, sap.ui.core.Collision collision);

					/// <summary>
					/// Opens the menu at the specified position.
					/// 
					/// The position of the menu is defined relative to an element in the visible DOM by specifying the docking location of the menu and of the related element.
					/// 
					/// See {@link sap.ui.core.Popup#open Popup#open} for further details about popup positioning.
					/// </summary>
					/// <param name="bWithKeyboard">Indicates whether or not the first item shall be highlighted when the menu is opened (keyboard case)</param>
					/// <param name="oOpenerRef">The element which will get the focus back again after the menu was closed</param>
					/// <param name="my">The reference docking location of the menu for positioning the menu on the screen</param>
					/// <param name="at">The 'of' element's reference docking location for positioning the menu on the screen</param>
					/// <param name="of">The menu is positioned relatively to this element based on the given dock locations</param>
					/// <param name="offset">The offset relative to the docking point, specified as a string with space-separated pixel values (e.g. "0 10" to move the popup 10 pixels to the right)</param>
					public extern virtual void open(bool bWithKeyboard, Union<sap.ui.core.Element, Retyped.dom.HTMLElement> oOpenerRef, sap.ui.core.Dock my, sap.ui.core.Dock at, Union<sap.ui.core.Element, Retyped.dom.HTMLElement> of, string offset);

					/// <summary>
					/// Opens the menu at the specified position.
					/// 
					/// The position of the menu is defined relative to an element in the visible DOM by specifying the docking location of the menu and of the related element.
					/// 
					/// See {@link sap.ui.core.Popup#open Popup#open} for further details about popup positioning.
					/// </summary>
					/// <param name="bWithKeyboard">Indicates whether or not the first item shall be highlighted when the menu is opened (keyboard case)</param>
					/// <param name="oOpenerRef">The element which will get the focus back again after the menu was closed</param>
					/// <param name="my">The reference docking location of the menu for positioning the menu on the screen</param>
					/// <param name="at">The 'of' element's reference docking location for positioning the menu on the screen</param>
					/// <param name="of">The menu is positioned relatively to this element based on the given dock locations</param>
					public extern virtual void open(bool bWithKeyboard, Union<sap.ui.core.Element, Retyped.dom.HTMLElement> oOpenerRef, sap.ui.core.Dock my, sap.ui.core.Dock at, Union<sap.ui.core.Element, Retyped.dom.HTMLElement> of);

					#endregion

					#endregion

				}
			}
		}
	}
}
