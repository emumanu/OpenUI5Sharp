using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				public static partial class util
				{
					/// <summary>
					/// Can have a name and a cell template.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.util.ExportColumn")]
					public partial class ExportColumn : sap.ui.@base.ManagedObject
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.@base.ManagedObject.Settings
						{
							/// <summary>
							/// Column name.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

							/// <summary>
							/// Cell template for column.
							/// </summary>
							public Union<sap.ui.core.util.ExportCell, string, sap.ui.@base.ManagedObject.BindAggregationInfo> template;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new ExportCell.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ExportColumn(string sId, sap.ui.core.util.ExportColumn.Settings mSettings);

						/// <summary>
						/// Constructor for a new ExportCell.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern ExportColumn(string sId);

						/// <summary>
						/// Constructor for a new ExportCell.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern ExportColumn();

						/// <summary>
						/// Constructor for a new ExportCell.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ExportColumn(sap.ui.core.util.ExportColumn.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property name

						/// <summary>
						/// Gets current value of property {@link #getName name}.
						/// 
						/// Column name.
						/// </summary>
						/// <returns>Value of property <code>name</code></returns>
						public extern virtual string getName();

						/// <summary>
						/// Sets a new value for property {@link #getName name}.
						/// 
						/// Column name.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sName">New value for property <code>name</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.ExportColumn setName(string sName);

						#endregion

						#region Methods for Aggregation template

						/// <summary>
						/// Gets content of aggregation {@link #getTemplate template}.
						/// 
						/// Cell template for column.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.util.ExportCell getTemplate();

						/// <summary>
						/// Destroys the template in the aggregation {@link #getTemplate template}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.ExportColumn destroyTemplate();

						/// <summary>
						/// Sets the aggregated {@link #getTemplate template}.
						/// </summary>
						/// <param name="oTemplate">The template to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.ExportColumn setTemplate(sap.ui.core.util.ExportCell oTemplate);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportColumn with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportColumn with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportColumn with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.util.ExportColumn.
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
}
