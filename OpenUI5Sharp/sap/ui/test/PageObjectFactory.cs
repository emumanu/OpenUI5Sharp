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
			public static partial class test
			{
				/// <summary>
				/// Page Object Factory
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class PageObjectFactory : sap.ui.@base.Object
				{
					#region Constructor

					public extern PageObjectFactory();

					#endregion

					#region Methods

					/// <summary>
					/// Create a page object configured as arrangement, action and assertion to the Opa.config. Use it to structure your arrangement, action and assertion based on parts of the screen to avoid name clashes and help structuring your tests.
					/// </summary>
					public extern static void create();

					#endregion

				}
			}
		}
	}
}
