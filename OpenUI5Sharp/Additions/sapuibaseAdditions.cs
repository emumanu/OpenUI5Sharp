using System;
using Bridge;

namespace UI5
{
    [External]
    public partial class sap
    {
        [External]
        public static partial class ui
        {
            [External]
            public static partial class @base
            {
                [External]
                public partial class ManagedObject
                {
                    /// <summary>
                    /// Delegate for the factory function. The factory function is called for each list entry to create the controls necessary to represent the current entry. The developer can decide, whether it is the same control with different properties or even a completely different control for each entry
                    /// </summary>
                    /// <param name="sId">identifier of the created control</param>
                    /// <param name="oContext">a data item from model list</param>
                    /// <returns>The created element</returns>
                    public delegate sap.ui.core.Element FactoryDelegate(string sId, sap.ui.model.Context oContext);

                    /// <summary>
                    /// Delegate for the a factory function to generate custom group visualization
                    /// </summary>
                    /// <param name="oGroup">the group to process</param>
                    /// <returns>the created element</returns>
                    public delegate sap.ui.core.Element GroupHeaderFactoryDelegate(object oGroup);

                    /// <summary>
					/// Returns the aggregated object(s) for the named aggregation of this ManagedObject.
					/// 
					/// If the aggregation does not contain any objects(s), the given <code>oDefaultForCreation</code> (or <code>null</code>) is set as new value of the aggregation and returned to the caller.
					/// 
					/// <b>Note:</b> the need to specify a default value and the fact that it is stored as new value of a so far empty aggregation is recognized as a shortcoming of this API but can no longer be changed for compatibility reasons.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically read the content of an aggregation. Use the concrete method get<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the name of the aggregation</param>
					/// <param name="oDefaultForCreation">the object that is used in case the current aggregation is empty</param>
					/// <returns>the aggregation array in case of 0..n-aggregations or the managed object or null in case of 0..1-aggregations</returns>
					public extern virtual T getAggregation<T>(string sAggregationName, T oDefaultForCreation);

                    /// <summary>
                    /// Returns the aggregated object(s) for the named aggregation of this ManagedObject.
                    /// 
                    /// If the aggregation does not contain any objects(s), the given <code>oDefaultForCreation</code> (or <code>null</code>) is set as new value of the aggregation and returned to the caller.
                    /// 
                    /// <b>Note:</b> the need to specify a default value and the fact that it is stored as new value of a so far empty aggregation is recognized as a shortcoming of this API but can no longer be changed for compatibility reasons.
                    /// 
                    /// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically read the content of an aggregation. Use the concrete method get<i>XYZ</i> for aggregation 'XYZ' instead.
                    /// </summary>
                    /// <param name="sAggregationName">the name of the aggregation</param>
                    /// <returns>the aggregation array in case of 0..n-aggregations or the managed object or null in case of 0..1-aggregations</returns>
                    public extern virtual T getAggregation<T>(string sAggregationName);

                    /// <summary>
				    /// Get the model to be used for data bindings with the given model name. If the object does not have a model set on itself, it will use the first model defined in its parent hierarchy.
				    /// 
				    /// The name can be omitted to reference the default model or it must be a non-empty string.
				    /// 
				    /// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
				    /// </summary>
				    /// <param name="sName">name of the model to be retrieved</param>
				    /// <returns>oModel</returns>
				    public virtual extern T getModel<T>(object sName) where T : sap.ui.model.Model;

                    /// <summary>
                    /// Get the model to be used for data bindings with the given model name. If the object does not have a model set on itself, it will use the first model defined in its parent hierarchy.
                    /// 
                    /// The name can be omitted to reference the default model or it must be a non-empty string.
                    /// 
                    /// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
                    /// </summary>
                    /// <returns>oModel</returns>
                    public virtual extern T getModel<T>() where T : sap.ui.model.Model;

                    /// <summary>
					/// Get the binding object for a specific aggregation/property
					/// </summary>
					/// <param name="sName">the name of the property or aggregation</param>
					/// <returns>the binding for the given name</returns>
					public extern virtual T getBinding<T>(string sName) where T : sap.ui.model.Binding;

                    /// <summary>
                    /// Get the binding context of this object for the given model name.
                    /// 
                    /// If the object does not have a binding context set on itself and has no own model set, it will use the first binding context defined in its parent hierarchy.
                    /// 
                    /// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
                    /// 
                    /// <b>Note:</b> A ManagedObject inherits binding contexts from the Core only when it is a descendant of a UIArea.
                    /// </summary>
                    /// <param name="sModelName">the name of the model or <code>undefined</code></param>
                    /// <returns>The binding context of this object</returns>
                    public extern virtual T getBindingContext<T>(string sModelName) where T : sap.ui.model.Context;

                    /// <summary>
                    /// Get the binding context of this object for the given model name.
                    /// 
                    /// If the object does not have a binding context set on itself and has no own model set, it will use the first binding context defined in its parent hierarchy.
                    /// 
                    /// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
                    /// 
                    /// <b>Note:</b> A ManagedObject inherits binding contexts from the Core only when it is a descendant of a UIArea.
                    /// </summary>
                    /// <returns>The binding context of this object</returns>
                    public extern virtual T getBindingContext<T>() where T : sap.ui.model.Context;

