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
			public static partial class ux3
			{
				/// <summary>
				/// DataSet
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.DataSet")]
				[Obsolete("Deprecated since 1.38. Use a container by choice from the {@link sap.m} library, instead.")]
				public partial class DataSet : sap.ui.core.Control
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
						/// show Toolbar
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showToolbar;

						/// <summary>
						/// show filter
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showFilter;

						/// <summary>
						/// Show/hide SearchField in Toolbar
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSearchField;

						/// <summary>
						/// Selection mode of the DataSet
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> multiSelect;

						/// <summary>
						/// Aggregation of DataSetItems
						/// </summary>
						public Union<sap.ui.ux3.DataSetItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

						/// <summary>
						/// views
						/// </summary>
						public Union<sap.ui.ux3.DataSetView[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> views;

						/// <summary>
						/// Filter control (e.g. a FacetFilter) for the DataSet
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> filter;

						/// <summary>
						/// Selected view of the Dataset
						/// </summary>
						public Union<sap.ui.ux3.DataSetView, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedView;

						/// <summary>
						/// selection Changed
						/// </summary>
						public sap.ui.ux3.DataSet.SelectionChangedDelegate selectionChanged;

						/// <summary>
						/// Event which is fired when the user triggers a search
						/// </summary>
						public sap.ui.SearchDelegate search;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SelectionChangedInfo
					{
						/// <summary>
						/// Old lead selected index
						/// </summary>
						public int oldLeadSelectedIndex;

						/// <summary>
						/// New lead selected index
						/// </summary>
						public int newLeadSelectedIndex;

					}

					#endregion

					#region Delegates

					public delegate void SelectionChangedDelegate(sap.ui.@base.Event<sap.ui.ux3.DataSet.SelectionChangedInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new DataSet.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern DataSet(string sId, sap.ui.ux3.DataSet.Settings mSettings);

					/// <summary>
					/// Constructor for a new DataSet.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern DataSet(string sId);

					/// <summary>
					/// Constructor for a new DataSet.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern DataSet();

					/// <summary>
					/// Constructor for a new DataSet.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern DataSet(sap.ui.ux3.DataSet.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property showToolbar

					/// <summary>
					/// Gets current value of property {@link #getShowToolbar showToolbar}.
					/// 
					/// show Toolbar
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showToolbar</code></returns>
					public extern virtual bool getShowToolbar();

					/// <summary>
					/// Sets a new value for property {@link #getShowToolbar showToolbar}.
					/// 
					/// show Toolbar
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowToolbar">New value for property <code>showToolbar</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet setShowToolbar(bool bShowToolbar);

					#endregion

					#region Methods for Property showFilter

					/// <summary>
					/// Gets current value of property {@link #getShowFilter showFilter}.
					/// 
					/// show filter
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showFilter</code></returns>
					public extern virtual bool getShowFilter();

					/// <summary>
					/// Sets a new value for property {@link #getShowFilter showFilter}.
					/// 
					/// show filter
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowFilter">New value for property <code>showFilter</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet setShowFilter(bool bShowFilter);

					#endregion

					#region Methods for Property showSearchField

					/// <summary>
					/// Gets current value of property {@link #getShowSearchField showSearchField}.
					/// 
					/// Show/hide SearchField in Toolbar
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showSearchField</code></returns>
					public extern virtual bool getShowSearchField();

					/// <summary>
					/// Sets a new value for property {@link #getShowSearchField showSearchField}.
					/// 
					/// Show/hide SearchField in Toolbar
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowSearchField">New value for property <code>showSearchField</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet setShowSearchField(bool bShowSearchField);

					#endregion

					#region Methods for Property multiSelect

					/// <summary>
					/// Gets current value of property {@link #getMultiSelect multiSelect}.
					/// 
					/// Selection mode of the DataSet
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>multiSelect</code></returns>
					public extern virtual bool getMultiSelect();

					/// <summary>
					/// setter for multi selection mode
					/// </summary>
					/// <param name="bMode">true for multi mode, false for single mode</param>
					public extern virtual void setMultiSelect(bool bMode);

					#endregion

					#region Methods for Aggregation items

					/// <summary>
					/// Gets content of aggregation {@link #getItems items}.
					/// 
					/// Aggregation of DataSetItems
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.DataSetItem[] getItems();

					/// <summary>
					/// Destroys all the items in the aggregation {@link #getItems items}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet destroyItems();

					/// <summary>
					/// Inserts a item into the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet insertItem(sap.ui.ux3.DataSetItem oItem, int iIndex);

					/// <summary>
					/// Adds some item to the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet addItem(sap.ui.ux3.DataSetItem oItem);

					/// <summary>
					/// Removes a item from the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="vItem">The item to remove or its index or id</param>
					/// <returns>The removed item or <code>null</code></returns>
					public extern virtual sap.ui.ux3.DataSetItem removeItem(Union<int, string, sap.ui.ux3.DataSetItem> vItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.DataSetItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oItem">The item whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfItem(sap.ui.ux3.DataSetItem oItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getItems items}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.DataSetItem[] removeAllItems();

					/// <summary>
					/// Binds aggregation {@link #getItems items} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet bindItems(object oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getItems items} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet unbindItems();

					#endregion

					#region Methods for Aggregation views

					/// <summary>
					/// Gets content of aggregation {@link #getViews views}.
					/// 
					/// views
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.DataSetView[] getViews();

					/// <summary>
					/// Destroys all the views in the aggregation {@link #getViews views}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet destroyViews();

					/// <summary>
					/// Inserts a view into the aggregation {@link #getViews views}.
					/// </summary>
					/// <param name="oView">The view to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the view should be inserted at; for a negative value of <code>iIndex</code>, the view is inserted at position 0; for a value greater than the current size of the aggregation, the view is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet insertView(sap.ui.ux3.DataSetView oView, int iIndex);

					/// <summary>
					/// Adds some view to the aggregation {@link #getViews views}.
					/// </summary>
					/// <param name="oView">The view to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet addView(sap.ui.ux3.DataSetView oView);

					/// <summary>
					/// Removes a view from the aggregation {@link #getViews views}.
					/// </summary>
					/// <param name="vView">The view to remove or its index or id</param>
					/// <returns>The removed view or <code>null</code></returns>
					public extern virtual sap.ui.ux3.DataSetView removeView(Union<int, string, sap.ui.ux3.DataSetView> vView);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.DataSetView</code> in the aggregation {@link #getViews views}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oView">The view whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfView(sap.ui.ux3.DataSetView oView);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getViews views}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.DataSetView[] removeAllViews();

					#endregion

					#region Methods for Aggregation filter

					/// <summary>
					/// Gets content of aggregation {@link #getFilter filter}.
					/// 
					/// Filter control (e.g. a FacetFilter) for the DataSet
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getFilter();

					/// <summary>
					/// Destroys all the filter in the aggregation {@link #getFilter filter}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet destroyFilter();

					/// <summary>
					/// Inserts a filter into the aggregation {@link #getFilter filter}.
					/// </summary>
					/// <param name="oFilter">The filter to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the filter should be inserted at; for a negative value of <code>iIndex</code>, the filter is inserted at position 0; for a value greater than the current size of the aggregation, the filter is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet insertFilter(sap.ui.core.Control oFilter, int iIndex);

					/// <summary>
					/// Adds some filter to the aggregation {@link #getFilter filter}.
					/// </summary>
					/// <param name="oFilter">The filter to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet addFilter(sap.ui.core.Control oFilter);

					/// <summary>
					/// Removes a filter from the aggregation {@link #getFilter filter}.
					/// </summary>
					/// <param name="vFilter">The filter to remove or its index or id</param>
					/// <returns>The removed filter or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeFilter(Union<int, string, sap.ui.core.Control> vFilter);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getFilter filter}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oFilter">The filter whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfFilter(sap.ui.core.Control oFilter);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getFilter filter}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllFilter();

					#endregion

					#region Methods for Aggregation _viewSwitches

					#endregion

					#region Methods for Aggregation _toolbar

					#endregion

					#region Methods for Association selectedView

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getSelectedView selectedView}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getSelectedView();

					/// <summary>
					/// Sets the associated {@link #getSelectedView selectedView}.
					/// </summary>
					/// <param name="oSelectedView">ID of an element which becomes the new target of this selectedView association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet setSelectedView(Union<sap.ui.core.ID, sap.ui.ux3.DataSetView> oSelectedView);

					#endregion

					#region Methods for Event selectionChanged

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChanged selectionChanged} event of this <code>sap.ui.ux3.DataSet</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSet</code> itself.
					/// 
					/// selection Changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.DataSet</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet attachSelectionChanged(object oData, sap.ui.ux3.DataSet.SelectionChangedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChanged selectionChanged} event of this <code>sap.ui.ux3.DataSet</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSet</code> itself.
					/// 
					/// selection Changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet attachSelectionChanged(object oData, sap.ui.ux3.DataSet.SelectionChangedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChanged selectionChanged} event of this <code>sap.ui.ux3.DataSet</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSet</code> itself.
					/// 
					/// selection Changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet attachSelectionChanged(sap.ui.ux3.DataSet.SelectionChangedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChanged selectionChanged} event of this <code>sap.ui.ux3.DataSet</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSet</code> itself.
					/// 
					/// selection Changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.DataSet</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet attachSelectionChanged(sap.ui.ux3.DataSet.SelectionChangedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:selectionChanged selectionChanged} event of this <code>sap.ui.ux3.DataSet</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet detachSelectionChanged(sap.ui.ux3.DataSet.SelectionChangedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:selectionChanged selectionChanged} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet fireSelectionChanged(sap.ui.ux3.DataSet.SelectionChangedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:selectionChanged selectionChanged} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet fireSelectionChanged();

					#endregion

					#region Methods for Event search

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.DataSet</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSet</code> itself.
					/// 
					/// Event which is fired when the user triggers a search
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.DataSet</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet attachSearch(object oData, sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.DataSet</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSet</code> itself.
					/// 
					/// Event which is fired when the user triggers a search
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet attachSearch(object oData, sap.ui.SearchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.DataSet</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSet</code> itself.
					/// 
					/// Event which is fired when the user triggers a search
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet attachSearch(sap.ui.SearchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.DataSet</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSet</code> itself.
					/// 
					/// Event which is fired when the user triggers a search
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.DataSet</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet attachSearch(sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:search search} event of this <code>sap.ui.ux3.DataSet</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet detachSearch(sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:search search} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet fireSearch(sap.ui.SearchInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:search search} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSet fireSearch();

					#endregion

					#region Other methods

					/// <summary>
					/// Rerendering of the FilterArea
					/// </summary>
					public extern virtual void _rerenderFilter();

					/// <summary>
					/// Rerendering of the Toolbar
					/// </summary>
					public extern virtual void _rerenderToolbar();

					/// <summary>
					/// add a toolbarItem to the toolbar
					/// </summary>
					/// <param name="oOToolbarItem">ToolbarItem</param>
					public extern virtual void addToolbarItem(sap.ui.commons.ToolbarItem oOToolbarItem);

					/// <summary>
					/// clears dataset from all previous selections
					/// </summary>
					public extern virtual void clearSelection();

					/// <summary>
					/// Creates a view switch button
					/// </summary>
					/// <param name="oView">View</param>
					/// <param name="iIndex">Index of view</param>
					/// <returns>viewSwitch instance</returns>
					public extern virtual object createViewSwitch(object oView, int iIndex);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.DataSet with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.DataSet with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.DataSet with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the LeadSelection index
					/// </summary>
					/// <returns>selected index</returns>
					public extern virtual int getLeadSelection();

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.DataSet.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// use this function to retrieve the lead selected index
					/// </summary>
					public extern virtual void getSelectedIndex();

					/// <summary>
					/// use this function to retrieve all selected indices if multiple select is enabled
					/// </summary>
					public extern virtual void getSelectedIndices();

					/// <summary>
					/// Returns id of selected Item from given index
					/// </summary>
					/// <param name="iIndex">index of selection</param>
					/// <returns>id of selected item</returns>
					public extern virtual string getSelectedItemId(int iIndex);

					/// <summary>
					/// Returns true if iIndex is selected
					/// </summary>
					/// <param name="iIndex">index of selection</param>
					/// <returns>index selected true/false</returns>
					public extern virtual bool isSelectedIndex(int iIndex);

					/// <summary>
					/// remove a toolbarItem to the toolbar
					/// </summary>
					/// <param name="oOToolbarItem"></param>
					public extern virtual void removeToolbarItem(sap.ui.commons.ToolbarItem oOToolbarItem);

					/// <summary>
					/// Set the LeadSelection index
					/// </summary>
					/// <param name="iIIndex">set LeadSelection index</param>
					public extern virtual void setLeadSelection(int iIIndex);

					#endregion

					#endregion

				}
			}
		}
	}
}
