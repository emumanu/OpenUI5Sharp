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
			public static partial class core
			{
				[External]
				[Namespace(false)]
				public static partial class mvc
				{
					/// <summary>
					/// Specifies possible view types
					/// </summary>
					[External]
					[Namespace(false)]
					public enum ViewType
					{
							/// <summary>
							/// HTML view
							/// </summary>
							HTML,
							/// <summary>
							/// JS View
							/// </summary>
							JS,
							/// <summary>
							/// JSON View
							/// </summary>
							JSON,
							/// <summary>
							/// Template View
							/// </summary>
							Template,
							/// <summary>
							/// XML view
							/// </summary>
							XML,
					}
					/// <summary>
					/// Marker interface for a ControllerExtension.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial interface IControllerExtension
					{
					}
				}
			}
		}
	}
}
