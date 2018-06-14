using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
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
					/// Internally used in {@link sap.ui.core.util.Export Export}.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class ExportRow : sap.ui.@base.ManagedObject
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
							/// Cells for the Export.
							/// </summary>
							public Union<sap.ui.core.util.ExportCell[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> cells;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new ExportRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ExportRow(string sId, sap.ui.core.util.ExportRow.Settings mSettings);

						/// <summary>
						/// Constructor for a new ExportRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern ExportRow(string sId);

						/// <summary>
						/// Constructor for a new ExportRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern ExportRow();

						/// <summary>
						/// Constructor for a new ExportRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ExportRow(sap.ui.core.util.ExportRow.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Aggregation cells

						/// <summary>
						/// Gets content of aggregation {@link #getCells cells}.
						/// 
						/// Cells for the Export.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.util.ExportCell[] getCells();

						/// <summary>
						/// Destroys all the cells in the aggregation {@link #getCells cells}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.ExportRow destroyCells();

						/// <summary>
						/// Inserts a cell into the aggregation {@link #getCells cells}.
						/// </summary>
						/// <param name="oCell">The cell to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the cell should be inserted at; for a negative value of <code>iIndex</code>, the cell is inserted at position 0; for a value greater than the current size of the aggregation, the cell is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.ExportRow insertCell(sap.ui.core.util.ExportCell oCell, int iIndex);

						/// <summary>
						/// Adds some cell to the aggregation {@link #getCells cells}.
						/// </summary>
						/// <param name="oCell">The cell to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.ExportRow addCell(sap.ui.core.util.ExportCell oCell);

						/// <summary>
						/// Removes a cell from the aggregation {@link #getCells cells}.
						/// </summary>
						/// <param name="vCell">The cell to remove or its index or id</param>
						/// <returns>The removed cell or <code>null</code></returns>
						public extern virtual sap.ui.core.util.ExportCell removeCell(Union<int, string, sap.ui.core.util.ExportCell> vCell);

						/// <summary>
						/// Checks for the provided <code>sap.ui.core.util.ExportCell</code> in the aggregation {@link #getCells cells}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oCell">The cell whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfCell(sap.ui.core.util.ExportCell oCell);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getCells cells}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.util.ExportCell[] removeAllCells();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.util.ExportRow.
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
}
