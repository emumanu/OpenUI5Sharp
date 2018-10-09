using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// This element used to provide messages. Rendering must be done within the control that uses this kind of element.
				/// 
				/// Its default level is none.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Message")]
				public partial class Message : sap.ui.core.Element
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Element.Settings
					{
						/// <summary>
						/// Message text
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Message's timestamp. It is just a simple String that will be used without any transformation. So the application that uses messages needs to format the timestamp to its own needs.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> timestamp;

						/// <summary>
						/// A possible icon URI of the message
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Setting the message's level.
						/// </summary>
						public Union<sap.ui.core.MessageType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> level;

						/// <summary>
						/// Determines whether the message should be read only. This helps the application to handle a message a different way if the application differentiates between read-only and common messages.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> readOnly;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Message.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Message(string sId, sap.ui.core.Message.Settings mSettings);

					/// <summary>
					/// Constructor for a new Message.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Message(string sId);

					/// <summary>
					/// Constructor for a new Message.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Message();

					/// <summary>
					/// Constructor for a new Message.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Message(sap.ui.core.Message.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// Message text
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// Message text
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Message setText(string sText);

					#endregion

					#region Methods for Property timestamp

					/// <summary>
					/// Gets current value of property {@link #getTimestamp timestamp}.
					/// 
					/// Message's timestamp. It is just a simple String that will be used without any transformation. So the application that uses messages needs to format the timestamp to its own needs.
					/// </summary>
					/// <returns>Value of property <code>timestamp</code></returns>
					public extern virtual string getTimestamp();

					/// <summary>
					/// Sets a new value for property {@link #getTimestamp timestamp}.
					/// 
					/// Message's timestamp. It is just a simple String that will be used without any transformation. So the application that uses messages needs to format the timestamp to its own needs.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTimestamp">New value for property <code>timestamp</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Message setTimestamp(string sTimestamp);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// A possible icon URI of the message
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// A possible icon URI of the message
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Message setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property level

					/// <summary>
					/// Gets current value of property {@link #getLevel level}.
					/// 
					/// Setting the message's level.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>level</code></returns>
					public extern virtual sap.ui.core.MessageType getLevel();

					/// <summary>
					/// Sets a new value for property {@link #getLevel level}.
					/// 
					/// Setting the message's level.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sLevel">New value for property <code>level</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Message setLevel(sap.ui.core.MessageType sLevel);

					#endregion

					#region Methods for Property readOnly

					/// <summary>
					/// Gets current value of property {@link #getReadOnly readOnly}.
					/// 
					/// Determines whether the message should be read only. This helps the application to handle a message a different way if the application differentiates between read-only and common messages.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>readOnly</code></returns>
					public extern virtual bool getReadOnly();

					/// <summary>
					/// Sets a new value for property {@link #getReadOnly readOnly}.
					/// 
					/// Determines whether the message should be read only. This helps the application to handle a message a different way if the application differentiates between read-only and common messages.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bReadOnly">New value for property <code>readOnly</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Message setReadOnly(bool bReadOnly);

					#endregion

					#region Other methods

					/// <summary>
					/// Compares the given message with <code>this</code> message. The types of {@link sap.ui.core.MessageType} are ordered from "Error" > "Warning" > "Success" > "Information" > "None".
					/// 
					/// See {@link sap.ui.core.Message.compareByType}
					/// </summary>
					/// <param name="oOther">message to compare with this one</param>
					/// <returns>returns <code>0</code> if both messages are at the same level. <code>-1</code> if <code>this</code> message has a lower level. <code>1</code> if <code>this</code> message has a higher level.</returns>
					public extern virtual int compareByType(sap.ui.core.Message oOther);

					/// <summary>
					/// Compares two given messages with each other.
					/// 
					/// The types of {@link sap.ui.core.MessageType} are ordered from "Error" > "Warning" > "Success" > "Information" > "None".
					/// </summary>
					/// <param name="oMessage1">first message to compare</param>
					/// <param name="oMessage2">second message to compare</param>
					/// <returns>returns <code>0</code> if both messages are at the same level. <code>-1</code> if <code>this</code> message has a lower level. <code>1</code> if <code>this</code> message has a higher level.</returns>
					public extern static int compareByType(sap.ui.core.Message oMessage1, sap.ui.core.Message oMessage2);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Message with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Message with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Message with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the icon's default URI depending on given size.
					/// 
					/// There are default icons for messages available that can be used this way. If no parameter is given, the size will be 16x16 per default. If larger icons are needed, the parameter "32x32" might be given.
					/// </summary>
					/// <param name="sSize">If parameter is not set the default icon's size will be 16x16. If parameter is set to "32x32" the icon size will be 32x32.</param>
					/// <returns>URI of the default icon.</returns>
					public extern virtual sap.ui.core.URI getDefaultIcon(string sSize);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.Message.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
