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
			public static partial class layout
			{
				public static partial class form
				{
					/// <summary>
					/// Base layout to render a <code>Form</code>. Other layouts to render a <code>Form</code> must inherit from this one.
					/// 
					/// <b>Note:</b> This control must not be used to render a <code>Form</code> in productive applications as it does not fulfill any design guidelines and usability standards.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.layout.form.FormLayout")]
					public partial class FormLayout : sap.ui.core.Control
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
							/// Specifies the background color of the <code>Form</code> content.
							/// 
							/// <b>Note:</b> The visualization of the different options depends on the theme used.
							/// </summary>
							public Union<sap.ui.layout.BackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern FormLayout(string sId, sap.ui.layout.form.FormLayout.Settings mSettings);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern FormLayout(string sId);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern FormLayout();

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern FormLayout(sap.ui.layout.form.FormLayout.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property backgroundDesign

						/// <summary>
						/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
						/// 
						/// Specifies the background color of the <code>Form</code> content.
						/// 
						/// <b>Note:</b> The visualization of the different options depends on the theme used.
						/// 
						/// Default value is <code>Translucent</code>.
						/// </summary>
						/// <returns>Value of property <code>backgroundDesign</code></returns>
						public extern virtual sap.ui.layout.BackgroundDesign getBackgroundDesign();

						/// <summary>
						/// Sets a new value for property {@link #getBackgroundDesign backgroundDesign}.
						/// 
						/// Specifies the background color of the <code>Form</code> content.
						/// 
						/// <b>Note:</b> The visualization of the different options depends on the theme used.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>Translucent</code>.
						/// </summary>
						/// <param name="sBackgroundDesign">New value for property <code>backgroundDesign</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormLayout setBackgroundDesign(sap.ui.layout.BackgroundDesign sBackgroundDesign);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.FormLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.FormLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.FormLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.layout.form.FormLayout.
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
}
