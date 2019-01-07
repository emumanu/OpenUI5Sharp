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
						/// List binding for an OData V4 model. An event handler can only be attached to this binding for the following events: 'AggregatedDataStateChange', 'change', 'dataReceived', 'dataRequested', 'DataStateChange' and 'refresh'. For other events, an error is thrown.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.v4.ODataListBinding")]
						public partial class ODataListBinding : sap.ui.model.ListBinding
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class SetAggregationInfo
							{
								/// <summary>
								/// A map from aggregatable property names or aliases to objects containing the following details: <ul> <li><code>subtotals</code>: An optional boolean that tells whether subtotals for this aggregatable property are needed <li><code>with</code>: An optional string that provides the name of the method (for example "sum") used for aggregation of this aggregatable property; see "3.1.2 Keyword with" <li><code>name</code>: An optional string that provides the original aggregatable property name in case a different alias is chosen as the name of the dynamic property used for aggregation of this aggregatable property; see "3.1.1 Keyword as" </ul>
								/// </summary>
								public object aggregate;

								/// <summary>
								/// A map from groupable property names to empty objects
								/// </summary>
								public object group;

								/// <summary>
								/// A list of groupable property names used to determine group levels. They may, but don't need to, be repeated in <code>oAggregation.group</code>. Group levels cannot be combined with filtering or with the system query option <code>$count</code>; only a single group level is supported.
								/// </summary>
								public string[] groupLevels;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Constructor for ListBinding.
							/// </summary>
							/// <param name="oModel">Model instance that this binding belongs to</param>
							/// <param name="sPath">Binding path for this binding; a relative path will be resolved relative to a given context</param>
							/// <param name="oContext">Context to be used to resolve a relative path</param>
							/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
							/// <param name="aFilters">Predefined filter/s (can be either a filter or an array of filters)</param>
							/// <param name="mParameters">Additional, implementation-specific parameters that should be used by the new list binding; this base class doesn't define any parameters, check the API reference for the concrete model implementations to learn about their supported parameters (if any)</param>
							public extern ODataListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, object mParameters);

							/// <summary>
							/// Constructor for ListBinding.
							/// </summary>
							/// <param name="oModel">Model instance that this binding belongs to</param>
							/// <param name="sPath">Binding path for this binding; a relative path will be resolved relative to a given context</param>
							/// <param name="oContext">Context to be used to resolve a relative path</param>
							/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
							/// <param name="aFilters">Predefined filter/s (can be either a filter or an array of filters)</param>
							public extern ODataListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

							/// <summary>
							/// Constructor for ListBinding.
							/// </summary>
							/// <param name="oModel">Model instance that this binding belongs to</param>
							/// <param name="sPath">Binding path for this binding; a relative path will be resolved relative to a given context</param>
							/// <param name="oContext">Context to be used to resolve a relative path</param>
							/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
							public extern ODataListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters);

							/// <summary>
							/// Constructor for ListBinding.
							/// </summary>
							/// <param name="oModel">Model instance that this binding belongs to</param>
							/// <param name="sPath">Binding path for this binding; a relative path will be resolved relative to a given context</param>
							/// <param name="oContext">Context to be used to resolve a relative path</param>
							public extern ODataListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

							#endregion

							#region Methods

							/// <summary>
							/// Changes this binding's parameters and refreshes the binding.
							/// 
							/// If there are pending changes an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #changeParameters}.
							/// 
							/// The parameters are changed according to the given map of parameters: Parameters with an <code>undefined</code> value are removed, the other parameters are set, and missing parameters remain unchanged.
							/// </summary>
							/// <param name="mParameters">Map of binding parameters, see {@link sap.ui.model.odata.v4.ODataModel#bindList} and {@link sap.ui.model.odata.v4.ODataModel#bindContext}</param>
							public extern virtual void changeParameters(object mParameters);

							/// <summary>
							/// Creates a new entity and inserts it at the beginning of the list. As long as the binding contains an entity created via this function, you cannot create another entity. This is only possible after the creation of the entity has been successfully sent to the server and you have called {@link #refresh} at the (parent) binding, which is absolute or not relative to a {@link sap.ui.model.odata.v4.Context}, or the new entity is deleted in between.
							/// 
							/// For creating the new entity, the binding's update group ID is used, see binding parameter $$updateGroupId of {@link sap.ui.model.odata.v4.ODataModel#bindList}.
							/// 
							/// You can call {@link sap.ui.model.odata.v4.Context#delete} to delete the created context again. As long as the context is transient (see {@link sap.ui.model.odata.v4.Context#isTransient}), {@link #resetChanges} and a call to {@link sap.ui.model.odata.v4.ODataModel#resetChanges} with the update group ID as parameter also delete the created context together with other changes.
							/// 
							/// If the creation of the entity on the server failed, the creation is repeated automatically. If the binding's update group ID has {@link sap.ui.model.odata.v4.SubmitMode.API}, it is repeated with the next call of {@link sap.ui.model.odata.v4.ODataModel#submitBatch}. Otherwise it is repeated with the next update for the entity.
							/// </summary>
							/// <param name="oInitialData">The initial data for the created entity</param>
							/// <returns>The context object for the created entity; its method {@link sap.ui.model.odata.v4.Context#created} returns a promise that is resolved when the creation is finished</returns>
							public extern virtual sap.ui.model.odata.v4.Context create(object oInitialData);

							/// <summary>
							/// Creates a new entity and inserts it at the beginning of the list. As long as the binding contains an entity created via this function, you cannot create another entity. This is only possible after the creation of the entity has been successfully sent to the server and you have called {@link #refresh} at the (parent) binding, which is absolute or not relative to a {@link sap.ui.model.odata.v4.Context}, or the new entity is deleted in between.
							/// 
							/// For creating the new entity, the binding's update group ID is used, see binding parameter $$updateGroupId of {@link sap.ui.model.odata.v4.ODataModel#bindList}.
							/// 
							/// You can call {@link sap.ui.model.odata.v4.Context#delete} to delete the created context again. As long as the context is transient (see {@link sap.ui.model.odata.v4.Context#isTransient}), {@link #resetChanges} and a call to {@link sap.ui.model.odata.v4.ODataModel#resetChanges} with the update group ID as parameter also delete the created context together with other changes.
							/// 
							/// If the creation of the entity on the server failed, the creation is repeated automatically. If the binding's update group ID has {@link sap.ui.model.odata.v4.SubmitMode.API}, it is repeated with the next call of {@link sap.ui.model.odata.v4.ODataModel#submitBatch}. Otherwise it is repeated with the next update for the entity.
							/// </summary>
							/// <returns>The context object for the created entity; its method {@link sap.ui.model.odata.v4.Context#created} returns a promise that is resolved when the creation is finished</returns>
							public extern virtual sap.ui.model.odata.v4.Context create();

							/// <summary>
							/// Destroys the object. The object must not be used anymore after this function was called.
							/// </summary>
							public extern override void destroy();

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Filters the list with the given filters.
							/// 
							/// If there are pending changes an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #filter}.
							/// </summary>
							/// <param name="vFilters">The dynamic filters to be used; replaces the dynamic filters given in {@link sap.ui.model.odata.v4.ODataModel#bindList}. The filter executed on the list is created from the following parts, which are combined with a logical 'and': <ul> <li> Dynamic filters of type {@link sap.ui.model.FilterType.Application} <li> Dynamic filters of type {@link sap.ui.model.FilterType.Control} <li> The static filters, as defined in the '$filter' binding parameter </ul></param>
							/// <param name="sFilterType">The filter type to be used</param>
							/// <returns><code>this</code> to facilitate method chaining</returns>
							public extern virtual sap.ui.model.odata.v4.ODataListBinding filter(Union<sap.ui.model.Filter, sap.ui.model.Filter[]> vFilters, sap.ui.model.FilterType sFilterType = sap.ui.model.FilterType.Application);

							/// <summary>
							/// Filters the list with the given filters.
							/// 
							/// If there are pending changes an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #filter}.
							/// </summary>
							/// <param name="vFilters">The dynamic filters to be used; replaces the dynamic filters given in {@link sap.ui.model.odata.v4.ODataModel#bindList}. The filter executed on the list is created from the following parts, which are combined with a logical 'and': <ul> <li> Dynamic filters of type {@link sap.ui.model.FilterType.Application} <li> Dynamic filters of type {@link sap.ui.model.FilterType.Control} <li> The static filters, as defined in the '$filter' binding parameter </ul></param>
							/// <returns><code>this</code> to facilitate method chaining</returns>
							public extern virtual sap.ui.model.odata.v4.ODataListBinding filter(Union<sap.ui.model.Filter, sap.ui.model.Filter[]> vFilters);

							/// <summary>
							/// Filters the list with the given filters.
							/// 
							/// If there are pending changes an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #filter}.
							/// </summary>
							/// <returns><code>this</code> to facilitate method chaining</returns>
							public extern virtual sap.ui.model.odata.v4.ODataListBinding filter();

							/// <summary>
							/// Filters the list with the given filters.
							/// 
							/// If there are pending changes an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #filter}.
							/// </summary>
							/// <param name="sFilterType">The filter type to be used</param>
							/// <returns><code>this</code> to facilitate method chaining</returns>
							public extern virtual sap.ui.model.odata.v4.ODataListBinding filter(sap.ui.model.FilterType sFilterType = sap.ui.model.FilterType.Application);

							/// <summary>
							/// Returns already created binding contexts for all entities in this list binding for the range determined by the given start index <code>iStart</code> and <code>iLength</code>. If at least one of the entities in the given range has not yet been loaded, fires a {@link #event:change} event on this list binding once these entities have been loaded <b>asynchronously</b>. A further call to this method in the 'change' event handler with the same index range then yields the updated array of contexts.
							/// </summary>
							/// <param name="iStart">The index where to start the retrieval of contexts</param>
							/// <param name="iLength">The number of contexts to retrieve beginning from the start index; defaults to the model's size limit, see {@link sap.ui.model.Model#setSizeLimit}; <code>Infinity</code> may be used since 1.53.0 to retrieve all data</param>
							/// <param name="iMaximumPrefetchSize">The maximum number of contexts to read before and after the given range; with this, controls can prefetch data that is likely to be needed soon, e.g. when scrolling down in a table. Negative values will be treated as 0. Supported since 1.39.0; <code>Infinity</code> may be used since 1.53.0 to prefetch all data and thus disable paging.</param>
							/// <returns>The array of already created contexts with the first entry containing the context for <code>iStart</code></returns>
							public extern virtual sap.ui.model.odata.v4.Context[] getContexts(int iStart, int iLength, int iMaximumPrefetchSize);

							/// <summary>
							/// Returns already created binding contexts for all entities in this list binding for the range determined by the given start index <code>iStart</code> and <code>iLength</code>. If at least one of the entities in the given range has not yet been loaded, fires a {@link #event:change} event on this list binding once these entities have been loaded <b>asynchronously</b>. A further call to this method in the 'change' event handler with the same index range then yields the updated array of contexts.
							/// </summary>
							/// <param name="iStart">The index where to start the retrieval of contexts</param>
							/// <param name="iLength">The number of contexts to retrieve beginning from the start index; defaults to the model's size limit, see {@link sap.ui.model.Model#setSizeLimit}; <code>Infinity</code> may be used since 1.53.0 to retrieve all data</param>
							/// <returns>The array of already created contexts with the first entry containing the context for <code>iStart</code></returns>
							public extern virtual sap.ui.model.odata.v4.Context[] getContexts(int iStart, int iLength);

							/// <summary>
							/// Returns already created binding contexts for all entities in this list binding for the range determined by the given start index <code>iStart</code> and <code>iLength</code>. If at least one of the entities in the given range has not yet been loaded, fires a {@link #event:change} event on this list binding once these entities have been loaded <b>asynchronously</b>. A further call to this method in the 'change' event handler with the same index range then yields the updated array of contexts.
							/// </summary>
							/// <param name="iStart">The index where to start the retrieval of contexts</param>
							/// <returns>The array of already created contexts with the first entry containing the context for <code>iStart</code></returns>
							public extern virtual sap.ui.model.odata.v4.Context[] getContexts(int iStart = 0);

							/// <summary>
							/// Returns already created binding contexts for all entities in this list binding for the range determined by the given start index <code>iStart</code> and <code>iLength</code>. If at least one of the entities in the given range has not yet been loaded, fires a {@link #event:change} event on this list binding once these entities have been loaded <b>asynchronously</b>. A further call to this method in the 'change' event handler with the same index range then yields the updated array of contexts.
							/// </summary>
							/// <returns>The array of already created contexts with the first entry containing the context for <code>iStart</code></returns>
							public extern virtual sap.ui.model.odata.v4.Context[] getContexts();

							/// <summary>
							/// Returns the contexts that were requested by a control last time. Does not trigger a data request. In the time between the {@link #event:dataRequested} event and the {@link #event:dataReceived} event, the resulting array contains <code>undefined</code> at those indexes where the data is not yet available.
							/// </summary>
							/// <returns>The contexts</returns>
							public extern virtual sap.ui.model.odata.v4.Context[] getCurrentContexts();

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void getDistinctValues();

							/// <summary>
							/// Returns the filter information as an abstract syntax tree. Consumers must not rely on the origin information to be available, future filter implementations will not provide this information.
							/// 
							/// If the system query option <code>$filter</code> is present, it will be added to the AST as a node with the following structure: <ul> <li><code>expression</code>: the value of the system query option <code>$filter</code> <li><code>syntax</code>: the OData version of this bindings model, e.g. "OData 4.0" <li><code>type</code>: "Custom" </ul>
							/// </summary>
							/// <param name="bIncludeOrigin">whether to include information about the filter objects from which the tree has been created</param>
							/// <returns>The AST of the filter tree including the static filter as string or null if no filters are set</returns>
							private extern object getFilterInfo(bool bIncludeOrigin = false);

							/// <summary>
							/// Returns the header context which allows binding to <code>$count</code>. If known, the value of such a binding is the element count of the collection on the server. Otherwise it is <code>undefined</code>. The value is a number and its type is <code>Edm.Int64</code>.
							/// 
							/// The count is known to the binding in the following situations: <ul> <li>It has been requested from the server via the system query option <code>$count</code>. <li>A "short read" in a paged collection (the server delivered less elements than requested) indicated that the server has no more unread elements. <li>It has been read completely in one request, for example an embedded collection via <code>$expand</code>. </ul>
							/// 
							/// The <code>$count</code> is unknown, if the binding is relative, but has no context.
							/// </summary>
							/// <returns>The header context or <code>null</code> if the binding is relative and has no context</returns>
							public extern virtual sap.ui.model.odata.v4.Context getHeaderContext();

							/// <summary>
							/// Returns the number of entries in the list. As long as the client does not know the size on the server an estimated length is returned.
							/// </summary>
							/// <returns>The number of entries in the list</returns>
							public extern virtual int getLength();

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.v4.ODataListBinding.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							[Name("getMetadata")]
							public extern static sap.ui.@base.Metadata getMetadataStatic();

							/// <summary>
							/// Returns the root binding of this binding's hierarchy, see binding {@link topic:54e0ddf695af4a6c978472cecb01c64d Initialization and Read Requests}.
							/// </summary>
							/// <returns>The root binding or <code>undefined</code> if this binding is not yet resolved.</returns>
							public extern virtual Union<sap.ui.model.odata.v4.ODataContextBinding, sap.ui.model.odata.v4.ODataListBinding, sap.ui.model.odata.v4.ODataPropertyBinding> getRootBinding();

							/// <summary>
							/// Returns <code>true</code> if this binding or its dependent bindings have pending changes, meaning updates that have not yet been successfully sent to the server.
							/// </summary>
							/// <returns><code>true</code> if the binding has pending changes</returns>
							public extern virtual bool hasPendingChanges();

							/// <summary>
							/// Initializes the OData list binding: Fires a 'change' event in case the binding has a resolved path and its root binding is not suspended.
							/// </summary>
							public extern override void initialize();

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void isInitial();

							/// <summary>
							/// Returns <code>true</code> if the length has been determined by the data returned from server. If the length is a client side estimation <code>false</code> is returned.
							/// </summary>
							/// <returns>If <code>true</true> the length is determined by server side data</returns>
							public extern override bool isLengthFinal();

							/// <summary>
							/// Refreshes the binding. Prompts the model to retrieve data from the server using the given group ID and notifies the control that new data is available.
							/// 
							/// Refresh is supported for bindings which are not relative to a {@link sap.ui.model.odata.v4.Context} and whose root binding is not suspended.
							/// 
							/// Note: When calling {@link #refresh} multiple times, the result of the request triggered by the last call determines the binding's data; it is <b>independent</b> of the order of calls to {@link sap.ui.model.odata.v4.ODataModel#submitBatch} with the given group ID.
							/// 
							/// If there are pending changes, an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #refresh}.
							/// </summary>
							/// <param name="sGroupId">The group ID to be used for refresh; if not specified, the group ID for this binding is used.
							/// 
							/// Valid values are <code>undefined</code>, '$auto', '$auto.*', '$direct' or application group IDs as specified in {@link sap.ui.model.odata.v4.ODataModel}.</param>
							public extern virtual void refresh(string sGroupId);

							/// <summary>
							/// Refreshes the binding. Prompts the model to retrieve data from the server using the given group ID and notifies the control that new data is available.
							/// 
							/// Refresh is supported for bindings which are not relative to a {@link sap.ui.model.odata.v4.Context} and whose root binding is not suspended.
							/// 
							/// Note: When calling {@link #refresh} multiple times, the result of the request triggered by the last call determines the binding's data; it is <b>independent</b> of the order of calls to {@link sap.ui.model.odata.v4.ODataModel#submitBatch} with the given group ID.
							/// 
							/// If there are pending changes, an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #refresh}.
							/// </summary>
							public extern virtual void refresh();

							/// <summary>
							/// Resets all pending changes of this binding, see {@link #hasPendingChanges}. Resets also invalid user input.
							/// </summary>
							public extern virtual void resetChanges();

							/// <summary>
							/// Resumes this binding. The binding can again fire change events and trigger data service requests. Before 1.53.0, this method was not supported and threw an error.
							/// </summary>
							public extern override void resume();

							/// <summary>
							/// Sets a new data aggregation object and derives the system query option <code>$apply</code> implicitly from it.
							/// </summary>
							/// <param name="oAggregation">An object holding the information needed for data aggregation; see also <a href="http://docs.oasis-open.org/odata/odata-data-aggregation-ext/v4.0/">OData Extension for Data Aggregation Version 4.0</a>.</param>
							public extern virtual void setAggregation(sap.ui.model.odata.v4.ODataListBinding.SetAggregationInfo oAggregation);

							/// <summary>
							/// Sort the entries represented by this list binding according to the given sorters. The sorters are stored at this list binding and they are used for each following data request.
							/// 
							/// If there are pending changes an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #sort}.
							/// </summary>
							/// <param name="vSorters">The dynamic sorters to be used; they replace the dynamic sorters given in {@link sap.ui.model.odata.v4.ODataModel#bindList}. Static sorters, as defined in the '$orderby' binding parameter, are always executed after the dynamic sorters.</param>
							/// <returns><code>this</code> to facilitate method chaining</returns>
							public extern virtual sap.ui.model.odata.v4.ODataListBinding sort(Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> vSorters);

							/// <summary>
							/// Sort the entries represented by this list binding according to the given sorters. The sorters are stored at this list binding and they are used for each following data request.
							/// 
							/// If there are pending changes an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #sort}.
							/// </summary>
							/// <returns><code>this</code> to facilitate method chaining</returns>
							public extern virtual sap.ui.model.odata.v4.ODataListBinding sort();

							/// <summary>
							/// Suspends this binding. A suspended binding does not fire change events nor does it trigger data service requests. Call {@link #resume} to resume the binding. Before 1.53.0, this method was not supported and threw an error.
							/// </summary>
							public extern override void suspend();

							/// <summary>
							/// Updates the binding's system query option <code>$apply</code> based on the given data aggregation information. Its value is "groupby((&lt;dimension_1,...,dimension_N,unit_or_text_1,...,unit_or_text_K>), aggregate(&lt;measure> with &lt;method> as &lt;alias>, ...))" where the "aggregate" part is only present if measures are given and both "with" and "as" are optional.
							/// </summary>
							/// <param name="aAggregation">An array with objects holding the information needed for data aggregation; see also <a href="http://docs.oasis-open.org/odata/odata-data-aggregation-ext/v4.0/">OData Extension for Data Aggregation Version 4.0</a></param>
							/// <returns>The return object contains a property <code>measureRangePromise</code> if and only if at least one measure has requested a minimum or maximum value; its value is a promise which resolves with the measure range map as soon as data has been received; the measure range map contains measure names as keys and objects as values which have a <code>min</code> and <code>max</code> property as requested above. <code>undefined</code> is returned instead of an empty object.</returns>
							public extern virtual object updateAnalyticalInfo(object[] aAggregation);

							#endregion

						}
					}
				}
			}
		}
	}
}
