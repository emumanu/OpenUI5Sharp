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
				/// Property binding implementation for client models.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.ClientPropertyBinding")]
				public partial class ClientPropertyBinding : sap.ui.model.PropertyBinding
				{
					#region Constructor

					/// <summary>
					/// Creates a new ClientPropertyBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindProperty Model#bindProperty} on the corresponding model implementation instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Binding path to be used for this binding, syntax depends on the concrete subclass</param>
					/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
					/// <param name="mParameters">Map of optional parameters as defined by subclasses; this class does not introduce any own parameters</param>
					public extern ClientPropertyBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, object mParameters);

					/// <summary>
					/// Creates a new ClientPropertyBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindProperty Model#bindProperty} on the corresponding model implementation instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Binding path to be used for this binding, syntax depends on the concrete subclass</param>
					/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
					public extern ClientPropertyBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientPropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientPropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientPropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.ClientPropertyBinding.
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
