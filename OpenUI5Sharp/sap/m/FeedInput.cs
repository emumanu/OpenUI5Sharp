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
			/// The Feed Input allows the user to enter text for a new feed entry and then post it.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.FeedInput")]
			public partial class FeedInput : sap.ui.core.Control
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
					/// Set this flag to "false" to disable both text input and post button.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

					/// <summary>
					/// The maximum length (the maximum number of characters) for the feed input's value. By default this is not limited.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxLength;

					/// <summary>
					/// The placeholder text shown in the input area as long as the user has not entered any text value.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> placeholder;

					/// <summary>
					/// The text value of the feed input. As long as the user has not entered any text the post button is disabled
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

					/// <summary>
					/// Icon to be displayed as a graphical element within the feed input. This can be an image or an icon from the icon font.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// If set to "true" (default), icons will be displayed. In case no icon is provided the standard placeholder will be displayed. if set to "false" icons are hidden
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showIcon;

					/// <summary>
					/// Some mobile devices support higher resolution images while others do not. Therefore, you should provide image resources for all relevant densities. If the property is set to "true", one or more requests are sent to the server to try and get the perfect density version of an image. If an image of a certain density is not available, the image control falls back to the default image, which should be provided.
					/// 
					/// If you do not have higher resolution images, you should set the property to "false" to avoid unnecessary round-trips.
					/// 
					/// Please be aware that this property is relevant only for images and not for icons.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconDensityAware;

					/// <summary>
					/// Sets a new tooltip for Submit button. The tooltip can either be a simple string (which in most cases will be rendered as the title attribute of this element) or an instance of sap.ui.core.TooltipBase. If a new tooltip is set, any previously set tooltip is deactivated. The default value is set language dependent.
					/// </summary>
					public Union<sap.ui.core.TooltipBase, string, sap.ui.@base.ManagedObject.BindPropertyInfo> buttonTooltip;

					/// <summary>
					/// Text for Picture which will be read by screenreader. If a new ariaLabelForPicture is set, any previously set ariaLabelForPicture is deactivated.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelForPicture;

					/// <summary>
					/// The Post event is triggered when the user has entered a value and pressed the post button. After firing this event, the value is reset.
					/// </summary>
					public sap.m.ValueDelegate post;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new FeedInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern FeedInput(string sId, sap.m.FeedInput.Settings mSettings);

				/// <summary>
				/// Constructor for a new FeedInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern FeedInput(string sId);

				/// <summary>
				/// Constructor for a new FeedInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern FeedInput();

				/// <summary>
				/// Constructor for a new FeedInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern FeedInput(sap.m.FeedInput.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Set this flag to "false" to disable both text input and post button.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Set this flag to "false" to disable both text input and post button.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property maxLength

				/// <summary>
				/// Gets current value of property {@link #getMaxLength maxLength}.
				/// 
				/// The maximum length (the maximum number of characters) for the feed input's value. By default this is not limited.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>maxLength</code></returns>
				public extern virtual int getMaxLength();

				/// <summary>
				/// Sets a new value for property {@link #getMaxLength maxLength}.
				/// 
				/// The maximum length (the maximum number of characters) for the feed input's value. By default this is not limited.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="iMaxLength">New value for property <code>maxLength</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput setMaxLength(int iMaxLength);

				#endregion

				#region Methods for Property placeholder

				/// <summary>
				/// Gets current value of property {@link #getPlaceholder placeholder}.
				/// 
				/// The placeholder text shown in the input area as long as the user has not entered any text value.
				/// 
				/// Default value is <code>Post something here</code>.
				/// </summary>
				/// <returns>Value of property <code>placeholder</code></returns>
				public extern virtual string getPlaceholder();

				/// <summary>
				/// Sets a new value for property {@link #getPlaceholder placeholder}.
				/// 
				/// The placeholder text shown in the input area as long as the user has not entered any text value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Post something here</code>.
				/// </summary>
				/// <param name="sPlaceholder">New value for property <code>placeholder</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput setPlaceholder(string sPlaceholder);

				#endregion

				#region Methods for Property value

				/// <summary>
				/// Gets current value of property {@link #getValue value}.
				/// 
				/// The text value of the feed input. As long as the user has not entered any text the post button is disabled
				/// </summary>
				/// <returns>Value of property <code>value</code></returns>
				public extern virtual string getValue();

				/// <summary>
				/// Sets a new value for property {@link #getValue value}.
				/// 
				/// The text value of the feed input. As long as the user has not entered any text the post button is disabled
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValue">New value for property <code>value</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput setValue(string sValue);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Icon to be displayed as a graphical element within the feed input. This can be an image or an icon from the icon font.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Icon to be displayed as a graphical element within the feed input. This can be an image or an icon from the icon font.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property showIcon

				/// <summary>
				/// Gets current value of property {@link #getShowIcon showIcon}.
				/// 
				/// If set to "true" (default), icons will be displayed. In case no icon is provided the standard placeholder will be displayed. if set to "false" icons are hidden
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showIcon</code></returns>
				public extern virtual bool getShowIcon();

				/// <summary>
				/// Sets a new value for property {@link #getShowIcon showIcon}.
				/// 
				/// If set to "true" (default), icons will be displayed. In case no icon is provided the standard placeholder will be displayed. if set to "false" icons are hidden
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowIcon">New value for property <code>showIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput setShowIcon(bool bShowIcon);

				#endregion

				#region Methods for Property iconDensityAware

				/// <summary>
				/// Gets current value of property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// Some mobile devices support higher resolution images while others do not. Therefore, you should provide image resources for all relevant densities. If the property is set to "true", one or more requests are sent to the server to try and get the perfect density version of an image. If an image of a certain density is not available, the image control falls back to the default image, which should be provided.
				/// 
				/// If you do not have higher resolution images, you should set the property to "false" to avoid unnecessary round-trips.
				/// 
				/// Please be aware that this property is relevant only for images and not for icons.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>iconDensityAware</code></returns>
				public extern virtual bool getIconDensityAware();

				/// <summary>
				/// Sets a new value for property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// Some mobile devices support higher resolution images while others do not. Therefore, you should provide image resources for all relevant densities. If the property is set to "true", one or more requests are sent to the server to try and get the perfect density version of an image. If an image of a certain density is not available, the image control falls back to the default image, which should be provided.
				/// 
				/// If you do not have higher resolution images, you should set the property to "false" to avoid unnecessary round-trips.
				/// 
				/// Please be aware that this property is relevant only for images and not for icons.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIconDensityAware">New value for property <code>iconDensityAware</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput setIconDensityAware(bool bIconDensityAware);

				#endregion

				#region Methods for Property buttonTooltip

				/// <summary>
				/// Gets current value of property {@link #getButtonTooltip buttonTooltip}.
				/// 
				/// Sets a new tooltip for Submit button. The tooltip can either be a simple string (which in most cases will be rendered as the title attribute of this element) or an instance of sap.ui.core.TooltipBase. If a new tooltip is set, any previously set tooltip is deactivated. The default value is set language dependent.
				/// 
				/// Default value is <code>Submit</code>.
				/// </summary>
				/// <returns>Value of property <code>buttonTooltip</code></returns>
				public extern virtual sap.ui.core.TooltipBase getButtonTooltip();

				/// <summary>
				/// Sets a new value for property {@link #getButtonTooltip buttonTooltip}.
				/// 
				/// Sets a new tooltip for Submit button. The tooltip can either be a simple string (which in most cases will be rendered as the title attribute of this element) or an instance of sap.ui.core.TooltipBase. If a new tooltip is set, any previously set tooltip is deactivated. The default value is set language dependent.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Submit</code>.
				/// </summary>
				/// <param name="sButtonTooltip">New value for property <code>buttonTooltip</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput setButtonTooltip(sap.ui.core.TooltipBase sButtonTooltip);

				#endregion

				#region Methods for Property ariaLabelForPicture

				/// <summary>
				/// Gets current value of property {@link #getAriaLabelForPicture ariaLabelForPicture}.
				/// 
				/// Text for Picture which will be read by screenreader. If a new ariaLabelForPicture is set, any previously set ariaLabelForPicture is deactivated.
				/// </summary>
				/// <returns>Value of property <code>ariaLabelForPicture</code></returns>
				public extern virtual string getAriaLabelForPicture();

				/// <summary>
				/// Sets a new value for property {@link #getAriaLabelForPicture ariaLabelForPicture}.
				/// 
				/// Text for Picture which will be read by screenreader. If a new ariaLabelForPicture is set, any previously set ariaLabelForPicture is deactivated.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sAriaLabelForPicture">New value for property <code>ariaLabelForPicture</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput setAriaLabelForPicture(string sAriaLabelForPicture);

				#endregion

				#region Methods for Event post

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:post post} event of this <code>sap.m.FeedInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedInput</code> itself.
				/// 
				/// The Post event is triggered when the user has entered a value and pressed the post button. After firing this event, the value is reset.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FeedInput</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput attachPost(object oData, sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:post post} event of this <code>sap.m.FeedInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedInput</code> itself.
				/// 
				/// The Post event is triggered when the user has entered a value and pressed the post button. After firing this event, the value is reset.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput attachPost(object oData, sap.m.ValueDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:post post} event of this <code>sap.m.FeedInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedInput</code> itself.
				/// 
				/// The Post event is triggered when the user has entered a value and pressed the post button. After firing this event, the value is reset.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput attachPost(sap.m.ValueDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:post post} event of this <code>sap.m.FeedInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedInput</code> itself.
				/// 
				/// The Post event is triggered when the user has entered a value and pressed the post button. After firing this event, the value is reset.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FeedInput</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput attachPost(sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:post post} event of this <code>sap.m.FeedInput</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput detachPost(sap.m.ValueDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:post post} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput firePost(sap.m.ValueInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:post post} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedInput firePost();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.FeedInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.FeedInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.FeedInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.FeedInput.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
