using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class layout
			{
				public static partial class form
				{
					/// <summary>
					/// Available <code>FormLayouts</code> used to render a <code>SimpleForm</code>.
					/// </summary>
					[External]
					[Namespace(false)]
					public enum SimpleFormLayout
					{
							/// <summary>
							/// Uses the <code>ColumnLayout</code> layout to render the <code>SimpleForm</code> control
							/// </summary>
							ColumnLayout,
							/// <summary>
							/// Uses the <code>GridLayout</code> layout to render the <code>SimpleForm</code> control
							/// </summary>
							GridLayout,
							/// <summary>
							/// Uses the <code>ResponsiveGridLayout</code> layout to render the <code>SimpleForm</code> control
							/// </summary>
							ResponsiveGridLayout,
							/// <summary>
							/// Uses the <code>ResponsiveLayout</code> layout to render the <code>SimpleForm</code> control
							/// </summary>
							ResponsiveLayout,
					}
				}
			}
		}
	}
}
