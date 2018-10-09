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
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.TreeBindingUtils")]
				public static partial class TreeBindingUtils
				{
					#region Methods

					/// <summary>
					/// Merges together oNewSection into a set of other sections (aSections) The array/objects are not modified, the function returns a new section array.
					/// </summary>
					/// <param name="aSections">the sections into which oNewSection will be merged</param>
					/// <param name="oNewSection">the section which should be merged into aNewSections</param>
					/// <returns>a new array containing all sections from aSections merged with oNewSection</returns>
					public extern static object[] mergeSections(object[] aSections, object oNewSection);

					#endregion

				}
			}
		}
	}
}
