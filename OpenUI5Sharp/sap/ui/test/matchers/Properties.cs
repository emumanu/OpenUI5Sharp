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
					/// Properties - checks if a control's properties have the provided values - all properties have to match their values.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.matchers.Properties")]
					public partial class Properties
					{
						#region Constructor

						/// <param name="oProperties">the object with the properties to be checked. Example: <pre>
						/// // Would filter for an enabled control with the text "Accept".
						/// new Properties({
						///     // The property text has the exact value "Accept"
						///     text: "Accept",
						///     // The property enabled also has to be true
						///     enabled: true
						/// })
						/// </pre> If the value is a RegExp, it tests the RegExp with the value. RegExp only works with string properties.</param>
						public extern Properties(object oProperties);

						#endregion

					}
				}
			}
		}
	}
}
