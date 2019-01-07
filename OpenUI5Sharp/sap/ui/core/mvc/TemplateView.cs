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
				public static partial class mvc
				{
					/// <summary>
					/// A view defined in a template.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.mvc.TemplateView")]
					[Obsolete("Deprecated since 1.56. use {@link sap.ui.core.mvc.XMLView} in combination with {@link topic:5ee619fc1370463ea674ee04b65ed83b XML Templating} instead")]
					public partial class TemplateView : sap.ui.core.mvc.View
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.mvc.View.Settings
						{
						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new mvc/TemplateView.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern TemplateView(string sId, sap.ui.core.mvc.TemplateView.Settings mSettings);

						/// <summary>
						/// Constructor for a new mvc/TemplateView.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern TemplateView(string sId);

						/// <summary>
						/// Constructor for a new mvc/TemplateView.
						/// </summary>
						public extern TemplateView();

						/// <summary>
						/// Constructor for a new mvc/TemplateView.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern TemplateView(sap.ui.core.mvc.TemplateView.Settings mSettings);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.TemplateView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.TemplateView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.TemplateView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.mvc.TemplateView.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						#endregion

					}
				}
			}
		}
	}
}
