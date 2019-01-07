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
				/// <summary>
				/// ListBinding is a specific binding for lists in the model, which can be used to populate Tables or ItemLists.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.ListBinding")]
				public abstract partial class ListBinding : sap.ui.model.Binding
				{
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
					public extern ListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, object mParameters);

					/// <summary>
					/// Constructor for ListBinding.
					/// </summary>
					/// <param name="oModel">Model instance that this binding belongs to</param>
					/// <param name="sPath">Binding path for this binding; a relative path will be resolved relative to a given context</param>
					/// <param name="oContext">Context to be used to resolve a relative path</param>
					/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
					/// <param name="aFilters">Predefined filter/s (can be either a filter or an array of filters)</param>
					public extern ListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

					/// <summary>
					/// Constructor for ListBinding.
					/// </summary>
					/// <param name="oModel">Model instance that this binding belongs to</param>
					/// <param name="sPath">Binding path for this binding; a relative path will be resolved relative to a given context</param>
					/// <param name="oContext">Context to be used to resolve a relative path</param>
					/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
					public extern ListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters);

					/// <summary>
					/// Constructor for ListBinding.
					/// </summary>
					/// <param name="oModel">Model instance that this binding belongs to</param>
					/// <param name="sPath">Binding path for this binding; a relative path will be resolved relative to a given context</param>
					/// <param name="oContext">Context to be used to resolve a relative path</param>
					public extern ListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

					#endregion

					#region Methods

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'filter' event of this <code>sap.ui.model.ListBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					[Obsolete("Deprecated since 1.11. use the change event. It now contains a parameter (reason : 'filter') when a filter event is fired.")]
					public extern virtual void attachFilter(object fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'filter' event of this <code>sap.ui.model.ListBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					[Obsolete("Deprecated since 1.11. use the change event. It now contains a parameter (reason : 'filter') when a filter event is fired.")]
					public extern virtual void attachFilter(object fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'sort' event of this <code>sap.ui.model.ListBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					[Obsolete("Deprecated since 1.11. use the change event. It now contains a parameter (reason : 'sort') when a sorter event is fired.")]
					public extern virtual void attachSort(object fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'sort' event of this <code>sap.ui.model.ListBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					[Obsolete("Deprecated since 1.11. use the change event. It now contains a parameter (reason : 'sort') when a sorter event is fired.")]
					public extern virtual void attachSort(object fnFunction);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'filter' event of this <code>sap.ui.model.ListBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					[Obsolete("Deprecated since 1.11. use the change event.")]
					public extern virtual void detachFilter(object fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'filter' event of this <code>sap.ui.model.ListBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					[Obsolete("Deprecated since 1.11. use the change event.")]
					public extern virtual void detachFilter(object fnFunction);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'sort' event of this <code>sap.ui.model.ListBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					[Obsolete("Deprecated since 1.11. use the change event.")]
					public extern virtual void detachSort(object fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'sort' event of this <code>sap.ui.model.ListBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					[Obsolete("Deprecated since 1.11. use the change event.")]
					public extern virtual void detachSort(object fnFunction);

					/// <summary>
					/// Enable extended change detection. When extended change detection is enabled, the list binding provides detailed information about changes, for example which entries have been removed or inserted. This can be utilized by a control for fine-grained update of its elements. Please see {@link sap.ui.model.ListBinding.prototype.getContexts} for more information.
					/// 
					/// For models that do not have a unique key on each entry by default, a key property or function can be set which is used to identify entries.
					/// </summary>
					/// <param name="bDetectUpdates">Whether changes within the same entity should cause a delete and insert command</param>
					/// <param name="vKey">The path of the property containing the key or a function getting the context as only parameter to calculate a key to identify an entry</param>
					public extern virtual void enableExtendedChangeDetection(bool bDetectUpdates, Union<object, string> vKey);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Applies a new set of filters to the list represented by this binding.
					/// 
					/// Depending on the nature of the model (client or server), the operation might be executed locally or on a server and it might execute asynchronously.
					/// 
					/// <h4>Application and Control Filters</h4> Each list binding maintains two separate lists of filters, one for filters defined by the control that owns the binding and another list for filters that an application can define in addition. When executing the filter operation, both sets of filters are combined.
					/// 
					/// By using the second parameter <code>sFilterType</code> of method <code>filter</code>, the caller can control which set of filters is modified. If no type is given, then the behavior depends on the model implementation and should be documented in the API reference for that model.
					/// 
					/// <h4>Auto-Grouping of Filters</h4> Filters are first grouped according to their binding path. All filters belonging to the same group are ORed and after that the results of all groups are ANDed. Usually this means, all filters applied to a single table column are ORed, while filters on different table columns are ANDed. Please either use the automatic grouping of filters (where applicable) or use explicit AND/OR filters, a mixture of both is not supported.
					/// </summary>
					/// <param name="aFilters">Array of filter objects</param>
					/// <param name="sFilterType">Type of the filter which should be adjusted; if no type is given, the behavior depends on the model implementation</param>
					/// <returns>returns <code>this</code> to facilitate method chaining</returns>
					public extern virtual sap.ui.model.ListBinding filter(sap.ui.model.Filter[] aFilters, sap.ui.model.FilterType sFilterType);

					/// <summary>
					/// Applies a new set of filters to the list represented by this binding.
					/// 
					/// Depending on the nature of the model (client or server), the operation might be executed locally or on a server and it might execute asynchronously.
					/// 
					/// <h4>Application and Control Filters</h4> Each list binding maintains two separate lists of filters, one for filters defined by the control that owns the binding and another list for filters that an application can define in addition. When executing the filter operation, both sets of filters are combined.
					/// 
					/// By using the second parameter <code>sFilterType</code> of method <code>filter</code>, the caller can control which set of filters is modified. If no type is given, then the behavior depends on the model implementation and should be documented in the API reference for that model.
					/// 
					/// <h4>Auto-Grouping of Filters</h4> Filters are first grouped according to their binding path. All filters belonging to the same group are ORed and after that the results of all groups are ANDed. Usually this means, all filters applied to a single table column are ORed, while filters on different table columns are ANDed. Please either use the automatic grouping of filters (where applicable) or use explicit AND/OR filters, a mixture of both is not supported.
					/// </summary>
					/// <param name="aFilters">Array of filter objects</param>
					/// <returns>returns <code>this</code> to facilitate method chaining</returns>
					public extern virtual sap.ui.model.ListBinding filter(sap.ui.model.Filter[] aFilters);

					/// <summary>
					/// Returns an array of binding contexts for the bound target list.
					/// 
					/// <h4>Extended Change Detection</h4> If extended change detection is enabled using {@link sap.ui.model.ListBinding.prototype.enableExtendedChangeDetection}, the context array may carry an additional property named <code>diff</code>, which contains an array of actual changes on the context array compared to the last call of <code>getContexts()</code>. In case no <code>diff</code> property is available on the context array, the list is completely different and needs to be recreated. In case the <code>diff</code> property contains an empty array, there have been no changes on the list.
					/// 
					/// Sample diff array: <code>[{index: 1, type: "delete"}, {index: 4, type: "insert}]</code>
					/// 
					/// <strong>Note:</strong>The public usage of this method is deprecated, as calls from outside of controls will lead to unexpected side effects. To avoid these side effect, use {@link sap.ui.model.ListBinding.prototype.getCurrentContexts} instead.
					/// </summary>
					/// <param name="iStartIndex">the startIndex where to start the retrieval of contexts</param>
					/// <param name="iLength">determines how many contexts to retrieve beginning from the start index.</param>
					/// <returns>the array of contexts for each row of the bound list</returns>
					public extern virtual sap.ui.model.Context[] getContexts(int iStartIndex = 0, int iLength = -1);

					/// <summary>
					/// Returns an array of currently used binding contexts of the bound control
					/// 
					/// This method does not trigger any data requests from the backend or delta calculation, but just returns the context array as last requested by the control. This can be used by the application to get access to the data currently displayed by a list control.
					/// </summary>
					/// <returns>the array of contexts for each row of the bound list</returns>
					public extern virtual sap.ui.model.Context[] getCurrentContexts();

					/// <summary>
					/// Returns list of distinct values for the given relative binding path
					/// </summary>
					/// <param name="sPath">the relative binding path</param>
					/// <returns>the array of distinct values.</returns>
					public extern virtual object[] getDistinctValues(string sPath);

					/// <summary>
					/// Return the filter information as an AST. The default implementation checks for this.oCombinedFilter, models not using this member may override the method. Consumers must not rely on the origin information to be available, future filter implementations will not provide this information.
					/// </summary>
					/// <param name="bIncludeOrigin">include information about the filter objects the tree has been created from</param>
					/// <returns>The AST of the filter tree</returns>
					private extern object getFilterInfo(bool bIncludeOrigin);

					/// <summary>
					/// Gets the group for the given context. Must only be called if isGrouped() returns that grouping is enabled for this binding. The grouping will be performed using the first sorter (in case multiple sorters are defined).
					/// </summary>
					/// <param name="oContext">the binding context</param>
					/// <returns>the group object containing a key property and optional custom properties</returns>
					public extern virtual object getGroup(sap.ui.model.Context oContext);

					/// <summary>
					/// Returns the number of entries in the list. This might be an estimated or preliminary length, in case the full length is not known yet, see method isLengthFinal().
					/// </summary>
					/// <returns>returns the number of entries in the list</returns>
					public extern virtual int getLength();

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.ListBinding.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Indicates whether grouping is enabled for the binding. Grouping is enabled for a list binding, if at least one sorter exists on the binding and the first sorter is a grouping sorter.
					/// </summary>
					/// <returns>whether grouping is enabled</returns>
					public extern virtual bool isGrouped();

					/// <summary>
					/// Returns whether the length which can be retrieved using getLength() is a known, final length, or a preliminary or estimated length which may change if further data is requested.
					/// </summary>
					/// <returns>returns whether the length is final</returns>
					public extern virtual bool isLengthFinal();

					/// <summary>
					/// Sorts the list according to the sorter object.
					/// 
					/// Instead of a single sorter also an array of sorters can be passed to the sort method. In this case they are processed in the sequence in which they are contained in the array.
					/// 
					/// <h4>Grouping</h4> Sorting and grouping are closely related, in case a list should be grouped, it must be sorted by the property to group with. Grouping is enabled by setting the <code>group</code> property on the sorter object. If it is enabled, you can get the current group of an item using {@link sap.ui.model.ListBinding.prototype.getGroup}. In case multiple sorters are provided, grouping can only be done on the first sorter, nested grouping is not supported.
					/// </summary>
					/// <param name="aSorters">the Sorter object or an array of sorters which defines the sort order</param>
					/// <returns>returns <code>this</code> to facilitate method chaining</returns>
					public extern virtual sap.ui.model.ListBinding sort(Union<sap.ui.model.Sorter, object[]> aSorters);

					#endregion

				}
			}
		}
	}
}
