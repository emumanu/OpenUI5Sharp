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
			/// The ActionSelect control provides a list of predefined items that allows end users to choose options and additionally trigger some actions.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ActionSelect")]
			public partial class ActionSelect : sap.m.Select
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.Select.Settings
				{
					/// <summary>
					/// Buttons to be added to the ActionSelect content.
					/// </summary>
					public Union<sap.m.Button, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> buttons;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ActionSelect.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern ActionSelect(string sId, sap.m.ActionSelect.Settings mSettings);

				/// <summary>
				/// Constructor for a new ActionSelect.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern ActionSelect(string sId);

				/// <summary>
				/// Constructor for a new ActionSelect.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ActionSelect();

				/// <summary>
				/// Constructor for a new ActionSelect.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern ActionSelect(sap.m.ActionSelect.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Association buttons

				/// <summary>
				/// Returns array of IDs of the elements which are the current targets of the association {@link #getButtons buttons}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID[] getButtons();

				/// <summary>
				/// Adds some button into the association {@link #getButtons buttons}.
				/// </summary>
				/// <param name="vButton">The buttons to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSelect addButton(Union<sap.ui.core.ID, sap.m.Button> vButton);

				/// <summary>
				/// Button to be removed from the ActionSelect content.
				/// </summary>
				/// <param name="vButton">The button to remove or its index or id.</param>
				/// <returns>The id of the removed button or null.</returns>
				public extern virtual string removeButton(Union<int, string, sap.m.Button> vButton);

				/// <summary>
				/// Remove all buttons from the ActionSelect.
				/// </summary>
				/// <returns>An array with the ids of the removed elements (might be empty).</returns>
				public extern virtual string[] removeAllButtons();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ActionSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Select.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ActionSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Select.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ActionSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Select.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ActionSelect.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				#endregion

				#endregion

			}
		}
	}
}
