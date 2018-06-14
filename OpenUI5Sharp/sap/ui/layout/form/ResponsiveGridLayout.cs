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
					/// The <code>ResponsiveGridLayout</code> control renders a <code>Form</code> using a responsive grid. Internally the <code>Grid</code> control is used for rendering. Using this layout, the <code>Form</code> is rendered in a responsive way. Depending on the available space, the <code>FormContainers</code> are rendered in one or different columns and the labels are rendered in the same row as the fields or above the fields. This behavior can be influenced by the properties of this layout control.
					/// 
					/// On the <code>FormContainers</code>, labels and content fields, <code>GridData</code> can be used to change the default rendering. <code>GridData</code> is not supported for <code>FormElements</code>.
					/// 
					/// <b>Note:</b> If <code>GridData</code> is used, this may result in a much more complex layout than the default one. This means that in some cases, the calculation for the other content may not bring the expected result. In such cases, <code>GridData</code> should be used for all content controls to disable the default behavior.
					/// 
					/// This control cannot be used stand-alone, it just renders a <code>Form</code>, so it must be assigned to a <code>Form</code> using the <code>layout</code> aggregation.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class ResponsiveGridLayout : sap.ui.layout.form.FormLayout
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
							/// Default span for labels in extra large size.
							/// 
							/// <b>Note:</b> If the default value -1 is not overwritten with the meaningful one then the <code>labelSpanL</code> value is used.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> labelSpanXL;

							/// <summary>
							/// Default span for labels in large size.
							/// 
							/// <b>Note:</b> If <code>adjustLabelSpanThis</code> is set, this property is only used if more than 1 <code>FormContainer</code> is in one line. If only 1 <code>FormContainer</code> is in the line, then the <code>labelSpanM</code> value is used.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> labelSpanL;

							/// <summary>
							/// Default span for labels in medium size.
							/// 
							/// <b>Note:</b> If <code>adjustLabelSpanThis</code> is set this property is used for full-size <code>FormContainers</code>. If more than one <code>FormContainer</code> is in one line, <code>labelSpanL</code> is used.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> labelSpanM;

							/// <summary>
							/// Default span for labels in small size.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> labelSpanS;

							/// <summary>
							/// If set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the number of <code>FormContainers</code> in one row. If only one <code>FormContainer</code> is displayed in one row, <code>labelSpanM</code> is used to define the size of the label. This is the same for medium and large <code>Forms</code>. This is done to align the labels on forms where full-size <code>FormContainers</code> and multiple-column rows are used in the same <code>Form</code> (because every <code>FormContainer</code> has its own <code>Grid</code> inside).
							/// 
							/// If not set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the <code>Form</code> size. The number of <code>FormContainers</code> doesn't matter in this case.
							/// </summary>
							public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> adjustLabelSpan;

							/// <summary>
							/// Number of grid cells that are empty at the end of each line on extra large size.
							/// 
							/// <b>Note:</b> If the default value -1 is not overwritten with the meaningful one then the <code>emptySpanL</code> value is used.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> emptySpanXL;

							/// <summary>
							/// Number of grid cells that are empty at the end of each line on large size.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> emptySpanL;

							/// <summary>
							/// Number of grid cells that are empty at the end of each line on medium size.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> emptySpanM;

							/// <summary>
							/// Number of grid cells that are empty at the end of each line on small size.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> emptySpanS;

							/// <summary>
							/// Number of columns for extra large size.
							/// 
							/// The number of columns for extra large size must not be smaller than the number of columns for large size. <b>Note:</b> If the default value -1 is not overwritten with the meaningful one then the <code>columnsL</code> value is used (from the backward compatibility reasons).
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> columnsXL;

							/// <summary>
							/// Number of columns for large size.
							/// 
							/// The number of columns for large size must not be smaller than the number of columns for medium size.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> columnsL;

							/// <summary>
							/// Number of columns for medium size.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> columnsM;

							/// <summary>
							/// If the <code>Form</code> contains only one single <code>FormContainer</code> and this property is set, the <code>FormContainer</code> is displayed using the full size of the <code>Form</code>. In this case the properties <code>columnsXL</code>, <code>columnsL</code> and <code>columnsM</code> are ignored.
							/// 
							/// In all other cases the <code>FormContainer</code> is displayed in the size of one column.
							/// </summary>
							public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> singleContainerFullSize;

							/// <summary>
							/// Breakpoint (in pixel) between large size and extra large (XL) size.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> breakpointXL;

							/// <summary>
							/// Breakpoint (in pixel) between Medium size and Large size.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> breakpointL;

							/// <summary>
							/// Breakpoint (in pixel) between Small size and Medium size.
							/// </summary>
							public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> breakpointM;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new <code>sap.ui.layout.form.ResponsiveGridLayout</code>.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern ResponsiveGridLayout(string sId, sap.ui.layout.form.ResponsiveGridLayout.Settings mSettings);

						/// <summary>
						/// Constructor for a new <code>sap.ui.layout.form.ResponsiveGridLayout</code>.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern ResponsiveGridLayout(string sId);

						/// <summary>
						/// Constructor for a new <code>sap.ui.layout.form.ResponsiveGridLayout</code>.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern ResponsiveGridLayout();

						/// <summary>
						/// Constructor for a new <code>sap.ui.layout.form.ResponsiveGridLayout</code>.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern ResponsiveGridLayout(sap.ui.layout.form.ResponsiveGridLayout.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property labelSpanXL

						/// <summary>
						/// Gets current value of property {@link #getLabelSpanXL labelSpanXL}.
						/// 
						/// Default span for labels in extra large size.
						/// 
						/// <b>Note:</b> If the default value -1 is not overwritten with the meaningful one then the <code>labelSpanL</code> value is used.
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
						/// <b>Note:</b> If the default value -1 is not overwritten with the meaningful one then the <code>labelSpanL</code> value is used.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <param name="iLabelSpanXL">New value for property <code>labelSpanXL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setLabelSpanXL(int iLabelSpanXL);

						#endregion

						#region Methods for Property labelSpanL

						/// <summary>
						/// Gets current value of property {@link #getLabelSpanL labelSpanL}.
						/// 
						/// Default span for labels in large size.
						/// 
						/// <b>Note:</b> If <code>adjustLabelSpanThis</code> is set, this property is only used if more than 1 <code>FormContainer</code> is in one line. If only 1 <code>FormContainer</code> is in the line, then the <code>labelSpanM</code> value is used.
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
						/// <b>Note:</b> If <code>adjustLabelSpanThis</code> is set, this property is only used if more than 1 <code>FormContainer</code> is in one line. If only 1 <code>FormContainer</code> is in the line, then the <code>labelSpanM</code> value is used.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>4</code>.
						/// </summary>
						/// <param name="iLabelSpanL">New value for property <code>labelSpanL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setLabelSpanL(int iLabelSpanL);

						#endregion

						#region Methods for Property labelSpanM

						/// <summary>
						/// Gets current value of property {@link #getLabelSpanM labelSpanM}.
						/// 
						/// Default span for labels in medium size.
						/// 
						/// <b>Note:</b> If <code>adjustLabelSpanThis</code> is set this property is used for full-size <code>FormContainers</code>. If more than one <code>FormContainer</code> is in one line, <code>labelSpanL</code> is used.
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
						/// <b>Note:</b> If <code>adjustLabelSpanThis</code> is set this property is used for full-size <code>FormContainers</code>. If more than one <code>FormContainer</code> is in one line, <code>labelSpanL</code> is used.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <param name="iLabelSpanM">New value for property <code>labelSpanM</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setLabelSpanM(int iLabelSpanM);

						#endregion

						#region Methods for Property labelSpanS

						/// <summary>
						/// Gets current value of property {@link #getLabelSpanS labelSpanS}.
						/// 
						/// Default span for labels in small size.
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
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>12</code>.
						/// </summary>
						/// <param name="iLabelSpanS">New value for property <code>labelSpanS</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setLabelSpanS(int iLabelSpanS);

						#endregion

						#region Methods for Property adjustLabelSpan

						/// <summary>
						/// Gets current value of property {@link #getAdjustLabelSpan adjustLabelSpan}.
						/// 
						/// If set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the number of <code>FormContainers</code> in one row. If only one <code>FormContainer</code> is displayed in one row, <code>labelSpanM</code> is used to define the size of the label. This is the same for medium and large <code>Forms</code>. This is done to align the labels on forms where full-size <code>FormContainers</code> and multiple-column rows are used in the same <code>Form</code> (because every <code>FormContainer</code> has its own <code>Grid</code> inside).
						/// 
						/// If not set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the <code>Form</code> size. The number of <code>FormContainers</code> doesn't matter in this case.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>adjustLabelSpan</code></returns>
						public extern virtual bool getAdjustLabelSpan();

						/// <summary>
						/// Sets a new value for property {@link #getAdjustLabelSpan adjustLabelSpan}.
						/// 
						/// If set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the number of <code>FormContainers</code> in one row. If only one <code>FormContainer</code> is displayed in one row, <code>labelSpanM</code> is used to define the size of the label. This is the same for medium and large <code>Forms</code>. This is done to align the labels on forms where full-size <code>FormContainers</code> and multiple-column rows are used in the same <code>Form</code> (because every <code>FormContainer</code> has its own <code>Grid</code> inside).
						/// 
						/// If not set, the usage of <code>labelSpanL</code> and <code>labelSpanM</code> are dependent on the <code>Form</code> size. The number of <code>FormContainers</code> doesn't matter in this case.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bAdjustLabelSpan">New value for property <code>adjustLabelSpan</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setAdjustLabelSpan(bool bAdjustLabelSpan);

						#endregion

						#region Methods for Property emptySpanXL

						/// <summary>
						/// Gets current value of property {@link #getEmptySpanXL emptySpanXL}.
						/// 
						/// Number of grid cells that are empty at the end of each line on extra large size.
						/// 
						/// <b>Note:</b> If the default value -1 is not overwritten with the meaningful one then the <code>emptySpanL</code> value is used.
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
						/// <b>Note:</b> If the default value -1 is not overwritten with the meaningful one then the <code>emptySpanL</code> value is used.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <param name="iEmptySpanXL">New value for property <code>emptySpanXL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setEmptySpanXL(int iEmptySpanXL);

						#endregion

						#region Methods for Property emptySpanL

						/// <summary>
						/// Gets current value of property {@link #getEmptySpanL emptySpanL}.
						/// 
						/// Number of grid cells that are empty at the end of each line on large size.
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
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <param name="iEmptySpanL">New value for property <code>emptySpanL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setEmptySpanL(int iEmptySpanL);

						#endregion

						#region Methods for Property emptySpanM

						/// <summary>
						/// Gets current value of property {@link #getEmptySpanM emptySpanM}.
						/// 
						/// Number of grid cells that are empty at the end of each line on medium size.
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
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <param name="iEmptySpanM">New value for property <code>emptySpanM</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setEmptySpanM(int iEmptySpanM);

						#endregion

						#region Methods for Property emptySpanS

						/// <summary>
						/// Gets current value of property {@link #getEmptySpanS emptySpanS}.
						/// 
						/// Number of grid cells that are empty at the end of each line on small size.
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
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>0</code>.
						/// </summary>
						/// <param name="iEmptySpanS">New value for property <code>emptySpanS</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setEmptySpanS(int iEmptySpanS);

						#endregion

						#region Methods for Property columnsXL

						/// <summary>
						/// Gets current value of property {@link #getColumnsXL columnsXL}.
						/// 
						/// Number of columns for extra large size.
						/// 
						/// The number of columns for extra large size must not be smaller than the number of columns for large size. <b>Note:</b> If the default value -1 is not overwritten with the meaningful one then the <code>columnsL</code> value is used (from the backward compatibility reasons).
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <returns>Value of property <code>columnsXL</code></returns>
						public extern virtual int getColumnsXL();

						/// <summary>
						/// Sets a new value for property {@link #getColumnsXL columnsXL}.
						/// 
						/// Number of columns for extra large size.
						/// 
						/// The number of columns for extra large size must not be smaller than the number of columns for large size. <b>Note:</b> If the default value -1 is not overwritten with the meaningful one then the <code>columnsL</code> value is used (from the backward compatibility reasons).
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>-1</code>.
						/// </summary>
						/// <param name="iColumnsXL">New value for property <code>columnsXL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setColumnsXL(int iColumnsXL);

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
						public extern virtual int getColumnsL();

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
						/// <param name="iColumnsL">New value for property <code>columnsL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setColumnsL(int iColumnsL);

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
						public extern virtual int getColumnsM();

						/// <summary>
						/// Sets a new value for property {@link #getColumnsM columnsM}.
						/// 
						/// Number of columns for medium size.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <param name="iColumnsM">New value for property <code>columnsM</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setColumnsM(int iColumnsM);

						#endregion

						#region Methods for Property singleContainerFullSize

						/// <summary>
						/// Gets current value of property {@link #getSingleContainerFullSize singleContainerFullSize}.
						/// 
						/// If the <code>Form</code> contains only one single <code>FormContainer</code> and this property is set, the <code>FormContainer</code> is displayed using the full size of the <code>Form</code>. In this case the properties <code>columnsXL</code>, <code>columnsL</code> and <code>columnsM</code> are ignored.
						/// 
						/// In all other cases the <code>FormContainer</code> is displayed in the size of one column.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>singleContainerFullSize</code></returns>
						public extern virtual bool getSingleContainerFullSize();

						/// <summary>
						/// Sets a new value for property {@link #getSingleContainerFullSize singleContainerFullSize}.
						/// 
						/// If the <code>Form</code> contains only one single <code>FormContainer</code> and this property is set, the <code>FormContainer</code> is displayed using the full size of the <code>Form</code>. In this case the properties <code>columnsXL</code>, <code>columnsL</code> and <code>columnsM</code> are ignored.
						/// 
						/// In all other cases the <code>FormContainer</code> is displayed in the size of one column.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bSingleContainerFullSize">New value for property <code>singleContainerFullSize</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setSingleContainerFullSize(bool bSingleContainerFullSize);

						#endregion

						#region Methods for Property breakpointXL

						/// <summary>
						/// Gets current value of property {@link #getBreakpointXL breakpointXL}.
						/// 
						/// Breakpoint (in pixel) between large size and extra large (XL) size.
						/// 
						/// Default value is <code>1440</code>.
						/// </summary>
						/// <returns>Value of property <code>breakpointXL</code></returns>
						public extern virtual int getBreakpointXL();

						/// <summary>
						/// Sets a new value for property {@link #getBreakpointXL breakpointXL}.
						/// 
						/// Breakpoint (in pixel) between large size and extra large (XL) size.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>1440</code>.
						/// </summary>
						/// <param name="iBreakpointXL">New value for property <code>breakpointXL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setBreakpointXL(int iBreakpointXL);

						#endregion

						#region Methods for Property breakpointL

						/// <summary>
						/// Gets current value of property {@link #getBreakpointL breakpointL}.
						/// 
						/// Breakpoint (in pixel) between Medium size and Large size.
						/// 
						/// Default value is <code>1024</code>.
						/// </summary>
						/// <returns>Value of property <code>breakpointL</code></returns>
						public extern virtual int getBreakpointL();

						/// <summary>
						/// Sets a new value for property {@link #getBreakpointL breakpointL}.
						/// 
						/// Breakpoint (in pixel) between Medium size and Large size.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>1024</code>.
						/// </summary>
						/// <param name="iBreakpointL">New value for property <code>breakpointL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setBreakpointL(int iBreakpointL);

						#endregion

						#region Methods for Property breakpointM

						/// <summary>
						/// Gets current value of property {@link #getBreakpointM breakpointM}.
						/// 
						/// Breakpoint (in pixel) between Small size and Medium size.
						/// 
						/// Default value is <code>600</code>.
						/// </summary>
						/// <returns>Value of property <code>breakpointM</code></returns>
						public extern virtual int getBreakpointM();

						/// <summary>
						/// Sets a new value for property {@link #getBreakpointM breakpointM}.
						/// 
						/// Breakpoint (in pixel) between Small size and Medium size.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>600</code>.
						/// </summary>
						/// <param name="iBreakpointM">New value for property <code>breakpointM</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ResponsiveGridLayout setBreakpointM(int iBreakpointM);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ResponsiveGridLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ResponsiveGridLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ResponsiveGridLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.layout.form.ResponsiveGridLayout.
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
