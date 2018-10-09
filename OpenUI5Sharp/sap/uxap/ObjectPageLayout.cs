using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class uxap
		{
			/// <summary>
			/// A layout that allows apps to easily display information related to a business object.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>ObjectPageLayout</code> layout is composed of a header (title and content), an optional anchor bar and block content wrapped in sections and subsections that structure the information.
			/// 
			/// <h3>Structure</h3>
			/// 
			/// An <code>ObjectPageLayout</code> control is used to put together all parts of an Object page - Header, optional Anchor Bar and Sections/Subsections.
			/// 
			/// <h4>Header</h4> The <code>ObjectPageLayout</code> implements the snapping header concept. This means that the upper part of the header (Header Title) always stays visible, while the lower part (Header Content) can scroll out of view.
			/// 
			/// Header Title is displayed at the top of the header and always remains visible above the scrollable content of the page. It contains the title and most prominent details of the object.
			/// 
			/// The Header Content scrolls along with the content of the page until it disappears (collapsed header). When scrolled back to the top it becomes visible again (expanded header). It contains all the additional information of the object.
			/// 
			/// <h4>Anchor Bar</h4> The Anchor Bar is an automatically generated internal menu that shows the titles of the sections and subsections and allows the user to scroll to the respective section and subsection content.
			/// 
			/// <h4>Sections, Subsections, Blocks</h4> The content of the page that appears bellow the header is composed of blocks structured into sections and subsections.
			/// 
			/// <h3>Usage</h3> Use the <code>ObjectPageLayout</code> if: <ul> <li>The users need to see, edit, or create an item with all its details.</li> <li>Users need to get an overview of an object and interact with different parts of the object.</li> </ul>
			/// 
			/// <h3>Responsive behavior</h3>
			/// 
			/// The <code>ObjectPageLayout</code> is responsive and adapts to all screen sizes.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageLayout")]
			public partial class ObjectPageLayout : sap.ui.core.Control
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
					/// Determines whether the Navigation bar (Anchor bar) is displayed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showAnchorBar;

					/// <summary>
					/// Determines whether to show a Popover with Subsection links when clicking on Section links in the Anchor bar.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showAnchorBarPopover;

					/// <summary>
					/// Determines whether the Anchor bar items are displayed in upper case.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> upperCaseAnchorBar;

					/// <summary>
					/// Determines the height of the ObjectPage.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// Enable lazy loading for the Object page Subsections.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableLazyLoading;

					/// <summary>
					/// Determines whether Subsection titles are displayed on top or to the left of the Subsection content.
					/// </summary>
					public Union<sap.uxap.ObjectPageSubSectionLayout, string, sap.ui.@base.ManagedObject.BindPropertyInfo> subSectionLayout;

					/// <summary>
					/// Determines the ARIA level of the <code>ObjectPageSection</code> and <code>ObjectPageSubSection</code> titles. The ARIA level is used by assisting technologies, such as screen readers, to create a hierarchical site map for faster navigation.
					/// 
					/// <br><b>Note:</b> <ul> <li>Defining a <code>sectionTitleLevel</code> will add <code>aria-level</code> attribute from 1 to 6 instead of changing the titles` HTML tag from H1 to H6. <br>For example: if <code>sectionTitleLevel</code> is <code>TitleLevel.H1</code>, it will result as aria-level of 1 added to the <code>ObjectPageSection</code> title. </li>
					/// 
					/// <li> The <code>ObjectPageSubSection</code> title would have <code>aria-level</code> one level lower than the defined. For example: if <code>sectionTitleLevel</code> is <code>TitleLevel.H1</code>, it will result as aria-level of 2 added to the <code>ObjectPageSubSection</code> title.</li>
					/// 
					/// <li> It is possible to define a <code>titleLevel</code> on <code>ObjectPageSection</code> or <code>ObjectPageSubSection</code> level. In this case the value of this property will be ignored. </li> </ul>
					/// </summary>
					public Union<sap.ui.core.TitleLevel, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sectionTitleLevel;

					/// <summary>
					/// Use tab navigation mode instead of the default Anchor bar mode. <br><b>Note: </b>Keep in mind that the <code>sap.m.IconTabBar</code> control is no longer used for the tab navigation mode.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> useIconTabBar;

					/// <summary>
					/// Determines the visibility of the Header content (headerContent aggregation).
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showHeaderContent;

					/// <summary>
					/// Determines whether the to use two column layout for the L screen size.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> useTwoColumnsForLargeScreen;

					/// <summary>
					/// Determines whether the title, image, markers and selectTitleArrow are shown in the Header content area.
					/// 
					/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.</li>
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showTitleInHeaderContent;

					/// <summary>
					/// Determines whether sections and subsections with importance Low and Medium are hidden even on large screens.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showOnlyHighImportance;

					/// <summary>
					/// Determines whether the page is a child page and renders it with a different design. Child pages have an additional (darker/lighter) stripe on the left side of their header content area.
					/// 
					/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> isChildPage;

					/// <summary>
					/// Determines whether Header Content will always be expanded on desktop.
					/// 
					/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> alwaysShowContentHeader;

					/// <summary>
					/// Determines whether the Header Content area can be pinned.
					/// 
					/// When set to <code>true</code>, a pin button is displayed within the Header Content area. The pin button allows the user to make the Header Content always visible at the top of the page above any scrollable content.
					/// 
					/// <b>Note:</b> This property is only taken into account if an instance of <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is used for the <code>headerTitle</code> aggregation.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerContentPinnable;

					/// <summary>
					/// Determines whether the user can switch between the expanded/collapsed states of the <code>sap.uxap.ObjectPageDynamicHeaderContent</code> by clicking on the <code>sap.uxap.ObjectPageDynamicHeaderTitle</code>. If set to <code>false</code>, the <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is not clickable and the application must provide other means for expanding/collapsing the <code>sap.uxap.ObjectPageDynamicHeaderContent</code>, if necessary.
					/// 
					/// <b>Note:</b> This property is only taken into account if an instance of <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is used for the <code>headerTitle</code> aggregation.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> toggleHeaderOnTitleClick;

					/// <summary>
					/// Preserves the current header state when scrolling. For example, if the user expands the header by clicking on the title and then scrolls down the page, the header will remain expanded.
					/// 
					/// <b>Notes:</b> <ul><li>This property is only taken into account if an instance of <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is used for the <code>headerTitle</code> aggregation.</li> <li>Based on internal rules, the value of the property is not always taken into account - for example, when the control is rendered on tablet or mobile and the control`s title and header are with height larger than the given threshold.</li></ul>
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> preserveHeaderStateOnScroll;

					/// <summary>
					/// Determines whether an Edit button will be displayed in Header Content.
					/// 
					/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showEditHeaderButton;

					/// <summary>
					/// Specifies whether the object page enables flexibility features, such as hiding and adding sections.<br> For more information about SAPUI5 flexibility, refer to the Developer Guide.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> flexEnabled;

					/// <summary>
					/// Determines whether the footer is visible.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showFooter;

					/// <summary>
					/// The sections that make up the Object page content area.
					/// </summary>
					public Union<sap.uxap.ObjectPageSection[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> sections;

					/// <summary>
					/// Object page header title - the upper, always static, part of the Object page header.
					/// </summary>
					public Union<sap.uxap.IHeaderTitle, string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerTitle;

					/// <summary>
					/// Object page header content - the dynamic part of the Object page header.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerContent;

					/// <summary>
					/// Object page floating footer.
					/// </summary>
					public Union<sap.m.IBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> footer;

					/// <summary>
					/// The section that is selected by default on load.
					/// </summary>
					public Union<sap.uxap.ObjectPageSection, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedSection;

					/// <summary>
					/// The event is fired when the Anchor bar is switched from moving to fixed or the other way round.
					/// </summary>
					public sap.uxap.ObjectPageLayout.ToggleAnchorBarDelegate toggleAnchorBar;

					/// <summary>
					/// The event is fired when the Edit Header button is pressed
					/// </summary>
					public sap.ui.@base.EventDelegate editHeaderButtonPress;

					/// <summary>
					/// The event is fired when the selected section is changed using the navigation.
					/// </summary>
					public sap.uxap.ObjectPageLayout.NavigateDelegate navigate;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class NavigateInfo
				{
					/// <summary>
					/// The selected section object.
					/// </summary>
					public sap.uxap.ObjectPageSection section;

					/// <summary>
					/// The selected subsection object.
					/// </summary>
					public sap.uxap.ObjectPageSubSection subSection;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ToggleAnchorBarInfo
				{
					/// <summary>
					/// False indicates that the Anchor bar has just detached from the Header and became part of the scrolling area. True means that the Anchor bar has just snapped to the Header.
					/// </summary>
					public bool @fixed;

				}

				#endregion

				#region Delegates

				public delegate void NavigateDelegate(sap.ui.@base.Event<sap.uxap.ObjectPageLayout.NavigateInfo> oEvent, object oData);

				public delegate void ToggleAnchorBarDelegate(sap.ui.@base.Event<sap.uxap.ObjectPageLayout.ToggleAnchorBarInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectPageLayout</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageLayout(string sId, sap.uxap.ObjectPageLayout.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectPageLayout</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectPageLayout(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectPageLayout</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectPageLayout();

				/// <summary>
				/// Constructor for a new <code>ObjectPageLayout</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageLayout(sap.uxap.ObjectPageLayout.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property showAnchorBar

				/// <summary>
				/// Gets current value of property {@link #getShowAnchorBar showAnchorBar}.
				/// 
				/// Determines whether the Navigation bar (Anchor bar) is displayed.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showAnchorBar</code></returns>
				public extern virtual bool getShowAnchorBar();

				/// <summary>
				/// Sets a new value for property {@link #getShowAnchorBar showAnchorBar}.
				/// 
				/// Determines whether the Navigation bar (Anchor bar) is displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowAnchorBar">New value for property <code>showAnchorBar</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setShowAnchorBar(bool bShowAnchorBar);

				#endregion

				#region Methods for Property showAnchorBarPopover

				/// <summary>
				/// Gets current value of property {@link #getShowAnchorBarPopover showAnchorBarPopover}.
				/// 
				/// Determines whether to show a Popover with Subsection links when clicking on Section links in the Anchor bar.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showAnchorBarPopover</code></returns>
				public extern virtual bool getShowAnchorBarPopover();

				/// <summary>
				/// Sets a new value for property {@link #getShowAnchorBarPopover showAnchorBarPopover}.
				/// 
				/// Determines whether to show a Popover with Subsection links when clicking on Section links in the Anchor bar.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowAnchorBarPopover">New value for property <code>showAnchorBarPopover</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setShowAnchorBarPopover(bool bShowAnchorBarPopover);

				#endregion

				#region Methods for Property upperCaseAnchorBar

				/// <summary>
				/// Gets current value of property {@link #getUpperCaseAnchorBar upperCaseAnchorBar}.
				/// 
				/// Determines whether the Anchor bar items are displayed in upper case.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>upperCaseAnchorBar</code></returns>
				public extern virtual bool getUpperCaseAnchorBar();

				/// <summary>
				/// Sets a new value for property {@link #getUpperCaseAnchorBar upperCaseAnchorBar}.
				/// 
				/// Determines whether the Anchor bar items are displayed in upper case.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bUpperCaseAnchorBar">New value for property <code>upperCaseAnchorBar</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setUpperCaseAnchorBar(bool bUpperCaseAnchorBar);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// Determines the height of the ObjectPage.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// Determines the height of the ObjectPage.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property enableLazyLoading

				/// <summary>
				/// Gets current value of property {@link #getEnableLazyLoading enableLazyLoading}.
				/// 
				/// Enable lazy loading for the Object page Subsections.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableLazyLoading</code></returns>
				public extern virtual bool getEnableLazyLoading();

				/// <summary>
				/// Sets a new value for property {@link #getEnableLazyLoading enableLazyLoading}.
				/// 
				/// Enable lazy loading for the Object page Subsections.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableLazyLoading">New value for property <code>enableLazyLoading</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setEnableLazyLoading(bool bEnableLazyLoading);

				#endregion

				#region Methods for Property subSectionLayout

				/// <summary>
				/// Gets current value of property {@link #getSubSectionLayout subSectionLayout}.
				/// 
				/// Determines whether Subsection titles are displayed on top or to the left of the Subsection content.
				/// 
				/// Default value is <code>TitleOnTop</code>.
				/// </summary>
				/// <returns>Value of property <code>subSectionLayout</code></returns>
				public extern virtual sap.uxap.ObjectPageSubSectionLayout getSubSectionLayout();

				/// <summary>
				/// Sets a new value for property {@link #getSubSectionLayout subSectionLayout}.
				/// 
				/// Determines whether Subsection titles are displayed on top or to the left of the Subsection content.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>TitleOnTop</code>.
				/// </summary>
				/// <param name="sSubSectionLayout">New value for property <code>subSectionLayout</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setSubSectionLayout(sap.uxap.ObjectPageSubSectionLayout sSubSectionLayout);

				#endregion

				#region Methods for Property sectionTitleLevel

				/// <summary>
				/// Gets current value of property {@link #getSectionTitleLevel sectionTitleLevel}.
				/// 
				/// Determines the ARIA level of the <code>ObjectPageSection</code> and <code>ObjectPageSubSection</code> titles. The ARIA level is used by assisting technologies, such as screen readers, to create a hierarchical site map for faster navigation.
				/// 
				/// <br><b>Note:</b> <ul> <li>Defining a <code>sectionTitleLevel</code> will add <code>aria-level</code> attribute from 1 to 6 instead of changing the titles` HTML tag from H1 to H6. <br>For example: if <code>sectionTitleLevel</code> is <code>TitleLevel.H1</code>, it will result as aria-level of 1 added to the <code>ObjectPageSection</code> title. </li>
				/// 
				/// <li> The <code>ObjectPageSubSection</code> title would have <code>aria-level</code> one level lower than the defined. For example: if <code>sectionTitleLevel</code> is <code>TitleLevel.H1</code>, it will result as aria-level of 2 added to the <code>ObjectPageSubSection</code> title.</li>
				/// 
				/// <li> It is possible to define a <code>titleLevel</code> on <code>ObjectPageSection</code> or <code>ObjectPageSubSection</code> level. In this case the value of this property will be ignored. </li> </ul>
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>sectionTitleLevel</code></returns>
				public extern virtual sap.ui.core.TitleLevel getSectionTitleLevel();

				/// <summary>
				/// Sets a new value for property {@link #getSectionTitleLevel sectionTitleLevel}.
				/// 
				/// Determines the ARIA level of the <code>ObjectPageSection</code> and <code>ObjectPageSubSection</code> titles. The ARIA level is used by assisting technologies, such as screen readers, to create a hierarchical site map for faster navigation.
				/// 
				/// <br><b>Note:</b> <ul> <li>Defining a <code>sectionTitleLevel</code> will add <code>aria-level</code> attribute from 1 to 6 instead of changing the titles` HTML tag from H1 to H6. <br>For example: if <code>sectionTitleLevel</code> is <code>TitleLevel.H1</code>, it will result as aria-level of 1 added to the <code>ObjectPageSection</code> title. </li>
				/// 
				/// <li> The <code>ObjectPageSubSection</code> title would have <code>aria-level</code> one level lower than the defined. For example: if <code>sectionTitleLevel</code> is <code>TitleLevel.H1</code>, it will result as aria-level of 2 added to the <code>ObjectPageSubSection</code> title.</li>
				/// 
				/// <li> It is possible to define a <code>titleLevel</code> on <code>ObjectPageSection</code> or <code>ObjectPageSubSection</code> level. In this case the value of this property will be ignored. </li> </ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <param name="sSectionTitleLevel">New value for property <code>sectionTitleLevel</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setSectionTitleLevel(sap.ui.core.TitleLevel sSectionTitleLevel);

				#endregion

				#region Methods for Property useIconTabBar

				/// <summary>
				/// Gets current value of property {@link #getUseIconTabBar useIconTabBar}.
				/// 
				/// Use tab navigation mode instead of the default Anchor bar mode. <br><b>Note: </b>Keep in mind that the <code>sap.m.IconTabBar</code> control is no longer used for the tab navigation mode.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>useIconTabBar</code></returns>
				public extern virtual bool getUseIconTabBar();

				/// <summary>
				/// Sets a new value for property {@link #getUseIconTabBar useIconTabBar}.
				/// 
				/// Use tab navigation mode instead of the default Anchor bar mode. <br><b>Note: </b>Keep in mind that the <code>sap.m.IconTabBar</code> control is no longer used for the tab navigation mode.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bUseIconTabBar">New value for property <code>useIconTabBar</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setUseIconTabBar(bool bUseIconTabBar);

				#endregion

				#region Methods for Property showHeaderContent

				/// <summary>
				/// Gets current value of property {@link #getShowHeaderContent showHeaderContent}.
				/// 
				/// Determines the visibility of the Header content (headerContent aggregation).
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showHeaderContent</code></returns>
				public extern virtual bool getShowHeaderContent();

				/// <summary>
				/// Sets a new value for property {@link #getShowHeaderContent showHeaderContent}.
				/// 
				/// Determines the visibility of the Header content (headerContent aggregation).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowHeaderContent">New value for property <code>showHeaderContent</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setShowHeaderContent(bool bShowHeaderContent);

				#endregion

				#region Methods for Property useTwoColumnsForLargeScreen

				/// <summary>
				/// Gets current value of property {@link #getUseTwoColumnsForLargeScreen useTwoColumnsForLargeScreen}.
				/// 
				/// Determines whether the to use two column layout for the L screen size.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>useTwoColumnsForLargeScreen</code></returns>
				public extern virtual bool getUseTwoColumnsForLargeScreen();

				/// <summary>
				/// Sets a new value for property {@link #getUseTwoColumnsForLargeScreen useTwoColumnsForLargeScreen}.
				/// 
				/// Determines whether the to use two column layout for the L screen size.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bUseTwoColumnsForLargeScreen">New value for property <code>useTwoColumnsForLargeScreen</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setUseTwoColumnsForLargeScreen(bool bUseTwoColumnsForLargeScreen);

				#endregion

				#region Methods for Property showTitleInHeaderContent

				/// <summary>
				/// Gets current value of property {@link #getShowTitleInHeaderContent showTitleInHeaderContent}.
				/// 
				/// Determines whether the title, image, markers and selectTitleArrow are shown in the Header content area.
				/// 
				/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.</li>
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showTitleInHeaderContent</code></returns>
				public extern virtual bool getShowTitleInHeaderContent();

				/// <summary>
				/// Sets a new value for property {@link #getShowTitleInHeaderContent showTitleInHeaderContent}.
				/// 
				/// Determines whether the title, image, markers and selectTitleArrow are shown in the Header content area.
				/// 
				/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.</li>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowTitleInHeaderContent">New value for property <code>showTitleInHeaderContent</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setShowTitleInHeaderContent(bool bShowTitleInHeaderContent);

				#endregion

				#region Methods for Property showOnlyHighImportance

				/// <summary>
				/// Gets current value of property {@link #getShowOnlyHighImportance showOnlyHighImportance}.
				/// 
				/// Determines whether sections and subsections with importance Low and Medium are hidden even on large screens.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showOnlyHighImportance</code></returns>
				public extern virtual bool getShowOnlyHighImportance();

				/// <summary>
				/// Sets a new value for property {@link #getShowOnlyHighImportance showOnlyHighImportance}.
				/// 
				/// Determines whether sections and subsections with importance Low and Medium are hidden even on large screens.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowOnlyHighImportance">New value for property <code>showOnlyHighImportance</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setShowOnlyHighImportance(bool bShowOnlyHighImportance);

				#endregion

				#region Methods for Property isChildPage

				/// <summary>
				/// Gets current value of property {@link #getIsChildPage isChildPage}.
				/// 
				/// Determines whether the page is a child page and renders it with a different design. Child pages have an additional (darker/lighter) stripe on the left side of their header content area.
				/// 
				/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>isChildPage</code></returns>
				public extern virtual bool getIsChildPage();

				/// <summary>
				/// Sets a new value for property {@link #getIsChildPage isChildPage}.
				/// 
				/// Determines whether the page is a child page and renders it with a different design. Child pages have an additional (darker/lighter) stripe on the left side of their header content area.
				/// 
				/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bIsChildPage">New value for property <code>isChildPage</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setIsChildPage(bool bIsChildPage);

				#endregion

				#region Methods for Property alwaysShowContentHeader

				/// <summary>
				/// Gets current value of property {@link #getAlwaysShowContentHeader alwaysShowContentHeader}.
				/// 
				/// Determines whether Header Content will always be expanded on desktop.
				/// 
				/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>alwaysShowContentHeader</code></returns>
				public extern virtual bool getAlwaysShowContentHeader();

				/// <summary>
				/// Sets a new value for property {@link #getAlwaysShowContentHeader alwaysShowContentHeader}.
				/// 
				/// Determines whether Header Content will always be expanded on desktop.
				/// 
				/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bAlwaysShowContentHeader">New value for property <code>alwaysShowContentHeader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setAlwaysShowContentHeader(bool bAlwaysShowContentHeader);

				#endregion

				#region Methods for Property headerContentPinnable

				/// <summary>
				/// Gets current value of property {@link #getHeaderContentPinnable headerContentPinnable}.
				/// 
				/// Determines whether the Header Content area can be pinned.
				/// 
				/// When set to <code>true</code>, a pin button is displayed within the Header Content area. The pin button allows the user to make the Header Content always visible at the top of the page above any scrollable content.
				/// 
				/// <b>Note:</b> This property is only taken into account if an instance of <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is used for the <code>headerTitle</code> aggregation.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>headerContentPinnable</code></returns>
				public extern virtual bool getHeaderContentPinnable();

				/// <summary>
				/// Sets a new value for property {@link #getHeaderContentPinnable headerContentPinnable}.
				/// 
				/// Determines whether the Header Content area can be pinned.
				/// 
				/// When set to <code>true</code>, a pin button is displayed within the Header Content area. The pin button allows the user to make the Header Content always visible at the top of the page above any scrollable content.
				/// 
				/// <b>Note:</b> This property is only taken into account if an instance of <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is used for the <code>headerTitle</code> aggregation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bHeaderContentPinnable">New value for property <code>headerContentPinnable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setHeaderContentPinnable(bool bHeaderContentPinnable);

				#endregion

				#region Methods for Property toggleHeaderOnTitleClick

				/// <summary>
				/// Gets current value of property {@link #getToggleHeaderOnTitleClick toggleHeaderOnTitleClick}.
				/// 
				/// Determines whether the user can switch between the expanded/collapsed states of the <code>sap.uxap.ObjectPageDynamicHeaderContent</code> by clicking on the <code>sap.uxap.ObjectPageDynamicHeaderTitle</code>. If set to <code>false</code>, the <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is not clickable and the application must provide other means for expanding/collapsing the <code>sap.uxap.ObjectPageDynamicHeaderContent</code>, if necessary.
				/// 
				/// <b>Note:</b> This property is only taken into account if an instance of <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is used for the <code>headerTitle</code> aggregation.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>toggleHeaderOnTitleClick</code></returns>
				public extern virtual bool getToggleHeaderOnTitleClick();

				/// <summary>
				/// Sets a new value for property {@link #getToggleHeaderOnTitleClick toggleHeaderOnTitleClick}.
				/// 
				/// Determines whether the user can switch between the expanded/collapsed states of the <code>sap.uxap.ObjectPageDynamicHeaderContent</code> by clicking on the <code>sap.uxap.ObjectPageDynamicHeaderTitle</code>. If set to <code>false</code>, the <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is not clickable and the application must provide other means for expanding/collapsing the <code>sap.uxap.ObjectPageDynamicHeaderContent</code>, if necessary.
				/// 
				/// <b>Note:</b> This property is only taken into account if an instance of <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is used for the <code>headerTitle</code> aggregation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bToggleHeaderOnTitleClick">New value for property <code>toggleHeaderOnTitleClick</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setToggleHeaderOnTitleClick(bool bToggleHeaderOnTitleClick);

				#endregion

				#region Methods for Property preserveHeaderStateOnScroll

				/// <summary>
				/// Gets current value of property {@link #getPreserveHeaderStateOnScroll preserveHeaderStateOnScroll}.
				/// 
				/// Preserves the current header state when scrolling. For example, if the user expands the header by clicking on the title and then scrolls down the page, the header will remain expanded.
				/// 
				/// <b>Notes:</b> <ul><li>This property is only taken into account if an instance of <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is used for the <code>headerTitle</code> aggregation.</li> <li>Based on internal rules, the value of the property is not always taken into account - for example, when the control is rendered on tablet or mobile and the control`s title and header are with height larger than the given threshold.</li></ul>
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>preserveHeaderStateOnScroll</code></returns>
				public extern virtual bool getPreserveHeaderStateOnScroll();

				/// <summary>
				/// Sets a new value for property {@link #getPreserveHeaderStateOnScroll preserveHeaderStateOnScroll}.
				/// 
				/// Preserves the current header state when scrolling. For example, if the user expands the header by clicking on the title and then scrolls down the page, the header will remain expanded.
				/// 
				/// <b>Notes:</b> <ul><li>This property is only taken into account if an instance of <code>sap.uxap.ObjectPageDynamicHeaderTitle</code> is used for the <code>headerTitle</code> aggregation.</li> <li>Based on internal rules, the value of the property is not always taken into account - for example, when the control is rendered on tablet or mobile and the control`s title and header are with height larger than the given threshold.</li></ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bPreserveHeaderStateOnScroll">New value for property <code>preserveHeaderStateOnScroll</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setPreserveHeaderStateOnScroll(bool bPreserveHeaderStateOnScroll);

				#endregion

				#region Methods for Property showEditHeaderButton

				/// <summary>
				/// Gets current value of property {@link #getShowEditHeaderButton showEditHeaderButton}.
				/// 
				/// Determines whether an Edit button will be displayed in Header Content.
				/// 
				/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showEditHeaderButton</code></returns>
				public extern virtual bool getShowEditHeaderButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowEditHeaderButton showEditHeaderButton}.
				/// 
				/// Determines whether an Edit button will be displayed in Header Content.
				/// 
				/// <b>Note</b>: This property is only taken into account if an instance of <code>sap.uxap.ObjectPageHeader</code> is used for the <code>headerTitle</code> aggregation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowEditHeaderButton">New value for property <code>showEditHeaderButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setShowEditHeaderButton(bool bShowEditHeaderButton);

				#endregion

				#region Methods for Property flexEnabled

				/// <summary>
				/// Gets current value of property {@link #getFlexEnabled flexEnabled}.
				/// 
				/// Specifies whether the object page enables flexibility features, such as hiding and adding sections.<br> For more information about SAPUI5 flexibility, refer to the Developer Guide.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>flexEnabled</code></returns>
				public extern virtual bool getFlexEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getFlexEnabled flexEnabled}.
				/// 
				/// Specifies whether the object page enables flexibility features, such as hiding and adding sections.<br> For more information about SAPUI5 flexibility, refer to the Developer Guide.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bFlexEnabled">New value for property <code>flexEnabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setFlexEnabled(bool bFlexEnabled);

				#endregion

				#region Methods for Property showFooter

				/// <summary>
				/// Gets current value of property {@link #getShowFooter showFooter}.
				/// 
				/// Determines whether the footer is visible.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showFooter</code></returns>
				public extern virtual bool getShowFooter();

				/// <summary>
				/// Sets a new value for property {@link #getShowFooter showFooter}.
				/// 
				/// Determines whether the footer is visible.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowFooter">New value for property <code>showFooter</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setShowFooter(bool bShowFooter);

				#endregion

				#region Methods for Aggregation sections

				/// <summary>
				/// Gets content of aggregation {@link #getSections sections}.
				/// 
				/// The sections that make up the Object page content area.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.uxap.ObjectPageSection[] getSections();

				/// <summary>
				/// Destroys all the sections in the aggregation {@link #getSections sections}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout destroySections();

				/// <summary>
				/// Inserts a section into the aggregation {@link #getSections sections}.
				/// </summary>
				/// <param name="oSection">The section to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the section should be inserted at; for a negative value of <code>iIndex</code>, the section is inserted at position 0; for a value greater than the current size of the aggregation, the section is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout insertSection(sap.uxap.ObjectPageSection oSection, int iIndex);

				/// <summary>
				/// Adds some section to the aggregation {@link #getSections sections}.
				/// </summary>
				/// <param name="oSection">The section to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout addSection(sap.uxap.ObjectPageSection oSection);

				/// <summary>
				/// Removes a section from the aggregation {@link #getSections sections}.
				/// </summary>
				/// <param name="vSection">The section to remove or its index or id</param>
				/// <returns>The removed section or <code>null</code></returns>
				public extern virtual sap.uxap.ObjectPageSection removeSection(Union<int, string, sap.uxap.ObjectPageSection> vSection);

				/// <summary>
				/// Checks for the provided <code>sap.uxap.ObjectPageSection</code> in the aggregation {@link #getSections sections}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oSection">The section whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfSection(sap.uxap.ObjectPageSection oSection);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getSections sections}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.uxap.ObjectPageSection[] removeAllSections();

				#endregion

				#region Methods for Aggregation headerTitle

				/// <summary>
				/// Gets content of aggregation {@link #getHeaderTitle headerTitle}.
				/// 
				/// Object page header title - the upper, always static, part of the Object page header.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.uxap.IHeaderTitle getHeaderTitle();

				/// <summary>
				/// Destroys the headerTitle in the aggregation {@link #getHeaderTitle headerTitle}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout destroyHeaderTitle();

				/// <summary>
				/// Sets the aggregated {@link #getHeaderTitle headerTitle}.
				/// </summary>
				/// <param name="oHeaderTitle">The headerTitle to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setHeaderTitle(sap.uxap.IHeaderTitle oHeaderTitle);

				#endregion

				#region Methods for Aggregation headerContent

				/// <summary>
				/// Gets content of aggregation {@link #getHeaderContent headerContent}.
				/// 
				/// Object page header content - the dynamic part of the Object page header.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getHeaderContent();

				/// <summary>
				/// Destroys all the headerContent in the aggregation {@link #getHeaderContent headerContent}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout destroyHeaderContent();

				/// <summary>
				/// Inserts a headerContent into the aggregation {@link #getHeaderContent headerContent}.
				/// </summary>
				/// <param name="oHeaderContent">The headerContent to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the headerContent should be inserted at; for a negative value of <code>iIndex</code>, the headerContent is inserted at position 0; for a value greater than the current size of the aggregation, the headerContent is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout insertHeaderContent(sap.ui.core.Control oHeaderContent, int iIndex);

				/// <summary>
				/// Adds some headerContent to the aggregation {@link #getHeaderContent headerContent}.
				/// </summary>
				/// <param name="oHeaderContent">The headerContent to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout addHeaderContent(sap.ui.core.Control oHeaderContent);

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

				#region Methods for Aggregation footer

				/// <summary>
				/// Gets content of aggregation {@link #getFooter footer}.
				/// 
				/// Object page floating footer.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IBar getFooter();

				/// <summary>
				/// Destroys the footer in the aggregation {@link #getFooter footer}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout destroyFooter();

				/// <summary>
				/// Sets the aggregated {@link #getFooter footer}.
				/// </summary>
				/// <param name="oFooter">The footer to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setFooter(sap.m.IBar oFooter);

				#endregion

				#region Methods for Aggregation _anchorBar

				#endregion

				#region Methods for Aggregation _iconTabBar

				#endregion

				#region Methods for Aggregation _headerContent

				#endregion

				#region Methods for Aggregation _customScrollBar

				#endregion

				#region Methods for Association selectedSection

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedSection selectedSection}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedSection();

				/// <summary>
				/// Sets the section that should be selected.
				/// 
				/// The section can either be given by itself or by its id.
				/// 
				/// Note that an argument of <code>null</code> will cause the first visible section be set as <code>selectedSection</code>. This is because the <code>sap.uxap.ObjectPageLayout</code> should always have one of its sections selected (unless it has 0 visible sections).
				/// </summary>
				/// <param name="sId">The ID or the section instance that should be selected Note that <code>null</code> or <code>undefined</code> are not valid arguments</param>
				/// <returns>Returns <code>this</code> to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout setSelectedSection(Union<string, sap.uxap.ObjectPageSection> sId);

				#endregion

				#region Methods for Event toggleAnchorBar

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleAnchorBar toggleAnchorBar} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the Anchor bar is switched from moving to fixed or the other way round.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachToggleAnchorBar(object oData, sap.uxap.ObjectPageLayout.ToggleAnchorBarDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleAnchorBar toggleAnchorBar} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the Anchor bar is switched from moving to fixed or the other way round.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachToggleAnchorBar(object oData, sap.uxap.ObjectPageLayout.ToggleAnchorBarDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleAnchorBar toggleAnchorBar} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the Anchor bar is switched from moving to fixed or the other way round.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachToggleAnchorBar(sap.uxap.ObjectPageLayout.ToggleAnchorBarDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleAnchorBar toggleAnchorBar} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the Anchor bar is switched from moving to fixed or the other way round.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachToggleAnchorBar(sap.uxap.ObjectPageLayout.ToggleAnchorBarDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:toggleAnchorBar toggleAnchorBar} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout detachToggleAnchorBar(sap.uxap.ObjectPageLayout.ToggleAnchorBarDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:toggleAnchorBar toggleAnchorBar} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout fireToggleAnchorBar(sap.uxap.ObjectPageLayout.ToggleAnchorBarInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:toggleAnchorBar toggleAnchorBar} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout fireToggleAnchorBar();

				#endregion

				#region Methods for Event editHeaderButtonPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:editHeaderButtonPress editHeaderButtonPress} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the Edit Header button is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachEditHeaderButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:editHeaderButtonPress editHeaderButtonPress} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the Edit Header button is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachEditHeaderButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:editHeaderButtonPress editHeaderButtonPress} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the Edit Header button is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachEditHeaderButtonPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:editHeaderButtonPress editHeaderButtonPress} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the Edit Header button is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachEditHeaderButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:editHeaderButtonPress editHeaderButtonPress} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout detachEditHeaderButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:editHeaderButtonPress editHeaderButtonPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout fireEditHeaderButtonPress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:editHeaderButtonPress editHeaderButtonPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout fireEditHeaderButtonPress();

				#endregion

				#region Methods for Event navigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the selected section is changed using the navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachNavigate(object oData, sap.uxap.ObjectPageLayout.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the selected section is changed using the navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachNavigate(object oData, sap.uxap.ObjectPageLayout.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the selected section is changed using the navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachNavigate(sap.uxap.ObjectPageLayout.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageLayout</code> itself.
				/// 
				/// The event is fired when the selected section is changed using the navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout attachNavigate(sap.uxap.ObjectPageLayout.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:navigate navigate} event of this <code>sap.uxap.ObjectPageLayout</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout detachNavigate(sap.uxap.ObjectPageLayout.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:navigate navigate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout fireNavigate(sap.uxap.ObjectPageLayout.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:navigate navigate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLayout fireNavigate();

				#endregion

				#region Other methods

				/// <summary>
				/// Resets the internal information of which subsections are in view and immediately calls the layout calculation so that an event <code>subSectionEnteredViewPort</code> is fired for the subsections that are actually in view. Use this method after a change in bindings to the existing object, since it's layout might have changed and the app needs to react to the new subsections in view.
				/// </summary>
				private extern void _triggerVisibleSubSectionsEvents();

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ObjectPageLayout.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns an sap.ui.core.delegate.ScrollEnablement object used to handle scrolling
				/// </summary>
				/// <returns></returns>
				public extern virtual object getScrollDelegate();

				/// <summary>
				/// Returns the UI5 ID of the Section that is currently being scrolled.
				/// </summary>
				/// <returns></returns>
				public extern virtual string getScrollingSectionId();

				/// <summary>
				/// This triggers rerendering of itself and its children.
				/// </summary>
				/// <param name="oOrigin">Child control for which the method was called</br> If the child is an instance of <code>sap.uxap.ObjectPageSection</code> that corresponds to an inactive tab, the invalidation will be suppressed (in iconTabBar mode)</param>
				public extern override void invalidate(sap.ui.@base.ManagedObject oOrigin);

				/// <summary>
				/// This triggers rerendering of itself and its children.
				/// </summary>
				public extern override void invalidate();

				/// <summary>
				/// Scrolls the Object page to the given Section.
				/// </summary>
				/// <param name="sId">The Section ID to scroll to</param>
				/// <param name="iDuration">Scroll duration (in ms). Default value is 0</param>
				/// <param name="iOffset">Additional pixels to scroll</param>
				public extern virtual void scrollToSection(string sId, int iDuration, int iOffset);

				#endregion

				#endregion

			}
		}
	}
}
