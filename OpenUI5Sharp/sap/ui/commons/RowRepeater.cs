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
				/// <summary>
				/// This control displays items in a stacked list format, allowing the user to page in order to see more items or to use the offered filtering and sorting capabilities in order to manipulate the displayed data.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.RowRepeater")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.ui.table.Table</code> control.")]
				public partial class RowRepeater : sap.ui.core.Control
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
						/// Number of rows displayed.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> numberOfRows;

						/// <summary>
						/// The index of the page currently displayed. The index starts at 1.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> currentPage;

						/// <summary>
						/// Step size used to increase the numberOfRows value. This feature is only active if value is greater than 0. This will deactivate the paging feature.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showMoreSteps;

						/// <summary>
						/// Row height adapts to rendered content. If a fixed height is specified the cells have a maximum height and the overflow will be hidden.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fixedRowHeight;

						/// <summary>
						/// The visual design of the control.
						/// </summary>
						public Union<sap.ui.commons.RowRepeaterDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

						/// <summary>
						/// Threshold to fetch the next chunk of data. The minimal threshold can be the numberOfRows of the RR.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> threshold;

						/// <summary>
						/// Rows to be repeated.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> rows;

						/// <summary>
						/// Title to be displayed in top left corner. Either text or icon.
						/// </summary>
						public Union<sap.ui.core.Title, string, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

						/// <summary>
						/// Filters to be provided in toolbar.
						/// </summary>
						public Union<sap.ui.commons.RowRepeaterFilter[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> filters;

						/// <summary>
						/// Sorters to be provided in secondary toolbar.
						/// </summary>
						public Union<sap.ui.commons.RowRepeaterSorter[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> sorters;

						/// <summary>
						/// This control is shown, in case there is no data available to be displayed in the RowRepeater.
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> noData;

						/// <summary>
						/// This event is triggered when a filter is set.
						/// </summary>
						public sap.ui.commons.RowRepeater.FilterDelegate filter;

						/// <summary>
						/// This event is triggered when a sorting is applied.
						/// </summary>
						public sap.ui.commons.RowRepeater.SortDelegate sort;

						/// <summary>
						/// This event is triggered when paging was executed.
						/// </summary>
						public sap.ui.commons.RowRepeater.PageDelegate page;

						/// <summary>
						/// This event is triggered when the number of rows was changed.
						/// </summary>
						public sap.ui.commons.RowRepeater.ResizeDelegate resize;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class FilterInfo
					{
						/// <summary>
						/// The ID of the filter that has just been applied.
						/// </summary>
						public string filterId;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class PageInfo
					{
						/// <summary>
						/// The value of the currentPage property after the change.
						/// </summary>
						public int currentPage;

						/// <summary>
						/// The value of the currentPage property before the change.
						/// </summary>
						public int previousPage;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ResizeInfo
					{
						/// <summary>
						/// The value of the numberOfRows property after the change.
						/// </summary>
						public int numberOfRows;

						/// <summary>
						/// The value of the numberOfRows property before the change.
						/// </summary>
						public int previousNumberOfRows;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SortInfo
					{
						/// <summary>
						/// The ID of the sorter that has just been applied.
						/// </summary>
						public string sorterId;

					}

					#endregion

					#region Delegates

					public delegate void FilterDelegate(sap.ui.@base.Event<sap.ui.commons.RowRepeater.FilterInfo> oEvent, object oData);

					public delegate void PageDelegate(sap.ui.@base.Event<sap.ui.commons.RowRepeater.PageInfo> oEvent, object oData);

					public delegate void ResizeDelegate(sap.ui.@base.Event<sap.ui.commons.RowRepeater.ResizeInfo> oEvent, object oData);

					public delegate void SortDelegate(sap.ui.@base.Event<sap.ui.commons.RowRepeater.SortInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new RowRepeater.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern RowRepeater(string sId, sap.ui.commons.RowRepeater.Settings mSettings);

					/// <summary>
					/// Constructor for a new RowRepeater.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern RowRepeater(string sId);

					/// <summary>
					/// Constructor for a new RowRepeater.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern RowRepeater();

					/// <summary>
					/// Constructor for a new RowRepeater.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern RowRepeater(sap.ui.commons.RowRepeater.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property numberOfRows

					/// <summary>
					/// Gets current value of property {@link #getNumberOfRows numberOfRows}.
					/// 
					/// Number of rows displayed.
					/// 
					/// Default value is <code>5</code>.
					/// </summary>
					/// <returns>Value of property <code>numberOfRows</code></returns>
					public extern virtual int getNumberOfRows();

					/// <summary>
					/// Setter for property <code>numberOfRows</code>.
					/// 
					/// Default value is <code>5</code>
					/// </summary>
					/// <param name="iNumberOfRows">new value for property <code>numberOfRows</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater setNumberOfRows(int iNumberOfRows);

					#endregion

					#region Methods for Property currentPage

					/// <summary>
					/// Gets current value of property {@link #getCurrentPage currentPage}.
					/// 
					/// The index of the page currently displayed. The index starts at 1.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>currentPage</code></returns>
					public extern virtual int getCurrentPage();

					/// <summary>
					/// Setter for property <code>currentPage</code>.
					/// </summary>
					/// <param name="iCurrentPage">new value for property <code>currentPage</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater setCurrentPage(int iCurrentPage);

					#endregion

					#region Methods for Property showMoreSteps

					/// <summary>
					/// Gets current value of property {@link #getShowMoreSteps showMoreSteps}.
					/// 
					/// Step size used to increase the numberOfRows value. This feature is only active if value is greater than 0. This will deactivate the paging feature.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>showMoreSteps</code></returns>
					public extern virtual int getShowMoreSteps();

					/// <summary>
					/// Override the default behavior of <code>setShowMoreSteps</code> to update the paging mode flag. Any change to the paging mode flag will result in the current page being set to the first page.
					/// </summary>
					/// <param name="iShowMoreSteps">new value for property <code>showMoreSteps</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater setShowMoreSteps(int iShowMoreSteps);

					#endregion

					#region Methods for Property fixedRowHeight

					/// <summary>
					/// Gets current value of property {@link #getFixedRowHeight fixedRowHeight}.
					/// 
					/// Row height adapts to rendered content. If a fixed height is specified the cells have a maximum height and the overflow will be hidden.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>fixedRowHeight</code></returns>
					public extern virtual sap.ui.core.CSSSize getFixedRowHeight();

					/// <summary>
					/// Sets a new value for property {@link #getFixedRowHeight fixedRowHeight}.
					/// 
					/// Row height adapts to rendered content. If a fixed height is specified the cells have a maximum height and the overflow will be hidden.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sFixedRowHeight">New value for property <code>fixedRowHeight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater setFixedRowHeight(sap.ui.core.CSSSize sFixedRowHeight);

					#endregion

					#region Methods for Property design

					/// <summary>
					/// Gets current value of property {@link #getDesign design}.
					/// 
					/// The visual design of the control.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <returns>Value of property <code>design</code></returns>
					public extern virtual sap.ui.commons.RowRepeaterDesign getDesign();

					/// <summary>
					/// Sets a new value for property {@link #getDesign design}.
					/// 
					/// The visual design of the control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <param name="sDesign">New value for property <code>design</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater setDesign(sap.ui.commons.RowRepeaterDesign sDesign);

					#endregion

					#region Methods for Property threshold

					/// <summary>
					/// Gets current value of property {@link #getThreshold threshold}.
					/// 
					/// Threshold to fetch the next chunk of data. The minimal threshold can be the numberOfRows of the RR.
					/// </summary>
					/// <returns>Value of property <code>threshold</code></returns>
					public extern virtual int getThreshold();

					/// <summary>
					/// Sets a new value for property {@link #getThreshold threshold}.
					/// 
					/// Threshold to fetch the next chunk of data. The minimal threshold can be the numberOfRows of the RR.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iThreshold">New value for property <code>threshold</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater setThreshold(int iThreshold);

					#endregion

					#region Methods for Aggregation rows

					/// <summary>
					/// Gets content of aggregation {@link #getRows rows}.
					/// 
					/// Rows to be repeated.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getRows();

					/// <summary>
					/// Destroys all the rows in the aggregation {@link #getRows rows}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater destroyRows();

					/// <summary>
					/// Inserts a row into the aggregation {@link #getRows rows}.
					/// </summary>
					/// <param name="oRow">The row to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the row should be inserted at; for a negative value of <code>iIndex</code>, the row is inserted at position 0; for a value greater than the current size of the aggregation, the row is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater insertRow(sap.ui.core.Control oRow, int iIndex);

					/// <summary>
					/// Adds some row to the aggregation {@link #getRows rows}.
					/// </summary>
					/// <param name="oRow">The row to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater addRow(sap.ui.core.Control oRow);

					/// <summary>
					/// Removes a row from the aggregation {@link #getRows rows}.
					/// </summary>
					/// <param name="vRow">The row to remove or its index or id</param>
					/// <returns>The removed row or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeRow(Union<int, string, sap.ui.core.Control> vRow);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getRows rows}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oRow">The row whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfRow(sap.ui.core.Control oRow);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getRows rows}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllRows();

					/// <summary>
					/// Binds aggregation {@link #getRows rows} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater bindRows(object oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getRows rows} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater unbindRows();

					#endregion

					#region Methods for Aggregation title

					/// <summary>
					/// Gets content of aggregation {@link #getTitle title}.
					/// 
					/// Title to be displayed in top left corner. Either text or icon.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Title getTitle();

					/// <summary>
					/// Destroys the title in the aggregation {@link #getTitle title}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater destroyTitle();

					/// <summary>
					/// Sets the aggregated {@link #getTitle title}.
					/// </summary>
					/// <param name="oTitle">The title to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater setTitle(sap.ui.core.Title oTitle);

					#endregion

					#region Methods for Aggregation filters

					/// <summary>
					/// Gets content of aggregation {@link #getFilters filters}.
					/// 
					/// Filters to be provided in toolbar.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.RowRepeaterFilter[] getFilters();

					/// <summary>
					/// Destroys all the filters in the aggregation {@link #getFilters filters}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater destroyFilters();

					/// <summary>
					/// Inserts a filter into the aggregation {@link #getFilters filters}.
					/// </summary>
					/// <param name="oFilter">The filter to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the filter should be inserted at; for a negative value of <code>iIndex</code>, the filter is inserted at position 0; for a value greater than the current size of the aggregation, the filter is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater insertFilter(sap.ui.commons.RowRepeaterFilter oFilter, int iIndex);

					/// <summary>
					/// Adds some filter to the aggregation {@link #getFilters filters}.
					/// </summary>
					/// <param name="oFilter">The filter to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater addFilter(sap.ui.commons.RowRepeaterFilter oFilter);

					/// <summary>
					/// Removes a filter from the aggregation {@link #getFilters filters}.
					/// </summary>
					/// <param name="vFilter">The filter to remove or its index or id</param>
					/// <returns>The removed filter or <code>null</code></returns>
					public extern virtual sap.ui.commons.RowRepeaterFilter removeFilter(Union<int, string, sap.ui.commons.RowRepeaterFilter> vFilter);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.RowRepeaterFilter</code> in the aggregation {@link #getFilters filters}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oFilter">The filter whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfFilter(sap.ui.commons.RowRepeaterFilter oFilter);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getFilters filters}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.RowRepeaterFilter[] removeAllFilters();

					#endregion

					#region Methods for Aggregation sorters

					/// <summary>
					/// Gets content of aggregation {@link #getSorters sorters}.
					/// 
					/// Sorters to be provided in secondary toolbar.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.RowRepeaterSorter[] getSorters();

					/// <summary>
					/// Destroys all the sorters in the aggregation {@link #getSorters sorters}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater destroySorters();

					/// <summary>
					/// Inserts a sorter into the aggregation {@link #getSorters sorters}.
					/// </summary>
					/// <param name="oSorter">The sorter to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the sorter should be inserted at; for a negative value of <code>iIndex</code>, the sorter is inserted at position 0; for a value greater than the current size of the aggregation, the sorter is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater insertSorter(sap.ui.commons.RowRepeaterSorter oSorter, int iIndex);

					/// <summary>
					/// Adds some sorter to the aggregation {@link #getSorters sorters}.
					/// </summary>
					/// <param name="oSorter">The sorter to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater addSorter(sap.ui.commons.RowRepeaterSorter oSorter);

					/// <summary>
					/// Removes a sorter from the aggregation {@link #getSorters sorters}.
					/// </summary>
					/// <param name="vSorter">The sorter to remove or its index or id</param>
					/// <returns>The removed sorter or <code>null</code></returns>
					public extern virtual sap.ui.commons.RowRepeaterSorter removeSorter(Union<int, string, sap.ui.commons.RowRepeaterSorter> vSorter);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.RowRepeaterSorter</code> in the aggregation {@link #getSorters sorters}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oSorter">The sorter whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfSorter(sap.ui.commons.RowRepeaterSorter oSorter);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getSorters sorters}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.RowRepeaterSorter[] removeAllSorters();

					#endregion

					#region Methods for Aggregation noData

					/// <summary>
					/// Gets content of aggregation {@link #getNoData noData}.
					/// 
					/// This control is shown, in case there is no data available to be displayed in the RowRepeater.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control getNoData();

					/// <summary>
					/// Destroys the noData in the aggregation {@link #getNoData noData}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater destroyNoData();

					/// <summary>
					/// Sets the aggregated {@link #getNoData noData}.
					/// </summary>
					/// <param name="oNoData">The noData to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater setNoData(sap.ui.core.Control oNoData);

					#endregion

					#region Methods for Aggregation filterToolbar

					#endregion

					#region Methods for Aggregation sorterToolbar

					#endregion

					#region Methods for Aggregation headerShowMoreButton

					#endregion

					#region Methods for Aggregation footerShowMoreButton

					#endregion

					#region Methods for Aggregation footerPager

					#endregion

					#region Methods for Event filter

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filter filter} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when a filter is set.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RowRepeater</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachFilter(object oData, sap.ui.commons.RowRepeater.FilterDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filter filter} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when a filter is set.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachFilter(object oData, sap.ui.commons.RowRepeater.FilterDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filter filter} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when a filter is set.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachFilter(sap.ui.commons.RowRepeater.FilterDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filter filter} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when a filter is set.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RowRepeater</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachFilter(sap.ui.commons.RowRepeater.FilterDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:filter filter} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater detachFilter(sap.ui.commons.RowRepeater.FilterDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:filter filter} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater fireFilter(sap.ui.commons.RowRepeater.FilterInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:filter filter} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater fireFilter();

					#endregion

					#region Methods for Event sort

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sort sort} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when a sorting is applied.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RowRepeater</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachSort(object oData, sap.ui.commons.RowRepeater.SortDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sort sort} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when a sorting is applied.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachSort(object oData, sap.ui.commons.RowRepeater.SortDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sort sort} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when a sorting is applied.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachSort(sap.ui.commons.RowRepeater.SortDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sort sort} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when a sorting is applied.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RowRepeater</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachSort(sap.ui.commons.RowRepeater.SortDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:sort sort} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater detachSort(sap.ui.commons.RowRepeater.SortDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:sort sort} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater fireSort(sap.ui.commons.RowRepeater.SortInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:sort sort} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater fireSort();

					#endregion

					#region Methods for Event page

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:page page} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when paging was executed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RowRepeater</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachPage(object oData, sap.ui.commons.RowRepeater.PageDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:page page} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when paging was executed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachPage(object oData, sap.ui.commons.RowRepeater.PageDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:page page} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when paging was executed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachPage(sap.ui.commons.RowRepeater.PageDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:page page} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when paging was executed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RowRepeater</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachPage(sap.ui.commons.RowRepeater.PageDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:page page} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater detachPage(sap.ui.commons.RowRepeater.PageDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:page page} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater firePage(sap.ui.commons.RowRepeater.PageInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:page page} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater firePage();

					#endregion

					#region Methods for Event resize

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when the number of rows was changed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RowRepeater</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachResize(object oData, sap.ui.commons.RowRepeater.ResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when the number of rows was changed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachResize(object oData, sap.ui.commons.RowRepeater.ResizeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when the number of rows was changed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachResize(sap.ui.commons.RowRepeater.ResizeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RowRepeater</code> itself.
					/// 
					/// This event is triggered when the number of rows was changed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RowRepeater</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater attachResize(sap.ui.commons.RowRepeater.ResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:resize resize} event of this <code>sap.ui.commons.RowRepeater</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater detachResize(sap.ui.commons.RowRepeater.ResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:resize resize} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater fireResize(sap.ui.commons.RowRepeater.ResizeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:resize resize} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater fireResize();

					#endregion

					#region Other methods

					/// <summary>
					/// Applies a filter.
					/// </summary>
					/// <param name="sId">The ID if the filter.</param>
					public extern virtual void applyFilter(string sId);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RowRepeater with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RowRepeater with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RowRepeater with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Switch to first page.
					/// </summary>
					public extern virtual void firstPage();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.RowRepeater.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Switch to specified page.
					/// </summary>
					/// <param name="iPageNumber">The index of the page to go to.</param>
					public extern virtual void gotoPage(int iPageNumber);

					/// <summary>
					/// Switch to last page.
					/// </summary>
					public extern virtual void lastPage();

					/// <summary>
					/// Switch to next page.
					/// </summary>
					public extern virtual void nextPage();

					/// <summary>
					/// Switch to previous page.
					/// </summary>
					public extern virtual void previousPage();

					/// <summary>
					/// Resizes the row repeater by changing the number of displayed rows. This method will only resize the RowRepeater if the property showMoreSteps is set.
					/// </summary>
					/// <param name="iNumberOfRows">The new value of number of rows displayed.</param>
					public extern virtual void resize(int iNumberOfRows);

					/// <summary>
					/// The <code>triggerShowMore</code> function increments the number of rows by the value of <code>showMoreSteps</code>.
					/// 
					/// This method will only trigger a showMore if the property showMoreSteps is set.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.RowRepeater triggerShowMore();

					/// <summary>
					/// Sort the data.
					/// </summary>
					/// <param name="sId">The ID of the sorter.</param>
					public extern virtual void triggerSort(string sId);

					#endregion

					#endregion

				}
			}
		}
	}
}
