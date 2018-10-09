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
			public static partial class core
			{
				public static partial class format
				{
					/// <summary>
					/// The ListFormat is a static class for formatting and parsing an array of strings in a locale-sensitive manner according to a set of format options.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.format.ListFormat")]
					public partial class ListFormat
					{
						#region Methods

						/// <summary>
						/// Formats a list according to the given format options.
						/// </summary>
						/// <param name="aList">The value to format</param>
						/// <returns>The formatted output value.</returns>
						public extern virtual string format(object[] aList);

						#endregion

					}
				}
			}
		}
	}
}
