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
			/// An input field to search for a specific item. <h3>Overview</h3> A search field is needed when the user needs to find specific information in large amounts of data. The search field is also the control of choice for filtering down a given amount of information. <h3>Structure</h3> The search input field can be used in two ways: <ul> <li>Manual search - The search is triggered after the user presses the search button. Manual search uses a “starts with” approach.</li> <li>Live search (search-as-you-type) - The search is triggered after each button press. A suggestion list is shown below the search field. Live search uses a “contains” approach.</li> </ul> <h3>Usage</h3> <h4>When to use:</h4> <ul> <li> Use live search whenever possible. </li> <li> Use a manual search only if the amount of data is too large and if your app would otherwise run into performance issues. </li> </ul> <h3>Responsive Behavior</h3> On mobile devices, there is no refresh button in the search field. "Pull Down to Refresh" is used instead. The "Pull Down to Refresh" arrow icon is animated and spins to signal that the user should release it.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class SearchField : sap.ui.core.Control, sap.ui.core.IFormContent
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
					/// Input Value.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> value;

					/// <summary>
					/// Defines the CSS width of the input. If not set, width is 100%.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

					/// <summary>
					/// Boolean property to enable the control (default is true).
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enabled;

					/// <summary>
					/// Invisible inputs are not rendered.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visible;

					/// <summary>
					/// Maximum number of characters. Value '0' means the feature is switched off.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> maxLength;

					/// <summary>
					/// Text shown when no value available. Default placeholder text is the word "Search" in the current local language (if supported) or in English.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> placeholder;

					/// <summary>
					/// Set to false to hide the magnifier icon.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showMagnifier;

					/// <summary>
					/// Set to true to display a refresh button in place of the search icon. By pressing the refresh button or F5 key on keyboard, the user can reload the results list without changing the search string.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showRefreshButton;

					/// <summary>
					/// Tooltip text of the refresh button. If it is not set, the Default placeholder text is the word "Refresh" in the current local language (if supported) or in English. Tooltips are not displayed on touch devices.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> refreshButtonTooltip;

					/// <summary>
					/// Set to true to show the search button with the magnifier icon. If false, both the search and refresh buttons are not displayed even if the "showRefreshButton" property is true.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showSearchButton;

					/// <summary>
					/// If true, a <code>suggest</code> event is fired when user types in the input and when the input is focused. On a phone device, a full screen dialog with suggestions is always shown even if the suggestions list is empty.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enableSuggestions;

					/// <summary>
					/// Normally, search text is selected for copy when the SearchField is focused by keyboard navigation. If an application re-renders the SearchField during the liveChange event, set this property to false to disable text selection by focus.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> selectOnFocus;

					/// <summary>
					/// <code>SuggestionItems</code> are the items which will be shown in the suggestions list. The following properties can be used: <ul> <li><code>key</code> is not displayed and may be used as internal technical field</li> <li><code>text</code> is displayed as normal suggestion text</li> <li><code>icon</code></li> <li><code>description</code> - additional text may be used to visually display search item type or category</li> </ul>
					/// </summary>
					public Union<sap.m.SuggestionItem[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> suggestionItems;

					/// <summary>
					/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelledBy;

					/// <summary>
					/// Event which is fired when the user triggers a search.
					/// </summary>
					public sap.m.SearchField.SearchDelegate search;

					/// <summary>
					/// This event is fired when the value of the search field is changed by a user - e.g. at each key press. Do not invalidate or re-render a focused search field, especially during the liveChange event.
					/// </summary>
					public sap.m.SearchField.LiveChangeDelegate liveChange;

					/// <summary>
					/// This event is fired when the search field is initially focused or its value is changed by the user. This event means that suggestion data should be updated, in case if suggestions are used. Use the value parameter to create new suggestions for it.
					/// </summary>
					public sap.m.SearchField.SuggestDelegate suggest;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class LiveChangeInfo
				{
					/// <summary>
					/// Current search string.
					/// </summary>
					public string newValue;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SearchInfo
				{
					/// <summary>
					/// The search query string.
					/// </summary>
					public string query;

					/// <summary>
					/// Suggestion list item in case if the user has selected an item from the suggestions list.
					/// </summary>
					public sap.m.SuggestionItem suggestionItem;

					/// <summary>
					/// Indicates if the user pressed the refresh icon.
					/// </summary>
					public bool refreshButtonPressed;

					/// <summary>
					/// Indicates if the user pressed the clear icon.
					/// </summary>
					public bool clearButtonPressed;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SuggestInfo
				{
					/// <summary>
					/// Current search string of the search field.
					/// </summary>
					public string suggestValue;

				}

				#endregion

				#region Delegates

				public delegate void LiveChangeDelegate(sap.ui.@base.Event<sap.m.SearchField.LiveChangeInfo> oEvent, object oData);

				public delegate void SearchDelegate(sap.ui.@base.Event<sap.m.SearchField.SearchInfo> oEvent, object oData);

				public delegate void SuggestDelegate(sap.ui.@base.Event<sap.m.SearchField.SuggestInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new SearchField.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern SearchField(string sId, sap.m.SearchField.Settings mSettings);

				/// <summary>
				/// Constructor for a new SearchField.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern SearchField(string sId);

				/// <summary>
				/// Constructor for a new SearchField.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern SearchField();

				/// <summary>
				/// Constructor for a new SearchField.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern SearchField(sap.m.SearchField.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property value

				/// <summary>
				/// Gets current value of property {@link #getValue value}.
				/// 
				/// Input Value.
				/// </summary>
				/// <returns>Value of property <code>value</code></returns>
				public extern virtual string getValue();

				/// <summary>
				/// Sets a new value for property {@link #getValue value}.
				/// 
				/// Input Value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValue">New value for property <code>value</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setValue(string sValue);

				/// <summary>
				/// Binds property {@link #getValue value} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindProperty ManagedObject.bindProperty} for a detailed description of the possible properties of <code>oBindingInfo</code>
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField bindValue(object oBindingInfo);

				/// <summary>
				/// Unbinds property {@link #getValue value} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField unbindValue();

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the CSS width of the input. If not set, width is 100%.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the CSS width of the input. If not set, width is 100%.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Boolean property to enable the control (default is true).
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Boolean property to enable the control (default is true).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Invisible inputs are not rendered.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern override bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Invisible inputs are not rendered.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setVisible(bool bVisible);

				#endregion

				#region Methods for Property maxLength

				/// <summary>
				/// Gets current value of property {@link #getMaxLength maxLength}.
				/// 
				/// Maximum number of characters. Value '0' means the feature is switched off.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>maxLength</code></returns>
				public extern virtual int getMaxLength();

				/// <summary>
				/// Sets a new value for property {@link #getMaxLength maxLength}.
				/// 
				/// Maximum number of characters. Value '0' means the feature is switched off.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="iMaxLength">New value for property <code>maxLength</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setMaxLength(int iMaxLength);

				#endregion

				#region Methods for Property placeholder

				/// <summary>
				/// Gets current value of property {@link #getPlaceholder placeholder}.
				/// 
				/// Text shown when no value available. Default placeholder text is the word "Search" in the current local language (if supported) or in English.
				/// </summary>
				/// <returns>Value of property <code>placeholder</code></returns>
				public extern virtual string getPlaceholder();

				/// <summary>
				/// Sets a new value for property {@link #getPlaceholder placeholder}.
				/// 
				/// Text shown when no value available. Default placeholder text is the word "Search" in the current local language (if supported) or in English.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sPlaceholder">New value for property <code>placeholder</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setPlaceholder(string sPlaceholder);

				#endregion

				#region Methods for Property showMagnifier

				/// <summary>
				/// Gets current value of property {@link #getShowMagnifier showMagnifier}.
				/// 
				/// Set to false to hide the magnifier icon.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.16.0. This parameter is deprecated. Use 'showSearchButton' instead.")]
				/// <returns>Value of property <code>showMagnifier</code></returns>
				public extern virtual bool getShowMagnifier();

				/// <summary>
				/// Sets a new value for property {@link #getShowMagnifier showMagnifier}.
				/// 
				/// Set to false to hide the magnifier icon.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.16.0. This parameter is deprecated. Use 'showSearchButton' instead.")]
				/// <param name="bShowMagnifier">New value for property <code>showMagnifier</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setShowMagnifier(bool bShowMagnifier);

				#endregion

				#region Methods for Property showRefreshButton

				/// <summary>
				/// Gets current value of property {@link #getShowRefreshButton showRefreshButton}.
				/// 
				/// Set to true to display a refresh button in place of the search icon. By pressing the refresh button or F5 key on keyboard, the user can reload the results list without changing the search string.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showRefreshButton</code></returns>
				public extern virtual bool getShowRefreshButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowRefreshButton showRefreshButton}.
				/// 
				/// Set to true to display a refresh button in place of the search icon. By pressing the refresh button or F5 key on keyboard, the user can reload the results list without changing the search string.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowRefreshButton">New value for property <code>showRefreshButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setShowRefreshButton(bool bShowRefreshButton);

				#endregion

				#region Methods for Property refreshButtonTooltip

				/// <summary>
				/// Gets current value of property {@link #getRefreshButtonTooltip refreshButtonTooltip}.
				/// 
				/// Tooltip text of the refresh button. If it is not set, the Default placeholder text is the word "Refresh" in the current local language (if supported) or in English. Tooltips are not displayed on touch devices.
				/// </summary>
				/// <returns>Value of property <code>refreshButtonTooltip</code></returns>
				public extern virtual string getRefreshButtonTooltip();

				/// <summary>
				/// Sets a new value for property {@link #getRefreshButtonTooltip refreshButtonTooltip}.
				/// 
				/// Tooltip text of the refresh button. If it is not set, the Default placeholder text is the word "Refresh" in the current local language (if supported) or in English. Tooltips are not displayed on touch devices.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sRefreshButtonTooltip">New value for property <code>refreshButtonTooltip</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setRefreshButtonTooltip(string sRefreshButtonTooltip);

				#endregion

				#region Methods for Property showSearchButton

				/// <summary>
				/// Gets current value of property {@link #getShowSearchButton showSearchButton}.
				/// 
				/// Set to true to show the search button with the magnifier icon. If false, both the search and refresh buttons are not displayed even if the "showRefreshButton" property is true.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showSearchButton</code></returns>
				public extern virtual bool getShowSearchButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowSearchButton showSearchButton}.
				/// 
				/// Set to true to show the search button with the magnifier icon. If false, both the search and refresh buttons are not displayed even if the "showRefreshButton" property is true.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowSearchButton">New value for property <code>showSearchButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setShowSearchButton(bool bShowSearchButton);

				#endregion

				#region Methods for Property enableSuggestions

				/// <summary>
				/// Gets current value of property {@link #getEnableSuggestions enableSuggestions}.
				/// 
				/// If true, a <code>suggest</code> event is fired when user types in the input and when the input is focused. On a phone device, a full screen dialog with suggestions is always shown even if the suggestions list is empty.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableSuggestions</code></returns>
				public extern virtual bool getEnableSuggestions();

				/// <summary>
				/// Sets a new value for property {@link #getEnableSuggestions enableSuggestions}.
				/// 
				/// If true, a <code>suggest</code> event is fired when user types in the input and when the input is focused. On a phone device, a full screen dialog with suggestions is always shown even if the suggestions list is empty.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableSuggestions">New value for property <code>enableSuggestions</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setEnableSuggestions(bool bEnableSuggestions);

				#endregion

				#region Methods for Property selectOnFocus

				/// <summary>
				/// Gets current value of property {@link #getSelectOnFocus selectOnFocus}.
				/// 
				/// Normally, search text is selected for copy when the SearchField is focused by keyboard navigation. If an application re-renders the SearchField during the liveChange event, set this property to false to disable text selection by focus.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.38. This parameter is deprecated and has no effect in run time. The cursor position of a focused search field is restored after re-rendering automatically.")]
				/// <returns>Value of property <code>selectOnFocus</code></returns>
				public extern virtual bool getSelectOnFocus();

				/// <summary>
				/// Sets a new value for property {@link #getSelectOnFocus selectOnFocus}.
				/// 
				/// Normally, search text is selected for copy when the SearchField is focused by keyboard navigation. If an application re-renders the SearchField during the liveChange event, set this property to false to disable text selection by focus.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.38. This parameter is deprecated and has no effect in run time. The cursor position of a focused search field is restored after re-rendering automatically.")]
				/// <param name="bSelectOnFocus">New value for property <code>selectOnFocus</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField setSelectOnFocus(bool bSelectOnFocus);

				#endregion

				#region Methods for Aggregation suggestionItems

				/// <summary>
				/// Gets content of aggregation {@link #getSuggestionItems suggestionItems}.
				/// 
				/// <code>SuggestionItems</code> are the items which will be shown in the suggestions list. The following properties can be used: <ul> <li><code>key</code> is not displayed and may be used as internal technical field</li> <li><code>text</code> is displayed as normal suggestion text</li> <li><code>icon</code></li> <li><code>description</code> - additional text may be used to visually display search item type or category</li> </ul>
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.SuggestionItem[] getSuggestionItems();

				/// <summary>
				/// Destroys all the suggestionItems in the aggregation {@link #getSuggestionItems suggestionItems}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField destroySuggestionItems();

				/// <summary>
				/// Inserts a suggestionItem into the aggregation {@link #getSuggestionItems suggestionItems}.
				/// </summary>
				/// <param name="oSuggestionItem">The suggestionItem to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the suggestionItem should be inserted at; for a negative value of <code>iIndex</code>, the suggestionItem is inserted at position 0; for a value greater than the current size of the aggregation, the suggestionItem is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField insertSuggestionItem(sap.m.SuggestionItem oSuggestionItem, int iIndex);

				/// <summary>
				/// Adds some suggestionItem to the aggregation {@link #getSuggestionItems suggestionItems}.
				/// </summary>
				/// <param name="oSuggestionItem">The suggestionItem to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField addSuggestionItem(sap.m.SuggestionItem oSuggestionItem);

				/// <summary>
				/// Removes a suggestionItem from the aggregation {@link #getSuggestionItems suggestionItems}.
				/// </summary>
				/// <param name="vSuggestionItem">The suggestionItem to remove or its index or id</param>
				/// <returns>The removed suggestionItem or <code>null</code></returns>
				public extern virtual sap.m.SuggestionItem removeSuggestionItem(Union<int, string, sap.m.SuggestionItem> vSuggestionItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.SuggestionItem</code> in the aggregation {@link #getSuggestionItems suggestionItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oSuggestionItem">The suggestionItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfSuggestionItem(sap.m.SuggestionItem oSuggestionItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getSuggestionItems suggestionItems}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.SuggestionItem[] removeAllSuggestionItems();

				#endregion

				#region Methods for Association ariaDescribedBy

				/// <summary>
				/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID[] getAriaDescribedBy();

				/// <summary>
				/// Adds some ariaDescribedBy into the association {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <param name="vAriaDescribedBy">The ariaDescribedBy to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

				/// <summary>
				/// Removes an ariaDescribedBy from the association named {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <param name="vAriaDescribedBy">The ariaDescribedBy to be removed or its index or ID</param>
				/// <returns>The removed ariaDescribedBy or <code>null</code></returns>
				public extern virtual sap.ui.core.ID removeAriaDescribedBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

				/// <summary>
				/// Removes all the controls in the association named {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.ID[] removeAllAriaDescribedBy();

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
				public extern virtual sap.m.SearchField addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event search

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// Event which is fired when the user triggers a search.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SearchField</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachSearch(object oData, sap.m.SearchField.SearchDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// Event which is fired when the user triggers a search.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachSearch(object oData, sap.m.SearchField.SearchDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// Event which is fired when the user triggers a search.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachSearch(sap.m.SearchField.SearchDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// Event which is fired when the user triggers a search.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SearchField</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachSearch(sap.m.SearchField.SearchDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:search search} event of this <code>sap.m.SearchField</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField detachSearch(sap.m.SearchField.SearchDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:search search} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField fireSearch(sap.m.SearchField.SearchInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:search search} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField fireSearch();

				#endregion

				#region Methods for Event liveChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// This event is fired when the value of the search field is changed by a user - e.g. at each key press. Do not invalidate or re-render a focused search field, especially during the liveChange event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SearchField</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachLiveChange(object oData, sap.m.SearchField.LiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// This event is fired when the value of the search field is changed by a user - e.g. at each key press. Do not invalidate or re-render a focused search field, especially during the liveChange event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachLiveChange(object oData, sap.m.SearchField.LiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// This event is fired when the value of the search field is changed by a user - e.g. at each key press. Do not invalidate or re-render a focused search field, especially during the liveChange event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachLiveChange(sap.m.SearchField.LiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// This event is fired when the value of the search field is changed by a user - e.g. at each key press. Do not invalidate or re-render a focused search field, especially during the liveChange event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SearchField</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachLiveChange(sap.m.SearchField.LiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.m.SearchField</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField detachLiveChange(sap.m.SearchField.LiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField fireLiveChange(sap.m.SearchField.LiveChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField fireLiveChange();

				#endregion

				#region Methods for Event suggest

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// This event is fired when the search field is initially focused or its value is changed by the user. This event means that suggestion data should be updated, in case if suggestions are used. Use the value parameter to create new suggestions for it.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SearchField</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachSuggest(object oData, sap.m.SearchField.SuggestDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// This event is fired when the search field is initially focused or its value is changed by the user. This event means that suggestion data should be updated, in case if suggestions are used. Use the value parameter to create new suggestions for it.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachSuggest(object oData, sap.m.SearchField.SuggestDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// This event is fired when the search field is initially focused or its value is changed by the user. This event means that suggestion data should be updated, in case if suggestions are used. Use the value parameter to create new suggestions for it.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachSuggest(sap.m.SearchField.SuggestDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.m.SearchField</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SearchField</code> itself.
				/// 
				/// This event is fired when the search field is initially focused or its value is changed by the user. This event means that suggestion data should be updated, in case if suggestions are used. Use the value parameter to create new suggestions for it.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SearchField</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField attachSuggest(sap.m.SearchField.SuggestDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:suggest suggest} event of this <code>sap.m.SearchField</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField detachSuggest(sap.m.SearchField.SuggestDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:suggest suggest} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField fireSuggest(sap.m.SearchField.SuggestInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:suggest suggest} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SearchField fireSuggest();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.SearchField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.SearchField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.SearchField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.SearchField.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Function returns DOM element which acts as reference point for the opening suggestion menu
				/// </summary>
				/// <returns>the DOM element at which to open the suggestion list</returns>
				public extern virtual dom.HTMLElement getPopupAnchorDomRef();

				/// <summary>
				/// Toggle visibility of the suggestion list.
				/// </summary>
				/// <param name="bShow">set to <code>true</code> to display suggestions and <code>false</code> to hide them. Default value is <code>true</code>. An empty suggestion list is not shown on desktop and tablet devices.<br>
				/// 
				/// This method may be called only as a response to the <code>suggest</code> event to ensure that the suggestion list is shown at the moment when the user expects it.</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.SearchField suggest(bool? bShow);

				#endregion

				#region Methods of sap.ui.core.IFormContent Interface

				/// <summary>
				/// In the <code>Form</code> control all content controls are positioned on a grid cell base. By default the controls use the full width of the used grid cell. But for some controls (like image controls), this is not the desired behavior. In this case the control must keep its original width.
				/// </summary>
				/// <returns>true if the <code>Form</code> is not allowed to adjust the width of the control to use the cell's width</returns>
				public extern static bool getFormDoNotAdjustWidth();

				#endregion

				#endregion

			}
		}
	}
}
