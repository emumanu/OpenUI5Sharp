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
			/// The FormattedText control allows the usage of a limited set of tags for inline display of formatted text in HTML format.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.FormattedText")]
			public partial class FormattedText : sap.ui.core.Control
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
					/// Text in HTML format. The following tags are supported: <ul> <li><code>a</code></li> <li><code>abbr</code></li> <li><code>blockquote</code></li> <li><code>br</code></li> <li><code>cite</code></li> <li><code>code</code></li> <li><code>em</code></li> <li><code>h1</code></li> <li><code>h2</code></li> <li><code>h3</code></li> <li><code>h4</code></li> <li><code>h5</code></li> <li><code>h6</code></li> <li><code>p</code></li> <li><code>pre</code></li> <li><code>strong</code></li> <li><code>span</code></li> <li><code>u</code></li> <li><code>dl</code></li> <li><code>dt</code></li> <li><code>dl</code></li> <li><code>ul</code></li> <li><code>ol</code></li> <li><code>li</code></li> </ul> <p><code>class, style,</code> and <code>target</code> attributes are allowed. If <code>target</code> is not set, links open in a new window by default. <p>Only safe <code>href</code> attributes can be used. See {@link jQuery.sap.validateUrl}.
					/// 
					/// <b>Note:</b> Keep in mind that not supported HTML tags and the content nested inside them are both not rendered by the control.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> htmlText;

					/// <summary>
					/// Optional width of the control in CSS units.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Determines whether strings that appear to be links will be converted to HTML anchor tags, and what are the criteria for recognizing them.
					/// </summary>
					public Union<sap.m.LinkConversion, string, sap.ui.@base.ManagedObject.BindPropertyInfo> convertLinksToAnchorTags;

					/// <summary>
					/// Determines the <code>target</code> attribute of the generated HTML anchor tags.
					/// 
					/// <b>Note:</b> Applicable only if <code>ConvertLinksToAnchorTags</code> property is used with a value other than <code>sap.m.LinkConversion.None</code>. Options are the standard values for the <code>target</code> attribute of the HTML anchor tag: <code>_self</code>, <code>_top</code>, <code>_blank</code>, <code>_parent</code>, <code>_search</code>.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> convertedLinksDefaultTarget;

					/// <summary>
					/// Optional height of the control in CSS units.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new FormattedText.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern FormattedText(string sId, sap.m.FormattedText.Settings mSettings);

				/// <summary>
				/// Constructor for a new FormattedText.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern FormattedText(string sId);

				/// <summary>
				/// Constructor for a new FormattedText.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern FormattedText();

				/// <summary>
				/// Constructor for a new FormattedText.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern FormattedText(sap.m.FormattedText.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property htmlText

				/// <summary>
				/// Gets current value of property {@link #getHtmlText htmlText}.
				/// 
				/// Text in HTML format. The following tags are supported: <ul> <li><code>a</code></li> <li><code>abbr</code></li> <li><code>blockquote</code></li> <li><code>br</code></li> <li><code>cite</code></li> <li><code>code</code></li> <li><code>em</code></li> <li><code>h1</code></li> <li><code>h2</code></li> <li><code>h3</code></li> <li><code>h4</code></li> <li><code>h5</code></li> <li><code>h6</code></li> <li><code>p</code></li> <li><code>pre</code></li> <li><code>strong</code></li> <li><code>span</code></li> <li><code>u</code></li> <li><code>dl</code></li> <li><code>dt</code></li> <li><code>dl</code></li> <li><code>ul</code></li> <li><code>ol</code></li> <li><code>li</code></li> </ul> <p><code>class, style,</code> and <code>target</code> attributes are allowed. If <code>target</code> is not set, links open in a new window by default. <p>Only safe <code>href</code> attributes can be used. See {@link jQuery.sap.validateUrl}.
				/// 
				/// <b>Note:</b> Keep in mind that not supported HTML tags and the content nested inside them are both not rendered by the control.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>htmlText</code></returns>
				public extern virtual string getHtmlText();

				/// <summary>
				/// Defines the HTML text to be displayed.
				/// </summary>
				/// <param name="sText">HTML text as a string</param>
				/// <returns>this for chaining</returns>
				public extern virtual sap.m.FormattedText setHtmlText(string sText);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Optional width of the control in CSS units.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Optional width of the control in CSS units.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FormattedText setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property convertLinksToAnchorTags

				/// <summary>
				/// Gets current value of property {@link #getConvertLinksToAnchorTags convertLinksToAnchorTags}.
				/// 
				/// Determines whether strings that appear to be links will be converted to HTML anchor tags, and what are the criteria for recognizing them.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>convertLinksToAnchorTags</code></returns>
				public extern virtual sap.m.LinkConversion getConvertLinksToAnchorTags();

				/// <summary>
				/// Sets a new value for property {@link #getConvertLinksToAnchorTags convertLinksToAnchorTags}.
				/// 
				/// Determines whether strings that appear to be links will be converted to HTML anchor tags, and what are the criteria for recognizing them.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sConvertLinksToAnchorTags">New value for property <code>convertLinksToAnchorTags</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FormattedText setConvertLinksToAnchorTags(sap.m.LinkConversion sConvertLinksToAnchorTags);

				#endregion

				#region Methods for Property convertedLinksDefaultTarget

				/// <summary>
				/// Gets current value of property {@link #getConvertedLinksDefaultTarget convertedLinksDefaultTarget}.
				/// 
				/// Determines the <code>target</code> attribute of the generated HTML anchor tags.
				/// 
				/// <b>Note:</b> Applicable only if <code>ConvertLinksToAnchorTags</code> property is used with a value other than <code>sap.m.LinkConversion.None</code>. Options are the standard values for the <code>target</code> attribute of the HTML anchor tag: <code>_self</code>, <code>_top</code>, <code>_blank</code>, <code>_parent</code>, <code>_search</code>.
				/// 
				/// Default value is <code>_blank</code>.
				/// </summary>
				/// <returns>Value of property <code>convertedLinksDefaultTarget</code></returns>
				public extern virtual string getConvertedLinksDefaultTarget();

				/// <summary>
				/// Sets a new value for property {@link #getConvertedLinksDefaultTarget convertedLinksDefaultTarget}.
				/// 
				/// Determines the <code>target</code> attribute of the generated HTML anchor tags.
				/// 
				/// <b>Note:</b> Applicable only if <code>ConvertLinksToAnchorTags</code> property is used with a value other than <code>sap.m.LinkConversion.None</code>. Options are the standard values for the <code>target</code> attribute of the HTML anchor tag: <code>_self</code>, <code>_top</code>, <code>_blank</code>, <code>_parent</code>, <code>_search</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>_blank</code>.
				/// </summary>
				/// <param name="sConvertedLinksDefaultTarget">New value for property <code>convertedLinksDefaultTarget</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FormattedText setConvertedLinksDefaultTarget(string sConvertedLinksDefaultTarget);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// Optional height of the control in CSS units.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// Optional height of the control in CSS units.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FormattedText setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.FormattedText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.FormattedText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.FormattedText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.FormattedText.
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
