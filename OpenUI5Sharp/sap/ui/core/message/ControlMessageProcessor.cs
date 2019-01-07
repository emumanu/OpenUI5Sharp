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
					/// The ControlMessageProcessor implementation. This MessageProcessor is able to handle Messages with the following target syntax: 'ControlID/PropertyName'. Creating an instance of this class using the "new" keyword always results in the same instance (Singleton).
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.message.ControlMessageProcessor")]
					public partial class ControlMessageProcessor : sap.ui.core.message.MessageProcessor
					{
						#region Constructor

						/// <summary>
						/// Constructor for a new ControlMessageProcessor
						/// </summary>
						public extern ControlMessageProcessor();

						#endregion

						#region Methods

						/// <summary>
						/// Check Messages and update controls with messages
						/// </summary>
						public extern virtual void checkMessages();

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.ControlMessageProcessor with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.message.MessageProcessor.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.ControlMessageProcessor with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.message.MessageProcessor.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.ControlMessageProcessor with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.message.MessageProcessor.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.message.ControlMessageProcessor.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Set Messages to check
						/// </summary>
						/// <param name="vMessages">map of messages: {'target': [array of messages],...}</param>
						public extern override void setMessages(Map vMessages);

						#endregion

					}
				}
			}
		}
	}
}
