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
			/// The <code>sap.m.ComboBoxTextField</code>.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ComboBoxTextField")]
			public partial class ComboBoxTextField : sap.m.InputBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.InputBase.Settings
				{
					/// <summary>
					/// Sets the maximum width of the text field.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxWidth;

					/// <summary>
					/// Indicates whether the dropdown downward-facing arrow button is shown.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showButton;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>sap.m.ComboBoxTextField</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				/// <param name="mSettings">Initial settings for the new control.</param>
				public extern ComboBoxTextField(string sId, sap.m.ComboBoxTextField.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>sap.m.ComboBoxTextField</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
				public extern ComboBoxTextField(string sId);

				/// <summary>
				/// Constructor for a new <code>sap.m.ComboBoxTextField</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ComboBoxTextField();

				/// <summary>
				/// Constructor for a new <code>sap.m.ComboBoxTextField</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control.</param>
				public extern ComboBoxTextField(sap.m.ComboBoxTextField.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property maxWidth

				/// <summary>
				/// Gets current value of property {@link #getMaxWidth maxWidth}.
				/// 
				/// Sets the maximum width of the text field.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>maxWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getMaxWidth();

				/// <summary>
				/// Sets a new value for property {@link #getMaxWidth maxWidth}.
				/// 
				/// Sets the maximum width of the text field.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sMaxWidth">New value for property <code>maxWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBoxTextField setMaxWidth(sap.ui.core.CSSSize sMaxWidth);

				#endregion

				#region Methods for Property showButton

				/// <summary>
				/// Gets current value of property {@link #getShowButton showButton}.
				/// 
				/// Indicates whether the dropdown downward-facing arrow button is shown.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showButton</code></returns>
				public extern virtual bool getShowButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowButton showButton}.
				/// 
				/// Indicates whether the dropdown downward-facing arrow button is shown.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowButton">New value for property <code>showButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ComboBoxTextField setShowButton(bool bShowButton);

				#endregion

				#region Methods for Aggregation _buttonLabelText

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ComboBoxTextField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ComboBoxTextField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ComboBoxTextField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ComboBoxTextField.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Gets the <code>value</code>.
				/// 
				/// Default value is an empty string.
				/// </summary>
				/// <returns>The value of property <code>value</code></returns>
				public extern override string getValue();

				#endregion

				#endregion

			}
		}
	}
}
