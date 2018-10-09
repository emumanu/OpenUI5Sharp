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
			/// Enables the users to select a localized date.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>DatePicker</code> lets the users select a localized date using touch, mouse, or keyboard input. It consists of two parts: the date input field and the date picker.
			/// 
			/// <b>Note:</b> The {@link sap.ui.unified.Calendar} is used internally only if the <code>DatePicker</code> is opened (not used for the initial rendering). If the <code>sap.ui.unified</code> library is not loaded before the <code>DatePicker</code> is opened, it will be loaded upon opening. This could lead to a waiting time when the <code>DatePicker</code> is opened for the first time. To prevent this, apps using the <code>DatePicker</code> should also load the <code>sap.ui.unified</code> library.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// The user can enter a date by: <ul><li>Using the calendar that opens in a popup</li> <li>Typing it in directly in the input field (not available for mobile devices)</li></ul>
			/// 
			/// On app level, there are two options to provide a date for the <code>DatePicker</code> - as a string to the <code>value</code> property or as a JavaScript Date object to the <code>dateValue</code> property (only one of these properties should be used at a time):
			/// 
			/// <ul><li>Use the <code>value</code> property if you want to bind the <code>DatePicker</code> to a model using the <code>sap.ui.model.type.Date</code></li> <li>Use the <code>value</code> property if the date is provided as a string from the backend or inside the app (for example, as ABAP type DATS field)</li> <li>Use the <code>dateValue</code> property if the date is already provided as a JavaScript Date object or you want to work with a JavaScript Date object</li></ul>
			/// 
			/// <h3>Formatting</h3>
			/// 
			/// All formatting and parsing of dates from and to strings is done using the {@link sap.ui.core.format.DateFormat}. If a date is entered by typing it into the input field, it must fit to the used date format and locale.
			/// 
			/// Supported format options are pattern-based on Unicode LDML Date Format notation. See {@link http://unicode.org/reports/tr35/#Date_Field_Symbol_Table}
			/// 
			/// For example, if the <code>valueFormat</code> is "yyyy-MM-dd", the <code>displayFormat</code> is "MMM d, y", and the used locale is English, a valid value string is "2015-07-30", which leads to an output of "Jul 30, 2015".
			/// 
			/// If no placeholder is set to the <code>DatePicker</code>, the used <code>displayFormat</code> is displayed as a placeholder. If another placeholder is needed, it must be set.
			/// 
			/// <b>Note:</b> If the string does NOT match the <code>displayFormat</code> (from user input) or the <code>valueFormat</code> (on app level), the {@link sap.ui.core.format.DateFormat} makes an attempt to parse it based on the locale settings. For more information, see the respective documentation in the API Reference.
			/// 
			/// <h3>Responsive behavior</h3>
			/// 
			/// The <code>DatePicker</code> is smaller in compact mode and provides a touch-friendly size in cozy mode.
			/// 
			/// On mobile devices, one tap on the input field opens the <code>DatePicker</code> in full screen. To close the window, the user can select a date (which triggers the close event), or select Cancel.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.DatePicker")]
			public partial class DatePicker : sap.m.DateTimeField
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
					/// Displays date in this given type in input field. Default value is taken from locale settings. Accepted are values of <code>sap.ui.core.CalendarType</code> or an empty string. If no type is set, the default type of the configuration is used. <b>Note:</b> If data binding on <code>value</code> property with type <code>sap.ui.model.type.Date</code> is used, this property will be ignored.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayFormatType;

					/// <summary>
					/// If set, the days in the calendar popup are also displayed in this calendar type If not set, the dates are only displayed in the primary calendar type
					/// </summary>
					public Union<sap.ui.core.CalendarType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> secondaryCalendarType;

					/// <summary>
					/// Minimum date that can be shown and selected in the <code>DatePicker</code>. This must be a JavaScript date object.
					/// 
					/// <b>Note:</b> If the <code>minDate</code> is set to be after the <code>maxDate</code>, the <code>maxDate</code> and the <code>minDate</code> are switched before rendering.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minDate;

					/// <summary>
					/// Maximum date that can be shown and selected in the <code>DatePicker</code>. This must be a JavaScript date object.
					/// 
					/// <b>Note:</b> If the <code>maxDate</code> is set to be before the <code>minDate</code>, the <code>maxDate</code> and the <code>minDate</code> are switched before rendering.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxDate;

					/// <summary>
					/// Date Range with type to visualize special days in the Calendar. If one day is assigned to more than one Type, only the first one will be used.
					/// 
					/// To set a single date (instead of a range), set only the startDate property of the sap.ui.unified.DateRange class.
					/// 
					/// <b>Note:</b> Since 1.48 you could set a non-working day via the sap.ui.unified.CalendarDayType.NonWorking enum type just as any other special date type using sap.ui.unified.DateRangeType.
					/// </summary>
					public Union<sap.ui.core.Element[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> specialDates;

					/// <summary>
					/// Association to the <code>CalendarLegend</code> explaining the colors of the <code>specialDates</code>.
					/// 
					/// <b>Note</b> The legend does not have to be rendered but must exist, and all required types must be assigned.
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> legend;

					/// <summary>
					/// Fired when navigating in <code>Calendar</code> popup.
					/// </summary>
					public sap.m.DatePicker.NavigateDelegate navigate;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class NavigateInfo
				{
					/// <summary>
					/// Date range containing the start and end date displayed in the <code>Calendar</code> popup.
					/// </summary>
					public sap.ui.unified.DateRange dateRange;

				}

				#endregion

				#region Delegates

				public delegate void NavigateDelegate(sap.ui.@base.Event<sap.m.DatePicker.NavigateInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>DatePicker</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DatePicker(string sId, sap.m.DatePicker.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>DatePicker</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				public extern DatePicker(string sId);

				/// <summary>
				/// Constructor for a new <code>DatePicker</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern DatePicker();

				/// <summary>
				/// Constructor for a new <code>DatePicker</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DatePicker(sap.m.DatePicker.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property displayFormatType

				/// <summary>
				/// Gets current value of property {@link #getDisplayFormatType displayFormatType}.
				/// 
				/// Displays date in this given type in input field. Default value is taken from locale settings. Accepted are values of <code>sap.ui.core.CalendarType</code> or an empty string. If no type is set, the default type of the configuration is used. <b>Note:</b> If data binding on <code>value</code> property with type <code>sap.ui.model.type.Date</code> is used, this property will be ignored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>displayFormatType</code></returns>
				public extern virtual string getDisplayFormatType();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayFormatType displayFormatType}.
				/// 
				/// Displays date in this given type in input field. Default value is taken from locale settings. Accepted are values of <code>sap.ui.core.CalendarType</code> or an empty string. If no type is set, the default type of the configuration is used. <b>Note:</b> If data binding on <code>value</code> property with type <code>sap.ui.model.type.Date</code> is used, this property will be ignored.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sDisplayFormatType">New value for property <code>displayFormatType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker setDisplayFormatType(string sDisplayFormatType);

				#endregion

				#region Methods for Property secondaryCalendarType

				/// <summary>
				/// Gets current value of property {@link #getSecondaryCalendarType secondaryCalendarType}.
				/// 
				/// If set, the days in the calendar popup are also displayed in this calendar type If not set, the dates are only displayed in the primary calendar type
				/// </summary>
				/// <returns>Value of property <code>secondaryCalendarType</code></returns>
				public extern virtual sap.ui.core.CalendarType getSecondaryCalendarType();

				/// <summary>
				/// Sets a new value for property {@link #getSecondaryCalendarType secondaryCalendarType}.
				/// 
				/// If set, the days in the calendar popup are also displayed in this calendar type If not set, the dates are only displayed in the primary calendar type
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sSecondaryCalendarType">New value for property <code>secondaryCalendarType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker setSecondaryCalendarType(sap.ui.core.CalendarType sSecondaryCalendarType);

				#endregion

				#region Methods for Property minDate

				/// <summary>
				/// Gets current value of property {@link #getMinDate minDate}.
				/// 
				/// Minimum date that can be shown and selected in the <code>DatePicker</code>. This must be a JavaScript date object.
				/// 
				/// <b>Note:</b> If the <code>minDate</code> is set to be after the <code>maxDate</code>, the <code>maxDate</code> and the <code>minDate</code> are switched before rendering.
				/// </summary>
				/// <returns>Value of property <code>minDate</code></returns>
				public extern virtual object getMinDate();

				/// <summary>
				/// Sets a new value for property {@link #getMinDate minDate}.
				/// 
				/// Minimum date that can be shown and selected in the <code>DatePicker</code>. This must be a JavaScript date object.
				/// 
				/// <b>Note:</b> If the <code>minDate</code> is set to be after the <code>maxDate</code>, the <code>maxDate</code> and the <code>minDate</code> are switched before rendering.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oMinDate">New value for property <code>minDate</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker setMinDate(object oMinDate);

				#endregion

				#region Methods for Property maxDate

				/// <summary>
				/// Gets current value of property {@link #getMaxDate maxDate}.
				/// 
				/// Maximum date that can be shown and selected in the <code>DatePicker</code>. This must be a JavaScript date object.
				/// 
				/// <b>Note:</b> If the <code>maxDate</code> is set to be before the <code>minDate</code>, the <code>maxDate</code> and the <code>minDate</code> are switched before rendering.
				/// </summary>
				/// <returns>Value of property <code>maxDate</code></returns>
				public extern virtual object getMaxDate();

				/// <summary>
				/// Sets a new value for property {@link #getMaxDate maxDate}.
				/// 
				/// Maximum date that can be shown and selected in the <code>DatePicker</code>. This must be a JavaScript date object.
				/// 
				/// <b>Note:</b> If the <code>maxDate</code> is set to be before the <code>minDate</code>, the <code>maxDate</code> and the <code>minDate</code> are switched before rendering.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oMaxDate">New value for property <code>maxDate</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker setMaxDate(object oMaxDate);

				#endregion

				#region Methods for Aggregation specialDates

				/// <summary>
				/// Gets content of aggregation {@link #getSpecialDates specialDates}.
				/// 
				/// Date Range with type to visualize special days in the Calendar. If one day is assigned to more than one Type, only the first one will be used.
				/// 
				/// To set a single date (instead of a range), set only the startDate property of the sap.ui.unified.DateRange class.
				/// 
				/// <b>Note:</b> Since 1.48 you could set a non-working day via the sap.ui.unified.CalendarDayType.NonWorking enum type just as any other special date type using sap.ui.unified.DateRangeType.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Element[] getSpecialDates();

				/// <summary>
				/// Destroys all the specialDates in the aggregation {@link #getSpecialDates specialDates}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker destroySpecialDates();

				/// <summary>
				/// Inserts a <code>specialDate</code> to the aggregation <code>specialDates</code>.
				/// </summary>
				/// <param name="oSpecialDate">the specialDate to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">the 0-based index the <code>specialDate</code> should be inserted at; for a negative value of <code>iIndex</code>, the <code>specialDate</code> is inserted at position 0; for a value greater than the current size of the aggregation, the <code>specialDate</code> is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker insertSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate, int iIndex);

				/// <summary>
				/// Adds some <code>specialDate</code> to the aggregation <code>specialDates</code>.
				/// </summary>
				/// <param name="oSpecialDate">the specialDate to add; if empty, nothing is added</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker addSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate);

				/// <summary>
				/// Removes a <code>specialDate</code> from the aggregation <code>specialDates</code>.
				/// </summary>
				/// <param name="oSpecialDate">The <code>specialDate</code> to remove or its index or id</param>
				/// <returns>The removed <code>specialDate</code> or null</returns>
				public extern virtual sap.ui.unified.DateTypeRange removeSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Element</code> in the aggregation {@link #getSpecialDates specialDates}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oSpecialDate">The specialDate whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfSpecialDate(sap.ui.core.Element oSpecialDate);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getSpecialDates specialDates}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Element[] removeAllSpecialDates();

				#endregion

				#region Methods for Association legend

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getLegend legend}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getLegend();

				/// <summary>
				/// Sets the associated legend.
				/// </summary>
				/// <param name="oLegend">ID of an element which becomes the new target of this <code>legend</code> association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker setLegend(Union<sap.ui.core.ID, sap.ui.unified.CalendarLegend> oLegend);

				#endregion

				#region Methods for Event navigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.DatePicker</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.DatePicker</code> itself.
				/// 
				/// Fired when navigating in <code>Calendar</code> popup.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.DatePicker</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker attachNavigate(object oData, sap.m.DatePicker.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.DatePicker</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.DatePicker</code> itself.
				/// 
				/// Fired when navigating in <code>Calendar</code> popup.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker attachNavigate(object oData, sap.m.DatePicker.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.DatePicker</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.DatePicker</code> itself.
				/// 
				/// Fired when navigating in <code>Calendar</code> popup.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker attachNavigate(sap.m.DatePicker.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.DatePicker</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.DatePicker</code> itself.
				/// 
				/// Fired when navigating in <code>Calendar</code> popup.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.DatePicker</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker attachNavigate(sap.m.DatePicker.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:navigate navigate} event of this <code>sap.m.DatePicker</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker detachNavigate(sap.m.DatePicker.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:navigate navigate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker fireNavigate(sap.m.DatePicker.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:navigate navigate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DatePicker fireNavigate();

				#endregion

				#region Methods for event change

				/// <summary>
				/// Fire event change to attached listeners.
				/// 
				/// Expects following event parameters: <ul> <li>'value' of type <code>string</code> The new value of the <code>sap.m.DatePicker</code>.</li> <li>'valid' of type <code>boolean</code> Indicator for a valid date.</li> </ul>
				/// </summary>
				/// <param name="mArguments">the arguments to pass along with the event.</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.DatePicker fireChange(Map mArguments);

				/// <summary>
				/// Fire event change to attached listeners.
				/// 
				/// Expects following event parameters: <ul> <li>'value' of type <code>string</code> The new value of the <code>sap.m.DatePicker</code>.</li> <li>'valid' of type <code>boolean</code> Indicator for a valid date.</li> </ul>
				/// </summary>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.DatePicker fireChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.DatePicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.DateTimeField.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.DatePicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.DateTimeField.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.DatePicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.DateTimeField.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <returns>Current accessibility state of the control.</returns>
				public extern override object getAccessibilityInfo();

				/// <summary>
				/// The date as JavaScript Date object. This is independent from any formatter.
				/// 
				/// <b>Note:</b> If this property is used, the <code>value</code> property should not be changed from the caller.
				/// </summary>
				/// <returns>the value of property <code>dateValue</code></returns>
				public extern override object getDateValue();

				/// <summary>
				/// The date is displayed in the input field using this format. By default, the medium format of the used locale is used.
				/// 
				/// Supported format options are pattern-based on Unicode LDML Date Format notation. {@link http://unicode.org/reports/tr35/#Date_Field_Symbol_Table} <b>Note:</b> If you use data binding on the <code>value</code> property with type <code>sap.ui.model.type.Date</code> this property will be ignored. The format defined in the binding will be used.
				/// </summary>
				/// <returns>the value of property <code>displayFormat</code></returns>
				public extern override string getDisplayFormat();

				/// <summary>
				/// Returns a metadata object for class sap.m.DatePicker.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Getter for property <code>value</code>.
				/// 
				/// Returns a date as a string in the format defined in property <code>valueFormat</code>.
				/// 
				/// <b>Note:</b> The value is always expected and updated in Gregorian calendar format. (If data binding is used the format of the binding is used.)
				/// 
				/// If this property is used, the <code>dateValue</code> property should not be changed from the caller.
				/// </summary>
				/// <returns>the value of property <code>value</code></returns>
				public extern override string getValue();

				/// <summary>
				/// The date string expected and returned in the <code>value</code> property uses this format. By default the short format of the used locale is used.
				/// 
				/// Supported format options are pattern-based on Unicode LDML Date Format notation. {@link http://unicode.org/reports/tr35/#Date_Field_Symbol_Table}
				/// 
				/// For example, if the date string represents an ABAP DATS type, the format should be "yyyyMMdd".
				/// 
				/// <b>Note:</b> If data binding on <code>value</code> property with type <code>sap.ui.model.type.Date</code> is used, this property will be ignored. The format defined in the binding will be used.
				/// </summary>
				/// <returns>the value of property <code>valueFormat</code></returns>
				public extern override string getValueFormat();

				/// <summary>
				/// Setter for property <code>value</code>.
				/// 
				/// Expects a date as a string in the format defined in property <code>valueFormat</code>.
				/// 
				/// <b>Note:</b> The value is always expected and updated in Gregorian calendar format. (If data binding is used the format of the binding is used.)
				/// 
				/// If this property is used, the <code>dateValue</code> property should not be changed from the caller.
				/// 
				/// If Data binding using a <code>sap.ui.model.type.Date</code> is used, please set the <code>formatOption</code> <code>stricktParsing</code> to <code>true</code>. This prevents unwanted automatic corrections of wrong input.
				/// </summary>
				/// <param name="sValue">The new value of the input.</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.DatePicker setValue(string sValue);

				/// <summary>
				/// Defines the width of the DatePicker. Default value is 100%
				/// </summary>
				/// <param name="sWidth">new value for <code>width</code></param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.DatePicker setWidth(string sWidth);

				#endregion

				#endregion

			}
		}
	}
}
