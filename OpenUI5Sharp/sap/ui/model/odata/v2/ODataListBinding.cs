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
						/// List binding implementation for oData format.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.v2.ODataListBinding")]
						public partial class ODataListBinding : sap.ui.model.ListBinding
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class ODataListBindingInfo
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

								/// <summary>
								/// Defines the operation mode of this binding
								/// </summary>
								public sap.ui.model.odata.OperationMode operationMode;

								/// <summary>
								/// Turns on the fault tolerance mode, data is not reset if a back-end request returns an error
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

								/// <summary>
								/// Whether a preliminary Context will be used
								/// </summary>
								public bool usePreliminaryContext;

							}

							#endregion

							#region Constructor

							/// <param name="oModel">Model that this list binding belongs to</param>
							/// <param name="sPath">Path into the model data, relative to the given <code>oContext</code></param>
							/// <param name="oContext">Context that the <code>sPath</code> is based on</param>
							/// <param name="aSorters">Initial sort order, can be either a sorter or an array of sorters</param>
							/// <param name="aFilters">Predefined filters, can be either a filter or an array of filters</param>
							/// <param name="mParameters">A map which contains additional parameters for the binding</param>
							public extern ODataListBinding(sap.ui.model.odata.v2.ODataModel oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, Map mParameters);

							/// <param name="oModel">Model that this list binding belongs to</param>
							/// <param name="sPath">Path into the model data, relative to the given <code>oContext</code></param>
							/// <param name="oContext">Context that the <code>sPath</code> is based on</param>
							/// <param name="aSorters">Initial sort order, can be either a sorter or an array of sorters</param>
							/// <param name="aFilters">Predefined filters, can be either a filter or an array of filters</param>
							public extern ODataListBinding(sap.ui.model.odata.v2.ODataModel oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

							/// <param name="oModel">Model that this list binding belongs to</param>
							/// <param name="sPath">Path into the model data, relative to the given <code>oContext</code></param>
							/// <param name="oContext">Context that the <code>sPath</code> is based on</param>
							/// <param name="aSorters">Initial sort order, can be either a sorter or an array of sorters</param>
							public extern ODataListBinding(sap.ui.model.odata.v2.ODataModel oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters);

							/// <param name="oModel">Model that this list binding belongs to</param>
							/// <param name="sPath">Path into the model data, relative to the given <code>oContext</code></param>
							/// <param name="oContext">Context that the <code>sPath</code> is based on</param>
							public extern ODataListBinding(sap.ui.model.odata.v2.ODataModel oModel, string sPath, sap.ui.model.Context oContext);

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Filters the list.
							/// 
							/// When using <code>sap.ui.model.Filter</code> the filters are first grouped according to their binding path. All filters belonging to the same group are combined with OR and after that the results of all groups are combined with AND. Usually this means, all filters applied to a single table column are combined with OR, while filters on different table columns are combined with AND. Please note that a custom filter function is only supported with operation mode <code>sap.ui.model.odata.OperationMode.Client</code>.
							/// </summary>
							/// <param name="aFilters">Single filter or array of filter objects</param>
							/// <param name="sFilterType">Type of the filter which should be adjusted. If it is not given, the standard behaviour applies</param>
							/// <param name="bReturnSuccess">Whether the success indicator should be returned instead of <code>this</code></param>
							/// <returns>Reference to <code>this</code> to facilitate method chaining or a boolean success indicator</returns>
							public extern virtual sap.ui.model.ListBinding filter(Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, sap.ui.model.FilterType sFilterType, bool bReturnSuccess = false);

							/// <summary>
							/// Return contexts for the list.
							/// </summary>
							/// <param name="iStartIndex">The start index of the requested contexts</param>
							/// <param name="iLength">The requested amount of contexts</param>
							/// <param name="iThreshold">The threshold value</param>
							/// <returns>The array of contexts for each row of the bound list</returns>
							public extern virtual sap.ui.model.Context[] getContexts(int iStartIndex, int iLength, int iThreshold);

							/// <summary>
							/// Return contexts for the list.
							/// </summary>
							/// <param name="iStartIndex">The start index of the requested contexts</param>
							/// <param name="iLength">The requested amount of contexts</param>
							/// <returns>The array of contexts for each row of the bound list</returns>
							public extern virtual sap.ui.model.Context[] getContexts(int iStartIndex, int iLength);

							/// <summary>
							/// Return contexts for the list.
							/// </summary>
							/// <param name="iStartIndex">The start index of the requested contexts</param>
							/// <returns>The array of contexts for each row of the bound list</returns>
							public extern virtual sap.ui.model.Context[] getContexts(int iStartIndex);

							/// <summary>
							/// Return contexts for the list.
							/// </summary>
							/// <returns>The array of contexts for each row of the bound list</returns>
							public extern virtual sap.ui.model.Context[] getContexts();

							/// <summary>
							/// Get a download URL with the specified format considering the sort/filter/custom parameters.
							/// </summary>
							/// <param name="sFormat">Value for the $format Parameter</param>
							/// <returns>URL which can be used for downloading</returns>
							public extern virtual string getDownloadUrl(string sFormat);

							/// <summary>
							/// Return the length of the list.
							/// 
							/// In case the final length is unknown (e.g. when searching on a large dataset), this will return an estimated length.
							/// </summary>
							/// <returns>The length</returns>
							public extern override int getLength();

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.v2.ODataListBinding.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Initialize binding.
							/// 
							/// Fires a change if data is already available ($expand) or a refresh. If metadata is not yet available, do nothing, method will be called again when metadata is loaded.
							/// </summary>
							/// <returns>oBinding The binding instance</returns>
							public extern virtual sap.ui.model.odata.v2.ODataListBinding initialize();

							/// <summary>
							/// Refreshes the binding, check whether the model data has been changed and fire change event if this is the case. For server side models this should refetch the data from the server. To update a control, even if no data has been changed, e.g. to reset a control after failed validation, please use the parameter bForceUpdate.
							/// </summary>
							/// <param name="bForceUpdate">Update the bound control even if no data has been changed</param>
							/// <param name="sGroupId">The group Id for the refresh</param>
							public extern virtual void refresh(bool bForceUpdate, string sGroupId);

							/// <summary>
							/// Refreshes the binding, check whether the model data has been changed and fire change event if this is the case. For server side models this should refetch the data from the server. To update a control, even if no data has been changed, e.g. to reset a control after failed validation, please use the parameter bForceUpdate.
							/// </summary>
							/// <param name="bForceUpdate">Update the bound control even if no data has been changed</param>
							public extern virtual void refresh(bool bForceUpdate);

							/// <summary>
							/// Refreshes the binding, check whether the model data has been changed and fire change event if this is the case. For server side models this should refetch the data from the server. To update a control, even if no data has been changed, e.g. to reset a control after failed validation, please use the parameter bForceUpdate.
							/// </summary>
							public extern virtual void refresh();

							/// <summary>
							/// Refreshes the binding, check whether the model data has been changed and fire change event if this is the case. For server side models this should refetch the data from the server. To update a control, even if no data has been changed, e.g. to reset a control after failed validation, please use the parameter bForceUpdate.
							/// </summary>
							/// <param name="sGroupId">The group Id for the refresh</param>
							public extern virtual void refresh(string sGroupId);

							/// <summary>
							/// Sorts the list.
							/// </summary>
							/// <param name="aSorters">A new sorter or an array of sorters which define the sort order</param>
							/// <param name="bReturnSuccess">Whether the success indicator should be returned instead of <code>this</code></param>
							/// <returns>Reference to <code>this</code> to facilitate method chaining or the success indicator</returns>
							public extern virtual sap.ui.model.ListBinding sort(Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, bool bReturnSuccess = false);

							#endregion

						}
					}
				}
			}
		}
	}
}
