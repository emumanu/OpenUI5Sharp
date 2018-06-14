using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// The <code>Text</code> control can be used for embedding longer text paragraphs, that need text wrapping, into your app. If the configured text value contains HTML code or script tags, those will be escaped.<br> <b>Note: </b>Line breaks (\r\n, \n\r, \r, \n) will always be visualized except when the <code>wrapping</code> property is set to <code>false</code>. In addition, tabs (\t) and whitespace (" ") can be preserved by setting the <code>renderWhitespace</code> property to <code>true</code>
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class Text : sap.ui.core.Control, sap.ui.core.IShrinkable, sap.ui.core.IFormContent
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
					/// Determines the text to be displayed.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> text;

					/// <summary>
					/// Available options for the text direction are LTR and RTL. By default the control inherits the text direction from its parent control.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> textDirection;

					/// <summary>
					/// Enables text wrapping.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> wrapping;

					/// <summary>
					/// Sets the horizontal alignment of the text.
					/// </summary>
					public Union<sap.ui.core.TextAlign, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> textAlign;

					/// <summary>
					/// Sets the width of the Text control. By default, the Text control uses the full width available. Set this property to restrict the width to a custom value.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

					/// <summary>
					/// Limits the number of lines for wrapping texts.
					/// 
					/// <b>Note</b>: The multi-line overflow indicator depends on the browser line clamping support. For such browsers, this will be shown as ellipsis, for the other browsers the overflow will just be hidden.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> maxLines;

					/// <summary>
					/// Specifies how whitespace and tabs inside the control are handled. If true, whitespace will be preserved by the browser. Depending on wrapping property text will either only wrap on line breaks or wrap when necessary, and on line breaks.
					/// 
					/// <b>Note:</b> Special characters that can be used are : \t , \n and " " respectively Tab, New line and Space.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> renderWhitespace;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Text.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Text(string sId, sap.m.Text.Settings mSettings);

				/// <summary>
				/// Constructor for a new Text.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Text(string sId);

				/// <summary>
				/// Constructor for a new Text.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Text();

				/// <summary>
				/// Constructor for a new Text.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Text(sap.m.Text.Settings mSettings);

				#endregion

				#region Fields

				/// <summary>
				/// Determines per instance whether line height should be cached or not.
				/// 
				/// Default value is true.
				/// </summary>
				public bool cacheLineHeight;

				/// <summary>
				/// Ellipsis(...) text to indicate more text when clampText function is used.
				/// 
				/// Can be overwritten with 3dots(...) if fonts do not support this UTF-8 character.
				/// </summary>
				public string ellipsis;

				/// <summary>
				/// Defines whether browser supports native line clamp or not and if browser is Chrome
				/// </summary>
				public static object hasNativeLineClamp;

				/// <summary>
				/// Default line height value as a number when line height is normal.
				/// 
				/// This value is required during max height calculation for the browsers that do not support line clamping. It is better to define line height in CSS instead of "normal" to get consistent <code>maxLines</code> results since normal line height not only varies from browser to browser but it also varies from one font face to another and can also vary within a given face.
				/// </summary>
				public int normalLineHeight;

				#endregion

				#region Methods

				#region Methods for Property text

				/// <summary>
				/// Gets the text.
				/// </summary>
				/// <param name="bNormalize">Indication for normalized text.</param>
				/// <returns>Text value.</returns>
				public extern virtual string getText(bool bNormalize);

				/// <summary>
				/// Sets the text.
				/// </summary>
				/// <param name="sText">Text value.</param>
				/// <returns>this Text reference for chaining.</returns>
				public extern virtual sap.m.Text setText(string sText);

				/// <summary>
				/// Binds property {@link #getText text} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindProperty ManagedObject.bindProperty} for a detailed description of the possible properties of <code>oBindingInfo</code>
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Text bindText(object oBindingInfo);

				/// <summary>
				/// Unbinds property {@link #getText text} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Text unbindText();

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Available options for the text direction are LTR and RTL. By default the control inherits the text direction from its parent control.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Available options for the text direction are LTR and RTL. By default the control inherits the text direction from its parent control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Text setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Property wrapping

				/// <summary>
				/// Gets current value of property {@link #getWrapping wrapping}.
				/// 
				/// Enables text wrapping.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>wrapping</code></returns>
				public extern virtual bool getWrapping();

				/// <summary>
				/// Sets a new value for property {@link #getWrapping wrapping}.
				/// 
				/// Enables text wrapping.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bWrapping">New value for property <code>wrapping</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Text setWrapping(bool bWrapping);

				#endregion

				#region Methods for Property textAlign

				/// <summary>
				/// Gets current value of property {@link #getTextAlign textAlign}.
				/// 
				/// Sets the horizontal alignment of the text.
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <returns>Value of property <code>textAlign</code></returns>
				public extern virtual sap.ui.core.TextAlign getTextAlign();

				/// <summary>
				/// Sets a new value for property {@link #getTextAlign textAlign}.
				/// 
				/// Sets the horizontal alignment of the text.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <param name="sTextAlign">New value for property <code>textAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Text setTextAlign(sap.ui.core.TextAlign sTextAlign);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Sets the width of the Text control. By default, the Text control uses the full width available. Set this property to restrict the width to a custom value.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Sets the width of the Text control. By default, the Text control uses the full width available. Set this property to restrict the width to a custom value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Text setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property maxLines

				/// <summary>
				/// Gets current value of property {@link #getMaxLines maxLines}.
				/// 
				/// Limits the number of lines for wrapping texts.
				/// 
				/// <b>Note</b>: The multi-line overflow indicator depends on the browser line clamping support. For such browsers, this will be shown as ellipsis, for the other browsers the overflow will just be hidden.
				/// </summary>
				/// <returns>Value of property <code>maxLines</code></returns>
				public extern virtual int getMaxLines();

				/// <summary>
				/// Sets a new value for property {@link #getMaxLines maxLines}.
				/// 
				/// Limits the number of lines for wrapping texts.
				/// 
				/// <b>Note</b>: The multi-line overflow indicator depends on the browser line clamping support. For such browsers, this will be shown as ellipsis, for the other browsers the overflow will just be hidden.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="iMaxLines">New value for property <code>maxLines</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Text setMaxLines(int iMaxLines);

				#endregion

				#region Methods for Property renderWhitespace

				/// <summary>
				/// Gets current value of property {@link #getRenderWhitespace renderWhitespace}.
				/// 
				/// Specifies how whitespace and tabs inside the control are handled. If true, whitespace will be preserved by the browser. Depending on wrapping property text will either only wrap on line breaks or wrap when necessary, and on line breaks.
				/// 
				/// <b>Note:</b> Special characters that can be used are : \t , \n and " " respectively Tab, New line and Space.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>renderWhitespace</code></returns>
				public extern virtual bool getRenderWhitespace();

				/// <summary>
				/// Sets a new value for property {@link #getRenderWhitespace renderWhitespace}.
				/// 
				/// Specifies how whitespace and tabs inside the control are handled. If true, whitespace will be preserved by the browser. Depending on wrapping property text will either only wrap on line breaks or wrap when necessary, and on line breaks.
				/// 
				/// <b>Note:</b> Special characters that can be used are : \t , \n and " " respectively Tab, New line and Space.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bRenderWhitespace">New value for property <code>renderWhitespace</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Text setRenderWhitespace(bool bRenderWhitespace);

				#endregion

				#region Other methods

				/// <summary>
				/// Decides whether the control can use native line clamp feature or not.
				/// 
				/// In RTL mode native line clamp feature is not supported.
				/// </summary>
				/// <returns></returns>
				public extern virtual bool canUseNativeLineClamp();

				/// <summary>
				/// Sets the max height to support <code>maxLines</code> property.
				/// </summary>
				/// <param name="oDomRef">DOM reference of the text container.</param>
				/// <returns>Calculated max height value.</returns>
				public extern virtual int clampHeight(dom.HTMLElement oDomRef);

				/// <summary>
				/// Sets the max height to support <code>maxLines</code> property.
				/// </summary>
				/// <returns>Calculated max height value.</returns>
				public extern virtual int clampHeight();

				/// <summary>
				/// Clamps the wrapping text according to max lines and returns the found ellipsis position. Parameters can be used for better performance.
				/// </summary>
				/// <param name="oDomRef">DOM reference of the text container.</param>
				/// <param name="iStartPos">Start point of the ellipsis search.</param>
				/// <param name="iEndPos">End point of the ellipsis search.</param>
				/// <returns>Returns found ellipsis position or undefined.</returns>
				public extern virtual int? clampText(dom.HTMLElement oDomRef, int iStartPos, int iEndPos);

				/// <summary>
				/// Clamps the wrapping text according to max lines and returns the found ellipsis position. Parameters can be used for better performance.
				/// </summary>
				/// <param name="oDomRef">DOM reference of the text container.</param>
				/// <param name="iStartPos">Start point of the ellipsis search.</param>
				/// <returns>Returns found ellipsis position or undefined.</returns>
				public extern virtual int? clampText(dom.HTMLElement oDomRef, int iStartPos);

				/// <summary>
				/// Clamps the wrapping text according to max lines and returns the found ellipsis position. Parameters can be used for better performance.
				/// </summary>
				/// <param name="oDomRef">DOM reference of the text container.</param>
				/// <returns>Returns found ellipsis position or undefined.</returns>
				public extern virtual int? clampText(dom.HTMLElement oDomRef);

				/// <summary>
				/// Clamps the wrapping text according to max lines and returns the found ellipsis position. Parameters can be used for better performance.
				/// </summary>
				/// <returns>Returns found ellipsis position or undefined.</returns>
				public extern virtual int? clampText();

				/// <summary>
				/// Clamps the wrapping text according to max lines and returns the found ellipsis position. Parameters can be used for better performance.
				/// </summary>
				/// <param name="iStartPos">Start point of the ellipsis search.</param>
				/// <returns>Returns found ellipsis position or undefined.</returns>
				public extern virtual int? clampText(int iStartPos);

				/// <summary>
				/// Clamps the wrapping text according to max lines and returns the found ellipsis position. Parameters can be used for better performance.
				/// </summary>
				/// <param name="iStartPos">Start point of the ellipsis search.</param>
				/// <param name="iEndPos">End point of the ellipsis search.</param>
				/// <returns>Returns found ellipsis position or undefined.</returns>
				public extern virtual int? clampText(int iStartPos, int iEndPos);

				/// <summary>
				/// Creates a new subclass of class sap.m.Text with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Text with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Text with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Gets the accessibility information for the text.
				/// </summary>
				/// <returns>Accessibility information for the text.</returns>
				public extern override object getAccessibilityInfo();

				/// <summary>
				/// Returns the max height according to max lines and line height calculation. This is not calculated max height!
				/// </summary>
				/// <param name="oDomRef">DOM reference of the text container.</param>
				/// <returns>The clamp height of the text.</returns>
				public extern virtual int getClampHeight(dom.HTMLElement oDomRef);

				/// <summary>
				/// Returns the max height according to max lines and line height calculation. This is not calculated max height!
				/// </summary>
				/// <returns>The clamp height of the text.</returns>
				public extern virtual int getClampHeight();

				/// <summary>
				/// Caches and returns the computed line height of the text.
				/// </summary>
				/// <param name="oDomRef">DOM reference of the text container.</param>
				/// <returns>returns calculated line height</returns>
				public extern virtual int getLineHeight(dom.HTMLElement oDomRef);

				/// <summary>
				/// Caches and returns the computed line height of the text.
				/// </summary>
				/// <returns>returns calculated line height</returns>
				public extern virtual int getLineHeight();

				/// <summary>
				/// Returns a metadata object for class sap.m.Text.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns the text node container's DOM reference. This can be different from <code>getDomRef</code> when inner wrapper is needed.
				/// </summary>
				/// <returns>DOM reference of the text.</returns>
				public extern virtual dom.HTMLElement getTextDomRef();

				/// <summary>
				/// Determines whether max lines should be rendered or not.
				/// </summary>
				/// <returns>Max lines of the text.</returns>
				public extern virtual dom.HTMLElement hasMaxLines();

				/// <summary>
				/// Overwrites onAfterRendering
				/// </summary>
				public extern override void onAfterRendering();

				/// <summary>
				/// To prevent from the layout thrashing of the <code>textContent</code> call, this method first tries to set the <code>nodeValue</code> of the first child if it exists.
				/// </summary>
				/// <param name="oDomRef">DOM reference of the text node container.</param>
				/// <param name="sNodeValue">new Node value.</param>
				public extern static void setNodeValue(dom.HTMLElement oDomRef, string sNodeValue);

				/// <summary>
				/// To prevent from the layout thrashing of the <code>textContent</code> call, this method first tries to set the <code>nodeValue</code> of the first child if it exists.
				/// </summary>
				/// <param name="oDomRef">DOM reference of the text node container.</param>
				public extern static void setNodeValue(dom.HTMLElement oDomRef);

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
