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
				/// Represents a container with scroll functionality, that can be used for text and controls. The Panel does not layout the embedded controls.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Panel")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Panel</code> control.")]
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
						/// Determines the width of the Panel in CSS size.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Determines the height of the Panel in CSS size. Per default, the height for the Panel is automatically adjusted to the content. Dimension allows to explicitly specify the height.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Represents the state of the of the Panel (enabled or disabled)
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Determines the scroll position from left to right. Value "0" means leftmost position.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollLeft;

						/// <summary>
						/// Determines the scroll position from top to bottom. Value "0" means topmost position.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollTop;

						/// <summary>
						/// Determines whether the Panel will have padding. Padding is theme-dependent.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> applyContentPadding;

						/// <summary>
						/// Determines whether the Panel will be initially collapsed. When it is initially collapsed, the contents are not rendered. A collapsed Panel consumes less space than an expanded one.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> collapsed;

						/// <summary>
						/// Determines the background color. Note that color settings are theme-dependent.
						/// </summary>
						public Union<sap.ui.commons.enums.AreaDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> areaDesign;

						/// <summary>
						/// Determines if the Panel can have a box as border. Note that displaying borders is theme-dependent.
						/// </summary>
						public Union<sap.ui.commons.enums.BorderDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> borderDesign;

						/// <summary>
						/// Determines whether the Panel will have an icon for collapsing/expanding, or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showCollapseIcon;

						/// <summary>
						/// Specifies the text that is rendered in the Panel header. Can be used to create a simple titles that do not require an icon in the header.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Aggregates the controls that are contained in the Panel. It is recommended to use a layout control as single direct child. When the Panel dimensions are set, the child control may have width and height of 100%. When the dimensions are not set, the child defines the size of the Panel.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Aggregates the title element of the Panel. For text titles only, you alternatively could use setText() which also creates a title in the background.
						/// </summary>
						public Union<sap.ui.core.Title, string, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

						/// <summary>
						/// The buttons that shall be displayed in the Panel header
						/// </summary>
						public Union<sap.ui.commons.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> buttons;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Panel.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Panel(string sId, sap.ui.commons.Panel.Settings mSettings);

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
					public extern Panel(sap.ui.commons.Panel.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Determines the width of the Panel in CSS size.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets the width of the panel.
					/// </summary>
					/// <param name="sWidth">The width of the panel as CSS size.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.Panel setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Determines the height of the Panel in CSS size. Per default, the height for the Panel is automatically adjusted to the content. Dimension allows to explicitly specify the height.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets the height of the panel.
					/// </summary>
					/// <param name="sHeight">The height of the panel as CSS size.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.Panel setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Represents the state of the of the Panel (enabled or disabled)
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Property setter for the "enabled" state
					/// </summary>
					/// <param name="bEnabled">Whether the Panel should be enabled or not.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.Panel setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property scrollLeft

					/// <summary>
					/// Returns the scroll position of the panel in pixels from the left. Returns 0 if not rendered yet. Also internally updates the control property.
					/// </summary>
					/// <returns>The scroll position.</returns>
					public extern virtual int getScrollLeft();

					/// <summary>
					/// Sets the scroll position of the panel in pixels from the left.
					/// </summary>
					/// <param name="iPosition">The position to scroll to.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.Panel setScrollLeft(int iPosition);

					#endregion

					#region Methods for Property scrollTop

					/// <summary>
					/// Returns the scroll position of the panel in pixels from the top. Returns 0 if not rendered yet. Also internally updates the control property.
					/// </summary>
					/// <returns>The scroll position.</returns>
					public extern virtual int getScrollTop();

					/// <summary>
					/// Sets the scrolls position of the panel in pixels from the top.
					/// </summary>
					/// <param name="iPosition">The position to scroll to.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.Panel setScrollTop(int iPosition);

					#endregion

					#region Methods for Property applyContentPadding

					/// <summary>
					/// Gets current value of property {@link #getApplyContentPadding applyContentPadding}.
					/// 
					/// Determines whether the Panel will have padding. Padding is theme-dependent.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>applyContentPadding</code></returns>
					public extern virtual bool getApplyContentPadding();

					/// <summary>
					/// Property setter for the padding
					/// </summary>
					/// <param name="bPadding">Whether the Panel should have padding.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.Panel setApplyContentPadding(bool bPadding);

					#endregion

					#region Methods for Property collapsed

					/// <summary>
					/// Gets current value of property {@link #getCollapsed collapsed}.
					/// 
					/// Determines whether the Panel will be initially collapsed. When it is initially collapsed, the contents are not rendered. A collapsed Panel consumes less space than an expanded one.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>collapsed</code></returns>
					public extern virtual bool getCollapsed();

					/// <summary>
					/// Property setter for the "collapsed" state
					/// </summary>
					/// <param name="bCollapsed">Whether the Panel should be collapsed or not.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.Panel setCollapsed(bool bCollapsed);

					#endregion

					#region Methods for Property areaDesign

					/// <summary>
					/// Gets current value of property {@link #getAreaDesign areaDesign}.
					/// 
					/// Determines the background color. Note that color settings are theme-dependent.
					/// 
					/// Default value is <code>Fill</code>.
					/// </summary>
					/// <returns>Value of property <code>areaDesign</code></returns>
					public extern virtual sap.ui.commons.enums.AreaDesign getAreaDesign();

					/// <summary>
					/// Sets a new value for property {@link #getAreaDesign areaDesign}.
					/// 
					/// Determines the background color. Note that color settings are theme-dependent.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Fill</code>.
					/// </summary>
					/// <param name="sAreaDesign">New value for property <code>areaDesign</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Panel setAreaDesign(sap.ui.commons.enums.AreaDesign sAreaDesign);

					#endregion

					#region Methods for Property borderDesign

					/// <summary>
					/// Gets current value of property {@link #getBorderDesign borderDesign}.
					/// 
					/// Determines if the Panel can have a box as border. Note that displaying borders is theme-dependent.
					/// 
					/// Default value is <code>Box</code>.
					/// </summary>
					/// <returns>Value of property <code>borderDesign</code></returns>
					public extern virtual sap.ui.commons.enums.BorderDesign getBorderDesign();

					/// <summary>
					/// Sets a new value for property {@link #getBorderDesign borderDesign}.
					/// 
					/// Determines if the Panel can have a box as border. Note that displaying borders is theme-dependent.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Box</code>.
					/// </summary>
					/// <param name="sBorderDesign">New value for property <code>borderDesign</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Panel setBorderDesign(sap.ui.commons.enums.BorderDesign sBorderDesign);

					#endregion

					#region Methods for Property showCollapseIcon

					/// <summary>
					/// Gets current value of property {@link #getShowCollapseIcon showCollapseIcon}.
					/// 
					/// Determines whether the Panel will have an icon for collapsing/expanding, or not.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showCollapseIcon</code></returns>
					public extern virtual bool getShowCollapseIcon();

					/// <summary>
					/// Sets a new value for property {@link #getShowCollapseIcon showCollapseIcon}.
					/// 
					/// Determines whether the Panel will have an icon for collapsing/expanding, or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowCollapseIcon">New value for property <code>showCollapseIcon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Panel setShowCollapseIcon(bool bShowCollapseIcon);

					#endregion

					#region Methods for Property text

					/// <summary>
					/// Returns the text that is rendered in the Panel header. If a Title control was used it returns the text of the Title control.
					/// </summary>
					/// <returns>The text in the Panel header.</returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets the text that will be rendered in the Panel header.
					/// </summary>
					/// <param name="sText">The text to render in the header.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.Panel setText(string sText);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// Aggregates the controls that are contained in the Panel. It is recommended to use a layout control as single direct child. When the Panel dimensions are set, the child control may have width and height of 100%. When the dimensions are not set, the child defines the size of the Panel.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Panel destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Panel insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Panel addContent(sap.ui.core.Control oContent);

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

					#region Methods for Aggregation title

					/// <summary>
					/// Gets content of aggregation {@link #getTitle title}.
					/// 
					/// Aggregates the title element of the Panel. For text titles only, you alternatively could use setText() which also creates a title in the background.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Title getTitle();

					/// <summary>
					/// Destroys the title in the aggregation {@link #getTitle title}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Panel destroyTitle();

					/// <summary>
					/// Sets a Tille control that will be rendered in the Panel header.
					/// </summary>
					/// <param name="oTitle">The Title to render in the header.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.Panel setTitle(sap.ui.core.Title oTitle);

					#endregion

					#region Methods for Aggregation buttons

					/// <summary>
					/// Gets content of aggregation {@link #getButtons buttons}.
					/// 
					/// The buttons that shall be displayed in the Panel header
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.Button[] getButtons();

					/// <summary>
					/// Destroys all the buttons in the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Panel destroyButtons();

					/// <summary>
					/// Inserts a button into the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <param name="oButton">The button to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the button should be inserted at; for a negative value of <code>iIndex</code>, the button is inserted at position 0; for a value greater than the current size of the aggregation, the button is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Panel insertButton(sap.ui.commons.Button oButton, int iIndex);

					/// <summary>
					/// Adds some button to the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <param name="oButton">The button to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Panel addButton(sap.ui.commons.Button oButton);

					/// <summary>
					/// Removes a button from the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <param name="vButton">The button to remove or its index or id</param>
					/// <returns>The removed button or <code>null</code></returns>
					public extern virtual sap.ui.commons.Button removeButton(Union<int, string, sap.ui.commons.Button> vButton);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.Button</code> in the aggregation {@link #getButtons buttons}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oButton">The button whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfButton(sap.ui.commons.Button oButton);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getButtons buttons}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.Button[] removeAllButtons();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Panel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Panel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Panel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					public extern virtual void getFocusInfo();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Panel.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Sets the dimensions of the panel.
					/// </summary>
					/// <param name="sWidth">The width of the panel as CSS size.</param>
					/// <param name="sHeight">The height of the panel as CSS size.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.Panel setDimensions(sap.ui.core.CSSSize sWidth, sap.ui.core.CSSSize sHeight);

					#endregion

					#endregion

				}
			}
		}
	}
}
