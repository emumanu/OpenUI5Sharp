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
			/// Represents a selectable item inside an IconTabBar.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.IconTabFilter")]
			public partial class IconTabFilter : sap.ui.core.Item, sap.m.IconTab, sap.ui.core.PopupInterface
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Item.Settings
				{
					/// <summary>
					/// Represents the "count" text, which is displayed in the tab filter.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> count;

					/// <summary>
					/// Enables special visualization for disabled filter (show all items). <b>Note:</b> You can use this property when you use <code>IconTabBar</code> as a filter. In order for it to be displayed correctly, the other tabs in the filter should consist of an icon, text and an optional count. It can be set to true for the first tab filter. You can find more detailed information in the {@link https://experience.sap.com/fiori-design-web/icontabbar/#tabs-as-filters UX Guidelines}.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showAll;

					/// <summary>
					/// Specifies the icon to be displayed for the tab filter.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// Specifies the icon color.
					/// 
					/// If an icon font is used, the color can be chosen from the icon colors (sap.ui.core.IconColor). Possible semantic colors are: Neutral, Positive, Critical, Negative. Instead of the semantic icon color the brand color can be used, this is named Default. Semantic colors and brand colors should not be mixed up inside one IconTabBar.
					/// </summary>
					public Union<sap.ui.core.IconColor, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconColor;

					/// <summary>
					/// If set to true, it sends one or more requests, trying to get the density perfect version of the image if this version of the image doesn't exist on the server. Default value is set to true.
					/// 
					/// If bandwidth is key for the application, set this value to false.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconDensityAware;

					/// <summary>
					/// Specifies whether the tab filter is rendered.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					/// <summary>
					/// Specifies whether the icon and the texts are placed vertically or horizontally.
					/// </summary>
					public Union<sap.m.IconTabFilterDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

					/// <summary>
					/// The content displayed for this item (optional).
					/// 
					/// If this content is set, it is displayed instead of the general content inside the IconTabBar.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new IconTabFilter.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern IconTabFilter(string sId, sap.m.IconTabFilter.Settings mSettings);

				/// <summary>
				/// Constructor for a new IconTabFilter.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				public extern IconTabFilter(string sId);

				/// <summary>
				/// Constructor for a new IconTabFilter.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern IconTabFilter();

				/// <summary>
				/// Constructor for a new IconTabFilter.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern IconTabFilter(sap.m.IconTabFilter.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property count

				/// <summary>
				/// Gets current value of property {@link #getCount count}.
				/// 
				/// Represents the "count" text, which is displayed in the tab filter.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>count</code></returns>
				public extern virtual string getCount();

				/// <summary>
				/// Sets a new value for property {@link #getCount count}.
				/// 
				/// Represents the "count" text, which is displayed in the tab filter.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sCount">New value for property <code>count</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabFilter setCount(string sCount);

				#endregion

				#region Methods for Property showAll

				/// <summary>
				/// Gets current value of property {@link #getShowAll showAll}.
				/// 
				/// Enables special visualization for disabled filter (show all items). <b>Note:</b> You can use this property when you use <code>IconTabBar</code> as a filter. In order for it to be displayed correctly, the other tabs in the filter should consist of an icon, text and an optional count. It can be set to true for the first tab filter. You can find more detailed information in the {@link https://experience.sap.com/fiori-design-web/icontabbar/#tabs-as-filters UX Guidelines}.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showAll</code></returns>
				public extern virtual bool getShowAll();

				/// <summary>
				/// Sets a new value for property {@link #getShowAll showAll}.
				/// 
				/// Enables special visualization for disabled filter (show all items). <b>Note:</b> You can use this property when you use <code>IconTabBar</code> as a filter. In order for it to be displayed correctly, the other tabs in the filter should consist of an icon, text and an optional count. It can be set to true for the first tab filter. You can find more detailed information in the {@link https://experience.sap.com/fiori-design-web/icontabbar/#tabs-as-filters UX Guidelines}.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowAll">New value for property <code>showAll</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabFilter setShowAll(bool bShowAll);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Specifies the icon to be displayed for the tab filter.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Specifies the icon to be displayed for the tab filter.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabFilter setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property iconColor

				/// <summary>
				/// Gets current value of property {@link #getIconColor iconColor}.
				/// 
				/// Specifies the icon color.
				/// 
				/// If an icon font is used, the color can be chosen from the icon colors (sap.ui.core.IconColor). Possible semantic colors are: Neutral, Positive, Critical, Negative. Instead of the semantic icon color the brand color can be used, this is named Default. Semantic colors and brand colors should not be mixed up inside one IconTabBar.
				/// 
				/// Default value is <code>Default</code>.
				/// </summary>
				/// <returns>Value of property <code>iconColor</code></returns>
				public extern virtual sap.ui.core.IconColor getIconColor();

				/// <summary>
				/// Sets a new value for property {@link #getIconColor iconColor}.
				/// 
				/// Specifies the icon color.
				/// 
				/// If an icon font is used, the color can be chosen from the icon colors (sap.ui.core.IconColor). Possible semantic colors are: Neutral, Positive, Critical, Negative. Instead of the semantic icon color the brand color can be used, this is named Default. Semantic colors and brand colors should not be mixed up inside one IconTabBar.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Default</code>.
				/// </summary>
				/// <param name="sIconColor">New value for property <code>iconColor</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabFilter setIconColor(sap.ui.core.IconColor sIconColor);

				#endregion

				#region Methods for Property iconDensityAware

				/// <summary>
				/// Gets current value of property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// If set to true, it sends one or more requests, trying to get the density perfect version of the image if this version of the image doesn't exist on the server. Default value is set to true.
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
				/// If set to true, it sends one or more requests, trying to get the density perfect version of the image if this version of the image doesn't exist on the server. Default value is set to true.
				/// 
				/// If bandwidth is key for the application, set this value to false.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIconDensityAware">New value for property <code>iconDensityAware</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabFilter setIconDensityAware(bool bIconDensityAware);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Specifies whether the tab filter is rendered.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern virtual bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Specifies whether the tab filter is rendered.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabFilter setVisible(bool bVisible);

				#endregion

				#region Methods for Property design

				/// <summary>
				/// Gets current value of property {@link #getDesign design}.
				/// 
				/// Specifies whether the icon and the texts are placed vertically or horizontally.
				/// 
				/// Default value is <code>Vertical</code>.
				/// </summary>
				/// <returns>Value of property <code>design</code></returns>
				public extern virtual sap.m.IconTabFilterDesign getDesign();

				/// <summary>
				/// Sets a new value for property {@link #getDesign design}.
				/// 
				/// Specifies whether the icon and the texts are placed vertically or horizontally.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Vertical</code>.
				/// </summary>
				/// <param name="sDesign">New value for property <code>design</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabFilter setDesign(sap.m.IconTabFilterDesign sDesign);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// The content displayed for this item (optional).
				/// 
				/// If this content is set, it is displayed instead of the general content inside the IconTabBar.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabFilter destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabFilter insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabFilter addContent(sap.ui.core.Control oContent);

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

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.IconTabFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.IconTabFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.IconTabFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.IconTabFilter.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Renders this item in the IconTabHeader.
				/// </summary>
				/// <param name="rm">the RenderManager that can be used for writing to the render output buffer</param>
				/// <param name="visibleIndex">the visible index within the parent control</param>
				/// <param name="visibleItemsCount">the visible items count</param>
				public extern virtual void render(sap.ui.core.RenderManager rm, int visibleIndex, int visibleItemsCount);

				/// <summary>
				/// Renders this item in the IconTabSelectList.
				/// </summary>
				/// <param name="rm">the RenderManager that can be used for writing to the render output buffer</param>
				/// <param name="selectList">the select list in which this filter is rendered</param>
				/// <param name="visibleIndex">the visible index within the parent control</param>
				/// <param name="visibleItemsCount">the visible items count</param>
				public extern virtual void renderInSelectList(sap.ui.core.RenderManager rm, sap.m.IconTabBarSelectList selectList, int visibleIndex, int visibleItemsCount);

				#endregion

				#endregion

			}
		}
	}
}
