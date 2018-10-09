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
			public static partial class commons
			{
				public static partial class layout
				{
					/// <summary>
					/// Background design (i.e. color), e.g. of a layout cell.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.BackgroundDesign")]
					public enum BackgroundDesign
					{
						/// <summary>
						/// A background design suitable for borders.
						/// </summary>
						Border,
						/// <summary>
						/// An opaque background design that looks dark filled.
						/// </summary>
						Fill1,
						/// <summary>
						/// An opaque background design that looks medium filled.
						/// </summary>
						Fill2,
						/// <summary>
						/// An opaque background design that looks light filled.
						/// </summary>
						Fill3,
						/// <summary>
						/// A background design suitable for headers.
						/// </summary>
						Header,
						/// <summary>
						/// A plain but opaque background design.
						/// </summary>
						Plain,
						/// <summary>
						/// A transparent background.
						/// </summary>
						Transparent,
					}
				}
			}
		}
	}
}
