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
						/// Representation of a property annotated with sap:aggregation-role="dimension".
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class Dimension
						{
							#region Constructor

							/// <summary>
							/// Create a representation of a dimension provided by an analytic query. Do not create your own instances.
							/// </summary>
							/// <param name="oQueryResult">The query result containing this dimension</param>
							/// <param name="oProperty">The datajs object object representing the dimension</param>
							public extern Dimension(sap.ui.model.analytics.odata4analytics.QueryResult oQueryResult, object oProperty);

							#endregion

							#region Methods

							/// <summary>
							/// Find attribute by name
							/// </summary>
							/// <param name="sName">Attribute name</param>
							/// <returns>The dimension attribute object with this name or null if it does not exist</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.Dimension findAttributeByName(string sName);

							/// <summary>
							/// Get the names of all attributes included in this dimension
							/// </summary>
							/// <returns>List of all attribute names</returns>
							public extern virtual string[] getAllAttributeNames();

							/// <summary>
							/// Get all attributes of this dimension
							/// </summary>
							/// <returns>An object with individual JS properties for each attribute of this dimension. The JS object properties all are objects of type odata4analytics.DimensionAttribute. The names of the JS object properties are given by the OData entity type property names representing the dimension attribute keys.</returns>
							public extern virtual object getAllAttributes();

							/// <summary>
							/// Get query result containing this dimension
							/// </summary>
							/// <returns>The query result object</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.QueryResult getContainingQueryResult();

							/// <summary>
							/// Get associated hierarchy
							/// </summary>
							/// <returns>The hierarchy object or null if there is none. It can be an instance of class odata4analytics.RecursiveHierarchy (TODO later: or a leveled hierarchy). Use methods isLeveledHierarchy and isRecursiveHierarchy to determine object type.</returns>
							public extern virtual object getHierarchy();

							/// <summary>
							/// Get the key property
							/// </summary>
							/// <returns>The datajs object representing the property for the dimension key</returns>
							public extern virtual object getKeyProperty();

							/// <summary>
							/// Get label
							/// </summary>
							/// <returns>The (possibly language-dependent) label text for this dimension</returns>
							public extern virtual string getLabelText();

							/// <summary>
							/// Get master data entity set for this dimension
							/// </summary>
							/// <returns>The master data entity set for this dimension, or null, if it does not exist</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.EntitySet getMasterDataEntitySet();

							/// <summary>
							/// Get the name of the dimension
							/// </summary>
							/// <returns>The name of this dimension, which is identical to the name of the dimension key property in the entity type</returns>
							public extern virtual string getName();

							/// <summary>
							/// Get super-ordinate dimension
							/// </summary>
							/// <returns>The super-ordinate dimension or null if there is none</returns>
							public extern virtual object getSuperOrdinateDimension();

							/// <summary>
							/// Get text property related to this dimension
							/// </summary>
							/// <returns>The datajs object representing the text property or null if it does not exist</returns>
							public extern virtual object getTextProperty();

							/// <summary>
							/// Get indicator whether or not master data is available for this dimension
							/// </summary>
							/// <returns>True iff master data is available</returns>
							public extern virtual bool hasMasterData();

							#endregion

						}
					}
				}
			}
		}
	}
}