                    /// <summary>
					/// Returns the value for the property with the given <code>sPropertyName</code>.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically retrieve the value of a property. Use the concrete method get<i>XYZ</i> for property 'XYZ' instead.
					/// </summary>
					/// <param name="sPropertyName">the name of the property</param>
					/// <returns>the value of the property</returns>
					public extern virtual T getProperty<T>(string sPropertyName);

                    /// <summary>
					/// Sets the given value for the given property after validating and normalizing it, marks this object as changed.
					/// 
					/// If the value is not valid with regard to the declared data type of the property, an Error is thrown. In case <code>null</code> or <code>undefined</code> is passed, the default value for this property is used (see {@link #validateProperty}). To fully reset the property to initial state, use {@link #resetProperty} instead. If the validated and normalized <code>oValue</code> equals the current value of the property, the internal state of this object is not changed (apart from the result of {@link #isPropertyInitial}). If the value changes, it is stored internally and the {@link #invalidate} method is called on this object. In the case of TwoWay databinding, the bound model is informed about the property change.
					/// 
					/// Note that ManagedObject only implements a single level of change tracking: if a first call to setProperty recognizes a change, 'invalidate' is called. If another call to setProperty reverts that change, invalidate() will be called again, the new status is not recognized as being 'clean' again.
					/// 
					/// <b>Note:</b> This method is a low level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically set a property. Use the concrete method set<i>XYZ</i> for property 'XYZ' or the generic {@link #applySettings} instead.
					/// </summary>
					/// <param name="sPropertyName">name of the property to set</param>
					/// <param name="oValue">value to set the property to</param>
					/// <param name="bSuppressInvalidate">if true, the managed object is not marked as changed</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject setProperty<T>(string sPropertyName, T oValue, bool bSuppressInvalidate);

                    /// <summary>
                    /// Sets the given value for the given property after validating and normalizing it, marks this object as changed.
                    /// 
                    /// If the value is not valid with regard to the declared data type of the property, an Error is thrown. In case <code>null</code> or <code>undefined</code> is passed, the default value for this property is used (see {@link #validateProperty}). To fully reset the property to initial state, use {@link #resetProperty} instead. If the validated and normalized <code>oValue</code> equals the current value of the property, the internal state of this object is not changed (apart from the result of {@link #isPropertyInitial}). If the value changes, it is stored internally and the {@link #invalidate} method is called on this object. In the case of TwoWay databinding, the bound model is informed about the property change.
                    /// 
                    /// Note that ManagedObject only implements a single level of change tracking: if a first call to setProperty recognizes a change, 'invalidate' is called. If another call to setProperty reverts that change, invalidate() will be called again, the new status is not recognized as being 'clean' again.
                    /// 
                    /// <b>Note:</b> This method is a low level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically set a property. Use the concrete method set<i>XYZ</i> for property 'XYZ' or the generic {@link #applySettings} instead.
                    /// </summary>
                    /// <param name="sPropertyName">name of the property to set</param>
                    /// <param name="oValue">value to set the property to</param>
                    /// <returns>Returns <code>this</code> to allow method chaining</returns>
                    public extern virtual sap.ui.@base.ManagedObject setProperty<T>(string sPropertyName, T oValue);
                }

                /// <summary>
                /// Exception class
                /// 
                /// This is the base exception class. In contrary to the Error an Exception
                /// should be thrown in cases, where the exception can, and should, be handled
                /// within the framework, instead of causing the application to exit.
                /// 
                /// 
                /// The try/catch statement in JavaScript cannot catch specific exceptions, so
                /// when catching internal exceptions you should make sure to rethrow other errors:
                /// 
                /// try {
                ///     ...
                /// }
                /// catch (oException) {
                ///     if (oException instanceof sap.ui.base.Exception) {
                ///         ...handle exception...
                ///     }
                ///     else {
                ///         throw oException;
                ///     }
                /// }
                /// </summary>
                [External]
                [Namespace(false)]
                [Name("sap.ui.base.Exception")]
                public partial class Exception : System.Exception
                {
                    public string name;

                    /// <summary>
                    /// Message explaining what went wrong
                    /// </summary>
                    public string message;

                    #region Constructor

                    /// <summary>
                    /// Constructor for a new Exception.
                    /// </summary>
                    /// <param name="message">Message explaining what went wrong</param>
                    public extern Exception(string message);

                    #endregion

                    // TODO: try to hide properties of System.Exception with Obsolete and System.ComponentModel.EditorBrowsable(EditorBrowsableState.Never)
                }

                [External]
                public partial class Event
                {
                    /// <summary>
					/// Returns the value of the parameter with the given sName.
					/// </summary>
					/// <param name="sName">The name of the parameter to return</param>
					/// <returns>The value for the named parameter</returns>
					public extern virtual T getParameter<T>(string sName);

                    /// <summary>
					/// Returns all parameter values of the event
					/// </summary>
					/// <returns>All parameters of the event</returns>
					public extern virtual T getParameters<T>();

                    /// <summary>
                    /// Returns the event provider on which the event was fired.
                    /// </summary>
                    /// <returns>The source of the event</returns>
                    public extern virtual T getSource<T>() where T : sap.ui.@base.EventProvider;
                }

                [External]
                [IgnoreGeneric]
                public partial class Event<TParameter> : sap.ui.@base.Event
                {
                    public extern Event(string sId, sap.ui.@base.EventProvider oSource, TParameter mParameters);
                }

                [External]
                public delegate void EventDelegate(sap.ui.@base.Event oEvent, object oData);
            }
        }
    }
}
