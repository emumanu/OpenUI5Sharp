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
				public static partial class message
				{
					/// <summary>
					/// This is an abstract base class for MessageProcessor objects.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.message.MessageProcessor")]
					public abstract partial class MessageProcessor : sap.ui.@base.EventProvider
					{
						#region Constructor

						/// <summary>
						/// Constructor for a new MessageProcessor
						/// </summary>
						public extern MessageProcessor();

						#endregion

						#region Methods

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'messageChange' event of this <code>sap.ui.core.message.MessageProcessor</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this MessageProcessor is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.message.MessageProcessor attachMessageChange(object oData, object fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'messageChange' event of this <code>sap.ui.core.message.MessageProcessor</code>.<br/>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.message.MessageProcessor attachMessageChange(object oData, object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'messageChange' event of this <code>sap.ui.core.message.MessageProcessor</code>.<br/>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.message.MessageProcessor attachMessageChange(object fnFunction);

						/// <summary>
						/// Implement in inheriting classes
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.model.ListBinding checkMessage();

						/// <summary>
						/// Destroys the MessageProcessor Instance
						/// </summary>
						public extern override void destroy();

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'sap.ui.core.message.MessageProcessor' event of this <code>sap.ui.core.message.MessageProcessor</code>.<br/>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.message.MessageProcessor detachMessageChange(object fnFunction, object oListener);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.MessageProcessor with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.MessageProcessor with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.MessageProcessor with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Fire event messageChange to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.message.MessageProcessor fireMessageChange(object mArguments);

						/// <summary>
						/// Fire event messageChange to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.message.MessageProcessor fireMessageChange();

						/// <summary>
						/// Returns the ID of the MessageProcessor instance
						/// </summary>
						/// <returns>sId The MessageProcessor ID</returns>
						public extern virtual string getId();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.message.MessageProcessor.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Implement in inheriting classes
						/// </summary>
						/// <param name="vMessages">map of messages: {'target': [array of messages],...}</param>
						public extern virtual void setMessages(Map vMessages);

						#endregion

					}
				}
			}
		}
	}
}
