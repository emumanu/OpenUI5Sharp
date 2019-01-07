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
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.form")]
				[Obsolete("Deprecated since 1.38.")]
				public static partial class form
				{
					#region Fields

					/// <summary>
					/// Available FormLayouts used for the SimpleForm.
					/// </summary>
					public static object SimpleFormLayout;

					#endregion

				}
			}
		}
	}
}
