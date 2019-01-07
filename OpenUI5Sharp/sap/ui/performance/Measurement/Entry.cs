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
			public static partial class performance
			{
				public partial class Measurement
				{
					/// <summary>
					/// Single Measurement Entry
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.performance.Measurement.Entry")]
					public partial class Entry
					{
						#region Fields

						/// <summary>
						/// ID of the measurement
						/// </summary>
						public string sId;

						/// <summary>
						/// Info for the measurement
						/// </summary>
						public string sInfo;

						/// <summary>
						/// Start time
						/// </summary>
						public int iStart;

						/// <summary>
						/// End time
						/// </summary>
						public int iEnd;

						/// <summary>
						/// An optional list of categories for the measure
						/// </summary>
						public Union<string, string[]> aCategories;

						#endregion

					}
				}
			}
		}
	}
}
