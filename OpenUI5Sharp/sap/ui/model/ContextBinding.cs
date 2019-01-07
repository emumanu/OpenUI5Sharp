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
				/// The ContextBinding is a specific binding for a setting context for the model
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.ContextBinding")]
				public abstract partial class ContextBinding : sap.ui.model.Binding
				{
					#region Constructor

					/// <summary>
					/// Constructor for ContextBinding
					/// </summary>
					/// <param name="oModel"></param>
					/// <param name="sPath"></param>
					/// <param name="oContext"></param>
					/// <param name="mParameters"></param>
					/// <param name="oEvents">object defining event handlers</param>
					public extern ContextBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, object mParameters, object oEvents);

					/// <summary>
					/// Constructor for ContextBinding
					/// </summary>
					/// <param name="oModel"></param>
					/// <param name="sPath"></param>
					/// <param name="oContext"></param>
					/// <param name="mParameters"></param>
					public extern ContextBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, object mParameters);

					/// <summary>
					/// Constructor for ContextBinding
					/// </summary>
					/// <param name="oModel"></param>
					/// <param name="sPath"></param>
					/// <param name="oContext"></param>
					public extern ContextBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ContextBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ContextBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ContextBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Return the bound context.
					/// </summary>
					/// <returns>Context object used by this context binding or <code>null</code></returns>
					public extern virtual sap.ui.model.Context getBoundContext();

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.ContextBinding.
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
