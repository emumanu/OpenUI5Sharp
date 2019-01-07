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
					public static partial class v4
					{
						/// <summary>
						/// Model implementation for OData V4.
						/// 
						/// Every resource path (relative to the service root URL, no query options) according to "4 Resource Path" in specification "OData Version 4.0 Part 2: URL Conventions" is a valid data binding path within this model if a leading slash is added; for example "/" + "SalesOrderList('A%2FB%26C')" to access an entity instance with key "A/B&C". Note that appropriate URI encoding is necessary. "4.5.1 Addressing Actions" needs an operation binding, see {@link sap.ui.model.odata.v4.ODataContextBinding}.
						/// 
						/// Note that the OData V4 model has its own {@link sap.ui.model.odata.v4.Context} class. Bindings which are relative to such a V4 context depend on their corresponding parent binding and do not access data with their own service requests unless parameters are provided.
						/// 
						/// <b>Group IDs</b> control the model's use of batch requests. Valid group IDs are: <ul> <li><b>$auto</b> and <b>$auto.*</b>: Bundles requests from the model in a batch request which is sent automatically before rendering. You can use different '$auto.*' group IDs to use different batch requests. The suffix may be any non-empty string consisting of alphanumeric characters from the basic Latin alphabet, including the underscore. The submit mode for these group IDs is always {@link sap.ui.model.odata.v4.SubmitMode#Auto}. </li> <li><b>$direct</b>: Sends requests directly without batch. The submit mode for this group ID is always {@link sap.ui.model.odata.v4.SubmitMode#Direct}. </li> <li>An application group ID, which is a non-empty string consisting of alphanumeric characters from the basic Latin alphabet, including the underscore. By default, an application group has the submit mode {@link sap.ui.model.odata.v4.SubmitMode#API}. It is possible to use a different submit mode; for details see <code>mParameters.groupProperties</code>. </li> </ul>
						/// 
						/// <b>Note: The model does not support any public events; attaching an event handler leads to an error.</b>
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.v4.ODataModel")]
						public partial class ODataModel : sap.ui.model.Model
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class ODataModelInfo
							{
								/// <summary>
								/// The URL (or an array of URLs) from which the annotation metadata are loaded. The annotation files are merged into the service metadata in the given order (last one wins). The same annotations are overwritten; if an annotation file contains other elements (like a type definition) that are already merged, an error is thrown. Supported since 1.41.0
								/// </summary>
								public Union<string, string[]> annotationURI;

								/// <summary>
								/// Whether the OData model's bindings automatically generate $select and $expand system query options from the binding hierarchy. Note: Dynamic changes to the binding hierarchy are not supported. Supported since 1.47.0
								/// </summary>
								public bool autoExpandSelect;

								/// <summary>
								/// Whether the following is requested at the earliest convenience: <ul> <li> root $metadata document and annotation files; <li> the security token. </ul> Note: The root $metadata document and annotation files are just requested but not yet converted from XML to JSON unless really needed. Supported since 1.53.0 <b>BEWARE:</b> The default value may change to <code>true</code> in later releases.
								/// </summary>
								public bool earlyRequests;

								/// <summary>
								/// Controls the model's use of batch requests: '$auto' bundles requests from the model in a batch request which is sent automatically before rendering; '$direct' sends requests directly without batch; other values result in an error
								/// </summary>
								public string groupId;

								/// <summary>
								/// Controls the use of batch requests for application groups. A map of application group IDs having an object with exactly one property <code>submit</code>. Valid values are 'API', 'Auto', 'Direct' see {@link sap.ui.model.odata.v4.SubmitMode}. Supported since 1.51.0
								/// </summary>
								public object groupProperties;

								/// <summary>
								/// The version of the OData service. Supported values are "2.0" and "4.0".
								/// </summary>
								public string odataVersion;

								/// <summary>
								/// The operation mode for sorting and filtering with the model's operation mode as default. Since 1.39.0, the operation mode {@link sap.ui.model.odata.OperationMode.Server} is supported. All other operation modes including <code>undefined</code> lead to an error if 'vFilters' or 'vSorters' are given or if {@link #filter} or {@link #sort} is called.
								/// </summary>
								public sap.ui.model.odata.OperationMode operationMode;

								/// <summary>
								/// Root URL of the service to request data from. The path part of the URL must end with a forward slash according to OData V4 specification ABNF, rule "serviceRoot". You may append OData custom query options to the service root URL separated with a "?", for example "/MyService/?custom=foo". See specification "OData Version 4.0 Part 2: URL Conventions", "5.2 Custom Query Options". OData system query options and OData parameter aliases lead to an error.
								/// </summary>
								public string serviceUrl;

								/// <summary>
								/// Whether <code>&lt;edmx:Reference></code> and <code>&lt;edmx:Include></code> directives are supported in order to load schemas on demand from other $metadata documents and include them into the current service ("cross-service references").
								/// </summary>
								public bool supportReferences;

								/// <summary>
								/// Controls synchronization between different bindings which refer to the same data for the case data changes in one binding. Must be set to 'None' which means bindings are not synchronized at all; all other values are not supported and lead to an error.
								/// </summary>
								public string synchronizationMode;

								/// <summary>
								/// The group ID that is used for update requests. If no update group ID is specified, <code> mParameters.groupId</code> is used. Valid update group IDs are <code>undefined</code>, '$auto', '$direct' or an application group ID.
								/// </summary>
								public string updateGroupId;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class BindContextInfo
							{
								/// <summary>
								/// The group ID to be used for <b>read</b> requests triggered by this binding; if not specified, either the parent binding's group ID (if the binding is relative) or the model's group ID is used, see {@link sap.ui.model.odata.v4.ODataModel#constructor}. Valid values are <code>undefined</code>, '$auto', '$auto.*', '$direct' or application group IDs as specified in {@link sap.ui.model.odata.v4.ODataModel}.
								/// </summary>
								[Name("$$groupId")]
								public string dollardollargroupId;

								/// <summary>
								/// For operation bindings only: Whether $expand and $select from the parent binding are used in the request sent on {@link #execute}. If set to <code>true</code>, the binding must not set the $expand or $select parameter itself and its {@link sap.ui.model.odata.v4.ODataContextBinding#execute} must resolve with a return value context.
								/// </summary>
								[Name("$$inheritExpandSelect")]
								public bool dollardollarinheritExpandSelect;

								/// <summary>
								/// Whether the binding always uses an own service request to read its data; only the value <code>true</code> is allowed.
								/// </summary>
								[Name("$$ownRequest")]
								public bool dollardollarownRequest;

								/// <summary>
								/// The group ID to be used for <b>update</b> requests triggered by this binding; if not specified, either the parent binding's update group ID (if the binding is relative) or the model's update group ID is used, see {@link sap.ui.model.odata.v4.ODataModel#constructor}. For valid values, see parameter "$$groupId".
								/// </summary>
								[Name("$$updateGroupId")]
								public string dollardollarupdateGroupId;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class BindListInfo
							{
								/// <summary>
								/// The operation mode for sorting. Since 1.39.0, the operation mode {@link sap.ui.model.odata.OperationMode.Server} is supported. All other operation modes including <code>undefined</code> lead to an error if 'vSorters' are given or if {@link sap.ui.model.odata.v4.ODataListBinding#sort} is called.
								/// </summary>
								public sap.ui.model.odata.OperationMode operationMode;

								/// <summary>
								/// An object holding the information needed for data aggregation, see {@link sap.ui.model.odata.v4.ODataListBinding#setAggregation} for details.
								/// </summary>
								[Name("$$aggregation")]
								public object dollardollaraggregation;

								/// <summary>
								/// The group ID to be used for <b>read</b> requests triggered by this binding; if not specified, either the parent binding's group ID (if the binding is relative) or the model's group ID is used, see {@link sap.ui.model.odata.v4.ODataModel#constructor}. Valid values are <code>undefined</code>, '$auto', '$auto.*', '$direct' or application group IDs as specified in {@link sap.ui.model.odata.v4.ODataModel}.
								/// </summary>
								[Name("$$groupId")]
								public string dollardollargroupId;

								/// <summary>
								/// Whether the binding always uses an own service request to read its data; only the value <code>true</code> is allowed.
								/// </summary>
								[Name("$$ownRequest")]
								public bool dollardollarownRequest;

								/// <summary>
								/// The group ID to be used for <b>update</b> requests triggered by this binding; if not specified, either the parent binding's update group ID (if the binding is relative) or the model's update group ID is used, see {@link sap.ui.model.odata.v4.ODataModel#constructor}. For valid values, see parameter "$$groupId".
								/// </summary>
								[Name("$$updateGroupId")]
								public string dollardollarupdateGroupId;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class BindPropertyInfo
							{
								/// <summary>
								/// The group ID to be used for <b>read</b> requests triggered by this binding; if not specified, either the parent binding's group ID (if the binding is relative) or the model's group ID is used, see {@link sap.ui.model.odata.v4.ODataModel#constructor}. Valid values are <code>undefined</code>, '$auto', '$auto.*', '$direct' or application group IDs as specified in {@link sap.ui.model.odata.v4.ODataModel}.
								/// </summary>
								[Name("$$groupId")]
								public string dollardollargroupId;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Constructor for a new ODataModel.
							/// </summary>
							/// <param name="mParameters">The parameters</param>
							public extern ODataModel(sap.ui.model.odata.v4.ODataModel.ODataModelInfo mParameters);

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new context binding for the given path, context and parameters.
							/// 
							/// This binding is inactive and will not know the bound context initially. You have to call {@link sap.ui.model.Binding#initialize} to get it updated asynchronously and register a change listener at the binding to be informed when the bound context is available.
							/// </summary>
							/// <param name="sPath">The binding path in the model; must not end with a slash</param>
							/// <param name="oContext">The context which is required as base for a relative path</param>
							/// <param name="mParameters">Map of binding parameters which can be OData query options as specified in "OData Version 4.0 Part 2: URL Conventions" or the binding-specific parameters as specified below. Note: The binding creates its own data service request if it is absolute or if it has any parameters or if it is relative and has a context created via {@link #createBindingContext}. The following OData query options are allowed: <ul> <li> All "5.2 Custom Query Options" except for those with a name starting with "sap-" <li> The $count, $expand, $filter, $levels, $orderby, $search and $select "5.1 System Query Options"; OData V4 only allows $count, $filter, $levels, $orderby and $search inside resource paths that identify a collection. In our case here, this means you can only use them inside $expand. </ul> All other query options lead to an error. Query options specified for the binding overwrite model query options.</param>
							/// <returns>The context binding</returns>
							public extern virtual sap.ui.model.odata.v4.ODataContextBinding bindContext(string sPath, sap.ui.model.odata.v4.Context oContext, sap.ui.model.odata.v4.ODataModel.BindContextInfo mParameters);

							/// <summary>
							/// Creates a new context binding for the given path, context and parameters.
							/// 
							/// This binding is inactive and will not know the bound context initially. You have to call {@link sap.ui.model.Binding#initialize} to get it updated asynchronously and register a change listener at the binding to be informed when the bound context is available.
							/// </summary>
							/// <param name="sPath">The binding path in the model; must not end with a slash</param>
							/// <param name="oContext">The context which is required as base for a relative path</param>
							/// <returns>The context binding</returns>
							public extern virtual sap.ui.model.odata.v4.ODataContextBinding bindContext(string sPath, sap.ui.model.odata.v4.Context oContext);

							/// <summary>
							/// Creates a new context binding for the given path, context and parameters.
							/// 
							/// This binding is inactive and will not know the bound context initially. You have to call {@link sap.ui.model.Binding#initialize} to get it updated asynchronously and register a change listener at the binding to be informed when the bound context is available.
							/// </summary>
							/// <param name="sPath">The binding path in the model; must not end with a slash</param>
							/// <returns>The context binding</returns>
							public extern virtual sap.ui.model.odata.v4.ODataContextBinding bindContext(string sPath);

							/// <summary>
							/// Creates a new list binding for the given path and optional context which must resolve to an absolute OData path for an entity set.
							/// </summary>
							/// <param name="sPath">The binding path in the model; must not be empty or end with a slash</param>
							/// <param name="oContext">The context which is required as base for a relative path</param>
							/// <param name="vSorters">The dynamic sorters to be used initially. Call {@link sap.ui.model.odata.v4.ODataListBinding#sort} to replace them. Static sorters, as defined in the '$orderby' binding parameter, are always executed after the dynamic sorters. Supported since 1.39.0.</param>
							/// <param name="vFilters">The dynamic application filters to be used initially. Call {@link sap.ui.model.odata.v4.ODataListBinding#filter} to replace them. Static filters, as defined in the '$filter' binding parameter, are always combined with the dynamic filters using a logical <code>AND</code>. Supported since 1.39.0.</param>
							/// <param name="mParameters">Map of binding parameters which can be OData query options as specified in "OData Version 4.0 Part 2: URL Conventions" or binding-specific parameters as specified below. Note: The binding creates its own data service request if it is absolute or if it has any parameters or if it is relative and has a context created via {@link #createBindingContext} or if it has sorters or filters. The following OData query options are allowed: <ul> <li> All "5.2 Custom Query Options" except for those with a name starting with "sap-" <li> The $apply, $count, $expand, $filter, $levels, $orderby, $search, and $select "5.1 System Query Options" </ul> All other query options lead to an error. Query options specified for the binding overwrite model query options.</param>
							/// <returns>The list binding</returns>
							public extern virtual sap.ui.model.odata.v4.ODataListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> vSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> vFilters, sap.ui.model.odata.v4.ODataModel.BindListInfo mParameters);

							/// <summary>
							/// Creates a new list binding for the given path and optional context which must resolve to an absolute OData path for an entity set.
							/// </summary>
							/// <param name="sPath">The binding path in the model; must not be empty or end with a slash</param>
							/// <param name="oContext">The context which is required as base for a relative path</param>
							/// <param name="vSorters">The dynamic sorters to be used initially. Call {@link sap.ui.model.odata.v4.ODataListBinding#sort} to replace them. Static sorters, as defined in the '$orderby' binding parameter, are always executed after the dynamic sorters. Supported since 1.39.0.</param>
							/// <param name="vFilters">The dynamic application filters to be used initially. Call {@link sap.ui.model.odata.v4.ODataListBinding#filter} to replace them. Static filters, as defined in the '$filter' binding parameter, are always combined with the dynamic filters using a logical <code>AND</code>. Supported since 1.39.0.</param>
							/// <returns>The list binding</returns>
							public extern virtual sap.ui.model.odata.v4.ODataListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> vSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> vFilters);

							/// <summary>
							/// Creates a new list binding for the given path and optional context which must resolve to an absolute OData path for an entity set.
							/// </summary>
							/// <param name="sPath">The binding path in the model; must not be empty or end with a slash</param>
							/// <param name="oContext">The context which is required as base for a relative path</param>
							/// <param name="vSorters">The dynamic sorters to be used initially. Call {@link sap.ui.model.odata.v4.ODataListBinding#sort} to replace them. Static sorters, as defined in the '$orderby' binding parameter, are always executed after the dynamic sorters. Supported since 1.39.0.</param>
							/// <returns>The list binding</returns>
							public extern virtual sap.ui.model.odata.v4.ODataListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> vSorters);

							/// <summary>
							/// Creates a new list binding for the given path and optional context which must resolve to an absolute OData path for an entity set.
							/// </summary>
							/// <param name="sPath">The binding path in the model; must not be empty or end with a slash</param>
							/// <param name="oContext">The context which is required as base for a relative path</param>
							/// <returns>The list binding</returns>
							public extern virtual sap.ui.model.odata.v4.ODataListBinding bindList(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Creates a new list binding for the given path and optional context which must resolve to an absolute OData path for an entity set.
							/// </summary>
							/// <param name="sPath">The binding path in the model; must not be empty or end with a slash</param>
							/// <returns>The list binding</returns>
							public extern virtual sap.ui.model.odata.v4.ODataListBinding bindList(string sPath);

							/// <summary>
							/// Creates a new property binding for the given path. This binding is inactive and will not know the property value initially. You have to call {@link sap.ui.model.Binding#initialize} to get it updated asynchronously and register a change listener at the binding to be informed when the value is available.
							/// </summary>
							/// <param name="sPath">The binding path in the model; must not be empty or end with a slash</param>
							/// <param name="oContext">The context which is required as base for a relative path</param>
							/// <param name="mParameters">Map of binding parameters which can be OData query options as specified in "OData Version 4.0 Part 2: URL Conventions" or the binding-specific parameter "$$groupId". Note: The binding creates its own data service request if it is absolute or if it has any parameters or if it is relative and has a context created via {@link #createBindingContext}. All "5.2 Custom Query Options" are allowed except for those with a name starting with "sap-". All other query options lead to an error. Query options specified for the binding overwrite model query options.</param>
							/// <returns>The property binding</returns>
							public extern virtual sap.ui.model.odata.v4.ODataPropertyBinding bindProperty(string sPath, sap.ui.model.Context oContext, sap.ui.model.odata.v4.ODataModel.BindPropertyInfo mParameters);

							/// <summary>
							/// Creates a new property binding for the given path. This binding is inactive and will not know the property value initially. You have to call {@link sap.ui.model.Binding#initialize} to get it updated asynchronously and register a change listener at the binding to be informed when the value is available.
							/// </summary>
							/// <param name="sPath">The binding path in the model; must not be empty or end with a slash</param>
							/// <param name="oContext">The context which is required as base for a relative path</param>
							/// <returns>The property binding</returns>
							public extern virtual sap.ui.model.odata.v4.ODataPropertyBinding bindProperty(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Creates a new property binding for the given path. This binding is inactive and will not know the property value initially. You have to call {@link sap.ui.model.Binding#initialize} to get it updated asynchronously and register a change listener at the binding to be informed when the value is available.
							/// </summary>
							/// <param name="sPath">The binding path in the model; must not be empty or end with a slash</param>
							/// <returns>The property binding</returns>
							public extern virtual sap.ui.model.odata.v4.ODataPropertyBinding bindProperty(string sPath);

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void bindTree();

							/// <summary>
							/// Creates a binding context for the given path. A relative path can only be resolved if a context is provided. Note: The parameters <code>mParameters</code>, <code>fnCallBack</code>, and <code>bReload</code> from {@link sap.ui.model.Model#createBindingContext} are not supported.
							/// 
							/// It is possible to create binding contexts pointing to metadata. A '##' is recognized as separator in the resolved path and splits it into two parts; note that '#' may also be used as separator but is deprecated since 1.51. The part before the separator is transformed into a metadata context (see {@link sap.ui.model.odata.v4.ODataMetaModel#getMetaContext}). The part following the separator is then interpreted relative to this metadata context, even if it starts with a '/'; a trailing '/' is allowed here, see {@link sap.ui.model.odata.v4.ODataMetaModel#requestObject} for the effect it has.
							/// 
							/// A binding path may also point to an operation advertisement which is addressed with '#<namespace>.<operation>' and is part of the data payload, not the metadata. The metadata of an operation can be addressed via '##' as described above.
							/// 
							/// Examples: <ul> <li><code>/Products('42')/Name##@com.sap.vocabularies.Common.v1.Label</code> points to the "Label" annotation of the "Name" property of the entity set "Products". <li><code>/##Products/Name@com.sap.vocabularies.Common.v1.Label</code> has no data path part and thus starts at the metadata root. It also points to the "Label" annotation of the "Name" property of the entity set "Products". <li><code>/Products##/</code> points to the entity type (note the trailing '/') of the entity set "Products". <li><code>/EMPLOYEES('1')/##com.sap.Action</code> points to the metadata of an action bound to the entity set "EMPLOYEES". <li><code>/EMPLOYEES('1')/#com.sap.Action</code> does not point to metadata, but to the action advertisement. </ul>
							/// </summary>
							/// <param name="sPath">The binding path, may be relative to the provided context</param>
							/// <param name="oContext">The context which is required as base for a relative path</param>
							/// <returns>The binding context with the resolved path and the model instance</returns>
							public extern virtual sap.ui.model.Context createBindingContext(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Creates a binding context for the given path. A relative path can only be resolved if a context is provided. Note: The parameters <code>mParameters</code>, <code>fnCallBack</code>, and <code>bReload</code> from {@link sap.ui.model.Model#createBindingContext} are not supported.
							/// 
							/// It is possible to create binding contexts pointing to metadata. A '##' is recognized as separator in the resolved path and splits it into two parts; note that '#' may also be used as separator but is deprecated since 1.51. The part before the separator is transformed into a metadata context (see {@link sap.ui.model.odata.v4.ODataMetaModel#getMetaContext}). The part following the separator is then interpreted relative to this metadata context, even if it starts with a '/'; a trailing '/' is allowed here, see {@link sap.ui.model.odata.v4.ODataMetaModel#requestObject} for the effect it has.
							/// 
							/// A binding path may also point to an operation advertisement which is addressed with '#<namespace>.<operation>' and is part of the data payload, not the metadata. The metadata of an operation can be addressed via '##' as described above.
							/// 
							/// Examples: <ul> <li><code>/Products('42')/Name##@com.sap.vocabularies.Common.v1.Label</code> points to the "Label" annotation of the "Name" property of the entity set "Products". <li><code>/##Products/Name@com.sap.vocabularies.Common.v1.Label</code> has no data path part and thus starts at the metadata root. It also points to the "Label" annotation of the "Name" property of the entity set "Products". <li><code>/Products##/</code> points to the entity type (note the trailing '/') of the entity set "Products". <li><code>/EMPLOYEES('1')/##com.sap.Action</code> points to the metadata of an action bound to the entity set "EMPLOYEES". <li><code>/EMPLOYEES('1')/#com.sap.Action</code> does not point to metadata, but to the action advertisement. </ul>
							/// </summary>
							/// <param name="sPath">The binding path, may be relative to the provided context</param>
							/// <returns>The binding context with the resolved path and the model instance</returns>
							public extern virtual sap.ui.model.Context createBindingContext(string sPath);

							/// <summary>
							/// Destroys this model and its meta model.
							/// </summary>
							public extern override void destroy();

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void destroyBindingContext();

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Returns the model's group ID.
							/// </summary>
							/// <returns>The group ID</returns>
							public extern virtual string getGroupId();

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.v4.ODataModel.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							[Name("getMetadata")]
							public extern static sap.ui.@base.Metadata getMetadataStatic();

							/// <summary>
							/// Returns the meta model for this ODataModel.
							/// </summary>
							/// <returns>The meta model for this ODataModel</returns>
							public extern virtual sap.ui.model.odata.v4.ODataMetaModel getMetaModel();

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void getObject();

							/// <summary>
							/// Returns the version of the OData service.
							/// </summary>
							/// <returns>The version of the OData service</returns>
							public extern virtual string getODataVersion();

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void getOriginalProperty();

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void getProperty();

							/// <summary>
							/// Returns the model's update group ID.
							/// </summary>
							/// <returns>The update group ID</returns>
							public extern virtual string getUpdateGroupId();

							/// <summary>
							/// Returns <code>true</code> if there are pending changes, meaning updates or created entities (see {@link sap.ui.model.odata.v4.ODataListBinding#create}) that have not yet been successfully sent to the server.
							/// </summary>
							/// <returns><code>true</code> if there are pending changes</returns>
							public extern virtual bool hasPendingChanges();

							/// <summary>
							/// Refreshes the model by calling refresh on all bindings which have a change event handler attached.
							/// 
							/// Note: When calling {@link #refresh} multiple times, the result of the request triggered by the last call determines the model's data; it is <b>independent</b> of the order of calls to {@link #submitBatch} with the given group ID.
							/// 
							/// If there are pending changes, an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link #submitBatch} to submit the changes or {@link #resetChanges} to reset the changes before calling {@link #refresh}.
							/// </summary>
							/// <param name="sGroupId">The group ID to be used for refresh; valid values are <code>undefined</code>, '$auto', '$auto.*', '$direct' or application group IDs as specified in {@link sap.ui.model.odata.v4.ODataModel}</param>
							public extern virtual void refresh(string sGroupId);

							/// <summary>
							/// Refreshes the model by calling refresh on all bindings which have a change event handler attached.
							/// 
							/// Note: When calling {@link #refresh} multiple times, the result of the request triggered by the last call determines the model's data; it is <b>independent</b> of the order of calls to {@link #submitBatch} with the given group ID.
							/// 
							/// If there are pending changes, an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link #submitBatch} to submit the changes or {@link #resetChanges} to reset the changes before calling {@link #refresh}.
							/// </summary>
							public extern virtual void refresh();

							/// <summary>
							/// Returns a promise for the "canonical path" of the entity for the given context. According to "4.3.1 Canonical URL" of the specification "OData Version 4.0 Part 2: URL Conventions", this is the "name of the entity set associated with the entity followed by the key predicate identifying the entity within the collection". Use the canonical path in {@link sap.ui.core.Element#bindElement} to create an element binding.
							/// </summary>
							/// <param name="oEntityContext">A context in this model which must point to a non-contained OData entity</param>
							/// <returns>A promise which is resolved with the canonical path (e.g. "/SalesOrderList('0500000000')") in case of success, or rejected with an instance of <code>Error</code> in case of failure, e.g. when the given context does not point to an entity</returns>
							[Obsolete("Deprecated since 1.39.0. Use {@link sap.ui.model.odata.v4.Context#requestCanonicalPath} instead.")]
							public extern virtual es5.Promise<object> requestCanonicalPath(sap.ui.model.odata.v4.Context oEntityContext);

							/// <summary>
							/// Resets all property changes and created entities associated with the given group ID which have not been successfully submitted via {@link #submitBatch}. Resets also invalid user input for the same group ID. This function does not reset the deletion of entities (see {@link sap.ui.model.odata.v4.Context#delete}) and the execution of OData operations (see {@link sap.ui.model.odata.v4.ODataContextBinding#execute}).
							/// </summary>
							/// <param name="sGroupId">The application group ID as specified in {@link sap.ui.model.odata.v4.ODataModel}. If it is <code>undefined</code>, the model's <code>updateGroupId</code> is used. Note that the default <code>updateGroupId</code> is '$auto', which is invalid here.</param>
							public extern virtual void resetChanges(string sGroupId);

							/// <summary>
							/// Resets all property changes and created entities associated with the given group ID which have not been successfully submitted via {@link #submitBatch}. Resets also invalid user input for the same group ID. This function does not reset the deletion of entities (see {@link sap.ui.model.odata.v4.Context#delete}) and the execution of OData operations (see {@link sap.ui.model.odata.v4.ODataContextBinding#execute}).
							/// </summary>
							public extern virtual void resetChanges();

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void setLegacySyntax();

							/// <summary>
							/// Submits the requests associated with the given application group ID in one batch request.
							/// </summary>
							/// <param name="sGroupId">The application group ID as specified in {@link sap.ui.model.odata.v4.ODataModel}.</param>
							/// <returns>A promise on the outcome of the HTTP request resolving with <code>undefined</code>; it is rejected with an error if the batch request itself fails</returns>
							public extern virtual es5.Promise<object> submitBatch(string sGroupId);

							/// <summary>
							/// Returns a string representation of this object including the service URL.
							/// </summary>
							/// <returns>A string description of this model</returns>
							public extern override string toString();

							#endregion

						}
					}
				}
			}
		}
	}
}
