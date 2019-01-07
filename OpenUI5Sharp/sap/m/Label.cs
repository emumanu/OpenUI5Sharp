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
			/// Provides a textual label for other controls. Label appearance can be influenced by properties such as <code>textAlign</code>, <code>design</code>, <code>displayOnly</code> and <code>wrapping</code>. As of version 1.50 the default value of the <code>wrapping</code> property is set to <code>false</code>
			/// 
			/// Labels for required fields are marked with an asterisk. <h3>Overview</h3> Labels are used as titles for single controls or groups of controls. <h3>Usage</h3> <h4>When to use</h4> <ul> <li>It's recommended to use the <code>Label</code> in Form controls.</li> <li>Use title case for labels.</li> </ul> <h4>When not to use</h4> <ul> <li> It is not recommended to use labels in Bold.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Label")]
			public partial class Label : sap.ui.core.Control, sap.ui.core.Label, sap.ui.core.IShrinkable, sap.m.IOverflowToolbarContent
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
					/// Sets the design of a Label to either Standard or Bold.
					/// </summary>
					public Union<sap.m.LabelDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

					/// <summary>
					/// Determines the Label text to be displayed.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
					/// </summary>
					public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textAlign;

					/// <summary>
					/// Options for the text direction are RTL and LTR. Alternatively, the control can inherit the text direction from its parent container.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

					/// <summary>
					/// Determines the width of the label.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Indicates that user input is required for input control labeled by the sap.m.Label. When the property is set to true and associated input field is empty an asterisk character is added to the label text.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> required;

					/// <summary>
					/// Determines if the label is in displayOnly mode. Controls in this mode are neither interactive, nor editable, nor focusable, and not in the tab chain.
					/// 
					/// <b>Note:</b> This property should be used only in Form controls in preview mode.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayOnly;

					/// <summary>
					/// Determines the wrapping of the text within the <code>Label</code>. If set to true the <code>Label</code> will wrap, when set to false the <code>Label</code> will be truncated and replaced with ellipsis which is the default behavior.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> wrapping;

					/// <summary>
					/// Specifies the vertical alignment of the <code>Label</code> related to the tallest and lowest element on the line.
					/// </summary>
					public Union<sap.ui.core.VerticalAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> vAlign;

					/// <summary>
					/// Association to the labeled control. By default the label set the for attribute to the ID of the labeled control. This can be changed by implementing the function getIdForLabel on the labelled control.
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> labelFor;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Label.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Label(string sId, sap.m.Label.Settings mSettings);

				/// <summary>
				/// Constructor for a new Label.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Label(string sId);

				/// <summary>
				/// Constructor for a new Label.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Label();

				/// <summary>
				/// Constructor for a new Label.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Label(sap.m.Label.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property design

				/// <summary>
				/// Gets current value of property {@link #getDesign design}.
				/// 
				/// Sets the design of a Label to either Standard or Bold.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <returns>Value of property <code>design</code></returns>
				public extern virtual sap.m.LabelDesign getDesign();

				/// <summary>
				/// Sets a new value for property {@link #getDesign design}.
				/// 
				/// Sets the design of a Label to either Standard or Bold.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <param name="sDesign">New value for property <code>design</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Label setDesign(sap.m.LabelDesign sDesign);

				#endregion

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Determines the Label text to be displayed.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// Determines the Label text to be displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Label setText(string sText);

				#endregion

				#region Methods for Property textAlign

				/// <summary>
				/// Gets current value of property {@link #getTextAlign textAlign}.
				/// 
				/// Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <returns>Value of property <code>textAlign</code></returns>
				public extern virtual sap.ui.core.TextAlign getTextAlign();

				/// <summary>
				/// Sets a new value for property {@link #getTextAlign textAlign}.
				/// 
				/// Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <param name="sTextAlign">New value for property <code>textAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Label setTextAlign(sap.ui.core.TextAlign sTextAlign);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Options for the text direction are RTL and LTR. Alternatively, the control can inherit the text direction from its parent container.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Options for the text direction are RTL and LTR. Alternatively, the control can inherit the text direction from its parent container.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Label setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Determines the width of the label.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Determines the width of the label.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Label setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property required

				/// <summary>
				/// Gets current value of property {@link #getRequired required}.
				/// 
				/// Indicates that user input is required for input control labeled by the sap.m.Label. When the property is set to true and associated input field is empty an asterisk character is added to the label text.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>required</code></returns>
				public extern virtual bool getRequired();

				/// <summary>
				/// Sets a new value for property {@link #getRequired required}.
				/// 
				/// Indicates that user input is required for input control labeled by the sap.m.Label. When the property is set to true and associated input field is empty an asterisk character is added to the label text.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bRequired">New value for property <code>required</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Label setRequired(bool bRequired);

				#endregion

				#region Methods for Property displayOnly

				/// <summary>
				/// Gets current value of property {@link #getDisplayOnly displayOnly}.
				/// 
				/// Determines if the label is in displayOnly mode. Controls in this mode are neither interactive, nor editable, nor focusable, and not in the tab chain.
				/// 
				/// <b>Note:</b> This property should be used only in Form controls in preview mode.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>displayOnly</code></returns>
				public extern virtual bool getDisplayOnly();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayOnly displayOnly}.
				/// 
				/// Determines if the label is in displayOnly mode. Controls in this mode are neither interactive, nor editable, nor focusable, and not in the tab chain.
				/// 
				/// <b>Note:</b> This property should be used only in Form controls in preview mode.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bDisplayOnly">New value for property <code>displayOnly</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Label setDisplayOnly(bool bDisplayOnly);

				#endregion

				#region Methods for Property wrapping

				/// <summary>
				/// Gets current value of property {@link #getWrapping wrapping}.
				/// 
				/// Determines the wrapping of the text within the <code>Label</code>. If set to true the <code>Label</code> will wrap, when set to false the <code>Label</code> will be truncated and replaced with ellipsis which is the default behavior.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>wrapping</code></returns>
				public extern virtual bool getWrapping();

				/// <summary>
				/// Sets a new value for property {@link #getWrapping wrapping}.
				/// 
				/// Determines the wrapping of the text within the <code>Label</code>. If set to true the <code>Label</code> will wrap, when set to false the <code>Label</code> will be truncated and replaced with ellipsis which is the default behavior.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bWrapping">New value for property <code>wrapping</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Label setWrapping(bool bWrapping);

				#endregion

				#region Methods for Property vAlign

				/// <summary>
				/// Gets current value of property {@link #getVAlign vAlign}.
				/// 
				/// Specifies the vertical alignment of the <code>Label</code> related to the tallest and lowest element on the line.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>vAlign</code></returns>
				public extern virtual sap.ui.core.VerticalAlign getVAlign();

				/// <summary>
				/// Sets a new value for property {@link #getVAlign vAlign}.
				/// 
				/// Specifies the vertical alignment of the <code>Label</code> related to the tallest and lowest element on the line.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sVAlign">New value for property <code>vAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Label setVAlign(sap.ui.core.VerticalAlign sVAlign);

				#endregion

				#region Methods for Association labelFor

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getLabelFor labelFor}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getLabelFor();

				/// <summary>
				/// Sets the associated {@link #getLabelFor labelFor}.
				/// </summary>
				/// <param name="oLabelFor">ID of an element which becomes the new target of this labelFor association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Label setLabelFor(Union<sap.ui.core.ID, sap.ui.core.Control> oLabelFor);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.Label with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Label with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Label with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Provides the current accessibility state of the control.
				/// </summary>
				/// <returns>AccessibilityInfo of the <code>sap.m.Label</code></returns>
				public extern override object getAccessibilityInfo();

				/// <summary>
				/// Returns a metadata object for class sap.m.Label.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Enables the <code>sap.m.Label</code> to move inside the sap.m.OverflowToolbar. Required by the {@link sap.m.IOverflowToolbarContent} interface.
				/// </summary>
				/// <returns>Configuration information for the <code>sap.m.IOverflowToolbarContent</code> interface.</returns>
				public extern virtual object getOverflowToolbarConfig();

				/// <summary>
				/// Sets the tooltip of the <code>sap.m.Label</code>.
				/// </summary>
				/// <param name="sTooltip">Tooltip's value represented in string format.</param>
				/// <returns><code>this</code> pointer for chaining.</returns>
				public extern virtual sap.m.Label setTooltip(string sTooltip);

				#endregion

				#endregion

			}
		}
	}
}
