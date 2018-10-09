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
			/// A wrapper control used to hold different types of system messages. <h3>Structure</h3> The message item holds the basic set of properties for a system message: <ul> <li> Type, title, subtitle and description </li> <li> If the description contains markup, the <code>markupDescription</code> needs to be set to true, to ensure it is interpreted correctly. </li> <li> If the long text description can be specified by a URL by setting, the <code>longtextUrl</code> property. </li> <li> The message item can have a single {@link sap.m.Link} after the description. It is stored in the <code>link</code> aggregation. </li> <h3>Usage</h3> <b>Note:</b> The MessageItem control replaces {@link sap.m.MessagePopoverItem} as a more generic wrapper for messages.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MessageItem")]
			public partial class MessageItem : sap.ui.core.Item
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
					/// Specifies the type of the message
					/// </summary>
					public Union<sap.ui.core.MessageType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					/// <summary>
					/// Specifies the title of the message
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Specifies the subtitle of the message <b>Note:</b> This is only visible when the <code>title</code> property is not empty.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> subtitle;

					/// <summary>
					/// Specifies detailed description of the message
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> description;

					/// <summary>
					/// Specifies if description should be interpreted as markup
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> markupDescription;

					/// <summary>
					/// Specifies long text description location URL
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> longtextUrl;

					/// <summary>
					/// Defines the number of messages for a given message.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> counter;

					/// <summary>
					/// Name of a message group the current item belongs to.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> groupName;

					/// <summary>
					/// Adds an sap.m.Link control which will be displayed at the end of the description of a message.
					/// </summary>
					public Union<sap.m.Link, string, sap.ui.@base.ManagedObject.BindAggregationInfo> link;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new MessageItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MessageItem(string sId, sap.m.MessageItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new MessageItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern MessageItem(string sId);

				/// <summary>
				/// Constructor for a new MessageItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern MessageItem();

				/// <summary>
				/// Constructor for a new MessageItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MessageItem(sap.m.MessageItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// Specifies the type of the message
				/// 
				/// Default value is <code>Error</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.ui.core.MessageType getType();

				/// <summary>
				/// Sets type of the MessageItem. <b>Note:</b> if you set the type to None it will be handled and rendered as Information.
				/// </summary>
				/// <param name="sType">Type of Message</param>
				/// <returns>The MessageItem</returns>
				public extern virtual sap.m.MessageItem setType(sap.ui.core.MessageType sType);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Specifies the title of the message
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Specifies the title of the message
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageItem setTitle(string sTitle);

				#endregion

				#region Methods for Property subtitle

				/// <summary>
				/// Gets current value of property {@link #getSubtitle subtitle}.
				/// 
				/// Specifies the subtitle of the message <b>Note:</b> This is only visible when the <code>title</code> property is not empty.
				/// </summary>
				/// <returns>Value of property <code>subtitle</code></returns>
				public extern virtual string getSubtitle();

				/// <summary>
				/// Sets a new value for property {@link #getSubtitle subtitle}.
				/// 
				/// Specifies the subtitle of the message <b>Note:</b> This is only visible when the <code>title</code> property is not empty.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sSubtitle">New value for property <code>subtitle</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageItem setSubtitle(string sSubtitle);

				#endregion

				#region Methods for Property description

				/// <summary>
				/// Gets current value of property {@link #getDescription description}.
				/// 
				/// Specifies detailed description of the message
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>description</code></returns>
				public extern virtual string getDescription();

				/// <summary>
				/// Sets a new value for property {@link #getDescription description}.
				/// 
				/// Specifies detailed description of the message
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sDescription">New value for property <code>description</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageItem setDescription(string sDescription);

				#endregion

				#region Methods for Property markupDescription

				/// <summary>
				/// Gets current value of property {@link #getMarkupDescription markupDescription}.
				/// 
				/// Specifies if description should be interpreted as markup
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>markupDescription</code></returns>
				public extern virtual bool getMarkupDescription();

				/// <summary>
				/// Sets a new value for property {@link #getMarkupDescription markupDescription}.
				/// 
				/// Specifies if description should be interpreted as markup
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bMarkupDescription">New value for property <code>markupDescription</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageItem setMarkupDescription(bool bMarkupDescription);

				#endregion

				#region Methods for Property longtextUrl

				/// <summary>
				/// Gets current value of property {@link #getLongtextUrl longtextUrl}.
				/// 
				/// Specifies long text description location URL
				/// </summary>
				/// <returns>Value of property <code>longtextUrl</code></returns>
				public extern virtual sap.ui.core.URI getLongtextUrl();

				/// <summary>
				/// Sets a new value for property {@link #getLongtextUrl longtextUrl}.
				/// 
				/// Specifies long text description location URL
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sLongtextUrl">New value for property <code>longtextUrl</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageItem setLongtextUrl(sap.ui.core.URI sLongtextUrl);

				#endregion

				#region Methods for Property counter

				/// <summary>
				/// Gets current value of property {@link #getCounter counter}.
				/// 
				/// Defines the number of messages for a given message.
				/// </summary>
				/// <returns>Value of property <code>counter</code></returns>
				public extern virtual int getCounter();

				/// <summary>
				/// Sets a new value for property {@link #getCounter counter}.
				/// 
				/// Defines the number of messages for a given message.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="iCounter">New value for property <code>counter</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageItem setCounter(int iCounter);

				#endregion

				#region Methods for Property groupName

				/// <summary>
				/// Gets current value of property {@link #getGroupName groupName}.
				/// 
				/// Name of a message group the current item belongs to.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>groupName</code></returns>
				public extern virtual string getGroupName();

				/// <summary>
				/// Sets a new value for property {@link #getGroupName groupName}.
				/// 
				/// Name of a message group the current item belongs to.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sGroupName">New value for property <code>groupName</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageItem setGroupName(string sGroupName);

				#endregion

				#region Methods for Aggregation link

				/// <summary>
				/// Gets content of aggregation {@link #getLink link}.
				/// 
				/// Adds an sap.m.Link control which will be displayed at the end of the description of a message.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Link getLink();

				/// <summary>
				/// Destroys the link in the aggregation {@link #getLink link}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageItem destroyLink();

				/// <summary>
				/// Sets the aggregated {@link #getLink link}.
				/// </summary>
				/// <param name="oLink">The link to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageItem setLink(sap.m.Link oLink);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.MessageItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessageItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessageItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.MessageItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
