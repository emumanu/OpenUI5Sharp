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
					/// List binding implementation for oData format.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.odata.ODataListBinding")]
					public partial class ODataListBinding : sap.ui.model.ListBinding
					{
						#region Constructor

						/// <param name="oModel">Model that this list binding belongs to</param>
						/// <param name="sPath">Path into the model data, relative to the given <code>oContext</code></param>
						/// <param name="oContext">Context that the <code>sPath</code> is based on</param>
						/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
						/// <param name="aFilters">Predefined filter/s (can be either a filter or an array of filters)</param>
						/// <param name="mParameters">A map which contains additional parameters for the binding</param>
						public extern ODataListBinding(sap.ui.model.odata.ODataModel oModel, string sPath, sap.ui.model.Context oContext, object[] aSorters, object[] aFilters, sap.ui.model.odata.ODataModel.ListBindInfo mParameters);

						/// <param name="oModel">Model that this list binding belongs to</param>
						/// <param name="sPath">Path into the model data, relative to the given <code>oContext</code></param>
						/// <param name="oContext">Context that the <code>sPath</code> is based on</param>
						/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
						/// <param name="aFilters">Predefined filter/s (can be either a filter or an array of filters)</param>
						public extern ODataListBinding(sap.ui.model.odata.ODataModel oModel, string sPath, sap.ui.model.Context oContext, object[] aSorters, object[] aFilters);

						/// <param name="oModel">Model that this list binding belongs to</param>
						/// <param name="sPath">Path into the model data, relative to the given <code>oContext</code></param>
						/// <param name="oContext">Context that the <code>sPath</code> is based on</param>
						/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
						public extern ODataListBinding(sap.ui.model.odata.ODataModel oModel, string sPath, sap.ui.model.Context oContext, object[] aSorters);

						/// <param name="oModel">Model that this list binding belongs to</param>
						/// <param name="sPath">Path into the model data, relative to the given <code>oContext</code></param>
						/// <param name="oContext">Context that the <code>sPath</code> is based on</param>
						public extern ODataListBinding(sap.ui.model.odata.ODataModel oModel, string sPath, sap.ui.model.Context oContext);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Filters the list.
						/// 
						/// When using sap.ui.model.Filter the filters are first grouped according to their binding path. All filters belonging to a group are combined with OR and after that the results of all groups are combined with AND. Usually this means, all filters applied to a single table column are combined with OR, while filters on different table columns are combined with AND. Please note that a custom filter function is not supported.
						/// </summary>
						/// <param name="aFilters">Array of filter objects</param>
						/// <param name="sFilterType">Type of the filter which should be adjusted, if it is not given, the standard behaviour applies</param>
						/// <returns>returns <code>this</code> to facilitate method chaining</returns>
						public extern virtual sap.ui.model.ListBinding filter(Union<sap.ui.model.Filter[], sap.ui.model.odata.Filter[]> aFilters, sap.ui.model.FilterType sFilterType);

						/// <summary>
						/// Return contexts for the list
						/// </summary>
						/// <param name="iStartIndex">the start index of the requested contexts</param>
						/// <param name="iLength">the requested amount of contexts</param>
						/// <param name="iThreshold"></param>
						/// <returns>the array of contexts for each row of the bound list</returns>
						public extern virtual sap.ui.model.Context[] getContexts(int iStartIndex, int iLength, int iThreshold);

						/// <summary>
						/// Return contexts for the list
						/// </summary>
						/// <param name="iStartIndex">the start index of the requested contexts</param>
						/// <param name="iLength">the requested amount of contexts</param>
						/// <returns>the array of contexts for each row of the bound list</returns>
						public extern virtual sap.ui.model.Context[] getContexts(int iStartIndex, int iLength);

						/// <summary>
						/// Return contexts for the list
						/// </summary>
						/// <param name="iStartIndex">the start index of the requested contexts</param>
						/// <returns>the array of contexts for each row of the bound list</returns>
						public extern virtual sap.ui.model.Context[] getContexts(int iStartIndex = 0);

						/// <summary>
						/// Return contexts for the list
						/// </summary>
						/// <returns>the array of contexts for each row of the bound list</returns>
						public extern virtual sap.ui.model.Context[] getContexts();

						/// <summary>
						/// Get a download URL with the specified format considering the sort/filter/custom parameters.
						/// </summary>
						/// <param name="sFormat">Value for the $format Parameter</param>
						/// <returns>URL which can be used for downloading</returns>
						public extern virtual string getDownloadUrl(string sFormat);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.odata.ODataListBinding.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Initialize binding. Fires a change if data is already available ($expand) or a refresh. If metadata is not yet available, do nothing, method will be called again when metadata is loaded.
						/// </summary>
						public extern override void initialize();

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
						/// Sorts the list.
						/// </summary>
						/// <param name="aSorters">the Sorter or an array of sorter objects object which define the sort order</param>
						/// <returns>returns <code>this</code> to facilitate method chaining</returns>
						public extern override sap.ui.model.ListBinding sort(Union<sap.ui.model.Sorter, object[]> aSorters);

						#endregion

					}
				}
			}
		}
	}
}
