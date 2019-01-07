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
					/// Model implementation for oData format
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.odata.ODataModel")]
					[Obsolete("Deprecated since 1.48. please use {@link sap.ui.model.odata.v2.ODataModel} instead.")]
					public partial class ODataModel : sap.ui.model.Model
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class ListBindInfo
						{
							/// <summary>
							/// Value for the OData <code>$expand</code> query parameter which should be included in the request
							/// </summary>
							public string expand;

							/// <summary>
							/// Value for the OData <code>$select</code> query parameter which should be included in the request
							/// </summary>
							public string select;

							/// <summary>
							/// An optional map of custom query parameters. Custom parameters must not start with <code>$</code>
							/// </summary>
							public Map custom;

							/// <summary>
							/// Defines the count mode of this binding; if not specified, the default count mode of the <code>oModel</code> is applied
							/// </summary>
							public sap.ui.model.odata.CountMode countMode;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class ODataModelInfo
						{
							/// <summary>
							/// if set true request payloads will be JSON, XML for false (default = false),
							/// </summary>
							public bool json;

							/// <summary>
							/// user for the service,
							/// </summary>
							public string user;

							/// <summary>
							/// password for service,
							/// </summary>
							public string password;

							/// <summary>
							/// a map of custom headers like {"myHeader":"myHeaderValue",...},
							/// </summary>
							public Map headers;

							/// <summary>
							/// enable/disable XCSRF-Token handling (default = true),
							/// </summary>
							public bool tokenHandling;

							/// <summary>
							/// experimental - true when user credentials are to be included in a cross-origin request. Please note that this works only if all requests are asynchronous.
							/// </summary>
							public bool withCredentials;

							/// <summary>
							/// (optional) determined if the service metadata request is sent synchronous or asynchronous. Default is false.
							/// </summary>
							public object loadMetadataAsync;

							/// <summary>
							/// (default = '2.0') please use the following string format e.g. '2.0' or '3.0'. OData version supported by the ODataModel: '2.0',
							/// </summary>
							public object maxDataServiceVersion;

							/// <summary>
							/// when true all requests will be sent in batch requests (default = false),
							/// </summary>
							public bool useBatch;

							/// <summary>
							/// enable/disable automatic refresh after change operations: default = true,
							/// </summary>
							public bool refreshAfterChange;

							/// <summary>
							/// The URL (or an array of URLs) from which the annotation metadata should be loaded,
							/// </summary>
							public Union<string, string[]> annotationURI;

							/// <summary>
							/// Whether or not to fire the metadataLoaded-event only after annotations have been loaded as well,
							/// </summary>
							public bool loadAnnotationsJoined;

							/// <summary>
							/// map of URL parameters - these parameters will be attached to all requests,
							/// </summary>
							public Map serviceUrlParams;

							/// <summary>
							/// map of URL parameters for metadata requests - only attached to $metadata request.
							/// </summary>
							public Map metadataUrlParams;

							/// <summary>
							/// sets the default count mode for the model. If not set, sap.ui.model.odata.CountMode.Both is used.
							/// </summary>
							public string defaultCountMode;

							/// <summary>
							/// a map of namespaces (name => URI) used for parsing the service metadata.
							/// </summary>
							public Map metadataNamespaces;

							/// <summary>
							/// Whether to skip the automated loading of annotations from the metadata document. Loading annotations from metadata does not have any effects (except the lost performance by invoking the parser) if there are not annotations inside the metadata document
							/// </summary>
							public bool skipMetadataAnnotationParsing;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class CallFunctionInfo
						{
							/// <summary>
							/// A string containing the type of method to call this function with
							/// </summary>
							public string method;

							/// <summary>
							/// A map containing the parameters that will be passed as query strings
							/// </summary>
							public Map urlParameters;

							/// <summary>
							/// If specified the sPath has to be relative to the path given with the context.
							/// </summary>
							public object context;

							/// <summary>
							/// a callback function which is called when the data has been successfully retrieved. The handler can have the following parameters: <code>oData</code> and <code>response</code>.
							/// </summary>
							public object success;

							/// <summary>
							/// a callback function which is called when the request failed. The handler can have the parameter: <code>oError</code> which contains additional error information.
							/// </summary>
							public object error;

							/// <summary>
							/// Whether or not to send the request asynchronously. Default: false In case sMethod is "GET", the request is always asynchronous. Please be advised that this feature is officially unsupported as using asynchronous requests can lead to data inconsistencies if the application does not make sure that the request was completed before continuing to work with the data.
							/// </summary>
							public bool async;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class CreateInfo
						{
							/// <summary>
							/// If specified the sPath has to be relative to the path given with the context.
							/// </summary>
							public object context;

							/// <summary>
							/// a callback function which is called when the data has been successfully retrieved. The handler can have the following parameters: oData and response.
							/// </summary>
							public object success;

							/// <summary>
							/// a callback function which is called when the request failed. The handler can have the parameter <code>oError</code> which contains additional error information.
							/// </summary>
							public object error;

							/// <summary>
							/// Whether the request should be done asynchronously. Default: false Please be advised that this feature is officially unsupported as using asynchronous requests can lead to data inconsistencies if the application does not make sure that the request was completed before continuing to work with the data.
							/// </summary>
							public bool async;

							/// <summary>
							/// A map containing the parameters that will be passed as query strings
							/// </summary>
							public Map urlParameters;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class OperationInfo
						{
							/// <summary>
							/// an ETag which can be used for concurrency control. If it is specified, it will be used in an If-Match-Header in the request to the server for this entry.
							/// </summary>
							public string sETag;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class ReadInfo
						{
							/// <summary>
							/// If specified the sPath has to be is relative to the path given with the context.
							/// </summary>
							public object context;

							/// <summary>
							/// A map containing the parameters that will be passed as query strings
							/// </summary>
							public Map urlParameters;

							/// <summary>
							/// true for asynchronous requests.
							/// </summary>
							public bool async;

							/// <summary>
							/// an array of sap.ui.model.Filter to be included in the request URL
							/// </summary>
							public object[] filters;

							/// <summary>
							/// an array of sap.ui.model.Sorter to be included in the request URL
							/// </summary>
							public object[] sorters;

							/// <summary>
							/// a callback function which is called when the data has been successfully retrieved. The handler can have the following parameters: oData and response.
							/// </summary>
							public object success;

							/// <summary>
							/// a callback function which is called when the request failed. The handler can have the parameter: oError which contains additional error information.
							/// </summary>
							public object error;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class RemoveInfo
						{
							/// <summary>
							/// If specified the sPath has to be relative to the path given with the context.
							/// </summary>
							public object context;

							/// <summary>
							/// a callback function which is called when the data has been successfully retrieved. The handler can have the following parameters: <code>oData</code> and <code>response</code>.
							/// </summary>
							public object success;

							/// <summary>
							/// a callback function which is called when the request failed. The handler can have the parameter: <code>oError</code> which contains additional error information.
							/// </summary>
							public object error;

							/// <summary>
							/// If specified, the If-Match-Header will be set to this Etag.
							/// </summary>
							public string eTag;

							/// <summary>
							/// if specified, this optional variable can be used to pass a payload into the delete function, e.g. if the entry which should be deleted has not been bound to any control, but has been retrieved via read, only.
							/// </summary>
							public object payload;

							/// <summary>
							/// Whether the request should be done asynchronously. Please be advised that this feature is officially unsupported as using asynchronous requests can lead to data inconsistencies if the application does not make sure that the request was completed before continuing to work with the data.
							/// </summary>
							public bool async;

							/// <summary>
							/// A map containing the parameters that will be passed as query strings
							/// </summary>
							public Map urlParameters;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class UpdateInfo
						{
							/// <summary>
							/// If specified the sPath has to be is relative to the path given with the context.
							/// </summary>
							public object context;

							/// <summary>
							/// a callback function which is called when the data has been successfully updated.
							/// </summary>
							public object success;

							/// <summary>
							/// a callback function which is called when the request failed. The handler can have the parameter <code>oError</code> which contains additional error information.
							/// </summary>
							public object error;

							/// <summary>
							/// trigger a MERGE request instead of a PUT request to perform a differential update
							/// </summary>
							public bool merge;

							/// <summary>
							/// If specified, the If-Match-Header will be set to this Etag.
							/// </summary>
							public string eTag;

							/// <summary>
							/// Whether the request should be done asynchronously. Please be advised that this feature is officially unsupported as using asynchronous requests can lead to data inconsistencies if the application does not make sure that the request was completed before continuing to work with the data.
							/// </summary>
							public bool async;

							/// <summary>
							/// A map containing the parameters that will be passed as query strings
							/// </summary>
							public Map urlParameters;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new ODataModel.
						/// </summary>
						/// <param name="sServiceUrl">base uri of the service to request data from; additional URL parameters appended here will be appended to every request can be passed with the mParameters object as well: [mParameters.serviceUrl] A serviceURl is required!</param>
						/// <param name="mParameters">(optional) a map which contains the following parameter properties:</param>
						public extern ODataModel(string sServiceUrl, sap.ui.model.odata.ODataModel.ODataModelInfo mParameters);

						/// <summary>
						/// Constructor for a new ODataModel.
						/// </summary>
						/// <param name="sServiceUrl">base uri of the service to request data from; additional URL parameters appended here will be appended to every request can be passed with the mParameters object as well: [mParameters.serviceUrl] A serviceURl is required!</param>
						public extern ODataModel(string sServiceUrl);

						/// <summary>
						/// Constructor for a new ODataModel.
						/// </summary>
						public extern ODataModel();

						/// <summary>
						/// Constructor for a new ODataModel.
						/// </summary>
						/// <param name="mParameters">(optional) a map which contains the following parameter properties:</param>
						public extern ODataModel(sap.ui.model.odata.ODataModel.ODataModelInfo mParameters);

						#endregion

						#region Methods

						/// <summary>
						/// Adds (a) new URL(s) to the be parsed for OData annotations, which are then merged into the annotations object which can be retrieved by calling the getServiceAnnotations()-method. If a $metadata url is passed the data will also be merged into the metadata object, which can be reached by calling the getServiceMetadata() method.
						/// </summary>
						/// <param name="vUrl">Either one URL as string or an array or URL strings</param>
						/// <returns>The Promise to load the given URL(s), resolved if all URLs have been loaded, rejected if at least one fails to load. If this promise resolves it returns the following parameters: annotations: The annotation object entitySets: An array of EntitySet objects containing the newly merged EntitySets from a $metadata requests. the structure is the same as in the metadata object reached by the getServiceMetadata() method. For non $metadata requests the array will be empty.</returns>
						public extern virtual es5.Promise<object> addAnnotationUrl(Union<string, string[]> vUrl);

						/// <summary>
						/// Adds new xml content to be parsed for OData annotations, which are then merged into the annotations object which can be retrieved by calling the getServiceAnnotations()-method.
						/// </summary>
						/// <param name="sXMLContent">The string that should be parsed as annotation XML</param>
						/// <param name="bSuppressEvents">Whether not to fire annotationsLoaded event on the annotationParser</param>
						/// <returns>The Promise to parse the given XML-String, resolved if parsed without errors, rejected if errors occur</returns>
						public extern virtual es5.Promise<object> addAnnotationXML(string sXMLContent, bool bSuppressEvents = false);

						/// <summary>
						/// Appends the change batch operations to the end of the batch stack. Only PUT, POST or DELETE batch operations should be included in the specified array. The operations in the array will be included in a single changeset. To embed change operations in different change sets call this method with the corresponding change operations again. If an illegal batch operation is added to the change set nothing will be performed and false will be returned.
						/// </summary>
						/// <param name="aChangeOperations">an array of change batch operations created via <code>createBatchOperation</code> and <code>sMethod</code> = POST, PUT, MERGE or DELETE</param>
						public extern virtual void addBatchChangeOperations(object[] aChangeOperations);

						/// <summary>
						/// Appends the read batch operations to the end of the batch stack. Only GET batch operations should be included in the specified array. If an illegal batch operation is added to the batch nothing will be performed and false will be returned.
						/// </summary>
						/// <param name="aReadOperations">an array of read batch operations created via <code>createBatchOperation</code> and <code>sMethod</code> = GET</param>
						public extern virtual void addBatchReadOperations(object[] aReadOperations);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'annotationsFailed' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachAnnotationsFailed(object oData, object fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'annotationsFailed' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachAnnotationsFailed(object oData, object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'annotationsFailed' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachAnnotationsFailed(object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'annotationsLoaded' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachAnnotationsLoaded(object oData, object fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'annotationsLoaded' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachAnnotationsLoaded(object oData, object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'annotationsLoaded' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachAnnotationsLoaded(object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'metadataFailed' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachMetadataFailed(object oData, object fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'metadataFailed' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachMetadataFailed(object oData, object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'metadataFailed' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachMetadataFailed(object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'metadataLoaded' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachMetadataLoaded(object oData, object fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'metadataLoaded' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachMetadataLoaded(object oData, object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'metadataLoaded' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel attachMetadataLoaded(object fnFunction);

						/// <summary>
						/// Creates a new list binding for this model.
						/// </summary>
						/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
						/// <param name="oContext">Binding context referring to this model</param>
						/// <param name="aSorters">Initial sort order, can be either a sorter or an array of sorters</param>
						/// <param name="aFilters">Predefined filter/s, can be either a filter or an array of filters</param>
						/// <param name="mParameters">Map which contains additional parameters for the binding</param>
						/// <returns>oBinding new list binding object</returns>
						public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, Map mParameters);

						/// <summary>
						/// Creates a new list binding for this model.
						/// </summary>
						/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
						/// <param name="oContext">Binding context referring to this model</param>
						/// <param name="aSorters">Initial sort order, can be either a sorter or an array of sorters</param>
						/// <param name="aFilters">Predefined filter/s, can be either a filter or an array of filters</param>
						/// <returns>oBinding new list binding object</returns>
						public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

						/// <summary>
						/// Creates a new list binding for this model.
						/// </summary>
						/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
						/// <param name="oContext">Binding context referring to this model</param>
						/// <param name="aSorters">Initial sort order, can be either a sorter or an array of sorters</param>
						/// <returns>oBinding new list binding object</returns>
						public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters);

						/// <summary>
						/// Creates a new list binding for this model.
						/// </summary>
						/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
						/// <param name="oContext">Binding context referring to this model</param>
						/// <returns>oBinding new list binding object</returns>
						public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext);

						/// <summary>
						/// Creates a new list binding for this model.
						/// </summary>
						/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
						/// <returns>oBinding new list binding object</returns>
						public extern virtual sap.ui.model.ListBinding bindList(string sPath);

						/// <summary>
						/// Trigger a request to the function import odata service that was specified in the model constructor.
						/// </summary>
						/// <param name="sFunctionName">A string containing the name of the function to call. The name is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <param name="mParameters">Optional parameter map containing any of the following properties:</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object callFunction(string sFunctionName, Map mParameters);

						/// <summary>
						/// Trigger a request to the function import odata service that was specified in the model constructor.
						/// </summary>
						/// <param name="sFunctionName">A string containing the name of the function to call. The name is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object callFunction(string sFunctionName);

						/// <summary>
						/// Removes all operations in the current batch.
						/// </summary>
						public extern virtual void clearBatch();

						/// <summary>
						/// Trigger a POST request to the odata service that was specified in the model constructor. Please note that deep creates are not supported and may not work.
						/// </summary>
						/// <param name="sPath">A string containing the path to the collection where an entry should be created. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <param name="oData">data of the entry that should be created.</param>
						/// <param name="mParameters">Optional parameter map containing any of the following properties:</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object create(string sPath, object oData, Map mParameters);

						/// <summary>
						/// Trigger a POST request to the odata service that was specified in the model constructor. Please note that deep creates are not supported and may not work.
						/// </summary>
						/// <param name="sPath">A string containing the path to the collection where an entry should be created. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <param name="oData">data of the entry that should be created.</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object create(string sPath, object oData);

						/// <summary>
						/// Creates a single batch operation (read or change operation) which can be used in a batch request.
						/// </summary>
						/// <param name="sPath">A string containing the path to the collection or entry where the batch operation should be performed. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <param name="sMethod">for the batch operation. Possible values are GET, PUT, MERGE, POST, DELETE</param>
						/// <param name="oData">optional data payload which should be created, updated, deleted in a change batch operation.</param>
						/// <param name="oParameters">optional parameter for additional information introduced in SAPUI5 1.9.1,</param>
						public extern virtual void createBatchOperation(string sPath, string sMethod, object oData, sap.ui.model.odata.ODataModel.OperationInfo oParameters);

						/// <summary>
						/// Creates a single batch operation (read or change operation) which can be used in a batch request.
						/// </summary>
						/// <param name="sPath">A string containing the path to the collection or entry where the batch operation should be performed. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <param name="sMethod">for the batch operation. Possible values are GET, PUT, MERGE, POST, DELETE</param>
						/// <param name="oData">optional data payload which should be created, updated, deleted in a change batch operation.</param>
						public extern virtual void createBatchOperation(string sPath, string sMethod, object oData);

						/// <summary>
						/// Creates a single batch operation (read or change operation) which can be used in a batch request.
						/// </summary>
						/// <param name="sPath">A string containing the path to the collection or entry where the batch operation should be performed. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <param name="sMethod">for the batch operation. Possible values are GET, PUT, MERGE, POST, DELETE</param>
						public extern virtual void createBatchOperation(string sPath, string sMethod);

						/// <summary>
						/// Creates a new entry object which is described by the metadata of the entity type of the specified sPath Name. A context object is returned which can be used to bind against the newly created object.
						/// 
						/// For each created entry a request is created and stored in a request queue. The request queue can be submitted by calling submitChanges. To delete a created entry from the request queue call deleteCreateEntry.
						/// 
						/// The optional vProperties parameter can be used as follows:
						/// 
						/// - vProperties could be an array containing the property names which should be included in the new entry. Other properties defined in the entity type are not included. - vProperties could be an object which includes the desired properties and the values which should be used for the created entry.
						/// 
						/// If vProperties is not specified, all properties in the entity type will be included in the created entry.
						/// 
						/// If there are no values specified the properties will have undefined values.
						/// 
						/// Please note that deep creates (including data defined by navigationproperties) are not supported
						/// </summary>
						/// <param name="sPath">Name of the path to the collection</param>
						/// <param name="vProperties">An array that specifies a set of properties or the entry</param>
						/// <returns>oContext A Context object that point to the new created entry.</returns>
						public extern virtual sap.ui.model.Context createEntry(string sPath, Union<object[], object> vProperties);

						/// <summary>
						/// Creates the key from the given collection name and property map
						/// </summary>
						/// <param name="sCollection">The name of the collection</param>
						/// <param name="oKeyParameters">The object containing at least all the key properties of the entity type</param>
						/// <param name="bDecode">Whether the URI decoding should be applied on the key</param>
						public extern virtual void createKey(string sCollection, object oKeyParameters, bool bDecode);

						/// <summary>
						/// Deletes a created entry from the request queue and the model.
						/// </summary>
						/// <param name="oContext">The context object pointing to the created entry</param>
						public extern virtual void deleteCreatedEntry(sap.ui.model.Context oContext);

						public extern override void destroy();

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'annotationsFailed' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel detachAnnotationsFailed(object fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'annotationsLoaded' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel detachAnnotationsLoaded(object fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'metadataFailed' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel detachMetadataFailed(object fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'metadataLoaded' event of this <code>sap.ui.model.odata.ODataModel</code>.
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel detachMetadataLoaded(object fnFunction, object oListener);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Fire event annotationsFailed to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel fireAnnotationsFailed(object mArguments);

						/// <summary>
						/// Fire event annotationsFailed to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel fireAnnotationsFailed();

						/// <summary>
						/// Fire event annotationsLoaded to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel fireAnnotationsLoaded(object mArguments);

						/// <summary>
						/// Fire event annotationsLoaded to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel fireAnnotationsLoaded();

						/// <summary>
						/// Fire event metadataFailed to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel fireMetadataFailed(object mArguments);

						/// <summary>
						/// Fire event metadataFailed to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel fireMetadataFailed();

						/// <summary>
						/// Fire event metadataLoaded to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel fireMetadataLoaded(object mArguments);

						/// <summary>
						/// Fire event metadataLoaded to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataModel fireMetadataLoaded();

						/// <summary>
						/// Force no caching
						/// </summary>
						/// <param name="bForceNoCache">whether to force no caching</param>
						[Obsolete("Deprecated since 1.13. the caching should be controlled by the backend by setting the correct cache control header")]
						public extern virtual void forceNoCache(bool bForceNoCache = false);

						/// <summary>
						/// Return requested data as object if the data has already been loaded and stored in the model.
						/// </summary>
						/// <param name="sPath">A string containing the path to the data object that should be returned.</param>
						/// <param name="oContext">the optional context which is used with the sPath to retrieve the requested data.</param>
						/// <param name="bIncludeExpandEntries">This parameter should be set when a URI or custom parameter with a $expand System Query Option was used to retrieve associated entries embedded/inline. If true then the getProperty function returns a desired property value/entry and includes the associated expand entries (if any). If false the associated/expanded entry properties are removed and not included in the desired entry as properties at all. This is useful for performing updates on the base entry only. Note: A copy and not a reference of the entry will be returned.</param>
						/// <returns>oData Object containing the requested data if the path is valid.</returns>
						[Obsolete("Deprecated since 1.6.0. please use {@link #getProperty} instead")]
						public extern virtual object getData(string sPath, object oContext, bool bIncludeExpandEntries);

						/// <summary>
						/// Return requested data as object if the data has already been loaded and stored in the model.
						/// </summary>
						/// <param name="sPath">A string containing the path to the data object that should be returned.</param>
						/// <param name="oContext">the optional context which is used with the sPath to retrieve the requested data.</param>
						/// <returns>oData Object containing the requested data if the path is valid.</returns>
						[Obsolete("Deprecated since 1.6.0. please use {@link #getProperty} instead")]
						public extern virtual object getData(string sPath, object oContext);

						/// <summary>
						/// Return requested data as object if the data has already been loaded and stored in the model.
						/// </summary>
						/// <param name="sPath">A string containing the path to the data object that should be returned.</param>
						/// <returns>oData Object containing the requested data if the path is valid.</returns>
						[Obsolete("Deprecated since 1.6.0. please use {@link #getProperty} instead")]
						public extern virtual object getData(string sPath);

						/// <summary>
						/// Returns the default count mode for retrieving the count of collections
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.model.odata.CountMode getDefaultCountMode();

						/// <summary>
						/// Returns all headers and custom headers which are stored in the OData model.
						/// </summary>
						/// <returns>the header map</returns>
						public extern virtual object getHeaders();

						/// <summary>
						/// Returns the key part from the entry URI or the given context or object
						/// </summary>
						/// <param name="oObject">The context or object</param>
						/// <param name="bDecode">Whether the URI decoding should be applied on the key</param>
						public extern virtual void getKey(Union<object, sap.ui.model.Context> oObject, bool bDecode);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.odata.ODataModel.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Returns an instance of an OData meta model which offers a unified access to both OData V2 metadata and V4 annotations. It uses the existing {@link sap.ui.model.odata.ODataMetadata} as a foundation and merges V4 annotations from the existing {@link sap.ui.model.odata.ODataAnnotations} directly into the corresponding model element.
						/// 
						/// <b>BEWARE:</b> Access to this OData meta model will fail before the promise returned by {@link sap.ui.model.odata.ODataMetaModel#loaded loaded} has been resolved!
						/// </summary>
						/// <returns>The meta model for this ODataModel</returns>
						public extern virtual sap.ui.model.odata.ODataMetaModel getMetaModel();

						/// <summary>
						/// Returns the value for the property with the given <code>sPath</code>. If the path points to a navigation property which has been loaded via $expand then the <code>bIncludeExpandEntries</code> parameter determines if the navigation property should be included in the returned value or not. Please note that this currently works for 1..1 navigation properties only.
						/// </summary>
						/// <param name="sPath">the path/name of the property</param>
						/// <param name="oContext">the context if available to access the property value</param>
						/// <param name="bIncludeExpandEntries">This parameter should be set when a URI or custom parameter with a $expand System Query Option was used to retrieve associated entries embedded/inline. If true then the getProperty function returns a desired property value/entry and includes the associated expand entries (if any). If false the associated/expanded entry properties are removed and not included in the desired entry as properties at all. This is useful for performing updates on the base entry only. Note: A copy and not a reference of the entry will be returned.</param>
						/// <returns>the value of the property</returns>
						public extern virtual object getProperty(string sPath, sap.ui.model.Context oContext, bool bIncludeExpandEntries);

						/// <summary>
						/// Returns the value for the property with the given <code>sPath</code>. If the path points to a navigation property which has been loaded via $expand then the <code>bIncludeExpandEntries</code> parameter determines if the navigation property should be included in the returned value or not. Please note that this currently works for 1..1 navigation properties only.
						/// </summary>
						/// <param name="sPath">the path/name of the property</param>
						/// <param name="oContext">the context if available to access the property value</param>
						/// <returns>the value of the property</returns>
						public extern virtual object getProperty(string sPath, sap.ui.model.Context oContext);

						/// <summary>
						/// Returns the value for the property with the given <code>sPath</code>. If the path points to a navigation property which has been loaded via $expand then the <code>bIncludeExpandEntries</code> parameter determines if the navigation property should be included in the returned value or not. Please note that this currently works for 1..1 navigation properties only.
						/// </summary>
						/// <param name="sPath">the path/name of the property</param>
						/// <returns>the value of the property</returns>
						public extern virtual object getProperty(string sPath);

						/// <summary>
						/// Returns the current security token. If the token has not been requested from the server it will be requested first.
						/// </summary>
						/// <returns>the CSRF security token</returns>
						public extern virtual string getSecurityToken();

						/// <summary>
						/// Return the annotation object. Please note that when using the model with bLoadMetadataAsync = true then this function might return undefined because the metadata has not been loaded yet. In this case attach to the <code>annotationsLoaded</code> event to get notified when the annotations are available and then call this function.
						/// </summary>
						/// <returns>metdata object</returns>
						public extern virtual object getServiceAnnotations();

						/// <summary>
						/// Return the metadata object. Please note that when using the model with bLoadMetadataAsync = true then this function might return undefined because the metadata has not been loaded yet. In this case attach to the <code>metadataLoaded</code> event to get notified when the metadata is available and then call this function.
						/// </summary>
						/// <returns>metdata object</returns>
						public extern virtual object getServiceMetadata();

						/// <summary>
						/// Checks if there exist pending changes in the model created by the setProperty method.
						/// </summary>
						/// <returns>true/false</returns>
						public extern virtual bool hasPendingChanges();

						/// <summary>
						/// Returns whether this model supports the $count on its collections
						/// </summary>
						/// <returns></returns>
						[Obsolete("Deprecated since 1.20. please use {@link #getDefaultCountMode} instead.")]
						public extern virtual bool isCountSupported();

						/// <summary>
						/// Trigger a GET request to the odata service that was specified in the model constructor. The data will not be stored in the model. The requested data is returned with the response.
						/// </summary>
						/// <param name="sPath">A string containing the path to the data which should be retrieved. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <param name="mParameters">Optional parameter map containing any of the following properties:</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object read(string sPath, Map mParameters);

						/// <summary>
						/// Trigger a GET request to the odata service that was specified in the model constructor. The data will not be stored in the model. The requested data is returned with the response.
						/// </summary>
						/// <param name="sPath">A string containing the path to the data which should be retrieved. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object read(string sPath);

						/// <summary>
						/// Refresh the model. This will check all bindings for updated data and update the controls if data has been changed.
						/// </summary>
						/// <param name="bForceUpdate">Force update of controls</param>
						/// <param name="bRemoveData">If set to true then the model data will be removed/cleared. Please note that the data might not be there when calling e.g. getProperty too early before the refresh call returned.</param>
						public extern virtual void refresh(bool bForceUpdate = false, bool bRemoveData = false);

						/// <summary>
						/// refreshes the metadata for model, e.g. in case the first request for metadata has failed
						/// </summary>
						public extern virtual void refreshMetadata();

						/// <summary>
						/// refresh XSRF token by performing a GET request against the service root URL.
						/// </summary>
						/// <param name="fnSuccess">a callback function which is called when the data has been successfully retrieved.</param>
						/// <param name="fnError">a callback function which is called when the request failed. The handler can have the parameter: oError which contains additional error information.</param>
						/// <param name="bAsync">true for asynchronous requests.</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object refreshSecurityToken(object fnSuccess, object fnError, bool bAsync = false);

						/// <summary>
						/// refresh XSRF token by performing a GET request against the service root URL.
						/// </summary>
						/// <param name="fnSuccess">a callback function which is called when the data has been successfully retrieved.</param>
						/// <param name="fnError">a callback function which is called when the request failed. The handler can have the parameter: oError which contains additional error information.</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object refreshSecurityToken(object fnSuccess, object fnError);

						/// <summary>
						/// refresh XSRF token by performing a GET request against the service root URL.
						/// </summary>
						/// <param name="fnSuccess">a callback function which is called when the data has been successfully retrieved.</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object refreshSecurityToken(object fnSuccess);

						/// <summary>
						/// refresh XSRF token by performing a GET request against the service root URL.
						/// </summary>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object refreshSecurityToken();

						/// <summary>
						/// refresh XSRF token by performing a GET request against the service root URL.
						/// </summary>
						/// <param name="fnError">a callback function which is called when the request failed. The handler can have the parameter: oError which contains additional error information.</param>
						/// <param name="bAsync">true for asynchronous requests.</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object refreshSecurityToken(object fnError, bool bAsync = false);

						/// <summary>
						/// refresh XSRF token by performing a GET request against the service root URL.
						/// </summary>
						/// <param name="bAsync">true for asynchronous requests.</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object refreshSecurityToken(bool bAsync = false);

						/// <summary>
						/// Trigger a DELETE request to the odata service that was specified in the model constructor.
						/// </summary>
						/// <param name="sPath">A string containing the path to the data that should be removed. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <param name="mParameters">Optional, can contain the following attributes: oContext, fnSuccess, fnError, sETag:</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object remove(string sPath, sap.ui.model.odata.ODataModel.RemoveInfo mParameters);

						/// <summary>
						/// Trigger a DELETE request to the odata service that was specified in the model constructor.
						/// </summary>
						/// <param name="sPath">A string containing the path to the data that should be removed. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object remove(string sPath);

						/// <summary>
						/// Resets the collected changes by the setProperty method and reloads the data from the server.
						/// </summary>
						/// <param name="fnSuccess">a callback function which is called when the data has been successfully resetted. The handler can have the following parameters: oData and response.</param>
						/// <param name="fnError">a callback function which is called when the request failed</param>
						public extern virtual void resetChanges(object fnSuccess, object fnError);

						/// <summary>
						/// Resets the collected changes by the setProperty method and reloads the data from the server.
						/// </summary>
						/// <param name="fnSuccess">a callback function which is called when the data has been successfully resetted. The handler can have the following parameters: oData and response.</param>
						public extern virtual void resetChanges(object fnSuccess);

						/// <summary>
						/// Resets the collected changes by the setProperty method and reloads the data from the server.
						/// </summary>
						public extern virtual void resetChanges();

						/// <summary>
						/// Sets whether this OData service supports $count on its collections.
						/// </summary>
						/// <param name="bCountSupported"></param>
						[Obsolete("Deprecated since 1.20. please use {@link #setDefaultCountMode} instead.")]
						public extern virtual void setCountSupported(bool bCountSupported);

						/// <summary>
						/// Sets the default mode how to retrieve the item count for a collection in this model.
						/// 
						/// The count can be determined in the following ways <ul> <li>by sending a separate <code>$count</code> request</li> <li>by adding parameter <code>$inlinecount=allpages</code> to one or all data requests</li> <li>a combination of the previous two</li> <li>not at all (questions about the size of the collection can't be answered then)</li> </ul> See {@link sap.ui.model.odata.CountMode} for all enumeration values and more details.
						/// 
						/// Note that a call to this method does not modify the count mode for existing list bindings, only bindings that are created afterwards will use the new mode when no mode is defined at their creation.
						/// 
						/// If no default count mode is set for an <code>ODataModel</code> (v1), the mode <code>Both</code> will be used for compatibility reasons.
						/// </summary>
						/// <param name="sCountMode">The new default count mode for this model</param>
						public extern virtual void setDefaultCountMode(sap.ui.model.odata.CountMode sCountMode);

						/// <summary>
						/// Set custom headers which are provided in a key/value map. These headers are used for requests against the OData backend. Private headers which are set in the ODataModel cannot be modified. These private headers are: accept, accept-language, x-csrf-token, MaxDataServiceVersion, DataServiceVersion.
						/// 
						/// To remove these headers simply set the mCustomHeaders parameter to null. Please also note that when calling this method again all previous custom headers are removed unless they are specified again in the mCustomHeaders parameter.
						/// </summary>
						/// <param name="mHeaders">the header name/value map.</param>
						public extern virtual void setHeaders(object mHeaders);

						/// <summary>
						/// Sets a new value for the given property <code>sPropertyName</code> in the model without triggering a server request. This can be done by the submitChanges method.
						/// 
						/// Note: Only one entry of one collection can be updated at once. Otherwise a fireRejectChange event is fired.
						/// 
						/// Before updating a different entry the existing changes of the current entry have to be submitted or resetted by the corresponding methods: submitChanges, resetChanges.
						/// 
						/// IMPORTANT: All pending changes are resetted in the model if the application triggeres any kind of refresh on that entry. Make sure to submit the pending changes first. To determine if there are any pending changes call the hasPendingChanges method.
						/// </summary>
						/// <param name="sPath">path of the property to set</param>
						/// <param name="oValue">value to set the property to</param>
						/// <param name="oContext">the context which will be used to set the property</param>
						/// <param name="bAsyncUpdate">whether to update other bindings dependent on this property asynchronously</param>
						/// <returns>true if the value was set correctly and false if errors occurred like the entry was not found or another entry was already updated.</returns>
						public extern virtual bool setProperty(string sPath, object oValue, sap.ui.model.Context oContext, bool bAsyncUpdate);

						/// <summary>
						/// Sets a new value for the given property <code>sPropertyName</code> in the model without triggering a server request. This can be done by the submitChanges method.
						/// 
						/// Note: Only one entry of one collection can be updated at once. Otherwise a fireRejectChange event is fired.
						/// 
						/// Before updating a different entry the existing changes of the current entry have to be submitted or resetted by the corresponding methods: submitChanges, resetChanges.
						/// 
						/// IMPORTANT: All pending changes are resetted in the model if the application triggeres any kind of refresh on that entry. Make sure to submit the pending changes first. To determine if there are any pending changes call the hasPendingChanges method.
						/// </summary>
						/// <param name="sPath">path of the property to set</param>
						/// <param name="oValue">value to set the property to</param>
						/// <param name="oContext">the context which will be used to set the property</param>
						/// <returns>true if the value was set correctly and false if errors occurred like the entry was not found or another entry was already updated.</returns>
						public extern virtual bool setProperty(string sPath, object oValue, sap.ui.model.Context oContext);

						/// <summary>
						/// Sets a new value for the given property <code>sPropertyName</code> in the model without triggering a server request. This can be done by the submitChanges method.
						/// 
						/// Note: Only one entry of one collection can be updated at once. Otherwise a fireRejectChange event is fired.
						/// 
						/// Before updating a different entry the existing changes of the current entry have to be submitted or resetted by the corresponding methods: submitChanges, resetChanges.
						/// 
						/// IMPORTANT: All pending changes are resetted in the model if the application triggeres any kind of refresh on that entry. Make sure to submit the pending changes first. To determine if there are any pending changes call the hasPendingChanges method.
						/// </summary>
						/// <param name="sPath">path of the property to set</param>
						/// <param name="oValue">value to set the property to</param>
						/// <returns>true if the value was set correctly and false if errors occurred like the entry was not found or another entry was already updated.</returns>
						public extern virtual bool setProperty(string sPath, object oValue);

						/// <summary>
						/// Enable/Disable automatic updates of all Bindings after change operations
						/// </summary>
						/// <param name="bRefreshAfterChange"></param>
						public extern virtual void setRefreshAfterChange(bool bRefreshAfterChange);

						/// <summary>
						/// Enable/Disable XCSRF-Token handling
						/// </summary>
						/// <param name="bTokenHandling">whether to use token handling or not</param>
						public extern virtual void setTokenHandlingEnabled(bool bTokenHandling = true);

						/// <summary>
						/// Enable/Disable batch for all requests
						/// </summary>
						/// <param name="bUseBatch">whether the requests should be encapsulated in a batch request</param>
						public extern virtual void setUseBatch(bool bUseBatch = false);

						/// <summary>
						/// Submits the collected changes in the batch which were collected via <code>addBatchReadOperations</code> or <code>addBatchChangeOperations</code>. The batch will be cleared afterwards. If the batch is empty no request will be performed and false will be returned. Note: No data will be stored in the model.
						/// </summary>
						/// <param name="fnSuccess">a callback function which is called when the batch request has been successfully sent. Note: There might have errors occured in the single batch operations. These errors can be accessed in the aErrorResponses parameter in the callback handler. The handler can have the following parameters: oData, oResponse and aErrorResponses.</param>
						/// <param name="fnError">a callback function which is called when the batch request failed. The handler can have the parameter: oError which contains additional error information.</param>
						/// <param name="bAsync">true for asynchronous request. Default is true.</param>
						/// <param name="bImportData"></param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request. Returns false if no request will be performed because the batch is empty.</returns>
						public extern virtual object submitBatch(object fnSuccess, object fnError, bool bAsync, bool bImportData);

						/// <summary>
						/// Submits the collected changes in the batch which were collected via <code>addBatchReadOperations</code> or <code>addBatchChangeOperations</code>. The batch will be cleared afterwards. If the batch is empty no request will be performed and false will be returned. Note: No data will be stored in the model.
						/// </summary>
						/// <param name="fnError">a callback function which is called when the batch request failed. The handler can have the parameter: oError which contains additional error information.</param>
						/// <param name="bAsync">true for asynchronous request. Default is true.</param>
						/// <param name="bImportData"></param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request. Returns false if no request will be performed because the batch is empty.</returns>
						public extern virtual object submitBatch(object fnError, bool bAsync, bool bImportData);

						/// <summary>
						/// Submits the collected changes in the batch which were collected via <code>addBatchReadOperations</code> or <code>addBatchChangeOperations</code>. The batch will be cleared afterwards. If the batch is empty no request will be performed and false will be returned. Note: No data will be stored in the model.
						/// </summary>
						/// <param name="bAsync">true for asynchronous request. Default is true.</param>
						/// <param name="bImportData"></param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request. Returns false if no request will be performed because the batch is empty.</returns>
						public extern virtual object submitBatch(bool bAsync, bool bImportData);

						/// <summary>
						/// Submits the collected changes in the batch which were collected via <code>addBatchReadOperations</code> or <code>addBatchChangeOperations</code>. The batch will be cleared afterwards. If the batch is empty no request will be performed and false will be returned. Note: No data will be stored in the model.
						/// </summary>
						/// <param name="bImportData"></param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request. Returns false if no request will be performed because the batch is empty.</returns>
						public extern virtual object submitBatch(bool bImportData);

						/// <summary>
						/// Submits the collected changes which were collected by the setProperty method. A MERGE request will be triggered to only update the changed properties. If a URI with a $expand System Query Option was used then the expand entries will be removed from the collected changes. Changes to this entries should be done on the entry itself. So no deep updates are supported.
						/// </summary>
						/// <param name="fnSuccess">a callback function which is called when the data has been successfully updated. The handler can have the following parameters: oData and response.</param>
						/// <param name="fnError">a callback function which is called when the request failed. The handler can have the parameter: oError which contains additional error information</param>
						/// <param name="oParameters">optional parameter for additional information introduced in SAPUI5 1.9.1</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object submitChanges(object fnSuccess, object fnError, sap.ui.model.odata.ODataModel.OperationInfo oParameters);

						/// <summary>
						/// Submits the collected changes which were collected by the setProperty method. A MERGE request will be triggered to only update the changed properties. If a URI with a $expand System Query Option was used then the expand entries will be removed from the collected changes. Changes to this entries should be done on the entry itself. So no deep updates are supported.
						/// </summary>
						/// <param name="fnSuccess">a callback function which is called when the data has been successfully updated. The handler can have the following parameters: oData and response.</param>
						/// <param name="fnError">a callback function which is called when the request failed. The handler can have the parameter: oError which contains additional error information</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object submitChanges(object fnSuccess, object fnError);

						/// <summary>
						/// Submits the collected changes which were collected by the setProperty method. A MERGE request will be triggered to only update the changed properties. If a URI with a $expand System Query Option was used then the expand entries will be removed from the collected changes. Changes to this entries should be done on the entry itself. So no deep updates are supported.
						/// </summary>
						/// <param name="fnSuccess">a callback function which is called when the data has been successfully updated. The handler can have the following parameters: oData and response.</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object submitChanges(object fnSuccess);

						/// <summary>
						/// Submits the collected changes which were collected by the setProperty method. A MERGE request will be triggered to only update the changed properties. If a URI with a $expand System Query Option was used then the expand entries will be removed from the collected changes. Changes to this entries should be done on the entry itself. So no deep updates are supported.
						/// </summary>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object submitChanges();

						/// <summary>
						/// Submits the collected changes which were collected by the setProperty method. A MERGE request will be triggered to only update the changed properties. If a URI with a $expand System Query Option was used then the expand entries will be removed from the collected changes. Changes to this entries should be done on the entry itself. So no deep updates are supported.
						/// </summary>
						/// <param name="fnError">a callback function which is called when the request failed. The handler can have the parameter: oError which contains additional error information</param>
						/// <param name="oParameters">optional parameter for additional information introduced in SAPUI5 1.9.1</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object submitChanges(object fnError, sap.ui.model.odata.ODataModel.OperationInfo oParameters);

						/// <summary>
						/// Submits the collected changes which were collected by the setProperty method. A MERGE request will be triggered to only update the changed properties. If a URI with a $expand System Query Option was used then the expand entries will be removed from the collected changes. Changes to this entries should be done on the entry itself. So no deep updates are supported.
						/// </summary>
						/// <param name="oParameters">optional parameter for additional information introduced in SAPUI5 1.9.1</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object submitChanges(sap.ui.model.odata.ODataModel.OperationInfo oParameters);

						/// <summary>
						/// Trigger a PUT/MERGE request to the odata service that was specified in the model constructor. Please note that deep updates are not supported and may not work. These should be done seperate on the entry directly.
						/// </summary>
						/// <param name="sPath">A string containing the path to the data that should be updated. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <param name="oData">data of the entry that should be updated.</param>
						/// <param name="mParameters">Optional, can contain the following attributes:</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object update(string sPath, object oData, Map mParameters);

						/// <summary>
						/// Trigger a PUT/MERGE request to the odata service that was specified in the model constructor. Please note that deep updates are not supported and may not work. These should be done seperate on the entry directly.
						/// </summary>
						/// <param name="sPath">A string containing the path to the data that should be updated. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
						/// <param name="oData">data of the entry that should be updated.</param>
						/// <returns>an object which has an <code>abort</code> function to abort the current request.</returns>
						public extern virtual object update(string sPath, object oData);

						/// <summary>
						/// update all bindings
						/// </summary>
						/// <param name="bForceUpdate">If set to false an update will only be done when the value of a binding changed.</param>
						public extern virtual void updateBindings(bool bForceUpdate = false);

						#endregion

					}
				}
			}
		}
	}
}
