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
				/// A text field with masked characters which borrows its properties and methods from TextField.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.PasswordField")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Input</code> control.")]
				public partial class PasswordField : sap.ui.commons.TextField
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.TextField.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new PasswordField.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern PasswordField(string sId, sap.ui.commons.PasswordField.Settings mSettings);

					/// <summary>
					/// Constructor for a new PasswordField.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern PasswordField(string sId);

					/// <summary>
					/// Constructor for a new PasswordField.
					/// </summary>
					public extern PasswordField();

					/// <summary>
					/// Constructor for a new PasswordField.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern PasswordField(sap.ui.commons.PasswordField.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.PasswordField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.PasswordField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.PasswordField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.PasswordField.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

				}
			}
		}
	}
}
