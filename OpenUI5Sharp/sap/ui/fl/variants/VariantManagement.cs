using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class fl
			{
				public static partial class variants
				{
					/// <summary>
					/// The <code>VariantManagement</code> control can be used to manage variants.
					/// 
					/// <h3>Usage</h3>
					/// 
					/// You can use this control in most controls that are enabled for <i>UI adaptation at runtime</i>.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.fl.variants.VariantManagement")]
					public partial class VariantManagement : sap.ui.core.Control
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.Control.Settings
						{
							/// <summary>
							/// Indicates that Execute on Selection is visible in the Save Variant and the Manage Variants dialogs.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showExecuteOnSelection;

							/// <summary>
							/// Indicates that set as default is visible in the Save Variant and the Manage Variants dialogs.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSetAsDefault;

							/// <summary>
							/// If set to<code>true</code>, the key for a vendor variant will be added manually.<br> <b>Node:</b>This flag is only used internally in the app variant scenarios.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> manualVariantKey;

							/// <summary>
							/// Indicates that the control is in error state. If set to <code>true</code> error message will be displayed whenever the variant is opened.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> inErrorState;

							/// <summary>
							/// Indicates that the control is in edit state. If set to <code>false</code> the footer of the views list will be hidden.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

							/// <summary>
							/// Determines the name of the model. The binding context will be defined by the current ID. <p> <b>Note:</b> In a UI adaptation scenario, this property is not used at all because the model name is <i>$FlexVariants</i>
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> modelName;

							/// <summary>
							/// Determines the intention of setting the current variant based on passed information. <p> <b>Note:</b> The VariantManagement control does not react in any way to this property.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> updateVariantInURL;

							/// <summary>
							/// Contains the controls, for which the variant management is responsible.
							/// </summary>
							public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> @for;

							/// <summary>
							/// This event is fired when the Save Variant dialog is closed with OK for a variant.
							/// </summary>
							public sap.ui.fl.variants.VariantManagement.SaveDelegate save;

							/// <summary>
							/// This event is fired when users apply changes to variants in the Manage Variants dialog.
							/// </summary>
							public sap.ui.@base.EventDelegate manage;

							/// <summary>
							/// This event is fired when the model and context are set.
							/// </summary>
							public sap.ui.@base.EventDelegate initialized;

							/// <summary>
							/// This event is fired when a new variant is selected.
							/// </summary>
							public sap.ui.fl.variants.VariantManagement.SelectDelegate select;

						}

						#endregion

						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class SaveInfo
						{
							/// <summary>
							/// The variant title
							/// </summary>
							public string name;

							/// <summary>
							/// Indicates if an existing variant is overwritten or if a new variant is created
							/// </summary>
							public bool overwrite;

							/// <summary>
							/// The variant key
							/// </summary>
							public string key;

							/// <summary>
							/// The Execute on Selection indicator
							/// </summary>
							public bool execute;

							/// <summary>
							/// The default variant indicator
							/// </summary>
							public bool def;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class SelectInfo
						{
							/// <summary>
							/// The variant key
							/// </summary>
							public string key;

						}

						#endregion

						#region Delegates

						public delegate void SaveDelegate(sap.ui.@base.Event<sap.ui.fl.variants.VariantManagement.SaveInfo> oEvent, object oData);

						public delegate void SelectDelegate(sap.ui.@base.Event<sap.ui.fl.variants.VariantManagement.SelectInfo> oEvent, object oData);

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new VariantManagement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern VariantManagement(string sId, sap.ui.fl.variants.VariantManagement.Settings mSettings);

						/// <summary>
						/// Constructor for a new VariantManagement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern VariantManagement(string sId);

						/// <summary>
						/// Constructor for a new VariantManagement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern VariantManagement();

						/// <summary>
						/// Constructor for a new VariantManagement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern VariantManagement(sap.ui.fl.variants.VariantManagement.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property showExecuteOnSelection

						/// <summary>
						/// Gets current value of property {@link #getShowExecuteOnSelection showExecuteOnSelection}.
						/// 
						/// Indicates that Execute on Selection is visible in the Save Variant and the Manage Variants dialogs.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>showExecuteOnSelection</code></returns>
						public extern virtual bool getShowExecuteOnSelection();

						/// <summary>
						/// Sets a new value for property {@link #getShowExecuteOnSelection showExecuteOnSelection}.
						/// 
						/// Indicates that Execute on Selection is visible in the Save Variant and the Manage Variants dialogs.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bShowExecuteOnSelection">New value for property <code>showExecuteOnSelection</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement setShowExecuteOnSelection(bool bShowExecuteOnSelection);

						#endregion

						#region Methods for Property showSetAsDefault

						/// <summary>
						/// Gets current value of property {@link #getShowSetAsDefault showSetAsDefault}.
						/// 
						/// Indicates that set as default is visible in the Save Variant and the Manage Variants dialogs.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>showSetAsDefault</code></returns>
						public extern virtual bool getShowSetAsDefault();

						/// <summary>
						/// Sets a new value for property {@link #getShowSetAsDefault showSetAsDefault}.
						/// 
						/// Indicates that set as default is visible in the Save Variant and the Manage Variants dialogs.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bShowSetAsDefault">New value for property <code>showSetAsDefault</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement setShowSetAsDefault(bool bShowSetAsDefault);

						#endregion

						#region Methods for Property manualVariantKey

						/// <summary>
						/// Gets current value of property {@link #getManualVariantKey manualVariantKey}.
						/// 
						/// If set to<code>true</code>, the key for a vendor variant will be added manually.<br> <b>Node:</b>This flag is only used internally in the app variant scenarios.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>manualVariantKey</code></returns>
						public extern virtual bool getManualVariantKey();

						/// <summary>
						/// Sets a new value for property {@link #getManualVariantKey manualVariantKey}.
						/// 
						/// If set to<code>true</code>, the key for a vendor variant will be added manually.<br> <b>Node:</b>This flag is only used internally in the app variant scenarios.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bManualVariantKey">New value for property <code>manualVariantKey</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement setManualVariantKey(bool bManualVariantKey);

						#endregion

						#region Methods for Property inErrorState

						/// <summary>
						/// Gets current value of property {@link #getInErrorState inErrorState}.
						/// 
						/// Indicates that the control is in error state. If set to <code>true</code> error message will be displayed whenever the variant is opened.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>inErrorState</code></returns>
						public extern virtual bool getInErrorState();

						/// <summary>
						/// Sets a new value for property {@link #getInErrorState inErrorState}.
						/// 
						/// Indicates that the control is in error state. If set to <code>true</code> error message will be displayed whenever the variant is opened.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bInErrorState">New value for property <code>inErrorState</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement setInErrorState(bool bInErrorState);

						#endregion

						#region Methods for Property editable

						/// <summary>
						/// Gets current value of property {@link #getEditable editable}.
						/// 
						/// Indicates that the control is in edit state. If set to <code>false</code> the footer of the views list will be hidden.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>editable</code></returns>
						public extern virtual bool getEditable();

						/// <summary>
						/// Sets a new value for property {@link #getEditable editable}.
						/// 
						/// Indicates that the control is in edit state. If set to <code>false</code> the footer of the views list will be hidden.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bEditable">New value for property <code>editable</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement setEditable(bool bEditable);

						#endregion

						#region Methods for Property modelName

						/// <summary>
						/// Gets current value of property {@link #getModelName modelName}.
						/// 
						/// Determines the name of the model. The binding context will be defined by the current ID. <p> <b>Note:</b> In a UI adaptation scenario, this property is not used at all because the model name is <i>$FlexVariants</i>
						/// </summary>
						/// <returns>Value of property <code>modelName</code></returns>
						public extern virtual string getModelName();

						/// <summary>
						/// Sets a new value for property {@link #getModelName modelName}.
						/// 
						/// Determines the name of the model. The binding context will be defined by the current ID. <p> <b>Note:</b> In a UI adaptation scenario, this property is not used at all because the model name is <i>$FlexVariants</i>
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sModelName">New value for property <code>modelName</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement setModelName(string sModelName);

						#endregion

						#region Methods for Property updateVariantInURL

						/// <summary>
						/// Gets current value of property {@link #getUpdateVariantInURL updateVariantInURL}.
						/// 
						/// Determines the intention of setting the current variant based on passed information. <p> <b>Note:</b> The VariantManagement control does not react in any way to this property.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>updateVariantInURL</code></returns>
						public extern virtual bool getUpdateVariantInURL();

						/// <summary>
						/// Sets a new value for property {@link #getUpdateVariantInURL updateVariantInURL}.
						/// 
						/// Determines the intention of setting the current variant based on passed information. <p> <b>Note:</b> The VariantManagement control does not react in any way to this property.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bUpdateVariantInURL">New value for property <code>updateVariantInURL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement setUpdateVariantInURL(bool bUpdateVariantInURL);

						#endregion

						#region Methods for Association for

						/// <summary>
						/// Returns array of IDs of the elements which are the current targets of the association {@link #getFor for}.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.ID[] getFor();

						/// <summary>
						/// Adds some for into the association {@link #getFor for}.
						/// </summary>
						/// <param name="vFor">The for to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement addFor(Union<sap.ui.core.ID, sap.ui.core.Control> vFor);

						/// <summary>
						/// Removes an for from the association named {@link #getFor for}.
						/// </summary>
						/// <param name="vFor">The for to be removed or its index or ID</param>
						/// <returns>The removed for or <code>null</code></returns>
						public extern virtual sap.ui.core.ID removeFor(Union<int, sap.ui.core.ID, sap.ui.core.Control> vFor);

						/// <summary>
						/// Removes all the controls in the association named {@link #getFor for}.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.ID[] removeAllFor();

						#endregion

						#region Methods for Event save

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:save save} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when the Save Variant dialog is closed with OK for a variant.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.variants.VariantManagement</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachSave(object oData, sap.ui.fl.variants.VariantManagement.SaveDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:save save} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when the Save Variant dialog is closed with OK for a variant.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachSave(object oData, sap.ui.fl.variants.VariantManagement.SaveDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:save save} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when the Save Variant dialog is closed with OK for a variant.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachSave(sap.ui.fl.variants.VariantManagement.SaveDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:save save} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when the Save Variant dialog is closed with OK for a variant.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.variants.VariantManagement</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachSave(sap.ui.fl.variants.VariantManagement.SaveDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:save save} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement detachSave(sap.ui.fl.variants.VariantManagement.SaveDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:save save} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement fireSave(sap.ui.fl.variants.VariantManagement.SaveInfo mParameters);

						/// <summary>
						/// Fires event {@link #event:save save} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement fireSave();

						#endregion

						#region Methods for Event manage

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:manage manage} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when users apply changes to variants in the Manage Variants dialog.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.variants.VariantManagement</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachManage(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:manage manage} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when users apply changes to variants in the Manage Variants dialog.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachManage(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:manage manage} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when users apply changes to variants in the Manage Variants dialog.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachManage(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:manage manage} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when users apply changes to variants in the Manage Variants dialog.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.variants.VariantManagement</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachManage(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:manage manage} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement detachManage(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:manage manage} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement fireManage(object mParameters);

						/// <summary>
						/// Fires event {@link #event:manage manage} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement fireManage();

						#endregion

						#region Methods for Event initialized

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:initialized initialized} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when the model and context are set.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.variants.VariantManagement</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachInitialized(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:initialized initialized} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when the model and context are set.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachInitialized(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:initialized initialized} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when the model and context are set.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachInitialized(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:initialized initialized} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when the model and context are set.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.variants.VariantManagement</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachInitialized(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:initialized initialized} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement detachInitialized(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:initialized initialized} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement fireInitialized(object mParameters);

						/// <summary>
						/// Fires event {@link #event:initialized initialized} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement fireInitialized();

						#endregion

						#region Methods for Event select

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when a new variant is selected.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.variants.VariantManagement</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachSelect(object oData, sap.ui.fl.variants.VariantManagement.SelectDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when a new variant is selected.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachSelect(object oData, sap.ui.fl.variants.VariantManagement.SelectDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when a new variant is selected.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachSelect(sap.ui.fl.variants.VariantManagement.SelectDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.variants.VariantManagement</code> itself.
						/// 
						/// This event is fired when a new variant is selected.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.variants.VariantManagement</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement attachSelect(sap.ui.fl.variants.VariantManagement.SelectDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.fl.variants.VariantManagement</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement detachSelect(sap.ui.fl.variants.VariantManagement.SelectDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:select select} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement fireSelect(sap.ui.fl.variants.VariantManagement.SelectInfo mParameters);

						/// <summary>
						/// Fires event {@link #event:select select} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement fireSelect();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.fl.variants.VariantManagement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.fl.variants.VariantManagement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.fl.variants.VariantManagement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Gets the currently selected variant key.
						/// </summary>
						/// <returns>The currently selected variant key. In case the model is yet not set <code>null</code> will be returned.</returns>
						public extern virtual string getCurrentVariantKey();

						/// <summary>
						/// Returns a metadata object for class sap.ui.fl.variants.VariantManagement.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Returns the title control of the VariantManagement. Usage in RTA scenario.
						/// </summary>
						/// <returns>title part of the VariantManagement control.</returns>
						public extern virtual sap.m.Title getTitle();

						/// <summary>
						/// Retrieves all variants.
						/// </summary>
						/// <returns>with all variants. In case the model is yet not set an empty array will be returned.</returns>
						public extern virtual object[] getVariants();

						/// <summary>
						/// Opens the manage dialog.
						/// </summary>
						/// <param name="bCreateAlways">in case this is set to <code>true</code> the former dialog will be destroyed, before a new one is created.</param>
						public extern virtual void openManagementDialog(bool bCreateAlways);

						/// <summary>
						/// Sets the new selected variant.
						/// </summary>
						/// <param name="sKey">the variant key which should be selected.</param>
						/// <returns>the current instance of {@link sap.ui.fl.variants.VariantManagement}.</returns>
						public extern virtual sap.ui.fl.variants.VariantManagement setCurrentVariantKey(string sKey);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
