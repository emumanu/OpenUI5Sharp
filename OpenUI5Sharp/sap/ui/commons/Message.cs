using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class commons
			{
				/// <summary>
				/// Creates the "Message"s to be supplied to the "MessageBar" Control.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Message")]
				[Obsolete("Deprecated since 1.4.0. A new messaging concept will be created in future. Therefore this control might be removed in one of the next versions.")]
				public partial class Message : sap.ui.core.Control
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
						/// "Success", or "Warning", or "Error" messages. (Mandatory)
						/// </summary>
						public Union<sap.ui.commons.MessageType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

						/// <summary>
						/// Message short text. (Mandatory)
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Associated UI element ID. (Optional) For navigation to error field.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> associatedElementId;

						/// <summary>
						/// Internal attribute, used to force the display of the "short" or the "long" text only.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

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
					public extern Message(string sId, sap.ui.commons.Message.Settings mSettings);

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
					public extern Message(sap.ui.commons.Message.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property type

					/// <summary>
					/// Gets current value of property {@link #getType type}.
					/// 
					/// "Success", or "Warning", or "Error" messages. (Mandatory)
					/// </summary>
					/// <returns>Value of property <code>type</code></returns>
					public extern virtual sap.ui.commons.MessageType getType();

					/// <summary>
					/// Sets a new value for property {@link #getType type}.
					/// 
					/// "Success", or "Warning", or "Error" messages. (Mandatory)
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sType">New value for property <code>type</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Message setType(sap.ui.commons.MessageType sType);

					#endregion

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// Message short text. (Mandatory)
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// Message short text. (Mandatory)
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Message setText(string sText);

					#endregion

					#region Methods for Property associatedElementId

					/// <summary>
					/// Gets current value of property {@link #getAssociatedElementId associatedElementId}.
					/// 
					/// Associated UI element ID. (Optional) For navigation to error field.
					/// </summary>
					/// <returns>Value of property <code>associatedElementId</code></returns>
					public extern virtual string getAssociatedElementId();

					/// <summary>
					/// Sets a new value for property {@link #getAssociatedElementId associatedElementId}.
					/// 
					/// Associated UI element ID. (Optional) For navigation to error field.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sAssociatedElementId">New value for property <code>associatedElementId</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Message setAssociatedElementId(string sAssociatedElementId);

					#endregion

					#region Methods for Property design

					/// <summary>
					/// Gets current value of property {@link #getDesign design}.
					/// 
					/// Internal attribute, used to force the display of the "short" or the "long" text only.
					/// </summary>
					/// <returns>Value of property <code>design</code></returns>
					public extern virtual string getDesign();

					/// <summary>
					/// Sets a new value for property {@link #getDesign design}.
					/// 
					/// Internal attribute, used to force the display of the "short" or the "long" text only.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sDesign">New value for property <code>design</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Message setDesign(string sDesign);

					#endregion

					#region Other methods

					/// <summary>
					/// Registers a callback function to be invoked if long text Details are to be made available.
					/// 
					/// This callback function will be supplied the corresponding Message "id", and should return the (simple) HTML string to be displayed within the Message Details Dialog.
					/// 
					/// E.g.: myMessage.bindDetails(getDetails); function getDetails(sId) {... return htmlString;}
					/// </summary>
					/// <param name="fnCallBack">the callback function</param>
					public extern virtual void bindDetails(object fnCallBack);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Message with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Message with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Message with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Message.
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
