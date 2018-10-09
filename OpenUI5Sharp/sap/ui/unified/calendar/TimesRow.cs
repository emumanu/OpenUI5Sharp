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
					/// Renders a row of time items using ItemNavigation. There is no paging or navigation outside the rendered area implemented. This is done inside the CalendarTimeInterval. If used inside the CalendarTimeInterval the properties and aggregation are directly taken from the parent (to not duplicate and synchronize DateRanges and so on...).
					/// 
					/// The TimesRow works with JavaScript Date objects.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.unified.calendar.TimesRow")]
					public partial class TimesRow : sap.ui.core.Control
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
							/// A date as JavaScript Date object. The month including this date is rendered and this date is focused initially (if no other focus is set). If the date property is not in the range <code>startDate</code> + <code>items</code> in the rendering phase, it is set to the <code>startDate</code>. So after setting the <code>startDate</code> the date should be set to be in the visible range.
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> date;

							/// <summary>
							/// Start date, as JavaScript Date object, of the row.
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> startDate;

							/// <summary>
							/// Number of time items displayed
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> items;

							/// <summary>
							/// Size of on time interval in minutes, default is 60 minutes.
							/// 
							/// <b>Note:</b> the start of the interval calculation is always <code>startDat</code> at 00:00.
							/// 
							/// An interval longer than 720 minutes is not allowed. Please use the <code>DatesRow</code> instead.
							/// 
							/// A day must be divisible by this interval size. One interval must not include more than one day.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> intervalMinutes;

							/// <summary>
							/// If set, interval selection is allowed
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> intervalSelection;

							/// <summary>
							/// If set, only a single month or interval, if intervalSelection is enabled, can be selected
							/// 
							/// <b>Note:</b> Selection of multiple intervals is not supported in the current version.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> singleSelection;

							/// <summary>
							/// If set, a header with the years is shown to visualize what month belongs to what year.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showHeader;

							/// <summary>
							/// Date ranges for selected dates. If <code>singleSelection</code> is set, only the first entry is used.
							/// </summary>
							public Union<sap.ui.unified.DateRange[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> selectedDates;

							/// <summary>
							/// Date ranges with type to visualize special item in the row. If one day is assigned to more than one type, only the first one will be used.
							/// </summary>
							public Union<sap.ui.unified.DateTypeRange[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> specialDates;

							/// <summary>
							/// Association to controls / IDs which label this control (see WAI-ARIA attribute aria-labelledby).
							/// </summary>
							public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

							/// <summary>
							/// Association to the <code>CalendarLegend</code> explaining the colors of the <code>specialDates</code>.
							/// 
							/// <b>Note</b> The legend does not have to be rendered but must exist, and all required types must be assigned.
							/// </summary>
							public Union<sap.ui.unified.CalendarLegend, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> legend;

							/// <summary>
							/// Time selection changed
							/// </summary>
							public sap.ui.@base.EventDelegate select;

							/// <summary>
							/// Time focus changed
							/// </summary>
							public sap.ui.unified.CalendarRowFocusDelegate focus;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new <code>TimesRow</code>. It shows a calendar with time granularity (normally hours)
						/// 
						/// <b>Note:</b> This is used inside the CalendarTimeInterval, not for standalone usage.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern TimesRow(string sId, sap.ui.unified.calendar.TimesRow.Settings mSettings);

						/// <summary>
						/// Constructor for a new <code>TimesRow</code>. It shows a calendar with time granularity (normally hours)
						/// 
						/// <b>Note:</b> This is used inside the CalendarTimeInterval, not for standalone usage.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern TimesRow(string sId);

						/// <summary>
						/// Constructor for a new <code>TimesRow</code>. It shows a calendar with time granularity (normally hours)
						/// 
						/// <b>Note:</b> This is used inside the CalendarTimeInterval, not for standalone usage.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern TimesRow();

						/// <summary>
						/// Constructor for a new <code>TimesRow</code>. It shows a calendar with time granularity (normally hours)
						/// 
						/// <b>Note:</b> This is used inside the CalendarTimeInterval, not for standalone usage.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern TimesRow(sap.ui.unified.calendar.TimesRow.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property date

						/// <summary>
						/// Gets current value of property {@link #getDate date}.
						/// 
						/// A date as JavaScript Date object. The month including this date is rendered and this date is focused initially (if no other focus is set). If the date property is not in the range <code>startDate</code> + <code>items</code> in the rendering phase, it is set to the <code>startDate</code>. So after setting the <code>startDate</code> the date should be set to be in the visible range.
						/// </summary>
						/// <returns>Value of property <code>date</code></returns>
						public extern virtual object getDate();

						/// <summary>
						/// Sets a new value for property {@link #getDate date}.
						/// 
						/// A date as JavaScript Date object. The month including this date is rendered and this date is focused initially (if no other focus is set). If the date property is not in the range <code>startDate</code> + <code>items</code> in the rendering phase, it is set to the <code>startDate</code>. So after setting the <code>startDate</code> the date should be set to be in the visible range.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="oDate">New value for property <code>date</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow setDate(object oDate);

						#endregion

						#region Methods for Property startDate

						/// <summary>
						/// Gets current value of property {@link #getStartDate startDate}.
						/// 
						/// Start date, as JavaScript Date object, of the row.
						/// </summary>
						/// <returns>Value of property <code>startDate</code></returns>
						public extern virtual object getStartDate();

						/// <summary>
						/// Sets a new value for property {@link #getStartDate startDate}.
						/// 
						/// Start date, as JavaScript Date object, of the row.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="oStartDate">New value for property <code>startDate</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow setStartDate(object oStartDate);

						#endregion

						#region Methods for Property items

						/// <summary>
						/// Gets current value of property {@link #getItems items}.
						/// 
						/// Number of time items displayed
						/// 
						/// Default value is <code>12</code>.
						/// </summary>
						/// <returns>Value of property <code>items</code></returns>
						public extern virtual int getItems();

						/// <summary>
						/// Sets a new value for property {@link #getItems items}.
						/// 
						/// Number of time items displayed
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>12</code>.
						/// </summary>
						/// <param name="iItems">New value for property <code>items</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow setItems(int iItems);

						#endregion

						#region Methods for Property intervalMinutes

						/// <summary>
						/// Gets current value of property {@link #getIntervalMinutes intervalMinutes}.
						/// 
						/// Size of on time interval in minutes, default is 60 minutes.
						/// 
						/// <b>Note:</b> the start of the interval calculation is always <code>startDat</code> at 00:00.
						/// 
						/// An interval longer than 720 minutes is not allowed. Please use the <code>DatesRow</code> instead.
						/// 
						/// A day must be divisible by this interval size. One interval must not include more than one day.
						/// 
						/// Default value is <code>60</code>.
						/// </summary>
						/// <returns>Value of property <code>intervalMinutes</code></returns>
						public extern virtual int getIntervalMinutes();

						/// <summary>
						/// Sets a new value for property {@link #getIntervalMinutes intervalMinutes}.
						/// 
						/// Size of on time interval in minutes, default is 60 minutes.
						/// 
						/// <b>Note:</b> the start of the interval calculation is always <code>startDat</code> at 00:00.
						/// 
						/// An interval longer than 720 minutes is not allowed. Please use the <code>DatesRow</code> instead.
						/// 
						/// A day must be divisible by this interval size. One interval must not include more than one day.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>60</code>.
						/// </summary>
						/// <param name="iIntervalMinutes">New value for property <code>intervalMinutes</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow setIntervalMinutes(int iIntervalMinutes);

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
						public extern virtual sap.ui.unified.calendar.TimesRow setIntervalSelection(bool bIntervalSelection);

						#endregion

						#region Methods for Property singleSelection

						/// <summary>
						/// Gets current value of property {@link #getSingleSelection singleSelection}.
						/// 
						/// If set, only a single month or interval, if intervalSelection is enabled, can be selected
						/// 
						/// <b>Note:</b> Selection of multiple intervals is not supported in the current version.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>singleSelection</code></returns>
						public extern virtual bool getSingleSelection();

						/// <summary>
						/// Sets a new value for property {@link #getSingleSelection singleSelection}.
						/// 
						/// If set, only a single month or interval, if intervalSelection is enabled, can be selected
						/// 
						/// <b>Note:</b> Selection of multiple intervals is not supported in the current version.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bSingleSelection">New value for property <code>singleSelection</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow setSingleSelection(bool bSingleSelection);

						#endregion

						#region Methods for Property showHeader

						/// <summary>
						/// Gets current value of property {@link #getShowHeader showHeader}.
						/// 
						/// If set, a header with the years is shown to visualize what month belongs to what year.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>showHeader</code></returns>
						public extern virtual bool getShowHeader();

						/// <summary>
						/// Sets a new value for property {@link #getShowHeader showHeader}.
						/// 
						/// If set, a header with the years is shown to visualize what month belongs to what year.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bShowHeader">New value for property <code>showHeader</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow setShowHeader(bool bShowHeader);

						#endregion

						#region Methods for Aggregation selectedDates

						/// <summary>
						/// Gets content of aggregation {@link #getSelectedDates selectedDates}.
						/// 
						/// Date ranges for selected dates. If <code>singleSelection</code> is set, only the first entry is used.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.unified.DateRange[] getSelectedDates();

						/// <summary>
						/// Destroys all the selectedDates in the aggregation {@link #getSelectedDates selectedDates}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow destroySelectedDates();

						/// <summary>
						/// Inserts a selectedDate into the aggregation {@link #getSelectedDates selectedDates}.
						/// </summary>
						/// <param name="oSelectedDate">The selectedDate to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the selectedDate should be inserted at; for a negative value of <code>iIndex</code>, the selectedDate is inserted at position 0; for a value greater than the current size of the aggregation, the selectedDate is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow insertSelectedDate(sap.ui.unified.DateRange oSelectedDate, int iIndex);

						/// <summary>
						/// Adds some selectedDate to the aggregation {@link #getSelectedDates selectedDates}.
						/// </summary>
						/// <param name="oSelectedDate">The selectedDate to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow addSelectedDate(sap.ui.unified.DateRange oSelectedDate);

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
						/// Date ranges with type to visualize special item in the row. If one day is assigned to more than one type, only the first one will be used.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.unified.DateTypeRange[] getSpecialDates();

						/// <summary>
						/// Destroys all the specialDates in the aggregation {@link #getSpecialDates specialDates}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow destroySpecialDates();

						/// <summary>
						/// Inserts a specialDate into the aggregation {@link #getSpecialDates specialDates}.
						/// </summary>
						/// <param name="oSpecialDate">The specialDate to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the specialDate should be inserted at; for a negative value of <code>iIndex</code>, the specialDate is inserted at position 0; for a value greater than the current size of the aggregation, the specialDate is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow insertSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate, int iIndex);

						/// <summary>
						/// Adds some specialDate to the aggregation {@link #getSpecialDates specialDates}.
						/// </summary>
						/// <param name="oSpecialDate">The specialDate to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow addSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate);

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
						public extern virtual sap.ui.unified.calendar.TimesRow addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
						public extern virtual sap.ui.unified.calendar.TimesRow setLegend(Union<sap.ui.core.ID, sap.ui.unified.CalendarLegend> oLegend);

						#endregion

						#region Methods for Event select

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.TimesRow</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.TimesRow</code> itself.
						/// 
						/// Time selection changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.TimesRow</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.TimesRow</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.TimesRow</code> itself.
						/// 
						/// Time selection changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.TimesRow</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.TimesRow</code> itself.
						/// 
						/// Time selection changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow attachSelect(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.TimesRow</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.TimesRow</code> itself.
						/// 
						/// Time selection changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.TimesRow</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow attachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.unified.calendar.TimesRow</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow detachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:select select} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow fireSelect(object mParameters);

						/// <summary>
						/// Fires event {@link #event:select select} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow fireSelect();

						#endregion

						#region Methods for Event focus

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:focus focus} event of this <code>sap.ui.unified.calendar.TimesRow</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.TimesRow</code> itself.
						/// 
						/// Time focus changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.TimesRow</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow attachFocus(object oData, sap.ui.unified.CalendarRowFocusDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:focus focus} event of this <code>sap.ui.unified.calendar.TimesRow</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.TimesRow</code> itself.
						/// 
						/// Time focus changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow attachFocus(object oData, sap.ui.unified.CalendarRowFocusDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:focus focus} event of this <code>sap.ui.unified.calendar.TimesRow</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.TimesRow</code> itself.
						/// 
						/// Time focus changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow attachFocus(sap.ui.unified.CalendarRowFocusDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:focus focus} event of this <code>sap.ui.unified.calendar.TimesRow</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.TimesRow</code> itself.
						/// 
						/// Time focus changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.TimesRow</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow attachFocus(sap.ui.unified.CalendarRowFocusDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:focus focus} event of this <code>sap.ui.unified.calendar.TimesRow</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow detachFocus(sap.ui.unified.CalendarRowFocusDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:focus focus} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow fireFocus(sap.ui.unified.CalendarRowFocusInfo mParameters);

						/// <summary>
						/// Fires event {@link #event:focus focus} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow fireFocus();

						#endregion

						#region Other methods

						/// <summary>
						/// Checks if a date is focusable in the current rendered output. This means that if it is not rendered, it is not focusable.
						/// </summary>
						/// <param name="oDate">JavaScript Date object for focused date.</param>
						/// <returns>flag if focusable</returns>
						public extern virtual bool checkDateFocusable(object oDate);

						/// <summary>
						/// Displays the given date without setting the focus
						/// </summary>
						/// <param name="oDate">JavaScript Date object for focused date.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.TimesRow displayDate(object oDate);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.TimesRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.TimesRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.TimesRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.unified.calendar.TimesRow.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
