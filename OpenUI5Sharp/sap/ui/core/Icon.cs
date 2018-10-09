using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// Icon uses embedded font instead of pixel image. Comparing to image, Icon is easily scalable, color can be altered live and various effects can be added using css.
				/// 
				/// A set of built in Icons is available and they can be fetched by calling sap.ui.core.IconPool.getIconURI and set this value to the src property on the Icon.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Icon")]
				public partial class Icon : sap.ui.core.Control, sap.ui.core.IFormContent
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
						/// This property should be set by the return value of calling sap.ui.core.IconPool.getIconURI with an Icon name parameter and an optional collection parameter which is required when using application extended Icons. A list of standard FontIcon is available here.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> src;

						/// <summary>
						/// Since Icon uses font, this property will be applied to the css font-size property on the rendered DOM element.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> size;

						/// <summary>
						/// The color of the Icon. If color is not defined here, the Icon inherits the color from its DOM parent.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> color;

						/// <summary>
						/// This color is shown when icon is hovered. This property has no visual effect when run on mobile device.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> hoverColor;

						/// <summary>
						/// This color is shown when icon is pressed/activated by the user.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> activeColor;

						/// <summary>
						/// This is the width of the DOM element which contains the Icon. Setting this property doesn't affect the size of the font. If you want to make the font bigger, increase the size property.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// This is the height of the DOM element which contains the Icon. Setting this property doesn't affect the size of the font. If you want to make the font bigger, increase the size property.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Background color of the Icon in normal state.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundColor;

						/// <summary>
						/// Background color for Icon in hover state. This property has no visual effect when run on mobile device.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> hoverBackgroundColor;

						/// <summary>
						/// Background color for Icon in active state.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> activeBackgroundColor;

						/// <summary>
						/// A decorative icon is included for design reasons. Accessibility tools will ignore decorative icons. Tab stop isn't affected by this property anymore and it's now controlled by the existence of press event handler and the noTabStop property.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> decorative;

						/// <summary>
						/// Decides whether a default Icon tooltip should be used if no tooltip is set.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> useIconTooltip;

						/// <summary>
						/// This defines the alternative text which is used for outputting the aria-label attribute on the DOM.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> alt;

						/// <summary>
						/// Defines whether the tab stop of icon is controlled by the existence of press event handler. When it's set to false, Icon control has tab stop when press event handler is attached. If it's set to true, Icon control never has tab stop no matter whether press event handler exists or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> noTabStop;

						/// <summary>
						/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// This event is fired when icon is pressed/activated by the user. When a handler is attached to this event, the Icon gets tab stop. If you want to disable this behavior, set the noTabStop property to true.
						/// </summary>
						public sap.ui.@base.EventDelegate press;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Icon.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Icon(string sId, sap.ui.core.Icon.Settings mSettings);

					/// <summary>
					/// Constructor for a new Icon.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Icon(string sId);

					/// <summary>
					/// Constructor for a new Icon.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Icon();

					/// <summary>
					/// Constructor for a new Icon.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Icon(sap.ui.core.Icon.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property src

					/// <summary>
					/// Gets current value of property {@link #getSrc src}.
					/// 
					/// This property should be set by the return value of calling sap.ui.core.IconPool.getIconURI with an Icon name parameter and an optional collection parameter which is required when using application extended Icons. A list of standard FontIcon is available here.
					/// </summary>
					/// <returns>Value of property <code>src</code></returns>
					public extern virtual sap.ui.core.URI getSrc();

					/// <summary>
					/// Sets a new value for property {@link #getSrc src}.
					/// 
					/// This property should be set by the return value of calling sap.ui.core.IconPool.getIconURI with an Icon name parameter and an optional collection parameter which is required when using application extended Icons. A list of standard FontIcon is available here.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSrc">New value for property <code>src</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setSrc(sap.ui.core.URI sSrc);

					#endregion

					#region Methods for Property size

					/// <summary>
					/// Gets current value of property {@link #getSize size}.
					/// 
					/// Since Icon uses font, this property will be applied to the css font-size property on the rendered DOM element.
					/// </summary>
					/// <returns>Value of property <code>size</code></returns>
					public extern virtual sap.ui.core.CSSSize getSize();

					/// <summary>
					/// Sets a new value for property {@link #getSize size}.
					/// 
					/// Since Icon uses font, this property will be applied to the css font-size property on the rendered DOM element.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSize">New value for property <code>size</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setSize(sap.ui.core.CSSSize sSize);

					#endregion

					#region Methods for Property color

					/// <summary>
					/// Gets current value of property {@link #getColor color}.
					/// 
					/// The color of the Icon. If color is not defined here, the Icon inherits the color from its DOM parent.
					/// </summary>
					/// <returns>Value of property <code>color</code></returns>
					public extern virtual string getColor();

					/// <summary>
					/// Sets a new value for property {@link #getColor color}.
					/// 
					/// The color of the Icon. If color is not defined here, the Icon inherits the color from its DOM parent.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sColor">New value for property <code>color</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setColor(string sColor);

					#endregion

					#region Methods for Property hoverColor

					/// <summary>
					/// Gets current value of property {@link #getHoverColor hoverColor}.
					/// 
					/// This color is shown when icon is hovered. This property has no visual effect when run on mobile device.
					/// </summary>
					/// <returns>Value of property <code>hoverColor</code></returns>
					public extern virtual string getHoverColor();

					/// <summary>
					/// Sets a new value for property {@link #getHoverColor hoverColor}.
					/// 
					/// This color is shown when icon is hovered. This property has no visual effect when run on mobile device.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHoverColor">New value for property <code>hoverColor</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setHoverColor(string sHoverColor);

					#endregion

					#region Methods for Property activeColor

					/// <summary>
					/// Gets current value of property {@link #getActiveColor activeColor}.
					/// 
					/// This color is shown when icon is pressed/activated by the user.
					/// </summary>
					/// <returns>Value of property <code>activeColor</code></returns>
					public extern virtual string getActiveColor();

					/// <summary>
					/// Sets a new value for property {@link #getActiveColor activeColor}.
					/// 
					/// This color is shown when icon is pressed/activated by the user.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sActiveColor">New value for property <code>activeColor</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setActiveColor(string sActiveColor);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// This is the width of the DOM element which contains the Icon. Setting this property doesn't affect the size of the font. If you want to make the font bigger, increase the size property.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// This is the width of the DOM element which contains the Icon. Setting this property doesn't affect the size of the font. If you want to make the font bigger, increase the size property.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// This is the height of the DOM element which contains the Icon. Setting this property doesn't affect the size of the font. If you want to make the font bigger, increase the size property.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// This is the height of the DOM element which contains the Icon. Setting this property doesn't affect the size of the font. If you want to make the font bigger, increase the size property.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property backgroundColor

					/// <summary>
					/// Gets current value of property {@link #getBackgroundColor backgroundColor}.
					/// 
					/// Background color of the Icon in normal state.
					/// </summary>
					/// <returns>Value of property <code>backgroundColor</code></returns>
					public extern virtual string getBackgroundColor();

					/// <summary>
					/// Sets a new value for property {@link #getBackgroundColor backgroundColor}.
					/// 
					/// Background color of the Icon in normal state.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sBackgroundColor">New value for property <code>backgroundColor</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setBackgroundColor(string sBackgroundColor);

					#endregion

					#region Methods for Property hoverBackgroundColor

					/// <summary>
					/// Gets current value of property {@link #getHoverBackgroundColor hoverBackgroundColor}.
					/// 
					/// Background color for Icon in hover state. This property has no visual effect when run on mobile device.
					/// </summary>
					/// <returns>Value of property <code>hoverBackgroundColor</code></returns>
					public extern virtual string getHoverBackgroundColor();

					/// <summary>
					/// Sets a new value for property {@link #getHoverBackgroundColor hoverBackgroundColor}.
					/// 
					/// Background color for Icon in hover state. This property has no visual effect when run on mobile device.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHoverBackgroundColor">New value for property <code>hoverBackgroundColor</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setHoverBackgroundColor(string sHoverBackgroundColor);

					#endregion

					#region Methods for Property activeBackgroundColor

					/// <summary>
					/// Gets current value of property {@link #getActiveBackgroundColor activeBackgroundColor}.
					/// 
					/// Background color for Icon in active state.
					/// </summary>
					/// <returns>Value of property <code>activeBackgroundColor</code></returns>
					public extern virtual string getActiveBackgroundColor();

					/// <summary>
					/// Sets a new value for property {@link #getActiveBackgroundColor activeBackgroundColor}.
					/// 
					/// Background color for Icon in active state.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sActiveBackgroundColor">New value for property <code>activeBackgroundColor</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setActiveBackgroundColor(string sActiveBackgroundColor);

					#endregion

					#region Methods for Property decorative

					/// <summary>
					/// Gets current value of property {@link #getDecorative decorative}.
					/// 
					/// A decorative icon is included for design reasons. Accessibility tools will ignore decorative icons. Tab stop isn't affected by this property anymore and it's now controlled by the existence of press event handler and the noTabStop property.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>decorative</code></returns>
					public extern virtual bool getDecorative();

					/// <summary>
					/// Sets a new value for property {@link #getDecorative decorative}.
					/// 
					/// A decorative icon is included for design reasons. Accessibility tools will ignore decorative icons. Tab stop isn't affected by this property anymore and it's now controlled by the existence of press event handler and the noTabStop property.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bDecorative">New value for property <code>decorative</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setDecorative(bool bDecorative);

					#endregion

					#region Methods for Property useIconTooltip

					/// <summary>
					/// Gets current value of property {@link #getUseIconTooltip useIconTooltip}.
					/// 
					/// Decides whether a default Icon tooltip should be used if no tooltip is set.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>useIconTooltip</code></returns>
					public extern virtual bool getUseIconTooltip();

					/// <summary>
					/// Sets a new value for property {@link #getUseIconTooltip useIconTooltip}.
					/// 
					/// Decides whether a default Icon tooltip should be used if no tooltip is set.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bUseIconTooltip">New value for property <code>useIconTooltip</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setUseIconTooltip(bool bUseIconTooltip);

					#endregion

					#region Methods for Property alt

					/// <summary>
					/// Gets current value of property {@link #getAlt alt}.
					/// 
					/// This defines the alternative text which is used for outputting the aria-label attribute on the DOM.
					/// </summary>
					/// <returns>Value of property <code>alt</code></returns>
					public extern virtual string getAlt();

					/// <summary>
					/// Sets a new value for property {@link #getAlt alt}.
					/// 
					/// This defines the alternative text which is used for outputting the aria-label attribute on the DOM.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sAlt">New value for property <code>alt</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setAlt(string sAlt);

					#endregion

					#region Methods for Property noTabStop

					/// <summary>
					/// Gets current value of property {@link #getNoTabStop noTabStop}.
					/// 
					/// Defines whether the tab stop of icon is controlled by the existence of press event handler. When it's set to false, Icon control has tab stop when press event handler is attached. If it's set to true, Icon control never has tab stop no matter whether press event handler exists or not.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>noTabStop</code></returns>
					public extern virtual bool getNoTabStop();

					/// <summary>
					/// Sets a new value for property {@link #getNoTabStop noTabStop}.
					/// 
					/// Defines whether the tab stop of icon is controlled by the existence of press event handler. When it's set to false, Icon control has tab stop when press event handler is attached. If it's set to true, Icon control never has tab stop no matter whether press event handler exists or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bNoTabStop">New value for property <code>noTabStop</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon setNoTabStop(bool bNoTabStop);

					#endregion

					#region Methods for Aggregation _invisibleText

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
					public extern virtual sap.ui.core.Icon addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

					#region Methods for Event press

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.core.Icon</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Icon</code> itself.
					/// 
					/// This event is fired when icon is pressed/activated by the user. When a handler is attached to this event, the Icon gets tab stop. If you want to disable this behavior, set the noTabStop property to true.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.Icon</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon attachPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.core.Icon</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Icon</code> itself.
					/// 
					/// This event is fired when icon is pressed/activated by the user. When a handler is attached to this event, the Icon gets tab stop. If you want to disable this behavior, set the noTabStop property to true.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon attachPress(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.core.Icon</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Icon</code> itself.
					/// 
					/// This event is fired when icon is pressed/activated by the user. When a handler is attached to this event, the Icon gets tab stop. If you want to disable this behavior, set the noTabStop property to true.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon attachPress(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.core.Icon</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Icon</code> itself.
					/// 
					/// This event is fired when icon is pressed/activated by the user. When a handler is attached to this event, the Icon gets tab stop. If you want to disable this behavior, set the noTabStop property to true.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.Icon</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon attachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.ui.core.Icon</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon detachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:press press} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon firePress(object mParameters);

					/// <summary>
					/// Fires event {@link #event:press press} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Icon firePress();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Icon with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Icon with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Icon with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					public extern virtual void getAccessibilityInfo();

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.Icon.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

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
}
