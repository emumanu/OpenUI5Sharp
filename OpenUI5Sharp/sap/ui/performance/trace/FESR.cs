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
				public static partial class trace
				{
					/// <summary>
					/// FESR API, consumed by E2eTraceLib instead of former EppLib.js. Provides functionality for creating the headers for the frontend-subrecords which will be sent with each first request of an interaction. The headers have a specific format, you may have a look at the createFESR methods.<br> There is a special order in which things are happening: <pre>
					/// 1. Interaction starts
					/// 1.1. Request 1.1 sent
					/// 1.2. Request 1.2 sent
					/// 2. Interaction starts
					/// 2.1 Creation of FESR for 1. interaction
					/// 2.2 Request 2.1 sent with FESR header for 1. interaction
					/// ...
					/// </pre>
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.performance.trace.FESR")]
					public partial class FESR
					{
						#region Methods

						/// <returns>State of the FESR header creation</returns>
						private extern static bool getActive();

						/// <param name="bActive">State of the FESR header creation</param>
						private extern static void setActive(bool bActive);

						#endregion

					}
				}
			}
		}
	}
}
