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
				public static partial class xml
				{
					/// <summary>
					/// Model implementation for XML format
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.xml.XMLModel")]
					public partial class XMLModel : sap.ui.model.ClientModel
					{
						#region Constructor

						/// <summary>
						/// Constructor for a new XMLModel.
						/// </summary>
						/// <param name="oData">either the URL where to load the XML from or an XML</param>
						public extern XMLModel(object oData);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.xml.XMLModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ClientModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.xml.XMLModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ClientModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.xml.XMLModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ClientModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.xml.XMLModel.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Returns the object for the given <code>path</code>
						/// </summary>
						/// <param name="sPath">the path to the object</param>
						/// <param name="oContext">the context which will be used to retrieve the object</param>
						/// <returns>the object</returns>
						public extern virtual object getObject(string sPath, sap.ui.model.Context oContext);

						/// <summary>
						/// Returns the object for the given <code>path</code>
						/// </summary>
						/// <param name="sPath">the path to the object</param>
						/// <returns>the object</returns>
						public extern virtual object getObject(string sPath);

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
						/// Serializes the current XML data of the model into a string.
						/// </summary>
						/// <returns>the XML document serialized as string</returns>
						public extern virtual void getXML();

						/// <summary>
						/// Load XML-encoded data from the server using a GET HTTP request and store the resulting XML data in the model. Note: Due to browser security restrictions, most "Ajax" requests are subject to the same origin policy, the request can not successfully retrieve data from a different domain, subdomain, or protocol.
						/// </summary>
						/// <param name="sURL">A string containing the URL to which the request is sent.</param>
						/// <param name="oParameters">A map or string that is sent to the server with the request.</param>
						/// <param name="bAsync">if the request should be asynchron or not. Default is true.</param>
						/// <param name="sType">of request. Default is 'GET'</param>
						/// <param name="bCache">force no caching if false. Default is false</param>
						/// <param name="mHeaders">An object of additional header key/value pairs to send along with the request</param>
						public extern virtual void loadData(string sURL, Union<object, string> oParameters, bool bAsync, string sType, bool bCache, object mHeaders);

						/// <summary>
						/// Sets the provided XML encoded data object to the model
						/// </summary>
						/// <param name="oData">the data to set to the model</param>
						public extern virtual void setData(object oData);

						/// <summary>
						/// Sets an XML namespace to use in the binding path
						/// </summary>
						/// <param name="sNameSpace">the namespace URI</param>
						/// <param name="sPrefix">the prefix for the namespace (optional)</param>
						public extern virtual void setNameSpace(string sNameSpace, string sPrefix);

						/// <summary>
						/// Sets an XML namespace to use in the binding path
						/// </summary>
						/// <param name="sNameSpace">the namespace URI</param>
						public extern virtual void setNameSpace(string sNameSpace);

						/// <summary>
						/// Sets a new value for the given property <code>sPropertyName</code> in the model. If the model value changed all interested parties are informed.
						/// </summary>
						/// <param name="sPath">path of the property to set</param>
						/// <param name="oValue">value to set the property to</param>
						/// <param name="oContext">the context which will be used to set the property</param>
						/// <param name="bAsyncUpdate">whether to update other bindings dependent on this property asynchronously</param>
						/// <returns>true if the value was set correctly and false if errors occurred like the entry was not found.</returns>
						public extern virtual bool setProperty(string sPath, object oValue, sap.ui.model.Context oContext, bool bAsyncUpdate);

						/// <summary>
						/// Sets a new value for the given property <code>sPropertyName</code> in the model. If the model value changed all interested parties are informed.
						/// </summary>
						/// <param name="sPath">path of the property to set</param>
						/// <param name="oValue">value to set the property to</param>
						/// <param name="oContext">the context which will be used to set the property</param>
						/// <returns>true if the value was set correctly and false if errors occurred like the entry was not found.</returns>
						public extern virtual bool setProperty(string sPath, object oValue, sap.ui.model.Context oContext);

						/// <summary>
						/// Sets a new value for the given property <code>sPropertyName</code> in the model. If the model value changed all interested parties are informed.
						/// </summary>
						/// <param name="sPath">path of the property to set</param>
						/// <param name="oValue">value to set the property to</param>
						/// <returns>true if the value was set correctly and false if errors occurred like the entry was not found.</returns>
						public extern virtual bool setProperty(string sPath, object oValue);

						/// <summary>
						/// Sets the specified XML formatted string text to the model
						/// </summary>
						/// <param name="sXMLText">the XML data as string</param>
						public extern virtual void setXML(string sXMLText);

						#endregion

					}
				}
			}
		}
	}
}
