using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class uxap
		{
			/// <summary>
			/// The main element that holds the content that is displayed in an {@link sap.uxap.ObjectPageLayout ObjectPageLayout}, but not necessarily only there.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The blocks give the flexibility to combine different content types.
			/// 
			/// A block is a control that: <ul> <li>Has modes and a view associated to each mode. At rendering time, the view associated to the mode is rendered.</li> <li>Can use all view types for storing its internal control tree (XML, JS, JSON, HTML)</li> </ul>
			/// 
			/// As any UI5 view, the XML view can have a controller which automatically comes with a <code>this.oParentBlock</code> attribute (so that the controller can interact with the block). If the controller implements the <code>onParentBlockModeChange</code> method, this method will be called with the <code>sMode</code> parameter when the view is used or reused by the block.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.BlockBase")]
			public partial class BlockBase : sap.ui.core.Control
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Control.Settings
				{
					/// <summary>
					/// Determines the mode of the block. When block is used inside ObjectPage this mode is inherited my the SubSection. The mode of the block is changed when SubSection mode changes.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> mode;

					/// <summary>
					/// Determines the visibility of the block.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					/// <summary>
					/// Determines on how many columns the layout will be rendered. Allowed values are integers from 1 to 4 and "auto".
					/// </summary>
					public Union<sap.uxap.BlockBaseColumnLayout, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnLayout;

					/// <summary>
					/// Determines if the block should automatically adjust its inner forms. Allowed values are "BlockColumns" and "OneColumn" and "None". If the value is "BlockColumns", then the inner form will have as many columns as the colspan of its parent block. If the value is "OneColumn", the inner form will have exactly one column, regardless the colspan of its parent block. If the value is "None", no automatic adjustment of inner forms will be made and the form will keep its original column count.
					/// </summary>
					public Union<sap.uxap.BlockBaseFormAdjustment, string, sap.ui.@base.ManagedObject.BindPropertyInfo> formAdjustment;

					/// <summary>
					/// Determines whether the show more button should be shown.
					/// 
					/// <b>Note:</b> The property will take effect if the <code>BlockBase</code> is inside <ObjectPageSubSection</code> and would be ignored in case the <code>BlockBase</code> is nested inside another <code>BlockBase</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSubSectionMore;

					/// <summary>
					/// Map external UI5 model and internal Block model
					/// </summary>
					public Union<sap.uxap.ModelMapping[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> mappings;

					/// <summary>
					/// The view that is rendered now. Can be used as getter for the rendered view.
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedView;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>BlockBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern BlockBase(string sId, sap.uxap.BlockBase.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>BlockBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern BlockBase(string sId);

				/// <summary>
				/// Constructor for a new <code>BlockBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern BlockBase();

				/// <summary>
				/// Constructor for a new <code>BlockBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern BlockBase(sap.uxap.BlockBase.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property mode

				/// <summary>
				/// Gets current value of property {@link #getMode mode}.
				/// 
				/// Determines the mode of the block. When block is used inside ObjectPage this mode is inherited my the SubSection. The mode of the block is changed when SubSection mode changes.
				/// </summary>
				/// <returns>Value of property <code>mode</code></returns>
				public extern virtual string getMode();

				/// <summary>
				/// Set the view mode for this particular block.
				/// </summary>
				/// <param name="sMode">the mode to apply to the control (that should be synchronized with view declared)</param>
				/// <returns>this</returns>
				public extern virtual object setMode(string sMode);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Determines the visibility of the block.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern override bool getVisible();

				/// <summary>
				/// Setter for the visibility of the block.
				/// </summary>
				public extern virtual void setVisible();

				#endregion

				#region Methods for Property columnLayout

				/// <summary>
				/// Gets current value of property {@link #getColumnLayout columnLayout}.
				/// 
				/// Determines on how many columns the layout will be rendered. Allowed values are integers from 1 to 4 and "auto".
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>columnLayout</code></returns>
				public extern virtual sap.uxap.BlockBaseColumnLayout getColumnLayout();

				/// <summary>
				/// Set the column layout for this particular block.
				/// </summary>
				/// <param name="sLayout">The column layout to apply to the control</param>
				public extern virtual void setColumnLayout(string sLayout);

				#endregion

				#region Methods for Property formAdjustment

				/// <summary>
				/// Gets current value of property {@link #getFormAdjustment formAdjustment}.
				/// 
				/// Determines if the block should automatically adjust its inner forms. Allowed values are "BlockColumns" and "OneColumn" and "None". If the value is "BlockColumns", then the inner form will have as many columns as the colspan of its parent block. If the value is "OneColumn", the inner form will have exactly one column, regardless the colspan of its parent block. If the value is "None", no automatic adjustment of inner forms will be made and the form will keep its original column count.
				/// 
				/// Default value is <code>BlockColumns</code>.
				/// </summary>
				/// <returns>Value of property <code>formAdjustment</code></returns>
				public extern virtual sap.uxap.BlockBaseFormAdjustment getFormAdjustment();

				/// <summary>
				/// Sets a new value for property {@link #getFormAdjustment formAdjustment}.
				/// 
				/// Determines if the block should automatically adjust its inner forms. Allowed values are "BlockColumns" and "OneColumn" and "None". If the value is "BlockColumns", then the inner form will have as many columns as the colspan of its parent block. If the value is "OneColumn", the inner form will have exactly one column, regardless the colspan of its parent block. If the value is "None", no automatic adjustment of inner forms will be made and the form will keep its original column count.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>BlockColumns</code>.
				/// </summary>
				/// <param name="sFormAdjustment">New value for property <code>formAdjustment</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BlockBase setFormAdjustment(sap.uxap.BlockBaseFormAdjustment sFormAdjustment);

				#endregion

				#region Methods for Property showSubSectionMore

				/// <summary>
				/// Gets current value of property {@link #getShowSubSectionMore showSubSectionMore}.
				/// 
				/// Determines whether the show more button should be shown.
				/// 
				/// <b>Note:</b> The property will take effect if the <code>BlockBase</code> is inside <ObjectPageSubSection</code> and would be ignored in case the <code>BlockBase</code> is nested inside another <code>BlockBase</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showSubSectionMore</code></returns>
				public extern virtual bool getShowSubSectionMore();

				/// <summary>
				/// Sets a new value for property {@link #getShowSubSectionMore showSubSectionMore}.
				/// 
				/// Determines whether the show more button should be shown.
				/// 
				/// <b>Note:</b> The property will take effect if the <code>BlockBase</code> is inside <ObjectPageSubSection</code> and would be ignored in case the <code>BlockBase</code> is nested inside another <code>BlockBase</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowSubSectionMore">New value for property <code>showSubSectionMore</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BlockBase setShowSubSectionMore(bool bShowSubSectionMore);

				#endregion

				#region Methods for Aggregation mappings

				/// <summary>
				/// Gets content of aggregation {@link #getMappings mappings}.
				/// 
				/// Map external UI5 model and internal Block model
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.uxap.ModelMapping[] getMappings();

				/// <summary>
				/// Destroys all the mappings in the aggregation {@link #getMappings mappings}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BlockBase destroyMappings();

				/// <summary>
				/// Inserts a mapping into the aggregation {@link #getMappings mappings}.
				/// </summary>
				/// <param name="oMapping">The mapping to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the mapping should be inserted at; for a negative value of <code>iIndex</code>, the mapping is inserted at position 0; for a value greater than the current size of the aggregation, the mapping is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BlockBase insertMapping(sap.uxap.ModelMapping oMapping, int iIndex);

				/// <summary>
				/// Adds some mapping to the aggregation {@link #getMappings mappings}.
				/// </summary>
				/// <param name="oMapping">The mapping to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BlockBase addMapping(sap.uxap.ModelMapping oMapping);

				/// <summary>
				/// Removes a mapping from the aggregation {@link #getMappings mappings}.
				/// </summary>
				/// <param name="vMapping">The mapping to remove or its index or id</param>
				/// <returns>The removed mapping or <code>null</code></returns>
				public extern virtual sap.uxap.ModelMapping removeMapping(Union<int, string, sap.uxap.ModelMapping> vMapping);

				/// <summary>
				/// Checks for the provided <code>sap.uxap.ModelMapping</code> in the aggregation {@link #getMappings mappings}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oMapping">The mapping whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfMapping(sap.uxap.ModelMapping oMapping);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getMappings mappings}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.uxap.ModelMapping[] removeAllMappings();

				#endregion

				#region Methods for Aggregation _views

				#endregion

				#region Methods for Association selectedView

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedView selectedView}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedView();

				/// <summary>
				/// Sets the associated {@link #getSelectedView selectedView}.
				/// </summary>
				/// <param name="oSelectedView">ID of an element which becomes the new target of this selectedView association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BlockBase setSelectedView(Union<sap.ui.core.ID, sap.ui.core.Control> oSelectedView);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.BlockBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.BlockBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.BlockBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.BlockBase.
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
