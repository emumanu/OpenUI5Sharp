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
			/// Represents the static part (header title) of the classic header of the {@link sap.uxap.ObjectPageLayout}.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>ObjectPageHeader</code> is used to display the basic information about a business object, such as title/description/picture, as well as a list of common actions.
			/// 
			/// <b>Note:</b> The <code>ObjectPageHeader</code> is meant to be used inside the <code>ObjectPageLayout</code> control. Any other usage is not supported and can lead to unexpected behavior.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageHeader")]
			public partial class ObjectPageHeader : sap.ui.core.Control, sap.uxap.IHeaderTitle
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
					/// The URL of the image, representing the business object
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> objectImageURI;

					/// <summary>
					/// The text to be used for the Alt and Tooltip attribute of the image, supplied via the objectImageURI property
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> objectImageAlt;

					/// <summary>
					/// The value of densityAware for the image, supplied via the objectImageURI property. See sap.m.Image for more details on densityAware.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> objectImageDensityAware;

					/// <summary>
					/// The title of the object
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> objectTitle;

					/// <summary>
					/// The description of the object
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> objectSubtitle;

					/// <summary>
					/// Determines whether the picture should be displayed in a square or with a circle-shaped mask.
					/// </summary>
					public Union<sap.uxap.ObjectPageHeaderPictureShape, string, sap.ui.@base.ManagedObject.BindPropertyInfo> objectImageShape;

					/// <summary>
					/// Determines whether the icon should always be visible or visible only when the header is snapped.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> isObjectIconAlwaysVisible;

					/// <summary>
					/// Determines whether the title should always be visible or visible only when the header is snapped.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> isObjectTitleAlwaysVisible;

					/// <summary>
					/// Determines whether the subtitle should always be visible or visible only when the header is snapped.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> isObjectSubtitleAlwaysVisible;

					/// <summary>
					/// Determines whether the action buttons should always be visible or visible only when the header is snapped.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> isActionAreaAlwaysVisible;

					/// <summary>
					/// Determines the design of the header - Light or Dark. <b>Note: </b>This property is deprecated. It will continue to work in the Blue Crystal theme, but it will not be taken into account for the Belize themes.
					/// </summary>
					public Union<sap.uxap.ObjectPageHeaderDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerDesign;

					/// <summary>
					/// When set to true, the selector arrow icon/image is shown and can be pressed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showTitleSelector;

					/// <summary>
					/// Set the favorite state to true or false. The showMarkers property must be true for this property to take effect.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> markFavorite;

					/// <summary>
					/// Set the flagged state to true or false. The showMarkers property must be true for this property to take effect.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> markFlagged;

					/// <summary>
					/// Indicates if object page header title supports showing markers such as flagged and favorite.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showMarkers;

					/// <summary>
					/// Set the locked state of the objectPageHeader.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> markLocked;

					/// <summary>
					/// Enables support of a placeholder image in case no image is specified or the URL of the provided image is invalid.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showPlaceholder;

					/// <summary>
					/// Marks that there are unsaved changes in the objectPageHeader. The markChanges state cannot be used together with the markLocked state. If both are set to true, only the locked state will be displayed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> markChanges;

					/// <summary>
					/// The breadcrumbs displayed in the <code>ObjectPageHeader</code>. If this aggregation is set, the <code>breadCrumbsLinks</code> aggregation is omitted.
					/// </summary>
					public Union<sap.m.Breadcrumbs, string, sap.ui.@base.ManagedObject.BindAggregationInfo> breadcrumbs;

					/// <summary>
					/// A list of all the active link elements in the BreadCrumbs control.
					/// </summary>
					public Union<sap.m.Link[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> breadCrumbsLinks;

					/// <summary>
					/// An instance of sap.m.Bar to be embedded in the header
					/// </summary>
					public Union<sap.m.Bar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> navigationBar;

					/// <summary>
					/// List of actions that will be displayed in the header. You can use ObjectPageHeaderActionButton controls to achieve a different visual representation of the action buttons in the action bar and the action sheet (overflow menu). You can use ObjectPageHeaderLayoutData to display a visual separator.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> actions;

					/// <summary>
					/// A button that is used for opening the side content of the page or some additional content.
					/// </summary>
					public Union<sap.m.Button, string, sap.ui.@base.ManagedObject.BindAggregationInfo> sideContentButton;

					/// <summary>
					/// A custom tooltip for the title selector button.
					/// 
					/// The custom tooltip will be visible if the <code>showTitleSelector</code> property is set to <code>true</code>.
					/// 
					/// <b>Note:</b> If the aggregation is destroyed or set to invalid value, the default tooltip will be set. The default tooltip text is "Related options".
					/// </summary>
					public Union<sap.ui.core.TooltipBase, string, sap.ui.@base.ManagedObject.BindAggregationInfo> titleSelectorTooltip;

					/// <summary>
					/// The event is fired when the objectPage header title selector (down-arrow) is pressed
					/// </summary>
					public sap.m.ObjectPressDelegate titleSelectorPress;

					/// <summary>
					/// The event is fired when the Locked button is pressed
					/// </summary>
					public sap.m.ObjectPressDelegate markLockedPress;

					/// <summary>
					/// The event is fired when the unsaved changes button is pressed
					/// </summary>
					public sap.m.ObjectPressDelegate markChangesPress;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageHeader(string sId, sap.uxap.ObjectPageHeader.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectPageHeader(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectPageHeader();

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageHeader(sap.uxap.ObjectPageHeader.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property objectImageURI

				/// <summary>
				/// Gets current value of property {@link #getObjectImageURI objectImageURI}.
				/// 
				/// The URL of the image, representing the business object
				/// </summary>
				/// <returns>Value of property <code>objectImageURI</code></returns>
				public extern virtual string getObjectImageURI();

				/// <summary>
				/// Sets a new value for property {@link #getObjectImageURI objectImageURI}.
				/// 
				/// The URL of the image, representing the business object
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sObjectImageURI">New value for property <code>objectImageURI</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setObjectImageURI(string sObjectImageURI);

				#endregion

				#region Methods for Property objectImageAlt

				/// <summary>
				/// Gets current value of property {@link #getObjectImageAlt objectImageAlt}.
				/// 
				/// The text to be used for the Alt and Tooltip attribute of the image, supplied via the objectImageURI property
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>objectImageAlt</code></returns>
				public extern virtual string getObjectImageAlt();

				/// <summary>
				/// Sets a new value for property {@link #getObjectImageAlt objectImageAlt}.
				/// 
				/// The text to be used for the Alt and Tooltip attribute of the image, supplied via the objectImageURI property
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sObjectImageAlt">New value for property <code>objectImageAlt</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setObjectImageAlt(string sObjectImageAlt);

				#endregion

				#region Methods for Property objectImageDensityAware

				/// <summary>
				/// Gets current value of property {@link #getObjectImageDensityAware objectImageDensityAware}.
				/// 
				/// The value of densityAware for the image, supplied via the objectImageURI property. See sap.m.Image for more details on densityAware.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>objectImageDensityAware</code></returns>
				public extern virtual bool getObjectImageDensityAware();

				/// <summary>
				/// Sets a new value for property {@link #getObjectImageDensityAware objectImageDensityAware}.
				/// 
				/// The value of densityAware for the image, supplied via the objectImageURI property. See sap.m.Image for more details on densityAware.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bObjectImageDensityAware">New value for property <code>objectImageDensityAware</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setObjectImageDensityAware(bool bObjectImageDensityAware);

				#endregion

				#region Methods for Property objectTitle

				/// <summary>
				/// Gets current value of property {@link #getObjectTitle objectTitle}.
				/// 
				/// The title of the object
				/// </summary>
				/// <returns>Value of property <code>objectTitle</code></returns>
				public extern virtual string getObjectTitle();

				/// <summary>
				/// Sets a new value for property {@link #getObjectTitle objectTitle}.
				/// 
				/// The title of the object
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sObjectTitle">New value for property <code>objectTitle</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setObjectTitle(string sObjectTitle);

				#endregion

				#region Methods for Property objectSubtitle

				/// <summary>
				/// Gets current value of property {@link #getObjectSubtitle objectSubtitle}.
				/// 
				/// The description of the object
				/// </summary>
				/// <returns>Value of property <code>objectSubtitle</code></returns>
				public extern virtual string getObjectSubtitle();

				/// <summary>
				/// Sets a new value for property {@link #getObjectSubtitle objectSubtitle}.
				/// 
				/// The description of the object
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sObjectSubtitle">New value for property <code>objectSubtitle</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setObjectSubtitle(string sObjectSubtitle);

				#endregion

				#region Methods for Property objectImageShape

				/// <summary>
				/// Gets current value of property {@link #getObjectImageShape objectImageShape}.
				/// 
				/// Determines whether the picture should be displayed in a square or with a circle-shaped mask.
				/// 
				/// Default value is <code>Square</code>.
				/// </summary>
				/// <returns>Value of property <code>objectImageShape</code></returns>
				public extern virtual sap.uxap.ObjectPageHeaderPictureShape getObjectImageShape();

				/// <summary>
				/// Sets a new value for property {@link #getObjectImageShape objectImageShape}.
				/// 
				/// Determines whether the picture should be displayed in a square or with a circle-shaped mask.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Square</code>.
				/// </summary>
				/// <param name="sObjectImageShape">New value for property <code>objectImageShape</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setObjectImageShape(sap.uxap.ObjectPageHeaderPictureShape sObjectImageShape);

				#endregion

				#region Methods for Property isObjectIconAlwaysVisible

				/// <summary>
				/// Gets current value of property {@link #getIsObjectIconAlwaysVisible isObjectIconAlwaysVisible}.
				/// 
				/// Determines whether the icon should always be visible or visible only when the header is snapped.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>isObjectIconAlwaysVisible</code></returns>
				public extern virtual bool getIsObjectIconAlwaysVisible();

				/// <summary>
				/// Sets a new value for property {@link #getIsObjectIconAlwaysVisible isObjectIconAlwaysVisible}.
				/// 
				/// Determines whether the icon should always be visible or visible only when the header is snapped.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bIsObjectIconAlwaysVisible">New value for property <code>isObjectIconAlwaysVisible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setIsObjectIconAlwaysVisible(bool bIsObjectIconAlwaysVisible);

				#endregion

				#region Methods for Property isObjectTitleAlwaysVisible

				/// <summary>
				/// Gets current value of property {@link #getIsObjectTitleAlwaysVisible isObjectTitleAlwaysVisible}.
				/// 
				/// Determines whether the title should always be visible or visible only when the header is snapped.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>isObjectTitleAlwaysVisible</code></returns>
				public extern virtual bool getIsObjectTitleAlwaysVisible();

				/// <summary>
				/// Sets a new value for property {@link #getIsObjectTitleAlwaysVisible isObjectTitleAlwaysVisible}.
				/// 
				/// Determines whether the title should always be visible or visible only when the header is snapped.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIsObjectTitleAlwaysVisible">New value for property <code>isObjectTitleAlwaysVisible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setIsObjectTitleAlwaysVisible(bool bIsObjectTitleAlwaysVisible);

				#endregion

				#region Methods for Property isObjectSubtitleAlwaysVisible

				/// <summary>
				/// Gets current value of property {@link #getIsObjectSubtitleAlwaysVisible isObjectSubtitleAlwaysVisible}.
				/// 
				/// Determines whether the subtitle should always be visible or visible only when the header is snapped.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>isObjectSubtitleAlwaysVisible</code></returns>
				public extern virtual bool getIsObjectSubtitleAlwaysVisible();

				/// <summary>
				/// Sets a new value for property {@link #getIsObjectSubtitleAlwaysVisible isObjectSubtitleAlwaysVisible}.
				/// 
				/// Determines whether the subtitle should always be visible or visible only when the header is snapped.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIsObjectSubtitleAlwaysVisible">New value for property <code>isObjectSubtitleAlwaysVisible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setIsObjectSubtitleAlwaysVisible(bool bIsObjectSubtitleAlwaysVisible);

				#endregion

				#region Methods for Property isActionAreaAlwaysVisible

				/// <summary>
				/// Gets current value of property {@link #getIsActionAreaAlwaysVisible isActionAreaAlwaysVisible}.
				/// 
				/// Determines whether the action buttons should always be visible or visible only when the header is snapped.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>isActionAreaAlwaysVisible</code></returns>
				public extern virtual bool getIsActionAreaAlwaysVisible();

				/// <summary>
				/// Sets a new value for property {@link #getIsActionAreaAlwaysVisible isActionAreaAlwaysVisible}.
				/// 
				/// Determines whether the action buttons should always be visible or visible only when the header is snapped.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIsActionAreaAlwaysVisible">New value for property <code>isActionAreaAlwaysVisible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setIsActionAreaAlwaysVisible(bool bIsActionAreaAlwaysVisible);

				#endregion

				#region Methods for Property headerDesign

				/// <summary>
				/// Gets current value of property {@link #getHeaderDesign headerDesign}.
				/// 
				/// Determines the design of the header - Light or Dark. <b>Note: </b>This property is deprecated. It will continue to work in the Blue Crystal theme, but it will not be taken into account for the Belize themes.
				/// 
				/// Default value is <code>Light</code>.
				/// </summary>
				/// <returns>Value of property <code>headerDesign</code></returns>
				[Obsolete("Deprecated since 1.40.1.")]
				public extern virtual sap.uxap.ObjectPageHeaderDesign getHeaderDesign();

				/// <summary>
				/// Sets a new value for property {@link #getHeaderDesign headerDesign}.
				/// 
				/// Determines the design of the header - Light or Dark. <b>Note: </b>This property is deprecated. It will continue to work in the Blue Crystal theme, but it will not be taken into account for the Belize themes.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Light</code>.
				/// </summary>
				/// <param name="sHeaderDesign">New value for property <code>headerDesign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.40.1.")]
				public extern virtual sap.uxap.ObjectPageHeader setHeaderDesign(sap.uxap.ObjectPageHeaderDesign sHeaderDesign);

				#endregion

				#region Methods for Property showTitleSelector

				/// <summary>
				/// Gets current value of property {@link #getShowTitleSelector showTitleSelector}.
				/// 
				/// When set to true, the selector arrow icon/image is shown and can be pressed.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showTitleSelector</code></returns>
				public extern virtual bool getShowTitleSelector();

				/// <summary>
				/// Sets a new value for property {@link #getShowTitleSelector showTitleSelector}.
				/// 
				/// When set to true, the selector arrow icon/image is shown and can be pressed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowTitleSelector">New value for property <code>showTitleSelector</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setShowTitleSelector(bool bShowTitleSelector);

				#endregion

				#region Methods for Property markFavorite

				/// <summary>
				/// Gets current value of property {@link #getMarkFavorite markFavorite}.
				/// 
				/// Set the favorite state to true or false. The showMarkers property must be true for this property to take effect.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>markFavorite</code></returns>
				public extern virtual bool getMarkFavorite();

				/// <summary>
				/// Sets a new value for property {@link #getMarkFavorite markFavorite}.
				/// 
				/// Set the favorite state to true or false. The showMarkers property must be true for this property to take effect.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bMarkFavorite">New value for property <code>markFavorite</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setMarkFavorite(bool bMarkFavorite);

				#endregion

				#region Methods for Property markFlagged

				/// <summary>
				/// Gets current value of property {@link #getMarkFlagged markFlagged}.
				/// 
				/// Set the flagged state to true or false. The showMarkers property must be true for this property to take effect.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>markFlagged</code></returns>
				public extern virtual bool getMarkFlagged();

				/// <summary>
				/// Sets a new value for property {@link #getMarkFlagged markFlagged}.
				/// 
				/// Set the flagged state to true or false. The showMarkers property must be true for this property to take effect.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bMarkFlagged">New value for property <code>markFlagged</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setMarkFlagged(bool bMarkFlagged);

				#endregion

				#region Methods for Property showMarkers

				/// <summary>
				/// Gets current value of property {@link #getShowMarkers showMarkers}.
				/// 
				/// Indicates if object page header title supports showing markers such as flagged and favorite.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showMarkers</code></returns>
				public extern virtual bool getShowMarkers();

				/// <summary>
				/// Sets a new value for property {@link #getShowMarkers showMarkers}.
				/// 
				/// Indicates if object page header title supports showing markers such as flagged and favorite.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowMarkers">New value for property <code>showMarkers</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setShowMarkers(bool bShowMarkers);

				#endregion

				#region Methods for Property markLocked

				/// <summary>
				/// Gets current value of property {@link #getMarkLocked markLocked}.
				/// 
				/// Set the locked state of the objectPageHeader.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>markLocked</code></returns>
				public extern virtual bool getMarkLocked();

				/// <summary>
				/// Sets a new value for property {@link #getMarkLocked markLocked}.
				/// 
				/// Set the locked state of the objectPageHeader.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bMarkLocked">New value for property <code>markLocked</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setMarkLocked(bool bMarkLocked);

				#endregion

				#region Methods for Property showPlaceholder

				/// <summary>
				/// Gets current value of property {@link #getShowPlaceholder showPlaceholder}.
				/// 
				/// Enables support of a placeholder image in case no image is specified or the URL of the provided image is invalid.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showPlaceholder</code></returns>
				public extern virtual bool getShowPlaceholder();

				/// <summary>
				/// Sets a new value for property {@link #getShowPlaceholder showPlaceholder}.
				/// 
				/// Enables support of a placeholder image in case no image is specified or the URL of the provided image is invalid.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowPlaceholder">New value for property <code>showPlaceholder</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setShowPlaceholder(bool bShowPlaceholder);

				#endregion

				#region Methods for Property markChanges

				/// <summary>
				/// Gets current value of property {@link #getMarkChanges markChanges}.
				/// 
				/// Marks that there are unsaved changes in the objectPageHeader. The markChanges state cannot be used together with the markLocked state. If both are set to true, only the locked state will be displayed.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>markChanges</code></returns>
				public extern virtual bool getMarkChanges();

				/// <summary>
				/// Sets a new value for property {@link #getMarkChanges markChanges}.
				/// 
				/// Marks that there are unsaved changes in the objectPageHeader. The markChanges state cannot be used together with the markLocked state. If both are set to true, only the locked state will be displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bMarkChanges">New value for property <code>markChanges</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setMarkChanges(bool bMarkChanges);

				#endregion

				#region Methods for Aggregation _breadCrumbs

				#endregion

				#region Methods for Aggregation breadcrumbs

				/// <summary>
				/// Gets content of aggregation {@link #getBreadcrumbs breadcrumbs}.
				/// 
				/// The breadcrumbs displayed in the <code>ObjectPageHeader</code>. If this aggregation is set, the <code>breadCrumbsLinks</code> aggregation is omitted.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Breadcrumbs getBreadcrumbs();

				/// <summary>
				/// Destroys the breadcrumbs in the aggregation {@link #getBreadcrumbs breadcrumbs}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader destroyBreadcrumbs();

				/// <summary>
				/// Sets the aggregated {@link #getBreadcrumbs breadcrumbs}.
				/// </summary>
				/// <param name="oBreadcrumbs">The breadcrumbs to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setBreadcrumbs(sap.m.Breadcrumbs oBreadcrumbs);

				#endregion

				#region Methods for Aggregation breadCrumbsLinks

				/// <summary>
				/// Gets content of aggregation {@link #getBreadCrumbsLinks breadCrumbsLinks}.
				/// 
				/// A list of all the active link elements in the BreadCrumbs control.
				/// </summary>
				/// <returns></returns>
				[Obsolete("Deprecated since 1.50. use the <code>breadcrumbs</code> aggregation instead.")]
				public extern virtual sap.m.Link[] getBreadCrumbsLinks();

				/// <summary>
				/// Destroys all the breadCrumbsLinks in the aggregation {@link #getBreadCrumbsLinks breadCrumbsLinks}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. use the <code>breadcrumbs</code> aggregation instead.")]
				public extern virtual sap.uxap.ObjectPageHeader destroyBreadCrumbsLinks();

				/// <summary>
				/// Inserts a breadCrumbLink into the aggregation {@link #getBreadCrumbsLinks breadCrumbsLinks}.
				/// </summary>
				/// <param name="oBreadCrumbLink">The breadCrumbLink to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the breadCrumbLink should be inserted at; for a negative value of <code>iIndex</code>, the breadCrumbLink is inserted at position 0; for a value greater than the current size of the aggregation, the breadCrumbLink is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. use the <code>breadcrumbs</code> aggregation instead.")]
				public extern virtual sap.uxap.ObjectPageHeader insertBreadCrumbLink(sap.m.Link oBreadCrumbLink, int iIndex);

				/// <summary>
				/// Adds some breadCrumbLink to the aggregation {@link #getBreadCrumbsLinks breadCrumbsLinks}.
				/// </summary>
				/// <param name="oBreadCrumbLink">The breadCrumbLink to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. use the <code>breadcrumbs</code> aggregation instead.")]
				public extern virtual sap.uxap.ObjectPageHeader addBreadCrumbLink(sap.m.Link oBreadCrumbLink);

				/// <summary>
				/// Removes a breadCrumbLink from the aggregation {@link #getBreadCrumbsLinks breadCrumbsLinks}.
				/// </summary>
				/// <param name="vBreadCrumbLink">The breadCrumbLink to remove or its index or id</param>
				/// <returns>The removed breadCrumbLink or <code>null</code></returns>
				[Obsolete("Deprecated since 1.50. use the <code>breadcrumbs</code> aggregation instead.")]
				public extern virtual sap.m.Link removeBreadCrumbLink(Union<int, string, sap.m.Link> vBreadCrumbLink);

				/// <summary>
				/// Checks for the provided <code>sap.m.Link</code> in the aggregation {@link #getBreadCrumbsLinks breadCrumbsLinks}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oBreadCrumbLink">The breadCrumbLink whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				[Obsolete("Deprecated since 1.50. use the <code>breadcrumbs</code> aggregation instead.")]
				public extern virtual int indexOfBreadCrumbLink(sap.m.Link oBreadCrumbLink);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getBreadCrumbsLinks breadCrumbsLinks}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				[Obsolete("Deprecated since 1.50. use the <code>breadcrumbs</code> aggregation instead.")]
				public extern virtual sap.m.Link[] removeAllBreadCrumbsLinks();

				#endregion

				#region Methods for Aggregation _overflowButton

				#endregion

				#region Methods for Aggregation _expandButton

				#endregion

				#region Methods for Aggregation _objectImage

				#endregion

				#region Methods for Aggregation _placeholder

				#endregion

				#region Methods for Aggregation _lockIconCont

				#endregion

				#region Methods for Aggregation _lockIcon

				#endregion

				#region Methods for Aggregation _titleArrowIconCont

				#endregion

				#region Methods for Aggregation _titleArrowIcon

				#endregion

				#region Methods for Aggregation _favIcon

				#endregion

				#region Methods for Aggregation _flagIcon

				#endregion

				#region Methods for Aggregation _overflowActionSheet

				#endregion

				#region Methods for Aggregation _changesIconCont

				#endregion

				#region Methods for Aggregation _changesIcon

				#endregion

				#region Methods for Aggregation _sideContentBtn

				#endregion

				#region Methods for Aggregation navigationBar

				/// <summary>
				/// Gets content of aggregation {@link #getNavigationBar navigationBar}.
				/// 
				/// An instance of sap.m.Bar to be embedded in the header
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Bar getNavigationBar();

				/// <summary>
				/// Destroys the navigationBar in the aggregation {@link #getNavigationBar navigationBar}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader destroyNavigationBar();

				/// <summary>
				/// Sets the aggregated {@link #getNavigationBar navigationBar}.
				/// </summary>
				/// <param name="oNavigationBar">The navigationBar to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setNavigationBar(sap.m.Bar oNavigationBar);

				#endregion

				#region Methods for Aggregation actions

				/// <summary>
				/// Gets content of aggregation {@link #getActions actions}.
				/// 
				/// List of actions that will be displayed in the header. You can use ObjectPageHeaderActionButton controls to achieve a different visual representation of the action buttons in the action bar and the action sheet (overflow menu). You can use ObjectPageHeaderLayoutData to display a visual separator.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getActions();

				/// <summary>
				/// Destroys all the actions in the aggregation {@link #getActions actions}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader destroyActions();

				/// <summary>
				/// Inserts a action into the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the action should be inserted at; for a negative value of <code>iIndex</code>, the action is inserted at position 0; for a value greater than the current size of the aggregation, the action is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader insertAction(sap.ui.core.Control oAction, int iIndex);

				/// <summary>
				/// Adds some action to the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader addAction(sap.ui.core.Control oAction);

				/// <summary>
				/// Removes a action from the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="vAction">The action to remove or its index or id</param>
				/// <returns>The removed action or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeAction(Union<int, string, sap.ui.core.Control> vAction);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getActions actions}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oAction">The action whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfAction(sap.ui.core.Control oAction);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getActions actions}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllActions();

				#endregion

				#region Methods for Aggregation sideContentButton

				/// <summary>
				/// Gets content of aggregation {@link #getSideContentButton sideContentButton}.
				/// 
				/// A button that is used for opening the side content of the page or some additional content.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Button getSideContentButton();

				/// <summary>
				/// Destroys the sideContentButton in the aggregation {@link #getSideContentButton sideContentButton}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader destroySideContentButton();

				/// <summary>
				/// Sets the aggregated {@link #getSideContentButton sideContentButton}.
				/// </summary>
				/// <param name="oSideContentButton">The sideContentButton to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setSideContentButton(sap.m.Button oSideContentButton);

				#endregion

				#region Methods for Aggregation titleSelectorTooltip

				/// <summary>
				/// Gets content of aggregation {@link #getTitleSelectorTooltip titleSelectorTooltip}.
				/// 
				/// A custom tooltip for the title selector button.
				/// 
				/// The custom tooltip will be visible if the <code>showTitleSelector</code> property is set to <code>true</code>.
				/// 
				/// <b>Note:</b> If the aggregation is destroyed or set to invalid value, the default tooltip will be set. The default tooltip text is "Related options".
				/// </summary>
				/// <returns></returns>
				public extern virtual Union<sap.ui.core.TooltipBase, string> getTitleSelectorTooltip();

				/// <summary>
				/// Destroys the titleSelectorTooltip in the aggregation {@link #getTitleSelectorTooltip titleSelectorTooltip}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader destroyTitleSelectorTooltip();

				/// <summary>
				/// Sets the aggregated {@link #getTitleSelectorTooltip titleSelectorTooltip}.
				/// </summary>
				/// <param name="vTitleSelectorTooltip">The titleSelectorTooltip to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader setTitleSelectorTooltip(Union<sap.ui.core.TooltipBase, string> vTitleSelectorTooltip);

				#endregion

				#region Methods for Event titleSelectorPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titleSelectorPress titleSelectorPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the objectPage header title selector (down-arrow) is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachTitleSelectorPress(object oData, sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titleSelectorPress titleSelectorPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the objectPage header title selector (down-arrow) is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachTitleSelectorPress(object oData, sap.m.ObjectPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titleSelectorPress titleSelectorPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the objectPage header title selector (down-arrow) is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachTitleSelectorPress(sap.m.ObjectPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titleSelectorPress titleSelectorPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the objectPage header title selector (down-arrow) is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachTitleSelectorPress(sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:titleSelectorPress titleSelectorPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader detachTitleSelectorPress(sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:titleSelectorPress titleSelectorPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader fireTitleSelectorPress(sap.m.ObjectPressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:titleSelectorPress titleSelectorPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader fireTitleSelectorPress();

				#endregion

				#region Methods for Event markLockedPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:markLockedPress markLockedPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the Locked button is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachMarkLockedPress(object oData, sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:markLockedPress markLockedPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the Locked button is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachMarkLockedPress(object oData, sap.m.ObjectPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:markLockedPress markLockedPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the Locked button is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachMarkLockedPress(sap.m.ObjectPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:markLockedPress markLockedPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the Locked button is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachMarkLockedPress(sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:markLockedPress markLockedPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader detachMarkLockedPress(sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:markLockedPress markLockedPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader fireMarkLockedPress(sap.m.ObjectPressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:markLockedPress markLockedPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader fireMarkLockedPress();

				#endregion

				#region Methods for Event markChangesPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:markChangesPress markChangesPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the unsaved changes button is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachMarkChangesPress(object oData, sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:markChangesPress markChangesPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the unsaved changes button is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachMarkChangesPress(object oData, sap.m.ObjectPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:markChangesPress markChangesPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the unsaved changes button is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachMarkChangesPress(sap.m.ObjectPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:markChangesPress markChangesPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.uxap.ObjectPageHeader</code> itself.
				/// 
				/// The event is fired when the unsaved changes button is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.uxap.ObjectPageHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader attachMarkChangesPress(sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:markChangesPress markChangesPress} event of this <code>sap.uxap.ObjectPageHeader</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader detachMarkChangesPress(sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:markChangesPress markChangesPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader fireMarkChangesPress(sap.m.ObjectPressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:markChangesPress markChangesPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeader fireMarkChangesPress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ObjectPageHeader.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				#endregion

				#endregion

			}
		}
	}
}
