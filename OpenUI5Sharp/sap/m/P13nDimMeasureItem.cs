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
			/// Type for <code>columnsItems</code> aggregation in <code>P13nDimMeasurePanel</code> control.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.P13nDimMeasureItem")]
			public partial class P13nDimMeasureItem : sap.ui.core.Item
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
					/// Specifies the unique chart column key. In this context a column refers to dimensions or measures of a chart.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnKey;

					/// <summary>
					/// Specifies the order of visible dimensions or measures of a chart.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> index;

					/// <summary>
					/// Specifies the visibility of dimensions or measures.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					/// <summary>
					/// Specifies the role of dimensions or measures. The role determines how dimensions and measures influence the chart.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> role;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nDimMeasureItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nDimMeasureItem(string sId, sap.m.P13nDimMeasureItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nDimMeasureItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nDimMeasureItem(string sId);

				/// <summary>
				/// Constructor for a new P13nDimMeasureItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nDimMeasureItem();

				/// <summary>
				/// Constructor for a new P13nDimMeasureItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nDimMeasureItem(sap.m.P13nDimMeasureItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property columnKey

				/// <summary>
				/// Gets current value of property {@link #getColumnKey columnKey}.
				/// 
				/// Specifies the unique chart column key. In this context a column refers to dimensions or measures of a chart.
				/// </summary>
				/// <returns>Value of property <code>columnKey</code></returns>
				public extern virtual string getColumnKey();

				/// <summary>
				/// Sets a new value for property {@link #getColumnKey columnKey}.
				/// 
				/// Specifies the unique chart column key. In this context a column refers to dimensions or measures of a chart.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sColumnKey">New value for property <code>columnKey</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasureItem setColumnKey(string sColumnKey);

				#endregion

				#region Methods for Property index

				/// <summary>
				/// Gets current value of property {@link #getIndex index}.
				/// 
				/// Specifies the order of visible dimensions or measures of a chart.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <returns>Value of property <code>index</code></returns>
				public extern virtual int getIndex();

				/// <summary>
				/// Sets a new value for property {@link #getIndex index}.
				/// 
				/// Specifies the order of visible dimensions or measures of a chart.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <param name="iIndex">New value for property <code>index</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasureItem setIndex(int iIndex);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Specifies the visibility of dimensions or measures.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern virtual bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Specifies the visibility of dimensions or measures.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasureItem setVisible(bool bVisible);

				#endregion

				#region Methods for Property role

				/// <summary>
				/// Gets current value of property {@link #getRole role}.
				/// 
				/// Specifies the role of dimensions or measures. The role determines how dimensions and measures influence the chart.
				/// </summary>
				/// <returns>Value of property <code>role</code></returns>
				public extern virtual string getRole();

				/// <summary>
				/// Sets a new value for property {@link #getRole role}.
				/// 
				/// Specifies the role of dimensions or measures. The role determines how dimensions and measures influence the chart.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sRole">New value for property <code>role</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasureItem setRole(string sRole);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nDimMeasureItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nDimMeasureItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nDimMeasureItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nDimMeasureItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
