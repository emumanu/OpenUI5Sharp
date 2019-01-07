using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class layout
			{
				/// <summary>
				/// The BlockLayoutRow is used as an aggregation to the BlockLayout. It aggregates Block Layout cells. The BlockLayoutRow has 2 rendering modes - scrollable and non scrollable.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.layout.BlockLayoutRow")]
				public partial class BlockLayoutRow : sap.ui.core.Control
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
						/// Sets the rendering mode of the BlockLayoutRow to scrollable. In scrollable mode, the cells get aligned side by side, with horizontal scroll bar for the row.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollable;

						/// <summary>
						/// Defines background type for that row. There might be several rows with the same type
						/// </summary>
						public Union<sap.ui.layout.BlockRowColorSets, string, sap.ui.@base.ManagedObject.BindPropertyInfo> rowColorSet;

						/// <summary>
						/// The content cells to be included in the row.
						/// </summary>
						public Union<sap.ui.layout.BlockLayoutCell[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Cells that would be accented. *Note:* This association has visual impact only for BlockLayouts with background types "Mixed" and "Accent".
						/// 
						/// Mixed: In this type, areas of 25% (on desktop) can have a dark background color. Per section one area can be dark. Accent: Every section can contain multiple gray blocks, which are used alternately, beginning with the bright one
						/// </summary>
						public Union<sap.ui.layout.BlockLayoutCell, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> accentCells;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new BlockLayoutRow.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern BlockLayoutRow(string sId, sap.ui.layout.BlockLayoutRow.Settings mSettings);

					/// <summary>
					/// Constructor for a new BlockLayoutRow.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern BlockLayoutRow(string sId);

					/// <summary>
					/// Constructor for a new BlockLayoutRow.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern BlockLayoutRow();

					/// <summary>
					/// Constructor for a new BlockLayoutRow.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern BlockLayoutRow(sap.ui.layout.BlockLayoutRow.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property scrollable

					/// <summary>
					/// Gets current value of property {@link #getScrollable scrollable}.
					/// 
					/// Sets the rendering mode of the BlockLayoutRow to scrollable. In scrollable mode, the cells get aligned side by side, with horizontal scroll bar for the row.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>scrollable</code></returns>
					public extern virtual bool getScrollable();

					/// <summary>
					/// Sets a new value for property {@link #getScrollable scrollable}.
					/// 
					/// Sets the rendering mode of the BlockLayoutRow to scrollable. In scrollable mode, the cells get aligned side by side, with horizontal scroll bar for the row.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bScrollable">New value for property <code>scrollable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutRow setScrollable(bool bScrollable);

					#endregion

					#region Methods for Property rowColorSet

					/// <summary>
					/// Gets current value of property {@link #getRowColorSet rowColorSet}.
					/// 
					/// Defines background type for that row. There might be several rows with the same type
					/// </summary>
					/// <returns>Value of property <code>rowColorSet</code></returns>
					public extern virtual sap.ui.layout.BlockRowColorSets getRowColorSet();

					/// <summary>
					/// Changes dynamically row color set Note: this might invalidate cells inside and also change color sets of the other BlockLayoutRow-s below it.
					/// </summary>
					/// <param name="sType"></param>
					/// <returns></returns>
					public extern virtual sap.ui.layout.BlockLayoutRow setRowColorSet(sap.ui.layout.BlockRowColorSets sType);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// The content cells to be included in the row.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.layout.BlockLayoutCell[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutRow destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutRow insertContent(sap.ui.layout.BlockLayoutCell oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutRow addContent(sap.ui.layout.BlockLayoutCell oContent);

					/// <summary>
					/// Removes a content from the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="vContent">The content to remove or its index or id</param>
					/// <returns>The removed content or <code>null</code></returns>
					public extern virtual sap.ui.layout.BlockLayoutCell removeContent(Union<int, string, sap.ui.layout.BlockLayoutCell> vContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.layout.BlockLayoutCell</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oContent">The content whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfContent(sap.ui.layout.BlockLayoutCell oContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getContent content}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell[] removeAllContent();

					#endregion

					#region Methods for Association accentCells

					/// <summary>
					/// Returns array of IDs of the elements which are the current targets of the association {@link #getAccentCells accentCells}.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID[] getAccentCells();

					/// <summary>
					/// Adds some accentCell into the association {@link #getAccentCells accentCells}.
					/// </summary>
					/// <param name="vAccentCell">The accentCells to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutRow addAccentCell(Union<sap.ui.core.ID, sap.ui.layout.BlockLayoutCell> vAccentCell);

					/// <summary>
					/// Removes an accentCell from the association named {@link #getAccentCells accentCells}.
					/// </summary>
					/// <param name="vAccentCell">The accentCell to be removed or its index or ID</param>
					/// <returns>The removed accentCell or <code>null</code></returns>
					public extern virtual sap.ui.core.ID removeAccentCell(Union<int, sap.ui.core.ID, sap.ui.layout.BlockLayoutCell> vAccentCell);

					/// <summary>
					/// Removes all the controls in the association named {@link #getAccentCells accentCells}.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ID[] removeAllAccentCells();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayoutRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayoutRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayoutRow with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.BlockLayoutRow.
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
}
