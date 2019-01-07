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
			/// BusyDialog is used to indicate that the system is busy. <h3>Overview</h3> When the busy dialog is displayed, the whole application is blocked. <h3>Structure</h3> The busy dialog can hold several elements, most of which are optional. <ul> <li><code>title</code> - A title for the dialog. By default, there is no title.</li> <li><code>text</code> - A text displayed above the busy animation.</li> <li><code>showCancelButton</code> - An optional Cancel button to stop the execution.</li> <li><code>customIcon</code> - An optional alternative icon to use as a busy animation.</li> </ul> <h3>Usage</h3> <h4>When to use</h4> <ul> <li>The operation lasts more than one second.</li> <li>You want to indicate loading in a page-to-page navigation (lightweight version).</li> <li>Offer a Cancel button if you expect the process to run more than 10 seconds.</li> <li> If you do not show a title or text, use the {@link sap.ui.core.InvisibleText invisible text} control to provide the reason for users with assistive technologies.</li> </ul> <h4>When not to use</h4> <ul> <li>The screen is not supposed to be blocked. Use a {@link sap.m.BusyIndicator} for the specific application part.</li> <li>Do not use the title of the busy dialog. Provide a precise text describing the operation in <code>text</code>.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.BusyDialog")]
			public partial class BusyDialog : sap.ui.core.Control
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
					/// Optional text displayed inside the dialog.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Sets the title of the BusyDialog. The default value is an empty string.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Icon, used from the BusyIndicator. This icon is invisible in iOS platform and it is density aware. You can use the density convention (@2, @1.5, etc.) to provide higher resolution image for higher density screens.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIcon;

					/// <summary>
					/// Defines the rotation speed of the given image. If GIF file is used, the speed has to be set to 0. The value is in milliseconds.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIconRotationSpeed;

					/// <summary>
					/// If this is set to <code>false</code>, the source image will be loaded directly without attempting to fetch the density perfect image for high density devices. By default, this is set to <code>true</code> but then one or more requests are sent trying to get the density perfect version of the image.
					/// 
					/// If bandwidth is the key for the application, set this value to <code>false</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIconDensityAware;

					/// <summary>
					/// Width of the provided icon with default value "44px".
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIconWidth;

					/// <summary>
					/// Height of the provided icon with default value "44px".
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIconHeight;

					/// <summary>
					/// The text of the cancel button. The default text is "Cancel" (translated to the respective language).
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> cancelButtonText;

					/// <summary>
					/// Indicates if the cancel button will be rendered inside the busy dialog. The default value is set to <code>false</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showCancelButton;

					/// <summary>
					/// Association to controls / IDs which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Fires when the busy dialog is closed.
					/// </summary>
					public sap.m.BusyDialog.CloseDelegate close;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class CloseInfo
				{
					/// <summary>
					/// Indicates if the close events are triggered by a user, pressing a cancel button or because the operation was terminated. This parameter is set to true if the close event is fired by user interaction.
					/// </summary>
					public bool cancelPressed;

				}

				#endregion

				#region Delegates

				public delegate void CloseDelegate(sap.ui.@base.Event<sap.m.BusyDialog.CloseInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new BusyDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				/// <param name="mSettings">Initial settings for the new control.</param>
				public extern BusyDialog(string sId, sap.m.BusyDialog.Settings mSettings);

				/// <summary>
				/// Constructor for a new BusyDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				public extern BusyDialog(string sId);

				/// <summary>
				/// Constructor for a new BusyDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern BusyDialog();

				/// <summary>
				/// Constructor for a new BusyDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control.</param>
				public extern BusyDialog(sap.m.BusyDialog.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Optional text displayed inside the dialog.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets the text for the BusyDialog.
				/// </summary>
				/// <param name="sText">The text for the BusyDialog.</param>
				/// <returns>BusyDialog reference for chaining.</returns>
				public extern virtual sap.m.BusyDialog setText(string sText);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Sets the title of the BusyDialog. The default value is an empty string.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets the title for the BusyDialog.
				/// </summary>
				/// <param name="sTitle">The title for the BusyDialog.</param>
				/// <returns>BusyDialog reference for chaining.</returns>
				public extern virtual sap.m.BusyDialog setTitle(string sTitle);

				#endregion

				#region Methods for Property customIcon

				/// <summary>
				/// Gets current value of property {@link #getCustomIcon customIcon}.
				/// 
				/// Icon, used from the BusyIndicator. This icon is invisible in iOS platform and it is density aware. You can use the density convention (@2, @1.5, etc.) to provide higher resolution image for higher density screens.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>customIcon</code></returns>
				public extern virtual sap.ui.core.URI getCustomIcon();

				/// <summary>
				/// Sets custom icon.
				/// </summary>
				/// <param name="sIcon">Icon to use as a busy animation.</param>
				/// <returns>BusyDialog reference for chaining.</returns>
				public extern virtual sap.m.BusyDialog setCustomIcon(string sIcon);

				#endregion

				#region Methods for Property customIconRotationSpeed

				/// <summary>
				/// Gets current value of property {@link #getCustomIconRotationSpeed customIconRotationSpeed}.
				/// 
				/// Defines the rotation speed of the given image. If GIF file is used, the speed has to be set to 0. The value is in milliseconds.
				/// 
				/// Default value is <code>1000</code>.
				/// </summary>
				/// <returns>Value of property <code>customIconRotationSpeed</code></returns>
				public extern virtual int getCustomIconRotationSpeed();

				/// <summary>
				/// Sets the rotation speed of the custom icon.
				/// </summary>
				/// <param name="iSpeed">Defines the rotation speed of the given image.</param>
				/// <returns>BusyDialog reference for chaining.</returns>
				public extern virtual sap.m.BusyDialog setCustomIconRotationSpeed(int iSpeed);

				#endregion

				#region Methods for Property customIconDensityAware

				/// <summary>
				/// Gets current value of property {@link #getCustomIconDensityAware customIconDensityAware}.
				/// 
				/// If this is set to <code>false</code>, the source image will be loaded directly without attempting to fetch the density perfect image for high density devices. By default, this is set to <code>true</code> but then one or more requests are sent trying to get the density perfect version of the image.
				/// 
				/// If bandwidth is the key for the application, set this value to <code>false</code>.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>customIconDensityAware</code></returns>
				public extern virtual bool getCustomIconDensityAware();

				/// <summary>
				/// Sets the density of the custom icon.
				/// </summary>
				/// <param name="bIsDensityAware">Determines if the source image will be loaded directly without attempting to fetch the density for high density devices.</param>
				/// <returns>BusyDialog reference for chaining.</returns>
				public extern virtual sap.m.BusyDialog setCustomIconDensityAware(bool bIsDensityAware);

				#endregion

				#region Methods for Property customIconWidth

				/// <summary>
				/// Gets current value of property {@link #getCustomIconWidth customIconWidth}.
				/// 
				/// Width of the provided icon with default value "44px".
				/// 
				/// Default value is <code>44px</code>.
				/// </summary>
				/// <returns>Value of property <code>customIconWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getCustomIconWidth();

				/// <summary>
				/// Sets the width of the custom icon.
				/// </summary>
				/// <param name="sWidth">Width of the provided icon in CSSSize.</param>
				/// <returns>BusyDialog reference for chaining.</returns>
				public extern virtual sap.m.BusyDialog setCustomIconWidth(string sWidth);

				#endregion

				#region Methods for Property customIconHeight

				/// <summary>
				/// Gets current value of property {@link #getCustomIconHeight customIconHeight}.
				/// 
				/// Height of the provided icon with default value "44px".
				/// 
				/// Default value is <code>44px</code>.
				/// </summary>
				/// <returns>Value of property <code>customIconHeight</code></returns>
				public extern virtual sap.ui.core.CSSSize getCustomIconHeight();

				/// <summary>
				/// Sets the height of the custom icon.
				/// </summary>
				/// <param name="sHeight">Height of the provided icon in CSSSize.</param>
				/// <returns>BusyDialog reference for chaining.</returns>
				public extern virtual sap.m.BusyDialog setCustomIconHeight(string sHeight);

				#endregion

				#region Methods for Property cancelButtonText

				/// <summary>
				/// Gets current value of property {@link #getCancelButtonText cancelButtonText}.
				/// 
				/// The text of the cancel button. The default text is "Cancel" (translated to the respective language).
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>cancelButtonText</code></returns>
				public extern virtual string getCancelButtonText();

				/// <summary>
				/// Shows the text for the cancel button.
				/// </summary>
				/// <param name="sText">Text for the cancel button.</param>
				/// <returns>The modified BusyDialog.</returns>
				public extern virtual sap.m.BusyDialog setCancelButtonText(string sText);

				#endregion

				#region Methods for Property showCancelButton

				/// <summary>
				/// Gets current value of property {@link #getShowCancelButton showCancelButton}.
				/// 
				/// Indicates if the cancel button will be rendered inside the busy dialog. The default value is set to <code>false</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showCancelButton</code></returns>
				public extern virtual bool getShowCancelButton();

				/// <summary>
				/// Shows the cancel button.
				/// </summary>
				/// <param name="bIsCancelButtonShown">Determines if the Cancel button is shown.</param>
				/// <returns>BusyDialog reference for chaining.</returns>
				public extern virtual sap.m.BusyDialog setShowCancelButton(bool bIsCancelButtonShown);

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
				public extern virtual sap.m.BusyDialog addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event close

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.BusyDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.BusyDialog</code> itself.
				/// 
				/// Fires when the busy dialog is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.BusyDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyDialog attachClose(object oData, sap.m.BusyDialog.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.BusyDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.BusyDialog</code> itself.
				/// 
				/// Fires when the busy dialog is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyDialog attachClose(object oData, sap.m.BusyDialog.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.BusyDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.BusyDialog</code> itself.
				/// 
				/// Fires when the busy dialog is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyDialog attachClose(sap.m.BusyDialog.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.BusyDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.BusyDialog</code> itself.
				/// 
				/// Fires when the busy dialog is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.BusyDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyDialog attachClose(sap.m.BusyDialog.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:close close} event of this <code>sap.m.BusyDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyDialog detachClose(sap.m.BusyDialog.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:close close} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyDialog fireClose(sap.m.BusyDialog.CloseInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:close close} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyDialog fireClose();

				#endregion

				#region Other methods

				/// <summary>
				/// Closes the BusyDialog.
				/// </summary>
				/// <param name="isClosedFromUserInteraction">Indicates if the BusyDialog is closed from a user interaction.</param>
				/// <returns>The modified BusyDialog.</returns>
				public extern virtual sap.m.BusyDialog close(bool isClosedFromUserInteraction);

				/// <summary>
				/// Closes the BusyDialog.
				/// </summary>
				/// <returns>The modified BusyDialog.</returns>
				public extern virtual sap.m.BusyDialog close();

				/// <summary>
				/// Creates a new subclass of class sap.m.BusyDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.BusyDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.BusyDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Gets the DOM reference for the BusyDialog.
				/// </summary>
				/// <returns>Dom reference.</returns>
				public extern virtual sap.m.BusyDialog getDomRef();

				/// <summary>
				/// Returns a metadata object for class sap.m.BusyDialog.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Gets the tooltip for the BusyDialog.
				/// </summary>
				/// <returns>BusyDialog reference for chaining.</returns>
				public extern virtual sap.m.BusyDialog getTooltip();

				/// <summary>
				/// Opens the BusyDialog.
				/// </summary>
				/// <returns>BusyDialog reference for chaining.</returns>
				public extern virtual sap.m.BusyDialog open();

				/// <summary>
				/// Sets the tooltip for the BusyDialog.
				/// </summary>
				/// <param name="sTooltip">The tooltip for the BusyDialog.</param>
				/// <returns>BusyDialog reference for chaining.</returns>
				public extern virtual sap.m.BusyDialog setTooltip(string sTooltip);

				#endregion

				#endregion

			}
		}
	}
}
