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
			public static partial class unified
			{
				/// <summary>
				/// User Header Action Item of the Shell.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.ShellHeadUserItem")]
				[Obsolete("Deprecated since 1.44.0.")]
				public partial class ShellHeadUserItem : sap.ui.core.Element
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Element.Settings
					{
						/// <summary>
						/// The name of the user.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> username;

						/// <summary>
						/// The user item is intended to be used for user settings. Normally these settings are done via a Menu or Dialog. If this property is set to true an indicator for such a popup mechanismn is shown in the item.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showPopupIndicator;

						/// <summary>
						/// An image of the user, normally a URI to an image but also an icon from the sap.ui.core.IconPool is possible.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> image;

						/// <summary>
						/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Event is fired when the user presses the button.
						/// </summary>
						public sap.ui.@base.EventDelegate press;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ShellHeadUserItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ShellHeadUserItem(string sId, sap.ui.unified.ShellHeadUserItem.Settings mSettings);

					/// <summary>
					/// Constructor for a new ShellHeadUserItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ShellHeadUserItem(string sId);

					/// <summary>
					/// Constructor for a new ShellHeadUserItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ShellHeadUserItem();

					/// <summary>
					/// Constructor for a new ShellHeadUserItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ShellHeadUserItem(sap.ui.unified.ShellHeadUserItem.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property username

					/// <summary>
					/// Gets current value of property {@link #getUsername username}.
					/// 
					/// The name of the user.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>username</code></returns>
					public extern virtual string getUsername();

					/// <summary>
					/// Sets a new value for property {@link #getUsername username}.
					/// 
					/// The name of the user.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sUsername">New value for property <code>username</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem setUsername(string sUsername);

					#endregion

					#region Methods for Property showPopupIndicator

					/// <summary>
					/// Gets current value of property {@link #getShowPopupIndicator showPopupIndicator}.
					/// 
					/// The user item is intended to be used for user settings. Normally these settings are done via a Menu or Dialog. If this property is set to true an indicator for such a popup mechanismn is shown in the item.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showPopupIndicator</code></returns>
					public extern virtual bool getShowPopupIndicator();

					/// <summary>
					/// Sets a new value for property {@link #getShowPopupIndicator showPopupIndicator}.
					/// 
					/// The user item is intended to be used for user settings. Normally these settings are done via a Menu or Dialog. If this property is set to true an indicator for such a popup mechanismn is shown in the item.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowPopupIndicator">New value for property <code>showPopupIndicator</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem setShowPopupIndicator(bool bShowPopupIndicator);

					#endregion

					#region Methods for Property image

					/// <summary>
					/// Gets current value of property {@link #getImage image}.
					/// 
					/// An image of the user, normally a URI to an image but also an icon from the sap.ui.core.IconPool is possible.
					/// </summary>
					/// <returns>Value of property <code>image</code></returns>
					public extern virtual sap.ui.core.URI getImage();

					/// <summary>
					/// Sets a new value for property {@link #getImage image}.
					/// 
					/// An image of the user, normally a URI to an image but also an icon from the sap.ui.core.IconPool is possible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sImage">New value for property <code>image</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem setImage(sap.ui.core.URI sImage);

					#endregion

					#region Methods for Association ariaLabelledBy

					/// <summary>
					/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID[] getAriaLabelledBy();

					/// <summary>
					/// Adds some ariaLabelledBy into the association {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <param name="vAriaLabelledBy">The ariaLabelledBy to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

					/// <summary>
					/// Removes an ariaLabelledBy from the association named {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <param name="vAriaLabelledBy">The ariaLabelledBy to be removed or its index or ID</param>
					/// <returns>The removed ariaLabelledBy or <code>null</code></returns>
					public extern virtual sap.ui.core.ID removeAriaLabelledBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

					/// <summary>
					/// Removes all the controls in the association named {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ID[] removeAllAriaLabelledBy();

					#endregion

					#region Methods for Event press

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.unified.ShellHeadUserItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellHeadUserItem</code> itself.
					/// 
					/// Event is fired when the user presses the button.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.ShellHeadUserItem</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem attachPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.unified.ShellHeadUserItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellHeadUserItem</code> itself.
					/// 
					/// Event is fired when the user presses the button.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem attachPress(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.unified.ShellHeadUserItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellHeadUserItem</code> itself.
					/// 
					/// Event is fired when the user presses the button.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem attachPress(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.unified.ShellHeadUserItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellHeadUserItem</code> itself.
					/// 
					/// Event is fired when the user presses the button.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.ShellHeadUserItem</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem attachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.ui.unified.ShellHeadUserItem</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem detachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:press press} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem firePress(object mParameters);

					/// <summary>
					/// Fires event {@link #event:press press} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem firePress();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellHeadUserItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellHeadUserItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellHeadUserItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.ShellHeadUserItem.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					#endregion

					#endregion

				}
			}
		}
	}
}
