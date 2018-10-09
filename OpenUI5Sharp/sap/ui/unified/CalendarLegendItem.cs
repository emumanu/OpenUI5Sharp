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
				/// Item to be displayed in a CalendarLegend.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.CalendarLegendItem")]
				public partial class CalendarLegendItem : sap.ui.core.Element
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
						/// Text to be displayed for the item.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Type of the item. If not set the type is automatically determined from the order of the items in the CalendarLegend.
						/// </summary>
						public Union<sap.ui.unified.CalendarDayType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

						/// <summary>
						/// Overrides the color derived from the <code>type</code> property.
						/// </summary>
						public Union<sap.ui.core.CSSColor, string, sap.ui.@base.ManagedObject.BindPropertyInfo> color;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new CalendarLegendItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CalendarLegendItem(string sId, sap.ui.unified.CalendarLegendItem.Settings mSettings);

					/// <summary>
					/// Constructor for a new CalendarLegendItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern CalendarLegendItem(string sId);

					/// <summary>
					/// Constructor for a new CalendarLegendItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern CalendarLegendItem();

					/// <summary>
					/// Constructor for a new CalendarLegendItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CalendarLegendItem(sap.ui.unified.CalendarLegendItem.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// Text to be displayed for the item.
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// Text to be displayed for the item.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarLegendItem setText(string sText);

					#endregion

					#region Methods for Property type

					/// <summary>
					/// Gets current value of property {@link #getType type}.
					/// 
					/// Type of the item. If not set the type is automatically determined from the order of the items in the CalendarLegend.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>type</code></returns>
					public extern virtual sap.ui.unified.CalendarDayType getType();

					/// <summary>
					/// Sets a new value for property {@link #getType type}.
					/// 
					/// Type of the item. If not set the type is automatically determined from the order of the items in the CalendarLegend.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sType">New value for property <code>type</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarLegendItem setType(sap.ui.unified.CalendarDayType sType);

					#endregion

					#region Methods for Property color

					/// <summary>
					/// Gets current value of property {@link #getColor color}.
					/// 
					/// Overrides the color derived from the <code>type</code> property.
					/// </summary>
					/// <returns>Value of property <code>color</code></returns>
					public extern virtual sap.ui.core.CSSColor getColor();

					/// <summary>
					/// Sets a new value for property {@link #getColor color}.
					/// 
					/// Overrides the color derived from the <code>type</code> property.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sColor">New value for property <code>color</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarLegendItem setColor(sap.ui.core.CSSColor sColor);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarLegendItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarLegendItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarLegendItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.CalendarLegendItem.
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
