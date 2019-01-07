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
				/// A menu is an interactive element which provides a choice of different actions to the user. These actions (items) can also be organized in submenus. Like other dialog-like controls, the menu is not rendered within the control hierarchy. Instead it can be opened at a specified position via a function call.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Menu")]
				[Obsolete("Deprecated since 1.21.0. replaced by {@link sap.ui.unified.Menu}")]
				public partial class Menu : sap.ui.unified.Menu
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.unified.Menu.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Menu control.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Menu(string sId, sap.ui.commons.Menu.Settings mSettings);

					/// <summary>
					/// Constructor for a new Menu control.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					public extern Menu(string sId);

					/// <summary>
					/// Constructor for a new Menu control.
					/// </summary>
					public extern Menu();

					/// <summary>
					/// Constructor for a new Menu control.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Menu(sap.ui.commons.Menu.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Menu with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.Menu.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Menu with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.Menu.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Menu with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.Menu.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Menu.
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
