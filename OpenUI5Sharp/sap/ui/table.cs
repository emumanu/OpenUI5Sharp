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
			/// <summary>
			/// Table-like controls, mainly for desktop scenarios.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.ui.table")]
			public static partial class table
			{
				/// <summary>
				/// Sort order of a column
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.SortOrder")]
				public enum SortOrder
				{
					/// <summary>
					/// Sort Order: ascending.
					/// </summary>
					Ascending,
					/// <summary>
					/// Sort Order: descending.
					/// </summary>
					Descending,
				}
				/// <summary>
				/// Shared DOM Reference IDs of the table.
				/// 
				/// Contains IDs of shared DOM references, which should be accessible to inheriting controls via getDomRef() function.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.SharedDomRef")]
				public enum SharedDomRef
				{
					/// <summary>
					/// The element id of the Horizontal Scroll Bar of the sap.ui.table.Table.
					/// </summary>
					HorizontalScrollBar,
					/// <summary>
					/// The element id of the Vertical Scroll Bar of the sap.ui.table.Table.
					/// </summary>
					VerticalScrollBar,
				}
				/// <summary>
				/// Row Action types.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.RowActionType")]
				public enum RowActionType
				{
					/// <summary>
					/// Custom defined Row Action.
					/// </summary>
					Custom,
					/// <summary>
					/// Delete Row Action.
					/// </summary>
					Delete,
					/// <summary>
					/// Navigation Row Action.
					/// </summary>
					Navigation,
				}
				/// <summary>
				/// Selection mode of the table
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.SelectionMode")]
				public enum SelectionMode
				{
					/// <summary>
					/// Select multiple rows at a time.
					/// </summary>
					Multi,
					/// <summary>
					/// Select multiple rows at a time (toggle behavior).
					/// </summary>
					MultiToggle,
					/// <summary>
					/// No rows can be selected.
					/// </summary>
					None,
					/// <summary>
					/// Select one row at a time.
					/// </summary>
					Single,
				}
				/// <summary>
				/// Details about the group event to distinguish between different actions associated with grouping
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.GroupEventType")]
				public enum GroupEventType
				{
					/// <summary>
					/// Group Column
					/// </summary>
					group,
					/// <summary>
					/// Show grouped column only as group header
					/// </summary>
					hideGroupedColumn,
					/// <summary>
					/// Change the group order of the columns. Move column one position down in the group sequence
					/// </summary>
					moveDown,
					/// <summary>
					/// Change the group order of the columns. Move column one position up in the group sequence
					/// </summary>
					moveUp,
					/// <summary>
					/// Show grouped column also as a column, not just as group header
					/// </summary>
					showGroupedColumn,
					/// <summary>
					/// Ungroup Column
					/// </summary>
					ungroup,
					/// <summary>
					/// Ungroup All Columns
					/// </summary>
					ungroupAll,
				}
				/// <summary>
				/// Navigation mode of the table
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.NavigationMode")]
				public enum NavigationMode
				{
					/// <summary>
					/// Uses the paginator control. This option must no longer be used. Using a scrollbar is the only navigation mode which is supported by the <code>sap.ui.table</code> library. The <code>navigationMode</code> property has always been a visual representation. No matter which navigation mode is used, data fetched from an OData service is loaded page-wise.
					/// </summary>
					Paginator,
					/// <summary>
					/// Uses the scrollbar control.
					/// </summary>
					Scrollbar,
				}
				/// <summary>
				/// Selection behavior of the table
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.SelectionBehavior")]
				public enum SelectionBehavior
				{
					/// <summary>
					/// Rows can be selected on the complete row.
					/// </summary>
					Row,
					/// <summary>
					/// Rows can only be selected on the row (and the selector is hidden).
					/// </summary>
					RowOnly,
					/// <summary>
					/// Rows can only be selected on the row selector.
					/// </summary>
					RowSelector,
				}
				/// <summary>
				/// Different modes for setting the auto expand mode on tree or analytical bindings.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.TreeAutoExpandMode")]
				public enum TreeAutoExpandMode
				{
				}
				/// <summary>
				/// VisibleRowCountMode of the table
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.VisibleRowCountMode")]
				public enum VisibleRowCountMode
				{
					/// <summary>
					/// The table automatically fills the height of the surrounding container. The visibleRowCount property is automatically changed accordingly. All rows need the same height, otherwise the auto mode doesn't always work as expected. The height of all siblings within the same layout container of the table will be subtracted from the available height. For performance reasons, it is recommended to add no siblings in the table's parent container.
					/// </summary>
					Auto,
					/// <summary>
					/// The table always has as many rows as defined in the visibleRowCount property.
					/// </summary>
					Fixed,
					/// <summary>
					/// After rendering the table has as many rows as defined in visibleRowCount property. The user is able to change the visible rows by moving a grip with the mouse. The visibleRowCount property is changed accordingly.
					/// </summary>
					Interactive,
				}
			}
		}
	}
}
