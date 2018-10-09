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
						/// Context binding for an OData V4 model. An event handler can only be attached to this binding for the following events: 'change', 'dataReceived', and 'dataRequested'. For other events, an error is thrown.
						/// 
						/// A context binding can also be used as an <i>operation binding</i> to support bound actions, action imports, bound functions and function imports. If you want to control the execution time of an operation, for example a function import named "GetNumberOfAvailableItems", create a context binding for the path "/GetNumberOfAvailableItems(...)" (as specified here, including the three dots). Such an operation binding is <i>deferred</i>, meaning that it does not request automatically, but only when you call {@link #execute}. {@link #refresh} is always ignored for actions and action imports. For bound functions and function imports, it is ignored if {@link #execute} has not yet been called. Afterwards it results in another call of the function with the parameter values of the last execute.
						/// 
						/// The binding parameter for bound actions or bound functions may be given in the binding path, for example "/SalesOrderList('42')/name.space.SalesOrder_Confirm". This can be used if the exact entity for the binding parameter is known in advance. If you use a relative binding instead, the operation path is a concatenation of the parent context's canonical path and the deferred binding's path.
						/// 
						/// <b>Example</b>: You have a table with a list binding to "/SalesOrderList". In each row you have a button to confirm the sales order, with the relative binding "name.space.SalesOrder_Confirm(...)". Then the parent context for such a button refers to an entity in "SalesOrderList", so its canonical path is "/SalesOrderList('<i>SalesOrderID</i>')" and the resulting path for the action is "/SalesOrderList('<i>SalesOrderID</i>')/name.space.SalesOrder_Confirm".
						/// 
						/// This also works if the relative path of the deferred operation binding starts with a navigation property. Then this navigation property will be part of the operation's resource path, which is still valid.
						/// 
						/// A deferred operation binding is not allowed to have another deferred operation binding as parent.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.v4.ODataContextBinding")]
						public partial class ODataContextBinding : sap.ui.model.ContextBinding
						{
							#region Constructor

							/// <summary>
							/// Do <strong>NOT</strong> call this private constructor, but rather use {@link sap.ui.model.odata.v4.ODataModel#bindContext} instead!
							/// </summary>
							/// <param name="oModel">The OData V4 model</param>
							/// <param name="sPath">The binding path in the model; must not end with a slash</param>
							/// <param name="oContext">The context which is required as base for a relative path</param>
							/// <param name="mParameters">Map of binding parameters</param>
							public extern ODataContextBinding(sap.ui.model.odata.v4.ODataModel oModel, string sPath, sap.ui.model.Context oContext, object mParameters);

							/// <summary>
							/// Do <strong>NOT</strong> call this private constructor, but rather use {@link sap.ui.model.odata.v4.ODataModel#bindContext} instead!
							/// </summary>
							/// <param name="oModel">The OData V4 model</param>
							/// <param name="sPath">The binding path in the model; must not end with a slash</param>
							/// <param name="oContext">The context which is required as base for a relative path</param>
							public extern ODataContextBinding(sap.ui.model.odata.v4.ODataModel oModel, string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Do <strong>NOT</strong> call this private constructor, but rather use {@link sap.ui.model.odata.v4.ODataModel#bindContext} instead!
							/// </summary>
							/// <param name="oModel">The OData V4 model</param>
							/// <param name="sPath">The binding path in the model; must not end with a slash</param>
							public extern ODataContextBinding(sap.ui.model.odata.v4.ODataModel oModel, string sPath);

							#endregion

							#region Methods

							/// <summary>
							/// Changes this binding's parameters and refreshes the binding.
							/// 
							/// If there are pending changes an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #changeParameters}.
							/// 
							/// The parameters are changed according to the given map of parameters: Parameters with an <code>undefined</code> value are removed, the other parameters are set, and missing parameters remain unchanged.
							/// </summary>
							/// <param name="mParameters">Map of binding parameters, see {@link sap.ui.model.odata.v4.ODataModel#bindList} and {@link sap.ui.model.odata.v4.ODataModel#bindContext}</param>
							public extern virtual void changeParameters(object mParameters);

							/// <summary>
							/// Destroys the object. The object must not be used anymore after this function was called.
							/// </summary>
							public extern override void destroy();

							/// <summary>
							/// Calls the OData operation that corresponds to this operation binding.
							/// 
							/// Parameters for the operation must be set via {@link #setParameter} beforehand.
							/// 
							/// The value of this binding is the result of the operation. To access a result of primitive type, bind a control to the path "value", for example <code>&lt;Text text="{value}"/></code>. If the result has a complex or entity type, you can bind properties as usual, for example <code>&lt;Text text="{street}"/></code>.
							/// </summary>
							/// <param name="sGroupId">The group ID to be used for the request; if not specified, the group ID for this binding is used, see {@link sap.ui.model.odata.v4.ODataContextBinding#constructor}. Valid values are <code>undefined</code>, '$auto', '$direct' or application group IDs as specified in {@link sap.ui.model.odata.v4.ODataModel#submitBatch}.</param>
							/// <returns>A promise that is resolved without data or a return value context when the operation call succeeded, or rejected with an instance of <code>Error</code> in case of failure, for instance if the operation metadata is not found, if overloading is not supported, or if a collection-valued function parameter is encountered. A return value context is a {@link sap.ui.model.odata.v4.Context} which represents a bound operation response. It is created only if the operation is bound and has a single entity return value from the same entity set as the operation's binding parameter and has a parent context which is a {@link sap.ui.model.odata.v4.Context} and points to an entity from an entity set.</returns>
							public extern virtual jquery.JQueryPromise<object> execute(string sGroupId);

							/// <summary>
							/// Calls the OData operation that corresponds to this operation binding.
							/// 
							/// Parameters for the operation must be set via {@link #setParameter} beforehand.
							/// 
							/// The value of this binding is the result of the operation. To access a result of primitive type, bind a control to the path "value", for example <code>&lt;Text text="{value}"/></code>. If the result has a complex or entity type, you can bind properties as usual, for example <code>&lt;Text text="{street}"/></code>.
							/// </summary>
							/// <returns>A promise that is resolved without data or a return value context when the operation call succeeded, or rejected with an instance of <code>Error</code> in case of failure, for instance if the operation metadata is not found, if overloading is not supported, or if a collection-valued function parameter is encountered. A return value context is a {@link sap.ui.model.odata.v4.Context} which represents a bound operation response. It is created only if the operation is bound and has a single entity return value from the same entity set as the operation's binding parameter and has a parent context which is a {@link sap.ui.model.odata.v4.Context} and points to an entity from an entity set.</returns>
							public extern virtual jquery.JQueryPromise<object> execute();

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataContextBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ContextBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataContextBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ContextBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataContextBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ContextBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Returns the bound context.
							/// </summary>
							/// <returns>The bound context</returns>
							public extern virtual sap.ui.model.odata.v4.Context getBoundContext();

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.v4.ODataContextBinding.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns the root binding of this binding's hierarchy, see binding {@link topic:54e0ddf695af4a6c978472cecb01c64d Initialization and Read Requests}.
							/// </summary>
							/// <returns>The root binding or <code>undefined</code> if this binding is not yet resolved.</returns>
							public extern virtual Union<sap.ui.model.odata.v4.ODataContextBinding, sap.ui.model.odata.v4.ODataListBinding, sap.ui.model.odata.v4.ODataPropertyBinding> getRootBinding();

							/// <summary>
							/// Returns <code>true</code> if this binding or its dependent bindings have pending changes, meaning updates that have not yet been successfully sent to the server.
							/// </summary>
							/// <returns><code>true</code> if the binding has pending changes</returns>
							public extern virtual bool hasPendingChanges();

							/// <summary>
							/// Initializes the OData list binding: Fires a 'change' event in case the binding has a resolved path and its root binding is not suspended.
							/// </summary>
							public extern override void initialize();

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void isInitial();

							/// <summary>
							/// Refreshes the binding. Prompts the model to retrieve data from the server using the given group ID and notifies the control that new data is available.
							/// 
							/// Refresh is supported for bindings which are not relative to a {@link sap.ui.model.odata.v4.Context} and whose root binding is not suspended.
							/// 
							/// Note: When calling {@link #refresh} multiple times, the result of the request triggered by the last call determines the binding's data; it is <b>independent</b> of the order of calls to {@link sap.ui.model.odata.v4.ODataModel#submitBatch} with the given group ID.
							/// 
							/// If there are pending changes, an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #refresh}.
							/// </summary>
							/// <param name="sGroupId">The group ID to be used for refresh; if not specified, the group ID for this binding is used.
							/// 
							/// Valid values are <code>undefined</code>, '$auto', '$direct' or application group IDs as specified in {@link sap.ui.model.odata.v4.ODataModel#submitBatch}.</param>
							public extern virtual void refresh(string sGroupId);

							/// <summary>
							/// Refreshes the binding. Prompts the model to retrieve data from the server using the given group ID and notifies the control that new data is available.
							/// 
							/// Refresh is supported for bindings which are not relative to a {@link sap.ui.model.odata.v4.Context} and whose root binding is not suspended.
							/// 
							/// Note: When calling {@link #refresh} multiple times, the result of the request triggered by the last call determines the binding's data; it is <b>independent</b> of the order of calls to {@link sap.ui.model.odata.v4.ODataModel#submitBatch} with the given group ID.
							/// 
							/// If there are pending changes, an error is thrown. Use {@link #hasPendingChanges} to check if there are pending changes. If there are changes, call {@link sap.ui.model.odata.v4.ODataModel#submitBatch} to submit the changes or {@link sap.ui.model.odata.v4.ODataModel#resetChanges} to reset the changes before calling {@link #refresh}.
							/// </summary>
							public extern virtual void refresh();

							/// <summary>
							/// Resets all pending changes of this binding, see {@link #hasPendingChanges}. Resets also invalid user input.
							/// </summary>
							public extern virtual void resetChanges();

							/// <summary>
							/// Resumes this binding. The binding can again fire change events and trigger data service requests. Before 1.53.0, this method was not supported and threw an error.
							/// </summary>
							public extern override void resume();

							/// <summary>
							/// Sets a parameter for an operation call.
							/// </summary>
							/// <param name="sParameterName">The parameter name</param>
							/// <param name="vValue">The parameter value</param>
							/// <returns><code>this</code> to enable method chaining</returns>
							public extern virtual sap.ui.model.odata.v4.ODataContextBinding setParameter(string sParameterName, object vValue);

							/// <summary>
							/// Suspends this binding. A suspended binding does not fire change events nor does it trigger data service requests. Call {@link #resume} to resume the binding. Before 1.53.0, this method was not supported and threw an error.
							/// </summary>
							public extern override void suspend();

							#endregion

						}
					}
				}
			}
		}
	}
}
