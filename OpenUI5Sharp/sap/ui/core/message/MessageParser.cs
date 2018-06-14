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
					/// <summary>
					/// This is an abstract base class for MessageParser objects.
					/// </summary>
					[External]
					[Namespace(false)]
					public abstract partial class MessageParser : sap.ui.@base.Object
					{
						#region Constructor

						/// <summary>
						/// Abstract MessageParser class to be inherited in back-end specific implementations.
						/// </summary>
						public extern MessageParser();

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.MessageParser with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.MessageParser with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.MessageParser with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.message.MessageParser.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Returns the registered processor on which the events for message handling can be fired
						/// </summary>
						/// <returns>The currently set MessageProcessor or null if none is set</returns>
						public extern virtual sap.ui.core.message.MessageProcessor getProcessor();

						/// <summary>
						/// Abstract parse method must be implemented in the inheriting class.
						/// </summary>
						public extern virtual void parse();

						/// <summary>
						/// This method is used by the model to register itself as MessageProcessor for this parser
						/// </summary>
						/// <param name="oProcessor">The MessageProcessor that can be used to fire events</param>
						/// <returns>Instance reference for method chaining</returns>
						public extern virtual sap.ui.core.message.MessageParser setProcessor(sap.ui.core.message.MessageProcessor oProcessor);

						#endregion

					}
				}
			}
		}
	}
}
