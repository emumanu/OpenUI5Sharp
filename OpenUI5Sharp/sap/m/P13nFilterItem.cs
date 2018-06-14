using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// Type for <code>filterItems</code> aggregation in P13nFilterPanel control.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class P13nFilterItem : sap.ui.core.Item
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
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> operation;

					/// <summary>
					/// value of the filter
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> value1;

					/// <summary>
					/// to value of the between filter
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> value2;

					/// <summary>
					/// key of the column
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> columnKey;

					/// <summary>
					/// defines if the filter is an include or exclude filter item
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> exclude;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nFilterItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nFilterItem(string sId, sap.m.P13nFilterItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nFilterItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nFilterItem(string sId);

				/// <summary>
				/// Constructor for a new P13nFilterItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nFilterItem();

				/// <summary>
				/// Constructor for a new P13nFilterItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nFilterItem(sap.m.P13nFilterItem.Settings mSettings);

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
				public extern virtual sap.m.P13nFilterItem setOperation(string sOperation);

				#endregion

				#region Methods for Property value1

				/// <summary>
				/// Gets current value of property {@link #getValue1 value1}.
				/// 
				/// value of the filter
				/// </summary>
				/// <returns>Value of property <code>value1</code></returns>
				public extern virtual string getValue1();

				/// <summary>
				/// Sets a new value for property {@link #getValue1 value1}.
				/// 
				/// value of the filter
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValue1">New value for property <code>value1</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterItem setValue1(string sValue1);

				#endregion

				#region Methods for Property value2

				/// <summary>
				/// Gets current value of property {@link #getValue2 value2}.
				/// 
				/// to value of the between filter
				/// </summary>
				/// <returns>Value of property <code>value2</code></returns>
				public extern virtual string getValue2();

				/// <summary>
				/// Sets a new value for property {@link #getValue2 value2}.
				/// 
				/// to value of the between filter
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValue2">New value for property <code>value2</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterItem setValue2(string sValue2);

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
				public extern virtual sap.m.P13nFilterItem setColumnKey(string sColumnKey);

				#endregion

				#region Methods for Property exclude

				/// <summary>
				/// Gets current value of property {@link #getExclude exclude}.
				/// 
				/// defines if the filter is an include or exclude filter item
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>exclude</code></returns>
				public extern virtual bool getExclude();

				/// <summary>
				/// Sets a new value for property {@link #getExclude exclude}.
				/// 
				/// defines if the filter is an include or exclude filter item
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bExclude">New value for property <code>exclude</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nFilterItem setExclude(bool bExclude);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nFilterItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nFilterItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nFilterItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nFilterItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
