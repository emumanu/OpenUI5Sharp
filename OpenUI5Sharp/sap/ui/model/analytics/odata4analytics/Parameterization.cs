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
						/// Representation of an entity type annotated with sap:semantics="parameters".
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class Parameterization
						{
							#region Constructor

							/// <summary>
							/// Create a representation of a parameterization for an analytic query. Do not create your own instances.
							/// </summary>
							/// <param name="oEntityType">The OData entity type for this parameterization</param>
							/// <param name="oEntitySet">The OData entity set for this parameterization offered by the OData service</param>
							public extern Parameterization(sap.ui.model.analytics.odata4analytics.EntityType oEntityType, sap.ui.model.analytics.odata4analytics.EntitySet oEntitySet);

							#endregion

							#region Methods

							/// <summary>
							/// Find parameter by name
							/// </summary>
							/// <param name="sName">Parameter name</param>
							/// <returns>The parameter object with this name or null if it does not exist</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.Parameter findParameterByName(string sName);

							/// <summary>
							/// Get the names of all parameters part of the parameterization
							/// </summary>
							/// <returns>List of all parameter names</returns>
							public extern virtual string[] getAllParameterNames();

							/// <summary>
							/// Get all parameters included in this parameterization
							/// </summary>
							/// <returns>An object with individual JS properties for each parameter included in the query result. The JS object properties all are objects of type odata4analytics.Parameter. The names of the JS object properties are given by the OData entity type property names representing the parameter keys.</returns>
							public extern virtual object getAllParameters();

							/// <summary>
							/// Get the entity set representing this query result in the OData model
							/// </summary>
							/// <returns>The OData entity set representing this query result</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.EntitySet getEntitySet();

							/// <summary>
							/// Get the entity type defining the type of this query result in the OData model
							/// </summary>
							/// <returns>The OData entity type for this query result</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.EntityType getEntityType();

							/// <summary>
							/// Get the name of the parameter
							/// </summary>
							/// <returns>The name of the parameterization, which is identical with the name of the entity set representing the parameterization in the OData service</returns>
							public extern virtual string getName();

							/// <summary>
							/// Get navigation property to query result
							/// </summary>
							/// <returns>The parameter object with this name or null if it does not exist</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.QueryResult getNavigationPropertyToQueryResult();

							#endregion

						}
					}
				}
			}
		}
	}
}
