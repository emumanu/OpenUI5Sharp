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
				public static partial class message
				{
					/// <summary>
					/// Model implementation for Messages
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.message.MessageModel")]
					public partial class MessageModel : sap.ui.model.ClientModel
					{
						#region Constructor

						/// <summary>
						/// Constructor for a new JSONModel.
						/// </summary>
						/// <param name="oMessageManager">The MessageManager instance</param>
						public extern MessageModel(sap.ui.core.message.MessageManager oMessageManager);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.message.MessageModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ClientModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.message.MessageModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ClientModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.message.MessageModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ClientModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.message.MessageModel.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Returns the value for the property with the given <code>sPropertyName</code>
						/// </summary>
						/// <param name="sPath">the path to the property</param>
						/// <param name="oContext">the context which will be used to retrieve the property</param>
						/// <returns>the value of the property</returns>
						public extern override object getProperty(string sPath, sap.ui.model.Context oContext);

						/// <summary>
						/// Returns the value for the property with the given <code>sPropertyName</code>
						/// </summary>
						/// <param name="sPath">the path to the property</param>
						/// <returns>the value of the property</returns>
						public extern override object getProperty(string sPath);

						/// <summary>
						/// Sets the message data to the model.
						/// </summary>
						/// <param name="oData">the data to set on the model</param>
						public extern virtual void setData(object oData);

						/// <summary>
						/// Sets a new value for the given property <code>sPropertyName</code> in the model. If the model value changed all interested parties are informed.
						/// </summary>
						/// <param name="sPath">path of the property to set</param>
						/// <param name="oValue">value to set the property to</param>
						/// <param name="oContext">the context which will be used to set the property</param>
						public extern virtual void setProperty(string sPath, object oValue, sap.ui.model.Context oContext);

						/// <summary>
						/// Sets a new value for the given property <code>sPropertyName</code> in the model. If the model value changed all interested parties are informed.
						/// </summary>
						/// <param name="sPath">path of the property to set</param>
						/// <param name="oValue">value to set the property to</param>
						public extern virtual void setProperty(string sPath, object oValue);

						#endregion

					}
				}
			}
		}
	}
}
