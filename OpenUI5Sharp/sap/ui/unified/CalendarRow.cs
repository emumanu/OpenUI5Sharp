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
				/// A calendar row with a header and appointments. The Appointments will be placed in the defined interval.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.CalendarRow")]
				public partial class CalendarRow : sap.ui.core.Control
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
						/// Start date, as JavaScript Date object, of the row. As default, the current date is used.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> startDate;

						/// <summary>
						/// Number of displayed intervals. The size of the intervals is defined with <code>intervalType</code>
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> intervals;

						/// <summary>
						/// Type of the intervals of the row. The default is one hour.
						/// </summary>
						public Union<sap.ui.unified.CalendarIntervalType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> intervalType;

						/// <summary>
						/// If set, subintervals are shown.
						/// 
						/// If the interval type is <code>Hour</code>, quarter hours are shown.
						/// 
						/// If the interval type is <code>Day</code>, hours are shown.
						/// 
						/// If the interval type is <code>Month</code>, days are shown.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSubIntervals;

						/// <summary>
						/// If set, interval headers are shown like specified in <code>showEmptyIntervalHeaders</code>.
						/// 
						/// If not set, no interval headers are shown even if <code>intervalHeaders</code> are assigned.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showIntervalHeaders;

						/// <summary>
						/// If set, interval headers are shown even if no <code>intervalHeaders</code> are assigned to the visible time frame.
						/// 
						/// If not set, no interval headers are shown if no <code>intervalHeaders</code> are assigned.
						/// 
						/// <b>Note:</b> This property is only used if <code>showIntervalHeaders</code> is set to true.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showEmptyIntervalHeaders;

						/// <summary>
						/// If set, the provided weekdays are displayed as non-working days. Valid values inside the array are 0 to 6. (Other values will just be ignored.)
						/// 
						/// If not set, the weekend defined in the locale settings is displayed as non-working days.
						/// 
						/// <b>Note:</b> The non working days are only visualized if <code>intervalType</code> is set to day.
						/// </summary>
						public Union<int[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> nonWorkingDays;

						/// <summary>
						/// If set, the provided hours are displayed as non-working hours. Valid values inside the array are 0 to 23. (Other values will just be ignored.)
						/// 
						/// <b>Note:</b> The non working hours are only visualized if <code>intervalType</code> is set to hour.
						/// </summary>
						public Union<int[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> nonWorkingHours;

						/// <summary>
						/// Width of the row
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Height of the row
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// If set, the <code>CalendarRow</code> checks for resize by itself.
						/// 
						/// If a lot of <code>CalendarRow</code> controls are used in one container control (like <code>PlanningCalendar</code>). the resize checks should be done only by this container control. Then the container control should call <code>handleResize</code> of the <code>CalendarRow</code> if a resize happens.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> checkResize;

						/// <summary>
						/// If set the <code>CalendarRow</code> triggers a periodic update to visualize the current time.
						/// 
						/// If a lot of <code>CalendarRow</code> controls are used in one container control (like <code>PlanningCalendar</code>) the periodic update should be triggered only by this container control. Then the container control should call <code>updateCurrentTimeVisualization</code> of the <code>CalendarRow</code> to update the visualization.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> updateCurrentTime;

						/// <summary>
						/// Defines the mode in which the overlapping appointments are displayed.
						/// 
						/// <b>Note:</b> This property takes effect, only if the <code>intervalType</code> of the current calendar view is set to <code>sap.ui.unified.CalendarIntervalType.Month</code>. On phone devices this property is ignored, and the default value is applied.
						/// </summary>
						public Union<sap.ui.unified.GroupAppointmentsMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> groupAppointmentsMode;

						/// <summary>
						/// If set the appointments without text (only title) are rendered with a smaller height.
						/// 
						/// <b>Note:</b> On phone devices this property is ignored, appointments are always rendered in full height to allow touching.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> appointmentsReducedHeight;

						/// <summary>
						/// Defines the visualization of the <code>CalendarAppoinment</code>
						/// 
						/// <b>Note:</b> The real visualization depends on the used theme.
						/// </summary>
						public Union<sap.ui.unified.CalendarAppointmentVisualization, string, sap.ui.@base.ManagedObject.BindPropertyInfo> appointmentsVisualization;

						/// <summary>
						/// Appointments to be displayed in the row. Appointments outside the visible time frame are not rendered.
						/// 
						/// <b>Note:</b> For performance reasons, only appointments in the visible time range or nearby should be assigned.
						/// </summary>
						public Union<sap.ui.unified.CalendarAppointment[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> appointments;

						/// <summary>
						/// Appointments to be displayed in the top of the intervals. The <code>intervalHeaders</code> are used to visualize public holidays and similar things.
						/// 
						/// Appointments outside the visible time frame are not rendered.
						/// 
						/// The <code>intervalHeaders</code> always fill whole intervals. If they are shorter than one interval, they are not displayed.
						/// 
						/// <b>Note:</b> For performance reasons, only appointments in the visible time range or nearby should be assigned.
						/// </summary>
						public Union<sap.ui.unified.CalendarAppointment[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> intervalHeaders;

						/// <summary>
						/// Association to controls / IDs which label this control (see WAI-ARIA attribute aria-labelledby).
						/// 
						/// <b>Note</b> These labels are also assigned to the appointments.
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Association to the <code>CalendarLegend</code> explaining the colors of the <code>Appointments</code>.
						/// 
						/// <b>Note</b> The legend does not have to be rendered but must exist, and all required types must be assigned.
						/// </summary>
						public Union<sap.ui.unified.CalendarLegend, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> legend;

						/// <summary>
						/// Fired if an appointment was selected
						/// </summary>
						public sap.m.CalendarSelectDelegate select;

						/// <summary>
						/// <code>startDate</code> was changed while navigating in <code>CalendarRow</code>
						/// </summary>
						public sap.ui.@base.EventDelegate startDateChange;

						/// <summary>
						/// The <code>CalendarRow</code> should be left while navigating. (Arrow up or arrow down.) The caller should determine the next control to be focused
						/// </summary>
						public sap.ui.unified.CalendarRow.LeaveRowDelegate leaveRow;

						/// <summary>
						/// Fired if an interval was selected
						/// </summary>
						public sap.ui.unified.CalendarRow.IntervalSelectDelegate intervalSelect;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class IntervalSelectInfo
					{
						/// <summary>
						/// Interval start date as JavaScript date object
						/// </summary>
						public object startDate;

						/// <summary>
						/// Interval end date as JavaScript date object
						/// </summary>
						public object endDate;

						/// <summary>
						/// If set, the selected interval is a subinterval
						/// </summary>
						public bool subInterval;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class LeaveRowInfo
					{
						/// <summary>
						/// The type of the event that triggers this <code>leaveRow</code>
						/// </summary>
						public string type;

					}

					#endregion

					#region Delegates

					public delegate void IntervalSelectDelegate(sap.ui.@base.Event<sap.ui.unified.CalendarRow.IntervalSelectInfo> oEvent, object oData);

					public delegate void LeaveRowDelegate(sap.ui.@base.Event<sap.ui.unified.CalendarRow.LeaveRowInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>CalendarRow</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern CalendarRow(string sId, sap.ui.unified.CalendarRow.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>CalendarRow</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern CalendarRow(string sId);

					/// <summary>
					/// Constructor for a new <code>CalendarRow</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern CalendarRow();

					/// <summary>
					/// Constructor for a new <code>CalendarRow</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern CalendarRow(sap.ui.unified.CalendarRow.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property startDate

					/// <summary>
					/// Gets current value of property {@link #getStartDate startDate}.
					/// 
					/// Start date, as JavaScript Date object, of the row. As default, the current date is used.
					/// </summary>
					/// <returns>Value of property <code>startDate</code></returns>
					public extern virtual object getStartDate();

					/// <summary>
					/// Sets a new value for property {@link #getStartDate startDate}.
					/// 
					/// Start date, as JavaScript Date object, of the row. As default, the current date is used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oStartDate">New value for property <code>startDate</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setStartDate(object oStartDate);

					#endregion

					#region Methods for Property intervals

					/// <summary>
					/// Gets current value of property {@link #getIntervals intervals}.
					/// 
					/// Number of displayed intervals. The size of the intervals is defined with <code>intervalType</code>
					/// 
					/// Default value is <code>12</code>.
					/// </summary>
					/// <returns>Value of property <code>intervals</code></returns>
					public extern virtual int getIntervals();

					/// <summary>
					/// Sets a new value for property {@link #getIntervals intervals}.
					/// 
					/// Number of displayed intervals. The size of the intervals is defined with <code>intervalType</code>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>12</code>.
					/// </summary>
					/// <param name="iIntervals">New value for property <code>intervals</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setIntervals(int iIntervals);

					#endregion

					#region Methods for Property intervalType

					/// <summary>
					/// Gets current value of property {@link #getIntervalType intervalType}.
					/// 
					/// Type of the intervals of the row. The default is one hour.
					/// 
					/// Default value is <code>Hour</code>.
					/// </summary>
					/// <returns>Value of property <code>intervalType</code></returns>
					public extern virtual sap.ui.unified.CalendarIntervalType getIntervalType();

					/// <summary>
					/// Sets a new value for property {@link #getIntervalType intervalType}.
					/// 
					/// Type of the intervals of the row. The default is one hour.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Hour</code>.
					/// </summary>
					/// <param name="sIntervalType">New value for property <code>intervalType</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setIntervalType(sap.ui.unified.CalendarIntervalType sIntervalType);

					#endregion

					#region Methods for Property showSubIntervals

					/// <summary>
					/// Gets current value of property {@link #getShowSubIntervals showSubIntervals}.
					/// 
					/// If set, subintervals are shown.
					/// 
					/// If the interval type is <code>Hour</code>, quarter hours are shown.
					/// 
					/// If the interval type is <code>Day</code>, hours are shown.
					/// 
					/// If the interval type is <code>Month</code>, days are shown.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>showSubIntervals</code></returns>
					public extern virtual bool getShowSubIntervals();

					/// <summary>
					/// Sets a new value for property {@link #getShowSubIntervals showSubIntervals}.
					/// 
					/// If set, subintervals are shown.
					/// 
					/// If the interval type is <code>Hour</code>, quarter hours are shown.
					/// 
					/// If the interval type is <code>Day</code>, hours are shown.
					/// 
					/// If the interval type is <code>Month</code>, days are shown.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShowSubIntervals">New value for property <code>showSubIntervals</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setShowSubIntervals(bool bShowSubIntervals);

					#endregion

					#region Methods for Property showIntervalHeaders

					/// <summary>
					/// Gets current value of property {@link #getShowIntervalHeaders showIntervalHeaders}.
					/// 
					/// If set, interval headers are shown like specified in <code>showEmptyIntervalHeaders</code>.
					/// 
					/// If not set, no interval headers are shown even if <code>intervalHeaders</code> are assigned.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showIntervalHeaders</code></returns>
					public extern virtual bool getShowIntervalHeaders();

					/// <summary>
					/// Sets a new value for property {@link #getShowIntervalHeaders showIntervalHeaders}.
					/// 
					/// If set, interval headers are shown like specified in <code>showEmptyIntervalHeaders</code>.
					/// 
					/// If not set, no interval headers are shown even if <code>intervalHeaders</code> are assigned.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowIntervalHeaders">New value for property <code>showIntervalHeaders</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setShowIntervalHeaders(bool bShowIntervalHeaders);

					#endregion

					#region Methods for Property showEmptyIntervalHeaders

					/// <summary>
					/// Gets current value of property {@link #getShowEmptyIntervalHeaders showEmptyIntervalHeaders}.
					/// 
					/// If set, interval headers are shown even if no <code>intervalHeaders</code> are assigned to the visible time frame.
					/// 
					/// If not set, no interval headers are shown if no <code>intervalHeaders</code> are assigned.
					/// 
					/// <b>Note:</b> This property is only used if <code>showIntervalHeaders</code> is set to true.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showEmptyIntervalHeaders</code></returns>
					public extern virtual bool getShowEmptyIntervalHeaders();

					/// <summary>
					/// Sets a new value for property {@link #getShowEmptyIntervalHeaders showEmptyIntervalHeaders}.
					/// 
					/// If set, interval headers are shown even if no <code>intervalHeaders</code> are assigned to the visible time frame.
					/// 
					/// If not set, no interval headers are shown if no <code>intervalHeaders</code> are assigned.
					/// 
					/// <b>Note:</b> This property is only used if <code>showIntervalHeaders</code> is set to true.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowEmptyIntervalHeaders">New value for property <code>showEmptyIntervalHeaders</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setShowEmptyIntervalHeaders(bool bShowEmptyIntervalHeaders);

					#endregion

					#region Methods for Property nonWorkingDays

					/// <summary>
					/// Gets current value of property {@link #getNonWorkingDays nonWorkingDays}.
					/// 
					/// If set, the provided weekdays are displayed as non-working days. Valid values inside the array are 0 to 6. (Other values will just be ignored.)
					/// 
					/// If not set, the weekend defined in the locale settings is displayed as non-working days.
					/// 
					/// <b>Note:</b> The non working days are only visualized if <code>intervalType</code> is set to day.
					/// </summary>
					/// <returns>Value of property <code>nonWorkingDays</code></returns>
					public extern virtual int[] getNonWorkingDays();

					/// <summary>
					/// Sets a new value for property {@link #getNonWorkingDays nonWorkingDays}.
					/// 
					/// If set, the provided weekdays are displayed as non-working days. Valid values inside the array are 0 to 6. (Other values will just be ignored.)
					/// 
					/// If not set, the weekend defined in the locale settings is displayed as non-working days.
					/// 
					/// <b>Note:</b> The non working days are only visualized if <code>intervalType</code> is set to day.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sNonWorkingDays">New value for property <code>nonWorkingDays</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setNonWorkingDays(int[] sNonWorkingDays);

					#endregion

					#region Methods for Property nonWorkingHours

					/// <summary>
					/// Gets current value of property {@link #getNonWorkingHours nonWorkingHours}.
					/// 
					/// If set, the provided hours are displayed as non-working hours. Valid values inside the array are 0 to 23. (Other values will just be ignored.)
					/// 
					/// <b>Note:</b> The non working hours are only visualized if <code>intervalType</code> is set to hour.
					/// </summary>
					/// <returns>Value of property <code>nonWorkingHours</code></returns>
					public extern virtual int[] getNonWorkingHours();

					/// <summary>
					/// Sets a new value for property {@link #getNonWorkingHours nonWorkingHours}.
					/// 
					/// If set, the provided hours are displayed as non-working hours. Valid values inside the array are 0 to 23. (Other values will just be ignored.)
					/// 
					/// <b>Note:</b> The non working hours are only visualized if <code>intervalType</code> is set to hour.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sNonWorkingHours">New value for property <code>nonWorkingHours</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setNonWorkingHours(int[] sNonWorkingHours);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Width of the row
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Width of the row
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Height of the row
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// Height of the row
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property checkResize

					/// <summary>
					/// Gets current value of property {@link #getCheckResize checkResize}.
					/// 
					/// If set, the <code>CalendarRow</code> checks for resize by itself.
					/// 
					/// If a lot of <code>CalendarRow</code> controls are used in one container control (like <code>PlanningCalendar</code>). the resize checks should be done only by this container control. Then the container control should call <code>handleResize</code> of the <code>CalendarRow</code> if a resize happens.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>checkResize</code></returns>
					public extern virtual bool getCheckResize();

					/// <summary>
					/// Sets a new value for property {@link #getCheckResize checkResize}.
					/// 
					/// If set, the <code>CalendarRow</code> checks for resize by itself.
					/// 
					/// If a lot of <code>CalendarRow</code> controls are used in one container control (like <code>PlanningCalendar</code>). the resize checks should be done only by this container control. Then the container control should call <code>handleResize</code> of the <code>CalendarRow</code> if a resize happens.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bCheckResize">New value for property <code>checkResize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setCheckResize(bool bCheckResize);

					#endregion

					#region Methods for Property updateCurrentTime

					/// <summary>
					/// Gets current value of property {@link #getUpdateCurrentTime updateCurrentTime}.
					/// 
					/// If set the <code>CalendarRow</code> triggers a periodic update to visualize the current time.
					/// 
					/// If a lot of <code>CalendarRow</code> controls are used in one container control (like <code>PlanningCalendar</code>) the periodic update should be triggered only by this container control. Then the container control should call <code>updateCurrentTimeVisualization</code> of the <code>CalendarRow</code> to update the visualization.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>updateCurrentTime</code></returns>
					public extern virtual bool getUpdateCurrentTime();

					/// <summary>
					/// Sets a new value for property {@link #getUpdateCurrentTime updateCurrentTime}.
					/// 
					/// If set the <code>CalendarRow</code> triggers a periodic update to visualize the current time.
					/// 
					/// If a lot of <code>CalendarRow</code> controls are used in one container control (like <code>PlanningCalendar</code>) the periodic update should be triggered only by this container control. Then the container control should call <code>updateCurrentTimeVisualization</code> of the <code>CalendarRow</code> to update the visualization.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bUpdateCurrentTime">New value for property <code>updateCurrentTime</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setUpdateCurrentTime(bool bUpdateCurrentTime);

					#endregion

					#region Methods for Property groupAppointmentsMode

					/// <summary>
					/// Gets current value of property {@link #getGroupAppointmentsMode groupAppointmentsMode}.
					/// 
					/// Defines the mode in which the overlapping appointments are displayed.
					/// 
					/// <b>Note:</b> This property takes effect, only if the <code>intervalType</code> of the current calendar view is set to <code>sap.ui.unified.CalendarIntervalType.Month</code>. On phone devices this property is ignored, and the default value is applied.
					/// 
					/// Default value is <code>Collapsed</code>.
					/// </summary>
					/// <returns>Value of property <code>groupAppointmentsMode</code></returns>
					public extern virtual sap.ui.unified.GroupAppointmentsMode getGroupAppointmentsMode();

					/// <summary>
					/// Sets a new value for property {@link #getGroupAppointmentsMode groupAppointmentsMode}.
					/// 
					/// Defines the mode in which the overlapping appointments are displayed.
					/// 
					/// <b>Note:</b> This property takes effect, only if the <code>intervalType</code> of the current calendar view is set to <code>sap.ui.unified.CalendarIntervalType.Month</code>. On phone devices this property is ignored, and the default value is applied.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Collapsed</code>.
					/// </summary>
					/// <param name="sGroupAppointmentsMode">New value for property <code>groupAppointmentsMode</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setGroupAppointmentsMode(sap.ui.unified.GroupAppointmentsMode sGroupAppointmentsMode);

					#endregion

					#region Methods for Property appointmentsReducedHeight

					/// <summary>
					/// Gets current value of property {@link #getAppointmentsReducedHeight appointmentsReducedHeight}.
					/// 
					/// If set the appointments without text (only title) are rendered with a smaller height.
					/// 
					/// <b>Note:</b> On phone devices this property is ignored, appointments are always rendered in full height to allow touching.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>appointmentsReducedHeight</code></returns>
					public extern virtual bool getAppointmentsReducedHeight();

					/// <summary>
					/// Sets a new value for property {@link #getAppointmentsReducedHeight appointmentsReducedHeight}.
					/// 
					/// If set the appointments without text (only title) are rendered with a smaller height.
					/// 
					/// <b>Note:</b> On phone devices this property is ignored, appointments are always rendered in full height to allow touching.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bAppointmentsReducedHeight">New value for property <code>appointmentsReducedHeight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setAppointmentsReducedHeight(bool bAppointmentsReducedHeight);

					#endregion

					#region Methods for Property appointmentsVisualization

					/// <summary>
					/// Gets current value of property {@link #getAppointmentsVisualization appointmentsVisualization}.
					/// 
					/// Defines the visualization of the <code>CalendarAppoinment</code>
					/// 
					/// <b>Note:</b> The real visualization depends on the used theme.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <returns>Value of property <code>appointmentsVisualization</code></returns>
					public extern virtual sap.ui.unified.CalendarAppointmentVisualization getAppointmentsVisualization();

					/// <summary>
					/// Sets a new value for property {@link #getAppointmentsVisualization appointmentsVisualization}.
					/// 
					/// Defines the visualization of the <code>CalendarAppoinment</code>
					/// 
					/// <b>Note:</b> The real visualization depends on the used theme.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <param name="sAppointmentsVisualization">New value for property <code>appointmentsVisualization</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow setAppointmentsVisualization(sap.ui.unified.CalendarAppointmentVisualization sAppointmentsVisualization);

					#endregion

					#region Methods for Aggregation appointments

					/// <summary>
					/// Gets content of aggregation {@link #getAppointments appointments}.
					/// 
					/// Appointments to be displayed in the row. Appointments outside the visible time frame are not rendered.
					/// 
					/// <b>Note:</b> For performance reasons, only appointments in the visible time range or nearby should be assigned.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.CalendarAppointment[] getAppointments();

					/// <summary>
					/// Destroys all the appointments in the aggregation {@link #getAppointments appointments}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow destroyAppointments();

					/// <summary>
					/// Inserts a appointment into the aggregation {@link #getAppointments appointments}.
					/// </summary>
					/// <param name="oAppointment">The appointment to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the appointment should be inserted at; for a negative value of <code>iIndex</code>, the appointment is inserted at position 0; for a value greater than the current size of the aggregation, the appointment is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow insertAppointment(sap.ui.unified.CalendarAppointment oAppointment, int iIndex);

					/// <summary>
					/// Adds some appointment to the aggregation {@link #getAppointments appointments}.
					/// </summary>
					/// <param name="oAppointment">The appointment to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow addAppointment(sap.ui.unified.CalendarAppointment oAppointment);

					/// <summary>
					/// Removes a appointment from the aggregation {@link #getAppointments appointments}.
					/// </summary>
					/// <param name="vAppointment">The appointment to remove or its index or id</param>
					/// <returns>The removed appointment or <code>null</code></returns>
					public extern virtual sap.ui.unified.CalendarAppointment removeAppointment(Union<int, string, sap.ui.unified.CalendarAppointment> vAppointment);

					/// <summary>
					/// Checks for the provided <code>sap.ui.unified.CalendarAppointment</code> in the aggregation {@link #getAppointments appointments}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oAppointment">The appointment whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfAppointment(sap.ui.unified.CalendarAppointment oAppointment);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getAppointments appointments}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.unified.CalendarAppointment[] removeAllAppointments();

					#endregion

					#region Methods for Aggregation intervalHeaders

					/// <summary>
					/// Gets content of aggregation {@link #getIntervalHeaders intervalHeaders}.
					/// 
					/// Appointments to be displayed in the top of the intervals. The <code>intervalHeaders</code> are used to visualize public holidays and similar things.
					/// 
					/// Appointments outside the visible time frame are not rendered.
					/// 
					/// The <code>intervalHeaders</code> always fill whole intervals. If they are shorter than one interval, they are not displayed.
					/// 
					/// <b>Note:</b> For performance reasons, only appointments in the visible time range or nearby should be assigned.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.CalendarAppointment[] getIntervalHeaders();

					/// <summary>
					/// Destroys all the intervalHeaders in the aggregation {@link #getIntervalHeaders intervalHeaders}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow destroyIntervalHeaders();

					/// <summary>
					/// Inserts a intervalHeader into the aggregation {@link #getIntervalHeaders intervalHeaders}.
					/// </summary>
					/// <param name="oIntervalHeader">The intervalHeader to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the intervalHeader should be inserted at; for a negative value of <code>iIndex</code>, the intervalHeader is inserted at position 0; for a value greater than the current size of the aggregation, the intervalHeader is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow insertIntervalHeader(sap.ui.unified.CalendarAppointment oIntervalHeader, int iIndex);

					/// <summary>
					/// Adds some intervalHeader to the aggregation {@link #getIntervalHeaders intervalHeaders}.
					/// </summary>
					/// <param name="oIntervalHeader">The intervalHeader to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow addIntervalHeader(sap.ui.unified.CalendarAppointment oIntervalHeader);

					/// <summary>
					/// Removes a intervalHeader from the aggregation {@link #getIntervalHeaders intervalHeaders}.
					/// </summary>
					/// <param name="vIntervalHeader">The intervalHeader to remove or its index or id</param>
					/// <returns>The removed intervalHeader or <code>null</code></returns>
					public extern virtual sap.ui.unified.CalendarAppointment removeIntervalHeader(Union<int, string, sap.ui.unified.CalendarAppointment> vIntervalHeader);

					/// <summary>
					/// Checks for the provided <code>sap.ui.unified.CalendarAppointment</code> in the aggregation {@link #getIntervalHeaders intervalHeaders}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oIntervalHeader">The intervalHeader whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfIntervalHeader(sap.ui.unified.CalendarAppointment oIntervalHeader);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getIntervalHeaders intervalHeaders}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.unified.CalendarAppointment[] removeAllIntervalHeaders();

					#endregion

					#region Methods for Aggregation groupAppointments

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
					public extern virtual sap.ui.unified.CalendarRow addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
					public extern virtual sap.ui.unified.CalendarRow setLegend(Union<sap.ui.core.ID, sap.ui.unified.CalendarLegend> oLegend);

					#endregion

					#region Methods for Event select

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// Fired if an appointment was selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarRow</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachSelect(object oData, sap.m.CalendarSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// Fired if an appointment was selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachSelect(object oData, sap.m.CalendarSelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// Fired if an appointment was selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachSelect(sap.m.CalendarSelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// Fired if an appointment was selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarRow</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachSelect(sap.m.CalendarSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow detachSelect(sap.m.CalendarSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow fireSelect(sap.m.CalendarSelectInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow fireSelect();

					#endregion

					#region Methods for Event startDateChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigating in <code>CalendarRow</code>
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarRow</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachStartDateChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigating in <code>CalendarRow</code>
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachStartDateChange(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigating in <code>CalendarRow</code>
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachStartDateChange(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// <code>startDate</code> was changed while navigating in <code>CalendarRow</code>
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarRow</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachStartDateChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:startDateChange startDateChange} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow detachStartDateChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:startDateChange startDateChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow fireStartDateChange(object mParameters);

					/// <summary>
					/// Fires event {@link #event:startDateChange startDateChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow fireStartDateChange();

					#endregion

					#region Methods for Event leaveRow

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:leaveRow leaveRow} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// The <code>CalendarRow</code> should be left while navigating. (Arrow up or arrow down.) The caller should determine the next control to be focused
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarRow</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachLeaveRow(object oData, sap.ui.unified.CalendarRow.LeaveRowDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:leaveRow leaveRow} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// The <code>CalendarRow</code> should be left while navigating. (Arrow up or arrow down.) The caller should determine the next control to be focused
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachLeaveRow(object oData, sap.ui.unified.CalendarRow.LeaveRowDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:leaveRow leaveRow} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// The <code>CalendarRow</code> should be left while navigating. (Arrow up or arrow down.) The caller should determine the next control to be focused
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachLeaveRow(sap.ui.unified.CalendarRow.LeaveRowDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:leaveRow leaveRow} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// The <code>CalendarRow</code> should be left while navigating. (Arrow up or arrow down.) The caller should determine the next control to be focused
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarRow</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachLeaveRow(sap.ui.unified.CalendarRow.LeaveRowDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:leaveRow leaveRow} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow detachLeaveRow(sap.ui.unified.CalendarRow.LeaveRowDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:leaveRow leaveRow} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow fireLeaveRow(sap.ui.unified.CalendarRow.LeaveRowInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:leaveRow leaveRow} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow fireLeaveRow();

					#endregion

					#region Methods for Event intervalSelect

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:intervalSelect intervalSelect} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// Fired if an interval was selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarRow</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachIntervalSelect(object oData, sap.ui.unified.CalendarRow.IntervalSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:intervalSelect intervalSelect} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// Fired if an interval was selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachIntervalSelect(object oData, sap.ui.unified.CalendarRow.IntervalSelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:intervalSelect intervalSelect} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// Fired if an interval was selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachIntervalSelect(sap.ui.unified.CalendarRow.IntervalSelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:intervalSelect intervalSelect} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.CalendarRow</code> itself.
					/// 
					/// Fired if an interval was selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.CalendarRow</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow attachIntervalSelect(sap.ui.unified.CalendarRow.IntervalSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:intervalSelect intervalSelect} event of this <code>sap.ui.unified.CalendarRow</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow detachIntervalSelect(sap.ui.unified.CalendarRow.IntervalSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:intervalSelect intervalSelect} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow fireIntervalSelect(sap.ui.unified.CalendarRow.IntervalSelectInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:intervalSelect intervalSelect} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow fireIntervalSelect();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Focus the given <code>CalendarAppointment</code> in the <code>CalendarRow</code>.
					/// </summary>
					/// <param name="oAppointment">Appointment to be focused.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow focusAppointment(sap.ui.unified.CalendarAppointment oAppointment);

					/// <summary>
					/// Focus the <code>CalendarAppointment</code> in the <code>CalendarRow</code> that is nearest to the given date.
					/// </summary>
					/// <param name="oDate">Javascript Date object.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow focusNearestAppointment(object oDate);

					/// <summary>
					/// Returns the focused <code>CalendarAppointment</code> of the <code>CalendarRow</code>.
					/// 
					/// The focus must not really be on the <code>CalendarAppointment</code>, it have just to be the one that has the focus when the <code>CalendarRow</code> was focused last time.
					/// </summary>
					/// <returns>Focused Appointment</returns>
					public extern virtual sap.ui.unified.CalendarAppointment getFocusedAppointment();

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.CalendarRow.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// After a resize of the <code>CalendarRow</code>, some calculations for appointment sizes are needed.
					/// 
					/// For this, each <code>CalendarRow</code> can trigger the resize check for it's own DOM. But if multiple <code>CalendarRow</code>s are used in one container (e.g. <code>PlanningCalendar</code>), it is better if the container triggers the resize check once and then calls this function of each <code>CalendarRow</code>.
					/// </summary>
					/// <param name="oEvent">The event object of the resize handler.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow handleResize(jquery.JQuery.Event oEvent);

					/// <summary>
					/// If the current time is in the visible output of the <code>CalendarRow</code>, the indicator for the current time must be positioned.
					/// 
					/// For this, each <code>CalendarRow</code> can trigger a timer. But if multiple <code>CalendarRow</code>s are used in one container (e.G. <code>PlanningCalendar</code>), it is better if the container triggers the interval once and then calls this function of each <code>CalendarRow</code>.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarRow updateCurrentTimeVisualization();

					#endregion

					#endregion

				}
			}
		}
	}
}
