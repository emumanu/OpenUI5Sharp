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
				public static partial class analytics
				{
					/// <summary>
					/// The OData4Analytics API is purely experimental, not yet functionally complete and not meant for productive usage. At present, its only purpose is to demonstrate how easy analytical extensions of OData4SAP can be consumed.
					/// 
					/// <em>USE OBJECTS VIA METHODS ONLY - DO NOT ACCESS JAVASCRIPT OBJECT PROPERTIES DIRECTLY !</em>
					/// 
					/// Lazy initialization of attributes will cause unexpected values when you access object attributes directly.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.analytics.odata4analytics")]
					public static partial class odata4analytics
					{
						#region Methods

						/// <summary>
						/// Specify which components of the dimension shall be included in the value set.
						/// </summary>
						/// <param name="bIncludeText">Indicator whether or not to include the dimension text (if available) in the value set.</param>
						/// <param name="bIncludeAttributes">Indicator whether or not to include all dimension attributes (if available) in the value set.</param>
						public extern static void includeDimensionTextAttributes(bool bIncludeText, bool bIncludeAttributes);

						#endregion

						/// <summary>
						/// Sort order of a property.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.analytics.odata4analytics.SortOrder")]
						public enum SortOrder
						{
							/// <summary>
							/// Sort Order: ascending.
							/// </summary>
							Ascending,
							/// <summary>
							/// Sort Order: descending.
							/// </summary>
							Descending,
						}
					}
				}
			}
		}
	}
}
