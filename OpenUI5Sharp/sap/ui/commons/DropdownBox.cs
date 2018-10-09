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
				/// The control provides a field that allows end users to an entry out of a list of pre-defined items. The choosable items can be provided in the form of a complete <code>ListBox</code>, single <code>ListItems</code>.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.DropdownBox")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.ComboBox}")]
				public partial class DropdownBox : sap.ui.commons.ComboBox
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.ComboBox.Settings
					{
						/// <summary>
						/// Whether the DropdownBox's search help should be enabled.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> searchHelpEnabled;

						/// <summary>
						/// (optional) The text to use for the search help entry.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> searchHelpText;

						/// <summary>
						/// (optional) The additional Text to use for the search help entry.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> searchHelpAdditionalText;

						/// <summary>
						/// (optional) The URI of the icon to use for the search help entry.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> searchHelpIcon;

						/// <summary>
						/// Maximum number of history items in the list.
						/// 
						/// If 0 no history is displayed or stored. The history is locally stored on the client. Therefore do not activate this feature when this control handles confidential data.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxHistoryItems;

						/// <summary>
						/// Event fired whenever the configured searchHelpItem is clicked or the searchHelpItem is configured and F4 key is pressed.
						/// </summary>
						public sap.m.ValueDelegate searchHelp;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new DropdownBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern DropdownBox(string sId, sap.ui.commons.DropdownBox.Settings mSettings);

					/// <summary>
					/// Constructor for a new DropdownBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					public extern DropdownBox(string sId);

					/// <summary>
					/// Constructor for a new DropdownBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern DropdownBox();

					/// <summary>
					/// Constructor for a new DropdownBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern DropdownBox(sap.ui.commons.DropdownBox.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property searchHelpEnabled

					/// <summary>
					/// Gets current value of property {@link #getSearchHelpEnabled searchHelpEnabled}.
					/// 
					/// Whether the DropdownBox's search help should be enabled.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>searchHelpEnabled</code></returns>
					public extern virtual bool getSearchHelpEnabled();

					/// <summary>
					/// Overwrite of Setter for property <code>searchHelpEnabled</code>. This method accepts additional parameter to be compatiple with the previous functionality
					/// 
					/// Default value is <code>false</code>
					/// </summary>
					/// <param name="bEnabled">new value for property <code>searchHelpEnabled</code></param>
					/// <param name="sText">new value for property <code>searchHelpText</code></param>
					/// <param name="sAdditionalText">new value for property <code>searchHelpAdditionalText</code></param>
					/// <param name="sIcon">new value for property <code>searchHelpIcon</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox setSearchHelpEnabled(bool bEnabled, string sText, string sAdditionalText, string sIcon);

					#endregion

					#region Methods for Property searchHelpText

					/// <summary>
					/// Gets current value of property {@link #getSearchHelpText searchHelpText}.
					/// 
					/// (optional) The text to use for the search help entry.
					/// </summary>
					/// <returns>Value of property <code>searchHelpText</code></returns>
					public extern virtual string getSearchHelpText();

					/// <summary>
					/// Overwrite of Setter for property <code>searchHelpText</code>.
					/// 
					/// Default value is empty/<code>undefined</code>
					/// </summary>
					/// <param name="sSearchHelpText">new value for property <code>searchHelpText</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox setSearchHelpText(string sSearchHelpText);

					#endregion

					#region Methods for Property searchHelpAdditionalText

					/// <summary>
					/// Gets current value of property {@link #getSearchHelpAdditionalText searchHelpAdditionalText}.
					/// 
					/// (optional) The additional Text to use for the search help entry.
					/// </summary>
					/// <returns>Value of property <code>searchHelpAdditionalText</code></returns>
					public extern virtual string getSearchHelpAdditionalText();

					/// <summary>
					/// Overwrite of Setter for property <code>searchHelpAdditionalText</code>.
					/// 
					/// Default value is empty/<code>undefined</code>
					/// </summary>
					/// <param name="sSearchHelpAdditionalText">new value for property <code>searchHelpAdditionalText</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox setSearchHelpAdditionalText(string sSearchHelpAdditionalText);

					#endregion

					#region Methods for Property searchHelpIcon

					/// <summary>
					/// Gets current value of property {@link #getSearchHelpIcon searchHelpIcon}.
					/// 
					/// (optional) The URI of the icon to use for the search help entry.
					/// </summary>
					/// <returns>Value of property <code>searchHelpIcon</code></returns>
					public extern virtual sap.ui.core.URI getSearchHelpIcon();

					/// <summary>
					/// Overwrite of Setter for property <code>searchHelpIcon</code>.
					/// 
					/// Default value is empty/<code>undefined</code>
					/// </summary>
					/// <param name="sSearchHelpIcon">new value for property <code>searchHelpIcon</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox setSearchHelpIcon(sap.ui.core.URI sSearchHelpIcon);

					#endregion

					#region Methods for Property maxHistoryItems

					/// <summary>
					/// Gets current value of property {@link #getMaxHistoryItems maxHistoryItems}.
					/// 
					/// Maximum number of history items in the list.
					/// 
					/// If 0 no history is displayed or stored. The history is locally stored on the client. Therefore do not activate this feature when this control handles confidential data.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>maxHistoryItems</code></returns>
					public extern virtual int getMaxHistoryItems();

					/// <summary>
					/// Sets a new value for property {@link #getMaxHistoryItems maxHistoryItems}.
					/// 
					/// Maximum number of history items in the list.
					/// 
					/// If 0 no history is displayed or stored. The history is locally stored on the client. Therefore do not activate this feature when this control handles confidential data.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iMaxHistoryItems">New value for property <code>maxHistoryItems</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox setMaxHistoryItems(int iMaxHistoryItems);

					#endregion

					#region Methods for Event searchHelp

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:searchHelp searchHelp} event of this <code>sap.ui.commons.DropdownBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.DropdownBox</code> itself.
					/// 
					/// Event fired whenever the configured searchHelpItem is clicked or the searchHelpItem is configured and F4 key is pressed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.DropdownBox</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox attachSearchHelp(object oData, sap.m.ValueDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:searchHelp searchHelp} event of this <code>sap.ui.commons.DropdownBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.DropdownBox</code> itself.
					/// 
					/// Event fired whenever the configured searchHelpItem is clicked or the searchHelpItem is configured and F4 key is pressed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox attachSearchHelp(object oData, sap.m.ValueDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:searchHelp searchHelp} event of this <code>sap.ui.commons.DropdownBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.DropdownBox</code> itself.
					/// 
					/// Event fired whenever the configured searchHelpItem is clicked or the searchHelpItem is configured and F4 key is pressed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox attachSearchHelp(sap.m.ValueDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:searchHelp searchHelp} event of this <code>sap.ui.commons.DropdownBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.DropdownBox</code> itself.
					/// 
					/// Event fired whenever the configured searchHelpItem is clicked or the searchHelpItem is configured and F4 key is pressed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.DropdownBox</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox attachSearchHelp(sap.m.ValueDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:searchHelp searchHelp} event of this <code>sap.ui.commons.DropdownBox</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox detachSearchHelp(sap.m.ValueDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:searchHelp searchHelp} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox fireSearchHelp(sap.m.ValueInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:searchHelp searchHelp} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.DropdownBox fireSearchHelp();

					#endregion

					#region Other methods

					/// <summary>
					/// Using this method the history of the DropdownBox can be cleared. This might be necessary if the items of the DropdownBox have changed. Otherwise invalid items may appear in the history.
					/// </summary>
					public extern virtual void clearHistory();

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.DropdownBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.ComboBox.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.DropdownBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.ComboBox.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.DropdownBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.ComboBox.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.DropdownBox.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Extends the method inherited from sap.ui.core.Element by providing information on Search Help access (if needed)
					/// </summary>
					/// <returns>string tooltip or undefined</returns>
					public extern override string getTooltip_AsString();

					/// <summary>
					/// Ensure that handed in ListBoxes are taken from the visible UI immediately.
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onAfterRendering(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle the click event happening in the DropdownBox
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onclick(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle focusin event Ensures the text gets selected when focus gets into the field
					/// </summary>
					/// <param name="oEvent">the occuring event</param>
					public extern override void onfocusin(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle keydown event
					/// </summary>
					/// <param name="oEvent">the occuring event</param>
					public extern virtual void onkeydown(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle keypress event
					/// </summary>
					/// <param name="oEvent">the occuring event</param>
					public extern virtual void onkeypress(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle keyup event This must only be considered if it is from Backspace-key in IE or after paste. In case there is a keyup with a tab this results from being entered via tabbing and can be ignored, too.
					/// </summary>
					/// <param name="oEvent">the occuring event</param>
					public extern override void onkeyup(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle paste event
					/// </summary>
					/// <param name="oEvent">the occuring event</param>
					public extern virtual void onpaste(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle pseudo event onsapdelete. If triggered with open dropdown and current item provided by history feature, removes the selected item from this instance's history.
					/// </summary>
					/// <param name="oEvent">the occuring event</param>
					public extern virtual void onsapdelete(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle pseudo event onsaphome
					/// </summary>
					/// <param name="oEvent">the occuring event</param>
					public extern virtual void onsaphome(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Move the cursor one step to the left (and adapt selection)
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onsapleft(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Move the cursor one step to the right (and adapt selection)
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onsapright(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle sapshow pseudo events on the control
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern override void onsapshow(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle the select event happening in the DropdownBox
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onselect(jquery.JQuery.Event oEvent);

					#endregion

					#endregion

				}
			}
		}
	}
}
