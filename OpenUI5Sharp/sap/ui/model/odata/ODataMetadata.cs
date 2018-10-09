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
					/// Implementation to access oData metadata
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.odata.ODataMetadata")]
					public partial class ODataMetadata : sap.ui.@base.EventProvider
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class ODataMetadataInfo
						{
							/// <summary>
							/// request is per default async
							/// </summary>
							public bool async;

							/// <summary>
							/// user for the service,
							/// </summary>
							public string user;

							/// <summary>
							/// password for service
							/// </summary>
							public string password;

							/// <summary>
							/// (optional) map of custom headers which should be set with the request.
							/// </summary>
							public object headers;

							/// <summary>
							/// (optional) A valid cache key
							/// </summary>
							public string cacheKey;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new ODataMetadata.
						/// </summary>
						/// <param name="sMetadataURI">needs the correct metadata uri including $metadata</param>
						/// <param name="mParams">optional map of parameters.</param>
						public extern ODataMetadata(string sMetadataURI, sap.ui.model.odata.ODataMetadata.ODataMetadataInfo mParams);

						/// <summary>
						/// Constructor for a new ODataMetadata.
						/// </summary>
						/// <param name="sMetadataURI">needs the correct metadata uri including $metadata</param>
						public extern ODataMetadata(string sMetadataURI);

						#endregion

						#region Methods

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'failed' event of this <code>sap.ui.model.odata.ODataMetadata</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMetadata attachFailed(object oData, object fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'failed' event of this <code>sap.ui.model.odata.ODataMetadata</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMetadata attachFailed(object oData, object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'failed' event of this <code>sap.ui.model.odata.ODataMetadata</code>.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMetadata attachFailed(object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'loaded' event of this <code>sap.ui.model.odata.ODataMetadata</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMetadata attachLoaded(object oData, object fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'loaded' event of this <code>sap.ui.model.odata.ODataMetadata</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMetadata attachLoaded(object oData, object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'loaded' event of this <code>sap.ui.model.odata.ODataMetadata</code>.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMetadata attachLoaded(object fnFunction);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'failed' event of this <code>sap.ui.model.odata.ODataMetadata</code>.
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMetadata detachFailed(object fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'loaded' event of this <code>sap.ui.model.odata.ODataMetadata</code>.
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMetadata detachLoaded(object fnFunction, object oListener);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataMetadata with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataMetadata with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataMetadata with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Fire event failed to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMetadata fireFailed(object mArguments);

						/// <summary>
						/// Fire event failed to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMetadata fireFailed();

						/// <summary>
						/// Fire event loaded to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataMetadata fireLoaded();

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.odata.ODataMetadata.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Return the metadata object
						/// </summary>
						/// <returns>metdata object</returns>
						public extern virtual object getServiceMetadata();

						/// <summary>
						/// Get the use-batch extension value if any
						/// </summary>
						/// <returns>true/false</returns>
						public extern virtual bool getUseBatch();

						/// <summary>
						/// Checks whether metadata loading has already failed
						/// </summary>
						/// <returns>returns whether metadata request has failed</returns>
						public extern virtual bool isFailed();

						/// <summary>
						/// Checks whether metadata is available
						/// </summary>
						/// <returns>returns whether metadata is already loaded</returns>
						public extern virtual bool isLoaded();

						/// <summary>
						/// Returns a promise for the loaded state of the metadata
						/// </summary>
						/// <returns>returns a promise on metadata loaded state</returns>
						public extern virtual jquery.JQueryPromise<object> loaded();

						/// <summary>
						/// Refreshes the metadata creating a new request to the server. Returns a new promise which can be resolved or rejected depending on the metadata loading state.
						/// </summary>
						/// <returns>returns a promise on metadata loaded state</returns>
						public extern virtual jquery.JQueryPromise<object> refresh();

						#endregion

					}
				}
			}
		}
	}
}
