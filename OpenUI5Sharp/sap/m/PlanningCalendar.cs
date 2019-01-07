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
			/// Displays rows with appointments for different entities (such as persons or teams) for the selected time interval.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// You can use the <code>PlanningCalendar</code> to represent a calendar containing multiple rows with appointments, where each row represents a different person.
			/// 
			/// You can configure different time-interval views that the user can switch between, such as hours or days, and even a whole week/month. The available navigation allows the user to select a specific interval using a picker, or move to the previous/next interval using arrows.
			/// 
			/// <b>Note:</b> The <code>PlanningCalendar</code> uses parts of the <code>sap.ui.unified</code> library. This library will be loaded after the <code>PlanningCalendar</code>, if it wasn't loaded first. This could lead to a waiting time when a <code>PlanningCalendar</code> is used for the first time. To prevent this, apps that use the <code>PlanningCalendar</code> should also load the <code>sap.ui.unified</code> library.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// The <code>PlanningCalendar</code> has the following structure from top to bottom:
			/// 
			/// <ul> <li>A toolbar where you can add your own buttons or other controls using the <code>toolbarContent</code> aggregation.</li> <li>A header containing a drop-down menu for selecting the {@link sap.m.PlanningCalendarView PlanningCalendarViews}, and navigation for moving through the intervals using arrows or selecting a specific interval with a picker. Custom views can be configured using the <code>views</code> aggregation. If not configured, the following set of default built-in views is available - Hours, Days, 1 Week, 1 Month, and Months. Setting a custom view(s) replaces the built-in ones.</li> <li>The rows of the <code>PlanningCalendar</code> that contain the assigned appointments. They can be configured with the <code>rows</code> aggregation, which is of type {@link sap.m.PlanningCalendarRow PlanningCalendarRow}.</li> </ul>
			/// 
			/// Since 1.48 the empty space in the cell that is below an appointment can be removed by adding the <code>sapUiCalendarAppFitVertically</code> CSS class to the <code>PlanningCalendar</code>. Please note that it should be used only for a <code>PlanningCalendar</code> with one appointment per day for a row that doesn't have interval headers set.
			/// 
			/// Since 1.44 alternating row colors can be suppressed by adding the <code>sapMPlanCalSuppressAlternatingRowColors</code> CSS class to the <code>PlanningCalendar</code>.
			/// 
			/// <h3>Responsive behavior</h3>
			/// 
			/// You can define the number of displayed intervals based on the size of the <code>PlanningCalendar</code> using the {@link sap.m.PlanningCalendarView PlanningCalendarView}'s properties.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.PlanningCalendar")]
			public partial class PlanningCalendar : sap.ui.core.Control
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
					/// Determines the start date of the row, as a JavaScript date object. The current date is used as default.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> startDate;

					/// <summary>
					/// Defines the key of the <code>PlanningCalendarView</code> used for the output.
					/// 
					/// <b>Note:</b> The default value is set <code>Hour</code>. If you are using your own views, the keys of these views should be used instead.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> viewKey;

					/// <summary>
					/// Determines whether only a single row can be selected.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> singleSelection;

					/// <summary>
					/// Specifies the width of the <code>PlanningCalendar</code>.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Specifies the height of the <code>PlanningCalendar</code>.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// Determines whether the assigned interval headers are displayed. You can assign them using the <code>intervalHeaders</code> aggregation of the {@link sap.m.PlanningCalendarRow PlanningCalendarRow}.
					/// 
					/// <b>Note:</b> If you set both <code>showIntervalHeaders</code> and <code>showEmptyIntervalHeaders</code> properties to <code>true</code>, the space (at the top of the intervals) where the assigned interval headers appear, will remain visible even if no interval headers are assigned.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showIntervalHeaders;

					/// <summary>
					/// Determines whether the space (at the top of the intervals), where the assigned interval headers appear, should remain visible even when no interval headers are present in the visible time frame. If set to <code>false</code>, this space would collapse/disappear when no interval headers are assigned.
					/// 
					/// <b>Note:</b> This property takes effect, only if <code>showIntervalHeaders</code> is also set to <code>true</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showEmptyIntervalHeaders;

					/// <summary>
					/// Determines whether the column containing the headers of the {@link sap.m.PlanningCalendarRow PlanningCalendarRows} is displayed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showRowHeaders;

					/// <summary>
					/// Defines the text that is displayed when no {@link sap.m.PlanningCalendarRow PlanningCalendarRows} are assigned.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> noDataText;

					/// <summary>
					/// Defines the mode in which the overlapping appointments are displayed.
					/// 
					/// <b>Note:</b> This property takes effect, only if the <code>intervalType</code> of the current calendar view is set to <code>sap.ui.unified.CalendarIntervalType.Month</code>. On phone devices this property is ignored, and the default value is applied.
					/// </summary>
					public Union<sap.ui.unified.GroupAppointmentsMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> groupAppointmentsMode;

					/// <summary>
					/// Determines whether the appointments that have only title without text are rendered with smaller height.
					/// 
					/// <b>Note:</b> On phone devices this property is ignored, appointments are always rendered in full height to facilitate touching.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> appointmentsReducedHeight;

					/// <summary>
					/// Determines how the appointments are visualized depending on the used theme.
					/// </summary>
					public Union<sap.ui.unified.CalendarAppointmentVisualization, string, sap.ui.@base.ManagedObject.BindPropertyInfo> appointmentsVisualization;

					/// <summary>
					/// Defines the minimum date that can be displayed and selected in the <code>PlanningCalendar</code>. This must be a JavaScript date object.
					/// 
					/// <b>Note:</b> If the <code>minDate</code> is set to be after the current <code>maxDate</code>, the <code>maxDate</code> is set to the last date of the month in which the <code>minDate</code> belongs.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minDate;

					/// <summary>
					/// Defines the maximum date that can be displayed and selected in the <code>PlanningCalendar</code>. This must be a JavaScript date object.
					/// 
					/// <b>Note:</b> If the <code>maxDate</code> is set to be before the current <code>minDate</code>, the <code>minDate</code> is set to the first date of the month in which the <code>maxDate</code> belongs.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxDate;

					/// <summary>
					/// Determines whether the day names are displayed in a separate line or inside the single days.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showDayNamesLine;

					/// <summary>
					/// Determines if the week numbers are displayed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showWeekNumbers;

					/// <summary>
					/// Defines the list of predefined views as an array. The views should be specified by their keys.
					/// 
					/// The default predefined views and their keys are available at {@link sap.m.PlanningCalendarBuiltInView}.
					/// 
					/// <b>Note:</b> If set, all specified views will be displayed along with any custom views (if available). If not set and no custom views are available, all default views will be displayed. If not set and there are any custom views available, only the custom views will be displayed.
					/// </summary>
					public Union<string[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> builtInViews;

					/// <summary>
					/// Determines whether the header area will remain visible (fixed on top) when the rest of the content is scrolled out of view.
					/// 
					/// The sticky header behavior is automatically disabled on phones in landscape mode for better visibility of the content.
					/// 
					/// <b>Note:</b> There is limited browser support, hence the API is in experimental state. Browsers that currently support this feature are Chrome (desktop and mobile), Safari (desktop and mobile) and Edge 41.
					/// 
					/// There are also some known issues with respect to the scrolling behavior and focus handling. A few are given below:
					/// 
					/// When the PlanningCalendar is placed in certain layout containers, for example the <code>GridLayout</code> control, the column headers do not fix at the top of the viewport. Similar behavior is also observed with the <code>ObjectPage</code> control.
					/// 
					/// This API should not be used in production environment.
					/// 
					/// <b>Note:</b> The <code>stickyHeader</code> of the <code>PlanningCalendar</code> uses the <code>sticky</code> property of <code>sap.m.Table</code>. Therefore, all features and limitations of the property in <code>sap.m.Table</code> apply to the <code>PlanningCalendar</code> as well.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> stickyHeader;

					/// <summary>
					/// Rows of the <code>PlanningCalendar</code>.
					/// </summary>
					public Union<sap.m.PlanningCalendarRow[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> rows;

					/// <summary>
					/// Views of the <code>PlanningCalendar</code>.
					/// 
					/// <b>Note:</b> If not set, all the default views are available. Their keys are defined in {@link sap.ui.unified.CalendarIntervalType}.
					/// </summary>
					public Union<sap.m.PlanningCalendarView[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> views;

					/// <summary>
					/// Special days in the header calendar visualized as date range with a type.
					/// 
					/// <b>Note:</b> If one day is assigned to more than one type, only the first type will be used.
					/// </summary>
					public Union<sap.ui.unified.DateTypeRange[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> specialDates;

					/// <summary>
					/// The content of the toolbar.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> toolbarContent;

					/// <summary>
					/// Association to controls / IDs which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Association to the <code>CalendarLegend</code> explaining the colors of the <code>Appointments</code>.
					/// 
					/// <b>Note:</b> The legend does not have to be rendered but must exist, and all required types must be assigned.
					/// </summary>
					public Union<sap.ui.unified.CalendarLegend, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> legend;

					/// <summary>
					/// Fired if an appointment is selected.
					/// </summary>
					public sap.m.CalendarSelectDelegate appointmentSelect;

					/// <summary>
					/// Fired if an interval was selected in the calendar header or in the row.
					/// </summary>
					public sap.m.PlanningCalendar.IntervalSelectDelegate intervalSelect;

					/// <summary>
					/// Fires when row selection is changed.
					/// </summary>
					public sap.m.PlanningCalendar.RowSelectionChangeDelegate rowSelectionChange;

					/// <summary>
					/// <code>startDate</code> was changed while navigating in the <code>PlanningCalendar</code>. The new value can be obtained using the <code>sap.m.PlanningCalendar#getStartDate()</code> method.
					/// </summary>
					public sap.ui.@base.EventDelegate startDateChange;

					/// <summary>
					/// <code>viewKey</code> was changed by user interaction.
					/// </summary>
					public sap.ui.@base.EventDelegate viewChange;

					/// <summary>
					/// Fires when a row header is clicked.
					/// </summary>
					public sap.ui.@base.EventDelegate rowHeaderClick;

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
					/// Start date of the selected interval, as a JavaScript date object.
					/// </summary>
					public object startDate;

					/// <summary>
					/// Interval end date as a JavaScript date object.
					/// </summary>
					public object endDate;

					/// <summary>
					/// If set, the selected interval is a subinterval.
					/// </summary>
					public bool subInterval;

					/// <summary>
					/// Row of the selected interval.
					/// </summary>
					public sap.m.PlanningCalendarRow row;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class RowSelectionChangeInfo
				{
					/// <summary>
					/// Array of rows whose selection has changed.
					/// </summary>
					public sap.m.PlanningCalendarRow[] rows;

				}

				#endregion

				#region Delegates

				public delegate void IntervalSelectDelegate(sap.ui.@base.Event<sap.m.PlanningCalendar.IntervalSelectInfo> oEvent, object oData);

				public delegate void RowSelectionChangeDelegate(sap.ui.@base.Event<sap.m.PlanningCalendar.RowSelectionChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>PlanningCalendar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sID">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern PlanningCalendar(string sID, sap.m.PlanningCalendar.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>PlanningCalendar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sID">ID for the new control, generated automatically if no ID is given</param>
				public extern PlanningCalendar(string sID);

				/// <summary>
				/// Constructor for a new <code>PlanningCalendar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern PlanningCalendar();

				/// <summary>
				/// Constructor for a new <code>PlanningCalendar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern PlanningCalendar(sap.m.PlanningCalendar.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property startDate

				/// <summary>
				/// Gets current value of property {@link #getStartDate startDate}.
				/// 
				/// Determines the start date of the row, as a JavaScript date object. The current date is used as default.
				/// </summary>
				/// <returns>Value of property <code>startDate</code></returns>
				public extern virtual object getStartDate();

				/// <summary>
				/// Sets the given date as start date. The current date is used as default. Depending on the current view the start date may be adjusted (for example, the week view shows always the first weekday of the same week as the given date).
				/// </summary>
				/// <param name="oStartDate">the date to set as <code>sap.m.PlanningCalendar</code> <code>startDate</code>. May be changed(adjusted) if property <code>startDate</code> is adjusted. See remark about week view above.</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setStartDate(DateTime oStartDate);

				#endregion

				#region Methods for Property viewKey

				/// <summary>
				/// Gets current value of property {@link #getViewKey viewKey}.
				/// 
				/// Defines the key of the <code>PlanningCalendarView</code> used for the output.
				/// 
				/// <b>Note:</b> The default value is set <code>Hour</code>. If you are using your own views, the keys of these views should be used instead.
				/// 
				/// Default value is <code>sap.ui.unified.CalendarIntervalType.Hour</code>.
				/// </summary>
				/// <returns>Value of property <code>viewKey</code></returns>
				public extern virtual string getViewKey();

				/// <summary>
				/// Sets a new value for property {@link #getViewKey viewKey}.
				/// 
				/// Defines the key of the <code>PlanningCalendarView</code> used for the output.
				/// 
				/// <b>Note:</b> The default value is set <code>Hour</code>. If you are using your own views, the keys of these views should be used instead.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>sap.ui.unified.CalendarIntervalType.Hour</code>.
				/// </summary>
				/// <param name="sViewKey">New value for property <code>viewKey</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setViewKey(string sViewKey);

				#endregion

				#region Methods for Property singleSelection

				/// <summary>
				/// Gets current value of property {@link #getSingleSelection singleSelection}.
				/// 
				/// Determines whether only a single row can be selected.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>singleSelection</code></returns>
				public extern virtual bool getSingleSelection();

				/// <summary>
				/// Sets a new value for property {@link #getSingleSelection singleSelection}.
				/// 
				/// Determines whether only a single row can be selected.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bSingleSelection">New value for property <code>singleSelection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setSingleSelection(bool bSingleSelection);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Specifies the width of the <code>PlanningCalendar</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Specifies the width of the <code>PlanningCalendar</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// Specifies the height of the <code>PlanningCalendar</code>.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// Specifies the height of the <code>PlanningCalendar</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property showIntervalHeaders

				/// <summary>
				/// Gets current value of property {@link #getShowIntervalHeaders showIntervalHeaders}.
				/// 
				/// Determines whether the assigned interval headers are displayed. You can assign them using the <code>intervalHeaders</code> aggregation of the {@link sap.m.PlanningCalendarRow PlanningCalendarRow}.
				/// 
				/// <b>Note:</b> If you set both <code>showIntervalHeaders</code> and <code>showEmptyIntervalHeaders</code> properties to <code>true</code>, the space (at the top of the intervals) where the assigned interval headers appear, will remain visible even if no interval headers are assigned.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showIntervalHeaders</code></returns>
				public extern virtual bool getShowIntervalHeaders();

				/// <summary>
				/// Sets a new value for property {@link #getShowIntervalHeaders showIntervalHeaders}.
				/// 
				/// Determines whether the assigned interval headers are displayed. You can assign them using the <code>intervalHeaders</code> aggregation of the {@link sap.m.PlanningCalendarRow PlanningCalendarRow}.
				/// 
				/// <b>Note:</b> If you set both <code>showIntervalHeaders</code> and <code>showEmptyIntervalHeaders</code> properties to <code>true</code>, the space (at the top of the intervals) where the assigned interval headers appear, will remain visible even if no interval headers are assigned.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowIntervalHeaders">New value for property <code>showIntervalHeaders</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setShowIntervalHeaders(bool bShowIntervalHeaders);

				#endregion

				#region Methods for Property showEmptyIntervalHeaders

				/// <summary>
				/// Gets current value of property {@link #getShowEmptyIntervalHeaders showEmptyIntervalHeaders}.
				/// 
				/// Determines whether the space (at the top of the intervals), where the assigned interval headers appear, should remain visible even when no interval headers are present in the visible time frame. If set to <code>false</code>, this space would collapse/disappear when no interval headers are assigned.
				/// 
				/// <b>Note:</b> This property takes effect, only if <code>showIntervalHeaders</code> is also set to <code>true</code>.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showEmptyIntervalHeaders</code></returns>
				public extern virtual bool getShowEmptyIntervalHeaders();

				/// <summary>
				/// Sets a new value for property {@link #getShowEmptyIntervalHeaders showEmptyIntervalHeaders}.
				/// 
				/// Determines whether the space (at the top of the intervals), where the assigned interval headers appear, should remain visible even when no interval headers are present in the visible time frame. If set to <code>false</code>, this space would collapse/disappear when no interval headers are assigned.
				/// 
				/// <b>Note:</b> This property takes effect, only if <code>showIntervalHeaders</code> is also set to <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowEmptyIntervalHeaders">New value for property <code>showEmptyIntervalHeaders</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setShowEmptyIntervalHeaders(bool bShowEmptyIntervalHeaders);

				#endregion

				#region Methods for Property showRowHeaders

				/// <summary>
				/// Gets current value of property {@link #getShowRowHeaders showRowHeaders}.
				/// 
				/// Determines whether the column containing the headers of the {@link sap.m.PlanningCalendarRow PlanningCalendarRows} is displayed.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showRowHeaders</code></returns>
				public extern virtual bool getShowRowHeaders();

				/// <summary>
				/// Sets a new value for property {@link #getShowRowHeaders showRowHeaders}.
				/// 
				/// Determines whether the column containing the headers of the {@link sap.m.PlanningCalendarRow PlanningCalendarRows} is displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowRowHeaders">New value for property <code>showRowHeaders</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setShowRowHeaders(bool bShowRowHeaders);

				#endregion

				#region Methods for Property noDataText

				/// <summary>
				/// Gets current value of property {@link #getNoDataText noDataText}.
				/// 
				/// Defines the text that is displayed when no {@link sap.m.PlanningCalendarRow PlanningCalendarRows} are assigned.
				/// </summary>
				/// <returns>Value of property <code>noDataText</code></returns>
				public extern virtual string getNoDataText();

				/// <summary>
				/// Sets a new value for property {@link #getNoDataText noDataText}.
				/// 
				/// Defines the text that is displayed when no {@link sap.m.PlanningCalendarRow PlanningCalendarRows} are assigned.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sNoDataText">New value for property <code>noDataText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setNoDataText(string sNoDataText);

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
				public extern virtual sap.m.PlanningCalendar setGroupAppointmentsMode(sap.ui.unified.GroupAppointmentsMode sGroupAppointmentsMode);

				#endregion

				#region Methods for Property appointmentsReducedHeight

				/// <summary>
				/// Gets current value of property {@link #getAppointmentsReducedHeight appointmentsReducedHeight}.
				/// 
				/// Determines whether the appointments that have only title without text are rendered with smaller height.
				/// 
				/// <b>Note:</b> On phone devices this property is ignored, appointments are always rendered in full height to facilitate touching.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>appointmentsReducedHeight</code></returns>
				public extern virtual bool getAppointmentsReducedHeight();

				/// <summary>
				/// Sets a new value for property {@link #getAppointmentsReducedHeight appointmentsReducedHeight}.
				/// 
				/// Determines whether the appointments that have only title without text are rendered with smaller height.
				/// 
				/// <b>Note:</b> On phone devices this property is ignored, appointments are always rendered in full height to facilitate touching.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bAppointmentsReducedHeight">New value for property <code>appointmentsReducedHeight</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setAppointmentsReducedHeight(bool bAppointmentsReducedHeight);

				#endregion

				#region Methods for Property appointmentsVisualization

				/// <summary>
				/// Gets current value of property {@link #getAppointmentsVisualization appointmentsVisualization}.
				/// 
				/// Determines how the appointments are visualized depending on the used theme.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <returns>Value of property <code>appointmentsVisualization</code></returns>
				public extern virtual sap.ui.unified.CalendarAppointmentVisualization getAppointmentsVisualization();

				/// <summary>
				/// Sets a new value for property {@link #getAppointmentsVisualization appointmentsVisualization}.
				/// 
				/// Determines how the appointments are visualized depending on the used theme.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <param name="sAppointmentsVisualization">New value for property <code>appointmentsVisualization</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setAppointmentsVisualization(sap.ui.unified.CalendarAppointmentVisualization sAppointmentsVisualization);

				#endregion

				#region Methods for Property minDate

				/// <summary>
				/// Gets current value of property {@link #getMinDate minDate}.
				/// 
				/// Defines the minimum date that can be displayed and selected in the <code>PlanningCalendar</code>. This must be a JavaScript date object.
				/// 
				/// <b>Note:</b> If the <code>minDate</code> is set to be after the current <code>maxDate</code>, the <code>maxDate</code> is set to the last date of the month in which the <code>minDate</code> belongs.
				/// </summary>
				/// <returns>Value of property <code>minDate</code></returns>
				public extern virtual object getMinDate();

				/// <summary>
				/// Sets a new value for property {@link #getMinDate minDate}.
				/// 
				/// Defines the minimum date that can be displayed and selected in the <code>PlanningCalendar</code>. This must be a JavaScript date object.
				/// 
				/// <b>Note:</b> If the <code>minDate</code> is set to be after the current <code>maxDate</code>, the <code>maxDate</code> is set to the last date of the month in which the <code>minDate</code> belongs.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oMinDate">New value for property <code>minDate</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setMinDate(object oMinDate);

				#endregion

				#region Methods for Property maxDate

				/// <summary>
				/// Gets current value of property {@link #getMaxDate maxDate}.
				/// 
				/// Defines the maximum date that can be displayed and selected in the <code>PlanningCalendar</code>. This must be a JavaScript date object.
				/// 
				/// <b>Note:</b> If the <code>maxDate</code> is set to be before the current <code>minDate</code>, the <code>minDate</code> is set to the first date of the month in which the <code>maxDate</code> belongs.
				/// </summary>
				/// <returns>Value of property <code>maxDate</code></returns>
				public extern virtual object getMaxDate();

				/// <summary>
				/// Sets a new value for property {@link #getMaxDate maxDate}.
				/// 
				/// Defines the maximum date that can be displayed and selected in the <code>PlanningCalendar</code>. This must be a JavaScript date object.
				/// 
				/// <b>Note:</b> If the <code>maxDate</code> is set to be before the current <code>minDate</code>, the <code>minDate</code> is set to the first date of the month in which the <code>maxDate</code> belongs.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oMaxDate">New value for property <code>maxDate</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setMaxDate(object oMaxDate);

				#endregion

				#region Methods for Property showDayNamesLine

				/// <summary>
				/// Gets current value of property {@link #getShowDayNamesLine showDayNamesLine}.
				/// 
				/// Determines whether the day names are displayed in a separate line or inside the single days.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showDayNamesLine</code></returns>
				public extern virtual bool getShowDayNamesLine();

				/// <summary>
				/// Sets a new value for property {@link #getShowDayNamesLine showDayNamesLine}.
				/// 
				/// Determines whether the day names are displayed in a separate line or inside the single days.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowDayNamesLine">New value for property <code>showDayNamesLine</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setShowDayNamesLine(bool bShowDayNamesLine);

				#endregion

				#region Methods for Property showWeekNumbers

				/// <summary>
				/// Gets current value of property {@link #getShowWeekNumbers showWeekNumbers}.
				/// 
				/// Determines if the week numbers are displayed.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showWeekNumbers</code></returns>
				public extern virtual bool getShowWeekNumbers();

				/// <summary>
				/// Sets a new value for property {@link #getShowWeekNumbers showWeekNumbers}.
				/// 
				/// Determines if the week numbers are displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowWeekNumbers">New value for property <code>showWeekNumbers</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setShowWeekNumbers(bool bShowWeekNumbers);

				#endregion

				#region Methods for Property builtInViews

				/// <summary>
				/// Gets current value of property {@link #getBuiltInViews builtInViews}.
				/// 
				/// Defines the list of predefined views as an array. The views should be specified by their keys.
				/// 
				/// The default predefined views and their keys are available at {@link sap.m.PlanningCalendarBuiltInView}.
				/// 
				/// <b>Note:</b> If set, all specified views will be displayed along with any custom views (if available). If not set and no custom views are available, all default views will be displayed. If not set and there are any custom views available, only the custom views will be displayed.
				/// 
				/// Default value is <code>[]</code>.
				/// </summary>
				/// <returns>Value of property <code>builtInViews</code></returns>
				public extern virtual string[] getBuiltInViews();

				/// <summary>
				/// Sets a new value for property {@link #getBuiltInViews builtInViews}.
				/// 
				/// Defines the list of predefined views as an array. The views should be specified by their keys.
				/// 
				/// The default predefined views and their keys are available at {@link sap.m.PlanningCalendarBuiltInView}.
				/// 
				/// <b>Note:</b> If set, all specified views will be displayed along with any custom views (if available). If not set and no custom views are available, all default views will be displayed. If not set and there are any custom views available, only the custom views will be displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>[]</code>.
				/// </summary>
				/// <param name="sBuiltInViews">New value for property <code>builtInViews</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setBuiltInViews(string[] sBuiltInViews);

				/// <summary>
				/// Sets a new value for property {@link #getBuiltInViews builtInViews}.
				/// 
				/// Defines the list of predefined views as an array. The views should be specified by their keys.
				/// 
				/// The default predefined views and their keys are available at {@link sap.m.PlanningCalendarBuiltInView}.
				/// 
				/// <b>Note:</b> If set, all specified views will be displayed along with any custom views (if available). If not set and no custom views are available, all default views will be displayed. If not set and there are any custom views available, only the custom views will be displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>[]</code>.
				/// </summary>
				/// <param name="sBuiltInViews">New value for property <code>builtInViews</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar setBuiltInViews(object[] sBuiltInViews);

				#endregion

				#region Methods for Property stickyHeader

				/// <summary>
				/// Gets current value of property {@link #getStickyHeader stickyHeader}.
				/// 
				/// Determines whether the header area will remain visible (fixed on top) when the rest of the content is scrolled out of view.
				/// 
				/// The sticky header behavior is automatically disabled on phones in landscape mode for better visibility of the content.
				/// 
				/// <b>Note:</b> There is limited browser support, hence the API is in experimental state. Browsers that currently support this feature are Chrome (desktop and mobile), Safari (desktop and mobile) and Edge 41.
				/// 
				/// There are also some known issues with respect to the scrolling behavior and focus handling. A few are given below:
				/// 
				/// When the PlanningCalendar is placed in certain layout containers, for example the <code>GridLayout</code> control, the column headers do not fix at the top of the viewport. Similar behavior is also observed with the <code>ObjectPage</code> control.
				/// 
				/// This API should not be used in production environment.
				/// 
				/// <b>Note:</b> The <code>stickyHeader</code> of the <code>PlanningCalendar</code> uses the <code>sticky</code> property of <code>sap.m.Table</code>. Therefore, all features and limitations of the property in <code>sap.m.Table</code> apply to the <code>PlanningCalendar</code> as well.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>stickyHeader</code></returns>
				public extern virtual bool getStickyHeader();

				/// <summary>
				/// Sets the stickyHeader property.
				/// </summary>
				/// <param name="bStick">Whether the header area will remain visible (fixed on top)</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.PlanningCalendar setStickyHeader(bool bStick);

				#endregion

				#region Methods for Aggregation rows

				/// <summary>
				/// Gets content of aggregation {@link #getRows rows}.
				/// 
				/// Rows of the <code>PlanningCalendar</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.PlanningCalendarRow[] getRows();

				/// <summary>
				/// Destroys all the rows in the aggregation {@link #getRows rows}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar destroyRows();

				/// <summary>
				/// Inserts a row into the aggregation {@link #getRows rows}.
				/// </summary>
				/// <param name="oRow">The row to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the row should be inserted at; for a negative value of <code>iIndex</code>, the row is inserted at position 0; for a value greater than the current size of the aggregation, the row is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar insertRow(sap.m.PlanningCalendarRow oRow, int iIndex);

				/// <summary>
				/// Adds some row to the aggregation {@link #getRows rows}.
				/// </summary>
				/// <param name="oRow">The row to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar addRow(sap.m.PlanningCalendarRow oRow);

				/// <summary>
				/// Removes a row from the aggregation {@link #getRows rows}.
				/// </summary>
				/// <param name="vRow">The row to remove or its index or id</param>
				/// <returns>The removed row or <code>null</code></returns>
				public extern virtual sap.m.PlanningCalendarRow removeRow(Union<int, string, sap.m.PlanningCalendarRow> vRow);

				/// <summary>
				/// Checks for the provided <code>sap.m.PlanningCalendarRow</code> in the aggregation {@link #getRows rows}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oRow">The row whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfRow(sap.m.PlanningCalendarRow oRow);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getRows rows}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.PlanningCalendarRow[] removeAllRows();

				#endregion

				#region Methods for Aggregation views

				/// <summary>
				/// Gets content of aggregation {@link #getViews views}.
				/// 
				/// Views of the <code>PlanningCalendar</code>.
				/// 
				/// <b>Note:</b> If not set, all the default views are available. Their keys are defined in {@link sap.ui.unified.CalendarIntervalType}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.PlanningCalendarView[] getViews();

				/// <summary>
				/// Destroys all the views in the aggregation {@link #getViews views}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar destroyViews();

				/// <summary>
				/// Inserts a view into the aggregation {@link #getViews views}.
				/// </summary>
				/// <param name="oView">The view to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the view should be inserted at; for a negative value of <code>iIndex</code>, the view is inserted at position 0; for a value greater than the current size of the aggregation, the view is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar insertView(sap.m.PlanningCalendarView oView, int iIndex);

				/// <summary>
				/// Adds some view to the aggregation {@link #getViews views}.
				/// </summary>
				/// <param name="oView">The view to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar addView(sap.m.PlanningCalendarView oView);

				/// <summary>
				/// Removes a view from the aggregation {@link #getViews views}.
				/// </summary>
				/// <param name="vView">The view to remove or its index or id</param>
				/// <returns>The removed view or <code>null</code></returns>
				public extern virtual sap.m.PlanningCalendarView removeView(Union<int, string, sap.m.PlanningCalendarView> vView);

				/// <summary>
				/// Checks for the provided <code>sap.m.PlanningCalendarView</code> in the aggregation {@link #getViews views}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oView">The view whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfView(sap.m.PlanningCalendarView oView);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getViews views}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.PlanningCalendarView[] removeAllViews();

				#endregion

				#region Methods for Aggregation specialDates

				/// <summary>
				/// Gets content of aggregation {@link #getSpecialDates specialDates}.
				/// 
				/// Special days in the header calendar visualized as date range with a type.
				/// 
				/// <b>Note:</b> If one day is assigned to more than one type, only the first type will be used.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.unified.DateTypeRange[] getSpecialDates();

				/// <summary>
				/// Destroys all the specialDates in the aggregation {@link #getSpecialDates specialDates}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar destroySpecialDates();

				/// <summary>
				/// Inserts a specialDate into the aggregation {@link #getSpecialDates specialDates}.
				/// </summary>
				/// <param name="oSpecialDate">The specialDate to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the specialDate should be inserted at; for a negative value of <code>iIndex</code>, the specialDate is inserted at position 0; for a value greater than the current size of the aggregation, the specialDate is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar insertSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate, int iIndex);

				/// <summary>
				/// Adds some specialDate to the aggregation {@link #getSpecialDates specialDates}.
				/// </summary>
				/// <param name="oSpecialDate">The specialDate to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar addSpecialDate(sap.ui.unified.DateTypeRange oSpecialDate);

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

				#region Methods for Aggregation toolbarContent

				/// <summary>
				/// Gets content of aggregation {@link #getToolbarContent toolbarContent}.
				/// 
				/// The content of the toolbar.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getToolbarContent();

				/// <summary>
				/// Destroys all the toolbarContent in the aggregation {@link #getToolbarContent toolbarContent}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar destroyToolbarContent();

				/// <summary>
				/// Inserts a toolbarContent into the aggregation {@link #getToolbarContent toolbarContent}.
				/// </summary>
				/// <param name="oToolbarContent">The toolbarContent to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the toolbarContent should be inserted at; for a negative value of <code>iIndex</code>, the toolbarContent is inserted at position 0; for a value greater than the current size of the aggregation, the toolbarContent is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar insertToolbarContent(sap.ui.core.Control oToolbarContent, int iIndex);

				/// <summary>
				/// Adds some toolbarContent to the aggregation {@link #getToolbarContent toolbarContent}.
				/// </summary>
				/// <param name="oToolbarContent">The toolbarContent to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar addToolbarContent(sap.ui.core.Control oToolbarContent);

				/// <summary>
				/// Removes a toolbarContent from the aggregation {@link #getToolbarContent toolbarContent}.
				/// </summary>
				/// <param name="vToolbarContent">The toolbarContent to remove or its index or id</param>
				/// <returns>The removed toolbarContent or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeToolbarContent(Union<int, string, sap.ui.core.Control> vToolbarContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getToolbarContent toolbarContent}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oToolbarContent">The toolbarContent whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfToolbarContent(sap.ui.core.Control oToolbarContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getToolbarContent toolbarContent}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllToolbarContent();

				#endregion

				#region Methods for Aggregation table

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
				public extern virtual sap.m.PlanningCalendar addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				public extern virtual sap.m.PlanningCalendar setLegend(Union<sap.ui.core.ID, sap.ui.unified.CalendarLegend> oLegend);

				#endregion

				#region Methods for Event appointmentSelect

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentSelect appointmentSelect} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fired if an appointment is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachAppointmentSelect(object oData, sap.m.CalendarSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentSelect appointmentSelect} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fired if an appointment is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachAppointmentSelect(object oData, sap.m.CalendarSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentSelect appointmentSelect} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fired if an appointment is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachAppointmentSelect(sap.m.CalendarSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:appointmentSelect appointmentSelect} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fired if an appointment is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachAppointmentSelect(sap.m.CalendarSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:appointmentSelect appointmentSelect} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar detachAppointmentSelect(sap.m.CalendarSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:appointmentSelect appointmentSelect} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireAppointmentSelect(sap.m.CalendarSelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:appointmentSelect appointmentSelect} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireAppointmentSelect();

				#endregion

				#region Methods for Event intervalSelect

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:intervalSelect intervalSelect} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fired if an interval was selected in the calendar header or in the row.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachIntervalSelect(object oData, sap.m.PlanningCalendar.IntervalSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:intervalSelect intervalSelect} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fired if an interval was selected in the calendar header or in the row.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachIntervalSelect(object oData, sap.m.PlanningCalendar.IntervalSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:intervalSelect intervalSelect} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fired if an interval was selected in the calendar header or in the row.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachIntervalSelect(sap.m.PlanningCalendar.IntervalSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:intervalSelect intervalSelect} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fired if an interval was selected in the calendar header or in the row.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachIntervalSelect(sap.m.PlanningCalendar.IntervalSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:intervalSelect intervalSelect} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar detachIntervalSelect(sap.m.PlanningCalendar.IntervalSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:intervalSelect intervalSelect} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireIntervalSelect(sap.m.PlanningCalendar.IntervalSelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:intervalSelect intervalSelect} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireIntervalSelect();

				#endregion

				#region Methods for Event rowSelectionChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowSelectionChange rowSelectionChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fires when row selection is changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachRowSelectionChange(object oData, sap.m.PlanningCalendar.RowSelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowSelectionChange rowSelectionChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fires when row selection is changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachRowSelectionChange(object oData, sap.m.PlanningCalendar.RowSelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowSelectionChange rowSelectionChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fires when row selection is changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachRowSelectionChange(sap.m.PlanningCalendar.RowSelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowSelectionChange rowSelectionChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fires when row selection is changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachRowSelectionChange(sap.m.PlanningCalendar.RowSelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:rowSelectionChange rowSelectionChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar detachRowSelectionChange(sap.m.PlanningCalendar.RowSelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:rowSelectionChange rowSelectionChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireRowSelectionChange(sap.m.PlanningCalendar.RowSelectionChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:rowSelectionChange rowSelectionChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireRowSelectionChange();

				#endregion

				#region Methods for Event startDateChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// <code>startDate</code> was changed while navigating in the <code>PlanningCalendar</code>. The new value can be obtained using the <code>sap.m.PlanningCalendar#getStartDate()</code> method.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachStartDateChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// <code>startDate</code> was changed while navigating in the <code>PlanningCalendar</code>. The new value can be obtained using the <code>sap.m.PlanningCalendar#getStartDate()</code> method.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachStartDateChange(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// <code>startDate</code> was changed while navigating in the <code>PlanningCalendar</code>. The new value can be obtained using the <code>sap.m.PlanningCalendar#getStartDate()</code> method.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachStartDateChange(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:startDateChange startDateChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// <code>startDate</code> was changed while navigating in the <code>PlanningCalendar</code>. The new value can be obtained using the <code>sap.m.PlanningCalendar#getStartDate()</code> method.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachStartDateChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:startDateChange startDateChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar detachStartDateChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:startDateChange startDateChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireStartDateChange(object mParameters);

				/// <summary>
				/// Fires event {@link #event:startDateChange startDateChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireStartDateChange();

				#endregion

				#region Methods for Event viewChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:viewChange viewChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// <code>viewKey</code> was changed by user interaction.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachViewChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:viewChange viewChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// <code>viewKey</code> was changed by user interaction.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachViewChange(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:viewChange viewChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// <code>viewKey</code> was changed by user interaction.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachViewChange(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:viewChange viewChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// <code>viewKey</code> was changed by user interaction.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachViewChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:viewChange viewChange} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar detachViewChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:viewChange viewChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireViewChange(object mParameters);

				/// <summary>
				/// Fires event {@link #event:viewChange viewChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireViewChange();

				#endregion

				#region Methods for Event rowHeaderClick

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowHeaderClick rowHeaderClick} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fires when a row header is clicked.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachRowHeaderClick(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowHeaderClick rowHeaderClick} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fires when a row header is clicked.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachRowHeaderClick(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowHeaderClick rowHeaderClick} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fires when a row header is clicked.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachRowHeaderClick(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowHeaderClick rowHeaderClick} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PlanningCalendar</code> itself.
				/// 
				/// Fires when a row header is clicked.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PlanningCalendar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar attachRowHeaderClick(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:rowHeaderClick rowHeaderClick} event of this <code>sap.m.PlanningCalendar</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar detachRowHeaderClick(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:rowHeaderClick rowHeaderClick} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireRowHeaderClick(object mParameters);

				/// <summary>
				/// Fires event {@link #event:rowHeaderClick rowHeaderClick} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar fireRowHeaderClick();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Getter for custom appointments sorter (if any).
				/// </summary>
				/// <returns></returns>
				public extern virtual object getCustomAppointmentsSorterCallback();

				/// <summary>
				/// Returns a metadata object for class sap.m.PlanningCalendar.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Holds the selected appointments. If no appointments are selected, an empty array is returned.
				/// </summary>
				/// <returns>Array of IDs of selected appointments</returns>
				public extern virtual sap.ui.unified.CalendarAppointment[] getSelectedAppointments();

				/// <summary>
				/// Returns an array containing the selected rows. If no row is selected, an empty array is returned.
				/// </summary>
				/// <returns>selected rows</returns>
				public extern virtual sap.m.PlanningCalendarRow[] getSelectedRows();

				/// <summary>
				/// Selects or deselects all <code>PlanningCalendarRows</code>.
				/// 
				/// <b>Note:</b> Selection only works if <code>singleSelection</code> is set to <code>false</code>.
				/// </summary>
				/// <param name="bSelect">Indicator showing whether <code>PlanningCalendarRows</code> should be selected or deselected</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendar selectAllRows(bool bSelect);

				/// <summary>
				/// Setter for custom sorting of appointments. If not used, the appointments will be sorted according to their duration vertically. For example, the start time and order to the X axis won't change.
				/// </summary>
				/// <param name="fnSorter"></param>
				/// <returns><code>this</code> for chaining</returns>
				public extern virtual sap.m.PlanningCalendar setCustomAppointmentsSorterCallback(object fnSorter);

				#endregion

				#endregion

			}
		}
	}
}
