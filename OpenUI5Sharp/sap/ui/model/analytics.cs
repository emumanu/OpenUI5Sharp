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
			public static partial class model
			{
				/// <summary>
				/// Analytical Adapter for ODataModels
				/// </summary>
				[External]
				[Namespace(false)]
				public static partial class analytics
				{
					#region Methods

					/// <summary>
					/// If called on an instance of an (v1/v2) ODataModel it will enrich it with analytics capabilities.
					/// </summary>
					public extern static void ODataModelAdapter();

					#endregion

				}
			}
		}
	}
}
