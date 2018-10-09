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
			/// Represents a row in the {@link sap.m.PlanningCalendar}.
			/// 
			/// This element holds the data of one row in the {@link sap.m.PlanningCalendar}. Once the header information (for example, person information) is assigned, the appointments are assigned. The <code>sap.m.PlanningCalendarRow</code> allows you to modify appointments at row level.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.PlanningCalendarRow")]
			public partial class PlanningCalendarRow : sap.ui.core.Element
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Element.Settings
				{
					/// <summary>
					/// Defines the title of the header (for example, the name of the person).
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Defines the text of the header (for example, the department of the person).
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Specifies the URI of an image or an icon registered in <code>sap.ui.core.IconPool</code>.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// Determines whether the provided weekdays are displayed as non-working days. Valid values inside the array are from 0 to 6 (other values are ignored). If not set, the weekend defined in the locale settings is displayed as non-working days.
					/// 
					/// <b>Note:</b> The non-working days are visualized if the <code>intervalType</code> property of the {@link sap.m.PlanningCalendarView} is set to <code>Day</code>.
					/// </summary>
					public Union<int[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> nonWorkingDays;

					/// <summary>
					/// Determines whether the provided hours are displayed as non-working hours. Valid values inside the array are from 0 to 23 (other values are ignored).
					/// 
					/// <b>Note:</b> The non-working hours are visualized if <code>intervalType</code> property of the {@link sap.m.PlanningCalendarView} is set to <code>Hour</code>.
					/// </summary>
					public Union<int[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> nonWorkingHours;

					/// <summary>
					/// Defines the selected state of the <code>PlanningCalendarRow</code>.
					/// 
					/// <b>Note:</b> Binding the <code>selected</code> property in single selection modes may cause unwanted results if you have more than one selected row in your binding.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selected;

					/// <summary>
					/// Defines the identifier of the row.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> key;

					/// <summary>
					/// Determines whether the appointments in the row are draggable.
					/// 
					/// The drag and drop interaction is visualized by a placeholder highlighting the area where the appointment can be dropped by the user.
					/// 
					/// By default, appointments can be dragged only within their original <code>PlanningCalendarRow</code>. When <code>enableAppointmentsDragAndDrop</code> is set to true, attaching the {@link #event:appointmentDragEnter appointmentDragEnter} event can change the default behavior and allow appointments to be dragged between calendar rows.
					/// 
					/// Specifics based on the intervals (hours, days or months) displayed in the <code>PlanningCalendar</code> views:
					/// 
					/// Hours:<br> For views where the displayed intervals are hours, the placeholder snaps on every interval of 30 minutes. After the appointment is dropped, the {@link #event:appointmentDrop appointmentDrop} event is fired, containing the new start and end JavaScript date objects.<br> For example, an appointment with start date "Nov 13 2017 12:17:00" and end date "Nov 13 2017 12:45:30" lasts for 27 minutes and 30 seconds. After dragging and dropping to a new time, the possible new start date has time that is either "hh:00:00" or "hh:30:00" because of the placeholder that can snap on every 30 minutes. The new end date is calculated to be 27 minutes and 30 seconds later and would be either "hh:27:30" or "hh:57:30".
					/// 
					/// Days:<br> For views where intervals are days, the placeholder highlights the whole day and after the appointment is dropped the {@link #event:appointmentDrop appointmentDrop} event is fired. The event contains the new start and end JavaScript date objects with changed date but the original time (hh:mm:ss) is preserved.
					/// 
					/// Months:<br> For views where intervals are months, the placeholder highlights the whole month and after the appointment is dropped the {@link #event:appointmentDrop appointmentDrop} event is fired. The event contains the new start and end JavaScript date objects with changed month but the original date and time is preserved.
					/// 
					/// <b>Note:</b> In "One month" view, the appointments are not draggable on small screen (as there they are displayed as a list below the dates). Group appointments are also not draggable.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableAppointmentsDragAndDrop;

					/// <summary>
					/// Determines whether the appointments in the row are resizable.
					/// 
					/// The resize interaction is visualized by making the appointment transparent.
					/// 
					/// Specifics based on the intervals (hours, days or months) displayed in the <code>PlanningCalendar</code> views:
					/// 
					/// Hours: For views where the displayed intervals are hours, the appointment snaps on every interval of 30 minutes. After the resize is finished, the {@link #event:appointmentResize appointmentResize} event is fired, containing the new start and end JavaScript date objects.
					/// 
					/// Days: For views where intervals are days, the appointment snaps to the end of the day. After the resize is finished, the {@link #event:appointmentResize appointmentResize} event is fired, containing the new start and end JavaScript date objects. The <code>endDate</code> time is changed to 00:00:00
					/// 
					/// Months: For views where intervals are months, the appointment snaps to the end of the month. The {@link #event:appointmentResize appointmentResize} event is fired, containing the new start and end JavaScript date objects. The <code>endDate</code> is set to the 00:00:00 and first day of the following month.
					/// 
					/// <b>Notes:</b> In "One month" view, the appointments are not resizable on small screen (as there they are displayed as a list below the dates). Group appointments are also not resizable
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableAppointmentsResize;

					/// <summary>
					/// Determines whether the appointments can be created by dragging on empty cells.
					/// 
					/// See {@link #property:enableAppointmentsResize enableAppointmentsResize} for the specific points for events snapping
					/// 
					/// <b>Notes:</b> In "One month" view, the appointments cannot be created on small screen (as there they are displayed as a list below the dates).
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableAppointmentsCreate;

					/// <summary>
					/// The appointments to be displayed in the row. Appointments that outside the visible time frame are not rendered.
					/// 
					/// <b>Note:</b> For performance reasons, only appointments in the visible time range or nearby should be assigned.
					/// </summary>
					public Union<sap.ui.unified.CalendarAppointment[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> appointments;

					/// <summary>
					/// The appointments to be displayed at the top of the intervals (for example, for public holidays). Appointments outside the visible time frame are not rendered.
					/// 
					/// Keep in mind that the <code>intervalHeaders</code> should always fill whole intervals. If they are shorter or longer than one interval, they are not displayed.
					/// 
					/// <b>Note:</b> For performance reasons, only appointments in the visible time range or nearby should be assigned.
					/// </summary>
					public Union<sap.ui.unified.CalendarAppointment[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> intervalHeaders;

					/// <summary>
					/// Holds the special dates in the context of a row. A single date or a date range can be set.
					/// 
					/// <b>Note</> Only date or date ranges of type <code>sap.ui.unified.CalendarDayType.NonWorking</code> will be visualized in the <code>PlanningCalendarRow</code>. If the aggregation is set as another type, the date or date range will be ignored and will not be displayed in the control.
					/// </summary>
					public Union<sap.ui.unified.DateTypeRange[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> specialDates;

					/// <summary>
					/// Fired if an appointment is dropped.
					/// </summary>
					public sap.m.PlanningCalendarRow.AppointmentDropDelegate appointmentDrop;

					/// <summary>
					/// Fired if an appointment is dropped.
					/// 
					/// When this event handler is attached, the default behavior of the <code>enableAppointmentsDragAndDrop</code> property to move appointments only within their original calendar row is no longer valid. You can move the appointment around all rows for which <code>enableAppointmentsDragAndDrop</code> is set to true. In this case, the drop target area is indicated by a placeholder. In the event handler you can call the <code>preventDefault</code> method of the event to prevent this default behavior. In this case, the placeholder will no longer be available and it will not be possible to drop the appointment in the row.
					/// </summary>
					public sap.m.PlanningCalendarRow.AppointmentDragEnterDelegate appointmentDragEnter;

					/// <summary>
					/// Fired if an appointment is resized.
					/// </summary>
					public sap.m.PlanningCalendarRow.AppointmentResizeDelegate appointmentResize;

					/// <summary>
					/// Fired if an appointment is created.
					/// </summary>
					public sap.m.PlanningCalendarRow.AppointmentCreateDelegate appointmentCreate;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class AppointmentCreateInfo
				{
					/// <summary>
					/// Start date of the created appointment, as a JavaScript date object.
					/// </summary>
					public object startDate;

					/// <summary>
					/// End date of the created appointment, as a JavaScript date object.
					/// </summary>
					public object endDate;

					/// <summary>
					/// The row of the appointment.
					/// </summary>
					public sap.m.PlanningCalendarRow calendarRow;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class AppointmentDragEnterInfo
				{
					/// <summary>
					/// The dropped appointment.
					/// </summary>
					public sap.ui.unified.CalendarAppointment appointment;

					/// <summary>
					/// Start date of the dropped appointment, as a JavaScript date object.
					/// </summary>
					public object startDate;

					/// <summary>
					/// Dropped appointment end date as a JavaScript date object.
					/// </summary>
					public object endDate;

					/// <summary>
					/// The row of the appointment.
					/// </summary>
					public sap.m.PlanningCalendarRow calendarRow;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class AppointmentDropInfo
				{
					/// <summary>
					/// The dropped appointment.
					/// </summary>
					public sap.ui.unified.CalendarAppointment appointment;

					/// <summary>
					/// Start date of the dropped appointment, as a JavaScript date object.
					/// </summary>
					public object startDate;

					/// <summary>
					/// Dropped appointment end date as a JavaScript date object.
					/// </summary>
					public object endDate;

					/// <summary>
					/// The row of the appointment.
					/// </summary>
					public sap.m.PlanningCalendarRow calendarRow;

					/// <summary>
					/// The drop type. If true - it's "Copy", if false - it's "Move".
					/// </summary>
					public bool copy;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class AppointmentResizeInfo
				{
					/// <summary>
					/// The resized appointment.
					/// </summary>
					public sap.ui.unified.CalendarAppointment appointment;

					/// <summary>
					/// Start date of the resized appointment, as a JavaScript date object.
					/// </summary>
					public object startDate;

					/// <summary>
					/// End date of the resized appointment, as a JavaScript date object.
					/// </summary>
					public object endDate;

				}

				#endregion

				#region Delegates

				public delegate void AppointmentCreateDelegate(sap.ui.@base.Event<sap.m.PlanningCalendarRow.AppointmentCreateInfo> oEvent, object oData);

				public delegate void AppointmentDragEnterDelegate(sap.ui.@base.Event<sap.m.PlanningCalendarRow.AppointmentDragEnterInfo> oEvent, object oData);

				public delegate void AppointmentDropDelegate(sap.ui.@base.Event<sap.m.PlanningCalendarRow.AppointmentDropInfo> oEvent, object oData);

				public delegate void AppointmentResizeDelegate(sap.ui.@base.Event<sap.m.PlanningCalendarRow.AppointmentResizeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarRow</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern PlanningCalendarRow(string sId, sap.m.PlanningCalendarRow.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarRow</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern PlanningCalendarRow(string sId);

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarRow</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern PlanningCalendarRow();

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarRow</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern PlanningCalendarRow(sap.m.PlanningCalendarRow.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Defines the title of the header (for example, the name of the person).
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Defines the title of the header (for example, the name of the person).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow setTitle(string sTitle);

				#endregion

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Defines the text of the header (for example, the department of the person).
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// Defines the text of the header (for example, the department of the person).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow setText(string sText);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Specifies the URI of an image or an icon registered in <code>sap.ui.core.IconPool</code>.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Specifies the URI of an image or an icon registered in <code>sap.ui.core.IconPool</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property nonWorkingDays

				/// <summary>
				/// Gets current value of property {@link #getNonWorkingDays nonWorkingDays}.
				/// 
				/// Determines whether the provided weekdays are displayed as non-working days. Valid values inside the array are from 0 to 6 (other values are ignored). If not set, the weekend defined in the locale settings is displayed as non-working days.
				/// 
				/// <b>Note:</b> The non-working days are visualized if the <code>intervalType</code> property of the {@link sap.m.PlanningCalendarView} is set to <code>Day</code>.
				/// </summary>
				/// <returns>Value of property <code>nonWorkingDays</code></returns>
				public extern virtual int[] getNonWorkingDays();

				/// <summary>
				/// Sets a new value for property {@link #getNonWorkingDays nonWorkingDays}.
				/// 
				/// Determines whether the provided weekdays are displayed as non-working days. Valid values inside the array are from 0 to 6 (other values are ignored). If not set, the weekend defined in the locale settings is displayed as non-working days.
				/// 
				/// <b>Note:</b> The non-working days are visualized if the <code>intervalType</code> property of the {@link sap.m.PlanningCalendarView} is set to <code>Day</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sNonWorkingDays">New value for property <code>nonWorkingDays</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow setNonWorkingDays(int[] sNonWorkingDays);

				#endregion

				#region Methods for Property nonWorkingHours

				/// <summary>
				/// Gets current value of property {@link #getNonWorkingHours nonWorkingHours}.
				/// 
				/// Determines whether the provided hours are displayed as non-working hours. Valid values inside the array are from 0 to 23 (other values are ignored).
				/// 
				/// <b>Note:</b> The non-working hours are visualized if <code>intervalType</code> property of the {@link sap.m.PlanningCalendarView} is set to <code>Hour</code>.
				/// </summary>
				/// <returns>Value of property <code>nonWorkingHours</code></returns>
				public extern virtual int[] getNonWorkingHours();

				/// <summary>
				/// Sets a new value for property {@link #getNonWorkingHours nonWorkingHours}.
				/// 
				/// Determines whether the provided hours are displayed as non-working hours. Valid values inside the array are from 0 to 23 (other values are ignored).
				/// 
				/// <b>Note:</b> The non-working hours are visualized if <code>intervalType</code> property of the {@link sap.m.PlanningCalendarView} is set to <code>Hour</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sNonWorkingHours">New value for property <code>nonWorkingHours</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow setNonWorkingHours(int[] sNonWorkingHours);

				#endregion

				#region Methods for Property selected

				/// <summary>
				/// Gets current value of property {@link #getSelected selected}.
				/// 
				/// Defines the selected state of the <code>PlanningCalendarRow</code>.
				/// 
				/// <b>Note:</b> Binding the <code>selected</code> property in single selection modes may cause unwanted results if you have more than one selected row in your binding.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>selected</code></returns>
				public extern virtual bool getSelected();

				/// <summary>
				/// Sets a new value for property {@link #getSelected selected}.
				/// 
				/// Defines the selected state of the <code>PlanningCalendarRow</code>.
				/// 
				/// <b>Note:</b> Binding the <code>selected</code> property in single selection modes may cause unwanted results if you have more than one selected row in your binding.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bSelected">New value for property <code>selected</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow setSelected(bool bSelected);

				#endregion

				#region Methods for Property key

				/// <summary>
				/// Gets current value of property {@link #getKey key}.
				/// 
				/// Defines the identifier of the row.
				/// </summary>
				/// <returns>Value of property <code>key</code></returns>
				public extern virtual string getKey();

				/// <summary>
				/// Sets a new value for property {@link #getKey key}.
				/// 
				/// Defines the identifier of the row.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sKey">New value for property <code>key</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow setKey(string sKey);

				#endregion

				#region Methods for Property enableAppointmentsDragAndDrop

				/// <summary>
				/// Gets current value of property {@link #getEnableAppointmentsDragAndDrop enableAppointmentsDragAndDrop}.
				/// 
				/// Determines whether the appointments in the row are draggable.
				/// 
				/// The drag and drop interaction is visualized by a placeholder highlighting the area where the appointment can be dropped by the user.
				/// 
				/// By default, appointments can be dragged only within their original <code>PlanningCalendarRow</code>. When <code>enableAppointmentsDragAndDrop</code> is set to true, attaching the {@link #event:appointmentDragEnter appointmentDragEnter} event can change the default behavior and allow appointments to be dragged between calendar rows.
				/// 
				/// Specifics based on the intervals (hours, days or months) displayed in the <code>PlanningCalendar</code> views:
				/// 
				/// Hours:<br> For views where the displayed intervals are hours, the placeholder snaps on every interval of 30 minutes. After the appointment is dropped, the {@link #event:appointmentDrop appointmentDrop} event is fired, containing the new start and end JavaScript date objects.<br> For example, an appointment with start date "Nov 13 2017 12:17:00" and end date "Nov 13 2017 12:45:30" lasts for 27 minutes and 30 seconds. After dragging and dropping to a new time, the possible new start date has time that is either "hh:00:00" or "hh:30:00" because of the placeholder that can snap on every 30 minutes. The new end date is calculated to be 27 minutes and 30 seconds later and would be either "hh:27:30" or "hh:57:30".
				/// 
				/// Days:<br> For views where intervals are days, the placeholder highlights the whole day and after the appointment is dropped the {@link #event:appointmentDrop appointmentDrop} event is fired. The event contains the new start and end JavaScript date objects with changed date but the original time (hh:mm:ss) is preserved.
				/// 
				/// Months:<br> For views where intervals are months, the placeholder highlights the whole month and after the appointment is dropped the {@link #event:appointmentDrop appointmentDrop} event is fired. The event contains the new start and end JavaScript date objects with changed month but the original date and time is preserved.
				/// 
				/// <b>Note:</b> In "One month" view, the appointments are not draggable on small screen (as there they are displayed as a list below the dates). Group appointments are also not draggable.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableAppointmentsDragAndDrop</code></returns>
				public extern virtual bool getEnableAppointmentsDragAndDrop();

				/// <summary>
				/// Sets a new value for property {@link #getEnableAppointmentsDragAndDrop enableAppointmentsDragAndDrop}.
				/// 
				/// Determines whether the appointments in the row are draggable.
				/// 
				/// The drag and drop interaction is visualized by a placeholder highlighting the area where the appointment can be dropped by the user.
				/// 
				/// By default, appointments can be dragged only within their original <code>PlanningCalendarRow</code>. When <code>enableAppointmentsDragAndDrop</code> is set to true, attaching the {@link #event:appointmentDragEnter appointmentDragEnter} event can change the default behavior and allow appointments to be dragged between calendar rows.
				/// 
				/// Specifics based on the intervals (hours, days or months) displayed in the <code>PlanningCalendar</code> views:
				/// 
				/// Hours:<br> For views where the displayed intervals are hours, the placeholder snaps on every interval of 30 minutes. After the appointment is dropped, the {@link #event:appointmentDrop appointmentDrop} event is fired, containing the new start and end JavaScript date objects.<br> For example, an appointment with start date "Nov 13 2017 12:17:00" and end date "Nov 13 2017 12:45:30" lasts for 27 minutes and 30 seconds. After dragging and dropping to a new time, the possible new start date has time that is either "hh:00:00" or "hh:30:00" because of the placeholder that can snap on every 30 minutes. The new end date is calculated to be 27 minutes and 30 seconds later and would be either "hh:27:30" or "hh:57:30".
				/// 
				/// Days:<br> For views where intervals are days, the placeholder highlights the whole day and after the appointment is dropped the {@link #event:appointmentDrop appointmentDrop} event is fired. The event contains the new start and end JavaScript date objects with changed date but the original time (hh:mm:ss) is preserved.
				/// 
				/// Months:<br> For views where intervals are months, the placeholder highlights the whole month and after the appointment is dropped the {@link #event:appointmentDrop appointmentDrop} event is fired. The event contains the new start and end JavaScript date objects with changed month but the original date and time is preserved.
				/// 
				/// <b>Note:</b> In "One month" view, the appointments are not draggable on small screen (as there they are displayed as a list below the dates). Group appointments are also not draggable.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableAppointmentsDragAndDrop">New value for property <code>enableAppointmentsDragAndDrop</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow setEnableAppointmentsDragAndDrop(bool bEnableAppointmentsDragAndDrop);

				#endregion

				#region Methods for Property enableAppointmentsResize

				/// <summary>
				/// Gets current value of property {@link #getEnableAppointmentsResize enableAppointmentsResize}.
				/// 
				/// Determines whether the appointments in the row are resizable.
				/// 
				/// The resize interaction is visualized by making the appointment transparent.
				/// 
				/// Specifics based on the intervals (hours, days or months) displayed in the <code>PlanningCalendar</code> views:
				/// 
				/// Hours: For views where the displayed intervals are hours, the appointment snaps on every interval of 30 minutes. After the resize is finished, the {@link #event:appointmentResize appointmentResize} event is fired, containing the new start and end JavaScript date objects.
				/// 
				/// Days: For views where intervals are days, the appointment snaps to the end of the day. After the resize is finished, the {@link #event:appointmentResize appointmentResize} event is fired, containing the new start and end JavaScript date objects. The <code>endDate</code> time is changed to 00:00:00
				/// 
				/// Months: For views where intervals are months, the appointment snaps to the end of the month. The {@link #event:appointmentResize appointmentResize} event is fired, containing the new start and end JavaScript date objects. The <code>endDate</code> is set to the 00:00:00 and first day of the following month.
				/// 
				/// <b>Notes:</b> In "One month" view, the appointments are not resizable on small screen (as there they are displayed as a list below the dates). Group appointments are also not resizable
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableAppointmentsResize</code></returns>
				public extern virtual bool getEnableAppointmentsResize();

				/// <summary>
				/// Sets a new value for property {@link #getEnableAppointmentsResize enableAppointmentsResize}.
				/// 
				/// Determines whether the appointments in the row are resizable.
				/// 
				/// The resize interaction is visualized by making the appointment transparent.
				/// 
				/// Specifics based on the intervals (hours, days or months) displayed in the <code>PlanningCalendar</code> views:
				/// 
				/// Hours: For views where the displayed intervals are hours, the appointment snaps on every interval of 30 minutes. After the resize is finished, the {@link #event:appointmentResize appointmentResize} event is fired, containing the new start and end JavaScript date objects.
				/// 
				/// Days: For views where intervals are days, the appointment snaps to the end of the day. After the resize is finished, the {@link #event:appointmentResize appointmentResize} event is fired, containing the new start and end JavaScript date objects. The <code>endDate</code> time is changed to 00:00:00
				/// 
				/// Months: For views where intervals are months, the appointment snaps to the end of the month. The {@link #event:appointmentResize appointmentResize} event is fired, containing the new start and end JavaScript date objects. The <code>endDate</code> is set to the 00:00:00 and first day of the following month.
				/// 
				/// <b>Notes:</b> In "One month" view, the appointments are not resizable on small screen (as there they are displayed as a list below the dates). Group appointments are also not resizable
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableAppointmentsResize">New value for property <code>enableAppointmentsResize</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow setEnableAppointmentsResize(bool bEnableAppointmentsResize);

				#endregion

				#region Methods for Property enableAppointmentsCreate

				/// <summary>
				/// Gets current value of property {@link #getEnableAppointmentsCreate enableAppointmentsCreate}.
				/// 
				/// Determines whether the appointments can be created by dragging on empty cells.
				/// 
				/// See {@link #property:enableAppointmentsResize enableAppointmentsResize} for the specific points for events snapping
				/// 
				/// <b>Notes:</b> In "One month" view, the appointments cannot be created on small screen (as there they are displayed as a list below the dates).
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableAppointmentsCreate</code></returns>
				public extern virtual bool getEnableAppointmentsCreate();

				/// <summary>
				/// Sets a new value for property {@link #getEnableAppointmentsCreate enableAppointmentsCreate}.
				/// 
				/// Determines whether the appointments can be created by dragging on empty cells.
				/// 
				/// See {@link #property:enableAppointmentsResize enableAppointmentsResize} for the specific points for events snapping
				/// 
				/// <b>Notes:</b> In "One month" view, the appointments cannot be created on small screen (as there they are displayed as a list below the dates).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableAppointmentsCreate">New value for property <code>enableAppointmentsCreate</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow setEnableAppointmentsCreate(bool bEnableAppointmentsCreate);

				#endregion

				#region Methods for Aggregation appointments

				/// <summary>
				/// Gets content of aggregation {@link #getAppointments appointments}.
				/// 
				/// The appointments to be displayed in the row. Appointments that outside the visible time frame are not rendered.
				/// 
				/// <b>Note:</b> For performance reasons, only appointments in the visible time range or nearby should be assigned.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.unified.CalendarAppointment[] getAppointments();

				/// <summary>
				/// Destroys all the appointments in the aggregation {@link #getAppointments appointments}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow destroyAppointments();

				/// <summary>
				/// Inserts a appointment into the aggregation {@link #getAppointments appointments}.
				/// </summary>
				/// <param name="oAppointment">The appointment to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the appointment should be inserted at; for a negative value of <code>iIndex</code>, the appointment is inserted at position 0; for a value greater than the current size of the aggregation, the appointment is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow insertAppointment(sap.ui.unified.CalendarAppointment oAppointment, int iIndex);

				/// <summary>
				/// Adds some appointment to the aggregation {@link #getAppointments appointments}.
				/// </summary>
				/// <param name="oAppointment">The appointment to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow addAppointment(sap.ui.unified.CalendarAppointment oAppointment);

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
				/// The appointments to be displayed at the top of the intervals (for example, for public holidays). Appointments outside the visible time frame are not rendered.
				/// 
				/// Keep in mind that the <code>intervalHeaders</code> should always fill whole intervals. If they are shorter or longer than one interval, they are not displayed.
				/// 
				/// <b>Note:</b> For performance reasons, only appointments in the visible time range or nearby should be assigned.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.unified.CalendarAppointment[] getIntervalHeaders();

				/// <summary>
				/// Destroys all the intervalHeaders in the aggregation {@link #getIntervalHeaders intervalHeaders}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow destroyIntervalHeaders();

				/// <summary>
				/// Inserts a intervalHeader into the aggregation {@link #getIntervalHeaders intervalHeaders}.
				/// </summary>
				/// <param name="oIntervalHeader">The intervalHeader to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the intervalHeader should be inserted at; for a negative value of <code>iIndex</code>, the intervalHeader is inserted at position 0; for a value greater than the current size of the aggregation, the intervalHeader is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow insertIntervalHeader(sap.ui.unified.CalendarAppointment oIntervalHeader, int iIndex);

				/// <summary>
				/// Adds some intervalHeader to the aggregation {@link #getIntervalHeaders intervalHeaders}.
				/// </summary>
				/// <param name="oIntervalHeader">The intervalHeader to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow addIntervalHeader(sap.ui.unified.CalendarAppointment oIntervalHeader);

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

				#region Methods for Aggregation specialDates

				/// <summary>
				/// Gets content of aggregation {@link #getSpecialDates specialDates}.
				/// 
				/// Holds the special dates in the context of a row. A single date or a date range can be set.
				/// 
				/// <b>Note</> Only date or date ranges of type <code>sap.ui.unified.CalendarDayType.NonWorking</code> will be visualized in the <code>PlanningCalendarRow</code>. If the aggregation is set as another type, the date or date range will be ignored and will not be displayed in the control.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.unified.DateTypeRange[] getSpecialDates();

				/// <summary>
				/// Destroys all the specialDates in the aggregation {@link #getSpecialDates specialDates}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow destroySpecialDates();

				/// <summary>
				/// Inserts a specialDate into the aggregation {@link #getSpecialDates specialDates}.
				/// </summary>
				/// <param name="oSpecialDate">The specialDate to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the specialDate should be inserted at; for a negative value of <code>iIndex</code>, the specialDate is inserted at position 0; for a value greater than the current size of the aggregation, the specialDate is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow insertSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate, int iIndex);

				/// <summary>
				/// Adds some specialDate to the aggregation {@link #getSpecialDates specialDates}.
				/// </summary>
				/// <param name="oSpecialDate">The specialDate to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow addSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate);

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

				#region Methods for Aggregation _nonWorkingDates

				#endregion

				#region Methods for Event appointmentDrop

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentDrop appointmentDrop} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is dropped.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendarRow</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentDrop(object oData, sap.m.PlanningCalendarRow.AppointmentDropDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentDrop appointmentDrop} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is dropped.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentDrop(object oData, sap.m.PlanningCalendarRow.AppointmentDropDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentDrop appointmentDrop} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is dropped.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentDrop(sap.m.PlanningCalendarRow.AppointmentDropDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentDrop appointmentDrop} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is dropped.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendarRow</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentDrop(sap.m.PlanningCalendarRow.AppointmentDropDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:appointmentDrop appointmentDrop} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow detachAppointmentDrop(sap.m.PlanningCalendarRow.AppointmentDropDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:appointmentDrop appointmentDrop} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow fireAppointmentDrop(sap.m.PlanningCalendarRow.AppointmentDropInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:appointmentDrop appointmentDrop} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow fireAppointmentDrop();

				#endregion

				#region Methods for Event appointmentDragEnter

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentDragEnter appointmentDragEnter} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is dropped.
				/// 
				/// When this event handler is attached, the default behavior of the <code>enableAppointmentsDragAndDrop</code> property to move appointments only within their original calendar row is no longer valid. You can move the appointment around all rows for which <code>enableAppointmentsDragAndDrop</code> is set to true. In this case, the drop target area is indicated by a placeholder. In the event handler you can call the <code>preventDefault</code> method of the event to prevent this default behavior. In this case, the placeholder will no longer be available and it will not be possible to drop the appointment in the row.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendarRow</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentDragEnter(object oData, sap.m.PlanningCalendarRow.AppointmentDragEnterDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentDragEnter appointmentDragEnter} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is dropped.
				/// 
				/// When this event handler is attached, the default behavior of the <code>enableAppointmentsDragAndDrop</code> property to move appointments only within their original calendar row is no longer valid. You can move the appointment around all rows for which <code>enableAppointmentsDragAndDrop</code> is set to true. In this case, the drop target area is indicated by a placeholder. In the event handler you can call the <code>preventDefault</code> method of the event to prevent this default behavior. In this case, the placeholder will no longer be available and it will not be possible to drop the appointment in the row.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentDragEnter(object oData, sap.m.PlanningCalendarRow.AppointmentDragEnterDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentDragEnter appointmentDragEnter} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is dropped.
				/// 
				/// When this event handler is attached, the default behavior of the <code>enableAppointmentsDragAndDrop</code> property to move appointments only within their original calendar row is no longer valid. You can move the appointment around all rows for which <code>enableAppointmentsDragAndDrop</code> is set to true. In this case, the drop target area is indicated by a placeholder. In the event handler you can call the <code>preventDefault</code> method of the event to prevent this default behavior. In this case, the placeholder will no longer be available and it will not be possible to drop the appointment in the row.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentDragEnter(sap.m.PlanningCalendarRow.AppointmentDragEnterDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentDragEnter appointmentDragEnter} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is dropped.
				/// 
				/// When this event handler is attached, the default behavior of the <code>enableAppointmentsDragAndDrop</code> property to move appointments only within their original calendar row is no longer valid. You can move the appointment around all rows for which <code>enableAppointmentsDragAndDrop</code> is set to true. In this case, the drop target area is indicated by a placeholder. In the event handler you can call the <code>preventDefault</code> method of the event to prevent this default behavior. In this case, the placeholder will no longer be available and it will not be possible to drop the appointment in the row.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendarRow</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentDragEnter(sap.m.PlanningCalendarRow.AppointmentDragEnterDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:appointmentDragEnter appointmentDragEnter} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow detachAppointmentDragEnter(sap.m.PlanningCalendarRow.AppointmentDragEnterDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:appointmentDragEnter appointmentDragEnter} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireAppointmentDragEnter(sap.m.PlanningCalendarRow.AppointmentDragEnterInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:appointmentDragEnter appointmentDragEnter} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireAppointmentDragEnter();

				#endregion

				#region Methods for Event appointmentResize

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentResize appointmentResize} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is resized.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendarRow</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentResize(object oData, sap.m.PlanningCalendarRow.AppointmentResizeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentResize appointmentResize} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is resized.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentResize(object oData, sap.m.PlanningCalendarRow.AppointmentResizeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentResize appointmentResize} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is resized.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentResize(sap.m.PlanningCalendarRow.AppointmentResizeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentResize appointmentResize} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is resized.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendarRow</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentResize(sap.m.PlanningCalendarRow.AppointmentResizeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:appointmentResize appointmentResize} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow detachAppointmentResize(sap.m.PlanningCalendarRow.AppointmentResizeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:appointmentResize appointmentResize} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow fireAppointmentResize(sap.m.PlanningCalendarRow.AppointmentResizeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:appointmentResize appointmentResize} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow fireAppointmentResize();

				#endregion

				#region Methods for Event appointmentCreate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentCreate appointmentCreate} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is created.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendarRow</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentCreate(object oData, sap.m.PlanningCalendarRow.AppointmentCreateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentCreate appointmentCreate} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is created.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentCreate(object oData, sap.m.PlanningCalendarRow.AppointmentCreateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentCreate appointmentCreate} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is created.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentCreate(sap.m.PlanningCalendarRow.AppointmentCreateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentCreate appointmentCreate} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendarRow</code> itself.
				/// 
				/// Fired if an appointment is created.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendarRow</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow attachAppointmentCreate(sap.m.PlanningCalendarRow.AppointmentCreateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:appointmentCreate appointmentCreate} event of this <code>sap.m.PlanningCalendarRow</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow detachAppointmentCreate(sap.m.PlanningCalendarRow.AppointmentCreateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:appointmentCreate appointmentCreate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow fireAppointmentCreate(sap.m.PlanningCalendarRow.AppointmentCreateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:appointmentCreate appointmentCreate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarRow fireAppointmentCreate();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendarRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendarRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendarRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.PlanningCalendarRow.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
