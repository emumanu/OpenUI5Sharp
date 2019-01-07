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
			/// The Title control represents a single line of text with explicit header / title semantics.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Title")]
			public partial class Title : sap.ui.core.Control, sap.ui.core.IShrinkable
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
					/// Defines the text which should be displayed as a title.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Defines the semantic level of the title. This information is e.g. used by assistive technologies like screenreaders to create a hierarchical site map for faster navigation. Depending on this setting either an HTML h1-h6 element is used or when using level <code>Auto</code> no explicit level information is written (HTML5 header element). This property does not influence the style of the control. Use the property <code>titleStyle</code> for this purpose instead.
					/// </summary>
					public Union<sap.ui.core.TitleLevel, string, sap.ui.@base.ManagedObject.BindPropertyInfo> level;

					/// <summary>
					/// Defines the style of the title. When using the <code>Auto</code> styling, the appearance of the title depends on the current position of the title (e.g. inside a <code>Toolbar</code>). This default behavior can be overridden by setting a different style explicitly. The actual appearance of the title and the different styles always depends on the theme being used.
					/// </summary>
					public Union<sap.ui.core.TitleLevel, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleStyle;

					/// <summary>
					/// Defines the width of the title.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Defines the alignment of the text within the title. <b>Note:</b> This property only has an effect if the overall width of the title control is larger than the displayed text.
					/// </summary>
					public Union<sap.ui.core.TextAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textAlign;

					/// <summary>
					/// Enables text wrapping. <b>Note:</b> Wrapping must only be activated if the surrounding container allows flexible heights.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> wrapping;

					/// <summary>
					/// Defines a relationship to a generic title description. If such a title element is associated, the properties text, level and tooltip (text only) of this element are consumed. The corresponding properties of the title control are ignored.
					/// </summary>
					public Union<sap.ui.core.Title, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Title control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Title(string sId, sap.m.Title.Settings mSettings);

				/// <summary>
				/// Constructor for a new Title control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				public extern Title(string sId);

				/// <summary>
				/// Constructor for a new Title control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Title();

				/// <summary>
				/// Constructor for a new Title control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Title(sap.m.Title.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Defines the text which should be displayed as a title.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// Defines the text which should be displayed as a title.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Title setText(string sText);

				#endregion

				#region Methods for Property level

				/// <summary>
				/// Gets current value of property {@link #getLevel level}.
				/// 
				/// Defines the semantic level of the title. This information is e.g. used by assistive technologies like screenreaders to create a hierarchical site map for faster navigation. Depending on this setting either an HTML h1-h6 element is used or when using level <code>Auto</code> no explicit level information is written (HTML5 header element). This property does not influence the style of the control. Use the property <code>titleStyle</code> for this purpose instead.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>level</code></returns>
				public extern virtual sap.ui.core.TitleLevel getLevel();

				/// <summary>
				/// Sets a new value for property {@link #getLevel level}.
				/// 
				/// Defines the semantic level of the title. This information is e.g. used by assistive technologies like screenreaders to create a hierarchical site map for faster navigation. Depending on this setting either an HTML h1-h6 element is used or when using level <code>Auto</code> no explicit level information is written (HTML5 header element). This property does not influence the style of the control. Use the property <code>titleStyle</code> for this purpose instead.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <param name="sLevel">New value for property <code>level</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Title setLevel(sap.ui.core.TitleLevel sLevel);

				#endregion

				#region Methods for Property titleStyle

				/// <summary>
				/// Gets current value of property {@link #getTitleStyle titleStyle}.
				/// 
				/// Defines the style of the title. When using the <code>Auto</code> styling, the appearance of the title depends on the current position of the title (e.g. inside a <code>Toolbar</code>). This default behavior can be overridden by setting a different style explicitly. The actual appearance of the title and the different styles always depends on the theme being used.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>titleStyle</code></returns>
				public extern virtual sap.ui.core.TitleLevel getTitleStyle();

				/// <summary>
				/// Sets a new value for property {@link #getTitleStyle titleStyle}.
				/// 
				/// Defines the style of the title. When using the <code>Auto</code> styling, the appearance of the title depends on the current position of the title (e.g. inside a <code>Toolbar</code>). This default behavior can be overridden by setting a different style explicitly. The actual appearance of the title and the different styles always depends on the theme being used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <param name="sTitleStyle">New value for property <code>titleStyle</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Title setTitleStyle(sap.ui.core.TitleLevel sTitleStyle);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the width of the title.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the width of the title.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Title setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property textAlign

				/// <summary>
				/// Gets current value of property {@link #getTextAlign textAlign}.
				/// 
				/// Defines the alignment of the text within the title. <b>Note:</b> This property only has an effect if the overall width of the title control is larger than the displayed text.
				/// 
				/// Default value is <code>Initial</code>.
				/// </summary>
				/// <returns>Value of property <code>textAlign</code></returns>
				public extern virtual sap.ui.core.TextAlign getTextAlign();

				/// <summary>
				/// Sets a new value for property {@link #getTextAlign textAlign}.
				/// 
				/// Defines the alignment of the text within the title. <b>Note:</b> This property only has an effect if the overall width of the title control is larger than the displayed text.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Initial</code>.
				/// </summary>
				/// <param name="sTextAlign">New value for property <code>textAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Title setTextAlign(sap.ui.core.TextAlign sTextAlign);

				#endregion

				#region Methods for Property wrapping

				/// <summary>
				/// Gets current value of property {@link #getWrapping wrapping}.
				/// 
				/// Enables text wrapping. <b>Note:</b> Wrapping must only be activated if the surrounding container allows flexible heights.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>wrapping</code></returns>
				public extern virtual bool getWrapping();

				/// <summary>
				/// Sets a new value for property {@link #getWrapping wrapping}.
				/// 
				/// Enables text wrapping. <b>Note:</b> Wrapping must only be activated if the surrounding container allows flexible heights.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bWrapping">New value for property <code>wrapping</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Title setWrapping(bool bWrapping);

				#endregion

				#region Methods for Association title

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getTitle title}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getTitle();

				/// <summary>
				/// Sets the associated {@link #getTitle title}.
				/// </summary>
				/// <param name="oTitle">ID of an element which becomes the new target of this title association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Title setTitle(Union<sap.ui.core.ID, sap.ui.core.Title> oTitle);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.Title with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Title with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Title with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Gets the accessibility information for the <code>sap.m.Title</code> control.
				/// </summary>
				/// <returns>Current accessibility state of the control</returns>
				public extern static object getAccessibilityInfo();

				/// <summary>
				/// Returns a metadata object for class sap.m.Title.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Sets the title for a <code>sap.m.Title</code> or <code>sap.ui.core.Title</code>
				/// </summary>
				/// <param name="vTitle">Given variant of the a title which can be <code>sap.m.Title</code> or <code>sap.ui.core.Title</code>.</param>
				/// <returns>this Title reference for chaining.</returns>
				public extern static sap.m.Title setTitle(Union<sap.m.Title, sap.ui.core.Title> vTitle);

				#endregion

				#endregion

			}
		}
	}
}
