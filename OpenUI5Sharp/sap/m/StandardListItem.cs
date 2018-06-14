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
			/// <code>sap.m.StandardListItem</code> is a list item providing the most common use cases, e.g. image, title and description.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class StandardListItem : sap.m.ListItemBase
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
					/// Defines the title of the list item.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

					/// <summary>
					/// Defines the additional information for the title. <b>Note:</b> This is only visible when the <code>title</code> property is not empty.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> description;

					/// <summary>
					/// Defines the list item icon.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> icon;

					/// <summary>
					/// Defines the indentation of the icon. If set to <code>false</code>, the icon will not be shown as embedded. Instead it will take the full height of the list item.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> iconInset;

					/// <summary>
					/// By default, one or more requests are sent to get the density perfect version of the icon if the given version of the icon doesn't exist on the server. <b>Note:</b> If bandwidth is a key factor for the application, set this value to <code>false</code>.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> iconDensityAware;

					/// <summary>
					/// Defines the icon that is shown while the list item is pressed.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> activeIcon;

					/// <summary>
					/// Defines an additional information text.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> info;

					/// <summary>
					/// Defines the state of the information text, e.g. <code>Error</code>, <code>Warning</code>, <code>Success</code>.
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> infoState;

					/// <summary>
					/// By default, the title size adapts to the available space and gets bigger if the description is empty. If you have list items with and without descriptions, this results in titles with different sizes. In this case, it can be better to switch the size adaption off by setting this property to <code>false</code>.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> adaptTitleSize;

					/// <summary>
					/// Defines the <code>title</code> text directionality with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> titleTextDirection;

					/// <summary>
					/// Defines the <code>info</code> directionality with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> infoTextDirection;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new StandardListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern StandardListItem(string sId, sap.m.StandardListItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new StandardListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				public extern StandardListItem(string sId);

				/// <summary>
				/// Constructor for a new StandardListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern StandardListItem();

				/// <summary>
				/// Constructor for a new StandardListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern StandardListItem(sap.m.StandardListItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Defines the title of the list item.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Defines the title of the list item.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StandardListItem setTitle(string sTitle);

				#endregion

				#region Methods for Property description

				/// <summary>
				/// Gets current value of property {@link #getDescription description}.
				/// 
				/// Defines the additional information for the title. <b>Note:</b> This is only visible when the <code>title</code> property is not empty.
				/// </summary>
				/// <returns>Value of property <code>description</code></returns>
				public extern virtual string getDescription();

				/// <summary>
				/// Sets a new value for property {@link #getDescription description}.
				/// 
				/// Defines the additional information for the title. <b>Note:</b> This is only visible when the <code>title</code> property is not empty.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDescription">New value for property <code>description</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StandardListItem setDescription(string sDescription);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Defines the list item icon.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Defines the list item icon.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StandardListItem setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property iconInset

				/// <summary>
				/// Gets current value of property {@link #getIconInset iconInset}.
				/// 
				/// Defines the indentation of the icon. If set to <code>false</code>, the icon will not be shown as embedded. Instead it will take the full height of the list item.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>iconInset</code></returns>
				public extern virtual bool getIconInset();

				/// <summary>
				/// Sets a new value for property {@link #getIconInset iconInset}.
				/// 
				/// Defines the indentation of the icon. If set to <code>false</code>, the icon will not be shown as embedded. Instead it will take the full height of the list item.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIconInset">New value for property <code>iconInset</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StandardListItem setIconInset(bool bIconInset);

				#endregion

				#region Methods for Property iconDensityAware

				/// <summary>
				/// Gets current value of property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// By default, one or more requests are sent to get the density perfect version of the icon if the given version of the icon doesn't exist on the server. <b>Note:</b> If bandwidth is a key factor for the application, set this value to <code>false</code>.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>iconDensityAware</code></returns>
				public extern virtual bool getIconDensityAware();

				/// <summary>
				/// Sets a new value for property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// By default, one or more requests are sent to get the density perfect version of the icon if the given version of the icon doesn't exist on the server. <b>Note:</b> If bandwidth is a key factor for the application, set this value to <code>false</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIconDensityAware">New value for property <code>iconDensityAware</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StandardListItem setIconDensityAware(bool bIconDensityAware);

				#endregion

				#region Methods for Property activeIcon

				/// <summary>
				/// Gets current value of property {@link #getActiveIcon activeIcon}.
				/// 
				/// Defines the icon that is shown while the list item is pressed.
				/// </summary>
				/// <returns>Value of property <code>activeIcon</code></returns>
				public extern virtual sap.ui.core.URI getActiveIcon();

				/// <summary>
				/// Sets a new value for property {@link #getActiveIcon activeIcon}.
				/// 
				/// Defines the icon that is shown while the list item is pressed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sActiveIcon">New value for property <code>activeIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StandardListItem setActiveIcon(sap.ui.core.URI sActiveIcon);

				#endregion

				#region Methods for Property info

				/// <summary>
				/// Gets current value of property {@link #getInfo info}.
				/// 
				/// Defines an additional information text.
				/// </summary>
				/// <returns>Value of property <code>info</code></returns>
				public extern virtual string getInfo();

				/// <summary>
				/// Sets a new value for property {@link #getInfo info}.
				/// 
				/// Defines an additional information text.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sInfo">New value for property <code>info</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StandardListItem setInfo(string sInfo);

				#endregion

				#region Methods for Property infoState

				/// <summary>
				/// Gets current value of property {@link #getInfoState infoState}.
				/// 
				/// Defines the state of the information text, e.g. <code>Error</code>, <code>Warning</code>, <code>Success</code>.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>infoState</code></returns>
				public extern virtual sap.ui.core.ValueState getInfoState();

				/// <summary>
				/// Sets a new value for property {@link #getInfoState infoState}.
				/// 
				/// Defines the state of the information text, e.g. <code>Error</code>, <code>Warning</code>, <code>Success</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sInfoState">New value for property <code>infoState</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StandardListItem setInfoState(sap.ui.core.ValueState sInfoState);

				#endregion

				#region Methods for Property adaptTitleSize

				/// <summary>
				/// Gets current value of property {@link #getAdaptTitleSize adaptTitleSize}.
				/// 
				/// By default, the title size adapts to the available space and gets bigger if the description is empty. If you have list items with and without descriptions, this results in titles with different sizes. In this case, it can be better to switch the size adaption off by setting this property to <code>false</code>.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>adaptTitleSize</code></returns>
				public extern virtual bool getAdaptTitleSize();

				/// <summary>
				/// Sets a new value for property {@link #getAdaptTitleSize adaptTitleSize}.
				/// 
				/// By default, the title size adapts to the available space and gets bigger if the description is empty. If you have list items with and without descriptions, this results in titles with different sizes. In this case, it can be better to switch the size adaption off by setting this property to <code>false</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bAdaptTitleSize">New value for property <code>adaptTitleSize</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StandardListItem setAdaptTitleSize(bool bAdaptTitleSize);

				#endregion

				#region Methods for Property titleTextDirection

				/// <summary>
				/// Gets current value of property {@link #getTitleTextDirection titleTextDirection}.
				/// 
				/// Defines the <code>title</code> text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>titleTextDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTitleTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTitleTextDirection titleTextDirection}.
				/// 
				/// Defines the <code>title</code> text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTitleTextDirection">New value for property <code>titleTextDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StandardListItem setTitleTextDirection(sap.ui.core.TextDirection sTitleTextDirection);

				#endregion

				#region Methods for Property infoTextDirection

				/// <summary>
				/// Gets current value of property {@link #getInfoTextDirection infoTextDirection}.
				/// 
				/// Defines the <code>info</code> directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>infoTextDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getInfoTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getInfoTextDirection infoTextDirection}.
				/// 
				/// Defines the <code>info</code> directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sInfoTextDirection">New value for property <code>infoTextDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.StandardListItem setInfoTextDirection(sap.ui.core.TextDirection sInfoTextDirection);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.StandardListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.StandardListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.StandardListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.StandardListItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
