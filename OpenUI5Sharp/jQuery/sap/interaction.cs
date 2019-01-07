using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public abstract partial class jQuery
	{
		public static partial class sap
		{
			[External]
			[Namespace(false)]
			[Name("jQuery.sap.interaction")]
			[Obsolete("Deprecated since 1.58. use {@link module:sap/ui/performance/trace/Interaction} instead")]
			public static partial class interaction
			{
				#region Methods

				/// <summary>
				/// Enables the interaction tracking.
				/// </summary>
				/// <param name="bActive">state of the interaction detection</param>
				public extern static void setActive(bool bActive);

				#endregion

			}
		}
	}
}
