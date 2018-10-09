using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class uxap
		{
			/// <summary>
			/// Used by the <code>BlockBase</code> control to define how many columns should it be assigned by the <code>objectPageSubSection</code>. The allowed values can be auto (subsection assigned a number of columns based on the parent objectPageLayout subsectionLayout property), 1, 2 or 3 (This may not be a valid value for some <code>subSectionLayout</code>, for example, asking for 3 columns in a 2 column layout would raise warnings).
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.BlockBaseColumnLayout")]
			public partial class BlockBaseColumnLayout
			{
				public static extern implicit operator string(BlockBaseColumnLayout ts);
				public static extern implicit operator BlockBaseColumnLayout(string val);
			}
		}
	}
}
