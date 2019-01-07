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
				/// Common button control that opens a menu when clicked by the user. The control provides an API for configuring the docking position of the menu.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.MenuButton")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.MenuButton</code> control.")]
				public partial class MenuButton : sap.ui.commons.Button
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.Button.Settings
					{
						/// <summary>
						/// The position / edge (see sap.ui.core.Popup.Dock) of the button where the menu is docked. Default is 'begin bottom'.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> dockButton;

						/// <summary>
						/// The position / edge (see sap.ui.core.Popup.Dock) of the menu which is docked to the button. Default is 'begin top'.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> dockMenu;

						/// <summary>
						/// Menu that shall be opened when the button is clicked
						/// </summary>
						public Union<sap.ui.unified.Menu, string, sap.ui.@base.ManagedObject.BindAggregationInfo> menu;

						/// <summary>
						/// Event that is fired when a menu item is selected by the user
						/// </summary>
						public sap.ui.ItemSelectedDelegate itemSelected;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class PressInfo
					{
						/// <summary>
						/// The id of the selected item
						/// </summary>
						public string itemId;

						/// <summary>
						/// The selected item
						/// </summary>
						public sap.ui.commons.MenuItemBase item;

					}

					#endregion

					#region Delegates

					public delegate void PressDelegate(sap.ui.@base.Event<sap.ui.commons.MenuButton.PressInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new MenuButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern MenuButton(string sId, sap.ui.commons.MenuButton.Settings mSettings);

					/// <summary>
					/// Constructor for a new MenuButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern MenuButton(string sId);

					/// <summary>
					/// Constructor for a new MenuButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern MenuButton();

					/// <summary>
					/// Constructor for a new MenuButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern MenuButton(sap.ui.commons.MenuButton.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property dockButton

					/// <summary>
					/// Gets current value of property {@link #getDockButton dockButton}.
					/// 
					/// The position / edge (see sap.ui.core.Popup.Dock) of the button where the menu is docked. Default is 'begin bottom'.
					/// </summary>
					/// <returns>Value of property <code>dockButton</code></returns>
					public extern virtual string getDockButton();

					/// <summary>
					/// Sets a new value for property {@link #getDockButton dockButton}.
					/// 
					/// The position / edge (see sap.ui.core.Popup.Dock) of the button where the menu is docked. Default is 'begin bottom'.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sDockButton">New value for property <code>dockButton</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton setDockButton(string sDockButton);

					#endregion

					#region Methods for Property dockMenu

					/// <summary>
					/// Gets current value of property {@link #getDockMenu dockMenu}.
					/// 
					/// The position / edge (see sap.ui.core.Popup.Dock) of the menu which is docked to the button. Default is 'begin top'.
					/// </summary>
					/// <returns>Value of property <code>dockMenu</code></returns>
					public extern virtual string getDockMenu();

					/// <summary>
					/// Sets a new value for property {@link #getDockMenu dockMenu}.
					/// 
					/// The position / edge (see sap.ui.core.Popup.Dock) of the menu which is docked to the button. Default is 'begin top'.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sDockMenu">New value for property <code>dockMenu</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton setDockMenu(string sDockMenu);

					#endregion

					#region Methods for Aggregation menu

					/// <summary>
					/// Gets content of aggregation {@link #getMenu menu}.
					/// 
					/// Menu that shall be opened when the button is clicked
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.Menu getMenu();

					/// <summary>
					/// Destroys the menu in the aggregation named <code>menu</code>.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton destroyMenu();

					/// <summary>
					/// Setter for the aggregated <code>menu</code>.
					/// </summary>
					/// <param name="oMenu">The menu to be set to the menu aggregation</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton setMenu(sap.ui.unified.Menu oMenu);

					#endregion

					#region Methods for Event itemSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelected itemSelected} event of this <code>sap.ui.commons.MenuButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.MenuButton</code> itself.
					/// 
					/// Event that is fired when a menu item is selected by the user
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.MenuButton</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton attachItemSelected(object oData, sap.ui.ItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelected itemSelected} event of this <code>sap.ui.commons.MenuButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.MenuButton</code> itself.
					/// 
					/// Event that is fired when a menu item is selected by the user
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton attachItemSelected(object oData, sap.ui.ItemSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelected itemSelected} event of this <code>sap.ui.commons.MenuButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.MenuButton</code> itself.
					/// 
					/// Event that is fired when a menu item is selected by the user
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton attachItemSelected(sap.ui.ItemSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelected itemSelected} event of this <code>sap.ui.commons.MenuButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.MenuButton</code> itself.
					/// 
					/// Event that is fired when a menu item is selected by the user
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.MenuButton</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton attachItemSelected(sap.ui.ItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemSelected itemSelected} event of this <code>sap.ui.commons.MenuButton</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton detachItemSelected(sap.ui.ItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:itemSelected itemSelected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton fireItemSelected(sap.ui.ItemSelectedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:itemSelected itemSelected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton fireItemSelected();

					#endregion

					#region Methods for event press

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'press' event of this <code>sap.ui.commons.MenuButton</code>.<br/>
					/// 
					/// Event is fired when an item from the menu was selected.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton attachPress(object oData, sap.ui.commons.MenuButton.PressDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'press' event of this <code>sap.ui.commons.MenuButton</code>.<br/>
					/// 
					/// Event is fired when an item from the menu was selected.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton attachPress(object oData, sap.ui.commons.MenuButton.PressDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'press' event of this <code>sap.ui.commons.MenuButton</code>.<br/>
					/// 
					/// Event is fired when an item from the menu was selected.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton attachPress(sap.ui.commons.MenuButton.PressDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'press' event of this <code>sap.ui.commons.MenuButton</code>.<br/>
					/// 
					/// Event is fired when an item from the menu was selected.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton attachPress(sap.ui.commons.MenuButton.PressDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'press' event of this <code>sap.ui.commons.MenuButton</code>.<br/>
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton detachPress(sap.ui.commons.MenuButton.PressDelegate fnFunction, object oListener);

					/// <summary>
					/// Fire event press to attached listeners.
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton firePress(Map mArguments);

					/// <summary>
					/// Fire event press to attached listeners.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MenuButton firePress();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MenuButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Button.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MenuButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Button.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MenuButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Button.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.MenuButton.
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
}
