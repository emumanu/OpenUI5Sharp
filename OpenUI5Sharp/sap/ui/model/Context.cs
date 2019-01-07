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
				/// The Context is a pointer to an object in the model data, which is used to allow definition of relative bindings, which are resolved relative to the defined object. Context elements are created either by the ListBinding for each list entry or by using createBindingContext.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.Context")]
				public abstract partial class Context : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Constructor for Context class.
					/// </summary>
					/// <param name="oModel">the model</param>
					/// <param name="sPath">the binding path</param>
					public extern Context(sap.ui.model.Model oModel, string sPath);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Context with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Context with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Context with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.Context.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Getter for model
					/// </summary>
					/// <returns>the model</returns>
					public extern virtual sap.ui.model.Model getModel();

					/// <summary>
					/// Gets the (model dependent) object the context points to or the object with the given relative binding path
					/// </summary>
					/// <param name="sPath">the binding path</param>
					/// <param name="mParameters">additional model specific parameters (optional)</param>
					/// <returns>the context object</returns>
					public extern virtual object getObject(string sPath, object mParameters);

					/// <summary>
					/// Gets the (model dependent) object the context points to or the object with the given relative binding path
					/// </summary>
					/// <param name="sPath">the binding path</param>
					/// <returns>the context object</returns>
					public extern virtual object getObject(string sPath);

					/// <summary>
					/// Gets the (model dependent) object the context points to or the object with the given relative binding path
					/// </summary>
					/// <returns>the context object</returns>
					public extern virtual object getObject();

					/// <summary>
					/// Gets the (model dependent) object the context points to or the object with the given relative binding path
					/// </summary>
					/// <param name="mParameters">additional model specific parameters (optional)</param>
					/// <returns>the context object</returns>
					public extern virtual object getObject(object mParameters);

					/// <summary>
					/// Getter for path of the context itself or a subpath
					/// </summary>
					/// <param name="sPath">the binding path (optional)</param>
					/// <returns>the binding path</returns>
					public extern virtual string getPath(string sPath);

					/// <summary>
					/// Getter for path of the context itself or a subpath
					/// </summary>
					/// <returns>the binding path</returns>
					public extern virtual string getPath();

					/// <summary>
					/// Gets the property with the given relative binding path
					/// </summary>
					/// <param name="sPath">the binding path</param>
					/// <returns>the property value</returns>
					public extern virtual object getProperty(string sPath);

					/// <summary>
					/// This method returns, whether the context is preliminary.
					/// </summary>
					/// <returns>the preliminary flag</returns>
					private extern bool isPreliminary();

					#endregion

				}
			}
		}
	}
}
