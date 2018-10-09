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
			/// <code>sap.m.GroupHeaderListItem</code> is used to display the title of a group and act as separator between groups in <code>sap.m.List</code> and <code>sap.m.Table</code>. <b>Note:</b> The inherited properties <code>unread</code>, <code>selected</code>, <code>counter</code> and <code>press</code> event from <code>sap.m.ListItemBase</code> are not supported.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.GroupHeaderListItem")]
			public partial class GroupHeaderListItem : sap.m.ListItemBase
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
					/// Defines the title of the group header.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Defines the count of items in the group, but it could also be an amount which represents the sum of all amounts in the group. <b>Note:</b> Will not be displayed if not set.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> count;

					/// <summary>
					/// Allows to uppercase the group title.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> upperCase;

					/// <summary>
					/// Defines the title text directionality with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleTextDirection;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new GroupHeaderListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern GroupHeaderListItem(string sId, sap.m.GroupHeaderListItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new GroupHeaderListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				public extern GroupHeaderListItem(string sId);

				/// <summary>
				/// Constructor for a new GroupHeaderListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern GroupHeaderListItem();

				/// <summary>
				/// Constructor for a new GroupHeaderListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern GroupHeaderListItem(sap.m.GroupHeaderListItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Defines the title of the group header.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Defines the title of the group header.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GroupHeaderListItem setTitle(string sTitle);

				#endregion

				#region Methods for Property count

				/// <summary>
				/// Gets current value of property {@link #getCount count}.
				/// 
				/// Defines the count of items in the group, but it could also be an amount which represents the sum of all amounts in the group. <b>Note:</b> Will not be displayed if not set.
				/// </summary>
				/// <returns>Value of property <code>count</code></returns>
				public extern virtual string getCount();

				/// <summary>
				/// Sets a new value for property {@link #getCount count}.
				/// 
				/// Defines the count of items in the group, but it could also be an amount which represents the sum of all amounts in the group. <b>Note:</b> Will not be displayed if not set.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sCount">New value for property <code>count</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GroupHeaderListItem setCount(string sCount);

				#endregion

				#region Methods for Property upperCase

				/// <summary>
				/// Gets current value of property {@link #getUpperCase upperCase}.
				/// 
				/// Allows to uppercase the group title.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>upperCase</code></returns>
				[Obsolete("Deprecated since 1.40.10.")]
				public extern virtual bool getUpperCase();

				/// <summary>
				/// Sets a new value for property {@link #getUpperCase upperCase}.
				/// 
				/// Allows to uppercase the group title.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bUpperCase">New value for property <code>upperCase</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.40.10.")]
				public extern virtual sap.m.GroupHeaderListItem setUpperCase(bool bUpperCase);

				#endregion

				#region Methods for Property titleTextDirection

				/// <summary>
				/// Gets current value of property {@link #getTitleTextDirection titleTextDirection}.
				/// 
				/// Defines the title text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>titleTextDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTitleTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTitleTextDirection titleTextDirection}.
				/// 
				/// Defines the title text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTitleTextDirection">New value for property <code>titleTextDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GroupHeaderListItem setTitleTextDirection(sap.ui.core.TextDirection sTitleTextDirection);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.GroupHeaderListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.GroupHeaderListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.GroupHeaderListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.GroupHeaderListItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
