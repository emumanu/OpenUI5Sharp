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
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.odata.ODataUtils")]
					public static partial class ODataUtils
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class SetOriginInfo
						{
							/// <summary>
							/// the system alias which will be used as the origin
							/// </summary>
							public string alias;

							/// <summary>
							/// the system id which will be used as the origin
							/// </summary>
							public string system;

							/// <summary>
							/// the system's client
							/// </summary>
							public string client;

							/// <summary>
							/// setting this flag to 'true' overrides the already existing origin
							/// </summary>
							public string force;

						}

						#endregion

						#region Methods

						/// <summary>
						/// Compares the given OData values based on their type. All date and time types can also be compared with a number. This number is then interpreted as the number of milliseconds that the corresponding date or time object should hold.
						/// </summary>
						/// <param name="vValue1">the first value to compare</param>
						/// <param name="vValue2">the second value to compare</param>
						/// <param name="bAsDecimal">if <code>true</code>, the string values <code>vValue1</code> and <code>vValue2</code> are compared as a decimal number (only sign, integer and fraction digits; no exponential format). Otherwise they are recognized by looking at their types.</param>
						/// <returns>the result of the compare: <code>0</code> if the values are equal, <code>-1</code> if the first value is smaller, <code>1</code> if the first value is larger, <code>NaN</code> if they cannot be compared</returns>
						public extern static int compare(object vValue1, object vValue2, bool bAsDecimal = false);

						/// <summary>
						/// Formats a JavaScript value according to the given <a href="http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem"> EDM type</a>.
						/// </summary>
						/// <param name="vValue">the value to format</param>
						/// <param name="sType">the EDM type (e.g. Edm.Decimal)</param>
						/// <param name="bCaseSensitive">Wether strings gets compared case sensitive or not</param>
						/// <returns>the formatted value</returns>
						public extern static string formatValue(object vValue, string sType, bool bCaseSensitive);

						/// <summary>
						/// Returns a comparator function optimized for the given EDM type.
						/// </summary>
						/// <param name="sEdmType">the EDM type</param>
						/// <returns>the comparator function taking two values of the given type and returning <code>0</code> if the values are equal, <code>-1</code> if the first value is smaller, <code>1</code> if the first value is larger and <code>NaN</code> if they cannot be compared (e.g. one value is <code>null</code> or <code>undefined</code>)</returns>
						public extern static object getComparator(string sEdmType);

						/// <summary>
						/// Adds an origin to the given service URL. If an origin is already present, it will only be replaced if the parameters object contains the flag "force: true". In case the URL already contains URL parameters, these will be kept. As a parameter, a sole alias is sufficient. The parameters vParameters.system and vParameters.client however have to be given in pairs. In case all three origin specifying parameters are given (system/client/alias), the alias has precedence.
						/// 
						/// Examples: setOrigin("/backend/service/url/", "DEMO_123"); - result: /backend/service/url;o=DEMO_123/
						/// 
						/// setOrigin("/backend/service/url;o=OTHERSYS8?myUrlParam=true&x=4", {alias: "DEMO_123", force: true}); - result /backend/service/url;o=DEMO_123?myUrlParam=true&x=4
						/// 
						/// setOrigin("/backend/service;o=NOT_TOUCHED/url;v=2;o=OTHERSYS8;srv=XVC", {alias: "DEMO_123", force: true}); - result /backend/service;o=NOT_TOUCHED/url;v=2;o=DEMO_123;srv=XVC
						/// 
						/// setOrigin("/backend/service/url/", {system: "DEMO", client: 134}); - result /backend/service/url;o=sid(DEMO.134)/
						/// </summary>
						/// <param name="sServiceURL">the URL which will be enriched with an origin</param>
						/// <param name="vParameters">if string then it is asumed its the system alias, else if the argument is an object then additional Parameters can be given</param>
						/// <returns>the service URL with the added origin.</returns>
						public extern static string setOrigin(string sServiceURL, Union<sap.ui.model.odata.ODataUtils.SetOriginInfo, string> vParameters);

						#endregion

					}
				}
			}
		}
	}
}
