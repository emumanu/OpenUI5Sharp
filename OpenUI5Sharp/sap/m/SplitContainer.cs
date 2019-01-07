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
			/// SplitContainer maintains two NavContainers if running on tablet or desktop and one NavContainer - on phone. The display of the master NavContainer depends on the portrait/landscape mode of the device and the mode of SplitContainer.
			/// 
			/// NOTE: This control must be rendered as a full screen control in order to make the show/hide master area work properly.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.SplitContainer")]
			public partial class SplitContainer : sap.ui.core.Control
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
					/// Determines the type of the transition/animation to apply when to() is called without defining the transition to use. The default is "slide", other options are "fade", "show", and the names of any registered custom transitions.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultTransitionNameDetail;

					/// <summary>
					/// Determines the type of the transition/animation to apply when to() is called, without defining the transition to use. The default is "slide", other options are "fade", "show", and the names of any registered custom transitions.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultTransitionNameMaster;

					/// <summary>
					/// Defines whether the master page will always be displayed (in portrait and landscape mode - StretchCompressMode), or if it should be hidden when in portrait mode (ShowHideMode). Default is ShowHideMode. Other possible values are Hide (Master is always hidden) and Popover (master is displayed in popover).
					/// </summary>
					public Union<sap.m.SplitAppMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> mode;

					/// <summary>
					/// Determines the text displayed in master button, which has a default value "Navigation". This text is only displayed in iOS platform and the icon from the current page in detail area is displayed in the master button for the other platforms. The master button is shown/hidden depending on the orientation of the device and whether the master area is opened or not. SplitContainer manages the show/hide of the master button by itself only when the pages added to the detail area are sap.m.Page with built-in header or sap.m.Page with built-in header, which is wrapped by one or several sap.ui.core.mvc.View. Otherwise, the show/hide of master button needs to be managed by the application.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> masterButtonText;

					/// <summary>
					/// Specifies the tooltip of the master button. If the tooltip is not specified, the title of the page, which is displayed is the master part, is set as tooltip to the master button.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> masterButtonTooltip;

					/// <summary>
					/// Determines the background color of the SplitContainer. If set, this color overrides the default one, which is defined by the theme (should only be used when really required). Any configured background image will be placed above this colored background, but any theme adaptation in the Theme Designer will override this setting. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete SplitContainer or whether it should be tiled.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundColor;

					/// <summary>
					/// Sets the background image of the SplitContainer. When set, this image overrides the default background defined by the theme (should only be used when really required). This background image will be placed above any color set for the background, but any theme adaptation in the Theme Designer will override this image setting. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete SplitContainer or whether it should be tiled.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundImage;

					/// <summary>
					/// Defines whether the background image (if configured) is proportionally stretched to cover the whole SplitContainer (false) or whether it should be tiled (true).
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundRepeat;

					/// <summary>
					/// Defines the opacity of the background image - between 0 (fully transparent) and 1 (fully opaque). This can be used to improve the content visibility by making the background image partly transparent.
					/// </summary>
					public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundOpacity;

					/// <summary>
					/// Determines the content entities, between which the SplitContainer navigates in master area. These can be of type sap.m.Page, sap.ui.core.View, sap.m.Carousel or any other control with fullscreen/page semantics. These aggregated controls receive navigation events like {@link sap.m.NavContainerChild#beforeShow beforeShow}, they are documented in the pseudo interface {@link sap.m.NavContainerChild sap.m.NavContainerChild}.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> masterPages;

					/// <summary>
					/// Determines the content entities, between which the SplitContainer navigates in detail area. These can be of type sap.m.Page, sap.ui.core.View, sap.m.Carousel or any other control with fullscreen/page semantics. These aggregated controls receive navigation events like {@link sap.m.NavContainerChild#beforeShow beforeShow}, they are documented in the pseudo interface {@link sap.m.NavContainerChild sap.m.NavContainerChild}.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> detailPages;

					/// <summary>
					/// Sets the initial detail page, which is displayed on application launch.
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialDetail;

					/// <summary>
					/// Sets the initial master page, which is displayed on application launch.
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialMaster;

					/// <summary>
					/// Fires when navigation between two pages in master area has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
					/// </summary>
					public sap.m.NavigateDelegate masterNavigate;

					/// <summary>
					/// Fires when navigation between two pages in master area has completed. NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
					/// </summary>
					public sap.m.NavigateDelegate afterMasterNavigate;

					/// <summary>
					/// Fires when a Master Button needs to be shown or hidden. This is necessary for custom headers when the SplitContainer control does not handle the placement of the master button automatically.
					/// </summary>
					public sap.ui.@base.EventDelegate masterButton;

					/// <summary>
					/// Fires before the master area is opened.
					/// </summary>
					public sap.ui.@base.EventDelegate beforeMasterOpen;

					/// <summary>
					/// Fires when the master area is fully opened after animation if any.
					/// </summary>
					public sap.ui.@base.EventDelegate afterMasterOpen;

					/// <summary>
					/// Fires before the master area is closed.
					/// </summary>
					public sap.ui.@base.EventDelegate beforeMasterClose;

					/// <summary>
					/// Fires when the master area is fully closed after the animation (if any).
					/// </summary>
					public sap.ui.@base.EventDelegate afterMasterClose;

					/// <summary>
					/// Fires when navigation between two pages in detail area has been triggered. The transition (if any) to the new page has not started yet. NOTE: This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
					/// </summary>
					public sap.m.NavigateDelegate detailNavigate;

					/// <summary>
					/// Fires when navigation between two pages in detail area has completed. NOTE: In case of animated transitions this event is fired with some delay after the "navigate" event.
					/// </summary>
					public sap.m.NavigateDelegate afterDetailNavigate;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new SplitContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern SplitContainer(string sId, sap.m.SplitContainer.Settings mSettings);

				/// <summary>
				/// Constructor for a new SplitContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern SplitContainer(string sId);

				/// <summary>
				/// Constructor for a new SplitContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern SplitContainer();

				/// <summary>
				/// Constructor for a new SplitContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern SplitContainer(sap.m.SplitContainer.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property defaultTransitionNameDetail

				/// <summary>
				/// Gets current value of property {@link #getDefaultTransitionNameDetail defaultTransitionNameDetail}.
				/// 
				/// Determines the type of the transition/animation to apply when to() is called without defining the transition to use. The default is "slide", other options are "fade", "show", and the names of any registered custom transitions.
				/// 
				/// Default value is <code>slide</code>.
				/// </summary>
				/// <returns>Value of property <code>defaultTransitionNameDetail</code></returns>
				public extern virtual string getDefaultTransitionNameDetail();

				/// <summary>
				/// Sets a new value for property {@link #getDefaultTransitionNameDetail defaultTransitionNameDetail}.
				/// 
				/// Determines the type of the transition/animation to apply when to() is called without defining the transition to use. The default is "slide", other options are "fade", "show", and the names of any registered custom transitions.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>slide</code>.
				/// </summary>
				/// <param name="sDefaultTransitionNameDetail">New value for property <code>defaultTransitionNameDetail</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer setDefaultTransitionNameDetail(string sDefaultTransitionNameDetail);

				#endregion

				#region Methods for Property defaultTransitionNameMaster

				/// <summary>
				/// Gets current value of property {@link #getDefaultTransitionNameMaster defaultTransitionNameMaster}.
				/// 
				/// Determines the type of the transition/animation to apply when to() is called, without defining the transition to use. The default is "slide", other options are "fade", "show", and the names of any registered custom transitions.
				/// 
				/// Default value is <code>slide</code>.
				/// </summary>
				/// <returns>Value of property <code>defaultTransitionNameMaster</code></returns>
				public extern virtual string getDefaultTransitionNameMaster();

				/// <summary>
				/// Sets a new value for property {@link #getDefaultTransitionNameMaster defaultTransitionNameMaster}.
				/// 
				/// Determines the type of the transition/animation to apply when to() is called, without defining the transition to use. The default is "slide", other options are "fade", "show", and the names of any registered custom transitions.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>slide</code>.
				/// </summary>
				/// <param name="sDefaultTransitionNameMaster">New value for property <code>defaultTransitionNameMaster</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer setDefaultTransitionNameMaster(string sDefaultTransitionNameMaster);

				#endregion

				#region Methods for Property mode

				/// <summary>
				/// Gets current value of property {@link #getMode mode}.
				/// 
				/// Defines whether the master page will always be displayed (in portrait and landscape mode - StretchCompressMode), or if it should be hidden when in portrait mode (ShowHideMode). Default is ShowHideMode. Other possible values are Hide (Master is always hidden) and Popover (master is displayed in popover).
				/// 
				/// Default value is <code>ShowHideMode</code>.
				/// </summary>
				/// <returns>Value of property <code>mode</code></returns>
				public extern virtual sap.m.SplitAppMode getMode();

				/// <summary>
				/// Sets a new value for property {@link #getMode mode}.
				/// 
				/// Defines whether the master page will always be displayed (in portrait and landscape mode - StretchCompressMode), or if it should be hidden when in portrait mode (ShowHideMode). Default is ShowHideMode. Other possible values are Hide (Master is always hidden) and Popover (master is displayed in popover).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>ShowHideMode</code>.
				/// </summary>
				/// <param name="sMode">New value for property <code>mode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer setMode(sap.m.SplitAppMode sMode);

				#endregion

				#region Methods for Property masterButtonText

				/// <summary>
				/// Gets current value of property {@link #getMasterButtonText masterButtonText}.
				/// 
				/// Determines the text displayed in master button, which has a default value "Navigation". This text is only displayed in iOS platform and the icon from the current page in detail area is displayed in the master button for the other platforms. The master button is shown/hidden depending on the orientation of the device and whether the master area is opened or not. SplitContainer manages the show/hide of the master button by itself only when the pages added to the detail area are sap.m.Page with built-in header or sap.m.Page with built-in header, which is wrapped by one or several sap.ui.core.mvc.View. Otherwise, the show/hide of master button needs to be managed by the application.
				/// </summary>
				/// <returns>Value of property <code>masterButtonText</code></returns>
				public extern virtual string getMasterButtonText();

				/// <summary>
				/// Sets a new value for property {@link #getMasterButtonText masterButtonText}.
				/// 
				/// Determines the text displayed in master button, which has a default value "Navigation". This text is only displayed in iOS platform and the icon from the current page in detail area is displayed in the master button for the other platforms. The master button is shown/hidden depending on the orientation of the device and whether the master area is opened or not. SplitContainer manages the show/hide of the master button by itself only when the pages added to the detail area are sap.m.Page with built-in header or sap.m.Page with built-in header, which is wrapped by one or several sap.ui.core.mvc.View. Otherwise, the show/hide of master button needs to be managed by the application.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMasterButtonText">New value for property <code>masterButtonText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer setMasterButtonText(string sMasterButtonText);

				#endregion

				#region Methods for Property masterButtonTooltip

				/// <summary>
				/// Gets current value of property {@link #getMasterButtonTooltip masterButtonTooltip}.
				/// 
				/// Specifies the tooltip of the master button. If the tooltip is not specified, the title of the page, which is displayed is the master part, is set as tooltip to the master button.
				/// </summary>
				/// <returns>Value of property <code>masterButtonTooltip</code></returns>
				public extern virtual string getMasterButtonTooltip();

				/// <summary>
				/// Sets a new value for property {@link #getMasterButtonTooltip masterButtonTooltip}.
				/// 
				/// Specifies the tooltip of the master button. If the tooltip is not specified, the title of the page, which is displayed is the master part, is set as tooltip to the master button.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMasterButtonTooltip">New value for property <code>masterButtonTooltip</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer setMasterButtonTooltip(string sMasterButtonTooltip);

				#endregion

				#region Methods for Property backgroundColor

				/// <summary>
				/// Gets current value of property {@link #getBackgroundColor backgroundColor}.
				/// 
				/// Determines the background color of the SplitContainer. If set, this color overrides the default one, which is defined by the theme (should only be used when really required). Any configured background image will be placed above this colored background, but any theme adaptation in the Theme Designer will override this setting. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete SplitContainer or whether it should be tiled.
				/// </summary>
				/// <returns>Value of property <code>backgroundColor</code></returns>
				public extern virtual string getBackgroundColor();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundColor backgroundColor}.
				/// 
				/// Determines the background color of the SplitContainer. If set, this color overrides the default one, which is defined by the theme (should only be used when really required). Any configured background image will be placed above this colored background, but any theme adaptation in the Theme Designer will override this setting. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete SplitContainer or whether it should be tiled.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sBackgroundColor">New value for property <code>backgroundColor</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer setBackgroundColor(string sBackgroundColor);

				#endregion

				#region Methods for Property backgroundImage

				/// <summary>
				/// Gets current value of property {@link #getBackgroundImage backgroundImage}.
				/// 
				/// Sets the background image of the SplitContainer. When set, this image overrides the default background defined by the theme (should only be used when really required). This background image will be placed above any color set for the background, but any theme adaptation in the Theme Designer will override this image setting. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete SplitContainer or whether it should be tiled.
				/// </summary>
				/// <returns>Value of property <code>backgroundImage</code></returns>
				public extern virtual sap.ui.core.URI getBackgroundImage();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundImage backgroundImage}.
				/// 
				/// Sets the background image of the SplitContainer. When set, this image overrides the default background defined by the theme (should only be used when really required). This background image will be placed above any color set for the background, but any theme adaptation in the Theme Designer will override this image setting. Use the backgroundRepeat property to define whether this image should be stretched to cover the complete SplitContainer or whether it should be tiled.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sBackgroundImage">New value for property <code>backgroundImage</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer setBackgroundImage(sap.ui.core.URI sBackgroundImage);

				#endregion

				#region Methods for Property backgroundRepeat

				/// <summary>
				/// Gets current value of property {@link #getBackgroundRepeat backgroundRepeat}.
				/// 
				/// Defines whether the background image (if configured) is proportionally stretched to cover the whole SplitContainer (false) or whether it should be tiled (true).
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundRepeat</code></returns>
				public extern virtual bool getBackgroundRepeat();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundRepeat backgroundRepeat}.
				/// 
				/// Defines whether the background image (if configured) is proportionally stretched to cover the whole SplitContainer (false) or whether it should be tiled (true).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bBackgroundRepeat">New value for property <code>backgroundRepeat</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer setBackgroundRepeat(bool bBackgroundRepeat);

				#endregion

				#region Methods for Property backgroundOpacity

				/// <summary>
				/// Gets current value of property {@link #getBackgroundOpacity backgroundOpacity}.
				/// 
				/// Defines the opacity of the background image - between 0 (fully transparent) and 1 (fully opaque). This can be used to improve the content visibility by making the background image partly transparent.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundOpacity</code></returns>
				public extern virtual float getBackgroundOpacity();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundOpacity backgroundOpacity}.
				/// 
				/// Defines the opacity of the background image - between 0 (fully transparent) and 1 (fully opaque). This can be used to improve the content visibility by making the background image partly transparent.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <param name="fBackgroundOpacity">New value for property <code>backgroundOpacity</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer setBackgroundOpacity(float fBackgroundOpacity);

				#endregion

				#region Methods for Aggregation masterPages

				/// <summary>
				/// Gets content of aggregation {@link #getMasterPages masterPages}.
				/// 
				/// Determines the content entities, between which the SplitContainer navigates in master area. These can be of type sap.m.Page, sap.ui.core.View, sap.m.Carousel or any other control with fullscreen/page semantics. These aggregated controls receive navigation events like {@link sap.m.NavContainerChild#beforeShow beforeShow}, they are documented in the pseudo interface {@link sap.m.NavContainerChild sap.m.NavContainerChild}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getMasterPages();

				/// <summary>
				/// Destroys all the masterPages in the aggregation {@link #getMasterPages masterPages}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer destroyMasterPages();

				/// <summary>
				/// Inserts a masterPage into the aggregation {@link #getMasterPages masterPages}.
				/// </summary>
				/// <param name="oMasterPage">The masterPage to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the masterPage should be inserted at; for a negative value of <code>iIndex</code>, the masterPage is inserted at position 0; for a value greater than the current size of the aggregation, the masterPage is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer insertMasterPage(sap.ui.core.Control oMasterPage, int iIndex);

				/// <summary>
				/// Adds some masterPage to the aggregation {@link #getMasterPages masterPages}.
				/// </summary>
				/// <param name="oMasterPage">The masterPage to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer addMasterPage(sap.ui.core.Control oMasterPage);

				/// <summary>
				/// Removes a masterPage from the aggregation {@link #getMasterPages masterPages}.
				/// </summary>
				/// <param name="vMasterPage">The masterPage to remove or its index or id</param>
				/// <returns>The removed masterPage or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeMasterPage(Union<int, string, sap.ui.core.Control> vMasterPage);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getMasterPages masterPages}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oMasterPage">The masterPage whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfMasterPage(sap.ui.core.Control oMasterPage);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getMasterPages masterPages}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllMasterPages();

				#endregion

				#region Methods for Aggregation detailPages

				/// <summary>
				/// Gets content of aggregation {@link #getDetailPages detailPages}.
				/// 
				/// Determines the content entities, between which the SplitContainer navigates in detail area. These can be of type sap.m.Page, sap.ui.core.View, sap.m.Carousel or any other control with fullscreen/page semantics. These aggregated controls receive navigation events like {@link sap.m.NavContainerChild#beforeShow beforeShow}, they are documented in the pseudo interface {@link sap.m.NavContainerChild sap.m.NavContainerChild}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getDetailPages();

				/// <summary>
				/// Destroys all the detailPages in the aggregation {@link #getDetailPages detailPages}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer destroyDetailPages();

				/// <summary>
				/// Inserts a detailPage into the aggregation {@link #getDetailPages detailPages}.
				/// </summary>
				/// <param name="oDetailPage">The detailPage to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the detailPage should be inserted at; for a negative value of <code>iIndex</code>, the detailPage is inserted at position 0; for a value greater than the current size of the aggregation, the detailPage is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer insertDetailPage(sap.ui.core.Control oDetailPage, int iIndex);

				/// <summary>
				/// Adds some detailPage to the aggregation {@link #getDetailPages detailPages}.
				/// </summary>
				/// <param name="oDetailPage">The detailPage to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer addDetailPage(sap.ui.core.Control oDetailPage);

				/// <summary>
				/// Removes a detailPage from the aggregation {@link #getDetailPages detailPages}.
				/// </summary>
				/// <param name="vDetailPage">The detailPage to remove or its index or id</param>
				/// <returns>The removed detailPage or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeDetailPage(Union<int, string, sap.ui.core.Control> vDetailPage);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getDetailPages detailPages}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oDetailPage">The detailPage whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfDetailPage(sap.ui.core.Control oDetailPage);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getDetailPages detailPages}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllDetailPages();

				#endregion

				#region Methods for Aggregation _navMaster

				#endregion

				#region Methods for Aggregation _navDetail

				#endregion

				#region Methods for Aggregation _navPopover

				#endregion

				#region Methods for Association initialDetail

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getInitialDetail initialDetail}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getInitialDetail();

				/// <summary>
				/// Sets the associated {@link #getInitialDetail initialDetail}.
				/// </summary>
				/// <param name="oInitialDetail">ID of an element which becomes the new target of this initialDetail association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer setInitialDetail(Union<sap.ui.core.ID, sap.ui.core.Control> oInitialDetail);

				#endregion

				#region Methods for Association initialMaster

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getInitialMaster initialMaster}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getInitialMaster();

				/// <summary>
				/// Sets the associated {@link #getInitialMaster initialMaster}.
				/// </summary>
				/// <param name="oInitialMaster">ID of an element which becomes the new target of this initialMaster association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer setInitialMaster(Union<sap.ui.core.ID, sap.ui.core.Control> oInitialMaster);

				#endregion

				#region Methods for Event masterNavigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:masterNavigate masterNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in master area has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachMasterNavigate(object oData, sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:masterNavigate masterNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in master area has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachMasterNavigate(object oData, sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:masterNavigate masterNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in master area has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachMasterNavigate(sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:masterNavigate masterNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in master area has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachMasterNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:masterNavigate masterNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer detachMasterNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:masterNavigate masterNavigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireMasterNavigate(sap.m.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:masterNavigate masterNavigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireMasterNavigate();

				#endregion

				#region Methods for Event afterMasterNavigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterNavigate afterMasterNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in master area has completed. NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterNavigate(object oData, sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterNavigate afterMasterNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in master area has completed. NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterNavigate(object oData, sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterNavigate afterMasterNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in master area has completed. NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterNavigate(sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterNavigate afterMasterNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in master area has completed. NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterMasterNavigate afterMasterNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer detachAfterMasterNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterMasterNavigate afterMasterNavigate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireAfterMasterNavigate(sap.m.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterMasterNavigate afterMasterNavigate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireAfterMasterNavigate();

				#endregion

				#region Methods for Event masterButton

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:masterButton masterButton} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when a Master Button needs to be shown or hidden. This is necessary for custom headers when the SplitContainer control does not handle the placement of the master button automatically.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachMasterButton(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:masterButton masterButton} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when a Master Button needs to be shown or hidden. This is necessary for custom headers when the SplitContainer control does not handle the placement of the master button automatically.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachMasterButton(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:masterButton masterButton} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when a Master Button needs to be shown or hidden. This is necessary for custom headers when the SplitContainer control does not handle the placement of the master button automatically.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachMasterButton(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:masterButton masterButton} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when a Master Button needs to be shown or hidden. This is necessary for custom headers when the SplitContainer control does not handle the placement of the master button automatically.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachMasterButton(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:masterButton masterButton} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer detachMasterButton(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:masterButton masterButton} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireMasterButton(object mParameters);

				/// <summary>
				/// Fires event {@link #event:masterButton masterButton} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireMasterButton();

				#endregion

				#region Methods for Event beforeMasterOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeMasterOpen beforeMasterOpen} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires before the master area is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachBeforeMasterOpen(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeMasterOpen beforeMasterOpen} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires before the master area is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachBeforeMasterOpen(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeMasterOpen beforeMasterOpen} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires before the master area is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachBeforeMasterOpen(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeMasterOpen beforeMasterOpen} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires before the master area is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachBeforeMasterOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeMasterOpen beforeMasterOpen} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer detachBeforeMasterOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeMasterOpen beforeMasterOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireBeforeMasterOpen(object mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeMasterOpen beforeMasterOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireBeforeMasterOpen();

				#endregion

				#region Methods for Event afterMasterOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterOpen afterMasterOpen} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when the master area is fully opened after animation if any.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterOpen(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterOpen afterMasterOpen} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when the master area is fully opened after animation if any.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterOpen(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterOpen afterMasterOpen} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when the master area is fully opened after animation if any.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterOpen(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterOpen afterMasterOpen} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when the master area is fully opened after animation if any.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterMasterOpen afterMasterOpen} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer detachAfterMasterOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterMasterOpen afterMasterOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireAfterMasterOpen(object mParameters);

				/// <summary>
				/// Fires event {@link #event:afterMasterOpen afterMasterOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireAfterMasterOpen();

				#endregion

				#region Methods for Event beforeMasterClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeMasterClose beforeMasterClose} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires before the master area is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachBeforeMasterClose(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeMasterClose beforeMasterClose} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires before the master area is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachBeforeMasterClose(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeMasterClose beforeMasterClose} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires before the master area is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachBeforeMasterClose(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeMasterClose beforeMasterClose} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires before the master area is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachBeforeMasterClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeMasterClose beforeMasterClose} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer detachBeforeMasterClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeMasterClose beforeMasterClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireBeforeMasterClose(object mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeMasterClose beforeMasterClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireBeforeMasterClose();

				#endregion

				#region Methods for Event afterMasterClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterClose afterMasterClose} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when the master area is fully closed after the animation (if any).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterClose(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterClose afterMasterClose} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when the master area is fully closed after the animation (if any).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterClose(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterClose afterMasterClose} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when the master area is fully closed after the animation (if any).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterClose(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMasterClose afterMasterClose} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when the master area is fully closed after the animation (if any).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterMasterClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterMasterClose afterMasterClose} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer detachAfterMasterClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterMasterClose afterMasterClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireAfterMasterClose(object mParameters);

				/// <summary>
				/// Fires event {@link #event:afterMasterClose afterMasterClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireAfterMasterClose();

				#endregion

				#region Methods for Event detailNavigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailNavigate detailNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in detail area has been triggered. The transition (if any) to the new page has not started yet. NOTE: This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachDetailNavigate(object oData, sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailNavigate detailNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in detail area has been triggered. The transition (if any) to the new page has not started yet. NOTE: This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachDetailNavigate(object oData, sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailNavigate detailNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in detail area has been triggered. The transition (if any) to the new page has not started yet. NOTE: This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachDetailNavigate(sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailNavigate detailNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in detail area has been triggered. The transition (if any) to the new page has not started yet. NOTE: This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachDetailNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:detailNavigate detailNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer detachDetailNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:detailNavigate detailNavigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireDetailNavigate(sap.m.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:detailNavigate detailNavigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireDetailNavigate();

				#endregion

				#region Methods for Event afterDetailNavigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterDetailNavigate afterDetailNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in detail area has completed. NOTE: In case of animated transitions this event is fired with some delay after the "navigate" event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterDetailNavigate(object oData, sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterDetailNavigate afterDetailNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in detail area has completed. NOTE: In case of animated transitions this event is fired with some delay after the "navigate" event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterDetailNavigate(object oData, sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterDetailNavigate afterDetailNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in detail area has completed. NOTE: In case of animated transitions this event is fired with some delay after the "navigate" event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterDetailNavigate(sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterDetailNavigate afterDetailNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitContainer</code> itself.
				/// 
				/// Fires when navigation between two pages in detail area has completed. NOTE: In case of animated transitions this event is fired with some delay after the "navigate" event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer attachAfterDetailNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterDetailNavigate afterDetailNavigate} event of this <code>sap.m.SplitContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer detachAfterDetailNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterDetailNavigate afterDetailNavigate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireAfterDetailNavigate(sap.m.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterDetailNavigate afterDetailNavigate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitContainer fireAfterDetailNavigate();

				#endregion

				#region Other methods

				/// <summary>
				/// Adds a content entity either to master area or detail area depending on the master parameter.
				/// 
				/// The method is provided mainly for providing API consistency between sap.m.SplitContainer and sap.m.App. So that the same code line can be reused.
				/// </summary>
				/// <param name="oPage">The content entities between which this SplitContainer navigates in either master area or detail area depending on the master parameter. These can be of type sap.m.Page, sap.ui.core.View, sap.m.Carousel or any other control with fullscreen/page semantics.</param>
				/// <param name="bMaster">States if the page should be added to the master area. If it's set to false, the page is added to detail area.</param>
				/// <returns></returns>
				public extern virtual sap.m.SplitContainer addPage(sap.ui.core.Control oPage, bool bMaster);

				/// <summary>
				/// Navigates back to the previous detail page found in the history.
				/// </summary>
				/// <param name="oBackData">This optional object can carry any payload data which should be made available to the target page of the back navigation. The event on the target page will contain this data object as backData property. (The original data from the to() navigation will still be available as data property.)
				/// 
				/// In scenarios where the entity triggering the navigation can or should not directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data. For back navigation this can be used, for example, when returning from a detail page to transfer any settings done there.
				/// 
				/// When the transitionParameters object is used, this data object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameter">This optional object can give additional information to the transition function, like the DOM element, which triggered the transition or the desired transition duration. The animation type can NOT be selected here - it is always the inverse of the "to" navigation.
				/// 
				/// In order to use the transitionParameters property, the data property must be used (at least "null" must be given) for a proper parameter order.
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition.</param>
				/// <returns></returns>
				public extern virtual sap.m.SplitContainer backDetail(object oBackData, object oTransitionParameter);

				/// <summary>
				/// Navigates back to the previous master page which is found in the history.
				/// </summary>
				/// <param name="oBackData">This optional object can carry any payload data which should be made available to the target page of the back navigation. The event on the target page will contain this data object as backData property (the original data from the to() navigation will still be available as data property).
				/// 
				/// In scenarios where the entity triggering the navigation can or should not directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data. For back navigation this can be used, for example, when returning from a detail page to transfer any settings done there.
				/// 
				/// When the transitionParameters object is used, this data object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameter">This optional object can give additional information to the transition function, like the DOM element, which triggered the transition or the desired transition duration. The animation type can NOT be selected here - it is always the inverse of the "to" navigation.
				/// 
				/// In order to use the transitionParameters property, the data property must be used (at least "null" must be given) for a proper parameter order.
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition.</param>
				/// <returns></returns>
				public extern virtual sap.m.SplitContainer backMaster(object oBackData, object oTransitionParameter);

				/// <summary>
				/// Navigates back to the nearest previous page in the SplitContainer history with the given ID (if there is no such page among the previous pages, nothing happens). The transition effect, which had been used to get to the current page is inverted and used for this navigation.
				/// 
				/// Calling this navigation method, first triggers the (cancelable) navigate event on the SplitContainer, then the beforeHide pseudo event on the source page, beforeFirstShow (if applicable), and beforeShow on the target page. Later, after the transition has completed, the afterShow pseudo event is triggered on the target page and afterHide - on the page, which has been left. The given backData object is available in the beforeFirstShow, beforeShow, and afterShow event objects as data property. The original "data" object from the "to" navigation is also available in these event objects.
				/// </summary>
				/// <param name="sPageId">The screen to which is being navigated to. The ID or the control itself can be given.</param>
				/// <param name="oBackData">This optional object can carry any payload data which should be made available to the target page of the back navigation. The event on the target page will contain this data object as backData property. (the original data from the to() navigation will still be available as data property).
				/// 
				/// In scenarios, where the entity triggering the navigation can't or shouldn't directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data. For back navigation this can be used, for example, when returning from a detail page to transfer any settings done there.
				/// 
				/// When the transitionParameters object is used, this data object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameters">This optional object can give additional information to the transition function, like the DOM element, which triggered the transition or the desired transition duration. The animation type can NOT be selected here - it is always the inverse of the "to" navigation.
				/// 
				/// In order to use the transitionParameters property, the data property must be used (at least "null" must be given) for a proper parameter order.
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition.</param>
				/// <returns></returns>
				public extern virtual sap.m.SplitContainer backToPage(string sPageId, object oBackData, object oTransitionParameters);

				/// <summary>
				/// Navigates back to the initial/top level of Detail (this is the element aggregated as initialPage, or the first added element). NOTE: If already on the initial page, nothing happens. The transition effect which had been used to get to the current page is inverted and used for this navigation.
				/// </summary>
				/// <param name="oBackData">This optional object can carry any payload data which should be made available to the target page of the back navigation. The event on the target page will contain this data object as backData property (the original data from the to() navigation will still be available as data property).
				/// 
				/// In scenarios where the entity triggering the navigation can or should not directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data. For back navigation this can be used, for example, when returning from a detail page to transfer any settings done there.
				/// 
				/// When the transitionParameters object is used, this data object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameter">This optional object can give additional information to the transition function, like the DOM element, which triggered the transition or the desired transition duration. The animation type can NOT be selected here - it is always the inverse of the "to" navigation.
				/// 
				/// In order to use the transitionParameters property, the data property must be used (at least "null" must be given) for a proper parameter order.
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition.</param>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control backToTopDetail(object oBackData, object oTransitionParameter);

				/// <summary>
				/// Navigates back to the initial/top level of Master (this is the element aggregated as "initialPage", or the first added element). NOTE: If already on the initial page, nothing happens. The transition effect which had been used to get to the current page is inverted and used for this navigation.
				/// </summary>
				/// <param name="oBackData">This optional object can carry any payload data which should be made available to the target page of the back navigation. The event on the target page will contain this data object as "backData" property. (The original data from the "to()" navigation will still be available as "data" property.)
				/// 
				/// In scenarios where the entity triggering the navigation can or should not directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data. For back navigation this can be used e.g. when returning from a detail page to transfer any settings done there.
				/// 
				/// When the "transitionParameters" object is used, this "data" object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameter">This optional object can give additional information to the transition function, like the DOM element which triggered the transition or the desired transition duration. The animation type can NOT be selected here - it is always the inverse of the "to" navigation.
				/// 
				/// In order to use the transitionParameters property, the data property must be used (at least "null" must be given) for a proper parameter order.
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition.</param>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control backToTopMaster(object oBackData, object oTransitionParameter);

				/// <summary>
				/// Creates a new subclass of class sap.m.SplitContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.SplitContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.SplitContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns the current displayed detail page.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getCurrentDetailPage();

				/// <summary>
				/// Returns the current displayed master page.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getCurrentMasterPage();

				/// <summary>
				/// Returns the currently displayed page either in master area or in detail area. When the parameter is set to true, the current page in master area is returned, otherwise, the current page in detail area is returned.
				/// 
				/// This method is provided mainly for API consistency between sap.m.SplitContainer and sap.m.App, so that the same code line can be reused.
				/// </summary>
				/// <param name="bMaster">States if this function returns the current page in master area. If it's set to false, the current page in detail area will be returned.</param>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getCurrentPage(bool bMaster);

				/// <summary>
				/// Returns the page with the given ID in detail area. If there's no page that has the given ID, null is returned.
				/// </summary>
				/// <param name="sId">The ID of the page that needs to be fetched.</param>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getDetailPage(string sId);

				/// <summary>
				/// Returns the page with the given ID in master area (if there's no page that has the given ID, null is returned).
				/// </summary>
				/// <param name="sId">The ID of the page that needs to be fetched</param>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getMasterPage(string sId);

				/// <summary>
				/// Returns a metadata object for class sap.m.SplitContainer.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Returns the page with the given ID from either master area, or detail area depending on the master parameter (if there's no page that has the given ID, null is returned).
				/// </summary>
				/// <param name="sId">The ID of the page that needs to be fetched</param>
				/// <param name="bMaster">If the page with given ID should be fetched from the master area. If it's set to false, the page will be fetched from detail area.</param>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getPage(string sId, bool bMaster);

				/// <summary>
				/// Returns the previous page (the page, from which the user drilled down to the current page with to()). Note: this is not the page, which the user has seen before, but the page which is the target of the next back() navigation. If there is no previous page, "undefined" is returned.
				/// </summary>
				/// <param name="bMaster">States if this function returns the previous page in master area. If it's set to false, the previous page in detail area will be returned.</param>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getPreviousPage(bool bMaster);

				/// <summary>
				/// Used to hide the master page when in ShowHideMode and the device is in portrait mode.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.SplitContainer hideMaster();

				/// <summary>
				/// Inserts the page/control with the specified ID into the navigation history stack of the NavContainer.
				/// 
				/// This can be used for deep-linking when the user directly reached a drilldown detail page using a bookmark and then wants to navigate up in the drilldown hierarchy. Normally, such a back navigation would not be possible as there is no previous page in the SplitContainer's history stack.
				/// </summary>
				/// <param name="sPageId">The ID of the control/page/screen, which is inserted into the history stack. The respective control must be aggregated by the SplitContainer, otherwise this will cause an error.</param>
				/// <param name="sTransitionName">The type of the transition/animation, which would have been used to navigate from the (inserted) previous page to the current page. When navigating back, the inverse animation will be applied. This parameter can be omitted; then the default value is "slide" (horizontal movement from the right).</param>
				/// <param name="oData">This optional object can carry any payload data which would have been given to the inserted previous page if the user would have done a normal forward navigation to it.</param>
				/// <returns></returns>
				public extern virtual sap.m.SplitContainer insertPreviousPage(string sPageId, string sTransitionName, object oData);

				/// <summary>
				/// Returns whether master area is currently displayed on the screen. In desktop browser or tablet, this method returns true when master area is displayed on the screen, regardless if in portrait or landscape mode. On mobile phone devices, this method returns true when the currently displayed page is from the pages, which are added to the master area, otherwise, it returns false.
				/// </summary>
				/// <returns></returns>
				public extern virtual bool isMasterShown();

				/// <summary>
				/// Used to make the master page visible when in ShowHideMode and the device is in portrait mode.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.SplitContainer showMaster();

				/// <summary>
				/// Navigates to the given page inside the SplitContainer. The navigation is done inside the master area if the page has been added, otherwise, it tries to do the page navigation in the detail area.
				/// </summary>
				/// <param name="sPageId">The screen to which we are navigating to. The ID or the control itself can be given.</param>
				/// <param name="sTransitionName">The type of the transition/animation to apply. This parameter can be omitted; then the default value is "slide" (horizontal movement from the right). Other options are: "fade", "flip", and "show" and the names of any registered custom transitions.
				/// 
				/// None of the standard transitions is currently making use of any given transition parameters.</param>
				/// <param name="oData">This optional object can carry any payload data which should be made available to the target page. The beforeShow event on the target page will contain this data object as data property.
				/// 
				/// Use case: in scenarios where the entity triggering the navigation can or should not directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data.
				/// 
				/// When the transitionParameters object is used, this "data" object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameters">This optional object can contain additional information for the transition function, like the DOM element which triggered the transition or the desired transition duration.
				/// 
				/// For a proper parameter order, the "data" parameter must be given when the transitionParameters parameter is used (it can be given as "null").
				/// 
				/// NOTE: It depends on the transition function how the object should be structured and which parameters are actually used to influence the transition. The "show", "slide" and "fade" transitions do not use any parameter.</param>
				/// <returns></returns>
				public extern virtual sap.m.SplitContainer to(string sPageId, string sTransitionName, object oData, object oTransitionParameters);

				/// <summary>
				/// Navigates to a given detail page.
				/// </summary>
				/// <param name="sPageId"></param>
				/// <param name="sTransitionName">The type of the transition/animation to apply. This parameter can be omitted; then the default is "slide" (horizontal movement from the right). Other options are: "fade", "flip", and "show" and the names of any registered custom transitions.
				/// 
				/// None of the standard transitions is currently making use of any given transition parameters.</param>
				/// <param name="oData">This optional object can carry any payload data which should be made available to the target page. The beforeShow event on the target page will contain this data object as data property.
				/// 
				/// Use case: in scenarios where the entity triggering the navigation can or should not directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data.
				/// 
				/// When the transitionParameters object is used, this data object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameter">This optional object can contain additional information for the transition function, like the DOM element, which triggered the transition or the desired transition duration.
				/// 
				/// For a proper parameter order, the data parameter must be given when the transitionParameters parameter is used (it can be given as "null").
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition. The "show", "slide" and "fade" transitions do not use any parameter.</param>
				/// <returns></returns>
				public extern virtual sap.m.SplitContainer toDetail(string sPageId, string sTransitionName, object oData, object oTransitionParameter);

				/// <summary>
				/// Navigates to a given master page.
				/// </summary>
				/// <param name="sPageId">The screen to which drilldown should happen. The ID or the control itself can be given.</param>
				/// <param name="sTransitionName">The type of the transition/animation to apply. This parameter can be omitted; then the default value is "slide" (horizontal movement from the right). Other options are: "fade", "flip", and "show" and the names of any registered custom transitions.
				/// 
				/// None of the standard transitions is currently making use of any given transition parameters.</param>
				/// <param name="oData">Since version 1.7.1. This optional object can carry any payload data which should be made available to the target page. The beforeShow event on the target page will contain this data object as data property.
				/// 
				/// Use case: in scenarios where the entity triggering the navigation can't or shouldn't directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data.
				/// 
				/// When the transitionParameters object is used, this data object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameters">Since version 1.7.1. This optional object can contain additional information for the transition function, like the DOM element, which triggered the transition or the desired transition duration.
				/// 
				/// For a proper parameter order, the data parameter must be given when the transitionParameters parameter is used (it can be given as "null").
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition. The "show", "slide" and "fade" transitions do not use any parameter.</param>
				/// <returns></returns>
				public extern virtual sap.m.SplitContainer toMaster(string sPageId, string sTransitionName, object oData, object oTransitionParameters);

				#endregion

				#endregion

			}
		}
	}
}
