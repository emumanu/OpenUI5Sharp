using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				public static partial class tmpl
				{
					/// <summary>
					/// The class for Handlebars Templates.
					/// </summary>
					[External]
					[Namespace(false)]
					public abstract partial class HandlebarsTemplate : sap.ui.core.tmpl.Template
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.tmpl.Template.Settings
						{
						}

						#endregion

						#region Constructor

						/// <summary>
						/// Creates and initializes a new handlebars template with the given <code>sId</code> and settings.
						/// 
						/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there.
						/// </summary>
						/// <param name="sId">optional id for the new template; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
						/// <param name="mSettings">optional map/JSON-object with initial settings for the new component instance</param>
						public extern HandlebarsTemplate(string sId, sap.ui.core.tmpl.HandlebarsTemplate.Settings mSettings);

						/// <summary>
						/// Creates and initializes a new handlebars template with the given <code>sId</code> and settings.
						/// 
						/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there.
						/// </summary>
						/// <param name="sId">optional id for the new template; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
						public extern HandlebarsTemplate(string sId);

						/// <summary>
						/// Creates and initializes a new handlebars template with the given <code>sId</code> and settings.
						/// 
						/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there.
						/// </summary>
						public extern HandlebarsTemplate();

						/// <summary>
						/// Creates and initializes a new handlebars template with the given <code>sId</code> and settings.
						/// 
						/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there.
						/// </summary>
						/// <param name="mSettings">optional map/JSON-object with initial settings for the new component instance</param>
						public extern HandlebarsTemplate(sap.ui.core.tmpl.HandlebarsTemplate.Settings mSettings);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.HandlebarsTemplate with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.tmpl.Template.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.HandlebarsTemplate with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.tmpl.Template.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.HandlebarsTemplate with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.tmpl.Template.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.tmpl.HandlebarsTemplate.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						#endregion

					}
				}
			}
		}
	}
}
