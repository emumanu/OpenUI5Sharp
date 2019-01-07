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
			/// Displays an empty page with an icon and a header when certain conditions are met. <h3>Overview</h3> MessagePage is displayed when there is no data or matching content. There are different use cases where a MessagePage might be visualized, for example: <ul> <li>The search query returned no results</li> <li>The app contains no items</li> <li>There are too many items</li> <li>The application is loading</li> </ul> The layout is unchanged but the text and icon vary depending on the use case. <h3>Usage</h3> <b>Note:</b> The <code>MessagePage</code> is not intended to be used as a top-level control, but rather used within controls such as <code>NavContainer</code>, <code>App</code>, <code>Shell</code> or other container controls.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MessagePage")]
			public partial class MessagePage : sap.ui.core.Control
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
					/// Determines the main text displayed on the MessagePage.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Determines the detailed description that shows additional information on the MessagePage.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> description;

					/// <summary>
					/// Determines the title in the header of MessagePage.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Determines the visibility of the MessagePage header. Can be used to hide the header of the MessagePage when it's embedded in another page.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showHeader;

					/// <summary>
					/// Determines the visibility of the navigation button in MessagePage header.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showNavButton;

					/// <summary>
					/// Determines the icon displayed on the MessagePage.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// Defines the alt attribute of the icon displayed on the <code>MessagePage</code>.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconAlt;

					/// <summary>
					/// Determines the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

					/// <summary>
					/// Defines whether the value set in the <code>description</code> property is displayed as formatted text in HTML format.
					/// 
					/// For details regarding supported HTML tags, see {@link sap.m.FormattedText}
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableFormattedText;

					/// <summary>
					/// The (optional) custom Text control of this page. Use this aggregation when the "text" (sap.m.Text) control needs to be replaced with an sap.m.Link control. "text" and "textDirection" setters can be used for this aggregation.
					/// </summary>
					public Union<sap.m.Link, string, sap.ui.@base.ManagedObject.BindAggregationInfo> customText;

					/// <summary>
					/// The (optional) custom description control of this page. Use this aggregation when the "description" (sap.m.Text) control needs to be replaced with an sap.m.Link control. "description" and "textDirection" setters can be used for this aggregation.
					/// </summary>
					public Union<sap.m.Link, string, sap.ui.@base.ManagedObject.BindAggregationInfo> customDescription;

					/// <summary>
					/// The buttons displayed under the description text.
					/// 
					/// <b>Note:</b> Buttons added to this aggregation are both vertically and horizontally centered. Depending on the available space, they may be rendered on several lines.
					/// </summary>
					public Union<sap.m.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> buttons;

					/// <summary>
					/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// This event is fired when Nav Button is pressed.
					/// </summary>
					public sap.ui.@base.EventDelegate navButtonPress;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new MessagePage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MessagePage(string sId, sap.m.MessagePage.Settings mSettings);

				/// <summary>
				/// Constructor for a new MessagePage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern MessagePage(string sId);

				/// <summary>
				/// Constructor for a new MessagePage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern MessagePage();

				/// <summary>
				/// Constructor for a new MessagePage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MessagePage(sap.m.MessagePage.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Determines the main text displayed on the MessagePage.
				/// 
				/// Default value is <code>No matching items found.</code>.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// Determines the main text displayed on the MessagePage.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>No matching items found.</code>.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage setText(string sText);

				#endregion

				#region Methods for Property description

				/// <summary>
				/// Gets current value of property {@link #getDescription description}.
				/// 
				/// Determines the detailed description that shows additional information on the MessagePage.
				/// 
				/// Default value is <code>Check the filter settings.</code>.
				/// </summary>
				/// <returns>Value of property <code>description</code></returns>
				public extern virtual string getDescription();

				/// <summary>
				/// Sets a new value for property {@link #getDescription description}.
				/// 
				/// Determines the detailed description that shows additional information on the MessagePage.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Check the filter settings.</code>.
				/// </summary>
				/// <param name="sDescription">New value for property <code>description</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage setDescription(string sDescription);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Determines the title in the header of MessagePage.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Determines the title in the header of MessagePage.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage setTitle(string sTitle);

				#endregion

				#region Methods for Property showHeader

				/// <summary>
				/// Gets current value of property {@link #getShowHeader showHeader}.
				/// 
				/// Determines the visibility of the MessagePage header. Can be used to hide the header of the MessagePage when it's embedded in another page.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showHeader</code></returns>
				public extern virtual bool getShowHeader();

				/// <summary>
				/// Sets a new value for property {@link #getShowHeader showHeader}.
				/// 
				/// Determines the visibility of the MessagePage header. Can be used to hide the header of the MessagePage when it's embedded in another page.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowHeader">New value for property <code>showHeader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage setShowHeader(bool bShowHeader);

				#endregion

				#region Methods for Property showNavButton

				/// <summary>
				/// Gets current value of property {@link #getShowNavButton showNavButton}.
				/// 
				/// Determines the visibility of the navigation button in MessagePage header.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showNavButton</code></returns>
				public extern virtual bool getShowNavButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowNavButton showNavButton}.
				/// 
				/// Determines the visibility of the navigation button in MessagePage header.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowNavButton">New value for property <code>showNavButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage setShowNavButton(bool bShowNavButton);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Determines the icon displayed on the MessagePage.
				/// 
				/// Default value is <code>sap-icon://documents</code>.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Determines the icon displayed on the MessagePage.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>sap-icon://documents</code>.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property iconAlt

				/// <summary>
				/// Gets current value of property {@link #getIconAlt iconAlt}.
				/// 
				/// Defines the alt attribute of the icon displayed on the <code>MessagePage</code>.
				/// </summary>
				/// <returns>Value of property <code>iconAlt</code></returns>
				public extern virtual string getIconAlt();

				/// <summary>
				/// Sets a new value for property {@link #getIconAlt iconAlt}.
				/// 
				/// Defines the alt attribute of the icon displayed on the <code>MessagePage</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIconAlt">New value for property <code>iconAlt</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage setIconAlt(string sIconAlt);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Determines the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Determines the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Property enableFormattedText

				/// <summary>
				/// Gets current value of property {@link #getEnableFormattedText enableFormattedText}.
				/// 
				/// Defines whether the value set in the <code>description</code> property is displayed as formatted text in HTML format.
				/// 
				/// For details regarding supported HTML tags, see {@link sap.m.FormattedText}
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableFormattedText</code></returns>
				public extern virtual bool getEnableFormattedText();

				/// <summary>
				/// Sets a new value for property {@link #getEnableFormattedText enableFormattedText}.
				/// 
				/// Defines whether the value set in the <code>description</code> property is displayed as formatted text in HTML format.
				/// 
				/// For details regarding supported HTML tags, see {@link sap.m.FormattedText}
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableFormattedText">New value for property <code>enableFormattedText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage setEnableFormattedText(bool bEnableFormattedText);

				#endregion

				#region Methods for Aggregation customText

				/// <summary>
				/// Gets content of aggregation {@link #getCustomText customText}.
				/// 
				/// The (optional) custom Text control of this page. Use this aggregation when the "text" (sap.m.Text) control needs to be replaced with an sap.m.Link control. "text" and "textDirection" setters can be used for this aggregation.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Link getCustomText();

				/// <summary>
				/// Destroys the customText in the aggregation {@link #getCustomText customText}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage destroyCustomText();

				/// <summary>
				/// Sets the aggregated {@link #getCustomText customText}.
				/// </summary>
				/// <param name="oCustomText">The customText to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage setCustomText(sap.m.Link oCustomText);

				#endregion

				#region Methods for Aggregation customDescription

				/// <summary>
				/// Gets content of aggregation {@link #getCustomDescription customDescription}.
				/// 
				/// The (optional) custom description control of this page. Use this aggregation when the "description" (sap.m.Text) control needs to be replaced with an sap.m.Link control. "description" and "textDirection" setters can be used for this aggregation.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Link getCustomDescription();

				/// <summary>
				/// Destroys the customDescription in the aggregation {@link #getCustomDescription customDescription}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage destroyCustomDescription();

				/// <summary>
				/// Sets the aggregated {@link #getCustomDescription customDescription}.
				/// </summary>
				/// <param name="oCustomDescription">The customDescription to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage setCustomDescription(sap.m.Link oCustomDescription);

				#endregion

				#region Methods for Aggregation buttons

				/// <summary>
				/// Gets content of aggregation {@link #getButtons buttons}.
				/// 
				/// The buttons displayed under the description text.
				/// 
				/// <b>Note:</b> Buttons added to this aggregation are both vertically and horizontally centered. Depending on the available space, they may be rendered on several lines.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Button[] getButtons();

				/// <summary>
				/// Destroys all the buttons in the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage destroyButtons();

				/// <summary>
				/// Inserts a button into the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <param name="oButton">The button to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the button should be inserted at; for a negative value of <code>iIndex</code>, the button is inserted at position 0; for a value greater than the current size of the aggregation, the button is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage insertButton(sap.m.Button oButton, int iIndex);

				/// <summary>
				/// Adds some button to the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <param name="oButton">The button to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage addButton(sap.m.Button oButton);

				/// <summary>
				/// Removes a button from the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <param name="vButton">The button to remove or its index or id</param>
				/// <returns>The removed button or <code>null</code></returns>
				public extern virtual sap.m.Button removeButton(Union<int, string, sap.m.Button> vButton);

				/// <summary>
				/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getButtons buttons}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oButton">The button whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfButton(sap.m.Button oButton);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getButtons buttons}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Button[] removeAllButtons();

				#endregion

				#region Methods for Aggregation _internalHeader

				#endregion

				#region Methods for Aggregation _formattedText

				#endregion

				#region Methods for Aggregation _text

				#endregion

				#region Methods for Aggregation _description

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
				public extern virtual sap.m.MessagePage addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
				public extern virtual sap.m.MessagePage addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event navButtonPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.MessagePage</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePage</code> itself.
				/// 
				/// This event is fired when Nav Button is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePage</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage attachNavButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.MessagePage</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePage</code> itself.
				/// 
				/// This event is fired when Nav Button is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage attachNavButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.MessagePage</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePage</code> itself.
				/// 
				/// This event is fired when Nav Button is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage attachNavButtonPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.MessagePage</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePage</code> itself.
				/// 
				/// This event is fired when Nav Button is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePage</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage attachNavButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.MessagePage</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage detachNavButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:navButtonPress navButtonPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage fireNavButtonPress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:navButtonPress navButtonPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePage fireNavButtonPress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.MessagePage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessagePage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessagePage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.MessagePage.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				#endregion

				#endregion

			}
		}
	}
}
