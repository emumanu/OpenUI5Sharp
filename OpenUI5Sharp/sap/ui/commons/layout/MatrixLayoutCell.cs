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
					[Name("sap.ui.commons.layout.MatrixLayoutCell")]
					[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.ui.layout.Grid</code> control.")]
					public partial class MatrixLayoutCell : sap.ui.core.Element
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
							/// Determines the matrix layout cell's background design.
							/// </summary>
							public Union<sap.ui.commons.layout.BackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

							/// <summary>
							/// Determines how many columns of the underlying grid structure are occupied by this matrix layout cell.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> colSpan;

							/// <summary>
							/// Determines the horizontal alignment of the matrix layout cell's content with the cell's borders.
							/// </summary>
							public Union<sap.ui.commons.layout.HAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> hAlign;

							/// <summary>
							/// Determines the padding of the matrix layout cell's content within the cell's borders. The default value is appropriate for all cells in a form-like layout. Consider to remove the padding on the outer layout in case of nesting.
							/// </summary>
							public Union<sap.ui.commons.layout.Padding, string, sap.ui.@base.ManagedObject.BindPropertyInfo> padding;

							/// <summary>
							/// Determines how many rows of the underlying grid structure are occupied by this matrix layout cell. In case a row-height is used, all rows affected by the RowSpan must have the same unit.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> rowSpan;

							/// <summary>
							/// Determines how a matrix layout cell is separated from its predecessor, via a vertical gutter of variable width, with or without a vertical line.
							/// </summary>
							public Union<sap.ui.commons.layout.Separation, string, sap.ui.@base.ManagedObject.BindPropertyInfo> separation;

							/// <summary>
							/// Determines the vertical alignment of the matrix layout cell's content with the cell's borders.
							/// </summary>
							public Union<sap.ui.commons.layout.VAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> vAlign;

							/// <summary>
							/// The matrix layout cell's content (arbitrary controls).
							/// 
							/// If the matrix row has a defined height and the matrix has layoutFixed = true, the controls inside of a cell should all use the same unit for its height property.
							/// </summary>
							public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new layout/MatrixLayoutCell.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern MatrixLayoutCell(string sId, sap.ui.commons.layout.MatrixLayoutCell.Settings mSettings);

						/// <summary>
						/// Constructor for a new layout/MatrixLayoutCell.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern MatrixLayoutCell(string sId);

						/// <summary>
						/// Constructor for a new layout/MatrixLayoutCell.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern MatrixLayoutCell();

						/// <summary>
						/// Constructor for a new layout/MatrixLayoutCell.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern MatrixLayoutCell(sap.ui.commons.layout.MatrixLayoutCell.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property backgroundDesign

						/// <summary>
						/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
						/// 
						/// Determines the matrix layout cell's background design.
						/// 
						/// Default value is <code>Transparent</code>.
						/// </summary>
						/// <returns>Value of property <code>backgroundDesign</code></returns>
						public extern virtual sap.ui.commons.layout.BackgroundDesign getBackgroundDesign();

						/// <summary>
						/// Sets a new value for property {@link #getBackgroundDesign backgroundDesign}.
						/// 
						/// Determines the matrix layout cell's background design.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>Transparent</code>.
						/// </summary>
						/// <param name="sBackgroundDesign">New value for property <code>backgroundDesign</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell setBackgroundDesign(sap.ui.commons.layout.BackgroundDesign sBackgroundDesign);

						#endregion

						#region Methods for Property colSpan

						/// <summary>
						/// Gets current value of property {@link #getColSpan colSpan}.
						/// 
						/// Determines how many columns of the underlying grid structure are occupied by this matrix layout cell.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <returns>Value of property <code>colSpan</code></returns>
						public extern virtual int getColSpan();

						/// <summary>
						/// Sets a new value for property {@link #getColSpan colSpan}.
						/// 
						/// Determines how many columns of the underlying grid structure are occupied by this matrix layout cell.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <param name="iColSpan">New value for property <code>colSpan</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell setColSpan(int iColSpan);

						#endregion

						#region Methods for Property hAlign

						/// <summary>
						/// Gets current value of property {@link #getHAlign hAlign}.
						/// 
						/// Determines the horizontal alignment of the matrix layout cell's content with the cell's borders.
						/// 
						/// Default value is <code>Begin</code>.
						/// </summary>
						/// <returns>Value of property <code>hAlign</code></returns>
						public extern virtual sap.ui.commons.layout.HAlign getHAlign();

						/// <summary>
						/// Sets a new value for property {@link #getHAlign hAlign}.
						/// 
						/// Determines the horizontal alignment of the matrix layout cell's content with the cell's borders.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>Begin</code>.
						/// </summary>
						/// <param name="sHAlign">New value for property <code>hAlign</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell setHAlign(sap.ui.commons.layout.HAlign sHAlign);

						#endregion

						#region Methods for Property padding

						/// <summary>
						/// Gets current value of property {@link #getPadding padding}.
						/// 
						/// Determines the padding of the matrix layout cell's content within the cell's borders. The default value is appropriate for all cells in a form-like layout. Consider to remove the padding on the outer layout in case of nesting.
						/// 
						/// Default value is <code>End</code>.
						/// </summary>
						/// <returns>Value of property <code>padding</code></returns>
						public extern virtual sap.ui.commons.layout.Padding getPadding();

						/// <summary>
						/// Sets a new value for property {@link #getPadding padding}.
						/// 
						/// Determines the padding of the matrix layout cell's content within the cell's borders. The default value is appropriate for all cells in a form-like layout. Consider to remove the padding on the outer layout in case of nesting.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>End</code>.
						/// </summary>
						/// <param name="sPadding">New value for property <code>padding</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell setPadding(sap.ui.commons.layout.Padding sPadding);

						#endregion

						#region Methods for Property rowSpan

						/// <summary>
						/// Gets current value of property {@link #getRowSpan rowSpan}.
						/// 
						/// Determines how many rows of the underlying grid structure are occupied by this matrix layout cell. In case a row-height is used, all rows affected by the RowSpan must have the same unit.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <returns>Value of property <code>rowSpan</code></returns>
						public extern virtual int getRowSpan();

						/// <summary>
						/// Sets a new value for property {@link #getRowSpan rowSpan}.
						/// 
						/// Determines how many rows of the underlying grid structure are occupied by this matrix layout cell. In case a row-height is used, all rows affected by the RowSpan must have the same unit.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <param name="iRowSpan">New value for property <code>rowSpan</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell setRowSpan(int iRowSpan);

						#endregion

						#region Methods for Property separation

						/// <summary>
						/// Gets current value of property {@link #getSeparation separation}.
						/// 
						/// Determines how a matrix layout cell is separated from its predecessor, via a vertical gutter of variable width, with or without a vertical line.
						/// 
						/// Default value is <code>None</code>.
						/// </summary>
						/// <returns>Value of property <code>separation</code></returns>
						public extern virtual sap.ui.commons.layout.Separation getSeparation();

						/// <summary>
						/// Sets a new value for property {@link #getSeparation separation}.
						/// 
						/// Determines how a matrix layout cell is separated from its predecessor, via a vertical gutter of variable width, with or without a vertical line.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>None</code>.
						/// </summary>
						/// <param name="sSeparation">New value for property <code>separation</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell setSeparation(sap.ui.commons.layout.Separation sSeparation);

						#endregion

						#region Methods for Property vAlign

						/// <summary>
						/// Gets current value of property {@link #getVAlign vAlign}.
						/// 
						/// Determines the vertical alignment of the matrix layout cell's content with the cell's borders.
						/// 
						/// Default value is <code>Middle</code>.
						/// </summary>
						/// <returns>Value of property <code>vAlign</code></returns>
						public extern virtual sap.ui.commons.layout.VAlign getVAlign();

						/// <summary>
						/// Sets a new value for property {@link #getVAlign vAlign}.
						/// 
						/// Determines the vertical alignment of the matrix layout cell's content with the cell's borders.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>Middle</code>.
						/// </summary>
						/// <param name="sVAlign">New value for property <code>vAlign</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell setVAlign(sap.ui.commons.layout.VAlign sVAlign);

						#endregion

						#region Methods for Aggregation content

						/// <summary>
						/// Gets content of aggregation {@link #getContent content}.
						/// 
						/// The matrix layout cell's content (arbitrary controls).
						/// 
						/// If the matrix row has a defined height and the matrix has layoutFixed = true, the controls inside of a cell should all use the same unit for its height property.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.Control[] getContent();

						/// <summary>
						/// Destroys all the content in the aggregation {@link #getContent content}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell destroyContent();

						/// <summary>
						/// Inserts a content into the aggregation {@link #getContent content}.
						/// </summary>
						/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell insertContent(sap.ui.core.Control oContent, int iIndex);

						/// <summary>
						/// Adds some content to the aggregation {@link #getContent content}.
						/// </summary>
						/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell addContent(sap.ui.core.Control oContent);

						/// <summary>
						/// Removes a content from the aggregation {@link #getContent content}.
						/// </summary>
						/// <param name="vContent">The content to remove or its index or id</param>
						/// <returns>The removed content or <code>null</code></returns>
						public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

						/// <summary>
						/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oContent">The content whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfContent(sap.ui.core.Control oContent);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getContent content}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.Control[] removeAllContent();

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
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell addStyleClass(string sStyleClass);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.MatrixLayoutCell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.MatrixLayoutCell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.MatrixLayoutCell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.layout.MatrixLayoutCell.
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
						public extern virtual sap.ui.commons.layout.MatrixLayoutCell removeStyleClass(string sStyleClass);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
