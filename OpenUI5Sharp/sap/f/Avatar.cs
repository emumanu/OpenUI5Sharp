using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class f
		{
			/// <summary>
			/// An image-like control that has different display options for representing images, initials, and icons.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>Avatar</code> control allows the usage of different content, shapes, and sizes depending on the use case.
			/// 
			/// The content types that can be displayed are either images, icons, or initials. The shape can be circular or square. There are several predefined sizes, as well as an option to set a custom size.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// Up to two Latin letters can be displayed as initials in an <code>Avatar</code>. If there are more than two letters, or if there's a non-Latin character present, a default image placeholder will be created.
			/// 
			/// There are two options for how the displayed image can fit inside the available area: <ul> <li>Cover - the image is scaled to cover all of the available area</li> <li>Contain - the image is scaled as large as possible while both its height and width fit inside the avalable area</li> </ul> <b>Note:</b> To set a custom size for the <code>Avatar</code>, you have to choose the <code>Custom</code> value for the <code>displaySize</code> property. Then, you have to set both the <code>customDisplaySize</code> and <code>customFontSize</code> properties.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.f.Avatar")]
			public partial class Avatar : sap.ui.core.Control
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
					/// Determines the path to the desired image or icon.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> src;

					/// <summary>
					/// Defines the displayed initials.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> initials;

					/// <summary>
					/// Defines the shape of the <code>Avatar</code>.
					/// </summary>
					public Union<sap.f.AvatarShape, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayShape;

					/// <summary>
					/// Sets a predefined display size of the <code>Avatar</code>.
					/// </summary>
					public Union<sap.f.AvatarSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displaySize;

					/// <summary>
					/// Specifies custom display size of the <code>Avatar</code>.
					/// 
					/// <b>Note:</b> It takes effect if the <code>displaySize</code> property is set to <code>Custom</code>.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customDisplaySize;

					/// <summary>
					/// Specifies custom font size of the <code>Avatar</code>.
					/// 
					/// <b>Note:</b> It takes effect if the <code>displaySize</code> property is set to <code>Custom</code>.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customFontSize;

					/// <summary>
					/// Specifies how an image would fit in the <code>Avatar</code>.
					/// </summary>
					public Union<sap.f.AvatarImageFitType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> imageFitType;

					/// <summary>
					/// A <code>sap.m.LightBox</code> instance, that will be opened automatically when the user interacts with the <code>Avatar</code> control.
					/// 
					/// The <code>press</code> event will still be fired.
					/// </summary>
					public Union<sap.m.LightBox, string, sap.ui.@base.ManagedObject.BindAggregationInfo> detailBox;

					/// <summary>
					/// Fired when the user selects the control.
					/// </summary>
					public sap.ui.@base.EventDelegate press;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>Avatar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Avatar(string sId, sap.f.Avatar.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>Avatar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Avatar(string sId);

				/// <summary>
				/// Constructor for a new <code>Avatar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Avatar();

				/// <summary>
				/// Constructor for a new <code>Avatar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Avatar(sap.f.Avatar.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property src

				/// <summary>
				/// Gets current value of property {@link #getSrc src}.
				/// 
				/// Determines the path to the desired image or icon.
				/// </summary>
				/// <returns>Value of property <code>src</code></returns>
				public extern virtual sap.ui.core.URI getSrc();

				/// <summary>
				/// Sets a new value for property {@link #getSrc src}.
				/// 
				/// Determines the path to the desired image or icon.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sSrc">New value for property <code>src</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar setSrc(sap.ui.core.URI sSrc);

				#endregion

				#region Methods for Property initials

				/// <summary>
				/// Gets current value of property {@link #getInitials initials}.
				/// 
				/// Defines the displayed initials.
				/// </summary>
				/// <returns>Value of property <code>initials</code></returns>
				public extern virtual string getInitials();

				/// <summary>
				/// Sets a new value for property {@link #getInitials initials}.
				/// 
				/// Defines the displayed initials.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sInitials">New value for property <code>initials</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar setInitials(string sInitials);

				#endregion

				#region Methods for Property displayShape

				/// <summary>
				/// Gets current value of property {@link #getDisplayShape displayShape}.
				/// 
				/// Defines the shape of the <code>Avatar</code>.
				/// 
				/// Default value is <code>Circle</code>.
				/// </summary>
				/// <returns>Value of property <code>displayShape</code></returns>
				public extern virtual sap.f.AvatarShape getDisplayShape();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayShape displayShape}.
				/// 
				/// Defines the shape of the <code>Avatar</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Circle</code>.
				/// </summary>
				/// <param name="sDisplayShape">New value for property <code>displayShape</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar setDisplayShape(sap.f.AvatarShape sDisplayShape);

				#endregion

				#region Methods for Property displaySize

				/// <summary>
				/// Gets current value of property {@link #getDisplaySize displaySize}.
				/// 
				/// Sets a predefined display size of the <code>Avatar</code>.
				/// 
				/// Default value is <code>S</code>.
				/// </summary>
				/// <returns>Value of property <code>displaySize</code></returns>
				public extern virtual sap.f.AvatarSize getDisplaySize();

				/// <summary>
				/// Sets a new value for property {@link #getDisplaySize displaySize}.
				/// 
				/// Sets a predefined display size of the <code>Avatar</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>S</code>.
				/// </summary>
				/// <param name="sDisplaySize">New value for property <code>displaySize</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar setDisplaySize(sap.f.AvatarSize sDisplaySize);

				#endregion

				#region Methods for Property customDisplaySize

				/// <summary>
				/// Gets current value of property {@link #getCustomDisplaySize customDisplaySize}.
				/// 
				/// Specifies custom display size of the <code>Avatar</code>.
				/// 
				/// <b>Note:</b> It takes effect if the <code>displaySize</code> property is set to <code>Custom</code>.
				/// 
				/// Default value is <code>3rem</code>.
				/// </summary>
				/// <returns>Value of property <code>customDisplaySize</code></returns>
				public extern virtual sap.ui.core.CSSSize getCustomDisplaySize();

				/// <summary>
				/// Sets a new value for property {@link #getCustomDisplaySize customDisplaySize}.
				/// 
				/// Specifies custom display size of the <code>Avatar</code>.
				/// 
				/// <b>Note:</b> It takes effect if the <code>displaySize</code> property is set to <code>Custom</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>3rem</code>.
				/// </summary>
				/// <param name="sCustomDisplaySize">New value for property <code>customDisplaySize</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar setCustomDisplaySize(sap.ui.core.CSSSize sCustomDisplaySize);

				#endregion

				#region Methods for Property customFontSize

				/// <summary>
				/// Gets current value of property {@link #getCustomFontSize customFontSize}.
				/// 
				/// Specifies custom font size of the <code>Avatar</code>.
				/// 
				/// <b>Note:</b> It takes effect if the <code>displaySize</code> property is set to <code>Custom</code>.
				/// 
				/// Default value is <code>1.125rem</code>.
				/// </summary>
				/// <returns>Value of property <code>customFontSize</code></returns>
				public extern virtual sap.ui.core.CSSSize getCustomFontSize();

				/// <summary>
				/// Sets a new value for property {@link #getCustomFontSize customFontSize}.
				/// 
				/// Specifies custom font size of the <code>Avatar</code>.
				/// 
				/// <b>Note:</b> It takes effect if the <code>displaySize</code> property is set to <code>Custom</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1.125rem</code>.
				/// </summary>
				/// <param name="sCustomFontSize">New value for property <code>customFontSize</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar setCustomFontSize(sap.ui.core.CSSSize sCustomFontSize);

				#endregion

				#region Methods for Property imageFitType

				/// <summary>
				/// Gets current value of property {@link #getImageFitType imageFitType}.
				/// 
				/// Specifies how an image would fit in the <code>Avatar</code>.
				/// 
				/// Default value is <code>Cover</code>.
				/// </summary>
				/// <returns>Value of property <code>imageFitType</code></returns>
				public extern virtual sap.f.AvatarImageFitType getImageFitType();

				/// <summary>
				/// Sets a new value for property {@link #getImageFitType imageFitType}.
				/// 
				/// Specifies how an image would fit in the <code>Avatar</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Cover</code>.
				/// </summary>
				/// <param name="sImageFitType">New value for property <code>imageFitType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar setImageFitType(sap.f.AvatarImageFitType sImageFitType);

				#endregion

				#region Methods for Aggregation detailBox

				/// <summary>
				/// Gets content of aggregation {@link #getDetailBox detailBox}.
				/// 
				/// A <code>sap.m.LightBox</code> instance, that will be opened automatically when the user interacts with the <code>Avatar</code> control.
				/// 
				/// The <code>press</code> event will still be fired.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.LightBox getDetailBox();

				/// <summary>
				/// Destroys the detailBox in the aggregation {@link #getDetailBox detailBox}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar destroyDetailBox();

				/// <summary>
				/// Sets the <code>detailBox</code> aggregation.
				/// </summary>
				/// <param name="oLightBox">Instance of the <code>LightBox</code> control or undefined</param>
				/// <returns><code>this</code> for chaining</returns>
				public extern virtual object setDetailBox(sap.m.LightBox oLightBox);

				/// <summary>
				/// Binds aggregation {@link #getDetailBox detailBox} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar bindDetailBox(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getDetailBox detailBox} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar unbindDetailBox();

				#endregion

				#region Methods for Event press

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.f.Avatar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.Avatar</code> itself.
				/// 
				/// Fired when the user selects the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.Avatar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar attachPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.f.Avatar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.Avatar</code> itself.
				/// 
				/// Fired when the user selects the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar attachPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.f.Avatar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.Avatar</code> itself.
				/// 
				/// Fired when the user selects the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar attachPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.f.Avatar</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.Avatar</code> itself.
				/// 
				/// Fired when the user selects the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.Avatar</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar attachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.f.Avatar</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar detachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar firePress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.Avatar firePress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.f.Avatar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.f.Avatar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.f.Avatar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <returns>The <code>sap.f.Avatar</code> accessibility information</returns>
				public extern virtual object getAccessibilityInfo();

				/// <summary>
				/// Returns a metadata object for class sap.f.Avatar.
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
