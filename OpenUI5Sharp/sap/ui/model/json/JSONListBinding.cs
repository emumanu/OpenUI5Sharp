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
				public static partial class json
				{
					/// <summary>
					/// List binding implementation for JSON format.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class JSONListBinding : sap.ui.model.ClientListBinding
					{
						#region Constructor

						/// <summary>
						/// Creates a new JSONListBinding.
						/// 
						/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.json.JSONModel#bindList JSONModel#bindList} on the corresponding model instance instead.
						/// </summary>
						/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
						/// <param name="sPath">Binding path to be used for this binding</param>
						/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
						/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
						/// <param name="aFilters">Predefined filter/s (can be either a filter or an array of filters)</param>
						/// <param name="mParameters">Map of optional parameters as defined by subclasses; this class does not introduce any own parameters</param>
						public extern JSONListBinding(sap.ui.model.json.JSONModel oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, object mParameters);

						/// <summary>
						/// Creates a new JSONListBinding.
						/// 
						/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.json.JSONModel#bindList JSONModel#bindList} on the corresponding model instance instead.
						/// </summary>
						/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
						/// <param name="sPath">Binding path to be used for this binding</param>
						/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
						/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
						/// <param name="aFilters">Predefined filter/s (can be either a filter or an array of filters)</param>
						public extern JSONListBinding(sap.ui.model.json.JSONModel oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

						/// <summary>
						/// Creates a new JSONListBinding.
						/// 
						/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.json.JSONModel#bindList JSONModel#bindList} on the corresponding model instance instead.
						/// </summary>
						/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
						/// <param name="sPath">Binding path to be used for this binding</param>
						/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
						/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
						public extern JSONListBinding(sap.ui.model.json.JSONModel oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters);

						/// <summary>
						/// Creates a new JSONListBinding.
						/// 
						/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.json.JSONModel#bindList JSONModel#bindList} on the corresponding model instance instead.
						/// </summary>
						/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
						/// <param name="sPath">Binding path to be used for this binding</param>
						/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
						public extern JSONListBinding(sap.ui.model.json.JSONModel oModel, string sPath, sap.ui.model.Context oContext);

						#endregion

						#region Methods

						/// <summary>
						/// Return contexts for the list or a specified subset of contexts
						/// </summary>
						/// <param name="iStartIndex">the startIndex where to start the retrieval of contexts</param>
						/// <param name="iLength">determines how many contexts to retrieve beginning from the start index. Default is the whole list length.</param>
						/// <returns>the contexts array</returns>
						public extern virtual object[] getContexts(int iStartIndex = 0, int iLength = -1);

						#endregion

					}
				}
			}
		}
	}
}
