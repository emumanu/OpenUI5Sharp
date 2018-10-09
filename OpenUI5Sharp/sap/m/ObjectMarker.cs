using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// The <code>sap.m.ObjectMarker</code> control represents one of the following predefined types: <ul> <li><code>Flagged</code> <li><code>Favorite</code> <li><code>Draft</code> <li><code>Locked</code> <li><code>LockedBy</code> <li><code>Unsaved</code> <li><code>UnsavedBy</code> </ul> <b>Note</b>: Use the <code>LockedBy/UnsavedBy</code> type along with the <code>additionalInfo</code> property to display the name of the user who locked/changed the object. If <code>additionalInfo</code> property is not set when using <code>LockedBy/UnsavedBy</code> types, the string "Locked by another user"/"Unsaved changes by another user" will be displayed. If you don't want to display name of the user, simply use the <code>Locked/Unsaved</code> types.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ObjectMarker")]
			public partial class ObjectMarker : sap.ui.core.Control
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
					/// Sets one of the predefined types.
					/// 
					/// <b>Note</b>: If the <code>visibility</code> property is not specified explicitly, every <code>type</code> comes with predefined one as follows: <ul> <li>For <code>Flagged</code> and <code>Favorite</code> the icon is visible and the text is not displayed</li> <li>For <code>Draft</code> the text is visible and the icon is not displayed</li> <li>For <code>Locked</code>, <code>LockedBy</code>, <code>Unsaved</code> and <code>UnsavedBy</code> - on screens larger than 600px both icon and text are visible, otherwise only the icon</li>
					/// 
					/// </ul>
					/// </summary>
					public Union<sap.m.ObjectMarkerType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					/// <summary>
					/// Sets one of the visibility states. Visibility states are as follows: <ul> <li><code>IconOnly</code> - displays only icon, regardless of the screen size</li> <li><code>TextOnly</code> - displays only text, regardless of the screen size</li> <li><code>IconAndText</code> - displays both icon and text, regardless of the screen size</li> </ul>
					/// </summary>
					public Union<sap.m.ObjectMarkerVisibility, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibility;

					/// <summary>
					/// Sets additional information to the displayed <code>type</code>.
					/// 
					/// <b>Note:</b> If no type is set, the additional information will not be displayed.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> additionalInfo;

					/// <summary>
					/// Event is fired when the <code>ObjectMarker</code> is interactive and the user taps/clicks on it.
					/// </summary>
					public sap.ui.@base.EventDelegate press;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ObjectMarker.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectMarker(string sId, sap.m.ObjectMarker.Settings mSettings);

				/// <summary>
				/// Constructor for a new ObjectMarker.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectMarker(string sId);

				/// <summary>
				/// Constructor for a new ObjectMarker.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectMarker();

				/// <summary>
				/// Constructor for a new ObjectMarker.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectMarker(sap.m.ObjectMarker.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// Sets one of the predefined types.
				/// 
				/// <b>Note</b>: If the <code>visibility</code> property is not specified explicitly, every <code>type</code> comes with predefined one as follows: <ul> <li>For <code>Flagged</code> and <code>Favorite</code> the icon is visible and the text is not displayed</li> <li>For <code>Draft</code> the text is visible and the icon is not displayed</li> <li>For <code>Locked</code>, <code>LockedBy</code>, <code>Unsaved</code> and <code>UnsavedBy</code> - on screens larger than 600px both icon and text are visible, otherwise only the icon</li>
				/// 
				/// </ul>
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.m.ObjectMarkerType getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// Sets one of the predefined types.
				/// 
				/// <b>Note</b>: If the <code>visibility</code> property is not specified explicitly, every <code>type</code> comes with predefined one as follows: <ul> <li>For <code>Flagged</code> and <code>Favorite</code> the icon is visible and the text is not displayed</li> <li>For <code>Draft</code> the text is visible and the icon is not displayed</li> <li>For <code>Locked</code>, <code>LockedBy</code>, <code>Unsaved</code> and <code>UnsavedBy</code> - on screens larger than 600px both icon and text are visible, otherwise only the icon</li>
				/// 
				/// </ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectMarker setType(sap.m.ObjectMarkerType sType);

				#endregion

				#region Methods for Property visibility

				/// <summary>
				/// Gets current value of property {@link #getVisibility visibility}.
				/// 
				/// Sets one of the visibility states. Visibility states are as follows: <ul> <li><code>IconOnly</code> - displays only icon, regardless of the screen size</li> <li><code>TextOnly</code> - displays only text, regardless of the screen size</li> <li><code>IconAndText</code> - displays both icon and text, regardless of the screen size</li> </ul>
				/// </summary>
				/// <returns>Value of property <code>visibility</code></returns>
				public extern virtual sap.m.ObjectMarkerVisibility getVisibility();

				/// <summary>
				/// Sets a new value for property {@link #getVisibility visibility}.
				/// 
				/// Sets one of the visibility states. Visibility states are as follows: <ul> <li><code>IconOnly</code> - displays only icon, regardless of the screen size</li> <li><code>TextOnly</code> - displays only text, regardless of the screen size</li> <li><code>IconAndText</code> - displays both icon and text, regardless of the screen size</li> </ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sVisibility">New value for property <code>visibility</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectMarker setVisibility(sap.m.ObjectMarkerVisibility sVisibility);

				#endregion

				#region Methods for Property additionalInfo

				/// <summary>
				/// Gets current value of property {@link #getAdditionalInfo additionalInfo}.
				/// 
				/// Sets additional information to the displayed <code>type</code>.
				/// 
				/// <b>Note:</b> If no type is set, the additional information will not be displayed.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>additionalInfo</code></returns>
				public extern virtual string getAdditionalInfo();

				/// <summary>
				/// Sets a new value for property {@link #getAdditionalInfo additionalInfo}.
				/// 
				/// Sets additional information to the displayed <code>type</code>.
				/// 
				/// <b>Note:</b> If no type is set, the additional information will not be displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sAdditionalInfo">New value for property <code>additionalInfo</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectMarker setAdditionalInfo(string sAdditionalInfo);

				#endregion

				#region Methods for Aggregation _innerControl

				#endregion

				#region Methods for Event press

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ObjectMarker</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectMarker</code> itself.
				/// 
				/// Event is fired when the <code>ObjectMarker</code> is interactive and the user taps/clicks on it.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectMarker</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectMarker attachPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ObjectMarker</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectMarker</code> itself.
				/// 
				/// Event is fired when the <code>ObjectMarker</code> is interactive and the user taps/clicks on it.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectMarker attachPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ObjectMarker</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectMarker</code> itself.
				/// 
				/// Event is fired when the <code>ObjectMarker</code> is interactive and the user taps/clicks on it.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectMarker attachPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ObjectMarker</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectMarker</code> itself.
				/// 
				/// Event is fired when the <code>ObjectMarker</code> is interactive and the user taps/clicks on it.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectMarker</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectMarker attachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.m.ObjectMarker</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectMarker detachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectMarker firePress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectMarker firePress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectMarker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectMarker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectMarker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ObjectMarker.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
