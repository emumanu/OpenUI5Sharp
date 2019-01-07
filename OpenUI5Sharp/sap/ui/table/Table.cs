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
				/// <p> Provides a comprehensive set of features for displaying and dealing with vast amounts of data. The Table control supports desktop PCs and tablet devices. On tablets, special consideration should be given to the number of visible columns and rows due to the limited performance of some devices. </p> <p> In order to keep the document DOM as lean as possible, the Table control reuses its DOM elements of the rows. When the user scrolls, only the row contexts are changed but the rendered controls remain the same. This allows the Table control to handle huge amounts of data. Nevertheless, restrictions apply regarding the number of displayed columns. Keep the number as low as possible to improve performance. Due to the nature of tables, the used control for column templates also has a big influence on the performance. </p> <p> The Table control relies completely on data binding, and its supported feature set is tightly coupled to the data model and binding being used. </p>
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.Table")]
				public partial class Table : sap.ui.core.Control
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
						/// Width of the Table.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// The height of the row content in pixel. The actual row height is also influenced by other factors, such as the border width. If no value is set, a default height is applied based on the content density configuration.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> rowHeight;

						/// <summary>
						/// Height of the column header of the Table in pixel.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnHeaderHeight;

						/// <summary>
						/// Flag whether the column header is visible or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnHeaderVisible;

						/// <summary>
						/// Number of visible rows of the table.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleRowCount;

						/// <summary>
						/// First visible row.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> firstVisibleRow;

						/// <summary>
						/// Selection mode of the Table. This property controls whether single or multiple rows can be selected and how the selection can be extended. It may also influence the visual appearance. When the selection mode is changed, the current selection is removed. <b>Note:</b> Since the group header visualization relies on the row selectors, the row selectors are always shown if the grouping functionality (depends on table type) is enabled, even if <code>sap.ui.table.SelectionMode.None</code> is set.
						/// </summary>
						public Union<sap.ui.table.SelectionMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectionMode;

						/// <summary>
						/// Selection behavior of the Table. This property defines whether the row selector is displayed and whether the row, the row selector or both can be clicked to select a row. <b>Note:</b> Since the group header visualization relies on the row selectors, the row selectors are always shown if the grouping functionality (depends on table type) is enabled, even if <code>sap.ui.table.SelectionBehavior.RowOnly</code> is set.
						/// </summary>
						public Union<sap.ui.table.SelectionBehavior, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectionBehavior;

						/// <summary>
						/// Zero-based index of selected item. Index value for no selection is -1. When multi-selection is enabled and multiple items are selected, the method returns the lead selected item. Sets the zero-based index of the currently selected item. This method removes any previous selections. When the given index is invalid, the call is ignored.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedIndex;

						/// <summary>
						/// Flag whether the controls of the Table are editable or not (currently this only controls the background color in certain themes!)
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

						/// <summary>
						/// This property has been deprecated and must not be used anymore, since <code>Scrollbar</code> is the only supported option.
						/// </summary>
						public Union<sap.ui.table.NavigationMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> navigationMode;

						/// <summary>
						/// The <code>threshold</code> defines how many additional (not yet visible records) shall be pre-fetched to enable smooth scrolling. The threshold is always added to the <code>visibleRowCount</code>. If the <code>visibleRowCount</code> is 10 and the <code>threshold</code> is 100, there will be 110 records fetched with the initial load. If the <code>threshold</code> is lower than the <code>visibleRowCount</code>, the <code>visibleRowCount</code> will be used as the <code>threshold</code>. If the value is 0 then the thresholding is disabled.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> threshold;

						/// <summary>
						/// Flag to enable or disable column reordering
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableColumnReordering;

						/// <summary>
						/// Enables or disables grouping. If grouping is enabled, the table is grouped by the column which is defined in the <code>groupBy</code> association.
						/// 
						/// The following restrictions apply: <ul> <li>Only client models are supported (e.g. {@link sap.ui.model.json.JSONModel}). Grouping does not work with OData models.</li> <li>The table can only be grouped by <b>one</b> column at a time. Grouping by another column will remove the current grouping.</li> <li>If grouping has been done, sorting and filtering is not possible. Any existing sorting and filtering rules do no longer apply. The UI is not updated accordingly (e.g. menu items, sort and filter icons).</li> <li>The column, by which the table is grouped, is not visible. It will become visible again only if the table is grouped by another column or grouping is disabled.</li> </ul>
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableGrouping;

						/// <summary>
						/// Flag to show or hide the column visibility menu. This menu will get displayed in each generated column header menu. It allows to show or hide columns
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showColumnVisibilityMenu;

						/// <summary>
						/// Flag whether to show the no data overlay or not once the table is empty. If set to false the table will just show a grid of empty cells
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showNoData;

						/// <summary>
						/// This defines how the table handles the visible rows in the table. The default behavior is, that a fixed row count is defined. If you change it to auto the visibleRowCount property is changed by the table automatically. It will then adjust its maximum row count to the space it is allowed to cover (limited by the surrounding container) and its minimum row count to the value of the property minAutoRowCount (default value : 5) In manual mode the user can change the visibleRowCount interactively.
						/// </summary>
						public Union<sap.ui.table.VisibleRowCountMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleRowCountMode;

						/// <summary>
						/// This property is used to set the minimum count of visible rows when the property visibleRowCountMode is set to Auto or Interactive. For any other visibleRowCountMode, it is ignored.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minAutoRowCount;

						/// <summary>
						/// Number of columns that are fixed on the left. Only columns which are not fixed can be scrolled horizontally.
						/// 
						/// <b>Note</b> <ul> <li>Fixed columns need a defined width for the feature to work.</li> <li>The aggregated width of all fixed columns must not exceed the table width. Otherwise the table ignores the value of the property and adapts the behavior in an appropriate way to ensure that the user is still able to scroll horizontally.</li> </ul>
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fixedColumnCount;

						/// <summary>
						/// Number of rows that are fix on the top. When you use a vertical scrollbar, only the rows which are not fixed, will scroll.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fixedRowCount;

						/// <summary>
						/// Number of rows that are fix on the bottom. When you use a vertical scrollbar, only the rows which are not fixed, will scroll.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fixedBottomRowCount;

						/// <summary>
						/// Flag whether to show or hide the column menu item to freeze or unfreeze a column.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableColumnFreeze;

						/// <summary>
						/// Flag whether to enable or disable the context menu on cells to trigger a filtering with the cell value.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableCellFilter;

						/// <summary>
						/// Setting this property to true will show an overlay on top of the Table content and users cannot click anymore on the Table content.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showOverlay;

						/// <summary>
						/// Specifies if a select all button should be displayed in the top left corner. This button is only displayed if the row selector is visible and the selection mode is set to any kind of multi selection.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableSelectAll;

						/// <summary>
						/// Set this parameter to true to implement your own filter behaviour. Instead of the filter input box a button will be rendered for which' press event (customFilter) you can register an event handler.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableCustomFilter;

						/// <summary>
						/// If set to <code>true</code>, the table changes its busy state, resulting in showing or hiding the busy indicator. The table will switch to busy as soon as data is retrieved to be displayed in the currently visible rows. This happens, for example, during scrolling, filtering, or sorting. As soon as the data has been retrieved, the table switches back to not busy. The busy state of the table can still be set manually by calling {@link sap.ui.core.Control#setBusy}.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableBusyIndicator;

						/// <summary>
						/// Number of row actions made visible which determines the width of the row action column. The values <code>0</code>, <code>1</code> and <code>2</code> are possible.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> rowActionCount;

						/// <summary>
						/// Enables alternating table row colors. Alternate row coloring is not available for the tree mode.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> alternateRowColors;

						/// <summary>
						/// Control or text of title section of the Table (if not set it will be hidden)
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

						/// <summary>
						/// Control or text of footer section of the Table (if not set it will be hidden)
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> footer;

						/// <summary>
						/// Toolbar of the Table If not set, no toolbar area will be rendered. Note: The CSS class sapMTBHeader-CTX is applied on the given toolbar.
						/// </summary>
						public Union<sap.ui.core.Toolbar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> toolbar;

						/// <summary>
						/// Extension section of the Table. If not set, no extension area will be rendered. Note: In case a <code>sap.m.Toolbar</code> is used as header the CSS class sapMTBHeader-CTX should be applied on this toolbar via <code>addStyleClass</code>.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> extension;

						/// <summary>
						/// Columns of the Table
						/// </summary>
						public Union<sap.ui.table.Column[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> columns;

						/// <summary>
						/// Rows of the Table
						/// </summary>
						public Union<sap.ui.table.Row[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> rows;

						/// <summary>
						/// The value for the noData aggregation can be either a string value or a control instance. The control is shown, in case there is no data for the Table available. In case of a string value this will simply replace the no data text.
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> noData;

						/// <summary>
						/// Template for row actions. A template is decoupled from the row or table. Each time the template's properties or aggregations are changed, the template has to be applied again via <code>setRowActionTemplate</code> for the changes to take effect.
						/// </summary>
						public Union<sap.ui.table.RowAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> rowActionTemplate;

						/// <summary>
						/// Template for row settings. A template is decoupled from the row or table. Each time the template's properties or aggregations are changed, the template has to be applied again via <code>setRowSettingsTemplate</code> for the changes to take effect.
						/// </summary>
						public Union<sap.ui.table.RowSettings, string, sap.ui.@base.ManagedObject.BindAggregationInfo> rowSettingsTemplate;

						/// <summary>
						/// Defines the context menu for the table.
						/// 
						/// <b>Note:</b> The context menu will also be available for the row selectors as well as in the row actions cell of the table control.
						/// 
						/// The custom context menu will not be shown in the group header rows and the sum row of the <code>AnalyticalTable</code> control.
						/// 
						/// If this aggregation is set, then the <code>enableCellFilter</code> property will have no effect.
						/// </summary>
						public Union<sap.ui.core.IContextMenu, string, sap.ui.@base.ManagedObject.BindAggregationInfo> contextMenu;

						/// <summary>
						/// The column by which the table is grouped. Grouping will only be performed if <code>enableGrouping</code> is set to <code>true</code>.
						/// </summary>
						public Union<sap.ui.table.Column, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> groupBy;

						/// <summary>
						/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// fired when the row selection of the table has been changed (the event parameters can be used to determine selection changes - to find out the selected rows you should better use the table selection API)
						/// </summary>
						public sap.ui.table.Table.RowSelectionChangeDelegate rowSelectionChange;

						/// <summary>
						/// fired when a column of the table has been selected
						/// </summary>
						public sap.ui.table.Table.ColumnDelegate columnSelect;

						/// <summary>
						/// fired when a table column is resized.
						/// </summary>
						public sap.ui.table.Table.ColumnResizeDelegate columnResize;

						/// <summary>
						/// fired when a table column is moved.
						/// </summary>
						public sap.ui.table.Table.ColumnMoveDelegate columnMove;

						/// <summary>
						/// fired when the table is sorted.
						/// </summary>
						public sap.ui.table.Table.SortDelegate sort;

						/// <summary>
						/// fired when the table is filtered.
						/// </summary>
						public sap.ui.table.Table.FilterDelegate filter;

						/// <summary>
						/// fired when the table is grouped (experimental!).
						/// </summary>
						public sap.ui.table.Table.ColumnDelegate group;

						/// <summary>
						/// fired when the visibility of a table column is changed.
						/// </summary>
						public sap.ui.table.Table.ColumnVisibilityDelegate columnVisibility;

						/// <summary>
						/// fired when the user clicks a cell of the table (experimental!).
						/// </summary>
						public sap.ui.table.Table.CellDelegate cellClick;

						/// <summary>
						/// fired when the user clicks a cell of the table.
						/// </summary>
						public sap.ui.table.Table.CellDelegate cellContextmenu;

						/// <summary>
						/// Fired when the user requests the context menu for a table cell.
						/// </summary>
						public sap.ui.table.Table.BeforeOpenContextMenuDelegate beforeOpenContextMenu;

						/// <summary>
						/// fired when a column of the table should be freezed
						/// </summary>
						public sap.ui.table.Table.ColumnDelegate columnFreeze;

						/// <summary>
						/// This event is triggered when the custom filter item of the column menu is pressed. The column on which the event was triggered is passed as parameter.
						/// </summary>
						public sap.ui.@base.EventDelegate customFilter;

						/// <summary>
						/// This event gets fired when the first visible row is changed. It should only be used by composite controls. The event even is fired when setFirstVisibleRow is called programmatically.
						/// </summary>
						public sap.ui.@base.EventDelegate firstVisibleRowChanged;

						/// <summary>
						/// This event gets fired when the busy state of the table changes. It should only be used by composite controls.
						/// </summary>
						public sap.ui.@base.EventDelegate busyStateChanged;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class BeforeOpenContextMenuInfo
					{
						/// <summary>
						/// Row index where the context menu opens.
						/// </summary>
						public int rowIndex;

						/// <summary>
						/// Column index where the context menu opens. This is the index of the column in the <code>columns</code> aggregation.
						/// </summary>
						public int columnIndex;

						/// <summary>
						/// Context menu
						/// </summary>
						public sap.ui.core.IContextMenu contextMenu;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class CellInfo
					{
						/// <summary>
						/// The control of the cell.
						/// </summary>
						public sap.ui.core.Control cellControl;

						/// <summary>
						/// DOM reference of the clicked cell. Can be used to position the context menu.
						/// </summary>
						public object cellDomRef;

						/// <summary>
						/// Row index of the selected cell.
						/// </summary>
						public int rowIndex;

						/// <summary>
						/// Column index of the selected cell. This is the index of visible columns and might differ from the index maintained in the column aggregation.
						/// </summary>
						public int columnIndex;

						/// <summary>
						/// Column ID of the selected cell.
						/// </summary>
						public string columnId;

						/// <summary>
						/// Row binding context of the selected cell.
						/// </summary>
						public sap.ui.model.Context rowBindingContext;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ColumnInfo
					{
						/// <summary>
						/// reference to the column to freeze
						/// </summary>
						public sap.ui.table.Column column;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ColumnMoveInfo
					{
						/// <summary>
						/// moved column.
						/// </summary>
						public sap.ui.table.Column column;

						/// <summary>
						/// new position of the column.
						/// </summary>
						public int newPos;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ColumnResizeInfo
					{
						/// <summary>
						/// resized column.
						/// </summary>
						public sap.ui.table.Column column;

						/// <summary>
						/// new width of the table column as CSS Size definition.
						/// </summary>
						public sap.ui.core.CSSSize width;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ColumnVisibilityInfo
					{
						/// <summary>
						/// affected column.
						/// </summary>
						public sap.ui.table.Column column;

						/// <summary>
						/// new value of the visible property.
						/// </summary>
						public bool visible;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class FilterInfo
					{
						/// <summary>
						/// filtered column.
						/// </summary>
						public sap.ui.table.Column column;

						/// <summary>
						/// filter value.
						/// </summary>
						public string value;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class RowSelectionChangeInfo
					{
						/// <summary>
						/// row index which has been clicked so that the selection has been changed (either selected or deselected)
						/// </summary>
						public int rowIndex;

						/// <summary>
						/// binding context of the row which has been clicked so that selection has been changed
						/// </summary>
						public object rowContext;

						/// <summary>
						/// array of row indices which selection has been changed (either selected or deselected)
						/// </summary>
						public int[] rowIndices;

						/// <summary>
						/// indicator if "select all" function is used to select rows
						/// </summary>
						public bool selectAll;

						/// <summary>
						/// indicates that the event was fired due to an explicit user interaction like clicking the row header or using the keyboard (SPACE or ENTER) to select a row or a range of rows.
						/// </summary>
						public bool userInteraction;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SortInfo
					{
						/// <summary>
						/// sorted column.
						/// </summary>
						public sap.ui.table.Column column;

						/// <summary>
						/// Sort Order
						/// </summary>
						public sap.ui.table.SortOrder sortOrder;

						/// <summary>
						/// If column was added to sorter this is true. If new sort is started this is set to false
						/// </summary>
						public bool columnAdded;

					}

					#endregion

					#region Delegates

					public delegate void BeforeOpenContextMenuDelegate(sap.ui.@base.Event<sap.ui.table.Table.BeforeOpenContextMenuInfo> oEvent, object oData);

					public delegate void CellDelegate(sap.ui.@base.Event<sap.ui.table.Table.CellInfo> oEvent, object oData);

					public delegate void ColumnDelegate(sap.ui.@base.Event<sap.ui.table.Table.ColumnInfo> oEvent, object oData);

					public delegate void ColumnMoveDelegate(sap.ui.@base.Event<sap.ui.table.Table.ColumnMoveInfo> oEvent, object oData);

					public delegate void ColumnResizeDelegate(sap.ui.@base.Event<sap.ui.table.Table.ColumnResizeInfo> oEvent, object oData);

					public delegate void ColumnVisibilityDelegate(sap.ui.@base.Event<sap.ui.table.Table.ColumnVisibilityInfo> oEvent, object oData);

					public delegate void FilterDelegate(sap.ui.@base.Event<sap.ui.table.Table.FilterInfo> oEvent, object oData);

					public delegate void RowSelectionChangeDelegate(sap.ui.@base.Event<sap.ui.table.Table.RowSelectionChangeInfo> oEvent, object oData);

					public delegate void SortDelegate(sap.ui.@base.Event<sap.ui.table.Table.SortInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Table.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Table(string sId, sap.ui.table.Table.Settings mSettings);

					/// <summary>
					/// Constructor for a new Table.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Table(string sId);

					/// <summary>
					/// Constructor for a new Table.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Table();

					/// <summary>
					/// Constructor for a new Table.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Table(sap.ui.table.Table.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Width of the Table.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Width of the Table.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property rowHeight

					/// <summary>
					/// Gets current value of property {@link #getRowHeight rowHeight}.
					/// 
					/// The height of the row content in pixel. The actual row height is also influenced by other factors, such as the border width. If no value is set, a default height is applied based on the content density configuration.
					/// </summary>
					/// <returns>Value of property <code>rowHeight</code></returns>
					public extern virtual int getRowHeight();

					/// <summary>
					/// Sets a new value for property {@link #getRowHeight rowHeight}.
					/// 
					/// The height of the row content in pixel. The actual row height is also influenced by other factors, such as the border width. If no value is set, a default height is applied based on the content density configuration.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iRowHeight">New value for property <code>rowHeight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setRowHeight(int iRowHeight);

					#endregion

					#region Methods for Property columnHeaderHeight

					/// <summary>
					/// Gets current value of property {@link #getColumnHeaderHeight columnHeaderHeight}.
					/// 
					/// Height of the column header of the Table in pixel.
					/// </summary>
					/// <returns>Value of property <code>columnHeaderHeight</code></returns>
					public extern virtual int getColumnHeaderHeight();

					/// <summary>
					/// Sets a new value for property {@link #getColumnHeaderHeight columnHeaderHeight}.
					/// 
					/// Height of the column header of the Table in pixel.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iColumnHeaderHeight">New value for property <code>columnHeaderHeight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setColumnHeaderHeight(int iColumnHeaderHeight);

					#endregion

					#region Methods for Property columnHeaderVisible

					/// <summary>
					/// Gets current value of property {@link #getColumnHeaderVisible columnHeaderVisible}.
					/// 
					/// Flag whether the column header is visible or not.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>columnHeaderVisible</code></returns>
					public extern virtual bool getColumnHeaderVisible();

					/// <summary>
					/// Sets a new value for property {@link #getColumnHeaderVisible columnHeaderVisible}.
					/// 
					/// Flag whether the column header is visible or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bColumnHeaderVisible">New value for property <code>columnHeaderVisible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setColumnHeaderVisible(bool bColumnHeaderVisible);

					#endregion

					#region Methods for Property visibleRowCount

					/// <summary>
					/// Gets current value of property {@link #getVisibleRowCount visibleRowCount}.
					/// 
					/// Number of visible rows of the table.
					/// 
					/// Default value is <code>10</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleRowCount</code></returns>
					public extern virtual int getVisibleRowCount();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleRowCount visibleRowCount}.
					/// 
					/// Number of visible rows of the table.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>10</code>.
					/// </summary>
					/// <param name="iVisibleRowCount">New value for property <code>visibleRowCount</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setVisibleRowCount(int iVisibleRowCount);

					#endregion

					#region Methods for Property firstVisibleRow

					/// <summary>
					/// Gets current value of property {@link #getFirstVisibleRow firstVisibleRow}.
					/// 
					/// First visible row.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>firstVisibleRow</code></returns>
					public extern virtual int getFirstVisibleRow();

					/// <summary>
					/// Sets a new value for property {@link #getFirstVisibleRow firstVisibleRow}.
					/// 
					/// First visible row.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iFirstVisibleRow">New value for property <code>firstVisibleRow</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setFirstVisibleRow(int iFirstVisibleRow);

					#endregion

					#region Methods for Property selectionMode

					/// <summary>
					/// Gets current value of property {@link #getSelectionMode selectionMode}.
					/// 
					/// Selection mode of the Table. This property controls whether single or multiple rows can be selected and how the selection can be extended. It may also influence the visual appearance. When the selection mode is changed, the current selection is removed. <b>Note:</b> Since the group header visualization relies on the row selectors, the row selectors are always shown if the grouping functionality (depends on table type) is enabled, even if <code>sap.ui.table.SelectionMode.None</code> is set.
					/// 
					/// Default value is <code>MultiToggle</code>.
					/// </summary>
					/// <returns>Value of property <code>selectionMode</code></returns>
					public extern virtual sap.ui.table.SelectionMode getSelectionMode();

					/// <summary>
					/// Sets the selection mode. The current selection is lost.
					/// </summary>
					/// <param name="sSelectionMode">the selection mode, see sap.ui.table.SelectionMode</param>
					/// <returns>a reference on the table for chaining</returns>
					public extern virtual void setSelectionMode(sap.ui.table.SelectionMode sSelectionMode);

					#endregion

					#region Methods for Property selectionBehavior

					/// <summary>
					/// Gets current value of property {@link #getSelectionBehavior selectionBehavior}.
					/// 
					/// Selection behavior of the Table. This property defines whether the row selector is displayed and whether the row, the row selector or both can be clicked to select a row. <b>Note:</b> Since the group header visualization relies on the row selectors, the row selectors are always shown if the grouping functionality (depends on table type) is enabled, even if <code>sap.ui.table.SelectionBehavior.RowOnly</code> is set.
					/// 
					/// Default value is <code>RowSelector</code>.
					/// </summary>
					/// <returns>Value of property <code>selectionBehavior</code></returns>
					public extern virtual sap.ui.table.SelectionBehavior getSelectionBehavior();

					/// <summary>
					/// Sets a new value for property {@link #getSelectionBehavior selectionBehavior}.
					/// 
					/// Selection behavior of the Table. This property defines whether the row selector is displayed and whether the row, the row selector or both can be clicked to select a row. <b>Note:</b> Since the group header visualization relies on the row selectors, the row selectors are always shown if the grouping functionality (depends on table type) is enabled, even if <code>sap.ui.table.SelectionBehavior.RowOnly</code> is set.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>RowSelector</code>.
					/// </summary>
					/// <param name="sSelectionBehavior">New value for property <code>selectionBehavior</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setSelectionBehavior(sap.ui.table.SelectionBehavior sSelectionBehavior);

					#endregion

					#region Methods for Property selectedIndex

					/// <summary>
					/// Gets current value of property {@link #getSelectedIndex selectedIndex}.
					/// 
					/// Zero-based index of selected item. Index value for no selection is -1. When multi-selection is enabled and multiple items are selected, the method returns the lead selected item. Sets the zero-based index of the currently selected item. This method removes any previous selections. When the given index is invalid, the call is ignored.
					/// 
					/// Default value is <code>-1</code>.
					/// </summary>
					/// <returns>Value of property <code>selectedIndex</code></returns>
					public extern virtual int getSelectedIndex();

					/// <summary>
					/// Sets a new value for property {@link #getSelectedIndex selectedIndex}.
					/// 
					/// Zero-based index of selected item. Index value for no selection is -1. When multi-selection is enabled and multiple items are selected, the method returns the lead selected item. Sets the zero-based index of the currently selected item. This method removes any previous selections. When the given index is invalid, the call is ignored.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>-1</code>.
					/// </summary>
					/// <param name="iSelectedIndex">New value for property <code>selectedIndex</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setSelectedIndex(int iSelectedIndex);

					#endregion

					#region Methods for Property editable

					/// <summary>
					/// Gets current value of property {@link #getEditable editable}.
					/// 
					/// Flag whether the controls of the Table are editable or not (currently this only controls the background color in certain themes!)
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>editable</code></returns>
					public extern virtual bool getEditable();

					/// <summary>
					/// Sets a new value for property {@link #getEditable editable}.
					/// 
					/// Flag whether the controls of the Table are editable or not (currently this only controls the background color in certain themes!)
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEditable">New value for property <code>editable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setEditable(bool bEditable);

					#endregion

					#region Methods for Property navigationMode

					/// <summary>
					/// Gets current value of property {@link #getNavigationMode navigationMode}.
					/// 
					/// This property has been deprecated and must not be used anymore, since <code>Scrollbar</code> is the only supported option.
					/// 
					/// Default value is <code>Scrollbar</code>.
					/// </summary>
					/// <returns>Value of property <code>navigationMode</code></returns>
					[Obsolete("Deprecated since 1.38.")]
					public extern virtual sap.ui.table.NavigationMode getNavigationMode();

					/// <summary>
					/// Sets a new value for property {@link #getNavigationMode navigationMode}.
					/// 
					/// This property has been deprecated and must not be used anymore, since <code>Scrollbar</code> is the only supported option.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Scrollbar</code>.
					/// </summary>
					/// <param name="sNavigationMode">New value for property <code>navigationMode</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.38.")]
					public extern virtual sap.ui.table.Table setNavigationMode(sap.ui.table.NavigationMode sNavigationMode);

					#endregion

					#region Methods for Property threshold

					/// <summary>
					/// Gets current value of property {@link #getThreshold threshold}.
					/// 
					/// The <code>threshold</code> defines how many additional (not yet visible records) shall be pre-fetched to enable smooth scrolling. The threshold is always added to the <code>visibleRowCount</code>. If the <code>visibleRowCount</code> is 10 and the <code>threshold</code> is 100, there will be 110 records fetched with the initial load. If the <code>threshold</code> is lower than the <code>visibleRowCount</code>, the <code>visibleRowCount</code> will be used as the <code>threshold</code>. If the value is 0 then the thresholding is disabled.
					/// 
					/// Default value is <code>100</code>.
					/// </summary>
					/// <returns>Value of property <code>threshold</code></returns>
					public extern virtual int getThreshold();

					/// <summary>
					/// Sets the threshold value, which will be added to all data requests in case the Table is bound against an OData service.
					/// </summary>
					public extern virtual void setThreshold();

					#endregion

					#region Methods for Property enableColumnReordering

					/// <summary>
					/// Gets current value of property {@link #getEnableColumnReordering enableColumnReordering}.
					/// 
					/// Flag to enable or disable column reordering
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableColumnReordering</code></returns>
					public extern virtual bool getEnableColumnReordering();

					/// <summary>
					/// Sets a new value for property {@link #getEnableColumnReordering enableColumnReordering}.
					/// 
					/// Flag to enable or disable column reordering
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableColumnReordering">New value for property <code>enableColumnReordering</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setEnableColumnReordering(bool bEnableColumnReordering);

					#endregion

					#region Methods for Property enableGrouping

					/// <summary>
					/// Gets current value of property {@link #getEnableGrouping enableGrouping}.
					/// 
					/// Enables or disables grouping. If grouping is enabled, the table is grouped by the column which is defined in the <code>groupBy</code> association.
					/// 
					/// The following restrictions apply: <ul> <li>Only client models are supported (e.g. {@link sap.ui.model.json.JSONModel}). Grouping does not work with OData models.</li> <li>The table can only be grouped by <b>one</b> column at a time. Grouping by another column will remove the current grouping.</li> <li>If grouping has been done, sorting and filtering is not possible. Any existing sorting and filtering rules do no longer apply. The UI is not updated accordingly (e.g. menu items, sort and filter icons).</li> <li>The column, by which the table is grouped, is not visible. It will become visible again only if the table is grouped by another column or grouping is disabled.</li> </ul>
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>enableGrouping</code></returns>
					public extern virtual bool getEnableGrouping();

					/// <summary>
					/// Sets a new value for property {@link #getEnableGrouping enableGrouping}.
					/// 
					/// Enables or disables grouping. If grouping is enabled, the table is grouped by the column which is defined in the <code>groupBy</code> association.
					/// 
					/// The following restrictions apply: <ul> <li>Only client models are supported (e.g. {@link sap.ui.model.json.JSONModel}). Grouping does not work with OData models.</li> <li>The table can only be grouped by <b>one</b> column at a time. Grouping by another column will remove the current grouping.</li> <li>If grouping has been done, sorting and filtering is not possible. Any existing sorting and filtering rules do no longer apply. The UI is not updated accordingly (e.g. menu items, sort and filter icons).</li> <li>The column, by which the table is grouped, is not visible. It will become visible again only if the table is grouped by another column or grouping is disabled.</li> </ul>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bEnableGrouping">New value for property <code>enableGrouping</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setEnableGrouping(bool bEnableGrouping);

					#endregion

					#region Methods for Property showColumnVisibilityMenu

					/// <summary>
					/// Gets current value of property {@link #getShowColumnVisibilityMenu showColumnVisibilityMenu}.
					/// 
					/// Flag to show or hide the column visibility menu. This menu will get displayed in each generated column header menu. It allows to show or hide columns
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>showColumnVisibilityMenu</code></returns>
					public extern virtual bool getShowColumnVisibilityMenu();

					/// <summary>
					/// Sets a new value for property {@link #getShowColumnVisibilityMenu showColumnVisibilityMenu}.
					/// 
					/// Flag to show or hide the column visibility menu. This menu will get displayed in each generated column header menu. It allows to show or hide columns
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShowColumnVisibilityMenu">New value for property <code>showColumnVisibilityMenu</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setShowColumnVisibilityMenu(bool bShowColumnVisibilityMenu);

					#endregion

					#region Methods for Property showNoData

					/// <summary>
					/// Gets current value of property {@link #getShowNoData showNoData}.
					/// 
					/// Flag whether to show the no data overlay or not once the table is empty. If set to false the table will just show a grid of empty cells
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showNoData</code></returns>
					public extern virtual bool getShowNoData();

					/// <summary>
					/// Sets a new value for property {@link #getShowNoData showNoData}.
					/// 
					/// Flag whether to show the no data overlay or not once the table is empty. If set to false the table will just show a grid of empty cells
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowNoData">New value for property <code>showNoData</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setShowNoData(bool bShowNoData);

					#endregion

					#region Methods for Property visibleRowCountMode

					/// <summary>
					/// Gets current value of property {@link #getVisibleRowCountMode visibleRowCountMode}.
					/// 
					/// This defines how the table handles the visible rows in the table. The default behavior is, that a fixed row count is defined. If you change it to auto the visibleRowCount property is changed by the table automatically. It will then adjust its maximum row count to the space it is allowed to cover (limited by the surrounding container) and its minimum row count to the value of the property minAutoRowCount (default value : 5) In manual mode the user can change the visibleRowCount interactively.
					/// 
					/// Default value is <code>Fixed</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleRowCountMode</code></returns>
					public extern virtual sap.ui.table.VisibleRowCountMode getVisibleRowCountMode();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleRowCountMode visibleRowCountMode}.
					/// 
					/// This defines how the table handles the visible rows in the table. The default behavior is, that a fixed row count is defined. If you change it to auto the visibleRowCount property is changed by the table automatically. It will then adjust its maximum row count to the space it is allowed to cover (limited by the surrounding container) and its minimum row count to the value of the property minAutoRowCount (default value : 5) In manual mode the user can change the visibleRowCount interactively.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Fixed</code>.
					/// </summary>
					/// <param name="sVisibleRowCountMode">New value for property <code>visibleRowCountMode</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setVisibleRowCountMode(sap.ui.table.VisibleRowCountMode sVisibleRowCountMode);

					#endregion

					#region Methods for Property minAutoRowCount

					/// <summary>
					/// Gets current value of property {@link #getMinAutoRowCount minAutoRowCount}.
					/// 
					/// This property is used to set the minimum count of visible rows when the property visibleRowCountMode is set to Auto or Interactive. For any other visibleRowCountMode, it is ignored.
					/// 
					/// Default value is <code>5</code>.
					/// </summary>
					/// <returns>Value of property <code>minAutoRowCount</code></returns>
					public extern virtual int getMinAutoRowCount();

					/// <summary>
					/// Sets a new value for property {@link #getMinAutoRowCount minAutoRowCount}.
					/// 
					/// This property is used to set the minimum count of visible rows when the property visibleRowCountMode is set to Auto or Interactive. For any other visibleRowCountMode, it is ignored.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>5</code>.
					/// </summary>
					/// <param name="iMinAutoRowCount">New value for property <code>minAutoRowCount</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setMinAutoRowCount(int iMinAutoRowCount);

					#endregion

					#region Methods for Property fixedColumnCount

					/// <summary>
					/// Gets current value of property {@link #getFixedColumnCount fixedColumnCount}.
					/// 
					/// Number of columns that are fixed on the left. Only columns which are not fixed can be scrolled horizontally.
					/// 
					/// <b>Note</b> <ul> <li>Fixed columns need a defined width for the feature to work.</li> <li>The aggregated width of all fixed columns must not exceed the table width. Otherwise the table ignores the value of the property and adapts the behavior in an appropriate way to ensure that the user is still able to scroll horizontally.</li> </ul>
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>fixedColumnCount</code></returns>
					public extern virtual int getFixedColumnCount();

					/// <summary>
					/// Sets a new value for property {@link #getFixedColumnCount fixedColumnCount}.
					/// 
					/// Number of columns that are fixed on the left. Only columns which are not fixed can be scrolled horizontally.
					/// 
					/// <b>Note</b> <ul> <li>Fixed columns need a defined width for the feature to work.</li> <li>The aggregated width of all fixed columns must not exceed the table width. Otherwise the table ignores the value of the property and adapts the behavior in an appropriate way to ensure that the user is still able to scroll horizontally.</li> </ul>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iFixedColumnCount">New value for property <code>fixedColumnCount</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setFixedColumnCount(int iFixedColumnCount);

					#endregion

					#region Methods for Property fixedRowCount

					/// <summary>
					/// Gets current value of property {@link #getFixedRowCount fixedRowCount}.
					/// 
					/// Number of rows that are fix on the top. When you use a vertical scrollbar, only the rows which are not fixed, will scroll.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>fixedRowCount</code></returns>
					public extern virtual int getFixedRowCount();

					/// <summary>
					/// Sets a new value for property {@link #getFixedRowCount fixedRowCount}.
					/// 
					/// Number of rows that are fix on the top. When you use a vertical scrollbar, only the rows which are not fixed, will scroll.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iFixedRowCount">New value for property <code>fixedRowCount</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setFixedRowCount(int iFixedRowCount);

					#endregion

					#region Methods for Property fixedBottomRowCount

					/// <summary>
					/// Gets current value of property {@link #getFixedBottomRowCount fixedBottomRowCount}.
					/// 
					/// Number of rows that are fix on the bottom. When you use a vertical scrollbar, only the rows which are not fixed, will scroll.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>fixedBottomRowCount</code></returns>
					public extern virtual int getFixedBottomRowCount();

					/// <summary>
					/// Sets a new value for property {@link #getFixedBottomRowCount fixedBottomRowCount}.
					/// 
					/// Number of rows that are fix on the bottom. When you use a vertical scrollbar, only the rows which are not fixed, will scroll.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iFixedBottomRowCount">New value for property <code>fixedBottomRowCount</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setFixedBottomRowCount(int iFixedBottomRowCount);

					#endregion

					#region Methods for Property enableColumnFreeze

					/// <summary>
					/// Gets current value of property {@link #getEnableColumnFreeze enableColumnFreeze}.
					/// 
					/// Flag whether to show or hide the column menu item to freeze or unfreeze a column.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>enableColumnFreeze</code></returns>
					public extern virtual bool getEnableColumnFreeze();

					/// <summary>
					/// Sets a new value for property {@link #getEnableColumnFreeze enableColumnFreeze}.
					/// 
					/// Flag whether to show or hide the column menu item to freeze or unfreeze a column.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bEnableColumnFreeze">New value for property <code>enableColumnFreeze</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setEnableColumnFreeze(bool bEnableColumnFreeze);

					#endregion

					#region Methods for Property enableCellFilter

					/// <summary>
					/// Gets current value of property {@link #getEnableCellFilter enableCellFilter}.
					/// 
					/// Flag whether to enable or disable the context menu on cells to trigger a filtering with the cell value.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>enableCellFilter</code></returns>
					public extern virtual bool getEnableCellFilter();

					/// <summary>
					/// Sets a new value for property {@link #getEnableCellFilter enableCellFilter}.
					/// 
					/// Flag whether to enable or disable the context menu on cells to trigger a filtering with the cell value.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bEnableCellFilter">New value for property <code>enableCellFilter</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setEnableCellFilter(bool bEnableCellFilter);

					#endregion

					#region Methods for Property showOverlay

					/// <summary>
					/// Gets current value of property {@link #getShowOverlay showOverlay}.
					/// 
					/// Setting this property to true will show an overlay on top of the Table content and users cannot click anymore on the Table content.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>showOverlay</code></returns>
					public extern virtual bool getShowOverlay();

					/// <summary>
					/// Sets a new value for property {@link #getShowOverlay showOverlay}.
					/// 
					/// Setting this property to true will show an overlay on top of the Table content and users cannot click anymore on the Table content.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShowOverlay">New value for property <code>showOverlay</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setShowOverlay(bool bShowOverlay);

					#endregion

					#region Methods for Property enableSelectAll

					/// <summary>
					/// Gets current value of property {@link #getEnableSelectAll enableSelectAll}.
					/// 
					/// Specifies if a select all button should be displayed in the top left corner. This button is only displayed if the row selector is visible and the selection mode is set to any kind of multi selection.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableSelectAll</code></returns>
					public extern virtual bool getEnableSelectAll();

					/// <summary>
					/// Sets a new value for property {@link #getEnableSelectAll enableSelectAll}.
					/// 
					/// Specifies if a select all button should be displayed in the top left corner. This button is only displayed if the row selector is visible and the selection mode is set to any kind of multi selection.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableSelectAll">New value for property <code>enableSelectAll</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setEnableSelectAll(bool bEnableSelectAll);

					#endregion

					#region Methods for Property enableCustomFilter

					/// <summary>
					/// Gets current value of property {@link #getEnableCustomFilter enableCustomFilter}.
					/// 
					/// Set this parameter to true to implement your own filter behaviour. Instead of the filter input box a button will be rendered for which' press event (customFilter) you can register an event handler.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>enableCustomFilter</code></returns>
					public extern virtual bool getEnableCustomFilter();

					/// <summary>
					/// Sets a new value for property {@link #getEnableCustomFilter enableCustomFilter}.
					/// 
					/// Set this parameter to true to implement your own filter behaviour. Instead of the filter input box a button will be rendered for which' press event (customFilter) you can register an event handler.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bEnableCustomFilter">New value for property <code>enableCustomFilter</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setEnableCustomFilter(bool bEnableCustomFilter);

					#endregion

					#region Methods for Property enableBusyIndicator

					/// <summary>
					/// Gets current value of property {@link #getEnableBusyIndicator enableBusyIndicator}.
					/// 
					/// If set to <code>true</code>, the table changes its busy state, resulting in showing or hiding the busy indicator. The table will switch to busy as soon as data is retrieved to be displayed in the currently visible rows. This happens, for example, during scrolling, filtering, or sorting. As soon as the data has been retrieved, the table switches back to not busy. The busy state of the table can still be set manually by calling {@link sap.ui.core.Control#setBusy}.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>enableBusyIndicator</code></returns>
					public extern virtual bool getEnableBusyIndicator();

					/// <summary>
					/// Sets a new value for property {@link #getEnableBusyIndicator enableBusyIndicator}.
					/// 
					/// If set to <code>true</code>, the table changes its busy state, resulting in showing or hiding the busy indicator. The table will switch to busy as soon as data is retrieved to be displayed in the currently visible rows. This happens, for example, during scrolling, filtering, or sorting. As soon as the data has been retrieved, the table switches back to not busy. The busy state of the table can still be set manually by calling {@link sap.ui.core.Control#setBusy}.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bEnableBusyIndicator">New value for property <code>enableBusyIndicator</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setEnableBusyIndicator(bool bEnableBusyIndicator);

					#endregion

					#region Methods for Property rowActionCount

					/// <summary>
					/// Gets current value of property {@link #getRowActionCount rowActionCount}.
					/// 
					/// Number of row actions made visible which determines the width of the row action column. The values <code>0</code>, <code>1</code> and <code>2</code> are possible.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>rowActionCount</code></returns>
					public extern virtual int getRowActionCount();

					/// <summary>
					/// Sets a new value for property {@link #getRowActionCount rowActionCount}.
					/// 
					/// Number of row actions made visible which determines the width of the row action column. The values <code>0</code>, <code>1</code> and <code>2</code> are possible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iRowActionCount">New value for property <code>rowActionCount</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setRowActionCount(int iRowActionCount);

					#endregion

					#region Methods for Property alternateRowColors

					/// <summary>
					/// Gets current value of property {@link #getAlternateRowColors alternateRowColors}.
					/// 
					/// Enables alternating table row colors. Alternate row coloring is not available for the tree mode.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>alternateRowColors</code></returns>
					public extern virtual bool getAlternateRowColors();

					/// <summary>
					/// Sets a new value for property {@link #getAlternateRowColors alternateRowColors}.
					/// 
					/// Enables alternating table row colors. Alternate row coloring is not available for the tree mode.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bAlternateRowColors">New value for property <code>alternateRowColors</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setAlternateRowColors(bool bAlternateRowColors);

					#endregion

					#region Methods for Aggregation title

					/// <summary>
					/// Gets content of aggregation {@link #getTitle title}.
					/// 
					/// Control or text of title section of the Table (if not set it will be hidden)
					/// </summary>
					/// <returns></returns>
					public extern virtual Union<sap.ui.core.Control, string> getTitle();

					/// <summary>
					/// Destroys the title in the aggregation {@link #getTitle title}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table destroyTitle();

					/// <summary>
					/// Sets the aggregated {@link #getTitle title}.
					/// </summary>
					/// <param name="vTitle">The title to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setTitle(Union<sap.ui.core.Control, string> vTitle);

					#endregion

					#region Methods for Aggregation footer

					/// <summary>
					/// Gets content of aggregation {@link #getFooter footer}.
					/// 
					/// Control or text of footer section of the Table (if not set it will be hidden)
					/// </summary>
					/// <returns></returns>
					public extern virtual Union<sap.ui.core.Control, string> getFooter();

					/// <summary>
					/// Destroys the footer in the aggregation {@link #getFooter footer}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table destroyFooter();

					/// <summary>
					/// Sets the aggregated {@link #getFooter footer}.
					/// </summary>
					/// <param name="vFooter">The footer to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setFooter(Union<sap.ui.core.Control, string> vFooter);

					#endregion

					#region Methods for Aggregation toolbar

					/// <summary>
					/// Gets content of aggregation {@link #getToolbar toolbar}.
					/// 
					/// Toolbar of the Table If not set, no toolbar area will be rendered. Note: The CSS class sapMTBHeader-CTX is applied on the given toolbar.
					/// </summary>
					/// <returns></returns>
					[Obsolete("Deprecated since 1.38. This aggregation is deprecated, use the <code>extension</code> aggregation instead.")]
					public extern virtual sap.ui.core.Toolbar getToolbar();

					/// <summary>
					/// Destroys the toolbar in the aggregation {@link #getToolbar toolbar}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.38. This aggregation is deprecated, use the <code>extension</code> aggregation instead.")]
					public extern virtual sap.ui.table.Table destroyToolbar();

					/// <summary>
					/// Sets the aggregated {@link #getToolbar toolbar}.
					/// </summary>
					/// <param name="oToolbar">The toolbar to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.38. This aggregation is deprecated, use the <code>extension</code> aggregation instead.")]
					public extern virtual sap.ui.table.Table setToolbar(sap.ui.core.Toolbar oToolbar);

					#endregion

					#region Methods for Aggregation extension

					/// <summary>
					/// Gets content of aggregation {@link #getExtension extension}.
					/// 
					/// Extension section of the Table. If not set, no extension area will be rendered. Note: In case a <code>sap.m.Toolbar</code> is used as header the CSS class sapMTBHeader-CTX should be applied on this toolbar via <code>addStyleClass</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getExtension();

					/// <summary>
					/// Destroys all the extension in the aggregation {@link #getExtension extension}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table destroyExtension();

					/// <summary>
					/// Inserts a extension into the aggregation {@link #getExtension extension}.
					/// </summary>
					/// <param name="oExtension">The extension to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the extension should be inserted at; for a negative value of <code>iIndex</code>, the extension is inserted at position 0; for a value greater than the current size of the aggregation, the extension is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table insertExtension(sap.ui.core.Control oExtension, int iIndex);

					/// <summary>
					/// Adds some extension to the aggregation {@link #getExtension extension}.
					/// </summary>
					/// <param name="oExtension">The extension to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table addExtension(sap.ui.core.Control oExtension);

					/// <summary>
					/// Removes a extension from the aggregation {@link #getExtension extension}.
					/// </summary>
					/// <param name="vExtension">The extension to remove or its index or id</param>
					/// <returns>The removed extension or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeExtension(Union<int, string, sap.ui.core.Control> vExtension);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getExtension extension}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oExtension">The extension whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfExtension(sap.ui.core.Control oExtension);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getExtension extension}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllExtension();

					#endregion

					#region Methods for Aggregation columns

					/// <summary>
					/// Gets content of aggregation {@link #getColumns columns}.
					/// 
					/// Columns of the Table
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.table.Column[] getColumns();

					/// <summary>
					/// Destroys all the columns in the aggregation {@link #getColumns columns}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table destroyColumns();

					/// <summary>
					/// Inserts a column into the aggregation {@link #getColumns columns}.
					/// </summary>
					/// <param name="oColumn">The column to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the column should be inserted at; for a negative value of <code>iIndex</code>, the column is inserted at position 0; for a value greater than the current size of the aggregation, the column is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table insertColumn(sap.ui.table.Column oColumn, int iIndex);

					/// <summary>
					/// Adds some column to the aggregation {@link #getColumns columns}.
					/// </summary>
					/// <param name="oColumn">The column to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table addColumn(sap.ui.table.Column oColumn);

					/// <summary>
					/// Removes a column from the aggregation {@link #getColumns columns}.
					/// </summary>
					/// <param name="vColumn">The column to remove or its index or id</param>
					/// <returns>The removed column or <code>null</code></returns>
					public extern virtual sap.ui.table.Column removeColumn(Union<int, string, sap.ui.table.Column> vColumn);

					/// <summary>
					/// Checks for the provided <code>sap.ui.table.Column</code> in the aggregation {@link #getColumns columns}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oColumn">The column whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfColumn(sap.ui.table.Column oColumn);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getColumns columns}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.table.Column[] removeAllColumns();

					/// <summary>
					/// Binds aggregation {@link #getColumns columns} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table bindColumns(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getColumns columns} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table unbindColumns();

					#endregion

					#region Methods for Aggregation rows

					/// <summary>
					/// Gets content of aggregation {@link #getRows rows}.
					/// 
					/// Rows of the Table
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.table.Row[] getRows();

					/// <summary>
					/// Destroys all the rows in the aggregation {@link #getRows rows}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table destroyRows();

					/// <summary>
					/// Inserts a row into the aggregation {@link #getRows rows}.
					/// </summary>
					/// <param name="oRow">The row to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the row should be inserted at; for a negative value of <code>iIndex</code>, the row is inserted at position 0; for a value greater than the current size of the aggregation, the row is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table insertRow(sap.ui.table.Row oRow, int iIndex);

					/// <summary>
					/// Adds some row to the aggregation {@link #getRows rows}.
					/// </summary>
					/// <param name="oRow">The row to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table addRow(sap.ui.table.Row oRow);

					/// <summary>
					/// Removes a row from the aggregation {@link #getRows rows}.
					/// </summary>
					/// <param name="vRow">The row to remove or its index or id</param>
					/// <returns>The removed row or <code>null</code></returns>
					public extern virtual sap.ui.table.Row removeRow(Union<int, string, sap.ui.table.Row> vRow);

					/// <summary>
					/// Checks for the provided <code>sap.ui.table.Row</code> in the aggregation {@link #getRows rows}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oRow">The row whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfRow(sap.ui.table.Row oRow);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getRows rows}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.table.Row[] removeAllRows();

					/// <summary>
					/// Binds aggregation {@link #getRows rows} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table bindRows(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getRows rows} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table unbindRows();

					#endregion

					#region Methods for Aggregation noData

					/// <summary>
					/// Gets content of aggregation {@link #getNoData noData}.
					/// 
					/// The value for the noData aggregation can be either a string value or a control instance. The control is shown, in case there is no data for the Table available. In case of a string value this will simply replace the no data text.
					/// </summary>
					/// <returns></returns>
					public extern virtual Union<sap.ui.core.Control, string> getNoData();

					/// <summary>
					/// Destroys the noData in the aggregation {@link #getNoData noData}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table destroyNoData();

					/// <summary>
					/// Sets the aggregated {@link #getNoData noData}.
					/// </summary>
					/// <param name="vNoData">The noData to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setNoData(Union<sap.ui.core.Control, string> vNoData);

					#endregion

					#region Methods for Aggregation rowActionTemplate

					/// <summary>
					/// Gets content of aggregation {@link #getRowActionTemplate rowActionTemplate}.
					/// 
					/// Template for row actions. A template is decoupled from the row or table. Each time the template's properties or aggregations are changed, the template has to be applied again via <code>setRowActionTemplate</code> for the changes to take effect.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.table.RowAction getRowActionTemplate();

					/// <summary>
					/// Destroys the rowActionTemplate in the aggregation {@link #getRowActionTemplate rowActionTemplate}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table destroyRowActionTemplate();

					/// <summary>
					/// Sets the aggregated {@link #getRowActionTemplate rowActionTemplate}.
					/// </summary>
					/// <param name="oRowActionTemplate">The rowActionTemplate to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setRowActionTemplate(sap.ui.table.RowAction oRowActionTemplate);

					#endregion

					#region Methods for Aggregation rowSettingsTemplate

					/// <summary>
					/// Gets content of aggregation {@link #getRowSettingsTemplate rowSettingsTemplate}.
					/// 
					/// Template for row settings. A template is decoupled from the row or table. Each time the template's properties or aggregations are changed, the template has to be applied again via <code>setRowSettingsTemplate</code> for the changes to take effect.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.table.RowSettings getRowSettingsTemplate();

					/// <summary>
					/// Destroys the rowSettingsTemplate in the aggregation {@link #getRowSettingsTemplate rowSettingsTemplate}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table destroyRowSettingsTemplate();

					/// <summary>
					/// Sets the aggregated {@link #getRowSettingsTemplate rowSettingsTemplate}.
					/// </summary>
					/// <param name="oRowSettingsTemplate">The rowSettingsTemplate to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setRowSettingsTemplate(sap.ui.table.RowSettings oRowSettingsTemplate);

					#endregion

					#region Methods for Aggregation contextMenu

					/// <summary>
					/// Gets content of aggregation {@link #getContextMenu contextMenu}.
					/// 
					/// Defines the context menu for the table.
					/// 
					/// <b>Note:</b> The context menu will also be available for the row selectors as well as in the row actions cell of the table control.
					/// 
					/// The custom context menu will not be shown in the group header rows and the sum row of the <code>AnalyticalTable</code> control.
					/// 
					/// If this aggregation is set, then the <code>enableCellFilter</code> property will have no effect.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.IContextMenu getContextMenu();

					/// <summary>
					/// Destroys the contextMenu in the aggregation {@link #getContextMenu contextMenu}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table destroyContextMenu();

					/// <summary>
					/// Sets the aggregated {@link #getContextMenu contextMenu}.
					/// </summary>
					/// <param name="oContextMenu">The contextMenu to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setContextMenu(sap.ui.core.IContextMenu oContextMenu);

					#endregion

					#region Methods for Association groupBy

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getGroupBy groupBy}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getGroupBy();

					/// <summary>
					/// Sets the associated {@link #getGroupBy groupBy}.
					/// </summary>
					/// <param name="oGroupBy">ID of an element which becomes the new target of this groupBy association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table setGroupBy(Union<sap.ui.core.ID, sap.ui.table.Column> oGroupBy);

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
					public extern virtual sap.ui.table.Table addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

					#region Methods for Event rowSelectionChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowSelectionChange rowSelectionChange} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the row selection of the table has been changed (the event parameters can be used to determine selection changes - to find out the selected rows you should better use the table selection API)
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachRowSelectionChange(object oData, sap.ui.table.Table.RowSelectionChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowSelectionChange rowSelectionChange} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the row selection of the table has been changed (the event parameters can be used to determine selection changes - to find out the selected rows you should better use the table selection API)
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachRowSelectionChange(object oData, sap.ui.table.Table.RowSelectionChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowSelectionChange rowSelectionChange} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the row selection of the table has been changed (the event parameters can be used to determine selection changes - to find out the selected rows you should better use the table selection API)
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachRowSelectionChange(sap.ui.table.Table.RowSelectionChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:rowSelectionChange rowSelectionChange} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the row selection of the table has been changed (the event parameters can be used to determine selection changes - to find out the selected rows you should better use the table selection API)
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachRowSelectionChange(sap.ui.table.Table.RowSelectionChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:rowSelectionChange rowSelectionChange} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachRowSelectionChange(sap.ui.table.Table.RowSelectionChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:rowSelectionChange rowSelectionChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table fireRowSelectionChange(sap.ui.table.Table.RowSelectionChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:rowSelectionChange rowSelectionChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table fireRowSelectionChange();

					#endregion

					#region Methods for Event columnSelect

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnSelect columnSelect} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a column of the table has been selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnSelect(object oData, sap.ui.table.Table.ColumnDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnSelect columnSelect} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a column of the table has been selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnSelect(object oData, sap.ui.table.Table.ColumnDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnSelect columnSelect} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a column of the table has been selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnSelect(sap.ui.table.Table.ColumnDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnSelect columnSelect} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a column of the table has been selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnSelect(sap.ui.table.Table.ColumnDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:columnSelect columnSelect} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachColumnSelect(sap.ui.table.Table.ColumnDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:columnSelect columnSelect} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnSelect(sap.ui.table.Table.ColumnInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:columnSelect columnSelect} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnSelect();

					#endregion

					#region Methods for Event columnResize

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnResize columnResize} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a table column is resized.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnResize(object oData, sap.ui.table.Table.ColumnResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnResize columnResize} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a table column is resized.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnResize(object oData, sap.ui.table.Table.ColumnResizeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnResize columnResize} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a table column is resized.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnResize(sap.ui.table.Table.ColumnResizeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnResize columnResize} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a table column is resized.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnResize(sap.ui.table.Table.ColumnResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:columnResize columnResize} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachColumnResize(sap.ui.table.Table.ColumnResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:columnResize columnResize} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnResize(sap.ui.table.Table.ColumnResizeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:columnResize columnResize} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnResize();

					#endregion

					#region Methods for Event columnMove

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnMove columnMove} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a table column is moved.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnMove(object oData, sap.ui.table.Table.ColumnMoveDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnMove columnMove} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a table column is moved.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnMove(object oData, sap.ui.table.Table.ColumnMoveDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnMove columnMove} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a table column is moved.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnMove(sap.ui.table.Table.ColumnMoveDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnMove columnMove} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a table column is moved.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnMove(sap.ui.table.Table.ColumnMoveDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:columnMove columnMove} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachColumnMove(sap.ui.table.Table.ColumnMoveDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:columnMove columnMove} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnMove(sap.ui.table.Table.ColumnMoveInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:columnMove columnMove} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnMove();

					#endregion

					#region Methods for Event sort

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sort sort} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is sorted.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachSort(object oData, sap.ui.table.Table.SortDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sort sort} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is sorted.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachSort(object oData, sap.ui.table.Table.SortDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sort sort} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is sorted.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachSort(sap.ui.table.Table.SortDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sort sort} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is sorted.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachSort(sap.ui.table.Table.SortDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:sort sort} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachSort(sap.ui.table.Table.SortDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:sort sort} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireSort(sap.ui.table.Table.SortInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:sort sort} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireSort();

					#endregion

					#region Methods for Event filter

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filter filter} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is filtered.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachFilter(object oData, sap.ui.table.Table.FilterDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filter filter} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is filtered.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachFilter(object oData, sap.ui.table.Table.FilterDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filter filter} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is filtered.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachFilter(sap.ui.table.Table.FilterDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filter filter} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is filtered.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachFilter(sap.ui.table.Table.FilterDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:filter filter} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachFilter(sap.ui.table.Table.FilterDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:filter filter} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireFilter(sap.ui.table.Table.FilterInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:filter filter} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireFilter();

					#endregion

					#region Methods for Event group

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:group group} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is grouped (experimental!).
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachGroup(object oData, sap.ui.table.Table.ColumnDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:group group} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is grouped (experimental!).
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachGroup(object oData, sap.ui.table.Table.ColumnDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:group group} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is grouped (experimental!).
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachGroup(sap.ui.table.Table.ColumnDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:group group} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the table is grouped (experimental!).
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachGroup(sap.ui.table.Table.ColumnDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:group group} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachGroup(sap.ui.table.Table.ColumnDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:group group} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireGroup(sap.ui.table.Table.ColumnInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:group group} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireGroup();

					#endregion

					#region Methods for Event columnVisibility

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnVisibility columnVisibility} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the visibility of a table column is changed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnVisibility(object oData, sap.ui.table.Table.ColumnVisibilityDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnVisibility columnVisibility} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the visibility of a table column is changed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnVisibility(object oData, sap.ui.table.Table.ColumnVisibilityDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnVisibility columnVisibility} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the visibility of a table column is changed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnVisibility(sap.ui.table.Table.ColumnVisibilityDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnVisibility columnVisibility} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the visibility of a table column is changed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnVisibility(sap.ui.table.Table.ColumnVisibilityDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:columnVisibility columnVisibility} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachColumnVisibility(sap.ui.table.Table.ColumnVisibilityDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:columnVisibility columnVisibility} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnVisibility(sap.ui.table.Table.ColumnVisibilityInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:columnVisibility columnVisibility} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnVisibility();

					#endregion

					#region Methods for Event cellClick

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cellClick cellClick} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the user clicks a cell of the table (experimental!).
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachCellClick(object oData, sap.ui.table.Table.CellDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cellClick cellClick} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the user clicks a cell of the table (experimental!).
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachCellClick(object oData, sap.ui.table.Table.CellDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cellClick cellClick} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the user clicks a cell of the table (experimental!).
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachCellClick(sap.ui.table.Table.CellDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cellClick cellClick} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the user clicks a cell of the table (experimental!).
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachCellClick(sap.ui.table.Table.CellDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:cellClick cellClick} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachCellClick(sap.ui.table.Table.CellDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:cellClick cellClick} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireCellClick(sap.ui.table.Table.CellInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:cellClick cellClick} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireCellClick();

					#endregion

					#region Methods for Event cellContextmenu

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cellContextmenu cellContextmenu} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the user clicks a cell of the table.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.54. replaced by <code>beforeOpenContextMenu</code>.")]
					public extern virtual sap.ui.table.Table attachCellContextmenu(object oData, sap.ui.table.Table.CellDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cellContextmenu cellContextmenu} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the user clicks a cell of the table.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.54. replaced by <code>beforeOpenContextMenu</code>.")]
					public extern virtual sap.ui.table.Table attachCellContextmenu(object oData, sap.ui.table.Table.CellDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cellContextmenu cellContextmenu} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the user clicks a cell of the table.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.54. replaced by <code>beforeOpenContextMenu</code>.")]
					public extern virtual sap.ui.table.Table attachCellContextmenu(sap.ui.table.Table.CellDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:cellContextmenu cellContextmenu} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when the user clicks a cell of the table.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.54. replaced by <code>beforeOpenContextMenu</code>.")]
					public extern virtual sap.ui.table.Table attachCellContextmenu(sap.ui.table.Table.CellDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:cellContextmenu cellContextmenu} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.54. replaced by <code>beforeOpenContextMenu</code>.")]
					public extern virtual sap.ui.table.Table detachCellContextmenu(sap.ui.table.Table.CellDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:cellContextmenu cellContextmenu} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					[Obsolete("Deprecated since 1.54. replaced by <code>beforeOpenContextMenu</code>.")]
					public extern virtual bool fireCellContextmenu(sap.ui.table.Table.CellInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:cellContextmenu cellContextmenu} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					[Obsolete("Deprecated since 1.54. replaced by <code>beforeOpenContextMenu</code>.")]
					public extern virtual bool fireCellContextmenu();

					#endregion

					#region Methods for Event beforeOpenContextMenu

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// Fired when the user requests the context menu for a table cell.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachBeforeOpenContextMenu(object oData, sap.ui.table.Table.BeforeOpenContextMenuDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// Fired when the user requests the context menu for a table cell.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachBeforeOpenContextMenu(object oData, sap.ui.table.Table.BeforeOpenContextMenuDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// Fired when the user requests the context menu for a table cell.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachBeforeOpenContextMenu(sap.ui.table.Table.BeforeOpenContextMenuDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// Fired when the user requests the context menu for a table cell.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachBeforeOpenContextMenu(sap.ui.table.Table.BeforeOpenContextMenuDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachBeforeOpenContextMenu(sap.ui.table.Table.BeforeOpenContextMenuDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:beforeOpenContextMenu beforeOpenContextMenu} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireBeforeOpenContextMenu(sap.ui.table.Table.BeforeOpenContextMenuInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:beforeOpenContextMenu beforeOpenContextMenu} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireBeforeOpenContextMenu();

					#endregion

					#region Methods for Event columnFreeze

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnFreeze columnFreeze} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a column of the table should be freezed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnFreeze(object oData, sap.ui.table.Table.ColumnDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnFreeze columnFreeze} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a column of the table should be freezed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnFreeze(object oData, sap.ui.table.Table.ColumnDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnFreeze columnFreeze} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a column of the table should be freezed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnFreeze(sap.ui.table.Table.ColumnDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:columnFreeze columnFreeze} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// fired when a column of the table should be freezed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachColumnFreeze(sap.ui.table.Table.ColumnDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:columnFreeze columnFreeze} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachColumnFreeze(sap.ui.table.Table.ColumnDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:columnFreeze columnFreeze} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnFreeze(sap.ui.table.Table.ColumnInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:columnFreeze columnFreeze} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireColumnFreeze();

					#endregion

					#region Methods for Event customFilter

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:customFilter customFilter} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event is triggered when the custom filter item of the column menu is pressed. The column on which the event was triggered is passed as parameter.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachCustomFilter(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:customFilter customFilter} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event is triggered when the custom filter item of the column menu is pressed. The column on which the event was triggered is passed as parameter.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachCustomFilter(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:customFilter customFilter} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event is triggered when the custom filter item of the column menu is pressed. The column on which the event was triggered is passed as parameter.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachCustomFilter(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:customFilter customFilter} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event is triggered when the custom filter item of the column menu is pressed. The column on which the event was triggered is passed as parameter.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachCustomFilter(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:customFilter customFilter} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachCustomFilter(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:customFilter customFilter} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table fireCustomFilter(object mParameters);

					/// <summary>
					/// Fires event {@link #event:customFilter customFilter} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table fireCustomFilter();

					#endregion

					#region Methods for Event firstVisibleRowChanged

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:firstVisibleRowChanged firstVisibleRowChanged} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event gets fired when the first visible row is changed. It should only be used by composite controls. The event even is fired when setFirstVisibleRow is called programmatically.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachFirstVisibleRowChanged(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:firstVisibleRowChanged firstVisibleRowChanged} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event gets fired when the first visible row is changed. It should only be used by composite controls. The event even is fired when setFirstVisibleRow is called programmatically.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachFirstVisibleRowChanged(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:firstVisibleRowChanged firstVisibleRowChanged} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event gets fired when the first visible row is changed. It should only be used by composite controls. The event even is fired when setFirstVisibleRow is called programmatically.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachFirstVisibleRowChanged(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:firstVisibleRowChanged firstVisibleRowChanged} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event gets fired when the first visible row is changed. It should only be used by composite controls. The event even is fired when setFirstVisibleRow is called programmatically.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachFirstVisibleRowChanged(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:firstVisibleRowChanged firstVisibleRowChanged} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachFirstVisibleRowChanged(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:firstVisibleRowChanged firstVisibleRowChanged} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table fireFirstVisibleRowChanged(object mParameters);

					/// <summary>
					/// Fires event {@link #event:firstVisibleRowChanged firstVisibleRowChanged} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table fireFirstVisibleRowChanged();

					#endregion

					#region Methods for Event busyStateChanged

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:busyStateChanged busyStateChanged} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event gets fired when the busy state of the table changes. It should only be used by composite controls.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachBusyStateChanged(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:busyStateChanged busyStateChanged} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event gets fired when the busy state of the table changes. It should only be used by composite controls.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachBusyStateChanged(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:busyStateChanged busyStateChanged} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event gets fired when the busy state of the table changes. It should only be used by composite controls.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachBusyStateChanged(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:busyStateChanged busyStateChanged} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.Table</code> itself.
					/// 
					/// This event gets fired when the busy state of the table changes. It should only be used by composite controls.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.Table</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table attachBusyStateChanged(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:busyStateChanged busyStateChanged} event of this <code>sap.ui.table.Table</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table detachBusyStateChanged(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:busyStateChanged busyStateChanged} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table fireBusyStateChanged(object mParameters);

					/// <summary>
					/// Fires event {@link #event:busyStateChanged busyStateChanged} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.Table fireBusyStateChanged();

					#endregion

					#region Other methods

					/// <summary>
					/// Adds the given selection interval to the selection. In case of single selection the "indexTo" value will be used for as selected index.
					/// </summary>
					/// <param name="iIndexFrom">Index from which .</param>
					/// <param name="iIndexTo">Indices of the items that shall additionally be selected.</param>
					/// <returns></returns>
					public extern virtual sap.ui.table.Table addSelectionInterval(int iIndexFrom, int iIndexTo);

					/// <summary>
					/// Triggers automatic resizing of a column to the widest content.
					/// </summary>
					/// <param name="iColIndex">The index of the column in the list of visible columns.</param>
					public extern virtual void autoResizeColumn(int iColIndex);

					/// <summary>
					/// Removes complete selection.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.table.Table clearSelection();

					/// <summary>
					/// Creates a new {@link sap.ui.core.util.Export} object and fills row/column information from the table if not provided. For the cell content, the column's "sortProperty" will be used (experimental!)
					/// 
					/// <p><b>Please note: This method uses synchronous requests. Support and functioning ends with the support for synchronous requests in browsers.</b></p>
					/// </summary>
					/// <param name="mSettings">settings for the new Export, see {@link sap.ui.core.util.Export} <code>constructor</code></param>
					/// <returns>Export object</returns>
					[Obsolete("Deprecated since 1.56. replaced by the <code>sap.ui.export</code> library.")]
					public extern virtual sap.ui.core.util.Export exportData(object mSettings);

					/// <summary>
					/// Creates a new {@link sap.ui.core.util.Export} object and fills row/column information from the table if not provided. For the cell content, the column's "sortProperty" will be used (experimental!)
					/// 
					/// <p><b>Please note: This method uses synchronous requests. Support and functioning ends with the support for synchronous requests in browsers.</b></p>
					/// </summary>
					/// <returns>Export object</returns>
					[Obsolete("Deprecated since 1.56. replaced by the <code>sap.ui.export</code> library.")]
					public extern virtual sap.ui.core.util.Export exportData();

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.Table with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.Table with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.Table with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Filter the given column by the given value.
					/// </summary>
					/// <param name="oColumn">column to be filtered</param>
					/// <param name="sValue">filter value as string (will be converted)</param>
					/// <returns></returns>
					public extern virtual sap.ui.table.Table filter(sap.ui.table.Column oColumn, string sValue);

					/// <summary>
					/// Returns the control inside the cell with the given row index (in the <code>rows</code> aggregation) and column index (in the <code>columns</code> aggregation or in the list of visible columns only, depending on parameter <code>bVisibleColumnIndex</code>).
					/// </summary>
					/// <param name="iRowIndex">Index of row in the table's <code>rows</code> aggregation</param>
					/// <param name="iColumnIndex">Index of column in the list of visible columns or in the <code>columns</code> aggregation, as indicated with <code>bVisibleColumnIndex</code></param>
					/// <param name="bVisibleColumnIndex">If set to <code>true</code>, the given column index is interpreted as index in the list of visible columns, otherwise as index in the <code>columns</code> aggregation</param>
					/// <returns>Control inside the cell with the given row and column index or <code>null</code> if no such control exists</returns>
					public extern virtual sap.ui.core.Control getCellControl(int iRowIndex, int iColumnIndex, bool bVisibleColumnIndex);

					/// <summary>
					/// In contrast to the function <code>getFixedColumnCount</code> which returns the value of the property <code>fixedColumnCount</code>, this function returns the actual fixed column count computed based on the table width.
					/// 
					/// <b>Note:</b> The computed column count is only available after the table is fully rendered.
					/// </summary>
					/// <returns>The actual fixed column count computed based on the table width.</returns>
					public extern virtual int getComputedFixedColumnCount();

					/// <summary>
					/// Returns the context of a row by its index. Please note that for server-based models like OData, the supplied index might not have been loaded yet. If the context is not available at the client, the binding will trigger a backend request and request this single context. Although this API looks synchronous it may not return a context but load it and fire a change event on the binding.
					/// 
					/// For server-based models you should consider to only make this API call when the index is within the currently visible scroll area.
					/// </summary>
					/// <param name="iIndex">Index of the row to return the context from.</param>
					/// <returns></returns>
					public extern virtual object getContextByIndex(int iIndex);

					/// <summary>
					/// Gets content of aggregation <code>dragDropConfig</code> which defines the drag-and-drop configuration.
					/// 
					/// The following restrictions apply: <ul> <li>Columns cannot be configured to be draggable.</li> <li>The following rows are not draggable: <ul> <li>Empty rows</li> <li>Group header rows</li> <li>Sum rows</li> </ul> </li> <li>Columns cannot be configured to be droppable.</li> <li>The following rows are not droppable: <ul> <li>The dragged row itself</li> <li>Empty rows</li> <li>Group header rows</li> <li>Sum rows</li> </ul> </li> </ul>
					/// </summary>
					/// <returns>sap.ui.core.dnd.DragDropBase[]</returns>
					public extern virtual void getDragDropConfig();

					/// <summary>
					/// Returns a metadata object for class sap.ui.table.Table.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Zero-based indices of selected items, wrapped in an array. An empty array means "no selection".
					/// </summary>
					/// <returns>int[]</returns>
					public extern virtual void getSelectedIndices();

					/// <summary>
					/// Gets sorted columns in the order of which the sort API at the table or column was called. Sorting on binding level is not reflected here.
					/// </summary>
					/// <returns>Array of sorted columns</returns>
					public extern virtual void getSortedColumns();

					/// <summary>
					/// Returns whether the given index is selected.
					/// </summary>
					/// <param name="iIndex">Index which is checked for selection state.</param>
					/// <returns></returns>
					public extern virtual bool isIndexSelected(int iIndex);

					/// <summary>
					/// Removes the given selection interval from the selection. In case of single selection this call removeSelectedIndex with the "indexTo" value.
					/// </summary>
					/// <param name="iIndexFrom">Index from which .</param>
					/// <param name="iIndexTo">Indices of the items that shall additionally be selected.</param>
					/// <returns></returns>
					public extern virtual sap.ui.table.Table removeSelectionInterval(int iIndexFrom, int iIndexTo);

					/// <summary>
					/// Add all rows to the selection. Please note that for server based models like OData the indices which are considered to be selected might not be available at the client yet. Calling getContextByIndex might not return a result but trigger a roundtrip to request this single entity.
					/// </summary>
					/// <returns>sap.ui.table.Table</returns>
					public extern virtual void selectAll();

					/// <summary>
					/// Sets the given selection interval as selection. In case of single selection the "indexTo" value will be used for as selected index.
					/// </summary>
					/// <param name="iIndexFrom">Index from which .</param>
					/// <param name="iIndexTo">Indices of the items that shall additionally be selected.</param>
					/// <returns></returns>
					public extern virtual sap.ui.table.Table setSelectionInterval(int iIndexFrom, int iIndexTo);

					/// <summary>
					/// Sets a new tooltip for this object. The tooltip can either be a simple string (which in most cases will be rendered as the <code>title</code> attribute of this Element) or an instance of {@link sap.ui.core.TooltipBase}.
					/// 
					/// If a new tooltip is set, any previously set tooltip is deactivated.
					/// 
					/// Please note that tooltips are not rendered for the table. The tooltip property will be set but it won't effect the DOM.
					/// </summary>
					/// <param name="vTooltip"></param>
					/// <returns>This-reference for chaining</returns>
					public extern virtual sap.ui.table.Table setTooltip(Union<string, sap.ui.core.TooltipBase> vTooltip);

					/// <summary>
					/// Sorts the given column ascending or descending.
					/// </summary>
					/// <param name="oColumn">column to be sorted or undefined to clear sorting</param>
					/// <param name="oSortOrder">sort order of the column (if undefined the default will be ascending)</param>
					/// <param name="bAdd">Set to true to add the new sort criterion to the existing sort criteria</param>
					/// <returns></returns>
					public extern virtual sap.ui.table.Table sort(sap.ui.table.Column oColumn, sap.ui.table.SortOrder oSortOrder, bool bAdd);

					#endregion

					#endregion

				}
			}
		}
	}
}
