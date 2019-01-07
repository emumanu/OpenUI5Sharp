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
				/// Special menu item which contains a label and a text field. This menu item is e.g. helpful for filter implementations. The aggregation <code>submenu</code> (inherited from parent class) is not supported for this type of menu item.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.MenuTextFieldItem")]
				[Obsolete("Deprecated since 1.21.0. Please use the control <code>sap.ui.unified.MenuTextFieldItem</code> of the library <code>sap.ui.unified</code> instead.")]
				public partial class MenuTextFieldItem : sap.ui.unified.MenuTextFieldItem
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.unified.MenuTextFieldItem.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new MenuTextFieldItem element.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MenuTextFieldItem(string sId, sap.ui.commons.MenuTextFieldItem.Settings mSettings);

					/// <summary>
					/// Constructor for a new MenuTextFieldItem element.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					public extern MenuTextFieldItem(string sId);

					/// <summary>
					/// Constructor for a new MenuTextFieldItem element.
					/// </summary>
					public extern MenuTextFieldItem();

					/// <summary>
					/// Constructor for a new MenuTextFieldItem element.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MenuTextFieldItem(sap.ui.commons.MenuTextFieldItem.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MenuTextFieldItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.MenuTextFieldItem.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MenuTextFieldItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.MenuTextFieldItem.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MenuTextFieldItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.MenuTextFieldItem.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.MenuTextFieldItem.
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
