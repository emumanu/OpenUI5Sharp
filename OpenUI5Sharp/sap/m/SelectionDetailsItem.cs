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
			/// This protected element provides an item for {@link sap.m.SelectionDetails} that is shown inside a list. The item includes SelectionDetailsItemLine as its lines that are displayed in one block above the optional actions. <b><i>Note:</i></b>It is protected and should only be used within the framework itself.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.SelectionDetailsItem")]
			public partial class SelectionDetailsItem : sap.ui.core.Element
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
					/// Determines whether or not the item is active and a navigation event is triggered on press.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableNav;

					/// <summary>
					/// Contains a record of information about, for example, measures and dimensions. These entries are usually obtained via selection in chart controls.
					/// </summary>
					public Union<sap.m.SelectionDetailsItemLine[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> lines;

					/// <summary>
					/// Contains custom actions shown below the main content of the item.
					/// </summary>
					public Union<sap.ui.core.Item[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> actions;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new SelectionDetailsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern SelectionDetailsItem(string sId, sap.m.SelectionDetailsItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new SelectionDetailsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				public extern SelectionDetailsItem(string sId);

				/// <summary>
				/// Constructor for a new SelectionDetailsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern SelectionDetailsItem();

				/// <summary>
				/// Constructor for a new SelectionDetailsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern SelectionDetailsItem(sap.m.SelectionDetailsItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property enableNav

				/// <summary>
				/// Gets current value of property {@link #getEnableNav enableNav}.
				/// 
				/// Determines whether or not the item is active and a navigation event is triggered on press.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableNav</code></returns>
				public extern virtual bool getEnableNav();

				/// <summary>
				/// Sets a new value for property {@link #getEnableNav enableNav}.
				/// 
				/// Determines whether or not the item is active and a navigation event is triggered on press.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableNav">New value for property <code>enableNav</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItem setEnableNav(bool bEnableNav);

				#endregion

				#region Methods for Aggregation lines

				/// <summary>
				/// Gets content of aggregation {@link #getLines lines}.
				/// 
				/// Contains a record of information about, for example, measures and dimensions. These entries are usually obtained via selection in chart controls.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.SelectionDetailsItemLine[] getLines();

				/// <summary>
				/// Destroys all the lines in the aggregation {@link #getLines lines}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItem destroyLines();

				/// <summary>
				/// Inserts a line into the aggregation {@link #getLines lines}.
				/// </summary>
				/// <param name="oLine">The line to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the line should be inserted at; for a negative value of <code>iIndex</code>, the line is inserted at position 0; for a value greater than the current size of the aggregation, the line is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItem insertLine(sap.m.SelectionDetailsItemLine oLine, int iIndex);

				/// <summary>
				/// Adds some line to the aggregation {@link #getLines lines}.
				/// </summary>
				/// <param name="oLine">The line to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItem addLine(sap.m.SelectionDetailsItemLine oLine);

				/// <summary>
				/// Removes a line from the aggregation {@link #getLines lines}.
				/// </summary>
				/// <param name="vLine">The line to remove or its index or id</param>
				/// <returns>The removed line or <code>null</code></returns>
				public extern virtual sap.m.SelectionDetailsItemLine removeLine(Union<int, string, sap.m.SelectionDetailsItemLine> vLine);

				/// <summary>
				/// Checks for the provided <code>sap.m.SelectionDetailsItemLine</code> in the aggregation {@link #getLines lines}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oLine">The line whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfLine(sap.m.SelectionDetailsItemLine oLine);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getLines lines}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.SelectionDetailsItemLine[] removeAllLines();

				/// <summary>
				/// Binds aggregation {@link #getLines lines} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItem bindLines(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getLines lines} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItem unbindLines();

				#endregion

				#region Methods for Aggregation actions

				/// <summary>
				/// Gets content of aggregation {@link #getActions actions}.
				/// 
				/// Contains custom actions shown below the main content of the item.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Item[] getActions();

				/// <summary>
				/// Destroys all the actions in the aggregation {@link #getActions actions}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItem destroyActions();

				/// <summary>
				/// Inserts a action into the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the action should be inserted at; for a negative value of <code>iIndex</code>, the action is inserted at position 0; for a value greater than the current size of the aggregation, the action is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItem insertAction(sap.ui.core.Item oAction, int iIndex);

				/// <summary>
				/// Adds some action to the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItem addAction(sap.ui.core.Item oAction);

				/// <summary>
				/// Removes a action from the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="vAction">The action to remove or its index or id</param>
				/// <returns>The removed action or <code>null</code></returns>
				public extern virtual sap.ui.core.Item removeAction(Union<int, string, sap.ui.core.Item> vAction);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Item</code> in the aggregation {@link #getActions actions}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oAction">The action whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfAction(sap.ui.core.Item oAction);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getActions actions}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Item[] removeAllActions();

				#endregion

				#region Methods for Aggregation _overflowToolbar

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectionDetailsItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectionDetailsItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectionDetailsItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns the public facade of the SelectionDetailsItem for non inner framework usages.
				/// </summary>
				/// <returns>The reduced facade for outer framework usages.</returns>
				public extern virtual sap.ui.@base.Interface getFacade();

				/// <summary>
				/// Returns a metadata object for class sap.m.SelectionDetailsItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
