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
			/// The ObjectIdentifier is a display control that enables the user to easily identify a specific object. The ObjectIdentifier title is the key identifier of the object and additional text and icons can be used to further distinguish it from other objects.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ObjectIdentifier")]
			public partial class ObjectIdentifier : sap.ui.core.Control
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
					/// Defines the object title.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Defines the object text.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Indicates whether or not the notes icon is displayed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> badgeNotes;

					/// <summary>
					/// Indicates whether or not the address book icon is displayed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> badgePeople;

					/// <summary>
					/// Indicates whether or not the attachments icon is displayed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> badgeAttachments;

					/// <summary>
					/// Indicates if the ObjectIdentifier is visible. An invisible ObjectIdentifier is not being rendered.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					/// <summary>
					/// Indicates if the ObjectIdentifier's title is clickable.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleActive;

					/// <summary>
					/// Specifies the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

					/// <summary>
					/// Association to controls / IDs, which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Fires when the title is active and the user taps/clicks on it.
					/// </summary>
					public sap.m.ObjectHeaderPressDelegate titlePress;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ObjectIdentifier.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectIdentifier(string sId, sap.m.ObjectIdentifier.Settings mSettings);

				/// <summary>
				/// Constructor for a new ObjectIdentifier.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectIdentifier(string sId);

				/// <summary>
				/// Constructor for a new ObjectIdentifier.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectIdentifier();

				/// <summary>
				/// Constructor for a new ObjectIdentifier.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectIdentifier(sap.m.ObjectIdentifier.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Defines the object title.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets the title. Default value is empty/undefined.
				/// </summary>
				/// <param name="sTitle">New value for property title</param>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier setTitle(string sTitle);

				#endregion

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Defines the object text.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets text. Default value is empty/undefined.
				/// </summary>
				/// <param name="sText">New value for property text</param>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier setText(string sText);

				#endregion

				#region Methods for Property badgeNotes

				/// <summary>
				/// Gets current value of property {@link #getBadgeNotes badgeNotes}.
				/// 
				/// Indicates whether or not the notes icon is displayed.
				/// </summary>
				/// <returns>Value of property <code>badgeNotes</code></returns>
				[Obsolete("Deprecated since 1.24.0. There is no replacement for the moment.")]
				public extern virtual bool getBadgeNotes();

				/// <summary>
				/// Sets a new value for property {@link #getBadgeNotes badgeNotes}.
				/// 
				/// Indicates whether or not the notes icon is displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bBadgeNotes">New value for property <code>badgeNotes</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.24.0. There is no replacement for the moment.")]
				public extern virtual sap.m.ObjectIdentifier setBadgeNotes(bool bBadgeNotes);

				#endregion

				#region Methods for Property badgePeople

				/// <summary>
				/// Gets current value of property {@link #getBadgePeople badgePeople}.
				/// 
				/// Indicates whether or not the address book icon is displayed.
				/// </summary>
				/// <returns>Value of property <code>badgePeople</code></returns>
				[Obsolete("Deprecated since 1.24.0. There is no replacement for the moment.")]
				public extern virtual bool getBadgePeople();

				/// <summary>
				/// Sets a new value for property {@link #getBadgePeople badgePeople}.
				/// 
				/// Indicates whether or not the address book icon is displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bBadgePeople">New value for property <code>badgePeople</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.24.0. There is no replacement for the moment.")]
				public extern virtual sap.m.ObjectIdentifier setBadgePeople(bool bBadgePeople);

				#endregion

				#region Methods for Property badgeAttachments

				/// <summary>
				/// Gets current value of property {@link #getBadgeAttachments badgeAttachments}.
				/// 
				/// Indicates whether or not the attachments icon is displayed.
				/// </summary>
				/// <returns>Value of property <code>badgeAttachments</code></returns>
				[Obsolete("Deprecated since 1.24.0. There is no replacement for the moment.")]
				public extern virtual bool getBadgeAttachments();

				/// <summary>
				/// Sets a new value for property {@link #getBadgeAttachments badgeAttachments}.
				/// 
				/// Indicates whether or not the attachments icon is displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bBadgeAttachments">New value for property <code>badgeAttachments</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.24.0. There is no replacement for the moment.")]
				public extern virtual sap.m.ObjectIdentifier setBadgeAttachments(bool bBadgeAttachments);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Indicates if the ObjectIdentifier is visible. An invisible ObjectIdentifier is not being rendered.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern override bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Indicates if the ObjectIdentifier is visible. An invisible ObjectIdentifier is not being rendered.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier setVisible(bool bVisible);

				#endregion

				#region Methods for Property titleActive

				/// <summary>
				/// Gets current value of property {@link #getTitleActive titleActive}.
				/// 
				/// Indicates if the ObjectIdentifier's title is clickable.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>titleActive</code></returns>
				public extern virtual bool getTitleActive();

				/// <summary>
				/// Sets property titleActive. Default value is false.
				/// </summary>
				/// <param name="bValue">new value for property titleActive</param>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier setTitleActive(bool bValue);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Specifies the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Specifies the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Aggregation _titleControl

				#endregion

				#region Methods for Aggregation _textControl

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
				public extern virtual sap.m.ObjectIdentifier addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event titlePress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titlePress titlePress} event of this <code>sap.m.ObjectIdentifier</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectIdentifier</code> itself.
				/// 
				/// Fires when the title is active and the user taps/clicks on it.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectIdentifier</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier attachTitlePress(object oData, sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titlePress titlePress} event of this <code>sap.m.ObjectIdentifier</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectIdentifier</code> itself.
				/// 
				/// Fires when the title is active and the user taps/clicks on it.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier attachTitlePress(object oData, sap.m.ObjectHeaderPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titlePress titlePress} event of this <code>sap.m.ObjectIdentifier</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectIdentifier</code> itself.
				/// 
				/// Fires when the title is active and the user taps/clicks on it.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier attachTitlePress(sap.m.ObjectHeaderPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:titlePress titlePress} event of this <code>sap.m.ObjectIdentifier</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectIdentifier</code> itself.
				/// 
				/// Fires when the title is active and the user taps/clicks on it.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectIdentifier</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier attachTitlePress(sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:titlePress titlePress} event of this <code>sap.m.ObjectIdentifier</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier detachTitlePress(sap.m.ObjectHeaderPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:titlePress titlePress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier fireTitlePress(sap.m.ObjectHeaderPressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:titlePress titlePress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectIdentifier fireTitlePress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectIdentifier with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectIdentifier with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectIdentifier with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ObjectIdentifier.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
