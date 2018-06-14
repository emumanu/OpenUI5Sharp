using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				public static partial class message
				{
					[External]
					[Namespace(false)]
					public partial class MessageManager : sap.ui.@base.EventProvider
					{
						#region Constructor

						/// <summary>
						/// Constructor for a new MessageManager.
						/// </summary>
						public extern MessageManager();

						#endregion

						#region Methods

						/// <summary>
						/// Add messages to MessageManager
						/// </summary>
						/// <param name="vMessages">Array of sap.ui.core.message.Message or single sap.ui.core.message.Message</param>
						public extern virtual void addMessages(Union<sap.ui.core.message.Message, sap.ui.core.message.Message[]> vMessages);

						/// <summary>
						/// Destroy MessageManager
						/// </summary>
						[Obsolete("Deprecated since 1.32. do not call <code>destroy()</code> on a <code>MessageManager</code>.")]
						public extern override void destroy();

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.MessageManager with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.MessageManager with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.MessageManager with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Get the MessageModel
						/// </summary>
						/// <returns>oMessageModel The Message Model</returns>
						public extern virtual sap.ui.model.message.MessageModel getMessageModel();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.message.MessageManager.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Register MessageProcessor
						/// </summary>
						/// <param name="oProcessor">The MessageProcessor</param>
						public extern virtual void registerMessageProcessor(sap.ui.core.message.MessageProcessor oProcessor);

						/// <summary>
						/// When using the databinding type system, the validation/parsing of a new property value could fail. In this case, a validationError/parseError event is fired. These events bubble up to the core. For registered ManagedObjects, the MessageManager attaches to these events and creates a <code>sap.ui.core.message.Message</code> (bHandleValidation=true) for each of these errors and cancels the event bubbling.
						/// </summary>
						/// <param name="oObject">The sap.ui.base.ManagedObject</param>
						/// <param name="bHandleValidation">Handle validationError/parseError events for this object. If set to true, the MessageManager creates a Message for each validation/parse error. The event bubbling is canceled in every case.</param>
						public extern virtual void registerObject(sap.ui.@base.ManagedObject oObject, bool bHandleValidation);

						/// <summary>
						/// Remove all messages
						/// </summary>
						public extern virtual void removeAllMessages();

						/// <summary>
						/// Remove given Messages
						/// </summary>
						/// <param name="vMessages">The message(s) to be removed.</param>
						public extern virtual void removeMessages(Union<sap.ui.core.message.Message, sap.ui.core.message.Message[]> vMessages);

						/// <summary>
						/// Deregister MessageProcessor
						/// </summary>
						/// <param name="oProcessor">The MessageProcessor</param>
						public extern virtual void unregisterMessageProcessor(sap.ui.core.message.MessageProcessor oProcessor);

						/// <summary>
						/// Unregister ManagedObject
						/// </summary>
						/// <param name="oObject">The sap.ui.base.ManagedObject</param>
						public extern virtual void unregisterObject(sap.ui.@base.ManagedObject oObject);

						#endregion

					}
				}
			}
		}
	}
}
