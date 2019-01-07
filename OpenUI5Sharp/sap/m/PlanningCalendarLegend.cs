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
			/// A legend for the {@link sap.m.PlanningCalendar} that displays the special dates and appointments in colors with their corresponding description. The <code>PlanningCalendarLegend</code> extends {@link sap.ui.unified.CalendarLegend} and overwrites the default value for property <code>columnWidth</code> to <code>auto</code>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.PlanningCalendarLegend")]
			public partial class PlanningCalendarLegend : sap.ui.unified.CalendarLegend
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.unified.CalendarLegend.Settings
				{
					/// <summary>
					/// Defines the text displayed in the header of the items list. It is commonly related to the calendar days.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> itemsHeader;

					/// <summary>
					/// Defines the text displayed in the header of the appointment items list. It is commonly related to the calendar appointments.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> appointmentItemsHeader;

					/// <summary>
					/// The legend items which show color and type information about the calendar appointments.
					/// </summary>
					public Union<sap.ui.unified.CalendarLegendItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> appointmentItems;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarLegend</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern PlanningCalendarLegend(string sId, sap.m.PlanningCalendarLegend.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarLegend</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern PlanningCalendarLegend(string sId);

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarLegend</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern PlanningCalendarLegend();

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarLegend</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern PlanningCalendarLegend(sap.m.PlanningCalendarLegend.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property itemsHeader

				/// <summary>
				/// Gets current value of property {@link #getItemsHeader itemsHeader}.
				/// 
				/// Defines the text displayed in the header of the items list. It is commonly related to the calendar days.
				/// 
				/// Default value is <code>Calendar</code>.
				/// </summary>
				/// <returns>Value of property <code>itemsHeader</code></returns>
				public extern virtual string getItemsHeader();

				/// <summary>
				/// Sets a new value for property {@link #getItemsHeader itemsHeader}.
				/// 
				/// Defines the text displayed in the header of the items list. It is commonly related to the calendar days.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Calendar</code>.
				/// </summary>
				/// <param name="sItemsHeader">New value for property <code>itemsHeader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarLegend setItemsHeader(string sItemsHeader);

				#endregion

				#region Methods for Property appointmentItemsHeader

				/// <summary>
				/// Gets current value of property {@link #getAppointmentItemsHeader appointmentItemsHeader}.
				/// 
				/// Defines the text displayed in the header of the appointment items list. It is commonly related to the calendar appointments.
				/// 
				/// Default value is <code>Appointments</code>.
				/// </summary>
				/// <returns>Value of property <code>appointmentItemsHeader</code></returns>
				public extern virtual string getAppointmentItemsHeader();

				/// <summary>
				/// Sets a new value for property {@link #getAppointmentItemsHeader appointmentItemsHeader}.
				/// 
				/// Defines the text displayed in the header of the appointment items list. It is commonly related to the calendar appointments.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Appointments</code>.
				/// </summary>
				/// <param name="sAppointmentItemsHeader">New value for property <code>appointmentItemsHeader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarLegend setAppointmentItemsHeader(string sAppointmentItemsHeader);

				#endregion

				#region Methods for Aggregation appointmentItems

				/// <summary>
				/// Gets content of aggregation {@link #getAppointmentItems appointmentItems}.
				/// 
				/// The legend items which show color and type information about the calendar appointments.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.unified.CalendarLegendItem[] getAppointmentItems();

				/// <summary>
				/// Destroys all the appointmentItems in the aggregation {@link #getAppointmentItems appointmentItems}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarLegend destroyAppointmentItems();

				/// <summary>
				/// Inserts a appointmentItem into the aggregation {@link #getAppointmentItems appointmentItems}.
				/// </summary>
				/// <param name="oAppointmentItem">The appointmentItem to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the appointmentItem should be inserted at; for a negative value of <code>iIndex</code>, the appointmentItem is inserted at position 0; for a value greater than the current size of the aggregation, the appointmentItem is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarLegend insertAppointmentItem(sap.ui.unified.CalendarLegendItem oAppointmentItem, int iIndex);

				/// <summary>
				/// Adds some appointmentItem to the aggregation {@link #getAppointmentItems appointmentItems}.
				/// </summary>
				/// <param name="oAppointmentItem">The appointmentItem to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarLegend addAppointmentItem(sap.ui.unified.CalendarLegendItem oAppointmentItem);

				/// <summary>
				/// Removes a appointmentItem from the aggregation {@link #getAppointmentItems appointmentItems}.
				/// </summary>
				/// <param name="vAppointmentItem">The appointmentItem to remove or its index or id</param>
				/// <returns>The removed appointmentItem or <code>null</code></returns>
				public extern virtual sap.ui.unified.CalendarLegendItem removeAppointmentItem(Union<int, string, sap.ui.unified.CalendarLegendItem> vAppointmentItem);

				/// <summary>
				/// Checks for the provided <code>sap.ui.unified.CalendarLegendItem</code> in the aggregation {@link #getAppointmentItems appointmentItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oAppointmentItem">The appointmentItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfAppointmentItem(sap.ui.unified.CalendarLegendItem oAppointmentItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getAppointmentItems appointmentItems}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.unified.CalendarLegendItem[] removeAllAppointmentItems();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendarLegend with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.CalendarLegend.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendarLegend with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.CalendarLegend.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendarLegend with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.CalendarLegend.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.PlanningCalendarLegend.
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
