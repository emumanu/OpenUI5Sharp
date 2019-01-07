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
			public static partial class commons
			{
				/// <summary>
				/// A TextField with an attached icon which triggeres an event.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ValueHelpField")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Input</code> control.")]
				public partial class ValueHelpField : sap.ui.commons.TextField
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.TextField.Settings
					{
						/// <summary>
						/// URL of the standard icon for the value help. If no parameter is supplied the default icon image will be shown. This can be a URI to an image or an icon font URI.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconURL;

						/// <summary>
						/// URL of the icon for the value help when hovered. If no parameter is supplied the standard icon image will be shown. If an icon font icon is used, this property is ignored.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconHoverURL;

						/// <summary>
						/// URL of the icon for the value help when disabled. If no parameter is supplied the default icon image will be shown. If an icon font icon is used, this property is ignored.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconDisabledURL;

						/// <summary>
						/// Event which is fired when the ValueHelp is requested.
						/// </summary>
						public sap.ui.@base.EventDelegate valueHelpRequest;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ValueHelpField.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ValueHelpField(string sId, sap.ui.commons.ValueHelpField.Settings mSettings);

					/// <summary>
					/// Constructor for a new ValueHelpField.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern ValueHelpField(string sId);

					/// <summary>
					/// Constructor for a new ValueHelpField.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ValueHelpField();

					/// <summary>
					/// Constructor for a new ValueHelpField.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ValueHelpField(sap.ui.commons.ValueHelpField.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property iconURL

					/// <summary>
					/// Gets current value of property {@link #getIconURL iconURL}.
					/// 
					/// URL of the standard icon for the value help. If no parameter is supplied the default icon image will be shown. This can be a URI to an image or an icon font URI.
					/// </summary>
					/// <returns>Value of property <code>iconURL</code></returns>
					public extern virtual sap.ui.core.URI getIconURL();

					/// <summary>
					/// Sets a new value for property {@link #getIconURL iconURL}.
					/// 
					/// URL of the standard icon for the value help. If no parameter is supplied the default icon image will be shown. This can be a URI to an image or an icon font URI.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIconURL">New value for property <code>iconURL</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ValueHelpField setIconURL(sap.ui.core.URI sIconURL);

					#endregion

					#region Methods for Property iconHoverURL

					/// <summary>
					/// Gets current value of property {@link #getIconHoverURL iconHoverURL}.
					/// 
					/// URL of the icon for the value help when hovered. If no parameter is supplied the standard icon image will be shown. If an icon font icon is used, this property is ignored.
					/// </summary>
					/// <returns>Value of property <code>iconHoverURL</code></returns>
					public extern virtual sap.ui.core.URI getIconHoverURL();

					/// <summary>
					/// Sets a new value for property {@link #getIconHoverURL iconHoverURL}.
					/// 
					/// URL of the icon for the value help when hovered. If no parameter is supplied the standard icon image will be shown. If an icon font icon is used, this property is ignored.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIconHoverURL">New value for property <code>iconHoverURL</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ValueHelpField setIconHoverURL(sap.ui.core.URI sIconHoverURL);

					#endregion

					#region Methods for Property iconDisabledURL

					/// <summary>
					/// Gets current value of property {@link #getIconDisabledURL iconDisabledURL}.
					/// 
					/// URL of the icon for the value help when disabled. If no parameter is supplied the default icon image will be shown. If an icon font icon is used, this property is ignored.
					/// </summary>
					/// <returns>Value of property <code>iconDisabledURL</code></returns>
					public extern virtual sap.ui.core.URI getIconDisabledURL();

					/// <summary>
					/// Sets a new value for property {@link #getIconDisabledURL iconDisabledURL}.
					/// 
					/// URL of the icon for the value help when disabled. If no parameter is supplied the default icon image will be shown. If an icon font icon is used, this property is ignored.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIconDisabledURL">New value for property <code>iconDisabledURL</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ValueHelpField setIconDisabledURL(sap.ui.core.URI sIconDisabledURL);

					#endregion

					#region Methods for Event valueHelpRequest

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:valueHelpRequest valueHelpRequest} event of this <code>sap.ui.commons.ValueHelpField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ValueHelpField</code> itself.
					/// 
					/// Event which is fired when the ValueHelp is requested.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.ValueHelpField</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ValueHelpField attachValueHelpRequest(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:valueHelpRequest valueHelpRequest} event of this <code>sap.ui.commons.ValueHelpField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ValueHelpField</code> itself.
					/// 
					/// Event which is fired when the ValueHelp is requested.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ValueHelpField attachValueHelpRequest(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:valueHelpRequest valueHelpRequest} event of this <code>sap.ui.commons.ValueHelpField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ValueHelpField</code> itself.
					/// 
					/// Event which is fired when the ValueHelp is requested.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ValueHelpField attachValueHelpRequest(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:valueHelpRequest valueHelpRequest} event of this <code>sap.ui.commons.ValueHelpField</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ValueHelpField</code> itself.
					/// 
					/// Event which is fired when the ValueHelp is requested.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.ValueHelpField</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ValueHelpField attachValueHelpRequest(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:valueHelpRequest valueHelpRequest} event of this <code>sap.ui.commons.ValueHelpField</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ValueHelpField detachValueHelpRequest(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:valueHelpRequest valueHelpRequest} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ValueHelpField fireValueHelpRequest(object mParameters);

					/// <summary>
					/// Fires event {@link #event:valueHelpRequest valueHelpRequest} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ValueHelpField fireValueHelpRequest();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ValueHelpField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ValueHelpField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ValueHelpField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.ValueHelpField.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Handle F4 event
					/// </summary>
					/// <param name="oEvent">the occurring event</param>
					public extern virtual void onsapshow(jquery.JQuery.Event oEvent);

					#endregion

					#endregion

				}
			}
		}
	}
}
