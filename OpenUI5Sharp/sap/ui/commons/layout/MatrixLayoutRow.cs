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
					/// Non-control element used as part of a matrix layout's inner structure.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.MatrixLayoutRow")]
					[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.ui.layout.Grid</code> control.")]
					public partial class MatrixLayoutRow : sap.ui.core.Element
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
							/// Height of the row.
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

							/// <summary>
							/// The matrix layout row's individual cells.
							/// </summary>
							public Union<sap.ui.commons.layout.MatrixLayoutCell[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> cells;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new layout/MatrixLayoutRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern MatrixLayoutRow(string sId, sap.ui.commons.layout.MatrixLayoutRow.Settings mSettings);

						/// <summary>
						/// Constructor for a new layout/MatrixLayoutRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern MatrixLayoutRow(string sId);

						/// <summary>
						/// Constructor for a new layout/MatrixLayoutRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern MatrixLayoutRow();

						/// <summary>
						/// Constructor for a new layout/MatrixLayoutRow.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern MatrixLayoutRow(sap.ui.commons.layout.MatrixLayoutRow.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property height

						/// <summary>
						/// Gets current value of property {@link #getHeight height}.
						/// 
						/// Height of the row.
						/// </summary>
						/// <returns>Value of property <code>height</code></returns>
						public extern virtual sap.ui.core.CSSSize getHeight();

						/// <summary>
						/// Sets a new value for property {@link #getHeight height}.
						/// 
						/// Height of the row.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sHeight">New value for property <code>height</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutRow setHeight(sap.ui.core.CSSSize sHeight);

						#endregion

						#region Methods for Aggregation cells

						/// <summary>
						/// Gets content of aggregation {@link #getCells cells}.
						/// 
						/// The matrix layout row's individual cells.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell[] getCells();

						/// <summary>
						/// Destroys all the cells in the aggregation {@link #getCells cells}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutRow destroyCells();

						/// <summary>
						/// Inserts a cell into the aggregation {@link #getCells cells}.
						/// </summary>
						/// <param name="oCell">The cell to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the cell should be inserted at; for a negative value of <code>iIndex</code>, the cell is inserted at position 0; for a value greater than the current size of the aggregation, the cell is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutRow insertCell(sap.ui.commons.layout.MatrixLayoutCell oCell, int iIndex);

						/// <summary>
						/// Adds some cell to the aggregation {@link #getCells cells}.
						/// </summary>
						/// <param name="oCell">The cell to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutRow addCell(sap.ui.commons.layout.MatrixLayoutCell oCell);

						/// <summary>
						/// Removes a cell from the aggregation {@link #getCells cells}.
						/// </summary>
						/// <param name="vCell">The cell to remove or its index or id</param>
						/// <returns>The removed cell or <code>null</code></returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell removeCell(Union<int, string, sap.ui.commons.layout.MatrixLayoutCell> vCell);

						/// <summary>
						/// Checks for the provided <code>sap.ui.commons.layout.MatrixLayoutCell</code> in the aggregation {@link #getCells cells}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oCell">The cell whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfCell(sap.ui.commons.layout.MatrixLayoutCell oCell);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getCells cells}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell[] removeAllCells();

						#endregion

						#region Other methods

						/// <summary>
						/// The string given as "sStyleClass" will be added to the "class" attribute of this element's root HTML element.
						/// 
						/// This method is intended to be used to mark controls as being of a special type for which special styling can be provided using CSS selectors that reference this style class name.
						/// 
						/// <pre>
						/// Example:
						/// myButton.addStyleClass("myRedTextButton"); // add a CSS class to one button instance
						/// 
						/// ...and in CSS:
						/// .myRedTextButton {
						/// color: red;
						/// }
						/// </pre>
						/// 
						/// This will add the CSS class "myRedTextButton" to the Button HTML and the CSS code above will then make the text in this particular button red.
						/// 
						/// Only characters allowed inside HTML attributes are allowed. Quotes are not allowed and this method will ignore any strings containing quotes. Strings containing spaces are interpreted as ONE custom style class (even though CSS selectors interpret them as different classes) and can only removed later by calling removeStyleClass() with exactly the same (space-containing) string as parameter. Multiple calls with the same sStyleClass will have no different effect than calling once. If sStyleClass is null, the call is ignored.
						/// 
						/// Returns <code>this</code> to allow method chaining
						/// </summary>
						/// <param name="sStyleClass">the CSS class name to be added</param>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutRow addStyleClass(string sStyleClass);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.MatrixLayoutRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.MatrixLayoutRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.MatrixLayoutRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.layout.MatrixLayoutRow.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Returns true if the given style class string is valid and if this Element has this style class set via a previous call to addStyleClass().
						/// </summary>
						/// <param name="sStyleClass">the style to check for</param>
						/// <returns></returns>
						public extern virtual bool hasStyleClass(string sStyleClass);

						/// <summary>
						/// Removes the given string from the list of custom style classes that have been set previously. Regular style classes like "sapUiBtn" cannot be removed.
						/// 
						/// Returns <code>this</code> to allow method chaining
						/// </summary>
						/// <param name="sStyleClass">the style to be removed</param>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutRow removeStyleClass(string sStyleClass);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
