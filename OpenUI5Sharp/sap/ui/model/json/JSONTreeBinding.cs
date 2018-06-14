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
					/// Tree binding implementation for JSON format.
					/// 
					/// The bound data can contain JSON objects and arrays. Both will be used to build the tree structure. You can optionally define a set of arrays to be used for the tree structure in the parameter <code>arrayNames</code>. If this parameter is set, all other objects and arrays will be ignored.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class JSONTreeBinding : sap.ui.model.ClientTreeBinding
					{
						#region Constructor

						/// <summary>
						/// Creates a new JSONListBinding.
						/// 
						/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.json.JSONModel#bindTree JSONModel#bindTree} on the corresponding model instance instead.
						/// </summary>
						/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
						/// <param name="sPath">Path pointing to the tree or array that should be bound</param>
						/// <param name="oContext">Context object for this binding, mandatory when a relative binding path is given</param>
						/// <param name="aFilters">Predefined filters contained in an array</param>
						/// <param name="mParameters">Additional model-specific parameters</param>
						public extern JSONTreeBinding(sap.ui.model.json.JSONModel oModel, string sPath, object oContext, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, object mParameters);

						/// <summary>
						/// Creates a new JSONListBinding.
						/// 
						/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.json.JSONModel#bindTree JSONModel#bindTree} on the corresponding model instance instead.
						/// </summary>
						/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
						/// <param name="sPath">Path pointing to the tree or array that should be bound</param>
						/// <param name="oContext">Context object for this binding, mandatory when a relative binding path is given</param>
						/// <param name="aFilters">Predefined filters contained in an array</param>
						public extern JSONTreeBinding(sap.ui.model.json.JSONModel oModel, string sPath, object oContext, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

						/// <summary>
						/// Creates a new JSONListBinding.
						/// 
						/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.json.JSONModel#bindTree JSONModel#bindTree} on the corresponding model instance instead.
						/// </summary>
						/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
						/// <param name="sPath">Path pointing to the tree or array that should be bound</param>
						/// <param name="oContext">Context object for this binding, mandatory when a relative binding path is given</param>
						public extern JSONTreeBinding(sap.ui.model.json.JSONModel oModel, string sPath, object oContext);

						/// <summary>
						/// Creates a new JSONListBinding.
						/// 
						/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.json.JSONModel#bindTree JSONModel#bindTree} on the corresponding model instance instead.
						/// </summary>
						/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
						/// <param name="sPath">Path pointing to the tree or array that should be bound</param>
						public extern JSONTreeBinding(sap.ui.model.json.JSONModel oModel, string sPath);

						#endregion

					}
				}
			}
		}
	}
}
