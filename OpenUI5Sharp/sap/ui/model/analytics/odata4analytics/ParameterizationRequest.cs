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
						/// Creation of URIs for query parameterizations.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.analytics.odata4analytics.ParameterizationRequest")]
						public partial class ParameterizationRequest
						{
							#region Constructor

							/// <summary>
							/// Create a request object for interaction with a query parameterization.
							/// </summary>
							/// <param name="oParameterization">Description of a query parameterization</param>
							public extern ParameterizationRequest(sap.ui.model.analytics.odata4analytics.Parameterization oParameterization);

							#endregion

							#region Methods

							/// <summary>
							/// Get the description of the parameterization on which this request operates on
							/// </summary>
							/// <returns>Description of a query parameterization</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.Parameterization getParameterization();

							/// <summary>
							/// Get the URI to locate the entity set for the query parameterization.
							/// </summary>
							/// <param name="sServiceRootURI">(optional) Identifies the root of the OData service</param>
							/// <returns>The resource path of the URI pointing to the entity set. It is a relative URI unless a service root is given, which would then prefixed in order to return a complete URL.</returns>
							public extern virtual void getURIToParameterizationEntitySet(string sServiceRootURI);

							/// <summary>
							/// Get the URI to locate the parameterization entity for the values assigned to all parameters beforehand. Notice that a value must be supplied for every parameter including those marked as optional. For optional parameters, assign the special value that the service provider uses as an "omitted" value. For example, for services based on BW Easy Queries, this would be an empty string.
							/// </summary>
							/// <param name="sServiceRootURI">(optional) Identifies the root of the OData service</param>
							/// <returns>The resource path of the URI pointing to the entity set. It is a relative URI unless a service root is given, which would then prefixed in order to return a complete URL.</returns>
							public extern virtual void getURIToParameterizationEntry(string sServiceRootURI);

							/// <summary>
							/// Assign a value to a parameter
							/// </summary>
							/// <param name="sParameterName">Name of the parameter. In case of a range value, provide the name of the lower boundary parameter.</param>
							/// <param name="sValue">Assigned value. Pass null to remove a value assignment.</param>
							/// <param name="sToValue">Omit it or set it to null for single values. If set, it will be assigned to the upper boundary parameter</param>
							public extern virtual void setParameterValue(string sParameterName, string sValue, string sToValue);

							#endregion

						}
					}
				}
			}
		}
	}
}
