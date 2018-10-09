using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public abstract partial class jQuery
	{
		[External]
		[Namespace(false)]
		[Name("jQuery.device")]
		[Obsolete("Deprecated since 1.20. use the respective functions of {@link sap.ui.Device} instead")]
		public static partial class device
		{
		}
	}
}
