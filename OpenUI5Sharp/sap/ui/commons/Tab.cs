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
				/// Represents a single tab in a TabStrip control.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Tab")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.TabContainer</code> control.")]
				public partial class Tab : sap.ui.commons.Panel
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.Panel.Settings
					{
						/// <summary>
						/// Specifies the vertical scrolling.
						/// </summary>
						public Union<sap.ui.core.Scrolling, string, sap.ui.@base.ManagedObject.BindPropertyInfo> verticalScrolling;

						/// <summary>
						/// Specifies the horizontal scrolling.
						/// </summary>
						public Union<sap.ui.core.Scrolling, string, sap.ui.@base.ManagedObject.BindPropertyInfo> horizontalScrolling;

						/// <summary>
						/// Specifies whether the tab contains a close button.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> closable;

						/// <summary>
						/// Defines whether the tab is the active one.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selected;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Tab.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Tab(string sId, sap.ui.commons.Tab.Settings mSettings);

					/// <summary>
					/// Constructor for a new Tab.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern Tab(string sId);

					/// <summary>
					/// Constructor for a new Tab.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Tab();

					/// <summary>
					/// Constructor for a new Tab.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Tab(sap.ui.commons.Tab.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property verticalScrolling

					/// <summary>
					/// Gets current value of property {@link #getVerticalScrolling verticalScrolling}.
					/// 
					/// Specifies the vertical scrolling.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>verticalScrolling</code></returns>
					public extern virtual sap.ui.core.Scrolling getVerticalScrolling();

					/// <summary>
					/// Sets a new value for property {@link #getVerticalScrolling verticalScrolling}.
					/// 
					/// Specifies the vertical scrolling.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sVerticalScrolling">New value for property <code>verticalScrolling</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tab setVerticalScrolling(sap.ui.core.Scrolling sVerticalScrolling);

					#endregion

					#region Methods for Property horizontalScrolling

					/// <summary>
					/// Gets current value of property {@link #getHorizontalScrolling horizontalScrolling}.
					/// 
					/// Specifies the horizontal scrolling.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>horizontalScrolling</code></returns>
					public extern virtual sap.ui.core.Scrolling getHorizontalScrolling();

					/// <summary>
					/// Sets a new value for property {@link #getHorizontalScrolling horizontalScrolling}.
					/// 
					/// Specifies the horizontal scrolling.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sHorizontalScrolling">New value for property <code>horizontalScrolling</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tab setHorizontalScrolling(sap.ui.core.Scrolling sHorizontalScrolling);

					#endregion

					#region Methods for Property closable

					/// <summary>
					/// Gets current value of property {@link #getClosable closable}.
					/// 
					/// Specifies whether the tab contains a close button.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>closable</code></returns>
					public extern virtual bool getClosable();

					/// <summary>
					/// Sets a new value for property {@link #getClosable closable}.
					/// 
					/// Specifies whether the tab contains a close button.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bClosable">New value for property <code>closable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tab setClosable(bool bClosable);

					#endregion

					#region Methods for Property selected

					/// <summary>
					/// Gets current value of property {@link #getSelected selected}.
					/// 
					/// Defines whether the tab is the active one.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>selected</code></returns>
					[Obsolete("Deprecated since 0.17.0. This property is not used. To identify the selected tab in a TabStrip selectedIndex is used.")]
					public extern virtual bool getSelected();

					/// <summary>
					/// Sets a new value for property {@link #getSelected selected}.
					/// 
					/// Defines whether the tab is the active one.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bSelected">New value for property <code>selected</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 0.17.0. This property is not used. To identify the selected tab in a TabStrip selectedIndex is used.")]
					public extern virtual sap.ui.commons.Tab setSelected(bool bSelected);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Tab with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Panel.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Tab with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Panel.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Tab with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Panel.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Tab.
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
