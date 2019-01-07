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
				/// Sorter for the list binding This object defines the sort order for the list binding.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.Sorter")]
				public partial class Sorter : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Constructor for Sorter
					/// </summary>
					/// <param name="sPath">the binding path used for sorting</param>
					/// <param name="bDescending">whether the sort order should be descending</param>
					/// <param name="vGroup">configure grouping of the content, can either be true to enable grouping based on the raw model property value, or a function which calculates the group value out of the context (e.g. oContext.getProperty("date").getYear() for year grouping). The control needs to implement the grouping behaviour for the aggregation which you want to group. In case a function is provided it must either return a primitive type value as the group key or an object containing a "key" property and additional properties needed for group visualization. <b>Note:</b> Grouping is only possible (and only makes sense) for the primary sort property.</param>
					/// <param name="fnComparator">a custom comparator function, which is used for clientside sorting instead of the default comparator method. Information about parameters and expected return values of such a method can be found in the default comparator documentation.</param>
					public extern Sorter(string sPath, bool bDescending, Union<bool, sap.ui.model.Sorter.CalculateGroupDelegate> vGroup, object fnComparator);

					/// <summary>
					/// Constructor for Sorter
					/// </summary>
					/// <param name="sPath">the binding path used for sorting</param>
					/// <param name="bDescending">whether the sort order should be descending</param>
					/// <param name="vGroup">configure grouping of the content, can either be true to enable grouping based on the raw model property value, or a function which calculates the group value out of the context (e.g. oContext.getProperty("date").getYear() for year grouping). The control needs to implement the grouping behaviour for the aggregation which you want to group. In case a function is provided it must either return a primitive type value as the group key or an object containing a "key" property and additional properties needed for group visualization. <b>Note:</b> Grouping is only possible (and only makes sense) for the primary sort property.</param>
					public extern Sorter(string sPath, bool bDescending, Union<bool, sap.ui.model.Sorter.CalculateGroupDelegate> vGroup);

					/// <summary>
					/// Constructor for Sorter
					/// </summary>
					/// <param name="sPath">the binding path used for sorting</param>
					/// <param name="bDescending">whether the sort order should be descending</param>
					public extern Sorter(string sPath, bool bDescending = false);

					#endregion

					#region Methods

					/// <summary>
					/// Compares two values
					/// 
					/// This is the default comparator function used for clientside sorting, if no custom comparator is given in the constructor. It does compare just by using equal/less than/greater than with automatic type casting, except for null values, which are last in ascending order, and string values where localeCompare is used.
					/// 
					/// The comparator method returns -1, 0 or 1, depending on the order of the two items and is suitable to be used as a comparator method for Array.sort.
					/// </summary>
					/// <param name="a">the first value to compare</param>
					/// <param name="b">the second value to compare</param>
					/// <returns>-1, 0 or 1 depending on the compare result</returns>
					public extern static int defaultComparator(object a, object b);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Sorter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Sorter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Sorter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a group object, at least containing a key property for group detection. May contain additional properties as provided by a custom group function.
					/// </summary>
					/// <param name="oContext">the binding context</param>
					/// <returns>An object containing a key property and optional custom properties</returns>
					public extern virtual object getGroup(sap.ui.model.Context oContext);

					/// <summary>
					/// Returns the group function of this Sorter. If grouping is not enabled on this Sorter, it will return undefined, if no explicit group function has been defined the default group function is returned. The returned function is bound to its Sorter, so it will group according to its own property path, even if it is used in the context of another Sorter.
					/// </summary>
					/// <returns>The group function</returns>
					public extern virtual object getGroupFunction();

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.Sorter.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					#endregion

				}
			}
		}
	}
}
