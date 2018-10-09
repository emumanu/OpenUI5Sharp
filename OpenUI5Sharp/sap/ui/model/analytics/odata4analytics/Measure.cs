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
						/// Representation of a property annotated with sap:aggregation-role="measure".
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.analytics.odata4analytics.Measure")]
						public partial class Measure
						{
							#region Constructor

							/// <summary>
							/// Create a representation of a measure provided by an analytic query. Do not create your own instances.
							/// </summary>
							/// <param name="oQueryResult">The query result containing this measure</param>
							/// <param name="oProperty">The datajs object object representing the measure</param>
							public extern Measure(sap.ui.model.analytics.odata4analytics.QueryResult oQueryResult, object oProperty);

							#endregion

							#region Methods

							/// <summary>
							/// Get the text property associated to the raw value property holding the formatted value related to this measure
							/// </summary>
							/// <returns>The datajs object representing the property holding the formatted value text of this measure or null if this measure does not have a unit</returns>
							public extern virtual object getFormattedValueProperty();

							/// <summary>
							/// Get label
							/// </summary>
							/// <returns>The (possibly language-dependent) label text for this measure</returns>
							public extern virtual string getLabelText();

							/// <summary>
							/// Get the name of the measure
							/// </summary>
							/// <returns>The name of the measure, which is identical to the name of the measure raw value property in the entity type</returns>
							public extern virtual string getName();

							/// <summary>
							/// Get the raw value property
							/// </summary>
							/// <returns>The datajs object representing the property holding the raw value of this measure</returns>
							public extern virtual object getRawValueProperty();

							/// <summary>
							/// Get the unit property related to this measure
							/// </summary>
							/// <returns>The datajs object representing the unit property or null if this measure does not have a unit</returns>
							public extern virtual object getUnitProperty();

							/// <summary>
							/// Get indicator whether or not the measure is updatable
							/// </summary>
							/// <returns>True iff the measure is updatable</returns>
							public extern virtual bool isUpdatable();

							#endregion

						}
					}
				}
			}
		}
	}
}
