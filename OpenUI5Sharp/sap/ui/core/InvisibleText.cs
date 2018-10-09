using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// An InvisibleText is used to bring hidden texts to the UI for screen reader support. The hidden text can e.g. be referenced in the ariaLabelledBy or ariaDescribedBy associations of other controls.
				/// 
				/// The inherited properties busy, busyIndicatorDelay and visible and the aggregation tooltip is not supported by this control.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.InvisibleText")]
				public partial class InvisibleText : sap.ui.core.Control
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
						/// The text of the InvisibleText.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new InvisibleText.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern InvisibleText(string sId, sap.ui.core.InvisibleText.Settings mSettings);

					/// <summary>
					/// Constructor for a new InvisibleText.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern InvisibleText(string sId);

					/// <summary>
					/// Constructor for a new InvisibleText.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern InvisibleText();

					/// <summary>
					/// Constructor for a new InvisibleText.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern InvisibleText(sap.ui.core.InvisibleText.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// The text of the InvisibleText.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// The text of the InvisibleText.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.InvisibleText setText(string sText);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.InvisibleText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.InvisibleText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.InvisibleText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.InvisibleText.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the ID of a shared <code>InvisibleText<code> instance whose <code>text</code> property is retrieved from the given library resource bundle and text key.
					/// 
					/// Calls with the same library and text key will return the same instance. The instance will be rendered statically.
					/// 
					/// When accessibility has been switched off by configuration or when the text key is empty or falsy, no ID will be returned.
					/// </summary>
					/// <param name="sLibrary">Name of the library to load the resource bundle for</param>
					/// <param name="sTextKey">Key of the text to retrieve from the resource bundle</param>
					/// <returns>ID of the shared control</returns>
					public extern static sap.ui.core.ID getStaticId(string sLibrary, string sTextKey);

					/// <summary>
					/// Returns the ID of a shared <code>InvisibleText<code> instance whose <code>text</code> property is retrieved from the given library resource bundle and text key.
					/// 
					/// Calls with the same library and text key will return the same instance. The instance will be rendered statically.
					/// 
					/// When accessibility has been switched off by configuration or when the text key is empty or falsy, no ID will be returned.
					/// </summary>
					/// <param name="sLibrary">Name of the library to load the resource bundle for</param>
					/// <returns>ID of the shared control</returns>
					public extern static sap.ui.core.ID getStaticId(string sLibrary);

					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					[Obsolete("Deprecated since 1.27. local BusyIndicator is not supported by control.")]
					public extern virtual sap.ui.core.InvisibleText setBusy();

					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					[Obsolete("Deprecated since 1.27. local BusyIndicator is not supported by control.")]
					public extern virtual sap.ui.core.InvisibleText setBusyIndicatorDelay();

					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					[Obsolete("Deprecated since 1.54. local BusyIndicator is not supported by control.")]
					public extern virtual sap.ui.core.InvisibleText setBusyIndicatorSize();

					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					[Obsolete("Deprecated since 1.27. tooltip is not supported by control.")]
					public extern virtual sap.ui.core.InvisibleText setTooltip();

					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					[Obsolete("Deprecated since 1.27. property <code>visible</code> is not supported by control.")]
					public extern virtual sap.ui.core.InvisibleText setVisible();

					/// <summary>
					/// Adds <code>this</code> control into the static, hidden area UI area container.
					/// </summary>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.InvisibleText toStatic();

					#endregion

					#endregion

				}
			}
		}
	}
}
