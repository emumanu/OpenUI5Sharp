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
				public static partial class layout
				{
					/// <summary>
					/// <p> A matrix layout arranges controls in a grid structure, using rows which need not have the same number of cells. </p>
					/// 
					/// <p> It uses predefined cell classes that guarantee appropriate distances between cells in the grid. The cell's <code>vGutter</code> property lets you specify additional horizontal distances easily. You can set these additional distances (known as gutters) with or without separators. The distance for each cell is specified by assigning a specific enumeration value of the class <code>LayoutCellSeparator</code> of the matrix data object. </p>
					/// 
					/// <p> You should <b>avoid nesting</b> matrix layouts. You should only use a matrix layout if you need to align controls horizontally across rows. </p>
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.MatrixLayout")]
					[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.ui.layout.Grid</code> control.")]
					public partial class MatrixLayout : sap.ui.core.Control
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
							/// CSS width of the matrix layout. If the LayoutFixed = true an adequate width should be provided.
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

							/// <summary>
							/// CSS height of the matrix layout.
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

							/// <summary>
							/// Sets the table layout. If fixed the width parameter of a column has priority, if not the width of the content of the colums has priority. The default is "fixed". If the fixed layout is used an adequate width of the MatrixLayout should be provided. Otherwise the column width displayed could be different than the given ones because of browser dependend optimazations.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> layoutFixed;

							/// <summary>
							/// Number of columns. If not specified, the number of columns will be determined from the given cells.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columns;

							/// <summary>
							/// Widths of the columns. Use an array to define the widths of the columns. If a column shall have an automatical sizing enter "auto" for this column width.
							/// </summary>
							public Union<sap.ui.core.CSSSize[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> widths;

							/// <summary>
							/// The matrix layout's individual rows.
							/// </summary>
							public Union<sap.ui.commons.layout.MatrixLayoutRow[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> rows;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new layout/MatrixLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern MatrixLayout(string sId, sap.ui.commons.layout.MatrixLayout.Settings mSettings);

						/// <summary>
						/// Constructor for a new layout/MatrixLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern MatrixLayout(string sId);

						/// <summary>
						/// Constructor for a new layout/MatrixLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern MatrixLayout();

						/// <summary>
						/// Constructor for a new layout/MatrixLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern MatrixLayout(sap.ui.commons.layout.MatrixLayout.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property width

						/// <summary>
						/// Gets current value of property {@link #getWidth width}.
						/// 
						/// CSS width of the matrix layout. If the LayoutFixed = true an adequate width should be provided.
						/// </summary>
						/// <returns>Value of property <code>width</code></returns>
						public extern virtual sap.ui.core.CSSSize getWidth();

						/// <summary>
						/// Sets a new value for property {@link #getWidth width}.
						/// 
						/// CSS width of the matrix layout. If the LayoutFixed = true an adequate width should be provided.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sWidth">New value for property <code>width</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayout setWidth(sap.ui.core.CSSSize sWidth);

						#endregion

						#region Methods for Property height

						/// <summary>
						/// Gets current value of property {@link #getHeight height}.
						/// 
						/// CSS height of the matrix layout.
						/// </summary>
						/// <returns>Value of property <code>height</code></returns>
						public extern virtual sap.ui.core.CSSSize getHeight();

						/// <summary>
						/// Sets a new value for property {@link #getHeight height}.
						/// 
						/// CSS height of the matrix layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sHeight">New value for property <code>height</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayout setHeight(sap.ui.core.CSSSize sHeight);

						#endregion

						#region Methods for Property layoutFixed

						/// <summary>
						/// Gets current value of property {@link #getLayoutFixed layoutFixed}.
						/// 
						/// Sets the table layout. If fixed the width parameter of a column has priority, if not the width of the content of the colums has priority. The default is "fixed". If the fixed layout is used an adequate width of the MatrixLayout should be provided. Otherwise the column width displayed could be different than the given ones because of browser dependend optimazations.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>layoutFixed</code></returns>
						public extern virtual bool getLayoutFixed();

						/// <summary>
						/// Sets a new value for property {@link #getLayoutFixed layoutFixed}.
						/// 
						/// Sets the table layout. If fixed the width parameter of a column has priority, if not the width of the content of the colums has priority. The default is "fixed". If the fixed layout is used an adequate width of the MatrixLayout should be provided. Otherwise the column width displayed could be different than the given ones because of browser dependend optimazations.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bLayoutFixed">New value for property <code>layoutFixed</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayout setLayoutFixed(bool bLayoutFixed);

						#endregion

						#region Methods for Property columns

						/// <summary>
						/// Gets current value of property {@link #getColumns columns}.
						/// 
						/// Number of columns. If not specified, the number of columns will be determined from the given cells.
						/// </summary>
						/// <returns>Value of property <code>columns</code></returns>
						public extern virtual int getColumns();

						/// <summary>
						/// Sets a new value for property {@link #getColumns columns}.
						/// 
						/// Number of columns. If not specified, the number of columns will be determined from the given cells.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="iColumns">New value for property <code>columns</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayout setColumns(int iColumns);

						#endregion

						#region Methods for Property widths

						/// <summary>
						/// Gets current value of property {@link #getWidths widths}.
						/// 
						/// Widths of the columns. Use an array to define the widths of the columns. If a column shall have an automatical sizing enter "auto" for this column width.
						/// </summary>
						/// <returns>Value of property <code>widths</code></returns>
						public extern virtual sap.ui.core.CSSSize[] getWidths();

						/// <summary>
						/// Sets a new value for property {@link #getWidths widths}.
						/// 
						/// Widths of the columns. Use an array to define the widths of the columns. If a column shall have an automatical sizing enter "auto" for this column width.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sWidths">New value for property <code>widths</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayout setWidths(sap.ui.core.CSSSize[] sWidths);

						#endregion

						#region Methods for Aggregation rows

						/// <summary>
						/// Gets content of aggregation {@link #getRows rows}.
						/// 
						/// The matrix layout's individual rows.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutRow[] getRows();

						/// <summary>
						/// Destroys all the rows in the aggregation {@link #getRows rows}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayout destroyRows();

						/// <summary>
						/// Inserts a row into the aggregation {@link #getRows rows}.
						/// </summary>
						/// <param name="oRow">The row to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the row should be inserted at; for a negative value of <code>iIndex</code>, the row is inserted at position 0; for a value greater than the current size of the aggregation, the row is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayout insertRow(sap.ui.commons.layout.MatrixLayoutRow oRow, int iIndex);

						/// <summary>
						/// Adds some row to the aggregation {@link #getRows rows}.
						/// </summary>
						/// <param name="oRow">The row to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayout addRow(sap.ui.commons.layout.MatrixLayoutRow oRow);

						/// <summary>
						/// Removes a row from the aggregation {@link #getRows rows}.
						/// </summary>
						/// <param name="vRow">The row to remove or its index or id</param>
						/// <returns>The removed row or <code>null</code></returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutRow removeRow(Union<int, string, sap.ui.commons.layout.MatrixLayoutRow> vRow);

						/// <summary>
						/// Checks for the provided <code>sap.ui.commons.layout.MatrixLayoutRow</code> in the aggregation {@link #getRows rows}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oRow">The row whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfRow(sap.ui.commons.layout.MatrixLayoutRow oRow);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getRows rows}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutRow[] removeAllRows();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new matrix layout row and appends it to this matrix layout.
						/// 
						/// Each argument must be either a matrix layout cell, which is added to the row "as is", or an arbitrary content control, which is wrapped with a new (default) matrix layout cell first and then added to the row.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayout createRow();

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.MatrixLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.MatrixLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.MatrixLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.layout.MatrixLayout.
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
