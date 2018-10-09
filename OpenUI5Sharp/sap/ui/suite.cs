using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			/// <summary>
			/// Suite controls library.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.ui.suite")]
			public static partial class suite
			{
				/// <summary>
				/// Defined color values for the Task Circle Control
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.suite.TaskCircleColor")]
				public enum TaskCircleColor
				{
					/// <summary>
					/// Default value
					/// </summary>
					Gray,
					/// <summary>
					/// Green
					/// </summary>
					Green,
					/// <summary>
					/// Red
					/// </summary>
					Red,
					/// <summary>
					/// Yellow
					/// </summary>
					Yellow,
				}
			}
		}
	}
}
