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
			public static partial class model
			{
				/// <summary>
				/// Analytical Adapter for ODataModels
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.analytics")]
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
