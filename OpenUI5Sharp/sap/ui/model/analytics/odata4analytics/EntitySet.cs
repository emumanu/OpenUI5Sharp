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
						/// Representation of an OData entity set.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.analytics.odata4analytics.EntitySet")]
						public partial class EntitySet
						{
							#region Constructor

							/// <summary>
							/// Create a representation of an OData entity set in the context of an analytic query. Do not create your own instances.
							/// </summary>
							/// <param name="oModel">datajs object for the OData model containing this entity set</param>
							/// <param name="oSchema">datajs object for the schema surrounding the container of this entity set</param>
							/// <param name="oContainer">datajs object for the container holding this entity set</param>
							/// <param name="oEntitySet">datajs object for the entity set</param>
							/// <param name="oEntityType">datajs object for the entity type</param>
							public extern EntitySet(object oModel, object oSchema, object oContainer, object oEntitySet, object oEntityType);

							#endregion

							#region Methods

							/// <summary>
							/// Get entity type used for this entity set
							/// </summary>
							/// <returns>The datajs object representing the entity type</returns>
							public extern virtual object getEntityType();

							/// <summary>
							/// Get the fully qualified name for this entity type
							/// </summary>
							/// <returns>The fully qualified name</returns>
							public extern virtual string getQName();

							/// <summary>
							/// Get full description for this entity set
							/// </summary>
							/// <returns>The datajs object representing the entity set</returns>
							public extern virtual object getSetDescription();

							/// <summary>
							/// Get names of properties in this entity set that can be updated
							/// </summary>
							/// <returns>An object with individual JS properties for each updatable property. For testing whether propertyName is the name of an updatable property, use <code>getUpdatablePropertyNameSet()[propertyName]</code>. The included JS object properties are all set to true.</returns>
							public extern virtual object getUpdatablePropertyNameSet();

							#endregion

						}
					}
				}
			}
		}
	}
}
