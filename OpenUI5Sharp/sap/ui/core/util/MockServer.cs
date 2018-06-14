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
				public static partial class util
				{
					/// <summary>
					/// Class to mock http requests made to a remote server
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class MockServer : sap.ui.@base.ManagedObject
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.@base.ManagedObject.Settings
						{
							/// <summary>
							/// Getter for property <code>rootUri</code>. Has to be relative and requires a trailing '/'. It also needs to match the URI set in OData/JSON models or simple XHR calls in order for the mock server to intercept them.
							/// 
							/// Default value is empty/<code>undefined</code>. Must end with a a trailing slash ("/").
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> rootUri;

							/// <summary>
							/// Whether or not the requests performed should be recorded (stored). This could be memory intense if each request is recorded. For unit testing purposes it should be set to <code>true</code> to compare requests performed otherwise this flag should be set to <code>false</code> e.g. for demonstration/app purposes.
							/// </summary>
							public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> recordRequests;

							/// <summary>
							/// Getter for property <code>requests</code>.
							/// 
							/// Default value is <code>[]</code>
							/// </summary>
							public Union<object[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> requests;

						}

						#endregion

						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Config
						{
							/// <summary>
							/// If set true, all mock servers will respond automatically. If set false you have to call {@link sap.ui.core.util.MockServer#respond} method for response.
							/// </summary>
							public bool autoRespond;

							/// <summary>
							/// the time in ms after all mock servers should send their response.
							/// </summary>
							public int autoRespondAfter;

							/// <summary>
							/// If set to true, all mock server will find <code>_method</code> parameter in the POST body and use this to override the actual method.
							/// </summary>
							public bool fakeHTTPMethods;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class SimulateInfo
						{
							/// <summary>
							/// base url which contains the mockdata as single .json files or the .json file containing the complete mock data
							/// </summary>
							public string sMockdataBaseUrl;

							/// <summary>
							/// true for the MockServer to generate mock data for missing .json files that are not found in sMockdataBaseUrl. Default value is false.
							/// </summary>
							public bool bGenerateMissingMockData;

							/// <summary>
							/// list of entity set names to fetch. This parameter should be used to improve performance in case there are a lot of entity sets but only a few are needed to be fetched. Default value is empty - in this case all entity sets will be retrieved.
							/// </summary>
							public object[] aEntitySetsNames;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new server object; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
						/// <param name="mSettings">optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
						/// <param name="oScope">scope object for resolving string based type and formatter references in bindings</param>
						public extern MockServer(string sId, sap.ui.core.util.MockServer.Settings mSettings, object oScope);

						/// <summary>
						/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new server object; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
						/// <param name="mSettings">optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
						public extern MockServer(string sId, sap.ui.core.util.MockServer.Settings mSettings);

						/// <summary>
						/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new server object; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
						public extern MockServer(string sId);

						/// <summary>
						/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern MockServer();

						/// <summary>
						/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
						public extern MockServer(sap.ui.core.util.MockServer.Settings mSettings);

						/// <summary>
						/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
						/// <param name="oScope">scope object for resolving string based type and formatter references in bindings</param>
						public extern MockServer(sap.ui.core.util.MockServer.Settings mSettings, object oScope);

						/// <summary>
						/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="oScope">scope object for resolving string based type and formatter references in bindings</param>
						public extern MockServer(object oScope);

						#endregion

						#region Fields

						/// <summary>
						/// Enum for the method.
						/// </summary>
						public static object HTTPMETHOD;

						#endregion

						#region Methods

						#region Methods for Property rootUri

						/// <summary>
						/// Getter for property <code>rootUri</code>. Has to be relative and requires a trailing '/'. It also needs to match the URI set in OData/JSON models or simple XHR calls in order for the mock server to intercept them.
						/// 
						/// Default value is empty/<code>undefined</code>. Must end with a a trailing slash ("/").
						/// </summary>
						/// <returns>the value of property <code>rootUri</code></returns>
						public extern virtual string getRootUri();

						/// <summary>
						/// Setter for property <code>rootUri</code>. All request path URI are prefixed with this root URI if set.
						/// 
						/// Default value is empty/<code>undefined</code>
						/// </summary>
						/// <param name="rootUri">new value for property <code>rootUri</code></param>
						public extern virtual void setRootUri(string rootUri);

						#endregion

						#region Methods for Property recordRequests

						/// <summary>
						/// Getter for property <code>recordRequests</code>. Returns whether or not the requests performed should be recorded (stored).
						/// 
						/// Default value is <code>true</code>
						/// </summary>
						/// <returns>the value of property <code>recordRequests</code></returns>
						public extern virtual bool getRecordRequests();

						/// <summary>
						/// Setter for property <code>recordRequests</code>. Defines whether or not the requests performed should be recorded (stored).
						/// 
						/// Default value is <code>true</code>
						/// </summary>
						/// <param name="recordRequests">new value for property <code>recordRequests</code></param>
						public extern virtual void setRecordRequests(bool recordRequests);

						#endregion

						#region Methods for Property requests

						/// <summary>
						/// Getter for property <code>requests</code>.
						/// 
						/// Default value is <code>[]</code>
						/// </summary>
						/// <returns>the value of property <code>rootUri</code></returns>
						public extern virtual object[] getRequests();

						/// <summary>
						/// Setter for property <code>requests</code>.
						/// 
						/// Default value is is <code>[]</code>
						/// 
						/// Each array entry should consist of an array with the following properties / values:
						/// 
						/// <ul> <li><b>method <string>: "GET"|"POST"|"DELETE|"PUT"</b> <br> (any HTTP verb) </li> <li><b>path <string>: "/path/to/resource"</b> <br> The path is converted to a regular expression, so it can contain normal regular expression syntax. All regular expression groups are forwarded as arguments to the <code>response</code> function. In addition to this, parameters can be written in this notation: <code>:param</code>. These placeholder will be replaced by regular expression groups. </li> <li><b>response <function>: function(xhr, param1, param2, ...) { }</b> <br> The xhr object can be used to respond on the request. Supported methods are: <br> <code>xhr.respond(iStatusCode, mHeaders, sBody)</code> <br> <code>xhr.respondJSON(iStatusCode, mHeaders, oJsonObjectOrString)</code>. By default a JSON header is set for response header <br> <code>xhr.respondXML(iStatusCode, mHeaders, sXmlString)</code>. By default an XML header is set for response header <br> <code>xhr.respondFile(iStatusCode, mHeaders, sFileUrl)</code>. By default the mime type of the file is set for response header </li> </ul>
						/// </summary>
						/// <param name="requests">new value for property <code>requests</code></param>
						public extern virtual void setRequests(object[] requests);

						#endregion

						#region Other methods

						/// <summary>
						/// Generates a floating-point, pseudo-random number in the range [0, 1[ using a linear congruential generator with drand48 parameters the seed is fixed, so the generated random sequence is always the same each property type has a own seed. Valid types are: String, DateTime, Int, Decimal, Boolean, Byte, Double, Single, SByte, Time, Guid, Binary, DateTimeOffset
						/// </summary>
						/// <param name="specific">property type of random mock value to be generated</param>
						/// <returns>(number) pseudo-random number</returns>
						public extern virtual void _getPseudoRandomNumber(string specific);

						/// <summary>
						/// Attaches an event handler to be called after the built-in request processing of the mock server
						/// </summary>
						/// <param name="@event">type according to HTTP Method</param>
						/// <param name="fnCallback">the name of the function that will be called at this exit The callback function exposes an event with parameters, depending on the type of the request. oEvent.getParameters() lists the parameters as per the request. Examples are: oXhr : the request object; oFilteredData : the mock data entries that are about to be returned in the response; oEntry : the mock data entry that is about to be returned in the response;</param>
						/// <param name="sEntitySet">(optional) the name of the entity set</param>
						public extern virtual void attachAfter(string @event, object fnCallback, string sEntitySet);

						/// <summary>
						/// Attaches an event handler to be called before the built-in request processing of the mock server
						/// </summary>
						/// <param name="@event">type according to HTTP Method</param>
						/// <param name="fnCallback">the name of the function that will be called at this exit. The callback function exposes an event with parameters, depending on the type of the request. oEvent.getParameters() lists the parameters as per the request. Examples are: oXhr : the request object; sUrlParams : the URL parameters of the request; sKeys : key properties of the requested entry; sNavProp/sNavName : name of navigation</param>
						/// <param name="sEntitySet">(optional) the name of the entity set</param>
						public extern virtual void attachBefore(string @event, object fnCallback, string sEntitySet);

						/// <summary>
						/// Global configuration of all mock servers.
						/// </summary>
						/// <param name="mConfig">the configuration object.</param>
						public extern static void config(sap.ui.core.util.MockServer.Config mConfig);

						/// <summary>
						/// Cleans up the resources associated with this object and all its aggregated children.
						/// 
						/// After an object has been destroyed, it can no longer be used in!
						/// 
						/// Applications should call this method if they don't need the object any longer.
						/// </summary>
						/// <param name="bSuppressInvalidate">if true, this ManagedObject is not marked as changed</param>
						public extern override void destroy(bool bSuppressInvalidate);

						/// <summary>
						/// Cleans up the resources associated with this object and all its aggregated children.
						/// 
						/// After an object has been destroyed, it can no longer be used in!
						/// 
						/// Applications should call this method if they don't need the object any longer.
						/// </summary>
						public extern override void destroy();

						/// <summary>
						/// Stops and calls destroy on all registered servers. Use this method for cleaning up.
						/// </summary>
						public extern static void destroyAll();

						/// <summary>
						/// Removes a previously attached event handler
						/// </summary>
						/// <param name="@event">type according to HTTP Method</param>
						/// <param name="fnCallback">the name of the function that will be called at this exit</param>
						/// <param name="sEntitySet">(optional) the name of the entity set</param>
						public extern virtual void detachAfter(string @event, object fnCallback, string sEntitySet);

						/// <summary>
						/// Removes a previously attached event handler
						/// </summary>
						/// <param name="@event">type according to HTTP Method</param>
						/// <param name="fnCallback">the name of the function that will be called at this exit</param>
						/// <param name="sEntitySet">(optional) the name of the entity set</param>
						public extern virtual void detachBefore(string @event, object fnCallback, string sEntitySet);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.MockServer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.MockServer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.MockServer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns the data model of the given EntitySet name.
						/// </summary>
						/// <param name="sEntitySetName">EntitySet name</param>
						/// <returns>data model of the given EntitySet</returns>
						public extern virtual object[] getEntitySetData(string sEntitySetName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.util.MockServer.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Returns whether the server is started or not.
						/// </summary>
						/// <returns>whether the server is started or not.</returns>
						public extern virtual bool isStarted();

						/// <summary>
						/// Respond to a request, when the servers are configured not to automatically respond.
						/// </summary>
						public extern static void respond();

						/// <summary>
						/// Sets the data of the given EntitySet name with the given array.
						/// </summary>
						/// <param name="sEntitySetName">EntitySet name</param>
						/// <param name="aData"></param>
						public extern virtual void setEntitySetData(string sEntitySetName, object[] aData);

						/// <summary>
						/// Simulates an existing OData service by sepcifiying the metadata URL and the base URL for the mockdata. The server configures the request handlers depending on the service metadata. The mockdata needs to be stored individually for each entity type in a separate JSON file. The name of the JSON file needs to match the name of the entity type. If no base url for the mockdata is specified then the mockdata are generated from the metadata
						/// </summary>
						/// <param name="sMetadataString">Either the URL to the service metadata document or the metadata document as xml string itself (starting with "<?xml")</param>
						/// <param name="vMockdataSettings">(optional) base url which contains the path to the mockdata, or an object which contains the following properties: sMockdataBaseUrl, bGenerateMissingMockData, aEntitySetsNames. See below for descriptions of these parameters. Ommit this parameter to produce random mock data based on the service metadata.</param>
						public extern virtual void simulate(string sMetadataString, Union<string, sap.ui.core.util.MockServer.SimulateInfo> vMockdataSettings);

						/// <summary>
						/// Simulates an existing OData service by sepcifiying the metadata URL and the base URL for the mockdata. The server configures the request handlers depending on the service metadata. The mockdata needs to be stored individually for each entity type in a separate JSON file. The name of the JSON file needs to match the name of the entity type. If no base url for the mockdata is specified then the mockdata are generated from the metadata
						/// </summary>
						/// <param name="sMetadataString">Either the URL to the service metadata document or the metadata document as xml string itself (starting with "<?xml")</param>
						public extern virtual void simulate(string sMetadataString);

						/// <summary>
						/// Starts the server.
						/// </summary>
						public extern virtual void start();

						/// <summary>
						/// Starts all registered servers.
						/// </summary>
						public extern static void startAll();

						/// <summary>
						/// Stops the server.
						/// </summary>
						public extern virtual void stop();

						/// <summary>
						/// Stops all registered servers.
						/// </summary>
						public extern static void stopAll();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
