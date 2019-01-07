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
				public static partial class @base
				{
					/// <summary>
					/// The ManagedObjectModel class can be used for data binding of properties and aggregations for managed objects.
					/// 
					/// Provides model access to a given {@link sap.ui.base.ManagedObject}. Such access allows to bind to properties and aggregations of this object.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.base.ManagedObjectModel")]
					public partial class ManagedObjectModel : sap.ui.model.json.JSONModel
					{
						#region Constructor

						/// <summary>
						/// The ManagedObjectModel class allows you to bind to properties and aggregations of managed objects.
						/// </summary>
						/// <param name="oObject">the managed object models root object</param>
						/// <param name="oData">an object for custom data</param>
						public extern ManagedObjectModel(sap.ui.@base.ManagedObject oObject, object oData);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.base.ManagedObjectModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.json.JSONModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.base.ManagedObjectModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.json.JSONModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.base.ManagedObjectModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.json.JSONModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.base.ManagedObjectModel.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Inserts the user-defined custom data into the model.
						/// </summary>
						/// <param name="oData">The data as JSON object to be set on the model</param>
						/// <param name="bMerge">If set to <code>true</code>, the data is merged instead of replaced</param>
						public extern override void setData(object oData, bool bMerge = false);

						#endregion

					}
				}
			}
		}
	}
}
