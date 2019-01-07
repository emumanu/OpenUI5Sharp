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
				/// The <code>RowSettings</code> control allows you to configure a row. You can only use this control in the context of the <code>sap.ui.table.Table</code> control to define row settings.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.RowSettings")]
				public partial class RowSettings : sap.ui.core.Element
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
						/// The highlight state of the rows. If the highlight is set to {@link sap.ui.core.MessageType.None} (default), no highlights are visible.
						/// </summary>
						public Union<sap.ui.core.MessageType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> highlight;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for new RowSettings.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new element, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern RowSettings(string sId, sap.ui.table.RowSettings.Settings mSettings);

					/// <summary>
					/// Constructor for new RowSettings.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new element, generated automatically if no ID is given</param>
					public extern RowSettings(string sId);

					/// <summary>
					/// Constructor for new RowSettings.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern RowSettings();

					/// <summary>
					/// Constructor for new RowSettings.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern RowSettings(sap.ui.table.RowSettings.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property highlight

					/// <summary>
					/// Gets current value of property {@link #getHighlight highlight}.
					/// 
					/// The highlight state of the rows. If the highlight is set to {@link sap.ui.core.MessageType.None} (default), no highlights are visible.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>highlight</code></returns>
					public extern virtual sap.ui.core.MessageType getHighlight();

					/// <summary>
					/// Sets a new value for property {@link #getHighlight highlight}.
					/// 
					/// The highlight state of the rows. If the highlight is set to {@link sap.ui.core.MessageType.None} (default), no highlights are visible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sHighlight">New value for property <code>highlight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.RowSettings setHighlight(sap.ui.core.MessageType sHighlight);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.RowSettings with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.RowSettings with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.RowSettings with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.table.RowSettings.
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
}
