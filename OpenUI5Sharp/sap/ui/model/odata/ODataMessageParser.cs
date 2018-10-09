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
			public static partial class model
			{
				public static partial class odata
				{
					/// <summary>
					/// OData implementation of the sap.ui.core.message.MessageParser class. Parses message responses from the back-end.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.odata.ODataMessageParser")]
					public abstract partial class ODataMessageParser : sap.ui.core.message.MessageParser
					{
						#region Constructor

						/// <summary>
						/// OData implementation of the sap.ui.core.message.MessageParser class. Parses message responses from the back-end.
						/// </summary>
						public extern ODataMessageParser();

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataMessageParser with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.message.MessageParser.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataMessageParser with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.message.MessageParser.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataMessageParser with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.message.MessageParser.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns the name of the header field that is used to parse the server messages
						/// </summary>
						/// <returns>The name of the header field</returns>
						public extern virtual string getHeaderField();

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.odata.ODataMessageParser.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Parses the given response for messages, calculates the delta and fires the messageChange-event on the MessageProcessor if messages are found.
						/// </summary>
						/// <param name="oResponse">The response from the server containing body and headers</param>
						/// <param name="oRequest">The original request that lead to this response</param>
						/// <param name="mGetEntities">A map containing the entities requested from the back-end as keys</param>
						/// <param name="mChangeEntities">A map containing the entities changed on the back-end as keys</param>
						public extern virtual void parse(object oResponse, object oRequest, Map mGetEntities, Map mChangeEntities);

						/// <summary>
						/// Sets the header field name that should be used for parsing the JSON messages
						/// </summary>
						/// <param name="sFieldName">The name of the header field that should be used as source of the message object</param>
						/// <returns>Instance reference for method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMessageParser setHeaderField(string sFieldName);

						#endregion

					}
				}
			}
		}
	}
}
