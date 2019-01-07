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
				public static partial class odata
				{
					/// <summary>
					/// Filter for the list binding
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.odata.Filter")]
					[Obsolete("Deprecated since 1.22. Please use the {@link sap.ui.model.Filter} instead.")]
					public partial class Filter : sap.ui.@base.Object
					{
						#region Constructor

						/// <summary>
						/// Constructor for Filter
						/// </summary>
						/// <param name="sPath">the binding path for this filter</param>
						/// <param name="aValues">Array of FilterOperators and their values: [{operator:"GE",value1:"val1"},{operator:"LE",value1:"val1"},{operator:"BT",value1:"val1",value2:"val2"}]</param>
						/// <param name="bAND">If true the values from aValues will be ANDed; otherwise ORed</param>
						public extern Filter(string sPath, object[] aValues, bool bAND = true);

						#endregion

						#region Methods

						/// <summary>
						/// Converts the <code>sap.ui.model.odata.Filter</code> into a <code>sap.ui.model.Filter</code>.
						/// </summary>
						/// <returns>a <code>sap.ui.model.Filter</code> object</returns>
						public extern virtual sap.ui.model.Filter convert();

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.Filter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.Filter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.Filter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.odata.Filter.
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
}
