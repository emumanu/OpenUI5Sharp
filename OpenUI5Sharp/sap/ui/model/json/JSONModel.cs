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
				public static partial class json
				{
					/// <summary>
					/// Model implementation for JSON format
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.json.JSONModel")]
					public partial class JSONModel : sap.ui.model.ClientModel
					{
						#region Constructor

						/// <summary>
						/// Constructor for a new JSONModel.
						/// 
						/// The observation feature is experimental! When observation is activated, the application can directly change the JS objects without the need to call setData, setProperty or refresh. Observation does only work for existing properties in the JSON, it cannot detect new properties or new array entries.
						/// </summary>
						/// <param name="oData">Either the URL where to load the JSON from or a JS object</param>
						/// <param name="bObserve">Whether to observe the JSON data for property changes (experimental)</param>
						public extern JSONModel(Union<object, string> oData, bool bObserve = false);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.json.JSONModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ClientModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.json.JSONModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ClientModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.json.JSONModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ClientModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Serializes the current JSON data of the model into a string. Note: May not work in Internet Explorer 8 because of lacking JSON support (works only if IE 8 mode is enabled)
						/// </summary>
						/// <returns>the JSON data serialized as string</returns>
						public extern virtual string getJSON();

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.json.JSONModel.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

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
						/// Load JSON-encoded data from the server using a GET HTTP request and store the resulting JSON data in the model. Note: Due to browser security restrictions, most "Ajax" requests are subject to the same origin policy, the request can not successfully retrieve data from a different domain, subdomain, or protocol.
						/// </summary>
						/// <param name="sURL">A string containing the URL to which the request is sent.</param>
						/// <param name="oParameters">A map or string that is sent to the server with the request. Data that is sent to the server is appended to the URL as a query string. If the value of the data parameter is an object (map), it is converted to a string and url-encoded before it is appended to the URL.</param>
						/// <param name="bAsync">By default, all requests are sent asynchronous (i.e. this is set to true by default). If you need synchronous requests, set this option to false. Cross-domain requests do not support synchronous operation. Note that synchronous requests may temporarily lock the browser, disabling any actions while the request is active.</param>
						/// <param name="sType">The type of request to make ("POST" or "GET"), default is "GET". Note: Other HTTP request methods, such as PUT and DELETE, can also be used here, but they are not supported by all browsers.</param>
						/// <param name="bMerge">whether the data should be merged instead of replaced</param>
						/// <param name="bCache">force no caching if false. Default is false</param>
						/// <param name="mHeaders">An object of additional header key/value pairs to send along with the request</param>
						public extern virtual void loadData(string sURL, Union<object, string> oParameters, bool bAsync, string sType, bool bMerge, bool bCache, object mHeaders);

						/// <summary>
						/// Load JSON-encoded data from the server using a GET HTTP request and store the resulting JSON data in the model. Note: Due to browser security restrictions, most "Ajax" requests are subject to the same origin policy, the request can not successfully retrieve data from a different domain, subdomain, or protocol.
						/// </summary>
						/// <param name="sURL">A string containing the URL to which the request is sent.</param>
						/// <param name="oParameters">A map or string that is sent to the server with the request. Data that is sent to the server is appended to the URL as a query string. If the value of the data parameter is an object (map), it is converted to a string and url-encoded before it is appended to the URL.</param>
						/// <param name="bAsync">By default, all requests are sent asynchronous (i.e. this is set to true by default). If you need synchronous requests, set this option to false. Cross-domain requests do not support synchronous operation. Note that synchronous requests may temporarily lock the browser, disabling any actions while the request is active.</param>
						/// <param name="sType">The type of request to make ("POST" or "GET"), default is "GET". Note: Other HTTP request methods, such as PUT and DELETE, can also be used here, but they are not supported by all browsers.</param>
						/// <param name="bMerge">whether the data should be merged instead of replaced</param>
						/// <param name="bCache">force no caching if false. Default is false</param>
						public extern virtual void loadData(string sURL, Union<object, string> oParameters, bool bAsync = true, string sType = "GET", bool bMerge = false, bool bCache = false);

						/// <summary>
						/// Load JSON-encoded data from the server using a GET HTTP request and store the resulting JSON data in the model. Note: Due to browser security restrictions, most "Ajax" requests are subject to the same origin policy, the request can not successfully retrieve data from a different domain, subdomain, or protocol.
						/// </summary>
						/// <param name="sURL">A string containing the URL to which the request is sent.</param>
						/// <param name="oParameters">A map or string that is sent to the server with the request. Data that is sent to the server is appended to the URL as a query string. If the value of the data parameter is an object (map), it is converted to a string and url-encoded before it is appended to the URL.</param>
						public extern virtual void loadData(string sURL, Union<object, string> oParameters);

						/// <summary>
						/// Load JSON-encoded data from the server using a GET HTTP request and store the resulting JSON data in the model. Note: Due to browser security restrictions, most "Ajax" requests are subject to the same origin policy, the request can not successfully retrieve data from a different domain, subdomain, or protocol.
						/// </summary>
						/// <param name="sURL">A string containing the URL to which the request is sent.</param>
						public extern virtual void loadData(string sURL);

						/// <summary>
						/// Sets the data, passed as a JS object tree, to the model.
						/// </summary>
						/// <param name="oData">the data to set on the model</param>
						/// <param name="bMerge">whether to merge the data instead of replacing it</param>
						public extern virtual void setData(object oData, bool bMerge = false);

						/// <summary>
						/// Sets the data, passed as a string in JSON format, to the model.
						/// </summary>
						/// <param name="sJSON">the JSON data to set on the model</param>
						/// <param name="bMerge">whether to merge the data instead of replacing it</param>
						public extern virtual void setJSON(string sJSON, bool bMerge = false);

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

						#endregion

					}
				}
			}
		}
	}
}
