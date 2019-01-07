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
			public static partial class commons
			{
				/// <summary>
				/// This element is used by the RowRepeater and allows to define a filter in this context along with the related data such as a text and an icon.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.RowRepeaterFilter")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.ui.table.Table</code> control.")]
				public partial class RowRepeaterFilter : sap.ui.core.Element
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
						/// The filter title if needed for display.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// The filter icon if needed for display.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// The set of filter objects.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> filters;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new RowRepeaterFilter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern RowRepeaterFilter(string sId, sap.ui.commons.RowRepeaterFilter.Settings mSettings);

					/// <summary>
					/// Constructor for a new RowRepeaterFilter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern RowRepeaterFilter(string sId);

					/// <summary>
					/// Constructor for a new RowRepeaterFilter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern RowRepeaterFilter();

					/// <summary>
					/// Constructor for a new RowRepeaterFilter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern RowRepeaterFilter(sap.ui.commons.RowRepeaterFilter.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// The filter title if needed for display.
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// The filter title if needed for display.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeaterFilter setText(string sText);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// The filter icon if needed for display.
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual string getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// The filter icon if needed for display.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeaterFilter setIcon(string sIcon);

					#endregion

					#region Methods for Property filters

					/// <summary>
					/// Gets current value of property {@link #getFilters filters}.
					/// 
					/// The set of filter objects.
					/// </summary>
					/// <returns>Value of property <code>filters</code></returns>
					public extern virtual object getFilters();

					/// <summary>
					/// Sets a new value for property {@link #getFilters filters}.
					/// 
					/// The set of filter objects.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oFilters">New value for property <code>filters</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeaterFilter setFilters(object oFilters);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RowRepeaterFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RowRepeaterFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RowRepeaterFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.RowRepeaterFilter.
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
}
