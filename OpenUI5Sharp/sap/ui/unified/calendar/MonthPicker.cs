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
					/// renders a MonthPicker with ItemNavigation This is used inside the calendar. Not for stand alone usage
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.unified.calendar.MonthPicker")]
					public partial class MonthPicker : sap.ui.core.Control
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
							/// The month is initial focused and selected The value must be between 0 and 11
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> month;

							/// <summary>
							/// number of displayed months The value must be between 1 and 12
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> months;

							/// <summary>
							/// number of months in each row The value must be between 0 and 12 (0 means just to have all months in one row, independent of the number)
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columns;

							/// <summary>
							/// If set, the calendar type is used for display. If not set, the calendar type of the global configuration is used.
							/// </summary>
							public Union<sap.ui.core.CalendarType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> primaryCalendarType;

							/// <summary>
							/// Month selection changed
							/// </summary>
							public sap.ui.@base.EventDelegate select;

							/// <summary>
							/// If less than 12 months are displayed the <code>pageChange</code> event is fired if the displayed months are changed by user navigation.
							/// </summary>
							public sap.ui.@base.EventDelegate pageChange;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new MonthPicker.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern MonthPicker(string sId, sap.ui.unified.calendar.MonthPicker.Settings mSettings);

						/// <summary>
						/// Constructor for a new MonthPicker.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern MonthPicker(string sId);

						/// <summary>
						/// Constructor for a new MonthPicker.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern MonthPicker();

						/// <summary>
						/// Constructor for a new MonthPicker.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern MonthPicker(sap.ui.unified.calendar.MonthPicker.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property month

						/// <summary>
						/// Gets current value of property {@link #getMonth month}.
						/// 
						/// The month is initial focused and selected The value must be between 0 and 11
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <returns>Value of property <code>month</code></returns>
						public extern virtual int getMonth();

						/// <summary>
						/// Sets a new value for property {@link #getMonth month}.
						/// 
						/// The month is initial focused and selected The value must be between 0 and 11
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <param name="iMonth">New value for property <code>month</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker setMonth(int iMonth);

						#endregion

						#region Methods for Property months

						/// <summary>
						/// Gets current value of property {@link #getMonths months}.
						/// 
						/// number of displayed months The value must be between 1 and 12
						/// 
						/// Default value is <code>12</code>.
						/// </summary>
						/// <returns>Value of property <code>months</code></returns>
						public extern virtual int getMonths();

						/// <summary>
						/// Sets a new value for property {@link #getMonths months}.
						/// 
						/// number of displayed months The value must be between 1 and 12
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>12</code>.
						/// </summary>
						/// <param name="iMonths">New value for property <code>months</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker setMonths(int iMonths);

						#endregion

						#region Methods for Property columns

						/// <summary>
						/// Gets current value of property {@link #getColumns columns}.
						/// 
						/// number of months in each row The value must be between 0 and 12 (0 means just to have all months in one row, independent of the number)
						/// 
						/// Default value is <code>3</code>.
						/// </summary>
						/// <returns>Value of property <code>columns</code></returns>
						public extern virtual int getColumns();

						/// <summary>
						/// Sets a new value for property {@link #getColumns columns}.
						/// 
						/// number of months in each row The value must be between 0 and 12 (0 means just to have all months in one row, independent of the number)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>3</code>.
						/// </summary>
						/// <param name="iColumns">New value for property <code>columns</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker setColumns(int iColumns);

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
						public extern virtual sap.ui.unified.calendar.MonthPicker setPrimaryCalendarType(sap.ui.core.CalendarType sPrimaryCalendarType);

						#endregion

						#region Methods for Event select

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.MonthPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.MonthPicker</code> itself.
						/// 
						/// Month selection changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.MonthPicker</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.MonthPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.MonthPicker</code> itself.
						/// 
						/// Month selection changed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.MonthPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.MonthPicker</code> itself.
						/// 
						/// Month selection changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker attachSelect(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.calendar.MonthPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.MonthPicker</code> itself.
						/// 
						/// Month selection changed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.MonthPicker</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker attachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.unified.calendar.MonthPicker</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker detachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:select select} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker fireSelect(object mParameters);

						/// <summary>
						/// Fires event {@link #event:select select} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker fireSelect();

						#endregion

						#region Methods for Event pageChange

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChange pageChange} event of this <code>sap.ui.unified.calendar.MonthPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.MonthPicker</code> itself.
						/// 
						/// If less than 12 months are displayed the <code>pageChange</code> event is fired if the displayed months are changed by user navigation.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.MonthPicker</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker attachPageChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChange pageChange} event of this <code>sap.ui.unified.calendar.MonthPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.MonthPicker</code> itself.
						/// 
						/// If less than 12 months are displayed the <code>pageChange</code> event is fired if the displayed months are changed by user navigation.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker attachPageChange(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChange pageChange} event of this <code>sap.ui.unified.calendar.MonthPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.MonthPicker</code> itself.
						/// 
						/// If less than 12 months are displayed the <code>pageChange</code> event is fired if the displayed months are changed by user navigation.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker attachPageChange(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChange pageChange} event of this <code>sap.ui.unified.calendar.MonthPicker</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.MonthPicker</code> itself.
						/// 
						/// If less than 12 months are displayed the <code>pageChange</code> event is fired if the displayed months are changed by user navigation.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.MonthPicker</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker attachPageChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:pageChange pageChange} event of this <code>sap.ui.unified.calendar.MonthPicker</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker detachPageChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:pageChange pageChange} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker firePageChange(object mParameters);

						/// <summary>
						/// Fires event {@link #event:pageChange pageChange} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker firePageChange();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.MonthPicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.MonthPicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.MonthPicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.unified.calendar.MonthPicker.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// displays the next page
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker nextPage();

						/// <summary>
						/// displays the previous page
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker previousPage();

						/// <summary>
						/// sets a minimum and maximum month
						/// </summary>
						/// <param name="iMin">minimum month as integer (starting with 0)</param>
						/// <param name="iMax">maximum month as integer (starting with 0)</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker setMinMax(int iMin, int iMax);

						/// <summary>
						/// sets a minimum and maximum month
						/// </summary>
						/// <param name="iMin">minimum month as integer (starting with 0)</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker setMinMax(int iMin);

						/// <summary>
						/// sets a minimum and maximum month
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.MonthPicker setMinMax();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
