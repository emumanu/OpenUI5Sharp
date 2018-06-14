using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// <h3>Overview</h3> A SelectDialog is a dialog containing a list, search functionality to filter it and a confirmation/cancel button. The list used in the dialog is a growing list and can be filled with any kind of list item. <h3>Structure</h3> <h4>Dialog structure</h4> The select dialog has the following components: <ul> <li>Header - title of the dialog</li> <li>Search field - input field to enter search terms</li> <li>Info toolbar (only in multi-select) - displays the number of currently selected items</li> <li>Content - {@link sap.m.StandardListItem standard list items}, {@link sap.m.DisplayListItem display list items} or {@link sap.m.FeedListItem feed list items}</li> <li>Button toolbar - for confirmation/cancellation buttons </li> </ul> <h4>List structure & selection</h4> <ul> <li> The search field triggers the events <code>search</code> and <code>liveChange</code> where a filter function can be applied to the list binding. </li> <li> The growing functionality of the list does not support two-way Binding, so if you use this control with a JSON model make sure the binding mode is set to <code>OneWay</code> and that you update the selection model manually with the items passed in the <code>confirm</code> event. </li> <li> In the multi-select mode of the select dialog, checkboxes are provided for choosing multiple entries. </li> <li> You can set <code>rememberSelections</code> to true to store the current selection and load this state when the dialog is opened again. </li> <li> When cancelling the selection, the event <code>change</code> will be fired and the selection is restored to the state when the dialog was opened. </li> </ul> <h3>Usage</h3> <h4>When to use:</h4> <ul> <li>You need to select one or more entries from a comprehensive list that contains multiple attributes or values. </li> </ul> <h4>When not to use:</h4> <ul> <li> You need to pick one item from a predefined set of options. Use {@link sap.m.Select select} or {@link sap.m.ComboBox combobox} instead. </li> <li> You need to select a range of item. Use {@link sap.ui.comp.valuehelpdialog.ValueHelpDialog value help dialog instead. </li> <li> You need to be able to add your own values to an existing list. Use a {@link sap.m.Dialog dialog} instead. </li> </ul> <h3>Responsive Behavior</h3> <ul> <li> On phones, the select dialog takes up the whole screen. </li> <li> On desktop and tablet devices, the select dialog appears as a popover. </li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class SelectDialog : sap.ui.core.Control
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
					/// Determines the title text that appears in the dialog header
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

					/// <summary>
					/// Determines the text shown when the list has no data
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> noDataText;

					/// <summary>
					/// Determines if the user can select several options from the list
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> multiSelect;

					/// <summary>
					/// Determines the number of items initially displayed in the list. Also defines the number of items to be requested from the model for each grow.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> growingThreshold;

					/// <summary>
					/// Determines the content width of the inner dialog. For more information, see the dialog documentation.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> contentWidth;

					/// <summary>
					/// This flag controls whether the dialog clears the selection after the confirm event has been fired. If the dialog needs to be opened multiple times in the same context to allow for corrections of previous user inputs, set this flag to "true".
					/// 
					/// <b>Note:</b> The sap.m.SelectDialog uses {@link sap.m.ListBase#rememberSelections this} property of the ListBase and therefore its limitations also apply here.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> rememberSelections;

					/// <summary>
					/// Determines the content height of the inner dialog. For more information, see the dialog documentation.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> contentHeight;

					/// <summary>
					/// The items of the list shown in the search dialog. It is recommended to use a StandardListItem for the dialog but other combinations are also possible.
					/// </summary>
					public Union<sap.m.ListItemBase[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// This event will be fired when the dialog is confirmed by selecting an item in single selection mode or by pressing the confirmation button in multi selection mode . The items being selected are returned as event parameters.
					/// </summary>
					public sap.m.SelectDialog.ConfirmDelegate confirm;

					/// <summary>
					/// This event will be fired when the search button has been clicked on the searchfield on the visual control
					/// </summary>
					public sap.m.SelectDialog.SearchOrLiveChangeDelegate search;

					/// <summary>
					/// This event will be fired when the value of the search field is changed by a user - e.g. at each key press
					/// </summary>
					public sap.m.SelectDialog.SearchOrLiveChangeDelegate liveChange;

					/// <summary>
					/// This event will be fired when the cancel button is clicked
					/// </summary>
					public sap.ui.@base.EventDelegate cancel;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ConfirmInfo
				{
					/// <summary>
					/// Returns the selected list item. When no item is selected, "null" is returned. When multi-selection is enabled and multiple items are selected, only the first selected item is returned.
					/// </summary>
					public sap.m.StandardListItem selectedItem;

					/// <summary>
					/// Returns an array containing the visible selected list items. If no items are selected, an empty array is returned.
					/// </summary>
					public sap.m.StandardListItem[] selectedItems;

					/// <summary>
					/// Returns the binding contexts of the selected items including the non-visible items. NOTE: In contrast to the parameter "selectedItems", this parameter will also include the selected but NOT visible items (e.g. due to list filtering). An empty array will be set for this parameter if no data binding is used. NOTE: When the list binding is pre-filtered and there are items in the selection that are not visible upon opening the dialog, these contexts are not loaded. Therefore, these items will not be included in the selectedContexts array unless they are displayed at least once.
					/// </summary>
					public string selectedContexts;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SearchOrLiveChangeInfo
				{
					/// <summary>
					/// The value to search for, which can change at any keypress
					/// </summary>
					public string value;

					/// <summary>
					/// The Items binding of the Select Dialog. It will only be available if the items aggregation is bound to a model.
					/// </summary>
					public object itemsBinding;

				}

				#endregion

				#region Delegates

				public delegate void ConfirmDelegate(sap.ui.@base.Event<sap.m.SelectDialog.ConfirmInfo> oEvent, object oData);

				public delegate void SearchOrLiveChangeDelegate(sap.ui.@base.Event<sap.m.SelectDialog.SearchOrLiveChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new SelectDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control A dialog that enables users to select one or more items from a comprehensive list.</param>
				public extern SelectDialog(string sId, sap.m.SelectDialog.Settings mSettings);

				/// <summary>
				/// Constructor for a new SelectDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern SelectDialog(string sId);

				/// <summary>
				/// Constructor for a new SelectDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern SelectDialog();

				/// <summary>
				/// Constructor for a new SelectDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control A dialog that enables users to select one or more items from a comprehensive list.</param>
				public extern SelectDialog(sap.m.SelectDialog.Settings mSettings);

				#endregion

				#region Fields

				/// <summary>
				/// Set the binding context for the internal list AND the current control so that both controls can be used with the context
				/// </summary>
				public object _setBindingContext;

				/// <summary>
				/// Set the model for the internal list AND the current control so that both controls can be used with data binding
				/// </summary>
				public object _setModel;

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Determines the title text that appears in the dialog header
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Set the title of the internal dialog
				/// </summary>
				/// <param name="sTitle">The title text for the dialog</param>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog setTitle(string sTitle);

				#endregion

				#region Methods for Property noDataText

				/// <summary>
				/// Get the internal List's no data text property
				/// </summary>
				/// <returns>the current no data text</returns>
				public extern virtual string getNoDataText();

				/// <summary>
				/// Set the internal List's no data text property
				/// </summary>
				/// <param name="sNoDataText">The no data text for the list</param>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog setNoDataText(string sNoDataText);

				#endregion

				#region Methods for Property multiSelect

				/// <summary>
				/// Gets current value of property {@link #getMultiSelect multiSelect}.
				/// 
				/// Determines if the user can select several options from the list
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>multiSelect</code></returns>
				public extern virtual bool getMultiSelect();

				/// <summary>
				/// Enable/Disable multi selection mode.
				/// </summary>
				/// <param name="bMulti">Flag for multi selection mode</param>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog setMultiSelect(bool bMulti);

				#endregion

				#region Methods for Property growingThreshold

				/// <summary>
				/// Gets current value of property {@link #getGrowingThreshold growingThreshold}.
				/// 
				/// Determines the number of items initially displayed in the list. Also defines the number of items to be requested from the model for each grow.
				/// </summary>
				/// <returns>Value of property <code>growingThreshold</code></returns>
				public extern virtual int getGrowingThreshold();

				/// <summary>
				/// Sets the growing threshold to the internal list
				/// </summary>
				/// <param name="iValue">Value for the list's growing threshold.</param>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog setGrowingThreshold(int iValue);

				#endregion

				#region Methods for Property contentWidth

				/// <summary>
				/// Get the internal Dialog's contentWidth property {@link sap.m.Dialog}
				/// </summary>
				/// <returns>sWidth The content width of the internal dialog</returns>
				public extern virtual sap.ui.core.CSSSize getContentWidth();

				/// <summary>
				/// Set the internal Dialog's contentWidth property {@link sap.m.Dialog}
				/// </summary>
				/// <param name="sWidth">The new content width value for the dialog</param>
				/// <returns><code>this</code>s pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog setContentWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property rememberSelections

				/// <summary>
				/// Gets current value of property {@link #getRememberSelections rememberSelections}.
				/// 
				/// This flag controls whether the dialog clears the selection after the confirm event has been fired. If the dialog needs to be opened multiple times in the same context to allow for corrections of previous user inputs, set this flag to "true".
				/// 
				/// <b>Note:</b> The sap.m.SelectDialog uses {@link sap.m.ListBase#rememberSelections this} property of the ListBase and therefore its limitations also apply here.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>rememberSelections</code></returns>
				public extern virtual bool getRememberSelections();

				/// <summary>
				/// Sets a new value for property {@link #getRememberSelections rememberSelections}.
				/// 
				/// This flag controls whether the dialog clears the selection after the confirm event has been fired. If the dialog needs to be opened multiple times in the same context to allow for corrections of previous user inputs, set this flag to "true".
				/// 
				/// <b>Note:</b> The sap.m.SelectDialog uses {@link sap.m.ListBase#rememberSelections this} property of the ListBase and therefore its limitations also apply here.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bRememberSelections">New value for property <code>rememberSelections</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog setRememberSelections(bool bRememberSelections);

				#endregion

				#region Methods for Property contentHeight

				/// <summary>
				/// Get the internal Dialog's contentHeight property {@link sap.m.Dialog}
				/// </summary>
				/// <returns>sHeight The content width of the internal dialog</returns>
				public extern virtual sap.ui.core.CSSSize getContentHeight();

				/// <summary>
				/// Set the internal Dialog's contentHeight property {@link sap.m.Dialog}
				/// </summary>
				/// <param name="sHeight">The new content width value for the dialog</param>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog setContentHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// The items of the list shown in the search dialog. It is recommended to use a StandardListItem for the dialog but other combinations are also possible.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ListItemBase[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog insertItem(sap.m.ListItemBase oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog addItem(sap.m.ListItemBase oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.m.ListItemBase removeItem(Union<int, string, sap.m.ListItemBase> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.ListItemBase</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.ListItemBase oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ListItemBase[] removeAllItems();

				#endregion

				#region Methods for Aggregation _dialog

				#endregion

				#region Methods for Event confirm

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the dialog is confirmed by selecting an item in single selection mode or by pressing the confirmation button in multi selection mode . The items being selected are returned as event parameters.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachConfirm(object oData, sap.m.SelectDialog.ConfirmDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the dialog is confirmed by selecting an item in single selection mode or by pressing the confirmation button in multi selection mode . The items being selected are returned as event parameters.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachConfirm(object oData, sap.m.SelectDialog.ConfirmDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the dialog is confirmed by selecting an item in single selection mode or by pressing the confirmation button in multi selection mode . The items being selected are returned as event parameters.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachConfirm(sap.m.SelectDialog.ConfirmDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the dialog is confirmed by selecting an item in single selection mode or by pressing the confirmation button in multi selection mode . The items being selected are returned as event parameters.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachConfirm(sap.m.SelectDialog.ConfirmDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:confirm confirm} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog detachConfirm(sap.m.SelectDialog.ConfirmDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:confirm confirm} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog fireConfirm(sap.m.SelectDialog.ConfirmInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:confirm confirm} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog fireConfirm();

				#endregion

				#region Methods for Event search

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the search button has been clicked on the searchfield on the visual control
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachSearch(object oData, sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the search button has been clicked on the searchfield on the visual control
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachSearch(object oData, sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the search button has been clicked on the searchfield on the visual control
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachSearch(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the search button has been clicked on the searchfield on the visual control
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachSearch(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:search search} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog detachSearch(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:search search} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog fireSearch(sap.m.SelectDialog.SearchOrLiveChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:search search} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog fireSearch();

				#endregion

				#region Methods for Event liveChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the value of the search field is changed by a user - e.g. at each key press
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachLiveChange(object oData, sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the value of the search field is changed by a user - e.g. at each key press
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachLiveChange(object oData, sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the value of the search field is changed by a user - e.g. at each key press
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachLiveChange(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the value of the search field is changed by a user - e.g. at each key press
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachLiveChange(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog detachLiveChange(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog fireLiveChange(sap.m.SelectDialog.SearchOrLiveChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog fireLiveChange();

				#endregion

				#region Methods for Event cancel

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the cancel button is clicked
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the cancel button is clicked
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the cancel button is clicked
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachCancel(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectDialog</code> itself.
				/// 
				/// This event will be fired when the cancel button is clicked
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog attachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:cancel cancel} event of this <code>sap.m.SelectDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog detachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:cancel cancel} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog fireCancel(object mParameters);

				/// <summary>
				/// Fires event {@link #event:cancel cancel} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectDialog fireCancel();

				#endregion

				#region Other methods

				/// <summary>
				/// Forward method to the inner dialog: addStyleClass
				/// </summary>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog addStyleClass();

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Forward method to the inner dialog: getDomRef
				/// </summary>
				/// <returns>The Element's DOM Element sub DOM Element or null</returns>
				public extern virtual dom.HTMLElement getDomRef();

				/// <summary>
				/// Returns a metadata object for class sap.m.SelectDialog.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Forward method to the inner dialog: hasStyleClass
				/// </summary>
				/// <returns>true if the class is set, false otherwise</returns>
				public extern virtual bool hasStyleClass();

				/// <summary>
				/// Invalidates the dialog instead of this control (we don't have a renderer)
				/// </summary>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog invalidate();

				/// <summary>
				/// Is called after renderer is finished to show the busy state
				/// </summary>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog onAfterRendering();

				/// <summary>
				/// Opens the internal dialog with a searchfield and a list.
				/// </summary>
				/// <param name="sSearchValue">A value for the search can be passed to match with the filter applied to the list binding.</param>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog open(string sSearchValue);

				/// <summary>
				/// Forward method to the inner dialog: removeStyleClass
				/// </summary>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog removeStyleClass();

				/// <summary>
				/// Forward method to the inner dialog: toggleStyleClass
				/// </summary>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SelectDialog toggleStyleClass();

				#endregion

				#endregion

			}
		}
	}
}
