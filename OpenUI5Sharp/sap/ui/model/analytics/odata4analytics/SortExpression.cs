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
						/// Representation of a $orderby expression for an OData entity type.
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class SortExpression
						{
							#region Constructor

							/// <summary>
							/// Create a representation of an order by expression for a given entity type. It can be rendered as value for the $orderby system query option.
							/// </summary>
							/// <param name="oModel">datajs object for the OData model containing this entity type</param>
							/// <param name="oSchema">datajs object for the schema containing this entity type</param>
							/// <param name="oEntityType">object for the entity type</param>
							public extern SortExpression(object oModel, object oSchema, sap.ui.model.analytics.odata4analytics.EntityType oEntityType);

							#endregion

							#region Methods

							/// <summary>
							/// Add a condition to the order by expression. It replaces any previously specified sort order for the property.
							/// </summary>
							/// <param name="sPropertyName">The name of the property bound in the condition</param>
							/// <param name="sSortOrder">sorting order used for the condition</param>
							/// <returns>This object for method chaining</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.SortExpression addSorter(string sPropertyName, sap.ui.model.analytics.odata4analytics.SortOrder sSortOrder);

							/// <summary>
							/// Clear expression from any sort conditions that may have been set previously
							/// </summary>
							public extern virtual void clear();

							/// <summary>
							/// Get description for this entity type
							/// </summary>
							/// <returns>The object representing the entity type</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.EntityType getEntityType();

							/// <summary>
							/// Get the first SAPUI5 Sorter object.
							/// </summary>
							/// <returns>first sorter object or null if empty</returns>
							public extern virtual sap.ui.model.Sorter getExpressionAsUI5Sorter();

							/// <summary>
							/// Get an array of SAPUI5 Sorter objects corresponding to this expression.
							/// </summary>
							/// <returns>List of sorter objects representing this expression</returns>
							public extern virtual sap.ui.model.Sorter[] getExpressionsAsUI5SorterArray();

							/// <summary>
							/// Get the value for the OData system query option $orderby corresponding to this expression.
							/// </summary>
							/// <param name="oSelectedPropertyNames">Object with properties requested for $select</param>
							/// <returns>The $orderby value for the sort expressions</returns>
							public extern virtual string getURIOrderByOptionValue(object oSelectedPropertyNames);

							/// <summary>
							/// Removes the order by expression for the given property name from the list of order by expression. If no order by expression with this property name exists the method does nothing.
							/// </summary>
							/// <param name="sPropertyName">The name of the property to be removed from the condition</param>
							public extern virtual void removeSorter(string sPropertyName);

							#endregion

						}
					}
				}
			}
		}
	}
}
