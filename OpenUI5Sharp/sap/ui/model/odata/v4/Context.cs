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
					public static partial class v4
					{
						/// <summary>
						/// Implementation of an OData V4 model's context.
						/// 
						/// The context is a pointer to model data as returned by a query from a {@link sap.ui.model.odata.v4.ODataContextBinding} or a {@link sap.ui.model.odata.v4.ODataListBinding}. Contexts are always and only created by such bindings. A context for a context binding points to the complete query result. A context for a list binding points to one specific entry in the binding's collection. A property binding does not have a context, you can access its value via {@link sap.ui.model.odata.v4.ODataPropertyBinding#getValue}.
						/// 
						/// Applications can access model data only via a context, either synchronously with the risk that the values are not available yet ({@link #getProperty} and {@link #getObject}) or asynchronously ({@link #requestProperty} and {@link #requestObject}).
						/// 
						/// Context instances are immutable except for their indexes.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.v4.Context")]
						public partial class Context : sap.ui.model.Context
						{
							#region Constructor

							/// <summary>
							/// Do <strong>NOT</strong> call this private constructor. In the OData V4 model you cannot create contexts at will: retrieve them from a binding or a view element instead.
							/// </summary>
							/// <param name="oModel">The model</param>
							/// <param name="oBinding">A binding that belongs to the model</param>
							/// <param name="sPath">An absolute path without trailing slash</param>
							/// <param name="iIndex">Index of item (within the collection addressed by <code>sPath</code>) represented by this context; used by list bindings, not context bindings</param>
							/// <param name="oCreatePromise">Promise returned by {@link #created}</param>
							public extern Context(sap.ui.model.odata.v4.ODataModel oModel, Union<sap.ui.model.odata.v4.ODataContextBinding, sap.ui.model.odata.v4.ODataListBinding> oBinding, string sPath, int iIndex, jquery.JQueryPromise<object> oCreatePromise);

							/// <summary>
							/// Do <strong>NOT</strong> call this private constructor. In the OData V4 model you cannot create contexts at will: retrieve them from a binding or a view element instead.
							/// </summary>
							/// <param name="oModel">The model</param>
							/// <param name="oBinding">A binding that belongs to the model</param>
							/// <param name="sPath">An absolute path without trailing slash</param>
							/// <param name="iIndex">Index of item (within the collection addressed by <code>sPath</code>) represented by this context; used by list bindings, not context bindings</param>
							public extern Context(sap.ui.model.odata.v4.ODataModel oModel, Union<sap.ui.model.odata.v4.ODataContextBinding, sap.ui.model.odata.v4.ODataListBinding> oBinding, string sPath, int iIndex);

							/// <summary>
							/// Do <strong>NOT</strong> call this private constructor. In the OData V4 model you cannot create contexts at will: retrieve them from a binding or a view element instead.
							/// </summary>
							/// <param name="oModel">The model</param>
							/// <param name="oBinding">A binding that belongs to the model</param>
							/// <param name="sPath">An absolute path without trailing slash</param>
							public extern Context(sap.ui.model.odata.v4.ODataModel oModel, Union<sap.ui.model.odata.v4.ODataContextBinding, sap.ui.model.odata.v4.ODataListBinding> oBinding, string sPath);

							#endregion

							#region Methods

							/// <summary>
							/// Returns a promise that is resolved without data when the entity represented by this context has been created in the backend and all selected properties of this entity are available. Expanded navigation properties are only available if the context's binding is refreshable.
							/// 
							/// As long as the promise is not yet resolved or rejected, the entity represented by this context is transient.
							/// </summary>
							/// <returns>A promise that is resolved without data when the entity represented by this context has been created in the backend. It is rejected with an <code>Error</code> instance where <code>oError.canceled === true</code> if the transient entity is deleted before it is created in the backend, for example via {@link sap.ui.model.odata.v4.Context#delete}, {@link sap.ui.model.odata.v4.ODataListBinding#resetChanges} or {@link sap.ui.model.odata.v4.ODataModel#resetChanges}. Returns <code>undefined</code> if the context has not been created using {@link sap.ui.model.odata.v4.ODataListBinding#create}.</returns>
							public extern virtual jquery.JQueryPromise<object> created();

							/// <summary>
							/// Deletes the OData entity this context points to.
							/// 
							/// The context must not be used anymore after successful deletion.
							/// </summary>
							/// <param name="sGroupId">The group ID to be used for the DELETE request; if not specified, the update group ID for the context's binding is used, see {@link sap.ui.model.odata.v4.ODataModel#bindContext} and {@link sap.ui.model.odata.v4.ODataModel#bindList}; the resulting group ID must not have {@link sap.ui.model.odata.v4.SubmitMode.API}.</param>
							/// <returns>A promise which is resolved without a result in case of success, or rejected with an instance of <code>Error</code> in case of failure, e.g. if the given context does not point to an entity, if it is not part of a list binding, if there are pending changes for the context's binding, if the resulting group ID has SubmitMode.API, or if the deletion on the server fails. <p> The error instance is flagged with <code>isConcurrentModification</code> in case a concurrent modification (e.g. by another user) of the entity between loading and deletion has been detected; this should be shown to the user who needs to decide whether to try deletion again. If the entity does not exist, we assume it has already been deleted by someone else and report success.</returns>
							public extern virtual jquery.JQueryPromise<object> delete(string sGroupId);

							/// <summary>
							/// Deletes the OData entity this context points to.
							/// 
							/// The context must not be used anymore after successful deletion.
							/// </summary>
							/// <returns>A promise which is resolved without a result in case of success, or rejected with an instance of <code>Error</code> in case of failure, e.g. if the given context does not point to an entity, if it is not part of a list binding, if there are pending changes for the context's binding, if the resulting group ID has SubmitMode.API, or if the deletion on the server fails. <p> The error instance is flagged with <code>isConcurrentModification</code> in case a concurrent modification (e.g. by another user) of the entity between loading and deletion has been detected; this should be shown to the user who needs to decide whether to try deletion again. If the entity does not exist, we assume it has already been deleted by someone else and report success.</returns>
							public extern virtual jquery.JQueryPromise<object> delete();

							/// <summary>
							/// Destroys this context, that is, it removes this context from all dependent bindings and drops references to binding and model, so that the context cannot be used anymore; it keeps path and index for debugging purposes.
							/// </summary>
							public extern override void destroy();

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.Context with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Context.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.Context with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Context.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.Context with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Context.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Returns the binding this context belongs to.
							/// </summary>
							/// <returns>The context's binding</returns>
							public extern virtual Union<sap.ui.model.odata.v4.ODataContextBinding, sap.ui.model.odata.v4.ODataListBinding> getBinding();

							/// <summary>
							/// Returns the "canonical path" of the entity for this context. According to "4.3.1 Canonical URL" of the specification "OData Version 4.0 Part 2: URL Conventions", this is the "name of the entity set associated with the entity followed by the key predicate identifying the entity within the collection". Use the canonical path in {@link sap.ui.core.Element#bindElement} to create an element binding. Note: For a transient context (see {@link #isTransient}) a wrong path is returned unless all key properties are available within the initial data.
							/// </summary>
							/// <returns>The canonical path (e.g. "/SalesOrderList('0500000000')")</returns>
							public extern virtual string getCanonicalPath();

							/// <summary>
							/// Returns the context's index within the binding's collection. The return value changes if a new entity is added via {@link sap.ui.model.odata.v4.ODataListBinding#create} or deleted again.
							/// </summary>
							/// <returns>The context's index within the binding's collection or <code>undefined</code> if the context does not belong to a list binding.</returns>
							public extern virtual int getIndex();

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.v4.Context.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns the value for the given path relative to this context. The function allows access to the complete data the context points to (if <code>sPath</code> is "") or any part thereof. The data is a JSON structure as described in <a href="http://docs.oasis-open.org/odata/odata-json-format/v4.0/odata-json-format-v4.0.html"> "OData JSON Format Version 4.0"</a>. Note that the function clones the result. Modify values via {@link sap.ui.model.odata.v4.ODataPropertyBinding#setValue}.
							/// 
							/// Returns <code>undefined</code> if the data is not (yet) available. Use {@link #requestObject} for asynchronous access.
							/// </summary>
							/// <param name="sPath">A relative path within the JSON structure</param>
							/// <returns>The requested value</returns>
							public extern virtual object getObject(string sPath = "");

							/// <summary>
							/// Returns the property value for the given path relative to this context. The path is expected to point to a structural property with primitive type. Returns <code>undefined</code> if the data is not (yet) available. Use {@link #requestProperty} for asynchronous access.
							/// </summary>
							/// <param name="sPath">A relative path within the JSON structure</param>
							/// <param name="bExternalFormat">If <code>true</code>, the value is returned in external format using a UI5 type for the given property path that formats corresponding to the property's EDM type and constraints. If the type is not yet available, <code>undefined</code> is returned.</param>
							/// <returns>The requested property value</returns>
							public extern virtual object getProperty(string sPath, bool bExternalFormat = false);

							/// <summary>
							/// Returns <code>true</code> if there are pending changes for the single entity in a {@link sap.ui.model.odata.v4.ODataListBinding} represented by this context or there are pending changes in dependent bindings relative to this context.
							/// </summary>
							/// <returns><code>true</code> if there are pending changes</returns>
							public extern virtual bool hasPendingChanges();

							/// <summary>
							/// Returns <code>true</code> if this context is transient, which means that the promise returned by {@link #created} is not yet resolved or rejected.
							/// </summary>
							/// <returns>Whether this context is transient</returns>
							public extern virtual bool isTransient();

							/// <summary>
							/// Refreshes the single entity in a {@link sap.ui.model.odata.v4.ODataListBinding} represented by this context.
							/// </summary>
							/// <param name="sGroupId">The group ID to be used for the refresh; if not specified, the group ID for the context's binding is used, see {@link sap.ui.model.odata.v4.ODataModel#bindList}.</param>
							/// <param name="bAllowRemoval">Allows the list binding to remove this context from its collection because the entity does not match the binding's filter anymore, see {@link sap.ui.model.odata.v4.ODataListBinding#filter}; a removed context is destroyed, see {@link #destroy}. Supported since 1.55.0</param>
							public extern virtual void refresh(string sGroupId, bool bAllowRemoval = false);

							/// <summary>
							/// Refreshes the single entity in a {@link sap.ui.model.odata.v4.ODataListBinding} represented by this context.
							/// </summary>
							/// <param name="sGroupId">The group ID to be used for the refresh; if not specified, the group ID for the context's binding is used, see {@link sap.ui.model.odata.v4.ODataModel#bindList}.</param>
							public extern virtual void refresh(string sGroupId);

							/// <summary>
							/// Refreshes the single entity in a {@link sap.ui.model.odata.v4.ODataListBinding} represented by this context.
							/// </summary>
							public extern virtual void refresh();

							/// <summary>
							/// Refreshes the single entity in a {@link sap.ui.model.odata.v4.ODataListBinding} represented by this context.
							/// </summary>
							/// <param name="bAllowRemoval">Allows the list binding to remove this context from its collection because the entity does not match the binding's filter anymore, see {@link sap.ui.model.odata.v4.ODataListBinding#filter}; a removed context is destroyed, see {@link #destroy}. Supported since 1.55.0</param>
							public extern virtual void refresh(bool bAllowRemoval = false);

							/// <summary>
							/// Returns a promise for the "canonical path" of the entity for this context. According to "4.3.1 Canonical URL" of the specification "OData Version 4.0 Part 2: URL Conventions", this is the "name of the entity set associated with the entity followed by the key predicate identifying the entity within the collection". Use the canonical path in {@link sap.ui.core.Element#bindElement} to create an element binding. Note: For a transient context (see {@link #isTransient}) a wrong path is returned unless all key properties are available within the initial data.
							/// </summary>
							/// <returns>A promise which is resolved with the canonical path (e.g. "/SalesOrderList('0500000000')") in case of success, or rejected with an instance of <code>Error</code> in case of failure, e.g. if the given context does not point to an entity</returns>
							public extern virtual jquery.JQueryPromise<object> requestCanonicalPath();

							/// <summary>
							/// Returns a promise on the value for the given path relative to this context. The function allows access to the complete data the context points to (if <code>sPath</code> is "") or any part thereof. The data is a JSON structure as described in <a href="http://docs.oasis-open.org/odata/odata-json-format/v4.0/odata-json-format-v4.0.html"> "OData JSON Format Version 4.0"</a>. Note that the function clones the result. Modify values via {@link sap.ui.model.odata.v4.ODataPropertyBinding#setValue}.
							/// 
							/// If you want {@link #requestObject} to read fresh data, call <code>oContext.getBinding().refresh()</code> first.
							/// </summary>
							/// <param name="sPath">A relative path within the JSON structure</param>
							/// <returns>A promise on the requested value</returns>
							public extern virtual jquery.JQueryPromise<object> requestObject(string sPath = "");

							/// <summary>
							/// Returns a promise on the property value for the given path relative to this context. The path is expected to point to a structural property with primitive type.
							/// </summary>
							/// <param name="sPath">A relative path within the JSON structure</param>
							/// <param name="bExternalFormat">If <code>true</code>, the value is returned in external format using a UI5 type for the given property path that formats corresponding to the property's EDM type and constraints.</param>
							/// <returns>A promise on the requested value; it is rejected if the value is not primitive</returns>
							public extern virtual jquery.JQueryPromise<object> requestProperty(string sPath, bool bExternalFormat = false);

							/// <summary>
							/// Returns a promise on the property value for the given path relative to this context. The path is expected to point to a structural property with primitive type.
							/// </summary>
							/// <param name="sPath">A relative path within the JSON structure</param>
							/// <returns>A promise on the requested value; it is rejected if the value is not primitive</returns>
							public extern virtual jquery.JQueryPromise<object> requestProperty(string sPath);

							/// <summary>
							/// Returns a promise on the property value for the given path relative to this context. The path is expected to point to a structural property with primitive type.
							/// </summary>
							/// <returns>A promise on the requested value; it is rejected if the value is not primitive</returns>
							public extern virtual jquery.JQueryPromise<object> requestProperty();

							/// <summary>
							/// Returns a promise on the property value for the given path relative to this context. The path is expected to point to a structural property with primitive type.
							/// </summary>
							/// <param name="bExternalFormat">If <code>true</code>, the value is returned in external format using a UI5 type for the given property path that formats corresponding to the property's EDM type and constraints.</param>
							/// <returns>A promise on the requested value; it is rejected if the value is not primitive</returns>
							public extern virtual jquery.JQueryPromise<object> requestProperty(bool bExternalFormat = false);

							/// <summary>
							/// Returns a string representation of this object including the binding path.
							/// </summary>
							/// <returns>A string description of this binding</returns>
							public extern virtual string toString();

							#endregion

						}
					}
				}
			}
		}
	}
}
