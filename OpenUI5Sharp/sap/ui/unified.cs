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
			/// Unified controls intended for both, mobile and desktop scenarios
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.ui.unified")]
			public static partial class unified
			{
				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class CalendarRowFocusInfo
				{
					/// <summary>
					/// First date, as JavaScript Date object, of the month that is focused.
					/// </summary>
					public object date;

					/// <summary>
					/// If set, the focused date is not rendered yet. (This happens by navigating out of the visible area.)
					/// </summary>
					public bool notVisible;

				}

				#endregion

				#region Delegates

				public delegate void CalendarRowFocusDelegate(sap.ui.@base.Event<sap.ui.unified.CalendarRowFocusInfo> oEvent, object oData);

				#endregion

				/// <summary>
				/// Types of a calendar day used for visualization.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.CalendarDayType")]
				public enum CalendarDayType
				{
					/// <summary>
					/// No special type is used.
					/// </summary>
					None,
					/// <summary>
					/// Non-working dates.
					/// </summary>
					NonWorking,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type01,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type02,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type03,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type04,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type05,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type06,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type07,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type08,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type09,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type10,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type11,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type12,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type13,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type14,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type15,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type16,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type17,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type18,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type19,
					/// <summary>
					/// The semantic meaning must be defined by the app. It can be displayed in a legend.
					/// </summary>
					Type20,
				}
				/// <summary>
				/// different styles for a ColorPicker.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.ColorPickerMode")]
				public enum ColorPickerMode
				{
					/// <summary>
					/// Color picker works with HSL values.
					/// </summary>
					HSL,
					/// <summary>
					/// Color picker works with HSV values.
					/// </summary>
					HSV,
				}
				/// <summary>
				/// Marker interface for controls that process instances of <code>window.Blob</code>, such as <code>window.File</code>. The implementation of this Interface should implement the following Interface methods: <ul> <li><code>getProcessedBlobsFromArray</code></li> </ul>
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.IProcessableBlobs")]
				public partial interface IProcessableBlobs
				{
					#region Methods

					#endregion

				}
				/// <summary>
				/// Interval types in a <code>CalendarRow</code>.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.CalendarIntervalType")]
				public enum CalendarIntervalType
				{
					/// <summary>
					/// Intervals have the size of one day.
					/// </summary>
					Day,
					/// <summary>
					/// Intervals have the size of one hour.
					/// </summary>
					Hour,
					/// <summary>
					/// Intervals have the size of one month.
					/// </summary>
					Month,
				}
				/// <summary>
				/// Types of display mode for overlapping appointments.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.GroupAppointmentsMode")]
				public enum GroupAppointmentsMode
				{
					/// <summary>
					/// Overlapping appointments are displayed as a collapsed group appointment.
					/// </summary>
					Collapsed,
					/// <summary>
					/// Overlapping appointments are displayed individually (expanded from a group).
					/// </summary>
					Expanded,
				}
				/// <summary>
				/// Predefined animations for the ContentSwitcher
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.ContentSwitcherAnimation")]
				public enum ContentSwitcherAnimation
				{
					/// <summary>
					/// Content is faded (opacity change).
					/// </summary>
					Fade,
					/// <summary>
					/// No animation. Content is switched instantly.
					/// </summary>
					None,
					/// <summary>
					/// The new content rotates in. (Just like one of those old newspaper-animations.)
					/// </summary>
					Rotate,
					/// <summary>
					/// The new content slides in from the left while the old content slides out to the left at the same time.
					/// </summary>
					SlideOver,
					/// <summary>
					/// The new slides in from the left (to the right).
					/// </summary>
					SlideRight,
					/// <summary>
					/// The new content is "zoomed in" from the center and grows to fill the full content area.
					/// </summary>
					ZoomIn,
					/// <summary>
					/// The old content is "zoomed out", i.e. shrinks to a point at the center of the content area.
					/// </summary>
					ZoomOut,
				}
				/// <summary>
				/// Standard day types visualized in a {@link sap.m.PlanningCalendarLegend}, which correspond to days in a {@link sap.ui.unified.Calendar}.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.StandardCalendarLegendItem")]
				public enum StandardCalendarLegendItem
				{
					/// <summary>
					/// Type used for visualization of the non-working days.
					/// </summary>
					NonWorkingDay,
					/// <summary>
					/// Type used for visualization of the currently selected day.
					/// </summary>
					Selected,
					/// <summary>
					/// Type used for visualization of the current date.
					/// </summary>
					Today,
					/// <summary>
					/// Type used for visualization of the regular work days.
					/// </summary>
					WorkingDay,
				}
				/// <summary>
				/// Visualization types for {@link sap.ui.unified.CalendarAppointment}.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.CalendarAppointmentVisualization")]
				public enum CalendarAppointmentVisualization
				{
					/// <summary>
					/// Visualization with fill color depending on the used theme.
					/// </summary>
					Filled,
					/// <summary>
					/// Standard visualization with no fill color.
					/// </summary>
					Standard,
				}
			}
		}
	}
}
