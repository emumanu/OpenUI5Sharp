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
			public static partial class test
			{
				public static partial class matchers
				{
					/// <summary>
					/// Ancestor - checks if a control has a defined ancestor
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.matchers.Ancestor")]
					public partial class Ancestor
					{
						#region Constructor

						/// <param name="oAncestorControl">the ancestor control to check, if undefined, validates every control to true. Can be a control or a control ID</param>
						/// <param name="bDirect">specifies if the ancestor should be a direct ancestor (parent)</param>
						public extern Ancestor(Union<object, string> oAncestorControl, bool bDirect);

						/// <param name="oAncestorControl">the ancestor control to check, if undefined, validates every control to true. Can be a control or a control ID</param>
						public extern Ancestor(Union<object, string> oAncestorControl);

						#endregion

					}
				}
			}
		}
	}
}
