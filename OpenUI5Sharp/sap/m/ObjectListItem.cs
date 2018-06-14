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
			/// ObjectListItem is a display control that provides summary information about an object as a list item. The ObjectListItem title is the key identifier of the object. Additional text and icons can be used to further distinguish it from other objects. Attributes and statuses can be used to provide additional meaning about the object to the user.
			/// 
			/// <b>Note:</b> The control must only be used in the context of a list.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class ObjectListItem : sap.m.ListItemBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ListItemBase.Settings
				{
					/// <summary>
					/// Defines the ObjectListItem title.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

					/// <summary>
					/// Defines the ObjectListItem number.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> number;

					/// <summary>
					/// Defines the number units qualifier of the ObjectListItem.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> numberUnit;

					/// <summary>
					/// Defines the introductory text for the ObjectListItem.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> intro;

					/// <summary>
					/// ObjectListItem icon displayed to the left of the title.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> icon;

					/// <summary>
					/// Icon displayed when the ObjectListItem is active.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> activeIcon;

					/// <summary>
					/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image (in case this version of image doesn't exist on the server).
					/// 
					/// If bandwidth is key for the application, set this value to false.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> iconDensityAware;

					/// <summary>
					/// Sets the favorite state for the ObjectListItem.<br><br>
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> markFavorite;

					/// <summary>
					/// Sets the flagged state for the ObjectListItem.<br><br>
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> markFlagged;

					/// <summary>
					/// If set to true, the ObjectListItem can be marked with icons such as favorite and flag.<br><br>
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showMarkers;

					/// <summary>
					/// Defines the ObjectListItem number and numberUnit value state.
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> numberState;

					/// <summary>
					/// Determines the text direction of the item title. Available options for the title direction are LTR (left-to-right) and RTL (right-to-left). By default the item title inherits the text direction from its parent.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> titleTextDirection;

					/// <summary>
					/// Determines the text direction of the item intro. Available options for the intro direction are LTR (left-to-right) and RTL (right-to-left). By default the item intro inherits the text direction from its parent.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> introTextDirection;

					/// <summary>
					/// Determines the text direction of the item number. Available options for the number direction are LTR (left-to-right) and RTL (right-to-left). By default the item number inherits the text direction from its parent.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> numberTextDirection;

					/// <summary>
					/// Sets the locked state of the ObjectListItem.<br><br>
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> markLocked;

					/// <summary>
					/// List of attributes displayed below the title to the left of the status fields.
					/// </summary>
					public Union<sap.m.ObjectAttribute[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> attributes;

					/// <summary>
					/// First status text field displayed on the right side of the attributes.
					/// </summary>
					public Union<sap.m.ObjectStatus, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> firstStatus;

					/// <summary>
					/// Second status text field displayed on the right side of the attributes.
					/// </summary>
					public Union<sap.m.ObjectStatus, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> secondStatus;

					/// <summary>
					/// List of markers (icon and/or text) that can be displayed for the <code>ObjectListItems</code>, such as favorite and flagged.<br><br> <b>Note:</b> You should use either this aggregation or the already deprecated properties - <code>markFlagged</code>, <code>markFavorite</code>, and <code>markLocked</code>. Using both can lead to unexpected results.
					/// </summary>
					public Union<sap.m.ObjectMarker[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> markers;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ObjectListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectListItem(string sId, sap.m.ObjectListItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new ObjectListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectListItem(string sId);

				/// <summary>
				/// Constructor for a new ObjectListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectListItem();

				/// <summary>
				/// Constructor for a new ObjectListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectListItem(sap.m.ObjectListItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Defines the ObjectListItem title.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Defines the ObjectListItem title.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setTitle(string sTitle);

				#endregion

				#region Methods for Property number

				/// <summary>
				/// Gets current value of property {@link #getNumber number}.
				/// 
				/// Defines the ObjectListItem number.
				/// </summary>
				/// <returns>Value of property <code>number</code></returns>
				public extern virtual string getNumber();

				/// <summary>
				/// Sets a new value for property {@link #getNumber number}.
				/// 
				/// Defines the ObjectListItem number.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sNumber">New value for property <code>number</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setNumber(string sNumber);

				#endregion

				#region Methods for Property numberUnit

				/// <summary>
				/// Gets current value of property {@link #getNumberUnit numberUnit}.
				/// 
				/// Defines the number units qualifier of the ObjectListItem.
				/// </summary>
				/// <returns>Value of property <code>numberUnit</code></returns>
				public extern virtual string getNumberUnit();

				/// <summary>
				/// Sets a new value for property {@link #getNumberUnit numberUnit}.
				/// 
				/// Defines the number units qualifier of the ObjectListItem.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sNumberUnit">New value for property <code>numberUnit</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setNumberUnit(string sNumberUnit);

				#endregion

				#region Methods for Property intro

				/// <summary>
				/// Gets current value of property {@link #getIntro intro}.
				/// 
				/// Defines the introductory text for the ObjectListItem.
				/// </summary>
				/// <returns>Value of property <code>intro</code></returns>
				public extern virtual string getIntro();

				/// <summary>
				/// Sets a new value for property {@link #getIntro intro}.
				/// 
				/// Defines the introductory text for the ObjectListItem.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIntro">New value for property <code>intro</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setIntro(string sIntro);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// ObjectListItem icon displayed to the left of the title.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// ObjectListItem icon displayed to the left of the title.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property activeIcon

				/// <summary>
				/// Gets current value of property {@link #getActiveIcon activeIcon}.
				/// 
				/// Icon displayed when the ObjectListItem is active.
				/// </summary>
				/// <returns>Value of property <code>activeIcon</code></returns>
				public extern virtual sap.ui.core.URI getActiveIcon();

				/// <summary>
				/// Sets a new value for property {@link #getActiveIcon activeIcon}.
				/// 
				/// Icon displayed when the ObjectListItem is active.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sActiveIcon">New value for property <code>activeIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setActiveIcon(sap.ui.core.URI sActiveIcon);

				#endregion

				#region Methods for Property iconDensityAware

				/// <summary>
				/// Gets current value of property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image (in case this version of image doesn't exist on the server).
				/// 
				/// If bandwidth is key for the application, set this value to false.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>iconDensityAware</code></returns>
				public extern virtual bool getIconDensityAware();

				/// <summary>
				/// Sets a new value for property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image (in case this version of image doesn't exist on the server).
				/// 
				/// If bandwidth is key for the application, set this value to false.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIconDensityAware">New value for property <code>iconDensityAware</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setIconDensityAware(bool bIconDensityAware);

				#endregion

				#region Methods for Property markFavorite

				/// <summary>
				/// Gets current value of property {@link #getMarkFavorite markFavorite}.
				/// 
				/// Sets the favorite state for the ObjectListItem.<br><br>
				/// </summary>
				[Obsolete("Deprecated since 1.42.0. replaced by <code>markers</code> aggregation. Add {@link sap.m.ObjectMarker} with type <code>sap.m.ObjectMarkerType.Favorite</code>. You should use either this property or the <code>markers</code> aggregation, using both may lead to unpredicted behavior.")]
				/// <returns>Value of property <code>markFavorite</code></returns>
				public extern virtual bool getMarkFavorite();

				/// <summary>
				/// Sets the visibility value of the Favorite marker.
				/// </summary>
				/// <param name="bMarked">the new value</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectListItem setMarkFavorite(bool bMarked);

				#endregion

				#region Methods for Property markFlagged

				/// <summary>
				/// Gets current value of property {@link #getMarkFlagged markFlagged}.
				/// 
				/// Sets the flagged state for the ObjectListItem.<br><br>
				/// </summary>
				[Obsolete("Deprecated since 1.42.0. replaced by <code>markers</code> aggregation. Add {@link sap.m.ObjectMarker} with type <code>sap.m.ObjectMarkerType.Flagged</code>. You should use either this property or the <code>markers</code> aggregation, using both may lead to unpredicted behavior.")]
				/// <returns>Value of property <code>markFlagged</code></returns>
				public extern virtual bool getMarkFlagged();

				/// <summary>
				/// Sets the visibility value of the Flagged marker.
				/// </summary>
				/// <param name="bMarked">the new value</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectListItem setMarkFlagged(bool bMarked);

				#endregion

				#region Methods for Property showMarkers

				/// <summary>
				/// Gets current value of property {@link #getShowMarkers showMarkers}.
				/// 
				/// If set to true, the ObjectListItem can be marked with icons such as favorite and flag.<br><br>
				/// </summary>
				[Obsolete("Deprecated since 1.42.0. replaced by <code>markers</code> aggregation. This property is valid only if you are using the already deprecated properties - <code>markFlagged</code>, <code>markFavorite</code>, and <code>markLocked</code>. If you are using the <code>markers</code> aggregation, the visibility of the markers depends on what is set in the aggregation itself.")]
				/// <returns>Value of property <code>showMarkers</code></returns>
				public extern virtual bool getShowMarkers();

				/// <summary>
				/// Sets the visibility value of the Flagged and Favorite markers.
				/// </summary>
				/// <param name="bMarked">the new value</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectListItem setShowMarkers(bool bMarked);

				#endregion

				#region Methods for Property numberState

				/// <summary>
				/// Gets current value of property {@link #getNumberState numberState}.
				/// 
				/// Defines the ObjectListItem number and numberUnit value state.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>numberState</code></returns>
				public extern virtual sap.ui.core.ValueState getNumberState();

				/// <summary>
				/// Sets a new value for property {@link #getNumberState numberState}.
				/// 
				/// Defines the ObjectListItem number and numberUnit value state.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sNumberState">New value for property <code>numberState</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setNumberState(sap.ui.core.ValueState sNumberState);

				#endregion

				#region Methods for Property titleTextDirection

				/// <summary>
				/// Gets current value of property {@link #getTitleTextDirection titleTextDirection}.
				/// 
				/// Determines the text direction of the item title. Available options for the title direction are LTR (left-to-right) and RTL (right-to-left). By default the item title inherits the text direction from its parent.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>titleTextDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTitleTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTitleTextDirection titleTextDirection}.
				/// 
				/// Determines the text direction of the item title. Available options for the title direction are LTR (left-to-right) and RTL (right-to-left). By default the item title inherits the text direction from its parent.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTitleTextDirection">New value for property <code>titleTextDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setTitleTextDirection(sap.ui.core.TextDirection sTitleTextDirection);

				#endregion

				#region Methods for Property introTextDirection

				/// <summary>
				/// Gets current value of property {@link #getIntroTextDirection introTextDirection}.
				/// 
				/// Determines the text direction of the item intro. Available options for the intro direction are LTR (left-to-right) and RTL (right-to-left). By default the item intro inherits the text direction from its parent.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>introTextDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getIntroTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getIntroTextDirection introTextDirection}.
				/// 
				/// Determines the text direction of the item intro. Available options for the intro direction are LTR (left-to-right) and RTL (right-to-left). By default the item intro inherits the text direction from its parent.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sIntroTextDirection">New value for property <code>introTextDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setIntroTextDirection(sap.ui.core.TextDirection sIntroTextDirection);

				#endregion

				#region Methods for Property numberTextDirection

				/// <summary>
				/// Gets current value of property {@link #getNumberTextDirection numberTextDirection}.
				/// 
				/// Determines the text direction of the item number. Available options for the number direction are LTR (left-to-right) and RTL (right-to-left). By default the item number inherits the text direction from its parent.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>numberTextDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getNumberTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getNumberTextDirection numberTextDirection}.
				/// 
				/// Determines the text direction of the item number. Available options for the number direction are LTR (left-to-right) and RTL (right-to-left). By default the item number inherits the text direction from its parent.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sNumberTextDirection">New value for property <code>numberTextDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setNumberTextDirection(sap.ui.core.TextDirection sNumberTextDirection);

				#endregion

				#region Methods for Property markLocked

				/// <summary>
				/// Gets current value of property {@link #getMarkLocked markLocked}.
				/// 
				/// Sets the locked state of the ObjectListItem.<br><br>
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.42.0. replaced by <code>markers</code> aggregation. Add {@link sap.m.ObjectMarker} with type <code>sap.m.ObjectMarkerType.Locked</code>. You should use either this property or the <code>markers</code> aggregation, using both may lead to unpredicted behavior.<br><br>")]
				/// <returns>Value of property <code>markLocked</code></returns>
				public extern virtual bool getMarkLocked();

				/// <summary>
				/// Sets the visibility value of the Favorite marker.
				/// </summary>
				/// <param name="bMarked">the new value</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ObjectListItem setMarkLocked(bool bMarked);

				#endregion

				#region Methods for Aggregation attributes

				/// <summary>
				/// Gets content of aggregation {@link #getAttributes attributes}.
				/// 
				/// List of attributes displayed below the title to the left of the status fields.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ObjectAttribute[] getAttributes();

				/// <summary>
				/// Destroys all the attributes in the aggregation {@link #getAttributes attributes}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem destroyAttributes();

				/// <summary>
				/// Inserts a attribute into the aggregation {@link #getAttributes attributes}.
				/// </summary>
				/// <param name="oAttribute">The attribute to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the attribute should be inserted at; for a negative value of <code>iIndex</code>, the attribute is inserted at position 0; for a value greater than the current size of the aggregation, the attribute is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem insertAttribute(sap.m.ObjectAttribute oAttribute, int iIndex);

				/// <summary>
				/// Adds some attribute to the aggregation {@link #getAttributes attributes}.
				/// </summary>
				/// <param name="oAttribute">The attribute to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem addAttribute(sap.m.ObjectAttribute oAttribute);

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
				/// First status text field displayed on the right side of the attributes.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ObjectStatus getFirstStatus();

				/// <summary>
				/// Destroys the firstStatus in the aggregation {@link #getFirstStatus firstStatus}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem destroyFirstStatus();

				/// <summary>
				/// Sets the aggregated {@link #getFirstStatus firstStatus}.
				/// </summary>
				/// <param name="oFirstStatus">The firstStatus to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setFirstStatus(sap.m.ObjectStatus oFirstStatus);

				#endregion

				#region Methods for Aggregation secondStatus

				/// <summary>
				/// Gets content of aggregation {@link #getSecondStatus secondStatus}.
				/// 
				/// Second status text field displayed on the right side of the attributes.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ObjectStatus getSecondStatus();

				/// <summary>
				/// Destroys the secondStatus in the aggregation {@link #getSecondStatus secondStatus}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem destroySecondStatus();

				/// <summary>
				/// Sets the aggregated {@link #getSecondStatus secondStatus}.
				/// </summary>
				/// <param name="oSecondStatus">The secondStatus to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem setSecondStatus(sap.m.ObjectStatus oSecondStatus);

				#endregion

				#region Methods for Aggregation markers

				/// <summary>
				/// Gets content of aggregation {@link #getMarkers markers}.
				/// 
				/// List of markers (icon and/or text) that can be displayed for the <code>ObjectListItems</code>, such as favorite and flagged.<br><br> <b>Note:</b> You should use either this aggregation or the already deprecated properties - <code>markFlagged</code>, <code>markFavorite</code>, and <code>markLocked</code>. Using both can lead to unexpected results.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ObjectMarker[] getMarkers();

				/// <summary>
				/// Destroys all the markers in the aggregation {@link #getMarkers markers}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem destroyMarkers();

				/// <summary>
				/// Inserts a marker into the aggregation {@link #getMarkers markers}.
				/// </summary>
				/// <param name="oMarker">The marker to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the marker should be inserted at; for a negative value of <code>iIndex</code>, the marker is inserted at position 0; for a value greater than the current size of the aggregation, the marker is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem insertMarker(sap.m.ObjectMarker oMarker, int iIndex);

				/// <summary>
				/// Adds some marker to the aggregation {@link #getMarkers markers}.
				/// </summary>
				/// <param name="oMarker">The marker to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectListItem addMarker(sap.m.ObjectMarker oMarker);

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

				#region Methods for Aggregation _objectNumber

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ObjectListItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
