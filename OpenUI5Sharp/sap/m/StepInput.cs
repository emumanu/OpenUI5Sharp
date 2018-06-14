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
			/// Allows the user to change the input values with predefined increments (steps).
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>StepInput</code> consists of an input field and buttons with icons to increase/decrease the value.
			/// 
			/// The user can change the value of the control by pressing the increase/decrease buttons, by typing a number directly, by using the keyboard up/down and page up/down, or by using the mouse scroll wheel. Decimal values are supported.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// The default step is 1 but the app developer can set a different one.
			/// 
			/// On desktop, the control supports a larger step, when using the keyboard page up/down keys. You can set a multiple of the step with the use of the <code>largerStep</code> property. The default value is 2 (two times the set step). For example, when using the keyboard page up/down keys the value increases/decreases with a double of the default step. If the set step is 2, the larger step is also 2 and the current value is 1, using the page up key will increase the value to 5 (1 + 2*2).
			/// 
			/// App developers can set a maximum and minimum value for the <code>StepInput</code>. The increase/decrease button and the up/down keyboard navigation become disabled when the value reaches the max/min or a new value is entered from the input which is greater/less than the max/min.
			/// 
			/// <i>When to use</i> <ul> <li>To adjust amounts, quantities, or other values quickly.</li> <li>To adjust values for a specific step.</li> </ul>
			/// 
			/// <i>When not to use</i> <ul> <li>To enter a static number (for example, postal code, phone number, or ID). In this case, use the regular {@link sap.m.Input} instead.</li> <li>To display a value that rarely needs to be adjusted and does not pertain to a particular step. In this case, use the regular {@link sap.m.Input} instead.</li> <li>To enter dates and times. In this case, use the {@link sap.m.DatePicker}, {@link sap.m.DateRangeSelection}, {@link sap.m.TimePicker}, or {@link sap.m.DateTimePicker} instead.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class StepInput : sap.ui.core.Control, sap.ui.core.IFormContent
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
					/// Sets the minimum possible value of the defined range.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> min;

					/// <summary>
					/// Sets the maximum possible value of the defined range.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> max;

					/// <summary>
					/// Increases/decreases the value of the input. <ul><b>Note:</b> <li>The value of the <code>step</code> property should not contain more digits after the decimal point than what is set to the <code>displayValuePrecision</code> property, as it may lead to an increase/decrease that is not visible for the user. For example, if the <code>value</code> is set to 1.22 and the <code>displayValuePrecision</code> is set to one digit after the decimal, the user will see 1.2. In this case, if the <code>value</code> of the <code>step</code> property is set to 1.005 and the user selects <code>increase</code>, the resulting value will increase to 1.2261 but the displayed value will remain as 1.2 as it will be rounded to the first digit after the decimal point.</li> <li>Depending on what is set for the <code>value</code> and the <code>displayValuePrecision</code> properties, it is possible the displayed value to be rounded to a higher number, for example to 3.0 when the actual value is 2.99.</li></ul>
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> step;

					/// <summary>
					/// Defines the calculation mode for the provided <code>step<code> and <code>largerStep</code>.
					/// 
					/// If the user increases/decreases the value by <code>largerStep</code>, this calculation will consider it as well. For example, if the current <code>value</code> is 3, <code>step</code> is 5, <code>largerStep</code> is 5 and the user chooses PageUp, the calculation logic will consider the value of 3x5=15 to decide what will be the next <code>value</code>.
					/// </summary>
					public Union<sap.m.StepInputStepModeType, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> stepMode;

					/// <summary>
					/// Increases/decreases the value with a larger value than the set step only when using the PageUp/PageDown keys. Default value is 2 times larger than the set step.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> largerStep;

					/// <summary>
					/// Determines the value of the <code>StepInput</code> and can be set initially from the app developer.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> value;

					/// <summary>
					/// Defines the name of the control for the purposes of form submission.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> name;

					/// <summary>
					/// Defines a short hint intended to aid the user with data entry when the control has no value.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> placeholder;

					/// <summary>
					/// Indicates that user input is required. This property is only needed for accessibility purposes when a single relationship between the field and a label (see aggregation <code>labelFor</code> of <code>sap.m.Label</code>) cannot be established (e.g. one label should label multiple fields).
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> required;

					/// <summary>
					/// Defines the width of the control.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

					/// <summary>
					/// Accepts the core enumeration ValueState.type that supports <code>None</code>, <code>Error</code>, <code>Warning</code> and <code>Success</code>.
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> valueState;

					/// <summary>
					/// Defines the text that appears in the value state message pop-up.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> valueStateText;

					/// <summary>
					/// Defines whether the control can be modified by the user or not. <b>Note:</b> A user can tab to the non-editable control, highlight it, and copy the text from it.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> editable;

					/// <summary>
					/// Indicates whether the user can interact with the control or not. <b>Note:</b> Disabled controls cannot be focused and they are out of the tab-chain.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enabled;

					/// <summary>
					/// Determines the number of digits after the decimal point.
					/// 
					/// The value should be between 0 (default) and 20. In case the value is not valid it will be set to the default value.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> displayValuePrecision;

					/// <summary>
					/// Determines the description text after the input field, for example units of measurement, currencies.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> description;

					/// <summary>
					/// Determines the distribution of space between the input field and the description text . Default value is 50% (leaving the other 50% for the description).
					/// 
					/// <b>Note:</b> This property takes effect only if the <code>description</code> property is also set.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> fieldWidth;

					/// <summary>
					/// Defines the horizontal alignment of the text that is displayed inside the input field.
					/// </summary>
					public Union<sap.ui.core.TextAlign, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> textAlign;

					/// <summary>
					/// Defines when the validation of the typed value will happen. By default this happens on focus out.
					/// </summary>
					public Union<sap.m.StepInputValidationMode, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> validationMode;

					/// <summary>
					/// Association to controls / IDs that label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelledBy;

					/// <summary>
					/// Association to controls / IDs which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaDescribedBy;

					/// <summary>
					/// Is fired when one of the following happens: <br> <ol> <li>the text in the input has changed and the focus leaves the input field or the enter key is pressed.</li> <li>One of the decrement or increment buttons is pressed</li> </ol>
					/// </summary>
					public sap.m.SubmitOrChangeDelegate change;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>StepInput</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern StepInput(string sId, sap.m.StepInput.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>StepInput</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern StepInput(string sId);

				/// <summary>
				/// Constructor for a new <code>StepInput</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern StepInput();

				/// <summary>
				/// Constructor for a new <code>StepInput</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern StepInput(sap.m.StepInput.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property min

				/// <summary>
				/// Gets current value of property {@link #getMin min}.
				/// 
				/// Sets the minimum possible value of the defined range.
				/// </summary>
				/// <returns>Value of property <code>min</code></returns>
				public extern virtual float getMin();

				/// <summary>
				/// Sets a new value for property {@link #getMin min}.
				/// 
				/// Sets the minimum possible value of the defined range.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="fMin">New value for property <code>min</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setMin(float fMin);

				#endregion

				#region Methods for Property max

				/// <summary>
				/// Gets current value of property {@link #getMax max}.
				/// 
				/// Sets the maximum possible value of the defined range.
				/// </summary>
				/// <returns>Value of property <code>max</code></returns>
				public extern virtual float getMax();

				/// <summary>
				/// Sets a new value for property {@link #getMax max}.
				/// 
				/// Sets the maximum possible value of the defined range.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="fMax">New value for property <code>max</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setMax(float fMax);

				#endregion

				#region Methods for Property step

				/// <summary>
				/// Gets current value of property {@link #getStep step}.
				/// 
				/// Increases/decreases the value of the input. <ul><b>Note:</b> <li>The value of the <code>step</code> property should not contain more digits after the decimal point than what is set to the <code>displayValuePrecision</code> property, as it may lead to an increase/decrease that is not visible for the user. For example, if the <code>value</code> is set to 1.22 and the <code>displayValuePrecision</code> is set to one digit after the decimal, the user will see 1.2. In this case, if the <code>value</code> of the <code>step</code> property is set to 1.005 and the user selects <code>increase</code>, the resulting value will increase to 1.2261 but the displayed value will remain as 1.2 as it will be rounded to the first digit after the decimal point.</li> <li>Depending on what is set for the <code>value</code> and the <code>displayValuePrecision</code> properties, it is possible the displayed value to be rounded to a higher number, for example to 3.0 when the actual value is 2.99.</li></ul>
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>step</code></returns>
				public extern virtual float getStep();

				/// <summary>
				/// Sets a new value for property {@link #getStep step}.
				/// 
				/// Increases/decreases the value of the input. <ul><b>Note:</b> <li>The value of the <code>step</code> property should not contain more digits after the decimal point than what is set to the <code>displayValuePrecision</code> property, as it may lead to an increase/decrease that is not visible for the user. For example, if the <code>value</code> is set to 1.22 and the <code>displayValuePrecision</code> is set to one digit after the decimal, the user will see 1.2. In this case, if the <code>value</code> of the <code>step</code> property is set to 1.005 and the user selects <code>increase</code>, the resulting value will increase to 1.2261 but the displayed value will remain as 1.2 as it will be rounded to the first digit after the decimal point.</li> <li>Depending on what is set for the <code>value</code> and the <code>displayValuePrecision</code> properties, it is possible the displayed value to be rounded to a higher number, for example to 3.0 when the actual value is 2.99.</li></ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <param name="fStep">New value for property <code>step</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setStep(float fStep);

				#endregion

				#region Methods for Property stepMode

				/// <summary>
				/// Gets current value of property {@link #getStepMode stepMode}.
				/// 
				/// Defines the calculation mode for the provided <code>step<code> and <code>largerStep</code>.
				/// 
				/// If the user increases/decreases the value by <code>largerStep</code>, this calculation will consider it as well. For example, if the current <code>value</code> is 3, <code>step</code> is 5, <code>largerStep</code> is 5 and the user chooses PageUp, the calculation logic will consider the value of 3x5=15 to decide what will be the next <code>value</code>.
				/// 
				/// Default value is <code>AdditionAndSubtraction</code>.
				/// </summary>
				/// <returns>Value of property <code>stepMode</code></returns>
				public extern virtual sap.m.StepInputStepModeType getStepMode();

				/// <summary>
				/// Sets a new value for property {@link #getStepMode stepMode}.
				/// 
				/// Defines the calculation mode for the provided <code>step<code> and <code>largerStep</code>.
				/// 
				/// If the user increases/decreases the value by <code>largerStep</code>, this calculation will consider it as well. For example, if the current <code>value</code> is 3, <code>step</code> is 5, <code>largerStep</code> is 5 and the user chooses PageUp, the calculation logic will consider the value of 3x5=15 to decide what will be the next <code>value</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>AdditionAndSubtraction</code>.
				/// </summary>
				/// <param name="sStepMode">New value for property <code>stepMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setStepMode(sap.m.StepInputStepModeType sStepMode);

				#endregion

				#region Methods for Property largerStep

				/// <summary>
				/// Gets current value of property {@link #getLargerStep largerStep}.
				/// 
				/// Increases/decreases the value with a larger value than the set step only when using the PageUp/PageDown keys. Default value is 2 times larger than the set step.
				/// 
				/// Default value is <code>2</code>.
				/// </summary>
				/// <returns>Value of property <code>largerStep</code></returns>
				public extern virtual float getLargerStep();

				/// <summary>
				/// Sets a new value for property {@link #getLargerStep largerStep}.
				/// 
				/// Increases/decreases the value with a larger value than the set step only when using the PageUp/PageDown keys. Default value is 2 times larger than the set step.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>2</code>.
				/// </summary>
				/// <param name="fLargerStep">New value for property <code>largerStep</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setLargerStep(float fLargerStep);

				#endregion

				#region Methods for Property value

				/// <summary>
				/// Gets current value of property {@link #getValue value}.
				/// 
				/// Determines the value of the <code>StepInput</code> and can be set initially from the app developer.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>value</code></returns>
				public extern virtual float getValue();

				/// <summary>
				/// Sets a new value for property {@link #getValue value}.
				/// 
				/// Determines the value of the <code>StepInput</code> and can be set initially from the app developer.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="fValue">New value for property <code>value</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setValue(float fValue);

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
				public extern virtual sap.m.StepInput setName(string sName);

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
				public extern virtual sap.m.StepInput setPlaceholder(string sPlaceholder);

				#endregion

				#region Methods for Property required

				/// <summary>
				/// Gets current value of property {@link #getRequired required}.
				/// 
				/// Indicates that user input is required. This property is only needed for accessibility purposes when a single relationship between the field and a label (see aggregation <code>labelFor</code> of <code>sap.m.Label</code>) cannot be established (e.g. one label should label multiple fields).
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>required</code></returns>
				public extern virtual bool getRequired();

				/// <summary>
				/// Sets a new value for property {@link #getRequired required}.
				/// 
				/// Indicates that user input is required. This property is only needed for accessibility purposes when a single relationship between the field and a label (see aggregation <code>labelFor</code> of <code>sap.m.Label</code>) cannot be established (e.g. one label should label multiple fields).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bRequired">New value for property <code>required</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setRequired(bool bRequired);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the width of the control.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the width of the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property valueState

				/// <summary>
				/// Gets current value of property {@link #getValueState valueState}.
				/// 
				/// Accepts the core enumeration ValueState.type that supports <code>None</code>, <code>Error</code>, <code>Warning</code> and <code>Success</code>.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>valueState</code></returns>
				public extern virtual sap.ui.core.ValueState getValueState();

				/// <summary>
				/// Sets a new value for property {@link #getValueState valueState}.
				/// 
				/// Accepts the core enumeration ValueState.type that supports <code>None</code>, <code>Error</code>, <code>Warning</code> and <code>Success</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sValueState">New value for property <code>valueState</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setValueState(sap.ui.core.ValueState sValueState);

				#endregion

				#region Methods for Property valueStateText

				/// <summary>
				/// Gets current value of property {@link #getValueStateText valueStateText}.
				/// 
				/// Defines the text that appears in the value state message pop-up.
				/// </summary>
				/// <returns>Value of property <code>valueStateText</code></returns>
				public extern virtual string getValueStateText();

				/// <summary>
				/// Sets a new value for property {@link #getValueStateText valueStateText}.
				/// 
				/// Defines the text that appears in the value state message pop-up.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValueStateText">New value for property <code>valueStateText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setValueStateText(string sValueStateText);

				#endregion

				#region Methods for Property editable

				/// <summary>
				/// Gets current value of property {@link #getEditable editable}.
				/// 
				/// Defines whether the control can be modified by the user or not. <b>Note:</b> A user can tab to the non-editable control, highlight it, and copy the text from it.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>editable</code></returns>
				public extern virtual bool getEditable();

				/// <summary>
				/// Sets a new value for property {@link #getEditable editable}.
				/// 
				/// Defines whether the control can be modified by the user or not. <b>Note:</b> A user can tab to the non-editable control, highlight it, and copy the text from it.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEditable">New value for property <code>editable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setEditable(bool bEditable);

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
				public extern virtual sap.m.StepInput setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property displayValuePrecision

				/// <summary>
				/// Gets current value of property {@link #getDisplayValuePrecision displayValuePrecision}.
				/// 
				/// Determines the number of digits after the decimal point.
				/// 
				/// The value should be between 0 (default) and 20. In case the value is not valid it will be set to the default value.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>displayValuePrecision</code></returns>
				public extern virtual int getDisplayValuePrecision();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayValuePrecision displayValuePrecision}.
				/// 
				/// Determines the number of digits after the decimal point.
				/// 
				/// The value should be between 0 (default) and 20. In case the value is not valid it will be set to the default value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="iDisplayValuePrecision">New value for property <code>displayValuePrecision</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setDisplayValuePrecision(int iDisplayValuePrecision);

				#endregion

				#region Methods for Property description

				/// <summary>
				/// Gets current value of property {@link #getDescription description}.
				/// 
				/// Determines the description text after the input field, for example units of measurement, currencies.
				/// </summary>
				/// <returns>Value of property <code>description</code></returns>
				public extern virtual string getDescription();

				/// <summary>
				/// Sets a new value for property {@link #getDescription description}.
				/// 
				/// Determines the description text after the input field, for example units of measurement, currencies.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDescription">New value for property <code>description</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setDescription(string sDescription);

				#endregion

				#region Methods for Property fieldWidth

				/// <summary>
				/// Gets current value of property {@link #getFieldWidth fieldWidth}.
				/// 
				/// Determines the distribution of space between the input field and the description text . Default value is 50% (leaving the other 50% for the description).
				/// 
				/// <b>Note:</b> This property takes effect only if the <code>description</code> property is also set.
				/// 
				/// Default value is <code>50%</code>.
				/// </summary>
				/// <returns>Value of property <code>fieldWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getFieldWidth();

				/// <summary>
				/// Sets a new value for property {@link #getFieldWidth fieldWidth}.
				/// 
				/// Determines the distribution of space between the input field and the description text . Default value is 50% (leaving the other 50% for the description).
				/// 
				/// <b>Note:</b> This property takes effect only if the <code>description</code> property is also set.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>50%</code>.
				/// </summary>
				/// <param name="sFieldWidth">New value for property <code>fieldWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setFieldWidth(sap.ui.core.CSSSize sFieldWidth);

				#endregion

				#region Methods for Property textAlign

				/// <summary>
				/// Gets current value of property {@link #getTextAlign textAlign}.
				/// 
				/// Defines the horizontal alignment of the text that is displayed inside the input field.
				/// 
				/// Default value is <code>End</code>.
				/// </summary>
				/// <returns>Value of property <code>textAlign</code></returns>
				public extern virtual sap.ui.core.TextAlign getTextAlign();

				/// <summary>
				/// Sets a new value for property {@link #getTextAlign textAlign}.
				/// 
				/// Defines the horizontal alignment of the text that is displayed inside the input field.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>End</code>.
				/// </summary>
				/// <param name="sTextAlign">New value for property <code>textAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setTextAlign(sap.ui.core.TextAlign sTextAlign);

				#endregion

				#region Methods for Property validationMode

				/// <summary>
				/// Gets current value of property {@link #getValidationMode validationMode}.
				/// 
				/// Defines when the validation of the typed value will happen. By default this happens on focus out.
				/// 
				/// Default value is <code>FocusOut</code>.
				/// </summary>
				/// <returns>Value of property <code>validationMode</code></returns>
				public extern virtual sap.m.StepInputValidationMode getValidationMode();

				/// <summary>
				/// Sets a new value for property {@link #getValidationMode validationMode}.
				/// 
				/// Defines when the validation of the typed value will happen. By default this happens on focus out.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>FocusOut</code>.
				/// </summary>
				/// <param name="sValidationMode">New value for property <code>validationMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput setValidationMode(sap.m.StepInputValidationMode sValidationMode);

				#endregion

				#region Methods for Aggregation _incrementButton

				#endregion

				#region Methods for Aggregation _decrementButton

				#endregion

				#region Methods for Aggregation _input

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
				public extern virtual sap.m.StepInput addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				public extern virtual sap.m.StepInput addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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

				#region Methods for Event change

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.StepInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.StepInput</code> itself.
				/// 
				/// Is fired when one of the following happens: <br> <ol> <li>the text in the input has changed and the focus leaves the input field or the enter key is pressed.</li> <li>One of the decrement or increment buttons is pressed</li> </ol>
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.StepInput</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput attachChange(object oData, sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.StepInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.StepInput</code> itself.
				/// 
				/// Is fired when one of the following happens: <br> <ol> <li>the text in the input has changed and the focus leaves the input field or the enter key is pressed.</li> <li>One of the decrement or increment buttons is pressed</li> </ol>
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput attachChange(object oData, sap.m.SubmitOrChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.StepInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.StepInput</code> itself.
				/// 
				/// Is fired when one of the following happens: <br> <ol> <li>the text in the input has changed and the focus leaves the input field or the enter key is pressed.</li> <li>One of the decrement or increment buttons is pressed</li> </ol>
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput attachChange(sap.m.SubmitOrChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.StepInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.StepInput</code> itself.
				/// 
				/// Is fired when one of the following happens: <br> <ol> <li>the text in the input has changed and the focus leaves the input field or the enter key is pressed.</li> <li>One of the decrement or increment buttons is pressed</li> </ol>
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.StepInput</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput attachChange(sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.m.StepInput</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput detachChange(sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput fireChange(sap.m.SubmitOrChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StepInput fireChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.StepInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.StepInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.StepInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.StepInput.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

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
