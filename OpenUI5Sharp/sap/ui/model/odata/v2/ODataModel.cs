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
					public static partial class v2
					{
						/// <summary>
						/// Model implementation based on the OData protocol.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.v2.ODataModel")]
						public partial class ODataModel : sap.ui.model.Model
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class AnnotationsFailedInfo
							{
								/// <summary>
								/// An array of Errors
								/// </summary>
								public Error[] result;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class AnnotationsLoadedInfo
							{
								/// <summary>
								/// An array consisting of one or several annotation sources and/or errors containing a source property and error details.
								/// </summary>
								public sap.ui.model.odata.v2.ODataAnnotations.Source[] result;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class BatchRequestInfo
							{
								/// <summary>
								/// The request ID
								/// </summary>
								public string ID;

								/// <summary>
								/// The URL which is sent to the backend
								/// </summary>
								public string url;

								/// <summary>
								/// The HTTP method
								/// </summary>
								public string method;

								/// <summary>
								/// The request headers
								/// </summary>
								public Map headers;

								/// <summary>
								/// Request was successful or not
								/// </summary>
								public bool success;

								/// <summary>
								/// If the request is synchronous or asynchronous (if available)
								/// </summary>
								public bool async;

								/// <summary>
								/// Array of embedded requests ($batch) Each request object within the array contains the following properties: url, method, headers, response object
								/// </summary>
								public object[] requests;

								/// <summary>
								/// The response object - empty object if no response: The response object contains the following properties: message, success, headers, statusCode, statusText, responseText
								/// </summary>
								public object response;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class BatchRequestSentInfo
							{
								/// <summary>
								/// The URL which is sent to the backend
								/// </summary>
								public string url;

								/// <summary>
								/// The type of the request (if available)
								/// </summary>
								public string type;

								/// <summary>
								/// If the request is synchronous or asynchronous (if available)
								/// </summary>
								public bool async;

								/// <summary>
								/// Array of embedded requests ($batch) Each request object within the array contains the following properties: url, method, headers
								/// </summary>
								public object[] requests;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class MetadataFailedInfo
							{
								/// <summary>
								/// The parsed metadata
								/// </summary>
								public string metadata;

								/// <summary>
								/// A text that describes the failure.
								/// </summary>
								public string message;

								/// <summary>
								/// HTTP status code returned by the request (if available)
								/// </summary>
								public string statusCode;

								/// <summary>
								/// The status as a text, details not specified, intended only for diagnosis output
								/// </summary>
								public string statusText;

								/// <summary>
								/// Response that has been received for the request, as a text string
								/// </summary>
								public string responseText;

								/// <summary>
								/// The response object - empty object if no response
								/// </summary>
								public object response;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class MetadataLoadedInfo
							{
								/// <summary>
								/// The parsed metadata
								/// </summary>
								public string metadata;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class RequestInfo
							{
								/// <summary>
								/// The request ID
								/// </summary>
								public string ID;

								/// <summary>
								/// The URL which is sent to the backend
								/// </summary>
								public string url;

								/// <summary>
								/// The HTTP method
								/// </summary>
								public string method;

								/// <summary>
								/// The request headers
								/// </summary>
								public Map headers;

								/// <summary>
								/// Request was successful or not
								/// </summary>
								public bool success;

								/// <summary>
								/// If the request is synchronous or asynchronous (if available)
								/// </summary>
								public bool async;

								/// <summary>
								/// The response object - empty object if no response: The response object contains the following properties: message, success, headers, statusCode, statusText, responseText
								/// </summary>
								public object response;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class RequestSentInfo
							{
								/// <summary>
								/// The request ID
								/// </summary>
								public string ID;

								/// <summary>
								/// The URL which is sent to the backend
								/// </summary>
								public string url;

								/// <summary>
								/// The HTTP method
								/// </summary>
								public string method;

								/// <summary>
								/// The request headers
								/// </summary>
								public Map headers;

								/// <summary>
								/// If the request is synchronous or asynchronous (if available)
								/// </summary>
								public bool async;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class ODataModelInfo
							{
								/// <summary>
								/// Base URI of the service to request data from; this property is mandatory when the first method parameter <code>serviceUrl</code> is omitted, but ignored otherwise
								/// </summary>
								public object serviceUrl;

								/// <summary>
								/// If set to <code>true</code>, request payloads will be JSON, XML for <code>false</code>
								/// </summary>
								public bool json;

								/// <summary>
								/// User for the service
								/// </summary>
								public string user;

								/// <summary>
								/// Password for service
								/// </summary>
								public string password;

								/// <summary>
								/// Map of custom headers (name/value pairs) like {"myHeader":"myHeaderValue",...}
								/// </summary>
								public Map headers;

								/// <summary>
								/// Enable/disable XCSRF-Token handling
								/// </summary>
								public bool tokenHandling;

								/// <summary>
								/// Experimental - <code>true</code> when user credentials are to be included in a cross-origin reques; please note that this only works if all requests are asynchronous
								/// </summary>
								public bool withCredentials;

								/// <summary>
								/// Please use the following string format e.g. '2.0' or '3.0'. OData version supported by the ODataModel: '2.0'
								/// </summary>
								public object maxDataServiceVersion;

								/// <summary>
								/// Whether all requests should be sent in batch requests
								/// </summary>
								public bool useBatch;

								/// <summary>
								/// Enable/disable automatic refresh after change operations
								/// </summary>
								public bool refreshAfterChange;

								/// <summary>
								/// The URL (or an array of URLs) from which the annotation metadata should be loaded
								/// </summary>
								public Union<string, string[]> annotationURI;

								/// <summary>
								/// Whether the <code>metadataLoaded</code> event will be fired only after all annotations have been loaded as well
								/// </summary>
								public bool loadAnnotationsJoined;

								/// <summary>
								/// Map of URL parameters (name/value pairs) - these parameters will be attached to all requests
								/// </summary>
								public Map serviceUrlParams;

								/// <summary>
								/// Map of URL parameters for metadata requests - only attached to a <code>$metadata</code> request
								/// </summary>
								public Map metadataUrlParams;

								/// <summary>
								/// Sets the default binding mode for the model
								/// </summary>
								public sap.ui.model.BindingMode defaultBindingMode;

								/// <summary>
								/// Sets the default count mode for the model
								/// </summary>
								public sap.ui.model.odata.CountMode defaultCountMode;

								/// <summary>
								/// Whether a preliminary Context will be created/used by a binding
								/// </summary>
								public bool preliminaryContext;

								/// <summary>
								/// Sets the default operation mode for the model
								/// </summary>
								public sap.ui.model.odata.OperationMode defaultOperationMode;

								/// <summary>
								/// Default update method which is used for all update requests
								/// </summary>
								public sap.ui.model.odata.UpdateMethod defaultUpdateMethod;

								/// <summary>
								/// Map of namespace aliases (alias => URI) that can be used in metadata binding paths; each alias is mapped to a corresponding namespace URI; when an alias is used in a metadata binding path, it addresses a metadata extension that belongs to the corresponding namespace URI; if <code>metadataNamespaces</code> is not given, the following default mappings will be used: <ul> <li><code>"sap": "sap:"http://www.sap.com/Protocols/SAPData"</code></li> <li><code> "m": "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata"</code></li> <li><code> "": "http://schemas.microsoft.com/ado/2007/06/edmx</code></li> </ul>
								/// </summary>
								public Map<string> metadataNamespaces;

								/// <summary>
								/// Whether to skip the automated loading of annotations from the metadata document. Loading annotations from metadata does not have any effects (except the lost performance by invoking the parser) if there are not annotations inside the metadata document
								/// </summary>
								public bool skipMetadataAnnotationParsing;

								/// <summary>
								/// Set this flag to <code>true</code> if your service does not support <code>HEAD</code> requests for fetching the service document (and thus the CSRF-token) to avoid sending a <code>HEAD</code>-request before falling back to <code>GET</code>
								/// </summary>
								public bool disableHeadRequestForToken;

								/// <summary>
								/// Whether to sequentialize all requests, needed in case the service cannot handle parallel requests
								/// </summary>
								public bool sequentializeRequests;

								/// <summary>
								/// Set this flag to <code>true</code> if you don´t want to start a new soft state session with context ID (<code>SID</code>) through header mechanism. This is useful if you want to share an <code>SID</code> between different browser windows
								/// </summary>
								public bool disableSoftStateHeader;

								/// <summary>
								/// Set this array to make custom response headers bindable via the entity's "__metadata/headers" property
								/// </summary>
								public string[] bindableResponseHeaders;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class BindListInfo
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
								/// Optional map of custom query parameters (name/value pairs); names of custom parameters must not start with <code>$</code>
								/// </summary>
								public Map custom;

								/// <summary>
								/// Count mode for this binding; if not specified, the default count mode for this model is used
								/// </summary>
								public sap.ui.model.odata.CountMode countMode;

								/// <summary>
								/// Operation mode for this binding; if not specified, the default operation mode of this model is used
								/// </summary>
								public sap.ui.model.odata.OperationMode operationMode;

								/// <summary>
								/// Turns on the fault tolerance mode, data is not reset if a backend request returns an error
								/// </summary>
								public bool faultTolerant;

								/// <summary>
								/// Sets the batch group ID to be used for requests originating from this binding
								/// </summary>
								public string batchGroupId;

								/// <summary>
								/// Threshold that defines how many entries should be fetched at least by the binding if <code>operationMode</code> is set to <code>Auto</code> (See documentation for {@link sap.ui.model.odata.OperationMode.Auto})
								/// </summary>
								public int threshold;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class BindTreeInfo
							{
								/// <summary>
								/// This parameter defines the mapping between data properties and the hierarchy used to visualize the tree, if not provided by the services metadata. For correct metadata annotation, please check the "SAP Annotations for OData Version 2.0" Specification.
								/// </summary>
								public sap.ui.model.odata.v2.ODataModel.TreeAnnotationPropertiesInfo treeAnnotationProperties;

								/// <summary>
								/// A map describing the navigation properties between entity sets, which should be used for constructing and paging the tree.
								/// </summary>
								public object navigation;

								/// <summary>
								/// This property defines the number of levels, which will be expanded initially. Please be aware, that this property leads to multiple backend requests. Default value is 0.
								/// </summary>
								public int numberOfExpandedLevels;

								/// <summary>
								/// The root level is the level of the topmost tree nodes, which will be used as an entry point for OData services. Conforming to the "SAP Annotations for OData Version 2.0" Specification, the root level must start at 0. Default value is therefore 0.
								/// </summary>
								public int rootLevel;

								/// <summary>
								/// Deprecated - use <code>groupId</code> instead: sets the batch group ID to be used for requests originating from this binding
								/// </summary>
								public string batchGroupId;

								/// <summary>
								/// ID of a request group; requests belonging to the same group will be bundled in one batch request
								/// </summary>
								public string groupId;

								/// <summary>
								/// Operation mode for this binding; defaults to the model's default operation mode when not specified
								/// </summary>
								public sap.ui.model.odata.OperationMode operationMode;

								/// <summary>
								/// A threshold, which will be used if the operation mode is set to <code>Auto</code>. In case of <code>OperationMode.Auto</code>, the binding tries to fetch (at least) as many entries as the threshold. Also see API documentation for {@link sap.ui.model.odata.OperationMode.Auto}.
								/// </summary>
								public int threshold;

								/// <summary>
								/// Set this flag if <code>$filter</code> statements should be used for the <code>$count/$inlinecount</code> and data retrieval in the <code>OperationMode.Auto</code>. Only use this if your backend supports prefiltering the tree and is capable of responding a complete tree hierarchy, including all inner nodes. To construct the hierarchy on the client, it is mandatory that all filter matches include their complete parent chain up to the root level. <code>OperationMode.Client</code> will still request the complete collection without filters, since they will be applied on the client.
								/// </summary>
								public bool useServersideApplicationFilters;

								/// <summary>
								/// A tree state handle can be given to the <code>ODataTreeBinding</code> when two conditions are met: The binding is running in <code>OperationMode.Client</code> AND the <code>sap.ui.table.TreeTable</code> is used. The feature is only available when using the <code>ODataTreeBindingAdapter</code>, which is automatically applied when using the <code>sap.ui.table.TreeTable</code>. The tree state handle will contain all necessary information to expand the tree to the given state. This feature is not supported in <code>OperationMode.Server</code> and <code>OperationMode.Auto</code>. Please see also the {@link sap.ui.model.odata.ODataTreeBindingAdapter#getCurrentTreeState getCurrentTreeState} function in the class <code>ODataTreeBindingAdapter</code>.
								/// </summary>
								public bool treeState;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class TreeAnnotationPropertiesInfo
							{
								/// <summary>
								/// Mapping to the property holding the level information,
								/// </summary>
								public int hierarchyLevelFor;

								/// <summary>
								/// Mapping to the property holding the hierarchy node ID,
								/// </summary>
								public string hierarchyNodeFor;

								/// <summary>
								/// Mapping to the property holding the parent node ID,
								/// </summary>
								public string hierarchyParentNodeFor;

								/// <summary>
								/// Mapping to the property holding the drill state for the node,
								/// </summary>
								public string hierarchyDrillStateFor;

								/// <summary>
								/// Mapping to the property holding the descendant count for the node.
								/// </summary>
								public string hierarchyNodeDescendantCountFor;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class CallFunctionInfo
							{
								/// <summary>
								/// HTTP method to use for the function call, should match the metadata for the function import
								/// </summary>
								public string method;

								/// <summary>
								/// A map containing the parameters that will be passed as query strings
								/// </summary>
								public Map urlParameters;

								/// <summary>
								/// A callback function which is called when the data has been successfully retrieved. The handler can have the following parameters: <code>oData</code> and <code>response</code>.
								/// </summary>
								public object success;

								/// <summary>
								/// A callback function which is called when the request failed. The handler can have the parameter: <code>oError</code> which contains additional error information.
								/// </summary>
								public object error;

								/// <summary>
								/// A map of headers for this request
								/// </summary>
								public Map headers;

								/// <summary>
								/// Deprecated - use <code>groupId</code> instead
								/// </summary>
								public string batchGroupId;

								/// <summary>
								/// ID of a request group; requests belonging to the same group will be bundled in one batch request
								/// </summary>
								public string groupId;

								/// <summary>
								/// If the function import changes an entity, the ETag for this entity could be passed with this parameter
								/// </summary>
								public string eTag;

								/// <summary>
								/// ID of the <code>ChangeSet</code> that this request should belong to
								/// </summary>
								public string changeSetId;

								/// <summary>
								/// Since 1.46; defines whether to update all bindings after submitting this change operation. See {@link #setRefreshAfterChange} If given, this overrules the model-wide <code>refreshAfterChange</code> flag for this operation only.
								/// </summary>
								public string refreshAfterChange;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class CreateInfo
							{
								/// <summary>
								/// If specified , <code>sPath</code> has to be relative to the path given with the context.
								/// </summary>
								public object context;

								/// <summary>
								/// A callback function which is called when the data has been successfully retrieved. The handler can have the following parameters: <code>oData</code> and <code>response</code>. The <code>oData</code> parameter contains the data of the newly created entry if it is provided by the backend. The <code>response</code> parameter contains information about the response of the request.
								/// </summary>
								public object success;

								/// <summary>
								/// A callback function which is called when the request failed. The handler can have the parameter <code>oError</code> which contains additional error information.
								/// </summary>
								public object error;

								/// <summary>
								/// A map containing the parameters that will be passed as query strings
								/// </summary>
								public Map urlParameters;

								/// <summary>
								/// A map of headers for this request
								/// </summary>
								public Map headers;

								/// <summary>
								/// Deprecated - use <code>groupId</code> instead
								/// </summary>
								public string batchGroupId;

								/// <summary>
								/// ID of a request group; requests belonging to the same group will be bundled in one batch request
								/// </summary>
								public string groupId;

								/// <summary>
								/// ID of the <code>ChangeSet</code> that this request should belong to
								/// </summary>
								public string changeSetId;

								/// <summary>
								/// Since 1.46; defines whether to update all bindings after submitting this change operation. See {@link #setRefreshAfterChange} If given, this overrules the model-wide <code>refreshAfterChange</code> flag for this operation only.
								/// </summary>
								public string refreshAfterChange;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class CreateBindingContextInfo
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
								/// Whether a preliminary Context will be created
								/// </summary>
								public bool preliminaryContext;

								/// <summary>
								/// Optional map of custom query parameters, names of custom parameters must not start with <code>$</code>.
								/// </summary>
								public Map custom;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class CreateEntryInfo
							{
								/// <summary>
								/// An array that specifies a set of properties or the entry
								/// </summary>
								public Union<object[], object> properties;

								/// <summary>
								/// Deprecated - use <code>groupId</code> instead
								/// </summary>
								public string batchGroupId;

								/// <summary>
								/// ID of a request group; requests belonging to the same group will be bundled in one batch request
								/// </summary>
								public string groupId;

								/// <summary>
								/// ID of the <code>ChangeSet</code> that this request should belong to
								/// </summary>
								public string changeSetId;

								/// <summary>
								/// The binding context
								/// </summary>
								public sap.ui.model.Context context;

								/// <summary>
								/// The success callback function
								/// </summary>
								public object success;

								/// <summary>
								/// The error callback function
								/// </summary>
								public object error;

								/// <summary>
								/// A map of headers
								/// </summary>
								public Map headers;

								/// <summary>
								/// A map of URL parameters
								/// </summary>
								public Map urlParameters;

								/// <summary>
								/// Since 1.46; defines whether to update all bindings after submitting this change operation. See {@link #setRefreshAfterChange} If given, this overrules the model-wide <code>refreshAfterChange</code> flag for this operation only.
								/// </summary>
								public string refreshAfterChange;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class GetObjectInfo
							{
								/// <summary>
								/// Comma-separated list of properties/paths to select
								/// </summary>
								public string select;

								/// <summary>
								/// Comma-separated list of navigation properties/paths to expand
								/// </summary>
								public string expand;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class ReadInfo
							{
								/// <summary>
								/// If specified, <code>sPath</code> has to be relative to the path given with the context.
								/// </summary>
								public object context;

								/// <summary>
								/// A map containing the parameters that will be passed as query strings
								/// </summary>
								public Map urlParameters;

								/// <summary>
								/// An array of filters to be included in the request URL
								/// </summary>
								public sap.ui.model.Filter[] filters;

								/// <summary>
								/// An array of sorters to be included in the request URL
								/// </summary>
								public sap.ui.model.Sorter[] sorters;

								/// <summary>
								/// A callback function which is called when the data has been successfully retrieved. The handler can have the following parameters: <code>oData</code> and <code>response</code>. The <code>oData</code> parameter contains the data of the retrieved data. The <code>response</code> parameter contains further information about the response of the request.
								/// </summary>
								public object success;

								/// <summary>
								/// A callback function which is called when the request failed. The handler can have the parameter: <code>oError</code> which contains additional error information.
								/// </summary>
								public object error;

								/// <summary>
								/// Deprecated - use <code>groupId</code> instead
								/// </summary>
								public string batchGroupId;

								/// <summary>
								/// ID of a request group; requests belonging to the same group will be bundled in one batch request
								/// </summary>
								public string groupId;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class Info
							{
								/// <summary>
								/// If specified, <code>sPath</code> has to be relative to the path given with the context.
								/// </summary>
								public object context;

								/// <summary>
								/// A callback function which is called when the data has been successfully retrieved. The handler can have the following parameters: <code>oData</code> and <code>response</code>.
								/// </summary>
								public object success;

								/// <summary>
								/// A callback function which is called when the request failed. The handler can have the parameter: <code>oError</code> which contains additional error information.
								/// </summary>
								public object error;

								/// <summary>
								/// If specified, the <code>If-Match</code> header will be set to this ETag.
								/// </summary>
								public string eTag;

								/// <summary>
								/// A map containing the parameters that will be passed as query strings
								/// </summary>
								public Map urlParameters;

								/// <summary>
								/// A map of headers for this request
								/// </summary>
								public Map headers;

								/// <summary>
								/// Deprecated - use <code>groupId</code> instead
								/// </summary>
								public string batchGroupId;

								/// <summary>
								/// ID of a request group; requests belonging to the same group will be bundled in one batch request
								/// </summary>
								public string groupId;

								/// <summary>
								/// ID of the <code>ChangeSet</code> that this request should belong to
								/// </summary>
								public string changeSetId;

								/// <summary>
								/// Since 1.46; defines whether to update all bindings after submitting this change operation. See {@link #setRefreshAfterChange} If given, this overrules the model-wide <code>refreshAfterChange</code> flag for this operation only.
								/// </summary>
								public string refreshAfterChange;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class SubmitChangesInfo
							{
								/// <summary>
								/// Deprecated - use <code>groupId</code> instead
								/// </summary>
								public string batchGroupId;

								/// <summary>
								/// Defines the group that should be submitted. If not specified all deferred groups will be submitted. Requests belonging to the same group will be bundled in one batch request.
								/// </summary>
								public string groupId;

								/// <summary>
								/// A callback function which is called when the data has been successfully updated. The handler can have the following parameters: <code>oData</code>. <code>oData</code> contains the parsed response data as a Javascript object. The batch response is in the <code>__batchResponses</code> property which may contain further <code>__changeResponses</code> in an array depending on the amount of changes and change sets of the actual batch request which was sent to the backend. The changeResponses contain the actual response of that change set in the <code>response</code> property. For each change set there is also a <code>__changeResponse</code> property.
								/// </summary>
								public object success;

								/// <summary>
								/// A callback function which is called when the request failed. The handler can have the parameter: <code>oError</code> which contains additional error information
								/// </summary>
								public object error;

								/// <summary>
								/// An ETag which can be used for concurrency control. If it is specified, it will be used in an <code>If-Match</code> header in the request to the server for this entry
								/// </summary>
								public string eTag;

							}

							#endregion

							#region Delegates

							public delegate void AnnotationsFailedDelegate(sap.ui.@base.Event<sap.ui.model.odata.v2.ODataModel.AnnotationsFailedInfo> oEvent, object oData);

							public delegate void AnnotationsLoadedDelegate(sap.ui.@base.Event<sap.ui.model.odata.v2.ODataModel.AnnotationsLoadedInfo> oEvent, object oData);

							public delegate void BatchRequestDelegate(sap.ui.@base.Event<sap.ui.model.odata.v2.ODataModel.BatchRequestInfo> oEvent, object oData);

							public delegate void BatchRequestSentDelegate(sap.ui.@base.Event<sap.ui.model.odata.v2.ODataModel.BatchRequestSentInfo> oEvent, object oData);

							public delegate void MetadataFailedDelegate(sap.ui.@base.Event<sap.ui.model.odata.v2.ODataModel.MetadataFailedInfo> oEvent, object oData);

							public delegate void MetadataLoadedDelegate(sap.ui.@base.Event<sap.ui.model.odata.v2.ODataModel.MetadataLoadedInfo> oEvent, object oData);

							public delegate void RequestDelegate(sap.ui.@base.Event<sap.ui.model.odata.v2.ODataModel.RequestInfo> oEvent, object oData);

							public delegate void RequestSentDelegate(sap.ui.@base.Event<sap.ui.model.odata.v2.ODataModel.RequestSentInfo> oEvent, object oData);

							#endregion

							#region Constructor

							/// <summary>
							/// Constructor for a new ODataModel.
							/// </summary>
							/// <param name="serviceUrl">Base URI of the service to request data from; additional URL parameters appended here will be appended to every request. If you pass an object it will be interpreted as the parameter object (second parameter). Then <code>mParameters.serviceUrl</code> becomes a mandatory parameter.</param>
							/// <param name="mParameters">Map which contains the following parameter properties:</param>
							public extern ODataModel(Union<string, object> serviceUrl, sap.ui.model.odata.v2.ODataModel.ODataModelInfo mParameters);

							/// <summary>
							/// Constructor for a new ODataModel.
							/// </summary>
							/// <param name="serviceUrl">Base URI of the service to request data from; additional URL parameters appended here will be appended to every request. If you pass an object it will be interpreted as the parameter object (second parameter). Then <code>mParameters.serviceUrl</code> becomes a mandatory parameter.</param>
							public extern ODataModel(Union<string, object> serviceUrl);

							#endregion

							#region Methods

							#region Methods for event annotationsFailed

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>annotationsFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachAnnotationsFailed(object oData, sap.ui.model.odata.v2.ODataModel.AnnotationsFailedDelegate fnFunction, object oListener);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>annotationsFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachAnnotationsFailed(object oData, sap.ui.model.odata.v2.ODataModel.AnnotationsFailedDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>annotationsFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachAnnotationsFailed(sap.ui.model.odata.v2.ODataModel.AnnotationsFailedDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>annotationsFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachAnnotationsFailed(sap.ui.model.odata.v2.ODataModel.AnnotationsFailedDelegate fnFunction, object oListener);

							/// <summary>
							/// Detach event-handler <code>fnFunction</code> from the <code>annotationsFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// 
							/// The passed function and listener object must match the ones previously used for event registration.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs.</param>
							/// <param name="oListener">Object on which the given function had to be called.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel detachAnnotationsFailed(sap.ui.model.odata.v2.ODataModel.AnnotationsFailedDelegate fnFunction, object oListener);

							/// <summary>
							/// Fire event <code>annotationsFailed</code> to attached listeners.
							/// </summary>
							/// <param name="mArguments">The arguments to pass along with the event</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireAnnotationsFailed(sap.ui.model.odata.v2.ODataModel.AnnotationsFailedInfo mArguments);

							/// <summary>
							/// Fire event <code>annotationsFailed</code> to attached listeners.
							/// </summary>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireAnnotationsFailed();

							#endregion

							#region Methods for event annotationsLoaded

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>annotationsLoaded</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachAnnotationsLoaded(object oData, sap.ui.model.odata.v2.ODataModel.AnnotationsLoadedDelegate fnFunction, object oListener);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>annotationsLoaded</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachAnnotationsLoaded(object oData, sap.ui.model.odata.v2.ODataModel.AnnotationsLoadedDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>annotationsLoaded</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachAnnotationsLoaded(sap.ui.model.odata.v2.ODataModel.AnnotationsLoadedDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>annotationsLoaded</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachAnnotationsLoaded(sap.ui.model.odata.v2.ODataModel.AnnotationsLoadedDelegate fnFunction, object oListener);

							/// <summary>
							/// Detach event-handler <code>fnFunction</code> from the <code>annotationsLoaded</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs.</param>
							/// <param name="oListener">Object on which the given function had to be called.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel detachAnnotationsLoaded(sap.ui.model.odata.v2.ODataModel.AnnotationsLoadedDelegate fnFunction, object oListener);

							/// <summary>
							/// Fire event <code>annotationsLoaded</code> to attached listeners.
							/// </summary>
							/// <param name="mArguments">The arguments to pass along with the event</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireAnnotationsLoaded(sap.ui.model.odata.v2.ODataModel.AnnotationsLoadedInfo mArguments);

							/// <summary>
							/// Fire event <code>annotationsLoaded</code> to attached listeners.
							/// </summary>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireAnnotationsLoaded();

							#endregion

							#region Methods for event batchRequestCompleted

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>batchRequestCompleted</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestCompleted(object oData, sap.ui.model.odata.v2.ODataModel.BatchRequestDelegate fnFunction, object oListener);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>batchRequestCompleted</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestCompleted(object oData, sap.ui.model.odata.v2.ODataModel.BatchRequestDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>batchRequestCompleted</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestCompleted(sap.ui.model.odata.v2.ODataModel.BatchRequestDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>batchRequestCompleted</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestCompleted(sap.ui.model.odata.v2.ODataModel.BatchRequestDelegate fnFunction, object oListener);

							/// <summary>
							/// Detach event-handler <code>fnFunction</code> from the <code>batchRequestCompleted</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// 
							/// The passed function and listener object must match the ones previously used for event registration.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs.</param>
							/// <param name="oListener">Object on which the given function had to be called.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel detachBatchRequestCompleted(sap.ui.model.odata.v2.ODataModel.BatchRequestDelegate fnFunction, object oListener);

							/// <summary>
							/// Fire event <code>batchRequestCompleted</code> to attached listeners.
							/// </summary>
							/// <param name="mArguments">parameters to add to the fired event</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireBatchRequestCompleted(sap.ui.model.odata.v2.ODataModel.BatchRequestInfo mArguments);

							#endregion

							#region Methods for event batchRequestFailed

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>batchRequestFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, this Model is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestFailed(object oData, sap.ui.model.odata.v2.ODataModel.BatchRequestDelegate fnFunction, object oListener);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>batchRequestFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestFailed(object oData, sap.ui.model.odata.v2.ODataModel.BatchRequestDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>batchRequestFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestFailed(sap.ui.model.odata.v2.ODataModel.BatchRequestDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>batchRequestFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, this Model is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestFailed(sap.ui.model.odata.v2.ODataModel.BatchRequestDelegate fnFunction, object oListener);

							/// <summary>
							/// Detach event-handler <code>fnFunction</code> from the <code>batchRequestFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.<br/>
							/// 
							/// The passed function and listener object must match the ones previously used for event registration.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs.</param>
							/// <param name="oListener">Object on which the given function had to be called.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel detachBatchRequestFailed(sap.ui.model.odata.v2.ODataModel.BatchRequestDelegate fnFunction, object oListener);

							/// <summary>
							/// Fire event <code>batchRequestFailed</code> to attached listeners.
							/// </summary>
							/// <param name="mArguments">the arguments to pass along with the event.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireBatchRequestFailed(sap.ui.model.odata.v2.ODataModel.BatchRequestInfo mArguments);

							#endregion

							#region Methods for event batchRequestSent

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>requestSent</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestSent(object oData, sap.ui.model.odata.v2.ODataModel.BatchRequestSentDelegate fnFunction, object oListener);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>requestSent</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestSent(object oData, sap.ui.model.odata.v2.ODataModel.BatchRequestSentDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>requestSent</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestSent(sap.ui.model.odata.v2.ODataModel.BatchRequestSentDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>requestSent</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachBatchRequestSent(sap.ui.model.odata.v2.ODataModel.BatchRequestSentDelegate fnFunction, object oListener);

							/// <summary>
							/// Detach event-handler <code>fnFunction</code> from the <code>batchRequestSent</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// 
							/// The passed function and listener object must match the ones previously used for event registration.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs.</param>
							/// <param name="oListener">Object on which the given function had to be called.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel detachBatchRequestSent(sap.ui.model.odata.v2.ODataModel.BatchRequestSentDelegate fnFunction, object oListener);

							/// <summary>
							/// Fire event <code>batchRequestSent</code> to attached listeners.
							/// </summary>
							/// <param name="mArguments">the arguments to pass along with the event.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireBatchRequestSent(sap.ui.model.odata.v2.ODataModel.BatchRequestSentInfo mArguments);

							/// <summary>
							/// Fire event <code>batchRequestSent</code> to attached listeners.
							/// </summary>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireBatchRequestSent();

							#endregion

							#region Methods for event metadataFailed

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>metadataFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachMetadataFailed(object oData, sap.ui.model.odata.v2.ODataModel.MetadataFailedDelegate fnFunction, object oListener);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>metadataFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachMetadataFailed(object oData, sap.ui.model.odata.v2.ODataModel.MetadataFailedDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>metadataFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachMetadataFailed(sap.ui.model.odata.v2.ODataModel.MetadataFailedDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>metadataFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachMetadataFailed(sap.ui.model.odata.v2.ODataModel.MetadataFailedDelegate fnFunction, object oListener);

							/// <summary>
							/// Detach event-handler <code>fnFunction</code> from the <code>metadataFailed</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// 
							/// The passed function and listener object must match the ones previously used for event registration.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs.</param>
							/// <param name="oListener">Object on which the given function had to be called.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel detachMetadataFailed(sap.ui.model.odata.v2.ODataModel.MetadataFailedDelegate fnFunction, object oListener);

							/// <summary>
							/// Fire event <code>metadataFailed</code> to attached listeners.
							/// </summary>
							/// <param name="mArguments">the arguments to pass along with the event.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireMetadataFailed(sap.ui.model.odata.v2.ODataModel.MetadataFailedInfo mArguments);

							/// <summary>
							/// Fire event <code>metadataFailed</code> to attached listeners.
							/// </summary>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireMetadataFailed();

							#endregion

							#region Methods for event metadataLoaded

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>metadataLoaded</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachMetadataLoaded(object oData, sap.ui.model.odata.v2.ODataModel.MetadataLoadedDelegate fnFunction, object oListener);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>metadataLoaded</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachMetadataLoaded(object oData, sap.ui.model.odata.v2.ODataModel.MetadataLoadedDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>metadataLoaded</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachMetadataLoaded(sap.ui.model.odata.v2.ODataModel.MetadataLoadedDelegate fnFunction);

							/// <summary>
							/// Attach event-handler <code>fnFunction</code> to the <code>metadataLoaded</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
							/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel attachMetadataLoaded(sap.ui.model.odata.v2.ODataModel.MetadataLoadedDelegate fnFunction, object oListener);

							/// <summary>
							/// Detach event-handler <code>fnFunction</code> from the <code>metadataLoaded</code> event of this <code>sap.ui.model.odata.v2.ODataModel</code>.
							/// 
							/// The passed function and listener object must match the ones previously used for event registration.
							/// </summary>
							/// <param name="fnFunction">The function to call, when the event occurs.</param>
							/// <param name="oListener">Object on which the given function had to be called.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel detachMetadataLoaded(sap.ui.model.odata.v2.ODataModel.MetadataLoadedDelegate fnFunction, object oListener);

							/// <summary>
							/// Fire event <code>metadataLoaded</code> to attached listeners.
							/// </summary>
							/// <param name="mArguments">the arguments to pass along with the event.</param>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireMetadataLoaded(sap.ui.model.odata.v2.ODataModel.MetadataLoadedInfo mArguments);

							/// <summary>
							/// Fire event <code>metadataLoaded</code> to attached listeners.
							/// </summary>
							/// <returns><code>this</code> to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataModel fireMetadataLoaded();

							#endregion

							#region Other methods

							/// <summary>
							/// Adds (a) new URL(s) whose content should be parsed as OData annotations, which are then merged into the annotations object which can be retrieved by calling the {@link #getServiceAnnotations}-method. If a <code>$metadata</code> URL is passed, the data will also be merged into the metadata object, which can be reached by calling the {@link #getServiceMetadata} method.
							/// </summary>
							/// <param name="vUrl">Either one URL as string or an array of URL strings</param>
							/// <returns>The Promise to load the given URL(s), resolved if all URLs have been loaded, rejected if at least one fails to load. If this promise resolves it returns an object with the following properties: <code>annotations</code>: The annotation object <code>entitySets</code>: An array of EntitySet objects containing the newly merged EntitySets from a <code>$metadata</code> requests. The structure is the same as in the metadata object reached by the <code>getServiceMetadata()</code> method. For non-<code>$metadata</code> requests the array will be empty.</returns>
							public extern virtual jquery.JQueryPromise<object> addAnnotationUrl(Union<string, string[]> vUrl);

							/// <summary>
							/// Adds new XML content to be parsed for OData annotations, which are then merged into the annotations object which can be retrieved by calling the {@link #getServiceAnnotations}-method.
							/// </summary>
							/// <param name="sXMLContent">The string that should be parsed as annotation XML</param>
							/// <param name="bSuppressEvents">Whether not to fire annotationsLoaded event on the annotationParser</param>
							/// <returns>The Promise to parse the given XML-String, resolved if parsed without errors, rejected if errors occur</returns>
							public extern virtual jquery.JQueryPromise<object> addAnnotationXML(string sXMLContent, bool bSuppressEvents = false);

							/// <summary>
							/// Returns a promise that resolves with an array containing information about the initially loaded annotations.
							/// 
							/// <b>Important</b>: This covers the annotations that were given to the model constructor, not the ones that might have been added later on using the protected API method {@link #addAnnotationUrl}. In order to get information about those, the event <code>annotationsLoaded</code> can be used.
							/// </summary>
							/// <returns>A promise to load the annotation URLs that were given to the model on instantiation</returns>
							public extern virtual jquery.JQueryPromise<object> annotationsLoaded();

							/// <summary>
							/// Creates new context binding for this model.
							/// </summary>
							/// <param name="sPath">Resolved path</param>
							/// <param name="oContext">Context object</param>
							/// <param name="mParameters">Map of parameters</param>
							/// <returns>The new context binding</returns>
							public extern virtual sap.ui.model.ContextBinding bindContext(string sPath, sap.ui.model.Context oContext, Map mParameters);

							/// <summary>
							/// Creates new context binding for this model.
							/// </summary>
							/// <param name="sPath">Resolved path</param>
							/// <param name="oContext">Context object</param>
							/// <returns>The new context binding</returns>
							public extern virtual sap.ui.model.ContextBinding bindContext(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Creates a new list binding for this model.
							/// </summary>
							/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
							/// <param name="oContext">Binding context referring to this model</param>
							/// <param name="aSorters">Initial sort order, can be either a sorter or an array of sorters</param>
							/// <param name="aFilters">Predefined filters, can be either a filter or an array of filters</param>
							/// <param name="mParameters">Map which contains additional parameters for the binding</param>
							/// <returns>The new list binding</returns>
							public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, Map mParameters);

							/// <summary>
							/// Creates a new list binding for this model.
							/// </summary>
							/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
							/// <param name="oContext">Binding context referring to this model</param>
							/// <param name="aSorters">Initial sort order, can be either a sorter or an array of sorters</param>
							/// <param name="aFilters">Predefined filters, can be either a filter or an array of filters</param>
							/// <returns>The new list binding</returns>
							public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

							/// <summary>
							/// Creates a new list binding for this model.
							/// </summary>
							/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
							/// <param name="oContext">Binding context referring to this model</param>
							/// <param name="aSorters">Initial sort order, can be either a sorter or an array of sorters</param>
							/// <returns>The new list binding</returns>
							public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters);

							/// <summary>
							/// Creates a new list binding for this model.
							/// </summary>
							/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
							/// <param name="oContext">Binding context referring to this model</param>
							/// <returns>The new list binding</returns>
							public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Creates a new list binding for this model.
							/// </summary>
							/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
							/// <returns>The new list binding</returns>
							public extern virtual sap.ui.model.ListBinding bindList(string sPath);

							/// <summary>
							/// Creates a new property binding for this model.
							/// </summary>
							/// <param name="sPath">Path pointing to the property that should be bound; either an absolute path or a path relative to a given <code>oContext</code></param>
							/// <param name="oContext">A context object for the new binding</param>
							/// <param name="mParameters">Map of optional parameters for the binding; the ODataModel (v2) currently supports no additional parameters</param>
							/// <returns>The new property binding</returns>
							public extern virtual sap.ui.model.PropertyBinding bindProperty(string sPath, object oContext, Map mParameters);

							/// <summary>
							/// Creates a new property binding for this model.
							/// </summary>
							/// <param name="sPath">Path pointing to the property that should be bound; either an absolute path or a path relative to a given <code>oContext</code></param>
							/// <param name="oContext">A context object for the new binding</param>
							/// <returns>The new property binding</returns>
							public extern virtual sap.ui.model.PropertyBinding bindProperty(string sPath, object oContext);

							/// <summary>
							/// Creates a new property binding for this model.
							/// </summary>
							/// <param name="sPath">Path pointing to the property that should be bound; either an absolute path or a path relative to a given <code>oContext</code></param>
							/// <returns>The new property binding</returns>
							public extern virtual sap.ui.model.PropertyBinding bindProperty(string sPath);

							/// <summary>
							/// Creates a new tree binding for this model.
							/// </summary>
							/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
							/// <param name="oContext">Binding context referring to this model</param>
							/// <param name="aFilters">Predefined filters, can be either a filter or an array of filters</param>
							/// <param name="mParameters">Map of parameters for the tree binding</param>
							/// <param name="aSorters">An array of predefined sorters</param>
							/// <returns>The new tree binding</returns>
							public extern virtual sap.ui.model.TreeBinding bindTree(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, Map mParameters, sap.ui.model.Sorter[] aSorters);

							/// <summary>
							/// Creates a new tree binding for this model.
							/// </summary>
							/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
							/// <param name="oContext">Binding context referring to this model</param>
							/// <param name="aFilters">Predefined filters, can be either a filter or an array of filters</param>
							/// <param name="mParameters">Map of parameters for the tree binding</param>
							/// <returns>The new tree binding</returns>
							public extern virtual sap.ui.model.TreeBinding bindTree(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, Map mParameters);

							/// <summary>
							/// Creates a new tree binding for this model.
							/// </summary>
							/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
							/// <param name="oContext">Binding context referring to this model</param>
							/// <param name="aFilters">Predefined filters, can be either a filter or an array of filters</param>
							/// <returns>The new tree binding</returns>
							public extern virtual sap.ui.model.TreeBinding bindTree(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

							/// <summary>
							/// Creates a new tree binding for this model.
							/// </summary>
							/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
							/// <param name="oContext">Binding context referring to this model</param>
							/// <returns>The new tree binding</returns>
							public extern virtual sap.ui.model.TreeBinding bindTree(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Creates a new tree binding for this model.
							/// </summary>
							/// <param name="sPath">Binding path, either absolute or relative to a given <code>oContext</code></param>
							/// <returns>The new tree binding</returns>
							public extern virtual sap.ui.model.TreeBinding bindTree(string sPath);

							/// <summary>
							/// Trigger a request to the function import OData service that was specified in the model constructor.
							/// 
							/// If the return type of the function import is either an entity type or a collection of an entity type, then the changes are reflected in the model. Otherwise they are ignored, and the <code>response</code> can be processed in the <code>success</code> callback.
							/// </summary>
							/// <param name="sFunctionName">A string containing the name of the function to call. The name is concatenated to the service URL which was specified in the model constructor.</param>
							/// <param name="mParameters">Optional parameter map containing any of the following properties:</param>
							/// <returns>An object which has a <code>contextCreated</code> function that returns a <code>Promise</code>. This resolves with the created {@link sap.ui.model.Context}. In addition it has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object callFunction(string sFunctionName, Map mParameters);

							/// <summary>
							/// Trigger a request to the function import OData service that was specified in the model constructor.
							/// 
							/// If the return type of the function import is either an entity type or a collection of an entity type, then the changes are reflected in the model. Otherwise they are ignored, and the <code>response</code> can be processed in the <code>success</code> callback.
							/// </summary>
							/// <param name="sFunctionName">A string containing the name of the function to call. The name is concatenated to the service URL which was specified in the model constructor.</param>
							/// <returns>An object which has a <code>contextCreated</code> function that returns a <code>Promise</code>. This resolves with the created {@link sap.ui.model.Context}. In addition it has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object callFunction(string sFunctionName);

							/// <summary>
							/// Trigger a <code>POST</code> request to the OData service that was specified in the model constructor.
							/// 
							/// Please note that deep creates are not supported and may not work.
							/// </summary>
							/// <param name="sPath">A string containing the path to the collection where an entry should be created. The path is concatenated to the service URL which was specified in the model constructor.</param>
							/// <param name="oData">Data of the entry that should be created.</param>
							/// <param name="mParameters">Optional parameter map containing any of the following properties:</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object create(string sPath, object oData, Map mParameters);

							/// <summary>
							/// Trigger a <code>POST</code> request to the OData service that was specified in the model constructor.
							/// 
							/// Please note that deep creates are not supported and may not work.
							/// </summary>
							/// <param name="sPath">A string containing the path to the collection where an entry should be created. The path is concatenated to the service URL which was specified in the model constructor.</param>
							/// <param name="oData">Data of the entry that should be created.</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object create(string sPath, object oData);

							/// <summary>
							/// Creates a binding context for the given path.
							/// 
							/// If the data of the context is not yet available, it can not be created, but first the entity needs to be fetched from the server asynchronously. In case no callback function is provided, the request will not be triggered.
							/// 
							/// If a callback function is given, the created binding context for a fetched entity is passed as argument to the given callback function.
							/// </summary>
							/// <param name="sPath">Binding path</param>
							/// <param name="oContext">Binding context</param>
							/// <param name="mParameters">Map which contains additional parameters for the binding</param>
							/// <param name="fnCallBack">Function to be called when context has been created. The parameter of the callback function is the newly created binding context.</param>
							/// <param name="bReload">Whether to reload data</param>
							/// <returns>The created binding context, only if the data is already available and the binding context could be created synchronously</returns>
							public extern virtual sap.ui.model.Context createBindingContext(string sPath, object oContext, Map mParameters, object fnCallBack, bool bReload);

							/// <summary>
							/// Creates a binding context for the given path.
							/// 
							/// If the data of the context is not yet available, it can not be created, but first the entity needs to be fetched from the server asynchronously. In case no callback function is provided, the request will not be triggered.
							/// 
							/// If a callback function is given, the created binding context for a fetched entity is passed as argument to the given callback function.
							/// </summary>
							/// <param name="sPath">Binding path</param>
							/// <param name="oContext">Binding context</param>
							/// <param name="mParameters">Map which contains additional parameters for the binding</param>
							/// <param name="fnCallBack">Function to be called when context has been created. The parameter of the callback function is the newly created binding context.</param>
							/// <returns>The created binding context, only if the data is already available and the binding context could be created synchronously</returns>
							public extern virtual sap.ui.model.Context createBindingContext(string sPath, object oContext, Map mParameters, object fnCallBack);

							/// <summary>
							/// Creates a binding context for the given path.
							/// 
							/// If the data of the context is not yet available, it can not be created, but first the entity needs to be fetched from the server asynchronously. In case no callback function is provided, the request will not be triggered.
							/// 
							/// If a callback function is given, the created binding context for a fetched entity is passed as argument to the given callback function.
							/// </summary>
							/// <param name="sPath">Binding path</param>
							/// <param name="oContext">Binding context</param>
							/// <param name="mParameters">Map which contains additional parameters for the binding</param>
							/// <returns>The created binding context, only if the data is already available and the binding context could be created synchronously</returns>
							public extern virtual sap.ui.model.Context createBindingContext(string sPath, object oContext, Map mParameters);

							/// <summary>
							/// Creates a binding context for the given path.
							/// 
							/// If the data of the context is not yet available, it can not be created, but first the entity needs to be fetched from the server asynchronously. In case no callback function is provided, the request will not be triggered.
							/// 
							/// If a callback function is given, the created binding context for a fetched entity is passed as argument to the given callback function.
							/// </summary>
							/// <param name="sPath">Binding path</param>
							/// <param name="oContext">Binding context</param>
							/// <returns>The created binding context, only if the data is already available and the binding context could be created synchronously</returns>
							public extern virtual sap.ui.model.Context createBindingContext(string sPath, object oContext);

							/// <summary>
							/// Creates a binding context for the given path.
							/// 
							/// If the data of the context is not yet available, it can not be created, but first the entity needs to be fetched from the server asynchronously. In case no callback function is provided, the request will not be triggered.
							/// 
							/// If a callback function is given, the created binding context for a fetched entity is passed as argument to the given callback function.
							/// </summary>
							/// <param name="sPath">Binding path</param>
							/// <returns>The created binding context, only if the data is already available and the binding context could be created synchronously</returns>
							public extern virtual sap.ui.model.Context createBindingContext(string sPath);

							/// <summary>
							/// Creates a new entry object which is described by the metadata of the entity type of the specified <code>sPath</code> Name. A context object is returned which can be used to bind against the newly created object.
							/// 
							/// For each created entry a request is created and stored in a request queue. The request queue can be submitted by calling {@link #submitChanges}. To delete a created entry from the request queue call {@link #deleteCreatedEntry}.
							/// 
							/// The optional parameter <code>mParameters.properties</code> can be used as follows: <ul> <li><code>properties</code> could be an array containing the property names which should be included in the new entry. Other properties defined in the entity type won't be included. </li> <li><code>properties</code> could be an object which includes the desired properties and the corresponding values which should be used for the created entry. </li> </ul> If <code>properties</code> is not specified, all properties in the entity type will be included in the created entry.
							/// 
							/// If there are no values specified, the properties will have <code>undefined</code> values.
							/// 
							/// Please note that deep creates (including data defined by navigation properties) are not supported.
							/// </summary>
							/// <param name="sPath">Name of the path to the EntitySet</param>
							/// <param name="mParameters">A map of the following parameters:</param>
							/// <returns>A Context object that points to the new created entry.</returns>
							public extern virtual sap.ui.model.Context createEntry(string sPath, Map mParameters);

							/// <summary>
							/// Creates the key from the given collection name and property map.
							/// 
							/// Please make sure that the metadata document is loaded before using this function.
							/// </summary>
							/// <param name="sCollection">Name of the collection</param>
							/// <param name="oKeyProperties">Object containing at least all the key properties of the entity type</param>
							/// <returns>Key of the entry</returns>
							public extern virtual string createKey(string sCollection, object oKeyProperties);

							/// <summary>
							/// Deletes a created entry from the request queue and from the model.
							/// </summary>
							/// <param name="oContext">The context object pointing to the created entry</param>
							public extern virtual void deleteCreatedEntry(sap.ui.model.Context oContext);

							public extern override void destroy();

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Force the update on the server of an entity by setting its ETag to '*'.
							/// 
							/// ETag handling must be active so the force update will work.
							/// </summary>
							/// <param name="sKey">The key to an Entity e.g.: Customer(4711)</param>
							public extern virtual void forceEntityUpdate(string sKey);

							/// <summary>
							/// Returns the definition of batch groups per entity type for two-way binding changes
							/// </summary>
							/// <returns>Definition of batch groups for two-way binding changes</returns>
							[Obsolete("Deprecated since 1.36. use {@link #getChangeGroups} instead")]
							public extern virtual Map getChangeBatchGroups();

							/// <summary>
							/// Returns the definition of groups per entity type for two-way binding changes
							/// </summary>
							/// <returns>mChangeGroups Definition of groups for two-way binding changes</returns>
							public extern virtual Map getChangeGroups();

							/// <summary>
							/// Return requested data as object if the data has already been loaded and stored in the model.
							/// </summary>
							/// <param name="sPath">A string containing the path to the data object that should be returned.</param>
							/// <param name="oContext">The optional context which is used with the <code>sPath</code> to retrieve the requested data.</param>
							/// <param name="bIncludeExpandEntries">This parameter should be set when a URI or custom parameter with a <code>$expand</code> system query option was used to retrieve associated entries embedded. If set to <code>true</code> then the <code>getProperty</code> function returns a desired property value or entry and includes the associated expand entries (if any). If set to <code>false</code> the associated/expanded entry properties are removed and not included in the desired entry as properties at all. This is useful for performing updates on the base entry only. Note: A copy, not a reference of the entry will be returned.</param>
							/// <returns>Object containing the requested data if the path is valid.</returns>
							[Obsolete("Deprecated since 1.24. please use {@link #getProperty} instead")]
							public extern virtual object getData(string sPath, object oContext, bool bIncludeExpandEntries);

							/// <summary>
							/// Return requested data as object if the data has already been loaded and stored in the model.
							/// </summary>
							/// <param name="sPath">A string containing the path to the data object that should be returned.</param>
							/// <param name="oContext">The optional context which is used with the <code>sPath</code> to retrieve the requested data.</param>
							/// <returns>Object containing the requested data if the path is valid.</returns>
							[Obsolete("Deprecated since 1.24. please use {@link #getProperty} instead")]
							public extern virtual object getData(string sPath, object oContext);

							/// <summary>
							/// Return requested data as object if the data has already been loaded and stored in the model.
							/// </summary>
							/// <param name="sPath">A string containing the path to the data object that should be returned.</param>
							/// <returns>Object containing the requested data if the path is valid.</returns>
							[Obsolete("Deprecated since 1.24. please use {@link #getProperty} instead")]
							public extern virtual object getData(string sPath);

							/// <summary>
							/// Returns the default count mode for retrieving the count of collections
							/// </summary>
							/// <returns>Returns the default count mode for this model</returns>
							public extern virtual sap.ui.model.odata.CountMode getDefaultCountMode();

							/// <summary>
							/// Returns the array of batch group IDs that are set as deferred
							/// </summary>
							/// <returns>aGroupIds The array of deferred batch group IDs</returns>
							[Obsolete("Deprecated since 1.32. use {@link #getDeferredGroups} instead")]
							public extern virtual object[] getDeferredBatchGroups();

							/// <summary>
							/// Returns the array of group IDs that are set as deferred.
							/// </summary>
							/// <returns>aGroupIds The array of deferred group IDs</returns>
							public extern virtual object[] getDeferredGroups();

							/// <summary>
							/// Returns the ETag for a given binding path/context or data object.
							/// </summary>
							/// <param name="sPath">The binding path</param>
							/// <param name="oContext">The binding context</param>
							/// <param name="oEntity">The entity data</param>
							/// <returns>The found ETag (or <code>null</code> if none could be found)</returns>
							public extern virtual string getETag(string sPath, sap.ui.model.Context oContext, object oEntity);

							/// <summary>
							/// Returns the ETag for a given binding path/context or data object.
							/// </summary>
							/// <param name="sPath">The binding path</param>
							/// <param name="oContext">The binding context</param>
							/// <returns>The found ETag (or <code>null</code> if none could be found)</returns>
							public extern virtual string getETag(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Returns the ETag for a given binding path/context or data object.
							/// </summary>
							/// <param name="sPath">The binding path</param>
							/// <returns>The found ETag (or <code>null</code> if none could be found)</returns>
							public extern virtual string getETag(string sPath);

							/// <summary>
							/// Returns the ETag for a given binding path/context or data object.
							/// </summary>
							/// <returns>The found ETag (or <code>null</code> if none could be found)</returns>
							public extern virtual string getETag();

							/// <summary>
							/// Returns the ETag for a given binding path/context or data object.
							/// </summary>
							/// <param name="oContext">The binding context</param>
							/// <returns>The found ETag (or <code>null</code> if none could be found)</returns>
							public extern virtual string getETag(sap.ui.model.Context oContext);

							/// <summary>
							/// Returns the ETag for a given binding path/context or data object.
							/// </summary>
							/// <param name="oContext">The binding context</param>
							/// <param name="oEntity">The entity data</param>
							/// <returns>The found ETag (or <code>null</code> if none could be found)</returns>
							public extern virtual string getETag(sap.ui.model.Context oContext, object oEntity);

							/// <summary>
							/// Returns the ETag for a given binding path/context or data object.
							/// </summary>
							/// <param name="oEntity">The entity data</param>
							/// <returns>The found ETag (or <code>null</code> if none could be found)</returns>
							public extern virtual string getETag(object oEntity);

							/// <summary>
							/// Returns all headers and custom headers which are stored in this OData model.
							/// </summary>
							/// <returns>The header map</returns>
							public extern virtual object getHeaders();

							/// <summary>
							/// Returns the key part for the given the canonical entry URI, model context or data object or <code>undefined</code> when the <code>vValue</code> can't be interpreted.
							/// </summary>
							/// <param name="vValue">The canonical entry URI, the context or entry object</param>
							/// <returns>Key of the entry or <code>undefined</code></returns>
							public extern virtual string getKey(Union<string, object, sap.ui.model.Context> vValue);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.v2.ODataModel.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns an instance of an OData meta model which offers a unified access to both OData V2 metadata and V4 annotations. It uses the existing {@link sap.ui.model.odata.ODataMetadata} as a foundation and merges V4 annotations from the existing {@link sap.ui.model.odata.v2.ODataAnnotations} directly into the corresponding model element.
							/// 
							/// <b>BEWARE:</b> Access to this OData meta model will fail before the promise returned by {@link sap.ui.model.odata.ODataMetaModel#loaded loaded} has been resolved!
							/// </summary>
							/// <returns>The meta model for this <code>ODataModel</code></returns>
							public extern virtual sap.ui.model.odata.ODataMetaModel getMetaModel();

							/// <summary>
							/// Returns the JSON object for an entity with the given <code>sPath</code> and optional <code>oContext</code>.
							/// 
							/// With the <code>mParameters.select</code> parameter it is possible to specify comma-separated property or navigation property names which should be included in the result object. This works like the OData <code>$select</code> parameter. With the <code>mParameters.expand</code> parameter it is possible to specify comma-separated navigation property names which should be included inline in the result object. This works like the OData <code>$expand</code> parameter.
							/// 
							/// This method will return a copy and not a reference of the entity. It does not load any data and may not return all requested data if it is not available/loaded. If select entries are contained in the parameters and not all selected properties are available, this method will return <code>undefined</code> instead of incomplete data. If no select entries are defined, all properties available on the client will be returned.
							/// 
							/// Example:<br> <code>{select: "Products/ProductName, Products", expand:"Products"}</code> will return no properties of the entity itself, but only the ProductName property of the Products navigation property. If Products/ProductName has not been loaded before, so is not available on the client, it will return <code>undefined</code>.
							/// </summary>
							/// <param name="sPath">Path referencing the object</param>
							/// <param name="oContext">Context the path should be resolved with, in case it is relative</param>
							/// <param name="mParameters">Map of parameters</param>
							/// <returns>The value for the given path/context or <code>undefined</code> if data or entity type could not be found or was incomplete</returns>
							public extern virtual object getObject(string sPath, sap.ui.model.Context oContext, Map mParameters);

							/// <summary>
							/// Returns the JSON object for an entity with the given <code>sPath</code> and optional <code>oContext</code>.
							/// 
							/// With the <code>mParameters.select</code> parameter it is possible to specify comma-separated property or navigation property names which should be included in the result object. This works like the OData <code>$select</code> parameter. With the <code>mParameters.expand</code> parameter it is possible to specify comma-separated navigation property names which should be included inline in the result object. This works like the OData <code>$expand</code> parameter.
							/// 
							/// This method will return a copy and not a reference of the entity. It does not load any data and may not return all requested data if it is not available/loaded. If select entries are contained in the parameters and not all selected properties are available, this method will return <code>undefined</code> instead of incomplete data. If no select entries are defined, all properties available on the client will be returned.
							/// 
							/// Example:<br> <code>{select: "Products/ProductName, Products", expand:"Products"}</code> will return no properties of the entity itself, but only the ProductName property of the Products navigation property. If Products/ProductName has not been loaded before, so is not available on the client, it will return <code>undefined</code>.
							/// </summary>
							/// <param name="sPath">Path referencing the object</param>
							/// <param name="oContext">Context the path should be resolved with, in case it is relative</param>
							/// <returns>The value for the given path/context or <code>undefined</code> if data or entity type could not be found or was incomplete</returns>
							public extern virtual object getObject(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Returns the JSON object for an entity with the given <code>sPath</code> and optional <code>oContext</code>.
							/// 
							/// With the <code>mParameters.select</code> parameter it is possible to specify comma-separated property or navigation property names which should be included in the result object. This works like the OData <code>$select</code> parameter. With the <code>mParameters.expand</code> parameter it is possible to specify comma-separated navigation property names which should be included inline in the result object. This works like the OData <code>$expand</code> parameter.
							/// 
							/// This method will return a copy and not a reference of the entity. It does not load any data and may not return all requested data if it is not available/loaded. If select entries are contained in the parameters and not all selected properties are available, this method will return <code>undefined</code> instead of incomplete data. If no select entries are defined, all properties available on the client will be returned.
							/// 
							/// Example:<br> <code>{select: "Products/ProductName, Products", expand:"Products"}</code> will return no properties of the entity itself, but only the ProductName property of the Products navigation property. If Products/ProductName has not been loaded before, so is not available on the client, it will return <code>undefined</code>.
							/// </summary>
							/// <param name="sPath">Path referencing the object</param>
							/// <returns>The value for the given path/context or <code>undefined</code> if data or entity type could not be found or was incomplete</returns>
							public extern virtual object getObject(string sPath);

							/// <summary>
							/// Returns the original value for the property with the given path and context. The original value is the value that was last responded by the server.
							/// </summary>
							/// <param name="sPath">The path/name of the property</param>
							/// <param name="oContext">The context if available to access the property value</param>
							/// <returns>the value of the property</returns>
							public extern override object getOriginalProperty(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Returns the original value for the property with the given path and context. The original value is the value that was last responded by the server.
							/// </summary>
							/// <param name="sPath">The path/name of the property</param>
							/// <returns>the value of the property</returns>
							public extern override object getOriginalProperty(string sPath);

							/// <summary>
							/// Returns the changed properties of all changed entities in a map which are still pending. The key is the string name of the entity and the value is an object which contains the changed properties.
							/// </summary>
							/// <returns>the pending changes in a map</returns>
							public extern virtual Map getPendingChanges();

							/// <summary>
							/// Returns the value for the property with the given <code>sPath</code>.
							/// 
							/// If the path points to a navigation property which has been loaded via <code>$expand</code> then the <code>bIncludeExpandEntries</code> parameter determines if the navigation property should be included in the returned value or not. Please note that this currently works for 1..1 navigation properties only.
							/// </summary>
							/// <param name="sPath">Path/name of the property</param>
							/// <param name="oContext">Context if available to access the property value</param>
							/// <param name="bIncludeExpandEntries">@deprecated Please use {@link #getObject} function with select/expand parameters instead. This parameter should be set when a URI or custom parameter with a <code>$expand</code> system query option was used to retrieve associated entries embedded/inline. If true then the <code>getProperty</code> function returns a desired property value/entry and includes the associated expand entries (if any). Note: A copy and not a reference of the entry will be returned.</param>
							/// <returns>Value of the property</returns>
							public extern virtual object getProperty(string sPath, sap.ui.model.Context oContext, bool bIncludeExpandEntries = false);

							/// <summary>
							/// Returns the value for the property with the given <code>sPath</code>.
							/// 
							/// If the path points to a navigation property which has been loaded via <code>$expand</code> then the <code>bIncludeExpandEntries</code> parameter determines if the navigation property should be included in the returned value or not. Please note that this currently works for 1..1 navigation properties only.
							/// </summary>
							/// <param name="sPath">Path/name of the property</param>
							/// <param name="oContext">Context if available to access the property value</param>
							/// <returns>Value of the property</returns>
							public extern virtual object getProperty(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Returns the value for the property with the given <code>sPath</code>.
							/// 
							/// If the path points to a navigation property which has been loaded via <code>$expand</code> then the <code>bIncludeExpandEntries</code> parameter determines if the navigation property should be included in the returned value or not. Please note that this currently works for 1..1 navigation properties only.
							/// </summary>
							/// <param name="sPath">Path/name of the property</param>
							/// <returns>Value of the property</returns>
							public extern virtual object getProperty(string sPath);

							/// <returns>bRefreshAfterChange Whether to automatically refresh after changes</returns>
							public extern virtual bool getRefreshAfterChange();

							/// <summary>
							/// Returns the current security token.
							/// 
							/// If the token has not been requested from the server it will be requested first (synchronously).
							/// </summary>
							/// <returns>The CSRF security token</returns>
							public extern virtual string getSecurityToken();

							/// <summary>
							/// Return the annotation object. Please note that the metadata is loaded asynchronously and this function might return undefined because the metadata has not been loaded yet. In this case attach to the <code>annotationsLoaded</code> event to get notified when the annotations are available and then call this function.
							/// </summary>
							/// <returns>Metadata object</returns>
							public extern virtual object getServiceAnnotations();

							/// <summary>
							/// Return the parsed XML metadata as a Javascript object.
							/// 
							/// Please note that the metadata is loaded asynchronously and this function might return undefined because the metadata has not been loaded yet. In this case attach to the <code>metadataLoaded</code> event to get notified when the metadata is available and then call this function.
							/// </summary>
							/// <returns>Metadata object</returns>
							public extern virtual object getServiceMetadata();

							/// <summary>
							/// Checks if there exist pending changes in the model created by the {@link #setProperty} method.
							/// </summary>
							/// <returns>Whether there are pending changes</returns>
							public extern virtual bool hasPendingChanges();

							/// <summary>
							/// Checks if there are pending requests, either ongoing or sequential.
							/// </summary>
							/// <returns>Whether there are pending requests</returns>
							public extern virtual bool hasPendingRequests();

							/// <summary>
							/// Invalidate the model data.
							/// 
							/// Mark all entries in the model cache as invalid. Next time a context binding or list binding is done, the entry will be detected as invalid and will be refreshed from the server.
							/// </summary>
							/// <param name="fnCheckEntry">A function which can be used to restrict invalidation to specific entries, gets the entity key and object as parameters and should return true for entities to invalidate.</param>
							public extern virtual void invalidate(object fnCheckEntry);

							/// <summary>
							/// Invalidate the model data.
							/// 
							/// Mark all entries in the model cache as invalid. Next time a context binding or list binding is done, the entry will be detected as invalid and will be refreshed from the server.
							/// </summary>
							public extern virtual void invalidate();

							/// <summary>
							/// Invalidate all entries of the given entity type in the model data.
							/// 
							/// Mark entries of the provided entity type in the model cache as invalid. Next time a context binding or list binding is done, the entry will be detected as invalid and will be refreshed from the server.
							/// </summary>
							/// <param name="sEntityType">the qualified name of the entity type</param>
							public extern virtual void invalidateEntityType(string sEntityType);

							/// <summary>
							/// Invalidate a single entry in the model data.
							/// 
							/// Mark the selected entry in the model cache as invalid. Next time a context binding or list binding is done, the entry will be detected as invalid and will be refreshed from the server.
							/// </summary>
							/// <param name="vEntry">the reference to the entry, either by key, absolute path or context object</param>
							public extern virtual void invalidateEntry(Union<string, sap.ui.model.Context> vEntry);

							/// <summary>
							/// Checks whether metadata loading has failed in the past.
							/// </summary>
							/// <returns>Whether metadata request has failed</returns>
							public extern virtual bool isMetadataLoadingFailed();

							/// <summary>
							/// Returns a promise for the loaded state of the metadata.
							/// 
							/// The promise won't get rejected in case the metadata loading failed but is only resolved if the metadata is loaded successfully. If <code>refreshMetadata</code> function is called after this promise is already resolved you should rely on the promise returned by <code>refreshMetadata</code> to get information about the refreshed metadata loaded state.
							/// </summary>
							/// <returns>A promise on metadata loaded state</returns>
							public extern virtual jquery.JQueryPromise<object> metadataLoaded();

							/// <summary>
							/// Trigger a <code>GET</code> request to the OData service that was specified in the model constructor.
							/// 
							/// The data will be stored in the model. The requested data is returned with the response.
							/// </summary>
							/// <param name="sPath">A string containing the path to the data which should be retrieved. The path is concatenated to the service URL which was specified in the model constructor.</param>
							/// <param name="mParameters">Optional parameter map containing any of the following properties:</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object read(string sPath, Map mParameters);

							/// <summary>
							/// Trigger a <code>GET</code> request to the OData service that was specified in the model constructor.
							/// 
							/// The data will be stored in the model. The requested data is returned with the response.
							/// </summary>
							/// <param name="sPath">A string containing the path to the data which should be retrieved. The path is concatenated to the service URL which was specified in the model constructor.</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object read(string sPath);

							/// <summary>
							/// Refresh the model.
							/// 
							/// This will check all bindings for updated data and update the controls if data has been changed.
							/// </summary>
							/// <param name="bForceUpdate">Force update of controls</param>
							/// <param name="bRemoveData">If set to <code>true</code> then the model data will be removed/cleared. Please note that the data might not be there when calling e.g. <code>getProperty</code> too early before the refresh call returned.</param>
							/// <param name="sGroupId">ID of a request group; requests belonging to the same group will be bundled in one batch request</param>
							public extern virtual void refresh(bool bForceUpdate, bool bRemoveData, string sGroupId);

							/// <summary>
							/// Refresh the model.
							/// 
							/// This will check all bindings for updated data and update the controls if data has been changed.
							/// </summary>
							/// <param name="bForceUpdate">Force update of controls</param>
							/// <param name="bRemoveData">If set to <code>true</code> then the model data will be removed/cleared. Please note that the data might not be there when calling e.g. <code>getProperty</code> too early before the refresh call returned.</param>
							public extern virtual void refresh(bool bForceUpdate = false, bool bRemoveData = false);

							/// <summary>
							/// Refresh the model.
							/// 
							/// This will check all bindings for updated data and update the controls if data has been changed.
							/// </summary>
							/// <param name="sGroupId">ID of a request group; requests belonging to the same group will be bundled in one batch request</param>
							public extern virtual void refresh(string sGroupId);

							/// <summary>
							/// Refresh the model.
							/// 
							/// This will check all bindings for updated data and update the controls if data has been changed.
							/// </summary>
							public extern virtual void refresh();

							/// <summary>
							/// Refreshes the metadata for this model, for example when the request for metadata has failed.
							/// 
							/// <b>Note</b>: Do not use <code>refreshMetadata</code> if the metadata is outdated or should be updated. This will lead to inconsistent data in the application.
							/// 
							/// Returns a new promise which can be resolved or rejected depending on the metadata loading state.
							/// </summary>
							/// <returns>A promise on metadata loaded state or <code>null</code> if metadata is not initialized or currently refreshed.</returns>
							[Obsolete("Deprecated since 1.42.")]
							public extern virtual jquery.JQueryPromise<object> refreshMetadata();

							/// <summary>
							/// Refresh XSRF token by performing a GET request against the service root URL.
							/// </summary>
							/// <param name="fnSuccess">Callback function which is called when the data has been successfully retrieved.</param>
							/// <param name="fnError">Callback function which is called when the request failed. The handler can have the parameter: oError which contains additional error information.</param>
							/// <param name="bAsync">Whether the request should be sent asynchronously</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object refreshSecurityToken(object fnSuccess, object fnError, bool bAsync = false);

							/// <summary>
							/// Refresh XSRF token by performing a GET request against the service root URL.
							/// </summary>
							/// <param name="fnSuccess">Callback function which is called when the data has been successfully retrieved.</param>
							/// <param name="fnError">Callback function which is called when the request failed. The handler can have the parameter: oError which contains additional error information.</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object refreshSecurityToken(object fnSuccess, object fnError);

							/// <summary>
							/// Refresh XSRF token by performing a GET request against the service root URL.
							/// </summary>
							/// <param name="fnSuccess">Callback function which is called when the data has been successfully retrieved.</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object refreshSecurityToken(object fnSuccess);

							/// <summary>
							/// Refresh XSRF token by performing a GET request against the service root URL.
							/// </summary>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object refreshSecurityToken();

							/// <summary>
							/// Refresh XSRF token by performing a GET request against the service root URL.
							/// </summary>
							/// <param name="fnError">Callback function which is called when the request failed. The handler can have the parameter: oError which contains additional error information.</param>
							/// <param name="bAsync">Whether the request should be sent asynchronously</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object refreshSecurityToken(object fnError, bool bAsync = false);

							/// <summary>
							/// Refresh XSRF token by performing a GET request against the service root URL.
							/// </summary>
							/// <param name="bAsync">Whether the request should be sent asynchronously</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object refreshSecurityToken(bool bAsync = false);

							/// <summary>
							/// Trigger a <code>DELETE</code> request to the OData service that was specified in the model constructor.
							/// </summary>
							/// <param name="sPath">A string containing the path to the data that should be removed. The path is concatenated to the service URL which was specified in the model constructor.</param>
							/// <param name="mParameters">Optional, can contain the following attributes:</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object remove(string sPath, sap.ui.model.odata.v2.ODataModel.Info mParameters);

							/// <summary>
							/// Trigger a <code>DELETE</code> request to the OData service that was specified in the model constructor.
							/// </summary>
							/// <param name="sPath">A string containing the path to the data that should be removed. The path is concatenated to the service URL which was specified in the model constructor.</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object remove(string sPath);

							/// <summary>
							/// Resets the changes that have been collected by the {@link #setProperty} method.
							/// </summary>
							/// <param name="aPath">Array of paths that should be reset. If no array is passed, all changes will be reset.</param>
							public extern virtual void resetChanges(object[] aPath);

							/// <summary>
							/// Resets the changes that have been collected by the {@link #setProperty} method.
							/// </summary>
							public extern virtual void resetChanges();

							/// <summary>
							/// Returns a promise, which will resolve with the security token as soon as it is available.
							/// </summary>
							/// <returns>A promise on the CSRF security token</returns>
							public extern virtual jquery.JQueryPromise<object> securityTokenAvailable();

							/// <summary>
							/// Definition of batch groups per entity type for two-way binding changes.
							/// </summary>
							/// <param name="mGroups">A map containing the definition of batch groups for two-way binding changes. The map has the following format: <pre>
							/// {
							///   "EntityTypeName": {
							///     batchGroupId: "ID",
							///     [changeSetId: "ID",]
							///     [single: true/false,]
							///   }
							/// }
							/// </pre> <ul> <li><code>batchGroupId</code>: Defines the batch group for changes of the defined <i>EntityTypeName</i></li> <li><code>changeSetId</code>: ID of a <code>ChangeSet</code> which bundles the changes for the entity type.</li> <li><code>single</code>: Defines if every change will get an own change set (defaults to <code>true</code>)</li> </ul></param>
							[Obsolete("Deprecated since 1.32. Use {@link #setChangeGroups} instead")]
							public extern virtual void setChangeBatchGroups(Map mGroups);

							/// <summary>
							/// Definition of groups per entity type for two-way binding changes.
							/// </summary>
							/// <param name="mGroups">A map containing the definition of batch groups for two-way binding changes. The map has the following format: <pre>
							/// {
							///   "EntityTypeName": {
							///     groupId: "ID",
							///     [changeSetId: "ID",]
							///     [single: true/false,]
							///   }
							/// }
							/// </pre> <ul> <li><code>groupId</code>: Defines the group for changes of the defined <i>EntityTypeName</i></li> <li><code>changeSetId</code>: ID of a <code>ChangeSet</code> which bundles the changes for the entity type.</li> <li><code>single</code>: Defines if every change will get an own change set (defaults to <code>true</code>)</li> </ul></param>
							public extern virtual void setChangeGroups(Map mGroups);

							/// <summary>
							/// Sets the default mode how to retrieve the item count for a collection in this model.
							/// 
							/// The count can be determined in the following ways <ul> <li>by sending a separate <code>$count</code> request</li> <li>by adding parameter <code>$inlinecount=allpages</code> to one or all data requests</li> <li>a combination of the previous two</li> <li>not at all (questions about the size of the collection can't be answered then)</li> </ul> See {@link sap.ui.model.odata.CountMode} for all enumeration values and more details.
							/// 
							/// Note that a call to this method does not modify the count mode for existing list bindings, only bindings that are created afterwards will use the new mode when no mode is defined at their creation.
							/// 
							/// If no default count mode is set for an <code>ODataModel</code> (v2), the mode <code>Request</code> will be used.
							/// </summary>
							/// <param name="sCountMode">The new default count mode for this model</param>
							public extern virtual void setDefaultCountMode(sap.ui.model.odata.CountMode sCountMode);

							/// <summary>
							/// Setting batch groups as deferred.
							/// 
							/// Requests that belong to a deferred batch group have to be sent by explicitly calling {@link #submitChanges}.
							/// </summary>
							/// <param name="aGroupIds">Array of batch group IDs that should be set as deferred</param>
							[Obsolete("Deprecated since 1.32. use {@link #setDeferredGroups} instead")]
							public extern virtual void setDeferredBatchGroups(object[] aGroupIds);

							/// <summary>
							/// Setting request groups as deferred.
							/// 
							/// Requests that belong to a deferred group will be sent by explicitly calling {@link #submitChanges}.
							/// </summary>
							/// <param name="aGroupIds">Array of group IDs that should be set as deferred</param>
							public extern virtual void setDeferredGroups(object[] aGroupIds);

							/// <summary>
							/// Set custom headers which are provided in a key/value map.
							/// 
							/// These headers are used for requests against the OData backend. Private headers which are set in the ODataModel cannot be modified. These private headers are: <code>accept, accept-language, x-csrf-token, MaxDataServiceVersion, DataServiceVersion</code>.
							/// 
							/// To remove these custom headers simply set the <code>mCustomHeaders</code> parameter to null. Please also note that when calling this method again all previous custom headers are removed unless they are specified again in the <code>mCustomHeaders</code> parameter.
							/// </summary>
							/// <param name="mHeaders">The header name/value map.</param>
							public extern virtual void setHeaders(object mHeaders);

							/// <summary>
							/// Sets a new value for the given property <code>sPath</code> in the model.
							/// 
							/// If the <code>changeBatchGroup</code> for the changed entity type is set to deferred changes could be submitted with {@link #submitChanges}. Otherwise the change will be submitted directly.
							/// </summary>
							/// <param name="sPath">Path of the property to set</param>
							/// <param name="oValue">Value to set the property to</param>
							/// <param name="oContext">The context which will be used to set the property</param>
							/// <param name="bAsyncUpdate">Whether to update other bindings dependent on this property asynchronously</param>
							/// <returns><code>true</code> if the value was set correctly and <code>false</code if errors occurred like the entry was not found or another entry was already updated.</returns>
							public extern virtual bool setProperty(string sPath, object oValue, sap.ui.model.Context oContext, bool bAsyncUpdate);

							/// <summary>
							/// Sets a new value for the given property <code>sPath</code> in the model.
							/// 
							/// If the <code>changeBatchGroup</code> for the changed entity type is set to deferred changes could be submitted with {@link #submitChanges}. Otherwise the change will be submitted directly.
							/// </summary>
							/// <param name="sPath">Path of the property to set</param>
							/// <param name="oValue">Value to set the property to</param>
							/// <param name="oContext">The context which will be used to set the property</param>
							/// <returns><code>true</code> if the value was set correctly and <code>false</code if errors occurred like the entry was not found or another entry was already updated.</returns>
							public extern virtual bool setProperty(string sPath, object oValue, sap.ui.model.Context oContext);

							/// <summary>
							/// Sets a new value for the given property <code>sPath</code> in the model.
							/// 
							/// If the <code>changeBatchGroup</code> for the changed entity type is set to deferred changes could be submitted with {@link #submitChanges}. Otherwise the change will be submitted directly.
							/// </summary>
							/// <param name="sPath">Path of the property to set</param>
							/// <param name="oValue">Value to set the property to</param>
							/// <returns><code>true</code> if the value was set correctly and <code>false</code if errors occurred like the entry was not found or another entry was already updated.</returns>
							public extern virtual bool setProperty(string sPath, object oValue);

							/// <summary>
							/// Defines whether all bindings are updated after a change operation.
							/// 
							/// This flag can be overruled on request level by providing the <code>refreshAfterChange</code> parameter to the corresponding function (for example {@link #update}).
							/// </summary>
							/// <param name="bRefreshAfterChange">Whether to automatically refresh after changes</param>
							public extern virtual void setRefreshAfterChange(bool bRefreshAfterChange);

							/// <summary>
							/// Enable/Disable XCSRF-Token handling.
							/// </summary>
							/// <param name="bTokenHandling">Whether to use token handling or not</param>
							public extern virtual void setTokenHandlingEnabled(bool bTokenHandling = true);

							/// <summary>
							/// Enable or disable batch mode for future requests.
							/// </summary>
							/// <param name="bUseBatch">Whether the requests should be encapsulated in a batch request</param>
							public extern virtual void setUseBatch(bool bUseBatch = false);

							/// <summary>
							/// Submits the collected changes which were collected by the {@link #setProperty} method.
							/// 
							/// The update method is defined by the global <code>defaultUpdateMethod</code> parameter which is <code>sap.ui.model.odata.UpdateMethod.Merge</code> by default. In case of a <code>sap.ui.model.odata.UpdateMethod.Merge</code> request only the changed properties will be updated. If a URI with a <code>$expand</code> query option was used then the expand entries will be removed from the collected changes. Changes to this entries should be done on the entry itself. So no deep updates are supported.
							/// 
							/// <b>Important</b>: The success/error handler will only be called if batch support is enabled. If multiple batch groups are submitted the handlers will be called for every batch group.
							/// </summary>
							/// <param name="mParameters">A map which contains the following parameter properties:</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request or requests</returns>
							public extern virtual object submitChanges(sap.ui.model.odata.v2.ODataModel.SubmitChangesInfo mParameters);

							/// <summary>
							/// Submits the collected changes which were collected by the {@link #setProperty} method.
							/// 
							/// The update method is defined by the global <code>defaultUpdateMethod</code> parameter which is <code>sap.ui.model.odata.UpdateMethod.Merge</code> by default. In case of a <code>sap.ui.model.odata.UpdateMethod.Merge</code> request only the changed properties will be updated. If a URI with a <code>$expand</code> query option was used then the expand entries will be removed from the collected changes. Changes to this entries should be done on the entry itself. So no deep updates are supported.
							/// 
							/// <b>Important</b>: The success/error handler will only be called if batch support is enabled. If multiple batch groups are submitted the handlers will be called for every batch group.
							/// </summary>
							/// <returns>An object which has an <code>abort</code> function to abort the current request or requests</returns>
							public extern virtual object submitChanges();

							/// <summary>
							/// Trigger a <code>PUT/MERGE</code> request to the OData service that was specified in the model constructor.
							/// 
							/// The update method used is defined by the global <code>defaultUpdateMethod</code> parameter which is <code>sap.ui.model.odata.UpdateMethod.Merge</code> by default. Please note that deep updates are not supported and may not work. These should be done separately and directly on the corresponding entry.
							/// </summary>
							/// <param name="sPath">A string containing the path to the data that should be updated. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
							/// <param name="oData">Data of the entry that should be updated.</param>
							/// <param name="mParameters">Optional, can contain the following attributes:</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object update(string sPath, object oData, Map mParameters);

							/// <summary>
							/// Trigger a <code>PUT/MERGE</code> request to the OData service that was specified in the model constructor.
							/// 
							/// The update method used is defined by the global <code>defaultUpdateMethod</code> parameter which is <code>sap.ui.model.odata.UpdateMethod.Merge</code> by default. Please note that deep updates are not supported and may not work. These should be done separately and directly on the corresponding entry.
							/// </summary>
							/// <param name="sPath">A string containing the path to the data that should be updated. The path is concatenated to the sServiceUrl which was specified in the model constructor.</param>
							/// <param name="oData">Data of the entry that should be updated.</param>
							/// <returns>An object which has an <code>abort</code> function to abort the current request.</returns>
							public extern virtual object update(string sPath, object oData);

							/// <summary>
							/// Update all bindings.
							/// </summary>
							/// <param name="bForceUpdate">If set to <code>false</code>, an update will only be done when the value of a binding changed.</param>
							public extern virtual void updateBindings(bool bForceUpdate = false);

							#endregion

							#endregion

						}
					}
				}
			}
		}
	}
}
