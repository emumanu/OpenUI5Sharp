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
				public partial class CompositeDataState : sap.ui.model.DataState
				{
					#region Constructor

					public extern CompositeDataState();

					#endregion

					#region Methods

					/// <summary>
					/// Returns or sets whether the data state is changed. As long as changed was not set to false the data state is dirty and the corresponding binding will fire data state change events.
					/// </summary>
					/// <param name="bNewState">the optional new state</param>
					/// <returns>whether the data state was changed.</returns>
					public extern override bool changed(bool bNewState);

					/// <summary>
					/// Returns or sets whether the data state is changed. As long as changed was not set to false the data state is dirty and the corresponding binding will fire data state change events.
					/// </summary>
					/// <returns>whether the data state was changed.</returns>
					public extern override bool changed();

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.CompositeDataState with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.DataState.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.CompositeDataState with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.DataState.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.CompositeDataState with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.DataState.extend}.
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
					public extern override Map getChanges();

					/// <summary>
					/// Sets an array of control state messages.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.DataState getControlMessages();

					/// <summary>
					/// Returns an array of the properties set on the inner datastates
					/// </summary>
					public extern virtual void getInternalProperty();

					/// <summary>
					/// Returns the dirty value of a binding that was rejected by a type validation. This value was of an incorrect type and could not be applied to the model. If the value was not rejected it will return null. In this case the current model value can be accessed using the <code>getValue</code> method.
					/// </summary>
					/// <returns>the value that was rejected or null</returns>
					public extern override object getInvalidValue();

					/// <summary>
					/// Returns the array of all state messages or null. This combines the model and control messages.
					/// </summary>
					/// <returns>the array of all messages or null if no {link:sap.ui.core.messages.ModelManager ModelManager} is used.</returns>
					public extern override sap.ui.core.Message[] getMessages();

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.CompositeDataState.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the array of state messages of the model or undefined
					/// </summary>
					/// <returns>the array of messages of the model or null if no {link:sap.ui.core.messages.ModelManager ModelManager} is used.</returns>
					public extern override sap.ui.core.Message[] getModelMessages();

					/// <summary>
					/// Returns whether the data state is dirty in the UI control. A data state is dirty in the UI control if the entered value did not yet pass the type validation.
					/// </summary>
					/// <returns>true if the data state is dirty</returns>
					public extern override bool isControlDirty();

					/// <summary>
					/// Returns whether the data state is dirty. A data state is dirty if the value was changed but is not yet confirmed by a server or the entered value did not yet pass the type validation.
					/// </summary>
					/// <returns>true if the data state is dirty</returns>
					public extern override bool isDirty();

					/// <summary>
					/// Returns whether the data state is in laundering. If data is send to the server the data state becomes laundering until the data was accepted or rejected.
					/// </summary>
					/// <returns>true if the data is laundering</returns>
					public extern override bool isLaundering();

					#endregion

				}
			}
		}
	}
}
