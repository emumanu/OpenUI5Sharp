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
				/// Renders an input field for text input.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.TextField")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.Input}")]
				public partial class TextField : sap.ui.core.Control, sap.ui.commons.ToolbarItem, sap.ui.core.IFormContent
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
						/// Text inside the <code>TextField</code>
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

						/// <summary>
						/// Direction of the text. Possible values: "rtl", "ltr".
						/// </summary>
						public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

						/// <summary>
						/// Switches enabled state of the control. Disabled fields have different colors, and can not be focused.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Switches edit state of the control. Read-only fields have different colors, depending on theme setting.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

						/// <summary>
						/// Depending on theme the <code>TextField</code> is shown as required. If a <code>Label</code> is assigned to the <code>TextField</code> it will visualize the requires state too.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> required;

						/// <summary>
						/// Width of text field. When it is set (CSS-size such as % or px), this is the exact size. When left blank, the text field length defines the width.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Maximum number of characters. Value '0' means the feature is switched off.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxLength;

						/// <summary>
						/// Visualizes warnings or errors related to the text field. Possible values: Warning, Error, Success.
						/// </summary>
						public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

						/// <summary>
						/// Sets the horizontal alignment of the text.
						/// </summary>
						public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textAlign;

						/// <summary>
						/// State of the Input Method Editor (IME).
						/// </summary>
						public Union<sap.ui.core.ImeMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> imeMode;

						/// <summary>
						/// Font type. valid values are Standard and Monospace.
						/// </summary>
						public Union<sap.ui.core.Design, string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

						/// <summary>
						/// Unique identifier used for help service.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> helpId;

						/// <summary>
						/// Accessibility role for the text field.
						/// </summary>
						public Union<sap.ui.core.AccessibleRole, string, sap.ui.@base.ManagedObject.BindPropertyInfo> accessibleRole;

						/// <summary>
						/// The <code>name</code> property to be used in the HTML code (e.g. for HTML forms that send data to the server via 'submit').
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

						/// <summary>
						/// Placeholder for the text field.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> placeholder;

						/// <summary>
						/// Association to controls / IDs which describe this control (see WAI-ARIA attribute aria-describedby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

						/// <summary>
						/// Association to controls / IDs which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Event is fired when the text in the field has changed AND the focus leaves the TextField or the Enter key is pressed.
						/// </summary>
						public sap.ui.ux3.ChangeDelegate change;

						/// <summary>
						/// This event if fired during typing into the <code>TextField</code> and returns the currently entered value. <b>Note:</b> This is not the content of the value property. The value property is only updated by ENTER and by leaving the control.
						/// </summary>
						public sap.ui.commons.LiveChangeDelegate liveChange;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new TextField.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sID">id for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern TextField(string sID, sap.ui.commons.TextField.Settings mSettings);

					/// <summary>
					/// Constructor for a new TextField.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sID">id for the new control, generated automatically if no ID is given</param>
					public extern TextField(string sID);

					/// <summary>
					/// Constructor for a new TextField.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern TextField();

					/// <summary>
					/// Constructor for a new TextField.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern TextField(sap.ui.commons.TextField.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property value

					/// <summary>
					/// Gets current value of property {@link #getValue value}.
					/// 
					/// Text inside the <code>TextField</code>
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>value</code></returns>
					public extern virtual string getValue();

					/// <summary>
					/// Sets a new value for property {@link #getValue value}.
					/// 
					/// Text inside the <code>TextField</code>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sValue">New value for property <code>value</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setValue(string sValue);

					/// <summary>
					/// Binds property {@link #getValue value} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindProperty ManagedObject.bindProperty} for a detailed description of the possible properties of <code>oBindingInfo</code>
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField bindValue(object oBindingInfo);

					/// <summary>
					/// Unbinds property {@link #getValue value} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField unbindValue();

					#endregion

					#region Methods for Property textDirection

					/// <summary>
					/// Gets current value of property {@link #getTextDirection textDirection}.
					/// 
					/// Direction of the text. Possible values: "rtl", "ltr".
					/// 
					/// Default value is <code>Inherit</code>.
					/// </summary>
					/// <returns>Value of property <code>textDirection</code></returns>
					public extern virtual sap.ui.core.TextDirection getTextDirection();

					/// <summary>
					/// Sets a new value for property {@link #getTextDirection textDirection}.
					/// 
					/// Direction of the text. Possible values: "rtl", "ltr".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Inherit</code>.
					/// </summary>
					/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setTextDirection(sap.ui.core.TextDirection sTextDirection);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Switches enabled state of the control. Disabled fields have different colors, and can not be focused.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// Switches enabled state of the control. Disabled fields have different colors, and can not be focused.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property editable

					/// <summary>
					/// Gets current value of property {@link #getEditable editable}.
					/// 
					/// Switches edit state of the control. Read-only fields have different colors, depending on theme setting.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>editable</code></returns>
					public extern virtual bool getEditable();

					/// <summary>
					/// Sets a new value for property {@link #getEditable editable}.
					/// 
					/// Switches edit state of the control. Read-only fields have different colors, depending on theme setting.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEditable">New value for property <code>editable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setEditable(bool bEditable);

					#endregion

					#region Methods for Property required

					/// <summary>
					/// Gets current value of property {@link #getRequired required}.
					/// 
					/// Depending on theme the <code>TextField</code> is shown as required. If a <code>Label</code> is assigned to the <code>TextField</code> it will visualize the requires state too.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>required</code></returns>
					public extern virtual bool getRequired();

					/// <summary>
					/// Sets a new value for property {@link #getRequired required}.
					/// 
					/// Depending on theme the <code>TextField</code> is shown as required. If a <code>Label</code> is assigned to the <code>TextField</code> it will visualize the requires state too.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bRequired">New value for property <code>required</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setRequired(bool bRequired);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Width of text field. When it is set (CSS-size such as % or px), this is the exact size. When left blank, the text field length defines the width.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Width of text field. When it is set (CSS-size such as % or px), this is the exact size. When left blank, the text field length defines the width.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property maxLength

					/// <summary>
					/// Gets current value of property {@link #getMaxLength maxLength}.
					/// 
					/// Maximum number of characters. Value '0' means the feature is switched off.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>maxLength</code></returns>
					public extern virtual int getMaxLength();

					/// <summary>
					/// Sets a new value for property {@link #getMaxLength maxLength}.
					/// 
					/// Maximum number of characters. Value '0' means the feature is switched off.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iMaxLength">New value for property <code>maxLength</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setMaxLength(int iMaxLength);

					#endregion

					#region Methods for Property valueState

					/// <summary>
					/// Gets current value of property {@link #getValueState valueState}.
					/// 
					/// Visualizes warnings or errors related to the text field. Possible values: Warning, Error, Success.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>valueState</code></returns>
					public extern virtual sap.ui.core.ValueState getValueState();

					/// <summary>
					/// Sets a new value for property {@link #getValueState valueState}.
					/// 
					/// Visualizes warnings or errors related to the text field. Possible values: Warning, Error, Success.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sValueState">New value for property <code>valueState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setValueState(sap.ui.core.ValueState sValueState);

					#endregion

					#region Methods for Property textAlign

					/// <summary>
					/// Gets current value of property {@link #getTextAlign textAlign}.
					/// 
					/// Sets the horizontal alignment of the text.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <returns>Value of property <code>textAlign</code></returns>
					public extern virtual sap.ui.core.TextAlign getTextAlign();

					/// <summary>
					/// Sets a new value for property {@link #getTextAlign textAlign}.
					/// 
					/// Sets the horizontal alignment of the text.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <param name="sTextAlign">New value for property <code>textAlign</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setTextAlign(sap.ui.core.TextAlign sTextAlign);

					#endregion

					#region Methods for Property imeMode

					/// <summary>
					/// Gets current value of property {@link #getImeMode imeMode}.
					/// 
					/// State of the Input Method Editor (IME).
					/// 
					/// Default value is <code>Auto</code>.
					/// </summary>
					/// <returns>Value of property <code>imeMode</code></returns>
					public extern virtual sap.ui.core.ImeMode getImeMode();

					/// <summary>
					/// Sets a new value for property {@link #getImeMode imeMode}.
					/// 
					/// State of the Input Method Editor (IME).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Auto</code>.
					/// </summary>
					/// <param name="sImeMode">New value for property <code>imeMode</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setImeMode(sap.ui.core.ImeMode sImeMode);

					#endregion

					#region Methods for Property design

					/// <summary>
					/// Gets current value of property {@link #getDesign design}.
					/// 
					/// Font type. valid values are Standard and Monospace.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <returns>Value of property <code>design</code></returns>
					public extern virtual sap.ui.core.Design getDesign();

					/// <summary>
					/// Sets a new value for property {@link #getDesign design}.
					/// 
					/// Font type. valid values are Standard and Monospace.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <param name="sDesign">New value for property <code>design</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setDesign(sap.ui.core.Design sDesign);

					#endregion

					#region Methods for Property helpId

					/// <summary>
					/// Gets current value of property {@link #getHelpId helpId}.
					/// 
					/// Unique identifier used for help service.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>helpId</code></returns>
					public extern virtual string getHelpId();

					/// <summary>
					/// Sets a new value for property {@link #getHelpId helpId}.
					/// 
					/// Unique identifier used for help service.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sHelpId">New value for property <code>helpId</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setHelpId(string sHelpId);

					#endregion

					#region Methods for Property accessibleRole

					/// <summary>
					/// Gets current value of property {@link #getAccessibleRole accessibleRole}.
					/// 
					/// Accessibility role for the text field.
					/// 
					/// Default value is <code>Textbox</code>.
					/// </summary>
					/// <returns>Value of property <code>accessibleRole</code></returns>
					public extern virtual sap.ui.core.AccessibleRole getAccessibleRole();

					/// <summary>
					/// Sets a new value for property {@link #getAccessibleRole accessibleRole}.
					/// 
					/// Accessibility role for the text field.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Textbox</code>.
					/// </summary>
					/// <param name="sAccessibleRole">New value for property <code>accessibleRole</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setAccessibleRole(sap.ui.core.AccessibleRole sAccessibleRole);

					#endregion

					#region Methods for Property name

					/// <summary>
					/// Gets current value of property {@link #getName name}.
					/// 
					/// The <code>name</code> property to be used in the HTML code (e.g. for HTML forms that send data to the server via 'submit').
					/// </summary>
					/// <returns>Value of property <code>name</code></returns>
					public extern virtual string getName();

					/// <summary>
					/// Sets a new value for property {@link #getName name}.
					/// 
					/// The <code>name</code> property to be used in the HTML code (e.g. for HTML forms that send data to the server via 'submit').
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sName">New value for property <code>name</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setName(string sName);

					#endregion

					#region Methods for Property placeholder

					/// <summary>
					/// Gets current value of property {@link #getPlaceholder placeholder}.
					/// 
					/// Placeholder for the text field.
					/// </summary>
					/// <returns>Value of property <code>placeholder</code></returns>
					public extern virtual string getPlaceholder();

					/// <summary>
					/// Sets a new value for property {@link #getPlaceholder placeholder}.
					/// 
					/// Placeholder for the text field.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sPlaceholder">New value for property <code>placeholder</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField setPlaceholder(string sPlaceholder);

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
					public extern virtual sap.ui.commons.TextField addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
					public extern virtual sap.ui.commons.TextField addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.TextField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TextField</code> itself.
					/// 
					/// Event is fired when the text in the field has changed AND the focus leaves the TextField or the Enter key is pressed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TextField</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField attachChange(object oData, sap.ui.ux3.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.TextField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TextField</code> itself.
					/// 
					/// Event is fired when the text in the field has changed AND the focus leaves the TextField or the Enter key is pressed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField attachChange(object oData, sap.ui.ux3.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.TextField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TextField</code> itself.
					/// 
					/// Event is fired when the text in the field has changed AND the focus leaves the TextField or the Enter key is pressed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField attachChange(sap.ui.ux3.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.TextField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TextField</code> itself.
					/// 
					/// Event is fired when the text in the field has changed AND the focus leaves the TextField or the Enter key is pressed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TextField</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField attachChange(sap.ui.ux3.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.ui.commons.TextField</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField detachChange(sap.ui.ux3.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField fireChange(sap.ui.ux3.ChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField fireChange();

					#endregion

					#region Methods for Event liveChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.TextField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TextField</code> itself.
					/// 
					/// This event if fired during typing into the <code>TextField</code> and returns the currently entered value. <b>Note:</b> This is not the content of the value property. The value property is only updated by ENTER and by leaving the control.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TextField</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField attachLiveChange(object oData, sap.ui.commons.LiveChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.TextField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TextField</code> itself.
					/// 
					/// This event if fired during typing into the <code>TextField</code> and returns the currently entered value. <b>Note:</b> This is not the content of the value property. The value property is only updated by ENTER and by leaving the control.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField attachLiveChange(object oData, sap.ui.commons.LiveChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.TextField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TextField</code> itself.
					/// 
					/// This event if fired during typing into the <code>TextField</code> and returns the currently entered value. <b>Note:</b> This is not the content of the value property. The value property is only updated by ENTER and by leaving the control.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField attachLiveChange(sap.ui.commons.LiveChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.TextField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TextField</code> itself.
					/// 
					/// This event if fired during typing into the <code>TextField</code> and returns the currently entered value. <b>Note:</b> This is not the content of the value property. The value property is only updated by ENTER and by leaving the control.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TextField</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField attachLiveChange(sap.ui.commons.LiveChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.TextField</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField detachLiveChange(sap.ui.commons.LiveChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:liveChange liveChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField fireLiveChange(sap.ui.commons.LiveChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:liveChange liveChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextField fireLiveChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Compares the previous value with the current value and fires the change event if the TextField is editable and the value has changed.
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void _checkChange(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TextField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TextField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TextField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <returns>Current accessibility state of the control</returns>
					public extern virtual object getAccessibilityInfo();

					/// <summary>
					/// Returns an object representing the serialized focus information
					/// </summary>
					/// <returns>an object representing the serialized focus information</returns>
					public extern override object getFocusInfo();

					/// <summary>
					/// Method for accessing the DOM Ref of the input element.
					/// </summary>
					/// <returns>DOM reference or null</returns>
					public extern virtual object getInputDomRef();

					/// <summary>
					/// Returns the current value of the <code>TextField</code>. In case of editing the <code>TextField</code> you can access the current value via this method. The validated value is accessible via the property value.
					/// </summary>
					/// <returns>live value</returns>
					public extern virtual string getLiveValue();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.TextField.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Event handler called when control is receiving the focus
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onfocusin(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Event handler for keyup. fire the liveChange event
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onkeyup(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Event handler called when enter key is pressed.
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onsapenter(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Event handler called when control is losing the focus
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onsapfocusleave(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Event handler called when text selection starts. When the text field is disabled, the text should not be selectable, so cancel the event.
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onselectstart(jquery.JQuery.Event oEvent);

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
}
