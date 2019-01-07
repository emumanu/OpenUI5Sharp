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
				/// The Binding is the object, which holds the necessary information for a data binding, like the binding path and the binding context, and acts like an interface to the model for the control, so it is the event provider for changes in the data model and provides getters for accessing properties or lists.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.Binding")]
				public abstract partial class Binding : sap.ui.@base.EventProvider
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class DataStateChangeInfo
					{
						/// <summary>
						/// The DataState object of the binding.
						/// </summary>
						public sap.ui.model.DataState dataState;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ChangeInfo
					{
						/// <summary>
						/// A string stating the reason for the data change. Can be any string and new values can be added in the future.
						/// </summary>
						public string reason;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class DataReceivedInfo
					{
						/// <summary>
						/// The data received. In error cases it will be undefined.
						/// </summary>
						public string data;

					}

					#endregion

					#region Delegates

					public delegate void DataStateChangeDelegate(sap.ui.@base.Event<sap.ui.model.Binding.DataStateChangeInfo> oEvent, object oData);

					public delegate void ChangeDelegate(sap.ui.@base.Event<sap.ui.model.Binding.ChangeInfo> oEvent, object oData);

					public delegate void DataReceivedDelegate(sap.ui.@base.Event<sap.ui.model.Binding.DataReceivedInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for Binding class.
					/// </summary>
					/// <param name="oModel">the model</param>
					/// <param name="sPath">the path</param>
					/// <param name="oContext">the context object</param>
					/// <param name="mParameters"></param>
					public extern Binding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, object mParameters);

					/// <summary>
					/// Constructor for Binding class.
					/// </summary>
					/// <param name="oModel">the model</param>
					/// <param name="sPath">the path</param>
					/// <param name="oContext">the context object</param>
					public extern Binding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

					#endregion

					#region Methods

					#region Methods for event AggregatedDataStateChange

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'AggregatedDataStateChange' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void attachAggregatedDataStateChange(sap.ui.model.Binding.DataStateChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'AggregatedDataStateChange' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void attachAggregatedDataStateChange(sap.ui.model.Binding.DataStateChangeDelegate fnFunction);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'AggregatedDataStateChange' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void detachAggregatedDataStateChange(sap.ui.model.Binding.DataStateChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'AggregatedDataStateChange' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void detachAggregatedDataStateChange(sap.ui.model.Binding.DataStateChangeDelegate fnFunction);

					#endregion

					#region Methods for event change

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'change' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void attachChange(sap.ui.model.Binding.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'change' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void attachChange(sap.ui.model.Binding.ChangeDelegate fnFunction);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'change' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void detachChange(sap.ui.model.Binding.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'change' event of this <code>sap.ui.model.Model</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void detachChange(sap.ui.model.Binding.ChangeDelegate fnFunction);

					#endregion

					#region Methods for event dataReceived

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'dataReceived' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void attachDataReceived(sap.ui.model.Binding.DataReceivedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'dataReceived' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void attachDataReceived(sap.ui.model.Binding.DataReceivedDelegate fnFunction);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'dataReceived' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void detachDataReceived(sap.ui.model.Binding.DataReceivedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'dataReceived' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void detachDataReceived(sap.ui.model.Binding.DataReceivedDelegate fnFunction);

					/// <summary>
					/// Fire event dataReceived to attached listeners. This event may also be fired when an error occured.
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					public extern virtual void fireDataReceived(Map mArguments);

					#endregion

					#region Methods for event dataRequested

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'dataRequested' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void attachDataRequested(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'dataRequested' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void attachDataRequested(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'dataRequested' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void detachDataRequested(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'dataRequested' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void detachDataRequested(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Fire event dataRequested to attached listeners.
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					public extern virtual void fireDataRequested(Map mArguments);

					#endregion

					#region Methods for event DataStateChange

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'DataStateChange' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void attachDataStateChange(sap.ui.model.Binding.DataStateChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'DataStateChange' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void attachDataStateChange(sap.ui.model.Binding.DataStateChangeDelegate fnFunction);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'DataStateChange' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void detachDataStateChange(sap.ui.model.Binding.DataStateChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'DataStateChange' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void detachDataStateChange(sap.ui.model.Binding.DataStateChangeDelegate fnFunction);

					#endregion

					#region Other methods

					/// <summary>
					/// Attach multiple events.
					/// </summary>
					/// <param name="oEvents"></param>
					public extern virtual void attachEvents(Map<object> oEvents);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'refresh' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void attachRefresh(object fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'refresh' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void attachRefresh(object fnFunction);

					/// <summary>
					/// Removes all control messages for this binding from the MessageManager in addition to the standard clean-up tasks.
					/// </summary>
					public extern override void destroy();

					/// <summary>
					/// Detach multiple events.
					/// </summary>
					/// <param name="oEvents"></param>
					public extern virtual void detachEvents(Map<object> oEvents);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'refresh' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					public extern virtual void detachRefresh(object fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'refresh' event of this <code>sap.ui.model.Binding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void detachRefresh(object fnFunction);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Binding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Binding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Binding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.Binding.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Initialize the binding. The message should be called when creating a binding. The default implementation calls checkUpdate(true).
					/// </summary>
					public extern virtual void initialize();

					/// <summary>
					/// Returns whether the binding is initial, which means it did not get an initial value yet
					/// </summary>
					/// <returns>whether binding is initial</returns>
					public extern virtual bool isInitial();

					/// <summary>
					/// Returns whether the binding is relative, which means it did not start with a /
					/// </summary>
					/// <returns>whether binding is relative</returns>
					public extern virtual bool isRelative();

					/// <summary>
					/// Returns true if the binding is suspended or false if not.
					/// </summary>
					/// <returns>whether binding is suspended</returns>
					public extern virtual bool isSuspended();

					/// <summary>
					/// Refreshes the binding, check whether the model data has been changed and fire change event if this is the case. For server side models this should refetch the data from the server. To update a control, even if no data has been changed, e.g. to reset a control after failed validation, please use the parameter bForceUpdate.
					/// </summary>
					/// <param name="bForceUpdate">Update the bound control even if no data has been changed</param>
					public extern virtual void refresh(bool bForceUpdate);

					/// <summary>
					/// Resumes the binding update. Change events will be fired again.
					/// 
					/// When the binding is resumed, a change event will be fired immediately, if the data has changed while the binding was suspended. For serverside models, a request to the server will be triggered, if a refresh was requested while the binding was suspended.
					/// </summary>
					public extern virtual void resume();

					/// <summary>
					/// Suspends the binding update. No change events will be fired.
					/// 
					/// A refresh call with bForceUpdate set to true will also update the binding and fire a change in suspended mode. Special operations on bindings, which require updates to work properly (as paging or filtering in list bindings) will also update and cause a change event although the binding is suspended.
					/// </summary>
					public extern virtual void suspend();

					/// <summary>
					/// Determines if the binding should be updated by comparing the current model against a specified model.
					/// </summary>
					/// <param name="oModel">The model instance to compare against</param>
					/// <returns>true if this binding should be updated</returns>
					public extern virtual bool updateRequired(object oModel);

					#endregion

					#endregion

				}
			}
		}
	}
}
