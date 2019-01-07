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
			/// View of the {@link sap.m.PlanningCalendar}.
			/// 
			/// The <code>PlanningCalendarView</code> defines the type of the intervals (hours, days, months) and how many intervals are displayed.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.PlanningCalendarView")]
			public partial class PlanningCalendarView : sap.ui.core.Element
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
					/// Defines the key of the view. This must be set to identify the used view in the {@link sap.m.PlanningCalendar}.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> key;

					/// <summary>
					/// Determines the type of the intervals of the row.
					/// 
					/// <b>Note:</b> Not all predefined interval types are supported for this property. For more information, see the descriptions in the {@link sap.ui.unified.CalendarIntervalType CalendarIntervalType} enumeration.
					/// </summary>
					public Union<sap.ui.unified.CalendarIntervalType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> intervalType;

					/// <summary>
					/// Defines the description of the <code>PlanningCalendarView</code>.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> description;

					/// <summary>
					/// Defines the number of intervals that are displayed for a {@link sap.m.PlanningCalendar} that is less than 600 pixels wide.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> intervalsS;

					/// <summary>
					/// Defines the number of intervals that are displayed for a {@link sap.m.PlanningCalendar} that is between 600 and 1024 pixels wide.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> intervalsM;

					/// <summary>
					/// Defines the number of intervals that are displayed for a {@link sap.m.PlanningCalendar} that is more than 1024 pixels wide.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> intervalsL;

					/// <summary>
					/// If set, subintervals are displayed as lines in the rows.
					/// 
					/// <ul> <li>Quarter hour subintervals for interval type <code>Hour</code>.</li> <li>Hour subintervals for interval types <code>Day</code>, <code>Week</code> and <code>OneMonth</code>.</li> <li>Day subintervals for interval type <code>Month</code>.</li> </ul>
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSubIntervals;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarView</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern PlanningCalendarView(string sId, sap.m.PlanningCalendarView.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarView</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern PlanningCalendarView(string sId);

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarView</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern PlanningCalendarView();

				/// <summary>
				/// Constructor for a new <code>PlanningCalendarView</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern PlanningCalendarView(sap.m.PlanningCalendarView.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property key

				/// <summary>
				/// Gets current value of property {@link #getKey key}.
				/// 
				/// Defines the key of the view. This must be set to identify the used view in the {@link sap.m.PlanningCalendar}.
				/// </summary>
				/// <returns>Value of property <code>key</code></returns>
				public extern virtual string getKey();

				/// <summary>
				/// Sets a new value for property {@link #getKey key}.
				/// 
				/// Defines the key of the view. This must be set to identify the used view in the {@link sap.m.PlanningCalendar}.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sKey">New value for property <code>key</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarView setKey(string sKey);

				#endregion

				#region Methods for Property intervalType

				/// <summary>
				/// Gets current value of property {@link #getIntervalType intervalType}.
				/// 
				/// Determines the type of the intervals of the row.
				/// 
				/// <b>Note:</b> Not all predefined interval types are supported for this property. For more information, see the descriptions in the {@link sap.ui.unified.CalendarIntervalType CalendarIntervalType} enumeration.
				/// 
				/// Default value is <code>Hour</code>.
				/// </summary>
				/// <returns>Value of property <code>intervalType</code></returns>
				public extern virtual sap.ui.unified.CalendarIntervalType getIntervalType();

				/// <summary>
				/// Sets a new value for property {@link #getIntervalType intervalType}.
				/// 
				/// Determines the type of the intervals of the row.
				/// 
				/// <b>Note:</b> Not all predefined interval types are supported for this property. For more information, see the descriptions in the {@link sap.ui.unified.CalendarIntervalType CalendarIntervalType} enumeration.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Hour</code>.
				/// </summary>
				/// <param name="sIntervalType">New value for property <code>intervalType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarView setIntervalType(sap.ui.unified.CalendarIntervalType sIntervalType);

				#endregion

				#region Methods for Property description

				/// <summary>
				/// Gets current value of property {@link #getDescription description}.
				/// 
				/// Defines the description of the <code>PlanningCalendarView</code>.
				/// </summary>
				/// <returns>Value of property <code>description</code></returns>
				public extern virtual string getDescription();

				/// <summary>
				/// Sets a new value for property {@link #getDescription description}.
				/// 
				/// Defines the description of the <code>PlanningCalendarView</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDescription">New value for property <code>description</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarView setDescription(string sDescription);

				#endregion

				#region Methods for Property intervalsS

				/// <summary>
				/// Gets current value of property {@link #getIntervalsS intervalsS}.
				/// 
				/// Defines the number of intervals that are displayed for a {@link sap.m.PlanningCalendar} that is less than 600 pixels wide.
				/// 
				/// Default value is <code>6</code>.
				/// </summary>
				/// <returns>Value of property <code>intervalsS</code></returns>
				public extern virtual int getIntervalsS();

				/// <summary>
				/// Sets a new value for property {@link #getIntervalsS intervalsS}.
				/// 
				/// Defines the number of intervals that are displayed for a {@link sap.m.PlanningCalendar} that is less than 600 pixels wide.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>6</code>.
				/// </summary>
				/// <param name="iIntervalsS">New value for property <code>intervalsS</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarView setIntervalsS(int iIntervalsS);

				#endregion

				#region Methods for Property intervalsM

				/// <summary>
				/// Gets current value of property {@link #getIntervalsM intervalsM}.
				/// 
				/// Defines the number of intervals that are displayed for a {@link sap.m.PlanningCalendar} that is between 600 and 1024 pixels wide.
				/// 
				/// Default value is <code>8</code>.
				/// </summary>
				/// <returns>Value of property <code>intervalsM</code></returns>
				public extern virtual int getIntervalsM();

				/// <summary>
				/// Sets a new value for property {@link #getIntervalsM intervalsM}.
				/// 
				/// Defines the number of intervals that are displayed for a {@link sap.m.PlanningCalendar} that is between 600 and 1024 pixels wide.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>8</code>.
				/// </summary>
				/// <param name="iIntervalsM">New value for property <code>intervalsM</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarView setIntervalsM(int iIntervalsM);

				#endregion

				#region Methods for Property intervalsL

				/// <summary>
				/// Gets current value of property {@link #getIntervalsL intervalsL}.
				/// 
				/// Defines the number of intervals that are displayed for a {@link sap.m.PlanningCalendar} that is more than 1024 pixels wide.
				/// 
				/// Default value is <code>12</code>.
				/// </summary>
				/// <returns>Value of property <code>intervalsL</code></returns>
				public extern virtual int getIntervalsL();

				/// <summary>
				/// Sets a new value for property {@link #getIntervalsL intervalsL}.
				/// 
				/// Defines the number of intervals that are displayed for a {@link sap.m.PlanningCalendar} that is more than 1024 pixels wide.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>12</code>.
				/// </summary>
				/// <param name="iIntervalsL">New value for property <code>intervalsL</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarView setIntervalsL(int iIntervalsL);

				#endregion

				#region Methods for Property showSubIntervals

				/// <summary>
				/// Gets current value of property {@link #getShowSubIntervals showSubIntervals}.
				/// 
				/// If set, subintervals are displayed as lines in the rows.
				/// 
				/// <ul> <li>Quarter hour subintervals for interval type <code>Hour</code>.</li> <li>Hour subintervals for interval types <code>Day</code>, <code>Week</code> and <code>OneMonth</code>.</li> <li>Day subintervals for interval type <code>Month</code>.</li> </ul>
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showSubIntervals</code></returns>
				public extern virtual bool getShowSubIntervals();

				/// <summary>
				/// Sets a new value for property {@link #getShowSubIntervals showSubIntervals}.
				/// 
				/// If set, subintervals are displayed as lines in the rows.
				/// 
				/// <ul> <li>Quarter hour subintervals for interval type <code>Hour</code>.</li> <li>Hour subintervals for interval types <code>Day</code>, <code>Week</code> and <code>OneMonth</code>.</li> <li>Day subintervals for interval type <code>Month</code>.</li> </ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowSubIntervals">New value for property <code>showSubIntervals</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PlanningCalendarView setShowSubIntervals(bool bShowSubIntervals);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendarView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendarView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.PlanningCalendarView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.PlanningCalendarView.
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
