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
			/// The root element of a UI5 mobile app.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>App</code> inherits from {@link sap.m.NavContainer} and thus provides its navigation capabilities. It adds certain header tags to the HTML page which are considered useful for mobile apps.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// You can configure the home icon of the <code>App</code>. For more information, see the <code>homeIcon</code> property.
			/// 
			/// There are options for setting the background color and a background image with the use of the <code>backgroundColor</code> and <code>backgroundImage</code> properties.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class App : sap.m.NavContainer
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.NavContainer.Settings
				{
					/// <summary>
					/// The icon to be displayed on the home screen of iOS devices after the user does "add to home screen".
					/// 
					/// Note that only the first attempt to set the homeIcon will be executed, subsequent settings are ignored.
					/// 
					/// This icon must be in PNG format. The property can either hold the URL of one single icon which is used for all devices (and possibly scaled, which looks not perfect), or an object holding icon URLs for the different required sizes.
					/// 
					/// A desktop icon (used for bookmarks and overriding the favicon) can also be configured. This requires an object to be given and the "icon" property of this object then defines the desktop bookmark icon. For this icon, PNG is not supported by Internet Explorer. The ICO format is supported by all browsers. ICO is also preferred for this desktop icon setting because the file can contain different images for different resolutions.
					/// 
					/// One example is:
					/// 
					/// app.setHomeIcon({ 'phone':'phone-icon.png', 'phone@2':'phone-retina.png', 'tablet':'tablet-icon.png', 'tablet@2':'tablet-retina.png', 'icon':'desktop.ico' });
					/// 
					/// The respective image sizes are 57/114 px for the phone and 72/144 px for the tablet. If an object is given but one of the sizes is not given, the largest given icon will be used for this size.
					/// 
					/// On Android these icons may or may not be used by the device. Apparently chances can be improved by adding glare effect and rounded corners, setting the file name so it ends with "-precomposed.png" and setting the "homeIconPrecomposed" property to "true".
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> homeIcon;

					/// <summary>
					/// Background color of the App. If set, this color will override the default background defined by the theme. So this should only be set when really required. Any configured background image will be placed above this colored background. But any theme adaptation in the Theme Designer will override this setting. Use the "backgroundRepeat" property to define whether this image should be stretched to cover the complete App or whether it should be tiled.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> backgroundColor;

					/// <summary>
					/// Background image of the App. If set, this image will override the default background defined by the theme. So this should only be set when really required. This background image will be placed above any color set for the background. But any theme adaptation in the Theme Designer will override this image setting. Use the "backgroundRepeat" property to define whether this image should be stretched to cover the complete App or whether it should be tiled.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> backgroundImage;

					/// <summary>
					/// Whether the background image (if configured) should be proportionally stretched to cover the whole App (false) or whether it should be tiled (true).
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> backgroundRepeat;

					/// <summary>
					/// Opacity of the background image. The opacity can be set between 0 (fully transparent) and 1 fully opaque). This can be used to make the application content better readable by making the background image partly transparent.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> backgroundOpacity;

					/// <summary>
					/// Fired when the orientation (portrait/landscape) of the device is changed.
					/// </summary>
					public sap.m.App.AppOrientationChangeDelegate orientationChange;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class AppOrientationChangeInfo
				{
					/// <summary>
					/// Whether the device is in landscape orientation.
					/// </summary>
					public bool landscape;

				}

				#endregion

				#region Delegates

				public delegate void AppOrientationChangeDelegate(sap.ui.@base.Event<sap.m.App.AppOrientationChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>App</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern App(string sId, sap.m.App.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>App</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern App(string sId);

				/// <summary>
				/// Constructor for a new <code>App</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern App();

				/// <summary>
				/// Constructor for a new <code>App</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern App(sap.m.App.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property homeIcon

				/// <summary>
				/// Gets current value of property {@link #getHomeIcon homeIcon}.
				/// 
				/// The icon to be displayed on the home screen of iOS devices after the user does "add to home screen".
				/// 
				/// Note that only the first attempt to set the homeIcon will be executed, subsequent settings are ignored.
				/// 
				/// This icon must be in PNG format. The property can either hold the URL of one single icon which is used for all devices (and possibly scaled, which looks not perfect), or an object holding icon URLs for the different required sizes.
				/// 
				/// A desktop icon (used for bookmarks and overriding the favicon) can also be configured. This requires an object to be given and the "icon" property of this object then defines the desktop bookmark icon. For this icon, PNG is not supported by Internet Explorer. The ICO format is supported by all browsers. ICO is also preferred for this desktop icon setting because the file can contain different images for different resolutions.
				/// 
				/// One example is:
				/// 
				/// app.setHomeIcon({ 'phone':'phone-icon.png', 'phone@2':'phone-retina.png', 'tablet':'tablet-icon.png', 'tablet@2':'tablet-retina.png', 'icon':'desktop.ico' });
				/// 
				/// The respective image sizes are 57/114 px for the phone and 72/144 px for the tablet. If an object is given but one of the sizes is not given, the largest given icon will be used for this size.
				/// 
				/// On Android these icons may or may not be used by the device. Apparently chances can be improved by adding glare effect and rounded corners, setting the file name so it ends with "-precomposed.png" and setting the "homeIconPrecomposed" property to "true".
				/// </summary>
				/// <returns>Value of property <code>homeIcon</code></returns>
				public extern virtual object getHomeIcon();

				/// <summary>
				/// Sets a new value for property {@link #getHomeIcon homeIcon}.
				/// 
				/// The icon to be displayed on the home screen of iOS devices after the user does "add to home screen".
				/// 
				/// Note that only the first attempt to set the homeIcon will be executed, subsequent settings are ignored.
				/// 
				/// This icon must be in PNG format. The property can either hold the URL of one single icon which is used for all devices (and possibly scaled, which looks not perfect), or an object holding icon URLs for the different required sizes.
				/// 
				/// A desktop icon (used for bookmarks and overriding the favicon) can also be configured. This requires an object to be given and the "icon" property of this object then defines the desktop bookmark icon. For this icon, PNG is not supported by Internet Explorer. The ICO format is supported by all browsers. ICO is also preferred for this desktop icon setting because the file can contain different images for different resolutions.
				/// 
				/// One example is:
				/// 
				/// app.setHomeIcon({ 'phone':'phone-icon.png', 'phone@2':'phone-retina.png', 'tablet':'tablet-icon.png', 'tablet@2':'tablet-retina.png', 'icon':'desktop.ico' });
				/// 
				/// The respective image sizes are 57/114 px for the phone and 72/144 px for the tablet. If an object is given but one of the sizes is not given, the largest given icon will be used for this size.
				/// 
				/// On Android these icons may or may not be used by the device. Apparently chances can be improved by adding glare effect and rounded corners, setting the file name so it ends with "-precomposed.png" and setting the "homeIconPrecomposed" property to "true".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oHomeIcon">New value for property <code>homeIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App setHomeIcon(object oHomeIcon);

				#endregion

				#region Methods for Property backgroundColor

				/// <summary>
				/// Gets current value of property {@link #getBackgroundColor backgroundColor}.
				/// 
				/// Background color of the App. If set, this color will override the default background defined by the theme. So this should only be set when really required. Any configured background image will be placed above this colored background. But any theme adaptation in the Theme Designer will override this setting. Use the "backgroundRepeat" property to define whether this image should be stretched to cover the complete App or whether it should be tiled.
				/// </summary>
				/// <returns>Value of property <code>backgroundColor</code></returns>
				public extern virtual string getBackgroundColor();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundColor backgroundColor}.
				/// 
				/// Background color of the App. If set, this color will override the default background defined by the theme. So this should only be set when really required. Any configured background image will be placed above this colored background. But any theme adaptation in the Theme Designer will override this setting. Use the "backgroundRepeat" property to define whether this image should be stretched to cover the complete App or whether it should be tiled.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sBackgroundColor">New value for property <code>backgroundColor</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App setBackgroundColor(string sBackgroundColor);

				#endregion

				#region Methods for Property backgroundImage

				/// <summary>
				/// Gets current value of property {@link #getBackgroundImage backgroundImage}.
				/// 
				/// Background image of the App. If set, this image will override the default background defined by the theme. So this should only be set when really required. This background image will be placed above any color set for the background. But any theme adaptation in the Theme Designer will override this image setting. Use the "backgroundRepeat" property to define whether this image should be stretched to cover the complete App or whether it should be tiled.
				/// </summary>
				/// <returns>Value of property <code>backgroundImage</code></returns>
				public extern virtual sap.ui.core.URI getBackgroundImage();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundImage backgroundImage}.
				/// 
				/// Background image of the App. If set, this image will override the default background defined by the theme. So this should only be set when really required. This background image will be placed above any color set for the background. But any theme adaptation in the Theme Designer will override this image setting. Use the "backgroundRepeat" property to define whether this image should be stretched to cover the complete App or whether it should be tiled.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sBackgroundImage">New value for property <code>backgroundImage</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App setBackgroundImage(sap.ui.core.URI sBackgroundImage);

				#endregion

				#region Methods for Property backgroundRepeat

				/// <summary>
				/// Gets current value of property {@link #getBackgroundRepeat backgroundRepeat}.
				/// 
				/// Whether the background image (if configured) should be proportionally stretched to cover the whole App (false) or whether it should be tiled (true).
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundRepeat</code></returns>
				public extern virtual bool getBackgroundRepeat();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundRepeat backgroundRepeat}.
				/// 
				/// Whether the background image (if configured) should be proportionally stretched to cover the whole App (false) or whether it should be tiled (true).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bBackgroundRepeat">New value for property <code>backgroundRepeat</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App setBackgroundRepeat(bool bBackgroundRepeat);

				#endregion

				#region Methods for Property backgroundOpacity

				/// <summary>
				/// Gets current value of property {@link #getBackgroundOpacity backgroundOpacity}.
				/// 
				/// Opacity of the background image. The opacity can be set between 0 (fully transparent) and 1 fully opaque). This can be used to make the application content better readable by making the background image partly transparent.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundOpacity</code></returns>
				public extern virtual float getBackgroundOpacity();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundOpacity backgroundOpacity}.
				/// 
				/// Opacity of the background image. The opacity can be set between 0 (fully transparent) and 1 fully opaque). This can be used to make the application content better readable by making the background image partly transparent.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <param name="fBackgroundOpacity">New value for property <code>backgroundOpacity</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App setBackgroundOpacity(float fBackgroundOpacity);

				#endregion

				#region Methods for Event orientationChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:orientationChange orientationChange} event of this <code>sap.m.App</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.App</code> itself.
				/// 
				/// Fired when the orientation (portrait/landscape) of the device is changed.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. use sap.ui.Device.orientation.attachHandler(...)")]
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.App</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App attachOrientationChange(object oData, sap.m.App.AppOrientationChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:orientationChange orientationChange} event of this <code>sap.m.App</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.App</code> itself.
				/// 
				/// Fired when the orientation (portrait/landscape) of the device is changed.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. use sap.ui.Device.orientation.attachHandler(...)")]
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App attachOrientationChange(object oData, sap.m.App.AppOrientationChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:orientationChange orientationChange} event of this <code>sap.m.App</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.App</code> itself.
				/// 
				/// Fired when the orientation (portrait/landscape) of the device is changed.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. use sap.ui.Device.orientation.attachHandler(...)")]
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App attachOrientationChange(sap.m.App.AppOrientationChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:orientationChange orientationChange} event of this <code>sap.m.App</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.App</code> itself.
				/// 
				/// Fired when the orientation (portrait/landscape) of the device is changed.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. use sap.ui.Device.orientation.attachHandler(...)")]
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.App</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App attachOrientationChange(sap.m.App.AppOrientationChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:orientationChange orientationChange} event of this <code>sap.m.App</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. use sap.ui.Device.orientation.attachHandler(...)")]
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App detachOrientationChange(sap.m.App.AppOrientationChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:orientationChange orientationChange} to attached listeners.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. use sap.ui.Device.orientation.attachHandler(...)")]
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App fireOrientationChange(sap.m.App.AppOrientationChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:orientationChange orientationChange} to attached listeners.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. use sap.ui.Device.orientation.attachHandler(...)")]
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.App fireOrientationChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.App with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.NavContainer.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.App with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.NavContainer.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.App with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.NavContainer.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.App.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
