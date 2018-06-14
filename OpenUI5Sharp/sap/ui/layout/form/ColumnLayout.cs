using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class layout
			{
				public static partial class form
				{
					/// <summary>
					/// The <code>ColumnLayout</code> control renders a <code>Form</code> control in a column-based responsive way. Depending on its size, the <code>Form</code> control is divided into one or more columns. (XL - max. 4 columns, L - max. 3 columns, M - max. 2 columns and S - 1 column.)
					/// 
					/// The <code>FormContainer</code> elements are spread out to the columns depending on the number of <code>FormContainer</code> elements and their size. For example, if there are 4 columns and 2 <code>FormContainer</code> elements, each <code>FormContainer</code> element will use 2 columns. If there are 3 columns and 2 <code>FormContainer</code> elements, the larger one will use 2 columns, the smaller one 1 column. The size of a <code>FormContainer</code> element will be determined based on the number of visible <code>FormElement</code> elements assigned to it. If there are more <code>FormContainer</code> elements than columns, every <code>FormContainer</code> element uses only one column. So the last row of the <code>Form</code> control will not be fully used.
					/// 
					/// The default size of the <code>FormContainer</code> element can be overwritten by using <code>ColumnContainerData</code> as <code>LayoutData</code>. If one <code>FormContainer</code> element has <code>ColumnContainerData</code> set, the size calculation of the other <code>FormContainer</code> elements might not lead to the expected result. In this case, use <code>ColumnContainerData</code> also for the other <code>FormContainer</code> elements.
					/// 
					/// The <code>FormElement</code> elements are spread out to the columns of a <code>FormContainer</code> element arranged in a newspaper-like order. The position of the labels and fields depends on the size of the used column. If there is enough space, the labels are beside the fields, otherwise above the fields.
					/// 
					/// The default size of a content control of a <code>FormElement</code> element can be overwritten using <code>ColumnElementData</code> as <code>LayoutData</code>. If one control assigned to a <code>FormElement</code> element has <code>ColumnElementData</code> set, the size calculation of the other controls assigned to the <code>FormElement</code> element might not lead to the expected result. In this case, use <code>ColumnElementData</code> for the other controls, assigned to the <code>FormElement</code> element, too.
					/// 
					/// The placement of the <code>FormElement</code> elements is made by the browser <code>column-count</code> logic. So this can be different in different browsers and lead in some cases to other results than might be expected.
					/// 
					/// <b>Note:</b> This control cannot be used stand-alone, it just renders a <code>Form</code> control, so it must be assigned to a <code>Form</code> control using the <code>layout</code> aggregation.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class ColumnLayout : sap.ui.layout.form.FormLayout
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.layout.form.FormLayout.Settings
						{
							/// <summary>
							/// Number of columns for extra-large size.
							/// 
							/// The number of columns for extra-large size must not be smaller than the number of columns for large size.
							/// </summary>
							public Union<sap.ui.layout.form.ColumnsXL, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> columnsXL;

							/// <summary>
							/// Number of columns for large size.
							/// 
							/// The number of columns for large size must not be smaller than the number of columns for medium size.
							/// </summary>
							public Union<sap.ui.layout.form.ColumnsL, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> columnsL;

							/// <summary>
							/// Number of columns for medium size.
							/// </summary>
							public Union<sap.ui.layout.form.ColumnsM, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> columnsM;

							/// <summary>
							/// Defines how many cells a label uses if the column is large.
							/// </summary>
							public Union<sap.ui.layout.form.ColumnCells, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> labelCellsLarge;

							/// <summary>
							/// Defines how many cells are empty at the end of a row. This could be used to keep the fields small on large screens.
							/// </summary>
							public Union<sap.ui.layout.form.EmptyCells, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> emptyCellsLarge;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new <code>sap.ui.layout.form.ColumnLayout</code>.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern ColumnLayout(string sId, sap.ui.layout.form.ColumnLayout.Settings mSettings);

						/// <summary>
						/// Constructor for a new <code>sap.ui.layout.form.ColumnLayout</code>.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern ColumnLayout(string sId);

						/// <summary>
						/// Constructor for a new <code>sap.ui.layout.form.ColumnLayout</code>.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern ColumnLayout();

						/// <summary>
						/// Constructor for a new <code>sap.ui.layout.form.ColumnLayout</code>.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern ColumnLayout(sap.ui.layout.form.ColumnLayout.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property columnsXL

						/// <summary>
						/// Gets current value of property {@link #getColumnsXL columnsXL}.
						/// 
						/// Number of columns for extra-large size.
						/// 
						/// The number of columns for extra-large size must not be smaller than the number of columns for large size.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <returns>Value of property <code>columnsXL</code></returns>
						public extern virtual sap.ui.layout.form.ColumnsXL getColumnsXL();

						/// <summary>
						/// Sets a new value for property {@link #getColumnsXL columnsXL}.
						/// 
						/// Number of columns for extra-large size.
						/// 
						/// The number of columns for extra-large size must not be smaller than the number of columns for large size.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <param name="sColumnsXL">New value for property <code>columnsXL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ColumnLayout setColumnsXL(sap.ui.layout.form.ColumnsXL sColumnsXL);

						#endregion

						#region Methods for Property columnsL

						/// <summary>
						/// Gets current value of property {@link #getColumnsL columnsL}.
						/// 
						/// Number of columns for large size.
						/// 
						/// The number of columns for large size must not be smaller than the number of columns for medium size.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <returns>Value of property <code>columnsL</code></returns>
						public extern virtual sap.ui.layout.form.ColumnsL getColumnsL();

						/// <summary>
						/// Sets a new value for property {@link #getColumnsL columnsL}.
						/// 
						/// Number of columns for large size.
						/// 
						/// The number of columns for large size must not be smaller than the number of columns for medium size.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <param name="sColumnsL">New value for property <code>columnsL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ColumnLayout setColumnsL(sap.ui.layout.form.ColumnsL sColumnsL);

						#endregion

						#region Methods for Property columnsM

						/// <summary>
						/// Gets current value of property {@link #getColumnsM columnsM}.
						/// 
						/// Number of columns for medium size.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <returns>Value of property <code>columnsM</code></returns>
						public extern virtual sap.ui.layout.form.ColumnsM getColumnsM();

						/// <summary>
						/// Sets a new value for property {@link #getColumnsM columnsM}.
						/// 
						/// Number of columns for medium size.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <param name="sColumnsM">New value for property <code>columnsM</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ColumnLayout setColumnsM(sap.ui.layout.form.ColumnsM sColumnsM);

						#endregion

						#region Methods for Property labelCellsLarge

						/// <summary>
						/// Gets current value of property {@link #getLabelCellsLarge labelCellsLarge}.
						/// 
						/// Defines how many cells a label uses if the column is large.
						/// 
						/// Default value is <code>4</code>.
						/// </summary>
						/// <returns>Value of property <code>labelCellsLarge</code></returns>
						public extern virtual sap.ui.layout.form.ColumnCells getLabelCellsLarge();

						/// <summary>
						/// Sets a new value for property {@link #getLabelCellsLarge labelCellsLarge}.
						/// 
						/// Defines how many cells a label uses if the column is large.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>4</code>.
						/// </summary>
						/// <param name="sLabelCellsLarge">New value for property <code>labelCellsLarge</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ColumnLayout setLabelCellsLarge(sap.ui.layout.form.ColumnCells sLabelCellsLarge);

						#endregion

						#region Methods for Property emptyCellsLarge

						/// <summary>
						/// Gets current value of property {@link #getEmptyCellsLarge emptyCellsLarge}.
						/// 
						/// Defines how many cells are empty at the end of a row. This could be used to keep the fields small on large screens.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <returns>Value of property <code>emptyCellsLarge</code></returns>
						public extern virtual sap.ui.layout.form.EmptyCells getEmptyCellsLarge();

						/// <summary>
						/// Sets a new value for property {@link #getEmptyCellsLarge emptyCellsLarge}.
						/// 
						/// Defines how many cells are empty at the end of a row. This could be used to keep the fields small on large screens.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <param name="sEmptyCellsLarge">New value for property <code>emptyCellsLarge</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ColumnLayout setEmptyCellsLarge(sap.ui.layout.form.EmptyCells sEmptyCellsLarge);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ColumnLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ColumnLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ColumnLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.layout.form.ColumnLayout.
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
