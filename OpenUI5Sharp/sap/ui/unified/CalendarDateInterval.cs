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
				/// Calendar with dates displayed in one line.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.CalendarDateInterval")]
				public partial class CalendarDateInterval : sap.ui.unified.Calendar
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.unified.Calendar.Settings
					{
						/// <summary>
						/// Start date of the Interval
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> startDate;

						/// <summary>
						/// number of days displayed on phones the maximum rendered number of days is 8.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> days;

						/// <summary>
						/// If set the day names are shown in a separate line. If not set the day names are shown inside the single days.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showDayNamesLine;

						/// <summary>
						/// If set, the month- and yearPicker opens on a popup
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> pickerPopup;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>CalendarDateInterval</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CalendarDateInterval(string sId, sap.ui.unified.CalendarDateInterval.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>CalendarDateInterval</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern CalendarDateInterval(string sId);

					/// <summary>
					/// Constructor for a new <code>CalendarDateInterval</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern CalendarDateInterval();

					/// <summary>
					/// Constructor for a new <code>CalendarDateInterval</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CalendarDateInterval(sap.ui.unified.CalendarDateInterval.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property startDate

					/// <summary>
					/// Gets current value of property {@link #getStartDate startDate}.
					/// 
					/// Start date of the Interval
					/// </summary>
					/// <returns>Value of property <code>startDate</code></returns>
					public extern virtual object getStartDate();

					/// <summary>
					/// Sets a new value for property {@link #getStartDate startDate}.
					/// 
					/// Start date of the Interval
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oStartDate">New value for property <code>startDate</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarDateInterval setStartDate(object oStartDate);

					#endregion

					#region Methods for Property days

					/// <summary>
					/// Gets current value of property {@link #getDays days}.
					/// 
					/// number of days displayed on phones the maximum rendered number of days is 8.
					/// 
					/// Default value is <code>7</code>.
					/// </summary>
					/// <returns>Value of property <code>days</code></returns>
					public extern virtual int getDays();

					/// <summary>
					/// Sets a new value for property {@link #getDays days}.
					/// 
					/// number of days displayed on phones the maximum rendered number of days is 8.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>7</code>.
					/// </summary>
					/// <param name="iDays">New value for property <code>days</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarDateInterval setDays(int iDays);

					#endregion

					#region Methods for Property showDayNamesLine

					/// <summary>
					/// Gets current value of property {@link #getShowDayNamesLine showDayNamesLine}.
					/// 
					/// If set the day names are shown in a separate line. If not set the day names are shown inside the single days.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showDayNamesLine</code></returns>
					public extern virtual bool getShowDayNamesLine();

					/// <summary>
					/// Sets a new value for property {@link #getShowDayNamesLine showDayNamesLine}.
					/// 
					/// If set the day names are shown in a separate line. If not set the day names are shown inside the single days.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowDayNamesLine">New value for property <code>showDayNamesLine</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarDateInterval setShowDayNamesLine(bool bShowDayNamesLine);

					#endregion

					#region Methods for Property pickerPopup

					/// <summary>
					/// Gets current value of property {@link #getPickerPopup pickerPopup}.
					/// 
					/// If set, the month- and yearPicker opens on a popup
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>pickerPopup</code></returns>
					public extern virtual bool getPickerPopup();

					/// <summary>
					/// Sets a new value for property {@link #getPickerPopup pickerPopup}.
					/// 
					/// If set, the month- and yearPicker opens on a popup
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bPickerPopup">New value for property <code>pickerPopup</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarDateInterval setPickerPopup(bool bPickerPopup);

					#endregion

					#region Methods for Aggregation calendarPicker

					#endregion

					#region Other methods

					/// <summary>
					/// If more than this number of days are displayed, start and end month are displayed on the button.
					/// </summary>
					/// <returns>The number of days to determine how the start and end of month are displayed</returns>
					public extern virtual int _getDaysLarge();

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarDateInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.Calendar.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarDateInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.Calendar.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarDateInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.Calendar.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.CalendarDateInterval.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Setter for property <code>firstDayOfWeek</code>.
					/// 
					/// Property <code>firstDayOfWeek</code> is not supported in <code>sap.ui.unified.CalendarDateInterval</code> control.
					/// </summary>
					/// <param name="iFirstDayOfWeek">First day of the week</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarDateInterval setFirstDayOfWeek(int iFirstDayOfWeek);

					/// <summary>
					/// Setter for property <code>firstDayOfWeek</code>.
					/// 
					/// Property <code>firstDayOfWeek</code> is not supported in <code>sap.ui.unified.CalendarDateInterval</code> control.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarDateInterval setFirstDayOfWeek();

					/// <summary>
					/// Setter for property <code>months</code>.
					/// 
					/// Property <code>months</code> is not supported in <code>sap.ui.unified.CalendarDateInterval</code> control.
					/// </summary>
					/// <param name="iMonths">How many months to be displayed</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarDateInterval setMonths(int iMonths);

					#endregion

					#endregion

				}
			}
		}
	}
}
