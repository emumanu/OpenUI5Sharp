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
				/// Model implementation for Client models
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.ClientModel")]
				public abstract partial class ClientModel : sap.ui.model.Model
				{
					#region Constructor

					/// <summary>
					/// Constructor for a new ClientModel.
					/// </summary>
					/// <param name="oData">URL where to load the data from</param>
					public extern ClientModel(string oData);

					/// <summary>
					/// Constructor for a new ClientModel.
					/// </summary>
					public extern ClientModel();

					#endregion

					#region Methods

					public extern override void destroy();

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Force no caching.
					/// </summary>
					/// <param name="bForceNoCache">whether to force not to cache</param>
					public extern virtual void forceNoCache(bool bForceNoCache = false);

					/// <summary>
					/// Returns the current data of the model. Be aware that the returned object is a reference to the model data so all changes to that data will also change the model data.
					/// </summary>
					/// <returns>the data object</returns>
					public extern virtual object getData();

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.ClientModel.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// update all bindings
					/// </summary>
					/// <param name="bForceUpdate">true/false: Default = false. If set to false an update will only be done when the value of a binding changed.</param>
					public extern virtual void updateBindings(bool bForceUpdate);

					#endregion

				}
			}
		}
	}
}
