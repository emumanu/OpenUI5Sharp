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
			/// Informs the user about an ongoing operation. <h3>Overview</h3> The busy indicator implies that an action is taking place within a single control. You can set the size of the icon, the text, but also define a custom icon to be used instead. <h3>Usage</h3> <h4>When to use</h4> <ul> <li>The user needs to be able to cancel the operation.</li> <li>Only part of the application or a particular control is affected.</li> </ul> <h4>When not to use</h4> <ul> <li>The operation takes less than one second.</li> <li>You need to block the screen and prevent the user from starting another activity. In this case, use the {@link sap.m.BusyDialog busy dialog}.</li> <li>Do not change the mouse cursor to indicate the ongoing operation.</li> <li>Do not show multiple busy indicators at once</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.BusyIndicator")]
			public partial class BusyIndicator : sap.ui.core.Control
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
					/// Defines text to be displayed below the busy indicator. It can be used to inform the user of the current operation.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Options for the text direction are RTL and LTR. Alternatively, the control can inherit the text direction from its parent container.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

					/// <summary>
					/// Icon URL if an icon is used as the busy indicator.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIcon;

					/// <summary>
					/// Defines the rotation speed of the given image. If a .gif is used, the speed has to be set to 0. The unit is in ms. <b>Note:</b> Values are considered valid when greater than or equal to 0. If invalid value is provided the speed defaults to 0.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIconRotationSpeed;

					/// <summary>
					/// If this is set to false, the src image will be loaded directly without attempting to fetch the density perfect image for high density device. By default, this is set to true but then one or more requests are sent to the server, trying to get the density perfect version of the specified image. If bandwidth is the key for the application, set this value to false.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIconDensityAware;

					/// <summary>
					/// Width of the provided icon. By default 44px are used.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIconWidth;

					/// <summary>
					/// Height of the provided icon. By default 44px are used.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIconHeight;

					/// <summary>
					/// Defines the size of the busy indicator. The animation consists of three circles, each of which will be this size. Therefore the total width of the control amounts to three times the given size.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> size;

					/// <summary>
					/// Setting this property will not have any effect on the appearance of the BusyIndicator in versions greater than or equal to 1.32.1
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new BusyIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern BusyIndicator(string sId, sap.m.BusyIndicator.Settings mSettings);

				/// <summary>
				/// Constructor for a new BusyIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern BusyIndicator(string sId);

				/// <summary>
				/// Constructor for a new BusyIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern BusyIndicator();

				/// <summary>
				/// Constructor for a new BusyIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern BusyIndicator(sap.m.BusyIndicator.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Defines text to be displayed below the busy indicator. It can be used to inform the user of the current operation.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// Defines text to be displayed below the busy indicator. It can be used to inform the user of the current operation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyIndicator setText(string sText);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Options for the text direction are RTL and LTR. Alternatively, the control can inherit the text direction from its parent container.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Options for the text direction are RTL and LTR. Alternatively, the control can inherit the text direction from its parent container.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyIndicator setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Property customIcon

				/// <summary>
				/// Gets current value of property {@link #getCustomIcon customIcon}.
				/// 
				/// Icon URL if an icon is used as the busy indicator.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>customIcon</code></returns>
				public extern virtual sap.ui.core.URI getCustomIcon();

				/// <summary>
				/// Sets a new value for property {@link #getCustomIcon customIcon}.
				/// 
				/// Icon URL if an icon is used as the busy indicator.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sCustomIcon">New value for property <code>customIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyIndicator setCustomIcon(sap.ui.core.URI sCustomIcon);

				#endregion

				#region Methods for Property customIconRotationSpeed

				/// <summary>
				/// Gets current value of property {@link #getCustomIconRotationSpeed customIconRotationSpeed}.
				/// 
				/// Defines the rotation speed of the given image. If a .gif is used, the speed has to be set to 0. The unit is in ms. <b>Note:</b> Values are considered valid when greater than or equal to 0. If invalid value is provided the speed defaults to 0.
				/// 
				/// Default value is <code>1000</code>.
				/// </summary>
				/// <returns>Value of property <code>customIconRotationSpeed</code></returns>
				public extern virtual int getCustomIconRotationSpeed();

				/// <summary>
				/// Sets a new value for property {@link #getCustomIconRotationSpeed customIconRotationSpeed}.
				/// 
				/// Defines the rotation speed of the given image. If a .gif is used, the speed has to be set to 0. The unit is in ms. <b>Note:</b> Values are considered valid when greater than or equal to 0. If invalid value is provided the speed defaults to 0.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1000</code>.
				/// </summary>
				/// <param name="iCustomIconRotationSpeed">New value for property <code>customIconRotationSpeed</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyIndicator setCustomIconRotationSpeed(int iCustomIconRotationSpeed);

				#endregion

				#region Methods for Property customIconDensityAware

				/// <summary>
				/// Gets current value of property {@link #getCustomIconDensityAware customIconDensityAware}.
				/// 
				/// If this is set to false, the src image will be loaded directly without attempting to fetch the density perfect image for high density device. By default, this is set to true but then one or more requests are sent to the server, trying to get the density perfect version of the specified image. If bandwidth is the key for the application, set this value to false.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>customIconDensityAware</code></returns>
				public extern virtual bool getCustomIconDensityAware();

				/// <summary>
				/// Sets a new value for property {@link #getCustomIconDensityAware customIconDensityAware}.
				/// 
				/// If this is set to false, the src image will be loaded directly without attempting to fetch the density perfect image for high density device. By default, this is set to true but then one or more requests are sent to the server, trying to get the density perfect version of the specified image. If bandwidth is the key for the application, set this value to false.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bCustomIconDensityAware">New value for property <code>customIconDensityAware</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyIndicator setCustomIconDensityAware(bool bCustomIconDensityAware);

				#endregion

				#region Methods for Property customIconWidth

				/// <summary>
				/// Gets current value of property {@link #getCustomIconWidth customIconWidth}.
				/// 
				/// Width of the provided icon. By default 44px are used.
				/// 
				/// Default value is <code>44px</code>.
				/// </summary>
				/// <returns>Value of property <code>customIconWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getCustomIconWidth();

				/// <summary>
				/// Sets a new value for property {@link #getCustomIconWidth customIconWidth}.
				/// 
				/// Width of the provided icon. By default 44px are used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>44px</code>.
				/// </summary>
				/// <param name="sCustomIconWidth">New value for property <code>customIconWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyIndicator setCustomIconWidth(sap.ui.core.CSSSize sCustomIconWidth);

				#endregion

				#region Methods for Property customIconHeight

				/// <summary>
				/// Gets current value of property {@link #getCustomIconHeight customIconHeight}.
				/// 
				/// Height of the provided icon. By default 44px are used.
				/// 
				/// Default value is <code>44px</code>.
				/// </summary>
				/// <returns>Value of property <code>customIconHeight</code></returns>
				public extern virtual sap.ui.core.CSSSize getCustomIconHeight();

				/// <summary>
				/// Sets a new value for property {@link #getCustomIconHeight customIconHeight}.
				/// 
				/// Height of the provided icon. By default 44px are used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>44px</code>.
				/// </summary>
				/// <param name="sCustomIconHeight">New value for property <code>customIconHeight</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyIndicator setCustomIconHeight(sap.ui.core.CSSSize sCustomIconHeight);

				#endregion

				#region Methods for Property size

				/// <summary>
				/// Gets current value of property {@link #getSize size}.
				/// 
				/// Defines the size of the busy indicator. The animation consists of three circles, each of which will be this size. Therefore the total width of the control amounts to three times the given size.
				/// 
				/// Default value is <code>1rem</code>.
				/// </summary>
				/// <returns>Value of property <code>size</code></returns>
				public extern virtual sap.ui.core.CSSSize getSize();

				/// <summary>
				/// Sets a new value for property {@link #getSize size}.
				/// 
				/// Defines the size of the busy indicator. The animation consists of three circles, each of which will be this size. Therefore the total width of the control amounts to three times the given size.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1rem</code>.
				/// </summary>
				/// <param name="sSize">New value for property <code>size</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.BusyIndicator setSize(sap.ui.core.CSSSize sSize);

				#endregion

				#region Methods for Property design

				/// <summary>
				/// Gets current value of property {@link #getDesign design}.
				/// 
				/// Setting this property will not have any effect on the appearance of the BusyIndicator in versions greater than or equal to 1.32.1
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>design</code></returns>
				[Obsolete("Deprecated since 1.32.1.")]
				public extern virtual string getDesign();

				/// <summary>
				/// Sets a new value for property {@link #getDesign design}.
				/// 
				/// Setting this property will not have any effect on the appearance of the BusyIndicator in versions greater than or equal to 1.32.1
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <param name="sDesign">New value for property <code>design</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.32.1.")]
				public extern virtual sap.m.BusyIndicator setDesign(string sDesign);

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
				public extern virtual sap.m.BusyIndicator addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.BusyIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.BusyIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.BusyIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.BusyIndicator.
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
