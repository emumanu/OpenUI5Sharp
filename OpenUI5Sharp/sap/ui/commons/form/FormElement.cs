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
					/// A form element is a combination of one label and different controls associated to this label.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.form.FormElement")]
					[Obsolete("Deprecated since 1.16.0. moved to sap.ui.layout library. Please use this one.")]
					public partial class FormElement : sap.ui.layout.form.FormElement
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.layout.form.FormElement.Settings
						{
						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new form/FormElement.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern FormElement(string sId, sap.ui.commons.form.FormElement.Settings mSettings);

						/// <summary>
						/// Constructor for a new form/FormElement.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern FormElement(string sId);

						/// <summary>
						/// Constructor for a new form/FormElement.
						/// </summary>
						public extern FormElement();

						/// <summary>
						/// Constructor for a new form/FormElement.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern FormElement(sap.ui.commons.form.FormElement.Settings mSettings);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.FormElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormElement.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.FormElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormElement.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.FormElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormElement.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.form.FormElement.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Getter for property <code>visible</code>. Invisible FormElements are not rendered.
						/// 
						/// Default value is <code>true</code>
						/// </summary>
						/// <returns>the value of property <code>visible</code></returns>
						public extern override bool getVisible();

						/// <summary>
						/// Setter for property <code>visible</code>.
						/// 
						/// Default value is <code>true</code>
						/// </summary>
						/// <param name="bVisible">new value for property <code>visible</code></param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.commons.form.FormElement setVisible(bool bVisible);

						#endregion

					}
				}
			}
		}
	}
}
