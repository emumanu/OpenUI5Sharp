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
			/// The <code>sap.m.MenuButton</code> control enables the user to show a hierarchical menu.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MenuButton")]
			public partial class MenuButton : sap.ui.core.Control
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
					/// Defines the text of the <code>MenuButton</code>. <br/><b>Note:</b> In <code>Split</code> <code>buttonMode</code> with <code>useDefaultActionOnly</code> set to <code>false</code>, the text is changed to display the last selected item's text, while in <code>Regular</code> <code>buttonMode</code> the text stays unchanged.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Defines the type of the <code>MenuButton</code> (for example, Default, Accept, Reject, Back, etc.)
					/// </summary>
					public Union<sap.m.ButtonType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					/// <summary>
					/// Defines the width of the <code>MenuButton</code>. <br/><b>Note:</b>As per visual design this width can be maximum of 12rem (192px).
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Boolean property to enable the control (default is <code>true</code>). <br/><b>Note:</b> Depending on custom settings, the buttons that are disabled have other colors than the enabled ones.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

					/// <summary>
					/// Defines the icon to be displayed as a graphical element within the button. It can be an image or an icon from the icon font.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// The source property of an alternative icon for the active (pressed) state of the button. Both active and default icon properties should be defined and of the same type - image or icon font. If the <code>icon</code> property is not set or has a different type, the active icon is not displayed.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> activeIcon;

					/// <summary>
					/// When set to <code>true</code> (default), one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server. If only one version of image is provided, set this value to <code>false</code> to avoid the attempt of fetching density perfect image.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconDensityAware;

					/// <summary>
					/// Specifies the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

					/// <summary>
					/// Defines whether the <code>MenuButton</code> is set to <code>Regular</code> or <code>Split</code> mode.
					/// </summary>
					public Union<sap.m.MenuButtonMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> buttonMode;

					/// <summary>
					/// Specifies the position of the popup menu with enumerated options. By default, the control opens the menu at its bottom left side.
					/// 
					/// <b>Note:</b> In the case that the menu has no space to show itself in the view port of the current window it tries to open itself to the inverted direction.
					/// </summary>
					public Union<sap.ui.core.Popup.Dock, string, sap.ui.@base.ManagedObject.BindPropertyInfo> menuPosition;

					/// <summary>
					/// Controls whether the default action handler is invoked always or it is invoked only until a menu item is selected. Usable only if <code>buttonMode</code> is set to <code>Split</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> useDefaultActionOnly;

					/// <summary>
					/// Defines the menu that opens for this button.
					/// </summary>
					public Union<sap.m.Menu, string, sap.ui.@base.ManagedObject.BindAggregationInfo> menu;

					/// <summary>
					/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Fired when the <code>buttonMode</code> is set to <code>Split</code> and the user presses the main button unless <code>useDefaultActionOnly</code> is set to <code>false</code> and another action from the menu has been selected previously.
					/// </summary>
					public sap.ui.@base.EventDelegate defaultAction;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new MenuButton.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MenuButton(string sId, sap.m.MenuButton.Settings mSettings);

				/// <summary>
				/// Constructor for a new MenuButton.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
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
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MenuButton(sap.m.MenuButton.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Defines the text of the <code>MenuButton</code>. <br/><b>Note:</b> In <code>Split</code> <code>buttonMode</code> with <code>useDefaultActionOnly</code> set to <code>false</code>, the text is changed to display the last selected item's text, while in <code>Regular</code> <code>buttonMode</code> the text stays unchanged.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// Defines the text of the <code>MenuButton</code>. <br/><b>Note:</b> In <code>Split</code> <code>buttonMode</code> with <code>useDefaultActionOnly</code> set to <code>false</code>, the text is changed to display the last selected item's text, while in <code>Regular</code> <code>buttonMode</code> the text stays unchanged.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton setText(string sText);

				#endregion

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// Defines the type of the <code>MenuButton</code> (for example, Default, Accept, Reject, Back, etc.)
				/// 
				/// Default value is <code>Default</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.m.ButtonType getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// Defines the type of the <code>MenuButton</code> (for example, Default, Accept, Reject, Back, etc.)
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Default</code>.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton setType(sap.m.ButtonType sType);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the width of the <code>MenuButton</code>. <br/><b>Note:</b>As per visual design this width can be maximum of 12rem (192px).
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the width of the <code>MenuButton</code>. <br/><b>Note:</b>As per visual design this width can be maximum of 12rem (192px).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Boolean property to enable the control (default is <code>true</code>). <br/><b>Note:</b> Depending on custom settings, the buttons that are disabled have other colors than the enabled ones.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Boolean property to enable the control (default is <code>true</code>). <br/><b>Note:</b> Depending on custom settings, the buttons that are disabled have other colors than the enabled ones.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Defines the icon to be displayed as a graphical element within the button. It can be an image or an icon from the icon font.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Defines the icon to be displayed as a graphical element within the button. It can be an image or an icon from the icon font.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property activeIcon

				/// <summary>
				/// Gets current value of property {@link #getActiveIcon activeIcon}.
				/// 
				/// The source property of an alternative icon for the active (pressed) state of the button. Both active and default icon properties should be defined and of the same type - image or icon font. If the <code>icon</code> property is not set or has a different type, the active icon is not displayed.
				/// </summary>
				/// <returns>Value of property <code>activeIcon</code></returns>
				public extern virtual sap.ui.core.URI getActiveIcon();

				/// <summary>
				/// Sets a new value for property {@link #getActiveIcon activeIcon}.
				/// 
				/// The source property of an alternative icon for the active (pressed) state of the button. Both active and default icon properties should be defined and of the same type - image or icon font. If the <code>icon</code> property is not set or has a different type, the active icon is not displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sActiveIcon">New value for property <code>activeIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton setActiveIcon(sap.ui.core.URI sActiveIcon);

				#endregion

				#region Methods for Property iconDensityAware

				/// <summary>
				/// Gets current value of property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// When set to <code>true</code> (default), one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server. If only one version of image is provided, set this value to <code>false</code> to avoid the attempt of fetching density perfect image.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>iconDensityAware</code></returns>
				public extern virtual bool getIconDensityAware();

				/// <summary>
				/// Sets a new value for property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// When set to <code>true</code> (default), one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server. If only one version of image is provided, set this value to <code>false</code> to avoid the attempt of fetching density perfect image.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIconDensityAware">New value for property <code>iconDensityAware</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton setIconDensityAware(bool bIconDensityAware);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Specifies the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Specifies the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Property buttonMode

				/// <summary>
				/// Gets current value of property {@link #getButtonMode buttonMode}.
				/// 
				/// Defines whether the <code>MenuButton</code> is set to <code>Regular</code> or <code>Split</code> mode.
				/// 
				/// Default value is <code>Regular</code>.
				/// </summary>
				/// <returns>Value of property <code>buttonMode</code></returns>
				public extern virtual sap.m.MenuButtonMode getButtonMode();

				/// <summary>
				/// Sets the <code>buttonMode</code> of the control.
				/// </summary>
				/// <param name="sMode">The new button mode</param>
				/// <returns>This instance</returns>
				public extern virtual sap.m.MenuButton setButtonMode(sap.m.MenuButtonMode sMode);

				#endregion

				#region Methods for Property menuPosition

				/// <summary>
				/// Gets current value of property {@link #getMenuPosition menuPosition}.
				/// 
				/// Specifies the position of the popup menu with enumerated options. By default, the control opens the menu at its bottom left side.
				/// 
				/// <b>Note:</b> In the case that the menu has no space to show itself in the view port of the current window it tries to open itself to the inverted direction.
				/// 
				/// Default value is <code>BeginBottom</code>.
				/// </summary>
				/// <returns>Value of property <code>menuPosition</code></returns>
				public extern virtual sap.ui.core.Popup.Dock getMenuPosition();

				/// <summary>
				/// Sets a new value for property {@link #getMenuPosition menuPosition}.
				/// 
				/// Specifies the position of the popup menu with enumerated options. By default, the control opens the menu at its bottom left side.
				/// 
				/// <b>Note:</b> In the case that the menu has no space to show itself in the view port of the current window it tries to open itself to the inverted direction.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>BeginBottom</code>.
				/// </summary>
				/// <param name="sMenuPosition">New value for property <code>menuPosition</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton setMenuPosition(sap.ui.core.Popup.Dock sMenuPosition);

				#endregion

				#region Methods for Property useDefaultActionOnly

				/// <summary>
				/// Gets current value of property {@link #getUseDefaultActionOnly useDefaultActionOnly}.
				/// 
				/// Controls whether the default action handler is invoked always or it is invoked only until a menu item is selected. Usable only if <code>buttonMode</code> is set to <code>Split</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>useDefaultActionOnly</code></returns>
				public extern virtual bool getUseDefaultActionOnly();

				/// <summary>
				/// Sets a new value for property {@link #getUseDefaultActionOnly useDefaultActionOnly}.
				/// 
				/// Controls whether the default action handler is invoked always or it is invoked only until a menu item is selected. Usable only if <code>buttonMode</code> is set to <code>Split</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bUseDefaultActionOnly">New value for property <code>useDefaultActionOnly</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton setUseDefaultActionOnly(bool bUseDefaultActionOnly);

				#endregion

				#region Methods for Aggregation menu

				/// <summary>
				/// Gets content of aggregation {@link #getMenu menu}.
				/// 
				/// Defines the menu that opens for this button.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Menu getMenu();

				/// <summary>
				/// Destroys the menu in the aggregation {@link #getMenu menu}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton destroyMenu();

				/// <summary>
				/// Sets the aggregated {@link #getMenu menu}.
				/// </summary>
				/// <param name="oMenu">The menu to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton setMenu(sap.m.Menu oMenu);

				#endregion

				#region Methods for Aggregation _button

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
				public extern virtual sap.m.MenuButton addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
				public extern virtual sap.m.MenuButton addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event defaultAction

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:defaultAction defaultAction} event of this <code>sap.m.MenuButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuButton</code> itself.
				/// 
				/// Fired when the <code>buttonMode</code> is set to <code>Split</code> and the user presses the main button unless <code>useDefaultActionOnly</code> is set to <code>false</code> and another action from the menu has been selected previously.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MenuButton</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton attachDefaultAction(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:defaultAction defaultAction} event of this <code>sap.m.MenuButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuButton</code> itself.
				/// 
				/// Fired when the <code>buttonMode</code> is set to <code>Split</code> and the user presses the main button unless <code>useDefaultActionOnly</code> is set to <code>false</code> and another action from the menu has been selected previously.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton attachDefaultAction(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:defaultAction defaultAction} event of this <code>sap.m.MenuButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuButton</code> itself.
				/// 
				/// Fired when the <code>buttonMode</code> is set to <code>Split</code> and the user presses the main button unless <code>useDefaultActionOnly</code> is set to <code>false</code> and another action from the menu has been selected previously.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton attachDefaultAction(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:defaultAction defaultAction} event of this <code>sap.m.MenuButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuButton</code> itself.
				/// 
				/// Fired when the <code>buttonMode</code> is set to <code>Split</code> and the user presses the main button unless <code>useDefaultActionOnly</code> is set to <code>false</code> and another action from the menu has been selected previously.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MenuButton</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton attachDefaultAction(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:defaultAction defaultAction} event of this <code>sap.m.MenuButton</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton detachDefaultAction(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:defaultAction defaultAction} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton fireDefaultAction(object mParameters);

				/// <summary>
				/// Fires event {@link #event:defaultAction defaultAction} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuButton fireDefaultAction();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.MenuButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MenuButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MenuButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.MenuButton.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Initializes the control.
				/// </summary>
				public extern override void init();

				/// <summary>
				/// Sets the tooltip for the <code>MenuButton</code>. Can either be an instance of a TooltipBase subclass or a simple string.
				/// </summary>
				/// <param name="vTooltip">The tooltip that should be shown.</param>
				/// <returns>this instance</returns>
				public extern virtual object setTooltip(sap.ui.core.TooltipBase vTooltip);

				#endregion

				#endregion

			}
		}
	}
}
