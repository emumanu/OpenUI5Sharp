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
			/// Allows the user to enter and edit text or numeric values in one line.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// You can enable the autocomplete suggestion feature and the value help option to easily enter a valid value.
			/// 
			/// <h3>Guidelines</h3>
			/// 
			/// <ul> <li> Always provide a meaningful label for any input field </li> <li> Limit the length of the input field. This will visually emphasize the constraints for the field. </li> <li> Do not use the <code>placeholder</code> property as a label.</li> <li> Use the <code>description</code> property only for small fields with no placeholders (i.e. for currencies).</li> </ul>
			/// 
			/// <h3>Structure</h3>
			/// 
			/// The controls inherits from {@link sap.m.InputBase} which controls the core properties like: <ul> <li> editable / read-only </li> <li> enabled / disabled</li> <li> placeholder</li> <li> text direction</li> <li> value states</li> </ul> To aid the user during input, you can enable value help (<code>showValueHelp</code>) or autocomplete (<code>showSuggestion</code>). <strong>Value help</strong> will open a new dialog where you can refine your input. <strong>Autocomplete</strong> has three types of suggestions: <ul> <li> Single value - a list of suggestions of type <code>sap.ui.core.Item</code> or <code>sap.ui.core.ListItem</code> </li> <li> Two values - a list of two suggestions (ID and description) of type <code>sap.ui.core.Item</code> or <code>sap.ui.core.ListItem</code> </li> <li> Tabular suggestions of type <code>sap.m.ColumnListItem</code> </li> </ul> The suggestions are stored in two aggregations <code>suggestionItems</code> (for single and double values) and <code>suggestionRows</code> (for tabular values).
			/// 
			/// <h3>Usage</h3>
			/// 
			/// <b>When to use:</b> Use the control for short inputs like emails, phones, passwords, fields for assisted value selection.
			/// 
			/// <b>When not to use:</b> Don't use the control for long texts, dates, designated search fields, fields for multiple selection.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Input")]
			public partial class Input : sap.m.InputBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.InputBase.Settings
				{
					/// <summary>
					/// HTML type of the internal <code>input</code> tag (e.g. Text, Number, Email, Phone). The particular effect of this property differs depending on the browser and the current language settings, especially for the type Number.<br> This parameter is intended to be used with touch devices that use different soft keyboard layouts depending on the given input type.<br> Only the default value <code>sap.m.InputType.Text</code> may be used in combination with data model formats. <code>sap.ui.model</code> defines extended formats that are mostly incompatible with normal HTML representations for numbers and dates.
					/// </summary>
					public Union<sap.m.InputType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					/// <summary>
					/// Maximum number of characters. Value '0' means the feature is switched off. This parameter is not compatible with the input type <code>sap.m.InputType.Number</code>. If the input type is set to <code>Number</code>, the <code>maxLength</code> value is ignored.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxLength;

					/// <summary>
					/// Only used if type=date and no datepicker is available. The data is displayed and the user input is parsed according to this format. NOTE: The value property is always of the form RFC 3339 (YYYY-MM-dd).
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> dateFormat;

					/// <summary>
					/// If set to true, a value help indicator will be displayed inside the control. When clicked the event "valueHelpRequest" will be fired.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showValueHelp;

					/// <summary>
					/// If this is set to true, suggest event is fired when user types in the input. Changing the suggestItems aggregation in suggest event listener will show suggestions within a popup. When runs on phone, input will first open a dialog where the input and suggestions are shown. When runs on a tablet, the suggestions are shown in a popup next to the input.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSuggestion;

					/// <summary>
					/// If set to true, direct text input is disabled and the control will trigger the event "valueHelpRequest" for all user interactions. The properties "showValueHelp", "editable", and "enabled" must be set to true, otherwise the property will have no effect
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueHelpOnly;

					/// <summary>
					/// Defines whether to filter the provided suggestions before showing them to the user.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> filterSuggests;

					/// <summary>
					/// If set, the value of this parameter will control the horizontal size of the suggestion list to display more data. This allows suggestion lists to be wider than the input field if there is enough space available. By default, the suggestion list is always as wide as the input field. Note: The value will be ignored if the actual width of the input field is larger than the specified parameter value.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxSuggestionWidth;

					/// <summary>
					/// Minimum length of the entered text in input before suggest event is fired. The default value is 1 which means the suggest event is fired after user types in input. When it's set to 0, suggest event is fired when input with no text gets focus.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> startSuggestion;

					/// <summary>
					/// For tabular suggestions, this flag will show/hide the button at the end of the suggestion table that triggers the event "valueHelpRequest" when pressed. The default value is true.
					/// 
					/// NOTE: If suggestions are not tabular or no suggestions are used, the button will not be displayed and this flag is without effect.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showTableSuggestionValueHelp;

					/// <summary>
					/// The description is a text after the input field, e.g. units of measurement, currencies.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> description;

					/// <summary>
					/// This property only takes effect if the description property is set. It controls the distribution of space between the input field and the description text. The default value is 50% leaving the other 50% for the description.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fieldWidth;

					/// <summary>
					/// Indicates when the value gets updated with the user changes: At each keystroke (true) or first when the user presses enter or tabs out (false).
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueLiveUpdate;

					/// <summary>
					/// Defines the key of the selected item.
					/// 
					/// <b>Note:</b> If duplicate keys exist, the first item matching the key is used.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedKey;

					/// <summary>
					/// Defines the display text format mode.
					/// </summary>
					public Union<sap.m.InputTextFormatMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textFormatMode;

					/// <summary>
					/// Defines the display text formatter function.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textFormatter;

					/// <summary>
					/// Defines the validation callback function called when a suggestion row gets selected.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> suggestionRowValidator;

					/// <summary>
					/// Specifies whether the suggestions highlighting is enabled.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableSuggestionsHighlighting;

					/// <summary>
					/// SuggestItems are the items which will be shown in the suggestion popup. Changing this aggregation (by calling addSuggestionItem, insertSuggestionItem, removeSuggestionItem, removeAllSuggestionItems, destroySuggestionItems) after input is rendered will open/close the suggestion popup. o display suggestions with two text values, it is also possible to add sap.ui.core/ListItems as SuggestionItems (since 1.21.1). For the selected ListItem, only the first value is returned to the input field.
					/// </summary>
					public Union<sap.ui.core.Item[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> suggestionItems;

					/// <summary>
					/// The suggestionColumns and suggestionRows are for tabular input suggestions. This aggregation allows for binding the table columns; for more details see the aggregation "suggestionRows".
					/// </summary>
					public Union<sap.m.Column[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> suggestionColumns;

					/// <summary>
					/// The suggestionColumns and suggestionRows are for tabular input suggestions. This aggregation allows for binding the table cells. The items of this aggregation are to be bound directly or to set in the suggest event method. Note: If this aggregation is filled, the aggregation suggestionItems will be ignored.
					/// </summary>
					public Union<sap.m.ColumnListItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> suggestionRows;

					/// <summary>
					/// Sets or retrieves the selected item from the suggestionItems.
					/// </summary>
					public Union<sap.ui.core.Item, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedItem;

					/// <summary>
					/// Sets or retrieves the selected row from the suggestionRows.
					/// </summary>
					public Union<sap.m.ColumnListItem, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedRow;

					/// <summary>
					/// This event is fired when the value of the input is changed - e.g. at each keypress
					/// </summary>
					public sap.m.Input.LiveChangeDelegate liveChange;

					/// <summary>
					/// When the value help indicator is clicked, this event will be fired.
					/// </summary>
					public sap.m.Input.ValueHelpRequestDelegate valueHelpRequest;

					/// <summary>
					/// This event is fired when user types in the input and showSuggestion is set to true. Changing the suggestItems aggregation will show the suggestions within a popup.
					/// </summary>
					public sap.m.Input.SuggestDelegate suggest;

					/// <summary>
					/// This event is fired when suggestionItem shown in suggestion popup are selected. This event is only fired when showSuggestion is set to true and there are suggestionItems shown in the suggestion popup.
					/// </summary>
					public sap.m.Input.SuggestionItemSelectedDelegate suggestionItemSelected;

					/// <summary>
					/// This event is fired when user presses the <code>Enter</code> key on the input.
					/// 
					/// <b>Note:</b> The event is fired independent of whether there was a change before or not. If a change was performed the event is fired after the change event. The event is also fired when an item of the select list is selected via <code>Enter</code>. The event is only fired on an input which allows text input (<code>editable</code>, <code>enabled</code> and not <code>valueHelpOnly</code>).
					/// </summary>
					public sap.m.ValueDelegate submit;

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
					/// The new value of the input.
					/// </summary>
					public string value;

					/// <summary>
					/// Indicate that ESC key triggered the event.
					/// </summary>
					public bool escPressed;

					/// <summary>
					/// The value of the input before pressing ESC key.
					/// </summary>
					public string previousValue;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SuggestInfo
				{
					/// <summary>
					/// The current value which has been typed in the input.
					/// </summary>
					public string suggestValue;

					/// <summary>
					/// The suggestion list is passed to this event for convenience. If you use list-based or tabular suggestions, fill the suggestionList with the items you want to suggest. Otherwise, directly add the suggestions to the "suggestionItems" aggregation of the input control.
					/// </summary>
					public sap.m.ListBase suggestionColumns;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SuggestionItemSelectedInfo
				{
					/// <summary>
					/// This is the item selected in the suggestion popup for one and two-value suggestions. For tabular suggestions, this value will not be set.
					/// </summary>
					public sap.ui.core.Item selectedItem;

					/// <summary>
					/// This is the row selected in the tabular suggestion popup represented as a ColumnListItem. For one and two-value suggestions, this value will not be set.
					/// 
					/// Note: The row result function to select a result value for the string is already executed at this time. To pick different value for the input field or to do follow up steps after the item has been selected.
					/// </summary>
					public sap.m.ColumnListItem selectedRow;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ValueHelpRequestInfo
				{
					/// <summary>
					/// The event parameter is set to true, when the button at the end of the suggestion table is clicked, otherwise false. It can be used to determine whether the "value help" trigger or the "show all items" trigger has been pressed.
					/// </summary>
					public bool fromSuggestions;

				}

				#endregion

				#region Delegates

				public delegate void LiveChangeDelegate(sap.ui.@base.Event<sap.m.Input.LiveChangeInfo> oEvent, object oData);

				public delegate void SuggestDelegate(sap.ui.@base.Event<sap.m.Input.SuggestInfo> oEvent, object oData);

				public delegate void SuggestionItemSelectedDelegate(sap.ui.@base.Event<sap.m.Input.SuggestionItemSelectedInfo> oEvent, object oData);

				public delegate void ValueHelpRequestDelegate(sap.ui.@base.Event<sap.m.Input.ValueHelpRequestInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>Input</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Input(string sId, sap.m.Input.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>Input</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Input(string sId);

				/// <summary>
				/// Constructor for a new <code>Input</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Input();

				/// <summary>
				/// Constructor for a new <code>Input</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Input(sap.m.Input.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// HTML type of the internal <code>input</code> tag (e.g. Text, Number, Email, Phone). The particular effect of this property differs depending on the browser and the current language settings, especially for the type Number.<br> This parameter is intended to be used with touch devices that use different soft keyboard layouts depending on the given input type.<br> Only the default value <code>sap.m.InputType.Text</code> may be used in combination with data model formats. <code>sap.ui.model</code> defines extended formats that are mostly incompatible with normal HTML representations for numbers and dates.
				/// 
				/// Default value is <code>Text</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.m.InputType getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// HTML type of the internal <code>input</code> tag (e.g. Text, Number, Email, Phone). The particular effect of this property differs depending on the browser and the current language settings, especially for the type Number.<br> This parameter is intended to be used with touch devices that use different soft keyboard layouts depending on the given input type.<br> Only the default value <code>sap.m.InputType.Text</code> may be used in combination with data model formats. <code>sap.ui.model</code> defines extended formats that are mostly incompatible with normal HTML representations for numbers and dates.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Text</code>.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setType(sap.m.InputType sType);

				#endregion

				#region Methods for Property maxLength

				/// <summary>
				/// Gets current value of property {@link #getMaxLength maxLength}.
				/// 
				/// Maximum number of characters. Value '0' means the feature is switched off. This parameter is not compatible with the input type <code>sap.m.InputType.Number</code>. If the input type is set to <code>Number</code>, the <code>maxLength</code> value is ignored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>maxLength</code></returns>
				public extern virtual int getMaxLength();

				/// <summary>
				/// Sets a new value for property {@link #getMaxLength maxLength}.
				/// 
				/// Maximum number of characters. Value '0' means the feature is switched off. This parameter is not compatible with the input type <code>sap.m.InputType.Number</code>. If the input type is set to <code>Number</code>, the <code>maxLength</code> value is ignored.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="iMaxLength">New value for property <code>maxLength</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setMaxLength(int iMaxLength);

				#endregion

				#region Methods for Property dateFormat

				/// <summary>
				/// Gets current value of property {@link #getDateFormat dateFormat}.
				/// 
				/// Only used if type=date and no datepicker is available. The data is displayed and the user input is parsed according to this format. NOTE: The value property is always of the form RFC 3339 (YYYY-MM-dd).
				/// 
				/// Default value is <code>YYYY-MM-dd</code>.
				/// </summary>
				/// <returns>Value of property <code>dateFormat</code></returns>
				[Obsolete("Deprecated since 1.9.1. <code>sap.m.DatePicker</code>, <code>sap.m.TimePicker</code> or <code>sap.m.DateTimePicker</code> should be used for date/time inputs and formating.")]
				public extern virtual string getDateFormat();

				/// <summary>
				/// Sets a new value for property {@link #getDateFormat dateFormat}.
				/// 
				/// Only used if type=date and no datepicker is available. The data is displayed and the user input is parsed according to this format. NOTE: The value property is always of the form RFC 3339 (YYYY-MM-dd).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>YYYY-MM-dd</code>.
				/// </summary>
				/// <param name="sDateFormat">New value for property <code>dateFormat</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.9.1. <code>sap.m.DatePicker</code>, <code>sap.m.TimePicker</code> or <code>sap.m.DateTimePicker</code> should be used for date/time inputs and formating.")]
				public extern virtual sap.m.Input setDateFormat(string sDateFormat);

				#endregion

				#region Methods for Property showValueHelp

				/// <summary>
				/// Gets current value of property {@link #getShowValueHelp showValueHelp}.
				/// 
				/// If set to true, a value help indicator will be displayed inside the control. When clicked the event "valueHelpRequest" will be fired.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showValueHelp</code></returns>
				public extern virtual bool getShowValueHelp();

				/// <summary>
				/// Sets a new value for property {@link #getShowValueHelp showValueHelp}.
				/// 
				/// If set to true, a value help indicator will be displayed inside the control. When clicked the event "valueHelpRequest" will be fired.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowValueHelp">New value for property <code>showValueHelp</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setShowValueHelp(bool bShowValueHelp);

				#endregion

				#region Methods for Property showSuggestion

				/// <summary>
				/// Gets current value of property {@link #getShowSuggestion showSuggestion}.
				/// 
				/// If this is set to true, suggest event is fired when user types in the input. Changing the suggestItems aggregation in suggest event listener will show suggestions within a popup. When runs on phone, input will first open a dialog where the input and suggestions are shown. When runs on a tablet, the suggestions are shown in a popup next to the input.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showSuggestion</code></returns>
				public extern virtual bool getShowSuggestion();

				/// <summary>
				/// Shows suggestions.
				/// </summary>
				/// <param name="bValue">Show suggestions.</param>
				/// <returns>this Input instance for chaining.</returns>
				public extern virtual sap.m.Input setShowSuggestion(bool bValue);

				#endregion

				#region Methods for Property valueHelpOnly

				/// <summary>
				/// Gets current value of property {@link #getValueHelpOnly valueHelpOnly}.
				/// 
				/// If set to true, direct text input is disabled and the control will trigger the event "valueHelpRequest" for all user interactions. The properties "showValueHelp", "editable", and "enabled" must be set to true, otherwise the property will have no effect
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>valueHelpOnly</code></returns>
				public extern virtual bool getValueHelpOnly();

				/// <summary>
				/// Sets a new value for property {@link #getValueHelpOnly valueHelpOnly}.
				/// 
				/// If set to true, direct text input is disabled and the control will trigger the event "valueHelpRequest" for all user interactions. The properties "showValueHelp", "editable", and "enabled" must be set to true, otherwise the property will have no effect
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bValueHelpOnly">New value for property <code>valueHelpOnly</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setValueHelpOnly(bool bValueHelpOnly);

				#endregion

				#region Methods for Property filterSuggests

				/// <summary>
				/// Gets current value of property {@link #getFilterSuggests filterSuggests}.
				/// 
				/// Defines whether to filter the provided suggestions before showing them to the user.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>filterSuggests</code></returns>
				public extern virtual bool getFilterSuggests();

				/// <summary>
				/// Sets a new value for property {@link #getFilterSuggests filterSuggests}.
				/// 
				/// Defines whether to filter the provided suggestions before showing them to the user.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bFilterSuggests">New value for property <code>filterSuggests</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setFilterSuggests(bool bFilterSuggests);

				#endregion

				#region Methods for Property maxSuggestionWidth

				/// <summary>
				/// Gets current value of property {@link #getMaxSuggestionWidth maxSuggestionWidth}.
				/// 
				/// If set, the value of this parameter will control the horizontal size of the suggestion list to display more data. This allows suggestion lists to be wider than the input field if there is enough space available. By default, the suggestion list is always as wide as the input field. Note: The value will be ignored if the actual width of the input field is larger than the specified parameter value.
				/// </summary>
				/// <returns>Value of property <code>maxSuggestionWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getMaxSuggestionWidth();

				/// <summary>
				/// Sets a new value for property {@link #getMaxSuggestionWidth maxSuggestionWidth}.
				/// 
				/// If set, the value of this parameter will control the horizontal size of the suggestion list to display more data. This allows suggestion lists to be wider than the input field if there is enough space available. By default, the suggestion list is always as wide as the input field. Note: The value will be ignored if the actual width of the input field is larger than the specified parameter value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMaxSuggestionWidth">New value for property <code>maxSuggestionWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setMaxSuggestionWidth(sap.ui.core.CSSSize sMaxSuggestionWidth);

				#endregion

				#region Methods for Property startSuggestion

				/// <summary>
				/// Gets current value of property {@link #getStartSuggestion startSuggestion}.
				/// 
				/// Minimum length of the entered text in input before suggest event is fired. The default value is 1 which means the suggest event is fired after user types in input. When it's set to 0, suggest event is fired when input with no text gets focus.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>startSuggestion</code></returns>
				public extern virtual int getStartSuggestion();

				/// <summary>
				/// Sets a new value for property {@link #getStartSuggestion startSuggestion}.
				/// 
				/// Minimum length of the entered text in input before suggest event is fired. The default value is 1 which means the suggest event is fired after user types in input. When it's set to 0, suggest event is fired when input with no text gets focus.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <param name="iStartSuggestion">New value for property <code>startSuggestion</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setStartSuggestion(int iStartSuggestion);

				#endregion

				#region Methods for Property showTableSuggestionValueHelp

				/// <summary>
				/// Gets current value of property {@link #getShowTableSuggestionValueHelp showTableSuggestionValueHelp}.
				/// 
				/// For tabular suggestions, this flag will show/hide the button at the end of the suggestion table that triggers the event "valueHelpRequest" when pressed. The default value is true.
				/// 
				/// NOTE: If suggestions are not tabular or no suggestions are used, the button will not be displayed and this flag is without effect.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showTableSuggestionValueHelp</code></returns>
				public extern virtual bool getShowTableSuggestionValueHelp();

				/// <summary>
				/// Shows value help suggestions in table.
				/// </summary>
				/// <param name="bValue">Show suggestions.</param>
				/// <returns>this Input instance for chaining.</returns>
				public extern virtual sap.m.Input setShowTableSuggestionValueHelp(bool bValue);

				#endregion

				#region Methods for Property description

				/// <summary>
				/// Gets current value of property {@link #getDescription description}.
				/// 
				/// The description is a text after the input field, e.g. units of measurement, currencies.
				/// </summary>
				/// <returns>Value of property <code>description</code></returns>
				public extern virtual string getDescription();

				/// <summary>
				/// Sets a new value for property {@link #getDescription description}.
				/// 
				/// The description is a text after the input field, e.g. units of measurement, currencies.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDescription">New value for property <code>description</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setDescription(string sDescription);

				#endregion

				#region Methods for Property fieldWidth

				/// <summary>
				/// Gets current value of property {@link #getFieldWidth fieldWidth}.
				/// 
				/// This property only takes effect if the description property is set. It controls the distribution of space between the input field and the description text. The default value is 50% leaving the other 50% for the description.
				/// 
				/// Default value is <code>50%</code>.
				/// </summary>
				/// <returns>Value of property <code>fieldWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getFieldWidth();

				/// <summary>
				/// Sets a new value for property {@link #getFieldWidth fieldWidth}.
				/// 
				/// This property only takes effect if the description property is set. It controls the distribution of space between the input field and the description text. The default value is 50% leaving the other 50% for the description.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>50%</code>.
				/// </summary>
				/// <param name="sFieldWidth">New value for property <code>fieldWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setFieldWidth(sap.ui.core.CSSSize sFieldWidth);

				#endregion

				#region Methods for Property valueLiveUpdate

				/// <summary>
				/// Gets current value of property {@link #getValueLiveUpdate valueLiveUpdate}.
				/// 
				/// Indicates when the value gets updated with the user changes: At each keystroke (true) or first when the user presses enter or tabs out (false).
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>valueLiveUpdate</code></returns>
				public extern virtual bool getValueLiveUpdate();

				/// <summary>
				/// Sets a new value for property {@link #getValueLiveUpdate valueLiveUpdate}.
				/// 
				/// Indicates when the value gets updated with the user changes: At each keystroke (true) or first when the user presses enter or tabs out (false).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bValueLiveUpdate">New value for property <code>valueLiveUpdate</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setValueLiveUpdate(bool bValueLiveUpdate);

				#endregion

				#region Methods for Property selectedKey

				/// <summary>
				/// Gets current value of property {@link #getSelectedKey selectedKey}.
				/// 
				/// Defines the key of the selected item.
				/// 
				/// <b>Note:</b> If duplicate keys exist, the first item matching the key is used.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>selectedKey</code></returns>
				public extern virtual string getSelectedKey();

				/// <summary>
				/// Sets the <code>selectedKey</code> property.
				/// 
				/// Default value is an empty string <code>""</code> or <code>undefined</code>.
				/// </summary>
				/// <param name="sKey">New value for property <code>selectedKey</code>. If the provided <code>sKey</code> is an empty string <code>""</code> or <code>undefined</code>, the selection is cleared. If duplicate keys exist, the first item matching the key is selected.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Input setSelectedKey(string sKey);

				#endregion

				#region Methods for Property textFormatMode

				/// <summary>
				/// Gets current value of property {@link #getTextFormatMode textFormatMode}.
				/// 
				/// Defines the display text format mode.
				/// 
				/// Default value is <code>Value</code>.
				/// </summary>
				/// <returns>Value of property <code>textFormatMode</code></returns>
				public extern virtual sap.m.InputTextFormatMode getTextFormatMode();

				/// <summary>
				/// Sets a new value for property {@link #getTextFormatMode textFormatMode}.
				/// 
				/// Defines the display text format mode.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Value</code>.
				/// </summary>
				/// <param name="sTextFormatMode">New value for property <code>textFormatMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setTextFormatMode(sap.m.InputTextFormatMode sTextFormatMode);

				#endregion

				#region Methods for Property textFormatter

				/// <summary>
				/// Gets current value of property {@link #getTextFormatter textFormatter}.
				/// 
				/// Defines the display text formatter function.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>textFormatter</code></returns>
				public extern virtual object getTextFormatter();

				/// <summary>
				/// Sets a new value for property {@link #getTextFormatter textFormatter}.
				/// 
				/// Defines the display text formatter function.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="oTextFormatter">New value for property <code>textFormatter</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setTextFormatter(object oTextFormatter);

				#endregion

				#region Methods for Property suggestionRowValidator

				/// <summary>
				/// Gets current value of property {@link #getSuggestionRowValidator suggestionRowValidator}.
				/// 
				/// Defines the validation callback function called when a suggestion row gets selected.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>suggestionRowValidator</code></returns>
				public extern virtual object getSuggestionRowValidator();

				/// <summary>
				/// Sets a new value for property {@link #getSuggestionRowValidator suggestionRowValidator}.
				/// 
				/// Defines the validation callback function called when a suggestion row gets selected.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="oSuggestionRowValidator">New value for property <code>suggestionRowValidator</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setSuggestionRowValidator(object oSuggestionRowValidator);

				#endregion

				#region Methods for Property enableSuggestionsHighlighting

				/// <summary>
				/// Gets current value of property {@link #getEnableSuggestionsHighlighting enableSuggestionsHighlighting}.
				/// 
				/// Specifies whether the suggestions highlighting is enabled.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enableSuggestionsHighlighting</code></returns>
				public extern virtual bool getEnableSuggestionsHighlighting();

				/// <summary>
				/// Sets a new value for property {@link #getEnableSuggestionsHighlighting enableSuggestionsHighlighting}.
				/// 
				/// Specifies whether the suggestions highlighting is enabled.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnableSuggestionsHighlighting">New value for property <code>enableSuggestionsHighlighting</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input setEnableSuggestionsHighlighting(bool bEnableSuggestionsHighlighting);

				#endregion

				#region Methods for Aggregation suggestionItems

				/// <summary>
				/// Gets content of aggregation {@link #getSuggestionItems suggestionItems}.
				/// 
				/// SuggestItems are the items which will be shown in the suggestion popup. Changing this aggregation (by calling addSuggestionItem, insertSuggestionItem, removeSuggestionItem, removeAllSuggestionItems, destroySuggestionItems) after input is rendered will open/close the suggestion popup. o display suggestions with two text values, it is also possible to add sap.ui.core/ListItems as SuggestionItems (since 1.21.1). For the selected ListItem, only the first value is returned to the input field.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Item[] getSuggestionItems();

				/// <summary>
				/// Destroys suggestion items.
				/// </summary>
				/// <returns>this Input instance for chaining.</returns>
				public extern virtual sap.m.Input destroySuggestionItems();

				/// <summary>
				/// Inserts suggestion item.
				/// </summary>
				/// <param name="oItem">Suggestion item.</param>
				/// <param name="iIndex">Index to be inserted.</param>
				/// <returns>this Input instance for chaining.</returns>
				public extern virtual sap.m.Input insertSuggestionItem(sap.ui.core.Item oItem, int iIndex);

				/// <summary>
				/// Adds suggestion item.
				/// </summary>
				/// <param name="oItem">Suggestion item.</param>
				/// <returns>this Input instance for chaining.</returns>
				public extern virtual sap.m.Input addSuggestionItem(sap.ui.core.Item oItem);

				/// <summary>
				/// Removes suggestion item.
				/// </summary>
				/// <param name="oItem">Suggestion item.</param>
				/// <returns>Determines whether the suggestion item has been removed.</returns>
				public extern virtual bool removeSuggestionItem(sap.ui.core.Item oItem);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Item</code> in the aggregation {@link #getSuggestionItems suggestionItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oSuggestionItem">The suggestionItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfSuggestionItem(sap.ui.core.Item oSuggestionItem);

				/// <summary>
				/// Removes all suggestion items.
				/// </summary>
				/// <returns>Determines whether the suggestion items are removed.</returns>
				public extern virtual bool removeAllSuggestionItems();

				#endregion

				#region Methods for Aggregation suggestionColumns

				/// <summary>
				/// Gets content of aggregation {@link #getSuggestionColumns suggestionColumns}.
				/// 
				/// The suggestionColumns and suggestionRows are for tabular input suggestions. This aggregation allows for binding the table columns; for more details see the aggregation "suggestionRows".
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Column[] getSuggestionColumns();

				/// <summary>
				/// Destroys all the suggestionColumns in the aggregation {@link #getSuggestionColumns suggestionColumns}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input destroySuggestionColumns();

				/// <summary>
				/// Inserts a suggestionColumn into the aggregation {@link #getSuggestionColumns suggestionColumns}.
				/// </summary>
				/// <param name="oSuggestionColumn">The suggestionColumn to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the suggestionColumn should be inserted at; for a negative value of <code>iIndex</code>, the suggestionColumn is inserted at position 0; for a value greater than the current size of the aggregation, the suggestionColumn is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input insertSuggestionColumn(sap.m.Column oSuggestionColumn, int iIndex);

				/// <summary>
				/// Adds some suggestionColumn to the aggregation {@link #getSuggestionColumns suggestionColumns}.
				/// </summary>
				/// <param name="oSuggestionColumn">The suggestionColumn to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input addSuggestionColumn(sap.m.Column oSuggestionColumn);

				/// <summary>
				/// Removes a suggestionColumn from the aggregation {@link #getSuggestionColumns suggestionColumns}.
				/// </summary>
				/// <param name="vSuggestionColumn">The suggestionColumn to remove or its index or id</param>
				/// <returns>The removed suggestionColumn or <code>null</code></returns>
				public extern virtual sap.m.Column removeSuggestionColumn(Union<int, string, sap.m.Column> vSuggestionColumn);

				/// <summary>
				/// Checks for the provided <code>sap.m.Column</code> in the aggregation {@link #getSuggestionColumns suggestionColumns}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oSuggestionColumn">The suggestionColumn whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfSuggestionColumn(sap.m.Column oSuggestionColumn);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getSuggestionColumns suggestionColumns}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Column[] removeAllSuggestionColumns();

				/// <summary>
				/// Binds aggregation {@link #getSuggestionColumns suggestionColumns} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input bindSuggestionColumns(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getSuggestionColumns suggestionColumns} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input unbindSuggestionColumns();

				#endregion

				#region Methods for Aggregation suggestionRows

				/// <summary>
				/// Gets content of aggregation {@link #getSuggestionRows suggestionRows}.
				/// 
				/// The suggestionColumns and suggestionRows are for tabular input suggestions. This aggregation allows for binding the table cells. The items of this aggregation are to be bound directly or to set in the suggest event method. Note: If this aggregation is filled, the aggregation suggestionItems will be ignored.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ColumnListItem[] getSuggestionRows();

				/// <summary>
				/// Destroys all suggestion rows.
				/// </summary>
				/// <returns>this Input instance for chaining.</returns>
				public extern virtual sap.m.Input destroySuggestionRows();

				/// <summary>
				/// Inserts suggestion row.
				/// </summary>
				/// <param name="oItem">Suggestion row</param>
				/// <param name="iIndex">Row index.</param>
				/// <returns>this Input instance for chaining.</returns>
				public extern virtual sap.m.Input insertSuggestionRow(sap.ui.core.Item oItem, int iIndex);

				/// <summary>
				/// Adds suggestion row.
				/// </summary>
				/// <param name="oItem">Suggestion item.</param>
				/// <returns>this Input instance for chaining.</returns>
				public extern virtual sap.m.Input addSuggestionRow(sap.ui.core.Item oItem);

				/// <summary>
				/// Removes suggestion row.
				/// </summary>
				/// <param name="oItem">Suggestion row.</param>
				/// <returns>Determines whether the suggestion row is removed.</returns>
				public extern virtual bool removeSuggestionRow(sap.ui.core.Item oItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.ColumnListItem</code> in the aggregation {@link #getSuggestionRows suggestionRows}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oSuggestionRow">The suggestionRow whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfSuggestionRow(sap.m.ColumnListItem oSuggestionRow);

				/// <summary>
				/// Removes all suggestion rows.
				/// </summary>
				/// <returns>Determines whether the suggestion rows are removed.</returns>
				public extern virtual bool removeAllSuggestionRows();

				/// <summary>
				/// Binds aggregation {@link #getSuggestionRows suggestionRows} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input bindSuggestionRows(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getSuggestionRows suggestionRows} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input unbindSuggestionRows();

				#endregion

				#region Methods for Aggregation _valueHelpIcon

				#endregion

				#region Methods for Association selectedItem

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedItem selectedItem}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedItem();

				/// <summary>
				/// Sets the <code>selectedItem</code> association.
				/// </summary>
				/// <param name="oItem">New value for the <code>selectedItem</code> association. Default value is <code>null</code>. If an ID of a <code>sap.ui.core.Item</code> is given, the item with this ID becomes the <code>selectedItem</code> association. Alternatively, a <code>sap.ui.core.Item</code> instance may be given or <code>null</code> to clear the selection.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Input setSelectedItem(sap.ui.core.Item oItem);

				#endregion

				#region Methods for Association selectedRow

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedRow selectedRow}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedRow();

				/// <summary>
				/// Sets the <code>selectedRow</code> association. Default value is <code>null</code>.
				/// </summary>
				/// <param name="oListItem">New value for the <code>selectedRow</code> association. If an ID of a <code>sap.m.ColumnListItem</code> is given, the item with this ID becomes the <code>selectedRow</code> association. Alternatively, a <code>sap.m.ColumnListItem</code> instance may be given or <code>null</code> to clear the selection.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Input setSelectedRow(sap.m.ColumnListItem oListItem);

				#endregion

				#region Methods for Event liveChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when the value of the input is changed - e.g. at each keypress
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Input</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachLiveChange(object oData, sap.m.Input.LiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when the value of the input is changed - e.g. at each keypress
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachLiveChange(object oData, sap.m.Input.LiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when the value of the input is changed - e.g. at each keypress
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachLiveChange(sap.m.Input.LiveChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when the value of the input is changed - e.g. at each keypress
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Input</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachLiveChange(sap.m.Input.LiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.m.Input</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input detachLiveChange(sap.m.Input.LiveChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input fireLiveChange(sap.m.Input.LiveChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input fireLiveChange();

				#endregion

				#region Methods for Event valueHelpRequest

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:valueHelpRequest valueHelpRequest} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// When the value help indicator is clicked, this event will be fired.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Input</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachValueHelpRequest(object oData, sap.m.Input.ValueHelpRequestDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:valueHelpRequest valueHelpRequest} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// When the value help indicator is clicked, this event will be fired.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachValueHelpRequest(object oData, sap.m.Input.ValueHelpRequestDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:valueHelpRequest valueHelpRequest} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// When the value help indicator is clicked, this event will be fired.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachValueHelpRequest(sap.m.Input.ValueHelpRequestDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:valueHelpRequest valueHelpRequest} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// When the value help indicator is clicked, this event will be fired.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Input</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachValueHelpRequest(sap.m.Input.ValueHelpRequestDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:valueHelpRequest valueHelpRequest} event of this <code>sap.m.Input</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input detachValueHelpRequest(sap.m.Input.ValueHelpRequestDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:valueHelpRequest valueHelpRequest} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input fireValueHelpRequest(sap.m.Input.ValueHelpRequestInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:valueHelpRequest valueHelpRequest} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input fireValueHelpRequest();

				#endregion

				#region Methods for Event suggest

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when user types in the input and showSuggestion is set to true. Changing the suggestItems aggregation will show the suggestions within a popup.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Input</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSuggest(object oData, sap.m.Input.SuggestDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when user types in the input and showSuggestion is set to true. Changing the suggestItems aggregation will show the suggestions within a popup.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSuggest(object oData, sap.m.Input.SuggestDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when user types in the input and showSuggestion is set to true. Changing the suggestItems aggregation will show the suggestions within a popup.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSuggest(sap.m.Input.SuggestDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when user types in the input and showSuggestion is set to true. Changing the suggestItems aggregation will show the suggestions within a popup.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Input</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSuggest(sap.m.Input.SuggestDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:suggest suggest} event of this <code>sap.m.Input</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input detachSuggest(sap.m.Input.SuggestDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:suggest suggest} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input fireSuggest(sap.m.Input.SuggestInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:suggest suggest} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input fireSuggest();

				#endregion

				#region Methods for Event suggestionItemSelected

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggestionItemSelected suggestionItemSelected} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when suggestionItem shown in suggestion popup are selected. This event is only fired when showSuggestion is set to true and there are suggestionItems shown in the suggestion popup.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Input</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSuggestionItemSelected(object oData, sap.m.Input.SuggestionItemSelectedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggestionItemSelected suggestionItemSelected} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when suggestionItem shown in suggestion popup are selected. This event is only fired when showSuggestion is set to true and there are suggestionItems shown in the suggestion popup.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSuggestionItemSelected(object oData, sap.m.Input.SuggestionItemSelectedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggestionItemSelected suggestionItemSelected} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when suggestionItem shown in suggestion popup are selected. This event is only fired when showSuggestion is set to true and there are suggestionItems shown in the suggestion popup.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSuggestionItemSelected(sap.m.Input.SuggestionItemSelectedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggestionItemSelected suggestionItemSelected} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when suggestionItem shown in suggestion popup are selected. This event is only fired when showSuggestion is set to true and there are suggestionItems shown in the suggestion popup.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Input</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSuggestionItemSelected(sap.m.Input.SuggestionItemSelectedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:suggestionItemSelected suggestionItemSelected} event of this <code>sap.m.Input</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input detachSuggestionItemSelected(sap.m.Input.SuggestionItemSelectedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:suggestionItemSelected suggestionItemSelected} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input fireSuggestionItemSelected(sap.m.Input.SuggestionItemSelectedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:suggestionItemSelected suggestionItemSelected} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input fireSuggestionItemSelected();

				#endregion

				#region Methods for Event submit

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:submit submit} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when user presses the <code>Enter</code> key on the input.
				/// 
				/// <b>Note:</b> The event is fired independent of whether there was a change before or not. If a change was performed the event is fired after the change event. The event is also fired when an item of the select list is selected via <code>Enter</code>. The event is only fired on an input which allows text input (<code>editable</code>, <code>enabled</code> and not <code>valueHelpOnly</code>).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Input</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSubmit(object oData, sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:submit submit} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when user presses the <code>Enter</code> key on the input.
				/// 
				/// <b>Note:</b> The event is fired independent of whether there was a change before or not. If a change was performed the event is fired after the change event. The event is also fired when an item of the select list is selected via <code>Enter</code>. The event is only fired on an input which allows text input (<code>editable</code>, <code>enabled</code> and not <code>valueHelpOnly</code>).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSubmit(object oData, sap.m.ValueDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:submit submit} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when user presses the <code>Enter</code> key on the input.
				/// 
				/// <b>Note:</b> The event is fired independent of whether there was a change before or not. If a change was performed the event is fired after the change event. The event is also fired when an item of the select list is selected via <code>Enter</code>. The event is only fired on an input which allows text input (<code>editable</code>, <code>enabled</code> and not <code>valueHelpOnly</code>).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSubmit(sap.m.ValueDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:submit submit} event of this <code>sap.m.Input</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Input</code> itself.
				/// 
				/// This event is fired when user presses the <code>Enter</code> key on the input.
				/// 
				/// <b>Note:</b> The event is fired independent of whether there was a change before or not. If a change was performed the event is fired after the change event. The event is also fired when an item of the select list is selected via <code>Enter</code>. The event is only fired on an input which allows text input (<code>editable</code>, <code>enabled</code> and not <code>valueHelpOnly</code>).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Input</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input attachSubmit(sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:submit submit} event of this <code>sap.m.Input</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input detachSubmit(sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:submit submit} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input fireSubmit(sap.m.ValueInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:submit submit} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Input fireSubmit();

				#endregion

				#region Other methods

				/// <summary>
				/// Refreshes delayed items.
				/// </summary>
				public extern virtual void _refreshItemsDelayed();

				/// <summary>
				/// Cancels any pending suggestions.
				/// </summary>
				public extern virtual void cancelPendingSuggest();

				/// <summary>
				/// Clones input.
				/// </summary>
				/// <returns>Cloned input.</returns>
				public extern virtual sap.m.Input clone();

				/// <summary>
				/// Closes the suggestion list.
				/// </summary>
				public extern virtual void closeSuggestions();

				/// <summary>
				/// Creates a new subclass of class sap.m.Input with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Input with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Input with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Gets accessibility information for the input.
				/// </summary>
				/// <returns>Accesibility information.</returns>
				public extern override object getAccessibilityInfo();

				/// <summary>
				/// Gets the inner input DOM value.
				/// </summary>
				/// <returns>The value of the input.</returns>
				public extern virtual object getDOMValue();

				/// <summary>
				/// Returns a metadata object for class sap.m.Input.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Getter for property <code>showValueStateMessage</code>. Whether the value state message should be shown. This property is already available for sap.m.Input since 1.16.0.
				/// 
				/// Default value is <code>true</code>
				/// </summary>
				/// <returns>the value of property <code>showValueStateMessage</code></returns>
				public extern override bool getShowValueStateMessage();

				/// <summary>
				/// Gets the item with the given key from the aggregation <code>suggestionItems</code>. <b>Note:</b> If duplicate keys exist, the first item matching the key is returned.
				/// </summary>
				/// <param name="sKey">An item key that specifies the item to retrieve.</param>
				/// <returns>Suggestion item.</returns>
				public extern virtual sap.ui.core.Item getSuggestionItemByKey(string sKey);

				/// <summary>
				/// Gets the input value.
				/// </summary>
				/// <returns>Value of the input.</returns>
				public extern virtual sap.m.Input getValue();

				/// <summary>
				/// Getter for property <code>valueStateText</code>. The text which is shown in the value state message popup. If not specfied a default text is shown. This property is already available for sap.m.Input since 1.16.0.
				/// 
				/// Default value is empty/<code>undefined</code>
				/// </summary>
				/// <returns>the value of property <code>valueStateText</code></returns>
				public extern override string getValueStateText();

				/// <summary>
				/// Returns the width of the input.
				/// </summary>
				/// <returns>The current width or 100% as default.</returns>
				public extern virtual string getWidth();

				/// <summary>
				/// Invalidates the control.
				/// </summary>
				public extern override void invalidate();

				/// <summary>
				/// Overwrites the onAfterRendering.
				/// </summary>
				public extern override void onAfterRendering();

				/// <summary>
				/// Overwrites the onBeforeRendering.
				/// </summary>
				public extern override void onBeforeRendering();

				/// <summary>
				/// Event handler for the onFocusIn event.
				/// </summary>
				/// <param name="oEvent">On focus in event.</param>
				public extern virtual void onfocusin(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Event handler for user input.
				/// </summary>
				/// <param name="oEvent">User input.</param>
				public extern virtual void oninput(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Keyboard handler for the onMouseDown event.
				/// </summary>
				/// <param name="oEvent">Keyboard event.</param>
				public extern virtual void onmousedown(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Keyboard handler for down arrow key.
				/// </summary>
				/// <param name="oEvent">Keyboard event.</param>
				public extern virtual void onsapdown(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Keyboard handler for end key.
				/// </summary>
				/// <param name="oEvent">Keyboard event.</param>
				public extern virtual void onsapend(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Keyboard handler for enter key.
				/// </summary>
				/// <param name="oEvent">Keyboard event.</param>
				public extern virtual void onsapenter(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Keyboard handler for escape key.
				/// </summary>
				/// <param name="oEvent">Keyboard event.</param>
				public extern virtual void onsapescape(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Keyboard handler for the onFocusLeave event.
				/// </summary>
				/// <param name="oEvent">Keyboard event.</param>
				public extern virtual void onsapfocusleave(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Keyboard handler for home key.
				/// </summary>
				/// <param name="oEvent">Keyboard event.</param>
				public extern virtual void onsaphome(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Keyboard handler for page down key.
				/// </summary>
				/// <param name="oEvent">Keyboard event.</param>
				public extern virtual void onsappagedown(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Keyboard handler for page up key.
				/// </summary>
				/// <param name="oEvent">Keyboard event.</param>
				public extern virtual void onsappageup(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Keyboard handler for up arrow key.
				/// </summary>
				/// <param name="oEvent">Keyboard event.</param>
				public extern virtual void onsapup(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Fire valueHelpRequest event on tap.
				/// </summary>
				/// <param name="oEvent">Ontap event.</param>
				public extern virtual void ontap(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Hook method to prevent the change event from being fired when the text input field loses focus.
				/// </summary>
				/// <param name="oEvent">The event object.</param>
				/// <returns>Whether or not the change event should be prevented.</returns>
				public extern override bool preventChangeOnFocusLeave(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Hook method to prevent the change event from being fired when the text input field loses focus.
				/// </summary>
				/// <returns>Whether or not the change event should be prevented.</returns>
				public extern override bool preventChangeOnFocusLeave();

				/// <summary>
				/// Sets the inner input DOM value.
				/// </summary>
				/// <param name="value">Dom value which will be set.</param>
				public extern virtual void setDOMValue(string value);

				/// <summary>
				/// Sets a custom filter function for suggestions. The default is to check whether the first item text begins with the typed value. For one and two-value suggestions this callback function will operate on sap.ui.core.Item types, for tabular suggestions the function will operate on sap.m.ColumnListItem types.
				/// </summary>
				/// <param name="fnFilter">The filter function is called when displaying suggestion items and has two input parameters: the first one is the string that is currently typed in the input field and the second one is the item that is being filtered. Returning true will add this item to the popup, returning false will not display it.</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.Input setFilterFunction(object fnFilter);

				/// <summary>
				/// Sets a custom result filter function for tabular suggestions to select the text that is passed to the input field. Default is to check whether the first cell with a "text" property begins with the typed value. For one value and two-value suggestions this callback function is not called.
				/// </summary>
				/// <param name="fnFilter">The result function is called with one parameter: the sap.m.ColumnListItem that is selected. The function must return a result string that will be displayed as the input field's value.</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.Input setRowResultFunction(object fnFilter);

				/// <summary>
				/// Setter for property <code>showValueStateMessage</code>.
				/// 
				/// Default value is <code>true</code>
				/// </summary>
				/// <param name="bShowValueStateMessage">new value for property <code>showValueStateMessage</code></param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern override sap.m.InputBase setShowValueStateMessage(bool bShowValueStateMessage);

				/// <summary>
				/// Setter for property <code>value</code>.
				/// 
				/// Default value is empty/<code>undefined</code>.
				/// </summary>
				/// <param name="sValue">New value for property <code>value</code>.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Input setValue(string sValue);

				/// <summary>
				/// Setter for property <code>valueStateText</code>.
				/// 
				/// Default value is empty/<code>undefined</code>
				/// </summary>
				/// <param name="sValueStateText">new value for property <code>valueStateText</code></param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.InputBase setValueStateText(string sValueStateText);

				/// <summary>
				/// Defines the width of the input. Default value is 100%.
				/// </summary>
				/// <param name="sWidth">The new width of the input.</param>
				/// <returns>Sets the width of the Input.</returns>
				public extern virtual void setWidth(string sWidth);

				/// <summary>
				/// Updates the inner input field.
				/// </summary>
				public extern virtual void updateInputField();

				/// <summary>
				/// Update suggestion items.
				/// </summary>
				/// <returns>this Input instance for chaining.</returns>
				public extern virtual sap.m.Input updateSuggestionItems();

				#endregion

				#endregion

			}
		}
	}
}
