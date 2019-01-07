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
			public static partial class table
			{
				/// <summary>
				/// The column menu provides all common actions that can be performed on a column.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.ColumnMenu")]
				public partial class ColumnMenu : sap.ui.unified.Menu
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
					/// Constructor for a new ColumnMenu.
					/// 
					/// <b>Note:</b> Applications must not use or change the default <code>sap.ui.table.ColumnMenu</code> of a column in any way or create own instances of <code>sap.ui.table.ColumnMenu</code>. To add a custom menu to a column, use the aggregation <code>menu</code> with a new instance of <code>sap.ui.unified.Menu</code>.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ColumnMenu(string sId, sap.ui.table.ColumnMenu.Settings mSettings);

					/// <summary>
					/// Constructor for a new ColumnMenu.
					/// 
					/// <b>Note:</b> Applications must not use or change the default <code>sap.ui.table.ColumnMenu</code> of a column in any way or create own instances of <code>sap.ui.table.ColumnMenu</code>. To add a custom menu to a column, use the aggregation <code>menu</code> with a new instance of <code>sap.ui.unified.Menu</code>.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ColumnMenu(string sId);

					/// <summary>
					/// Constructor for a new ColumnMenu.
					/// 
					/// <b>Note:</b> Applications must not use or change the default <code>sap.ui.table.ColumnMenu</code> of a column in any way or create own instances of <code>sap.ui.table.ColumnMenu</code>. To add a custom menu to a column, use the aggregation <code>menu</code> with a new instance of <code>sap.ui.unified.Menu</code>.
					/// </summary>
					public extern ColumnMenu();

					/// <summary>
					/// Constructor for a new ColumnMenu.
					/// 
					/// <b>Note:</b> Applications must not use or change the default <code>sap.ui.table.ColumnMenu</code> of a column in any way or create own instances of <code>sap.ui.table.ColumnMenu</code>. To add a custom menu to a column, use the aggregation <code>menu</code> with a new instance of <code>sap.ui.unified.Menu</code>.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ColumnMenu(sap.ui.table.ColumnMenu.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.ColumnMenu with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.Menu.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.ColumnMenu with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.Menu.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.ColumnMenu with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.Menu.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.table.ColumnMenu.
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
