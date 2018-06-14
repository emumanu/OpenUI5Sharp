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
				/// <summary>
				/// This is an abstract base class for model objects.
				/// </summary>
				[External]
				[Namespace(false)]
				public abstract partial class Model : sap.ui.core.message.MessageProcessor
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ParseErrorInfo
					{
						public int errorCode;

						public string url;

						public string reason;

						public string srcText;

						public int line;

						public int linepos;

						public int filepos;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class PropertyChangeInfo
					{
						/// <summary>
						/// The cause of the property value change
						/// </summary>
						public sap.ui.model.ChangeReason reason;

						/// <summary>
						/// The path of the property
						/// </summary>
						public string path;

						/// <summary>
						/// The binding context (if available)
						/// </summary>
						public sap.ui.model.Context context;

						/// <summary>
						/// The current value of the property
						/// </summary>
						public object value;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class RequestCompletedInfo
					{
						/// <summary>
						/// The url which was sent to the backend
						/// </summary>
						public string url;

						/// <summary>
						/// The type of the request (if available)
						/// </summary>
						public string type;

						/// <summary>
						/// if the request has been successful or not. In case of errors consult the optional errorobject parameter.
						/// </summary>
						public bool success;

						/// <summary>
						/// If the request failed the error if any can be accessed in this property.
						/// </summary>
						public object errorobject;

						/// <summary>
						/// If the request is synchronous or asynchronous (if available)
						/// </summary>
						public bool async;

						/// <summary>
						/// Additional information for the request (if available) <strong>deprecated</strong>
						/// </summary>
						public string info;

						/// <summary>
						/// Additional information for the request (if available)
						/// </summary>
						public object infoObject;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class RequestFailedInfo
					{
						/// <summary>
						/// A text that describes the failure.
						/// </summary>
						public string message;

						/// <summary>
						/// HTTP status code returned by the request (if available)
						/// </summary>
						public string statusCode;

						/// <summary>
						/// The status as a text, details not specified, intended only for diagnosis output
						/// </summary>
						public string statusText;

						/// <summary>
						/// Response that has been received for the request, as a text string
						/// </summary>
						public string responseText;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class RequestSentInfo
					{
						/// <summary>
						/// The url which is sent to the backend
						/// </summary>
						public string url;

						/// <summary>
						/// The type of the request (if available)
						/// </summary>
						public string type;

						/// <summary>
						/// If the request is synchronous or asynchronous (if available)
						/// </summary>
						public bool async;

						/// <summary>
						/// Additional information for the request (if available) <strong>deprecated</strong>
						/// </summary>
						public string info;

						/// <summary>
						/// Additional information for the request (if available)
						/// </summary>
						public object infoObject;

					}

					#endregion

					#region Delegates

					public delegate void ParseErrorDelegate(sap.ui.@base.Event<sap.ui.model.Model.ParseErrorInfo> oEvent, object oData);

					public delegate void PropertyChangeDelegate(sap.ui.@base.Event<sap.ui.model.Model.PropertyChangeInfo> oEvent, object oData);

					public delegate void RequestCompletedDelegate(sap.ui.@base.Event<sap.ui.model.Model.RequestCompletedInfo> oEvent, object oData);

					public delegate void RequestFailedDelegate(sap.ui.@base.Event<sap.ui.model.Model.RequestFailedInfo> oEvent, object oData);

					public delegate void RequestSentDelegate(sap.ui.@base.Event<sap.ui.model.Model.RequestSentInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Model.
					/// 
					/// Every Model is a MessageProcessor that is able to handle Messages with the normal binding path syntax in the target.
					/// </summary>
					public extern Model();

					#endregion

					#region Methods

					#region Methods for event parseError

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'parseError' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachParseError(object oData, sap.ui.model.Model.ParseErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'parseError' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachParseError(object oData, sap.ui.model.Model.ParseErrorDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'parseError' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachParseError(sap.ui.model.Model.ParseErrorDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'parseError' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachParseError(sap.ui.model.Model.ParseErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'parseError' event of this <code>sap.ui.model.Model</code>.<br/>
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model detachParseError(sap.ui.model.Model.ParseErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Fire event parseError to attached listeners.
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model fireParseError(sap.ui.model.Model.ParseErrorInfo mArguments);

					/// <summary>
					/// Fire event parseError to attached listeners.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model fireParseError();

					#endregion

					#region Methods for event propertyChange

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'propertyChange' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachPropertyChange(object oData, sap.ui.model.Model.PropertyChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'propertyChange' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachPropertyChange(object oData, sap.ui.model.Model.PropertyChangeDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'propertyChange' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachPropertyChange(sap.ui.model.Model.PropertyChangeDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'propertyChange' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachPropertyChange(sap.ui.model.Model.PropertyChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'propertyChange' event of this <code>sap.ui.model.Model</code>.
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model detachPropertyChange(sap.ui.model.Model.PropertyChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fire event propertyChange to attached listeners.
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model firePropertyChange(sap.ui.model.Model.PropertyChangeInfo mArguments);

					/// <summary>
					/// Fire event propertyChange to attached listeners.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model firePropertyChange();

					#endregion

					#region Methods for event requestCompleted

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestCompleted' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestCompleted(object oData, sap.ui.model.Model.RequestCompletedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestCompleted' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestCompleted(object oData, sap.ui.model.Model.RequestCompletedDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestCompleted' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestCompleted(sap.ui.model.Model.RequestCompletedDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestCompleted' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestCompleted(sap.ui.model.Model.RequestCompletedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'requestCompleted' event of this <code>sap.ui.model.Model</code>.
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model detachRequestCompleted(sap.ui.model.Model.RequestCompletedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fire event requestCompleted to attached listeners.
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model fireRequestCompleted(sap.ui.model.Model.RequestCompletedInfo mArguments);

					/// <summary>
					/// Fire event requestCompleted to attached listeners.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model fireRequestCompleted();

					#endregion

					#region Methods for event requestFailed

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestFailed' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, this Model is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestFailed(object oData, sap.ui.model.Model.RequestFailedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestFailed' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestFailed(object oData, sap.ui.model.Model.RequestFailedDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestFailed' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestFailed(sap.ui.model.Model.RequestFailedDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestFailed' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, this Model is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestFailed(sap.ui.model.Model.RequestFailedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'requestFailed' event of this <code>sap.ui.model.Model</code>.<br/>
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model detachRequestFailed(sap.ui.model.Model.RequestFailedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fire event requestFailed to attached listeners.
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model fireRequestFailed(sap.ui.model.Model.RequestFailedInfo mArguments);

					/// <summary>
					/// Fire event requestFailed to attached listeners.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model fireRequestFailed();

					#endregion

					#region Methods for event requestSent

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestSent' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestSent(object oData, sap.ui.model.Model.RequestSentDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestSent' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestSent(object oData, sap.ui.model.Model.RequestSentDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestSent' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestSent(sap.ui.model.Model.RequestSentDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'requestSent' event of this <code>sap.ui.model.Model</code>.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, the global context (window) is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model attachRequestSent(sap.ui.model.Model.RequestSentDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'requestSent' event of this <code>sap.ui.model.Model</code>.
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model detachRequestSent(sap.ui.model.Model.RequestSentDelegate fnFunction, object oListener);

					/// <summary>
					/// Fire event requestSent to attached listeners.
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model fireRequestSent(sap.ui.model.Model.RequestSentInfo mArguments);

					/// <summary>
					/// Fire event requestSent to attached listeners.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.Model fireRequestSent();

					#endregion

					#region Other methods

					/// <summary>
					/// Create ContextBinding
					/// </summary>
					/// <param name="sPath">the path pointing to the property that should be bound or an object which contains the following parameter properties: path, context, parameters</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <param name="mParameters">additional model specific parameters (optional)</param>
					/// <param name="oEvents">event handlers can be passed to the binding ({change:myHandler})</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.ContextBinding bindContext(Union<string, object> sPath, object oContext, object mParameters, object oEvents);

					/// <summary>
					/// Create ContextBinding
					/// </summary>
					/// <param name="sPath">the path pointing to the property that should be bound or an object which contains the following parameter properties: path, context, parameters</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <param name="mParameters">additional model specific parameters (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.ContextBinding bindContext(Union<string, object> sPath, object oContext, object mParameters);

					/// <summary>
					/// Create ContextBinding
					/// </summary>
					/// <param name="sPath">the path pointing to the property that should be bound or an object which contains the following parameter properties: path, context, parameters</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.ContextBinding bindContext(Union<string, object> sPath, object oContext);

					/// <summary>
					/// Create ContextBinding
					/// </summary>
					/// <param name="sPath">the path pointing to the property that should be bound or an object which contains the following parameter properties: path, context, parameters</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.ContextBinding bindContext(Union<string, object> sPath);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the list / array that should be bound</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <param name="aSorters">initial sort order (can be either a sorter or an array of sorters) (optional)</param>
					/// <param name="aFilters">predefined filter/s (can be either a filter or an array of filters) (optional)</param>
					/// <param name="mParameters">additional model specific parameters (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, object mParameters);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the list / array that should be bound</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <param name="aSorters">initial sort order (can be either a sorter or an array of sorters) (optional)</param>
					/// <param name="aFilters">predefined filter/s (can be either a filter or an array of filters) (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the list / array that should be bound</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <param name="aSorters">initial sort order (can be either a sorter or an array of sorters) (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the list / array that should be bound</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the list / array that should be bound</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.ListBinding bindList(string sPath);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the property that should be bound</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <param name="mParameters">additional model specific parameters (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.PropertyBinding bindProperty(string sPath, object oContext, object mParameters);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the property that should be bound</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.PropertyBinding bindProperty(string sPath, object oContext);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the property that should be bound</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.PropertyBinding bindProperty(string sPath);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the tree / array that should be bound</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <param name="aFilters">predefined filter/s contained in an array (optional)</param>
					/// <param name="mParameters">additional model specific parameters (optional)</param>
					/// <param name="aSorters">predefined sap.ui.model.sorter/s contained in an array (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.TreeBinding bindTree(string sPath, object oContext, object[] aFilters, object mParameters, object[] aSorters);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the tree / array that should be bound</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <param name="aFilters">predefined filter/s contained in an array (optional)</param>
					/// <param name="mParameters">additional model specific parameters (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.TreeBinding bindTree(string sPath, object oContext, object[] aFilters, object mParameters);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the tree / array that should be bound</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <param name="aFilters">predefined filter/s contained in an array (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.TreeBinding bindTree(string sPath, object oContext, object[] aFilters);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the tree / array that should be bound</param>
					/// <param name="oContext">the context object for this databinding (optional)</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.TreeBinding bindTree(string sPath, object oContext);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path pointing to the tree / array that should be bound</param>
					/// <returns></returns>
					public extern virtual sap.ui.model.TreeBinding bindTree(string sPath);

					/// <summary>
					/// Checks whether the given filters contain an unsupported operator.
					/// 
					/// OData v1, v2 and Client Bindings cannot be filtered with <code>sap.ui.model.FilterOperator</code> <code>"Any"</code> and <code>"All"</code>. The model property <code>mUnsupportedFilterOperators</code> can be configured in each model subclass to describe the unsupported operators.
					/// 
					/// If any of the given filters contains nested filters, those are checked recursively.
					/// </summary>
					/// <param name="vFilters">Single filter or an array of filter instances</param>
					public extern virtual void checkFilterOperation(Union<sap.ui.model.Filter, sap.ui.model.Filter[]> vFilters);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to create the new context from</param>
					/// <param name="oContext">the context which should be used to create the new binding context</param>
					/// <param name="mParameters">the parameters used to create the new binding context</param>
					/// <param name="fnCallBack">the function which should be called after the binding context has been created</param>
					/// <param name="bReload">force reload even if data is already available. For server side models this should refetch the data from the server</param>
					/// <returns>the binding context, if it could be created synchronously</returns>
					public extern virtual sap.ui.model.Context createBindingContext(string sPath, object oContext, object mParameters, object fnCallBack, bool bReload);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to create the new context from</param>
					/// <param name="oContext">the context which should be used to create the new binding context</param>
					/// <param name="mParameters">the parameters used to create the new binding context</param>
					/// <param name="fnCallBack">the function which should be called after the binding context has been created</param>
					/// <returns>the binding context, if it could be created synchronously</returns>
					public extern virtual sap.ui.model.Context createBindingContext(string sPath, object oContext, object mParameters, object fnCallBack);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to create the new context from</param>
					/// <param name="oContext">the context which should be used to create the new binding context</param>
					/// <param name="mParameters">the parameters used to create the new binding context</param>
					/// <returns>the binding context, if it could be created synchronously</returns>
					public extern virtual sap.ui.model.Context createBindingContext(string sPath, object oContext, object mParameters);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to create the new context from</param>
					/// <param name="oContext">the context which should be used to create the new binding context</param>
					/// <returns>the binding context, if it could be created synchronously</returns>
					public extern virtual sap.ui.model.Context createBindingContext(string sPath, object oContext);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to create the new context from</param>
					/// <returns>the binding context, if it could be created synchronously</returns>
					public extern virtual sap.ui.model.Context createBindingContext(string sPath);

					/// <summary>
					/// Destroys the model and clears the model data. A model implementation may override this function and perform model specific cleanup tasks e.g. abort requests, prevent new requests, etc.
					/// </summary>
					public extern override void destroy();

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="oContext">to destroy</param>
					public extern virtual void destroyBindingContext(object oContext);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Model with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.message.MessageProcessor.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Model with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.message.MessageProcessor.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Model with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.message.MessageProcessor.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Get the default binding mode for the model
					/// </summary>
					/// <returns>default binding mode of the model</returns>
					public extern virtual sap.ui.model.BindingMode getDefaultBindingMode();

					/// <summary>
					/// Get messages for path
					/// </summary>
					/// <param name="sPath">The binding path</param>
					public extern virtual void getMessagesByPath(string sPath);

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.Model.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the meta model associated with this model if it is available for the concrete model type.
					/// </summary>
					/// <returns>The meta model or undefined if no meta model exists.</returns>
					public extern virtual sap.ui.model.MetaModel getMetaModel();

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to where to read the object</param>
					/// <param name="oContext">the context with which the path should be resolved</param>
					/// <param name="mParameters">additional model specific parameters</param>
					/// <returns>The value for the given path / context or < code > undefined </ code > if data or entity type could not be found or was incomplete</returns>
					public extern virtual object getObject(string sPath, sap.ui.model.Context oContext, object mParameters);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to where to read the object</param>
					/// <param name="oContext">the context with which the path should be resolved</param>
					/// <returns>The value for the given path / context or < code > undefined </ code > if data or entity type could not be found or was incomplete</returns>
					public extern virtual object getObject(string sPath, sap.ui.model.Context oContext);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to where to read the object</param>
					/// <returns>The value for the given path / context or < code > undefined </ code > if data or entity type could not be found or was incomplete</returns>
					public extern virtual object getObject(string sPath);

					/// <summary>
					/// Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
					/// </summary>
					/// <param name="sPath">the path/name of the property</param>
					/// <param name="oContext">the context if available to access the property value</param>
					/// <returns>vValue the value of the property</returns>
					public extern virtual object getOriginalProperty(string sPath, sap.ui.model.Context oContext);

					/// <summary>
					/// Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
					/// </summary>
					/// <param name="sPath">the path/name of the property</param>
					/// <returns>vValue the value of the property</returns>
					public extern virtual object getOriginalProperty(string sPath);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to where to read the attribute value</param>
					/// <param name="oContext">the context with which the path should be resolved</param>
					/// <returns>Returns the value for the property with the given sPropertyName</returns>
					public extern virtual object getProperty(string sPath, sap.ui.model.Context oContext);

					/// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to where to read the attribute value</param>
					/// <returns>Returns the value for the property with the given sPropertyName</returns>
					public extern virtual object getProperty(string sPath);

					/// <summary>
					/// Check if the specified binding mode is supported by the model.
					/// </summary>
					/// <param name="sMode">the binding mode to check</param>
					public extern virtual void isBindingModeSupported(sap.ui.model.BindingMode sMode);

					/// <summary>
					/// Returns whether legacy path syntax is used
					/// </summary>
					/// <returns></returns>
					public extern virtual bool isLegacySyntax();

					/// <summary>
					/// Refresh the model. This will check all bindings for updated data and update the controls if data has been changed.
					/// </summary>
					/// <param name="bForceUpdate">Update controls even if data has not been changed</param>
					public extern virtual void refresh(bool bForceUpdate);

					/// <summary>
					/// Set the default binding mode for the model. If the default binding mode should be changed, this method should be called directly after model instance creation and before any binding creation. Otherwise it is not guaranteed that the existing bindings will be updated with the new binding mode.
					/// </summary>
					/// <param name="sMode">the default binding mode to set for the model</param>
					/// <returns>this pointer for chaining</returns>
					public extern virtual sap.ui.model.Model setDefaultBindingMode(sap.ui.model.BindingMode sMode);

					/// <summary>
					/// Enables legacy path syntax handling
					/// 
					/// This defines, whether relative bindings, which do not have a defined binding context, should be compatible to earlier releases which means they are resolved relative to the root element or handled strict and stay unresolved until a binding context is set
					/// </summary>
					/// <param name="bLegacySyntax">the path syntax to use</param>
					public extern virtual void setLegacySyntax(bool bLegacySyntax);

					/// <summary>
					/// Sets messages
					/// </summary>
					/// <param name="mMessages">Messages for this model</param>
					public extern virtual void setMessages(object mMessages);

					/// <summary>
					/// Set the maximum number of entries which are used for list bindings.
					/// 
					/// Default is 100.
					/// </summary>
					/// <param name="iSizeLimit">collection size limit</param>
					public extern virtual void setSizeLimit(int iSizeLimit);

					#endregion

					#endregion

				}
			}
		}
	}
}
