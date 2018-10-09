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
			/// Horizontal container most commonly used to display buttons, labels, selects and various other input controls.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// By default, the <code>Toolbar</code> items are shrinkable if they have percent-based width (for example, {@link sap.m.Input} and {@link sap.m.Slider}) or implement the {@link sap.ui.core.IShrinkable} interface (for example, {@link sap.m.Text} and {@link sap.m.Label}). This behavior can be overridden by providing {@link sap.m.ToolbarLayoutData} for the <code>Toolbar</code> items.
			/// 
			/// <b>Note:</b> It is recommended that you use {@link sap.m.OverflowToolbar} over <code>sap.m.Toolbar</code>, unless you want to avoid the overflow behavior in favor of shrinking.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// You can add a visual separator between the preceding and succeeding {@link sap.m.Toolbar} item with the use of the {@link sap.m.ToolbarSeparator}. The separator is theme dependent and can be a padding, a margin or a line.
			/// 
			/// To add horizontal space between the <code>Toolbar</code> items, use the {@link sap.m.ToolbarSpacer}. You can define the width of the horizontal space or make it flexible to cover the remaining space between the <code>Toolbar</code> items (for example, to to push an item to the edge of the <code>Toolbar</code>.
			/// 
			/// <b>Note:</b> {@link sap.m.ToolbarLayoutData} should not be used together with {@link sap.m.ToolbarSpacer}.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Toolbar")]
			public partial class Toolbar : sap.ui.core.Control, sap.ui.core.Toolbar, sap.m.IBar
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
					/// Defines the width of the control. By default, Toolbar is a block element. If the width is not explicitly set, the control will assume its natural size.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Indicates that the whole toolbar is clickable. The Press event is fired only if Active is set to true. Note: This property should be used when there are no interactive controls inside the toolbar and the toolbar itself is meant to be interactive.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> active;

					/// <summary>
					/// Sets the enabled property of all controls defined in the content aggregation. Note: This property does not apply to the toolbar itself, but rather to its items.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

					/// <summary>
					/// Defines the height of the control. By default, the <code>height</code> property depends on the used theme and the <code>design</code> property.
					/// 
					/// <b>Note:</b> It is not recommended to use this property if the <code>sapMTBHeader-CTX</code> class is used
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// Defines the toolbar design.
					/// 
					/// <b>Note:</b> Design settings are theme-dependent. They also determine the default height of the toolbar.
					/// </summary>
					public Union<sap.m.ToolbarDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

					/// <summary>
					/// Defines the visual style of the <code>Toolbar</code>.
					/// 
					/// <b>Note:</b> The visual styles are theme-dependent.
					/// </summary>
					public Union<sap.m.ToolbarStyle, string, sap.ui.@base.ManagedObject.BindPropertyInfo> style;

					/// <summary>
					/// The content of the toolbar.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Fired when the user clicks on the toolbar, if the Active property is set to "true".
					/// </summary>
					public sap.m.Toolbar.PressDelegate press;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class PressInfo
				{
					/// <summary>
					/// The toolbar item that was pressed
					/// </summary>
					public sap.ui.core.Control srcControl;

				}

				#endregion

				#region Delegates

				public delegate void PressDelegate(sap.ui.@base.Event<sap.m.Toolbar.PressInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>Toolbar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Toolbar(string sId, sap.m.Toolbar.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>Toolbar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Toolbar(string sId);

				/// <summary>
				/// Constructor for a new <code>Toolbar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Toolbar();

				/// <summary>
				/// Constructor for a new <code>Toolbar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Toolbar(sap.m.Toolbar.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the width of the control. By default, Toolbar is a block element. If the width is not explicitly set, the control will assume its natural size.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the width of the control. By default, Toolbar is a block element. If the width is not explicitly set, the control will assume its natural size.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property active

				/// <summary>
				/// Gets current value of property {@link #getActive active}.
				/// 
				/// Indicates that the whole toolbar is clickable. The Press event is fired only if Active is set to true. Note: This property should be used when there are no interactive controls inside the toolbar and the toolbar itself is meant to be interactive.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>active</code></returns>
				public extern virtual bool getActive();

				/// <summary>
				/// Sets a new value for property {@link #getActive active}.
				/// 
				/// Indicates that the whole toolbar is clickable. The Press event is fired only if Active is set to true. Note: This property should be used when there are no interactive controls inside the toolbar and the toolbar itself is meant to be interactive.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bActive">New value for property <code>active</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar setActive(bool bActive);

				#endregion

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Sets the enabled property of all controls defined in the content aggregation. Note: This property does not apply to the toolbar itself, but rather to its items.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Sets the enabled property of all controls defined in the content aggregation. Note: This property does not apply to the toolbar itself, but rather to its items.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// Defines the height of the control. By default, the <code>height</code> property depends on the used theme and the <code>design</code> property.
				/// 
				/// <b>Note:</b> It is not recommended to use this property if the <code>sapMTBHeader-CTX</code> class is used
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// Defines the height of the control. By default, the <code>height</code> property depends on the used theme and the <code>design</code> property.
				/// 
				/// <b>Note:</b> It is not recommended to use this property if the <code>sapMTBHeader-CTX</code> class is used
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property design

				/// <summary>
				/// Gets current value of property {@link #getDesign design}.
				/// 
				/// Defines the toolbar design.
				/// 
				/// <b>Note:</b> Design settings are theme-dependent. They also determine the default height of the toolbar.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>design</code></returns>
				public extern virtual sap.m.ToolbarDesign getDesign();

				/// <summary>
				/// Sets a new value for property {@link #getDesign design}.
				/// 
				/// Defines the toolbar design.
				/// 
				/// <b>Note:</b> Design settings are theme-dependent. They also determine the default height of the toolbar.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <param name="sDesign">New value for property <code>design</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar setDesign(sap.m.ToolbarDesign sDesign);

				#endregion

				#region Methods for Property style

				/// <summary>
				/// Gets current value of property {@link #getStyle style}.
				/// 
				/// Defines the visual style of the <code>Toolbar</code>.
				/// 
				/// <b>Note:</b> The visual styles are theme-dependent.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <returns>Value of property <code>style</code></returns>
				public extern virtual sap.m.ToolbarStyle getStyle();

				/// <summary>
				/// Sets a new value for property {@link #getStyle style}.
				/// 
				/// Defines the visual style of the <code>Toolbar</code>.
				/// 
				/// <b>Note:</b> The visual styles are theme-dependent.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <param name="sStyle">New value for property <code>style</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar setStyle(sap.m.ToolbarStyle sStyle);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// The content of the toolbar.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar addContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes a content from the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="vContent">The content to remove or its index or id</param>
				/// <returns>The removed content or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oContent">The content whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getContent content}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllContent();

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
				public extern virtual sap.m.Toolbar addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.Toolbar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Toolbar</code> itself.
				/// 
				/// Fired when the user clicks on the toolbar, if the Active property is set to "true".
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Toolbar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar attachPress(object oData, sap.m.Toolbar.PressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.Toolbar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Toolbar</code> itself.
				/// 
				/// Fired when the user clicks on the toolbar, if the Active property is set to "true".
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar attachPress(object oData, sap.m.Toolbar.PressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.Toolbar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Toolbar</code> itself.
				/// 
				/// Fired when the user clicks on the toolbar, if the Active property is set to "true".
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar attachPress(sap.m.Toolbar.PressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.Toolbar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Toolbar</code> itself.
				/// 
				/// Fired when the user clicks on the toolbar, if the Active property is set to "true".
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Toolbar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar attachPress(sap.m.Toolbar.PressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.m.Toolbar</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar detachPress(sap.m.Toolbar.PressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar firePress(sap.m.Toolbar.PressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Toolbar firePress();

				#endregion

				#region Other methods

				/// <summary>
				/// Sets classes according to the context of the page. Possible contexts are header, footer and subheader.
				/// </summary>
				/// <returns><code>this</code> for chaining</returns>
				public extern virtual sap.m.IBar _applyContextClassFor();

				/// <summary>
				/// Sets HTML tag according to the context of the page. Possible contexts are header, footer and subheader.
				/// </summary>
				/// <returns><code>this</code> for chaining</returns>
				public extern virtual sap.m.IBar _applyTag();

				/// <summary>
				/// Sets classes and HTML tag according to the context of the page. Possible contexts are header, footer, subheader
				/// </summary>
				/// <returns><code>this</code> for chaining</returns>
				public extern virtual sap.m.IBar applyTagAndContextClassFor();

				/// <summary>
				/// Creates a new subclass of class sap.m.Toolbar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Toolbar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Toolbar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Gets the HTML tag of the root domref
				/// </summary>
				/// <returns>the HTML-tag</returns>
				public extern virtual sap.m.IBarHTMLTag getHTMLTag();

				/// <summary>
				/// Returns a metadata object for class sap.m.Toolbar.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns the first sap.m.Title control instance inside the toolbar for the accessibility
				/// </summary>
				/// <returns>The <code>sap.m.Title</code> instance or undefined</returns>
				public extern virtual sap.m.Title getTitleControl();

				/// <summary>
				/// Returns the first sap.m.Title control id inside the toolbar for the accessibility
				/// </summary>
				/// <returns>The <code>sap.m.Title</code> ID</returns>
				public extern virtual string getTitleId();

				/// <summary>
				/// Returns if the bar is sensitive to the container context. Implementation of the IBar interface
				/// </summary>
				/// <returns>isContextSensitive</returns>
				public extern virtual bool isContextSensitive();

				/// <summary>
				/// Sets the HTML tag of the root domref
				/// </summary>
				/// <param name="sTag"></param>
				/// <returns>this for chaining</returns>
				public extern virtual sap.m.IBar setHTMLTag(string sTag);

				#endregion

				#endregion

			}
		}
	}
}
