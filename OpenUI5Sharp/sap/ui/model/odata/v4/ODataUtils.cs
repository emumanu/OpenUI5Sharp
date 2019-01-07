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
				public static partial class odata
				{
					public static partial class v4
					{
						/// <summary>
						/// A collection of methods which help to consume OData V4 services.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.v4.ODataUtils")]
						public static partial class ODataUtils
						{
							#region Methods

							/// <summary>
							/// Compares the given OData values.
							/// </summary>
							/// <param name="vValue1">The first value to compare</param>
							/// <param name="vValue2">The second value to compare</param>
							/// <param name="vEdmType">If <code>true</code> or "Decimal", the string values <code>vValue1</code> and <code>vValue2</code> are assumed to be valid "Edm.Decimal" or "Edm.Int64" values and are compared as a decimal number (only sign, integer and fraction digits; no exponential format). If "DateTime", the string values <code>vValue1</code> and <code>vValue2</code> are assumed to be valid "Edm.DateTimeOffset" values and are compared based on the corresponding number of milliseconds since 1 January, 1970 UTC. Otherwise the values are compared with the JavaScript operators <code>===</code> and <code>></code>.</param>
							/// <returns>The result of the comparison: <code>0</code> if the values are equal, <code>1</code> if the first value is larger, <code>-1</code> if the second value is larger, <code>NaN</code> if they cannot be compared</returns>
							public extern static int compare(object vValue1, object vValue2, Union<bool, string> vEdmType);

							/// <summary>
							/// Compares the given OData values.
							/// </summary>
							/// <param name="vValue1">The first value to compare</param>
							/// <param name="vValue2">The second value to compare</param>
							/// <returns>The result of the comparison: <code>0</code> if the values are equal, <code>1</code> if the first value is larger, <code>-1</code> if the second value is larger, <code>NaN</code> if they cannot be compared</returns>
							public extern static int compare(object vValue1, object vValue2);

							/// <summary>
							/// Parses an "Edm.Date" value and returns the corresponding JavaScript <code>Date</code> value (UTC with a time value of "00:00:00").
							/// </summary>
							/// <param name="sDate">The "Edm.Date" value to parse</param>
							/// <returns>The JavaScript <code>Date</code> value</returns>
							public extern static DateTime parseDate(string sDate);

							/// <summary>
							/// Parses an "Edm.DateTimeOffset" value and returns the corresponding JavaScript <code>Date</code> value.
							/// </summary>
							/// <param name="sDateTimeOffset">The "Edm.DateTimeOffset" value to parse</param>
							/// <returns>The JavaScript <code>Date</code> value</returns>
							public extern static DateTime parseDateTimeOffset(string sDateTimeOffset);

							/// <summary>
							/// Parses an "Edm.TimeOfDay" value and returns the corresponding JavaScript <code>Date</code> value (UTC with a date value of "1970-01-01").
							/// </summary>
							/// <param name="sTimeOfDay">The "Edm.TimeOfDay" value to parse</param>
							/// <returns>The JavaScript <code>Date</code> value</returns>
							public extern static DateTime parseTimeOfDay(string sTimeOfDay);

							/// <summary>
							/// Formats the given OData value into a literal suitable for usage in URLs.
							/// </summary>
							/// <param name="vValue">The value according to "OData JSON Format Version 4.0" section "7.1 Primitive Value"</param>
							/// <param name="sType">The OData primitive type, e.g. "Edm.String"</param>
							/// <returns>The literal according to "OData Version 4.0 Part 2: URL Conventions" section* "5.1.1.6.1 Primitive Literals"</returns>
							public extern static string formatLiteral(object vValue, string sType);

							#endregion

						}
					}
				}
			}
		}
	}
}
