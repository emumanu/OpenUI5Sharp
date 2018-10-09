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
				/// The row.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.Row")]
				public partial class Row : sap.ui.core.Element
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
						/// The controls for the cells.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> cells;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Row.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Row(string sId, sap.ui.table.Row.Settings mSettings);

					/// <summary>
					/// Constructor for a new Row.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Row(string sId);

					/// <summary>
					/// Constructor for a new Row.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Row();

					/// <summary>
					/// Constructor for a new Row.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Row(sap.ui.table.Row.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Aggregation cells

					/// <summary>
					/// Gets content of aggregation {@link #getCells cells}.
					/// 
					/// The controls for the cells.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getCells();

					/// <summary>
					/// Destroys all the cells in the aggregation {@link #getCells cells}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Row destroyCells();

					/// <summary>
					/// Inserts a cell into the aggregation {@link #getCells cells}.
					/// </summary>
					/// <param name="oCell">The cell to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the cell should be inserted at; for a negative value of <code>iIndex</code>, the cell is inserted at position 0; for a value greater than the current size of the aggregation, the cell is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Row insertCell(sap.ui.core.Control oCell, int iIndex);

					/// <summary>
					/// Adds some cell to the aggregation {@link #getCells cells}.
					/// </summary>
					/// <param name="oCell">The cell to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Row addCell(sap.ui.core.Control oCell);

					/// <summary>
					/// Removes a cell from the aggregation {@link #getCells cells}.
					/// </summary>
					/// <param name="vCell">The cell to remove or its index or id</param>
					/// <returns>The removed cell or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeCell(Union<int, string, sap.ui.core.Control> vCell);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getCells cells}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oCell">The cell whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfCell(sap.ui.core.Control oCell);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getCells cells}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllCells();

					#endregion

					#region Methods for Aggregation _rowAction

					#endregion

					#region Methods for Aggregation _settings

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.Row with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.Row with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.Row with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the index of the row in the table or -1 if not added to a table. This function considers the scroll position of the table and also takes fixed rows and fixed bottom rows into account.
					/// </summary>
					/// <returns>index of the row (considers scroll position and fixed rows)</returns>
					public extern virtual int getIndex();

					/// <summary>
					/// Returns a metadata object for class sap.ui.table.Row.
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
