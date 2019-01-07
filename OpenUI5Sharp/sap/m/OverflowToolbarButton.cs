using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// Represents an {@link sap.m.Button} that shows its text only when in the overflow area of an {@link sap.m.OverflowToolbar}.
			/// 
			/// <b>Note:</b> This control is intended to be used exclusively in the context of the <code>OverflowToolbar</code>, whenever it is required to have buttons that show only an icon in the toolbar, but icon and text in the overflow menu.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.OverflowToolbarButton")]
			public partial class OverflowToolbarButton : sap.m.Button
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.Button.Settings
				{
				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>OverflowToolbarButton</code>.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern OverflowToolbarButton(string sId, sap.m.OverflowToolbarButton.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>OverflowToolbarButton</code>.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern OverflowToolbarButton(string sId);

				/// <summary>
				/// Constructor for a new <code>OverflowToolbarButton</code>.
				/// </summary>
				public extern OverflowToolbarButton();

				/// <summary>
				/// Constructor for a new <code>OverflowToolbarButton</code>.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern OverflowToolbarButton(sap.m.OverflowToolbarButton.Settings mSettings);

				#endregion

				#region Methods

				/// <summary>
				/// Creates a new subclass of class sap.m.OverflowToolbarButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Button.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.OverflowToolbarButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Button.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.OverflowToolbarButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Button.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.OverflowToolbarButton.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				#endregion

			}
		}
	}
}
