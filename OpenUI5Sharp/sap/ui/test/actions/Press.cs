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
			public static partial class test
			{
				public static partial class actions
				{
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.actions.Press")]
					public partial class Press : sap.ui.test.actions.Action
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.test.actions.Action.Settings
						{
						}

						#endregion

						#region Constructor

						/// <summary>
						/// The Press action is used to simulate a press interaction on a Control's dom ref. This will work out of the box for most of the controls (even custom controls).
						/// 
						/// Here is a List of supported controls (some controls will trigger the press on a specific region):
						/// 
						/// <ul> <li>sap.m.Button</li> <li>sap.m.Link</li> <li>sap.m.StandardListItem</li> <li>sap.m.IconTabFilter</li> <li>sap.m.Input - Value help</li> <li>sap.m.SearchField - Search Button</li> <li>sap.m.Page - Back Button</li> <li>sap.m.semantic.FullscreenPage - Back Button</li> <li>sap.m.semantic.DetailPage - Back Button</li> <li>sap.m.List - More Button</li> <li>sap.m.Table - More Button</li> <li>sap.m.StandardTile</li> <li>sap.m.ComboBox</li> <li>sap.m.ObjectIdentifier</li> <li>sap.ui.comp.smartfilterbar.SmartFilterBar - Go Button</li> </ul>
						/// </summary>
						public extern Press();

						#endregion

						#region Methods

						/// <summary>
						/// Sets focus on given control and triggers a 'tap' event on it (which is internally translated into a 'press' event). Logs an error if control is not visible (i.e. has no dom representation)
						/// </summary>
						/// <param name="oControl">the control on which the 'press' event is triggered</param>
						public extern virtual void executeOn(sap.ui.core.Control oControl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.actions.Press with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.actions.Action.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.actions.Press with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.actions.Action.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.actions.Press with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.actions.Action.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.test.actions.Press.
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
