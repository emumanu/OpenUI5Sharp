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
			/// A dialog to select items in a table containing multiple values and attributes. <h3>Overview</h3> The table select dialog helps users select items in a table-like structure with several attributes and values per item. A search fields helps narrow down the results. <h3>Structure</h3> The table select dialog consists of the following elements: <ul> <li> Search field - used to search enter search terms for a specific item.</li> <li> Info toolbar (only in multi-select mode) - displays the number of currently selected items.</li> <li> Content - the table with the items.</li> <li> Footer (optional) - a toolbar for actions.</li> </ul> Table select dialog supports multi-selection when the <code>multiSelect</code> property is set.
			/// 
			/// The selected items can be stored for later editing when the <code>rememberSelections</code> property is set. <b>Note:</b> This property has to be set before the dialog is opened. <h3>Usage</h3> <h4>When to use:</h4> <ul> <li>You need to select one or more items from a comprehensive list that contains multiple attributes or values.</li> </ul> <h4>When not to use:</h4> <ul> <li>You need to select only one item from a predefined list of single-value options. Use the {@link sap.m.Select Select} control instead.</li> <li>You need to display complex content without having the user navigate away from the current page or you want to prompt the user for an action. Use the {@link sap.m.Dialog Dialog} control instead.</li> <li>You need to select items within a query-based range. Use the {@link https://experience.sap.com/fiori-design-web/value-help-dialog/ Value Help Dialog} control instead.</li> <li>You need to filter a set of items without any selection. Use the {@link https://experience.sap.com/fiori-design-web/filter-bar/ Filter Bar} control instead.</li> </ul> <h4>Notes:</h4> <ul> <li>The property <code>growing</code> must not be used together with two-way binding. <li>When the property <code>growing</code> is set to <code>true</code> (default value), the features <code>selected count</code> in info bar, <code>search</code> and <code>select/deselect all</code>, if present, work only for the currently loaded items. To make sure that all items in the table are loaded at once and the above features work properly, set the property to <code>false</code>. <li>Since version 1.58, the columns headers and the info toolbar are sticky (remain fixed on top when scrolling). This feature is not supported in all browsers. For more information on browser support limitations, you can refer to the {@link sap.m.ListBase sap.m.ListBase} <code>sticky</code> property. </ul> <h3>Responsive Behavior</h3> <ul> <li>On smaller screens, the columns of the table wrap and build a list that shows all the information.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.TableSelectDialog")]
			public partial class TableSelectDialog : sap.ui.core.Control
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
					/// Specifies the title text in the dialog header.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Specifies the text displayed when the table has no data.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> noDataText;

					/// <summary>
					/// Enables the user to select several options from the table.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> multiSelect;

					/// <summary>
					/// Determines the progressive loading. When set to <code>true</code>, enables the growing feature of the control to load more items by requesting from the bound model. <b>Note:</b> This feature only works when an <code>items</code> aggregation is bound. Growing must not be used together with two-way binding. <b>Note:</b> If the property is set to true, the features <code>selected count</code> in info bar, <code>search</code> and <code>select/deselect all</code>, if present, work only for the currently loaded items. To make sure that all items in the table are loaded at once and the above features work properly, we recommend setting the <code>growing</code> property to false.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> growing;

					/// <summary>
					/// Determines the number of items initially displayed in the table and defines the number of items to be requested from the model for each grow. This property can only be used if the property <code>growing</code> is set to <code>true</code>.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> growingThreshold;

					/// <summary>
					/// Determines the content width of the inner dialog. For more information, see the Dialog documentation.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentWidth;

					/// <summary>
					/// Controls whether the dialog clears the selection or not. When the dialog is opened multiple times in the same context to allow for corrections of previous user inputs, set this flag to "true". When the dialog should reset the selection to allow for a new selection each time set it to "false" Note: This property must be set before the Dialog is opened to have an effect.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> rememberSelections;

					/// <summary>
					/// Specifies the content height of the inner dialog. For more information, see the Dialog documentation.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentHeight;

					/// <summary>
					/// This flag controls whether the Clear button is shown. When set to <code>true</code>, it provides a way to clear a selection made in Table Select Dialog.
					/// 
					/// We recommend enabling of the Clear button in the following cases, where a mechanism to clear the value is needed: In case the Table Select Dialog is in single-selection mode (default mode) and <code>rememberSelections</code> is set to <code>true</code>. The Clear button needs to be enabled in order to allow users to clear the selection. In case of using <code>sap.m.Input</code> with <code>valueHelpOnly</code> set to <code>true</code>, the Clear button can be used for clearing the selection. In case the application stores a value and uses only Table Select Dialog to edit/maintain it.
					/// 
					/// Optional: In case <code>multiSelect</code> is set to <code>true</code>, the selection can be easily cleared with one click.
					/// 
					/// <b>Note:</b> When used with oData, only the loaded selections will be cleared.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showClearButton;

					/// <summary>
					/// The items of the table.
					/// </summary>
					public Union<sap.m.ColumnListItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// The columns bindings.
					/// </summary>
					public Union<sap.m.Column[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> columns;

					/// <summary>
					/// Fires when the dialog is confirmed by selecting an item in single-selection mode or by pressing the confirmation button in multi-selection mode. The items being selected are returned as event parameters.
					/// </summary>
					public sap.m.SelectDialog.ConfirmDelegate confirm;

					/// <summary>
					/// Fires when the search button has been clicked on dialog.
					/// </summary>
					public sap.m.SelectDialog.SearchOrLiveChangeDelegate search;

					/// <summary>
					/// Fires when the value of the search field is changed by a user (for example at each key press).
					/// </summary>
					public sap.m.SelectDialog.SearchOrLiveChangeDelegate liveChange;

					/// <summary>
					/// Fires when the Cancel button is clicked.
					/// </summary>
					public sap.ui.@base.EventDelegate cancel;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new TableSelectDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TableSelectDialog(string sId, sap.m.TableSelectDialog.Settings mSettings);

				/// <summary>
				/// Constructor for a new TableSelectDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern TableSelectDialog(string sId);

				/// <summary>
				/// Constructor for a new TableSelectDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern TableSelectDialog();

				/// <summary>
				/// Constructor for a new TableSelectDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TableSelectDialog(sap.m.TableSelectDialog.Settings mSettings);

				#endregion

				#region Fields

				/// <summary>
				/// Sets the model for the internal table and the current control, so that both controls can be used with data binding.
				/// </summary>
				public object _setModel;

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Specifies the title text in the dialog header.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets the title of the internal dialog
				/// </summary>
				/// <param name="sTitle">the title text for the dialog</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog setTitle(string sTitle);

				#endregion

				#region Methods for Property noDataText

				/// <summary>
				/// Retrieves the internal List's no data text property
				/// </summary>
				/// <returns>the current no data text</returns>
				public extern virtual string getNoDataText();

				/// <summary>
				/// Sets the no data text of the internal table
				/// </summary>
				/// <param name="sNoDataText">the no data text for the table</param>
				public extern virtual void setNoDataText(string sNoDataText);

				#endregion

				#region Methods for Property multiSelect

				/// <summary>
				/// Gets current value of property {@link #getMultiSelect multiSelect}.
				/// 
				/// Enables the user to select several options from the table.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>multiSelect</code></returns>
				public extern virtual bool getMultiSelect();

				/// <summary>
				/// Enables/Disables multi selection mode.
				/// </summary>
				/// <param name="bMulti">flag for multi selection mode</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog setMultiSelect(bool bMulti);

				#endregion

				#region Methods for Property growing

				/// <summary>
				/// Gets current value of property {@link #getGrowing growing}.
				/// 
				/// Determines the progressive loading. When set to <code>true</code>, enables the growing feature of the control to load more items by requesting from the bound model. <b>Note:</b> This feature only works when an <code>items</code> aggregation is bound. Growing must not be used together with two-way binding. <b>Note:</b> If the property is set to true, the features <code>selected count</code> in info bar, <code>search</code> and <code>select/deselect all</code>, if present, work only for the currently loaded items. To make sure that all items in the table are loaded at once and the above features work properly, we recommend setting the <code>growing</code> property to false.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>growing</code></returns>
				public extern virtual bool getGrowing();

				/// <summary>
				/// Sets the growing to the internal table
				/// </summary>
				/// <param name="bValue">Value for the table's growing.</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog setGrowing(bool bValue);

				#endregion

				#region Methods for Property growingThreshold

				/// <summary>
				/// Gets current value of property {@link #getGrowingThreshold growingThreshold}.
				/// 
				/// Determines the number of items initially displayed in the table and defines the number of items to be requested from the model for each grow. This property can only be used if the property <code>growing</code> is set to <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>growingThreshold</code></returns>
				public extern virtual int getGrowingThreshold();

				/// <summary>
				/// Sets the growing threshold to the internal table
				/// </summary>
				/// <param name="iValue">Value for the table's growing threshold.</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog setGrowingThreshold(int iValue);

				#endregion

				#region Methods for Property contentWidth

				/// <summary>
				/// Retrieves content width of the select dialog {@link sap.m.Dialog}
				/// </summary>
				/// <returns>sWidth the content width of the internal dialog</returns>
				public extern virtual sap.ui.core.CSSSize getContentWidth();

				/// <summary>
				/// Sets content width of the select dialog {@link sap.m.Dialog}
				/// </summary>
				/// <param name="sWidth">the new content width value for the dialog</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog setContentWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property rememberSelections

				/// <summary>
				/// Gets current value of property {@link #getRememberSelections rememberSelections}.
				/// 
				/// Controls whether the dialog clears the selection or not. When the dialog is opened multiple times in the same context to allow for corrections of previous user inputs, set this flag to "true". When the dialog should reset the selection to allow for a new selection each time set it to "false" Note: This property must be set before the Dialog is opened to have an effect.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>rememberSelections</code></returns>
				public extern virtual bool getRememberSelections();

				/// <summary>
				/// Sets a new value for property {@link #getRememberSelections rememberSelections}.
				/// 
				/// Controls whether the dialog clears the selection or not. When the dialog is opened multiple times in the same context to allow for corrections of previous user inputs, set this flag to "true". When the dialog should reset the selection to allow for a new selection each time set it to "false" Note: This property must be set before the Dialog is opened to have an effect.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bRememberSelections">New value for property <code>rememberSelections</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog setRememberSelections(bool bRememberSelections);

				#endregion

				#region Methods for Property contentHeight

				/// <summary>
				/// Retrieves content height of the select dialog {@link sap.m.Dialog}
				/// </summary>
				/// <returns>sHeight the content height of the internal dialog</returns>
				public extern virtual sap.ui.core.CSSSize getContentHeight();

				/// <summary>
				/// Sets content height of the select dialog {@link sap.m.Dialog}
				/// </summary>
				/// <param name="sHeight">the new content height value for the dialog</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog setContentHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property showClearButton

				/// <summary>
				/// Gets current value of property {@link #getShowClearButton showClearButton}.
				/// 
				/// This flag controls whether the Clear button is shown. When set to <code>true</code>, it provides a way to clear a selection made in Table Select Dialog.
				/// 
				/// We recommend enabling of the Clear button in the following cases, where a mechanism to clear the value is needed: In case the Table Select Dialog is in single-selection mode (default mode) and <code>rememberSelections</code> is set to <code>true</code>. The Clear button needs to be enabled in order to allow users to clear the selection. In case of using <code>sap.m.Input</code> with <code>valueHelpOnly</code> set to <code>true</code>, the Clear button can be used for clearing the selection. In case the application stores a value and uses only Table Select Dialog to edit/maintain it.
				/// 
				/// Optional: In case <code>multiSelect</code> is set to <code>true</code>, the selection can be easily cleared with one click.
				/// 
				/// <b>Note:</b> When used with oData, only the loaded selections will be cleared.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showClearButton</code></returns>
				public extern virtual bool getShowClearButton();

				/// <summary>
				/// Sets the Clear button visible state
				/// </summary>
				/// <param name="bVisible">Value for the Clear button visible state.</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog setShowClearButton(bool bVisible);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// The items of the table.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ColumnListItem[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog insertItem(sap.m.ColumnListItem oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog addItem(sap.m.ColumnListItem oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.m.ColumnListItem removeItem(Union<int, string, sap.m.ColumnListItem> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.ColumnListItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.ColumnListItem oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ColumnListItem[] removeAllItems();

				/// <summary>
				/// Binds aggregation {@link #getItems items} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog bindItems(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog unbindItems();

				#endregion

				#region Methods for Aggregation _dialog

				#endregion

				#region Methods for Aggregation columns

				/// <summary>
				/// Gets content of aggregation {@link #getColumns columns}.
				/// 
				/// The columns bindings.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Column[] getColumns();

				/// <summary>
				/// Destroys all the columns in the aggregation {@link #getColumns columns}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog destroyColumns();

				/// <summary>
				/// Inserts a column into the aggregation {@link #getColumns columns}.
				/// </summary>
				/// <param name="oColumn">The column to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the column should be inserted at; for a negative value of <code>iIndex</code>, the column is inserted at position 0; for a value greater than the current size of the aggregation, the column is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog insertColumn(sap.m.Column oColumn, int iIndex);

				/// <summary>
				/// Adds some column to the aggregation {@link #getColumns columns}.
				/// </summary>
				/// <param name="oColumn">The column to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog addColumn(sap.m.Column oColumn);

				/// <summary>
				/// Removes a column from the aggregation {@link #getColumns columns}.
				/// </summary>
				/// <param name="vColumn">The column to remove or its index or id</param>
				/// <returns>The removed column or <code>null</code></returns>
				public extern virtual sap.m.Column removeColumn(Union<int, string, sap.m.Column> vColumn);

				/// <summary>
				/// Checks for the provided <code>sap.m.Column</code> in the aggregation {@link #getColumns columns}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oColumn">The column whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfColumn(sap.m.Column oColumn);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getColumns columns}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Column[] removeAllColumns();

				/// <summary>
				/// Binds aggregation {@link #getColumns columns} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog bindColumns(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getColumns columns} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog unbindColumns();

				#endregion

				#region Methods for Event confirm

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the dialog is confirmed by selecting an item in single-selection mode or by pressing the confirmation button in multi-selection mode. The items being selected are returned as event parameters.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TableSelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachConfirm(object oData, sap.m.SelectDialog.ConfirmDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the dialog is confirmed by selecting an item in single-selection mode or by pressing the confirmation button in multi-selection mode. The items being selected are returned as event parameters.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachConfirm(object oData, sap.m.SelectDialog.ConfirmDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the dialog is confirmed by selecting an item in single-selection mode or by pressing the confirmation button in multi-selection mode. The items being selected are returned as event parameters.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachConfirm(sap.m.SelectDialog.ConfirmDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the dialog is confirmed by selecting an item in single-selection mode or by pressing the confirmation button in multi-selection mode. The items being selected are returned as event parameters.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TableSelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachConfirm(sap.m.SelectDialog.ConfirmDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:confirm confirm} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog detachConfirm(sap.m.SelectDialog.ConfirmDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:confirm confirm} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog fireConfirm(sap.m.SelectDialog.ConfirmInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:confirm confirm} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog fireConfirm();

				#endregion

				#region Methods for Event search

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the search button has been clicked on dialog.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TableSelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachSearch(object oData, sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the search button has been clicked on dialog.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachSearch(object oData, sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the search button has been clicked on dialog.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachSearch(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the search button has been clicked on dialog.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TableSelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachSearch(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:search search} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog detachSearch(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:search search} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog fireSearch(sap.m.SelectDialog.SearchOrLiveChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:search search} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog fireSearch();

				#endregion

				#region Methods for Event liveChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the value of the search field is changed by a user (for example at each key press).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TableSelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachLiveChange(object oData, sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the value of the search field is changed by a user (for example at each key press).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachLiveChange(object oData, sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the value of the search field is changed by a user (for example at each key press).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachLiveChange(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the value of the search field is changed by a user (for example at each key press).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TableSelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachLiveChange(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog detachLiveChange(sap.m.SelectDialog.SearchOrLiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog fireLiveChange(sap.m.SelectDialog.SearchOrLiveChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog fireLiveChange();

				#endregion

				#region Methods for Event cancel

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the Cancel button is clicked.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TableSelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the Cancel button is clicked.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the Cancel button is clicked.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachCancel(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TableSelectDialog</code> itself.
				/// 
				/// Fires when the Cancel button is clicked.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TableSelectDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog attachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:cancel cancel} event of this <code>sap.m.TableSelectDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog detachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:cancel cancel} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog fireCancel(object mParameters);

				/// <summary>
				/// Fires event {@link #event:cancel cancel} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog fireCancel();

				#endregion

				#region Other methods

				/// <summary>
				/// Transfers method to the inner dialog: addStyleClass
				/// </summary>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog addStyleClass();

				/// <summary>
				/// Creates a new subclass of class sap.m.TableSelectDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TableSelectDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TableSelectDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Gets current busy state.
				/// </summary>
				/// <returns>value of currtent busy state.</returns>
				public extern override bool getBusy();

				/// <summary>
				/// Transfers method to the inner dialog: getDomRef
				/// </summary>
				/// <returns>The Element's DOM Element sub DOM Element or null</returns>
				public extern virtual Retyped.dom.HTMLElement getDomRef();

				/// <summary>
				/// Returns a metadata object for class sap.m.TableSelectDialog.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Transfers method to the inner dialog: hasStyleClass
				/// </summary>
				/// <returns>true if the class is set, false otherwise</returns>
				public extern virtual bool hasStyleClass();

				/// <summary>
				/// Invalidates the dialog instead of this control, as there is no renderer.
				/// </summary>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog invalidate();

				/// <summary>
				/// Shows the busy state and is called after the renderer is finished.
				/// </summary>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog onAfterRendering();

				/// <summary>
				/// Opens the internal dialog with a searchfield and a table.
				/// </summary>
				/// <param name="sSearchValue">Value for the search. The table will be automatically trigger the search event if this parameter is set.</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.TableSelectDialog open(string sSearchValue);

				/// <summary>
				/// Transfers method to the inner dialog: removeStyleClass
				/// </summary>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog removeStyleClass();

				/// <summary>
				/// Enables/Disables busy state.
				/// </summary>
				/// <param name="flag">for enabling busy indicator</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog setBusy(bool flag);

				/// <summary>
				/// Sets the busyIndicatorDelay value to the internal table
				/// </summary>
				/// <param name="iValue">Value for the busyIndicatorDelay.</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog setBusyIndicatorDelay(int iValue);

				/// <summary>
				/// Transfers method to the inner dialog: toggleStyleClass
				/// </summary>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TableSelectDialog toggleStyleClass();

				#endregion

				#endregion

			}
		}
	}
}
