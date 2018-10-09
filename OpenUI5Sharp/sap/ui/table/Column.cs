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
				/// The column allows you to define column specific properties that will be applied when rendering the table.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.Column")]
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
						/// Width of the column in CSS units. Default value is <code>auto</code>, see <a href="https://www.w3.org/TR/CSS2/tables.html#width-layout"></a> <p>Minimal column width is device-dependent, for example on desktop devices the column will not be smaller than 48px. <p>This property can be changed by the user or by the application configuration/personalization. <p>If a user adjusts the column width manually, the resulting value is always set in pixels. In addition, other columns with width <code>auto</code> get a fixed minimum width and do not shrink after the resizing.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Defines the minimum width of a column in pixels. <p>This property only has an effect if the given column width is flexible, for example with width <code>auto</code>. <p>This property only influences the automatic behavior. If a user adjusts the column width manually, the column width can become smaller. <p>Minimal column width is device-dependent, for example on desktop devices the column will not be smaller than 48px.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minWidth;

						/// <summary>
						/// If the table is wider than the sum of widths of the visible columns, the columns will be resized proportionally to their widths that were set originally. If set to false, the column will be displayed in the original width. If all columns are set to not be flexible, an extra "dummy" column will be created at the end of the table.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> flexible;

						/// <summary>
						/// If set to true, the column can be resized either using the resize bar (by mouse) or using the keyboard (SHIFT + Left/Right Arrow keys)
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> resizable;

						/// <summary>
						/// Horizontal alignment of the column content. Controls with a text align do not inherit the horizontal alignment. You have to set the text align directly on the template.
						/// </summary>
						public Union<sap.ui.core.HorizontalAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> hAlign;

						/// <summary>
						/// Indicates if the column is sorted. This property only controls if a sort indicator is displayed in the column header - it does not trigger the sort function. The column has to be sorted by calling <code>Column.sort()</code>
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sorted;

						/// <summary>
						/// This property indicates the sort direction (Ascending or Descending). The corresponding icon will be rendered if the property <code>sorted</code> is <code>true</code>
						/// </summary>
						public Union<sap.ui.table.SortOrder, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sortOrder;

						/// <summary>
						/// Specifies the binding property on which the column will sort. Since the column template may have composite bindings, it's not possible to figure out on which binding property the sort shall be applied. Therefore the binding property for sorting must be specified. For example, if the first name and last name are displayed in the same column, only one of the two can be defined as <code>sortProperty</code>.
						/// 
						/// A column menu entry for sorting can only be generated if the <code>sortProperty</code> is set.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> sortProperty;

						/// <summary>
						/// Indicates if the column is filtered. This property only controls if a filter indicator is displayed in the column header - it does not trigger the filter function. The column has to be filtered by calling <code>Column.sort()</code>
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> filtered;

						/// <summary>
						/// Specifies the binding property on which the column shall be filtered. Since the column template may have composite bindings, it's not possible to figure out on which binding property the filter shall be applied. Therefore the binding property for filtering must be specified. For example, if the first name and last name are displayed in the same column, only one of the two can be defined as <code>filterProperty</code>.
						/// 
						/// A column menu entry for filtering can only be generated if the <code>filterProperty</code> is set. The default menu entry is a text input field.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> filterProperty;

						/// <summary>
						/// Specifies the value of the filter as string (will be converted into the proper data type). It is possible to provide a filterOperator as string, as shown here: <pre>
						/// &gt; 50
						/// &lt; 100
						/// &gt;= 150
						/// &lt;= 200
						/// = 250
						/// != 300
						/// *something    ends with
						/// something*    starts with
						/// *something*   contains
						/// some..thing   between
						/// 50..100       between
						/// </pre>
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> filterValue;

						/// <summary>
						/// Filter operator to use when filtering this column.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> filterOperator;

						/// <summary>
						/// If this property is set, the default filter operator of the column is overridden. By default <code>Contains</code> is used for string and <code>EQ</code> for other types. A valid <code>sap.ui.model.FilterOperator</code> needs to be passed.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultFilterOperator;

						/// <summary>
						/// Type of Filter. This is used to transform the search term to the specified type, to make sure that the right columns are displayed. This should be the same as defined in binding for this column. As an alternative you can pass a function which does the conversion. The function receives the entered filter value as parameter and returns the proper value for the filter expression. Another option is to pass the class name of the type, e.g.: <code>sap.ui.model.type.Date</code> or an expression similar to the binding syntax, e.g.: <code>"\{type: 'sap.ui.model.type.Date', formatOptions: \{UTC: true\}, constraints: \{\} \}"</code>. Here the escaping is mandatory to avoid handling by the binding parser. By default the filter type is <code>sap.ui.model.type.String</code>.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> filterType;

						/// <summary>
						/// Indicates if the column is grouped.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> grouped;

						/// <summary>
						/// Invisible controls are not rendered.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

						/// <summary>
						/// The name of the column which is used in the column visibility menu item as text. If not set as a fallback the column menu tries to get the text from the nested Label.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

						/// <summary>
						/// Defines if the filter menu entry is displayed
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showFilterMenuEntry;

						/// <summary>
						/// Defines if the sort menu entries are displayed
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSortMenuEntry;

						/// <summary>
						/// If this property is set, a span is applied for the header. When moving columns, all columns which are part of the header will be moved. The <code>headerSpan</code> can be either an integer or an array of integers (if you use the multi header feature of the table). If you only specify an integer, this span is applied for all header rows, with multiple integers you can specify a separate span for each header row.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerSpan;

						/// <summary>
						/// Enables auto-resizing of the column on double clicking the resize bar. The width is determined on the widest currently displayed content. It does not consider rows which are currently not scrolled into view. Currently only implemented to work with the following controls: <code>sap.m.Text, sap.m.Label, sap.m.Link, sap.m.Input, sap.ui.commons.TextView, sap.ui.commons.Label, sap.ui.commons.Link and sap.ui.commons.TextField, sap.ui.commons.Checkbox, sap.m.Checkbox</code>
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> autoResizable;

						/// <summary>
						/// Label of the column which is displayed in the column header. This aggregation is for the standard behavior, where you only want to display one single row header. If a string is supplied, a default label control will be created. Which control this is depends on the loaded libraries.
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> label;

						/// <summary>
						/// Labels of the column which are displayed in the column header. Define a control for each header row in the table. Use this aggregation if you want to use multiple headers per column.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> multiLabels;

						/// <summary>
						/// Template (cell renderer) of this column. A template is decoupled from the column. Each time the template's properties or aggregations have been changed, the template has to be applied again via <code>setTemplate</code> for the changes to take effect. If a string is defined, a default text control will be created with its text property bound to the value of the string. The default template depends on the libraries loaded. If there is no template, the column will not be rendered in the table. The set of supported controls is limited. See section "{@link topic:148892ff9aea4a18b912829791e38f3e Tables: Which One Should I Choose?}" in the documentation for more details. While it is technically possible to also use other controls, doing so might lead to issues with regards to scrolling, alignment, condensed mode, screen reader support, and keyboard support.
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> template;

						/// <summary>
						/// The menu used by the column. By default the {@link sap.ui.table.ColumnMenu} is used.
						/// 
						/// <b>Note:</b> Applications must not use or change the default <code>sap.ui.table.ColumnMenu</code> of a column in any way or create own instances of <code>sap.ui.table.ColumnMenu</code>. To add a custom menu to a column, use the aggregation <code>menu</code> with a new instance of <code>sap.ui.unified.Menu</code>.
						/// </summary>
						public Union<sap.ui.unified.Menu, string, sap.ui.@base.ManagedObject.BindAggregationInfo> menu;

						/// <summary>
						/// Fires before the column menu is opened.
						/// </summary>
						public sap.ui.table.Column.ColumnMenuOpenDelegate columnMenuOpen;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ColumnMenuOpenInfo
					{
						/// <summary>
						/// Refence to the selected <code>menu</code> instance to be opened.
						/// </summary>
						public sap.ui.unified.Menu menu;

					}

					#endregion

					#region Delegates

					public delegate void ColumnMenuOpenDelegate(sap.ui.@base.Event<sap.ui.table.Column.ColumnMenuOpenInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Column.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Column(string sId, sap.ui.table.Column.Settings mSettings);

					/// <summary>
					/// Constructor for a new Column.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
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
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Column(sap.ui.table.Column.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Width of the column in CSS units. Default value is <code>auto</code>, see <a href="https://www.w3.org/TR/CSS2/tables.html#width-layout"></a> <p>Minimal column width is device-dependent, for example on desktop devices the column will not be smaller than 48px. <p>This property can be changed by the user or by the application configuration/personalization. <p>If a user adjusts the column width manually, the resulting value is always set in pixels. In addition, other columns with width <code>auto</code> get a fixed minimum width and do not shrink after the resizing.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Width of the column in CSS units. Default value is <code>auto</code>, see <a href="https://www.w3.org/TR/CSS2/tables.html#width-layout"></a> <p>Minimal column width is device-dependent, for example on desktop devices the column will not be smaller than 48px. <p>This property can be changed by the user or by the application configuration/personalization. <p>If a user adjusts the column width manually, the resulting value is always set in pixels. In addition, other columns with width <code>auto</code> get a fixed minimum width and do not shrink after the resizing.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property minWidth

					/// <summary>
					/// Gets current value of property {@link #getMinWidth minWidth}.
					/// 
					/// Defines the minimum width of a column in pixels. <p>This property only has an effect if the given column width is flexible, for example with width <code>auto</code>. <p>This property only influences the automatic behavior. If a user adjusts the column width manually, the column width can become smaller. <p>Minimal column width is device-dependent, for example on desktop devices the column will not be smaller than 48px.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>minWidth</code></returns>
					public extern virtual int getMinWidth();

					/// <summary>
					/// Sets a new value for property {@link #getMinWidth minWidth}.
					/// 
					/// Defines the minimum width of a column in pixels. <p>This property only has an effect if the given column width is flexible, for example with width <code>auto</code>. <p>This property only influences the automatic behavior. If a user adjusts the column width manually, the column width can become smaller. <p>Minimal column width is device-dependent, for example on desktop devices the column will not be smaller than 48px.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iMinWidth">New value for property <code>minWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setMinWidth(int iMinWidth);

					#endregion

					#region Methods for Property flexible

					/// <summary>
					/// Gets current value of property {@link #getFlexible flexible}.
					/// 
					/// If the table is wider than the sum of widths of the visible columns, the columns will be resized proportionally to their widths that were set originally. If set to false, the column will be displayed in the original width. If all columns are set to not be flexible, an extra "dummy" column will be created at the end of the table.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>flexible</code></returns>
					[Obsolete("Deprecated since 1.44. this property has no effect. Use the property <code>minWidth</code> in combination with the property <code>width='auto'</code> instead.")]
					public extern virtual bool getFlexible();

					/// <summary>
					/// Sets a new value for property {@link #getFlexible flexible}.
					/// 
					/// If the table is wider than the sum of widths of the visible columns, the columns will be resized proportionally to their widths that were set originally. If set to false, the column will be displayed in the original width. If all columns are set to not be flexible, an extra "dummy" column will be created at the end of the table.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bFlexible">New value for property <code>flexible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.44. this property has no effect. Use the property <code>minWidth</code> in combination with the property <code>width='auto'</code> instead.")]
					public extern virtual sap.ui.table.Column setFlexible(bool bFlexible);

					#endregion

					#region Methods for Property resizable

					/// <summary>
					/// Gets current value of property {@link #getResizable resizable}.
					/// 
					/// If set to true, the column can be resized either using the resize bar (by mouse) or using the keyboard (SHIFT + Left/Right Arrow keys)
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>resizable</code></returns>
					public extern virtual bool getResizable();

					/// <summary>
					/// Sets a new value for property {@link #getResizable resizable}.
					/// 
					/// If set to true, the column can be resized either using the resize bar (by mouse) or using the keyboard (SHIFT + Left/Right Arrow keys)
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bResizable">New value for property <code>resizable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setResizable(bool bResizable);

					#endregion

					#region Methods for Property hAlign

					/// <summary>
					/// Gets current value of property {@link #getHAlign hAlign}.
					/// 
					/// Horizontal alignment of the column content. Controls with a text align do not inherit the horizontal alignment. You have to set the text align directly on the template.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <returns>Value of property <code>hAlign</code></returns>
					public extern virtual sap.ui.core.HorizontalAlign getHAlign();

					/// <summary>
					/// Sets a new value for property {@link #getHAlign hAlign}.
					/// 
					/// Horizontal alignment of the column content. Controls with a text align do not inherit the horizontal alignment. You have to set the text align directly on the template.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <param name="sHAlign">New value for property <code>hAlign</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setHAlign(sap.ui.core.HorizontalAlign sHAlign);

					#endregion

					#region Methods for Property sorted

					/// <summary>
					/// Gets current value of property {@link #getSorted sorted}.
					/// 
					/// Indicates if the column is sorted. This property only controls if a sort indicator is displayed in the column header - it does not trigger the sort function. The column has to be sorted by calling <code>Column.sort()</code>
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>sorted</code></returns>
					public extern virtual bool getSorted();

					/// <summary>
					/// Sets a new value for property {@link #getSorted sorted}.
					/// 
					/// Indicates if the column is sorted. This property only controls if a sort indicator is displayed in the column header - it does not trigger the sort function. The column has to be sorted by calling <code>Column.sort()</code>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bSorted">New value for property <code>sorted</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setSorted(bool bSorted);

					#endregion

					#region Methods for Property sortOrder

					/// <summary>
					/// Gets current value of property {@link #getSortOrder sortOrder}.
					/// 
					/// This property indicates the sort direction (Ascending or Descending). The corresponding icon will be rendered if the property <code>sorted</code> is <code>true</code>
					/// 
					/// Default value is <code>Ascending</code>.
					/// </summary>
					/// <returns>Value of property <code>sortOrder</code></returns>
					public extern virtual sap.ui.table.SortOrder getSortOrder();

					/// <summary>
					/// Sets a new value for property {@link #getSortOrder sortOrder}.
					/// 
					/// This property indicates the sort direction (Ascending or Descending). The corresponding icon will be rendered if the property <code>sorted</code> is <code>true</code>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Ascending</code>.
					/// </summary>
					/// <param name="sSortOrder">New value for property <code>sortOrder</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setSortOrder(sap.ui.table.SortOrder sSortOrder);

					#endregion

					#region Methods for Property sortProperty

					/// <summary>
					/// Gets current value of property {@link #getSortProperty sortProperty}.
					/// 
					/// Specifies the binding property on which the column will sort. Since the column template may have composite bindings, it's not possible to figure out on which binding property the sort shall be applied. Therefore the binding property for sorting must be specified. For example, if the first name and last name are displayed in the same column, only one of the two can be defined as <code>sortProperty</code>.
					/// 
					/// A column menu entry for sorting can only be generated if the <code>sortProperty</code> is set.
					/// </summary>
					/// <returns>Value of property <code>sortProperty</code></returns>
					public extern virtual string getSortProperty();

					/// <summary>
					/// Sets a new value for property {@link #getSortProperty sortProperty}.
					/// 
					/// Specifies the binding property on which the column will sort. Since the column template may have composite bindings, it's not possible to figure out on which binding property the sort shall be applied. Therefore the binding property for sorting must be specified. For example, if the first name and last name are displayed in the same column, only one of the two can be defined as <code>sortProperty</code>.
					/// 
					/// A column menu entry for sorting can only be generated if the <code>sortProperty</code> is set.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSortProperty">New value for property <code>sortProperty</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setSortProperty(string sSortProperty);

					#endregion

					#region Methods for Property filtered

					/// <summary>
					/// Gets current value of property {@link #getFiltered filtered}.
					/// 
					/// Indicates if the column is filtered. This property only controls if a filter indicator is displayed in the column header - it does not trigger the filter function. The column has to be filtered by calling <code>Column.sort()</code>
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>filtered</code></returns>
					public extern virtual bool getFiltered();

					/// <summary>
					/// Sets a new value for property {@link #getFiltered filtered}.
					/// 
					/// Indicates if the column is filtered. This property only controls if a filter indicator is displayed in the column header - it does not trigger the filter function. The column has to be filtered by calling <code>Column.sort()</code>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bFiltered">New value for property <code>filtered</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setFiltered(bool bFiltered);

					#endregion

					#region Methods for Property filterProperty

					/// <summary>
					/// Gets current value of property {@link #getFilterProperty filterProperty}.
					/// 
					/// Specifies the binding property on which the column shall be filtered. Since the column template may have composite bindings, it's not possible to figure out on which binding property the filter shall be applied. Therefore the binding property for filtering must be specified. For example, if the first name and last name are displayed in the same column, only one of the two can be defined as <code>filterProperty</code>.
					/// 
					/// A column menu entry for filtering can only be generated if the <code>filterProperty</code> is set. The default menu entry is a text input field.
					/// </summary>
					/// <returns>Value of property <code>filterProperty</code></returns>
					public extern virtual string getFilterProperty();

					/// <summary>
					/// Sets a new value for property {@link #getFilterProperty filterProperty}.
					/// 
					/// Specifies the binding property on which the column shall be filtered. Since the column template may have composite bindings, it's not possible to figure out on which binding property the filter shall be applied. Therefore the binding property for filtering must be specified. For example, if the first name and last name are displayed in the same column, only one of the two can be defined as <code>filterProperty</code>.
					/// 
					/// A column menu entry for filtering can only be generated if the <code>filterProperty</code> is set. The default menu entry is a text input field.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFilterProperty">New value for property <code>filterProperty</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setFilterProperty(string sFilterProperty);

					#endregion

					#region Methods for Property filterValue

					/// <summary>
					/// Gets current value of property {@link #getFilterValue filterValue}.
					/// 
					/// Specifies the value of the filter as string (will be converted into the proper data type). It is possible to provide a filterOperator as string, as shown here: <pre>
					/// &gt; 50
					/// &lt; 100
					/// &gt;= 150
					/// &lt;= 200
					/// = 250
					/// != 300
					/// something    ends with
					/// something*    starts with
					/// something*   contains
					/// some..thing   between
					/// 50..100       between
					/// </pre>
					/// </summary>
					/// <returns>Value of property <code>filterValue</code></returns>
					public extern virtual string getFilterValue();

					/// <summary>
					/// Sets a new value for property {@link #getFilterValue filterValue}.
					/// 
					/// Specifies the value of the filter as string (will be converted into the proper data type). It is possible to provide a filterOperator as string, as shown here: <pre>
					/// &gt; 50
					/// &lt; 100
					/// &gt;= 150
					/// &lt;= 200
					/// = 250
					/// != 300
					/// something    ends with
					/// something*    starts with
					/// something*   contains
					/// some..thing   between
					/// 50..100       between
					/// </pre>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFilterValue">New value for property <code>filterValue</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setFilterValue(string sFilterValue);

					#endregion

					#region Methods for Property filterOperator

					/// <summary>
					/// Gets current value of property {@link #getFilterOperator filterOperator}.
					/// 
					/// Filter operator to use when filtering this column.
					/// </summary>
					/// <returns>Value of property <code>filterOperator</code></returns>
					public extern virtual string getFilterOperator();

					/// <summary>
					/// Sets a new value for property {@link #getFilterOperator filterOperator}.
					/// 
					/// Filter operator to use when filtering this column.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFilterOperator">New value for property <code>filterOperator</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setFilterOperator(string sFilterOperator);

					#endregion

					#region Methods for Property defaultFilterOperator

					/// <summary>
					/// Gets current value of property {@link #getDefaultFilterOperator defaultFilterOperator}.
					/// 
					/// If this property is set, the default filter operator of the column is overridden. By default <code>Contains</code> is used for string and <code>EQ</code> for other types. A valid <code>sap.ui.model.FilterOperator</code> needs to be passed.
					/// </summary>
					/// <returns>Value of property <code>defaultFilterOperator</code></returns>
					public extern virtual string getDefaultFilterOperator();

					/// <summary>
					/// Sets a new value for property {@link #getDefaultFilterOperator defaultFilterOperator}.
					/// 
					/// If this property is set, the default filter operator of the column is overridden. By default <code>Contains</code> is used for string and <code>EQ</code> for other types. A valid <code>sap.ui.model.FilterOperator</code> needs to be passed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sDefaultFilterOperator">New value for property <code>defaultFilterOperator</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setDefaultFilterOperator(string sDefaultFilterOperator);

					#endregion

					#region Methods for Property filterType

					/// <summary>
					/// Gets current value of property {@link #getFilterType filterType}.
					/// 
					/// Type of Filter. This is used to transform the search term to the specified type, to make sure that the right columns are displayed. This should be the same as defined in binding for this column. As an alternative you can pass a function which does the conversion. The function receives the entered filter value as parameter and returns the proper value for the filter expression. Another option is to pass the class name of the type, e.g.: <code>sap.ui.model.type.Date</code> or an expression similar to the binding syntax, e.g.: <code>"\{type: 'sap.ui.model.type.Date', formatOptions: \{UTC: true\}, constraints: \{\} \}"</code>. Here the escaping is mandatory to avoid handling by the binding parser. By default the filter type is <code>sap.ui.model.type.String</code>.
					/// </summary>
					/// <returns>Value of property <code>filterType</code></returns>
					public extern virtual object getFilterType();

					/// <summary>
					/// Sets a new value for property {@link #getFilterType filterType}.
					/// 
					/// Type of Filter. This is used to transform the search term to the specified type, to make sure that the right columns are displayed. This should be the same as defined in binding for this column. As an alternative you can pass a function which does the conversion. The function receives the entered filter value as parameter and returns the proper value for the filter expression. Another option is to pass the class name of the type, e.g.: <code>sap.ui.model.type.Date</code> or an expression similar to the binding syntax, e.g.: <code>"\{type: 'sap.ui.model.type.Date', formatOptions: \{UTC: true\}, constraints: \{\} \}"</code>. Here the escaping is mandatory to avoid handling by the binding parser. By default the filter type is <code>sap.ui.model.type.String</code>.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oFilterType">New value for property <code>filterType</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setFilterType(object oFilterType);

					#endregion

					#region Methods for Property grouped

					/// <summary>
					/// Gets current value of property {@link #getGrouped grouped}.
					/// 
					/// Indicates if the column is grouped.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>grouped</code></returns>
					public extern virtual bool getGrouped();

					/// <summary>
					/// Sets a new value for property {@link #getGrouped grouped}.
					/// 
					/// Indicates if the column is grouped.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bGrouped">New value for property <code>grouped</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setGrouped(bool bGrouped);

					#endregion

					#region Methods for Property visible

					/// <summary>
					/// Gets current value of property {@link #getVisible visible}.
					/// 
					/// Invisible controls are not rendered.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visible</code></returns>
					public extern virtual bool getVisible();

					/// <summary>
					/// Sets a new value for property {@link #getVisible visible}.
					/// 
					/// Invisible controls are not rendered.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisible">New value for property <code>visible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setVisible(bool bVisible);

					#endregion

					#region Methods for Property name

					/// <summary>
					/// Gets current value of property {@link #getName name}.
					/// 
					/// The name of the column which is used in the column visibility menu item as text. If not set as a fallback the column menu tries to get the text from the nested Label.
					/// </summary>
					/// <returns>Value of property <code>name</code></returns>
					public extern virtual string getName();

					/// <summary>
					/// Sets a new value for property {@link #getName name}.
					/// 
					/// The name of the column which is used in the column visibility menu item as text. If not set as a fallback the column menu tries to get the text from the nested Label.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sName">New value for property <code>name</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setName(string sName);

					#endregion

					#region Methods for Property showFilterMenuEntry

					/// <summary>
					/// Gets current value of property {@link #getShowFilterMenuEntry showFilterMenuEntry}.
					/// 
					/// Defines if the filter menu entry is displayed
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showFilterMenuEntry</code></returns>
					public extern virtual bool getShowFilterMenuEntry();

					/// <summary>
					/// Sets a new value for property {@link #getShowFilterMenuEntry showFilterMenuEntry}.
					/// 
					/// Defines if the filter menu entry is displayed
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowFilterMenuEntry">New value for property <code>showFilterMenuEntry</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setShowFilterMenuEntry(bool bShowFilterMenuEntry);

					#endregion

					#region Methods for Property showSortMenuEntry

					/// <summary>
					/// Gets current value of property {@link #getShowSortMenuEntry showSortMenuEntry}.
					/// 
					/// Defines if the sort menu entries are displayed
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showSortMenuEntry</code></returns>
					public extern virtual bool getShowSortMenuEntry();

					/// <summary>
					/// Sets a new value for property {@link #getShowSortMenuEntry showSortMenuEntry}.
					/// 
					/// Defines if the sort menu entries are displayed
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowSortMenuEntry">New value for property <code>showSortMenuEntry</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setShowSortMenuEntry(bool bShowSortMenuEntry);

					#endregion

					#region Methods for Property headerSpan

					/// <summary>
					/// Gets current value of property {@link #getHeaderSpan headerSpan}.
					/// 
					/// If this property is set, a span is applied for the header. When moving columns, all columns which are part of the header will be moved. The <code>headerSpan</code> can be either an integer or an array of integers (if you use the multi header feature of the table). If you only specify an integer, this span is applied for all header rows, with multiple integers you can specify a separate span for each header row.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>headerSpan</code></returns>
					public extern virtual object getHeaderSpan();

					/// <summary>
					/// Sets a new value for property {@link #getHeaderSpan headerSpan}.
					/// 
					/// If this property is set, a span is applied for the header. When moving columns, all columns which are part of the header will be moved. The <code>headerSpan</code> can be either an integer or an array of integers (if you use the multi header feature of the table). If you only specify an integer, this span is applied for all header rows, with multiple integers you can specify a separate span for each header row.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="oHeaderSpan">New value for property <code>headerSpan</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setHeaderSpan(object oHeaderSpan);

					#endregion

					#region Methods for Property autoResizable

					/// <summary>
					/// Gets current value of property {@link #getAutoResizable autoResizable}.
					/// 
					/// Enables auto-resizing of the column on double clicking the resize bar. The width is determined on the widest currently displayed content. It does not consider rows which are currently not scrolled into view. Currently only implemented to work with the following controls: <code>sap.m.Text, sap.m.Label, sap.m.Link, sap.m.Input, sap.ui.commons.TextView, sap.ui.commons.Label, sap.ui.commons.Link and sap.ui.commons.TextField, sap.ui.commons.Checkbox, sap.m.Checkbox</code>
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>autoResizable</code></returns>
					public extern virtual bool getAutoResizable();

					/// <summary>
					/// Sets a new value for property {@link #getAutoResizable autoResizable}.
					/// 
					/// Enables auto-resizing of the column on double clicking the resize bar. The width is determined on the widest currently displayed content. It does not consider rows which are currently not scrolled into view. Currently only implemented to work with the following controls: <code>sap.m.Text, sap.m.Label, sap.m.Link, sap.m.Input, sap.ui.commons.TextView, sap.ui.commons.Label, sap.ui.commons.Link and sap.ui.commons.TextField, sap.ui.commons.Checkbox, sap.m.Checkbox</code>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bAutoResizable">New value for property <code>autoResizable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setAutoResizable(bool bAutoResizable);

					#endregion

					#region Methods for Aggregation label

					/// <summary>
					/// Gets content of aggregation {@link #getLabel label}.
					/// 
					/// Label of the column which is displayed in the column header. This aggregation is for the standard behavior, where you only want to display one single row header. If a string is supplied, a default label control will be created. Which control this is depends on the loaded libraries.
					/// </summary>
					/// <returns></returns>
					public extern virtual Union<sap.ui.core.Control, string> getLabel();

					/// <summary>
					/// Destroys the label in the aggregation {@link #getLabel label}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column destroyLabel();

					/// <summary>
					/// Sets the aggregated {@link #getLabel label}.
					/// </summary>
					/// <param name="vLabel">The label to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setLabel(Union<sap.ui.core.Control, string> vLabel);

					#endregion

					#region Methods for Aggregation multiLabels

					/// <summary>
					/// Gets content of aggregation {@link #getMultiLabels multiLabels}.
					/// 
					/// Labels of the column which are displayed in the column header. Define a control for each header row in the table. Use this aggregation if you want to use multiple headers per column.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getMultiLabels();

					/// <summary>
					/// Destroys all the multiLabels in the aggregation {@link #getMultiLabels multiLabels}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column destroyMultiLabels();

					/// <summary>
					/// Inserts a multiLabel into the aggregation {@link #getMultiLabels multiLabels}.
					/// </summary>
					/// <param name="oMultiLabel">The multiLabel to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the multiLabel should be inserted at; for a negative value of <code>iIndex</code>, the multiLabel is inserted at position 0; for a value greater than the current size of the aggregation, the multiLabel is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column insertMultiLabel(sap.ui.core.Control oMultiLabel, int iIndex);

					/// <summary>
					/// Adds some multiLabel to the aggregation {@link #getMultiLabels multiLabels}.
					/// </summary>
					/// <param name="oMultiLabel">The multiLabel to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column addMultiLabel(sap.ui.core.Control oMultiLabel);

					/// <summary>
					/// Removes a multiLabel from the aggregation {@link #getMultiLabels multiLabels}.
					/// </summary>
					/// <param name="vMultiLabel">The multiLabel to remove or its index or id</param>
					/// <returns>The removed multiLabel or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeMultiLabel(Union<int, string, sap.ui.core.Control> vMultiLabel);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getMultiLabels multiLabels}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oMultiLabel">The multiLabel whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfMultiLabel(sap.ui.core.Control oMultiLabel);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getMultiLabels multiLabels}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllMultiLabels();

					#endregion

					#region Methods for Aggregation template

					/// <summary>
					/// Gets content of aggregation {@link #getTemplate template}.
					/// 
					/// Template (cell renderer) of this column. A template is decoupled from the column. Each time the template's properties or aggregations have been changed, the template has to be applied again via <code>setTemplate</code> for the changes to take effect. If a string is defined, a default text control will be created with its text property bound to the value of the string. The default template depends on the libraries loaded. If there is no template, the column will not be rendered in the table. The set of supported controls is limited. See section "{@link topic:148892ff9aea4a18b912829791e38f3e Tables: Which One Should I Choose?}" in the documentation for more details. While it is technically possible to also use other controls, doing so might lead to issues with regards to scrolling, alignment, condensed mode, screen reader support, and keyboard support.
					/// </summary>
					/// <returns></returns>
					public extern virtual Union<sap.ui.core.Control, string> getTemplate();

					/// <summary>
					/// Destroys the template in the aggregation {@link #getTemplate template}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column destroyTemplate();

					/// <summary>
					/// Sets the aggregated {@link #getTemplate template}.
					/// </summary>
					/// <param name="vTemplate">The template to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setTemplate(Union<sap.ui.core.Control, string> vTemplate);

					#endregion

					#region Methods for Aggregation menu

					/// <summary>
					/// Gets content of aggregation {@link #getMenu menu}.
					/// 
					/// The menu used by the column. By default the {@link sap.ui.table.ColumnMenu} is used.
					/// 
					/// <b>Note:</b> Applications must not use or change the default <code>sap.ui.table.ColumnMenu</code> of a column in any way or create own instances of <code>sap.ui.table.ColumnMenu</code>. To add a custom menu to a column, use the aggregation <code>menu</code> with a new instance of <code>sap.ui.unified.Menu</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.Menu getMenu();

					/// <summary>
					/// Destroys the menu in the aggregation {@link #getMenu menu}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column destroyMenu();

					/// <summary>
					/// Sets the aggregated {@link #getMenu menu}.
					/// </summary>
					/// <param name="oMenu">The menu to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column setMenu(sap.ui.unified.Menu oMenu);

					#endregion

					#region Methods for Event columnMenuOpen

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnMenuOpen columnMenuOpen} event of this <code>sap.ui.table.Column</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Column</code> itself.
					/// 
					/// Fires before the column menu is opened.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Column</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column attachColumnMenuOpen(object oData, sap.ui.table.Column.ColumnMenuOpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnMenuOpen columnMenuOpen} event of this <code>sap.ui.table.Column</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Column</code> itself.
					/// 
					/// Fires before the column menu is opened.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column attachColumnMenuOpen(object oData, sap.ui.table.Column.ColumnMenuOpenDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnMenuOpen columnMenuOpen} event of this <code>sap.ui.table.Column</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Column</code> itself.
					/// 
					/// Fires before the column menu is opened.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column attachColumnMenuOpen(sap.ui.table.Column.ColumnMenuOpenDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnMenuOpen columnMenuOpen} event of this <code>sap.ui.table.Column</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Column</code> itself.
					/// 
					/// Fires before the column menu is opened.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Column</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column attachColumnMenuOpen(sap.ui.table.Column.ColumnMenuOpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:columnMenuOpen columnMenuOpen} event of this <code>sap.ui.table.Column</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Column detachColumnMenuOpen(sap.ui.table.Column.ColumnMenuOpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:columnMenuOpen columnMenuOpen} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnMenuOpen(sap.ui.table.Column.ColumnMenuOpenInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:columnMenuOpen columnMenuOpen} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnMenuOpen();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.Column with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.Column with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.Column with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.table.Column.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns a column template clone. It either finds an unused clone or clones a new one from the column template.
					/// </summary>
					/// <param name="iIndex">Index of the column in the column aggregation of the table</param>
					/// <returns>Clone of the column template, or <code>null</code> if no column template is defined</returns>
					public extern virtual sap.ui.core.Control getTemplateClone(int iIndex);

					/// <summary>
					/// Returns whether the column should be rendered.
					/// </summary>
					/// <returns>Returns <code>true</code>, if the column should be rendered</returns>
					public extern virtual bool shouldRender();

					/// <summary>
					/// sorts the current column ascending or descending
					/// </summary>
					/// <param name="bDescending">sort order of the column (if undefined the default will be ascending)</param>
					/// <returns></returns>
					[Obsolete("Deprecated since 1.5.1. Please use the function 'sap.ui.Table.prototype.sort'.")]
					public extern virtual sap.ui.table.Column sort(bool bDescending);

					/// <summary>
					/// Toggles the sort order of the column.
					/// </summary>
					/// <returns></returns>
					[Obsolete("Deprecated since 1.5.1. Please use the function 'sap.ui.Table.prototype.sort'.")]
					public extern virtual sap.ui.table.Column toggleSort();

					#endregion

					#endregion

				}
			}
		}
	}
}
