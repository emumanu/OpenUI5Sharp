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
						/// Representation of an OData entity type.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.analytics.odata4analytics.EntityType")]
						public partial class EntityType
						{
							#region Constructor

							/// <summary>
							/// Create a representation of an OData entity type in the context of an analytic query. Do not create your own instances.
							/// </summary>
							/// <param name="oModel">datajs object for the OData model containing this entity type</param>
							/// <param name="oSchema">datajs object for the schema containing this entity type</param>
							/// <param name="oEntityType">datajs object for the entity type</param>
							public extern EntityType(object oModel, object oSchema, object oEntityType);

							#endregion

							#region Methods

							/// <summary>
							/// Find property by name
							/// </summary>
							/// <param name="sPropertyName">Property name</param>
							/// <returns>The datajs object representing the property or null if it does not exist</returns>
							public extern virtual object findPropertyByName(string sPropertyName);

							/// <summary>
							/// Get the names of all properties with an associated hierarchy
							/// </summary>
							/// <returns>List of all property names</returns>
							public extern virtual string[] getAllHierarchyPropertyNames();

							/// <summary>
							/// Get names of properties that can be filtered, that is they can be used in $filter expressions
							/// </summary>
							/// <returns>Array with names of properties that can be filtered.</returns>
							public extern virtual string[] getFilterablePropertyNames();

							/// <summary>
							/// Get heading of the property with specified name (identified by property metadata annotation sap:heading)
							/// </summary>
							/// <param name="sPropertyName">Property name</param>
							/// <returns>The heading string</returns>
							public extern virtual string getHeadingOfProperty(string sPropertyName);

							/// <summary>
							/// Get the hierarchy associated to a given property Based on the current specification, hierarchies are always recursive. TODO: Extend behavior when leveled hierarchies get in scope
							/// </summary>
							/// <param name="sName">Parameter name</param>
							/// <returns>The hierarchy object or null if it does not exist</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.RecursiveHierarchy getHierarchy(string sName);

							/// <summary>
							/// Get key properties of this type
							/// </summary>
							/// <returns>The list of key property names</returns>
							public extern virtual string[] getKeyProperties();

							/// <summary>
							/// Get label of the property with specified name (identified by property metadata annotation sap:label)
							/// </summary>
							/// <param name="sPropertyName">Property name</param>
							/// <returns>The label string</returns>
							public extern virtual string getLabelOfProperty(string sPropertyName);

							/// <summary>
							/// Get all properties
							/// </summary>
							/// <returns>Object with (JavaScript) properties, one for each (OData entity type) property. These (JavaScript) properties hold the datajs object representing the property</returns>
							public extern virtual object getProperties();

							/// <summary>
							/// Get properties for which filter restrictions have been specified
							/// </summary>
							/// <returns>Object with (JavaScript) properties, one for each (OData entity type) property. The property value is from odata4analytics.EntityType.propertyFilterRestriction and indicates the filter restriction for this property.</returns>
							public extern virtual object getPropertiesWithFilterRestrictions();

							/// <summary>
							/// Get the fully qualified name for this entity type
							/// </summary>
							/// <returns>The fully qualified name</returns>
							public extern virtual string getQName();

							/// <summary>
							/// Get quick info of the property with specified name (identified by property metadata annotation sap:quickinfo)
							/// </summary>
							/// <param name="sPropertyName">Property name</param>
							/// <returns>The quick info string</returns>
							public extern virtual string getQuickInfoOfProperty(string sPropertyName);

							/// <summary>
							/// Get names of properties that must be filtered, that is they must appear in every $filter expression
							/// </summary>
							/// <returns>Array with names of properties that must be filtered.</returns>
							public extern virtual string[] getRequiredFilterPropertyNames();

							/// <summary>
							/// Get names of properties that can be sorted, that is they can be used in $orderby expressions
							/// </summary>
							/// <returns>Array with names of properties that can be sorted.</returns>
							public extern virtual string[] getSortablePropertyNames();

							/// <summary>
							/// Get the super-ordinate property related to the property with specified name (identified by property metadata annotation sap:super-ordinate)
							/// </summary>
							/// <param name="sPropertyName">Property name</param>
							/// <returns>The datajs object representing the super-ordinate property or null if it does not exist</returns>
							public extern virtual object getSuperOrdinatePropertyOfProperty(string sPropertyName);

							/// <summary>
							/// Get the text property related to the property with specified name (identified by property metadata annotation sap:text)
							/// </summary>
							/// <param name="sPropertyName">Property name</param>
							/// <returns>The datajs object representing the text property or null if it does not exist</returns>
							public extern virtual object getTextPropertyOfProperty(string sPropertyName);

							/// <summary>
							/// Get full description for this entity type
							/// </summary>
							/// <returns>The datajs object representing the entity type</returns>
							public extern virtual object getTypeDescription();

							#endregion

						}
					}
				}
			}
		}
	}
}
