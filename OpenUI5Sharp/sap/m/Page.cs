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
			/// A container control that holds one whole screen of an application.
			/// 
			/// <h3>Overview</h3> The sap.m.Page is a container control that holds one whole screen of an application. The page has three distinct areas that can hold content - a header, content area and a footer. <h3>Structure</h3> <h4>Header</h4> The top most area of the page is occupied by the header. The standard header includes a navigation button and a title. Alternatively, you can create your own custom header, which is defined in the <code>customHeader</code> aggregation. <h4>Content</h4> The content occupies the main part of the page. Only the content area is scrollable by default. This can be prevented by setting <code>enableScrolling</code> to <code>false</code>. <h4>Footer</h4> The footer is optional and occupies the fixed bottom part of the page. Alternatively, the footer can be floating above the bottom part of the content. This is enabled with the <code>floatingFooter</code> property.
			/// 
			/// <b>Note:</b> All accessibility information for the different areas and their corresponding ARIA roles is set in the aggregation <code>landmarkInfo</code> of type {@link sap.m.PageAccessibleLandmarkInfo}
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Page")]
			public partial class Page : sap.ui.core.Control
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
					/// The title text appearing in the page header bar.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Defines the semantic level of the title. Using "Auto" no explicit level information is written. Used for accessibility purposes only.
					/// </summary>
					public Union<sap.ui.core.TitleLevel, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleLevel;

					/// <summary>
					/// A nav button will be rendered on the left area of header bar if this property is set to true.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showNavButton;

					/// <summary>
					/// Whether this page shall have a header. If set to true, either the control under the "customHeader" aggregation is used, or if there is no such control, a Header control is constructed from the properties "title", "showNavButton", "navButtonText" and "icon" depending on the platform.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showHeader;

					/// <summary>
					/// Whether this page shall show the subheader.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSubHeader;

					/// <summary>
					/// The text of the nav button when running in iOS (if shown) in case it deviates from the default, which is "Back". This property is mvi-theme-dependent and will not have any effect in other themes.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> navButtonText;

					/// <summary>
					/// The tooltip of the nav button
					/// 
					/// Since version 1.34
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> navButtonTooltip;

					/// <summary>
					/// Enable vertical scrolling of page contents. Page headers and footers are fixed and do not scroll. If set to false, there will be no vertical scrolling at all.
					/// 
					/// The Page only allows vertical scrolling because horizontal scrolling is discouraged in general for full-page content. If it still needs to be achieved, disable the Page scrolling and use a ScrollContainer as full-page content of the Page. This allows you to freely configure scrolling. It can also be used to create horizontally-scrolling sub-areas of (vertically-scrolling) Pages.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableScrolling;

					/// <summary>
					/// the icon that is rendered in the page header bar in non-iOS phone/tablet platforms. This property is theme-dependent and only has an effect in the MVI theme.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// This property is used to set the background color of a page. When a list is placed inside a page, the value "List" should be used to display a gray background. "Standard", with the default background color, is used if not specified.
					/// </summary>
					public Union<sap.m.PageBackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

					/// <summary>
					/// This property is used to set the appearance of the NavButton. By default when showNavButton is set to true, a back button will be shown in iOS and an up button in other platforms. In case you want to show a normal button in the left header area, you can set the value to "Default".
					/// </summary>
					public Union<sap.m.ButtonType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> navButtonType;

					/// <summary>
					/// Whether this page shall have a footer
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showFooter;

					/// <summary>
					/// Decides which area is covered by the local BusyIndicator when <code>page.setBusy()</code> is called. By default the entire page is covered, including headers and footer. When this property is set to "true", only the content area is covered (not header/sub header and footer), which is useful e.g. when there is a SearchField in the sub header and live search continuously updates the content area while the user is still able to type.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentOnlyBusy;

					/// <summary>
					/// Decides whether the footer can float. When set to true, the footer is not fixed below the content area anymore, but rather floats over it with a slight offset from the bottom.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> floatingFooter;

					/// <summary>
					/// The content of this page
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					/// <summary>
					/// The (optional) custom header of this page. Use this aggregation only when a custom header is constructed where the default header consisting of title text + nav button is not sufficient. If this aggregation is set, the simple properties "title", "showNavButton", "NavButtonText" and "icon" are not used.
					/// </summary>
					public Union<sap.m.IBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> customHeader;

					/// <summary>
					/// The (optional) footer of this page. It is always located at the bottom of the page
					/// </summary>
					public Union<sap.m.IBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> footer;

					/// <summary>
					/// a subHeader will be rendered directly under the header
					/// </summary>
					public Union<sap.m.IBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> subHeader;

					/// <summary>
					/// Controls to be added to the right side of the page header. Usually an application would use Button controls and limit the number to one when the application needs to run on smartphones. There is no automatic overflow handling when the space is insufficient. When a customHeader is used, this aggregation will be ignored.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerContent;

					/// <summary>
					/// Accessible landmark settings to be applied on the containers of the <code>sap.m.Page</code> control.
					/// 
					/// If not set, no landmarks will be written.
					/// </summary>
					public Union<sap.m.PageAccessibleLandmarkInfo, string, sap.ui.@base.ManagedObject.BindAggregationInfo> landmarkInfo;

					/// <summary>
					/// this event is fired when Nav Button is tapped
					/// </summary>
					public sap.ui.@base.EventDelegate navButtonTap;

					/// <summary>
					/// this event is fired when Nav Button is pressed
					/// </summary>
					public sap.ui.@base.EventDelegate navButtonPress;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Page.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Page(string sId, sap.m.Page.Settings mSettings);

				/// <summary>
				/// Constructor for a new Page.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Page(string sId);

				/// <summary>
				/// Constructor for a new Page.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Page();

				/// <summary>
				/// Constructor for a new Page.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Page(sap.m.Page.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// The title text appearing in the page header bar.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// The title text appearing in the page header bar.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setTitle(string sTitle);

				#endregion

				#region Methods for Property titleLevel

				/// <summary>
				/// Gets current value of property {@link #getTitleLevel titleLevel}.
				/// 
				/// Defines the semantic level of the title. Using "Auto" no explicit level information is written. Used for accessibility purposes only.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>titleLevel</code></returns>
				public extern virtual sap.ui.core.TitleLevel getTitleLevel();

				/// <summary>
				/// Sets a new value for property {@link #getTitleLevel titleLevel}.
				/// 
				/// Defines the semantic level of the title. Using "Auto" no explicit level information is written. Used for accessibility purposes only.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <param name="sTitleLevel">New value for property <code>titleLevel</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setTitleLevel(sap.ui.core.TitleLevel sTitleLevel);

				#endregion

				#region Methods for Property showNavButton

				/// <summary>
				/// Gets current value of property {@link #getShowNavButton showNavButton}.
				/// 
				/// A nav button will be rendered on the left area of header bar if this property is set to true.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showNavButton</code></returns>
				public extern virtual bool getShowNavButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowNavButton showNavButton}.
				/// 
				/// A nav button will be rendered on the left area of header bar if this property is set to true.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowNavButton">New value for property <code>showNavButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setShowNavButton(bool bShowNavButton);

				#endregion

				#region Methods for Property showHeader

				/// <summary>
				/// Gets current value of property {@link #getShowHeader showHeader}.
				/// 
				/// Whether this page shall have a header. If set to true, either the control under the "customHeader" aggregation is used, or if there is no such control, a Header control is constructed from the properties "title", "showNavButton", "navButtonText" and "icon" depending on the platform.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showHeader</code></returns>
				public extern virtual bool getShowHeader();

				/// <summary>
				/// Sets a new value for property {@link #getShowHeader showHeader}.
				/// 
				/// Whether this page shall have a header. If set to true, either the control under the "customHeader" aggregation is used, or if there is no such control, a Header control is constructed from the properties "title", "showNavButton", "navButtonText" and "icon" depending on the platform.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowHeader">New value for property <code>showHeader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setShowHeader(bool bShowHeader);

				#endregion

				#region Methods for Property showSubHeader

				/// <summary>
				/// Gets current value of property {@link #getShowSubHeader showSubHeader}.
				/// 
				/// Whether this page shall show the subheader.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showSubHeader</code></returns>
				public extern virtual bool getShowSubHeader();

				/// <summary>
				/// Sets a new value for property {@link #getShowSubHeader showSubHeader}.
				/// 
				/// Whether this page shall show the subheader.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowSubHeader">New value for property <code>showSubHeader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setShowSubHeader(bool bShowSubHeader);

				#endregion

				#region Methods for Property navButtonText

				/// <summary>
				/// Gets current value of property {@link #getNavButtonText navButtonText}.
				/// 
				/// The text of the nav button when running in iOS (if shown) in case it deviates from the default, which is "Back". This property is mvi-theme-dependent and will not have any effect in other themes.
				/// </summary>
				/// <returns>Value of property <code>navButtonText</code></returns>
				[Obsolete("Deprecated since 1.20. Deprecated since the MVI theme is removed now. This property only affected the NavButton in that theme.")]
				public extern virtual string getNavButtonText();

				/// <summary>
				/// Sets a new value for property {@link #getNavButtonText navButtonText}.
				/// 
				/// The text of the nav button when running in iOS (if shown) in case it deviates from the default, which is "Back". This property is mvi-theme-dependent and will not have any effect in other themes.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sNavButtonText">New value for property <code>navButtonText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.20. Deprecated since the MVI theme is removed now. This property only affected the NavButton in that theme.")]
				public extern virtual sap.m.Page setNavButtonText(string sNavButtonText);

				#endregion

				#region Methods for Property navButtonTooltip

				/// <summary>
				/// Gets current value of property {@link #getNavButtonTooltip navButtonTooltip}.
				/// 
				/// The tooltip of the nav button
				/// 
				/// Since version 1.34
				/// </summary>
				/// <returns>Value of property <code>navButtonTooltip</code></returns>
				public extern virtual string getNavButtonTooltip();

				/// <summary>
				/// Sets a new value for property {@link #getNavButtonTooltip navButtonTooltip}.
				/// 
				/// The tooltip of the nav button
				/// 
				/// Since version 1.34
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sNavButtonTooltip">New value for property <code>navButtonTooltip</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setNavButtonTooltip(string sNavButtonTooltip);

				#endregion

				#region Methods for Property enableScrolling

				/// <summary>
				/// Gets current value of property {@link #getEnableScrolling enableScrolling}.
				/// 
				/// Enable vertical scrolling of page contents. Page headers and footers are fixed and do not scroll. If set to false, there will be no vertical scrolling at all.
				/// 
				/// The Page only allows vertical scrolling because horizontal scrolling is discouraged in general for full-page content. If it still needs to be achieved, disable the Page scrolling and use a ScrollContainer as full-page content of the Page. This allows you to freely configure scrolling. It can also be used to create horizontally-scrolling sub-areas of (vertically-scrolling) Pages.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enableScrolling</code></returns>
				public extern virtual bool getEnableScrolling();

				/// <summary>
				/// Sets a new value for property {@link #getEnableScrolling enableScrolling}.
				/// 
				/// Enable vertical scrolling of page contents. Page headers and footers are fixed and do not scroll. If set to false, there will be no vertical scrolling at all.
				/// 
				/// The Page only allows vertical scrolling because horizontal scrolling is discouraged in general for full-page content. If it still needs to be achieved, disable the Page scrolling and use a ScrollContainer as full-page content of the Page. This allows you to freely configure scrolling. It can also be used to create horizontally-scrolling sub-areas of (vertically-scrolling) Pages.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnableScrolling">New value for property <code>enableScrolling</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setEnableScrolling(bool bEnableScrolling);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// the icon that is rendered in the page header bar in non-iOS phone/tablet platforms. This property is theme-dependent and only has an effect in the MVI theme.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				[Obsolete("Deprecated since 1.20. Deprecated since the MVI theme is removed now. This property only affected the NavButton in that theme.")]
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// the icon that is rendered in the page header bar in non-iOS phone/tablet platforms. This property is theme-dependent and only has an effect in the MVI theme.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.20. Deprecated since the MVI theme is removed now. This property only affected the NavButton in that theme.")]
				public extern virtual sap.m.Page setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property backgroundDesign

				/// <summary>
				/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// This property is used to set the background color of a page. When a list is placed inside a page, the value "List" should be used to display a gray background. "Standard", with the default background color, is used if not specified.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundDesign</code></returns>
				public extern virtual sap.m.PageBackgroundDesign getBackgroundDesign();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// This property is used to set the background color of a page. When a list is placed inside a page, the value "List" should be used to display a gray background. "Standard", with the default background color, is used if not specified.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <param name="sBackgroundDesign">New value for property <code>backgroundDesign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setBackgroundDesign(sap.m.PageBackgroundDesign sBackgroundDesign);

				#endregion

				#region Methods for Property navButtonType

				/// <summary>
				/// Gets current value of property {@link #getNavButtonType navButtonType}.
				/// 
				/// This property is used to set the appearance of the NavButton. By default when showNavButton is set to true, a back button will be shown in iOS and an up button in other platforms. In case you want to show a normal button in the left header area, you can set the value to "Default".
				/// 
				/// Default value is <code>Back</code>.
				/// </summary>
				/// <returns>Value of property <code>navButtonType</code></returns>
				[Obsolete("Deprecated since 1.20. Deprecated since the MVI theme is removed now. This property is only usable with a Button text in that theme.")]
				public extern virtual sap.m.ButtonType getNavButtonType();

				/// <summary>
				/// Sets a new value for property {@link #getNavButtonType navButtonType}.
				/// 
				/// This property is used to set the appearance of the NavButton. By default when showNavButton is set to true, a back button will be shown in iOS and an up button in other platforms. In case you want to show a normal button in the left header area, you can set the value to "Default".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Back</code>.
				/// </summary>
				/// <param name="sNavButtonType">New value for property <code>navButtonType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.20. Deprecated since the MVI theme is removed now. This property is only usable with a Button text in that theme.")]
				public extern virtual sap.m.Page setNavButtonType(sap.m.ButtonType sNavButtonType);

				#endregion

				#region Methods for Property showFooter

				/// <summary>
				/// Gets current value of property {@link #getShowFooter showFooter}.
				/// 
				/// Whether this page shall have a footer
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showFooter</code></returns>
				public extern virtual bool getShowFooter();

				/// <summary>
				/// Sets a new value for property {@link #getShowFooter showFooter}.
				/// 
				/// Whether this page shall have a footer
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowFooter">New value for property <code>showFooter</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setShowFooter(bool bShowFooter);

				#endregion

				#region Methods for Property contentOnlyBusy

				/// <summary>
				/// Gets current value of property {@link #getContentOnlyBusy contentOnlyBusy}.
				/// 
				/// Decides which area is covered by the local BusyIndicator when <code>page.setBusy()</code> is called. By default the entire page is covered, including headers and footer. When this property is set to "true", only the content area is covered (not header/sub header and footer), which is useful e.g. when there is a SearchField in the sub header and live search continuously updates the content area while the user is still able to type.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>contentOnlyBusy</code></returns>
				public extern virtual bool getContentOnlyBusy();

				/// <summary>
				/// Sets a new value for property {@link #getContentOnlyBusy contentOnlyBusy}.
				/// 
				/// Decides which area is covered by the local BusyIndicator when <code>page.setBusy()</code> is called. By default the entire page is covered, including headers and footer. When this property is set to "true", only the content area is covered (not header/sub header and footer), which is useful e.g. when there is a SearchField in the sub header and live search continuously updates the content area while the user is still able to type.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bContentOnlyBusy">New value for property <code>contentOnlyBusy</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setContentOnlyBusy(bool bContentOnlyBusy);

				#endregion

				#region Methods for Property floatingFooter

				/// <summary>
				/// Gets current value of property {@link #getFloatingFooter floatingFooter}.
				/// 
				/// Decides whether the footer can float. When set to true, the footer is not fixed below the content area anymore, but rather floats over it with a slight offset from the bottom.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>floatingFooter</code></returns>
				public extern virtual bool getFloatingFooter();

				/// <summary>
				/// Sets a new value for property {@link #getFloatingFooter floatingFooter}.
				/// 
				/// Decides whether the footer can float. When set to true, the footer is not fixed below the content area anymore, but rather floats over it with a slight offset from the bottom.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bFloatingFooter">New value for property <code>floatingFooter</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setFloatingFooter(bool bFloatingFooter);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// The content of this page
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page addContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes a content from the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="vContent">The content to remove or its index or id</param>
				/// <returns>The removed content or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oContent">The content whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getContent content}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllContent();

				#endregion

				#region Methods for Aggregation customHeader

				/// <summary>
				/// Gets content of aggregation {@link #getCustomHeader customHeader}.
				/// 
				/// The (optional) custom header of this page. Use this aggregation only when a custom header is constructed where the default header consisting of title text + nav button is not sufficient. If this aggregation is set, the simple properties "title", "showNavButton", "NavButtonText" and "icon" are not used.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IBar getCustomHeader();

				/// <summary>
				/// Destroys the customHeader in the aggregation {@link #getCustomHeader customHeader}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page destroyCustomHeader();

				/// <summary>
				/// Sets the aggregated {@link #getCustomHeader customHeader}.
				/// </summary>
				/// <param name="oCustomHeader">The customHeader to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setCustomHeader(sap.m.IBar oCustomHeader);

				#endregion

				#region Methods for Aggregation footer

				/// <summary>
				/// Gets content of aggregation {@link #getFooter footer}.
				/// 
				/// The (optional) footer of this page. It is always located at the bottom of the page
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IBar getFooter();

				/// <summary>
				/// Destroys the footer in the aggregation {@link #getFooter footer}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page destroyFooter();

				/// <summary>
				/// Sets the aggregated {@link #getFooter footer}.
				/// </summary>
				/// <param name="oFooter">The footer to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setFooter(sap.m.IBar oFooter);

				#endregion

				#region Methods for Aggregation subHeader

				/// <summary>
				/// Gets content of aggregation {@link #getSubHeader subHeader}.
				/// 
				/// a subHeader will be rendered directly under the header
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IBar getSubHeader();

				/// <summary>
				/// Destroys the subHeader in the aggregation {@link #getSubHeader subHeader}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page destroySubHeader();

				/// <summary>
				/// Sets the aggregated {@link #getSubHeader subHeader}.
				/// </summary>
				/// <param name="oSubHeader">The subHeader to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setSubHeader(sap.m.IBar oSubHeader);

				#endregion

				#region Methods for Aggregation headerContent

				/// <summary>
				/// Gets content of aggregation {@link #getHeaderContent headerContent}.
				/// 
				/// Controls to be added to the right side of the page header. Usually an application would use Button controls and limit the number to one when the application needs to run on smartphones. There is no automatic overflow handling when the space is insufficient. When a customHeader is used, this aggregation will be ignored.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getHeaderContent();

				/// <summary>
				/// Destroys all the headerContent in the aggregation {@link #getHeaderContent headerContent}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page destroyHeaderContent();

				/// <summary>
				/// Inserts a headerContent into the aggregation {@link #getHeaderContent headerContent}.
				/// </summary>
				/// <param name="oHeaderContent">The headerContent to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the headerContent should be inserted at; for a negative value of <code>iIndex</code>, the headerContent is inserted at position 0; for a value greater than the current size of the aggregation, the headerContent is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page insertHeaderContent(sap.ui.core.Control oHeaderContent, int iIndex);

				/// <summary>
				/// Adds some headerContent to the aggregation {@link #getHeaderContent headerContent}.
				/// </summary>
				/// <param name="oHeaderContent">The headerContent to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page addHeaderContent(sap.ui.core.Control oHeaderContent);

				/// <summary>
				/// Removes a headerContent from the aggregation {@link #getHeaderContent headerContent}.
				/// </summary>
				/// <param name="vHeaderContent">The headerContent to remove or its index or id</param>
				/// <returns>The removed headerContent or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeHeaderContent(Union<int, string, sap.ui.core.Control> vHeaderContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getHeaderContent headerContent}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oHeaderContent">The headerContent whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfHeaderContent(sap.ui.core.Control oHeaderContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getHeaderContent headerContent}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllHeaderContent();

				#endregion

				#region Methods for Aggregation landmarkInfo

				/// <summary>
				/// Gets content of aggregation {@link #getLandmarkInfo landmarkInfo}.
				/// 
				/// Accessible landmark settings to be applied on the containers of the <code>sap.m.Page</code> control.
				/// 
				/// If not set, no landmarks will be written.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.PageAccessibleLandmarkInfo getLandmarkInfo();

				/// <summary>
				/// Destroys the landmarkInfo in the aggregation {@link #getLandmarkInfo landmarkInfo}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page destroyLandmarkInfo();

				/// <summary>
				/// Sets the aggregated {@link #getLandmarkInfo landmarkInfo}.
				/// </summary>
				/// <param name="oLandmarkInfo">The landmarkInfo to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page setLandmarkInfo(sap.m.PageAccessibleLandmarkInfo oLandmarkInfo);

				#endregion

				#region Methods for Aggregation _internalHeader

				#endregion

				#region Methods for Event navButtonTap

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonTap navButtonTap} event of this <code>sap.m.Page</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Page</code> itself.
				/// 
				/// this event is fired when Nav Button is tapped
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Page</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.12.2. the navButtonPress event is replacing this event")]
				public extern virtual sap.m.Page attachNavButtonTap(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonTap navButtonTap} event of this <code>sap.m.Page</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Page</code> itself.
				/// 
				/// this event is fired when Nav Button is tapped
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.12.2. the navButtonPress event is replacing this event")]
				public extern virtual sap.m.Page attachNavButtonTap(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonTap navButtonTap} event of this <code>sap.m.Page</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Page</code> itself.
				/// 
				/// this event is fired when Nav Button is tapped
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.12.2. the navButtonPress event is replacing this event")]
				public extern virtual sap.m.Page attachNavButtonTap(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonTap navButtonTap} event of this <code>sap.m.Page</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Page</code> itself.
				/// 
				/// this event is fired when Nav Button is tapped
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Page</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.12.2. the navButtonPress event is replacing this event")]
				public extern virtual sap.m.Page attachNavButtonTap(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:navButtonTap navButtonTap} event of this <code>sap.m.Page</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.12.2. the navButtonPress event is replacing this event")]
				public extern virtual sap.m.Page detachNavButtonTap(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:navButtonTap navButtonTap} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.12.2. the navButtonPress event is replacing this event")]
				public extern virtual sap.m.Page fireNavButtonTap(object mParameters);

				/// <summary>
				/// Fires event {@link #event:navButtonTap navButtonTap} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.12.2. the navButtonPress event is replacing this event")]
				public extern virtual sap.m.Page fireNavButtonTap();

				#endregion

				#region Methods for Event navButtonPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.Page</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Page</code> itself.
				/// 
				/// this event is fired when Nav Button is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Page</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page attachNavButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.Page</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Page</code> itself.
				/// 
				/// this event is fired when Nav Button is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page attachNavButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.Page</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Page</code> itself.
				/// 
				/// this event is fired when Nav Button is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page attachNavButtonPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.Page</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Page</code> itself.
				/// 
				/// this event is fired when Nav Button is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Page</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page attachNavButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.Page</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page detachNavButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:navButtonPress navButtonPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page fireNavButtonPress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:navButtonPress navButtonPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Page fireNavButtonPress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.Page with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Page with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Page with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Page.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Scrolls to the given position. Only available if enableScrolling is set to "true".
				/// </summary>
				/// <param name="y">The vertical pixel position to scroll to. Scrolling down happens with positive values.</param>
				/// <param name="time">The duration of animated scrolling. To scroll immediately without animation, give 0 as value. 0 is also the default value, when this optional parameter is omitted.</param>
				/// <returns><code>this</code> to facilitate method chaining.</returns>
				public extern virtual sap.m.Page scrollTo(int y, int time);

				/// <summary>
				/// Scrolls to an element(DOM or sap.ui.core.Element) within the page if the element is rendered.
				/// </summary>
				/// <param name="oElement">The element to which should be scrolled.</param>
				/// <param name="iTime">The duration of animated scrolling. To scroll immediately without animation, give 0 as value or leave it default.</param>
				/// <returns><code>this</code> to facilitate method chaining.</returns>
				public extern virtual sap.m.Page scrollToElement(Union<dom.HTMLElement, sap.ui.core.Element> oElement, int iTime = 0);

				#endregion

				#endregion

			}
		}
	}
}
