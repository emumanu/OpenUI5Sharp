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
						/// Representation of a dimension attribute.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.analytics.odata4analytics.DimensionAttribute")]
						public partial class DimensionAttribute
						{
							#region Constructor

							/// <summary>
							/// Create a representation of a dimension attribute provided by an analytic query. Do not create your own instances.
							/// </summary>
							/// <param name="oQueryResult">The query result containing this dimension attribute</param>
							/// <param name="oProperty">The datajs object object representing the dimension attribute</param>
							public extern DimensionAttribute(sap.ui.model.analytics.odata4analytics.QueryResult oQueryResult, object oProperty);

							#endregion

							#region Methods

							/// <summary>
							/// Get dimension
							/// </summary>
							/// <returns>The dimension object containing this attribute</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.Dimension getDimension();

							/// <summary>
							/// Get the key property
							/// </summary>
							/// <returns>The datajs object representing the property for the key of this dimension attribute</returns>
							public extern virtual object getKeyProperty();

							/// <summary>
							/// Get label
							/// </summary>
							/// <returns>The (possibly language-dependent) label text for this dimension attribute</returns>
							public extern virtual string getLabelText();

							/// <summary>
							/// Get the name of the dimension attribute
							/// </summary>
							/// <returns>The name of the dimension attribute, which is identical to the name of the property in the entity type holding the attribute value</returns>
							public extern virtual string getName();

							/// <summary>
							/// Get text property related to this dimension attribute
							/// </summary>
							/// <returns>The datajs object representing the text property or null if it does not exist</returns>
							public extern virtual object getTextProperty();

							#endregion

						}
					}
				}
			}
		}
	}
}
