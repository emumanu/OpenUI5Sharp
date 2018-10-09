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
			/// A container control which has a header and content. <h3>Overview</h3> The panel is a container for grouping and displaying information. It can be collapsed to save space on the screen. <h4>Guidelines:</h4> <ul> <li>Nesting two or more panels is not recommended.</li> <li>Do not stack too many panels on one page.</li> </ul> <h3>Structure</h3> A panel consists of a title bar with a header text or header toolbar, an info toolbar (optional), and a content area. Using the <code>headerToolbar</code> aggregation, you can add a toolbar with any toolbar content (i.e. custom buttons, spacers, titles) inside the title bar.
			/// 
			/// There are two types of panels: fixed and expandable. Expendable panels are enabled by the <code>expandable</code> property. Furthermore you can define an expand animation with the property <code>expandAnimation</code>. <h3>Usage</h3> <h4>When to use:</h4> <ul> <li>You need to group or display information and want to give users the option of hiding this information.</li> <li>You want to show additional information on demand (for example, a panel could show optional input fields for an advanced search).</li> <li>You want to create a panel with controls that do not require user interaction and are not part of a form. Depending on the usage, change the <code>accessibleRole</code> property from the default <code>{@link sap.m.PanelAccessibleRole Form}</code> to <code>{@link sap.m.PanelAccessibleRole Region}</code> or <code>{@link sap.m.PanelAccessibleRole Complementary}</code>.</li> </ul> <h3>Responsive Behavior</h3> <ul> <li>If the width of the panel is set to 100% (default), the panel and its children are resized responsively, depending on its parent container.</li> <li>If the panel has a fixed defined height, it will take up the space, even if the panel is collapsed.</li> <li>When the panel is expandable, an arrow icon (pointing to the right) appears in front of the header.</li> <li>When the animation is activated, expand/collapse uses a smooth animation to open or close the content area.</li> <li>When the panel expands/collapses, the arrow icon rotates 90 degrees clockwise/counter-clockwise.</li> <li>When the height uses the default property <code>auto</code>, the height of the content area is automatically adjusted to match the height of its content.</li> <li>When the height of the panel is set to a fixed size, the content area can be scrolled through.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Panel")]
			public partial class Panel : sap.ui.core.Control
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
					/// This property is used to set the header text of the Panel. The "headerText" is visible in both expanded and collapsed state. Note: This property is overwritten by the "headerToolbar" aggregation.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerText;

					/// <summary>
					/// Determines the Panel width.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Determines the Panel height.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// Specifies whether the control is expandable. This allows for collapsing or expanding the infoToolbar (if available) and content of the Panel. Note: If expandable is set to false, the Panel will always be rendered expanded.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expandable;

					/// <summary>
					/// Indicates whether the Panel is expanded or not. If expanded is set to true, then both the infoToolbar (if available) and the content are rendered. If expanded is set to false, then only the headerText or headerToolbar is rendered.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expanded;

					/// <summary>
					/// Indicates whether the transition between the expanded and the collapsed state of the control is animated. By default the animation is enabled.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expandAnimation;

					/// <summary>
					/// This property is used to set the background color of the Panel. Depending on the theme you can change the state of the background from "Solid" over "Translucent" to "Transparent".
					/// </summary>
					public Union<sap.m.BackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

					/// <summary>
					/// This property is used to set the accessible aria role of the Panel. Depending on the usage you can change the role from the default <code>Form</code> to <code>Region</code> or <code>Complementary</code>.
					/// </summary>
					public Union<sap.m.PanelAccessibleRole, string, sap.ui.@base.ManagedObject.BindPropertyInfo> accessibleRole;

					/// <summary>
					/// Determines the content of the Panel. The content will be visible only when the Panel is expanded.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					/// <summary>
					/// This aggregation allows the use of a custom Toolbar as header for the Panel. The "headerToolbar" is visible in both expanded and collapsed state. Use it when you want to add extra controls for user interactions in the header. Note: This aggregation overwrites "headerText" property.
					/// </summary>
					public Union<sap.m.Toolbar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerToolbar;

					/// <summary>
					/// This aggregation allows the use of a custom Toolbar as information bar for the Panel. The "infoToolbar" is placed below the header and is visible only in expanded state. Use it when you want to show extra information to the user.
					/// </summary>
					public Union<sap.m.Toolbar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> infoToolbar;

					/// <summary>
					/// Indicates that the panel will expand or collapse.
					/// </summary>
					public sap.m.Panel.ExpandDelegate expand;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ExpandInfo
				{
					/// <summary>
					/// If the panel will expand, this is true. If the panel will collapse, this is false.
					/// </summary>
					public bool expand;

					/// <summary>
					/// Identifies whether the event is triggered by an user interaction or by calling setExpanded.
					/// </summary>
					public bool triggeredByInteraction;

				}

				#endregion

				#region Delegates

				public delegate void ExpandDelegate(sap.ui.@base.Event<sap.m.Panel.ExpandInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Panel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Panel(string sId, sap.m.Panel.Settings mSettings);

				/// <summary>
				/// Constructor for a new Panel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Panel(string sId);

				/// <summary>
				/// Constructor for a new Panel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Panel();

				/// <summary>
				/// Constructor for a new Panel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Panel(sap.m.Panel.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property headerText

				/// <summary>
				/// Gets current value of property {@link #getHeaderText headerText}.
				/// 
				/// This property is used to set the header text of the Panel. The "headerText" is visible in both expanded and collapsed state. Note: This property is overwritten by the "headerToolbar" aggregation.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>headerText</code></returns>
				public extern virtual string getHeaderText();

				/// <summary>
				/// Sets a new value for property {@link #getHeaderText headerText}.
				/// 
				/// This property is used to set the header text of the Panel. The "headerText" is visible in both expanded and collapsed state. Note: This property is overwritten by the "headerToolbar" aggregation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sHeaderText">New value for property <code>headerText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel setHeaderText(string sHeaderText);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Determines the Panel width.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets the width of the panel.
				/// </summary>
				/// <param name="sWidth">The width of the Panel as CSS size.</param>
				/// <returns>Pointer to the control instance to allow method chaining.</returns>
				public extern virtual sap.m.Panel setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// Determines the Panel height.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets the height of the panel.
				/// </summary>
				/// <param name="sHeight">The height of the panel as CSS size.</param>
				/// <returns>Pointer to the control instance to allow method chaining.</returns>
				public extern virtual sap.m.Panel setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property expandable

				/// <summary>
				/// Gets current value of property {@link #getExpandable expandable}.
				/// 
				/// Specifies whether the control is expandable. This allows for collapsing or expanding the infoToolbar (if available) and content of the Panel. Note: If expandable is set to false, the Panel will always be rendered expanded.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>expandable</code></returns>
				public extern virtual bool getExpandable();

				/// <summary>
				/// Sets the expandable property of the control.
				/// </summary>
				/// <param name="bExpandable">Defines whether the control is expandable or not.</param>
				/// <returns>Pointer to the control instance to allow method chaining.</returns>
				public extern virtual sap.m.Panel setExpandable(bool bExpandable);

				#endregion

				#region Methods for Property expanded

				/// <summary>
				/// Gets current value of property {@link #getExpanded expanded}.
				/// 
				/// Indicates whether the Panel is expanded or not. If expanded is set to true, then both the infoToolbar (if available) and the content are rendered. If expanded is set to false, then only the headerText or headerToolbar is rendered.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>expanded</code></returns>
				public extern virtual bool getExpanded();

				/// <summary>
				/// Sets the expanded property of the control.
				/// </summary>
				/// <param name="bExpanded">Defines whether control is expanded or not.</param>
				/// <returns>Pointer to the control instance to allow method chaining.</returns>
				public extern virtual sap.m.Panel setExpanded(bool bExpanded);

				#endregion

				#region Methods for Property expandAnimation

				/// <summary>
				/// Gets current value of property {@link #getExpandAnimation expandAnimation}.
				/// 
				/// Indicates whether the transition between the expanded and the collapsed state of the control is animated. By default the animation is enabled.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>expandAnimation</code></returns>
				public extern virtual bool getExpandAnimation();

				/// <summary>
				/// Sets a new value for property {@link #getExpandAnimation expandAnimation}.
				/// 
				/// Indicates whether the transition between the expanded and the collapsed state of the control is animated. By default the animation is enabled.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bExpandAnimation">New value for property <code>expandAnimation</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel setExpandAnimation(bool bExpandAnimation);

				#endregion

				#region Methods for Property backgroundDesign

				/// <summary>
				/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// This property is used to set the background color of the Panel. Depending on the theme you can change the state of the background from "Solid" over "Translucent" to "Transparent".
				/// 
				/// Default value is <code>Translucent</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundDesign</code></returns>
				public extern virtual sap.m.BackgroundDesign getBackgroundDesign();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// This property is used to set the background color of the Panel. Depending on the theme you can change the state of the background from "Solid" over "Translucent" to "Transparent".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Translucent</code>.
				/// </summary>
				/// <param name="sBackgroundDesign">New value for property <code>backgroundDesign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel setBackgroundDesign(sap.m.BackgroundDesign sBackgroundDesign);

				#endregion

				#region Methods for Property accessibleRole

				/// <summary>
				/// Gets current value of property {@link #getAccessibleRole accessibleRole}.
				/// 
				/// This property is used to set the accessible aria role of the Panel. Depending on the usage you can change the role from the default <code>Form</code> to <code>Region</code> or <code>Complementary</code>.
				/// 
				/// Default value is <code>Form</code>.
				/// </summary>
				/// <returns>Value of property <code>accessibleRole</code></returns>
				public extern virtual sap.m.PanelAccessibleRole getAccessibleRole();

				/// <summary>
				/// Sets the accessibleRole property of the control.
				/// </summary>
				/// <param name="sRole">Defines the aria role of the control.</param>
				/// <returns>Pointer to the control instance to allow method chaining.</returns>
				public extern virtual sap.m.Panel setAccessibleRole(sap.m.PanelAccessibleRole sRole);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// Determines the content of the Panel. The content will be visible only when the Panel is expanded.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel addContent(sap.ui.core.Control oContent);

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

				#region Methods for Aggregation headerToolbar

				/// <summary>
				/// Gets content of aggregation {@link #getHeaderToolbar headerToolbar}.
				/// 
				/// This aggregation allows the use of a custom Toolbar as header for the Panel. The "headerToolbar" is visible in both expanded and collapsed state. Use it when you want to add extra controls for user interactions in the header. Note: This aggregation overwrites "headerText" property.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Toolbar getHeaderToolbar();

				/// <summary>
				/// Destroys the headerToolbar in the aggregation {@link #getHeaderToolbar headerToolbar}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel destroyHeaderToolbar();

				/// <summary>
				/// Sets the aggregated {@link #getHeaderToolbar headerToolbar}.
				/// </summary>
				/// <param name="oHeaderToolbar">The headerToolbar to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel setHeaderToolbar(sap.m.Toolbar oHeaderToolbar);

				#endregion

				#region Methods for Aggregation infoToolbar

				/// <summary>
				/// Gets content of aggregation {@link #getInfoToolbar infoToolbar}.
				/// 
				/// This aggregation allows the use of a custom Toolbar as information bar for the Panel. The "infoToolbar" is placed below the header and is visible only in expanded state. Use it when you want to show extra information to the user.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Toolbar getInfoToolbar();

				/// <summary>
				/// Destroys the infoToolbar in the aggregation {@link #getInfoToolbar infoToolbar}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel destroyInfoToolbar();

				/// <summary>
				/// Sets the aggregated {@link #getInfoToolbar infoToolbar}.
				/// </summary>
				/// <param name="oInfoToolbar">The infoToolbar to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel setInfoToolbar(sap.m.Toolbar oInfoToolbar);

				#endregion

				#region Methods for Event expand

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:expand expand} event of this <code>sap.m.Panel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Panel</code> itself.
				/// 
				/// Indicates that the panel will expand or collapse.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Panel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel attachExpand(object oData, sap.m.Panel.ExpandDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:expand expand} event of this <code>sap.m.Panel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Panel</code> itself.
				/// 
				/// Indicates that the panel will expand or collapse.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel attachExpand(object oData, sap.m.Panel.ExpandDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:expand expand} event of this <code>sap.m.Panel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Panel</code> itself.
				/// 
				/// Indicates that the panel will expand or collapse.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel attachExpand(sap.m.Panel.ExpandDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:expand expand} event of this <code>sap.m.Panel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Panel</code> itself.
				/// 
				/// Indicates that the panel will expand or collapse.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Panel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel attachExpand(sap.m.Panel.ExpandDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:expand expand} event of this <code>sap.m.Panel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel detachExpand(sap.m.Panel.ExpandDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:expand expand} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel fireExpand(sap.m.Panel.ExpandInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:expand expand} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Panel fireExpand();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.Panel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Panel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Panel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Panel.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
