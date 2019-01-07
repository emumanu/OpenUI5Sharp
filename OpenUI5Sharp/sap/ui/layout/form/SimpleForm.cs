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
			public static partial class layout
			{
				public static partial class form
				{
					/// <summary>
					/// The <code>SimpleForm</code> provides an easy-to-use API to create simple forms. Inside a <code>SimpleForm</code>, a <code>Form</code> control is created along with its <code>FormContainers</code> and <code>FormElements</code>, but the complexity in the API is removed. <ul> <li>A new <code>Title</code> or <code>Toolbar</code> starts a new group (<code>FormContainer</code>) in the form.</li> <li>A new <code>Label</code> starts a new row (<code>FormElement</code>) in the form.</li> <li>All other controls will be assigned to the row (<code>FormElement</code>) that started with the last label.</li> </ul> Use <code>LayoutData</code> to influence the layout for special cases in the Input/Display controls.
					/// 
					/// <b>Note:</b> If a more complex form is needed, use <code>Form</code> instead.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.layout.form.SimpleForm")]
					public partial class SimpleForm : sap.ui.core.Control
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
							/// The maximum amount of groups (<code>FormContainers</code>) per row that is used before a new row is started.
							/// 
							/// <b>Note:</b> If a <code>ResponsiveGridLayout</code> is used as a <code>layout</code>, this property is not used. Please use the properties <code>ColumnsL</code> and <code>ColumnsM</code> in this case.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxContainerCols;

							/// <summary>
							/// The overall minimum width in pixels that is used for the <code>SimpleForm</code>.
							/// 
							/// If the available width is below the given <code>minWidth</code> the <code>SimpleForm</code> will create a new row for the next group (<code>FormContainer</code>). The default value is -1, meaning that inner groups (<code>FormContainers</code>) will be stacked until <code>maxContainerCols</code> is reached, irrespective of whether a <code>width</code> is reached or the available parents width is reached.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveLayout</code> is used as a layout.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minWidth;

							/// <summary>
							/// Width of the form.
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

							/// <summary>
							/// Applies a device-specific and theme-specific line height and label alignment to the form rows if the form has editable content. If set, all (not only the editable) rows of the form will get the line height of editable fields.
							/// 
							/// The labels inside the form will be rendered by default in the according mode.
							/// 
							/// <b>Note:</b> The setting of this property does not change the content of the form. For example, <code>Input</code> controls in a form with <code>editable</code> set to false are still editable.
							/// 
							/// <b>Warning:</b> If this property is wrongly set, this might lead to visual issues. The labels and fields might be misaligned, the labels might be rendered in the wrong mode, and the spacing between the single controls might be wrong. Also, controls that do not fit the mode might be rendered incorrectly.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

							/// <summary>
							/// Specifies the min-width in pixels of the label in all form rows.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveLayout</code> is used as a layout.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> labelMinWidth;

							/// <summary>
							/// The <code>FormLayout</code> that is used to render the <code>SimpleForm</code>.
							/// 
							/// We recommend using the <code>ResponsiveGridLayout</code> for rendering a <code>SimpleForm</code>, as its responsiveness uses the space available in the best way possible.
							/// 
							/// <b>Note</b> If possible, set the <code>layout</code> before adding content to prevent calculations for the default layout.
							/// </summary>
							public Union<sap.ui.layout.form.SimpleFormLayout, string, sap.ui.@base.ManagedObject.BindPropertyInfo> layout;

							/// <summary>
							/// Default span for labels in extra large size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout. If the default value -1 is not overwritten with the meaningful one then the <code>labelSpanL</code> value is used (from the backward compatibility reasons).
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> labelSpanXL;

							/// <summary>
							/// Default span for labels in large size.
							/// 
							/// <b>Note:</b> If <code>adjustLabelSpan</code> is set, this property is only used if more than 1 <code>FormContainer</code> is in one line. If only 1 <code>FormContainer</code> is in the line, then the <code>labelSpanM</code> value is used.
							/// 
							/// <b>Note:</b> This property is only used if <code>ResponsiveGridLayout</code> or <code>ColumnLayout</code> is used as a layout. If a <code>ColumnLayout</code> is used, this property defines the label size for large columns.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> labelSpanL;

							/// <summary>
							/// Default span for labels in medium size.
							/// 
							/// <b>Note:</b> If <code>adjustLabelSpan</code> is set, this property is used for full-size <code>FormContainers</code>. If more than one <code>FormContainer</code> is in one line, <code>labelSpanL</code> is used.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> labelSpanM;

							/// <summary>
							/// Default span for labels in small size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> labelSpanS;

							/// <summary>
							/// If set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the number of <code>FormContainers</code> in one row. If only one <code>FormContainer</code> is displayed in one row, <code>labelSpanM</code> is used to define the size of the label. This is the same for medium and large <code>Forms</code>. This is done to align the labels on forms where full-size <code>FormContainers</code> and multiple-column rows are used in the same <code>Form</code> (because every <code>FormContainer</code> has its own grid inside).
							/// 
							/// If not set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the <code>Form</code> size. The number of <code>FormContainers</code> doesn't matter in this case.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> adjustLabelSpan;

							/// <summary>
							/// Number of grid cells that are empty at the end of each line on extra large size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout. If the default value -1 is not overwritten with the meaningful one then the <code>emptySpanL</code> value is used (from the backward compatibility reasons).
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> emptySpanXL;

							/// <summary>
							/// Number of grid cells that are empty at the end of each line on large size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout. If a <code>ColumnLayout</code> is used, this property defines the empty cells for large columns.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> emptySpanL;

							/// <summary>
							/// Number of grid cells that are empty at the end of each line on medium size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> emptySpanM;

							/// <summary>
							/// Number of grid cells that are empty at the end of each line on small size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> emptySpanS;

							/// <summary>
							/// Form columns for extra large size. The number of columns for extra large size must not be smaller than the number of columns for large size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout. If the default value -1 is not overwritten with the meaningful one then the <code>columnsL</code> value is used (from the backward compatibility reasons).
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnsXL;

							/// <summary>
							/// Form columns for large size. The number of columns for large size must not be smaller than the number of columns for medium size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnsL;

							/// <summary>
							/// Form columns for medium size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnsM;

							/// <summary>
							/// If the <code>Form</code> contains only one single <code>FormContainer</code> and this property is set, the <code>FormContainer</code> is displayed using the full size of the <code>Form</code>. In this case the properties <code>columnsL</code> and <code>columnsM</code> are ignored.
							/// 
							/// In all other cases the <code>FormContainer</code> is displayed in the size of one column.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> singleContainerFullSize;

							/// <summary>
							/// Breakpoint between Medium size and Large size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> breakpointXL;

							/// <summary>
							/// Breakpoint between Medium size and Large size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> breakpointL;

							/// <summary>
							/// Breakpoint between Small size and Medium size.
							/// 
							/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> breakpointM;

							/// <summary>
							/// Specifies the background color of the <code>SimpleForm</code> content.
							/// 
							/// The visualization of the different options depends on the used theme.
							/// </summary>
							public Union<sap.ui.layout.BackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

							/// <summary>
							/// The content of the form is structured in the following way: <ul> <li>Add a <code>Title</code> or <code>Toolbar</code> control to start a new group (<code>FormContainer</code>).</li> <li>Add a <code>Label</code> control to start a new row (<code>FormElement</code>).</li> <li>Add controls as input fields, text fields or other as needed.</li> <li>Use <code>LayoutData</code> to influence the layout for special cases in the single controls. For example, if a <code>ResponsiveLayout</code> is used as a layout, the form content is weighted using weight 3 for the labels and weight 5 for the fields part. By default the label column is 192 pixels wide. If your input controls should influence their width, you can add <code>sap.ui.layout.ResponsiveFlowLayoutData</code> to them via <code>setLayoutData</code> method. Ensure that the sum of the weights in the <code>ResponsiveFlowLayoutData</code> is not more than 5, as this is the total width of the input control part of each form row.</li> </ul> Example for a row where the <code>Input</code> weight 4 and the second <code>Input</code> weight 1 (using <code>ResponsiveLayout</code>): <pre>
							/// new sap.m.Label({text:"Label"});
							/// new sap.m.Input({value:"Weight 4", layoutData: new sap.ui.layout.ResponsiveFlowLayoutData({weight:4})}),
							/// new sap.m.Input({value:"Weight 1", layoutData: new sap.ui.layout.ResponsiveFlowLayoutData({weight:1})}),
							/// </pre>
							/// 
							/// For example, if a <code>ResponsiveGridLayout</code> is used as a layout, there are 12 cells in one row. Depending on the screen size the labels use the defined <code>labelSpan</code>. The remaining cells are used for the fields (and <code>emptySpan</code> if defined). The available cells are distributed to all fields in the row. If one field should use a fixed number of cells you can add <code>sap.ui.layout.GridData</code> to them via <code>setLayoutData</code> method. If there are additional fields in the row they will get the remaining cells. </ul> Example for a row with two <code>Input</code> controls where one uses four cells on small screens, one cell on medium screens and 2 cells on larger screens (using <code>ResponsiveGridLayout</code>): <pre>
							/// new sap.m.Label({text:"Label"});
							/// new sap.m.Input({value:"auto size"}),
							/// new sap.m.Input({value:"fix size", layoutData: new sap.ui.layout.GridData({span: "XL1 L1 M2 S4"})}),
							/// </pre>
							/// 
							/// <b>Warning:</b> Do not put any layout or other container controls in here. This could damage the visual layout, keyboard support and screen-reader support. Only labels, titles, toolbars and form controls are allowed. Views are also not supported. Allowed form controls implement the interface <code>sap.ui.core.IFormContent</code>.
							/// 
							/// If editable controls are used as content, the <code>editable</code> property must be set to <code>true</code>, otherwise to <code>false</code>. If the <code>editable</code> property is set incorrectly, there will be visual issues like wrong label alignment or wrong spacing between the controls.
							/// </summary>
							public Union<sap.ui.core.Element[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

							/// <summary>
							/// Title element of the <code>SimpleForm</code>. Can either be a <code>Title</code> element, or a string.
							/// </summary>
							public Union<sap.ui.core.Title, string, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

							/// <summary>
							/// Toolbar of the <code>SimpleForm</code>.
							/// 
							/// <b>Note:</b> If a <code>Toolbar</code> is used, the <code>Title</code> is ignored. If a title is needed inside the <code>Toolbar</code> it must be added at content to the <code>Toolbar</code>. In this case add the <code>Title</code> to the <code>ariaLabelledBy</code> association.
							/// </summary>
							public Union<sap.ui.core.Toolbar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> toolbar;

							/// <summary>
							/// Association to controls / IDs which label this control (see WAI-ARIA attribute <code>aria-labelledby</code>).
							/// </summary>
							public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.SimpleForm.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern SimpleForm(string sId, sap.ui.layout.form.SimpleForm.Settings mSettings);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.SimpleForm.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern SimpleForm(string sId);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.SimpleForm.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern SimpleForm();

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.SimpleForm.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern SimpleForm(sap.ui.layout.form.SimpleForm.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property maxContainerCols

						/// <summary>
						/// Gets current value of property {@link #getMaxContainerCols maxContainerCols}.
						/// 
						/// The maximum amount of groups (<code>FormContainers</code>) per row that is used before a new row is started.
						/// 
						/// <b>Note:</b> If a <code>ResponsiveGridLayout</code> is used as a <code>layout</code>, this property is not used. Please use the properties <code>ColumnsL</code> and <code>ColumnsM</code> in this case.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <returns>Value of property <code>maxContainerCols</code></returns>
						public extern virtual int getMaxContainerCols();

						/// <summary>
						/// Sets a new value for property {@link #getMaxContainerCols maxContainerCols}.
						/// 
						/// The maximum amount of groups (<code>FormContainers</code>) per row that is used before a new row is started.
						/// 
						/// <b>Note:</b> If a <code>ResponsiveGridLayout</code> is used as a <code>layout</code>, this property is not used. Please use the properties <code>ColumnsL</code> and <code>ColumnsM</code> in this case.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <param name="iMaxContainerCols">New value for property <code>maxContainerCols</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setMaxContainerCols(int iMaxContainerCols);

						#endregion

						#region Methods for Property minWidth

						/// <summary>
						/// Gets current value of property {@link #getMinWidth minWidth}.
						/// 
						/// The overall minimum width in pixels that is used for the <code>SimpleForm</code>.
						/// 
						/// If the available width is below the given <code>minWidth</code> the <code>SimpleForm</code> will create a new row for the next group (<code>FormContainer</code>). The default value is -1, meaning that inner groups (<code>FormContainers</code>) will be stacked until <code>maxContainerCols</code> is reached, irrespective of whether a <code>width</code> is reached or the available parents width is reached.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveLayout</code> is used as a layout.
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <returns>Value of property <code>minWidth</code></returns>
						public extern virtual int getMinWidth();

						/// <summary>
						/// Sets a new value for property {@link #getMinWidth minWidth}.
						/// 
						/// The overall minimum width in pixels that is used for the <code>SimpleForm</code>.
						/// 
						/// If the available width is below the given <code>minWidth</code> the <code>SimpleForm</code> will create a new row for the next group (<code>FormContainer</code>). The default value is -1, meaning that inner groups (<code>FormContainers</code>) will be stacked until <code>maxContainerCols</code> is reached, irrespective of whether a <code>width</code> is reached or the available parents width is reached.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <param name="iMinWidth">New value for property <code>minWidth</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setMinWidth(int iMinWidth);

						#endregion

						#region Methods for Property width

						/// <summary>
						/// Gets current value of property {@link #getWidth width}.
						/// 
						/// Width of the form.
						/// </summary>
						/// <returns>Value of property <code>width</code></returns>
						public extern virtual sap.ui.core.CSSSize getWidth();

						/// <summary>
						/// Sets a new value for property {@link #getWidth width}.
						/// 
						/// Width of the form.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sWidth">New value for property <code>width</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setWidth(sap.ui.core.CSSSize sWidth);

						#endregion

						#region Methods for Property editable

						/// <summary>
						/// Gets current value of property {@link #getEditable editable}.
						/// 
						/// Applies a device-specific and theme-specific line height and label alignment to the form rows if the form has editable content. If set, all (not only the editable) rows of the form will get the line height of editable fields.
						/// 
						/// The labels inside the form will be rendered by default in the according mode.
						/// 
						/// <b>Note:</b> The setting of this property does not change the content of the form. For example, <code>Input</code> controls in a form with <code>editable</code> set to false are still editable.
						/// 
						/// <b>Warning:</b> If this property is wrongly set, this might lead to visual issues. The labels and fields might be misaligned, the labels might be rendered in the wrong mode, and the spacing between the single controls might be wrong. Also, controls that do not fit the mode might be rendered incorrectly.
						/// </summary>
						/// <returns>Value of property <code>editable</code></returns>
						public extern virtual bool getEditable();

						/// <summary>
						/// Sets a new value for property {@link #getEditable editable}.
						/// 
						/// Applies a device-specific and theme-specific line height and label alignment to the form rows if the form has editable content. If set, all (not only the editable) rows of the form will get the line height of editable fields.
						/// 
						/// The labels inside the form will be rendered by default in the according mode.
						/// 
						/// <b>Note:</b> The setting of this property does not change the content of the form. For example, <code>Input</code> controls in a form with <code>editable</code> set to false are still editable.
						/// 
						/// <b>Warning:</b> If this property is wrongly set, this might lead to visual issues. The labels and fields might be misaligned, the labels might be rendered in the wrong mode, and the spacing between the single controls might be wrong. Also, controls that do not fit the mode might be rendered incorrectly.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="bEditable">New value for property <code>editable</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setEditable(bool bEditable);

						#endregion

						#region Methods for Property labelMinWidth

						/// <summary>
						/// Gets current value of property {@link #getLabelMinWidth labelMinWidth}.
						/// 
						/// Specifies the min-width in pixels of the label in all form rows.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveLayout</code> is used as a layout.
						/// 
						/// Default value is <code>192</code>.
						/// </summary>
						/// <returns>Value of property <code>labelMinWidth</code></returns>
						public extern virtual int getLabelMinWidth();

						/// <summary>
						/// Sets a new value for property {@link #getLabelMinWidth labelMinWidth}.
						/// 
						/// Specifies the min-width in pixels of the label in all form rows.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>192</code>.
						/// </summary>
						/// <param name="iLabelMinWidth">New value for property <code>labelMinWidth</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setLabelMinWidth(int iLabelMinWidth);

						#endregion

						#region Methods for Property layout

						/// <summary>
						/// Gets current value of property {@link #getLayout layout}.
						/// 
						/// The <code>FormLayout</code> that is used to render the <code>SimpleForm</code>.
						/// 
						/// We recommend using the <code>ResponsiveGridLayout</code> for rendering a <code>SimpleForm</code>, as its responsiveness uses the space available in the best way possible.
						/// 
						/// <b>Note</b> If possible, set the <code>layout</code> before adding content to prevent calculations for the default layout.
						/// 
						/// Default value is <code>ResponsiveLayout</code>.
						/// </summary>
						/// <returns>Value of property <code>layout</code></returns>
						public extern virtual sap.ui.layout.form.SimpleFormLayout getLayout();

						/// <summary>
						/// Sets a new value for property {@link #getLayout layout}.
						/// 
						/// The <code>FormLayout</code> that is used to render the <code>SimpleForm</code>.
						/// 
						/// We recommend using the <code>ResponsiveGridLayout</code> for rendering a <code>SimpleForm</code>, as its responsiveness uses the space available in the best way possible.
						/// 
						/// <b>Note</b> If possible, set the <code>layout</code> before adding content to prevent calculations for the default layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>ResponsiveLayout</code>.
						/// </summary>
						/// <param name="sLayout">New value for property <code>layout</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setLayout(sap.ui.layout.form.SimpleFormLayout sLayout);

						#endregion

						#region Methods for Property labelSpanXL

						/// <summary>
						/// Gets current value of property {@link #getLabelSpanXL labelSpanXL}.
						/// 
						/// Default span for labels in extra large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout. If the default value -1 is not overwritten with the meaningful one then the <code>labelSpanL</code> value is used (from the backward compatibility reasons).
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <returns>Value of property <code>labelSpanXL</code></returns>
						public extern virtual int getLabelSpanXL();

						/// <summary>
						/// Sets a new value for property {@link #getLabelSpanXL labelSpanXL}.
						/// 
						/// Default span for labels in extra large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout. If the default value -1 is not overwritten with the meaningful one then the <code>labelSpanL</code> value is used (from the backward compatibility reasons).
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <param name="iLabelSpanXL">New value for property <code>labelSpanXL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setLabelSpanXL(int iLabelSpanXL);

						#endregion

						#region Methods for Property labelSpanL

						/// <summary>
						/// Gets current value of property {@link #getLabelSpanL labelSpanL}.
						/// 
						/// Default span for labels in large size.
						/// 
						/// <b>Note:</b> If <code>adjustLabelSpan</code> is set, this property is only used if more than 1 <code>FormContainer</code> is in one line. If only 1 <code>FormContainer</code> is in the line, then the <code>labelSpanM</code> value is used.
						/// 
						/// <b>Note:</b> This property is only used if <code>ResponsiveGridLayout</code> or <code>ColumnLayout</code> is used as a layout. If a <code>ColumnLayout</code> is used, this property defines the label size for large columns.
						/// 
						/// Default value is <code>4</code>.
						/// </summary>
						/// <returns>Value of property <code>labelSpanL</code></returns>
						public extern virtual int getLabelSpanL();

						/// <summary>
						/// Sets a new value for property {@link #getLabelSpanL labelSpanL}.
						/// 
						/// Default span for labels in large size.
						/// 
						/// <b>Note:</b> If <code>adjustLabelSpan</code> is set, this property is only used if more than 1 <code>FormContainer</code> is in one line. If only 1 <code>FormContainer</code> is in the line, then the <code>labelSpanM</code> value is used.
						/// 
						/// <b>Note:</b> This property is only used if <code>ResponsiveGridLayout</code> or <code>ColumnLayout</code> is used as a layout. If a <code>ColumnLayout</code> is used, this property defines the label size for large columns.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>4</code>.
						/// </summary>
						/// <param name="iLabelSpanL">New value for property <code>labelSpanL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setLabelSpanL(int iLabelSpanL);

						#endregion

						#region Methods for Property labelSpanM

						/// <summary>
						/// Gets current value of property {@link #getLabelSpanM labelSpanM}.
						/// 
						/// Default span for labels in medium size.
						/// 
						/// <b>Note:</b> If <code>adjustLabelSpan</code> is set, this property is used for full-size <code>FormContainers</code>. If more than one <code>FormContainer</code> is in one line, <code>labelSpanL</code> is used.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <returns>Value of property <code>labelSpanM</code></returns>
						public extern virtual int getLabelSpanM();

						/// <summary>
						/// Sets a new value for property {@link #getLabelSpanM labelSpanM}.
						/// 
						/// Default span for labels in medium size.
						/// 
						/// <b>Note:</b> If <code>adjustLabelSpan</code> is set, this property is used for full-size <code>FormContainers</code>. If more than one <code>FormContainer</code> is in one line, <code>labelSpanL</code> is used.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <param name="iLabelSpanM">New value for property <code>labelSpanM</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setLabelSpanM(int iLabelSpanM);

						#endregion

						#region Methods for Property labelSpanS

						/// <summary>
						/// Gets current value of property {@link #getLabelSpanS labelSpanS}.
						/// 
						/// Default span for labels in small size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// Default value is <code>12</code>.
						/// </summary>
						/// <returns>Value of property <code>labelSpanS</code></returns>
						public extern virtual int getLabelSpanS();

						/// <summary>
						/// Sets a new value for property {@link #getLabelSpanS labelSpanS}.
						/// 
						/// Default span for labels in small size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>12</code>.
						/// </summary>
						/// <param name="iLabelSpanS">New value for property <code>labelSpanS</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setLabelSpanS(int iLabelSpanS);

						#endregion

						#region Methods for Property adjustLabelSpan

						/// <summary>
						/// Gets current value of property {@link #getAdjustLabelSpan adjustLabelSpan}.
						/// 
						/// If set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the number of <code>FormContainers</code> in one row. If only one <code>FormContainer</code> is displayed in one row, <code>labelSpanM</code> is used to define the size of the label. This is the same for medium and large <code>Forms</code>. This is done to align the labels on forms where full-size <code>FormContainers</code> and multiple-column rows are used in the same <code>Form</code> (because every <code>FormContainer</code> has its own grid inside).
						/// 
						/// If not set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the <code>Form</code> size. The number of <code>FormContainers</code> doesn't matter in this case.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>adjustLabelSpan</code></returns>
						public extern virtual bool getAdjustLabelSpan();

						/// <summary>
						/// Sets a new value for property {@link #getAdjustLabelSpan adjustLabelSpan}.
						/// 
						/// If set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the number of <code>FormContainers</code> in one row. If only one <code>FormContainer</code> is displayed in one row, <code>labelSpanM</code> is used to define the size of the label. This is the same for medium and large <code>Forms</code>. This is done to align the labels on forms where full-size <code>FormContainers</code> and multiple-column rows are used in the same <code>Form</code> (because every <code>FormContainer</code> has its own grid inside).
						/// 
						/// If not set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the <code>Form</code> size. The number of <code>FormContainers</code> doesn't matter in this case.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bAdjustLabelSpan">New value for property <code>adjustLabelSpan</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setAdjustLabelSpan(bool bAdjustLabelSpan);

						#endregion

						#region Methods for Property emptySpanXL

						/// <summary>
						/// Gets current value of property {@link #getEmptySpanXL emptySpanXL}.
						/// 
						/// Number of grid cells that are empty at the end of each line on extra large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout. If the default value -1 is not overwritten with the meaningful one then the <code>emptySpanL</code> value is used (from the backward compatibility reasons).
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <returns>Value of property <code>emptySpanXL</code></returns>
						public extern virtual int getEmptySpanXL();

						/// <summary>
						/// Sets a new value for property {@link #getEmptySpanXL emptySpanXL}.
						/// 
						/// Number of grid cells that are empty at the end of each line on extra large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout. If the default value -1 is not overwritten with the meaningful one then the <code>emptySpanL</code> value is used (from the backward compatibility reasons).
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <param name="iEmptySpanXL">New value for property <code>emptySpanXL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setEmptySpanXL(int iEmptySpanXL);

						#endregion

						#region Methods for Property emptySpanL

						/// <summary>
						/// Gets current value of property {@link #getEmptySpanL emptySpanL}.
						/// 
						/// Number of grid cells that are empty at the end of each line on large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout. If a <code>ColumnLayout</code> is used, this property defines the empty cells for large columns.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <returns>Value of property <code>emptySpanL</code></returns>
						public extern virtual int getEmptySpanL();

						/// <summary>
						/// Sets a new value for property {@link #getEmptySpanL emptySpanL}.
						/// 
						/// Number of grid cells that are empty at the end of each line on large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout. If a <code>ColumnLayout</code> is used, this property defines the empty cells for large columns.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <param name="iEmptySpanL">New value for property <code>emptySpanL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setEmptySpanL(int iEmptySpanL);

						#endregion

						#region Methods for Property emptySpanM

						/// <summary>
						/// Gets current value of property {@link #getEmptySpanM emptySpanM}.
						/// 
						/// Number of grid cells that are empty at the end of each line on medium size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <returns>Value of property <code>emptySpanM</code></returns>
						public extern virtual int getEmptySpanM();

						/// <summary>
						/// Sets a new value for property {@link #getEmptySpanM emptySpanM}.
						/// 
						/// Number of grid cells that are empty at the end of each line on medium size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <param name="iEmptySpanM">New value for property <code>emptySpanM</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setEmptySpanM(int iEmptySpanM);

						#endregion

						#region Methods for Property emptySpanS

						/// <summary>
						/// Gets current value of property {@link #getEmptySpanS emptySpanS}.
						/// 
						/// Number of grid cells that are empty at the end of each line on small size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <returns>Value of property <code>emptySpanS</code></returns>
						public extern virtual int getEmptySpanS();

						/// <summary>
						/// Sets a new value for property {@link #getEmptySpanS emptySpanS}.
						/// 
						/// Number of grid cells that are empty at the end of each line on small size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <param name="iEmptySpanS">New value for property <code>emptySpanS</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setEmptySpanS(int iEmptySpanS);

						#endregion

						#region Methods for Property columnsXL

						/// <summary>
						/// Gets current value of property {@link #getColumnsXL columnsXL}.
						/// 
						/// Form columns for extra large size. The number of columns for extra large size must not be smaller than the number of columns for large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout. If the default value -1 is not overwritten with the meaningful one then the <code>columnsL</code> value is used (from the backward compatibility reasons).
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <returns>Value of property <code>columnsXL</code></returns>
						public extern virtual int getColumnsXL();

						/// <summary>
						/// Sets a new value for property {@link #getColumnsXL columnsXL}.
						/// 
						/// Form columns for extra large size. The number of columns for extra large size must not be smaller than the number of columns for large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout. If the default value -1 is not overwritten with the meaningful one then the <code>columnsL</code> value is used (from the backward compatibility reasons).
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <param name="iColumnsXL">New value for property <code>columnsXL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setColumnsXL(int iColumnsXL);

						#endregion

						#region Methods for Property columnsL

						/// <summary>
						/// Gets current value of property {@link #getColumnsL columnsL}.
						/// 
						/// Form columns for large size. The number of columns for large size must not be smaller than the number of columns for medium size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <returns>Value of property <code>columnsL</code></returns>
						public extern virtual int getColumnsL();

						/// <summary>
						/// Sets a new value for property {@link #getColumnsL columnsL}.
						/// 
						/// Form columns for large size. The number of columns for large size must not be smaller than the number of columns for medium size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <param name="iColumnsL">New value for property <code>columnsL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setColumnsL(int iColumnsL);

						#endregion

						#region Methods for Property columnsM

						/// <summary>
						/// Gets current value of property {@link #getColumnsM columnsM}.
						/// 
						/// Form columns for medium size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <returns>Value of property <code>columnsM</code></returns>
						public extern virtual int getColumnsM();

						/// <summary>
						/// Sets a new value for property {@link #getColumnsM columnsM}.
						/// 
						/// Form columns for medium size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> or a <code>ColumnLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <param name="iColumnsM">New value for property <code>columnsM</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setColumnsM(int iColumnsM);

						#endregion

						#region Methods for Property singleContainerFullSize

						/// <summary>
						/// Gets current value of property {@link #getSingleContainerFullSize singleContainerFullSize}.
						/// 
						/// If the <code>Form</code> contains only one single <code>FormContainer</code> and this property is set, the <code>FormContainer</code> is displayed using the full size of the <code>Form</code>. In this case the properties <code>columnsL</code> and <code>columnsM</code> are ignored.
						/// 
						/// In all other cases the <code>FormContainer</code> is displayed in the size of one column.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>singleContainerFullSize</code></returns>
						public extern virtual bool getSingleContainerFullSize();

						/// <summary>
						/// Sets a new value for property {@link #getSingleContainerFullSize singleContainerFullSize}.
						/// 
						/// If the <code>Form</code> contains only one single <code>FormContainer</code> and this property is set, the <code>FormContainer</code> is displayed using the full size of the <code>Form</code>. In this case the properties <code>columnsL</code> and <code>columnsM</code> are ignored.
						/// 
						/// In all other cases the <code>FormContainer</code> is displayed in the size of one column.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bSingleContainerFullSize">New value for property <code>singleContainerFullSize</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setSingleContainerFullSize(bool bSingleContainerFullSize);

						#endregion

						#region Methods for Property breakpointXL

						/// <summary>
						/// Gets current value of property {@link #getBreakpointXL breakpointXL}.
						/// 
						/// Breakpoint between Medium size and Large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// Default value is <code>1440</code>.
						/// </summary>
						/// <returns>Value of property <code>breakpointXL</code></returns>
						public extern virtual int getBreakpointXL();

						/// <summary>
						/// Sets a new value for property {@link #getBreakpointXL breakpointXL}.
						/// 
						/// Breakpoint between Medium size and Large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>1440</code>.
						/// </summary>
						/// <param name="iBreakpointXL">New value for property <code>breakpointXL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setBreakpointXL(int iBreakpointXL);

						#endregion

						#region Methods for Property breakpointL

						/// <summary>
						/// Gets current value of property {@link #getBreakpointL breakpointL}.
						/// 
						/// Breakpoint between Medium size and Large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// Default value is <code>1024</code>.
						/// </summary>
						/// <returns>Value of property <code>breakpointL</code></returns>
						public extern virtual int getBreakpointL();

						/// <summary>
						/// Sets a new value for property {@link #getBreakpointL breakpointL}.
						/// 
						/// Breakpoint between Medium size and Large size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>1024</code>.
						/// </summary>
						/// <param name="iBreakpointL">New value for property <code>breakpointL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setBreakpointL(int iBreakpointL);

						#endregion

						#region Methods for Property breakpointM

						/// <summary>
						/// Gets current value of property {@link #getBreakpointM breakpointM}.
						/// 
						/// Breakpoint between Small size and Medium size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// Default value is <code>600</code>.
						/// </summary>
						/// <returns>Value of property <code>breakpointM</code></returns>
						public extern virtual int getBreakpointM();

						/// <summary>
						/// Sets a new value for property {@link #getBreakpointM breakpointM}.
						/// 
						/// Breakpoint between Small size and Medium size.
						/// 
						/// <b>Note:</b> This property is only used if a <code>ResponsiveGridLayout</code> is used as a layout.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>600</code>.
						/// </summary>
						/// <param name="iBreakpointM">New value for property <code>breakpointM</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setBreakpointM(int iBreakpointM);

						#endregion

						#region Methods for Property backgroundDesign

						/// <summary>
						/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
						/// 
						/// Specifies the background color of the <code>SimpleForm</code> content.
						/// 
						/// The visualization of the different options depends on the used theme.
						/// 
						/// Default value is <code>Translucent</code>.
						/// </summary>
						/// <returns>Value of property <code>backgroundDesign</code></returns>
						public extern virtual sap.ui.layout.BackgroundDesign getBackgroundDesign();

						/// <summary>
						/// Sets a new value for property {@link #getBackgroundDesign backgroundDesign}.
						/// 
						/// Specifies the background color of the <code>SimpleForm</code> content.
						/// 
						/// The visualization of the different options depends on the used theme.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>Translucent</code>.
						/// </summary>
						/// <param name="sBackgroundDesign">New value for property <code>backgroundDesign</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setBackgroundDesign(sap.ui.layout.BackgroundDesign sBackgroundDesign);

						#endregion

						#region Methods for Aggregation content

						/// <summary>
						/// Gets content of aggregation {@link #getContent content}.
						/// 
						/// The content of the form is structured in the following way: <ul> <li>Add a <code>Title</code> or <code>Toolbar</code> control to start a new group (<code>FormContainer</code>).</li> <li>Add a <code>Label</code> control to start a new row (<code>FormElement</code>).</li> <li>Add controls as input fields, text fields or other as needed.</li> <li>Use <code>LayoutData</code> to influence the layout for special cases in the single controls. For example, if a <code>ResponsiveLayout</code> is used as a layout, the form content is weighted using weight 3 for the labels and weight 5 for the fields part. By default the label column is 192 pixels wide. If your input controls should influence their width, you can add <code>sap.ui.layout.ResponsiveFlowLayoutData</code> to them via <code>setLayoutData</code> method. Ensure that the sum of the weights in the <code>ResponsiveFlowLayoutData</code> is not more than 5, as this is the total width of the input control part of each form row.</li> </ul> Example for a row where the <code>Input</code> weight 4 and the second <code>Input</code> weight 1 (using <code>ResponsiveLayout</code>): <pre>
						/// new sap.m.Label({text:"Label"});
						/// new sap.m.Input({value:"Weight 4", layoutData: new sap.ui.layout.ResponsiveFlowLayoutData({weight:4})}),
						/// new sap.m.Input({value:"Weight 1", layoutData: new sap.ui.layout.ResponsiveFlowLayoutData({weight:1})}),
						/// </pre>
						/// 
						/// For example, if a <code>ResponsiveGridLayout</code> is used as a layout, there are 12 cells in one row. Depending on the screen size the labels use the defined <code>labelSpan</code>. The remaining cells are used for the fields (and <code>emptySpan</code> if defined). The available cells are distributed to all fields in the row. If one field should use a fixed number of cells you can add <code>sap.ui.layout.GridData</code> to them via <code>setLayoutData</code> method. If there are additional fields in the row they will get the remaining cells. </ul> Example for a row with two <code>Input</code> controls where one uses four cells on small screens, one cell on medium screens and 2 cells on larger screens (using <code>ResponsiveGridLayout</code>): <pre>
						/// new sap.m.Label({text:"Label"});
						/// new sap.m.Input({value:"auto size"}),
						/// new sap.m.Input({value:"fix size", layoutData: new sap.ui.layout.GridData({span: "XL1 L1 M2 S4"})}),
						/// </pre>
						/// 
						/// <b>Warning:</b> Do not put any layout or other container controls in here. This could damage the visual layout, keyboard support and screen-reader support. Only labels, titles, toolbars and form controls are allowed. Views are also not supported. Allowed form controls implement the interface <code>sap.ui.core.IFormContent</code>.
						/// 
						/// If editable controls are used as content, the <code>editable</code> property must be set to <code>true</code>, otherwise to <code>false</code>. If the <code>editable</code> property is set incorrectly, there will be visual issues like wrong label alignment or wrong spacing between the controls.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.Element[] getContent();

						/// <summary>
						/// Destroys all the content in the aggregation {@link #getContent content}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm destroyContent();

						/// <summary>
						/// Inserts a content into the aggregation {@link #getContent content}.
						/// </summary>
						/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm insertContent(sap.ui.core.Element oContent, int iIndex);

						/// <summary>
						/// Adds some content to the aggregation {@link #getContent content}.
						/// </summary>
						/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm addContent(sap.ui.core.Element oContent);

						/// <summary>
						/// Removes a content from the aggregation {@link #getContent content}.
						/// </summary>
						/// <param name="vContent">The content to remove or its index or id</param>
						/// <returns>The removed content or <code>null</code></returns>
						public extern virtual sap.ui.core.Element removeContent(Union<int, string, sap.ui.core.Element> vContent);

						/// <summary>
						/// Checks for the provided <code>sap.ui.core.Element</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oContent">The content whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfContent(sap.ui.core.Element oContent);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getContent content}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.Element[] removeAllContent();

						#endregion

						#region Methods for Aggregation form

						#endregion

						#region Methods for Aggregation title

						/// <summary>
						/// Gets content of aggregation {@link #getTitle title}.
						/// 
						/// Title element of the <code>SimpleForm</code>. Can either be a <code>Title</code> element, or a string.
						/// </summary>
						/// <returns></returns>
						public extern virtual Union<sap.ui.core.Title, string> getTitle();

						/// <summary>
						/// Destroys the title in the aggregation {@link #getTitle title}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm destroyTitle();

						/// <summary>
						/// Sets the aggregated {@link #getTitle title}.
						/// </summary>
						/// <param name="vTitle">The title to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setTitle(Union<sap.ui.core.Title, string> vTitle);

						#endregion

						#region Methods for Aggregation toolbar

						/// <summary>
						/// Gets content of aggregation {@link #getToolbar toolbar}.
						/// 
						/// Toolbar of the <code>SimpleForm</code>.
						/// 
						/// <b>Note:</b> If a <code>Toolbar</code> is used, the <code>Title</code> is ignored. If a title is needed inside the <code>Toolbar</code> it must be added at content to the <code>Toolbar</code>. In this case add the <code>Title</code> to the <code>ariaLabelledBy</code> association.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.Toolbar getToolbar();

						/// <summary>
						/// Destroys the toolbar in the aggregation {@link #getToolbar toolbar}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm destroyToolbar();

						/// <summary>
						/// Sets the aggregated {@link #getToolbar toolbar}.
						/// </summary>
						/// <param name="oToolbar">The toolbar to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm setToolbar(sap.ui.core.Toolbar oToolbar);

						#endregion

						#region Methods for Association ariaLabelledBy

						/// <summary>
						/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaLabelledBy ariaLabelledBy}.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.ID[] getAriaLabelledBy();

						/// <summary>
						/// Adds some ariaLabelledBy into the association {@link #getAriaLabelledBy ariaLabelledBy}.
						/// </summary>
						/// <param name="vAriaLabelledBy">The ariaLabelledBy to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.SimpleForm addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

						/// <summary>
						/// Removes an ariaLabelledBy from the association named {@link #getAriaLabelledBy ariaLabelledBy}.
						/// </summary>
						/// <param name="vAriaLabelledBy">The ariaLabelledBy to be removed or its index or ID</param>
						/// <returns>The removed ariaLabelledBy or <code>null</code></returns>
						public extern virtual sap.ui.core.ID removeAriaLabelledBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

						/// <summary>
						/// Removes all the controls in the association named {@link #getAriaLabelledBy ariaLabelledBy}.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.ID[] removeAllAriaLabelledBy();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.SimpleForm with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.SimpleForm with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.SimpleForm with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.layout.form.SimpleForm.
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
