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
				public static partial class json
				{
					/// <summary>
					/// Property binding implementation for JSON format.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.json.JSONPropertyBinding")]
					public partial class JSONPropertyBinding : sap.ui.model.ClientPropertyBinding
					{
						#region Constructor

						/// <summary>
						/// Creates a new JSONListBinding.
						/// 
						/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.json.JSONModel#bindProperty JSONModel#bindProperty} on the corresponding model instance instead.
						/// </summary>
						/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
						/// <param name="sPath">Binding path to be used for this binding</param>
						/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
						/// <param name="mParameters">Map of optional parameters as defined by subclasses; this class does not introduce any own parameters</param>
						public extern JSONPropertyBinding(sap.ui.model.json.JSONModel oModel, string sPath, sap.ui.model.Context oContext, object mParameters);

						/// <summary>
						/// Creates a new JSONListBinding.
						/// 
						/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.json.JSONModel#bindProperty JSONModel#bindProperty} on the corresponding model instance instead.
						/// </summary>
						/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
						/// <param name="sPath">Binding path to be used for this binding</param>
						/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
						public extern JSONPropertyBinding(sap.ui.model.json.JSONModel oModel, string sPath, sap.ui.model.Context oContext);

						#endregion

					}
				}
			}
		}
	}
}
