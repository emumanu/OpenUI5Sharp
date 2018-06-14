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
			/// A single-field input control that enables the users to fill time related input fields.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>TimePicker</code> control enables the users to fill time related input fields using touch, mouse, or keyboard input.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// Use this control if you want the user to select a time. If you want the user to select a duration (1 hour), use the {@link sap.m.Select} control instead.
			/// 
			/// The user can enter a date by:
			/// 
			/// <ul><li>Using the <code>TimePicker</code> dropdown that opens in a popup</li> <li>Typing it in directly in the input field</li></ul>
			/// 
			/// On app level, there are two options to provide value for the <code>TimePicker</code> - as a string to the <code>value</code> property or as a JavaScript Date object to the <code>dateValue</code> property (only one of these properties should be used at a time):
			/// 
			/// <ul><li>Use the <code>value</code> property if you want to bind the <code>TimePicker</code> to a model using the <code>sap.ui.model.type.Time</code></li> <li>Use the <code>value</code> property if the date is provided as a string from the backend or inside the app (for example, as ABAP type DATS field)</li> <li>Use the <code>dateValue</code> property if the date is already provided as a JavaScript Date object or you want to work with a JavaScript Date object</li></ul>
			/// 
			/// <h3>Formatting</h3>
			/// 
			/// All formatting and parsing of values from and to strings is done using the {@link sap.ui.core.format.DateFormat}. If a value is entered by typing it into the input field, it must fit to the used time format and locale.
			/// 
			/// Supported format options are pattern-based on Unicode LDML Date Format notation. See {@link http://unicode.org/reports/tr35/#Date_Field_Symbol_Table}
			/// 
			/// A time format must be specified, otherwise the default "HH:mm:ss a" will be used. For example, if the <code>valueFormat</code> is "HH-mm-ss a", the <code>displayFormat</code> is "HH:mm:ss a", and the used locale is English, a valid value string is "10-30-15 AM", which leads to an output of "10:30:15 AM".
			/// 
			/// If no placeholder is set to the <code>TimePicker</code>, the used <code>displayFormat</code> is displayed as a placeholder. If another placeholder is needed, it must be set.
			/// 
			/// <b>Note:</b> If the string does NOT match the <code>displayFormat</code> (from user input) or the <code>valueFormat</code> (on app level), the {@link sap.ui.core.format.DateFormat} makes an attempt to parse it based on the locale settings. For more information, see the respective documentation in the API Reference.
			/// 
			/// <h3>Responsive behavior</h3>
			/// 
			/// The <code>TimePicker</code> is responsive and fully adapts to all device types. For larger screens, such as tablet or desktop, it opens as a popover. For mobile devices, it opens in full screen.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class TimePicker : sap.m.DateTimeField
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.DateTimeField.Settings
				{
					/// <summary>
					/// Defines the locale used to parse string values representing time.
					/// 
					/// Determines the locale, used to interpret the string, supplied by the <code>value</code> property.
					/// 
					/// Example: AM in the string "09:04 AM" is locale (language) dependent. The format comes from the browser language settings if not set explicitly. Used in combination with 12 hour <code>displayFormat</code> containing 'a', which stands for day period string.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> localeId;

					/// <summary>
					/// Displays the text of the general picker label and is read by screen readers. It is visible only on phone.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

					/// <summary>
					/// Sets the minutes slider step. If step is less than 1, it will be automatically converted back to 1. The minutes slider is populated only by multiples of the step.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> minutesStep;

					/// <summary>
					/// Sets the seconds slider step. If step is less than 1, it will be automatically converted back to 1. The seconds slider is populated only by multiples of the step.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> secondsStep;

					/// <summary>
					/// Defines a placeholder symbol. Shown at the position where there is no user input yet.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> placeholderSymbol;

					/// <summary>
					/// Mask defined by its characters type (respectively, by its length). You should consider the following important facts: 1. The mask characters normally correspond to an existing rule (one rule per unique char). Characters which don't, are considered immutable characters (for example, the mask '2099', where '9' corresponds to a rule for digits, has the characters '2' and '0' as immutable). 2. Adding a rule corresponding to the <code>placeholderSymbol</code> is not recommended and would lead to an unpredictable behavior. 3. You can use the special escape character '^' called "Caret" prepending a rule character to make it immutable. Use the double escape '^^' if you want to make use of the escape character as an immutable one.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> mask;

					/// <summary>
					/// Defines whether the mask is enabled. When disabled, there are no restrictions and validation for the user and no placeholders are displayed.
					/// 
					/// <b>Note:</b> A disabled mask does not reset any validation rules that are already set. You can update the <code>mask</code> property and add new <code>rules</code> while it is disabled. When <code>maskMode</code> is set to <code>On</code> again, the <code>rules</code> and the updated <code>mask</code> will be applied.
					/// </summary>
					public Union<sap.m.TimePickerMaskMode, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> maskMode;

					/// <summary>
					/// Allows to set a value of 24:00, used to indicate the end of the day. Works only with HH or H formats. Don't use it together with am/pm.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> support2400;

					/// <summary>
					/// A list of validation rules (one rule per mask character).
					/// </summary>
					public Union<sap.m.MaskInputRule[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> rules;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>TimePicker</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TimePicker(string sId, sap.m.TimePicker.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>TimePicker</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern TimePicker(string sId);

				/// <summary>
				/// Constructor for a new <code>TimePicker</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern TimePicker();

				/// <summary>
				/// Constructor for a new <code>TimePicker</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TimePicker(sap.m.TimePicker.Settings mSettings);

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
				/// Sets the locale of the control.
				/// 
				/// Used for parsing and formatting the time values in languages different than English. Necessary for translation and auto-complete of the day periods, such as AM and PM.
				/// </summary>
				/// <param name="sLocaleId">A locale identifier like 'en_US'</param>
				/// <returns>this instance, used for chaining</returns>
				public extern virtual sap.m.TimePicker setLocaleId(string sLocaleId);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Displays the text of the general picker label and is read by screen readers. It is visible only on phone.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Displays the text of the general picker label and is read by screen readers. It is visible only on phone.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePicker setTitle(string sTitle);

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
				/// <param name="step">The step used to generate values for the minutes slider</param>
				/// <returns>this</returns>
				public extern virtual object setMinutesStep(int step);

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
				/// <param name="step">The step used to generate values for the seconds slider</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.TimePicker setSecondsStep(int step);

				#endregion

				#region Methods for Property placeholderSymbol

				/// <summary>
				/// Gets current value of property {@link #getPlaceholderSymbol placeholderSymbol}.
				/// 
				/// Defines a placeholder symbol. Shown at the position where there is no user input yet.
				/// 
				/// Default value is <code>_</code>.
				/// </summary>
				/// <returns>Value of property <code>placeholderSymbol</code></returns>
				public extern virtual string getPlaceholderSymbol();

				/// <summary>
				/// Sets a new value for property {@link #getPlaceholderSymbol placeholderSymbol}.
				/// 
				/// Defines a placeholder symbol. Shown at the position where there is no user input yet.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>_</code>.
				/// </summary>
				/// <param name="sPlaceholderSymbol">New value for property <code>placeholderSymbol</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePicker setPlaceholderSymbol(string sPlaceholderSymbol);

				#endregion

				#region Methods for Property mask

				/// <summary>
				/// Gets current value of property {@link #getMask mask}.
				/// 
				/// Mask defined by its characters type (respectively, by its length). You should consider the following important facts: 1. The mask characters normally correspond to an existing rule (one rule per unique char). Characters which don't, are considered immutable characters (for example, the mask '2099', where '9' corresponds to a rule for digits, has the characters '2' and '0' as immutable). 2. Adding a rule corresponding to the <code>placeholderSymbol</code> is not recommended and would lead to an unpredictable behavior. 3. You can use the special escape character '^' called "Caret" prepending a rule character to make it immutable. Use the double escape '^^' if you want to make use of the escape character as an immutable one.
				/// </summary>
				/// <returns>Value of property <code>mask</code></returns>
				public extern virtual string getMask();

				/// <summary>
				/// Sets a new value for property {@link #getMask mask}.
				/// 
				/// Mask defined by its characters type (respectively, by its length). You should consider the following important facts: 1. The mask characters normally correspond to an existing rule (one rule per unique char). Characters which don't, are considered immutable characters (for example, the mask '2099', where '9' corresponds to a rule for digits, has the characters '2' and '0' as immutable). 2. Adding a rule corresponding to the <code>placeholderSymbol</code> is not recommended and would lead to an unpredictable behavior. 3. You can use the special escape character '^' called "Caret" prepending a rule character to make it immutable. Use the double escape '^^' if you want to make use of the escape character as an immutable one.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMask">New value for property <code>mask</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePicker setMask(string sMask);

				#endregion

				#region Methods for Property maskMode

				/// <summary>
				/// Gets current value of property {@link #getMaskMode maskMode}.
				/// 
				/// Defines whether the mask is enabled. When disabled, there are no restrictions and validation for the user and no placeholders are displayed.
				/// 
				/// <b>Note:</b> A disabled mask does not reset any validation rules that are already set. You can update the <code>mask</code> property and add new <code>rules</code> while it is disabled. When <code>maskMode</code> is set to <code>On</code> again, the <code>rules</code> and the updated <code>mask</code> will be applied.
				/// 
				/// Default value is <code>On</code>.
				/// </summary>
				/// <returns>Value of property <code>maskMode</code></returns>
				public extern virtual sap.m.TimePickerMaskMode getMaskMode();

				/// <summary>
				/// Sets a new value for property {@link #getMaskMode maskMode}.
				/// 
				/// Defines whether the mask is enabled. When disabled, there are no restrictions and validation for the user and no placeholders are displayed.
				/// 
				/// <b>Note:</b> A disabled mask does not reset any validation rules that are already set. You can update the <code>mask</code> property and add new <code>rules</code> while it is disabled. When <code>maskMode</code> is set to <code>On</code> again, the <code>rules</code> and the updated <code>mask</code> will be applied.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>On</code>.
				/// </summary>
				/// <param name="sMaskMode">New value for property <code>maskMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePicker setMaskMode(sap.m.TimePickerMaskMode sMaskMode);

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
				/// Sets <code>support2400</code> of the control.
				/// 
				/// Allows the control to use 24-hour format. Recommended usage is to not use it with am/pm format.
				/// </summary>
				/// <param name="bSupport2400"></param>
				/// <returns>this instance, used for chaining</returns>
				public extern virtual sap.m.TimePicker setSupport2400(bool bSupport2400);

				#endregion

				#region Methods for Aggregation rules

				/// <summary>
				/// Gets content of aggregation {@link #getRules rules}.
				/// 
				/// A list of validation rules (one rule per mask character).
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.MaskInputRule[] getRules();

				/// <summary>
				/// Destroys all the rules in the aggregation {@link #getRules rules}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePicker destroyRules();

				/// <summary>
				/// Inserts a rule into the aggregation {@link #getRules rules}.
				/// </summary>
				/// <param name="oRule">The rule to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the rule should be inserted at; for a negative value of <code>iIndex</code>, the rule is inserted at position 0; for a value greater than the current size of the aggregation, the rule is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePicker insertRule(sap.m.MaskInputRule oRule, int iIndex);

				/// <summary>
				/// Adds some rule to the aggregation {@link #getRules rules}.
				/// </summary>
				/// <param name="oRule">The rule to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TimePicker addRule(sap.m.MaskInputRule oRule);

				/// <summary>
				/// Removes a rule from the aggregation {@link #getRules rules}.
				/// </summary>
				/// <param name="vRule">The rule to remove or its index or id</param>
				/// <returns>The removed rule or <code>null</code></returns>
				public extern virtual sap.m.MaskInputRule removeRule(Union<int, string, sap.m.MaskInputRule> vRule);

				/// <summary>
				/// Checks for the provided <code>sap.m.MaskInputRule</code> in the aggregation {@link #getRules rules}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oRule">The rule whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfRule(sap.m.MaskInputRule oRule);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getRules rules}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.MaskInputRule[] removeAllRules();

				#endregion

				#region Methods for Aggregation _picker

				#endregion

				#region Methods for event change

				/// <summary>
				/// Fires change event to attached listeners.
				/// 
				/// Expects following event parameters: <ul> <li>value parameter of type <code>string</code> - the new value of the input</li> <li>valid parameter of type <code>boolean</code> - indicator for a valid time</li> </ul>
				/// </summary>
				/// <param name="mArguments">The arguments to pass along with the event</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.TimePicker fireChange(Map mArguments);

				/// <summary>
				/// Fires change event to attached listeners.
				/// 
				/// Expects following event parameters: <ul> <li>value parameter of type <code>string</code> - the new value of the input</li> <li>valid parameter of type <code>boolean</code> - indicator for a valid time</li> </ul>
				/// </summary>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.TimePicker fireChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.TimePicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.DateTimeField.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TimePicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.DateTimeField.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TimePicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.DateTimeField.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Fires the change event for the listeners
				/// </summary>
				/// <param name="sValue">value of the input.</param>
				/// <param name="oParams">extra event parameters.</param>
				public extern override void fireChangeEvent(string sValue, object oParams);

				/// <summary>
				/// Fires the change event for the listeners
				/// </summary>
				/// <param name="sValue">value of the input.</param>
				public extern override void fireChangeEvent(string sValue);

				/// <returns>Current accessibility state of the control.</returns>
				public extern override object getAccessibilityInfo();

				/// <summary>
				/// Holds a reference to a JavaScript Date Object. The <code>value</code> (string) property will be set according to it. Alternatively, if the <code>value</code> and <code>valueFormat</code> pair properties are supplied instead, the <code>dateValue</code> will be instantiated according to the parsed <code>value</code>.
				/// </summary>
				/// <returns>the value of property <code>dateValue</code></returns>
				public extern override object getDateValue();

				/// <summary>
				/// Determines the format, displayed in the input field and the picker sliders.
				/// 
				/// The default value is the browser's medium time format locale setting {@link sap.ui.core.LocaleData#getTimePattern}. If data binding with type {@link sap.ui.model.type.Time} or {@link sap.ui.model.odata.type.Time} is used for the <code>value</code> property, the <code>displayFormat</code> property is ignored as the information is provided from the binding itself.
				/// </summary>
				/// <returns>the value of property <code>displayFormat</code></returns>
				public extern override string getDisplayFormat();

				/// <summary>
				/// Returns a metadata object for class sap.m.TimePicker.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Determines the format of the value property.
				/// 
				/// The default value is the browser's medium time format locale setting {@link sap.ui.core.LocaleData#getTimePattern}. If data binding with type {@link sap.ui.model.type.Time} or {@link sap.ui.model.odata.type.Time} is used for the <code>value</code> property, the <code>valueFormat</code> property is ignored as the information is provided from the binding itself.
				/// </summary>
				/// <returns>the value of property <code>valueFormat</code></returns>
				public extern override string getValueFormat();

				/// <summary>
				/// Initializes the control.
				/// </summary>
				public extern override void init();

				/// <summary>
				/// Called after the picker closes.
				/// </summary>
				public extern virtual void onAfterClose();

				/// <summary>
				/// Called after the picker appears.
				/// </summary>
				public extern virtual void onAfterOpen();

				/// <summary>
				/// Called before the picker appears.
				/// </summary>
				public extern virtual void onBeforeOpen();

				/// <summary>
				/// Sets tooltip of the control.
				/// </summary>
				/// <param name="vTooltip"></param>
				/// <returns>A reference to <code>this</code> instance to allow method chaining.</returns>
				public extern virtual sap.m.TimePicker setTooltip(Union<string, sap.ui.core.TooltipBase> vTooltip);

				#endregion

				#endregion

			}
		}
	}
}
