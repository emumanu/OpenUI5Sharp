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
			public static partial class ux3
			{
				/// <summary>
				/// The Ux3 GoldReflection Shell, which is an application frame with navigation capabilities. It is supposed to be added to a direct child of the BODY tag of a page and there should be no other parts of the page consuming space outside the Shell.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.Shell")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.Shell}")]
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
						/// The application title to appear in the left part of the header, usually a company and/or product name. appIcon and appTitle are both optional and can both be set; in this case the icon appears first.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> appTitle;

						/// <summary>
						/// The URL of the image to appear in the left part of the header, usually a branding image containing a logo and/or product name. appIcon and appTitle are both optional and can both be set; in this case the icon appears first. If the appIcon is set, for accessibility reasons the appIconTooltip must also be set.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> appIcon;

						/// <summary>
						/// The tooltip of the application icon in the header
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> appIconTooltip;

						/// <summary>
						/// Whether the Logoff button in the header should be displayed or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showLogoutButton;

						/// <summary>
						/// The tooltip to be displayed for the Logout Button of the Shell. If not set, a text meaning "Logout" in the current language will be displayed.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> logoutButtonTooltip;

						/// <summary>
						/// Whether the "Global Search" tool should be displayed or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSearchTool;

						/// <summary>
						/// Whether the "Inspector" tool should be displayed or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showInspectorTool;

						/// <summary>
						/// Whether the "Feeder" tool should be displayed or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showFeederTool;

						/// <summary>
						/// Whether the tool area should be displayed at all or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showTools;

						/// <summary>
						/// Whether the pane bar should be displayed at all or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showPane;

						/// <summary>
						/// Defines which header type to be used. Depending on the header type some other functionality might be obsolete.
						/// </summary>
						public Union<sap.ui.ux3.ShellHeaderType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerType;

						/// <summary>
						/// Defines which design type is to be used.
						/// </summary>
						public Union<sap.ui.ux3.ShellDesignType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> designType;

						/// <summary>
						/// The width of the right-hand side pane in pixels. The value must be a non-negative integer. The Shell reserves the right to define a minimum width (currently 50px).
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> paneWidth;

						/// <summary>
						/// Whether the Shell content area should have a theme-dependent padding or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> applyContentPadding;

						/// <summary>
						/// If set to true, the content area has a defined height. This means that any content put inside can use "100%" height in CSS and will then consume all available space. However, if content is larger, scrollbars will appear at the content area of the Shell and not on window level.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fullHeightContent;

						/// <summary>
						/// Whether the Shell header (Title Area + Header Items) can be accessed when an Overlay, OverlayContainer or ThingInspector is open.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> allowOverlayHeaderAccess;

						/// <summary>
						/// The workset items.
						/// </summary>
						public Union<sap.ui.ux3.NavigationItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> worksetItems;

						/// <summary>
						/// The items to appear in the PaneBar.
						/// </summary>
						public Union<sap.ui.core.Item[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> paneBarItems;

						/// <summary>
						/// The content to appear in the pane area.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> paneContent;

						/// <summary>
						/// The content to appear in the main canvas. Each modification of this aggregation leads to a re-rendering of the content area - but not to a re-rendering of the complete Shell.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// The items which appear in the ToolPalette and are opened as popup when clicked.
						/// </summary>
						public Union<sap.ui.ux3.ToolPopup[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> toolPopups;

						/// <summary>
						/// Controls to appear in the header next to the logout button. It is recommended to only use controls of type Button, MenuButton and TextView. The respective UI guidelines need to be enforced on a higher level.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerItems;

						/// <summary>
						/// The NotificationBar which should be integrated into the Shell.
						/// </summary>
						public Union<sap.ui.ux3.NotificationBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> notificationBar;

						/// <summary>
						/// The ID of the Item that is currently selected. When setting, the NavigationItem itself can be given instead of its ID. There will not be a worksetItemSelected event, the application is responsible to show the proper content according to the newly selected WorksetItem. If the set WorksetItem does not exist in this Shell, the first item (and first sub-item) will be selected after the call. When getting, always the ID is returned, by which the NavigationItem instance can be retrieved.
						/// </summary>
						public Union<sap.ui.ux3.NavigationItem, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedWorksetItem;

						/// <summary>
						/// Fired when a workset item was selected by the user. The application may populate the sub-items of the given workset item in the event handler, but this must happen synchronously. If this is done, the application is responsible for displaying the correct content for the selected one of the newly created sub-items. The Shell will currently always mark the first sub-item as selected.
						/// </summary>
						public sap.ui.ux3.SelectedDelegate worksetItemSelected;

						/// <summary>
						/// An item in the right-hand-side pane bar has been selected, the pane is now visible and can be filled with UI elements.
						/// </summary>
						public sap.ui.ux3.Shell.PaneBarItemSelectedDelegate paneBarItemSelected;

						/// <summary>
						/// Fired when the user clicks the "Log-off" button
						/// </summary>
						public sap.ui.@base.EventDelegate logout;

						/// <summary>
						/// Fired when search has been triggered.
						/// </summary>
						public sap.ui.@base.EventDelegate search;

						/// <summary>
						/// Fired when a new feed entry is submitted.
						/// </summary>
						public sap.ui.@base.EventDelegate feedSubmit;

						/// <summary>
						/// Fired after a side pane of the shell is closed. It is also fired, when an open pane is closed by calling setShowPane(false), if and only if the pane was opened before.
						/// </summary>
						public sap.ui.ux3.Delegate paneClosed;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class PaneBarItemSelectedInfo
					{
						/// <summary>
						/// The ID of the selected PaneBarItem.
						/// </summary>
						public string id;

						/// <summary>
						/// The selected Item
						/// </summary>
						public sap.ui.core.Item item;

						/// <summary>
						/// The key of the selected Item (or null if there is no key)
						/// </summary>
						public string key;

					}

					#endregion

					#region Delegates

					public delegate void PaneBarItemSelectedDelegate(sap.ui.@base.Event<sap.ui.ux3.Shell.PaneBarItemSelectedInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Shell.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Shell(string sId, sap.ui.ux3.Shell.Settings mSettings);

					/// <summary>
					/// Constructor for a new Shell.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
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
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Shell(sap.ui.ux3.Shell.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property appTitle

					/// <summary>
					/// Gets current value of property {@link #getAppTitle appTitle}.
					/// 
					/// The application title to appear in the left part of the header, usually a company and/or product name. appIcon and appTitle are both optional and can both be set; in this case the icon appears first.
					/// </summary>
					/// <returns>Value of property <code>appTitle</code></returns>
					public extern virtual string getAppTitle();

					/// <summary>
					/// Sets a new value for property {@link #getAppTitle appTitle}.
					/// 
					/// The application title to appear in the left part of the header, usually a company and/or product name. appIcon and appTitle are both optional and can both be set; in this case the icon appears first.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sAppTitle">New value for property <code>appTitle</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setAppTitle(string sAppTitle);

					#endregion

					#region Methods for Property appIcon

					/// <summary>
					/// Gets current value of property {@link #getAppIcon appIcon}.
					/// 
					/// The URL of the image to appear in the left part of the header, usually a branding image containing a logo and/or product name. appIcon and appTitle are both optional and can both be set; in this case the icon appears first. If the appIcon is set, for accessibility reasons the appIconTooltip must also be set.
					/// </summary>
					/// <returns>Value of property <code>appIcon</code></returns>
					public extern virtual sap.ui.core.URI getAppIcon();

					/// <summary>
					/// Sets a new value for property {@link #getAppIcon appIcon}.
					/// 
					/// The URL of the image to appear in the left part of the header, usually a branding image containing a logo and/or product name. appIcon and appTitle are both optional and can both be set; in this case the icon appears first. If the appIcon is set, for accessibility reasons the appIconTooltip must also be set.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sAppIcon">New value for property <code>appIcon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setAppIcon(sap.ui.core.URI sAppIcon);

					#endregion

					#region Methods for Property appIconTooltip

					/// <summary>
					/// Gets current value of property {@link #getAppIconTooltip appIconTooltip}.
					/// 
					/// The tooltip of the application icon in the header
					/// </summary>
					/// <returns>Value of property <code>appIconTooltip</code></returns>
					public extern virtual string getAppIconTooltip();

					/// <summary>
					/// Sets a new value for property {@link #getAppIconTooltip appIconTooltip}.
					/// 
					/// The tooltip of the application icon in the header
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sAppIconTooltip">New value for property <code>appIconTooltip</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setAppIconTooltip(string sAppIconTooltip);

					#endregion

					#region Methods for Property showLogoutButton

					/// <summary>
					/// Gets current value of property {@link #getShowLogoutButton showLogoutButton}.
					/// 
					/// Whether the Logoff button in the header should be displayed or not.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showLogoutButton</code></returns>
					public extern virtual bool getShowLogoutButton();

					/// <summary>
					/// Sets a new value for property {@link #getShowLogoutButton showLogoutButton}.
					/// 
					/// Whether the Logoff button in the header should be displayed or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowLogoutButton">New value for property <code>showLogoutButton</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setShowLogoutButton(bool bShowLogoutButton);

					#endregion

					#region Methods for Property logoutButtonTooltip

					/// <summary>
					/// Gets current value of property {@link #getLogoutButtonTooltip logoutButtonTooltip}.
					/// 
					/// The tooltip to be displayed for the Logout Button of the Shell. If not set, a text meaning "Logout" in the current language will be displayed.
					/// </summary>
					/// <returns>Value of property <code>logoutButtonTooltip</code></returns>
					public extern virtual string getLogoutButtonTooltip();

					/// <summary>
					/// Sets a new value for property {@link #getLogoutButtonTooltip logoutButtonTooltip}.
					/// 
					/// The tooltip to be displayed for the Logout Button of the Shell. If not set, a text meaning "Logout" in the current language will be displayed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sLogoutButtonTooltip">New value for property <code>logoutButtonTooltip</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setLogoutButtonTooltip(string sLogoutButtonTooltip);

					#endregion

					#region Methods for Property showSearchTool

					/// <summary>
					/// Gets current value of property {@link #getShowSearchTool showSearchTool}.
					/// 
					/// Whether the "Global Search" tool should be displayed or not.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showSearchTool</code></returns>
					public extern virtual bool getShowSearchTool();

					/// <summary>
					/// Sets a new value for property {@link #getShowSearchTool showSearchTool}.
					/// 
					/// Whether the "Global Search" tool should be displayed or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowSearchTool">New value for property <code>showSearchTool</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setShowSearchTool(bool bShowSearchTool);

					#endregion

					#region Methods for Property showInspectorTool

					/// <summary>
					/// Gets current value of property {@link #getShowInspectorTool showInspectorTool}.
					/// 
					/// Whether the "Inspector" tool should be displayed or not.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>showInspectorTool</code></returns>
					[Obsolete("Deprecated since 1.7.2. According to the current Ux designs, the ThingInspector should NOT be opened like this from the Tool Pane. And technically, the ThingInspector is not a ToolPopup. Instead trigger it from the respective elements in the Shell content.")]
					public extern virtual bool getShowInspectorTool();

					/// <summary>
					/// Sets a new value for property {@link #getShowInspectorTool showInspectorTool}.
					/// 
					/// Whether the "Inspector" tool should be displayed or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShowInspectorTool">New value for property <code>showInspectorTool</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.7.2. According to the current Ux designs, the ThingInspector should NOT be opened like this from the Tool Pane. And technically, the ThingInspector is not a ToolPopup. Instead trigger it from the respective elements in the Shell content.")]
					public extern virtual sap.ui.ux3.Shell setShowInspectorTool(bool bShowInspectorTool);

					#endregion

					#region Methods for Property showFeederTool

					/// <summary>
					/// Gets current value of property {@link #getShowFeederTool showFeederTool}.
					/// 
					/// Whether the "Feeder" tool should be displayed or not.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showFeederTool</code></returns>
					public extern virtual bool getShowFeederTool();

					/// <summary>
					/// Sets a new value for property {@link #getShowFeederTool showFeederTool}.
					/// 
					/// Whether the "Feeder" tool should be displayed or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowFeederTool">New value for property <code>showFeederTool</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setShowFeederTool(bool bShowFeederTool);

					#endregion

					#region Methods for Property showTools

					/// <summary>
					/// Gets current value of property {@link #getShowTools showTools}.
					/// 
					/// Whether the tool area should be displayed at all or not.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showTools</code></returns>
					public extern virtual bool getShowTools();

					/// <summary>
					/// Sets a new value for property {@link #getShowTools showTools}.
					/// 
					/// Whether the tool area should be displayed at all or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowTools">New value for property <code>showTools</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setShowTools(bool bShowTools);

					#endregion

					#region Methods for Property showPane

					/// <summary>
					/// Gets current value of property {@link #getShowPane showPane}.
					/// 
					/// Whether the pane bar should be displayed at all or not.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showPane</code></returns>
					public extern virtual bool getShowPane();

					/// <summary>
					/// Sets a new value for property {@link #getShowPane showPane}.
					/// 
					/// Whether the pane bar should be displayed at all or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowPane">New value for property <code>showPane</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setShowPane(bool bShowPane);

					#endregion

					#region Methods for Property headerType

					/// <summary>
					/// Gets current value of property {@link #getHeaderType headerType}.
					/// 
					/// Defines which header type to be used. Depending on the header type some other functionality might be obsolete.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <returns>Value of property <code>headerType</code></returns>
					public extern virtual sap.ui.ux3.ShellHeaderType getHeaderType();

					/// <summary>
					/// Sets a new value for property {@link #getHeaderType headerType}.
					/// 
					/// Defines which header type to be used. Depending on the header type some other functionality might be obsolete.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <param name="sHeaderType">New value for property <code>headerType</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setHeaderType(sap.ui.ux3.ShellHeaderType sHeaderType);

					#endregion

					#region Methods for Property designType

					/// <summary>
					/// Gets current value of property {@link #getDesignType designType}.
					/// 
					/// Defines which design type is to be used.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <returns>Value of property <code>designType</code></returns>
					public extern virtual sap.ui.ux3.ShellDesignType getDesignType();

					/// <summary>
					/// Sets a new value for property {@link #getDesignType designType}.
					/// 
					/// Defines which design type is to be used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <param name="sDesignType">New value for property <code>designType</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setDesignType(sap.ui.ux3.ShellDesignType sDesignType);

					#endregion

					#region Methods for Property paneWidth

					/// <summary>
					/// Gets current value of property {@link #getPaneWidth paneWidth}.
					/// 
					/// The width of the right-hand side pane in pixels. The value must be a non-negative integer. The Shell reserves the right to define a minimum width (currently 50px).
					/// 
					/// Default value is <code>250</code>.
					/// </summary>
					/// <returns>Value of property <code>paneWidth</code></returns>
					public extern virtual int getPaneWidth();

					/// <summary>
					/// Sets a new value for property {@link #getPaneWidth paneWidth}.
					/// 
					/// The width of the right-hand side pane in pixels. The value must be a non-negative integer. The Shell reserves the right to define a minimum width (currently 50px).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>250</code>.
					/// </summary>
					/// <param name="iPaneWidth">New value for property <code>paneWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setPaneWidth(int iPaneWidth);

					#endregion

					#region Methods for Property applyContentPadding

					/// <summary>
					/// Gets current value of property {@link #getApplyContentPadding applyContentPadding}.
					/// 
					/// Whether the Shell content area should have a theme-dependent padding or not.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>applyContentPadding</code></returns>
					public extern virtual bool getApplyContentPadding();

					/// <summary>
					/// Sets a new value for property {@link #getApplyContentPadding applyContentPadding}.
					/// 
					/// Whether the Shell content area should have a theme-dependent padding or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bApplyContentPadding">New value for property <code>applyContentPadding</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setApplyContentPadding(bool bApplyContentPadding);

					#endregion

					#region Methods for Property fullHeightContent

					/// <summary>
					/// Gets current value of property {@link #getFullHeightContent fullHeightContent}.
					/// 
					/// If set to true, the content area has a defined height. This means that any content put inside can use "100%" height in CSS and will then consume all available space. However, if content is larger, scrollbars will appear at the content area of the Shell and not on window level.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>fullHeightContent</code></returns>
					public extern virtual bool getFullHeightContent();

					/// <summary>
					/// Sets a new value for property {@link #getFullHeightContent fullHeightContent}.
					/// 
					/// If set to true, the content area has a defined height. This means that any content put inside can use "100%" height in CSS and will then consume all available space. However, if content is larger, scrollbars will appear at the content area of the Shell and not on window level.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bFullHeightContent">New value for property <code>fullHeightContent</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setFullHeightContent(bool bFullHeightContent);

					#endregion

					#region Methods for Property allowOverlayHeaderAccess

					/// <summary>
					/// Gets current value of property {@link #getAllowOverlayHeaderAccess allowOverlayHeaderAccess}.
					/// 
					/// Whether the Shell header (Title Area + Header Items) can be accessed when an Overlay, OverlayContainer or ThingInspector is open.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>allowOverlayHeaderAccess</code></returns>
					public extern virtual bool getAllowOverlayHeaderAccess();

					/// <summary>
					/// Sets a new value for property {@link #getAllowOverlayHeaderAccess allowOverlayHeaderAccess}.
					/// 
					/// Whether the Shell header (Title Area + Header Items) can be accessed when an Overlay, OverlayContainer or ThingInspector is open.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bAllowOverlayHeaderAccess">New value for property <code>allowOverlayHeaderAccess</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setAllowOverlayHeaderAccess(bool bAllowOverlayHeaderAccess);

					#endregion

					#region Methods for Aggregation worksetItems

					/// <summary>
					/// Gets content of aggregation {@link #getWorksetItems worksetItems}.
					/// 
					/// The workset items.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.NavigationItem[] getWorksetItems();

					/// <summary>
					/// Destroys all the worksetItems in the aggregation {@link #getWorksetItems worksetItems}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell destroyWorksetItems();

					/// <summary>
					/// Inserts a worksetItem into the aggregation {@link #getWorksetItems worksetItems}.
					/// </summary>
					/// <param name="oWorksetItem">The worksetItem to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the worksetItem should be inserted at; for a negative value of <code>iIndex</code>, the worksetItem is inserted at position 0; for a value greater than the current size of the aggregation, the worksetItem is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell insertWorksetItem(sap.ui.ux3.NavigationItem oWorksetItem, int iIndex);

					/// <summary>
					/// Adds some worksetItem to the aggregation {@link #getWorksetItems worksetItems}.
					/// </summary>
					/// <param name="oWorksetItem">The worksetItem to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell addWorksetItem(sap.ui.ux3.NavigationItem oWorksetItem);

					/// <summary>
					/// Removes a worksetItem from the aggregation {@link #getWorksetItems worksetItems}.
					/// </summary>
					/// <param name="vWorksetItem">The worksetItem to remove or its index or id</param>
					/// <returns>The removed worksetItem or <code>null</code></returns>
					public extern virtual sap.ui.ux3.NavigationItem removeWorksetItem(Union<int, string, sap.ui.ux3.NavigationItem> vWorksetItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.NavigationItem</code> in the aggregation {@link #getWorksetItems worksetItems}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oWorksetItem">The worksetItem whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfWorksetItem(sap.ui.ux3.NavigationItem oWorksetItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getWorksetItems worksetItems}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.NavigationItem[] removeAllWorksetItems();

					#endregion

					#region Methods for Aggregation paneBarItems

					/// <summary>
					/// Gets content of aggregation {@link #getPaneBarItems paneBarItems}.
					/// 
					/// The items to appear in the PaneBar.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Item[] getPaneBarItems();

					/// <summary>
					/// Destroys all the paneBarItems in the aggregation {@link #getPaneBarItems paneBarItems}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell destroyPaneBarItems();

					/// <summary>
					/// Inserts a paneBarItem into the aggregation {@link #getPaneBarItems paneBarItems}.
					/// </summary>
					/// <param name="oPaneBarItem">The paneBarItem to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the paneBarItem should be inserted at; for a negative value of <code>iIndex</code>, the paneBarItem is inserted at position 0; for a value greater than the current size of the aggregation, the paneBarItem is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell insertPaneBarItem(sap.ui.core.Item oPaneBarItem, int iIndex);

					/// <summary>
					/// Adds some paneBarItem to the aggregation {@link #getPaneBarItems paneBarItems}.
					/// </summary>
					/// <param name="oPaneBarItem">The paneBarItem to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell addPaneBarItem(sap.ui.core.Item oPaneBarItem);

					/// <summary>
					/// Removes a paneBarItem from the aggregation {@link #getPaneBarItems paneBarItems}.
					/// </summary>
					/// <param name="vPaneBarItem">The paneBarItem to remove or its index or id</param>
					/// <returns>The removed paneBarItem or <code>null</code></returns>
					public extern virtual sap.ui.core.Item removePaneBarItem(Union<int, string, sap.ui.core.Item> vPaneBarItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Item</code> in the aggregation {@link #getPaneBarItems paneBarItems}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oPaneBarItem">The paneBarItem whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfPaneBarItem(sap.ui.core.Item oPaneBarItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getPaneBarItems paneBarItems}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Item[] removeAllPaneBarItems();

					#endregion

					#region Methods for Aggregation paneContent

					/// <summary>
					/// Gets content of aggregation {@link #getPaneContent paneContent}.
					/// 
					/// The content to appear in the pane area.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getPaneContent();

					/// <summary>
					/// Destroys all the paneContent in the aggregation {@link #getPaneContent paneContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell destroyPaneContent();

					/// <summary>
					/// Inserts a paneContent into the aggregation {@link #getPaneContent paneContent}.
					/// </summary>
					/// <param name="oPaneContent">The paneContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the paneContent should be inserted at; for a negative value of <code>iIndex</code>, the paneContent is inserted at position 0; for a value greater than the current size of the aggregation, the paneContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell insertPaneContent(sap.ui.core.Control oPaneContent, int iIndex);

					/// <summary>
					/// Adds some paneContent to the aggregation {@link #getPaneContent paneContent}.
					/// </summary>
					/// <param name="oPaneContent">The paneContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell addPaneContent(sap.ui.core.Control oPaneContent);

					/// <summary>
					/// Removes a paneContent from the aggregation {@link #getPaneContent paneContent}.
					/// </summary>
					/// <param name="vPaneContent">The paneContent to remove or its index or id</param>
					/// <returns>The removed paneContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removePaneContent(Union<int, string, sap.ui.core.Control> vPaneContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getPaneContent paneContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oPaneContent">The paneContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfPaneContent(sap.ui.core.Control oPaneContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getPaneContent paneContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllPaneContent();

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// The content to appear in the main canvas. Each modification of this aggregation leads to a re-rendering of the content area - but not to a re-rendering of the complete Shell.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell addContent(sap.ui.core.Control oContent);

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

					#region Methods for Aggregation toolPopups

					/// <summary>
					/// Gets content of aggregation {@link #getToolPopups toolPopups}.
					/// 
					/// The items which appear in the ToolPalette and are opened as popup when clicked.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ToolPopup[] getToolPopups();

					/// <summary>
					/// Destroys all the toolPopups in the aggregation {@link #getToolPopups toolPopups}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell destroyToolPopups();

					/// <summary>
					/// Inserts a toolPopup into the aggregation {@link #getToolPopups toolPopups}.
					/// </summary>
					/// <param name="oToolPopup">The toolPopup to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the toolPopup should be inserted at; for a negative value of <code>iIndex</code>, the toolPopup is inserted at position 0; for a value greater than the current size of the aggregation, the toolPopup is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell insertToolPopup(sap.ui.ux3.ToolPopup oToolPopup, int iIndex);

					/// <summary>
					/// Adds some toolPopup to the aggregation {@link #getToolPopups toolPopups}.
					/// </summary>
					/// <param name="oToolPopup">The toolPopup to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell addToolPopup(sap.ui.ux3.ToolPopup oToolPopup);

					/// <summary>
					/// Removes a toolPopup from the aggregation {@link #getToolPopups toolPopups}.
					/// </summary>
					/// <param name="vToolPopup">The toolPopup to remove or its index or id</param>
					/// <returns>The removed toolPopup or <code>null</code></returns>
					public extern virtual sap.ui.ux3.ToolPopup removeToolPopup(Union<int, string, sap.ui.ux3.ToolPopup> vToolPopup);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.ToolPopup</code> in the aggregation {@link #getToolPopups toolPopups}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oToolPopup">The toolPopup whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfToolPopup(sap.ui.ux3.ToolPopup oToolPopup);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getToolPopups toolPopups}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.ToolPopup[] removeAllToolPopups();

					#endregion

					#region Methods for Aggregation headerItems

					/// <summary>
					/// Gets content of aggregation {@link #getHeaderItems headerItems}.
					/// 
					/// Controls to appear in the header next to the logout button. It is recommended to only use controls of type Button, MenuButton and TextView. The respective UI guidelines need to be enforced on a higher level.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getHeaderItems();

					/// <summary>
					/// Destroys all the headerItems in the aggregation {@link #getHeaderItems headerItems}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell destroyHeaderItems();

					/// <summary>
					/// Inserts a headerItem into the aggregation {@link #getHeaderItems headerItems}.
					/// </summary>
					/// <param name="oHeaderItem">The headerItem to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the headerItem should be inserted at; for a negative value of <code>iIndex</code>, the headerItem is inserted at position 0; for a value greater than the current size of the aggregation, the headerItem is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell insertHeaderItem(sap.ui.core.Control oHeaderItem, int iIndex);

					/// <summary>
					/// Adds some headerItem to the aggregation {@link #getHeaderItems headerItems}.
					/// </summary>
					/// <param name="oHeaderItem">The headerItem to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell addHeaderItem(sap.ui.core.Control oHeaderItem);

					/// <summary>
					/// Removes a headerItem from the aggregation {@link #getHeaderItems headerItems}.
					/// </summary>
					/// <param name="vHeaderItem">The headerItem to remove or its index or id</param>
					/// <returns>The removed headerItem or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeHeaderItem(Union<int, string, sap.ui.core.Control> vHeaderItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getHeaderItems headerItems}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oHeaderItem">The headerItem whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfHeaderItem(sap.ui.core.Control oHeaderItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getHeaderItems headerItems}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllHeaderItems();

					#endregion

					#region Methods for Aggregation notificationBar

					/// <summary>
					/// Gets content of aggregation {@link #getNotificationBar notificationBar}.
					/// 
					/// The NotificationBar which should be integrated into the Shell.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.NotificationBar getNotificationBar();

					/// <summary>
					/// Destroys the notificationBar in the aggregation {@link #getNotificationBar notificationBar}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell destroyNotificationBar();

					#endregion

					#region Methods for Aggregation _paneOverflowMenu

					#endregion

					#region Methods for Association selectedWorksetItem

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getSelectedWorksetItem selectedWorksetItem}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getSelectedWorksetItem();

					/// <summary>
					/// Sets the associated {@link #getSelectedWorksetItem selectedWorksetItem}.
					/// </summary>
					/// <param name="oSelectedWorksetItem">ID of an element which becomes the new target of this selectedWorksetItem association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell setSelectedWorksetItem(Union<sap.ui.core.ID, sap.ui.ux3.NavigationItem> oSelectedWorksetItem);

					#endregion

					#region Methods for Event worksetItemSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:worksetItemSelected worksetItemSelected} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when a workset item was selected by the user. The application may populate the sub-items of the given workset item in the event handler, but this must happen synchronously. If this is done, the application is responsible for displaying the correct content for the selected one of the newly created sub-items. The Shell will currently always mark the first sub-item as selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachWorksetItemSelected(object oData, sap.ui.ux3.SelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:worksetItemSelected worksetItemSelected} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when a workset item was selected by the user. The application may populate the sub-items of the given workset item in the event handler, but this must happen synchronously. If this is done, the application is responsible for displaying the correct content for the selected one of the newly created sub-items. The Shell will currently always mark the first sub-item as selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachWorksetItemSelected(object oData, sap.ui.ux3.SelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:worksetItemSelected worksetItemSelected} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when a workset item was selected by the user. The application may populate the sub-items of the given workset item in the event handler, but this must happen synchronously. If this is done, the application is responsible for displaying the correct content for the selected one of the newly created sub-items. The Shell will currently always mark the first sub-item as selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachWorksetItemSelected(sap.ui.ux3.SelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:worksetItemSelected worksetItemSelected} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when a workset item was selected by the user. The application may populate the sub-items of the given workset item in the event handler, but this must happen synchronously. If this is done, the application is responsible for displaying the correct content for the selected one of the newly created sub-items. The Shell will currently always mark the first sub-item as selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachWorksetItemSelected(sap.ui.ux3.SelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:worksetItemSelected worksetItemSelected} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell detachWorksetItemSelected(sap.ui.ux3.SelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:worksetItemSelected worksetItemSelected} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireWorksetItemSelected(sap.ui.ux3.SelectedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:worksetItemSelected worksetItemSelected} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireWorksetItemSelected();

					#endregion

					#region Methods for Event paneBarItemSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:paneBarItemSelected paneBarItemSelected} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// An item in the right-hand-side pane bar has been selected, the pane is now visible and can be filled with UI elements.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachPaneBarItemSelected(object oData, sap.ui.ux3.Shell.PaneBarItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:paneBarItemSelected paneBarItemSelected} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// An item in the right-hand-side pane bar has been selected, the pane is now visible and can be filled with UI elements.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachPaneBarItemSelected(object oData, sap.ui.ux3.Shell.PaneBarItemSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:paneBarItemSelected paneBarItemSelected} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// An item in the right-hand-side pane bar has been selected, the pane is now visible and can be filled with UI elements.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachPaneBarItemSelected(sap.ui.ux3.Shell.PaneBarItemSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:paneBarItemSelected paneBarItemSelected} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// An item in the right-hand-side pane bar has been selected, the pane is now visible and can be filled with UI elements.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachPaneBarItemSelected(sap.ui.ux3.Shell.PaneBarItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:paneBarItemSelected paneBarItemSelected} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell detachPaneBarItemSelected(sap.ui.ux3.Shell.PaneBarItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:paneBarItemSelected paneBarItemSelected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell firePaneBarItemSelected(sap.ui.ux3.Shell.PaneBarItemSelectedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:paneBarItemSelected paneBarItemSelected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell firePaneBarItemSelected();

					#endregion

					#region Methods for Event logout

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:logout logout} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when the user clicks the "Log-off" button
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachLogout(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:logout logout} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when the user clicks the "Log-off" button
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachLogout(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:logout logout} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when the user clicks the "Log-off" button
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachLogout(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:logout logout} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when the user clicks the "Log-off" button
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachLogout(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:logout logout} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell detachLogout(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:logout logout} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell fireLogout(object mParameters);

					/// <summary>
					/// Fires event {@link #event:logout logout} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell fireLogout();

					#endregion

					#region Methods for Event search

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when search has been triggered.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachSearch(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when search has been triggered.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachSearch(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when search has been triggered.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachSearch(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when search has been triggered.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachSearch(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:search search} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell detachSearch(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:search search} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell fireSearch(object mParameters);

					/// <summary>
					/// Fires event {@link #event:search search} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell fireSearch();

					#endregion

					#region Methods for Event feedSubmit

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachFeedSubmit(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachFeedSubmit(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachFeedSubmit(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachFeedSubmit(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell detachFeedSubmit(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:feedSubmit feedSubmit} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell fireFeedSubmit(object mParameters);

					/// <summary>
					/// Fires event {@link #event:feedSubmit feedSubmit} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell fireFeedSubmit();

					#endregion

					#region Methods for Event paneClosed

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:paneClosed paneClosed} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired after a side pane of the shell is closed. It is also fired, when an open pane is closed by calling setShowPane(false), if and only if the pane was opened before.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachPaneClosed(object oData, sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:paneClosed paneClosed} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired after a side pane of the shell is closed. It is also fired, when an open pane is closed by calling setShowPane(false), if and only if the pane was opened before.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachPaneClosed(object oData, sap.ui.ux3.Delegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:paneClosed paneClosed} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired after a side pane of the shell is closed. It is also fired, when an open pane is closed by calling setShowPane(false), if and only if the pane was opened before.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachPaneClosed(sap.ui.ux3.Delegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:paneClosed paneClosed} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Shell</code> itself.
					/// 
					/// Fired after a side pane of the shell is closed. It is also fired, when an open pane is closed by calling setShowPane(false), if and only if the pane was opened before.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Shell</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell attachPaneClosed(sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:paneClosed paneClosed} event of this <code>sap.ui.ux3.Shell</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell detachPaneClosed(sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:paneClosed paneClosed} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell firePaneClosed(sap.ui.ux3.Info mParameters);

					/// <summary>
					/// Fires event {@link #event:paneClosed paneClosed} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Shell firePaneClosed();

					#endregion

					#region Other methods

					/// <summary>
					/// Closes the side Pane (if open).
					/// 
					/// Returns 'this' to allow method chaining.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.Shell closePane();

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Shell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Shell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Shell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.Shell.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the SearchField control which is used in the Search Tool.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.SearchField getSearchField();

					/// <summary>
					/// Experimental method! Do not use!
					/// 
					/// Makes Shell personalization available and injects the given personalization settings. This should be called before the user can do any adaptations per drag&drop or using the personalization dialog. Otherwise it may override the user's new settings.
					/// </summary>
					/// <param name="oSettings">Personalization settings object</param>
					public extern virtual void initializePersonalization(object oSettings);

					/// <summary>
					/// Returns 'true' if the side Pane is currently open.
					/// </summary>
					/// <returns></returns>
					public extern virtual bool isPaneOpen();

					/// <summary>
					/// Opens the side Pane.
					/// 
					/// A valid ID of a paneBarItem must be given, so this item can be marked as selected. A "paneBarItemSelected" event is then fired as if the opening was triggered by the user by a click on the respective PaneBarItem. This method can be called (with different IDs) even when the Pane is already open. It has then the same effect as if the user switches between PaneBarItems.
					/// 
					/// Returns 'this' to allow method chaining.
					/// </summary>
					/// <param name="sPaneBarItemId">The ID of the PaneBarItem which should be marked as selected.</param>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.Shell openPane(string sPaneBarItemId);

					/// <summary>
					/// Experimental method! Do not use!
					/// </summary>
					public extern virtual void openPersonalizationDialog();

					/// <summary>
					/// Replaces the existing Shell content with the given Control(-Tree). Only leads to a re-rendering of the content area (not the complete Shell). This method may be more convenient than a series of calls to "removeContent" and "addContent", which each lead to a re-rendering of the content area (but again not of the complete Shell).
					/// 
					/// By default the old content is not destroyed and is returned by this method in an array for further usage. To avoid memory leaks, the old content should be destroyed (if not needed later), by setting the "destroyOldContent" flag or by destroying it manually later on. If "destroyOldContent" is set, an empty array is returned.
					/// </summary>
					/// <param name="oContent">The new Content. In this method it must be exactly one control (-tree). Use addContent() to add more control (-trees) to the main content area of the Shell.</param>
					/// <param name="bDestroyOldContent">If set, the controls previously contained in the Shell will be destroyed, to avoid memory leaks.</param>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] setContent(sap.ui.core.Control oContent, bool bDestroyOldContent);

					/// <summary>
					/// Moves the complete Shell away from the right window border by the given number of pixels (left border in RTL case).
					/// 
					/// So there is space for a sidebar or so outside the Shell. The CSS class 'sapUiUx3ShellOuterSideBar' provides the basic position capabilities for the sidebar DOM element.
					/// 
					/// This feature is not public. The usage is only granted to special groups on request.
					/// </summary>
					/// <param name="px">how many pixels of free space should be next to the Shell (between 0 and 600)</param>
					/// <param name="complete">optional callback function to call after the animation</param>
					/// <param name="outerId">optional id of the content representing the outside sidebar. If specified the width of the content is animated.</param>
					public extern virtual void setOffsetRight(int px, object complete, string outerId);

					/// <summary>
					/// Moves the complete Shell away from the right window border by the given number of pixels (left border in RTL case).
					/// 
					/// So there is space for a sidebar or so outside the Shell. The CSS class 'sapUiUx3ShellOuterSideBar' provides the basic position capabilities for the sidebar DOM element.
					/// 
					/// This feature is not public. The usage is only granted to special groups on request.
					/// </summary>
					/// <param name="px">how many pixels of free space should be next to the Shell (between 0 and 600)</param>
					/// <param name="complete">optional callback function to call after the animation</param>
					public extern virtual void setOffsetRight(int px, object complete);

					/// <summary>
					/// Moves the complete Shell away from the right window border by the given number of pixels (left border in RTL case).
					/// 
					/// So there is space for a sidebar or so outside the Shell. The CSS class 'sapUiUx3ShellOuterSideBar' provides the basic position capabilities for the sidebar DOM element.
					/// 
					/// This feature is not public. The usage is only granted to special groups on request.
					/// </summary>
					/// <param name="px">how many pixels of free space should be next to the Shell (between 0 and 600)</param>
					public extern virtual void setOffsetRight(int px);

					/// <summary>
					/// Replaces the existing side pane content with the given Control(-Tree). This method is optimized to only re-render the pane content (and not the shell) which is faster and smoother than any other way of changing the "paneContent" aggregation.
					/// 
					/// By default, the old pane content is not destroyed and is returned by this method in an array for further usage. To avoid memory leaks, the old content should be destroyed (if not needed later), by setting the "destroyOldContent" flag or by destroying it manually later on. If "destroyOldContent" is set, an empty array is returned.
					/// </summary>
					/// <param name="oContent">The new Pane content. In this method it must be exactly one control (-tree). This could likely be a layout or a specific ux3 Pane control. Use addPaneContent() to add more control (-trees) to the Pane.</param>
					/// <param name="bDestroyOldContent">If set, the controls previously contained in the pane will be destroyed, to avoid memory leaks.</param>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] setPaneContent(sap.ui.core.Control oContent, bool bDestroyOldContent);

					#endregion

					#endregion

				}
			}
		}
	}
}
