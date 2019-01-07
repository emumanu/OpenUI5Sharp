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
			public static partial class unified
			{
				/// <summary>
				/// Basic Calendar. This calendar is used for DatePickers
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.Calendar")]
				public partial class Calendar : sap.ui.core.Control
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
						/// If set, interval selection is allowed
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> intervalSelection;

						/// <summary>
						/// If set, only a single date or interval, if intervalSelection is enabled, can be selected
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> singleSelection;

						/// <summary>
						/// Determines the number of months displayed.
						/// 
						/// As of version 1.50, the duplicated dates are not displayed if there are multiple months.
						/// 
						/// <b>Note:</b> On phones, only one month is displayed.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> months;

						/// <summary>
						/// If set, the first day of the displayed week is this day. Valid values are 0 to 6. If not a valid value is set, the default of the used locale is used.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> firstDayOfWeek;

						/// <summary>
						/// If set, the provided weekdays are displayed as non-working days. Valid values inside the array are 0 to 6. If not set, the weekend defined in the locale settings is displayed as non-working days.
						/// 
						/// <b>Note:</b> Keep in mind that this property sets only weekly-recurring days as non-working. If you need specific dates or dates ranges, such as national holidays, use the <code>specialDates</code> aggregation to set them. Both the non-working days (from property) and dates (from aggregation) are visualized the same.
						/// </summary>
						public Union<int[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> nonWorkingDays;

						/// <summary>
						/// If set, the calendar type is used for display. If not set, the calendar type of the global configuration is used.
						/// </summary>
						public Union<sap.ui.core.CalendarType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> primaryCalendarType;

						/// <summary>
						/// If set, the days are also displayed in this calendar type If not set, the dates are only displayed in the primary calendar type
						/// </summary>
						public Union<sap.ui.core.CalendarType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> secondaryCalendarType;

						/// <summary>
						/// Width of Calendar
						/// 
						/// <b>Note:</b> There is a theme depending minimum width, so the calendar can not be set smaller.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Minimum date that can be shown and selected in the Calendar. This must be a JavaScript date object.
						/// 
						/// <b>Note:</b> if the date is inside of a month the complete month is displayed, but dates outside the valid range can not be selected.
						/// 
						/// <b>Note:</b> If the <code>minDate</code> is set to be after the <code>maxDate</code>, the <code>maxDate</code> is set to the end of the month of the <code>minDate</code>.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minDate;

						/// <summary>
						/// Maximum date that can be shown and selected in the Calendar. This must be a JavaScript date object.
						/// 
						/// <b>Note:</b> if the date is inside of a month the complete month is displayed, but dates outside the valid range can not be selected.
						/// 
						/// <b>Note:</b> If the <code>maxDate</code> is set to be before the <code>minDate</code>, the <code>minDate</code> is set to the begin of the month of the <code>maxDate</code>.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxDate;

						/// <summary>
						/// Determines whether the week numbers in the months are displayed.
						/// 
						/// <b>Note:</b> For Islamic calendars, the week numbers are not displayed regardless of what is set to this property.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showWeekNumbers;

						/// <summary>
						/// Dates or date ranges for selected dates.
						/// 
						/// To set a single date (instead of a range), set only the <code>startDate</code> property of the {@link sap.ui.unified.DateRange} class.
						/// </summary>
						public Union<sap.ui.unified.DateRange[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> selectedDates;

						/// <summary>
						/// Dates or date ranges with type, to visualize special days in the <code>Calendar</code>. If one day is assigned to more than one Type, only the first one will be used.
						/// 
						/// To set a single date (instead of a range), set only the <code>startDate</code> property of the {@link sap.ui.unified.DateRange} class.
						/// 
						/// <b>Note:</b> Keep in mind that the <code>NonWorking</code> type is for marking specific dates or date ranges as non-working, where if you need a weekly-reccuring non-working days (weekend), you should use the <code>nonWorkingDays</code> property. Both the non-working days (from property) and dates (from aggregation) are visualized the same.
						/// </summary>
						public Union<sap.ui.unified.DateTypeRange[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> specialDates;

						/// <summary>
						/// Dates or date ranges for disabled dates.
						/// 
						/// To set a single date (instead of a range), set only the <code>startDate</code> property of the {@link sap.ui.unified.DateRange} class.
						/// </summary>
						public Union<sap.ui.unified.DateRange[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> disabledDates;

						/// <summary>
						/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Association to the <code>CalendarLegend</code> explaining the colors of the <code>specialDates</code>.
						/// 
						/// <b>Note</b> The legend does not have to be rendered but must exist, and all required types must be assigned.
						/// </summary>
						public Union<sap.ui.unified.CalendarLegend, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> legend;

						/// <summary>
						/// Date selection changed
						/// </summary>
						public sap.ui.@base.EventDelegate select;

						/// <summary>
						/// Date selection was cancelled
						/// </summary>
						public sap.ui.@base.EventDelegate cancel;

						/// <summary>
						/// <code>startDate</code> was changed while navigation in <code>Calendar</code>
						/// 
						/// Use <code>getStartDate</code> function to determine the current start date
						/// </summary>
						public sap.ui.@base.EventDelegate startDateChange;

						/// <summary>
						/// Week number selection changed. By default, clicking on the week number will select the corresponding week. If the week has already been selected, clicking the week number will deselect it.
						/// 
						/// The default behavior can be prevented using the <code>preventDefault</code> method.
						/// 
						/// <b>Note</b> Works for Gregorian calendars only and when <code>intervalSelection</code> is set to 'true'.
						/// </summary>
						public sap.ui.unified.Calendar.WeekNumberSelectDelegate weekNumberSelect;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class WeekNumberSelectInfo
					{
						/// <summary>
						/// The selected week number.
						/// </summary>
						public int weekNumber;

						/// <summary>
						/// The days of the corresponding week that are selected or deselected.
						/// </summary>
						public sap.ui.unified.DateRange weekDays;

					}

					#endregion

					#region Delegates

					public delegate void WeekNumberSelectDelegate(sap.ui.@base.Event<sap.ui.unified.Calendar.WeekNumberSelectInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Calendar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Calendar(string sId, sap.ui.unified.Calendar.Settings mSettings);

					/// <summary>
					/// Constructor for a new Calendar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Calendar(string sId);

					/// <summary>
					/// Constructor for a new Calendar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Calendar();

					/// <summary>
					/// Constructor for a new Calendar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Calendar(sap.ui.unified.Calendar.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property intervalSelection

					/// <summary>
					/// Gets current value of property {@link #getIntervalSelection intervalSelection}.
					/// 
					/// If set, interval selection is allowed
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>intervalSelection</code></returns>
					public extern virtual bool getIntervalSelection();

					/// <summary>
					/// Sets a new value for property {@link #getIntervalSelection intervalSelection}.
					/// 
					/// If set, interval selection is allowed
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bIntervalSelection">New value for property <code>intervalSelection</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setIntervalSelection(bool bIntervalSelection);

					#endregion

					#region Methods for Property singleSelection

					/// <summary>
					/// Gets current value of property {@link #getSingleSelection singleSelection}.
					/// 
					/// If set, only a single date or interval, if intervalSelection is enabled, can be selected
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>singleSelection</code></returns>
					public extern virtual bool getSingleSelection();

					/// <summary>
					/// Sets a new value for property {@link #getSingleSelection singleSelection}.
					/// 
					/// If set, only a single date or interval, if intervalSelection is enabled, can be selected
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bSingleSelection">New value for property <code>singleSelection</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setSingleSelection(bool bSingleSelection);

					#endregion

					#region Methods for Property months

					/// <summary>
					/// Gets current value of property {@link #getMonths months}.
					/// 
					/// Determines the number of months displayed.
					/// 
					/// As of version 1.50, the duplicated dates are not displayed if there are multiple months.
					/// 
					/// <b>Note:</b> On phones, only one month is displayed.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>months</code></returns>
					public extern virtual int getMonths();

					/// <summary>
					/// Sets a new value for property {@link #getMonths months}.
					/// 
					/// Determines the number of months displayed.
					/// 
					/// As of version 1.50, the duplicated dates are not displayed if there are multiple months.
					/// 
					/// <b>Note:</b> On phones, only one month is displayed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="iMonths">New value for property <code>months</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setMonths(int iMonths);

					#endregion

					#region Methods for Property firstDayOfWeek

					/// <summary>
					/// Gets current value of property {@link #getFirstDayOfWeek firstDayOfWeek}.
					/// 
					/// If set, the first day of the displayed week is this day. Valid values are 0 to 6. If not a valid value is set, the default of the used locale is used.
					/// 
					/// Default value is <code>-1</code>.
					/// </summary>
					/// <returns>Value of property <code>firstDayOfWeek</code></returns>
					public extern virtual int getFirstDayOfWeek();

					/// <summary>
					/// Sets a new value for property {@link #getFirstDayOfWeek firstDayOfWeek}.
					/// 
					/// If set, the first day of the displayed week is this day. Valid values are 0 to 6. If not a valid value is set, the default of the used locale is used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>-1</code>.
					/// </summary>
					/// <param name="iFirstDayOfWeek">New value for property <code>firstDayOfWeek</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setFirstDayOfWeek(int iFirstDayOfWeek);

					#endregion

					#region Methods for Property nonWorkingDays

					/// <summary>
					/// Gets current value of property {@link #getNonWorkingDays nonWorkingDays}.
					/// 
					/// If set, the provided weekdays are displayed as non-working days. Valid values inside the array are 0 to 6. If not set, the weekend defined in the locale settings is displayed as non-working days.
					/// 
					/// <b>Note:</b> Keep in mind that this property sets only weekly-recurring days as non-working. If you need specific dates or dates ranges, such as national holidays, use the <code>specialDates</code> aggregation to set them. Both the non-working days (from property) and dates (from aggregation) are visualized the same.
					/// </summary>
					/// <returns>Value of property <code>nonWorkingDays</code></returns>
					public extern virtual int[] getNonWorkingDays();

					/// <summary>
					/// Sets a new value for property {@link #getNonWorkingDays nonWorkingDays}.
					/// 
					/// If set, the provided weekdays are displayed as non-working days. Valid values inside the array are 0 to 6. If not set, the weekend defined in the locale settings is displayed as non-working days.
					/// 
					/// <b>Note:</b> Keep in mind that this property sets only weekly-recurring days as non-working. If you need specific dates or dates ranges, such as national holidays, use the <code>specialDates</code> aggregation to set them. Both the non-working days (from property) and dates (from aggregation) are visualized the same.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sNonWorkingDays">New value for property <code>nonWorkingDays</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setNonWorkingDays(int[] sNonWorkingDays);

					#endregion

					#region Methods for Property primaryCalendarType

					/// <summary>
					/// Gets current value of property {@link #getPrimaryCalendarType primaryCalendarType}.
					/// 
					/// If set, the calendar type is used for display. If not set, the calendar type of the global configuration is used.
					/// </summary>
					/// <returns>Value of property <code>primaryCalendarType</code></returns>
					public extern virtual sap.ui.core.CalendarType getPrimaryCalendarType();

					/// <summary>
					/// Sets a new value for property {@link #getPrimaryCalendarType primaryCalendarType}.
					/// 
					/// If set, the calendar type is used for display. If not set, the calendar type of the global configuration is used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sPrimaryCalendarType">New value for property <code>primaryCalendarType</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setPrimaryCalendarType(sap.ui.core.CalendarType sPrimaryCalendarType);

					#endregion

					#region Methods for Property secondaryCalendarType

					/// <summary>
					/// Gets current value of property {@link #getSecondaryCalendarType secondaryCalendarType}.
					/// 
					/// If set, the days are also displayed in this calendar type If not set, the dates are only displayed in the primary calendar type
					/// </summary>
					/// <returns>Value of property <code>secondaryCalendarType</code></returns>
					public extern virtual sap.ui.core.CalendarType getSecondaryCalendarType();

					/// <summary>
					/// Sets a new value for property {@link #getSecondaryCalendarType secondaryCalendarType}.
					/// 
					/// If set, the days are also displayed in this calendar type If not set, the dates are only displayed in the primary calendar type
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSecondaryCalendarType">New value for property <code>secondaryCalendarType</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setSecondaryCalendarType(sap.ui.core.CalendarType sSecondaryCalendarType);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Width of Calendar
					/// 
					/// <b>Note:</b> There is a theme depending minimum width, so the calendar can not be set smaller.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Width of Calendar
					/// 
					/// <b>Note:</b> There is a theme depending minimum width, so the calendar can not be set smaller.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property minDate

					/// <summary>
					/// Gets current value of property {@link #getMinDate minDate}.
					/// 
					/// Minimum date that can be shown and selected in the Calendar. This must be a JavaScript date object.
					/// 
					/// <b>Note:</b> if the date is inside of a month the complete month is displayed, but dates outside the valid range can not be selected.
					/// 
					/// <b>Note:</b> If the <code>minDate</code> is set to be after the <code>maxDate</code>, the <code>maxDate</code> is set to the end of the month of the <code>minDate</code>.
					/// </summary>
					/// <returns>Value of property <code>minDate</code></returns>
					public extern virtual object getMinDate();

					/// <summary>
					/// Sets a minimum date for the calendar.
					/// </summary>
					/// <param name="oDate">a JavaScript date</param>
					/// <returns><code>this</code> for method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setMinDate(DateTime oDate);

					#endregion

					#region Methods for Property maxDate

					/// <summary>
					/// Gets current value of property {@link #getMaxDate maxDate}.
					/// 
					/// Maximum date that can be shown and selected in the Calendar. This must be a JavaScript date object.
					/// 
					/// <b>Note:</b> if the date is inside of a month the complete month is displayed, but dates outside the valid range can not be selected.
					/// 
					/// <b>Note:</b> If the <code>maxDate</code> is set to be before the <code>minDate</code>, the <code>minDate</code> is set to the begin of the month of the <code>maxDate</code>.
					/// </summary>
					/// <returns>Value of property <code>maxDate</code></returns>
					public extern virtual object getMaxDate();

					/// <summary>
					/// Sets a maximum date for the calendar.
					/// </summary>
					/// <param name="oDate">a JavaScript date</param>
					/// <returns><code>this</code> for method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setMaxDate(DateTime oDate);

					#endregion

					#region Methods for Property showWeekNumbers

					/// <summary>
					/// Gets current value of property {@link #getShowWeekNumbers showWeekNumbers}.
					/// 
					/// Determines whether the week numbers in the months are displayed.
					/// 
					/// <b>Note:</b> For Islamic calendars, the week numbers are not displayed regardless of what is set to this property.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showWeekNumbers</code></returns>
					public extern virtual bool getShowWeekNumbers();

					/// <summary>
					/// Sets a new value for property {@link #getShowWeekNumbers showWeekNumbers}.
					/// 
					/// Determines whether the week numbers in the months are displayed.
					/// 
					/// <b>Note:</b> For Islamic calendars, the week numbers are not displayed regardless of what is set to this property.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowWeekNumbers">New value for property <code>showWeekNumbers</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setShowWeekNumbers(bool bShowWeekNumbers);

					#endregion

					#region Methods for Aggregation selectedDates

					/// <summary>
					/// Gets content of aggregation {@link #getSelectedDates selectedDates}.
					/// 
					/// Dates or date ranges for selected dates.
					/// 
					/// To set a single date (instead of a range), set only the <code>startDate</code> property of the {@link sap.ui.unified.DateRange} class.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.DateRange[] getSelectedDates();

					/// <summary>
					/// Destroys all the selectedDates in the aggregation {@link #getSelectedDates selectedDates}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar destroySelectedDates();

					/// <summary>
					/// Inserts a selectedDate into the aggregation {@link #getSelectedDates selectedDates}.
					/// </summary>
					/// <param name="oSelectedDate">The selectedDate to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the selectedDate should be inserted at; for a negative value of <code>iIndex</code>, the selectedDate is inserted at position 0; for a value greater than the current size of the aggregation, the selectedDate is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar insertSelectedDate(sap.ui.unified.DateRange oSelectedDate, int iIndex);

					/// <summary>
					/// Adds some selectedDate to the aggregation {@link #getSelectedDates selectedDates}.
					/// </summary>
					/// <param name="oSelectedDate">The selectedDate to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar addSelectedDate(sap.ui.unified.DateRange oSelectedDate);

					/// <summary>
					/// Removes a selectedDate from the aggregation {@link #getSelectedDates selectedDates}.
					/// </summary>
					/// <param name="vSelectedDate">The selectedDate to remove or its index or id</param>
					/// <returns>The removed selectedDate or <code>null</code></returns>
					public extern virtual sap.ui.unified.DateRange removeSelectedDate(Union<int, string, sap.ui.unified.DateRange> vSelectedDate);

					/// <summary>
					/// Checks for the provided <code>sap.ui.unified.DateRange</code> in the aggregation {@link #getSelectedDates selectedDates}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oSelectedDate">The selectedDate whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfSelectedDate(sap.ui.unified.DateRange oSelectedDate);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getSelectedDates selectedDates}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.unified.DateRange[] removeAllSelectedDates();

					#endregion

					#region Methods for Aggregation specialDates

					/// <summary>
					/// Gets content of aggregation {@link #getSpecialDates specialDates}.
					/// 
					/// Dates or date ranges with type, to visualize special days in the <code>Calendar</code>. If one day is assigned to more than one Type, only the first one will be used.
					/// 
					/// To set a single date (instead of a range), set only the <code>startDate</code> property of the {@link sap.ui.unified.DateRange} class.
					/// 
					/// <b>Note:</b> Keep in mind that the <code>NonWorking</code> type is for marking specific dates or date ranges as non-working, where if you need a weekly-reccuring non-working days (weekend), you should use the <code>nonWorkingDays</code> property. Both the non-working days (from property) and dates (from aggregation) are visualized the same.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.DateTypeRange[] getSpecialDates();

					/// <summary>
					/// Destroys all the specialDates in the aggregation {@link #getSpecialDates specialDates}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar destroySpecialDates();

					/// <summary>
					/// Inserts a specialDate into the aggregation {@link #getSpecialDates specialDates}.
					/// </summary>
					/// <param name="oSpecialDate">The specialDate to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the specialDate should be inserted at; for a negative value of <code>iIndex</code>, the specialDate is inserted at position 0; for a value greater than the current size of the aggregation, the specialDate is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar insertSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate, int iIndex);

					/// <summary>
					/// Adds some specialDate to the aggregation {@link #getSpecialDates specialDates}.
					/// </summary>
					/// <param name="oSpecialDate">The specialDate to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar addSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate);

					/// <summary>
					/// Removes a specialDate from the aggregation {@link #getSpecialDates specialDates}.
					/// </summary>
					/// <param name="vSpecialDate">The specialDate to remove or its index or id</param>
					/// <returns>The removed specialDate or <code>null</code></returns>
					public extern virtual sap.ui.unified.DateTypeRange removeSpecialDate(Union<int, string, sap.ui.unified.DateTypeRange> vSpecialDate);

					/// <summary>
					/// Checks for the provided <code>sap.ui.unified.DateTypeRange</code> in the aggregation {@link #getSpecialDates specialDates}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oSpecialDate">The specialDate whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getSpecialDates specialDates}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.unified.DateTypeRange[] removeAllSpecialDates();

					#endregion

					#region Methods for Aggregation disabledDates

					/// <summary>
					/// Gets content of aggregation {@link #getDisabledDates disabledDates}.
					/// 
					/// Dates or date ranges for disabled dates.
					/// 
					/// To set a single date (instead of a range), set only the <code>startDate</code> property of the {@link sap.ui.unified.DateRange} class.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.DateRange[] getDisabledDates();

					/// <summary>
					/// Destroys all the disabledDates in the aggregation {@link #getDisabledDates disabledDates}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar destroyDisabledDates();

					/// <summary>
					/// Inserts a disabledDate into the aggregation {@link #getDisabledDates disabledDates}.
					/// </summary>
					/// <param name="oDisabledDate">The disabledDate to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the disabledDate should be inserted at; for a negative value of <code>iIndex</code>, the disabledDate is inserted at position 0; for a value greater than the current size of the aggregation, the disabledDate is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar insertDisabledDate(sap.ui.unified.DateRange oDisabledDate, int iIndex);

					/// <summary>
					/// Adds some disabledDate to the aggregation {@link #getDisabledDates disabledDates}.
					/// </summary>
					/// <param name="oDisabledDate">The disabledDate to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar addDisabledDate(sap.ui.unified.DateRange oDisabledDate);

					/// <summary>
					/// Removes a disabledDate from the aggregation {@link #getDisabledDates disabledDates}.
					/// </summary>
					/// <param name="vDisabledDate">The disabledDate to remove or its index or id</param>
					/// <returns>The removed disabledDate or <code>null</code></returns>
					public extern virtual sap.ui.unified.DateRange removeDisabledDate(Union<int, string, sap.ui.unified.DateRange> vDisabledDate);

					/// <summary>
					/// Checks for the provided <code>sap.ui.unified.DateRange</code> in the aggregation {@link #getDisabledDates disabledDates}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oDisabledDate">The disabledDate whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfDisabledDate(sap.ui.unified.DateRange oDisabledDate);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getDisabledDates disabledDates}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.unified.DateRange[] removeAllDisabledDates();

					#endregion

					#region Methods for Aggregation header

					#endregion

					#region Methods for Aggregation secondMonthHeader

					#endregion

					#region Methods for Aggregation month

					#endregion

					#region Methods for Aggregation monthPicker

					#endregion

					#region Methods for Aggregation yearPicker

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
					public extern virtual sap.ui.unified.Calendar addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

					#region Methods for Association legend

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getLegend legend}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getLegend();

					/// <summary>
					/// Sets the associated {@link #getLegend legend}.
					/// </summary>
					/// <param name="oLegend">ID of an element which becomes the new target of this legend association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar setLegend(Union<sap.ui.core.ID, sap.ui.unified.CalendarLegend> oLegend);

					#endregion

					#region Methods for Event select

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Date selection changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.Calendar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Date selection changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Date selection changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachSelect(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Date selection changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.Calendar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar detachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar fireSelect(object mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar fireSelect();

					#endregion

					#region Methods for Event cancel

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Date selection was cancelled
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.Calendar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Date selection was cancelled
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Date selection was cancelled
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachCancel(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Date selection was cancelled
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.Calendar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:cancel cancel} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar detachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:cancel cancel} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar fireCancel(object mParameters);

					/// <summary>
					/// Fires event {@link #event:cancel cancel} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar fireCancel();

					#endregion

					#region Methods for Event startDateChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigation in <code>Calendar</code>
					/// 
					/// Use <code>getStartDate</code> function to determine the current start date
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.Calendar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachStartDateChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigation in <code>Calendar</code>
					/// 
					/// Use <code>getStartDate</code> function to determine the current start date
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachStartDateChange(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigation in <code>Calendar</code>
					/// 
					/// Use <code>getStartDate</code> function to determine the current start date
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachStartDateChange(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigation in <code>Calendar</code>
					/// 
					/// Use <code>getStartDate</code> function to determine the current start date
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.Calendar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachStartDateChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar detachStartDateChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:startDateChange startDateChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar fireStartDateChange(object mParameters);

					/// <summary>
					/// Fires event {@link #event:startDateChange startDateChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar fireStartDateChange();

					#endregion

					#region Methods for Event weekNumberSelect

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:weekNumberSelect weekNumberSelect} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Week number selection changed. By default, clicking on the week number will select the corresponding week. If the week has already been selected, clicking the week number will deselect it.
					/// 
					/// The default behavior can be prevented using the <code>preventDefault</code> method.
					/// 
					/// <b>Note</b> Works for Gregorian calendars only and when <code>intervalSelection</code> is set to 'true'.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.Calendar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachWeekNumberSelect(object oData, sap.ui.unified.Calendar.WeekNumberSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:weekNumberSelect weekNumberSelect} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Week number selection changed. By default, clicking on the week number will select the corresponding week. If the week has already been selected, clicking the week number will deselect it.
					/// 
					/// The default behavior can be prevented using the <code>preventDefault</code> method.
					/// 
					/// <b>Note</b> Works for Gregorian calendars only and when <code>intervalSelection</code> is set to 'true'.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachWeekNumberSelect(object oData, sap.ui.unified.Calendar.WeekNumberSelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:weekNumberSelect weekNumberSelect} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Week number selection changed. By default, clicking on the week number will select the corresponding week. If the week has already been selected, clicking the week number will deselect it.
					/// 
					/// The default behavior can be prevented using the <code>preventDefault</code> method.
					/// 
					/// <b>Note</b> Works for Gregorian calendars only and when <code>intervalSelection</code> is set to 'true'.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachWeekNumberSelect(sap.ui.unified.Calendar.WeekNumberSelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:weekNumberSelect weekNumberSelect} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.Calendar</code> itself.
					/// 
					/// Week number selection changed. By default, clicking on the week number will select the corresponding week. If the week has already been selected, clicking the week number will deselect it.
					/// 
					/// The default behavior can be prevented using the <code>preventDefault</code> method.
					/// 
					/// <b>Note</b> Works for Gregorian calendars only and when <code>intervalSelection</code> is set to 'true'.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.Calendar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar attachWeekNumberSelect(sap.ui.unified.Calendar.WeekNumberSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:weekNumberSelect weekNumberSelect} event of this <code>sap.ui.unified.Calendar</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar detachWeekNumberSelect(sap.ui.unified.Calendar.WeekNumberSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:weekNumberSelect weekNumberSelect} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireWeekNumberSelect(sap.ui.unified.Calendar.WeekNumberSelectInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:weekNumberSelect weekNumberSelect} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireWeekNumberSelect();

					#endregion

					#region Other methods

					/// <summary>
					/// Displays a date in the calendar but don't set the focus.
					/// </summary>
					/// <param name="oDate">JavaScript date object for focused date.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar displayDate(object oDate);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Calendar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Calendar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Calendar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Sets the focused date of the calendar.
					/// </summary>
					/// <param name="oDate">JavaScript date object for focused date.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar focusDate(object oDate);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.Calendar.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Returns the first day of the displayed month.
					/// 
					/// There might be some days of the previous month shown, but they can not be focused.
					/// </summary>
					/// <returns>JavaScript date object for start date.</returns>
					public extern virtual object getStartDate();

					#endregion

					#endregion

				}
			}
		}
	}
}
