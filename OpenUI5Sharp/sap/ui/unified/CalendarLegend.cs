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
				/// A legend for the Calendar Control. Displays special dates colors with their corresponding description. The aggregation specialDates can be set herefor.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.CalendarLegend")]
				public partial class CalendarLegend : sap.ui.core.Control
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
						/// Determines the standard items related to the calendar days, such as, today, selected, working and non-working. Values must be one of <code>sap.ui.unified.StandardCalendarLegendItem</code>. Note: for versions 1.50 and 1.52, this property was defined in the the subclass <code>sap.m.PlanningCalendarLegend</code>
						/// </summary>
						public Union<string[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> standardItems;

						/// <summary>
						/// Defines the width of the created columns in which the items are arranged.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnWidth;

						/// <summary>
						/// Items to be displayed.
						/// </summary>
						public Union<sap.ui.unified.CalendarLegendItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new CalendarLegend.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CalendarLegend(string sId, sap.ui.unified.CalendarLegend.Settings mSettings);

					/// <summary>
					/// Constructor for a new CalendarLegend.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern CalendarLegend(string sId);

					/// <summary>
					/// Constructor for a new CalendarLegend.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern CalendarLegend();

					/// <summary>
					/// Constructor for a new CalendarLegend.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CalendarLegend(sap.ui.unified.CalendarLegend.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property standardItems

					/// <summary>
					/// Gets current value of property {@link #getStandardItems standardItems}.
					/// 
					/// Determines the standard items related to the calendar days, such as, today, selected, working and non-working. Values must be one of <code>sap.ui.unified.StandardCalendarLegendItem</code>. Note: for versions 1.50 and 1.52, this property was defined in the the subclass <code>sap.m.PlanningCalendarLegend</code>
					/// 
					/// Default value is <code>Today,Selected,WorkingDay,NonWorkingDay</code>.
					/// </summary>
					/// <returns>Value of property <code>standardItems</code></returns>
					public extern virtual string[] getStandardItems();

					/// <summary>
					/// Sets a new value for property {@link #getStandardItems standardItems}.
					/// 
					/// Determines the standard items related to the calendar days, such as, today, selected, working and non-working. Values must be one of <code>sap.ui.unified.StandardCalendarLegendItem</code>. Note: for versions 1.50 and 1.52, this property was defined in the the subclass <code>sap.m.PlanningCalendarLegend</code>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Today,Selected,WorkingDay,NonWorkingDay</code>.
					/// </summary>
					/// <param name="sStandardItems">New value for property <code>standardItems</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarLegend setStandardItems(string[] sStandardItems);

					/// <summary>
					/// Sets a new value for property {@link #getStandardItems standardItems}.
					/// 
					/// Determines the standard items related to the calendar days, such as, today, selected, working and non-working. Values must be one of <code>sap.ui.unified.StandardCalendarLegendItem</code>. Note: for versions 1.50 and 1.52, this property was defined in the the subclass <code>sap.m.PlanningCalendarLegend</code>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Today,Selected,WorkingDay,NonWorkingDay</code>.
					/// </summary>
					/// <param name="sStandardItems">New value for property <code>standardItems</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarLegend setStandardItems(object[] sStandardItems);

					#endregion

					#region Methods for Property columnWidth

					/// <summary>
					/// Gets current value of property {@link #getColumnWidth columnWidth}.
					/// 
					/// Defines the width of the created columns in which the items are arranged.
					/// 
					/// Default value is <code>120px</code>.
					/// </summary>
					/// <returns>Value of property <code>columnWidth</code></returns>
					public extern virtual sap.ui.core.CSSSize getColumnWidth();

					/// <summary>
					/// Sets a new value for property {@link #getColumnWidth columnWidth}.
					/// 
					/// Defines the width of the created columns in which the items are arranged.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>120px</code>.
					/// </summary>
					/// <param name="sColumnWidth">New value for property <code>columnWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarLegend setColumnWidth(sap.ui.core.CSSSize sColumnWidth);

					#endregion

					#region Methods for Aggregation items

					/// <summary>
					/// Gets content of aggregation {@link #getItems items}.
					/// 
					/// Items to be displayed.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.CalendarLegendItem[] getItems();

					/// <summary>
					/// Destroys all the items in the aggregation {@link #getItems items}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarLegend destroyItems();

					/// <summary>
					/// Inserts a item into the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarLegend insertItem(sap.ui.unified.CalendarLegendItem oItem, int iIndex);

					/// <summary>
					/// Adds some item to the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarLegend addItem(sap.ui.unified.CalendarLegendItem oItem);

					/// <summary>
					/// Removes a item from the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="vItem">The item to remove or its index or id</param>
					/// <returns>The removed item or <code>null</code></returns>
					public extern virtual sap.ui.unified.CalendarLegendItem removeItem(Union<int, string, sap.ui.unified.CalendarLegendItem> vItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.unified.CalendarLegendItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oItem">The item whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfItem(sap.ui.unified.CalendarLegendItem oItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getItems items}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.unified.CalendarLegendItem[] removeAllItems();

					#endregion

					#region Methods for Aggregation _standardItems

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarLegend with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarLegend with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarLegend with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.CalendarLegend.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
