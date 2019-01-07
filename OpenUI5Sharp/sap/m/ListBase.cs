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
			/// The <code>sap.m.ListBase</code> control provides a base functionality of the <code>sap.m.List</code> and <code>sap.m.Table</code> controls. Selection, deletion, unread states and inset style are also maintained in <code>sap.m.ListBase</code>.
			/// 
			/// See section "{@link topic:295e44b2d0144318bcb7bdd56bfa5189 List, List Item, and Table}" in the documentation for an introduction to subclasses of <code>sap.m.ListBase</code> control.
			/// 
			/// <b>Note:</b> The ListBase including all contained items may be completely re-rendered when the data of a bound model is changed. Due to the limited hardware resources of mobile devices this can lead to longer delays for lists that contain many items. As such the usage of a list is not recommended for these use cases.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ListBase")]
			public partial class ListBase : sap.ui.core.Control
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
					/// Defines the indentation of the container. Setting it to <code>true</code> indents the list.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> inset;

					/// <summary>
					/// Defines the header text that appears in the control. <b>Note:</b> If <code>headerToolbar</code> aggregation is set, then this property is ignored.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerText;

					/// <summary>
					/// Defines the header style of the control. Possible values are <code>Standard</code> and <code>Plain</code>.
					/// </summary>
					public Union<sap.m.ListHeaderDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerDesign;

					/// <summary>
					/// Defines the footer text that appears in the control.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> footerText;

					/// <summary>
					/// Defines the mode of the control (e.g. <code>None</code>, <code>SingleSelect</code>, <code>MultiSelect</code>, <code>Delete</code>).
					/// </summary>
					public Union<sap.m.ListMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> mode;

					/// <summary>
					/// Sets the width of the control.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Defines whether the items are selectable by clicking on the item itself (<code>true</code>) rather than having to set the selection control first. <b>Note:</b> The <code>SingleSelectMaster</code> mode also provides this functionality by default.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> includeItemInSelection;

					/// <summary>
					/// Activates the unread indicator for all items, if set to <code>true</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showUnread;

					/// <summary>
					/// This text is displayed when the control contains no items.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> noDataText;

					/// <summary>
					/// Defines whether or not the text specified in the <code>noDataText</code> property is displayed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showNoData;

					/// <summary>
					/// When this property is set to <code>true</code>, the control will automatically display a busy indicator when it detects that data is being loaded. This busy indicator blocks the interaction with the items until data loading is finished. By default, the busy indicator will be shown after one second. This behavior can be customized by setting the <code>busyIndicatorDelay</code> property.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableBusyIndicator;

					/// <summary>
					/// Defines if animations will be shown while switching between modes.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> modeAnimationOn;

					/// <summary>
					/// Defines which item separator style will be used.
					/// </summary>
					public Union<sap.m.ListSeparators, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSeparators;

					/// <summary>
					/// Defines the direction of the swipe movement (e.g LeftToRight, RightToLeft, Both) to display the control defined in the <code>swipeContent</code> aggregation.
					/// </summary>
					public Union<sap.m.SwipeDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> swipeDirection;

					/// <summary>
					/// If set to <code>true</code>, enables the growing feature of the control to load more items by requesting from the model. <b>Note:</b>: This feature only works when an <code>items</code> aggregation is bound. Growing must not be used together with two-way binding.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> growing;

					/// <summary>
					/// Defines the number of items to be requested from the model for each grow. This property can only be used if the <code>growing</code> property is set to <code>true</code>.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> growingThreshold;

					/// <summary>
					/// Defines the text displayed on the growing button. The default is a translated text ("More") coming from the message bundle. This property can only be used if the <code>growing</code> property is set to <code>true</code>.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> growingTriggerText;

					/// <summary>
					/// If set to true, the user can scroll down/up to load more items. Otherwise a growing button is displayed at the bottom/top of the control. <b>Note:</b> This property can only be used if the <code>growing</code> property is set to <code>true</code> and only if there is one instance of <code>sap.m.List</code> or <code>sap.m.Table</code> inside the scrollable scroll container (e.g <code>sap.m.Page</code>).
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> growingScrollToLoad;

					/// <summary>
					/// Defines the direction of the growing feature. If set to <code>Downwards</code> the user has to scroll down to load more items or the growing button is displayed at the bottom. If set to <code>Upwards</code> the user has to scroll up to load more items or the growing button is displayed at the top.
					/// </summary>
					public Union<sap.m.ListGrowingDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> growingDirection;

					/// <summary>
					/// If set to true, this control remembers and retains the selection of the items after a binding update has been performed (e.g. sorting, filtering). <b>Note:</b> This feature works only if two-way data binding for the <code>selected</code> property of the item is not used. It also needs to be turned off if the binding context of the item does not always point to the same entry in the model, for example, if the order of the data in the <code>JSONModel</code> is changed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> rememberSelections;

					/// <summary>
					/// Defines keyboard handling behavior of the control.
					/// </summary>
					public Union<sap.m.ListKeyboardMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> keyboardMode;

					/// <summary>
					/// Defines the section of the control that remains fixed at the top of the page during vertical scrolling as long as the control is in the viewport.
					/// 
					/// <b>Note:</b> Enabling sticky column headers in List controls will not have any effect.
					/// 
					/// There is limited browser support. Browsers that do not support this feature are listed below: <ul> <li>IE</li> <li>Edge lower than version 41 (EdgeHTML 16)</li> <li>Firefox lower than version 59</li> </ul>
					/// 
					/// There are also some known limitations with respect to the scrolling behavior. A few are given below: <ul> <li>If the control is placed in certain layout containers, for example, the <code>sap.ui.layout.Grid</code> control, the sticky elements of the control are not fixed at the top of the viewport. The control behaves in a similar way when placed within the <code>sap.m.ObjectPage</code> control.</li> <li>If sticky column headers are enabled in the <code>sap.m.Table</code> control, setting focus on the column headers will let the table scroll to the top.</li> </ul>
					/// </summary>
					public Union<sap.m.Sticky[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> sticky;

					/// <summary>
					/// Defines the items contained within this control.
					/// </summary>
					public Union<sap.m.ListItemBase[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// User can swipe to bring in this control on the right hand side of an item. <b>Note:</b> For non-touch devices, this functionality is ignored.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> swipeContent;

					/// <summary>
					/// The header area can be used as a toolbar to add extra controls for user interactions. <b>Note:</b> When set, this overwrites the <code>headerText</code> property.
					/// </summary>
					public Union<sap.m.Toolbar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerToolbar;

					/// <summary>
					/// A toolbar that is placed below the header to show extra information to the user.
					/// </summary>
					public Union<sap.m.Toolbar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> infoToolbar;

					/// <summary>
					/// Defines the context menu of the items.
					/// </summary>
					public Union<sap.ui.core.IContextMenu, string, sap.ui.@base.ManagedObject.BindAggregationInfo> contextMenu;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Fires when selection is changed via user interaction. In <code>MultiSelect</code> mode, this event is also fired on deselection.
					/// </summary>
					public sap.m.ListBase.EventDelegate select;

					/// <summary>
					/// Fires when selection is changed via user interaction inside the control.
					/// </summary>
					public sap.m.ListBase.SelectionChangeDelegate selectionChange;

					/// <summary>
					/// Fires when delete icon is pressed by user.
					/// </summary>
					public sap.m.ListBase.EventDelegate delete;

					/// <summary>
					/// Fires after us"r's swipe action and before the <code>swipeContent</code> is shown. On the <code>swipe</code> event handler, <code>swipeContent</code> can be changed according to the swiped item. Calling the <code>preventDefault</code> method of the event cancels the swipe action.
					/// </summary>
					public sap.m.ListBase.SwipeDelegate swipe;

					/// <summary>
					/// Fires before the new growing chunk is requested from the model.
					/// </summary>
					public sap.m.ListBase.GrowingDelegate growingStarted;

					/// <summary>
					/// Fires after the new growing chunk has been fetched from the model and processed by the control.
					/// </summary>
					public sap.m.ListBase.GrowingDelegate growingFinished;

					/// <summary>
					/// Fires before <code>items</code> binding is updated (e.g. sorting, filtering)
					/// 
					/// <b>Note:</b> Event handler should not invalidate the control.
					/// </summary>
					public sap.m.ListBase.UpdateDelegate updateStarted;

					/// <summary>
					/// Fires after <code>items</code> binding is updated and processed by the control.
					/// </summary>
					public sap.m.ListBase.UpdateDelegate updateFinished;

					/// <summary>
					/// Fires when an item is pressed unless the item's <code>type</code> property is <code>Inactive</code>.
					/// </summary>
					public sap.m.ListBase.ItemPressDelegate itemPress;

					/// <summary>
					/// Fired when the context menu is opened. When the context menu is opened, the binding context of the item is set to the given <code>contextMenu</code>.
					/// </summary>
					public sap.m.ListBase.EventDelegate beforeOpenContextMenu;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class EventInfo
				{
					/// <summary>
					/// Item in which the context menu was opened.
					/// </summary>
					public sap.m.ListItemBase listItem;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class GrowingInfo
				{
					/// <summary>
					/// Actual number of items.
					/// </summary>
					public int actual;

					/// <summary>
					/// Total number of items.
					/// </summary>
					public int total;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ItemPressInfo
				{
					/// <summary>
					/// The item which fired the pressed event.
					/// </summary>
					public sap.m.ListItemBase listItem;

					/// <summary>
					/// The control which caused the press event within the container.
					/// </summary>
					public sap.ui.core.Control srcControl;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SelectionChangeInfo
				{
					/// <summary>
					/// The item whose selection has changed. In <code>MultiSelect</code> mode, only the up-most selected item is returned. This parameter can be used for single-selection modes.
					/// </summary>
					public sap.m.ListItemBase listItem;

					/// <summary>
					/// Array of items whose selection has changed. This parameter can be used for <code>MultiSelect</code> mode.
					/// </summary>
					public sap.m.ListItemBase[] listItems;

					/// <summary>
					/// Indicates whether the <code>listItem</code> parameter is selected or not.
					/// </summary>
					public bool selected;

					/// <summary>
					/// Indicates whether the select all action is triggered or not.
					/// </summary>
					public bool selectAll;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SwipeInfo
				{
					/// <summary>
					/// The item which fired the swipe.
					/// </summary>
					public sap.m.ListItemBase listItem;

					/// <summary>
					/// Aggregated <code>swipeContent</code> control that is shown on the right hand side of the item.
					/// </summary>
					public sap.ui.core.Control swipeContent;

					/// <summary>
					/// Holds which control caused the swipe event within the item.
					/// </summary>
					public sap.ui.core.Control srcControl;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class UpdateInfo
				{
					/// <summary>
					/// The reason of the update, e.g. Binding, Filter, Sort, Growing, Change, Refresh, Context.
					/// </summary>
					public string reason;

					/// <summary>
					/// Actual number of items.
					/// </summary>
					public int actual;

					/// <summary>
					/// The total count of bound items. This can be used if the <code>growing</code> property is set to <code>true</code>.
					/// </summary>
					public int total;

				}

				#endregion

				#region Delegates

				public delegate void EventDelegate(sap.ui.@base.Event<sap.m.ListBase.EventInfo> oEvent, object oData);

				public delegate void GrowingDelegate(sap.ui.@base.Event<sap.m.ListBase.GrowingInfo> oEvent, object oData);

				public delegate void ItemPressDelegate(sap.ui.@base.Event<sap.m.ListBase.ItemPressInfo> oEvent, object oData);

				public delegate void SelectionChangeDelegate(sap.ui.@base.Event<sap.m.ListBase.SelectionChangeInfo> oEvent, object oData);

				public delegate void SwipeDelegate(sap.ui.@base.Event<sap.m.ListBase.SwipeInfo> oEvent, object oData);

				public delegate void UpdateDelegate(sap.ui.@base.Event<sap.m.ListBase.UpdateInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ListBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ListBase(string sId, sap.m.ListBase.Settings mSettings);

				/// <summary>
				/// Constructor for a new ListBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				public extern ListBase(string sId);

				/// <summary>
				/// Constructor for a new ListBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ListBase();

				/// <summary>
				/// Constructor for a new ListBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ListBase(sap.m.ListBase.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property inset

				/// <summary>
				/// Gets current value of property {@link #getInset inset}.
				/// 
				/// Defines the indentation of the container. Setting it to <code>true</code> indents the list.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>inset</code></returns>
				public extern virtual bool getInset();

				/// <summary>
				/// Sets a new value for property {@link #getInset inset}.
				/// 
				/// Defines the indentation of the container. Setting it to <code>true</code> indents the list.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bInset">New value for property <code>inset</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setInset(bool bInset);

				#endregion

				#region Methods for Property headerText

				/// <summary>
				/// Gets current value of property {@link #getHeaderText headerText}.
				/// 
				/// Defines the header text that appears in the control. <b>Note:</b> If <code>headerToolbar</code> aggregation is set, then this property is ignored.
				/// </summary>
				/// <returns>Value of property <code>headerText</code></returns>
				public extern virtual string getHeaderText();

				/// <summary>
				/// Sets a new value for property {@link #getHeaderText headerText}.
				/// 
				/// Defines the header text that appears in the control. <b>Note:</b> If <code>headerToolbar</code> aggregation is set, then this property is ignored.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHeaderText">New value for property <code>headerText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setHeaderText(string sHeaderText);

				#endregion

				#region Methods for Property headerDesign

				/// <summary>
				/// Gets current value of property {@link #getHeaderDesign headerDesign}.
				/// 
				/// Defines the header style of the control. Possible values are <code>Standard</code> and <code>Plain</code>.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <returns>Value of property <code>headerDesign</code></returns>
				[Obsolete("Deprecated since 1.16. No longer has any functionality.")]
				public extern virtual sap.m.ListHeaderDesign getHeaderDesign();

				/// <summary>
				/// Sets a new value for property {@link #getHeaderDesign headerDesign}.
				/// 
				/// Defines the header style of the control. Possible values are <code>Standard</code> and <code>Plain</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <param name="sHeaderDesign">New value for property <code>headerDesign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16. No longer has any functionality.")]
				public extern virtual sap.m.ListBase setHeaderDesign(sap.m.ListHeaderDesign sHeaderDesign);

				#endregion

				#region Methods for Property footerText

				/// <summary>
				/// Gets current value of property {@link #getFooterText footerText}.
				/// 
				/// Defines the footer text that appears in the control.
				/// </summary>
				/// <returns>Value of property <code>footerText</code></returns>
				public extern virtual string getFooterText();

				/// <summary>
				/// Sets a new value for property {@link #getFooterText footerText}.
				/// 
				/// Defines the footer text that appears in the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sFooterText">New value for property <code>footerText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setFooterText(string sFooterText);

				#endregion

				#region Methods for Property mode

				/// <summary>
				/// Gets current value of property {@link #getMode mode}.
				/// 
				/// Defines the mode of the control (e.g. <code>None</code>, <code>SingleSelect</code>, <code>MultiSelect</code>, <code>Delete</code>).
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>mode</code></returns>
				public extern virtual sap.m.ListMode getMode();

				/// <summary>
				/// Sets a new value for property {@link #getMode mode}.
				/// 
				/// Defines the mode of the control (e.g. <code>None</code>, <code>SingleSelect</code>, <code>MultiSelect</code>, <code>Delete</code>).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sMode">New value for property <code>mode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setMode(sap.m.ListMode sMode);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Sets the width of the control.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Sets the width of the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property includeItemInSelection

				/// <summary>
				/// Gets current value of property {@link #getIncludeItemInSelection includeItemInSelection}.
				/// 
				/// Defines whether the items are selectable by clicking on the item itself (<code>true</code>) rather than having to set the selection control first. <b>Note:</b> The <code>SingleSelectMaster</code> mode also provides this functionality by default.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>includeItemInSelection</code></returns>
				public extern virtual bool getIncludeItemInSelection();

				/// <summary>
				/// Sets a new value for property {@link #getIncludeItemInSelection includeItemInSelection}.
				/// 
				/// Defines whether the items are selectable by clicking on the item itself (<code>true</code>) rather than having to set the selection control first. <b>Note:</b> The <code>SingleSelectMaster</code> mode also provides this functionality by default.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bIncludeItemInSelection">New value for property <code>includeItemInSelection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setIncludeItemInSelection(bool bIncludeItemInSelection);

				#endregion

				#region Methods for Property showUnread

				/// <summary>
				/// Gets current value of property {@link #getShowUnread showUnread}.
				/// 
				/// Activates the unread indicator for all items, if set to <code>true</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showUnread</code></returns>
				public extern virtual bool getShowUnread();

				/// <summary>
				/// Sets a new value for property {@link #getShowUnread showUnread}.
				/// 
				/// Activates the unread indicator for all items, if set to <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowUnread">New value for property <code>showUnread</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setShowUnread(bool bShowUnread);

				#endregion

				#region Methods for Property noDataText

				/// <summary>
				/// Gets current value of property {@link #getNoDataText noDataText}.
				/// 
				/// This text is displayed when the control contains no items.
				/// </summary>
				/// <returns>Value of property <code>noDataText</code></returns>
				public extern virtual string getNoDataText();

				/// <summary>
				/// Sets a new value for property {@link #getNoDataText noDataText}.
				/// 
				/// This text is displayed when the control contains no items.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sNoDataText">New value for property <code>noDataText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setNoDataText(string sNoDataText);

				#endregion

				#region Methods for Property showNoData

				/// <summary>
				/// Gets current value of property {@link #getShowNoData showNoData}.
				/// 
				/// Defines whether or not the text specified in the <code>noDataText</code> property is displayed.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showNoData</code></returns>
				public extern virtual bool getShowNoData();

				/// <summary>
				/// Sets a new value for property {@link #getShowNoData showNoData}.
				/// 
				/// Defines whether or not the text specified in the <code>noDataText</code> property is displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowNoData">New value for property <code>showNoData</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setShowNoData(bool bShowNoData);

				#endregion

				#region Methods for Property enableBusyIndicator

				/// <summary>
				/// Gets current value of property {@link #getEnableBusyIndicator enableBusyIndicator}.
				/// 
				/// When this property is set to <code>true</code>, the control will automatically display a busy indicator when it detects that data is being loaded. This busy indicator blocks the interaction with the items until data loading is finished. By default, the busy indicator will be shown after one second. This behavior can be customized by setting the <code>busyIndicatorDelay</code> property.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enableBusyIndicator</code></returns>
				public extern virtual bool getEnableBusyIndicator();

				/// <summary>
				/// Sets a new value for property {@link #getEnableBusyIndicator enableBusyIndicator}.
				/// 
				/// When this property is set to <code>true</code>, the control will automatically display a busy indicator when it detects that data is being loaded. This busy indicator blocks the interaction with the items until data loading is finished. By default, the busy indicator will be shown after one second. This behavior can be customized by setting the <code>busyIndicatorDelay</code> property.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnableBusyIndicator">New value for property <code>enableBusyIndicator</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setEnableBusyIndicator(bool bEnableBusyIndicator);

				#endregion

				#region Methods for Property modeAnimationOn

				/// <summary>
				/// Gets current value of property {@link #getModeAnimationOn modeAnimationOn}.
				/// 
				/// Defines if animations will be shown while switching between modes.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>modeAnimationOn</code></returns>
				public extern virtual bool getModeAnimationOn();

				/// <summary>
				/// Sets a new value for property {@link #getModeAnimationOn modeAnimationOn}.
				/// 
				/// Defines if animations will be shown while switching between modes.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bModeAnimationOn">New value for property <code>modeAnimationOn</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setModeAnimationOn(bool bModeAnimationOn);

				#endregion

				#region Methods for Property showSeparators

				/// <summary>
				/// Gets current value of property {@link #getShowSeparators showSeparators}.
				/// 
				/// Defines which item separator style will be used.
				/// 
				/// Default value is <code>All</code>.
				/// </summary>
				/// <returns>Value of property <code>showSeparators</code></returns>
				public extern virtual sap.m.ListSeparators getShowSeparators();

				/// <summary>
				/// Sets a new value for property {@link #getShowSeparators showSeparators}.
				/// 
				/// Defines which item separator style will be used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>All</code>.
				/// </summary>
				/// <param name="sShowSeparators">New value for property <code>showSeparators</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setShowSeparators(sap.m.ListSeparators sShowSeparators);

				#endregion

				#region Methods for Property swipeDirection

				/// <summary>
				/// Gets current value of property {@link #getSwipeDirection swipeDirection}.
				/// 
				/// Defines the direction of the swipe movement (e.g LeftToRight, RightToLeft, Both) to display the control defined in the <code>swipeContent</code> aggregation.
				/// 
				/// Default value is <code>Both</code>.
				/// </summary>
				/// <returns>Value of property <code>swipeDirection</code></returns>
				public extern virtual sap.m.SwipeDirection getSwipeDirection();

				/// <summary>
				/// Sets a new value for property {@link #getSwipeDirection swipeDirection}.
				/// 
				/// Defines the direction of the swipe movement (e.g LeftToRight, RightToLeft, Both) to display the control defined in the <code>swipeContent</code> aggregation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Both</code>.
				/// </summary>
				/// <param name="sSwipeDirection">New value for property <code>swipeDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setSwipeDirection(sap.m.SwipeDirection sSwipeDirection);

				#endregion

				#region Methods for Property growing

				/// <summary>
				/// Gets current value of property {@link #getGrowing growing}.
				/// 
				/// If set to <code>true</code>, enables the growing feature of the control to load more items by requesting from the model. <b>Note:</b>: This feature only works when an <code>items</code> aggregation is bound. Growing must not be used together with two-way binding.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>growing</code></returns>
				public extern virtual bool getGrowing();

				/// <summary>
				/// Sets a new value for property {@link #getGrowing growing}.
				/// 
				/// If set to <code>true</code>, enables the growing feature of the control to load more items by requesting from the model. <b>Note:</b>: This feature only works when an <code>items</code> aggregation is bound. Growing must not be used together with two-way binding.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bGrowing">New value for property <code>growing</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setGrowing(bool bGrowing);

				#endregion

				#region Methods for Property growingThreshold

				/// <summary>
				/// Gets current value of property {@link #getGrowingThreshold growingThreshold}.
				/// 
				/// Defines the number of items to be requested from the model for each grow. This property can only be used if the <code>growing</code> property is set to <code>true</code>.
				/// 
				/// Default value is <code>20</code>.
				/// </summary>
				/// <returns>Value of property <code>growingThreshold</code></returns>
				public extern virtual int getGrowingThreshold();

				/// <summary>
				/// Sets a new value for property {@link #getGrowingThreshold growingThreshold}.
				/// 
				/// Defines the number of items to be requested from the model for each grow. This property can only be used if the <code>growing</code> property is set to <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>20</code>.
				/// </summary>
				/// <param name="iGrowingThreshold">New value for property <code>growingThreshold</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setGrowingThreshold(int iGrowingThreshold);

				#endregion

				#region Methods for Property growingTriggerText

				/// <summary>
				/// Gets current value of property {@link #getGrowingTriggerText growingTriggerText}.
				/// 
				/// Defines the text displayed on the growing button. The default is a translated text ("More") coming from the message bundle. This property can only be used if the <code>growing</code> property is set to <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>growingTriggerText</code></returns>
				public extern virtual string getGrowingTriggerText();

				/// <summary>
				/// Sets a new value for property {@link #getGrowingTriggerText growingTriggerText}.
				/// 
				/// Defines the text displayed on the growing button. The default is a translated text ("More") coming from the message bundle. This property can only be used if the <code>growing</code> property is set to <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sGrowingTriggerText">New value for property <code>growingTriggerText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setGrowingTriggerText(string sGrowingTriggerText);

				#endregion

				#region Methods for Property growingScrollToLoad

				/// <summary>
				/// Gets current value of property {@link #getGrowingScrollToLoad growingScrollToLoad}.
				/// 
				/// If set to true, the user can scroll down/up to load more items. Otherwise a growing button is displayed at the bottom/top of the control. <b>Note:</b> This property can only be used if the <code>growing</code> property is set to <code>true</code> and only if there is one instance of <code>sap.m.List</code> or <code>sap.m.Table</code> inside the scrollable scroll container (e.g <code>sap.m.Page</code>).
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>growingScrollToLoad</code></returns>
				public extern virtual bool getGrowingScrollToLoad();

				/// <summary>
				/// Sets a new value for property {@link #getGrowingScrollToLoad growingScrollToLoad}.
				/// 
				/// If set to true, the user can scroll down/up to load more items. Otherwise a growing button is displayed at the bottom/top of the control. <b>Note:</b> This property can only be used if the <code>growing</code> property is set to <code>true</code> and only if there is one instance of <code>sap.m.List</code> or <code>sap.m.Table</code> inside the scrollable scroll container (e.g <code>sap.m.Page</code>).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bGrowingScrollToLoad">New value for property <code>growingScrollToLoad</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setGrowingScrollToLoad(bool bGrowingScrollToLoad);

				#endregion

				#region Methods for Property growingDirection

				/// <summary>
				/// Gets current value of property {@link #getGrowingDirection growingDirection}.
				/// 
				/// Defines the direction of the growing feature. If set to <code>Downwards</code> the user has to scroll down to load more items or the growing button is displayed at the bottom. If set to <code>Upwards</code> the user has to scroll up to load more items or the growing button is displayed at the top.
				/// 
				/// Default value is <code>Downwards</code>.
				/// </summary>
				/// <returns>Value of property <code>growingDirection</code></returns>
				public extern virtual sap.m.ListGrowingDirection getGrowingDirection();

				/// <summary>
				/// Sets a new value for property {@link #getGrowingDirection growingDirection}.
				/// 
				/// Defines the direction of the growing feature. If set to <code>Downwards</code> the user has to scroll down to load more items or the growing button is displayed at the bottom. If set to <code>Upwards</code> the user has to scroll up to load more items or the growing button is displayed at the top.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Downwards</code>.
				/// </summary>
				/// <param name="sGrowingDirection">New value for property <code>growingDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setGrowingDirection(sap.m.ListGrowingDirection sGrowingDirection);

				#endregion

				#region Methods for Property rememberSelections

				/// <summary>
				/// Gets current value of property {@link #getRememberSelections rememberSelections}.
				/// 
				/// If set to true, this control remembers and retains the selection of the items after a binding update has been performed (e.g. sorting, filtering). <b>Note:</b> This feature works only if two-way data binding for the <code>selected</code> property of the item is not used. It also needs to be turned off if the binding context of the item does not always point to the same entry in the model, for example, if the order of the data in the <code>JSONModel</code> is changed.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>rememberSelections</code></returns>
				public extern virtual bool getRememberSelections();

				/// <summary>
				/// Sets a new value for property {@link #getRememberSelections rememberSelections}.
				/// 
				/// If set to true, this control remembers and retains the selection of the items after a binding update has been performed (e.g. sorting, filtering). <b>Note:</b> This feature works only if two-way data binding for the <code>selected</code> property of the item is not used. It also needs to be turned off if the binding context of the item does not always point to the same entry in the model, for example, if the order of the data in the <code>JSONModel</code> is changed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bRememberSelections">New value for property <code>rememberSelections</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setRememberSelections(bool bRememberSelections);

				#endregion

				#region Methods for Property keyboardMode

				/// <summary>
				/// Gets current value of property {@link #getKeyboardMode keyboardMode}.
				/// 
				/// Defines keyboard handling behavior of the control.
				/// 
				/// Default value is <code>Navigation</code>.
				/// </summary>
				/// <returns>Value of property <code>keyboardMode</code></returns>
				public extern virtual sap.m.ListKeyboardMode getKeyboardMode();

				/// <summary>
				/// Sets a new value for property {@link #getKeyboardMode keyboardMode}.
				/// 
				/// Defines keyboard handling behavior of the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Navigation</code>.
				/// </summary>
				/// <param name="sKeyboardMode">New value for property <code>keyboardMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setKeyboardMode(sap.m.ListKeyboardMode sKeyboardMode);

				#endregion

				#region Methods for Property sticky

				/// <summary>
				/// Gets current value of property {@link #getSticky sticky}.
				/// 
				/// Defines the section of the control that remains fixed at the top of the page during vertical scrolling as long as the control is in the viewport.
				/// 
				/// <b>Note:</b> Enabling sticky column headers in List controls will not have any effect.
				/// 
				/// There is limited browser support. Browsers that do not support this feature are listed below: <ul> <li>IE</li> <li>Edge lower than version 41 (EdgeHTML 16)</li> <li>Firefox lower than version 59</li> </ul>
				/// 
				/// There are also some known limitations with respect to the scrolling behavior. A few are given below: <ul> <li>If the control is placed in certain layout containers, for example, the <code>sap.ui.layout.Grid</code> control, the sticky elements of the control are not fixed at the top of the viewport. The control behaves in a similar way when placed within the <code>sap.m.ObjectPage</code> control.</li> <li>If sticky column headers are enabled in the <code>sap.m.Table</code> control, setting focus on the column headers will let the table scroll to the top.</li> </ul>
				/// </summary>
				/// <returns>Value of property <code>sticky</code></returns>
				public extern virtual sap.m.Sticky[] getSticky();

				/// <summary>
				/// Sets a new value for property {@link #getSticky sticky}.
				/// 
				/// Defines the section of the control that remains fixed at the top of the page during vertical scrolling as long as the control is in the viewport.
				/// 
				/// <b>Note:</b> Enabling sticky column headers in List controls will not have any effect.
				/// 
				/// There is limited browser support. Browsers that do not support this feature are listed below: <ul> <li>IE</li> <li>Edge lower than version 41 (EdgeHTML 16)</li> <li>Firefox lower than version 59</li> </ul>
				/// 
				/// There are also some known limitations with respect to the scrolling behavior. A few are given below: <ul> <li>If the control is placed in certain layout containers, for example, the <code>sap.ui.layout.Grid</code> control, the sticky elements of the control are not fixed at the top of the viewport. The control behaves in a similar way when placed within the <code>sap.m.ObjectPage</code> control.</li> <li>If sticky column headers are enabled in the <code>sap.m.Table</code> control, setting focus on the column headers will let the table scroll to the top.</li> </ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sSticky">New value for property <code>sticky</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setSticky(sap.m.Sticky[] sSticky);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// Defines the items contained within this control.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ListItemBase[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase insertItem(sap.m.ListItemBase oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase addItem(sap.m.ListItemBase oItem);

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

				/// <summary>
				/// Binds aggregation {@link #getItems items} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase bindItems(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase unbindItems();

				#endregion

				#region Methods for Aggregation swipeContent

				/// <summary>
				/// Gets content of aggregation {@link #getSwipeContent swipeContent}.
				/// 
				/// User can swipe to bring in this control on the right hand side of an item. <b>Note:</b> For non-touch devices, this functionality is ignored.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getSwipeContent();

				/// <summary>
				/// Destroys the swipeContent in the aggregation {@link #getSwipeContent swipeContent}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase destroySwipeContent();

				/// <summary>
				/// Sets the aggregated {@link #getSwipeContent swipeContent}.
				/// </summary>
				/// <param name="oSwipeContent">The swipeContent to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setSwipeContent(sap.ui.core.Control oSwipeContent);

				#endregion

				#region Methods for Aggregation headerToolbar

				/// <summary>
				/// Gets content of aggregation {@link #getHeaderToolbar headerToolbar}.
				/// 
				/// The header area can be used as a toolbar to add extra controls for user interactions. <b>Note:</b> When set, this overwrites the <code>headerText</code> property.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Toolbar getHeaderToolbar();

				/// <summary>
				/// Destroys the headerToolbar in the aggregation {@link #getHeaderToolbar headerToolbar}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase destroyHeaderToolbar();

				/// <summary>
				/// Sets the aggregated {@link #getHeaderToolbar headerToolbar}.
				/// </summary>
				/// <param name="oHeaderToolbar">The headerToolbar to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setHeaderToolbar(sap.m.Toolbar oHeaderToolbar);

				#endregion

				#region Methods for Aggregation infoToolbar

				/// <summary>
				/// Gets content of aggregation {@link #getInfoToolbar infoToolbar}.
				/// 
				/// A toolbar that is placed below the header to show extra information to the user.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Toolbar getInfoToolbar();

				/// <summary>
				/// Destroys the infoToolbar in the aggregation {@link #getInfoToolbar infoToolbar}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase destroyInfoToolbar();

				/// <summary>
				/// Sets the aggregated {@link #getInfoToolbar infoToolbar}.
				/// </summary>
				/// <param name="oInfoToolbar">The infoToolbar to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setInfoToolbar(sap.m.Toolbar oInfoToolbar);

				#endregion

				#region Methods for Aggregation contextMenu

				/// <summary>
				/// Gets content of aggregation {@link #getContextMenu contextMenu}.
				/// 
				/// Defines the context menu of the items.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.IContextMenu getContextMenu();

				/// <summary>
				/// Destroys the contextMenu in the aggregation {@link #getContextMenu contextMenu}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase destroyContextMenu();

				/// <summary>
				/// Sets the aggregated {@link #getContextMenu contextMenu}.
				/// </summary>
				/// <param name="oContextMenu">The contextMenu to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase setContextMenu(sap.ui.core.IContextMenu oContextMenu);

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
				public extern virtual sap.m.ListBase addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event select

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when selection is changed via user interaction. In <code>MultiSelect</code> mode, this event is also fired on deselection.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16. Use the <code>selectionChange</code> event instead.")]
				public extern virtual sap.m.ListBase attachSelect(object oData, sap.m.ListBase.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when selection is changed via user interaction. In <code>MultiSelect</code> mode, this event is also fired on deselection.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16. Use the <code>selectionChange</code> event instead.")]
				public extern virtual sap.m.ListBase attachSelect(object oData, sap.m.ListBase.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when selection is changed via user interaction. In <code>MultiSelect</code> mode, this event is also fired on deselection.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16. Use the <code>selectionChange</code> event instead.")]
				public extern virtual sap.m.ListBase attachSelect(sap.m.ListBase.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when selection is changed via user interaction. In <code>MultiSelect</code> mode, this event is also fired on deselection.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16. Use the <code>selectionChange</code> event instead.")]
				public extern virtual sap.m.ListBase attachSelect(sap.m.ListBase.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.m.ListBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16. Use the <code>selectionChange</code> event instead.")]
				public extern virtual sap.m.ListBase detachSelect(sap.m.ListBase.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16. Use the <code>selectionChange</code> event instead.")]
				public extern virtual sap.m.ListBase fireSelect(sap.m.ListBase.EventInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16. Use the <code>selectionChange</code> event instead.")]
				public extern virtual sap.m.ListBase fireSelect();

				#endregion

				#region Methods for Event selectionChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when selection is changed via user interaction inside the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachSelectionChange(object oData, sap.m.ListBase.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when selection is changed via user interaction inside the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachSelectionChange(object oData, sap.m.ListBase.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when selection is changed via user interaction inside the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachSelectionChange(sap.m.ListBase.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when selection is changed via user interaction inside the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachSelectionChange(sap.m.ListBase.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:selectionChange selectionChange} event of this <code>sap.m.ListBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase detachSelectionChange(sap.m.ListBase.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase fireSelectionChange(sap.m.ListBase.SelectionChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase fireSelectionChange();

				#endregion

				#region Methods for Event delete

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:delete delete} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when delete icon is pressed by user.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachDelete(object oData, sap.m.ListBase.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:delete delete} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when delete icon is pressed by user.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachDelete(object oData, sap.m.ListBase.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:delete delete} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when delete icon is pressed by user.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachDelete(sap.m.ListBase.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:delete delete} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when delete icon is pressed by user.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachDelete(sap.m.ListBase.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:delete delete} event of this <code>sap.m.ListBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase detachDelete(sap.m.ListBase.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:delete delete} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase fireDelete(sap.m.ListBase.EventInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:delete delete} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase fireDelete();

				#endregion

				#region Methods for Event swipe

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:swipe swipe} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after us"r's swipe action and before the <code>swipeContent</code> is shown. On the <code>swipe</code> event handler, <code>swipeContent</code> can be changed according to the swiped item. Calling the <code>preventDefault</code> method of the event cancels the swipe action.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachSwipe(object oData, sap.m.ListBase.SwipeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:swipe swipe} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after us"r's swipe action and before the <code>swipeContent</code> is shown. On the <code>swipe</code> event handler, <code>swipeContent</code> can be changed according to the swiped item. Calling the <code>preventDefault</code> method of the event cancels the swipe action.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachSwipe(object oData, sap.m.ListBase.SwipeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:swipe swipe} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after us"r's swipe action and before the <code>swipeContent</code> is shown. On the <code>swipe</code> event handler, <code>swipeContent</code> can be changed according to the swiped item. Calling the <code>preventDefault</code> method of the event cancels the swipe action.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachSwipe(sap.m.ListBase.SwipeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:swipe swipe} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after us"r's swipe action and before the <code>swipeContent</code> is shown. On the <code>swipe</code> event handler, <code>swipeContent</code> can be changed according to the swiped item. Calling the <code>preventDefault</code> method of the event cancels the swipe action.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachSwipe(sap.m.ListBase.SwipeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:swipe swipe} event of this <code>sap.m.ListBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase detachSwipe(sap.m.ListBase.SwipeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:swipe swipe} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireSwipe(sap.m.ListBase.SwipeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:swipe swipe} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireSwipe();

				#endregion

				#region Methods for Event growingStarted

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:growingStarted growingStarted} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires before the new growing chunk is requested from the model.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use <code>updateStarted</code> event with listening <code>changeReason</code>.")]
				public extern virtual sap.m.ListBase attachGrowingStarted(object oData, sap.m.ListBase.GrowingDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:growingStarted growingStarted} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires before the new growing chunk is requested from the model.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use <code>updateStarted</code> event with listening <code>changeReason</code>.")]
				public extern virtual sap.m.ListBase attachGrowingStarted(object oData, sap.m.ListBase.GrowingDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:growingStarted growingStarted} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires before the new growing chunk is requested from the model.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use <code>updateStarted</code> event with listening <code>changeReason</code>.")]
				public extern virtual sap.m.ListBase attachGrowingStarted(sap.m.ListBase.GrowingDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:growingStarted growingStarted} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires before the new growing chunk is requested from the model.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use <code>updateStarted</code> event with listening <code>changeReason</code>.")]
				public extern virtual sap.m.ListBase attachGrowingStarted(sap.m.ListBase.GrowingDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:growingStarted growingStarted} event of this <code>sap.m.ListBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use <code>updateStarted</code> event with listening <code>changeReason</code>.")]
				public extern virtual sap.m.ListBase detachGrowingStarted(sap.m.ListBase.GrowingDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:growingStarted growingStarted} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use <code>updateStarted</code> event with listening <code>changeReason</code>.")]
				public extern virtual sap.m.ListBase fireGrowingStarted(sap.m.ListBase.GrowingInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:growingStarted growingStarted} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use <code>updateStarted</code> event with listening <code>changeReason</code>.")]
				public extern virtual sap.m.ListBase fireGrowingStarted();

				#endregion

				#region Methods for Event growingFinished

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:growingFinished growingFinished} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after the new growing chunk has been fetched from the model and processed by the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use 'updateFinished' event.")]
				public extern virtual sap.m.ListBase attachGrowingFinished(object oData, sap.m.ListBase.GrowingDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:growingFinished growingFinished} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after the new growing chunk has been fetched from the model and processed by the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use 'updateFinished' event.")]
				public extern virtual sap.m.ListBase attachGrowingFinished(object oData, sap.m.ListBase.GrowingDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:growingFinished growingFinished} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after the new growing chunk has been fetched from the model and processed by the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use 'updateFinished' event.")]
				public extern virtual sap.m.ListBase attachGrowingFinished(sap.m.ListBase.GrowingDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:growingFinished growingFinished} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after the new growing chunk has been fetched from the model and processed by the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use 'updateFinished' event.")]
				public extern virtual sap.m.ListBase attachGrowingFinished(sap.m.ListBase.GrowingDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:growingFinished growingFinished} event of this <code>sap.m.ListBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use 'updateFinished' event.")]
				public extern virtual sap.m.ListBase detachGrowingFinished(sap.m.ListBase.GrowingDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:growingFinished growingFinished} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use 'updateFinished' event.")]
				public extern virtual sap.m.ListBase fireGrowingFinished(sap.m.ListBase.GrowingInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:growingFinished growingFinished} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.3. Instead, use 'updateFinished' event.")]
				public extern virtual sap.m.ListBase fireGrowingFinished();

				#endregion

				#region Methods for Event updateStarted

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateStarted updateStarted} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires before <code>items</code> binding is updated (e.g. sorting, filtering)
				/// 
				/// <b>Note:</b> Event handler should not invalidate the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachUpdateStarted(object oData, sap.m.ListBase.UpdateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateStarted updateStarted} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires before <code>items</code> binding is updated (e.g. sorting, filtering)
				/// 
				/// <b>Note:</b> Event handler should not invalidate the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachUpdateStarted(object oData, sap.m.ListBase.UpdateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateStarted updateStarted} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires before <code>items</code> binding is updated (e.g. sorting, filtering)
				/// 
				/// <b>Note:</b> Event handler should not invalidate the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachUpdateStarted(sap.m.ListBase.UpdateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateStarted updateStarted} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires before <code>items</code> binding is updated (e.g. sorting, filtering)
				/// 
				/// <b>Note:</b> Event handler should not invalidate the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachUpdateStarted(sap.m.ListBase.UpdateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:updateStarted updateStarted} event of this <code>sap.m.ListBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase detachUpdateStarted(sap.m.ListBase.UpdateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:updateStarted updateStarted} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase fireUpdateStarted(sap.m.ListBase.UpdateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:updateStarted updateStarted} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase fireUpdateStarted();

				#endregion

				#region Methods for Event updateFinished

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateFinished updateFinished} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after <code>items</code> binding is updated and processed by the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachUpdateFinished(object oData, sap.m.ListBase.UpdateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateFinished updateFinished} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after <code>items</code> binding is updated and processed by the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachUpdateFinished(object oData, sap.m.ListBase.UpdateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateFinished updateFinished} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after <code>items</code> binding is updated and processed by the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachUpdateFinished(sap.m.ListBase.UpdateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateFinished updateFinished} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires after <code>items</code> binding is updated and processed by the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachUpdateFinished(sap.m.ListBase.UpdateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:updateFinished updateFinished} event of this <code>sap.m.ListBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase detachUpdateFinished(sap.m.ListBase.UpdateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:updateFinished updateFinished} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase fireUpdateFinished(sap.m.ListBase.UpdateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:updateFinished updateFinished} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase fireUpdateFinished();

				#endregion

				#region Methods for Event itemPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPress itemPress} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when an item is pressed unless the item's <code>type</code> property is <code>Inactive</code>.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachItemPress(object oData, sap.m.ListBase.ItemPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPress itemPress} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when an item is pressed unless the item's <code>type</code> property is <code>Inactive</code>.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachItemPress(object oData, sap.m.ListBase.ItemPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPress itemPress} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when an item is pressed unless the item's <code>type</code> property is <code>Inactive</code>.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachItemPress(sap.m.ListBase.ItemPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPress itemPress} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fires when an item is pressed unless the item's <code>type</code> property is <code>Inactive</code>.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachItemPress(sap.m.ListBase.ItemPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemPress itemPress} event of this <code>sap.m.ListBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase detachItemPress(sap.m.ListBase.ItemPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:itemPress itemPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase fireItemPress(sap.m.ListBase.ItemPressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:itemPress itemPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase fireItemPress();

				#endregion

				#region Methods for Event beforeOpenContextMenu

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fired when the context menu is opened. When the context menu is opened, the binding context of the item is set to the given <code>contextMenu</code>.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachBeforeOpenContextMenu(object oData, sap.m.ListBase.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fired when the context menu is opened. When the context menu is opened, the binding context of the item is set to the given <code>contextMenu</code>.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachBeforeOpenContextMenu(object oData, sap.m.ListBase.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fired when the context menu is opened. When the context menu is opened, the binding context of the item is set to the given <code>contextMenu</code>.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachBeforeOpenContextMenu(sap.m.ListBase.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.m.ListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListBase</code> itself.
				/// 
				/// Fired when the context menu is opened. When the context menu is opened, the binding context of the item is set to the given <code>contextMenu</code>.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase attachBeforeOpenContextMenu(sap.m.ListBase.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.m.ListBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListBase detachBeforeOpenContextMenu(sap.m.ListBase.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeOpenContextMenu beforeOpenContextMenu} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireBeforeOpenContextMenu(sap.m.ListBase.EventInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeOpenContextMenu beforeOpenContextMenu} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireBeforeOpenContextMenu();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ListBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ListBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ListBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns growing information as object with "actual" and "total" keys. Note: This function returns "null" if "growing" feature is disabled.
				/// </summary>
				/// <returns></returns>
				public extern virtual object getGrowingInfo();

				/// <summary>
				/// Returns ItemNavigation for controls uses List
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.@delegate.ItemNavigation getItemNavigation();

				/// <summary>
				/// Returns the last list mode, the mode that is rendered This can be used to detect mode changes during rendering
				/// </summary>
				public extern virtual void getLastMode();

				/// <summary>
				/// Returns a metadata object for class sap.m.ListBase.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Returns the binding contexts of the selected items. Note: This method returns an empty array if no databinding is used.
				/// </summary>
				/// <param name="bAll">Set true to include even invisible selected items(e.g. the selections from the previous filters). Note: In single selection modes, only the last selected item's binding context is returned in array.</param>
				/// <returns></returns>
				public extern virtual object[] getSelectedContexts(bool bAll);

				/// <summary>
				/// Returns selected list item. When no item is selected, "null" is returned. When "multi-selection" is enabled and multiple items are selected, only the up-most selected item is returned.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ListItemBase getSelectedItem();

				/// <summary>
				/// Returns an array containing the selected list items. If no items are selected, an empty array is returned.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ListItemBase[] getSelectedItems();

				/// <summary>
				/// Returns swiped list item. When no item is swiped, "null" is returned.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ListItemBase getSwipedItem();

				/// <summary>
				/// Removes visible selections of the current selection mode.
				/// </summary>
				/// <param name="bAll">Since version 1.16.3. This control keeps old selections after filter or sorting. Set this parameter "true" to remove all selections.</param>
				/// <returns></returns>
				public extern virtual sap.m.ListBase removeSelections(bool bAll);

				/// <summary>
				/// Select all items in "MultiSelection" mode.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ListBase selectAll();

				/// <summary>
				/// Selects or deselects the given list item.
				/// </summary>
				/// <param name="oListItem">The list item whose selection to be changed. This parameter is mandatory.</param>
				/// <param name="bSelect">Sets selected status of the list item. Default value is true.</param>
				/// <returns></returns>
				public extern virtual sap.m.ListBase setSelectedItem(sap.m.ListItemBase oListItem, bool bSelect);

				/// <summary>
				/// Sets a list item to be selected by id. In single mode the method removes the previous selection.
				/// </summary>
				/// <param name="sId">The id of the list item whose selection to be changed.</param>
				/// <param name="bSelect">Sets selected status of the list item. Default value is true.</param>
				/// <returns></returns>
				public extern virtual sap.m.ListBase setSelectedItemById(string sId, bool bSelect);

				/// <summary>
				/// After swipeContent is shown, user can interact with this control(e.g Tap). After interaction is done, you can/should use this method to hide swipeContent from screen. Note: If users try to tap inside of the list but outside of the swipeContent then control hides automatically.
				/// </summary>
				/// <param name="oCallback">This callback function is called with two parameters(swipedListItem and swipedContent) after swipe-out animation is finished.</param>
				/// <returns></returns>
				public extern virtual sap.m.ListBase swipeOut(object oCallback);

				#endregion

				#endregion

			}
		}
	}
}
