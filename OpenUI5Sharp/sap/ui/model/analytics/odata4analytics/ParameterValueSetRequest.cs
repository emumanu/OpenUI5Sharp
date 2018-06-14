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
						/// Creation of URIs for fetching a query parameter value set.
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class ParameterValueSetRequest
						{
							#region Constructor

							/// <summary>
							/// Create a request object for interaction with a query parameter value help.
							/// </summary>
							/// <param name="oParameter">Description of a query parameter</param>
							public extern ParameterValueSetRequest(sap.ui.model.analytics.odata4analytics.Parameter oParameter);

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
							/// Get the unescaped URI to fetch the parameter value set.
							/// </summary>
							/// <param name="sServiceRootURI">(optional) Identifies the root of the OData service</param>
							/// <returns>The unescaped URI that contains the OData resource path and OData system query options to express the request for the parameter value set..</returns>
							public extern virtual string getURIToParameterValueSetEntries(string sServiceRootURI);

							/// <summary>
							/// Specify which components of the parameter shall be included in the value set.
							/// </summary>
							/// <param name="bIncludeText">Indicator whether or not to include the parameter text (if available) in the value set. Pass null to keep current setting.</param>
							public extern virtual void includeParameterText(bool bIncludeText);

							/// <summary>
							/// Set the filter expression for this request.
							/// 
							/// Expressions are represented by separate objects. Calling this method replaces the filter object maintained by this request.
							/// </summary>
							/// <param name="oFilter">The filter object to be associated with this request.</param>
							public extern virtual void setFilterExpression(sap.ui.model.analytics.odata4analytics.FilterExpression oFilter);

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
