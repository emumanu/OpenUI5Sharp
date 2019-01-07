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
				/// Is used to provide tool tips that can have long text, image and title. This tool tip extends the TooltipBase.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.RichTooltip")]
				[Obsolete("Deprecated since 1.38. Tf you want to achieve a similar behavior, use a <code>sap.m.Popover</code> control and open it next to your control.")]
				public partial class RichTooltip : sap.ui.core.TooltipBase
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.TooltipBase.Settings
					{
						/// <summary>
						/// Tool tip title to be displayed in the header.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// If RichTooltip contains an image, this property is used to define the source path.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> imageSrc;

						/// <summary>
						/// This property is an individual text that will be used instead of the default ValueState text
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueStateText;

						/// <summary>
						/// This is the alt text for the image
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> imageAltText;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new RichTooltip.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern RichTooltip(string sId, sap.ui.commons.RichTooltip.Settings mSettings);

					/// <summary>
					/// Constructor for a new RichTooltip.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern RichTooltip(string sId);

					/// <summary>
					/// Constructor for a new RichTooltip.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern RichTooltip();

					/// <summary>
					/// Constructor for a new RichTooltip.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern RichTooltip(sap.ui.commons.RichTooltip.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// Tool tip title to be displayed in the header.
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// Tool tip title to be displayed in the header.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RichTooltip setTitle(string sTitle);

					#endregion

					#region Methods for Property imageSrc

					/// <summary>
					/// Gets current value of property {@link #getImageSrc imageSrc}.
					/// 
					/// If RichTooltip contains an image, this property is used to define the source path.
					/// </summary>
					/// <returns>Value of property <code>imageSrc</code></returns>
					public extern virtual sap.ui.core.URI getImageSrc();

					/// <summary>
					/// Sets a new value for property {@link #getImageSrc imageSrc}.
					/// 
					/// If RichTooltip contains an image, this property is used to define the source path.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sImageSrc">New value for property <code>imageSrc</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RichTooltip setImageSrc(sap.ui.core.URI sImageSrc);

					#endregion

					#region Methods for Property valueStateText

					/// <summary>
					/// This returns the previously set text. Since a FormattedTextView is used for rendering and stuff the corresponding property of the FormattedTextView is being read and returned. If no text was set an empty string is being returned.
					/// </summary>
					/// <returns>the ValueState text that was previously set.</returns>
					public extern virtual string getValueStateText();

					/// <summary>
					/// This sets an individual text for the ValueState of the parent element of the RichTooltip.
					/// </summary>
					/// <param name="sText">the text that should be shown as individual ValueState text</param>
					/// <returns>Returns <code>this</code> to facilitate method chaining.</returns>
					public extern virtual sap.ui.commons.RichTooltip setValueStateText(string sText);

					#endregion

					#region Methods for Property imageAltText

					/// <summary>
					/// Gets current value of property {@link #getImageAltText imageAltText}.
					/// 
					/// This is the alt text for the image
					/// </summary>
					/// <returns>Value of property <code>imageAltText</code></returns>
					public extern virtual string getImageAltText();

					/// <summary>
					/// Sets a new value for property {@link #getImageAltText imageAltText}.
					/// 
					/// This is the alt text for the image
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sImageAltText">New value for property <code>imageAltText</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RichTooltip setImageAltText(string sImageAltText);

					#endregion

					#region Methods for Aggregation formattedText

					#endregion

					#region Methods for Aggregation individualStateText

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RichTooltip with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.TooltipBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RichTooltip with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.TooltipBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RichTooltip with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.TooltipBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.RichTooltip.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Calculates the height of the RichTooltip to set a proper min-height. Additionally the ARIA attributes are set to the corresponding elements.
					/// </summary>
					public extern override void onAfterRendering();

					#endregion

					#endregion

				}
			}
		}
	}
}
