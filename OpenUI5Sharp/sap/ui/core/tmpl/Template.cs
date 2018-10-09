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
				public static partial class tmpl
				{
					/// <summary>
					/// Base Class for Template.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.tmpl.Template")]
					[Obsolete("Deprecated since 1.56. use XMLView or JSView instead")]
					public abstract partial class Template : sap.ui.@base.ManagedObject
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.@base.ManagedObject.Settings
						{
							/// <summary>
							/// The Template definition as a String.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> content;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Creates and initializes a new template with the given <code>sId</code> and settings.
						/// 
						/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">optional id for the new template; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
						/// <param name="mSettings">optional map/JSON-object with initial settings for the new component instance</param>
						public extern Template(string sId, sap.ui.core.tmpl.Template.Settings mSettings);

						/// <summary>
						/// Creates and initializes a new template with the given <code>sId</code> and settings.
						/// 
						/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">optional id for the new template; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
						public extern Template(string sId);

						/// <summary>
						/// Creates and initializes a new template with the given <code>sId</code> and settings.
						/// 
						/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern Template();

						/// <summary>
						/// Creates and initializes a new template with the given <code>sId</code> and settings.
						/// 
						/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">optional map/JSON-object with initial settings for the new component instance</param>
						public extern Template(sap.ui.core.tmpl.Template.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property content

						/// <summary>
						/// Gets current value of property {@link #getContent content}.
						/// 
						/// The Template definition as a String.
						/// </summary>
						/// <returns>Value of property <code>content</code></returns>
						public extern virtual string getContent();

						/// <summary>
						/// Sets a new value for property {@link #getContent content}.
						/// 
						/// The Template definition as a String.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sContent">New value for property <code>content</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.Template setContent(string sContent);

						#endregion

						#region Other methods

						/// <summary>
						/// Returns the registered template for the given ID, if any.
						/// </summary>
						/// <param name="sId"></param>
						/// <returns>the template for the given ID</returns>
						public extern static sap.ui.core.tmpl.Template byId(string sId);

						/// <summary>
						/// Creates an anonymous TemplateControl for the Template.
						/// </summary>
						/// <param name="sId">the control ID</param>
						/// <param name="oContext">the context for the renderer/templating</param>
						/// <param name="oView"></param>
						/// <returns>the created control instance</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl createControl(string sId, object oContext, sap.ui.core.mvc.View oView);

						/// <summary>
						/// Declares a new control based on this template and returns the created class / constructor function. The class is based on the information coming from the abstract functions <code>createMetadata</code> and <code>createRenderer</code>.
						/// </summary>
						/// <param name="sControl">the fully qualified name of the control</param>
						/// <returns>the created class / constructor function</returns>
						public extern virtual object declareControl(string sControl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.Template with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.Template with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.Template with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						public extern virtual void getInterface();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.tmpl.Template.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// parses the given path and extracts the model and path
						/// </summary>
						/// <param name="sPath">the path</param>
						/// <returns>the model and the path</returns>
						public extern static object parsePath(string sPath);

						/// <summary>
						/// Creates an anonymous TemplateControl for the Template and places the control into the specified DOM element.
						/// </summary>
						/// <param name="oRef">the id or the DOM reference where to render the template</param>
						/// <param name="oContext">The context to use to evaluate the Template. It will be applied as value for the context property of the created control.</param>
						/// <param name="vPosition">Describes the position where the control should be put into the container</param>
						/// <param name="bInline"></param>
						/// <returns>the created control instance</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl placeAt(Union<string, dom.HTMLElement> oRef, object oContext, Union<string, int> vPosition, bool bInline);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
