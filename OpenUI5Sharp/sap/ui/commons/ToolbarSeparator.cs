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
				/// A small vertical line that is generally added to the tool bar between the items to visually separate them.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ToolbarSeparator")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Toolbar</code> control.")]
				public partial class ToolbarSeparator : sap.ui.core.Element, sap.ui.commons.ToolbarItem
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Element.Settings
					{
						/// <summary>
						/// When set to false, there is no visual indication of separation by a vertical line but by a wider space.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayVisualSeparator;

						/// <summary>
						/// Design of the Separator.
						/// </summary>
						public Union<sap.ui.commons.ToolbarSeparatorDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ToolbarSeparator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ToolbarSeparator(string sId, sap.ui.commons.ToolbarSeparator.Settings mSettings);

					/// <summary>
					/// Constructor for a new ToolbarSeparator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ToolbarSeparator(string sId);

					/// <summary>
					/// Constructor for a new ToolbarSeparator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ToolbarSeparator();

					/// <summary>
					/// Constructor for a new ToolbarSeparator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ToolbarSeparator(sap.ui.commons.ToolbarSeparator.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property displayVisualSeparator

					/// <summary>
					/// Gets current value of property {@link #getDisplayVisualSeparator displayVisualSeparator}.
					/// 
					/// When set to false, there is no visual indication of separation by a vertical line but by a wider space.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>displayVisualSeparator</code></returns>
					public extern virtual bool getDisplayVisualSeparator();

					/// <summary>
					/// Sets a new value for property {@link #getDisplayVisualSeparator displayVisualSeparator}.
					/// 
					/// When set to false, there is no visual indication of separation by a vertical line but by a wider space.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bDisplayVisualSeparator">New value for property <code>displayVisualSeparator</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ToolbarSeparator setDisplayVisualSeparator(bool bDisplayVisualSeparator);

					#endregion

					#region Methods for Property design

					/// <summary>
					/// Gets current value of property {@link #getDesign design}.
					/// 
					/// Design of the Separator.
					/// </summary>
					/// <returns>Value of property <code>design</code></returns>
					public extern virtual sap.ui.commons.ToolbarSeparatorDesign getDesign();

					/// <summary>
					/// Sets a new value for property {@link #getDesign design}.
					/// 
					/// Design of the Separator.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sDesign">New value for property <code>design</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ToolbarSeparator setDesign(sap.ui.commons.ToolbarSeparatorDesign sDesign);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ToolbarSeparator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ToolbarSeparator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ToolbarSeparator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.ToolbarSeparator.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
