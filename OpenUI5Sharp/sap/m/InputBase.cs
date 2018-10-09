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
			/// The <code>sap.m.InputBase</code> control provides a basic functionality for input controls.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.InputBase")]
			public partial class InputBase : sap.ui.core.Control, sap.ui.core.IFormContent
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
					/// Visualizes the validation state of the control, e.g. <code>Error</code>, <code>Warning</code>, <code>Success</code>.
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

					/// <summary>
					/// Defines the name of the control for the purposes of form submission.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

					/// <summary>
					/// Defines a short hint intended to aid the user with data entry when the control has no value.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> placeholder;

					/// <summary>
					/// Defines whether the control can be modified by the user or not. <b>Note:</b> A user can tab to non-editable control, highlight it, and copy the text from it.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

					/// <summary>
					/// Defines the text that appears in the value state message pop-up. If this is not specified, a default text is shown from the resource bundle.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueStateText;

					/// <summary>
					/// Indicates whether the value state message should be shown or not.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showValueStateMessage;

					/// <summary>
					/// Defines the horizontal alignment of the text that is shown inside the input field.
					/// </summary>
					public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textAlign;

					/// <summary>
					/// Defines the text directionality of the input field, e.g. <code>RTL</code>, <code>LTR</code>
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

					/// <summary>
					/// Indicates that user input is required. This property is only needed for accessibility purposes when a single relationship between the field and a label (see aggregation <code>labelFor</code> of <code>sap.m.Label</code>) cannot be established (e.g. one label should label multiple fields).
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> required;

					/// <summary>
					/// Association to controls / IDs that label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Is fired when the text in the input field has changed and the focus leaves the input field or the enter key is pressed.
					/// </summary>
					public sap.m.ValueDelegate change;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>sap.m.InputBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern InputBase(string sId, sap.m.InputBase.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>sap.m.InputBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern InputBase(string sId);

				/// <summary>
				/// Constructor for a new <code>sap.m.InputBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern InputBase();

				/// <summary>
				/// Constructor for a new <code>sap.m.InputBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern InputBase(sap.m.InputBase.Settings mSettings);

				#endregion

				#region Fields

				/// <summary>
				/// Indicates whether the input field is in the rendering phase.
				/// </summary>
				public object bRenderingPhase;

				/// <summary>
				/// Use labels as placeholder configuration. It can be necessary for the subclasses to overwrite this when native placeholder usage causes undesired input events or when placeholder attribute is not supported for the specified type. https://html.spec.whatwg.org/multipage/forms.html#input-type-attr-summary
				/// </summary>
				public object bShowLabelAsPlaceholder;

				#endregion

				#region Methods

				#region Methods for Property value

				/// <summary>
				/// Gets current value of property {@link #getValue value}.
				/// 
				/// Defines the value of the control.
				/// </summary>
				/// <returns>Value of property <code>value</code></returns>
				public extern virtual string getValue();

				/// <summary>
				/// Setter for property <code>value</code>.
				/// 
				/// Default value is empty/<code>undefined</code>.
				/// </summary>
				/// <param name="sValue">New value for property <code>value</code>.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.InputBase setValue(string sValue);

				/// <summary>
				/// Binds property {@link #getValue value} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindProperty ManagedObject.bindProperty} for a detailed description of the possible properties of <code>oBindingInfo</code>
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputBase bindValue(object oBindingInfo);

				/// <summary>
				/// Unbinds property {@link #getValue value} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputBase unbindValue();

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
				public extern virtual sap.m.InputBase setWidth(sap.ui.core.CSSSize sWidth);

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
				public extern virtual sap.m.InputBase setEnabled(bool bEnabled);

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
				/// Setter for property <code>valueState</code>.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sValueState">New value for property <code>valueState</code>.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.InputBase setValueState(sap.ui.core.ValueState sValueState);

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
				public extern virtual sap.m.InputBase setName(string sName);

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
				public extern virtual sap.m.InputBase setPlaceholder(string sPlaceholder);

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
				public extern virtual sap.m.InputBase setEditable(bool bEditable);

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
				/// Setter for property <code>valueStateText</code>.
				/// 
				/// Default value is empty/<code>undefined</code>.
				/// </summary>
				/// <param name="sText">New value for property <code>valueStateText</code>.</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.InputBase setValueStateText(string sText);

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
				public extern virtual sap.m.InputBase setShowValueStateMessage(bool bShowValueStateMessage);

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
				public extern virtual sap.m.InputBase setTextAlign(sap.ui.core.TextAlign sTextAlign);

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
				public extern virtual sap.m.InputBase setTextDirection(sap.ui.core.TextDirection sTextDirection);

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
				public extern virtual sap.m.InputBase setRequired(bool bRequired);

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
				public extern virtual sap.m.InputBase addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.InputBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.InputBase</code> itself.
				/// 
				/// Is fired when the text in the input field has changed and the focus leaves the input field or the enter key is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.InputBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputBase attachChange(object oData, sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.InputBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.InputBase</code> itself.
				/// 
				/// Is fired when the text in the input field has changed and the focus leaves the input field or the enter key is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputBase attachChange(object oData, sap.m.ValueDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.InputBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.InputBase</code> itself.
				/// 
				/// Is fired when the text in the input field has changed and the focus leaves the input field or the enter key is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputBase attachChange(sap.m.ValueDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.InputBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.InputBase</code> itself.
				/// 
				/// Is fired when the text in the input field has changed and the focus leaves the input field or the enter key is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.InputBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputBase attachChange(sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.m.InputBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputBase detachChange(sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputBase fireChange(sap.m.ValueInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputBase fireChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Applies the focus info. To be overwritten by subclasses.
				/// </summary>
				/// <param name="oFocusInfo"></param>
				public extern override void applyFocusInfo(object oFocusInfo);

				/// <summary>
				/// Registers an event listener to the browser input event.
				/// </summary>
				/// <param name="fnCallback">Function to be called when the value of the input element is changed.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				[Obsolete("Deprecated since 1.22. Instead, use event delegation(oninput) to listen input event.")]
				public extern virtual sap.m.InputBase bindToInputEvent(object fnCallback);

				/// <summary>
				/// Close value state message popup.
				/// </summary>
				public extern virtual void closeValueStateMessage();

				/// <summary>
				/// Creates a new subclass of class sap.m.InputBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.InputBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.InputBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Fires the change event for the listeners
				/// </summary>
				/// <param name="sValue">value of the input.</param>
				/// <param name="oParams">extra event parameters.</param>
				public extern virtual void fireChangeEvent(string sValue, object oParams);

				/// <summary>
				/// Fires the change event for the listeners
				/// </summary>
				/// <param name="sValue">value of the input.</param>
				public extern virtual void fireChangeEvent(string sValue);

				/// <returns>Current accessibility state of the control</returns>
				public extern virtual object getAccessibilityInfo();

				/// <summary>
				/// Gets the DOM element reference where the message popup is attached.
				/// </summary>
				/// <returns>The DOM element reference where the message popup is attached</returns>
				public extern virtual object getDomRefForValueStateMessage();

				/// <summary>
				/// Returns an object representing the serialized focus information. To be overwritten by subclasses.
				/// </summary>
				/// <returns>An object representing the serialized focus information.</returns>
				public extern override object getFocusInfo();

				/// <summary>
				/// Gets the labels referencing this control.
				/// </summary>
				/// <returns>Array of objects which are the current targets of the <code>ariaLabelledBy</code> association and the labels referencing this control.</returns>
				public extern virtual sap.m.Label[] getLabels();

				/// <summary>
				/// Returns a metadata object for class sap.m.InputBase.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Retrieves the selected text. Only supported for input control's type of Text, Url, Tel and Password.
				/// </summary>
				/// <returns>The selected text.</returns>
				public extern virtual string getSelectedText();

				/// <summary>
				/// Handles the change event.
				/// </summary>
				/// <param name="oEvent"></param>
				/// <param name="mParameters">Additional event parameters to be passed in to the change event handler if the value has changed</param>
				/// <param name="sNewValue">Passed value on change</param>
				/// <returns>true when change event is fired</returns>
				public extern virtual bool? onChange(object oEvent, object mParameters, string sNewValue);

				/// <summary>
				/// Hook method that gets called when the input value is reverted with hitting escape. It may require to re-implement this method from sub classes for control specific behaviour.
				/// </summary>
				/// <param name="sValue">Reverted value of the input.</param>
				public extern virtual void onValueRevertedByEscape(string sValue);

				/// <summary>
				/// Open value state message popup.
				/// </summary>
				public extern virtual void openValueStateMessage();

				/// <summary>
				/// Hook method to prevent the change event from being fired when the text input field loses focus.
				/// </summary>
				/// <param name="oEvent">The event object.</param>
				/// <returns>Whether or not the change event should be prevented.</returns>
				public extern virtual bool preventChangeOnFocusLeave(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Hook method to prevent the change event from being fired when the text input field loses focus.
				/// </summary>
				/// <returns>Whether or not the change event should be prevented.</returns>
				public extern virtual bool preventChangeOnFocusLeave();

				/// <summary>
				/// Selects the text within the input field between the specified start and end positions. Only supported for input control's type of Text, Url, Tel and Password.
				/// </summary>
				/// <param name="iSelectionStart">The index into the text at which the first selected character is located.</param>
				/// <param name="iSelectionEnd">The index into the text at which the last selected character is located.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.InputBase selectText(int iSelectionStart, int iSelectionEnd);

				/// <summary>
				/// Sets the DOM value of the input field and handles placeholder visibility.
				/// </summary>
				/// <param name="sValue">value of the input field.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.InputBase updateDomValue(string sValue);

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
