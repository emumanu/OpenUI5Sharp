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
			/// <code>ObjectHeader</code> is a display control that enables the user to easily identify a specific object. The object header title is the key identifier of the object and additional text and icons can be used to further distinguish it from other objects.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ObjectHeader")]
			public partial class ObjectHeader : sap.ui.core.Control
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
					/// Determines the title of the <code>ObjectHeader</code>.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Determines the displayed number of the <code>ObjectHeader</code> number field.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> number;

					/// <summary>
					/// Determines the units qualifier of the <code>ObjectHeader</code> number.
					/// 
					/// <b>Note:</b> The value of the <code>numberUnit</code> is not displayed if the number property is set to <code>null</code>.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> numberUnit;

					/// <summary>
					/// Determines the introductory text for the <code>ObjectHeader</code>.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> intro;

					/// <summary>
					/// Determines whether the introductory text of the <code>ObjectHeader</code> is clickable.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> introActive;

					/// <summary>
					/// Determines whether the title of the <code>ObjectHeader</code> is clickable and is set only if a title is provided.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleActive;

					/// <summary>
					/// Defines the icon of the <code>ObjectHeader</code>.
					/// 
					/// <b>Note:</b> Recursive resolution of binding expressions is not supported by the framework. It works only in ObjectHeader, since it is a composite control and creates an Image control internally.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// Determines whether the <code>ObjectHeader</code> icon is clickable.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconActive;

					/// <summary>
					/// Determines the alternative text of the <code>ObjectHeader</code> icon. The text is displayed if the image for the icon is not available, or cannot be displayed.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconAlt;

					/// <summary>
					/// Determines the tooltip text of the <code>ObjectHeader</code> icon.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconTooltip;

					/// <summary>
					/// By default, this is set to <code>true</code> but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
					/// 
					/// If bandwidth is the key for the application, set this value to <code>false</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconDensityAware;

					/// <summary>
					/// Sets the favorite state for the <code>ObjectHeader</code>. The <code>showMarkers</code> property must be set to <code>true</code> for this property to take effect.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> markFavorite;

					/// <summary>
					/// Sets the flagged state for the <code>ObjectHeader</code>. The <code>showMarkers</code> property must be set to <code>true</code> for this property to take effect.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> markFlagged;

					/// <summary>
					/// If set to <code>true</code>, the <code>ObjectHeader</code> can be marked with icons such as favorite and flag.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showMarkers;

					/// <summary>
					/// Determines whether the selector arrow icon/image is displayed and can be pressed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showTitleSelector;

					/// <summary>
					/// Determines the value state of the <code>number</code> and <code>numberUnit</code> properties.
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> numberState;

					/// <summary>
					/// <code>ObjectHeader</code> with title, one attribute, number, and number unit.
					/// 
					/// <b>Note:</b> Only applied if the <code>responsive</code> property is set to <code>false</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> condensed;

					/// <summary>
					/// Determines the background color of the <code>ObjectHeader</code>.
					/// 
					/// <b>Note:</b> The different types of <code>ObjectHeader</code> come with different default background: <ul> <li>non responsive - Transparent</li> <li>responsive - Translucent</li> <li>condensed - Solid</li> </ul>
					/// </summary>
					public Union<sap.m.BackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

					/// <summary>
					/// Determines whether the <code>ObjectHeader</code> is rendered with a different design that reacts responsively to the screen sizes.
					/// 
					/// <b>Note:</b> Be aware that the design and behavior of the responsive <code>ObjectHeader</code> could change without further notification.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> responsive;

					/// <summary>
					/// Optimizes the display of the elements of the <code>ObjectHeader</code>.
					/// 
					/// Set this property to <code>true</code> if your app uses a fullscreen layout (as opposed to a master-detail or other split-screen layout).
					/// 
					/// <b>Note</b>: Only applied if the <code>responsive</code> property is also set to <code>true</code>.
					/// 
					/// If set to <code>true</code>, the following situations apply: <ul> <li>On desktop, 1-3 attributes/statuses - positioned as a third block on the right side of the Title/Number group</li> <li>On desktop, 4+ attributes/statuses - 4 columns below the Title/Number</li> <li>On tablet (portrait mode), always in 2 columns below the Title/Number</li> <li>On tablet (landscape mode), 1-2 attributes/statuses - 2 columns below the Title/Number</li> <li>On tablet (landscape mode), 3+ attributes/statuses - 3 columns below the Title/Number</li> </ul> On phone, the attributes and statuses are always positioned in 1 column below the Title/Number of the <code>ObjectHeader</code>.
					/// 
					/// If set to <code>false</code>, the attributes and statuses are being positioned below the Title/Number of the <code>ObjectHeader</code> in 2 or 3 columns depending on their number: <ul> <li>On desktop, 1-4 attributes/statuses - 2 columns</li> <li>On desktop, 5+ attributes/statuses - 3 columns</li> <li>On tablet, always in 2 columns</li> </ul>
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fullScreenOptimized;

					/// <summary>
					/// Defines the title link target URI. Supports standard hyperlink behavior.
					/// 
					/// <b>Note:</b> If an action should be triggered, this property should not be set, but instead an event handler for the <code>titlePress</code> event should be registered.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleHref;

					/// <summary>
					/// Determines the <code>target</code> attribute for the title link. Options are <code>_self</code>, <code>_top</code>, <code>_blank</code>, <code>_parent</code>, <code>_search</code>. Alternatively, a frame name can be entered.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleTarget;

					/// <summary>
					/// Determines the intro link target URI. Supports standard hyperlink behavior. If an action should be triggered, this should not be set, but instead an event handler for the <code>introPress</code> event should be registered.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> introHref;

					/// <summary>
					/// Determines the <code>target</code> attribute for the intro link. Options are <code>_self</code>, <code>_top</code>, <code>_blank</code>, <code>_parent</code>, <code>_search</code>. Alternatively, a frame name can be entered.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> introTarget;

					/// <summary>
					/// Specifies the title text directionality with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleTextDirection;

					/// <summary>
					/// Specifies the intro text directionality with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> introTextDirection;

					/// <summary>
					/// Specifies the number and unit text directionality with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> numberTextDirection;

					/// <summary>
					/// Determines a custom text for the tooltip of the select title arrow. If not set, a default text of the tooltip will be displayed.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleSelectorTooltip;

					/// <summary>
					/// Defines the semantic level of the title.
					/// 
					/// This information is used by assistive technologies, such as screen readers to create a hierarchical site map for faster navigation. Depending on this setting an HTML h1-h6 element is used.
					/// </summary>
					public Union<sap.ui.core.TitleLevel, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleLevel;

					/// <summary>
					/// The list of Object Attributes
					/// </summary>
					public Union<sap.m.ObjectAttribute[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> attributes;

					/// <summary>
					/// First status shown on the right side of the attributes above the second status. If it is not set the first attribute will expand to take the entire row.
					/// </summary>
					public Union<sap.m.ObjectStatus, string, sap.ui.@base.ManagedObject.BindAggregationInfo> firstStatus;

					/// <summary>
					/// Second status shown on the right side of the attributes below the first status. If it is not set the second attribute will expand to take the entire row.
					/// </summary>
					public Union<sap.m.ObjectStatus, string, sap.ui.@base.ManagedObject.BindAggregationInfo> secondStatus;

					/// <summary>
					/// The list of Object sap.ui.core.Control. It will only allow sap.m.ObjectStatus and sap.m.ProgressIndicator controls.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> statuses;

					/// <summary>
					/// NOTE: Only applied if you set "responsive=false". Additional object numbers and units are managed in this aggregation. The numbers are hidden on tablet and phone size screens. When only one number is provided, it is rendered with additional separator from the main ObjectHeader number.
					/// </summary>
					public Union<sap.m.ObjectNumber[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> additionalNumbers;

					/// <summary>
					/// This aggregation takes only effect when you set "responsive" to true. It can either be filled with an sap.m.IconTabBar or an sap.suite.ui.commons.HeaderContainer control. Overflow handling must be taken care of by the inner control. If used with an IconTabBar control, only the header will be displayed inside the object header, the content will be displayed below the ObjectHeader.
					/// </summary>
					public Union<sap.m.ObjectHeaderContainer, string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerContainer;

					/// <summary>
					/// List of markers (icon and/or text) that can be displayed for the <code>ObjectHeader</code>, such as favorite and flagged.<br><br> <b>Note:</b> You should use either this aggregation or the already deprecated properties - <code>markFlagged</code> and <code>markFavorite</code>. Using both can lead to unexpected results.
					/// </summary>
					public Union<sap.m.ObjectMarker[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> markers;

					/// <summary>
					/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Event is fired when the title is active and the user taps/clicks on it
					/// </summary>
					public sap.m.ObjectHeaderPressDelegate titlePress;

					/// <summary>
					/// Event is fired when the intro is active and the user taps/clicks on it
					/// </summary>
					public sap.m.ObjectHeaderPressDelegate introPress;

					/// <summary>
					/// Event is fired when the title icon is active and the user taps/clicks on it
					/// </summary>
					public sap.m.ObjectHeaderPressDelegate iconPress;

					/// <summary>
					/// Event is fired when the object header title selector (down-arrow) is pressed
					/// </summary>
					public sap.m.ObjectHeaderPressDelegate titleSelectorPress;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new </code>ObjectHeader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectHeader(string sId, sap.m.ObjectHeader.Settings mSettings);

				/// <summary>
				/// Constructor for a new </code>ObjectHeader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectHeader(string sId);

				/// <summary>
				/// Constructor for a new </code>ObjectHeader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectHeader();

				/// <summary>
				/// Constructor for a new </code>ObjectHeader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectHeader(sap.m.ObjectHeader.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Determines the title of the <code>ObjectHeader</code>.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Determines the title of the <code>ObjectHeader</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setTitle(string sTitle);

				#endregion

				#region Methods for Property number

				/// <summary>
				/// Gets current value of property {@link #getNumber number}.
				/// 
				/// Determines the displayed number of the <code>ObjectHeader</code> number field.
				/// </summary>
				/// <returns>Value of property <code>number</code></returns>
				public extern virtual string getNumber();

				/// <summary>
				/// Set the number value to the internal aggregation
				/// </summary>
				/// <param name="sNumber">the new value</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectHeader setNumber(string sNumber);

				#endregion

				#region Methods for Property numberUnit

				/// <summary>
				/// Gets current value of property {@link #getNumberUnit numberUnit}.
				/// 
				/// Determines the units qualifier of the <code>ObjectHeader</code> number.
				/// 
				/// <b>Note:</b> The value of the <code>numberUnit</code> is not displayed if the number property is set to <code>null</code>.
				/// </summary>
				/// <returns>Value of property <code>numberUnit</code></returns>
				public extern virtual string getNumberUnit();

				/// <summary>
				/// Set the number unit to the internal aggregation
				/// </summary>
				/// <param name="sUnit">the new value</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectHeader setNumberUnit(string sUnit);

				#endregion

				#region Methods for Property intro

				/// <summary>
				/// Gets current value of property {@link #getIntro intro}.
				/// 
				/// Determines the introductory text for the <code>ObjectHeader</code>.
				/// </summary>
				/// <returns>Value of property <code>intro</code></returns>
				public extern virtual string getIntro();

				/// <summary>
				/// Sets a new value for property {@link #getIntro intro}.
				/// 
				/// Determines the introductory text for the <code>ObjectHeader</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIntro">New value for property <code>intro</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setIntro(string sIntro);

				#endregion

				#region Methods for Property introActive

				/// <summary>
				/// Gets current value of property {@link #getIntroActive introActive}.
				/// 
				/// Determines whether the introductory text of the <code>ObjectHeader</code> is clickable.
				/// </summary>
				/// <returns>Value of property <code>introActive</code></returns>
				public extern virtual bool getIntroActive();

				/// <summary>
				/// Sets a new value for property {@link #getIntroActive introActive}.
				/// 
				/// Determines whether the introductory text of the <code>ObjectHeader</code> is clickable.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bIntroActive">New value for property <code>introActive</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setIntroActive(bool bIntroActive);

				#endregion

				#region Methods for Property titleActive

				/// <summary>
				/// Gets current value of property {@link #getTitleActive titleActive}.
				/// 
				/// Determines whether the title of the <code>ObjectHeader</code> is clickable and is set only if a title is provided.
				/// </summary>
				/// <returns>Value of property <code>titleActive</code></returns>
				public extern virtual bool getTitleActive();

				/// <summary>
				/// Sets a new value for property {@link #getTitleActive titleActive}.
				/// 
				/// Determines whether the title of the <code>ObjectHeader</code> is clickable and is set only if a title is provided.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bTitleActive">New value for property <code>titleActive</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setTitleActive(bool bTitleActive);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Defines the icon of the <code>ObjectHeader</code>.
				/// 
				/// <b>Note:</b> Recursive resolution of binding expressions is not supported by the framework. It works only in ObjectHeader, since it is a composite control and creates an Image control internally.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Defines the icon of the <code>ObjectHeader</code>.
				/// 
				/// <b>Note:</b> Recursive resolution of binding expressions is not supported by the framework. It works only in ObjectHeader, since it is a composite control and creates an Image control internally.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property iconActive

				/// <summary>
				/// Gets current value of property {@link #getIconActive iconActive}.
				/// 
				/// Determines whether the <code>ObjectHeader</code> icon is clickable.
				/// </summary>
				/// <returns>Value of property <code>iconActive</code></returns>
				public extern virtual bool getIconActive();

				/// <summary>
				/// Sets a new value for property {@link #getIconActive iconActive}.
				/// 
				/// Determines whether the <code>ObjectHeader</code> icon is clickable.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bIconActive">New value for property <code>iconActive</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setIconActive(bool bIconActive);

				#endregion

				#region Methods for Property iconAlt

				/// <summary>
				/// Gets current value of property {@link #getIconAlt iconAlt}.
				/// 
				/// Determines the alternative text of the <code>ObjectHeader</code> icon. The text is displayed if the image for the icon is not available, or cannot be displayed.
				/// </summary>
				/// <returns>Value of property <code>iconAlt</code></returns>
				public extern virtual string getIconAlt();

				/// <summary>
				/// Sets a new value for property {@link #getIconAlt iconAlt}.
				/// 
				/// Determines the alternative text of the <code>ObjectHeader</code> icon. The text is displayed if the image for the icon is not available, or cannot be displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIconAlt">New value for property <code>iconAlt</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setIconAlt(string sIconAlt);

				#endregion

				#region Methods for Property iconTooltip

				/// <summary>
				/// Gets current value of property {@link #getIconTooltip iconTooltip}.
				/// 
				/// Determines the tooltip text of the <code>ObjectHeader</code> icon.
				/// </summary>
				/// <returns>Value of property <code>iconTooltip</code></returns>
				public extern virtual string getIconTooltip();

				/// <summary>
				/// Sets a new value for property {@link #getIconTooltip iconTooltip}.
				/// 
				/// Determines the tooltip text of the <code>ObjectHeader</code> icon.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIconTooltip">New value for property <code>iconTooltip</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setIconTooltip(string sIconTooltip);

				#endregion

				#region Methods for Property iconDensityAware

				/// <summary>
				/// Gets current value of property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// By default, this is set to <code>true</code> but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
				/// 
				/// If bandwidth is the key for the application, set this value to <code>false</code>.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>iconDensityAware</code></returns>
				public extern virtual bool getIconDensityAware();

				/// <summary>
				/// Sets a new value for property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// By default, this is set to <code>true</code> but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
				/// 
				/// If bandwidth is the key for the application, set this value to <code>false</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIconDensityAware">New value for property <code>iconDensityAware</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setIconDensityAware(bool bIconDensityAware);

				#endregion

				#region Methods for Property markFavorite

				/// <summary>
				/// Gets current value of property {@link #getMarkFavorite markFavorite}.
				/// 
				/// Sets the favorite state for the <code>ObjectHeader</code>. The <code>showMarkers</code> property must be set to <code>true</code> for this property to take effect.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>markFavorite</code></returns>
				[Obsolete("Deprecated since 1.42.0. replaced by <code>markers</code> aggregation. Add {@link sap.m.ObjectMarker} with type <code>sap.m.ObjectMarkerType.Favorite</code>. You should use either this property or the <code>markers</code> aggregation, using both may lead to unpredicted behavior.")]
				public extern virtual bool getMarkFavorite();

				/// <summary>
				/// Sets the visibility value of the Favorite marker.
				/// </summary>
				/// <param name="bMarked">visibility of the marker</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectHeader setMarkFavorite(bool bMarked);

				#endregion

				#region Methods for Property markFlagged

				/// <summary>
				/// Gets current value of property {@link #getMarkFlagged markFlagged}.
				/// 
				/// Sets the flagged state for the <code>ObjectHeader</code>. The <code>showMarkers</code> property must be set to <code>true</code> for this property to take effect.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>markFlagged</code></returns>
				[Obsolete("Deprecated since 1.42.0. replaced by <code>markers</code> aggregation. Add {@link sap.m.ObjectMarker} with type <code>sap.m.ObjectMarkerType.Flagged</code>. You should use either this property or the <code>markers</code> aggregation, using both may lead to unpredicted behavior.")]
				public extern virtual bool getMarkFlagged();

				/// <summary>
				/// Sets the visibility value of the Flagged marker.
				/// </summary>
				/// <param name="bMarked">visibility of the marker</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectHeader setMarkFlagged(bool bMarked);

				#endregion

				#region Methods for Property showMarkers

				/// <summary>
				/// Gets current value of property {@link #getShowMarkers showMarkers}.
				/// 
				/// If set to <code>true</code>, the <code>ObjectHeader</code> can be marked with icons such as favorite and flag.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showMarkers</code></returns>
				[Obsolete("Deprecated since 1.42.0. replaced by <code>markers</code> aggregationv. This property is valid only if you are using the already deprecated properties - <code>markFlagged</code> and <code>markFavorite</code>. If you are using <code>markers</code>, the visibility of the markers depends on what is set in the aggregation itself.")]
				public extern virtual bool getShowMarkers();

				/// <summary>
				/// Sets the visibility value of the Flagged and Favorite markers.
				/// </summary>
				/// <param name="bMarked">visibility of all markers</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectHeader setShowMarkers(bool bMarked);

				#endregion

				#region Methods for Property showTitleSelector

				/// <summary>
				/// Gets current value of property {@link #getShowTitleSelector showTitleSelector}.
				/// 
				/// Determines whether the selector arrow icon/image is displayed and can be pressed.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showTitleSelector</code></returns>
				public extern virtual bool getShowTitleSelector();

				/// <summary>
				/// Sets a new value for property {@link #getShowTitleSelector showTitleSelector}.
				/// 
				/// Determines whether the selector arrow icon/image is displayed and can be pressed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowTitleSelector">New value for property <code>showTitleSelector</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setShowTitleSelector(bool bShowTitleSelector);

				#endregion

				#region Methods for Property numberState

				/// <summary>
				/// Gets current value of property {@link #getNumberState numberState}.
				/// 
				/// Determines the value state of the <code>number</code> and <code>numberUnit</code> properties.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>numberState</code></returns>
				public extern virtual sap.ui.core.ValueState getNumberState();

				/// <summary>
				/// Set the number state to the internal aggregation
				/// </summary>
				/// <param name="sState">the new value</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectHeader setNumberState(sap.ui.core.ValueState sState);

				#endregion

				#region Methods for Property condensed

				/// <summary>
				/// Gets current value of property {@link #getCondensed condensed}.
				/// 
				/// <code>ObjectHeader</code> with title, one attribute, number, and number unit.
				/// 
				/// <b>Note:</b> Only applied if the <code>responsive</code> property is set to <code>false</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>condensed</code></returns>
				public extern virtual bool getCondensed();

				/// <summary>
				/// Set the condensed flag
				/// </summary>
				/// <param name="bCondensed">the new value</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectHeader setCondensed(bool bCondensed);

				#endregion

				#region Methods for Property backgroundDesign

				/// <summary>
				/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Determines the background color of the <code>ObjectHeader</code>.
				/// 
				/// <b>Note:</b> The different types of <code>ObjectHeader</code> come with different default background: <ul> <li>non responsive - Transparent</li> <li>responsive - Translucent</li> <li>condensed - Solid</li> </ul>
				/// </summary>
				/// <returns>Value of property <code>backgroundDesign</code></returns>
				public extern virtual sap.m.BackgroundDesign getBackgroundDesign();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Determines the background color of the <code>ObjectHeader</code>.
				/// 
				/// <b>Note:</b> The different types of <code>ObjectHeader</code> come with different default background: <ul> <li>non responsive - Transparent</li> <li>responsive - Translucent</li> <li>condensed - Solid</li> </ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sBackgroundDesign">New value for property <code>backgroundDesign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setBackgroundDesign(sap.m.BackgroundDesign sBackgroundDesign);

				#endregion

				#region Methods for Property responsive

				/// <summary>
				/// Gets current value of property {@link #getResponsive responsive}.
				/// 
				/// Determines whether the <code>ObjectHeader</code> is rendered with a different design that reacts responsively to the screen sizes.
				/// 
				/// <b>Note:</b> Be aware that the design and behavior of the responsive <code>ObjectHeader</code> could change without further notification.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>responsive</code></returns>
				public extern virtual bool getResponsive();

				/// <summary>
				/// Sets a new value for property {@link #getResponsive responsive}.
				/// 
				/// Determines whether the <code>ObjectHeader</code> is rendered with a different design that reacts responsively to the screen sizes.
				/// 
				/// <b>Note:</b> Be aware that the design and behavior of the responsive <code>ObjectHeader</code> could change without further notification.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bResponsive">New value for property <code>responsive</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setResponsive(bool bResponsive);

				#endregion

				#region Methods for Property fullScreenOptimized

				/// <summary>
				/// Gets current value of property {@link #getFullScreenOptimized fullScreenOptimized}.
				/// 
				/// Optimizes the display of the elements of the <code>ObjectHeader</code>.
				/// 
				/// Set this property to <code>true</code> if your app uses a fullscreen layout (as opposed to a master-detail or other split-screen layout).
				/// 
				/// <b>Note</b>: Only applied if the <code>responsive</code> property is also set to <code>true</code>.
				/// 
				/// If set to <code>true</code>, the following situations apply: <ul> <li>On desktop, 1-3 attributes/statuses - positioned as a third block on the right side of the Title/Number group</li> <li>On desktop, 4+ attributes/statuses - 4 columns below the Title/Number</li> <li>On tablet (portrait mode), always in 2 columns below the Title/Number</li> <li>On tablet (landscape mode), 1-2 attributes/statuses - 2 columns below the Title/Number</li> <li>On tablet (landscape mode), 3+ attributes/statuses - 3 columns below the Title/Number</li> </ul> On phone, the attributes and statuses are always positioned in 1 column below the Title/Number of the <code>ObjectHeader</code>.
				/// 
				/// If set to <code>false</code>, the attributes and statuses are being positioned below the Title/Number of the <code>ObjectHeader</code> in 2 or 3 columns depending on their number: <ul> <li>On desktop, 1-4 attributes/statuses - 2 columns</li> <li>On desktop, 5+ attributes/statuses - 3 columns</li> <li>On tablet, always in 2 columns</li> </ul>
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>fullScreenOptimized</code></returns>
				public extern virtual bool getFullScreenOptimized();

				/// <summary>
				/// Sets a new value for property {@link #getFullScreenOptimized fullScreenOptimized}.
				/// 
				/// Optimizes the display of the elements of the <code>ObjectHeader</code>.
				/// 
				/// Set this property to <code>true</code> if your app uses a fullscreen layout (as opposed to a master-detail or other split-screen layout).
				/// 
				/// <b>Note</b>: Only applied if the <code>responsive</code> property is also set to <code>true</code>.
				/// 
				/// If set to <code>true</code>, the following situations apply: <ul> <li>On desktop, 1-3 attributes/statuses - positioned as a third block on the right side of the Title/Number group</li> <li>On desktop, 4+ attributes/statuses - 4 columns below the Title/Number</li> <li>On tablet (portrait mode), always in 2 columns below the Title/Number</li> <li>On tablet (landscape mode), 1-2 attributes/statuses - 2 columns below the Title/Number</li> <li>On tablet (landscape mode), 3+ attributes/statuses - 3 columns below the Title/Number</li> </ul> On phone, the attributes and statuses are always positioned in 1 column below the Title/Number of the <code>ObjectHeader</code>.
				/// 
				/// If set to <code>false</code>, the attributes and statuses are being positioned below the Title/Number of the <code>ObjectHeader</code> in 2 or 3 columns depending on their number: <ul> <li>On desktop, 1-4 attributes/statuses - 2 columns</li> <li>On desktop, 5+ attributes/statuses - 3 columns</li> <li>On tablet, always in 2 columns</li> </ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bFullScreenOptimized">New value for property <code>fullScreenOptimized</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setFullScreenOptimized(bool bFullScreenOptimized);

				#endregion

				#region Methods for Property titleHref

				/// <summary>
				/// Gets current value of property {@link #getTitleHref titleHref}.
				/// 
				/// Defines the title link target URI. Supports standard hyperlink behavior.
				/// 
				/// <b>Note:</b> If an action should be triggered, this property should not be set, but instead an event handler for the <code>titlePress</code> event should be registered.
				/// </summary>
				/// <returns>Value of property <code>titleHref</code></returns>
				public extern virtual sap.ui.core.URI getTitleHref();

				/// <summary>
				/// Sets a new value for property {@link #getTitleHref titleHref}.
				/// 
				/// Defines the title link target URI. Supports standard hyperlink behavior.
				/// 
				/// <b>Note:</b> If an action should be triggered, this property should not be set, but instead an event handler for the <code>titlePress</code> event should be registered.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitleHref">New value for property <code>titleHref</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setTitleHref(sap.ui.core.URI sTitleHref);

				#endregion

				#region Methods for Property titleTarget

				/// <summary>
				/// Gets current value of property {@link #getTitleTarget titleTarget}.
				/// 
				/// Determines the <code>target</code> attribute for the title link. Options are <code>_self</code>, <code>_top</code>, <code>_blank</code>, <code>_parent</code>, <code>_search</code>. Alternatively, a frame name can be entered.
				/// </summary>
				/// <returns>Value of property <code>titleTarget</code></returns>
				public extern virtual string getTitleTarget();

				/// <summary>
				/// Sets a new value for property {@link #getTitleTarget titleTarget}.
				/// 
				/// Determines the <code>target</code> attribute for the title link. Options are <code>_self</code>, <code>_top</code>, <code>_blank</code>, <code>_parent</code>, <code>_search</code>. Alternatively, a frame name can be entered.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitleTarget">New value for property <code>titleTarget</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setTitleTarget(string sTitleTarget);

				#endregion

				#region Methods for Property introHref

				/// <summary>
				/// Gets current value of property {@link #getIntroHref introHref}.
				/// 
				/// Determines the intro link target URI. Supports standard hyperlink behavior. If an action should be triggered, this should not be set, but instead an event handler for the <code>introPress</code> event should be registered.
				/// </summary>
				/// <returns>Value of property <code>introHref</code></returns>
				public extern virtual sap.ui.core.URI getIntroHref();

				/// <summary>
				/// Sets a new value for property {@link #getIntroHref introHref}.
				/// 
				/// Determines the intro link target URI. Supports standard hyperlink behavior. If an action should be triggered, this should not be set, but instead an event handler for the <code>introPress</code> event should be registered.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIntroHref">New value for property <code>introHref</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setIntroHref(sap.ui.core.URI sIntroHref);

				#endregion

				#region Methods for Property introTarget

				/// <summary>
				/// Gets current value of property {@link #getIntroTarget introTarget}.
				/// 
				/// Determines the <code>target</code> attribute for the intro link. Options are <code>_self</code>, <code>_top</code>, <code>_blank</code>, <code>_parent</code>, <code>_search</code>. Alternatively, a frame name can be entered.
				/// </summary>
				/// <returns>Value of property <code>introTarget</code></returns>
				public extern virtual string getIntroTarget();

				/// <summary>
				/// Sets a new value for property {@link #getIntroTarget introTarget}.
				/// 
				/// Determines the <code>target</code> attribute for the intro link. Options are <code>_self</code>, <code>_top</code>, <code>_blank</code>, <code>_parent</code>, <code>_search</code>. Alternatively, a frame name can be entered.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIntroTarget">New value for property <code>introTarget</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setIntroTarget(string sIntroTarget);

				#endregion

				#region Methods for Property titleTextDirection

				/// <summary>
				/// Gets current value of property {@link #getTitleTextDirection titleTextDirection}.
				/// 
				/// Specifies the title text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>titleTextDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTitleTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTitleTextDirection titleTextDirection}.
				/// 
				/// Specifies the title text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTitleTextDirection">New value for property <code>titleTextDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setTitleTextDirection(sap.ui.core.TextDirection sTitleTextDirection);

				#endregion

				#region Methods for Property introTextDirection

				/// <summary>
				/// Gets current value of property {@link #getIntroTextDirection introTextDirection}.
				/// 
				/// Specifies the intro text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>introTextDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getIntroTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getIntroTextDirection introTextDirection}.
				/// 
				/// Specifies the intro text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sIntroTextDirection">New value for property <code>introTextDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setIntroTextDirection(sap.ui.core.TextDirection sIntroTextDirection);

				#endregion

				#region Methods for Property numberTextDirection

				/// <summary>
				/// Gets current value of property {@link #getNumberTextDirection numberTextDirection}.
				/// 
				/// Specifies the number and unit text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>numberTextDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getNumberTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getNumberTextDirection numberTextDirection}.
				/// 
				/// Specifies the number and unit text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sNumberTextDirection">New value for property <code>numberTextDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setNumberTextDirection(sap.ui.core.TextDirection sNumberTextDirection);

				#endregion

				#region Methods for Property titleSelectorTooltip

				/// <summary>
				/// Gets current value of property {@link #getTitleSelectorTooltip titleSelectorTooltip}.
				/// 
				/// Determines a custom text for the tooltip of the select title arrow. If not set, a default text of the tooltip will be displayed.
				/// 
				/// Default value is <code>Options</code>.
				/// </summary>
				/// <returns>Value of property <code>titleSelectorTooltip</code></returns>
				public extern virtual string getTitleSelectorTooltip();

				/// <summary>
				/// Sets the new text for the tooltip of the select title arrow to the internal aggregation
				/// </summary>
				/// <param name="sTooltip">the tooltip of the title selector</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectHeader setTitleSelectorTooltip(string sTooltip);

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
				public extern virtual sap.m.ObjectHeader setTitleLevel(sap.ui.core.TitleLevel sTitleLevel);

				#endregion

				#region Methods for Aggregation attributes

				/// <summary>
				/// Gets content of aggregation {@link #getAttributes attributes}.
				/// 
				/// The list of Object Attributes
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ObjectAttribute[] getAttributes();

				/// <summary>
				/// Destroys all the attributes in the aggregation {@link #getAttributes attributes}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader destroyAttributes();

				/// <summary>
				/// Inserts a attribute into the aggregation {@link #getAttributes attributes}.
				/// </summary>
				/// <param name="oAttribute">The attribute to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the attribute should be inserted at; for a negative value of <code>iIndex</code>, the attribute is inserted at position 0; for a value greater than the current size of the aggregation, the attribute is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader insertAttribute(sap.m.ObjectAttribute oAttribute, int iIndex);

				/// <summary>
				/// Adds some attribute to the aggregation {@link #getAttributes attributes}.
				/// </summary>
				/// <param name="oAttribute">The attribute to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader addAttribute(sap.m.ObjectAttribute oAttribute);

				/// <summary>
				/// Removes a attribute from the aggregation {@link #getAttributes attributes}.
				/// </summary>
				/// <param name="vAttribute">The attribute to remove or its index or id</param>
				/// <returns>The removed attribute or <code>null</code></returns>
				public extern virtual sap.m.ObjectAttribute removeAttribute(Union<int, string, sap.m.ObjectAttribute> vAttribute);

				/// <summary>
				/// Checks for the provided <code>sap.m.ObjectAttribute</code> in the aggregation {@link #getAttributes attributes}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oAttribute">The attribute whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfAttribute(sap.m.ObjectAttribute oAttribute);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getAttributes attributes}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ObjectAttribute[] removeAllAttributes();

				#endregion

				#region Methods for Aggregation firstStatus

				/// <summary>
				/// Gets content of aggregation {@link #getFirstStatus firstStatus}.
				/// 
				/// First status shown on the right side of the attributes above the second status. If it is not set the first attribute will expand to take the entire row.
				/// </summary>
				/// <returns></returns>
				[Obsolete("Deprecated since 1.16.0. replaced by <code>statuses</code> aggregation")]
				public extern virtual sap.m.ObjectStatus getFirstStatus();

				/// <summary>
				/// Destroys the firstStatus in the aggregation {@link #getFirstStatus firstStatus}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.0. replaced by <code>statuses</code> aggregation")]
				public extern virtual sap.m.ObjectHeader destroyFirstStatus();

				/// <summary>
				/// Sets the aggregated {@link #getFirstStatus firstStatus}.
				/// </summary>
				/// <param name="oFirstStatus">The firstStatus to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.0. replaced by <code>statuses</code> aggregation")]
				public extern virtual sap.m.ObjectHeader setFirstStatus(sap.m.ObjectStatus oFirstStatus);

				#endregion

				#region Methods for Aggregation secondStatus

				/// <summary>
				/// Gets content of aggregation {@link #getSecondStatus secondStatus}.
				/// 
				/// Second status shown on the right side of the attributes below the first status. If it is not set the second attribute will expand to take the entire row.
				/// </summary>
				/// <returns></returns>
				[Obsolete("Deprecated since 1.16.0. replaced by <code>statuses</code> aggregation")]
				public extern virtual sap.m.ObjectStatus getSecondStatus();

				/// <summary>
				/// Destroys the secondStatus in the aggregation {@link #getSecondStatus secondStatus}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.0. replaced by <code>statuses</code> aggregation")]
				public extern virtual sap.m.ObjectHeader destroySecondStatus();

				/// <summary>
				/// Sets the aggregated {@link #getSecondStatus secondStatus}.
				/// </summary>
				/// <param name="oSecondStatus">The secondStatus to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16.0. replaced by <code>statuses</code> aggregation")]
				public extern virtual sap.m.ObjectHeader setSecondStatus(sap.m.ObjectStatus oSecondStatus);

				#endregion

				#region Methods for Aggregation statuses

				/// <summary>
				/// Gets content of aggregation {@link #getStatuses statuses}.
				/// 
				/// The list of Object sap.ui.core.Control. It will only allow sap.m.ObjectStatus and sap.m.ProgressIndicator controls.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getStatuses();

				/// <summary>
				/// Destroys all the statuses in the aggregation {@link #getStatuses statuses}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader destroyStatuses();

				/// <summary>
				/// Inserts a status into the aggregation {@link #getStatuses statuses}.
				/// </summary>
				/// <param name="oStatus">The status to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the status should be inserted at; for a negative value of <code>iIndex</code>, the status is inserted at position 0; for a value greater than the current size of the aggregation, the status is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader insertStatus(sap.ui.core.Control oStatus, int iIndex);

				/// <summary>
				/// Adds some status to the aggregation {@link #getStatuses statuses}.
				/// </summary>
				/// <param name="oStatus">The status to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader addStatus(sap.ui.core.Control oStatus);

				/// <summary>
				/// Removes a status from the aggregation {@link #getStatuses statuses}.
				/// </summary>
				/// <param name="vStatus">The status to remove or its index or id</param>
				/// <returns>The removed status or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeStatus(Union<int, string, sap.ui.core.Control> vStatus);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getStatuses statuses}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oStatus">The status whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfStatus(sap.ui.core.Control oStatus);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getStatuses statuses}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllStatuses();

				#endregion

				#region Methods for Aggregation _objectNumber

				#endregion

				#region Methods for Aggregation additionalNumbers

				/// <summary>
				/// Gets content of aggregation {@link #getAdditionalNumbers additionalNumbers}.
				/// 
				/// NOTE: Only applied if you set "responsive=false". Additional object numbers and units are managed in this aggregation. The numbers are hidden on tablet and phone size screens. When only one number is provided, it is rendered with additional separator from the main ObjectHeader number.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ObjectNumber[] getAdditionalNumbers();

				/// <summary>
				/// Destroys all the additionalNumbers in the aggregation {@link #getAdditionalNumbers additionalNumbers}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader destroyAdditionalNumbers();

				/// <summary>
				/// Inserts a additionalNumber into the aggregation {@link #getAdditionalNumbers additionalNumbers}.
				/// </summary>
				/// <param name="oAdditionalNumber">The additionalNumber to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the additionalNumber should be inserted at; for a negative value of <code>iIndex</code>, the additionalNumber is inserted at position 0; for a value greater than the current size of the aggregation, the additionalNumber is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader insertAdditionalNumber(sap.m.ObjectNumber oAdditionalNumber, int iIndex);

				/// <summary>
				/// Adds some additionalNumber to the aggregation {@link #getAdditionalNumbers additionalNumbers}.
				/// </summary>
				/// <param name="oAdditionalNumber">The additionalNumber to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader addAdditionalNumber(sap.m.ObjectNumber oAdditionalNumber);

				/// <summary>
				/// Removes a additionalNumber from the aggregation {@link #getAdditionalNumbers additionalNumbers}.
				/// </summary>
				/// <param name="vAdditionalNumber">The additionalNumber to remove or its index or id</param>
				/// <returns>The removed additionalNumber or <code>null</code></returns>
				public extern virtual sap.m.ObjectNumber removeAdditionalNumber(Union<int, string, sap.m.ObjectNumber> vAdditionalNumber);

				/// <summary>
				/// Checks for the provided <code>sap.m.ObjectNumber</code> in the aggregation {@link #getAdditionalNumbers additionalNumbers}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oAdditionalNumber">The additionalNumber whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfAdditionalNumber(sap.m.ObjectNumber oAdditionalNumber);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getAdditionalNumbers additionalNumbers}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ObjectNumber[] removeAllAdditionalNumbers();

				#endregion

				#region Methods for Aggregation headerContainer

				/// <summary>
				/// Gets content of aggregation {@link #getHeaderContainer headerContainer}.
				/// 
				/// This aggregation takes only effect when you set "responsive" to true. It can either be filled with an sap.m.IconTabBar or an sap.suite.ui.commons.HeaderContainer control. Overflow handling must be taken care of by the inner control. If used with an IconTabBar control, only the header will be displayed inside the object header, the content will be displayed below the ObjectHeader.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ObjectHeaderContainer getHeaderContainer();

				/// <summary>
				/// Destroys the headerContainer in the aggregation {@link #getHeaderContainer headerContainer}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader destroyHeaderContainer();

				/// <summary>
				/// Sets the aggregated {@link #getHeaderContainer headerContainer}.
				/// </summary>
				/// <param name="oHeaderContainer">The headerContainer to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader setHeaderContainer(sap.m.ObjectHeaderContainer oHeaderContainer);

				#endregion

				#region Methods for Aggregation markers

				/// <summary>
				/// Gets content of aggregation {@link #getMarkers markers}.
				/// 
				/// List of markers (icon and/or text) that can be displayed for the <code>ObjectHeader</code>, such as favorite and flagged.<br><br> <b>Note:</b> You should use either this aggregation or the already deprecated properties - <code>markFlagged</code> and <code>markFavorite</code>. Using both can lead to unexpected results.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ObjectMarker[] getMarkers();

				/// <summary>
				/// Destroys all the markers in the aggregation {@link #getMarkers markers}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader destroyMarkers();

				/// <summary>
				/// Inserts a marker into the aggregation {@link #getMarkers markers}.
				/// </summary>
				/// <param name="oMarker">The marker to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the marker should be inserted at; for a negative value of <code>iIndex</code>, the marker is inserted at position 0; for a value greater than the current size of the aggregation, the marker is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader insertMarker(sap.m.ObjectMarker oMarker, int iIndex);

				/// <summary>
				/// Adds some marker to the aggregation {@link #getMarkers markers}.
				/// </summary>
				/// <param name="oMarker">The marker to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader addMarker(sap.m.ObjectMarker oMarker);

				/// <summary>
				/// Removes a marker from the aggregation {@link #getMarkers markers}.
				/// </summary>
				/// <param name="vMarker">The marker to remove or its index or id</param>
				/// <returns>The removed marker or <code>null</code></returns>
				public extern virtual sap.m.ObjectMarker removeMarker(Union<int, string, sap.m.ObjectMarker> vMarker);

				/// <summary>
				/// Checks for the provided <code>sap.m.ObjectMarker</code> in the aggregation {@link #getMarkers markers}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oMarker">The marker whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfMarker(sap.m.ObjectMarker oMarker);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getMarkers markers}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ObjectMarker[] removeAllMarkers();

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
				public extern virtual sap.m.ObjectHeader addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
				public extern virtual sap.m.ObjectHeader addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event titlePress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titlePress titlePress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the title is active and the user taps/clicks on it
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachTitlePress(object oData, sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titlePress titlePress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the title is active and the user taps/clicks on it
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachTitlePress(object oData, sap.m.ObjectHeaderPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titlePress titlePress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the title is active and the user taps/clicks on it
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachTitlePress(sap.m.ObjectHeaderPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titlePress titlePress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the title is active and the user taps/clicks on it
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachTitlePress(sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:titlePress titlePress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader detachTitlePress(sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:titlePress titlePress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader fireTitlePress(sap.m.ObjectHeaderPressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:titlePress titlePress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader fireTitlePress();

				#endregion

				#region Methods for Event introPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:introPress introPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the intro is active and the user taps/clicks on it
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachIntroPress(object oData, sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:introPress introPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the intro is active and the user taps/clicks on it
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachIntroPress(object oData, sap.m.ObjectHeaderPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:introPress introPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the intro is active and the user taps/clicks on it
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachIntroPress(sap.m.ObjectHeaderPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:introPress introPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the intro is active and the user taps/clicks on it
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachIntroPress(sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:introPress introPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader detachIntroPress(sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:introPress introPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader fireIntroPress(sap.m.ObjectHeaderPressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:introPress introPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader fireIntroPress();

				#endregion

				#region Methods for Event iconPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconPress iconPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the title icon is active and the user taps/clicks on it
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachIconPress(object oData, sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconPress iconPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the title icon is active and the user taps/clicks on it
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachIconPress(object oData, sap.m.ObjectHeaderPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconPress iconPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the title icon is active and the user taps/clicks on it
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachIconPress(sap.m.ObjectHeaderPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconPress iconPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the title icon is active and the user taps/clicks on it
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachIconPress(sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:iconPress iconPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader detachIconPress(sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:iconPress iconPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader fireIconPress(sap.m.ObjectHeaderPressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:iconPress iconPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader fireIconPress();

				#endregion

				#region Methods for Event titleSelectorPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titleSelectorPress titleSelectorPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the object header title selector (down-arrow) is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachTitleSelectorPress(object oData, sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titleSelectorPress titleSelectorPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the object header title selector (down-arrow) is pressed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachTitleSelectorPress(object oData, sap.m.ObjectHeaderPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titleSelectorPress titleSelectorPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the object header title selector (down-arrow) is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachTitleSelectorPress(sap.m.ObjectHeaderPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titleSelectorPress titleSelectorPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectHeader</code> itself.
				/// 
				/// Event is fired when the object header title selector (down-arrow) is pressed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader attachTitleSelectorPress(sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:titleSelectorPress titleSelectorPress} event of this <code>sap.m.ObjectHeader</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader detachTitleSelectorPress(sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:titleSelectorPress titleSelectorPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader fireTitleSelectorPress(sap.m.ObjectHeaderPressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:titleSelectorPress titleSelectorPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectHeader fireTitleSelectorPress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ObjectHeader.
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
