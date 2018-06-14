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
					public partial class Message : sap.ui.@base.Object
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class MessageInfo
						{
							/// <summary>
							/// The message id: will be defaulted if no id is set
							/// </summary>
							public string id;

							/// <summary>
							/// The message text
							/// </summary>
							public string message;

							/// <summary>
							/// The message description
							/// </summary>
							public string description;

							/// <summary>
							/// The message description url to get a more detailed message
							/// </summary>
							public string descriptionUrl;

							/// <summary>
							/// The message additionalText
							/// </summary>
							public string additionalText;

							/// <summary>
							/// The message type
							/// </summary>
							public sap.ui.core.MessageType type;

							/// <summary>
							/// The message code
							/// </summary>
							public string code;

							/// <summary>
							/// If the message is set as technical message
							/// </summary>
							public bool technical;

							public sap.ui.core.message.MessageProcessor processor;

							/// <summary>
							/// The message target: The syntax is MessageProcessor dependent. Read the documentation of the respective MessageProcessor.
							/// </summary>
							public string target;

							/// <summary>
							/// Sets message persistent: If persistent is set <code>true</code> the message lifecycle is controlled by the application
							/// </summary>
							public bool persistent;

							/// <summary>
							/// Sets message date which can be used to remove old messages. Number of milliseconds elapsed since 1 January 1970 00:00:00 UTC
							/// </summary>
							public int date;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new Message.
						/// </summary>
						/// <param name="mParameters">(optional) a map which contains the following parameter properties:</param>
						public extern Message(sap.ui.core.message.Message.MessageInfo mParameters);

						/// <summary>
						/// Constructor for a new Message.
						/// </summary>
						public extern Message();

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.Message with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.Message with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.message.Message with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns the messages additional text.
						/// </summary>
						/// <returns>The additionaltext</returns>
						public extern virtual string getAdditionalText();

						/// <summary>
						/// Returns the message code
						/// </summary>
						/// <returns>code</returns>
						public extern virtual string getCode();

						/// <summary>
						/// Returns the control ID if set.
						/// 
						/// NOTE: The control ID is only set for Controls based on <code>sap.m.InputBase</code> The Control must be bound to a Model so the Message could be propagated to this Control. The propagation happens only if the Control is created and visible on the screen. Is this the case the control ID is set. The ID is not set in all other cases and cannot be set manually.
						/// 
						/// If a Message is propagated to multiple Controls bound to the same target the last Control wins.
						/// </summary>
						/// <returns>sControlId</returns>
						public extern virtual string getControlId();

						/// <summary>
						/// Set the date of the message
						/// </summary>
						/// <returns>The message date in number of milliseconds elapsed since 1 January 1970 00:00:00 UTC. As returned by Date.now().</returns>
						public extern virtual int getDate();

						/// <summary>
						/// Returns the message description
						/// </summary>
						/// <returns>description</returns>
						public extern virtual string getDescription();

						/// <summary>
						/// Returns the message description URL which should be used to download the description content
						/// </summary>
						/// <returns>The URL pointing to the description long text</returns>
						public extern virtual string getDescriptionUrl();

						/// <summary>
						/// Returns the Message Id
						/// </summary>
						/// <returns>id</returns>
						public extern virtual string getId();

						/// <summary>
						/// Returns message text
						/// </summary>
						/// <returns>message</returns>
						public extern virtual string getMessage();

						/// <summary>
						/// Returns the message processor
						/// </summary>
						/// <returns>processor</returns>
						public extern virtual sap.ui.core.message.MessageProcessor getMessageProcessor();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.message.Message.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Returns the if Message is persistent
						/// </summary>
						/// <returns>bPersistent</returns>
						public extern virtual bool getPersistent();

						/// <summary>
						/// Returns the message target
						/// </summary>
						/// <returns>target</returns>
						public extern virtual string getTarget();

						/// <summary>
						/// Returns the if Message set as technical message
						/// </summary>
						/// <returns>true if message is technical or false if not</returns>
						public extern virtual bool getTechnical();

						/// <summary>
						/// Returns the message type
						/// </summary>
						/// <returns>type</returns>
						public extern virtual sap.ui.core.MessageType getType();

						/// <summary>
						/// Sets the additionaltext for the message or merge different additionaltext strings
						/// </summary>
						/// <param name="sAdditionalText">The additionaltext.</param>
						public extern virtual void setAdditionalText(string sAdditionalText);

						/// <summary>
						/// Set message code
						/// </summary>
						/// <param name="sCode">The Message code</param>
						public extern virtual void setCode(string sCode);

						/// <summary>
						/// Set the date of the message, this will automatically be set on message creation
						/// </summary>
						/// <param name="iDate">The message date in number of milliseconds elapsed since 1 January 1970 00:00:00 UTC. As returned by Date.now().</param>
						public extern virtual void setDate(int iDate);

						/// <summary>
						/// Set message description
						/// </summary>
						/// <param name="sDescription">The Message description</param>
						public extern virtual void setDescription(string sDescription);

						/// <summary>
						/// Set message description URL which should be used to download the description content
						/// </summary>
						/// <param name="sDescription">The URL pointing to the description long text</param>
						public extern virtual void setDescriptionUrl(string sDescription);

						/// <summary>
						/// Set message text
						/// </summary>
						/// <param name="sMessage">The Message as text</param>
						public extern virtual void setMessage(string sMessage);

						/// <summary>
						/// Set message processor
						/// </summary>
						/// <param name="oMessageProcessor">The Message processor</param>
						public extern virtual void setMessageProcessor(sap.ui.core.message.MessageProcessor oMessageProcessor);

						/// <summary>
						/// Set message persistent
						/// </summary>
						/// <param name="bPersistent">Set Message persistent: If persisten is set true the message lifecycle controlled by Application</param>
						public extern virtual void setPersistent(bool bPersistent);

						/// <summary>
						/// Set message target: The syntax is MessageProcessor dependent. See the documentation of the respective MessageProcessor.
						/// </summary>
						/// <param name="sTarget">The Message target</param>
						public extern virtual void setTarget(string sTarget);

						/// <summary>
						/// Set message as technical message
						/// </summary>
						/// <param name="bTechnical">Set Message as technical message lifecycle controlled by Application</param>
						public extern virtual void setTechnical(bool bTechnical);

						/// <summary>
						/// Set message type
						/// </summary>
						/// <param name="sType">The Message type</param>
						public extern virtual void setType(sap.ui.core.MessageType sType);

						#endregion

					}
				}
			}
		}
	}
}
