using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		/// <summary>
		/// SAPUI5 library with controls specialized for administrative applications.
		/// </summary>
		[External]
		[Namespace(false)]
		[Name("sap.tnt")]
		public static partial class tnt
		{
			/// <summary>
			/// Predefined types of <code>InfoLabel</code>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.tnt.RenderMode")]
			public enum RenderMode
			{
				/// <summary>
				/// When type of the content of <code>InfoLabel</code> is text padding are loose
				/// </summary>
				Loose,
				/// <summary>
				/// When type of the content of <code>InfoLabel</code> is numeric paddings are narrow
				/// </summary>
				Narrow,
			}
		}
	}
}
