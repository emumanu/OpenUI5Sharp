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
			/// Represents an item which is displayed within an sap.m.LightBox. This item holds all properties of the image as well as the title and subtitle.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.LightBoxItem")]
			public partial class LightBoxItem : sap.ui.core.Element
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Element.Settings
				{
					/// <summary>
					/// Source for the image. This property is mandatory. If not set the popup will not open
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> imageSrc;

					/// <summary>
					/// Alt value for the image
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> alt;

					/// <summary>
					/// Title text for the image. This property is mandatory.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Subtitle text for the image
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> subtitle;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new LightBoxItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern LightBoxItem(string sId, sap.m.LightBoxItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new LightBoxItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern LightBoxItem(string sId);

				/// <summary>
				/// Constructor for a new LightBoxItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern LightBoxItem();

				/// <summary>
				/// Constructor for a new LightBoxItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern LightBoxItem(sap.m.LightBoxItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property imageSrc

				/// <summary>
				/// Gets current value of property {@link #getImageSrc imageSrc}.
				/// 
				/// Source for the image. This property is mandatory. If not set the popup will not open
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>imageSrc</code></returns>
				public extern virtual sap.ui.core.URI getImageSrc();

				/// <summary>
				/// Sets the source of the image.
				/// </summary>
				/// <param name="sImageSrc">The image URI</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.LightBoxItem setImageSrc(sap.ui.core.URI sImageSrc);

				#endregion

				#region Methods for Property alt

				/// <summary>
				/// Gets current value of property {@link #getAlt alt}.
				/// 
				/// Alt value for the image
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>alt</code></returns>
				public extern virtual string getAlt();

				/// <summary>
				/// Sets the alt text of the image.
				/// </summary>
				/// <param name="alt">The alt text</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.LightBoxItem setAlt(string alt);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Title text for the image. This property is mandatory.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets the title of the image.
				/// </summary>
				/// <param name="title">The image title</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.LightBoxItem setTitle(string title);

				#endregion

				#region Methods for Property subtitle

				/// <summary>
				/// Gets current value of property {@link #getSubtitle subtitle}.
				/// 
				/// Subtitle text for the image
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>subtitle</code></returns>
				public extern virtual string getSubtitle();

				/// <summary>
				/// Sets the subtitle of the image.
				/// </summary>
				/// <param name="subtitleText">The image subtitle</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.LightBoxItem setSubtitle(string subtitleText);

				#endregion

				#region Methods for Aggregation _image

				#endregion

				#region Methods for Aggregation _title

				#endregion

				#region Methods for Aggregation _subtitle

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.LightBoxItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.LightBoxItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.LightBoxItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.LightBoxItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
