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
			public static partial class model
			{
				public static partial class odata
				{
					public static partial class v2
					{
						/// <summary>
						/// Tree binding implementation for OData models.
						/// 
						/// <h3>Hierarchy Annotations</h3> To use the v2.ODataTreeBinding with an OData service, which exposes hierarchy annotations, please see the <b>"SAP Annotations for OData Version 2.0"</b> Specification. The required property annotations, as well as accepted/default values are documented in the specification.
						/// 
						/// Services which include the <code>hierarchy-node-descendant-count-for</code> annotation and expose the data points in a depth-first pre-order sorted manner, can use an optimized auto-expand feature by specifying the <code>numberOfExpandedLevels</code> in the binding parameters. This will pre-expand the hierarchy to the given number of levels, with one single initial OData request.
						/// 
						/// For services without the <code>hierarchy-node-descendant-count-for</code> annotation, the <code>numberOfExpandedLevels</code> property is deprecated.
						/// 
						/// <h3>Navigation Properties</h3> <i>Important: The use of navigation properties to build up the hierarchy structure is deprecated and it is recommended to use the hierarchy annotations mentioned above instead.</i> In addition to these hierarchy annotations, the ODataTreeBinding also supports (cyclic) references between entities based on navigation properties. To do this you have to specify the binding parameter "navigation". The pattern for this is as follows: { entitySetName: "navigationPropertyName" }. Example: { "Employees": "toColleagues" }
						/// 
						/// <h3>OperationModes</h3> For a full definition and explanation of all OData binding OperationModes please see {@link sap.ui.model.odata.OperationMode}.
						/// 
						/// <h4>In OperationMode.Server</h4> Filtering on the ODataTreeBinding is only supported with application filters. However please be aware that this applies only to filters which do not prevent the creation of a hierarchy. So filtering on a property (e.g. a "Customer") is fine, as long as the application can ensure that the responses from the backend are sufficient to create a valid hierarchy on the client. Subsequent paging requests for sibiling and child nodes must also return responses since the filters will be sent with every request. Using Control-Filters ({@link sap.ui.model.FilterType}) via the filter() function is not supported for the OperationMode.Server.
						/// 
						/// </h4>OperationMode.Client and OperationMode.Auto</h4> The ODataTreeBinding supports Control-Filters only in OperationModes <code>Client</code> and <code>Auto</code>.
						/// 
						/// In these OperationModes, the filters and sorters will be applied on the client, same as for the v2.ODataListBinding.
						/// 
						/// The OperationModes <code>Client</code> and <code>Auto</code> are only supported for services. which expose the hierarchy annotations mentioned above, but do <b>not</b> expose the <code>hierarchy-node-descendant-count-for</code> annotation. Services with hierarchy annotations including the <code>hierarchy-node-descendant-count-for</code> annotation, do NOT support the OperationModes Client and Auto.
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class ODataTreeBinding : sap.ui.model.TreeBinding
						{
							#region Constructor

							/// <param name="oModel"></param>
							/// <param name="sPath"></param>
							/// <param name="oContext"></param>
							/// <param name="aApplicationFilters">predefined filter/s (can be either a filter or an array of filters). All initial filters, will be sent with every request. Filtering on the ODataTreeBinding is only supported with initial filters.</param>
							/// <param name="mParameters">Parameter Object</param>
							/// <param name="aSorters">predefined sorter/s (can be either a sorter or an array of sorters)</param>
							public extern ODataTreeBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, sap.ui.model.Filter[] aApplicationFilters, sap.ui.model.odata.v2.ODataModel.BindTreeInfo mParameters, sap.ui.model.Sorter[] aSorters);

							/// <param name="oModel"></param>
							/// <param name="sPath"></param>
							/// <param name="oContext"></param>
							/// <param name="aApplicationFilters">predefined filter/s (can be either a filter or an array of filters). All initial filters, will be sent with every request. Filtering on the ODataTreeBinding is only supported with initial filters.</param>
							/// <param name="mParameters">Parameter Object</param>
							public extern ODataTreeBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, sap.ui.model.Filter[] aApplicationFilters, sap.ui.model.odata.v2.ODataModel.BindTreeInfo mParameters);

							/// <param name="oModel"></param>
							/// <param name="sPath"></param>
							/// <param name="oContext"></param>
							/// <param name="aApplicationFilters">predefined filter/s (can be either a filter or an array of filters). All initial filters, will be sent with every request. Filtering on the ODataTreeBinding is only supported with initial filters.</param>
							public extern ODataTreeBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, sap.ui.model.Filter[] aApplicationFilters);

							/// <param name="oModel"></param>
							/// <param name="sPath"></param>
							/// <param name="oContext"></param>
							public extern ODataTreeBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataTreeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.TreeBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataTreeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.TreeBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataTreeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.TreeBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Applies the given filters to the ODataTreeBinding. Please note that "Control" filters are not supported for OperationMode.Server, here only "Application" filters are allowed. Filters given via the constructor are always Application filters and will be send with every backend-request. Please see the constructor documentation for more information.
							/// 
							/// Since 1.34.0 complete clientside filtering is supported for OperationMode.Client and in OperationMode.Auto, in case the backend-count is lower than the threshold. In this case all control and application filters will be applied on the client. See also: {@link sap.ui.model.odata.OperationMode.Auto}, {@link sap.ui.model.FilterType}.
							/// 
							/// For the OperationMode.Client and OperationMode.Auto, you may also specify the "useServersideApplicationFilters" constructor binding parameter. If this is set, the Application filters will always be applied on the backend, and thus trigger an OData request. Please see the constructor documentation for more information.
							/// </summary>
							/// <param name="aFilters"></param>
							/// <param name="sFilterType">Type of the filter which should be adjusted, if it is not given, the standard behaviour FilterType.Client applies</param>
							/// <returns>returns <code>this</code> to facilitate method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataTreeBinding filter(Union<sap.ui.model.Filter[], sap.ui.model.Filter> aFilters, sap.ui.model.FilterType sFilterType);

							/// <summary>
							/// Returns the number of child nodes. This function is not available when the annotation "hierarchy-node-descendant-count-for" is exposed on the service.
							/// </summary>
							/// <param name="oContext">the context element of the node</param>
							/// <returns>the number of children</returns>
							public extern override int getChildCount(object oContext);

							/// <summary>
							/// Get a download URL with the specified format considering the sort/filter/custom parameters.
							/// </summary>
							/// <param name="sFormat">Value for the $format Parameter</param>
							/// <returns>URL which can be used for downloading</returns>
							public extern virtual string getDownloadUrl(string sFormat);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.v2.ODataTreeBinding.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns the contexts of the child nodes for the given context. This function is not available when the annotation "hierarchy-node-descendant-count-for" is exposed on the service.
							/// </summary>
							/// <param name="oContext">the context for which the child nodes should be retrieved</param>
							/// <param name="iStartIndex">the start index of the requested contexts</param>
							/// <param name="iLength">the requested amount of contexts</param>
							/// <param name="iThreshold"></param>
							/// <returns>the contexts array</returns>
							public extern virtual sap.ui.model.Context[] getNodeContexts(sap.ui.model.Context oContext, int iStartIndex, int iLength, int iThreshold);

							/// <summary>
							/// Returns root contexts for the tree. You can specify the start index and the length for paging requests. This function is not available when the annotation "hierarchy-node-descendant-count-for" is exposed on the service.
							/// </summary>
							/// <param name="iStartIndex">the start index of the requested contexts</param>
							/// <param name="iLength">the requested amount of contexts. If none given, the default value is the size limit of the underlying sap.ui.model.odata.v2.ODataModel instance.</param>
							/// <param name="iThreshold">the number of entities which should be retrieved in addition to the given length. A higher threshold reduces the number of backend requests, yet these request blow up in size, since more data is loaded.</param>
							/// <returns>an array containing the contexts for the entities returned by the backend, might be fewer than requested if the backend does not have enough data.</returns>
							public extern virtual sap.ui.model.Context[] getRootContexts(int iStartIndex = 0, int iLength = -1, int iThreshold = 0);

							/// <summary>
							/// Returns the rootLevel
							/// </summary>
							/// <returns></returns>
							public extern virtual int getRootLevel();

							/// <summary>
							/// Returns the value of a given hierarchy annotation.
							/// </summary>
							/// <param name="sAttributeName">The name of the hierarchy annotation</param>
							/// <returns>The value of the hierarchy annotation</returns>
							private extern string getTreeAnnotation(string sAttributeName);

							/// <summary>
							/// Returns if the node has child nodes. If the ODataTreeBinding is running with hierarchy annotations, a context with the property values "expanded" or "collapsed" for the drilldown state property, returns true. Entities with drilldown state "leaf" return false.
							/// 
							/// This function is not available when the annotation "hierarchy-node-descendant-count-for" is exposed on the service.
							/// </summary>
							/// <param name="oContext">the context element of the node</param>
							/// <returns>true if node has children</returns>
							public extern virtual bool hasChildren(sap.ui.model.Context oContext);

							/// <summary>
							/// Initialize binding. Fires a change if data is already available ($expand) or a refresh. If metadata is not yet available, do nothing, method will be called again when metadata is loaded.
							/// </summary>
							/// <returns>The binding instance</returns>
							public extern virtual sap.ui.model.odata.v2.ODataTreeBinding initialize();

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
							/// Sets the rootLevel The root level is the level of the topmost tree nodes, which will be used as an entry point for OData services. This is only possible (and necessary) for OData services implementing the hierarchy annotation specification, or when providing the annotation information locally as a binding parameter. See the constructor for API documentation on this.
							/// </summary>
							/// <param name="iRootLevel"></param>
							public extern virtual void setRootLevel(int iRootLevel);

							/// <summary>
							/// Sorts the Tree according to the given Sorter(s). In OperationMode.Client or OperationMode.Auto (if the given threshold is satisfied), the sorters are applied locally on the client.
							/// </summary>
							/// <param name="aSorters">the Sorter or an Array of sap.ui.model.Sorter instances</param>
							/// <returns>returns <code>this</code> to facilitate method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataTreeBinding sort(Union<sap.ui.model.Sorter[], sap.ui.model.Sorter> aSorters);

							#endregion

						}
					}
				}
			}
		}
	}
}
