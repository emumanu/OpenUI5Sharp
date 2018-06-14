using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
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
					/// renders a YearPicker with ItemNavigation This is used inside the calendar. Not for stand alone usage
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class YearPicker : sap.ui.core.Control
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
							/// The year is initial focused and selected The value must be between 0 and 9999
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> year;

							/// <summary>
							/// number of displayed years
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> years;

							/// <summary>
							/// number of years in each row 0 means just to have all years in one row, independent of the number
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> columns;

							/// <summary>
							/// Date as JavaScript Date object. For this date a <code>YearPicker</code> is rendered. If a Year is selected the date is updated with the start date of the selected year (depending on the calendar type).
							/// </summary>
							public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> date;

							/// <summary>
							/// If set, the calendar type is used for display. If not set, the calendar type of the global configuration is used.
							/// </summary>
							public Union<sap.ui.core.CalendarType, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> primaryCalendarType;

							/// <summary>
							/// Month selection changed
							/// </summary>
							public sap.ui.@base.EventDelegate select;

							/// <summary>
							/// The <code>pageChange</code> event is fired if the displayed years are changed by user navigation.
							/// </summary>
							public sap.ui.@base.EventDelegate pageChange;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new YearPicker.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern YearPicker(string sId, sap.ui.unified.calendar.YearPicker.Settings mSettings);

						/// <summary>
						/// Constructor for a new YearPicker.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern YearPicker(string sId);

						/// <summary>
						/// Constructor for a new YearPicker.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern YearPicker();

						/// <summary>
						/// Constructor for a new YearPicker.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern YearPicker(sap.ui.unified.calendar.YearPicker.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property year

						/// <summary>
						/// Gets current value of property {@link #getYear year}.
						/// 
						/// The year is initial focused and selected The value must be between 0 and 9999
						/// 
						/// Default value is <code>2000</code>.
						/// </summary>
						[Obsolete("Deprecated since 1.34.0. replaced by <code>date</code> property")]
						/// <returns>Value of property <code>year</code></returns>
						public extern virtual int getYear();

						/// <summary>
						/// Sets a new value for property {@link #getYear year}.
						/// 
						/// The year is initial focused and selected The value must be between 0 and 9999
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>2000</code>.
						/// </summary>
						[Obsolete("Deprecated since 1.34.0. replaced by <code>date</code> property")]
						/// <param name="iYear">New value for property <code>year</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker setYear(int iYear);

						#endregion

						#region Methods for Property years

						/// <summary>
						/// Gets current value of property {@link #getYears years}.
						/// 
						/// number of displayed years
						/// 
						/// Default value is <code>20</code>.
						/// </summary>
						/// <returns>Value of property <code>years</code></returns>
						public extern virtual int getYears();

						/// <summary>
						/// Sets a new value for property {@link #getYears years}.
						/// 
						/// number of displayed years
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>20</code>.
						/// </summary>
						/// <param name="iYears">New value for property <code>years</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker setYears(int iYears);

						#endregion

						#region Methods for Property columns

						/// <summary>
						/// Gets current value of property {@link #getColumns columns}.
						/// 
						/// number of years in each row 0 means just to have all years in one row, independent of the number
						/// 
						/// Default value is <code>4</code>.
						/// </summary>
						/// <returns>Value of property <code>columns</code></returns>
						public extern virtual int getColumns();

						/// <summary>
						/// Sets a new value for property {@link #getColumns columns}.
						/// 
						/// number of years in each row 0 means just to have all years in one row, independent of the number
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>4</code>.
						/// </summary>
						/// <param name="iColumns">New value for property <code>columns</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker setColumns(int iColumns);

						#endregion

						#region Methods for Property date

						/// <summary>
						/// Gets current value of property {@link #getDate date}.
						/// 
						/// Date as JavaScript Date object. For this date a <code>YearPicker</code> is rendered. If a Year is selected the date is updated with the start date of the selected year (depending on the calendar type).
						/// </summary>
						/// <returns>Value of property <code>date</code></returns>
						public extern virtual object getDate();

						/// <summary>
						/// Sets a new value for property {@link #getDate date}.
						/// 
						/// Date as JavaScript Date object. For this date a <code>YearPicker</code> is rendered. If a Year is selected the date is updated with the start date of the selected year (depending on the calendar type).
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="oDate">New value for property <code>date</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker setDate(object oDate);

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
						public extern virtual sap.ui.unified.calendar.YearPicker setPrimaryCalendarType(sap.ui.core.CalendarType sPrimaryCalendarType);

						#endregion

						#region Methods for Event select

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.YearPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.YearPicker</code> itself.
						/// 
						/// Month selection changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.YearPicker</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.YearPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.YearPicker</code> itself.
						/// 
						/// Month selection changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.YearPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.YearPicker</code> itself.
						/// 
						/// Month selection changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker attachSelect(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.YearPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.YearPicker</code> itself.
						/// 
						/// Month selection changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.YearPicker</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker attachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.unified.calendar.YearPicker</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker detachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:select select} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker fireSelect(object mParameters);

						/// <summary>
						/// Fires event {@link #event:select select} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker fireSelect();

						#endregion

						#region Methods for Event pageChange

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChange pageChange} event of this <code>sap.ui.unified.calendar.YearPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.YearPicker</code> itself.
						/// 
						/// The <code>pageChange</code> event is fired if the displayed years are changed by user navigation.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.YearPicker</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker attachPageChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChange pageChange} event of this <code>sap.ui.unified.calendar.YearPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.YearPicker</code> itself.
						/// 
						/// The <code>pageChange</code> event is fired if the displayed years are changed by user navigation.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker attachPageChange(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChange pageChange} event of this <code>sap.ui.unified.calendar.YearPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.YearPicker</code> itself.
						/// 
						/// The <code>pageChange</code> event is fired if the displayed years are changed by user navigation.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker attachPageChange(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChange pageChange} event of this <code>sap.ui.unified.calendar.YearPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.YearPicker</code> itself.
						/// 
						/// The <code>pageChange</code> event is fired if the displayed years are changed by user navigation.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.YearPicker</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker attachPageChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:pageChange pageChange} event of this <code>sap.ui.unified.calendar.YearPicker</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker detachPageChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:pageChange pageChange} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker firePageChange(object mParameters);

						/// <summary>
						/// Fires event {@link #event:pageChange pageChange} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker firePageChange();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.YearPicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.YearPicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.YearPicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// return the first date of the first rendered year <b>Note:</b> If the YearPicker is not rendered no date is returned
						/// </summary>
						/// <returns>JavaScript Date Object</returns>
						public extern virtual object getFirstRenderedDate();

						/// <summary>
						/// Returns a metadata object for class sap.ui.unified.calendar.YearPicker.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// displays the next page
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker nextPage();

						/// <summary>
						/// displays the previous page
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.YearPicker previousPage();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
