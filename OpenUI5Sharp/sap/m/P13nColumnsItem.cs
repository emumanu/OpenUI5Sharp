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
			/// Type for <code>columnsItems</code> aggregation in <code>P13nColumnsPanel</code> control.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class P13nColumnsItem : sap.ui.core.Item
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
					/// This property contains the unique table column key
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> columnKey;

					/// <summary>
					/// This property contains the index of a table column
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> index;

					/// <summary>
					/// This property decides whether a <code>P13nColumnsItem</code> is visible
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visible;

					/// <summary>
					/// This property contains the with of a table column.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

					/// <summary>
					/// This property contains the total flag of a table column.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> total;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nColumnsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nColumnsItem(string sId, sap.m.P13nColumnsItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nColumnsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nColumnsItem(string sId);

				/// <summary>
				/// Constructor for a new P13nColumnsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nColumnsItem();

				/// <summary>
				/// Constructor for a new P13nColumnsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nColumnsItem(sap.m.P13nColumnsItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property columnKey

				/// <summary>
				/// Gets current value of property {@link #getColumnKey columnKey}.
				/// 
				/// This property contains the unique table column key
				/// </summary>
				/// <returns>Value of property <code>columnKey</code></returns>
				public extern virtual string getColumnKey();

				/// <summary>
				/// Sets a new value for property {@link #getColumnKey columnKey}.
				/// 
				/// This property contains the unique table column key
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sColumnKey">New value for property <code>columnKey</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsItem setColumnKey(string sColumnKey);

				#endregion

				#region Methods for Property index

				/// <summary>
				/// Gets current value of property {@link #getIndex index}.
				/// 
				/// This property contains the index of a table column
				/// </summary>
				/// <returns>Value of property <code>index</code></returns>
				public extern virtual int getIndex();

				/// <summary>
				/// Sets a new value for property {@link #getIndex index}.
				/// 
				/// This property contains the index of a table column
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="iIndex">New value for property <code>index</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsItem setIndex(int iIndex);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// This property decides whether a <code>P13nColumnsItem</code> is visible
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern virtual bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// This property decides whether a <code>P13nColumnsItem</code> is visible
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsItem setVisible(bool bVisible);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// This property contains the with of a table column.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual string getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// This property contains the with of a table column.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsItem setWidth(string sWidth);

				#endregion

				#region Methods for Property total

				/// <summary>
				/// Gets current value of property {@link #getTotal total}.
				/// 
				/// This property contains the total flag of a table column.
				/// </summary>
				/// <returns>Value of property <code>total</code></returns>
				public extern virtual bool getTotal();

				/// <summary>
				/// Sets a new value for property {@link #getTotal total}.
				/// 
				/// This property contains the total flag of a table column.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bTotal">New value for property <code>total</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsItem setTotal(bool bTotal);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nColumnsItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nColumnsItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nColumnsItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nColumnsItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
