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
			/// Defines layout data for the {@link sap.m.Toolbar} items.
			/// 
			/// <b>Note:</b> <code>ToolbarLayoutData</code> should not be used together with {@link sap.m.ToolbarSpacer}.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ToolbarLayoutData")]
			public partial class ToolbarLayoutData : sap.ui.core.LayoutData
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.LayoutData.Settings
				{
					/// <summary>
					/// Determines whether the control, when in a toolbar, is shrinkable or not. For controls with fixed width (100px, 5rem, etc...) this property is ignored.
					/// 
					/// Note: Nested layout controls should not be shrinkable.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> shrinkable;

					/// <summary>
					/// Sets the minimum width of the toolbar item.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minWidth;

					/// <summary>
					/// Sets the maximum width of the toolbar item.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxWidth;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ToolbarLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ToolbarLayoutData(string sId, sap.m.ToolbarLayoutData.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ToolbarLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ToolbarLayoutData(string sId);

				/// <summary>
				/// Constructor for a new <code>ToolbarLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ToolbarLayoutData();

				/// <summary>
				/// Constructor for a new <code>ToolbarLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ToolbarLayoutData(sap.m.ToolbarLayoutData.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property shrinkable

				/// <summary>
				/// Gets current value of property {@link #getShrinkable shrinkable}.
				/// 
				/// Determines whether the control, when in a toolbar, is shrinkable or not. For controls with fixed width (100px, 5rem, etc...) this property is ignored.
				/// 
				/// Note: Nested layout controls should not be shrinkable.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>shrinkable</code></returns>
				public extern virtual bool getShrinkable();

				/// <summary>
				/// Sets a new value for property {@link #getShrinkable shrinkable}.
				/// 
				/// Determines whether the control, when in a toolbar, is shrinkable or not. For controls with fixed width (100px, 5rem, etc...) this property is ignored.
				/// 
				/// Note: Nested layout controls should not be shrinkable.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShrinkable">New value for property <code>shrinkable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ToolbarLayoutData setShrinkable(bool bShrinkable);

				#endregion

				#region Methods for Property minWidth

				/// <summary>
				/// Gets current value of property {@link #getMinWidth minWidth}.
				/// 
				/// Sets the minimum width of the toolbar item.
				/// </summary>
				/// <returns>Value of property <code>minWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getMinWidth();

				/// <summary>
				/// Sets a new value for property {@link #getMinWidth minWidth}.
				/// 
				/// Sets the minimum width of the toolbar item.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMinWidth">New value for property <code>minWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ToolbarLayoutData setMinWidth(sap.ui.core.CSSSize sMinWidth);

				#endregion

				#region Methods for Property maxWidth

				/// <summary>
				/// Gets current value of property {@link #getMaxWidth maxWidth}.
				/// 
				/// Sets the maximum width of the toolbar item.
				/// </summary>
				/// <returns>Value of property <code>maxWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getMaxWidth();

				/// <summary>
				/// Sets a new value for property {@link #getMaxWidth maxWidth}.
				/// 
				/// Sets the maximum width of the toolbar item.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMaxWidth">New value for property <code>maxWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ToolbarLayoutData setMaxWidth(sap.ui.core.CSSSize sMaxWidth);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ToolbarLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ToolbarLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ToolbarLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ToolbarLayoutData.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
