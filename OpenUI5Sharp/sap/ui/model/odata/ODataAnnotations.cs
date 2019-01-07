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
					/// Implementation to access oData Annotations
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.odata.ODataAnnotations")]
					public partial class ODataAnnotations : sap.ui.@base.EventProvider
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class SetXMLOptions
						{
							/// <summary>
							/// Success callback gets an objec as argument with the properties "annotations" containing the parsed annotations and "xmlDoc" containing the XML-Document that was returned by the request.
							/// </summary>
							public object success;

							/// <summary>
							/// Error callback gets an objec as argument with the property "xmlDoc" containing the XML-Document that was returned by the request and could not be correctly parsed.
							/// </summary>
							public object error;

							/// <summary>
							/// If this option is set to true, events are fired as if the annotations were loaded from a URL
							/// </summary>
							public bool fireEvents;

						}

						#endregion

						#region Constructor

						/// <param name="aAnnotationURI">The annotation-URL or an array of URLS that should be parsed and merged</param>
						/// <param name="oMetadata"></param>
						/// <param name="mParams"></param>
						public extern ODataAnnotations(Union<string, string[]> aAnnotationURI, sap.ui.model.odata.ODataMetadata oMetadata, object mParams);

						#endregion

						#region Methods

						/// <summary>
						/// Adds either one URL or an array of URLs to be loaded and parsed. The result will be merged into the annotations data which can be retrieved using the getAnnotations-method.
						/// </summary>
						/// <param name="vUrl">Either one URL as string or an array of URL strings</param>
						/// <returns>The Promise to load the given URL(s), resolved if all URLs have been loaded, rejected if at least one failed to load. The argument is an object containing the annotations object, success (an array of sucessfully loaded URLs), fail (an array ob of failed URLs).</returns>
						public extern virtual es5.Promise<object> addUrl(Union<string, string[]> vUrl);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'failed' event of this <code>sap.ui.model.odata.ODataAnnotations</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataAnnotations attachFailed(object oData, object fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'failed' event of this <code>sap.ui.model.odata.ODataAnnotations</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataAnnotations attachFailed(object oData, object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'failed' event of this <code>sap.ui.model.odata.ODataAnnotations</code>.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataAnnotations attachFailed(object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'loaded' event of this <code>sap.ui.model.odata.ODataAnnotations</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataAnnotations attachLoaded(object oData, object fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'loaded' event of this <code>sap.ui.model.odata.ODataAnnotations</code>.
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataAnnotations attachLoaded(object oData, object fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'loaded' event of this <code>sap.ui.model.odata.ODataAnnotations</code>.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataAnnotations attachLoaded(object fnFunction);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'failed' event of this <code>sap.ui.model.odata.ODataAnnotations</code>.
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataAnnotations detachFailed(object fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'loaded' event of this <code>sap.ui.model.odata.ODataAnnotations</code>.
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataAnnotations detachLoaded(object fnFunction, object oListener);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataAnnotations with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataAnnotations with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataAnnotations with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
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
						public extern virtual sap.ui.model.odata.ODataAnnotations fireFailed(object mArguments);

						/// <summary>
						/// Fire event failed to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataAnnotations fireFailed();

						/// <summary>
						/// Fire event loaded to attached listeners.
						/// </summary>
						/// <param name="mArguments">Map of arguments that will be given as parameters to the event handler</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataAnnotations fireLoaded(Map mArguments);

						/// <summary>
						/// Fire event loaded to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.model.odata.ODataAnnotations fireLoaded();

						/// <summary>
						/// returns the raw annotation data
						/// </summary>
						/// <returns>returns annotations data</returns>
						public extern virtual object getAnnotationsData();

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.odata.ODataAnnotations.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Checks whether annotations loading of at least one of the given URLs has already failed. Note: For asynchronous annotations {@link #attachFailed} has to be used.
						/// </summary>
						/// <returns>whether annotations request has failed</returns>
						public extern virtual bool isFailed();

						/// <summary>
						/// Checks whether annotations from at least one source are available
						/// </summary>
						/// <returns>returns whether annotations is already loaded</returns>
						public extern virtual bool isLoaded();

						/// <summary>
						/// Set custom headers which are provided in a key/value map. These headers are used for all requests. The Accept-Language header cannot be modified and is set using the Core's language setting.
						/// 
						/// To remove these headers simply set the mHeaders parameter to {}. Please also note that when calling this method again all previous custom headers are removed unless they are specified again in the mCustomHeaders parameter.
						/// </summary>
						/// <param name="mHeaders">the header name/value map.</param>
						public extern virtual void setHeaders(Map mHeaders);

						/// <summary>
						/// Sets an XML document.
						/// </summary>
						/// <param name="oXMLDocument">The XML document to parse for annotations</param>
						/// <param name="sXMLContent">The XML content as string to parse for annotations</param>
						/// <param name="mOptions">Additional options</param>
						/// <returns>Whether or not parsing was successful</returns>
						public extern virtual bool setXML(object oXMLDocument, string sXMLContent, Map mOptions);

						/// <summary>
						/// Sets an XML document.
						/// </summary>
						/// <param name="oXMLDocument">The XML document to parse for annotations</param>
						/// <param name="sXMLContent">The XML content as string to parse for annotations</param>
						/// <returns>Whether or not parsing was successful</returns>
						public extern virtual bool setXML(object oXMLDocument, string sXMLContent);

						#endregion

					}
				}
			}
		}
	}
}
