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
					public static partial class v2
					{
						/// <summary>
						/// The ContextBinding is a specific binding for a setting context for the model
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.v2.ODataContextBinding")]
						public abstract partial class ODataContextBinding : sap.ui.model.ContextBinding
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class ODataContextBindingInfo
							{
								/// <summary>
								/// For the OData <code>$expand</code> query option parameter which should be included in the request
								/// </summary>
								public string expand;

								/// <summary>
								/// For the OData <code>$select</code> query option parameter which should be included in the request
								/// </summary>
								public string select;

								/// <summary>
								/// An optional map of custom query parameters. Custom parameters must not start with <code>$</code>.
								/// </summary>
								public Map custom;

								/// <summary>
								/// Whether a preliminary Context will be created
								/// </summary>
								public bool createPreliminaryContext;

								/// <summary>
								/// Whether a preliminary Context will be used
								/// </summary>
								public bool usePreliminaryContext;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Constructor for odata.ODataContextBinding
							/// </summary>
							/// <param name="oModel"></param>
							/// <param name="sPath"></param>
							/// <param name="oContext"></param>
							/// <param name="mParameters">A map which contains additional parameters for the binding.</param>
							public extern ODataContextBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Map mParameters);

							/// <summary>
							/// Constructor for odata.ODataContextBinding
							/// </summary>
							/// <param name="oModel"></param>
							/// <param name="sPath"></param>
							/// <param name="oContext"></param>
							public extern ODataContextBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataContextBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ContextBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataContextBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ContextBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataContextBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ContextBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.v2.ODataContextBinding.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <param name="bForceUpdate">Update the bound control even if no data has been changed</param>
							/// <param name="sGroupId">The group Id for the refresh</param>
							public extern virtual void refresh(bool bForceUpdate, string sGroupId);

							/// <param name="bForceUpdate">Update the bound control even if no data has been changed</param>
							public extern virtual void refresh(bool bForceUpdate);

							public extern virtual void refresh();

							/// <param name="sGroupId">The group Id for the refresh</param>
							public extern virtual void refresh(string sGroupId);

							#endregion

						}
					}
				}
			}
		}
	}
}
