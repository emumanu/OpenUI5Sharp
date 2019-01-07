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
						/// Property binding for an OData V4 model. An event handler can only be attached to this binding for the following events: 'AggregatedDataStateChange', 'change', 'dataReceived', 'dataRequested' and 'DataStateChange'. For unsupported events, an error is thrown.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.v4.ODataPropertyBinding")]
						public partial class ODataPropertyBinding : sap.ui.model.PropertyBinding
						{
							#region Constructor

							/// <summary>
							/// Constructor for PropertyBinding
							/// </summary>
							/// <param name="oModel"></param>
							/// <param name="sPath"></param>
							/// <param name="oContext"></param>
							/// <param name="mParameters"></param>
							public extern ODataPropertyBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, object mParameters);

							/// <summary>
							/// Constructor for PropertyBinding
							/// </summary>
							/// <param name="oModel"></param>
							/// <param name="sPath"></param>
							/// <param name="oContext"></param>
							public extern ODataPropertyBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

							#endregion

							#region Methods

							/// <summary>
							/// Destroys the object. The object must not be used anymore after this function was called.
							/// </summary>
							public extern override void destroy();

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataPropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataPropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataPropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.v4.ODataPropertyBinding.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							[Name("getMetadata")]
							public extern static sap.ui.@base.Metadata getMetadataStatic();

							/// <summary>
							/// Returns the root binding of this binding's hierarchy, see binding {@link topic:54e0ddf695af4a6c978472cecb01c64d Initialization and Read Requests}.
							/// </summary>
							/// <returns>The root binding or <code>undefined</code> if this binding is not yet resolved.</returns>
							public extern virtual Union<sap.ui.model.odata.v4.ODataContextBinding, sap.ui.model.odata.v4.ODataListBinding, sap.ui.model.odata.v4.ODataPropertyBinding> getRootBinding();

							/// <summary>
							/// Returns the current value.
							/// </summary>
							/// <returns>The current value</returns>
							public extern virtual object getValue();

							/// <summary>
							/// Determines which type of value list exists for this property.
							/// </summary>
							/// <returns>The value list type</returns>
							public extern virtual sap.ui.model.odata.v4.ValueListType getValueListType();

							/// <summary>
							/// Returns <code>true</code> if this binding or its dependent bindings have pending changes, meaning updates that have not yet been successfully sent to the server.
							/// </summary>
							/// <returns><code>true</code> if the binding has pending changes</returns>
							public extern virtual bool hasPendingChanges();

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
							/// Valid values are <code>undefined</code>, '$auto', '$auto.*', '$direct' or application group IDs as specified in {@link sap.ui.model.odata.v4.ODataModel}.</param>
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
							/// Requests information to retrieve a value list for this property.
							/// </summary>
							/// <returns>A promise which is resolved with a map of qualifier to value list mapping objects structured as defined by <code>com.sap.vocabularies.Common.v1.ValueListMappingType</code>; the map entry with key "" represents the mapping without qualifier. Each entry has an additional property "$model" which is the {@link sap.ui.model.odata.v4.ODataModel} instance to read value list data via this mapping.
							/// 
							/// For fixed values, only one mapping is expected and the qualifier is ignored. The mapping is available with key "".
							/// 
							/// The promise is rejected with an error if there is no value list information available for this property. Use {@link #getValueListType} to determine if value list information exists. It is also rejected with an error if the value list metadata is inconsistent.
							/// 
							/// An inconsistency can result from one of the following reasons: <ul> <li> There is a reference, but the referenced service does not contain mappings for the property. <li> The referenced service contains annotation targets in the namespace of the data service that are not mappings for the property. <li> Two different referenced services contain a mapping using the same qualifier. <li> A service is referenced twice. <li> No mappings have been found. </ul></returns>
							public extern virtual es5.Promise<object> requestValueListInfo();

							/// <summary>
							/// Determines which type of value list exists for this property.
							/// </summary>
							/// <returns>A promise that is resolved with the type of the value list. It is rejected if the property cannot be found in the metadata.</returns>
							public extern virtual es5.Promise<object> requestValueListType();

							/// <summary>
							/// Resets all pending changes of this binding, see {@link #hasPendingChanges}. Resets also invalid user input.
							/// </summary>
							public extern virtual void resetChanges();

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern override void resume();

							/// <summary>
							/// Sets the optional type and internal type for this binding; used for formatting and parsing. Fires a change event if the type has changed.
							/// </summary>
							/// <param name="oType">The type for this binding</param>
							/// <param name="sInternalType">The internal type of the element property which owns this binding, for example "any", "boolean", "float", "int", "string"; see {@link sap.ui.model.odata.type} for more information</param>
							public extern override void setType(sap.ui.model.Type oType, string sInternalType);

							/// <summary>
							/// Sets the new current value and updates the cache. If the value cannot be accepted or cannot be updated on the server, an error is logged to the console and added to the message manager as a technical message.
							/// </summary>
							/// <param name="vValue">The new value which must be primitive</param>
							/// <param name="sGroupId">The group ID to be used for this update call; if not specified, the update group ID for this binding (or its relevant parent binding) is used, see {@link sap.ui.model.odata.v4.ODataPropertyBinding#constructor}. Valid values are <code>undefined</code>, '$auto', '$auto.*', '$direct' or application group IDs as specified in {@link sap.ui.model.odata.v4.ODataModel}.</param>
							public extern virtual void setValue(object vValue, string sGroupId);

							/// <summary>
							/// Sets the new current value and updates the cache. If the value cannot be accepted or cannot be updated on the server, an error is logged to the console and added to the message manager as a technical message.
							/// </summary>
							/// <param name="vValue">The new value which must be primitive</param>
							public extern virtual void setValue(object vValue);

							/// <summary>
							/// Method not supported
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
