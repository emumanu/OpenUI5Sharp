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
			/// QuickViewPage consists of a page header, an object icon or image, an object name with short description, and an object information divided in groups. The control uses the sap.m.SimpleForm control to display information.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.QuickViewPage")]
			public partial class QuickViewPage : sap.ui.core.Control
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
					/// Page id
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> pageId;

					/// <summary>
					/// Specifies the text displayed in the header of the control.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> header;

					/// <summary>
					/// Specifies the text displayed in the header of the content section of the control.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Specifies the URL which opens when the title or the thumbnail is clicked.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleUrl;

					/// <summary>
					/// Specifies the application which provides target and param configuration for cross-application navigation from the 'page header'.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> crossAppNavCallback;

					/// <summary>
					/// Specifies the text displayed under the header of the content section
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> description;

					/// <summary>
					/// Specifies the URL of the icon displayed under the header of the page
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// QuickViewGroup consists of a title (optional) and an entity of group elements.
					/// </summary>
					public Union<sap.m.QuickViewGroup[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> groups;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new QuickViewPage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickViewPage(string sId, sap.m.QuickViewPage.Settings mSettings);

				/// <summary>
				/// Constructor for a new QuickViewPage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern QuickViewPage(string sId);

				/// <summary>
				/// Constructor for a new QuickViewPage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern QuickViewPage();

				/// <summary>
				/// Constructor for a new QuickViewPage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickViewPage(sap.m.QuickViewPage.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property pageId

				/// <summary>
				/// Gets current value of property {@link #getPageId pageId}.
				/// 
				/// Page id
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>pageId</code></returns>
				public extern virtual string getPageId();

				/// <summary>
				/// Sets a new value for property {@link #getPageId pageId}.
				/// 
				/// Page id
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sPageId">New value for property <code>pageId</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage setPageId(string sPageId);

				#endregion

				#region Methods for Property header

				/// <summary>
				/// Gets current value of property {@link #getHeader header}.
				/// 
				/// Specifies the text displayed in the header of the control.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>header</code></returns>
				public extern virtual string getHeader();

				/// <summary>
				/// Sets a new value for property {@link #getHeader header}.
				/// 
				/// Specifies the text displayed in the header of the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sHeader">New value for property <code>header</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage setHeader(string sHeader);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Specifies the text displayed in the header of the content section of the control.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Specifies the text displayed in the header of the content section of the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage setTitle(string sTitle);

				#endregion

				#region Methods for Property titleUrl

				/// <summary>
				/// Gets current value of property {@link #getTitleUrl titleUrl}.
				/// 
				/// Specifies the URL which opens when the title or the thumbnail is clicked.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>titleUrl</code></returns>
				public extern virtual string getTitleUrl();

				/// <summary>
				/// Sets a new value for property {@link #getTitleUrl titleUrl}.
				/// 
				/// Specifies the URL which opens when the title or the thumbnail is clicked.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sTitleUrl">New value for property <code>titleUrl</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage setTitleUrl(string sTitleUrl);

				#endregion

				#region Methods for Property crossAppNavCallback

				/// <summary>
				/// Gets current value of property {@link #getCrossAppNavCallback crossAppNavCallback}.
				/// 
				/// Specifies the application which provides target and param configuration for cross-application navigation from the 'page header'.
				/// </summary>
				/// <returns>Value of property <code>crossAppNavCallback</code></returns>
				public extern virtual object getCrossAppNavCallback();

				/// <summary>
				/// Sets a new value for property {@link #getCrossAppNavCallback crossAppNavCallback}.
				/// 
				/// Specifies the application which provides target and param configuration for cross-application navigation from the 'page header'.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oCrossAppNavCallback">New value for property <code>crossAppNavCallback</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage setCrossAppNavCallback(object oCrossAppNavCallback);

				#endregion

				#region Methods for Property description

				/// <summary>
				/// Gets current value of property {@link #getDescription description}.
				/// 
				/// Specifies the text displayed under the header of the content section
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>description</code></returns>
				public extern virtual string getDescription();

				/// <summary>
				/// Sets a new value for property {@link #getDescription description}.
				/// 
				/// Specifies the text displayed under the header of the content section
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sDescription">New value for property <code>description</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage setDescription(string sDescription);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Specifies the URL of the icon displayed under the header of the page
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual string getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Specifies the URL of the icon displayed under the header of the page
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage setIcon(string sIcon);

				#endregion

				#region Methods for Aggregation groups

				/// <summary>
				/// Gets content of aggregation {@link #getGroups groups}.
				/// 
				/// QuickViewGroup consists of a title (optional) and an entity of group elements.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.QuickViewGroup[] getGroups();

				/// <summary>
				/// Destroys all the groups in the aggregation {@link #getGroups groups}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage destroyGroups();

				/// <summary>
				/// Inserts a group into the aggregation {@link #getGroups groups}.
				/// </summary>
				/// <param name="oGroup">The group to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the group should be inserted at; for a negative value of <code>iIndex</code>, the group is inserted at position 0; for a value greater than the current size of the aggregation, the group is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage insertGroup(sap.m.QuickViewGroup oGroup, int iIndex);

				/// <summary>
				/// Adds some group to the aggregation {@link #getGroups groups}.
				/// </summary>
				/// <param name="oGroup">The group to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage addGroup(sap.m.QuickViewGroup oGroup);

				/// <summary>
				/// Removes a group from the aggregation {@link #getGroups groups}.
				/// </summary>
				/// <param name="vGroup">The group to remove or its index or id</param>
				/// <returns>The removed group or <code>null</code></returns>
				public extern virtual sap.m.QuickViewGroup removeGroup(Union<int, string, sap.m.QuickViewGroup> vGroup);

				/// <summary>
				/// Checks for the provided <code>sap.m.QuickViewGroup</code> in the aggregation {@link #getGroups groups}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oGroup">The group whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfGroup(sap.m.QuickViewGroup oGroup);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getGroups groups}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.QuickViewGroup[] removeAllGroups();

				/// <summary>
				/// Binds aggregation {@link #getGroups groups} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage bindGroups(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getGroups groups} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewPage unbindGroups();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.QuickViewPage.
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
