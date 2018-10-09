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
				public static partial class transport
				{
					/// <summary>
					/// The Transport Dialog Control can be used to implement a value help for selecting an ABAP package and transport request. It is not a generic utility, but part of the Variantmanament and therefore cannot be used in any other application.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.fl.transport.TransportDialog")]
					public partial class TransportDialog : sap.m.Dialog
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.m.Dialog.Settings
						{
							/// <summary>
							/// An ABAP package that can be used as default for the ABAP package selection.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> pkg;

							/// <summary>
							/// The set of ABAP transport requests that can be selected by a user.
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> transports;

							/// <summary>
							/// The LREP object for which as transport request has to be selected
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> lrepObject;

							/// <summary>
							/// Flag indicating whether the selection of an ABAP package is to be hidden or not.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> hidePackage;

							/// <summary>
							/// This event will be fired when the user clicks the OK button on the dialog.
							/// </summary>
							public sap.ui.@base.EventDelegate ok;

							/// <summary>
							/// This event will be fired when the user clicks the Cancel button on the dialog.
							/// </summary>
							public sap.ui.@base.EventDelegate cancel;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new transport/TransportDialog.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern TransportDialog(string sId, sap.ui.fl.transport.TransportDialog.Settings mSettings);

						/// <summary>
						/// Constructor for a new transport/TransportDialog.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern TransportDialog(string sId);

						/// <summary>
						/// Constructor for a new transport/TransportDialog.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern TransportDialog();

						/// <summary>
						/// Constructor for a new transport/TransportDialog.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern TransportDialog(sap.ui.fl.transport.TransportDialog.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property pkg

						/// <summary>
						/// Gets current value of property {@link #getPkg pkg}.
						/// 
						/// An ABAP package that can be used as default for the ABAP package selection.
						/// </summary>
						/// <returns>Value of property <code>pkg</code></returns>
						public extern virtual string getPkg();

						/// <summary>
						/// An ABAP package that can be used as default for the ABAP package selection. The property can only be set once and afterwards it cannot be changed.
						/// </summary>
						/// <param name="sPackage">an ABAP package that can be used as default for the ABAP package selection.</param>
						public extern virtual void setPkg(string sPackage);

						#endregion

						#region Methods for Property transports

						/// <summary>
						/// Gets current value of property {@link #getTransports transports}.
						/// 
						/// The set of ABAP transport requests that can be selected by a user.
						/// </summary>
						/// <returns>Value of property <code>transports</code></returns>
						public extern virtual object getTransports();

						/// <summary>
						/// The set of ABAP transport requests that can be selected by a user.
						/// </summary>
						/// <param name="aSelection">the set of ABAP transport requests that can be selected by a user.</param>
						public extern virtual void setTransports(object[] aSelection);

						#endregion

						#region Methods for Property lrepObject

						/// <summary>
						/// Gets current value of property {@link #getLrepObject lrepObject}.
						/// 
						/// The LREP object for which as transport request has to be selected
						/// </summary>
						/// <returns>Value of property <code>lrepObject</code></returns>
						public extern virtual object getLrepObject();

						/// <summary>
						/// The LREP object for which as transport request has to be selected. The property can only be set once and afterwards it cannot be changed.
						/// </summary>
						/// <param name="oObject">an LREP object for which as transport request has to be selected. The object has the attributes name, namespace and type.</param>
						public extern virtual void setLrepObject(object oObject);

						#endregion

						#region Methods for Property hidePackage

						/// <summary>
						/// Gets current value of property {@link #getHidePackage hidePackage}.
						/// 
						/// Flag indicating whether the selection of an ABAP package is to be hidden or not.
						/// </summary>
						/// <returns>Value of property <code>hidePackage</code></returns>
						public extern virtual bool getHidePackage();

						/// <summary>
						/// Flag indicating whether the selection of an ABAP package is to be hidden or not.
						/// </summary>
						/// <param name="bHide">if set to <code>true</code>, the package selection is hidden.</param>
						public extern virtual void setHidePackage(bool bHide);

						#endregion

						#region Methods for Event ok

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:ok ok} event of this <code>sap.ui.fl.transport.TransportDialog</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.transport.TransportDialog</code> itself.
						/// 
						/// This event will be fired when the user clicks the OK button on the dialog.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.transport.TransportDialog</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog attachOk(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:ok ok} event of this <code>sap.ui.fl.transport.TransportDialog</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.transport.TransportDialog</code> itself.
						/// 
						/// This event will be fired when the user clicks the OK button on the dialog.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog attachOk(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:ok ok} event of this <code>sap.ui.fl.transport.TransportDialog</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.transport.TransportDialog</code> itself.
						/// 
						/// This event will be fired when the user clicks the OK button on the dialog.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog attachOk(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:ok ok} event of this <code>sap.ui.fl.transport.TransportDialog</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.transport.TransportDialog</code> itself.
						/// 
						/// This event will be fired when the user clicks the OK button on the dialog.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.transport.TransportDialog</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog attachOk(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:ok ok} event of this <code>sap.ui.fl.transport.TransportDialog</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog detachOk(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:ok ok} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog fireOk(object mParameters);

						/// <summary>
						/// Fires event {@link #event:ok ok} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog fireOk();

						#endregion

						#region Methods for Event cancel

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.fl.transport.TransportDialog</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.transport.TransportDialog</code> itself.
						/// 
						/// This event will be fired when the user clicks the Cancel button on the dialog.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.transport.TransportDialog</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.fl.transport.TransportDialog</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.transport.TransportDialog</code> itself.
						/// 
						/// This event will be fired when the user clicks the Cancel button on the dialog.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.fl.transport.TransportDialog</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.transport.TransportDialog</code> itself.
						/// 
						/// This event will be fired when the user clicks the Cancel button on the dialog.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog attachCancel(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.ui.fl.transport.TransportDialog</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.fl.transport.TransportDialog</code> itself.
						/// 
						/// This event will be fired when the user clicks the Cancel button on the dialog.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.fl.transport.TransportDialog</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog attachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:cancel cancel} event of this <code>sap.ui.fl.transport.TransportDialog</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog detachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:cancel cancel} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog fireCancel(object mParameters);

						/// <summary>
						/// Fires event {@link #event:cancel cancel} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.fl.transport.TransportDialog fireCancel();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.fl.transport.TransportDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Dialog.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.fl.transport.TransportDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Dialog.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.fl.transport.TransportDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Dialog.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.fl.transport.TransportDialog.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
