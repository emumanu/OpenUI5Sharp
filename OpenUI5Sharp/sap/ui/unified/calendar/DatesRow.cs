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
					/// renders a row of days with ItemNavigation This is used inside the calendar. Not for stand alone usage If used inside the calendar the properties and aggregation are directly taken from the parent (To not duplicate and sync DateRanges and so on...)
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.unified.calendar.DatesRow")]
					public partial class DatesRow : sap.ui.unified.calendar.Month
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.unified.calendar.Month.Settings
						{
							/// <summary>
							/// Start date of the row If in rendering phase the date property is not in the range startDate + days, it is set to the start date So after setting the start date the date should be set to be in the range of the start date
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> startDate;

							/// <summary>
							/// number of days displayed
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> days;

							/// <summary>
							/// If set the day names are shown in a separate line. If not set the day names are shown inside the single days.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showDayNamesLine;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new calendar/DatesRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern DatesRow(string sId, sap.ui.unified.calendar.DatesRow.Settings mSettings);

						/// <summary>
						/// Constructor for a new calendar/DatesRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern DatesRow(string sId);

						/// <summary>
						/// Constructor for a new calendar/DatesRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern DatesRow();

						/// <summary>
						/// Constructor for a new calendar/DatesRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern DatesRow(sap.ui.unified.calendar.DatesRow.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property startDate

						/// <summary>
						/// Gets current value of property {@link #getStartDate startDate}.
						/// 
						/// Start date of the row If in rendering phase the date property is not in the range startDate + days, it is set to the start date So after setting the start date the date should be set to be in the range of the start date
						/// </summary>
						/// <returns>Value of property <code>startDate</code></returns>
						public extern virtual object getStartDate();

						/// <summary>
						/// Sets a new value for property {@link #getStartDate startDate}.
						/// 
						/// Start date of the row If in rendering phase the date property is not in the range startDate + days, it is set to the start date So after setting the start date the date should be set to be in the range of the start date
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="oStartDate">New value for property <code>startDate</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.DatesRow setStartDate(object oStartDate);

						#endregion

						#region Methods for Property days

						/// <summary>
						/// Gets current value of property {@link #getDays days}.
						/// 
						/// number of days displayed
						/// 
						/// Default value is <code>7</code>.
						/// </summary>
						/// <returns>Value of property <code>days</code></returns>
						public extern virtual int getDays();

						/// <summary>
						/// Sets a new value for property {@link #getDays days}.
						/// 
						/// number of days displayed
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>7</code>.
						/// </summary>
						/// <param name="iDays">New value for property <code>days</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.DatesRow setDays(int iDays);

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
						public extern virtual sap.ui.unified.calendar.DatesRow setShowDayNamesLine(bool bShowDayNamesLine);

						#endregion

						#region Other methods

						/// <summary>
						/// displays the a given date without setting the focus
						/// 
						/// Property <code>date</code> date to be focused or displayed. It must be in the displayed date range beginning with <code>startDate</code> and <code>days</code> days So set this properties before setting the date.
						/// </summary>
						/// <param name="oDate">JavaScript date object for focused date.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.DatesRow displayDate(object oDate);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.DatesRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.calendar.Month.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.DatesRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.calendar.Month.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.DatesRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.calendar.Month.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.unified.calendar.DatesRow.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Setter for property <code>date</code>.
						/// 
						/// Property <code>date</code> date to be focused or displayed. It must be in the displayed date range beginning with <code>startDate</code> and <code>days</code> days So set this properties before setting the date.
						/// </summary>
						/// <param name="oDate">JavaScript date object for start date.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.DatesRow setDate(object oDate);

						/// <summary>
						/// Setter for property <code>firstDayOfWeek</code>.
						/// 
						/// Property <code>firstDayOfWeek</code> is not supported in <code>sap.ui.unified.calendar.DatesRow</code> control.
						/// </summary>
						/// <param name="iFirstDayOfWeek">The first day of the week</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.DatesRow setFirstDayOfWeek(int iFirstDayOfWeek);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
