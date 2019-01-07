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
			/// The <code>sap.m.Column</code> allows to define column specific properties that will be applied when rendering the <code>sap.m.Table</code>.
			/// 
			/// See section "{@link topic:6f778a805bc3453dbb66e246d8271839 Defining Column Width}" in the documentation to understand how to define the <code>width</code> property of the <code>sap.m.Column</code> to render a <code>sap.m.Table</code> control properly.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Column")]
			public partial class Column : sap.ui.core.Element
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
					/// Defines the width of the column. If you leave it empty then this column covers the remaining space.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Defines the horizontal alignment of the column content.
					/// 
					/// <b>Note:</b> Text controls with a <code>textAlign</code> property inherits the horizontal alignment.
					/// </summary>
					public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> hAlign;

					/// <summary>
					/// Defines the vertical alignment of the cells in a column. This property does not affect the vertical alignment of header and footer.
					/// </summary>
					public Union<sap.ui.core.VerticalAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> vAlign;

					/// <summary>
					/// CSS class name for column contents(header, cells and footer of column). This property can be used for different column styling. If column is shown as pop-in then this class name is applied to related pop-in row.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> styleClass;

					/// <summary>
					/// Specifies whether or not the column is visible. Invisible columns are not rendered.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					/// <summary>
					/// Defines the minimum screen width to show or hide this column. By default column is always shown. The responsive behavior of the <code>sap.m.Table</code> is determined by this property. As an example by setting <code>minScreenWidth</code> property to "40em" (or "640px" or "Tablet") shows this column on tablet (and desktop) but hides on mobile. As you can give specific CSS sizes (e.g: "480px" or "40em"), you can also use the {@link sap.m.ScreenSize} enumeration (e.g: "Phone", "Tablet", "Desktop", "Small", "Medium", "Large", ....). Please also see <code>demandPopin</code> property for further responsive design options.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> minScreenWidth;

					/// <summary>
					/// According to your minScreenWidth settings, the column can be hidden in different screen sizes. Setting this property to true, shows this column as pop-in instead of hiding it.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> demandPopin;

					/// <summary>
					/// Horizontal alignment of the pop-in content. Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
					/// 
					/// <b>Note:</b> Controls with a text align do not inherit the horizontal alignment.
					/// </summary>
					public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> popinHAlign;

					/// <summary>
					/// Defines enumerated display options for the pop-in.
					/// </summary>
					public Union<sap.m.PopinDisplay, string, sap.ui.@base.ManagedObject.BindPropertyInfo> popinDisplay;

					/// <summary>
					/// Set <code>true</code> to merge repeating/duplicate cells into one cell block. See <code>mergeFunctionName</code> property to customize. <b>Note:</b> Merging only happens at the rendering of the <code>sap.m.Table</code> control, subsequent changes on the cell or item do not have any effect on the merged state of the cells, therefore this feature should not be used together with two-way binding. This property is ignored if any column is configured to be shown as a pop-in.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> mergeDuplicates;

					/// <summary>
					/// Defines the control serialization function if <code>mergeDuplicates<code> property is set to <code>true</code>. The control itself uses this function to compare values of two repeating cells. Default value "getText" is suitable for <code>sap.m.Label</code> and <code>sap.m.Text</code> controls but for the <code>sap.ui.core.Icon</code> control "getSrc" function should be used to merge icons. <b>Note:</b> You can pass one string parameter to given function after "#" sign. e.g. "data#myparameter"
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> mergeFunctionName;

					/// <summary>
					/// Control to be displayed in the column header.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> header;

					/// <summary>
					/// Control to be displayed in the column footer.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> footer;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Column.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern Column(string sId, sap.m.Column.Settings mSettings);

				/// <summary>
				/// Constructor for a new Column.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern Column(string sId);

				/// <summary>
				/// Constructor for a new Column.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Column();

				/// <summary>
				/// Constructor for a new Column.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern Column(sap.m.Column.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the width of the column. If you leave it empty then this column covers the remaining space.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the width of the column. If you leave it empty then this column covers the remaining space.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property hAlign

				/// <summary>
				/// Gets current value of property {@link #getHAlign hAlign}.
				/// 
				/// Defines the horizontal alignment of the column content.
				/// 
				/// <b>Note:</b> Text controls with a <code>textAlign</code> property inherits the horizontal alignment.
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <returns>Value of property <code>hAlign</code></returns>
				public extern virtual sap.ui.core.TextAlign getHAlign();

				/// <summary>
				/// Sets a new value for property {@link #getHAlign hAlign}.
				/// 
				/// Defines the horizontal alignment of the column content.
				/// 
				/// <b>Note:</b> Text controls with a <code>textAlign</code> property inherits the horizontal alignment.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <param name="sHAlign">New value for property <code>hAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setHAlign(sap.ui.core.TextAlign sHAlign);

				#endregion

				#region Methods for Property vAlign

				/// <summary>
				/// Gets current value of property {@link #getVAlign vAlign}.
				/// 
				/// Defines the vertical alignment of the cells in a column. This property does not affect the vertical alignment of header and footer.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>vAlign</code></returns>
				public extern virtual sap.ui.core.VerticalAlign getVAlign();

				/// <summary>
				/// Sets a new value for property {@link #getVAlign vAlign}.
				/// 
				/// Defines the vertical alignment of the cells in a column. This property does not affect the vertical alignment of header and footer.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sVAlign">New value for property <code>vAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setVAlign(sap.ui.core.VerticalAlign sVAlign);

				#endregion

				#region Methods for Property styleClass

				/// <summary>
				/// Gets current value of property {@link #getStyleClass styleClass}.
				/// 
				/// CSS class name for column contents(header, cells and footer of column). This property can be used for different column styling. If column is shown as pop-in then this class name is applied to related pop-in row.
				/// </summary>
				/// <returns>Value of property <code>styleClass</code></returns>
				public extern virtual string getStyleClass();

				/// <summary>
				/// Sets a new value for property {@link #getStyleClass styleClass}.
				/// 
				/// CSS class name for column contents(header, cells and footer of column). This property can be used for different column styling. If column is shown as pop-in then this class name is applied to related pop-in row.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sStyleClass">New value for property <code>styleClass</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setStyleClass(string sStyleClass);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Specifies whether or not the column is visible. Invisible columns are not rendered.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern virtual bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Specifies whether or not the column is visible. Invisible columns are not rendered.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setVisible(bool bVisible);

				#endregion

				#region Methods for Property minScreenWidth

				/// <summary>
				/// Gets current value of property {@link #getMinScreenWidth minScreenWidth}.
				/// 
				/// Defines the minimum screen width to show or hide this column. By default column is always shown. The responsive behavior of the <code>sap.m.Table</code> is determined by this property. As an example by setting <code>minScreenWidth</code> property to "40em" (or "640px" or "Tablet") shows this column on tablet (and desktop) but hides on mobile. As you can give specific CSS sizes (e.g: "480px" or "40em"), you can also use the {@link sap.m.ScreenSize} enumeration (e.g: "Phone", "Tablet", "Desktop", "Small", "Medium", "Large", ....). Please also see <code>demandPopin</code> property for further responsive design options.
				/// </summary>
				/// <returns>Value of property <code>minScreenWidth</code></returns>
				public extern virtual string getMinScreenWidth();

				/// <summary>
				/// Sets a new value for property {@link #getMinScreenWidth minScreenWidth}.
				/// 
				/// Defines the minimum screen width to show or hide this column. By default column is always shown. The responsive behavior of the <code>sap.m.Table</code> is determined by this property. As an example by setting <code>minScreenWidth</code> property to "40em" (or "640px" or "Tablet") shows this column on tablet (and desktop) but hides on mobile. As you can give specific CSS sizes (e.g: "480px" or "40em"), you can also use the {@link sap.m.ScreenSize} enumeration (e.g: "Phone", "Tablet", "Desktop", "Small", "Medium", "Large", ....). Please also see <code>demandPopin</code> property for further responsive design options.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMinScreenWidth">New value for property <code>minScreenWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setMinScreenWidth(string sMinScreenWidth);

				#endregion

				#region Methods for Property demandPopin

				/// <summary>
				/// Gets current value of property {@link #getDemandPopin demandPopin}.
				/// 
				/// According to your minScreenWidth settings, the column can be hidden in different screen sizes. Setting this property to true, shows this column as pop-in instead of hiding it.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>demandPopin</code></returns>
				public extern virtual bool getDemandPopin();

				/// <summary>
				/// Sets a new value for property {@link #getDemandPopin demandPopin}.
				/// 
				/// According to your minScreenWidth settings, the column can be hidden in different screen sizes. Setting this property to true, shows this column as pop-in instead of hiding it.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bDemandPopin">New value for property <code>demandPopin</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setDemandPopin(bool bDemandPopin);

				#endregion

				#region Methods for Property popinHAlign

				/// <summary>
				/// Gets current value of property {@link #getPopinHAlign popinHAlign}.
				/// 
				/// Horizontal alignment of the pop-in content. Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
				/// 
				/// <b>Note:</b> Controls with a text align do not inherit the horizontal alignment.
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <returns>Value of property <code>popinHAlign</code></returns>
				[Obsolete("Deprecated since 1.14. Use popinDisplay property instead.")]
				public extern virtual sap.ui.core.TextAlign getPopinHAlign();

				/// <summary>
				/// Sets a new value for property {@link #getPopinHAlign popinHAlign}.
				/// 
				/// Horizontal alignment of the pop-in content. Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
				/// 
				/// <b>Note:</b> Controls with a text align do not inherit the horizontal alignment.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <param name="sPopinHAlign">New value for property <code>popinHAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.14. Use popinDisplay property instead.")]
				public extern virtual sap.m.Column setPopinHAlign(sap.ui.core.TextAlign sPopinHAlign);

				#endregion

				#region Methods for Property popinDisplay

				/// <summary>
				/// Gets current value of property {@link #getPopinDisplay popinDisplay}.
				/// 
				/// Defines enumerated display options for the pop-in.
				/// 
				/// Default value is <code>Block</code>.
				/// </summary>
				/// <returns>Value of property <code>popinDisplay</code></returns>
				public extern virtual sap.m.PopinDisplay getPopinDisplay();

				/// <summary>
				/// Sets a new value for property {@link #getPopinDisplay popinDisplay}.
				/// 
				/// Defines enumerated display options for the pop-in.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Block</code>.
				/// </summary>
				/// <param name="sPopinDisplay">New value for property <code>popinDisplay</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setPopinDisplay(sap.m.PopinDisplay sPopinDisplay);

				#endregion

				#region Methods for Property mergeDuplicates

				/// <summary>
				/// Gets current value of property {@link #getMergeDuplicates mergeDuplicates}.
				/// 
				/// Set <code>true</code> to merge repeating/duplicate cells into one cell block. See <code>mergeFunctionName</code> property to customize. <b>Note:</b> Merging only happens at the rendering of the <code>sap.m.Table</code> control, subsequent changes on the cell or item do not have any effect on the merged state of the cells, therefore this feature should not be used together with two-way binding. This property is ignored if any column is configured to be shown as a pop-in.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>mergeDuplicates</code></returns>
				public extern virtual bool getMergeDuplicates();

				/// <summary>
				/// Sets a new value for property {@link #getMergeDuplicates mergeDuplicates}.
				/// 
				/// Set <code>true</code> to merge repeating/duplicate cells into one cell block. See <code>mergeFunctionName</code> property to customize. <b>Note:</b> Merging only happens at the rendering of the <code>sap.m.Table</code> control, subsequent changes on the cell or item do not have any effect on the merged state of the cells, therefore this feature should not be used together with two-way binding. This property is ignored if any column is configured to be shown as a pop-in.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bMergeDuplicates">New value for property <code>mergeDuplicates</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setMergeDuplicates(bool bMergeDuplicates);

				#endregion

				#region Methods for Property mergeFunctionName

				/// <summary>
				/// Gets current value of property {@link #getMergeFunctionName mergeFunctionName}.
				/// 
				/// Defines the control serialization function if <code>mergeDuplicates<code> property is set to <code>true</code>. The control itself uses this function to compare values of two repeating cells. Default value "getText" is suitable for <code>sap.m.Label</code> and <code>sap.m.Text</code> controls but for the <code>sap.ui.core.Icon</code> control "getSrc" function should be used to merge icons. <b>Note:</b> You can pass one string parameter to given function after "#" sign. e.g. "data#myparameter"
				/// 
				/// Default value is <code>getText</code>.
				/// </summary>
				/// <returns>Value of property <code>mergeFunctionName</code></returns>
				public extern virtual string getMergeFunctionName();

				/// <summary>
				/// Sets a new value for property {@link #getMergeFunctionName mergeFunctionName}.
				/// 
				/// Defines the control serialization function if <code>mergeDuplicates<code> property is set to <code>true</code>. The control itself uses this function to compare values of two repeating cells. Default value "getText" is suitable for <code>sap.m.Label</code> and <code>sap.m.Text</code> controls but for the <code>sap.ui.core.Icon</code> control "getSrc" function should be used to merge icons. <b>Note:</b> You can pass one string parameter to given function after "#" sign. e.g. "data#myparameter"
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>getText</code>.
				/// </summary>
				/// <param name="sMergeFunctionName">New value for property <code>mergeFunctionName</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setMergeFunctionName(string sMergeFunctionName);

				#endregion

				#region Methods for Aggregation header

				/// <summary>
				/// Gets content of aggregation {@link #getHeader header}.
				/// 
				/// Control to be displayed in the column header.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getHeader();

				/// <summary>
				/// Destroys the header in the aggregation {@link #getHeader header}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column destroyHeader();

				/// <summary>
				/// Sets the aggregated {@link #getHeader header}.
				/// </summary>
				/// <param name="oHeader">The header to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setHeader(sap.ui.core.Control oHeader);

				#endregion

				#region Methods for Aggregation footer

				/// <summary>
				/// Gets content of aggregation {@link #getFooter footer}.
				/// 
				/// Control to be displayed in the column footer.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getFooter();

				/// <summary>
				/// Destroys the footer in the aggregation {@link #getFooter footer}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column destroyFooter();

				/// <summary>
				/// Sets the aggregated {@link #getFooter footer}.
				/// </summary>
				/// <param name="oFooter">The footer to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Column setFooter(sap.ui.core.Control oFooter);

				#endregion

				#region Other methods

				/// <summary>
				/// Apply text alignment of the Column to the Text controls
				/// </summary>
				/// <param name="oControl">List control</param>
				/// <param name="sAlign">TextAlign enumeration</param>
				/// <returns>oControl</returns>
				public extern virtual sap.ui.core.Control applyAlignTo(sap.ui.core.Control oControl, string sAlign);

				/// <summary>
				/// Apply text alignment of the Column to the Text controls
				/// </summary>
				/// <param name="oControl">List control</param>
				/// <returns>oControl</returns>
				public extern virtual sap.ui.core.Control applyAlignTo(sap.ui.core.Control oControl);

				/// <summary>
				/// Clears the last value of the column if mergeDuplicates property is true
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Column clearLastValue();

				/// <summary>
				/// Creates a new subclass of class sap.m.Column with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Column with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Column with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns CSS alignment according to column hAlign setting or given parameter for Begin/End values checks the locale settings
				/// </summary>
				/// <param name="sAlign">TextAlign enumeration</param>
				/// <returns>left|center|right</returns>
				public extern virtual string getCssAlign(string sAlign);

				/// <summary>
				/// Returns CSS alignment according to column hAlign setting or given parameter for Begin/End values checks the locale settings
				/// </summary>
				/// <returns>left|center|right</returns>
				public extern virtual string getCssAlign();

				/// <summary>
				/// Gets the initial order of the column
				/// </summary>
				/// <returns>initial order of the column</returns>
				public extern virtual int getInitialOrder();

				/// <summary>
				/// Gets the last value of the column
				/// </summary>
				public extern virtual void getLastValue();

				/// <summary>
				/// Returns a metadata object for class sap.m.Column.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Gets the order of the column
				/// </summary>
				/// <returns>nOrder order of the column</returns>
				public extern virtual int getOrder();

				/// <summary>
				/// Determines whether the column will be hidden via media queries or not
				/// </summary>
				public extern virtual void isHidden();

				/// <summary>
				/// Determines whether the column will be shown as pop-in or not
				/// </summary>
				public extern virtual void isPopin();

				/// <summary>
				/// Gets called from the Table when the all items are removed
				/// </summary>
				public extern virtual void onItemsRemoved();

				/// <summary>
				/// Display or hide the column from given table This does not set the visibility property of the column
				/// </summary>
				/// <param name="oTableDomRef">Table DOM reference</param>
				/// <param name="bDisplay">whether visible or not</param>
				public extern virtual void setDisplay(object oTableDomRef, bool bDisplay);

				/// <summary>
				/// Display or hide the column from given table This does not set the visibility property of the column
				/// </summary>
				/// <param name="oTableDomRef">Table DOM reference</param>
				public extern virtual void setDisplay(object oTableDomRef);

				/// <summary>
				/// Display or hide the column from given table via checking media query changes
				/// </summary>
				/// <param name="oTableDomRef">Table DOM reference</param>
				public extern virtual void setDisplayViaMedia(object oTableDomRef);

				/// <summary>
				/// Sets the visible column index Negative index values can be used to clear
				/// </summary>
				/// <param name="nIndex">index of the visible column</param>
				public extern virtual void setIndex(int nIndex);

				/// <summary>
				/// Sets the initial order of the column
				/// </summary>
				/// <param name="nOrder">initial order of the column</param>
				public extern virtual void setInitialOrder(int nOrder);

				/// <summary>
				/// Sets the last value of the column if mergeDuplicates property is true
				/// </summary>
				/// <param name="value">Any Value</param>
				/// <returns></returns>
				public extern virtual sap.m.Column setLastValue(object value);

				/// <summary>
				/// Sets the order of the column Does not do the visual effect Table should be invalidate to re-render
				/// </summary>
				/// <param name="nOrder">order of the column</param>
				public extern virtual void setOrder(int nOrder);

				#endregion

				#endregion

			}
		}
	}
}
