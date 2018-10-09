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
			/// The <code>ObjectAttribute</code> control displays a text field that can be normal or active. The <code>ObjectAttribute</code> fires a <code>press</code> event when the user chooses the active text.
			/// 
			/// <b>Note:</b> If property <code>active</code> is set to <code>true</code>, only the value of the <code>text</code> property is styled and acts as a link. In this case the <code>text</code> property must also be set, as otherwise there will be no link displayed for the user.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ObjectAttribute")]
			public partial class ObjectAttribute : sap.ui.core.Control
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
					/// Defines the ObjectAttribute title.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Defines the ObjectAttribute text.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Indicates if the <code>ObjectAttribute</code> text is selectable for the user.
					/// 
					/// <b>Note:</b> As of version 1.48, only the value of the <code>text</code> property becomes active (styled and acts like a link) as opposed to both the <code>title</code> and <code>text</code> in the previous versions. If you set this property to <code>true</code>, you have to also set the <code>text</code> property.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> active;

					/// <summary>
					/// Determines the direction of the text, not including the title. Available options for the text direction are LTR (left-to-right) and RTL (right-to-left). By default the control inherits the text direction from its parent control.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

					/// <summary>
					/// When the aggregation is set, it replaces the text, active and textDirection properties. This also ignores the press event. The provided control is displayed as an active link. <b>Note:</b> It will only allow sap.m.Text and sap.m.Link controls.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> customContent;

					/// <summary>
					/// Fires when the user clicks on active text.
					/// </summary>
					public sap.m.ObjectPressDelegate press;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectAttribute</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectAttribute(string sId, sap.m.ObjectAttribute.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectAttribute</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectAttribute(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectAttribute</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectAttribute();

				/// <summary>
				/// Constructor for a new <code>ObjectAttribute</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectAttribute(sap.m.ObjectAttribute.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Defines the ObjectAttribute title.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Defines the ObjectAttribute title.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute setTitle(string sTitle);

				#endregion

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Defines the ObjectAttribute text.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// Defines the ObjectAttribute text.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute setText(string sText);

				#endregion

				#region Methods for Property active

				/// <summary>
				/// Gets current value of property {@link #getActive active}.
				/// 
				/// Indicates if the <code>ObjectAttribute</code> text is selectable for the user.
				/// 
				/// <b>Note:</b> As of version 1.48, only the value of the <code>text</code> property becomes active (styled and acts like a link) as opposed to both the <code>title</code> and <code>text</code> in the previous versions. If you set this property to <code>true</code>, you have to also set the <code>text</code> property.
				/// </summary>
				/// <returns>Value of property <code>active</code></returns>
				public extern virtual bool getActive();

				/// <summary>
				/// Sets a new value for property {@link #getActive active}.
				/// 
				/// Indicates if the <code>ObjectAttribute</code> text is selectable for the user.
				/// 
				/// <b>Note:</b> As of version 1.48, only the value of the <code>text</code> property becomes active (styled and acts like a link) as opposed to both the <code>title</code> and <code>text</code> in the previous versions. If you set this property to <code>true</code>, you have to also set the <code>text</code> property.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bActive">New value for property <code>active</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute setActive(bool bActive);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Determines the direction of the text, not including the title. Available options for the text direction are LTR (left-to-right) and RTL (right-to-left). By default the control inherits the text direction from its parent control.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Determines the direction of the text, not including the title. Available options for the text direction are LTR (left-to-right) and RTL (right-to-left). By default the control inherits the text direction from its parent control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Aggregation customContent

				/// <summary>
				/// Gets content of aggregation {@link #getCustomContent customContent}.
				/// 
				/// When the aggregation is set, it replaces the text, active and textDirection properties. This also ignores the press event. The provided control is displayed as an active link. <b>Note:</b> It will only allow sap.m.Text and sap.m.Link controls.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getCustomContent();

				/// <summary>
				/// Destroys the customContent in the aggregation {@link #getCustomContent customContent}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute destroyCustomContent();

				/// <summary>
				/// Sets the aggregated {@link #getCustomContent customContent}.
				/// </summary>
				/// <param name="oCustomContent">The customContent to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute setCustomContent(sap.ui.core.Control oCustomContent);

				#endregion

				#region Methods for Aggregation _textControl

				#endregion

				#region Methods for Event press

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ObjectAttribute</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectAttribute</code> itself.
				/// 
				/// Fires when the user clicks on active text.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectAttribute</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute attachPress(object oData, sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ObjectAttribute</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectAttribute</code> itself.
				/// 
				/// Fires when the user clicks on active text.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute attachPress(object oData, sap.m.ObjectPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ObjectAttribute</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectAttribute</code> itself.
				/// 
				/// Fires when the user clicks on active text.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute attachPress(sap.m.ObjectPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ObjectAttribute</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ObjectAttribute</code> itself.
				/// 
				/// Fires when the user clicks on active text.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ObjectAttribute</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute attachPress(sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.m.ObjectAttribute</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute detachPress(sap.m.ObjectPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute firePress(sap.m.ObjectPressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ObjectAttribute firePress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectAttribute with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectAttribute with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ObjectAttribute with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ObjectAttribute.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Defines to which DOM reference the Popup should be docked.
				/// </summary>
				/// <returns>The DOM reference that Popup should dock to</returns>
				public extern virtual dom.HTMLElement getPopupAnchorDomRef();

				#endregion

				#endregion

			}
		}
	}
}
