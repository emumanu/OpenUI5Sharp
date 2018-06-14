using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// Embeds standard HTML in an SAPUI5 control tree.
				/// 
				/// Security Hint: By default, the HTML content (property 'content') is not sanitized and therefore open to XSS attacks. Applications that want to show user defined input in an HTML control, should either sanitize the content on their own or activate automatic sanitizing through the {@link #setSanitizeContent sanitizeContent} property.
				/// 
				/// Although this control inherits the <code>tooltip</code> aggregation/property and the <code>hasStyleClass</code>, <code>addStyleClass</code>, <code>removeStyleClass</code> and <code>toggleStyleClass</code> methods from its base class, it doesn't support them. Instead, the defined HTML content can contain a tooltip (title attribute) or custom CSS classes.
				/// 
				/// For further hints about usage restrictions for this control, see also the documentation of the <code>content</code> property.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class HTML : sap.ui.core.Control
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
						/// HTML content to be displayed, defined as a string.
						/// 
						/// The content is converted to DOM nodes with a call to <code>new jQuery(content)</code>, so any restrictions for the jQuery constructor apply to the content of the HTML control as well.
						/// 
						/// Some of these restrictions (there might be others!) are: <ul> <li>the content must be enclosed in tags, pure text is not supported. </li> <li>if the content contains script tags, they will be executed but they will not appear in the resulting DOM tree. When the contained code tries to find the corresponding script tag, it will fail.</li> </ul>
						/// 
						/// Please consider to consult the jQuery documentation as well.
						/// 
						/// The HTML control currently doesn't prevent the usage of multiple root nodes in its DOM content (e.g. <code>setContent("&lt;div/>&lt;div/>")</code>), but this is not a guaranteed feature. The accepted content might be restricted to single root nodes in future versions. To notify applications about this fact, a warning is written in the log when multiple root nodes are used.
						/// 
						/// When changing the content dynamically, ensure that the ID of the root node remains the same as the HTML control's ID. Otherwise it cannot be guaranteed that certain lifecycle events take place.
						/// </summary>
						public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Whether existing DOM content is preferred over the given content string.
						/// 
						/// There are two scenarios where this flag is relevant (when set to true): <ul> <li>for the initial rendering: when an HTML control is added to a UIArea for the first time and if the root node of that UIArea contained DOM content with the same id as the HTML control, then that content will be used for rendering instead of any specified string content</li> <li>any follow-up rendering: when an HTML control is rendered for the second or any later time and the preferDOM flag is set, then the DOM from the first rendering is preserved and not replaced by the string content</li> </ul>
						/// 
						/// As preserving the existing DOM is the most common use case of the HTML control, the default value is true.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> preferDOM;

						/// <summary>
						/// Whether to run the HTML sanitizer once the content (HTML markup) is applied or not.
						/// 
						/// To configure allowed URLs please use the whitelist API via jQuery.sap.addUrlWhitelist.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> sanitizeContent;

						/// <summary>
						/// Specifies whether the control is visible. Invisible controls are not rendered.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visible;

						/// <summary>
						/// Fired after the HTML control has been rendered. Allows to manipulate the resulting DOM.
						/// 
						/// When the control doesn't have string content and no preserved DOM existed for this control, then this event will fire, but there won't be a DOM node for this control.
						/// </summary>
						public sap.ui.core.HTML.AfterRenderingDelegate afterRendering;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class AfterRenderingInfo
					{
						/// <summary>
						/// Whether the current DOM of the control has been preserved (true) or not (e.g. rendered from content property or it is an empty HTML control).
						/// </summary>
						public bool isPreservedDOM;

					}

					#endregion

					#region Delegates

					public delegate void AfterRenderingDelegate(sap.ui.@base.Event<sap.ui.core.HTML.AfterRenderingInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new HTML.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern HTML(string sId, sap.ui.core.HTML.Settings mSettings);

					/// <summary>
					/// Constructor for a new HTML.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern HTML(string sId);

					/// <summary>
					/// Constructor for a new HTML.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern HTML();

					/// <summary>
					/// Constructor for a new HTML.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern HTML(sap.ui.core.HTML.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property content

					/// <summary>
					/// Gets current value of property {@link #getContent content}.
					/// 
					/// HTML content to be displayed, defined as a string.
					/// 
					/// The content is converted to DOM nodes with a call to <code>new jQuery(content)</code>, so any restrictions for the jQuery constructor apply to the content of the HTML control as well.
					/// 
					/// Some of these restrictions (there might be others!) are: <ul> <li>the content must be enclosed in tags, pure text is not supported. </li> <li>if the content contains script tags, they will be executed but they will not appear in the resulting DOM tree. When the contained code tries to find the corresponding script tag, it will fail.</li> </ul>
					/// 
					/// Please consider to consult the jQuery documentation as well.
					/// 
					/// The HTML control currently doesn't prevent the usage of multiple root nodes in its DOM content (e.g. <code>setContent("&lt;div/>&lt;div/>")</code>), but this is not a guaranteed feature. The accepted content might be restricted to single root nodes in future versions. To notify applications about this fact, a warning is written in the log when multiple root nodes are used.
					/// 
					/// When changing the content dynamically, ensure that the ID of the root node remains the same as the HTML control's ID. Otherwise it cannot be guaranteed that certain lifecycle events take place.
					/// </summary>
					/// <returns>Value of property <code>content</code></returns>
					public extern virtual string getContent();

					/// <summary>
					/// Sets a new value for property {@link #getContent content}.
					/// 
					/// HTML content to be displayed, defined as a string.
					/// 
					/// The content is converted to DOM nodes with a call to <code>new jQuery(content)</code>, so any restrictions for the jQuery constructor apply to the content of the HTML control as well.
					/// 
					/// Some of these restrictions (there might be others!) are: <ul> <li>the content must be enclosed in tags, pure text is not supported. </li> <li>if the content contains script tags, they will be executed but they will not appear in the resulting DOM tree. When the contained code tries to find the corresponding script tag, it will fail.</li> </ul>
					/// 
					/// Please consider to consult the jQuery documentation as well.
					/// 
					/// The HTML control currently doesn't prevent the usage of multiple root nodes in its DOM content (e.g. <code>setContent("&lt;div/>&lt;div/>")</code>), but this is not a guaranteed feature. The accepted content might be restricted to single root nodes in future versions. To notify applications about this fact, a warning is written in the log when multiple root nodes are used.
					/// 
					/// When changing the content dynamically, ensure that the ID of the root node remains the same as the HTML control's ID. Otherwise it cannot be guaranteed that certain lifecycle events take place.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sContent">New value for property <code>content</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.HTML setContent(string sContent);

					#endregion

					#region Methods for Property preferDOM

					/// <summary>
					/// Gets current value of property {@link #getPreferDOM preferDOM}.
					/// 
					/// Whether existing DOM content is preferred over the given content string.
					/// 
					/// There are two scenarios where this flag is relevant (when set to true): <ul> <li>for the initial rendering: when an HTML control is added to a UIArea for the first time and if the root node of that UIArea contained DOM content with the same id as the HTML control, then that content will be used for rendering instead of any specified string content</li> <li>any follow-up rendering: when an HTML control is rendered for the second or any later time and the preferDOM flag is set, then the DOM from the first rendering is preserved and not replaced by the string content</li> </ul>
					/// 
					/// As preserving the existing DOM is the most common use case of the HTML control, the default value is true.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>preferDOM</code></returns>
					public extern virtual bool getPreferDOM();

					/// <summary>
					/// Sets a new value for property {@link #getPreferDOM preferDOM}.
					/// 
					/// Whether existing DOM content is preferred over the given content string.
					/// 
					/// There are two scenarios where this flag is relevant (when set to true): <ul> <li>for the initial rendering: when an HTML control is added to a UIArea for the first time and if the root node of that UIArea contained DOM content with the same id as the HTML control, then that content will be used for rendering instead of any specified string content</li> <li>any follow-up rendering: when an HTML control is rendered for the second or any later time and the preferDOM flag is set, then the DOM from the first rendering is preserved and not replaced by the string content</li> </ul>
					/// 
					/// As preserving the existing DOM is the most common use case of the HTML control, the default value is true.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bPreferDOM">New value for property <code>preferDOM</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.HTML setPreferDOM(bool bPreferDOM);

					#endregion

					#region Methods for Property sanitizeContent

					/// <summary>
					/// Gets current value of property {@link #getSanitizeContent sanitizeContent}.
					/// 
					/// Whether to run the HTML sanitizer once the content (HTML markup) is applied or not.
					/// 
					/// To configure allowed URLs please use the whitelist API via jQuery.sap.addUrlWhitelist.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>sanitizeContent</code></returns>
					public extern virtual bool getSanitizeContent();

					/// <summary>
					/// Sets a new value for property {@link #getSanitizeContent sanitizeContent}.
					/// 
					/// Whether to run the HTML sanitizer once the content (HTML markup) is applied or not.
					/// 
					/// To configure allowed URLs please use the whitelist API via jQuery.sap.addUrlWhitelist.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bSanitizeContent">New value for property <code>sanitizeContent</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.HTML setSanitizeContent(bool bSanitizeContent);

					#endregion

					#region Methods for Property visible

					/// <summary>
					/// Gets current value of property {@link #getVisible visible}.
					/// 
					/// Specifies whether the control is visible. Invisible controls are not rendered.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visible</code></returns>
					public extern override bool getVisible();

					/// <summary>
					/// Sets a new value for property {@link #getVisible visible}.
					/// 
					/// Specifies whether the control is visible. Invisible controls are not rendered.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisible">New value for property <code>visible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.HTML setVisible(bool bVisible);

					#endregion

					#region Methods for Event afterRendering

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.HTML</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.HTML</code> itself.
					/// 
					/// Fired after the HTML control has been rendered. Allows to manipulate the resulting DOM.
					/// 
					/// When the control doesn't have string content and no preserved DOM existed for this control, then this event will fire, but there won't be a DOM node for this control.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.HTML</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.HTML attachAfterRendering(object oData, sap.ui.core.HTML.AfterRenderingDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.HTML</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.HTML</code> itself.
					/// 
					/// Fired after the HTML control has been rendered. Allows to manipulate the resulting DOM.
					/// 
					/// When the control doesn't have string content and no preserved DOM existed for this control, then this event will fire, but there won't be a DOM node for this control.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.HTML attachAfterRendering(object oData, sap.ui.core.HTML.AfterRenderingDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.HTML</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.HTML</code> itself.
					/// 
					/// Fired after the HTML control has been rendered. Allows to manipulate the resulting DOM.
					/// 
					/// When the control doesn't have string content and no preserved DOM existed for this control, then this event will fire, but there won't be a DOM node for this control.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.HTML attachAfterRendering(sap.ui.core.HTML.AfterRenderingDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.HTML</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.HTML</code> itself.
					/// 
					/// Fired after the HTML control has been rendered. Allows to manipulate the resulting DOM.
					/// 
					/// When the control doesn't have string content and no preserved DOM existed for this control, then this event will fire, but there won't be a DOM node for this control.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.HTML</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.HTML attachAfterRendering(sap.ui.core.HTML.AfterRenderingDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.HTML</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.HTML detachAfterRendering(sap.ui.core.HTML.AfterRenderingDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:afterRendering afterRendering} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.HTML fireAfterRendering(sap.ui.core.HTML.AfterRenderingInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:afterRendering afterRendering} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.HTML fireAfterRendering();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.HTML with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.HTML with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.HTML with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <param name="sSuffix">Suffix of the Element to be retrieved or empty</param>
					/// <returns>The element's DOM reference or null</returns>
					public extern override dom.HTMLElement getDomRef(string sSuffix = "");

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.HTML.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Sets some new DOM content for this HTML control. The content will replace the existing content after the next rendering. Properties are not modified, but preferDOM should be set to true.
					/// </summary>
					/// <param name="oDom">the new DOM content</param>
					/// <returns><code>this</code> to facilitate method chaining</returns>
					public extern virtual sap.ui.core.HTML setDOMContent(dom.HTMLElement oDom);

					#endregion

					#endregion

				}
			}
		}
	}
}
