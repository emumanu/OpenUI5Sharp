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
				public static partial class analytics
				{
					[External]
					[Namespace(false)]
					public partial class AnalyticalTreeBindingAdapter
					{
						#region Constructor

						/// <summary>
						/// Adapter for TreeBindings to add the ListBinding functionality and use the tree structure in list based controls.
						/// </summary>
						public extern AnalyticalTreeBindingAdapter();

						#endregion

						#region Methods

						/// <summary>
						/// Retrieves the currently set number of expanded levels from the Binding (commonly an AnalyticalBinding).
						/// </summary>
						/// <returns>the number of expanded levels</returns>
						public extern virtual int getNumberOfExpandedLevels();

						/// <summary>
						/// Checks if the AnalyticalBinding has totaled measures available. Used for rendering sum rows.
						/// </summary>
						/// <returns>Whether the binding has totaled measures or not</returns>
						public extern virtual bool hasTotaledMeasures();

						/// <summary>
						/// Sets the number of expanded levels on the TreeBinding (commonly an AnalyticalBinding). This is NOT the same as AnalyticalTreeBindingAdapter#collapse or AnalyticalTreeBindingAdapter#expand. Setting the number of expanded levels leads to different requests. This function is used by the AnalyticalTable for the ungroup/ungroup-all feature.
						/// </summary>
						/// <param name="iLevels">the number of levels which should be expanded, minimum is 0</param>
						public extern virtual void setNumberOfExpandedLevels(int iLevels);

						#endregion

					}
				}
			}
		}
	}
}
