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
			/// Second-level information container of an {@link sap.uxap.ObjectPageLayout}.
			/// 
			/// An <code>ObjectPageSubSection</code> may only be used within sections in the <code>ObjectPageLayout</code>. Subsections are used to display primary information in the <code>blocks</code> aggregation (always visible) and not-so-important information in the <code>moreBlocks</code> aggregation. The content in the <code>moreBlocks</code> aggregation is initially hidden, but may be accessed with a "See more" (...) button.
			/// 
			/// <b>Note:</b> This control is intended to be used only as part of the <code>ObjectPageLayout</code>.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageSubSection")]
			public partial class ObjectPageSubSection : sap.uxap.ObjectPageSectionBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.uxap.ObjectPageSectionBase.Settings
				{
					/// <summary>
					/// A mode property that will be passed to the controls in the blocks and moreBlocks aggregations. Only relevant if these aggregations use Object page blocks.
					/// </summary>
					public Union<sap.uxap.ObjectPageSubSectionMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> mode;

					/// <summary>
					/// Determines whether the Subsection title is displayed in upper case.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleUppercase;

					/// <summary>
					/// Controls to be displayed in the subsection
					/// 
					/// <b>Note:</b> The SAP Fiori Design guidelines require that the <code>ObjectPageHeader</code>'s content and the <code>ObjectPage</code>'s subsection content are aligned vertically. When using {@link sap.ui.layout.form.Form}, {@link sap.m.Panel}, {@link sap.m.Table} and {@link sap.m.List} in the subsection content area of <code>ObjectPage</code>, you need to adjust their left text offset to achieve the vertical alignment. To do this, apply the <code>sapUxAPObjectPageSubSectionAlignContent</code> CSS class to them and set their <code>width</code> property to <code>auto</code> (if not set by default).
					/// 
					/// Example:
					/// 
					/// <pre>
					/// <code> &lt;Panel class="sapUxAPObjectPageSubSectionAlignContent" width="auto"&gt;&lt;/Panel&gt; </code>
					/// </pre>
					/// </summary>
					public Union<sap.ui.core.Element[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> blocks;

					/// <summary>
					/// Additional controls to display when the Show more / See all / (...) button is pressed
					/// </summary>
					public Union<sap.ui.core.Element[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> moreBlocks;

					/// <summary>
					/// Actions available for this Subsection
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> actions;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectPageSubSection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageSubSection(string sId, sap.uxap.ObjectPageSubSection.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectPageSubSection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectPageSubSection(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectPageSubSection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectPageSubSection();

				/// <summary>
				/// Constructor for a new <code>ObjectPageSubSection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageSubSection(sap.uxap.ObjectPageSubSection.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property mode

				/// <summary>
				/// Gets current value of property {@link #getMode mode}.
				/// 
				/// A mode property that will be passed to the controls in the blocks and moreBlocks aggregations. Only relevant if these aggregations use Object page blocks.
				/// 
				/// Default value is <code>Collapsed</code>.
				/// </summary>
				/// <returns>Value of property <code>mode</code></returns>
				public extern virtual sap.uxap.ObjectPageSubSectionMode getMode();

				/// <summary>
				/// Sets a new value for property {@link #getMode mode}.
				/// 
				/// A mode property that will be passed to the controls in the blocks and moreBlocks aggregations. Only relevant if these aggregations use Object page blocks.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Collapsed</code>.
				/// </summary>
				/// <param name="sMode">New value for property <code>mode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSubSection setMode(sap.uxap.ObjectPageSubSectionMode sMode);

				#endregion

				#region Methods for Property titleUppercase

				/// <summary>
				/// Gets current value of property {@link #getTitleUppercase titleUppercase}.
				/// 
				/// Determines whether the Subsection title is displayed in upper case.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>titleUppercase</code></returns>
				public extern virtual bool getTitleUppercase();

				/// <summary>
				/// Sets a new value for property {@link #getTitleUppercase titleUppercase}.
				/// 
				/// Determines whether the Subsection title is displayed in upper case.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bTitleUppercase">New value for property <code>titleUppercase</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSubSection setTitleUppercase(bool bTitleUppercase);

				#endregion

				#region Methods for Aggregation _grid

				#endregion

				#region Methods for Aggregation blocks

				/// <summary>
				/// Gets content of aggregation {@link #getBlocks blocks}.
				/// 
				/// Controls to be displayed in the subsection
				/// 
				/// <b>Note:</b> The SAP Fiori Design guidelines require that the <code>ObjectPageHeader</code>'s content and the <code>ObjectPage</code>'s subsection content are aligned vertically. When using {@link sap.ui.layout.form.Form}, {@link sap.m.Panel}, {@link sap.m.Table} and {@link sap.m.List} in the subsection content area of <code>ObjectPage</code>, you need to adjust their left text offset to achieve the vertical alignment. To do this, apply the <code>sapUxAPObjectPageSubSectionAlignContent</code> CSS class to them and set their <code>width</code> property to <code>auto</code> (if not set by default).
				/// 
				/// Example:
				/// 
				/// <pre>
				/// <code> &lt;Panel class="sapUxAPObjectPageSubSectionAlignContent" width="auto"&gt;&lt;/Panel&gt; </code>
				/// </pre>
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getBlocks();

				/// <summary>
				/// Destroys all the blocks in the aggregation {@link #getBlocks blocks}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSubSection destroyBlocks();

				/// <summary>
				/// Adds an <code>sap.uxap.BlockBase</code> instance to the <code>blocks</code> aggregation.
				/// 
				/// <b>Note:</b> The <code>insertBlock</code> method is not supported by design. If used, it works as an <code>addBlock</code>, adding a single block to the end of the <code>blocks</code> aggregation.
				/// </summary>
				/// <param name="oObject">The <code>sap.uxap.BlockBase</code> instance</param>
				/// <param name="iIndex">The insertion index</param>
				/// <returns>The <code>sap.uxap.ObjectPageSubSection</code> instance</returns>
				public extern virtual sap.uxap.ObjectPageSubSection insertBlock(sap.uxap.BlockBase oObject, int iIndex);

				/// <summary>
				/// Adds some block to the aggregation {@link #getBlocks blocks}.
				/// </summary>
				/// <param name="oBlock">The block to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSubSection addBlock(sap.ui.core.Control oBlock);

				/// <summary>
				/// Removes a block from the aggregation {@link #getBlocks blocks}.
				/// </summary>
				/// <param name="vBlock">The block to remove or its index or id</param>
				/// <returns>The removed block or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeBlock(Union<int, string, sap.ui.core.Control> vBlock);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getBlocks blocks}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oBlock">The block whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfBlock(sap.ui.core.Control oBlock);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getBlocks blocks}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllBlocks();

				#endregion

				#region Methods for Aggregation moreBlocks

				/// <summary>
				/// Gets content of aggregation {@link #getMoreBlocks moreBlocks}.
				/// 
				/// Additional controls to display when the Show more / See all / (...) button is pressed
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getMoreBlocks();

				/// <summary>
				/// Destroys all the moreBlocks in the aggregation {@link #getMoreBlocks moreBlocks}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSubSection destroyMoreBlocks();

				/// <summary>
				/// Adds an <code>sap.uxap.BlockBase</code> instance to the <code>moreBlocks</code> aggregation.
				/// 
				/// <b>Note:</b> The <code>insertMoreBlock</code> method is not supported by design. If used, it works as an <code>addMoreBlock</code>, adding a single block to the end of the <code>moreBlocks</code> aggregation.
				/// </summary>
				/// <param name="oObject">The <code>sap.uxap.BlockBase</code> instance</param>
				/// <param name="iIndex">The insertion index</param>
				/// <returns>The <code>sap.uxap.ObjectPageSubSection</code> instance</returns>
				public extern virtual sap.uxap.ObjectPageSubSection insertMoreBlock(sap.uxap.BlockBase oObject, int iIndex);

				/// <summary>
				/// Adds some moreBlock to the aggregation {@link #getMoreBlocks moreBlocks}.
				/// </summary>
				/// <param name="oMoreBlock">The moreBlock to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSubSection addMoreBlock(sap.ui.core.Control oMoreBlock);

				/// <summary>
				/// Removes a moreBlock from the aggregation {@link #getMoreBlocks moreBlocks}.
				/// </summary>
				/// <param name="vMoreBlock">The moreBlock to remove or its index or id</param>
				/// <returns>The removed moreBlock or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeMoreBlock(Union<int, string, sap.ui.core.Control> vMoreBlock);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getMoreBlocks moreBlocks}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oMoreBlock">The moreBlock whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfMoreBlock(sap.ui.core.Control oMoreBlock);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getMoreBlocks moreBlocks}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllMoreBlocks();

				#endregion

				#region Methods for Aggregation actions

				/// <summary>
				/// Gets content of aggregation {@link #getActions actions}.
				/// 
				/// Actions available for this Subsection
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getActions();

				/// <summary>
				/// Destroys all the actions in the aggregation {@link #getActions actions}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSubSection destroyActions();

				/// <summary>
				/// Inserts a action into the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the action should be inserted at; for a negative value of <code>iIndex</code>, the action is inserted at position 0; for a value greater than the current size of the aggregation, the action is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSubSection insertAction(sap.ui.core.Control oAction, int iIndex);

				/// <summary>
				/// Adds some action to the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSubSection addAction(sap.ui.core.Control oAction);

				/// <summary>
				/// Removes a action from the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="vAction">The action to remove or its index or id</param>
				/// <returns>The removed action or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeAction(Union<int, string, sap.ui.core.Control> vAction);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getActions actions}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oAction">The action whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfAction(sap.ui.core.Control oAction);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getActions actions}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllActions();

				#endregion

				#region Other methods

				/// <summary>
				/// Sets DOM ID of the Title borrowed from this SubSection
				/// </summary>
				/// <param name="sId">the ID of the DOM Element</param>
				private extern void _setBorrowedTitleDomId(string sId);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageSubSection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.uxap.ObjectPageSectionBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageSubSection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.uxap.ObjectPageSectionBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageSubSection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.uxap.ObjectPageSectionBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ObjectPageSubSection.
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
