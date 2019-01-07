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
			/// A wrapper around the IMG tag. The image can be loaded from a remote or local server.
			/// 
			/// Density related image will be loaded if image with density awareness name in format [imageName]@[densityValue].[extension] is provided. The valid desity values are 1, 1.5, 2. If the original devicePixelRatio isn't one of the three valid numbers, it's rounded up to the nearest one.
			/// 
			/// There are various size setting options available, and the images can be combined with actions.
			/// 
			/// From version 1.30, new image mode sap.m.ImageMode.Background is added. When this mode is set, the src property is set using the css style 'background-image'. The properties 'backgroundSize', 'backgroundPosition', 'backgroundRepeat' have effect only when image is in sap.m.ImageMode.Background mode. In order to make the high density image correctly displayed, the 'backgroundSize' should be set to the dimension of the normal density version.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Image")]
			public partial class Image : sap.ui.core.Control, sap.ui.core.IFormContent
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
					/// Relative or absolute path to URL where the image file is stored. The path will be adapted to the density aware format according to the density of the device following the convention that [imageName]@[densityValue].[extension]
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> src;

					/// <summary>
					/// When the empty value is kept, the original size is not changed. It is also possible to make settings for width or height only, the original ratio between width/height is maintained. When 'mode' property is set to sap.m.ImageMode.Background, this property always needs to be set. Otherwise the output DOM element has a 0 size.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// When the empty value is kept, the original size is not changed. It is also possible to make settings for width or height only, the original ratio between width/height is maintained. When 'mode' property is set to sap.m.ImageMode.Background, this property always needs to be set. Otherwise the output DOM element has a 0 size.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// A decorative image is included for design reasons. Accessibility tools will ignore decorative images.
					/// 
					/// Note: If the Image has an image map (useMap is set), this property will be overridden (the image will not be rendered as decorative). A decorative image has no ALT attribute, so the Alt property is ignored if the image is decorative.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> decorative;

					/// <summary>
					/// The alternative text that is displayed in case the Image is not available, or cannot be displayed. If the image is set to decorative this property is ignored.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> alt;

					/// <summary>
					/// The name of the image map that defines the clickable areas
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> useMap;

					/// <summary>
					/// If this is set to false, the src image will be loaded directly without attempting to fetch the density perfect image for high density device.
					/// 
					/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
					/// 
					/// If bandwidth is the key for the application, set this value to false.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> densityAware;

					/// <summary>
					/// The source property which is used when the image is pressed.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> activeSrc;

					/// <summary>
					/// Defines how the src and the activeSrc is output to the Dom Element. When set to sap.m.ImageMode.Image which is the default value, the src (activeSrc) is set to the 'src' attribute of the 'img' tag. When set to sap.m.ImageMode.Background, the src (activeSrc) is set to the CSS style 'background-image' and the root DOM element is rendered as a 'span' tag instead of an 'img' tag.
					/// </summary>
					public Union<sap.m.ImageMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> mode;

					/// <summary>
					/// Defines the size of the image in sap.m.ImageMode.Background mode. This property is set on the output DOM element using CSS style 'background-size'. This property takes effect only when the 'mode' property is set to sap.m.ImageMode.Background.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundSize;

					/// <summary>
					/// Defines the position of the image in sap.m.ImageMode.Background mode. This property is set on the output DOM element using CSS style 'background-position'. This property takes effect only when the 'mode' property is set to sap.m.ImageMode.Background.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundPosition;

					/// <summary>
					/// Defines whether the source image is repeated when the output DOM element is bigger than the source. This property is set on the output DOM element using CSS style 'background-repeat'. This property takes effect only when the 'mode' property is set to sap.m.ImageMode.Background.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundRepeat;

					/// <summary>
					/// A <code>sap.m.LightBox</code> instance, that will be opened automatically when the user interacts with the <code>Image</code> control.
					/// 
					/// The <code>tap</code> event will still be fired.
					/// </summary>
					public Union<sap.m.LightBox, string, sap.ui.@base.ManagedObject.BindAggregationInfo> detailBox;

					/// <summary>
					/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledBy).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Event is fired when the user clicks on the control. (This event is deprecated, use the press event instead)
					/// </summary>
					public sap.ui.@base.EventDelegate tap;

					/// <summary>
					/// Event is fired when the user clicks on the control.
					/// </summary>
					public sap.ui.@base.EventDelegate press;

					/// <summary>
					/// Event is fired when the image resource is loaded.
					/// </summary>
					public sap.ui.@base.EventDelegate load;

					/// <summary>
					/// Event is fired when the image resource can't be loaded. If densityAware is set to true, the event is fired when none of the fallback resources can be loaded.
					/// </summary>
					public sap.ui.@base.EventDelegate error;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Image.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern Image(string sId, sap.m.Image.Settings mSettings);

				/// <summary>
				/// Constructor for a new Image.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern Image(string sId);

				/// <summary>
				/// Constructor for a new Image.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Image();

				/// <summary>
				/// Constructor for a new Image.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern Image(sap.m.Image.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property src

				/// <summary>
				/// Gets current value of property {@link #getSrc src}.
				/// 
				/// Relative or absolute path to URL where the image file is stored. The path will be adapted to the density aware format according to the density of the device following the convention that [imageName]@[densityValue].[extension]
				/// </summary>
				/// <returns>Value of property <code>src</code></returns>
				public extern virtual sap.ui.core.URI getSrc();

				/// <summary>
				/// Sets a new value for property {@link #getSrc src}.
				/// 
				/// Relative or absolute path to URL where the image file is stored. The path will be adapted to the density aware format according to the density of the device following the convention that [imageName]@[densityValue].[extension]
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sSrc">New value for property <code>src</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setSrc(sap.ui.core.URI sSrc);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// When the empty value is kept, the original size is not changed. It is also possible to make settings for width or height only, the original ratio between width/height is maintained. When 'mode' property is set to sap.m.ImageMode.Background, this property always needs to be set. Otherwise the output DOM element has a 0 size.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// When the empty value is kept, the original size is not changed. It is also possible to make settings for width or height only, the original ratio between width/height is maintained. When 'mode' property is set to sap.m.ImageMode.Background, this property always needs to be set. Otherwise the output DOM element has a 0 size.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// When the empty value is kept, the original size is not changed. It is also possible to make settings for width or height only, the original ratio between width/height is maintained. When 'mode' property is set to sap.m.ImageMode.Background, this property always needs to be set. Otherwise the output DOM element has a 0 size.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// When the empty value is kept, the original size is not changed. It is also possible to make settings for width or height only, the original ratio between width/height is maintained. When 'mode' property is set to sap.m.ImageMode.Background, this property always needs to be set. Otherwise the output DOM element has a 0 size.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property decorative

				/// <summary>
				/// Gets current value of property {@link #getDecorative decorative}.
				/// 
				/// A decorative image is included for design reasons. Accessibility tools will ignore decorative images.
				/// 
				/// Note: If the Image has an image map (useMap is set), this property will be overridden (the image will not be rendered as decorative). A decorative image has no ALT attribute, so the Alt property is ignored if the image is decorative.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>decorative</code></returns>
				public extern virtual bool getDecorative();

				/// <summary>
				/// Sets a new value for property {@link #getDecorative decorative}.
				/// 
				/// A decorative image is included for design reasons. Accessibility tools will ignore decorative images.
				/// 
				/// Note: If the Image has an image map (useMap is set), this property will be overridden (the image will not be rendered as decorative). A decorative image has no ALT attribute, so the Alt property is ignored if the image is decorative.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bDecorative">New value for property <code>decorative</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setDecorative(bool bDecorative);

				#endregion

				#region Methods for Property alt

				/// <summary>
				/// Gets current value of property {@link #getAlt alt}.
				/// 
				/// The alternative text that is displayed in case the Image is not available, or cannot be displayed. If the image is set to decorative this property is ignored.
				/// </summary>
				/// <returns>Value of property <code>alt</code></returns>
				public extern virtual string getAlt();

				/// <summary>
				/// Sets a new value for property {@link #getAlt alt}.
				/// 
				/// The alternative text that is displayed in case the Image is not available, or cannot be displayed. If the image is set to decorative this property is ignored.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sAlt">New value for property <code>alt</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setAlt(string sAlt);

				#endregion

				#region Methods for Property useMap

				/// <summary>
				/// Gets current value of property {@link #getUseMap useMap}.
				/// 
				/// The name of the image map that defines the clickable areas
				/// </summary>
				/// <returns>Value of property <code>useMap</code></returns>
				public extern virtual string getUseMap();

				/// <summary>
				/// Sets a new value for property {@link #getUseMap useMap}.
				/// 
				/// The name of the image map that defines the clickable areas
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sUseMap">New value for property <code>useMap</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setUseMap(string sUseMap);

				#endregion

				#region Methods for Property densityAware

				/// <summary>
				/// Gets current value of property {@link #getDensityAware densityAware}.
				/// 
				/// If this is set to false, the src image will be loaded directly without attempting to fetch the density perfect image for high density device.
				/// 
				/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
				/// 
				/// If bandwidth is the key for the application, set this value to false.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>densityAware</code></returns>
				public extern virtual bool getDensityAware();

				/// <summary>
				/// Sets a new value for property {@link #getDensityAware densityAware}.
				/// 
				/// If this is set to false, the src image will be loaded directly without attempting to fetch the density perfect image for high density device.
				/// 
				/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
				/// 
				/// If bandwidth is the key for the application, set this value to false.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bDensityAware">New value for property <code>densityAware</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setDensityAware(bool bDensityAware);

				#endregion

				#region Methods for Property activeSrc

				/// <summary>
				/// Gets current value of property {@link #getActiveSrc activeSrc}.
				/// 
				/// The source property which is used when the image is pressed.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>activeSrc</code></returns>
				public extern virtual sap.ui.core.URI getActiveSrc();

				/// <summary>
				/// Sets a new value for property {@link #getActiveSrc activeSrc}.
				/// 
				/// The source property which is used when the image is pressed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sActiveSrc">New value for property <code>activeSrc</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setActiveSrc(sap.ui.core.URI sActiveSrc);

				#endregion

				#region Methods for Property mode

				/// <summary>
				/// Gets current value of property {@link #getMode mode}.
				/// 
				/// Defines how the src and the activeSrc is output to the Dom Element. When set to sap.m.ImageMode.Image which is the default value, the src (activeSrc) is set to the 'src' attribute of the 'img' tag. When set to sap.m.ImageMode.Background, the src (activeSrc) is set to the CSS style 'background-image' and the root DOM element is rendered as a 'span' tag instead of an 'img' tag.
				/// 
				/// Default value is <code>Image</code>.
				/// </summary>
				/// <returns>Value of property <code>mode</code></returns>
				public extern virtual sap.m.ImageMode getMode();

				/// <summary>
				/// Sets a new value for property {@link #getMode mode}.
				/// 
				/// Defines how the src and the activeSrc is output to the Dom Element. When set to sap.m.ImageMode.Image which is the default value, the src (activeSrc) is set to the 'src' attribute of the 'img' tag. When set to sap.m.ImageMode.Background, the src (activeSrc) is set to the CSS style 'background-image' and the root DOM element is rendered as a 'span' tag instead of an 'img' tag.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Image</code>.
				/// </summary>
				/// <param name="sMode">New value for property <code>mode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setMode(sap.m.ImageMode sMode);

				#endregion

				#region Methods for Property backgroundSize

				/// <summary>
				/// Gets current value of property {@link #getBackgroundSize backgroundSize}.
				/// 
				/// Defines the size of the image in sap.m.ImageMode.Background mode. This property is set on the output DOM element using CSS style 'background-size'. This property takes effect only when the 'mode' property is set to sap.m.ImageMode.Background.
				/// 
				/// Default value is <code>cover</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundSize</code></returns>
				public extern virtual string getBackgroundSize();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundSize backgroundSize}.
				/// 
				/// Defines the size of the image in sap.m.ImageMode.Background mode. This property is set on the output DOM element using CSS style 'background-size'. This property takes effect only when the 'mode' property is set to sap.m.ImageMode.Background.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>cover</code>.
				/// </summary>
				/// <param name="sBackgroundSize">New value for property <code>backgroundSize</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setBackgroundSize(string sBackgroundSize);

				#endregion

				#region Methods for Property backgroundPosition

				/// <summary>
				/// Gets current value of property {@link #getBackgroundPosition backgroundPosition}.
				/// 
				/// Defines the position of the image in sap.m.ImageMode.Background mode. This property is set on the output DOM element using CSS style 'background-position'. This property takes effect only when the 'mode' property is set to sap.m.ImageMode.Background.
				/// 
				/// Default value is <code>initial</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundPosition</code></returns>
				public extern virtual string getBackgroundPosition();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundPosition backgroundPosition}.
				/// 
				/// Defines the position of the image in sap.m.ImageMode.Background mode. This property is set on the output DOM element using CSS style 'background-position'. This property takes effect only when the 'mode' property is set to sap.m.ImageMode.Background.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>initial</code>.
				/// </summary>
				/// <param name="sBackgroundPosition">New value for property <code>backgroundPosition</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setBackgroundPosition(string sBackgroundPosition);

				#endregion

				#region Methods for Property backgroundRepeat

				/// <summary>
				/// Gets current value of property {@link #getBackgroundRepeat backgroundRepeat}.
				/// 
				/// Defines whether the source image is repeated when the output DOM element is bigger than the source. This property is set on the output DOM element using CSS style 'background-repeat'. This property takes effect only when the 'mode' property is set to sap.m.ImageMode.Background.
				/// 
				/// Default value is <code>no-repeat</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundRepeat</code></returns>
				public extern virtual string getBackgroundRepeat();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundRepeat backgroundRepeat}.
				/// 
				/// Defines whether the source image is repeated when the output DOM element is bigger than the source. This property is set on the output DOM element using CSS style 'background-repeat'. This property takes effect only when the 'mode' property is set to sap.m.ImageMode.Background.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>no-repeat</code>.
				/// </summary>
				/// <param name="sBackgroundRepeat">New value for property <code>backgroundRepeat</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image setBackgroundRepeat(string sBackgroundRepeat);

				#endregion

				#region Methods for Aggregation detailBox

				/// <summary>
				/// Gets content of aggregation {@link #getDetailBox detailBox}.
				/// 
				/// A <code>sap.m.LightBox</code> instance, that will be opened automatically when the user interacts with the <code>Image</code> control.
				/// 
				/// The <code>tap</code> event will still be fired.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.LightBox getDetailBox();

				/// <summary>
				/// Destroys the detailBox in the aggregation {@link #getDetailBox detailBox}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image destroyDetailBox();

				/// <summary>
				/// Sets the <code>detailBox</code> aggregation.
				/// </summary>
				/// <param name="oLightBox">Instance of the <code>LightBox</code> control or undefined</param>
				/// <returns><code>this</code> for chaining</returns>
				public extern virtual sap.m.Image setDetailBox(sap.m.LightBox oLightBox);

				/// <summary>
				/// Binds aggregation {@link #getDetailBox detailBox} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image bindDetailBox(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getDetailBox detailBox} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image unbindDetailBox();

				#endregion

				#region Methods for Association ariaDescribedBy

				/// <summary>
				/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID[] getAriaDescribedBy();

				/// <summary>
				/// Adds some ariaDescribedBy into the association {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <param name="vAriaDescribedBy">The ariaDescribedBy to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

				/// <summary>
				/// Removes an ariaDescribedBy from the association named {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <param name="vAriaDescribedBy">The ariaDescribedBy to be removed or its index or ID</param>
				/// <returns>The removed ariaDescribedBy or <code>null</code></returns>
				public extern virtual sap.ui.core.ID removeAriaDescribedBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

				/// <summary>
				/// Removes all the controls in the association named {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.ID[] removeAllAriaDescribedBy();

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
				public extern virtual sap.m.Image addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event tap

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tap tap} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the user clicks on the control. (This event is deprecated, use the press event instead)
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Image</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachTap(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tap tap} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the user clicks on the control. (This event is deprecated, use the press event instead)
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachTap(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tap tap} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the user clicks on the control. (This event is deprecated, use the press event instead)
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachTap(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tap tap} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the user clicks on the control. (This event is deprecated, use the press event instead)
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Image</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachTap(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:tap tap} event of this <code>sap.m.Image</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image detachTap(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:tap tap} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image fireTap(object mParameters);

				/// <summary>
				/// Fires event {@link #event:tap tap} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image fireTap();

				#endregion

				#region Methods for Event press

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the user clicks on the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Image</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the user clicks on the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the user clicks on the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the user clicks on the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Image</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.m.Image</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image detachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image firePress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image firePress();

				#endregion

				#region Methods for Event load

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:load load} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the image resource is loaded.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Image</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachLoad(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:load load} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the image resource is loaded.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachLoad(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:load load} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the image resource is loaded.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachLoad(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:load load} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the image resource is loaded.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Image</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachLoad(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:load load} event of this <code>sap.m.Image</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image detachLoad(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:load load} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image fireLoad(object mParameters);

				/// <summary>
				/// Fires event {@link #event:load load} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image fireLoad();

				#endregion

				#region Methods for Event error

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:error error} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the image resource can't be loaded. If densityAware is set to true, the event is fired when none of the fallback resources can be loaded.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Image</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachError(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:error error} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the image resource can't be loaded. If densityAware is set to true, the event is fired when none of the fallback resources can be loaded.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachError(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:error error} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the image resource can't be loaded. If densityAware is set to true, the event is fired when none of the fallback resources can be loaded.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachError(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:error error} event of this <code>sap.m.Image</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Image</code> itself.
				/// 
				/// Event is fired when the image resource can't be loaded. If densityAware is set to true, the event is fired when none of the fallback resources can be loaded.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Image</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image attachError(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:error error} event of this <code>sap.m.Image</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image detachError(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:error error} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image fireError(object mParameters);

				/// <summary>
				/// Fires event {@link #event:error error} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Image fireError();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.Image with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Image with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Image with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns the <code>sap.m.Image</code> accessibility information.
				/// </summary>
				/// <returns>The <code>sap.m.Image</code> accessibility information</returns>
				public extern virtual object getAccessibilityInfo();

				/// <summary>
				/// Returns a metadata object for class sap.m.Image.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

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
