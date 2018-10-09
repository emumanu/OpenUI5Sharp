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
			/// Type for <code>groupItems</code> aggregation in P13nGroupPanel control.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.P13nGroupItem")]
			public partial class P13nGroupItem : sap.ui.core.Item
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Item.Settings
				{
					/// <summary>
					/// sap.m.P13nConditionOperation
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> operation;

					/// <summary>
					/// key of the column
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnKey;

					/// <summary>
					/// make the grouped column as normalcolumn visible
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showIfGrouped;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nGroupItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nGroupItem(string sId, sap.m.P13nGroupItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nGroupItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nGroupItem(string sId);

				/// <summary>
				/// Constructor for a new P13nGroupItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nGroupItem();

				/// <summary>
				/// Constructor for a new P13nGroupItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nGroupItem(sap.m.P13nGroupItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property operation

				/// <summary>
				/// Gets current value of property {@link #getOperation operation}.
				/// 
				/// sap.m.P13nConditionOperation
				/// </summary>
				/// <returns>Value of property <code>operation</code></returns>
				public extern virtual string getOperation();

				/// <summary>
				/// Sets a new value for property {@link #getOperation operation}.
				/// 
				/// sap.m.P13nConditionOperation
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sOperation">New value for property <code>operation</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupItem setOperation(string sOperation);

				#endregion

				#region Methods for Property columnKey

				/// <summary>
				/// Gets current value of property {@link #getColumnKey columnKey}.
				/// 
				/// key of the column
				/// </summary>
				/// <returns>Value of property <code>columnKey</code></returns>
				public extern virtual string getColumnKey();

				/// <summary>
				/// Sets a new value for property {@link #getColumnKey columnKey}.
				/// 
				/// key of the column
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sColumnKey">New value for property <code>columnKey</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupItem setColumnKey(string sColumnKey);

				#endregion

				#region Methods for Property showIfGrouped

				/// <summary>
				/// Gets current value of property {@link #getShowIfGrouped showIfGrouped}.
				/// 
				/// make the grouped column as normalcolumn visible
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showIfGrouped</code></returns>
				public extern virtual bool getShowIfGrouped();

				/// <summary>
				/// Sets a new value for property {@link #getShowIfGrouped showIfGrouped}.
				/// 
				/// make the grouped column as normalcolumn visible
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowIfGrouped">New value for property <code>showIfGrouped</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nGroupItem setShowIfGrouped(bool bShowIfGrouped);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nGroupItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nGroupItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nGroupItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nGroupItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
