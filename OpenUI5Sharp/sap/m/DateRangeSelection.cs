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
			/// A single-field input control that enables the users to enter a localized date range.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>DateRangeSelection</code> enables the users to enter a localized date range using touch, mouse, keyboard input, or by selecting a date range in the calendar. They can also navigate directly from one month or year to another.
			/// 
			/// <b>Note:</b> The {@link sap.ui.unified.Calendar} is used internally only if the <code>DateRangeSelection</code> is opened (not used for the initial rendering). If the <code>sap.ui.unified</code> library is not loaded before the <code>DateRangeSelection</code> is opened, it will be loaded upon opening. This could lead to a waiting time when the <code>DateRangeSelection</code> is opened for the first time. To prevent this, apps using the <code>DateRangeSelection</code> should also load the <code>sap.ui.unified</code> library.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// <i>When to use?</i>
			/// 
			/// If you need a time range and know that your user is a power user who has to input lots of data. If the keyboard is the primary device used for navigating the app, use two input fields. This allows the user to quickly jump from field to field. By selecting a date in one of the fields, the other field should recognize the information and jump to the same selection.
			/// 
			/// <i>When not to use?</i>
			/// 
			/// If the user's primary goal is not to select ranges or if you just want to enter a date and a time. For such cases, use the {@link sap.m.DatePicker} or {@link sap.m.TimePicker}.
			/// 
			/// The user can enter a date by: <ul><li>Using the calendar that opens in a popup</li> <li>Typing it in directly in the input field (not available for mobile devices)</li></ul>
			/// 
			/// On app level, there are two options to provide a date for the <code>DateRangeSelection</code> - date range as a string to the <code>value</code> property or JavaScript Date objects to the <code>dateValue</code> and <code>secondDateValue</code> properties (only one of these options should be used at a time):
			/// 
			/// <ul><li>Use the <code>value</code> property if the date range is already provided as a formatted string</li> <li>Use the <code>dateValue</code> and <code>secondDateValue</code> properties if the date range is already provided as JavaScript Date objects or you want to work with JavaScript Date objects</li></ul>
			/// 
			/// <h3>Formatting</h3>
			/// 
			/// All formatting and parsing of dates from and to strings is done using the {@link sap.ui.core.format.DateFormat}. If a date is entered by typing it into the input field, it must fit to the used date format and locale.
			/// 
			/// Supported format options are pattern-based on Unicode LDML Date Format notation. See {@link http://unicode.org/reports/tr35/#Date_Field_Symbol_Table}
			/// 
			/// For example, if the <code>displayFormat</code> is "MMM d, y", delimiter is "-", and the used locale is English, a valid value string is "Jul 29, 2015 - Jul 31, 2015" and it is displayed in the same way in the input field.
			/// 
			/// If no placeholder is set to the <code>DateRangeSelection</code>, the used <code>displayFormat</code> is displayed as a placeholder. If another placeholder is needed, it must be set.
			/// 
			/// <b>Note:</b> If the string does NOT match the <code>displayFormat</code> (from user input) or the <code>valueFormat</code> (on app level), the {@link sap.ui.core.format.DateFormat} makes an attempt to parse it based on the locale settings. For more information, see the respective documentation in the API Reference.
			/// 
			/// <h3>Responsive behavior</h3>
			/// 
			/// The <code>DateRangeSelection</code> is fully responsive. It is smaller in compact mode and provides a touch-friendly size in cozy mode.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class DateRangeSelection : sap.m.DatePicker
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.DatePicker.Settings
				{
					/// <summary>
					/// Delimiter between start and end date. Default value is "-". If no delimiter is given, the one defined for the used locale is used.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> delimiter;

					/// <summary>
					/// The end date of the range as JavaScript Date object. This is independent from any formatter.
					/// 
					/// <b>Note:</b> If this property is used, the <code>value</code> property should not be changed from the caller.
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> secondDateValue;

					/// <summary>
					/// Start date of the range.
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> from;

					/// <summary>
					/// End date of the range.
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> to;

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
					/// The new value of the <code>sap.m.DateRangeSelection</code>.
					/// </summary>
					public string value;

					/// <summary>
					/// Indicator for a valid date.
					/// </summary>
					public bool valid;

					/// <summary>
					/// Current start date after change.
					/// </summary>
					public object from;

					/// <summary>
					/// Current end date after change.
					/// </summary>
					public object to;

				}

				#endregion

				#region Delegates

				public delegate void ChangeDelegate(sap.ui.@base.Event<sap.m.DateRangeSelection.ChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>DateRangeSelection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DateRangeSelection(string sId, sap.m.DateRangeSelection.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>DateRangeSelection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern DateRangeSelection(string sId);

				/// <summary>
				/// Constructor for a new <code>DateRangeSelection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern DateRangeSelection();

				/// <summary>
				/// Constructor for a new <code>DateRangeSelection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DateRangeSelection(sap.m.DateRangeSelection.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property delimiter

				/// <summary>
				/// Gets current value of property {@link #getDelimiter delimiter}.
				/// 
				/// Delimiter between start and end date. Default value is "-". If no delimiter is given, the one defined for the used locale is used.
				/// 
				/// Default value is <code>-</code>.
				/// </summary>
				/// <returns>Value of property <code>delimiter</code></returns>
				public extern virtual string getDelimiter();

				/// <summary>
				/// Sets a new value for property {@link #getDelimiter delimiter}.
				/// 
				/// Delimiter between start and end date. Default value is "-". If no delimiter is given, the one defined for the used locale is used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>-</code>.
				/// </summary>
				/// <param name="sDelimiter">New value for property <code>delimiter</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateRangeSelection setDelimiter(string sDelimiter);

				#endregion

				#region Methods for Property secondDateValue

				/// <summary>
				/// Gets current value of property {@link #getSecondDateValue secondDateValue}.
				/// 
				/// The end date of the range as JavaScript Date object. This is independent from any formatter.
				/// 
				/// <b>Note:</b> If this property is used, the <code>value</code> property should not be changed from the caller.
				/// </summary>
				/// <returns>Value of property <code>secondDateValue</code></returns>
				public extern virtual object getSecondDateValue();

				/// <summary>
				/// Sets a new value for property {@link #getSecondDateValue secondDateValue}.
				/// 
				/// The end date of the range as JavaScript Date object. This is independent from any formatter.
				/// 
				/// <b>Note:</b> If this property is used, the <code>value</code> property should not be changed from the caller.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oSecondDateValue">New value for property <code>secondDateValue</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateRangeSelection setSecondDateValue(object oSecondDateValue);

				#endregion

				#region Methods for Property from

				/// <summary>
				/// Gets current value of property {@link #getFrom from}.
				/// 
				/// Start date of the range.
				/// </summary>
				[Obsolete("Deprecated since 1.22.0. replaced by <code>dateValue</code> property of the {@link sap.m.DateTimeField}")]
				/// <returns>Value of property <code>from</code></returns>
				public extern virtual object getFrom();

				/// <summary>
				/// Sets a new value for property {@link #getFrom from}.
				/// 
				/// Start date of the range.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				[Obsolete("Deprecated since 1.22.0. replaced by <code>dateValue</code> property of the {@link sap.m.DateTimeField}")]
				/// <param name="oFrom">New value for property <code>from</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateRangeSelection setFrom(object oFrom);

				#endregion

				#region Methods for Property to

				/// <summary>
				/// Gets current value of property {@link #getTo to}.
				/// 
				/// End date of the range.
				/// </summary>
				[Obsolete("Deprecated since 1.22.0. replaced by <code>secondDateValue</code> property")]
				/// <returns>Value of property <code>to</code></returns>
				public extern virtual object getTo();

				/// <summary>
				/// Sets a new value for property {@link #getTo to}.
				/// 
				/// End date of the range.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				[Obsolete("Deprecated since 1.22.0. replaced by <code>secondDateValue</code> property")]
				/// <param name="oTo">New value for property <code>to</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateRangeSelection setTo(object oTo);

				#endregion

				#region Methods for event change

				/// <summary>
				/// Fire event change to attached listeners.
				/// 
				/// Expects following event parameters: <ul> <li>'value' of type <code>string</code> The new value of the <code>sap.m.DateRangeSelection</code>.</li> <li>'valid' of type <code>boolean</code> Indicator for a valid date.</li> <li>'from' of type <code>object</code> Current start date after change.</li> <li>'to' of type <code>object</code> Current end date after change.</li> </ul>
				/// </summary>
				/// <param name="mArguments">The arguments to pass along with the event.</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.DateRangeSelection fireChange(Map mArguments);

				/// <summary>
				/// Fire event change to attached listeners.
				/// 
				/// Expects following event parameters: <ul> <li>'value' of type <code>string</code> The new value of the <code>sap.m.DateRangeSelection</code>.</li> <li>'valid' of type <code>boolean</code> Indicator for a valid date.</li> <li>'from' of type <code>object</code> Current start date after change.</li> <li>'to' of type <code>object</code> Current end date after change.</li> </ul>
				/// </summary>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.DateRangeSelection fireChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.DateRangeSelection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.DatePicker.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.DateRangeSelection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.DatePicker.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.DateRangeSelection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.DatePicker.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <returns>Current accessibility state of the control</returns>
				public extern override object getAccessibilityInfo();

				/// <summary>
				/// Getter for property <code>dateValue</code>.
				/// 
				/// The start date of the range as JavaScript Date object. This is independent from any formatter.
				/// 
				/// <b>Note:</b> If this property is used, the <code>value</code> property should not be changed from the caller.
				/// </summary>
				/// <returns>the value of property <code>dateValue</code></returns>
				public extern override object getDateValue();

				/// <summary>
				/// Returns a metadata object for class sap.m.DateRangeSelection.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Getter for property <code>value</code>.
				/// 
				/// Returns a date as a string in the format defined in property <code>displayFormat</code>.
				/// 
				/// <b>Note:</b> As the value string always used the <code>displayFormat</code>, it is both locale-dependent and calendar-type-dependent.
				/// 
				/// If this property is used, the <code>dateValue</code> property should not be changed from the caller.
				/// </summary>
				/// <returns>the value of property <code>value</code></returns>
				public extern override string getValue();

				/// <summary>
				/// Getter for property <code>valueFormat</code>.
				/// 
				/// <b>Note:</b> Property <code>valueFormat</code> is not supported in the <code>sap.m.DateRangeSelection</code> control.
				/// </summary>
				/// <returns>the value of property valueFormat</returns>
				public extern override string getValueFormat();

				/// <summary>
				/// Setter for property <code>dateValue</code>.
				/// 
				/// The start date of the range as JavaScript Date object. This is independent from any formatter.
				/// 
				/// <b>Note:</b> If this property is used, the <code>value</code> property should not be changed from the caller.
				/// </summary>
				/// <param name="oDateValue">New value for property <code>dateValue</code></param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.DateRangeSelection setDateValue(object oDateValue);

				/// <summary>
				/// Setter for property <code>value</code>.
				/// 
				/// Expects a date as a string in the format defined in property <code>displayFormat</code>.
				/// 
				/// <b>Note:</b> As the value string always used the <code>displayFormat</code>, it is both locale-dependent and calendar-type-dependent.
				/// 
				/// If this property is used, the <code>dateValue</code> property should not be changed from the caller.
				/// </summary>
				/// <param name="sValue">The new value of the input.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.DateRangeSelection setValue(string sValue);

				/// <summary>
				/// Setter for property <code>valueFormat</code>.
				/// 
				/// <b>Note:</b> Property <code>valueFormat</code> is not supported in the <code>sap.m.DateRangeSelection</code> control.
				/// </summary>
				/// <param name="sValueFormat">New value for property valueFormat</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.DateRangeSelection setValueFormat(string sValueFormat);

				#endregion

				#endregion

			}
		}
	}
}
