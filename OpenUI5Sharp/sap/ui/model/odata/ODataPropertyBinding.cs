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
					/// Property binding implementation for oData format
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.odata.ODataPropertyBinding")]
					public partial class ODataPropertyBinding : sap.ui.model.PropertyBinding
					{
						#region Constructor

						/// <param name="oModel"></param>
						/// <param name="sPath"></param>
						/// <param name="oContext"></param>
						/// <param name="mParameters"></param>
						public extern ODataPropertyBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, object mParameters);

						/// <param name="oModel"></param>
						/// <param name="sPath"></param>
						/// <param name="oContext"></param>
						public extern ODataPropertyBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataPropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataPropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataPropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.odata.ODataPropertyBinding.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Returns the current value of the bound target
						/// </summary>
						/// <returns>the current value of the bound target</returns>
						public extern override object getValue();

						/// <summary>
						/// Initialize the binding. The message should be called when creating a binding. If metadata is not yet available, do nothing, method will be called again when metadata is loaded.
						/// </summary>
						public extern override void initialize();

						#endregion

					}
				}
			}
		}
	}
}
