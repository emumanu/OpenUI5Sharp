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
					/// A View defined using JSON.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.mvc.JSONView")]
					public partial class JSONView : sap.ui.core.mvc.View
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

						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class CreateOptions
						{
							/// <summary>
							/// Specifies an ID for the View instance. If no ID is given, an ID will be generated.
							/// </summary>
							public string id;

							/// <summary>
							/// The view name that corresponds to a JSON module that can be loaded via the module system (viewName + suffix ".view.json").
							/// </summary>
							public string viewName;

							/// <summary>
							/// view definition as a JSON string or an object literal
							/// </summary>
							public Union<string, object> definition;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new mvc/JSONView.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern JSONView(string sId, sap.ui.core.mvc.JSONView.Settings mSettings);

						/// <summary>
						/// Constructor for a new mvc/JSONView.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern JSONView(string sId);

						/// <summary>
						/// Constructor for a new mvc/JSONView.
						/// </summary>
						public extern JSONView();

						/// <summary>
						/// Constructor for a new mvc/JSONView.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern JSONView(sap.ui.core.mvc.JSONView.Settings mSettings);

						#endregion

						#region Fields

						/// <summary>
						/// Flag for feature detection of asynchronous loading/rendering
						/// </summary>
						public static object asyncSupport;

						#endregion

						#region Methods

						/// <summary>
						/// Creates a JSON view of the given configuration.
						/// </summary>
						/// <param name="mOptions">A map containing the view configuration options.</param>
						/// <returns>a Promise which resolves with the created JSONView instance.</returns>
						public extern static jquery.JQueryPromise<object> create(Map mOptions);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.JSONView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.JSONView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.JSONView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.mvc.JSONView.
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
