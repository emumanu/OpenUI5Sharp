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
				public static partial class analytics
				{
					public static partial class odata4analytics
					{
						/// <summary>
						/// Creation of URIs for fetching a query dimension value set.
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class DimensionMemberSetRequest
						{
							#region Constructor

							/// <summary>
							/// Create a request object for interaction with a dimension value help. Such a value help is served by either the query result entity set, in which case the returned dimension members are limited to those also used in the query result data. Or, the value help is populated by a master data entity set, if made available by the service. In this case, the result will include all valid members for that dimension.
							/// </summary>
							/// <param name="oDimension">Description of a dimension</param>
							/// <param name="oParameterizationRequest">(optional) Request object for interactions with the parameterization of the query result or (not yet supported) master data entity set Such an object is required if the entity set holding the dimension members includes parameters.</param>
							/// <param name="bUseMasterData">(optional) Indicates use of master data for determining the dimension members.</param>
							public extern DimensionMemberSetRequest(sap.ui.model.analytics.odata4analytics.Dimension oDimension, sap.ui.model.analytics.odata4analytics.ParameterizationRequest oParameterizationRequest, bool bUseMasterData);

							#endregion

							#region Methods

							/// <summary>
							/// Get the filter expression for this request.
							/// 
							/// Expressions are represented by separate objects. If none exists so far, a new expression object gets created.
							/// </summary>
							/// <returns>The filter object associated to this request.</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.FilterExpression getFilterExpression();

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
							/// <param name="sQueryOptionName">Identifies the query option: $select, $filter,... or any custom query option</param>
							/// <returns>The value of the requested query option or null, if this option is not used for the OData request.</returns>
							public extern virtual string getURIQueryOptionValue(string sQueryOptionName);

							/// <summary>
							/// Get the URI to locate the entity set for the dimension memebers.
							/// </summary>
							/// <param name="sServiceRootURI">(optional) Identifies the root of the OData service</param>
							/// <returns>The resource path of the URI pointing to the entity set. It is a relative URI unless a service root is given, which would then prefixed in order to return a complete URL.</returns>
							public extern virtual string getURIToDimensionMemberEntitySet(string sServiceRootURI);

							/// <summary>
							/// Get the unescaped URI to fetch the dimension members, optionally augmented by text and attributes.
							/// </summary>
							/// <param name="sServiceRootURI">(optional) Identifies the root of the OData service</param>
							/// <returns>The unescaped URI that contains the OData resource path and OData system query options to express the request for the parameter value set..</returns>
							public extern virtual string getURIToDimensionMemberEntries(string sServiceRootURI);

							/// <summary>
							/// Set the filter expression for this request.
							/// 
							/// Expressions are represented by separate objects. Calling this method replaces the filter object maintained by this request.
							/// </summary>
							/// <param name="oFilter">The filter object to be associated with this request.</param>
							public extern virtual void setFilterExpression(sap.ui.model.analytics.odata4analytics.FilterExpression oFilter);

							/// <summary>
							/// Set the parameterization request required for retrieving dimension members directly from the query result, if it is parameterized.
							/// </summary>
							/// <param name="oParameterizationRequest">Request object for interactions with the parameterization of this query result</param>
							public extern virtual void setParameterizationRequest(object oParameterizationRequest);

							/// <summary>
							/// Set further options to be applied for the OData request
							/// </summary>
							/// <param name="bIncludeCount">Indicates whether or not the result shall include a count for the returned entities. Default is not to include it. Pass null to keep current setting.</param>
							public extern virtual void setRequestOptions(bool bIncludeCount);

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
