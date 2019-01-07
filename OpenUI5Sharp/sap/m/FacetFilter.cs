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
			/// Provides filtering functionality with multiple parameters.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>FacetFilter</code> control is used to provide filtering functionality with multiple parameters and supports the users in finding the information they need from potentially very large data sets.
			/// 
			/// Your app can have dependencies between facets where selection of filter items in one facet list limits the list of valid filters in another facet list.
			/// 
			/// The <code>FacetFilter</code> uses {@link sap.m.FacetFilterList FacetFilterList} and {@link sap.m.FacetFilterItem FacetFilterItem} to model facets and their associated filters.
			/// 
			/// <b>Note: </b>{@link sap.m.FacetFilterList FacetFilterList} is a subclass of {@link sap.m.List} and supports growing enablement feature via the property <code>growing</code>. When you use this feature, be aware that it only works with one-way data binding. Having growing feature enabled when the <code>items</code> aggregation is bound to a model with two-way data binding, may lead to unexpected and/or inconsistent behavior across browsers, such as unexpected closing of the list.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// Use the <code>FacetFilter</code> if your app displays a large list of items that can be grouped by multiple parameters, for example products by category and supplier. With the <code>FacetFilter</code>, you allow the users to dynamically filter the list so it only displays products from the categories and suppliers they want to see.
			/// 
			/// While the {@link sap.m.FacetFilterList} popup is opened (when the user selects a button corresponding to the list's name), any other activities leading to focus change will close it. For example, when the popup is opened and the app developer loads a {@link sap.m.BusyDialog} or any other dialog that obtains the focus, the popup will be closed.
			/// 
			/// <h3>Responsive behavior</h3>
			/// 
			/// The <code>FacetFilter</code> supports the following two types, which can be configured using the control's <code>type</code> property:
			/// 
			/// <ul><li>Simple type (default) - only available for desktop and tablet screen sizes. The active facets are displayed as individually selectable buttons on the toolbar.</li> <li>Light type - automatically enabled on smart phone sized devices, but also available for desktop and tablets. The active facets and selected filter items are displayed in the summary bar. When the user selects the summary bar, a navigable dialog list of all facets is displayed. When the user selects a facet, the dialog scrolls to show the list of filters that are available for the selected facet.</li></ul>
			/// 
			/// <h3>Additional Information</h3>
			/// 
			/// For more information, go to <b>Developer Guide</b> section in the Demo Kit and navigate to <b>More&nbsp;About&nbsp;Controls</b>&nbsp;>&nbsp;<b>sap.m</b>&nbsp;>&nbsp;<b>Facet&nbsp;Filter</b>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.FacetFilter")]
			public partial class FacetFilter : sap.ui.core.Control, sap.ui.core.IShrinkable
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
					/// If set to <code>true</code> and the FacetFilter type is <code>Simple</code>, then the Add Facet icon will be displayed and each facet button will also have a Facet Remove icon displayed beside it, allowing the user to deactivate the facet.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showPersonalization;

					/// <summary>
					/// Defines the default appearance of the FacetFilter on the device. Possible values are <code>Simple</code> (default) and <code>Light</code>.
					/// </summary>
					public Union<sap.m.FacetFilterType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					/// <summary>
					/// Enables/disables live search in the search field of all <code>sap.m.FacetFilterList</code> instances.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> liveSearch;

					/// <summary>
					/// Shows the summary bar instead of the FacetFilter buttons bar when set to <code>true</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSummaryBar;

					/// <summary>
					/// Shows/hides the FacetFilter Reset button.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showReset;

					/// <summary>
					/// If set to <code>true</code>, an OK button is displayed for every FacetFilterList popover. This button allows the user to close the popover from within the popover instead of having to click outside of it.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showPopoverOKButton;

					/// <summary>
					/// Collection of FacetFilterList controls.
					/// </summary>
					public Union<sap.m.FacetFilterList[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> lists;

					/// <summary>
					/// Fired when the Reset button is pressed to inform that all FacetFilterLists need to be reset.
					/// </summary>
					public sap.ui.@base.EventDelegate reset;

					/// <summary>
					/// Fired when the user confirms filter selection.
					/// </summary>
					public sap.ui.@base.EventDelegate confirm;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>FacetFilter</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern FacetFilter(string sId, sap.m.FacetFilter.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>FacetFilter</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern FacetFilter(string sId);

				/// <summary>
				/// Constructor for a new <code>FacetFilter</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern FacetFilter();

				/// <summary>
				/// Constructor for a new <code>FacetFilter</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern FacetFilter(sap.m.FacetFilter.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property showPersonalization

				/// <summary>
				/// Gets current value of property {@link #getShowPersonalization showPersonalization}.
				/// 
				/// If set to <code>true</code> and the FacetFilter type is <code>Simple</code>, then the Add Facet icon will be displayed and each facet button will also have a Facet Remove icon displayed beside it, allowing the user to deactivate the facet.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showPersonalization</code></returns>
				public extern virtual bool getShowPersonalization();

				/// <summary>
				/// Sets a new value for property {@link #getShowPersonalization showPersonalization}.
				/// 
				/// If set to <code>true</code> and the FacetFilter type is <code>Simple</code>, then the Add Facet icon will be displayed and each facet button will also have a Facet Remove icon displayed beside it, allowing the user to deactivate the facet.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowPersonalization">New value for property <code>showPersonalization</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter setShowPersonalization(bool bShowPersonalization);

				#endregion

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// Defines the default appearance of the FacetFilter on the device. Possible values are <code>Simple</code> (default) and <code>Light</code>.
				/// 
				/// Default value is <code>Simple</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.m.FacetFilterType getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// Defines the default appearance of the FacetFilter on the device. Possible values are <code>Simple</code> (default) and <code>Light</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Simple</code>.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter setType(sap.m.FacetFilterType sType);

				#endregion

				#region Methods for Property liveSearch

				/// <summary>
				/// Gets current value of property {@link #getLiveSearch liveSearch}.
				/// 
				/// Enables/disables live search in the search field of all <code>sap.m.FacetFilterList</code> instances.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>liveSearch</code></returns>
				public extern virtual bool getLiveSearch();

				/// <summary>
				/// Sets a new value for property {@link #getLiveSearch liveSearch}.
				/// 
				/// Enables/disables live search in the search field of all <code>sap.m.FacetFilterList</code> instances.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bLiveSearch">New value for property <code>liveSearch</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter setLiveSearch(bool bLiveSearch);

				#endregion

				#region Methods for Property showSummaryBar

				/// <summary>
				/// Gets current value of property {@link #getShowSummaryBar showSummaryBar}.
				/// 
				/// Shows the summary bar instead of the FacetFilter buttons bar when set to <code>true</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showSummaryBar</code></returns>
				public extern virtual bool getShowSummaryBar();

				/// <summary>
				/// Sets a new value for property {@link #getShowSummaryBar showSummaryBar}.
				/// 
				/// Shows the summary bar instead of the FacetFilter buttons bar when set to <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowSummaryBar">New value for property <code>showSummaryBar</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter setShowSummaryBar(bool bShowSummaryBar);

				#endregion

				#region Methods for Property showReset

				/// <summary>
				/// Gets current value of property {@link #getShowReset showReset}.
				/// 
				/// Shows/hides the FacetFilter Reset button.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showReset</code></returns>
				public extern virtual bool getShowReset();

				/// <summary>
				/// Sets a new value for property {@link #getShowReset showReset}.
				/// 
				/// Shows/hides the FacetFilter Reset button.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowReset">New value for property <code>showReset</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter setShowReset(bool bShowReset);

				#endregion

				#region Methods for Property showPopoverOKButton

				/// <summary>
				/// Gets current value of property {@link #getShowPopoverOKButton showPopoverOKButton}.
				/// 
				/// If set to <code>true</code>, an OK button is displayed for every FacetFilterList popover. This button allows the user to close the popover from within the popover instead of having to click outside of it.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showPopoverOKButton</code></returns>
				public extern virtual bool getShowPopoverOKButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowPopoverOKButton showPopoverOKButton}.
				/// 
				/// If set to <code>true</code>, an OK button is displayed for every FacetFilterList popover. This button allows the user to close the popover from within the popover instead of having to click outside of it.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowPopoverOKButton">New value for property <code>showPopoverOKButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter setShowPopoverOKButton(bool bShowPopoverOKButton);

				#endregion

				#region Methods for Aggregation lists

				/// <summary>
				/// Gets content of aggregation {@link #getLists lists}.
				/// 
				/// Collection of FacetFilterList controls.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.FacetFilterList[] getLists();

				/// <summary>
				/// Destroys all the lists in the aggregation {@link #getLists lists}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter destroyLists();

				/// <summary>
				/// Inserts a list into the aggregation {@link #getLists lists}.
				/// </summary>
				/// <param name="oList">The list to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the list should be inserted at; for a negative value of <code>iIndex</code>, the list is inserted at position 0; for a value greater than the current size of the aggregation, the list is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter insertList(sap.m.FacetFilterList oList, int iIndex);

				/// <summary>
				/// Adds some list to the aggregation {@link #getLists lists}.
				/// </summary>
				/// <param name="oList">The list to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter addList(sap.m.FacetFilterList oList);

				/// <summary>
				/// Removes a list from the aggregation {@link #getLists lists}.
				/// </summary>
				/// <param name="vList">The list to remove or its index or id</param>
				/// <returns>The removed list or <code>null</code></returns>
				public extern virtual sap.m.FacetFilterList removeList(Union<int, string, sap.m.FacetFilterList> vList);

				/// <summary>
				/// Checks for the provided <code>sap.m.FacetFilterList</code> in the aggregation {@link #getLists lists}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oList">The list whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfList(sap.m.FacetFilterList oList);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getLists lists}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.FacetFilterList[] removeAllLists();

				#endregion

				#region Methods for Aggregation buttons

				#endregion

				#region Methods for Aggregation removeFacetIcons

				#endregion

				#region Methods for Aggregation popover

				#endregion

				#region Methods for Aggregation addFacetButton

				#endregion

				#region Methods for Aggregation dialog

				#endregion

				#region Methods for Aggregation summaryBar

				#endregion

				#region Methods for Aggregation resetButton

				#endregion

				#region Methods for Aggregation arrowLeft

				#endregion

				#region Methods for Aggregation arrowRight

				#endregion

				#region Methods for Event reset

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:reset reset} event of this <code>sap.m.FacetFilter</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilter</code> itself.
				/// 
				/// Fired when the Reset button is pressed to inform that all FacetFilterLists need to be reset.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FacetFilter</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter attachReset(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:reset reset} event of this <code>sap.m.FacetFilter</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilter</code> itself.
				/// 
				/// Fired when the Reset button is pressed to inform that all FacetFilterLists need to be reset.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter attachReset(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:reset reset} event of this <code>sap.m.FacetFilter</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilter</code> itself.
				/// 
				/// Fired when the Reset button is pressed to inform that all FacetFilterLists need to be reset.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter attachReset(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:reset reset} event of this <code>sap.m.FacetFilter</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilter</code> itself.
				/// 
				/// Fired when the Reset button is pressed to inform that all FacetFilterLists need to be reset.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FacetFilter</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter attachReset(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:reset reset} event of this <code>sap.m.FacetFilter</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter detachReset(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:reset reset} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter fireReset(object mParameters);

				/// <summary>
				/// Fires event {@link #event:reset reset} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter fireReset();

				#endregion

				#region Methods for Event confirm

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.FacetFilter</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilter</code> itself.
				/// 
				/// Fired when the user confirms filter selection.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FacetFilter</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter attachConfirm(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.FacetFilter</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilter</code> itself.
				/// 
				/// Fired when the user confirms filter selection.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter attachConfirm(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.FacetFilter</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilter</code> itself.
				/// 
				/// Fired when the user confirms filter selection.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter attachConfirm(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.FacetFilter</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilter</code> itself.
				/// 
				/// Fired when the user confirms filter selection.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FacetFilter</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter attachConfirm(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:confirm confirm} event of this <code>sap.m.FacetFilter</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter detachConfirm(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:confirm confirm} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter fireConfirm(object mParameters);

				/// <summary>
				/// Fires event {@link #event:confirm confirm} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilter fireConfirm();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.FacetFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.FacetFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.FacetFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.FacetFilter.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Opens the FacetFilter dialog.
				/// </summary>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.FacetFilter openFilterDialog();

				/// <summary>
				/// This method refreshes the internal model for thr FacetList. It should be called everytime when the model of FacetFilter is changed and update to the FacetList is needed
				/// </summary>
				/// <returns></returns>
				private extern sap.m.FacetFilter refreshFacetList();

				#endregion

				#endregion

			}
		}
	}
}
