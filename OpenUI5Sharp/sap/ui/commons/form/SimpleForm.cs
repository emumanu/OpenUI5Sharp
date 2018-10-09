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
				public static partial class form
				{
					/// <summary>
					/// Use the SimpleForm to create a form based on title, label and fields that are stacked in the content aggregation. Add Title to start a new FormContainer(Group). Add Label to start a new row in the container. Add Input/Display controls as needed. Use LayoutData to influence the layout for special cases in the Input/Display controls.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.form.SimpleForm")]
					[Obsolete("Deprecated since 1.16.0. moved to sap.ui.layout library. Please use this one.")]
					public partial class SimpleForm : sap.ui.layout.form.SimpleForm
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.layout.form.SimpleForm.Settings
						{
						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new form/SimpleForm.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern SimpleForm(string sId, sap.ui.commons.form.SimpleForm.Settings mSettings);

						/// <summary>
						/// Constructor for a new form/SimpleForm.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern SimpleForm(string sId);

						/// <summary>
						/// Constructor for a new form/SimpleForm.
						/// </summary>
						public extern SimpleForm();

						/// <summary>
						/// Constructor for a new form/SimpleForm.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern SimpleForm(sap.ui.commons.form.SimpleForm.Settings mSettings);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.SimpleForm with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.SimpleForm.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.SimpleForm with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.SimpleForm.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.SimpleForm with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.SimpleForm.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Getter for property <code>layout</code>. The FormLayout that is used to render the SimpleForm
						/// 
						/// Default value is <code>ResponsiveLayout</code>
						/// </summary>
						/// <returns>the value of property <code>layout</code></returns>
						public extern virtual sap.ui.layout.form.SimpleFormLayout getLayout();

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.form.SimpleForm.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Setter for property <code>layout</code>.
						/// 
						/// Default value is <code>ResponsiveLayout</code>
						/// </summary>
						/// <param name="oLayout">new value for property <code>layout</code></param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.commons.form.SimpleForm setLayout(sap.ui.layout.form.SimpleFormLayout oLayout);

						#endregion

					}
				}
			}
		}
	}
}
