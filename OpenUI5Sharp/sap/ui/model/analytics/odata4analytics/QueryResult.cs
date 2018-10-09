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
						/// Representation of an entity type annotated with sap:semantics="aggregate".
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.analytics.odata4analytics.QueryResult")]
						public partial class QueryResult
						{
							#region Constructor

							/// <summary>
							/// Create a representation of an analytic query. Do not create your own instances.
							/// </summary>
							/// <param name="oModel">The analytical model containing this query result entity set</param>
							/// <param name="oEntityType">The OData entity type for this query</param>
							/// <param name="oEntitySet">The OData entity set for this query offered by the OData service</param>
							/// <param name="oParameterization">The parameterization of this query, if any</param>
							public extern QueryResult(sap.ui.model.analytics.odata4analytics.Model oModel, sap.ui.model.analytics.odata4analytics.EntityType oEntityType, sap.ui.model.analytics.odata4analytics.EntitySet oEntitySet, sap.ui.model.analytics.odata4analytics.Parameterization oParameterization);

							#endregion

							#region Methods

							/// <summary>
							/// Find dimension by name
							/// </summary>
							/// <param name="sName">Dimension name</param>
							/// <returns>The dimension object with this name or null if it does not exist</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.Dimension findDimensionByName(string sName);

							/// <summary>
							/// Find dimension by property name
							/// </summary>
							/// <param name="sName">Property name</param>
							/// <returns>The dimension object to which the given property name is related, because the property holds the dimension key, its text, or is an attribute of this dimension. If no such dimension exists, null is returned.</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.Dimension findDimensionByPropertyName(string sName);

							/// <summary>
							/// Find measure by name
							/// </summary>
							/// <param name="sName">Measure name</param>
							/// <returns>The measure object with this name or null if it does not exist</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.Measure findMeasureByName(string sName);

							/// <summary>
							/// Find measure by property name
							/// </summary>
							/// <param name="sName">Property name</param>
							/// <returns>The measure object to which the given property name is related, because the property holds the raw measure value or its formatted value. If no such measure exists, null is returned.</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.Measure findMeasureByPropertyName(string sName);

							/// <summary>
							/// Get the names of all dimensions included in the query result
							/// </summary>
							/// <returns>List of all dimension names</returns>
							public extern virtual string[] getAllDimensionNames();

							/// <summary>
							/// Get all dimensions included in this query result
							/// </summary>
							/// <returns>An object with individual JS properties for each dimension included in the query result. The JS object properties all are objects of type odata4analytics.Dimension. The names of the JS object properties are given by the OData entity type property names representing the dimension keys.</returns>
							public extern virtual object getAllDimensions();

							/// <summary>
							/// Get the names of all measures included in the query result
							/// </summary>
							/// <returns>List of all measure names</returns>
							public extern virtual string[] getAllMeasureNames();

							/// <summary>
							/// Get all measures included in this query result
							/// </summary>
							/// <returns>An object with individual JS properties for each measure included in the query result. The JS object properties all are objects of type odata4analytics.Measure. The names of the JS object properties are given by the OData entity type property names representing the measure raw values.</returns>
							public extern virtual object getAllMeasures();

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
							/// Get the analytical model containing the entity set for this query result
							/// </summary>
							/// <returns>The analytical representation of the OData model</returns>
							public extern virtual object getModel();

							/// <summary>
							/// Get the name of the query result
							/// </summary>
							/// <returns>The fully qualified name of the query result, which is identical with the name of the entity set representing the query result in the OData service</returns>
							public extern virtual string getName();

							/// <summary>
							/// Get the parameterization of this query result
							/// </summary>
							/// <returns>The object for the parameterization or null if the query result is not parameterized</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.Parameterization getParameterization();

							/// <summary>
							/// Get property holding the totaled property list
							/// </summary>
							/// <returns>The datajs object representing this property</returns>
							public extern virtual object getTotaledPropertiesListProperty();

							#endregion

						}
					}
				}
			}
		}
	}
}
