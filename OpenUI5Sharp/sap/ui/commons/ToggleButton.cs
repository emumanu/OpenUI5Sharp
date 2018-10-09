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
				/// The ToggleButton Control is a Button that can be toggled between pressed and normal state
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ToggleButton")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.ToggleButton}")]
				public partial class ToggleButton : sap.ui.commons.Button
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.Button.Settings
					{
						/// <summary>
						/// The property is “true” when the control is toggled. The default state of this property is "false".
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> pressed;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ToggleButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ToggleButton(string sId, sap.ui.commons.ToggleButton.Settings mSettings);

					/// <summary>
					/// Constructor for a new ToggleButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ToggleButton(string sId);

					/// <summary>
					/// Constructor for a new ToggleButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ToggleButton();

					/// <summary>
					/// Constructor for a new ToggleButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ToggleButton(sap.ui.commons.ToggleButton.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property pressed

					/// <summary>
					/// Gets current value of property {@link #getPressed pressed}.
					/// 
					/// The property is “true” when the control is toggled. The default state of this property is "false".
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>pressed</code></returns>
					public extern virtual bool getPressed();

					/// <summary>
					/// Sets a new value for property {@link #getPressed pressed}.
					/// 
					/// The property is “true” when the control is toggled. The default state of this property is "false".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bPressed">New value for property <code>pressed</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ToggleButton setPressed(bool bPressed);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ToggleButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Button.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ToggleButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Button.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ToggleButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Button.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <returns>Current accessibility state of the control</returns>
					public extern override object getAccessibilityInfo();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.ToggleButton.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
