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
				public static partial class mvc
				{
					/// <summary>
					/// A View defined/constructed by JavaScript code.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class JSView : sap.ui.core.mvc.View
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
						/// Constructor for a new mvc/JSView.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern JSView(string sId, sap.ui.core.mvc.JSView.Settings mSettings);

						/// <summary>
						/// Constructor for a new mvc/JSView.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern JSView(string sId);

						/// <summary>
						/// Constructor for a new mvc/JSView.
						/// </summary>
						public extern JSView();

						/// <summary>
						/// Constructor for a new mvc/JSView.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern JSView(sap.ui.core.mvc.JSView.Settings mSettings);

						#endregion

						#region Fields

						/// <summary>
						/// Flag for feature detection of asynchronous loading/rendering
						/// </summary>
						public static object asyncSupport;

						#endregion

						#region Methods

						/// <summary>
						/// A method to be implemented by JSViews, returning the View UI. While for declarative View types like XMLView or JSONView the user interface definition is declared in a separate file, JSViews programmatically construct the UI. This happens in the createContent method which every JSView needs to implement. The View implementation can construct the complete UI in this method - or only return the root control and create the rest of the UI lazily later on.
						/// </summary>
						/// <returns>a control or (typically) tree of controls representing the View user interface</returns>
						public extern virtual sap.ui.core.Control createContent();

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.JSView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.JSView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.JSView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// A method to be implemented by JSViews, returning the flag whether to prefix the IDs of controls automatically or not if the controls are created inside the {@link sap.ui.core.mvc.JSView#createContent} function. By default this feature is not activated.
						/// 
						/// You can overwrite this function and return true to activate the automatic prefixing.
						/// </summary>
						/// <returns>true, if the controls IDs should be prefixed automatically</returns>
						public extern virtual bool getAutoPrefixId();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.mvc.JSView.
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
