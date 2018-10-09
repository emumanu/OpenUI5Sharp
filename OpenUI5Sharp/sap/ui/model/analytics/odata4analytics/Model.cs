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
						/// Representation of an OData model with analytical annotations defined by OData4SAP.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.analytics.odata4analytics.Model")]
						public partial class Model
						{
							#region Constructor

							/// <summary>
							/// Create a representation of the analytical semantics of OData service metadata
							/// </summary>
							/// <param name="oModelReference">An instance of ReferenceByURI, ReferenceByModel or ReferenceWithWorkaround for locating the OData service.</param>
							/// <param name="mParameter">Additional parameters for controlling the model construction. Currently supported are: <li> sAnnotationJSONDoc - A JSON document providing extra annotations to the elements of the structure of the given service </li> <li> modelVersion - Parameter to define which ODataModel version should be used, in you use 'odata4analytics.Model.ReferenceByURI': 1 (default), 2 see also: AnalyticalVersionInfo constants </li></param>
							public extern Model(object oModelReference, object mParameter);

							/// <summary>
							/// Create a representation of the analytical semantics of OData service metadata
							/// </summary>
							/// <param name="oModelReference">An instance of ReferenceByURI, ReferenceByModel or ReferenceWithWorkaround for locating the OData service.</param>
							public extern Model(object oModelReference);

							#endregion

							#region Methods

							/// <summary>
							/// Find analytic query result by name
							/// </summary>
							/// <param name="sName">Fully qualified name of query result entity set</param>
							/// <returns>The query result object with this name or null if it does not exist</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.QueryResult findQueryResultByName(string sName);

							/// <summary>
							/// Get the names of all query results (entity sets) offered by the model
							/// </summary>
							/// <returns>List of all query result names</returns>
							public extern virtual string[] getAllQueryResultNames();

							/// <summary>
							/// Get all query results offered by the model
							/// </summary>
							/// <returns>An object with individual JS properties for each query result included in the model. The JS object properties all are objects of type odata4analytics.QueryResult. The names of the JS object properties are given by the entity set names representing the query results.</returns>
							public extern virtual object getAllQueryResults();

							/// <summary>
							/// Get underlying OData model provided by SAPUI5
							/// </summary>
							/// <returns>The SAPUI5 representation of the model.</returns>
							public extern virtual object getODataModel();

							#endregion

						}
					}
				}
			}
		}
	}
}
