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
			/// Allows end users to interact with date and/or time and select from a date and/or time pad.
			/// 
			/// <b>Note:</b> This control should not be used any longer, instead please use the dedicated <code>sap.m.DatePicker</code>, <code>sap.m.TimePicker</code> or <code>sap.m.DateTimePicker</code> control.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.DateTimeInput")]
			[Obsolete("Deprecated since 1.32.8. replaced by {@link sap.m.DatePicker}, {@link sap.m.TimePicker} or {@link sap.m.DateTimePicker}")]
			public partial class DateTimeInput : sap.ui.core.Control
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
					/// Defines the value of the control.
					/// 
					/// The new value must be in the format set by <code>valueFormat</code>.
					/// 
					/// The "Now" literal can also be assigned as a parameter to show the current date and/or time.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

					/// <summary>
					/// Defines the width of the control.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Indicates whether the user can interact with the control or not. <b>Note:</b> Disabled controls cannot be focused and they are out of the tab-chain.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

					/// <summary>
					/// Defines whether the control can be modified by the user or not. <b>Note:</b> A user can tab to non-editable control, highlight it, and copy the text from it.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

					/// <summary>
					/// Visualizes the validation state of the control, e.g. <code>Error</code>, <code>Warning</code>, <code>Success</code>.
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

					/// <summary>
					/// Defines the text that appears in the value state message pop-up. If this is not specified, a default text is shown from the resource bundle.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueStateText;

					/// <summary>
					/// Indicates whether the value state message should be shown or not.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showValueStateMessage;

					/// <summary>
					/// Defines the name of the control for the purposes of form submission.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

					/// <summary>
					/// Defines a short hint intended to aid the user with data entry when the control has no value.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> placeholder;

					/// <summary>
					/// Defines the horizontal alignment of the text that is shown inside the input field.
					/// </summary>
					public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textAlign;

					/// <summary>
					/// Defines the text directionality of the input field, e.g. <code>RTL</code>, <code>LTR</code>
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

					/// <summary>
					/// Type of DateTimeInput (e.g. Date, Time, DateTime)
					/// </summary>
					public Union<sap.m.DateTimeInputType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					/// <summary>
					/// Displays date value in this given format in text field. Default value is taken from locale settings. If you use data-binding on value property with type sap.ui.model.type.Date then you can ignore this property or the latter wins. If the user's browser supports native picker then this property is overwritten by browser with locale settings.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayFormat;

					/// <summary>
					/// Given value property should match with valueFormat to parse date. Default value is taken from locale settings. You can only set and get value in this format. If you use data-binding on value property with type sap.ui.model.type.Date you can ignore this property or the latter wins.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueFormat;

					/// <summary>
					/// This property as JavaScript Date Object can be used to assign a new value which is independent from valueFormat.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> dateValue;

					/// <summary>
					/// Association to controls / IDs that label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// This event gets fired when the selection has finished and the value has changed.
					/// </summary>
					public sap.m.DateTimeInput.ChangeDelegate change;

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
					/// The string value of the control in given valueFormat (or locale format).
					/// </summary>
					public string value;

					/// <summary>
					/// The value of control as JavaScript Date Object or null if value is empty.
					/// </summary>
					public object dateValue;

					/// <summary>
					/// if set, the entered value is a valid date. If not set the entered value cannot be converted to a date.
					/// </summary>
					public bool valid;

				}

				#endregion

				#region Delegates

				public delegate void ChangeDelegate(sap.ui.@base.Event<sap.m.DateTimeInput.ChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new DateTimeInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DateTimeInput(string sId, sap.m.DateTimeInput.Settings mSettings);

				/// <summary>
				/// Constructor for a new DateTimeInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern DateTimeInput(string sId);

				/// <summary>
				/// Constructor for a new DateTimeInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern DateTimeInput();

				/// <summary>
				/// Constructor for a new DateTimeInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DateTimeInput(sap.m.DateTimeInput.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property value

				/// <summary>
				/// Gets current value of property {@link #getValue value}.
				/// 
				/// Defines the value of the control.
				/// 
				/// The new value must be in the format set by <code>valueFormat</code>.
				/// 
				/// The "Now" literal can also be assigned as a parameter to show the current date and/or time.
				/// </summary>
				/// <returns>Value of property <code>value</code></returns>
				public extern virtual string getValue();

				/// <summary>
				/// Sets a new value for property {@link #getValue value}.
				/// 
				/// Defines the value of the control.
				/// 
				/// The new value must be in the format set by <code>valueFormat</code>.
				/// 
				/// The "Now" literal can also be assigned as a parameter to show the current date and/or time.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValue">New value for property <code>value</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setValue(string sValue);

				/// <summary>
				/// Binds property {@link #getValue value} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindProperty ManagedObject.bindProperty} for a detailed description of the possible properties of <code>oBindingInfo</code>
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput bindValue(sap.ui.@base.ManagedObject.BindPropertyInfo oBindingInfo);

				/// <summary>
				/// Unbinds property {@link #getValue value} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput unbindValue();

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the width of the control.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the width of the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Indicates whether the user can interact with the control or not. <b>Note:</b> Disabled controls cannot be focused and they are out of the tab-chain.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Indicates whether the user can interact with the control or not. <b>Note:</b> Disabled controls cannot be focused and they are out of the tab-chain.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property editable

				/// <summary>
				/// Gets current value of property {@link #getEditable editable}.
				/// 
				/// Defines whether the control can be modified by the user or not. <b>Note:</b> A user can tab to non-editable control, highlight it, and copy the text from it.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>editable</code></returns>
				public extern virtual bool getEditable();

				/// <summary>
				/// Sets a new value for property {@link #getEditable editable}.
				/// 
				/// Defines whether the control can be modified by the user or not. <b>Note:</b> A user can tab to non-editable control, highlight it, and copy the text from it.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEditable">New value for property <code>editable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setEditable(bool bEditable);

				#endregion

				#region Methods for Property valueState

				/// <summary>
				/// Gets current value of property {@link #getValueState valueState}.
				/// 
				/// Visualizes the validation state of the control, e.g. <code>Error</code>, <code>Warning</code>, <code>Success</code>.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>valueState</code></returns>
				public extern virtual sap.ui.core.ValueState getValueState();

				/// <summary>
				/// Sets a new value for property {@link #getValueState valueState}.
				/// 
				/// Visualizes the validation state of the control, e.g. <code>Error</code>, <code>Warning</code>, <code>Success</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sValueState">New value for property <code>valueState</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setValueState(sap.ui.core.ValueState sValueState);

				#endregion

				#region Methods for Property valueStateText

				/// <summary>
				/// Gets current value of property {@link #getValueStateText valueStateText}.
				/// 
				/// Defines the text that appears in the value state message pop-up. If this is not specified, a default text is shown from the resource bundle.
				/// </summary>
				/// <returns>Value of property <code>valueStateText</code></returns>
				public extern virtual string getValueStateText();

				/// <summary>
				/// Sets a new value for property {@link #getValueStateText valueStateText}.
				/// 
				/// Defines the text that appears in the value state message pop-up. If this is not specified, a default text is shown from the resource bundle.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValueStateText">New value for property <code>valueStateText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setValueStateText(string sValueStateText);

				#endregion

				#region Methods for Property showValueStateMessage

				/// <summary>
				/// Gets current value of property {@link #getShowValueStateMessage showValueStateMessage}.
				/// 
				/// Indicates whether the value state message should be shown or not.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showValueStateMessage</code></returns>
				public extern virtual bool getShowValueStateMessage();

				/// <summary>
				/// Sets a new value for property {@link #getShowValueStateMessage showValueStateMessage}.
				/// 
				/// Indicates whether the value state message should be shown or not.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowValueStateMessage">New value for property <code>showValueStateMessage</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setShowValueStateMessage(bool bShowValueStateMessage);

				#endregion

				#region Methods for Property name

				/// <summary>
				/// Gets current value of property {@link #getName name}.
				/// 
				/// Defines the name of the control for the purposes of form submission.
				/// </summary>
				/// <returns>Value of property <code>name</code></returns>
				public extern virtual string getName();

				/// <summary>
				/// Sets a new value for property {@link #getName name}.
				/// 
				/// Defines the name of the control for the purposes of form submission.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sName">New value for property <code>name</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setName(string sName);

				#endregion

				#region Methods for Property placeholder

				/// <summary>
				/// Gets current value of property {@link #getPlaceholder placeholder}.
				/// 
				/// Defines a short hint intended to aid the user with data entry when the control has no value.
				/// </summary>
				/// <returns>Value of property <code>placeholder</code></returns>
				public extern virtual string getPlaceholder();

				/// <summary>
				/// Sets a new value for property {@link #getPlaceholder placeholder}.
				/// 
				/// Defines a short hint intended to aid the user with data entry when the control has no value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sPlaceholder">New value for property <code>placeholder</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setPlaceholder(string sPlaceholder);

				#endregion

				#region Methods for Property textAlign

				/// <summary>
				/// Gets current value of property {@link #getTextAlign textAlign}.
				/// 
				/// Defines the horizontal alignment of the text that is shown inside the input field.
				/// 
				/// Default value is <code>Initial</code>.
				/// </summary>
				/// <returns>Value of property <code>textAlign</code></returns>
				public extern virtual sap.ui.core.TextAlign getTextAlign();

				/// <summary>
				/// Sets a new value for property {@link #getTextAlign textAlign}.
				/// 
				/// Defines the horizontal alignment of the text that is shown inside the input field.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Initial</code>.
				/// </summary>
				/// <param name="sTextAlign">New value for property <code>textAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setTextAlign(sap.ui.core.TextAlign sTextAlign);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Defines the text directionality of the input field, e.g. <code>RTL</code>, <code>LTR</code>
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Defines the text directionality of the input field, e.g. <code>RTL</code>, <code>LTR</code>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// Type of DateTimeInput (e.g. Date, Time, DateTime)
				/// 
				/// Default value is <code>Date</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.m.DateTimeInputType getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// Type of DateTimeInput (e.g. Date, Time, DateTime)
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Date</code>.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setType(sap.m.DateTimeInputType sType);

				#endregion

				#region Methods for Property displayFormat

				/// <summary>
				/// Gets current value of property {@link #getDisplayFormat displayFormat}.
				/// 
				/// Displays date value in this given format in text field. Default value is taken from locale settings. If you use data-binding on value property with type sap.ui.model.type.Date then you can ignore this property or the latter wins. If the user's browser supports native picker then this property is overwritten by browser with locale settings.
				/// </summary>
				/// <returns>Value of property <code>displayFormat</code></returns>
				public extern virtual string getDisplayFormat();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayFormat displayFormat}.
				/// 
				/// Displays date value in this given format in text field. Default value is taken from locale settings. If you use data-binding on value property with type sap.ui.model.type.Date then you can ignore this property or the latter wins. If the user's browser supports native picker then this property is overwritten by browser with locale settings.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDisplayFormat">New value for property <code>displayFormat</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setDisplayFormat(string sDisplayFormat);

				#endregion

				#region Methods for Property valueFormat

				/// <summary>
				/// Gets current value of property {@link #getValueFormat valueFormat}.
				/// 
				/// Given value property should match with valueFormat to parse date. Default value is taken from locale settings. You can only set and get value in this format. If you use data-binding on value property with type sap.ui.model.type.Date you can ignore this property or the latter wins.
				/// </summary>
				/// <returns>Value of property <code>valueFormat</code></returns>
				public extern virtual string getValueFormat();

				/// <summary>
				/// Sets a new value for property {@link #getValueFormat valueFormat}.
				/// 
				/// Given value property should match with valueFormat to parse date. Default value is taken from locale settings. You can only set and get value in this format. If you use data-binding on value property with type sap.ui.model.type.Date you can ignore this property or the latter wins.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValueFormat">New value for property <code>valueFormat</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setValueFormat(string sValueFormat);

				#endregion

				#region Methods for Property dateValue

				/// <summary>
				/// Gets current value of property {@link #getDateValue dateValue}.
				/// 
				/// This property as JavaScript Date Object can be used to assign a new value which is independent from valueFormat.
				/// </summary>
				/// <returns>Value of property <code>dateValue</code></returns>
				public extern virtual object getDateValue();

				/// <summary>
				/// Sets a new value for property {@link #getDateValue dateValue}.
				/// 
				/// This property as JavaScript Date Object can be used to assign a new value which is independent from valueFormat.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oDateValue">New value for property <code>dateValue</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput setDateValue(object oDateValue);

				#endregion

				#region Methods for Aggregation _picker

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
				public extern virtual sap.m.DateTimeInput addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.DateTimeInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.DateTimeInput</code> itself.
				/// 
				/// This event gets fired when the selection has finished and the value has changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.DateTimeInput</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput attachChange(object oData, sap.m.DateTimeInput.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.DateTimeInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.DateTimeInput</code> itself.
				/// 
				/// This event gets fired when the selection has finished and the value has changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput attachChange(object oData, sap.m.DateTimeInput.ChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.DateTimeInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.DateTimeInput</code> itself.
				/// 
				/// This event gets fired when the selection has finished and the value has changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput attachChange(sap.m.DateTimeInput.ChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.DateTimeInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.DateTimeInput</code> itself.
				/// 
				/// This event gets fired when the selection has finished and the value has changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.DateTimeInput</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput attachChange(sap.m.DateTimeInput.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.m.DateTimeInput</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput detachChange(sap.m.DateTimeInput.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput fireChange(sap.m.DateTimeInput.ChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeInput fireChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.DateTimeInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.DateTimeInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.DateTimeInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <returns>Current accessibility state of the control</returns>
				public extern virtual object getAccessibilityInfo();

				/// <summary>
				/// Returns a metadata object for class sap.m.DateTimeInput.
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
