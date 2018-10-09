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
				/// The control is used for labeling other controls. The API provides formatting options, for example, for bold display or alignment. A label can have an icon.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Label")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Label</code> control.")]
				public partial class Label : sap.ui.core.Control, sap.ui.commons.ToolbarItem, sap.ui.core.Label
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
						/// Defines whether the labels are in bold format.
						/// </summary>
						public Union<sap.ui.commons.LabelDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

						/// <summary>
						/// Determines the text direction - right-to-left (RTL) and left-to-right (LTR).
						/// </summary>
						public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

						/// <summary>
						/// Specifies whether a line wrapping width shall be displayed when the text value is longer than the width is.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> wrapping;

						/// <summary>
						/// Determines the control width as common CSS-size (for example, px or % as unit).
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Determines the text to be displayed.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Determines the icon to be displayed in the control. This can be a URI to an image or an icon font URI.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Determines the alignment of the text. Available options are <code>Begin</code>, <code>Center</code>, <code>End</code>, <code>Left</code>, and <code>Right</code>.
						/// </summary>
						public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textAlign;

						/// <summary>
						/// Allows to enforce the required indicator even when the associated control doesn't have a getRequired method (a required property) or when the flag is not set. If the associated control has a required property, the values of both required flags are combined with the OR operator, so a Label can't override a required=true value.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> required;

						/// <summary>
						/// Determines whether the required indicator is at the beginning of the label (if set) or at the end (if not set).
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> requiredAtBegin;

						/// <summary>
						/// Defines the association to the labeled control. By default, the label is set the for the attribute to the ID of the labeled control. This can be changed with the implementation of function getIdForLabel on the labelled control.
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
					public extern Label(string sId, sap.ui.commons.Label.Settings mSettings);

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
					public extern Label(sap.ui.commons.Label.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property design

					/// <summary>
					/// Gets current value of property {@link #getDesign design}.
					/// 
					/// Defines whether the labels are in bold format.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <returns>Value of property <code>design</code></returns>
					public extern virtual sap.ui.commons.LabelDesign getDesign();

					/// <summary>
					/// Sets a new value for property {@link #getDesign design}.
					/// 
					/// Defines whether the labels are in bold format.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <param name="sDesign">New value for property <code>design</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Label setDesign(sap.ui.commons.LabelDesign sDesign);

					#endregion

					#region Methods for Property textDirection

					/// <summary>
					/// Gets current value of property {@link #getTextDirection textDirection}.
					/// 
					/// Determines the text direction - right-to-left (RTL) and left-to-right (LTR).
					/// 
					/// Default value is <code>Inherit</code>.
					/// </summary>
					/// <returns>Value of property <code>textDirection</code></returns>
					public extern virtual sap.ui.core.TextDirection getTextDirection();

					/// <summary>
					/// Sets a new value for property {@link #getTextDirection textDirection}.
					/// 
					/// Determines the text direction - right-to-left (RTL) and left-to-right (LTR).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Inherit</code>.
					/// </summary>
					/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Label setTextDirection(sap.ui.core.TextDirection sTextDirection);

					#endregion

					#region Methods for Property wrapping

					/// <summary>
					/// Gets current value of property {@link #getWrapping wrapping}.
					/// 
					/// Specifies whether a line wrapping width shall be displayed when the text value is longer than the width is.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>wrapping</code></returns>
					public extern virtual bool getWrapping();

					/// <summary>
					/// Sets a new value for property {@link #getWrapping wrapping}.
					/// 
					/// Specifies whether a line wrapping width shall be displayed when the text value is longer than the width is.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bWrapping">New value for property <code>wrapping</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Label setWrapping(bool bWrapping);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Determines the control width as common CSS-size (for example, px or % as unit).
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Determines the control width as common CSS-size (for example, px or % as unit).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Label setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// Determines the text to be displayed.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// Determines the text to be displayed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Label setText(string sText);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// Determines the icon to be displayed in the control. This can be a URI to an image or an icon font URI.
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// Determines the icon to be displayed in the control. This can be a URI to an image or an icon font URI.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Label setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property textAlign

					/// <summary>
					/// Gets current value of property {@link #getTextAlign textAlign}.
					/// 
					/// Determines the alignment of the text. Available options are <code>Begin</code>, <code>Center</code>, <code>End</code>, <code>Left</code>, and <code>Right</code>.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <returns>Value of property <code>textAlign</code></returns>
					public extern virtual sap.ui.core.TextAlign getTextAlign();

					/// <summary>
					/// Sets a new value for property {@link #getTextAlign textAlign}.
					/// 
					/// Determines the alignment of the text. Available options are <code>Begin</code>, <code>Center</code>, <code>End</code>, <code>Left</code>, and <code>Right</code>.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <param name="sTextAlign">New value for property <code>textAlign</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Label setTextAlign(sap.ui.core.TextAlign sTextAlign);

					#endregion

					#region Methods for Property required

					/// <summary>
					/// Gets current value of property {@link #getRequired required}.
					/// 
					/// Allows to enforce the required indicator even when the associated control doesn't have a getRequired method (a required property) or when the flag is not set. If the associated control has a required property, the values of both required flags are combined with the OR operator, so a Label can't override a required=true value.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>required</code></returns>
					public extern virtual bool getRequired();

					/// <summary>
					/// Sets a new value for property {@link #getRequired required}.
					/// 
					/// Allows to enforce the required indicator even when the associated control doesn't have a getRequired method (a required property) or when the flag is not set. If the associated control has a required property, the values of both required flags are combined with the OR operator, so a Label can't override a required=true value.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bRequired">New value for property <code>required</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Label setRequired(bool bRequired);

					#endregion

					#region Methods for Property requiredAtBegin

					/// <summary>
					/// Gets current value of property {@link #getRequiredAtBegin requiredAtBegin}.
					/// 
					/// Determines whether the required indicator is at the beginning of the label (if set) or at the end (if not set).
					/// </summary>
					/// <returns>Value of property <code>requiredAtBegin</code></returns>
					public extern virtual bool getRequiredAtBegin();

					/// <summary>
					/// Sets a new value for property {@link #getRequiredAtBegin requiredAtBegin}.
					/// 
					/// Determines whether the required indicator is at the beginning of the label (if set) or at the end (if not set).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="bRequiredAtBegin">New value for property <code>requiredAtBegin</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Label setRequiredAtBegin(bool bRequiredAtBegin);

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
					public extern virtual sap.ui.commons.Label setLabelFor(Union<sap.ui.core.ID, sap.ui.core.Control> oLabelFor);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Label with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Label with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Label with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					public extern virtual void getAccessibilityInfo();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Label.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
