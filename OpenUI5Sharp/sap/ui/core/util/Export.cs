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
					/// Export provides the possibility to generate a list of data in a specific format / type, e.g. CSV to use it in other programs / applications.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.util.Export")]
					public partial class Export : sap.ui.core.Control
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
							/// Type that generates the content.
							/// </summary>
							public Union<sap.ui.core.util.ExportType, string, sap.ui.@base.ManagedObject.BindAggregationInfo> exportType;

							/// <summary>
							/// Columns for the Export.
							/// </summary>
							public Union<sap.ui.core.util.ExportColumn[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> columns;

							/// <summary>
							/// Rows of the Export.
							/// </summary>
							public Union<sap.ui.core.util.ExportRow[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> rows;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new Export.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern Export(string sId, sap.ui.core.util.Export.Settings mSettings);

						/// <summary>
						/// Constructor for a new Export.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern Export(string sId);

						/// <summary>
						/// Constructor for a new Export.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern Export();

						/// <summary>
						/// Constructor for a new Export.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern Export(sap.ui.core.util.Export.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Aggregation exportType

						/// <summary>
						/// Gets content of aggregation {@link #getExportType exportType}.
						/// 
						/// Type that generates the content.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.util.ExportType getExportType();

						/// <summary>
						/// Destroys the exportType in the aggregation {@link #getExportType exportType}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export destroyExportType();

						/// <summary>
						/// Sets the aggregated {@link #getExportType exportType}.
						/// </summary>
						/// <param name="oExportType">The exportType to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export setExportType(sap.ui.core.util.ExportType oExportType);

						#endregion

						#region Methods for Aggregation columns

						/// <summary>
						/// Gets content of aggregation {@link #getColumns columns}.
						/// 
						/// Columns for the Export.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.util.ExportColumn[] getColumns();

						/// <summary>
						/// Destroys all the columns in the aggregation {@link #getColumns columns}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export destroyColumns();

						/// <summary>
						/// Inserts a column into the aggregation {@link #getColumns columns}.
						/// </summary>
						/// <param name="oColumn">The column to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the column should be inserted at; for a negative value of <code>iIndex</code>, the column is inserted at position 0; for a value greater than the current size of the aggregation, the column is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export insertColumn(sap.ui.core.util.ExportColumn oColumn, int iIndex);

						/// <summary>
						/// Adds some column to the aggregation {@link #getColumns columns}.
						/// </summary>
						/// <param name="oColumn">The column to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export addColumn(sap.ui.core.util.ExportColumn oColumn);

						/// <summary>
						/// Removes a column from the aggregation {@link #getColumns columns}.
						/// </summary>
						/// <param name="vColumn">The column to remove or its index or id</param>
						/// <returns>The removed column or <code>null</code></returns>
						public extern virtual sap.ui.core.util.ExportColumn removeColumn(Union<int, string, sap.ui.core.util.ExportColumn> vColumn);

						/// <summary>
						/// Checks for the provided <code>sap.ui.core.util.ExportColumn</code> in the aggregation {@link #getColumns columns}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oColumn">The column whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfColumn(sap.ui.core.util.ExportColumn oColumn);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getColumns columns}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.util.ExportColumn[] removeAllColumns();

						/// <summary>
						/// Binds aggregation {@link #getColumns columns} to model data.
						/// 
						/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
						/// </summary>
						/// <param name="oBindingInfo">The binding information</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export bindColumns(object oBindingInfo);

						/// <summary>
						/// Unbinds aggregation {@link #getColumns columns} from model data.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export unbindColumns();

						#endregion

						#region Methods for Aggregation rows

						/// <summary>
						/// Gets content of aggregation {@link #getRows rows}.
						/// 
						/// Rows of the Export.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.util.ExportRow[] getRows();

						/// <summary>
						/// Destroys all the rows in the aggregation {@link #getRows rows}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export destroyRows();

						/// <summary>
						/// Inserts a row into the aggregation {@link #getRows rows}.
						/// </summary>
						/// <param name="oRow">The row to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the row should be inserted at; for a negative value of <code>iIndex</code>, the row is inserted at position 0; for a value greater than the current size of the aggregation, the row is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export insertRow(sap.ui.core.util.ExportRow oRow, int iIndex);

						/// <summary>
						/// Adds some row to the aggregation {@link #getRows rows}.
						/// </summary>
						/// <param name="oRow">The row to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export addRow(sap.ui.core.util.ExportRow oRow);

						/// <summary>
						/// Removes a row from the aggregation {@link #getRows rows}.
						/// </summary>
						/// <param name="vRow">The row to remove or its index or id</param>
						/// <returns>The removed row or <code>null</code></returns>
						public extern virtual sap.ui.core.util.ExportRow removeRow(Union<int, string, sap.ui.core.util.ExportRow> vRow);

						/// <summary>
						/// Checks for the provided <code>sap.ui.core.util.ExportRow</code> in the aggregation {@link #getRows rows}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oRow">The row whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfRow(sap.ui.core.util.ExportRow oRow);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getRows rows}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.util.ExportRow[] removeAllRows();

						/// <summary>
						/// Binds aggregation {@link #getRows rows} to model data.
						/// 
						/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
						/// </summary>
						/// <param name="oBindingInfo">The binding information</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export bindRows(object oBindingInfo);

						/// <summary>
						/// Unbinds aggregation {@link #getRows rows} from model data.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.Export unbindRows();

						#endregion

						#region Methods for Aggregation _template

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.Export with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.Export with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.Export with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Generates the file content and returns a Promise with the instance as context (this).<br> The promise will be resolved with the generated content as a string.
						/// 
						/// <p><b>Please note: The return value was changed from jQuery Promises to standard ES6 Promises. jQuery specific Promise methods ('done', 'fail', 'always', 'pipe' and 'state') are still available but should not be used. Please use only the standard methods 'then' and 'catch'!</b></p>
						/// </summary>
						/// <returns>Promise object</returns>
						public extern virtual jquery.JQueryPromise<object> generate();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.util.Export.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Generates the file content, triggers a download / save action and returns a Promise with the instance as context (this).<br> The promise will be resolved with the generated content as a string. <p><b>For information about browser support, see <code>sap.ui.core.util.File.save</code></b></p>
						/// 
						/// <p><b>Please note: The return value was changed from jQuery Promises to standard ES6 Promises. jQuery specific Promise methods ('done', 'fail', 'always', 'pipe' and 'state') are still available but should not be used. Please use only the standard methods 'then' and 'catch'!</b></p>
						/// </summary>
						/// <param name="sFileName">file name, defaults to 'data'</param>
						/// <returns>Promise object</returns>
						public extern virtual jquery.JQueryPromise<object> saveFile(string sFileName);

						/// <summary>
						/// Generates the file content, triggers a download / save action and returns a Promise with the instance as context (this).<br> The promise will be resolved with the generated content as a string. <p><b>For information about browser support, see <code>sap.ui.core.util.File.save</code></b></p>
						/// 
						/// <p><b>Please note: The return value was changed from jQuery Promises to standard ES6 Promises. jQuery specific Promise methods ('done', 'fail', 'always', 'pipe' and 'state') are still available but should not be used. Please use only the standard methods 'then' and 'catch'!</b></p>
						/// </summary>
						/// <returns>Promise object</returns>
						public extern virtual jquery.JQueryPromise<object> saveFile();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
