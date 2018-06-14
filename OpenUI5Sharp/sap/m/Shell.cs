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
			/// The Shell control can be used as root element of applications. It can contain an App or a <code>SplitApp</code> control. The Shell provides some overarching functionality for the overall application and takes care of visual adaptation, such as a frame around the App, on desktop browser platforms.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class Shell : sap.ui.core.Control
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
					/// Defines the application title, which may or may not be displayed outside the actual application, depending on the available screen size.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

					/// <summary>
					/// Defines the logo to be displayed next to the App when the screen is sufficiently large.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> logo;

					/// <summary>
					/// Determines whether the Logout button should be displayed. Currently, this only happens on very tall screens (1568px height), otherwise, it is always hidden.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showLogout;

					/// <summary>
					/// Defines texts, such as the name of the logged-in user, which should be displayed on the right side of the header (if there is enough space to display the header at all - this only happens on very tall screens (1568px height), otherwise, it is always hidden).
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> headerRightText;

					/// <summary>
					/// Determines whether the width of the content (the aggregated App) should be limited or extended to the full screen width.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> appWidthLimited;

					/// <summary>
					/// Defines the background color of the Shell. If set, this color will override the default background defined by the theme. This should only be set when really required. Any configured background image will be placed above this colored background. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete Shell or whether it should be tiled.
					/// </summary>
					public Union<sap.ui.core.CSSColor, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> backgroundColor;

					/// <summary>
					/// Defines the background image of the Shell. If set, this image will override the default background defined by the theme. This should only be set when really required. This background image will be placed above any color set for the background. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete Shell or whether it should be tiled.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> backgroundImage;

					/// <summary>
					/// Determines whether the background image (if configured) should be proportionally stretched to cover the whole Shell (false, default) or whether it should be tiled (true).
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> backgroundRepeat;

					/// <summary>
					/// Defines the opacity of the background image. The opacity can be set between 0 (fully transparent) and 1 (fully opaque). This can be used to improve readability of the Shell content by making the background image partly transparent.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> backgroundOpacity;

					/// <summary>
					/// Sets the icon used for the mobile device home screen and the icon to be used for bookmarks by desktop browsers.
					/// 
					/// This property should be only set once, and as early as possible. Subsequent calls replace the previous icon settings and may lead to different behavior depending on the browser.
					/// 
					/// Different image sizes for device home screen need to be given as PNG images, an ICO file needs to be given as desktop browser bookmark icon (other file formats may not work in all browsers). The <code>precomposed</code> flag defines whether there is already a glow effect contained in the home screen images (or whether iOS should add such an effect). The given structure could look like this: { 'phone':'phone-icon_57x57.png', 'phone@2':'phone-retina_114x114.png', 'tablet':'tablet-icon_72x72.png', 'tablet@2':'tablet-retina_144x144.png', 'precomposed':true, 'favicon':'favicon.ico' }
					/// 
					/// See jQuery.sap.setIcons() for full documentation.
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> homeIcon;

					/// <summary>
					/// Defines the semantic level of the title.
					/// 
					/// This information is used by assistive technologies, such as screen readers to create a hierarchical site map for faster navigation. Depending on this setting an HTML h1-h6 element is used.
					/// </summary>
					public Union<sap.ui.core.TitleLevel, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> titleLevel;

					/// <summary>
					/// A Shell contains an App or a SplitApp (they may be wrapped in a View). Other control types are not allowed.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> app;

					/// <summary>
					/// Fires when the user presses the logout button/link.
					/// </summary>
					public sap.ui.@base.EventDelegate logout;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Shell.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Shell(string sId, sap.m.Shell.Settings mSettings);

				/// <summary>
				/// Constructor for a new Shell.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Shell(string sId);

				/// <summary>
				/// Constructor for a new Shell.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Shell();

				/// <summary>
				/// Constructor for a new Shell.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Shell(sap.m.Shell.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Defines the application title, which may or may not be displayed outside the actual application, depending on the available screen size.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Defines the application title, which may or may not be displayed outside the actual application, depending on the available screen size.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setTitle(string sTitle);

				#endregion

				#region Methods for Property logo

				/// <summary>
				/// Gets current value of property {@link #getLogo logo}.
				/// 
				/// Defines the logo to be displayed next to the App when the screen is sufficiently large.
				/// </summary>
				/// <returns>Value of property <code>logo</code></returns>
				public extern virtual sap.ui.core.URI getLogo();

				/// <summary>
				/// Sets a new value for property {@link #getLogo logo}.
				/// 
				/// Defines the logo to be displayed next to the App when the screen is sufficiently large.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sLogo">New value for property <code>logo</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setLogo(sap.ui.core.URI sLogo);

				#endregion

				#region Methods for Property showLogout

				/// <summary>
				/// Gets current value of property {@link #getShowLogout showLogout}.
				/// 
				/// Determines whether the Logout button should be displayed. Currently, this only happens on very tall screens (1568px height), otherwise, it is always hidden.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showLogout</code></returns>
				public extern virtual bool getShowLogout();

				/// <summary>
				/// Sets a new value for property {@link #getShowLogout showLogout}.
				/// 
				/// Determines whether the Logout button should be displayed. Currently, this only happens on very tall screens (1568px height), otherwise, it is always hidden.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowLogout">New value for property <code>showLogout</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setShowLogout(bool bShowLogout);

				#endregion

				#region Methods for Property headerRightText

				/// <summary>
				/// Gets current value of property {@link #getHeaderRightText headerRightText}.
				/// 
				/// Defines texts, such as the name of the logged-in user, which should be displayed on the right side of the header (if there is enough space to display the header at all - this only happens on very tall screens (1568px height), otherwise, it is always hidden).
				/// </summary>
				/// <returns>Value of property <code>headerRightText</code></returns>
				public extern virtual string getHeaderRightText();

				/// <summary>
				/// Sets a new value for property {@link #getHeaderRightText headerRightText}.
				/// 
				/// Defines texts, such as the name of the logged-in user, which should be displayed on the right side of the header (if there is enough space to display the header at all - this only happens on very tall screens (1568px height), otherwise, it is always hidden).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHeaderRightText">New value for property <code>headerRightText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setHeaderRightText(string sHeaderRightText);

				#endregion

				#region Methods for Property appWidthLimited

				/// <summary>
				/// Gets current value of property {@link #getAppWidthLimited appWidthLimited}.
				/// 
				/// Determines whether the width of the content (the aggregated App) should be limited or extended to the full screen width.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>appWidthLimited</code></returns>
				public extern virtual bool getAppWidthLimited();

				/// <summary>
				/// Sets a new value for property {@link #getAppWidthLimited appWidthLimited}.
				/// 
				/// Determines whether the width of the content (the aggregated App) should be limited or extended to the full screen width.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bAppWidthLimited">New value for property <code>appWidthLimited</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setAppWidthLimited(bool bAppWidthLimited);

				#endregion

				#region Methods for Property backgroundColor

				/// <summary>
				/// Gets current value of property {@link #getBackgroundColor backgroundColor}.
				/// 
				/// Defines the background color of the Shell. If set, this color will override the default background defined by the theme. This should only be set when really required. Any configured background image will be placed above this colored background. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete Shell or whether it should be tiled.
				/// </summary>
				/// <returns>Value of property <code>backgroundColor</code></returns>
				public extern virtual sap.ui.core.CSSColor getBackgroundColor();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundColor backgroundColor}.
				/// 
				/// Defines the background color of the Shell. If set, this color will override the default background defined by the theme. This should only be set when really required. Any configured background image will be placed above this colored background. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete Shell or whether it should be tiled.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sBackgroundColor">New value for property <code>backgroundColor</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setBackgroundColor(sap.ui.core.CSSColor sBackgroundColor);

				#endregion

				#region Methods for Property backgroundImage

				/// <summary>
				/// Gets current value of property {@link #getBackgroundImage backgroundImage}.
				/// 
				/// Defines the background image of the Shell. If set, this image will override the default background defined by the theme. This should only be set when really required. This background image will be placed above any color set for the background. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete Shell or whether it should be tiled.
				/// </summary>
				/// <returns>Value of property <code>backgroundImage</code></returns>
				public extern virtual sap.ui.core.URI getBackgroundImage();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundImage backgroundImage}.
				/// 
				/// Defines the background image of the Shell. If set, this image will override the default background defined by the theme. This should only be set when really required. This background image will be placed above any color set for the background. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete Shell or whether it should be tiled.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sBackgroundImage">New value for property <code>backgroundImage</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setBackgroundImage(sap.ui.core.URI sBackgroundImage);

				#endregion

				#region Methods for Property backgroundRepeat

				/// <summary>
				/// Gets current value of property {@link #getBackgroundRepeat backgroundRepeat}.
				/// 
				/// Determines whether the background image (if configured) should be proportionally stretched to cover the whole Shell (false, default) or whether it should be tiled (true).
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundRepeat</code></returns>
				public extern virtual bool getBackgroundRepeat();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundRepeat backgroundRepeat}.
				/// 
				/// Determines whether the background image (if configured) should be proportionally stretched to cover the whole Shell (false, default) or whether it should be tiled (true).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bBackgroundRepeat">New value for property <code>backgroundRepeat</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setBackgroundRepeat(bool bBackgroundRepeat);

				#endregion

				#region Methods for Property backgroundOpacity

				/// <summary>
				/// Gets current value of property {@link #getBackgroundOpacity backgroundOpacity}.
				/// 
				/// Defines the opacity of the background image. The opacity can be set between 0 (fully transparent) and 1 (fully opaque). This can be used to improve readability of the Shell content by making the background image partly transparent.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundOpacity</code></returns>
				public extern virtual float getBackgroundOpacity();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundOpacity backgroundOpacity}.
				/// 
				/// Defines the opacity of the background image. The opacity can be set between 0 (fully transparent) and 1 (fully opaque). This can be used to improve readability of the Shell content by making the background image partly transparent.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <param name="fBackgroundOpacity">New value for property <code>backgroundOpacity</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setBackgroundOpacity(float fBackgroundOpacity);

				#endregion

				#region Methods for Property homeIcon

				/// <summary>
				/// Gets current value of property {@link #getHomeIcon homeIcon}.
				/// 
				/// Sets the icon used for the mobile device home screen and the icon to be used for bookmarks by desktop browsers.
				/// 
				/// This property should be only set once, and as early as possible. Subsequent calls replace the previous icon settings and may lead to different behavior depending on the browser.
				/// 
				/// Different image sizes for device home screen need to be given as PNG images, an ICO file needs to be given as desktop browser bookmark icon (other file formats may not work in all browsers). The <code>precomposed</code> flag defines whether there is already a glow effect contained in the home screen images (or whether iOS should add such an effect). The given structure could look like this: { 'phone':'phone-icon_57x57.png', 'phone@2':'phone-retina_114x114.png', 'tablet':'tablet-icon_72x72.png', 'tablet@2':'tablet-retina_144x144.png', 'precomposed':true, 'favicon':'favicon.ico' }
				/// 
				/// See jQuery.sap.setIcons() for full documentation.
				/// </summary>
				/// <returns>Value of property <code>homeIcon</code></returns>
				public extern virtual object getHomeIcon();

				/// <summary>
				/// Sets a new value for property {@link #getHomeIcon homeIcon}.
				/// 
				/// Sets the icon used for the mobile device home screen and the icon to be used for bookmarks by desktop browsers.
				/// 
				/// This property should be only set once, and as early as possible. Subsequent calls replace the previous icon settings and may lead to different behavior depending on the browser.
				/// 
				/// Different image sizes for device home screen need to be given as PNG images, an ICO file needs to be given as desktop browser bookmark icon (other file formats may not work in all browsers). The <code>precomposed</code> flag defines whether there is already a glow effect contained in the home screen images (or whether iOS should add such an effect). The given structure could look like this: { 'phone':'phone-icon_57x57.png', 'phone@2':'phone-retina_114x114.png', 'tablet':'tablet-icon_72x72.png', 'tablet@2':'tablet-retina_144x144.png', 'precomposed':true, 'favicon':'favicon.ico' }
				/// 
				/// See jQuery.sap.setIcons() for full documentation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oHomeIcon">New value for property <code>homeIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setHomeIcon(object oHomeIcon);

				#endregion

				#region Methods for Property titleLevel

				/// <summary>
				/// Gets current value of property {@link #getTitleLevel titleLevel}.
				/// 
				/// Defines the semantic level of the title.
				/// 
				/// This information is used by assistive technologies, such as screen readers to create a hierarchical site map for faster navigation. Depending on this setting an HTML h1-h6 element is used.
				/// 
				/// Default value is <code>H1</code>.
				/// </summary>
				/// <returns>Value of property <code>titleLevel</code></returns>
				public extern virtual sap.ui.core.TitleLevel getTitleLevel();

				/// <summary>
				/// Sets a new value for property {@link #getTitleLevel titleLevel}.
				/// 
				/// Defines the semantic level of the title.
				/// 
				/// This information is used by assistive technologies, such as screen readers to create a hierarchical site map for faster navigation. Depending on this setting an HTML h1-h6 element is used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>H1</code>.
				/// </summary>
				/// <param name="sTitleLevel">New value for property <code>titleLevel</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setTitleLevel(sap.ui.core.TitleLevel sTitleLevel);

				#endregion

				#region Methods for Aggregation app

				/// <summary>
				/// Gets content of aggregation {@link #getApp app}.
				/// 
				/// A Shell contains an App or a SplitApp (they may be wrapped in a View). Other control types are not allowed.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getApp();

				/// <summary>
				/// Destroys the app in the aggregation {@link #getApp app}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell destroyApp();

				/// <summary>
				/// Sets the aggregated {@link #getApp app}.
				/// </summary>
				/// <param name="oApp">The app to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell setApp(sap.ui.core.Control oApp);

				#endregion

				#region Methods for Event logout

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:logout logout} event of this <code>sap.m.Shell</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Shell</code> itself.
				/// 
				/// Fires when the user presses the logout button/link.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Shell</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell attachLogout(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:logout logout} event of this <code>sap.m.Shell</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Shell</code> itself.
				/// 
				/// Fires when the user presses the logout button/link.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell attachLogout(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:logout logout} event of this <code>sap.m.Shell</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Shell</code> itself.
				/// 
				/// Fires when the user presses the logout button/link.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell attachLogout(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:logout logout} event of this <code>sap.m.Shell</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Shell</code> itself.
				/// 
				/// Fires when the user presses the logout button/link.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Shell</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell attachLogout(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:logout logout} event of this <code>sap.m.Shell</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell detachLogout(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:logout logout} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell fireLogout(object mParameters);

				/// <summary>
				/// Fires event {@link #event:logout logout} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Shell fireLogout();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.Shell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Shell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Shell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Shell.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
