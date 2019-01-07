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
				public static partial class calendar
				{
					/// <summary>
					/// renders a month with ItemNavigation This is used inside the calendar. Not for stand alone usage If used inside the calendar the properties and aggregation are directly taken from the parent (To not duplicate and sync DateRanges and so on...)
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.unified.calendar.Month")]
					public partial class Month : sap.ui.core.Control
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
							/// A date as JavaScript Date object. The month including this date is rendered and this date is focused initially (if no other focus is set).
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> date;

							/// <summary>
							/// If set, interval selection is allowed
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> intervalSelection;

							/// <summary>
							/// If set, only a single date or interval, if intervalSelection is enabled, can be selected
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> singleSelection;

							/// <summary>
							/// If set, a header with the month name is shown
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showHeader;

							/// <summary>
							/// If set, the first day of the displayed week is this day. Valid values are 0 to 6. If not a valid value is set, the default of the used locale is used.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> firstDayOfWeek;

							/// <summary>
							/// If set, the provided weekdays are displayed as non-working days. Valid values inside the array are 0 to 6. If not set, the weekend defined in the locale settings is displayed as non-working days.
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
							/// Width of Month
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

							/// <summary>
							/// Determines whether the week numbers in the months are displayed.
							/// 
							/// <b>Note:</b> For Islamic calendars, the week numbers are not displayed regardless of what is set to this property.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showWeekNumbers;

							/// <summary>
							/// Date Ranges for selected dates of the DatePicker
							/// </summary>
							public Union<sap.ui.unified.DateRange[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> selectedDates;

							/// <summary>
							/// <code>DateRange</code> with type to visualize special days in the Calendar.
							/// 
							/// <b>Note:</b> If one day is assigned to more than one DateTypeRange, only the first one will be used. The only exception is when one of the types is <code>NonWorking</code>, then you can have both <code>NonWorking</code> and the other type. For example, you can have <code>NonWorking</code> + <code>Type01</code> but you can't have <code>Type01</code> + <code>Type02</code>.
							/// </summary>
							public Union<sap.ui.unified.DateTypeRange[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> specialDates;

							/// <summary>
							/// Date Ranges for disabled dates
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
							/// Date focus changed
							/// </summary>
							public sap.ui.unified.calendar.Month.FocusDelegate focus;

						}

						#endregion

						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class FocusInfo
						{
							/// <summary>
							/// focused date
							/// </summary>
							public object date;

							/// <summary>
							/// focused date is in an other month that the displayed one
							/// </summary>
							public bool otherMonth;

							/// <summary>
							/// focused date is set to the same as before (date in other month clicked)
							/// </summary>
							public bool restoreOldDate;

						}

						#endregion

						#region Delegates

						public delegate void FocusDelegate(sap.ui.@base.Event<sap.ui.unified.calendar.Month.FocusInfo> oEvent, object oData);

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new calendar/Month.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern Month(string sId, sap.ui.unified.calendar.Month.Settings mSettings);

						/// <summary>
						/// Constructor for a new calendar/Month.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern Month(string sId);

						/// <summary>
						/// Constructor for a new calendar/Month.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern Month();

						/// <summary>
						/// Constructor for a new calendar/Month.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern Month(sap.ui.unified.calendar.Month.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property date

						/// <summary>
						/// Gets current value of property {@link #getDate date}.
						/// 
						/// A date as JavaScript Date object. The month including this date is rendered and this date is focused initially (if no other focus is set).
						/// </summary>
						/// <returns>Value of property <code>date</code></returns>
						public extern virtual object getDate();

						/// <summary>
						/// Sets a new value for property {@link #getDate date}.
						/// 
						/// A date as JavaScript Date object. The month including this date is rendered and this date is focused initially (if no other focus is set).
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="oDate">New value for property <code>date</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month setDate(object oDate);

						#endregion

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
						public extern virtual sap.ui.unified.calendar.Month setIntervalSelection(bool bIntervalSelection);

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
						public extern virtual sap.ui.unified.calendar.Month setSingleSelection(bool bSingleSelection);

						#endregion

						#region Methods for Property showHeader

						/// <summary>
						/// Gets current value of property {@link #getShowHeader showHeader}.
						/// 
						/// If set, a header with the month name is shown
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>showHeader</code></returns>
						public extern virtual bool getShowHeader();

						/// <summary>
						/// Sets a new value for property {@link #getShowHeader showHeader}.
						/// 
						/// If set, a header with the month name is shown
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bShowHeader">New value for property <code>showHeader</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month setShowHeader(bool bShowHeader);

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
						public extern virtual sap.ui.unified.calendar.Month setFirstDayOfWeek(int iFirstDayOfWeek);

						#endregion

						#region Methods for Property nonWorkingDays

						/// <summary>
						/// Gets current value of property {@link #getNonWorkingDays nonWorkingDays}.
						/// 
						/// If set, the provided weekdays are displayed as non-working days. Valid values inside the array are 0 to 6. If not set, the weekend defined in the locale settings is displayed as non-working days.
						/// </summary>
						/// <returns>Value of property <code>nonWorkingDays</code></returns>
						public extern virtual int[] getNonWorkingDays();

						/// <summary>
						/// Sets a new value for property {@link #getNonWorkingDays nonWorkingDays}.
						/// 
						/// If set, the provided weekdays are displayed as non-working days. Valid values inside the array are 0 to 6. If not set, the weekend defined in the locale settings is displayed as non-working days.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sNonWorkingDays">New value for property <code>nonWorkingDays</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month setNonWorkingDays(int[] sNonWorkingDays);

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
						public extern virtual sap.ui.unified.calendar.Month setPrimaryCalendarType(sap.ui.core.CalendarType sPrimaryCalendarType);

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
						public extern virtual sap.ui.unified.calendar.Month setSecondaryCalendarType(sap.ui.core.CalendarType sSecondaryCalendarType);

						#endregion

						#region Methods for Property width

						/// <summary>
						/// Gets current value of property {@link #getWidth width}.
						/// 
						/// Width of Month
						/// </summary>
						/// <returns>Value of property <code>width</code></returns>
						public extern virtual sap.ui.core.CSSSize getWidth();

						/// <summary>
						/// Sets a new value for property {@link #getWidth width}.
						/// 
						/// Width of Month
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sWidth">New value for property <code>width</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month setWidth(sap.ui.core.CSSSize sWidth);

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
						public extern virtual sap.ui.unified.calendar.Month setShowWeekNumbers(bool bShowWeekNumbers);

						#endregion

						#region Methods for Aggregation selectedDates

						/// <summary>
						/// Gets content of aggregation {@link #getSelectedDates selectedDates}.
						/// 
						/// Date Ranges for selected dates of the DatePicker
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.unified.DateRange[] getSelectedDates();

						/// <summary>
						/// Destroys all the selectedDates in the aggregation {@link #getSelectedDates selectedDates}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month destroySelectedDates();

						/// <summary>
						/// Inserts a selectedDate into the aggregation {@link #getSelectedDates selectedDates}.
						/// </summary>
						/// <param name="oSelectedDate">The selectedDate to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the selectedDate should be inserted at; for a negative value of <code>iIndex</code>, the selectedDate is inserted at position 0; for a value greater than the current size of the aggregation, the selectedDate is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month insertSelectedDate(sap.ui.unified.DateRange oSelectedDate, int iIndex);

						/// <summary>
						/// Adds some selectedDate to the aggregation {@link #getSelectedDates selectedDates}.
						/// </summary>
						/// <param name="oSelectedDate">The selectedDate to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month addSelectedDate(sap.ui.unified.DateRange oSelectedDate);

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
						/// <code>DateRange</code> with type to visualize special days in the Calendar.
						/// 
						/// <b>Note:</b> If one day is assigned to more than one DateTypeRange, only the first one will be used. The only exception is when one of the types is <code>NonWorking</code>, then you can have both <code>NonWorking</code> and the other type. For example, you can have <code>NonWorking</code> + <code>Type01</code> but you can't have <code>Type01</code> + <code>Type02</code>.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.unified.DateTypeRange[] getSpecialDates();

						/// <summary>
						/// Destroys all the specialDates in the aggregation {@link #getSpecialDates specialDates}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month destroySpecialDates();

						/// <summary>
						/// Inserts a specialDate into the aggregation {@link #getSpecialDates specialDates}.
						/// </summary>
						/// <param name="oSpecialDate">The specialDate to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the specialDate should be inserted at; for a negative value of <code>iIndex</code>, the specialDate is inserted at position 0; for a value greater than the current size of the aggregation, the specialDate is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month insertSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate, int iIndex);

						/// <summary>
						/// Adds some specialDate to the aggregation {@link #getSpecialDates specialDates}.
						/// </summary>
						/// <param name="oSpecialDate">The specialDate to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month addSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate);

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
						/// Date Ranges for disabled dates
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.unified.DateRange[] getDisabledDates();

						/// <summary>
						/// Destroys all the disabledDates in the aggregation {@link #getDisabledDates disabledDates}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month destroyDisabledDates();

						/// <summary>
						/// Inserts a disabledDate into the aggregation {@link #getDisabledDates disabledDates}.
						/// </summary>
						/// <param name="oDisabledDate">The disabledDate to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the disabledDate should be inserted at; for a negative value of <code>iIndex</code>, the disabledDate is inserted at position 0; for a value greater than the current size of the aggregation, the disabledDate is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month insertDisabledDate(sap.ui.unified.DateRange oDisabledDate, int iIndex);

						/// <summary>
						/// Adds some disabledDate to the aggregation {@link #getDisabledDates disabledDates}.
						/// </summary>
						/// <param name="oDisabledDate">The disabledDate to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month addDisabledDate(sap.ui.unified.DateRange oDisabledDate);

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
						public extern virtual sap.ui.unified.calendar.Month addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
						public extern virtual sap.ui.unified.calendar.Month setLegend(Union<sap.ui.core.ID, sap.ui.unified.CalendarLegend> oLegend);

						#endregion

						#region Methods for Event select

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.Month</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Month</code> itself.
						/// 
						/// Date selection changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Month</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.Month</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Month</code> itself.
						/// 
						/// Date selection changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.Month</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Month</code> itself.
						/// 
						/// Date selection changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month attachSelect(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.Month</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Month</code> itself.
						/// 
						/// Date selection changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Month</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month attachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.unified.calendar.Month</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month detachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:select select} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month fireSelect(object mParameters);

						/// <summary>
						/// Fires event {@link #event:select select} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month fireSelect();

						#endregion

						#region Methods for Event focus

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:focus focus} event of this <code>sap.ui.unified.calendar.Month</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Month</code> itself.
						/// 
						/// Date focus changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Month</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month attachFocus(object oData, sap.ui.unified.calendar.Month.FocusDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:focus focus} event of this <code>sap.ui.unified.calendar.Month</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Month</code> itself.
						/// 
						/// Date focus changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month attachFocus(object oData, sap.ui.unified.calendar.Month.FocusDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:focus focus} event of this <code>sap.ui.unified.calendar.Month</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Month</code> itself.
						/// 
						/// Date focus changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month attachFocus(sap.ui.unified.calendar.Month.FocusDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:focus focus} event of this <code>sap.ui.unified.calendar.Month</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Month</code> itself.
						/// 
						/// Date focus changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Month</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month attachFocus(sap.ui.unified.calendar.Month.FocusDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:focus focus} event of this <code>sap.ui.unified.calendar.Month</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month detachFocus(sap.ui.unified.calendar.Month.FocusDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:focus focus} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month fireFocus(sap.ui.unified.calendar.Month.FocusInfo mParameters);

						/// <summary>
						/// Fires event {@link #event:focus focus} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month fireFocus();

						#endregion

						#region Other methods

						/// <summary>
						/// checks if a date is focusable in the current rendered output. So if not rendered or in other month it is not focusable.
						/// </summary>
						/// <param name="oDate">JavaScript date object for focused date.</param>
						/// <returns>flag if focusable</returns>
						public extern virtual bool checkDateFocusable(object oDate);

						/// <summary>
						/// displays the month of a given date without setting the focus
						/// </summary>
						/// <param name="oDate">JavaScript date object for focused date.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Month displayDate(object oDate);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.Month with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.Month with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.Month with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.unified.calendar.Month.
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
	}
}
