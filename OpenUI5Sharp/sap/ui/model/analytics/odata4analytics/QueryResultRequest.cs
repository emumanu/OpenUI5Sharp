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
				public static partial class analytics
				{
					public static partial class odata4analytics
					{
						/// <summary>
						/// Creation of URIs for fetching query results.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.analytics.odata4analytics.QueryResultRequest")]
						public partial class QueryResultRequest
						{
							#region Constructor

							/// <summary>
							/// Create a request object for interaction with a query result.
							/// </summary>
							/// <param name="oQueryResult">Description of a query parameterization</param>
							/// <param name="oParameterizationRequest">Request object for interactions with the parameterization of this query. Only required if the query service includes parameters.</param>
							public extern QueryResultRequest(sap.ui.model.analytics.odata4analytics.QueryResult oQueryResult, sap.ui.model.analytics.odata4analytics.ParameterizationRequest oParameterizationRequest);

							/// <summary>
							/// Create a request object for interaction with a query result.
							/// </summary>
							/// <param name="oQueryResult">Description of a query parameterization</param>
							public extern QueryResultRequest(sap.ui.model.analytics.odata4analytics.QueryResult oQueryResult);

							#endregion

							#region Methods

							/// <summary>
							/// Adds a recursive hierarchy to the aggregation level.
							/// </summary>
							/// <param name="sHierarchyDimensionName">Name of dimension whose hierarchy shall be part of the aggregation level</param>
							/// <param name="bIncludeExternalKey">Indicator whether or not to include the external node key (if available) in the query result</param>
							/// <param name="bIncludeText">Indicator whether or not to include the node text (if available) in the query result</param>
							public extern virtual void addRecursiveHierarchy(string sHierarchyDimensionName, bool bIncludeExternalKey, bool bIncludeText);

							/// <summary>
							/// Add one or more dimensions to the aggregation level
							/// </summary>
							/// <param name="aDimensionName">Array of dimension names to be added to the already defined aggregation level.</param>
							public extern virtual void addToAggregationLevel(object aDimensionName);

							/// <summary>
							/// Get the names of the dimensions included in the aggregation level
							/// </summary>
							/// <returns>The dimension names included in the aggregation level</returns>
							public extern virtual object[] getAggregationLevel();

							/// <summary>
							/// Get details about a dimensions included in the aggregation level
							/// </summary>
							/// <param name="sDImensionName">Name of a dimension included in the aggregation level of this request, for which details shall be returned</param>
							/// <returns>An object with three properties named key and text, both with Boolean values indicating whether the key and text of this dimension are included in this request. The third property named attributes is an array of attribute names of this dimension included in this request, or null, if there are none.</returns>
							public extern virtual object getAggregationLevelDetails(object sDImensionName);

							/// <summary>
							/// Get the filter expression for this request.
							/// 
							/// Expressions are represented by separate objects. If none exists so far, a new expression object gets created.
							/// </summary>
							/// <returns>The filter object associated to this request.</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.FilterExpression getFilterExpression();

							/// <summary>
							/// Get the names of the measures included in the query result request
							/// </summary>
							/// <returns>The measure names included in the query result request</returns>
							public extern virtual object[] getMeasureNames();

							/// <summary>
							/// Retrieves the current parametrization request
							/// </summary>
							/// <returns></returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.ParameterizationRequest getParameterizationRequest();

							/// <summary>
							/// Get the description of the query result on which this request operates on
							/// </summary>
							/// <returns>Description of a query result</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.QueryResult getQueryResult();

							/// <summary>
							/// Returns the current page boundaries as object with properties <code>start</code> and <code>end</code>. If the end of the page is unbounded, <code>end</code> is null.
							/// </summary>
							/// <returns>the current page boundaries as object</returns>
							public extern virtual object getResultPageBoundaries();

							/// <summary>
							/// Get the sort expression for this request.
							/// 
							/// Expressions are represented by separate objects. If none exists so far, a new expression object gets created.
							/// </summary>
							/// <returns>The sort object associated to this request.</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.SortExpression getSortExpression();

							/// <summary>
							/// Get the value of a query option for the OData request URI corresponding to this request.
							/// </summary>
							/// <param name="sQueryOptionName">Identifies the query option: $select, $filter,$orderby ... or any custom query option</param>
							/// <returns>The value of the requested query option or null, if this option is not used for the OData request.</returns>
							public extern virtual string getURIQueryOptionValue(string sQueryOptionName);

							/// <summary>
							/// Get the URI to locate the entity set for the query result.
							/// </summary>
							/// <param name="sServiceRootURI">(optional) Identifies the root of the OData service</param>
							/// <returns>The resource path of the URI pointing to the entity set. It is a relative URI unless a service root is given, which would then prefixed in order to return a complete URL.</returns>
							public extern virtual string getURIToQueryResultEntitySet(string sServiceRootURI);

							/// <summary>
							/// Get the unescaped URI to fetch the query result.
							/// </summary>
							/// <param name="sServiceRootURI">(optional) Identifies the root of the OData service</param>
							/// <param name="sResourcePath">(optional) OData resource path to be considered. If provided, it overwrites any parameterization object that might have been specified separately.</param>
							/// <returns>The unescaped URI that contains the OData resource path and OData system query options to express the aggregation level, filter expression and further options.</returns>
							public extern virtual string getURIToQueryResultEntries(string sServiceRootURI, string sResourcePath);

							/// <summary>
							/// Specify which dimension components shall be included in the query result. The settings get applied to the currently defined aggregation level.
							/// </summary>
							/// <param name="sDimensionName">Name of the dimension for which the settings get applied. Specify null to apply the settings to all dimensions in the aggregation level.</param>
							/// <param name="bIncludeKey">Indicator whether or not to include the dimension key in the query result. Pass null to keep current setting.</param>
							/// <param name="bIncludeText">Indicator whether or not to include the dimension text (if available) in the query result. Pass null to keep current setting.</param>
							/// <param name="aAttributeName">Array of dimension attribute names to be included in the result. Pass null to keep current setting. This argument is ignored if sDimensionName is null.</param>
							public extern virtual void includeDimensionKeyTextAttributes(string sDimensionName, bool bIncludeKey, bool bIncludeText, object aAttributeName);

							/// <summary>
							/// Specify which measure components shall be included in the query result. The settings get applied to the currently set measures.
							/// </summary>
							/// <param name="sMeasureName">Name of the measure for which the settings get applied. Specify null to apply the settings to all currently set measures.</param>
							/// <param name="bIncludeRawValue">Indicator whether or not to include the raw value in the query result. Pass null to keep current setting.</param>
							/// <param name="bIncludeFormattedValue">Indicator whether or not to include the formatted value (if available) in the query result. Pass null to keep current setting.</param>
							/// <param name="bIncludeUnit">Indicator whether or not to include the unit (if available) in the query result. Pass null to keep current setting.</param>
							public extern virtual void includeMeasureRawFormattedValueUnit(string sMeasureName, bool bIncludeRawValue, bool bIncludeFormattedValue, bool bIncludeUnit);

							/// <summary>
							/// Remove one or more dimensions from the aggregation level. The method also removed a potential sort expression on the dimension.
							/// </summary>
							/// <param name="aDimensionName">Array of dimension names to be removed from the already defined aggregation level.</param>
							public extern virtual void removeFromAggregationLevel(object aDimensionName);

							/// <summary>
							/// Set the aggregation level for the query result request. By default, the query result will include the properties holding the keys of the given dimensions. This setting can be changed using includeDimensionKeyTextAttributes.
							/// </summary>
							/// <param name="aDimensionName">Array of dimension names to be part of the aggregation level. If null, the aggregation level includes all dimensions, if empty, no dimension is included.</param>
							public extern virtual void setAggregationLevel(object aDimensionName);

							/// <summary>
							/// Set the filter expression for this request.
							/// 
							/// Expressions are represented by separate objects. Calling this method replaces the filter object maintained by this request.
							/// </summary>
							/// <param name="oFilter">The filter object to be associated with this request.</param>
							public extern virtual void setFilterExpression(sap.ui.model.analytics.odata4analytics.FilterExpression oFilter);

							/// <summary>
							/// Set the measures to be included in the query result request. By default, the query result will include the properties holding the raw values of the given measures. This setting can be changed using includeMeasureRawFormattedValueUnit.
							/// </summary>
							/// <param name="aMeasureName">Array of measure names to be part of the query result request. If null, the request includes all measures, if empty, no measure is included.</param>
							public extern virtual void setMeasures(object aMeasureName);

							/// <summary>
							/// Set the parameterization request required for interactions with the query result of parameterized queries. This method provides an alternative way to assign a parameterization request to a query result request.
							/// </summary>
							/// <param name="oParameterizationRequest">Request object for interactions with the parameterization of this query</param>
							public extern virtual void setParameterizationRequest(object oParameterizationRequest);

							/// <summary>
							/// Set further options to be applied for the OData request to fetch the query result
							/// </summary>
							/// <param name="bIncludeEntityKey">Indicates whether or not the entity key should be returned for every entry in the query result. Default is not to include it. Pass null to keep current setting.</param>
							/// <param name="bIncludeCount">Indicates whether or not the result shall include a count for the returned entities. Default is not to include it. Pass null to keep current setting.</param>
							/// <param name="bReturnNoEntities">Indicates whether or not the result shall be empty. This will translate to $top=0 in the OData request and override any setting done with setResultPageBoundaries. The default is not to suppress entities in the result. Pass null to keep current setting. The main use case for this option is to create a request with $inlinecount returning an entity count.</param>
							public extern virtual void setRequestOptions(bool bIncludeEntityKey, bool bIncludeCount, bool bReturnNoEntities);

							/// <summary>
							/// Set the resource path to be considered for the OData request URI of this query request object. This method provides an alternative way to assign a path comprising a parameterization. If a path is provided, it overwrites any parameterization object that might have been specified separately.
							/// </summary>
							/// <param name="sResourcePath">Resource path pointing to the entity set of the query result. Must include a valid parameterization if query contains parameters.</param>
							public extern virtual void setResourcePath(string sResourcePath);

							/// <summary>
							/// Specify that only a page of the query result shall be returned. A page is described by its boundaries, that are row numbers for the first and last rows in the query result to be returned.
							/// </summary>
							/// <param name="start">The first row of the query result to be returned. Numbering starts at 1. Passing null is equivalent to start with the first row.</param>
							/// <param name="end">The last row of the query result to be returned. Passing null is equivalent to get all rows up to the end of the query result.</param>
							public extern virtual void setResultPageBoundaries(int start, int end);

							/// <summary>
							/// Set the sort expression for this request.
							/// 
							/// Expressions are represented by separate objects. Calling this method replaces the sort object maintained by this request.
							/// </summary>
							/// <param name="oSorter">The sort object to be associated with this request.</param>
							public extern virtual void setSortExpression(sap.ui.model.analytics.odata4analytics.SortExpression oSorter);

							#endregion

						}
					}
				}
			}
		}
	}
}
