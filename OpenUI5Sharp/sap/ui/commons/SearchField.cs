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
				/// Allows the user to type search queries and to trigger the search. Optionally, suggestions can be added.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.SearchField")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.SearchField</code> control.")]
				public partial class SearchField : sap.ui.core.Control, sap.ui.commons.ToolbarItem
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
						/// Defines whether a pop up list shall be provided for suggestions
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableListSuggest;

						/// <summary>
						/// Defines whether the list expander shall be displayed in the case of an enabled list for suggestions. This feature is deactivated on mobile devices.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showListExpander;

						/// <summary>
						/// Defines whether the clear functionality shall be active
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableClear;

						/// <summary>
						/// Defines whether an additional search button shall be displayed
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showExternalButton;

						/// <summary>
						/// When list suggestion is enabled all suggestions are cached and no suggest event is fired.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableCache;

						/// <summary>
						/// Defines whether the search event should also be fired when the SearchField is empty (like a Filter field) and when the clear button (if activated) is pressed.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableFilterMode;

						/// <summary>
						/// Text that shall be displayed within the search field
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

						/// <summary>
						/// Disabled fields have different colors, and they can not be focused.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Non-editable controls have different colors, depending on custom settings
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

						/// <summary>
						/// Control width in CSS-size
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Maximum number of characters. Value '0' means the feature is switched off.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxLength;

						/// <summary>
						/// Visualizes warnings or errors related to the input field. Possible values: Warning, Error, Success, None.
						/// </summary>
						public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

						/// <summary>
						/// Placeholder for the input field.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> placeholder;

						/// <summary>
						/// Sets the horizontal alignment of the text
						/// </summary>
						public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textAlign;

						/// <summary>
						/// Defines the number of items in the suggestion list that shall be displayed at once. If the overall number of list items is higher than the setting, a scroll bar is provided.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleItemCount;

						/// <summary>
						/// Minimum length of the entered string triggering the suggestion list.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> startSuggestion;

						/// <summary>
						/// Maximum number of suggestion items in the suggestion list.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxSuggestionItems;

						/// <summary>
						/// Maximum number of history items in the suggestion list. 0 displays and stores no history. The history is locally stored on the client. Therefore do not activate this feature when this control handles confidential data.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxHistoryItems;

						/// <summary>
						/// Search provider instance which handles the suggestions for this SearchField (e.g. Open Search Protocol).
						/// </summary>
						public Union<sap.ui.core.search.SearchProvider, string, sap.ui.@base.ManagedObject.BindAggregationInfo> searchProvider;

						/// <summary>
						/// Association to controls / IDs which describe this control (see WAI-ARIA attribute aria-describedby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

						/// <summary>
						/// Association to controls / IDs which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Event which is fired when the user triggers a search
						/// </summary>
						public sap.ui.SearchDelegate search;

						/// <summary>
						/// Event which is fired when new suggest values are required.
						/// </summary>
						public sap.m.ValueDelegate suggest;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new SearchField.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern SearchField(string sId, sap.ui.commons.SearchField.Settings mSettings);

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
					public extern SearchField(sap.ui.commons.SearchField.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property enableListSuggest

					/// <summary>
					/// Gets current value of property {@link #getEnableListSuggest enableListSuggest}.
					/// 
					/// Defines whether a pop up list shall be provided for suggestions
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableListSuggest</code></returns>
					public extern virtual bool getEnableListSuggest();

					/// <summary>
					/// Sets a new value for property {@link #getEnableListSuggest enableListSuggest}.
					/// 
					/// Defines whether a pop up list shall be provided for suggestions
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableListSuggest">New value for property <code>enableListSuggest</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setEnableListSuggest(bool bEnableListSuggest);

					#endregion

					#region Methods for Property showListExpander

					/// <summary>
					/// Gets current value of property {@link #getShowListExpander showListExpander}.
					/// 
					/// Defines whether the list expander shall be displayed in the case of an enabled list for suggestions. This feature is deactivated on mobile devices.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showListExpander</code></returns>
					public extern virtual bool getShowListExpander();

					/// <summary>
					/// Sets a new value for property {@link #getShowListExpander showListExpander}.
					/// 
					/// Defines whether the list expander shall be displayed in the case of an enabled list for suggestions. This feature is deactivated on mobile devices.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowListExpander">New value for property <code>showListExpander</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setShowListExpander(bool bShowListExpander);

					#endregion

					#region Methods for Property enableClear

					/// <summary>
					/// Gets current value of property {@link #getEnableClear enableClear}.
					/// 
					/// Defines whether the clear functionality shall be active
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>enableClear</code></returns>
					public extern virtual bool getEnableClear();

					/// <summary>
					/// Sets a new value for property {@link #getEnableClear enableClear}.
					/// 
					/// Defines whether the clear functionality shall be active
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bEnableClear">New value for property <code>enableClear</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setEnableClear(bool bEnableClear);

					#endregion

					#region Methods for Property showExternalButton

					/// <summary>
					/// Gets current value of property {@link #getShowExternalButton showExternalButton}.
					/// 
					/// Defines whether an additional search button shall be displayed
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>showExternalButton</code></returns>
					public extern virtual bool getShowExternalButton();

					/// <summary>
					/// Sets a new value for property {@link #getShowExternalButton showExternalButton}.
					/// 
					/// Defines whether an additional search button shall be displayed
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShowExternalButton">New value for property <code>showExternalButton</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setShowExternalButton(bool bShowExternalButton);

					#endregion

					#region Methods for Property enableCache

					/// <summary>
					/// Gets current value of property {@link #getEnableCache enableCache}.
					/// 
					/// When list suggestion is enabled all suggestions are cached and no suggest event is fired.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableCache</code></returns>
					public extern virtual bool getEnableCache();

					/// <summary>
					/// Sets a new value for property {@link #getEnableCache enableCache}.
					/// 
					/// When list suggestion is enabled all suggestions are cached and no suggest event is fired.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableCache">New value for property <code>enableCache</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setEnableCache(bool bEnableCache);

					#endregion

					#region Methods for Property enableFilterMode

					/// <summary>
					/// Gets current value of property {@link #getEnableFilterMode enableFilterMode}.
					/// 
					/// Defines whether the search event should also be fired when the SearchField is empty (like a Filter field) and when the clear button (if activated) is pressed.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>enableFilterMode</code></returns>
					public extern virtual bool getEnableFilterMode();

					/// <summary>
					/// Sets a new value for property {@link #getEnableFilterMode enableFilterMode}.
					/// 
					/// Defines whether the search event should also be fired when the SearchField is empty (like a Filter field) and when the clear button (if activated) is pressed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bEnableFilterMode">New value for property <code>enableFilterMode</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setEnableFilterMode(bool bEnableFilterMode);

					#endregion

					#region Methods for Property value

					/// <summary>
					/// Gets current value of property {@link #getValue value}.
					/// 
					/// Text that shall be displayed within the search field
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>value</code></returns>
					public extern virtual string getValue();

					/// <summary>
					/// Sets a new value for property {@link #getValue value}.
					/// 
					/// Text that shall be displayed within the search field
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sValue">New value for property <code>value</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setValue(string sValue);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Disabled fields have different colors, and they can not be focused.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// Disabled fields have different colors, and they can not be focused.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property editable

					/// <summary>
					/// Gets current value of property {@link #getEditable editable}.
					/// 
					/// Non-editable controls have different colors, depending on custom settings
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>editable</code></returns>
					public extern virtual bool getEditable();

					/// <summary>
					/// Sets a new value for property {@link #getEditable editable}.
					/// 
					/// Non-editable controls have different colors, depending on custom settings
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEditable">New value for property <code>editable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setEditable(bool bEditable);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Control width in CSS-size
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Control width in CSS-size
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setWidth(sap.ui.core.CSSSize sWidth);

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
					public extern virtual sap.ui.commons.SearchField setMaxLength(int iMaxLength);

					#endregion

					#region Methods for Property valueState

					/// <summary>
					/// Gets current value of property {@link #getValueState valueState}.
					/// 
					/// Visualizes warnings or errors related to the input field. Possible values: Warning, Error, Success, None.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>valueState</code></returns>
					public extern virtual sap.ui.core.ValueState getValueState();

					/// <summary>
					/// Sets a new value for property {@link #getValueState valueState}.
					/// 
					/// Visualizes warnings or errors related to the input field. Possible values: Warning, Error, Success, None.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sValueState">New value for property <code>valueState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setValueState(sap.ui.core.ValueState sValueState);

					#endregion

					#region Methods for Property placeholder

					/// <summary>
					/// Gets current value of property {@link #getPlaceholder placeholder}.
					/// 
					/// Placeholder for the input field.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>placeholder</code></returns>
					public extern virtual string getPlaceholder();

					/// <summary>
					/// Sets a new value for property {@link #getPlaceholder placeholder}.
					/// 
					/// Placeholder for the input field.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sPlaceholder">New value for property <code>placeholder</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setPlaceholder(string sPlaceholder);

					#endregion

					#region Methods for Property textAlign

					/// <summary>
					/// Gets current value of property {@link #getTextAlign textAlign}.
					/// 
					/// Sets the horizontal alignment of the text
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <returns>Value of property <code>textAlign</code></returns>
					public extern virtual sap.ui.core.TextAlign getTextAlign();

					/// <summary>
					/// Sets a new value for property {@link #getTextAlign textAlign}.
					/// 
					/// Sets the horizontal alignment of the text
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <param name="sTextAlign">New value for property <code>textAlign</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setTextAlign(sap.ui.core.TextAlign sTextAlign);

					#endregion

					#region Methods for Property visibleItemCount

					/// <summary>
					/// Gets current value of property {@link #getVisibleItemCount visibleItemCount}.
					/// 
					/// Defines the number of items in the suggestion list that shall be displayed at once. If the overall number of list items is higher than the setting, a scroll bar is provided.
					/// 
					/// Default value is <code>20</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleItemCount</code></returns>
					public extern virtual int getVisibleItemCount();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleItemCount visibleItemCount}.
					/// 
					/// Defines the number of items in the suggestion list that shall be displayed at once. If the overall number of list items is higher than the setting, a scroll bar is provided.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>20</code>.
					/// </summary>
					/// <param name="iVisibleItemCount">New value for property <code>visibleItemCount</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setVisibleItemCount(int iVisibleItemCount);

					#endregion

					#region Methods for Property startSuggestion

					/// <summary>
					/// Gets current value of property {@link #getStartSuggestion startSuggestion}.
					/// 
					/// Minimum length of the entered string triggering the suggestion list.
					/// 
					/// Default value is <code>3</code>.
					/// </summary>
					/// <returns>Value of property <code>startSuggestion</code></returns>
					public extern virtual int getStartSuggestion();

					/// <summary>
					/// Sets a new value for property {@link #getStartSuggestion startSuggestion}.
					/// 
					/// Minimum length of the entered string triggering the suggestion list.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>3</code>.
					/// </summary>
					/// <param name="iStartSuggestion">New value for property <code>startSuggestion</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setStartSuggestion(int iStartSuggestion);

					#endregion

					#region Methods for Property maxSuggestionItems

					/// <summary>
					/// Gets current value of property {@link #getMaxSuggestionItems maxSuggestionItems}.
					/// 
					/// Maximum number of suggestion items in the suggestion list.
					/// 
					/// Default value is <code>10</code>.
					/// </summary>
					/// <returns>Value of property <code>maxSuggestionItems</code></returns>
					public extern virtual int getMaxSuggestionItems();

					/// <summary>
					/// Sets a new value for property {@link #getMaxSuggestionItems maxSuggestionItems}.
					/// 
					/// Maximum number of suggestion items in the suggestion list.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>10</code>.
					/// </summary>
					/// <param name="iMaxSuggestionItems">New value for property <code>maxSuggestionItems</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setMaxSuggestionItems(int iMaxSuggestionItems);

					#endregion

					#region Methods for Property maxHistoryItems

					/// <summary>
					/// Gets current value of property {@link #getMaxHistoryItems maxHistoryItems}.
					/// 
					/// Maximum number of history items in the suggestion list. 0 displays and stores no history. The history is locally stored on the client. Therefore do not activate this feature when this control handles confidential data.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>maxHistoryItems</code></returns>
					public extern virtual int getMaxHistoryItems();

					/// <summary>
					/// Sets a new value for property {@link #getMaxHistoryItems maxHistoryItems}.
					/// 
					/// Maximum number of history items in the suggestion list. 0 displays and stores no history. The history is locally stored on the client. Therefore do not activate this feature when this control handles confidential data.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iMaxHistoryItems">New value for property <code>maxHistoryItems</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setMaxHistoryItems(int iMaxHistoryItems);

					#endregion

					#region Methods for Aggregation searchProvider

					/// <summary>
					/// Gets content of aggregation {@link #getSearchProvider searchProvider}.
					/// 
					/// Search provider instance which handles the suggestions for this SearchField (e.g. Open Search Protocol).
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.search.SearchProvider getSearchProvider();

					/// <summary>
					/// Destroys the searchProvider in the aggregation {@link #getSearchProvider searchProvider}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField destroySearchProvider();

					/// <summary>
					/// Sets the aggregated {@link #getSearchProvider searchProvider}.
					/// </summary>
					/// <param name="oSearchProvider">The searchProvider to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField setSearchProvider(sap.ui.core.search.SearchProvider oSearchProvider);

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
					public extern virtual sap.ui.commons.SearchField addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
					public extern virtual sap.ui.commons.SearchField addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.commons.SearchField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SearchField</code> itself.
					/// 
					/// Event which is fired when the user triggers a search
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.SearchField</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField attachSearch(object oData, sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.commons.SearchField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SearchField</code> itself.
					/// 
					/// Event which is fired when the user triggers a search
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField attachSearch(object oData, sap.ui.SearchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.commons.SearchField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SearchField</code> itself.
					/// 
					/// Event which is fired when the user triggers a search
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField attachSearch(sap.ui.SearchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.commons.SearchField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SearchField</code> itself.
					/// 
					/// Event which is fired when the user triggers a search
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.SearchField</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField attachSearch(sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:search search} event of this <code>sap.ui.commons.SearchField</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField detachSearch(sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:search search} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField fireSearch(sap.ui.SearchInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:search search} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField fireSearch();

					#endregion

					#region Methods for Event suggest

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.ui.commons.SearchField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SearchField</code> itself.
					/// 
					/// Event which is fired when new suggest values are required.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.SearchField</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField attachSuggest(object oData, sap.m.ValueDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.ui.commons.SearchField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SearchField</code> itself.
					/// 
					/// Event which is fired when new suggest values are required.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField attachSuggest(object oData, sap.m.ValueDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.ui.commons.SearchField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SearchField</code> itself.
					/// 
					/// Event which is fired when new suggest values are required.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField attachSuggest(sap.m.ValueDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.ui.commons.SearchField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SearchField</code> itself.
					/// 
					/// Event which is fired when new suggest values are required.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.SearchField</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField attachSuggest(sap.m.ValueDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:suggest suggest} event of this <code>sap.ui.commons.SearchField</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField detachSuggest(sap.m.ValueDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:suggest suggest} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField fireSuggest(sap.m.ValueInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:suggest suggest} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SearchField fireSuggest();

					#endregion

					#region Other methods

					/// <summary>
					/// Clears the history of the control
					/// </summary>
					public extern virtual void clearHistory();

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.SearchField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.SearchField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.SearchField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.SearchField.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Callback function used to provide the suggest values in the handler of the suggest event (only in list suggestion mode)
					/// </summary>
					/// <param name="sSSuggestValue">The value which was provided in the corresponding suggest event (parameter 'value')</param>
					/// <param name="aASuggestions">The list of suggestions belonging to the suggest value</param>
					public extern virtual void suggest(string sSSuggestValue, string[] aASuggestions);

					/// <summary>
					/// Callback function used to provide the suggest values in the handler of the suggest event (only in list suggestion mode)
					/// </summary>
					/// <param name="sSSuggestValue">The value which was provided in the corresponding suggest event (parameter 'value')</param>
					/// <param name="aASuggestions">The list of suggestions belonging to the suggest value</param>
					public extern virtual void suggest(string sSSuggestValue, object[] aASuggestions);

					#endregion

					#endregion

				}
			}
		}
	}
}
