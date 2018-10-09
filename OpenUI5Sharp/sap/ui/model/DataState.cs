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
				/// Provides and update the status data of a binding. Depending on the models state and controls state changes, the data state is used to propagated changes to a control. The control can react on these changes by implementing the <code>refreshDataState</code> method for the control. Here the data state object is passed as a parameter.
				/// 
				/// Using the {@link #getChanges getChanges} method the control can determine the changed properties and their old and new value. <pre>
				///     //sample implementation to handle message changes
				///     myControl.prototype.refreshDataState = function(oDataState) {
				///        var aMessages = oDataState.getChanges().messages;
				///        if (aMessages) {
				///            for (var i = 0; i &lt; aMessages.length; i++) {
				///                console.log(aMessages.message);
				///            }
				///        }
				///     }
				/// 
				///     //sample implementation to handle laundering state
				///     myControl.prototype.refreshDataState = function(oDataState) {
				///        var bLaundering = oDataState.getChanges().laundering || false;
				///        this.setBusy(bLaundering);
				///     }
				/// 
				///     //sample implementation to handle dirty state
				///     myControl.prototype.refreshDataState = function(oDataState) {
				///        if (oDataState.isDirty()) console.log("Control " + this.getId() + " is now dirty");
				///     }
				/// </pre>
				/// 
				/// Using the {@link #getProperty getProperty} method the control can read the properties of the data state. The properties are <ul> <li><code>value</code> The value formatted by the formatter of the binding <li><code>originalValue</code> The original value of the model formatted by the formatter of the binding <li><code>invalidValue</code> The control value that was tried to be applied to the model but was rejected by a type validation <li><code>modelMessages</code> The messages that were applied to the binding by the <code>sap.ui.model.MessageModel</code> <li><code>controlMessages</code> The messages that were applied due to type validation errors <li><code>messages</code> All messages of the data state <li><code>dirty</code> true if the value was not yet confirmed by the server </ul>
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.DataState")]
				public partial class DataState : sap.ui.@base.Object
				{
					#region Constructor

					public extern DataState();

					#endregion

					#region Methods

					/// <summary>
					/// Returns or sets whether the data state is changed. As long as changed was not set to false the data state is dirty and the corresponding binding will fire data state change events.
					/// </summary>
					/// <param name="bNewState">the optional new state</param>
					/// <returns>whether the data state was changed.</returns>
					public extern virtual bool changed(bool bNewState);

					/// <summary>
					/// Returns or sets whether the data state is changed. As long as changed was not set to false the data state is dirty and the corresponding binding will fire data state change events.
					/// </summary>
					/// <returns>whether the data state was changed.</returns>
					public extern virtual bool changed();

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.DataState with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.DataState with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.DataState with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the changes of the data state in a map that the control can use in the <code>refreshDataState</code> method. The changed property's name is the key in the map. Each element in the map contains an object of below structure. <pre>
					///    {
					///        oldValue : The old value of the property,
					///        value    : The new value of the property
					///    }
					/// </pre> The map only contains the changed properties.
					/// </summary>
					/// <returns>the changed of the data state</returns>
					public extern virtual Map getChanges();

					/// <summary>
					/// Returns the array of state messages of the control or undefined.
					/// </summary>
					/// <returns>the array of messages of the control or null if no {link:sap.ui.core.messages.ModelManager ModelManager} is used.</returns>
					public extern virtual sap.ui.core.Message[] getControlMessages();

					/// <summary>
					/// Returns the dirty value of a binding that was rejected by a type validation. This value was of an incorrect type and could not be applied to the model. If the value was not rejected it will return null. In this case the current model value can be accessed using the <code>getValue</code> method.
					/// </summary>
					/// <returns>the value that was rejected or null</returns>
					public extern virtual object getInvalidValue();

					/// <summary>
					/// Returns the array of all state messages or null. This combines the model and control messages.
					/// </summary>
					/// <returns>the array of all messages or null if no {link:sap.ui.core.messages.ModelManager ModelManager} is used.</returns>
					public extern virtual sap.ui.core.Message[] getMessages();

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.DataState.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the array of state messages of the model or undefined
					/// </summary>
					/// <returns>the array of messages of the model or null if no {link:sap.ui.core.messages.ModelManager ModelManager} is used.</returns>
					public extern virtual sap.ui.core.Message[] getModelMessages();

					/// <summary>
					/// Returns the formatted original value of the data. The original value is the last confirmed value.
					/// </summary>
					/// <returns>the original confirmed value of the server</returns>
					public extern virtual object getOriginalValue();

					/// <summary>
					/// Returns the formatted value of the data state.
					/// </summary>
					/// <returns>The value of the data.</returns>
					public extern virtual object getValue();

					/// <summary>
					/// Returns whether the data state is dirty in the UI control. A data state is dirty in the UI control if the entered value did not yet pass the type validation.
					/// </summary>
					/// <returns>true if the data state is dirty</returns>
					public extern virtual bool isControlDirty();

					/// <summary>
					/// Returns whether the data state is dirty. A data state is dirty if the value was changed but is not yet confirmed by a server or the entered value did not yet pass the type validation.
					/// </summary>
					/// <returns>true if the data state is dirty</returns>
					public extern virtual bool isDirty();

					/// <summary>
					/// Returns whether the data state is in laundering. If data is sent to the server, the data state becomes laundering until the data was accepted or rejected.
					/// </summary>
					/// <returns>true if the data is laundering</returns>
					public extern virtual bool isLaundering();

					/// <summary>
					/// Sets an array of control state messages.
					/// </summary>
					/// <param name="the">control messages</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.DataState setControlMessages(sap.ui.core.Message[] the);

					/// <summary>
					/// Sets the dirty value that was rejected by the type validation.
					/// </summary>
					/// <param name="vInvalidValue">the value that was rejected by the type validation or null if the value was valid</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.DataState setInvalidValue(object vInvalidValue);

					/// <summary>
					/// Sets the laundering state of the data state.
					/// </summary>
					/// <param name="bLaundering">true if the state is laundering</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.DataState setLaundering(bool bLaundering);

					/// <summary>
					/// Sets an array of model state messages.
					/// </summary>
					/// <param name="the">model messages for this data state.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.DataState setModelMessages(object[] the);

					/// <summary>
					/// Sets the formatted original value of the data.
					/// </summary>
					/// <param name="vOriginalValue">the original value</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.DataState setOriginalValue(bool vOriginalValue);

					/// <summary>
					/// Sets the formatted value of the data state,
					/// </summary>
					/// <param name="vValue">the value</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.DataState setValue(object vValue);

					#endregion

				}
			}
		}
	}
}
