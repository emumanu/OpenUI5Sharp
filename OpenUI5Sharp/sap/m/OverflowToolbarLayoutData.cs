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
			/// Holds layout data for the {@link sap.m.OverflowToolbar} items.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.OverflowToolbarLayoutData")]
			public partial class OverflowToolbarLayoutData : sap.m.ToolbarLayoutData
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ToolbarLayoutData.Settings
				{
					/// <summary>
					/// The OverflowToolbar item can or cannot move to the overflow area
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> moveToOverflow;

					/// <summary>
					/// The OverflowToolbar item can or cannot stay in the overflow area
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> stayInOverflow;

					/// <summary>
					/// Defines OverflowToolbar items priority, Available priorities ate NeverOverflow, High, Low, Disappear and AlwaysOverflow
					/// </summary>
					public Union<sap.m.OverflowToolbarPriority, string, sap.ui.@base.ManagedObject.BindPropertyInfo> priority;

					/// <summary>
					/// Defines OverflowToolbar items group number. Default value is 0, which means that the control does not belong to any group. Elements that belong to a group overflow together. The overall priority of the group is defined by the element with highest priority. Elements that belong to a group are not allowed to have AlwaysOverflow or NeverOverflow priority.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> group;

					/// <summary>
					/// Defines whether the overflow area is automatically closed when interacting with a control in it
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> closeOverflowOnInteraction;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>OverflowToolbarLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new element, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern OverflowToolbarLayoutData(string sId, sap.m.OverflowToolbarLayoutData.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>OverflowToolbarLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new element, generated automatically if no ID is given</param>
				public extern OverflowToolbarLayoutData(string sId);

				/// <summary>
				/// Constructor for a new <code>OverflowToolbarLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern OverflowToolbarLayoutData();

				/// <summary>
				/// Constructor for a new <code>OverflowToolbarLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern OverflowToolbarLayoutData(sap.m.OverflowToolbarLayoutData.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property moveToOverflow

				/// <summary>
				/// Gets current value of property {@link #getMoveToOverflow moveToOverflow}.
				/// 
				/// The OverflowToolbar item can or cannot move to the overflow area
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>moveToOverflow</code></returns>
				[Obsolete("Deprecated since 1.32.")]
				public extern virtual bool getMoveToOverflow();

				/// <summary>
				/// Sets a new value for property {@link #getMoveToOverflow moveToOverflow}.
				/// 
				/// The OverflowToolbar item can or cannot move to the overflow area
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bMoveToOverflow">New value for property <code>moveToOverflow</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.32.")]
				public extern virtual sap.m.OverflowToolbarLayoutData setMoveToOverflow(bool bMoveToOverflow);

				#endregion

				#region Methods for Property stayInOverflow

				/// <summary>
				/// Gets current value of property {@link #getStayInOverflow stayInOverflow}.
				/// 
				/// The OverflowToolbar item can or cannot stay in the overflow area
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>stayInOverflow</code></returns>
				[Obsolete("Deprecated since 1.32.")]
				public extern virtual bool getStayInOverflow();

				/// <summary>
				/// Sets a new value for property {@link #getStayInOverflow stayInOverflow}.
				/// 
				/// The OverflowToolbar item can or cannot stay in the overflow area
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bStayInOverflow">New value for property <code>stayInOverflow</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.32.")]
				public extern virtual sap.m.OverflowToolbarLayoutData setStayInOverflow(bool bStayInOverflow);

				#endregion

				#region Methods for Property priority

				/// <summary>
				/// Gets current value of property {@link #getPriority priority}.
				/// 
				/// Defines OverflowToolbar items priority, Available priorities ate NeverOverflow, High, Low, Disappear and AlwaysOverflow
				/// 
				/// Default value is <code>High</code>.
				/// </summary>
				/// <returns>Value of property <code>priority</code></returns>
				public extern virtual sap.m.OverflowToolbarPriority getPriority();

				/// <summary>
				/// Sets a new value for property {@link #getPriority priority}.
				/// 
				/// Defines OverflowToolbar items priority, Available priorities ate NeverOverflow, High, Low, Disappear and AlwaysOverflow
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>High</code>.
				/// </summary>
				/// <param name="sPriority">New value for property <code>priority</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.OverflowToolbarLayoutData setPriority(sap.m.OverflowToolbarPriority sPriority);

				#endregion

				#region Methods for Property group

				/// <summary>
				/// Gets current value of property {@link #getGroup group}.
				/// 
				/// Defines OverflowToolbar items group number. Default value is 0, which means that the control does not belong to any group. Elements that belong to a group overflow together. The overall priority of the group is defined by the element with highest priority. Elements that belong to a group are not allowed to have AlwaysOverflow or NeverOverflow priority.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>group</code></returns>
				public extern virtual int getGroup();

				/// <summary>
				/// Sets a new value for property {@link #getGroup group}.
				/// 
				/// Defines OverflowToolbar items group number. Default value is 0, which means that the control does not belong to any group. Elements that belong to a group overflow together. The overall priority of the group is defined by the element with highest priority. Elements that belong to a group are not allowed to have AlwaysOverflow or NeverOverflow priority.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="iGroup">New value for property <code>group</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.OverflowToolbarLayoutData setGroup(int iGroup);

				#endregion

				#region Methods for Property closeOverflowOnInteraction

				/// <summary>
				/// Gets current value of property {@link #getCloseOverflowOnInteraction closeOverflowOnInteraction}.
				/// 
				/// Defines whether the overflow area is automatically closed when interacting with a control in it
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>closeOverflowOnInteraction</code></returns>
				public extern virtual bool getCloseOverflowOnInteraction();

				/// <summary>
				/// Sets a new value for property {@link #getCloseOverflowOnInteraction closeOverflowOnInteraction}.
				/// 
				/// Defines whether the overflow area is automatically closed when interacting with a control in it
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bCloseOverflowOnInteraction">New value for property <code>closeOverflowOnInteraction</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.OverflowToolbarLayoutData setCloseOverflowOnInteraction(bool bCloseOverflowOnInteraction);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.OverflowToolbarLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ToolbarLayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.OverflowToolbarLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ToolbarLayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.OverflowToolbarLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ToolbarLayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.OverflowToolbarLayoutData.
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
