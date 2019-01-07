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
			/// A picker list container control used inside the {@link sap.m.TimePicker} or standalone to hold all the sliders.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.TimePickerSliders")]
			public partial class TimePickerSliders : sap.ui.core.Control
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
					/// Defines the locale used to parse string values representing time.
					/// 
					/// Determines the locale, used to interpret the string, supplied by the <code>value</code> property.
					/// 
					/// Example: AM in the string "09:04 AM" is locale (language) dependent. The format comes from the browser language settings if not set explicitly. Used in combination with 12 hour <code>displayFormat</code> containing 'a', which stands for day period string.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> localeId;

					/// <summary>
					/// Defines the time <code>displayFormat</code> of the sliders. The <code>displayFormat</code> comes from the browser language settings if not set explicitly.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayFormat;

					/// <summary>
					/// Defines the text of the picker label.
					/// 
					/// It is read by screen readers. It is visible only on phone.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> labelText;

					/// <summary>
					/// Sets the minutes slider step. If step is less than 1, it will be automatically converted back to 1. The minutes slider is populated only by multiples of the step.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minutesStep;

					/// <summary>
					/// Sets the seconds slider step. If step is less than 1, it will be automatically converted back to 1. The seconds slider is populated only by multiples of the step.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> secondsStep;

					/// <summary>
					/// Sets the width of the container. The minimum width is 320px.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Sets the height of the container. If percentage value is used the parent container should have specified height
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// Defines the value of the control.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

					/// <summary>
					/// Determines the format of the <code>value</code> property.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueFormat;

					/// <summary>
					/// Allows to set a value of 24:00, used to indicate the end of the day. Works only with HH or H formats. Don't use it together with am/pm.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> support2400;

					/// <summary>
					/// Fired when the value is changed.
					/// </summary>
					public sap.m.ValueDelegate change;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>TimePickerSliders</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TimePickerSliders(string sId, sap.m.TimePickerSliders.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>TimePickerSliders</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern TimePickerSliders(string sId);

				/// <summary>
				/// Constructor for a new <code>TimePickerSliders</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern TimePickerSliders();

				/// <summary>
				/// Constructor for a new <code>TimePickerSliders</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TimePickerSliders(sap.m.TimePickerSliders.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property localeId

				/// <summary>
				/// Gets current value of property {@link #getLocaleId localeId}.
				/// 
				/// Defines the locale used to parse string values representing time.
				/// 
				/// Determines the locale, used to interpret the string, supplied by the <code>value</code> property.
				/// 
				/// Example: AM in the string "09:04 AM" is locale (language) dependent. The format comes from the browser language settings if not set explicitly. Used in combination with 12 hour <code>displayFormat</code> containing 'a', which stands for day period string.
				/// </summary>
				/// <returns>Value of property <code>localeId</code></returns>
				public extern virtual string getLocaleId();

				/// <summary>
				/// Sets the <code>localeId</code> property.
				/// </summary>
				/// <param name="sLocaleId">The ID of the Locale</param>
				/// <returns>this instance, used for chaining</returns>
				public extern virtual sap.m.TimePickerSliders setLocaleId(string sLocaleId);

				#endregion

				#region Methods for Property displayFormat

				/// <summary>
				/// Gets current value of property {@link #getDisplayFormat displayFormat}.
				/// 
				/// Defines the time <code>displayFormat</code> of the sliders. The <code>displayFormat</code> comes from the browser language settings if not set explicitly.
				/// </summary>
				/// <returns>Value of property <code>displayFormat</code></returns>
				public extern virtual string getDisplayFormat();

				/// <summary>
				/// Sets the time <code>displayFormat</code>.
				/// </summary>
				/// <param name="sFormat">New display format</param>
				/// <returns>this instance, used for chaining</returns>
				public extern virtual sap.m.TimePickerSliders setDisplayFormat(string sFormat);

				#endregion

				#region Methods for Property labelText

				/// <summary>
				/// Gets current value of property {@link #getLabelText labelText}.
				/// 
				/// Defines the text of the picker label.
				/// 
				/// It is read by screen readers. It is visible only on phone.
				/// </summary>
				/// <returns>Value of property <code>labelText</code></returns>
				public extern virtual string getLabelText();

				/// <summary>
				/// Sets the text for the picker label.
				/// </summary>
				/// <param name="sLabelText">A text for the label</param>
				/// <returns>this instance, used for chaining</returns>
				public extern virtual sap.m.TimePickerSliders setLabelText(string sLabelText);

				#endregion

				#region Methods for Property minutesStep

				/// <summary>
				/// Gets current value of property {@link #getMinutesStep minutesStep}.
				/// 
				/// Sets the minutes slider step. If step is less than 1, it will be automatically converted back to 1. The minutes slider is populated only by multiples of the step.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>minutesStep</code></returns>
				public extern virtual int getMinutesStep();

				/// <summary>
				/// Sets the minutes slider step.
				/// </summary>
				/// <param name="value">The step used to generate values for the minutes slider</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders setMinutesStep(int value);

				#endregion

				#region Methods for Property secondsStep

				/// <summary>
				/// Gets current value of property {@link #getSecondsStep secondsStep}.
				/// 
				/// Sets the seconds slider step. If step is less than 1, it will be automatically converted back to 1. The seconds slider is populated only by multiples of the step.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>secondsStep</code></returns>
				public extern virtual int getSecondsStep();

				/// <summary>
				/// Sets the seconds slider step.
				/// </summary>
				/// <param name="value">The step used to generate values for the seconds slider</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders setSecondsStep(int value);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Sets the width of the container. The minimum width is 320px.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets the width of the <code>TimepickerSliders</code> container.
				/// </summary>
				/// <param name="sWidth">The width of the <code>TimepickerSliders</code< as CSS size</param>
				/// <returns>Pointer to the control instance to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// Sets the height of the container. If percentage value is used the parent container should have specified height
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets the height of the <code>TimepickerSliders</code> container.
				/// </summary>
				/// <param name="sHeight">The height of the <code>TimepickerSliders</code> as CSS size</param>
				/// <returns>Pointer to the control instance to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property value

				/// <summary>
				/// Gets current value of property {@link #getValue value}.
				/// 
				/// Defines the value of the control.
				/// </summary>
				/// <returns>Value of property <code>value</code></returns>
				public extern virtual string getValue();

				/// <summary>
				/// Sets the value of the <code>TimepickerSliders</code> container.
				/// </summary>
				/// <param name="sValue">The value of the <code>TimepickerSliders</code></param>
				/// <returns>Pointer to the control instance to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders setValue(string sValue);

				#endregion

				#region Methods for Property valueFormat

				/// <summary>
				/// Gets current value of property {@link #getValueFormat valueFormat}.
				/// 
				/// Determines the format of the <code>value</code> property.
				/// </summary>
				/// <returns>Value of property <code>valueFormat</code></returns>
				public extern virtual string getValueFormat();

				/// <summary>
				/// Sets a new value for property {@link #getValueFormat valueFormat}.
				/// 
				/// Determines the format of the <code>value</code> property.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValueFormat">New value for property <code>valueFormat</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders setValueFormat(string sValueFormat);

				#endregion

				#region Methods for Property support2400

				/// <summary>
				/// Gets current value of property {@link #getSupport2400 support2400}.
				/// 
				/// Allows to set a value of 24:00, used to indicate the end of the day. Works only with HH or H formats. Don't use it together with am/pm.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>support2400</code></returns>
				public extern virtual bool getSupport2400();

				/// <summary>
				/// Sets <code>support2400</code>.
				/// </summary>
				/// <param name="bSupport2400"></param>
				/// <returns>this instance, used for chaining</returns>
				public extern virtual sap.m.TimePickerSliders setSupport2400(bool bSupport2400);

				#endregion

				#region Methods for Aggregation _columns

				#endregion

				#region Methods for Event change

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.TimePickerSliders</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TimePickerSliders</code> itself.
				/// 
				/// Fired when the value is changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TimePickerSliders</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders attachChange(object oData, sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.TimePickerSliders</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TimePickerSliders</code> itself.
				/// 
				/// Fired when the value is changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders attachChange(object oData, sap.m.ValueDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.TimePickerSliders</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TimePickerSliders</code> itself.
				/// 
				/// Fired when the value is changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders attachChange(sap.m.ValueDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.TimePickerSliders</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TimePickerSliders</code> itself.
				/// 
				/// Fired when the value is changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TimePickerSliders</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders attachChange(sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.m.TimePickerSliders</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders detachChange(sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders fireChange(sap.m.ValueInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders fireChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Collapses all the slider controls.
				/// </summary>
				/// <returns>Pointer to the control instance to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders collapseAll();

				/// <summary>
				/// Creates a new subclass of class sap.m.TimePickerSliders with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TimePickerSliders with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TimePickerSliders with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.TimePickerSliders.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Gets the time values from the sliders, as a date object.
				/// </summary>
				/// <returns>A JavaScript date object</returns>
				public extern virtual object getTimeValues();

				/// <summary>
				/// Opens first slider.
				/// </summary>
				/// <returns>Pointer to the control instance to allow method chaining</returns>
				public extern virtual sap.m.TimePickerSliders openFirstSlider();

				#endregion

				#endregion

			}
		}
	}
}
