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
			public static partial class table
			{
				/// <summary>
				/// This column adds additional properties to the table column which are needed for the analytical binding and table
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.AnalyticalColumn")]
				public partial class AnalyticalColumn : sap.ui.table.Column
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.table.Column.Settings
					{
						/// <summary>
						/// Defines the primary model property which is used inside the Column. In case of the analytical extension this means the property which is grouped by for dimensions or the property which is summed for measures.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> leadingProperty;

						/// <summary>
						/// If defined a sum for this column is calculated
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> summed;

						/// <summary>
						/// Specifies that the dimension referred to by the column shall be included in the granularity of the data result. It allows a finer distinction between a visible/grouped/(included)inResult column.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> inResult;

						/// <summary>
						/// Specifies whether the column is displayed within the table even if it is grouped or not. A grouped column has the same value for every rows within the group.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showIfGrouped;

						/// <summary>
						/// If the column is grouped, this formatter is used to format the value in the group header
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> groupHeaderFormatter;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new AnalyticalColumn.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern AnalyticalColumn(string sId, sap.ui.table.AnalyticalColumn.Settings mSettings);

					/// <summary>
					/// Constructor for a new AnalyticalColumn.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern AnalyticalColumn(string sId);

					/// <summary>
					/// Constructor for a new AnalyticalColumn.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern AnalyticalColumn();

					/// <summary>
					/// Constructor for a new AnalyticalColumn.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern AnalyticalColumn(sap.ui.table.AnalyticalColumn.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property leadingProperty

					/// <summary>
					/// Gets current value of property {@link #getLeadingProperty leadingProperty}.
					/// 
					/// Defines the primary model property which is used inside the Column. In case of the analytical extension this means the property which is grouped by for dimensions or the property which is summed for measures.
					/// </summary>
					/// <returns>Value of property <code>leadingProperty</code></returns>
					public extern virtual string getLeadingProperty();

					/// <summary>
					/// Sets a new value for property {@link #getLeadingProperty leadingProperty}.
					/// 
					/// Defines the primary model property which is used inside the Column. In case of the analytical extension this means the property which is grouped by for dimensions or the property which is summed for measures.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sLeadingProperty">New value for property <code>leadingProperty</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.AnalyticalColumn setLeadingProperty(string sLeadingProperty);

					#endregion

					#region Methods for Property summed

					/// <summary>
					/// Gets current value of property {@link #getSummed summed}.
					/// 
					/// If defined a sum for this column is calculated
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>summed</code></returns>
					public extern virtual bool getSummed();

					/// <summary>
					/// Sets a new value for property {@link #getSummed summed}.
					/// 
					/// If defined a sum for this column is calculated
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bSummed">New value for property <code>summed</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.AnalyticalColumn setSummed(bool bSummed);

					#endregion

					#region Methods for Property inResult

					/// <summary>
					/// Gets current value of property {@link #getInResult inResult}.
					/// 
					/// Specifies that the dimension referred to by the column shall be included in the granularity of the data result. It allows a finer distinction between a visible/grouped/(included)inResult column.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>inResult</code></returns>
					public extern virtual bool getInResult();

					/// <summary>
					/// Sets a new value for property {@link #getInResult inResult}.
					/// 
					/// Specifies that the dimension referred to by the column shall be included in the granularity of the data result. It allows a finer distinction between a visible/grouped/(included)inResult column.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bInResult">New value for property <code>inResult</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.AnalyticalColumn setInResult(bool bInResult);

					#endregion

					#region Methods for Property showIfGrouped

					/// <summary>
					/// Gets current value of property {@link #getShowIfGrouped showIfGrouped}.
					/// 
					/// Specifies whether the column is displayed within the table even if it is grouped or not. A grouped column has the same value for every rows within the group.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>showIfGrouped</code></returns>
					public extern virtual bool getShowIfGrouped();

					/// <summary>
					/// Sets a new value for property {@link #getShowIfGrouped showIfGrouped}.
					/// 
					/// Specifies whether the column is displayed within the table even if it is grouped or not. A grouped column has the same value for every rows within the group.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShowIfGrouped">New value for property <code>showIfGrouped</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.AnalyticalColumn setShowIfGrouped(bool bShowIfGrouped);

					#endregion

					#region Methods for Property groupHeaderFormatter

					/// <summary>
					/// Gets current value of property {@link #getGroupHeaderFormatter groupHeaderFormatter}.
					/// 
					/// If the column is grouped, this formatter is used to format the value in the group header
					/// </summary>
					/// <returns>Value of property <code>groupHeaderFormatter</code></returns>
					public extern virtual object getGroupHeaderFormatter();

					/// <summary>
					/// Sets a new value for property {@link #getGroupHeaderFormatter groupHeaderFormatter}.
					/// 
					/// If the column is grouped, this formatter is used to format the value in the group header
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oGroupHeaderFormatter">New value for property <code>groupHeaderFormatter</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.AnalyticalColumn setGroupHeaderFormatter(object oGroupHeaderFormatter);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.AnalyticalColumn with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.table.Column.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.AnalyticalColumn with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.table.Column.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.AnalyticalColumn with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.table.Column.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.table.AnalyticalColumn.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Returns the information whether the column is groupable.
					/// 
					/// The column is groupable only if the following conditions are fulfilled: <ul> <li>The column must be child of an <code>AnalyticalTable</code>.</li> <li>The <code>rows</code> aggregation of the table must be bound.</li> <li>The metadata of the model must be loaded.</li> <li>The column's <code>leadingProperty</code> must be a sortable and filterable dimension.</li> </ul>
					/// </summary>
					/// <returns><code>true</code> if the column is groupable</returns>
					public extern virtual bool isGroupable();

					#endregion

					#endregion

				}
			}
		}
	}
}
