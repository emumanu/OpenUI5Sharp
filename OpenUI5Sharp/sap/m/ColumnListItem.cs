using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// <code>sap.m.ColumnListItem</code> can be used with the <code>cells</code> aggregation to create rows for the <code>sap.m.Table</code> control. The <code>columns</code> aggregation of the <code>sap.m.Table</code> should match with the cells aggregation.
			/// 
			/// <b>Note:</b> This control should only be used within the <code>sap.m.Table</code> control. The inherited <code>counter</code> property of <code>sap.m.ListItemBase</code> is not supported.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ColumnListItem")]
			public partial class ColumnListItem : sap.m.ListItemBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ListItemBase.Settings
				{
					/// <summary>
					/// Sets the vertical alignment of all the cells within the table row (including selection and navigation). <b>Note:</b> <code>vAlign</code> property of <code>sap.m.Column</code> overrides the property for cell vertical alignment if both are set.
					/// </summary>
					public Union<sap.ui.core.VerticalAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> vAlign;

					/// <summary>
					/// Every <code>control</code> inside the <code>cells</code> aggregation defines one cell of the row. <b>Note:</b> The order of the <code>cells</code> aggregation must match the order of the <code>columns</code> aggregation of <code>sap.m.Table</code>.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> cells;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ColumnListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ColumnListItem(string sId, sap.m.ColumnListItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new ColumnListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				public extern ColumnListItem(string sId);

				/// <summary>
				/// Constructor for a new ColumnListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ColumnListItem();

				/// <summary>
				/// Constructor for a new ColumnListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ColumnListItem(sap.m.ColumnListItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property vAlign

				/// <summary>
				/// Gets current value of property {@link #getVAlign vAlign}.
				/// 
				/// Sets the vertical alignment of all the cells within the table row (including selection and navigation). <b>Note:</b> <code>vAlign</code> property of <code>sap.m.Column</code> overrides the property for cell vertical alignment if both are set.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>vAlign</code></returns>
				public extern virtual sap.ui.core.VerticalAlign getVAlign();

				/// <summary>
				/// Sets a new value for property {@link #getVAlign vAlign}.
				/// 
				/// Sets the vertical alignment of all the cells within the table row (including selection and navigation). <b>Note:</b> <code>vAlign</code> property of <code>sap.m.Column</code> overrides the property for cell vertical alignment if both are set.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sVAlign">New value for property <code>vAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColumnListItem setVAlign(sap.ui.core.VerticalAlign sVAlign);

				#endregion

				#region Methods for Aggregation cells

				/// <summary>
				/// Gets content of aggregation {@link #getCells cells}.
				/// 
				/// Every <code>control</code> inside the <code>cells</code> aggregation defines one cell of the row. <b>Note:</b> The order of the <code>cells</code> aggregation must match the order of the <code>columns</code> aggregation of <code>sap.m.Table</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getCells();

				/// <summary>
				/// Destroys all the cells in the aggregation {@link #getCells cells}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColumnListItem destroyCells();

				/// <summary>
				/// Inserts a cell into the aggregation {@link #getCells cells}.
				/// </summary>
				/// <param name="oCell">The cell to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the cell should be inserted at; for a negative value of <code>iIndex</code>, the cell is inserted at position 0; for a value greater than the current size of the aggregation, the cell is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColumnListItem insertCell(sap.ui.core.Control oCell, int iIndex);

				/// <summary>
				/// Adds some cell to the aggregation {@link #getCells cells}.
				/// </summary>
				/// <param name="oCell">The cell to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColumnListItem addCell(sap.ui.core.Control oCell);

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

				/// <summary>
				/// Binds aggregation {@link #getCells cells} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColumnListItem bindCells(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getCells cells} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColumnListItem unbindCells();

				#endregion

				#region Other methods

				/// <summary>
				/// Returns pop-in DOMRef as a jQuery Object
				/// </summary>
				[Name("$Popin")]
				public extern virtual void dollarPopin();

				/// <summary>
				/// Creates a new subclass of class sap.m.ColumnListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ColumnListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ColumnListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ColumnListItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Returns the pop-in element.
				/// </summary>
				public extern virtual void getPopin();

				/// <summary>
				/// Returns the tabbable DOM elements as a jQuery collection When popin is available this separated dom should also be included
				/// </summary>
				/// <returns>jQuery object</returns>
				public extern override jQuery getTabbables();

				/// <summary>
				/// Determines whether control has pop-in or not.
				/// </summary>
				public extern virtual void hasPopin();

				/// <summary>
				/// Pemove pop-in from DOM
				/// </summary>
				public extern virtual void removePopin();

				#endregion

				#endregion

			}
		}
	}
}
