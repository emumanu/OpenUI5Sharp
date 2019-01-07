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
					/// A view defined/constructed by declarative HTML.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.mvc.HTMLView")]
					public partial class HTMLView : sap.ui.core.mvc.View
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
							/// Name of the view resource in module name notation (without suffix)
							/// </summary>
							public string viewName;

							/// <summary>
							/// The view definition.
							/// </summary>
							public string definition;

							/// <summary>
							/// Controller instance to be used for this view. The given controller instance overrides the controller defined in the view definition. Sharing a controller instance between multiple views is not supported.
							/// </summary>
							public sap.ui.core.mvc.Controller controller;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new mvc/HTMLView.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern HTMLView(string sId, sap.ui.core.mvc.HTMLView.Settings mSettings);

						/// <summary>
						/// Constructor for a new mvc/HTMLView.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern HTMLView(string sId);

						/// <summary>
						/// Constructor for a new mvc/HTMLView.
						/// </summary>
						public extern HTMLView();

						/// <summary>
						/// Constructor for a new mvc/HTMLView.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern HTMLView(sap.ui.core.mvc.HTMLView.Settings mSettings);

						#endregion

						#region Fields

						/// <summary>
						/// Flag for feature detection of asynchronous loading/rendering
						/// </summary>
						public static object asyncSupport;

						#endregion

						#region Methods

						/// <summary>
						/// Creates an instance of a declarative HTML view.
						/// </summary>
						/// <param name="mOptions">A map containig the view configuration options.</param>
						/// <returns>A Promise which resolves with the created HTMLView instance</returns>
						public extern static es5.Promise<object> create(Map mOptions);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.HTMLView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.HTMLView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.HTMLView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.mvc.HTMLView.
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
