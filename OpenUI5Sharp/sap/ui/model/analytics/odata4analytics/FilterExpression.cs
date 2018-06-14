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
						/// Representation of a $filter expression for an OData entity type.
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class FilterExpression
						{
							#region Constructor

							/// <summary>
							/// Create a representation of a filter expression for a given entity type. It can be rendered as value for the $filter system query option.
							/// </summary>
							/// <param name="oModel">datajs object for the OData model containing this entity type</param>
							/// <param name="oSchema">datajs object for the schema containing this entity type</param>
							/// <param name="oEntityType">object for the entity type</param>
							public extern FilterExpression(object oModel, object oSchema, sap.ui.model.analytics.odata4analytics.EntityType oEntityType);

							#endregion

							#region Methods

							/// <summary>
							/// Add a condition to the filter expression.
							/// 
							/// Multiple conditions on the same property are combined with a logical OR first, and in a second step conditions for different properties are combined with a logical AND.
							/// </summary>
							/// <param name="sPropertyName">The name of the property bound in the condition</param>
							/// <param name="sOperator">operator used for the condition</param>
							/// <param name="oValue">value to be used for this condition</param>
							/// <param name="oValue2">(optional) as second value to be used for this condition</param>
							/// <returns>This object for method chaining</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.FilterExpression addCondition(string sPropertyName, sap.ui.model.FilterOperator sOperator, object oValue, object oValue2);

							/// <summary>
							/// Add a set condition to the filter expression.
							/// 
							/// A set condition tests if the value of a property is included in a set of given values. It is a convenience method for this particular use case eliminating the need for multiple API calls.
							/// </summary>
							/// <param name="sPropertyName">The name of the property bound in the condition</param>
							/// <param name="aValues">values defining the set</param>
							/// <returns>This object for method chaining</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.FilterExpression addSetCondition(string sPropertyName, object[] aValues);

							/// <summary>
							/// Add an array of UI5 filter conditions to the filter expression.
							/// 
							/// The UI5 filter condition is combined with the other given conditions using a logical AND. This method is particularly useful for passing forward already created UI5 filter arrays.
							/// </summary>
							/// <param name="aUI5Filter">Array of UI5 filter objects</param>
							/// <returns>This object for method chaining</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.FilterExpression addUI5FilterConditions(sap.ui.model.Filter[] aUI5Filter);

							/// <summary>
							/// Check if request is compliant with basic filter constraints expressed in metadata:
							/// 
							/// (a) all properties required in the filter expression have been referenced (b) the single-value filter restrictions have been obeyed
							/// </summary>
							/// <returns>The value true. In case the expression violates some of the rules, an exception with some explanatory message is thrown</returns>
							public extern virtual bool checkValidity();

							/// <summary>
							/// Clear expression from any conditions that may have been set previously
							/// </summary>
							public extern virtual void clear();

							/// <summary>
							/// Get description for this entity type
							/// </summary>
							/// <returns>The object representing the entity type</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.EntityType getEntityType();

							/// <summary>
							/// Get an array of SAPUI5 Filter objects corresponding to this expression.
							/// </summary>
							/// <returns>List of filter objects representing this expression</returns>
							public extern virtual sap.ui.model.Filter[] getExpressionAsUI5FilterArray();

							/// <summary>
							/// Get the value for the OData system query option $filter corresponding to this expression.
							/// </summary>
							/// <returns>The $filter value for the filter expression</returns>
							public extern virtual string getURIFilterOptionValue();

							/// <summary>
							/// Remove all conditions for some property from the filter expression.
							/// 
							/// All previously set conditions for some property are removed from the filter expression.
							/// </summary>
							/// <param name="sPropertyName">The name of the property bound in the condition</param>
							/// <returns>This object for method chaining</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.FilterExpression removeConditions(string sPropertyName);

							#endregion

						}
					}
				}
			}
		}
	}
}
