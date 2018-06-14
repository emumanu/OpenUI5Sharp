using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
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
						/// Annotation loader for OData V2 services
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class ODataAnnotations : sap.ui.@base.EventProvider
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class ODataAnnotationsOptions
							{
								/// <summary>
								/// One or several annotation sources. See {@link sap.ui.model.odata.v2.ODataAnnotations#addSource} for more details
								/// </summary>
								public Union<string, Map, string[], Map[]> source;

								/// <summary>
								/// A map of headers to be sent with every request. See {@link sap.ui.model.odata.v2.ODataAnnotations#setHeaders} for more details
								/// </summary>
								public Map headers;

								/// <summary>
								/// If set to <code>true</code>, the metadata document will not be parsed for annotations;
								/// </summary>
								public bool skipMetadata;

								/// <summary>
								/// (optional) A valid cache key
								/// </summary>
								public string cacheKey;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Creates a new instance of the ODataAnnotations annotation loader.
							/// </summary>
							/// <param name="oMetadata">Metadata object with the metadata information needed to parse the annotations</param>
							/// <param name="mOptions">Obligatory options</param>
							public extern ODataAnnotations(sap.ui.model.odata.ODataMetadata oMetadata, Map mOptions);

							#endregion

							#region Methods

							/// <summary>
							/// Adds one or several sources to the annotation loader. Sources will be loaded instantly but merged only after the previously added source has either been successfully merged or failed.
							/// </summary>
							/// <param name="vSource">One or several annotation source(s). Can be either a string or a map of the type <code>sap.ui.model.odata.v2.ODataAnnotations.Source</code> or an array containing several (either strings or source objects).</param>
							/// <returns>The promise to (load,) parse and merge the given source(s). The Promise resolves on success with an array of maps containing properties <code>source</code> and <code>data</code>. See the parameters of the <code>success</code> event for more details. The promise fails in case at least one source could not be (loaded,) parsed or merged with an array of objects containing Errors and/or Success objects.</returns>
							public extern virtual jquery.JQueryPromise<object> addSource(Union<string, string[], sap.ui.model.odata.v2.ODataAnnotations.Source, sap.ui.model.odata.v2.ODataAnnotations.Source[]> vSource);

							/// <summary>
							/// This event exists for compatibility with the old Annotation loader Attaches the given callback to the <code>allFailed</code> event. This event is fired when no annotation from a group of sources was successfully (loaded,) parsed and merged. The parameter <code>result</code> will be set on the event argument and contains an array of Errors in the order in which the sources had been added.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <param name="oListener">Object to use as context of the callback. If empty, the global context is used.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachAllFailed(object oData, object fnFunction, object oListener);

							/// <summary>
							/// This event exists for compatibility with the old Annotation loader Attaches the given callback to the <code>allFailed</code> event. This event is fired when no annotation from a group of sources was successfully (loaded,) parsed and merged. The parameter <code>result</code> will be set on the event argument and contains an array of Errors in the order in which the sources had been added.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachAllFailed(object oData, object fnFunction);

							/// <summary>
							/// This event exists for compatibility with the old Annotation loader Attaches the given callback to the <code>allFailed</code> event. This event is fired when no annotation from a group of sources was successfully (loaded,) parsed and merged. The parameter <code>result</code> will be set on the event argument and contains an array of Errors in the order in which the sources had been added.
							/// </summary>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachAllFailed(object fnFunction);

							/// <summary>
							/// Attaches the given callback to the <code>error</code> event, which is fired whenever a source cannot be loaded, parsed or merged into the annotation data. The following parameters will be set on the event object that is given to the callback function: <code>source</code> - A map containing the properties <code>type</code> - containing either "url" or "xml" - and <code>data</code> containing the data given as source, either a URL or an XML string depending on how the source was added. <code>error</code> - An Error object describing the problem that occurred
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <param name="oListener">Object to use as context of the callback. If empty, the global context is used.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachError(object oData, object fnFunction, object oListener);

							/// <summary>
							/// Attaches the given callback to the <code>error</code> event, which is fired whenever a source cannot be loaded, parsed or merged into the annotation data. The following parameters will be set on the event object that is given to the callback function: <code>source</code> - A map containing the properties <code>type</code> - containing either "url" or "xml" - and <code>data</code> containing the data given as source, either a URL or an XML string depending on how the source was added. <code>error</code> - An Error object describing the problem that occurred
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachError(object oData, object fnFunction);

							/// <summary>
							/// Attaches the given callback to the <code>error</code> event, which is fired whenever a source cannot be loaded, parsed or merged into the annotation data. The following parameters will be set on the event object that is given to the callback function: <code>source</code> - A map containing the properties <code>type</code> - containing either "url" or "xml" - and <code>data</code> containing the data given as source, either a URL or an XML string depending on how the source was added. <code>error</code> - An Error object describing the problem that occurred
							/// </summary>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachError(object fnFunction);

							/// <summary>
							/// Attaches the given callback to the <code>failed</code> event. This event is fired when at least one annotation from a group of sources was not successfully (loaded,) parsed or merged. The parameter <code>result</code> will be set on the event argument and contains an array of Errors in the order in which the sources had been added.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <param name="oListener">Object to use as context of the callback. If empty, the global context is used.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachFailed(object oData, object fnFunction, object oListener);

							/// <summary>
							/// Attaches the given callback to the <code>failed</code> event. This event is fired when at least one annotation from a group of sources was not successfully (loaded,) parsed or merged. The parameter <code>result</code> will be set on the event argument and contains an array of Errors in the order in which the sources had been added.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachFailed(object oData, object fnFunction);

							/// <summary>
							/// Attaches the given callback to the <code>failed</code> event. This event is fired when at least one annotation from a group of sources was not successfully (loaded,) parsed or merged. The parameter <code>result</code> will be set on the event argument and contains an array of Errors in the order in which the sources had been added.
							/// </summary>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachFailed(object fnFunction);

							/// <summary>
							/// Attaches the given callback to the <code>loaded</code> event. This event is fired when all annotations from a group of sources was successfully (loaded,) parsed and merged. The parameter <code>result</code> will be set on the event argument and contains an array of all loaded sources as well as Errors in the order in which they had been added.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <param name="oListener">Object to use as context of the callback. If empty, the global context is used.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachLoaded(object oData, object fnFunction, object oListener);

							/// <summary>
							/// Attaches the given callback to the <code>loaded</code> event. This event is fired when all annotations from a group of sources was successfully (loaded,) parsed and merged. The parameter <code>result</code> will be set on the event argument and contains an array of all loaded sources as well as Errors in the order in which they had been added.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachLoaded(object oData, object fnFunction);

							/// <summary>
							/// Attaches the given callback to the <code>loaded</code> event. This event is fired when all annotations from a group of sources was successfully (loaded,) parsed and merged. The parameter <code>result</code> will be set on the event argument and contains an array of all loaded sources as well as Errors in the order in which they had been added.
							/// </summary>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachLoaded(object fnFunction);

							/// <summary>
							/// This event exists for compatibility with the old Annotation loader Attaches the given callback to the <code>someLoaded</code> event. This event is fired when at least one annotation from a group of sources was successfully (loaded,) parsed and merged. The parameter <code>result</code> will be set on the event argument and contains an array of all loaded sources as well as Errors in the order in which they had been added.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <param name="oListener">Object to use as context of the callback. If empty, the global context is used.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachSomeLoaded(object oData, object fnFunction, object oListener);

							/// <summary>
							/// This event exists for compatibility with the old Annotation loader Attaches the given callback to the <code>someLoaded</code> event. This event is fired when at least one annotation from a group of sources was successfully (loaded,) parsed and merged. The parameter <code>result</code> will be set on the event argument and contains an array of all loaded sources as well as Errors in the order in which they had been added.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachSomeLoaded(object oData, object fnFunction);

							/// <summary>
							/// This event exists for compatibility with the old Annotation loader Attaches the given callback to the <code>someLoaded</code> event. This event is fired when at least one annotation from a group of sources was successfully (loaded,) parsed and merged. The parameter <code>result</code> will be set on the event argument and contains an array of all loaded sources as well as Errors in the order in which they had been added.
							/// </summary>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachSomeLoaded(object fnFunction);

							/// <summary>
							/// Attaches the given callback to the <code>success</code> event, which is fired whenever a source has been successfully (loaded,) parsed and merged into the annotation data. The following parameters will be set on the event object that is given to the callback function: <code>source</code> - A map containing the properties <code>type</code> - containing either "url" or "xml" - and <code>data</code> containing the data given as source, either a URL or an XML string depending on how the source was added.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <param name="oListener">Object to use as context of the callback. If empty, the global context is used.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachSuccess(object oData, object fnFunction, object oListener);

							/// <summary>
							/// Attaches the given callback to the <code>success</code> event, which is fired whenever a source has been successfully (loaded,) parsed and merged into the annotation data. The following parameters will be set on the event object that is given to the callback function: <code>source</code> - A map containing the properties <code>type</code> - containing either "url" or "xml" - and <code>data</code> containing the data given as source, either a URL or an XML string depending on how the source was added.
							/// </summary>
							/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachSuccess(object oData, object fnFunction);

							/// <summary>
							/// Attaches the given callback to the <code>success</code> event, which is fired whenever a source has been successfully (loaded,) parsed and merged into the annotation data. The following parameters will be set on the event object that is given to the callback function: <code>source</code> - A map containing the properties <code>type</code> - containing either "url" or "xml" - and <code>data</code> containing the data given as source, either a URL or an XML string depending on how the source was added.
							/// </summary>
							/// <param name="fnFunction">The event callback. This function will be called in the context of the oListener object if given as the next argument.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations attachSuccess(object fnFunction);

							/// <summary>
							/// Detaches the given callback from the <code>allFailed</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachFailed}.</param>
							/// <param name="oListener">The same (if any) context object that was used when attaching to the <code>error</code> event.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachAllFailed(object fnFunction, object oListener);

							/// <summary>
							/// Detaches the given callback from the <code>allFailed</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachFailed}.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachAllFailed(object fnFunction);

							/// <summary>
							/// Detaches the given callback from the <code>error</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachError}.</param>
							/// <param name="oListener">The same (if any) context object that was used when attaching to the <code>error</code> event.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachError(object fnFunction, object oListener);

							/// <summary>
							/// Detaches the given callback from the <code>error</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachError}.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachError(object fnFunction);

							/// <summary>
							/// Detaches the given callback from the <code>failed</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachFailed}.</param>
							/// <param name="oListener">The same (if any) context object that was used when attaching to the <code>error</code> event.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachFailed(object fnFunction, object oListener);

							/// <summary>
							/// Detaches the given callback from the <code>failed</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachFailed}.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachFailed(object fnFunction);

							/// <summary>
							/// Detaches the given callback from the <code>loaded</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachLoaded}.</param>
							/// <param name="oListener">The same (if any) context object that was used when attaching to the <code>error</code> event.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachLoaded(object fnFunction, object oListener);

							/// <summary>
							/// Detaches the given callback from the <code>loaded</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachLoaded}.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachLoaded(object fnFunction);

							/// <summary>
							/// Detaches the given callback from the <code>someLoaded</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachSomeLoaded}.</param>
							/// <param name="oListener">The same (if any) context object that was used when attaching to the <code>error</code> event.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachSomeLoaded(object fnFunction, object oListener);

							/// <summary>
							/// Detaches the given callback from the <code>someLoaded</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachSomeLoaded}.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachSomeLoaded(object fnFunction);

							/// <summary>
							/// Detaches the given callback from the <code>success</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachSuccess}.</param>
							/// <param name="oListener">The same (if any) context object that was used when attaching to the <code>success</code> event.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachSuccess(object fnFunction, object oListener);

							/// <summary>
							/// Detaches the given callback from the <code>success</code> event. The passed function and listener object must match the ones previously used for attaching to the event.
							/// </summary>
							/// <param name="fnFunction">The event callback previously used with {@link sap.ui.model.odata.v2.ODataAnnotations#attachSuccess}.</param>
							/// <returns><code>this</code>-reference to allow method chaining.</returns>
							public extern virtual sap.ui.model.odata.v2.ODataAnnotations detachSuccess(object fnFunction);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataAnnotations with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataAnnotations with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v2.ODataAnnotations with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Returns the parsed and merged annotation data object.
							/// </summary>
							[Obsolete("Deprecated since 1.37.0. only kept for compatibility with V1 API, use {@link #getData} instead.")]
							/// <returns>returns annotations data</returns>
							public extern virtual object getAnnotationsData();

							/// <summary>
							/// Returns the parsed and merged annotation data object
							/// </summary>
							/// <returns>returns annotations data</returns>
							public extern virtual object getData();

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.v2.ODataAnnotations.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns a promise that resolves when the annotation sources that were added up to this point were successfully (loaded,) parsed and merged
							/// </summary>
							/// <returns>The Promise that resolves/rejects after the last added sources have been processed</returns>
							public extern virtual jquery.JQueryPromise<object> loaded();

							/// <summary>
							/// Set custom headers which are provided in a key/value map. These headers are used for all requests. The "Accept-Language" header cannot be modified and is set using the core's language setting.
							/// 
							/// To remove these headers, simply set the <code>mHeaders</code> parameter to <code>{}</code>. Please also note that when calling this method again all previous custom headers are removed unless they are specified again in the <code>mCustomHeaders</code> parameter.
							/// </summary>
							/// <param name="mHeaders">the header name/value map.</param>
							public extern virtual void setHeaders(Map mHeaders);

							#endregion

						}
					}
				}
			}
		}
	}
}
