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
				/// Calendar with granularity of months displayed in one line.
				/// 
				/// <b>Note:</b> JavaScript Date objects are used to set and return the months, mark them as selected or as a special type. But the date part of the Date object is not used. If a Date object is returned the date will be set to the 1st of the corresponding month.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.CalendarMonthInterval")]
				public partial class CalendarMonthInterval : sap.ui.core.Control
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
						/// Width of the <code>CalendarMonthInterval</code>. The width of the single months depends on this width.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Start date of the Interval as JavaScript Date object. The month of this Date will be the first month in the displayed row.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> startDate;

						/// <summary>
						/// If set, interval selection is allowed
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> intervalSelection;

						/// <summary>
						/// If set, only a single date or interval, if <code>intervalSelection</code> is enabled, can be selected
						/// 
						/// <b>Note:</b> Selection of multiple intervals is not supported in the current version.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> singleSelection;

						/// <summary>
						/// Number of months displayed
						/// 
						/// <b>Note:</b> On phones, the maximum number of months displayed in the row is always 6.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> months;

						/// <summary>
						/// If set, the yearPicker opens on a popup
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> pickerPopup;

						/// <summary>
						/// Minimum date that can be shown and selected in the Calendar. This must be a JavaScript date object.
						/// 
						/// <b>Note:</b> If the <code>minDate</code> is set to be after the <code>maxDate</code>, the <code>maxDate</code> is set to the end of the month of the <code>minDate</code>.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minDate;

						/// <summary>
						/// Maximum date that can be shown and selected in the Calendar. This must be a JavaScript date object.
						/// 
						/// <b>Note:</b> If the <code>maxDate</code> is set to be before the <code>minDate</code>, the <code>minDate</code> is set to the begin of the month of the <code>maxDate</code>.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxDate;

						/// <summary>
						/// Date ranges for selected dates of the <code>CalendarMonthInterval</code>.
						/// 
						/// If <code>singleSelection</code> is set, only the first entry is used.
						/// 
						/// <b>Note:</b> Even if only one day is selected, the whole corresponding month is selected.
						/// </summary>
						public Union<sap.ui.unified.DateRange[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> selectedDates;

						/// <summary>
						/// Date ranges with type to visualize special months in the <code>CalendarMonthInterval</code>. If one day is assigned to more than one type, only the first one will be used.
						/// 
						/// <b>Note:</b> Even if only one day is set as a special day, the whole corresponding month is displayed in this way.
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
						/// Month selection changed
						/// </summary>
						public sap.ui.@base.EventDelegate select;

						/// <summary>
						/// Month selection was cancelled
						/// </summary>
						public sap.ui.@base.EventDelegate cancel;

						/// <summary>
						/// <code>startDate</code> was changed while navigation in <code>CalendarMonthInterval</code>
						/// </summary>
						public sap.ui.@base.EventDelegate startDateChange;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>CalendarMonthInterval</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern CalendarMonthInterval(string sId, sap.ui.unified.CalendarMonthInterval.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>CalendarMonthInterval</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern CalendarMonthInterval(string sId);

					/// <summary>
					/// Constructor for a new <code>CalendarMonthInterval</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern CalendarMonthInterval();

					/// <summary>
					/// Constructor for a new <code>CalendarMonthInterval</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern CalendarMonthInterval(sap.ui.unified.CalendarMonthInterval.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Width of the <code>CalendarMonthInterval</code>. The width of the single months depends on this width.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Width of the <code>CalendarMonthInterval</code>. The width of the single months depends on this width.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property startDate

					/// <summary>
					/// Gets current value of property {@link #getStartDate startDate}.
					/// 
					/// Start date of the Interval as JavaScript Date object. The month of this Date will be the first month in the displayed row.
					/// </summary>
					/// <returns>Value of property <code>startDate</code></returns>
					public extern virtual object getStartDate();

					/// <summary>
					/// Sets a new value for property {@link #getStartDate startDate}.
					/// 
					/// Start date of the Interval as JavaScript Date object. The month of this Date will be the first month in the displayed row.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oStartDate">New value for property <code>startDate</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval setStartDate(object oStartDate);

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
					public extern virtual sap.ui.unified.CalendarMonthInterval setIntervalSelection(bool bIntervalSelection);

					#endregion

					#region Methods for Property singleSelection

					/// <summary>
					/// Gets current value of property {@link #getSingleSelection singleSelection}.
					/// 
					/// If set, only a single date or interval, if <code>intervalSelection</code> is enabled, can be selected
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
					/// If set, only a single date or interval, if <code>intervalSelection</code> is enabled, can be selected
					/// 
					/// <b>Note:</b> Selection of multiple intervals is not supported in the current version.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bSingleSelection">New value for property <code>singleSelection</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval setSingleSelection(bool bSingleSelection);

					#endregion

					#region Methods for Property months

					/// <summary>
					/// Gets current value of property {@link #getMonths months}.
					/// 
					/// Number of months displayed
					/// 
					/// <b>Note:</b> On phones, the maximum number of months displayed in the row is always 6.
					/// 
					/// Default value is <code>12</code>.
					/// </summary>
					/// <returns>Value of property <code>months</code></returns>
					public extern virtual int getMonths();

					/// <summary>
					/// Sets a new value for property {@link #getMonths months}.
					/// 
					/// Number of months displayed
					/// 
					/// <b>Note:</b> On phones, the maximum number of months displayed in the row is always 6.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>12</code>.
					/// </summary>
					/// <param name="iMonths">New value for property <code>months</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval setMonths(int iMonths);

					#endregion

					#region Methods for Property pickerPopup

					/// <summary>
					/// Gets current value of property {@link #getPickerPopup pickerPopup}.
					/// 
					/// If set, the yearPicker opens on a popup
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>pickerPopup</code></returns>
					public extern virtual bool getPickerPopup();

					/// <summary>
					/// Sets a new value for property {@link #getPickerPopup pickerPopup}.
					/// 
					/// If set, the yearPicker opens on a popup
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bPickerPopup">New value for property <code>pickerPopup</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval setPickerPopup(bool bPickerPopup);

					#endregion

					#region Methods for Property minDate

					/// <summary>
					/// Gets current value of property {@link #getMinDate minDate}.
					/// 
					/// Minimum date that can be shown and selected in the Calendar. This must be a JavaScript date object.
					/// 
					/// <b>Note:</b> If the <code>minDate</code> is set to be after the <code>maxDate</code>, the <code>maxDate</code> is set to the end of the month of the <code>minDate</code>.
					/// </summary>
					/// <returns>Value of property <code>minDate</code></returns>
					public extern virtual object getMinDate();

					/// <summary>
					/// Sets a new value for property {@link #getMinDate minDate}.
					/// 
					/// Minimum date that can be shown and selected in the Calendar. This must be a JavaScript date object.
					/// 
					/// <b>Note:</b> If the <code>minDate</code> is set to be after the <code>maxDate</code>, the <code>maxDate</code> is set to the end of the month of the <code>minDate</code>.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oMinDate">New value for property <code>minDate</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval setMinDate(object oMinDate);

					#endregion

					#region Methods for Property maxDate

					/// <summary>
					/// Gets current value of property {@link #getMaxDate maxDate}.
					/// 
					/// Maximum date that can be shown and selected in the Calendar. This must be a JavaScript date object.
					/// 
					/// <b>Note:</b> If the <code>maxDate</code> is set to be before the <code>minDate</code>, the <code>minDate</code> is set to the begin of the month of the <code>maxDate</code>.
					/// </summary>
					/// <returns>Value of property <code>maxDate</code></returns>
					public extern virtual object getMaxDate();

					/// <summary>
					/// Sets a new value for property {@link #getMaxDate maxDate}.
					/// 
					/// Maximum date that can be shown and selected in the Calendar. This must be a JavaScript date object.
					/// 
					/// <b>Note:</b> If the <code>maxDate</code> is set to be before the <code>minDate</code>, the <code>minDate</code> is set to the begin of the month of the <code>maxDate</code>.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oMaxDate">New value for property <code>maxDate</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval setMaxDate(object oMaxDate);

					#endregion

					#region Methods for Aggregation selectedDates

					/// <summary>
					/// Gets content of aggregation {@link #getSelectedDates selectedDates}.
					/// 
					/// Date ranges for selected dates of the <code>CalendarMonthInterval</code>.
					/// 
					/// If <code>singleSelection</code> is set, only the first entry is used.
					/// 
					/// <b>Note:</b> Even if only one day is selected, the whole corresponding month is selected.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.DateRange[] getSelectedDates();

					/// <summary>
					/// Destroys all the selectedDates in the aggregation {@link #getSelectedDates selectedDates}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval destroySelectedDates();

					/// <summary>
					/// Inserts a selectedDate into the aggregation {@link #getSelectedDates selectedDates}.
					/// </summary>
					/// <param name="oSelectedDate">The selectedDate to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the selectedDate should be inserted at; for a negative value of <code>iIndex</code>, the selectedDate is inserted at position 0; for a value greater than the current size of the aggregation, the selectedDate is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval insertSelectedDate(sap.ui.unified.DateRange oSelectedDate, int iIndex);

					/// <summary>
					/// Adds some selectedDate to the aggregation {@link #getSelectedDates selectedDates}.
					/// </summary>
					/// <param name="oSelectedDate">The selectedDate to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval addSelectedDate(sap.ui.unified.DateRange oSelectedDate);

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
					/// Date ranges with type to visualize special months in the <code>CalendarMonthInterval</code>. If one day is assigned to more than one type, only the first one will be used.
					/// 
					/// <b>Note:</b> Even if only one day is set as a special day, the whole corresponding month is displayed in this way.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.DateTypeRange[] getSpecialDates();

					/// <summary>
					/// Destroys all the specialDates in the aggregation {@link #getSpecialDates specialDates}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval destroySpecialDates();

					/// <summary>
					/// Inserts a specialDate into the aggregation {@link #getSpecialDates specialDates}.
					/// </summary>
					/// <param name="oSpecialDate">The specialDate to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the specialDate should be inserted at; for a negative value of <code>iIndex</code>, the specialDate is inserted at position 0; for a value greater than the current size of the aggregation, the specialDate is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval insertSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate, int iIndex);

					/// <summary>
					/// Adds some specialDate to the aggregation {@link #getSpecialDates specialDates}.
					/// </summary>
					/// <param name="oSpecialDate">The specialDate to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval addSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate);

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

					#region Methods for Aggregation header

					#endregion

					#region Methods for Aggregation monthsRow

					#endregion

					#region Methods for Aggregation yearPicker

					#endregion

					#region Methods for Aggregation calendarPicker

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
					public extern virtual sap.ui.unified.CalendarMonthInterval addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
					public extern virtual sap.ui.unified.CalendarMonthInterval setLegend(Union<sap.ui.core.ID, sap.ui.unified.CalendarLegend> oLegend);

					#endregion

					#region Methods for Event select

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// Month selection changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarMonthInterval</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// Month selection changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// Month selection changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachSelect(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// Month selection changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarMonthInterval</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval detachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval fireSelect(object mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval fireSelect();

					#endregion

					#region Methods for Event cancel

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// Month selection was cancelled
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarMonthInterval</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// Month selection was cancelled
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// Month selection was cancelled
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachCancel(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// Month selection was cancelled
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarMonthInterval</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:cancel cancel} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval detachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:cancel cancel} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval fireCancel(object mParameters);

					/// <summary>
					/// Fires event {@link #event:cancel cancel} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval fireCancel();

					#endregion

					#region Methods for Event startDateChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigation in <code>CalendarMonthInterval</code>
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarMonthInterval</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachStartDateChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigation in <code>CalendarMonthInterval</code>
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachStartDateChange(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigation in <code>CalendarMonthInterval</code>
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachStartDateChange(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarMonthInterval</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigation in <code>CalendarMonthInterval</code>
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarMonthInterval</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval attachStartDateChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.CalendarMonthInterval</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval detachStartDateChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:startDateChange startDateChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval fireStartDateChange(object mParameters);

					/// <summary>
					/// Fires event {@link #event:startDateChange startDateChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval fireStartDateChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Displays a month in the <code>CalendarMonthInterval</code> but doesn't set the focus.
					/// </summary>
					/// <param name="oDatetime">JavaScript date object for displayed date. (The month of this date will be displayed.)</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarMonthInterval displayDate(object oDatetime);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarMonthInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarMonthInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarMonthInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Sets the focused month of the <code>CalendarMonthInterval</code>.
					/// </summary>
					/// <param name="oDatetime">JavaScript date object for focused date. (The month of this date will be focused.)</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.Calendar focusDate(object oDatetime);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.CalendarMonthInterval.
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
