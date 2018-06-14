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
			/// The P13nDimMeasurePanel control is used to define chart-specific settings like chart type, the visibility, the order and roles of dimensions and measures for table personalization.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class P13nDimMeasurePanel : sap.m.P13nPanel
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.P13nPanel.Settings
				{
					/// <summary>
					/// Specifies a chart type key.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> chartTypeKey;

					/// <summary>
					/// List of columns that has been changed.
					/// </summary>
					public Union<sap.m.P13nDimMeasureItem[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> dimMeasureItems;

					/// <summary>
					/// Specifies available chart types.
					/// </summary>
					public Union<sap.ui.core.Item[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> availableChartTypes;

					/// <summary>
					/// Event raised when one or more <code>DimMeasureItems</code> has been updated. Aggregation <code>DimMeasureItems</code> should be updated outside...
					/// </summary>
					public sap.ui.@base.EventDelegate changeDimMeasureItems;

					/// <summary>
					/// Event raised when a <code>ChartType</code> has been updated.
					/// </summary>
					public sap.ui.@base.EventDelegate changeChartType;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nDimMeasurePanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nDimMeasurePanel(string sId, sap.m.P13nDimMeasurePanel.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nDimMeasurePanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern P13nDimMeasurePanel(string sId);

				/// <summary>
				/// Constructor for a new P13nDimMeasurePanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nDimMeasurePanel();

				/// <summary>
				/// Constructor for a new P13nDimMeasurePanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nDimMeasurePanel(sap.m.P13nDimMeasurePanel.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property chartTypeKey

				/// <summary>
				/// Gets current value of property {@link #getChartTypeKey chartTypeKey}.
				/// 
				/// Specifies a chart type key.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>chartTypeKey</code></returns>
				public extern virtual string getChartTypeKey();

				/// <summary>
				/// Sets a new value for property {@link #getChartTypeKey chartTypeKey}.
				/// 
				/// Specifies a chart type key.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sChartTypeKey">New value for property <code>chartTypeKey</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel setChartTypeKey(string sChartTypeKey);

				#endregion

				#region Methods for Aggregation dimMeasureItems

				/// <summary>
				/// Gets content of aggregation {@link #getDimMeasureItems dimMeasureItems}.
				/// 
				/// List of columns that has been changed.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.P13nDimMeasureItem[] getDimMeasureItems();

				/// <summary>
				/// Destroys all the dimMeasureItems in the aggregation {@link #getDimMeasureItems dimMeasureItems}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel destroyDimMeasureItems();

				/// <summary>
				/// Inserts a dimMeasureItem into the aggregation {@link #getDimMeasureItems dimMeasureItems}.
				/// </summary>
				/// <param name="oDimMeasureItem">The dimMeasureItem to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the dimMeasureItem should be inserted at; for a negative value of <code>iIndex</code>, the dimMeasureItem is inserted at position 0; for a value greater than the current size of the aggregation, the dimMeasureItem is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel insertDimMeasureItem(sap.m.P13nDimMeasureItem oDimMeasureItem, int iIndex);

				/// <summary>
				/// Adds some dimMeasureItem to the aggregation {@link #getDimMeasureItems dimMeasureItems}.
				/// </summary>
				/// <param name="oDimMeasureItem">The dimMeasureItem to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel addDimMeasureItem(sap.m.P13nDimMeasureItem oDimMeasureItem);

				/// <summary>
				/// Removes a dimMeasureItem from the aggregation {@link #getDimMeasureItems dimMeasureItems}.
				/// </summary>
				/// <param name="vDimMeasureItem">The dimMeasureItem to remove or its index or id</param>
				/// <returns>The removed dimMeasureItem or <code>null</code></returns>
				public extern virtual sap.m.P13nDimMeasureItem removeDimMeasureItem(Union<int, string, sap.m.P13nDimMeasureItem> vDimMeasureItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.P13nDimMeasureItem</code> in the aggregation {@link #getDimMeasureItems dimMeasureItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oDimMeasureItem">The dimMeasureItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfDimMeasureItem(sap.m.P13nDimMeasureItem oDimMeasureItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getDimMeasureItems dimMeasureItems}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.P13nDimMeasureItem[] removeAllDimMeasureItems();

				/// <summary>
				/// Binds aggregation {@link #getDimMeasureItems dimMeasureItems} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel bindDimMeasureItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getDimMeasureItems dimMeasureItems} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel unbindDimMeasureItems();

				#endregion

				#region Methods for Aggregation content

				#endregion

				#region Methods for Aggregation availableChartTypes

				/// <summary>
				/// Gets content of aggregation {@link #getAvailableChartTypes availableChartTypes}.
				/// 
				/// Specifies available chart types.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Item[] getAvailableChartTypes();

				/// <summary>
				/// Destroys all the availableChartTypes in the aggregation {@link #getAvailableChartTypes availableChartTypes}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel destroyAvailableChartTypes();

				/// <summary>
				/// Inserts a availableChartType into the aggregation {@link #getAvailableChartTypes availableChartTypes}.
				/// </summary>
				/// <param name="oAvailableChartType">The availableChartType to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the availableChartType should be inserted at; for a negative value of <code>iIndex</code>, the availableChartType is inserted at position 0; for a value greater than the current size of the aggregation, the availableChartType is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel insertAvailableChartType(sap.ui.core.Item oAvailableChartType, int iIndex);

				/// <summary>
				/// Adds some availableChartType to the aggregation {@link #getAvailableChartTypes availableChartTypes}.
				/// </summary>
				/// <param name="oAvailableChartType">The availableChartType to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel addAvailableChartType(sap.ui.core.Item oAvailableChartType);

				/// <summary>
				/// Removes a availableChartType from the aggregation {@link #getAvailableChartTypes availableChartTypes}.
				/// </summary>
				/// <param name="vAvailableChartType">The availableChartType to remove or its index or id</param>
				/// <returns>The removed availableChartType or <code>null</code></returns>
				public extern virtual sap.ui.core.Item removeAvailableChartType(Union<int, string, sap.ui.core.Item> vAvailableChartType);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Item</code> in the aggregation {@link #getAvailableChartTypes availableChartTypes}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oAvailableChartType">The availableChartType whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfAvailableChartType(sap.ui.core.Item oAvailableChartType);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getAvailableChartTypes availableChartTypes}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Item[] removeAllAvailableChartTypes();

				#endregion

				#region Methods for Event changeDimMeasureItems

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeDimMeasureItems changeDimMeasureItems} event of this <code>sap.m.P13nDimMeasurePanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDimMeasurePanel</code> itself.
				/// 
				/// Event raised when one or more <code>DimMeasureItems</code> has been updated. Aggregation <code>DimMeasureItems</code> should be updated outside...
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nDimMeasurePanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel attachChangeDimMeasureItems(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeDimMeasureItems changeDimMeasureItems} event of this <code>sap.m.P13nDimMeasurePanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDimMeasurePanel</code> itself.
				/// 
				/// Event raised when one or more <code>DimMeasureItems</code> has been updated. Aggregation <code>DimMeasureItems</code> should be updated outside...
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel attachChangeDimMeasureItems(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeDimMeasureItems changeDimMeasureItems} event of this <code>sap.m.P13nDimMeasurePanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDimMeasurePanel</code> itself.
				/// 
				/// Event raised when one or more <code>DimMeasureItems</code> has been updated. Aggregation <code>DimMeasureItems</code> should be updated outside...
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel attachChangeDimMeasureItems(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeDimMeasureItems changeDimMeasureItems} event of this <code>sap.m.P13nDimMeasurePanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDimMeasurePanel</code> itself.
				/// 
				/// Event raised when one or more <code>DimMeasureItems</code> has been updated. Aggregation <code>DimMeasureItems</code> should be updated outside...
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nDimMeasurePanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel attachChangeDimMeasureItems(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:changeDimMeasureItems changeDimMeasureItems} event of this <code>sap.m.P13nDimMeasurePanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel detachChangeDimMeasureItems(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:changeDimMeasureItems changeDimMeasureItems} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel fireChangeDimMeasureItems(object mParameters);

				/// <summary>
				/// Fires event {@link #event:changeDimMeasureItems changeDimMeasureItems} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel fireChangeDimMeasureItems();

				#endregion

				#region Methods for Event changeChartType

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeChartType changeChartType} event of this <code>sap.m.P13nDimMeasurePanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDimMeasurePanel</code> itself.
				/// 
				/// Event raised when a <code>ChartType</code> has been updated.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nDimMeasurePanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel attachChangeChartType(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeChartType changeChartType} event of this <code>sap.m.P13nDimMeasurePanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDimMeasurePanel</code> itself.
				/// 
				/// Event raised when a <code>ChartType</code> has been updated.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel attachChangeChartType(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeChartType changeChartType} event of this <code>sap.m.P13nDimMeasurePanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDimMeasurePanel</code> itself.
				/// 
				/// Event raised when a <code>ChartType</code> has been updated.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel attachChangeChartType(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeChartType changeChartType} event of this <code>sap.m.P13nDimMeasurePanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDimMeasurePanel</code> itself.
				/// 
				/// Event raised when a <code>ChartType</code> has been updated.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nDimMeasurePanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel attachChangeChartType(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:changeChartType changeChartType} event of this <code>sap.m.P13nDimMeasurePanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel detachChangeChartType(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:changeChartType changeChartType} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel fireChangeChartType(object mParameters);

				/// <summary>
				/// Fires event {@link #event:changeChartType changeChartType} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDimMeasurePanel fireChangeChartType();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nDimMeasurePanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nDimMeasurePanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nDimMeasurePanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nDimMeasurePanel.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
