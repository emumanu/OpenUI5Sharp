using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// Helper for Popups.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.PopupHelper")]
			public static partial class PopupHelper
			{
				#region Methods

				/// <summary>
				/// This methods converts the percentage value to an absolute number based on the given base number.
				/// </summary>
				/// <param name="sPercentage">A percentage value in string format, for example "25%"</param>
				/// <param name="fBaseSize">A float number which the calculation is based on.</param>
				/// <returns>The calculated size string with "px" as unit or null when the format of given parameter is wrong.</returns>
				public extern static void calcPercentageSize(string sPercentage, float fBaseSize);

				#endregion

			}
		}
	}
}
