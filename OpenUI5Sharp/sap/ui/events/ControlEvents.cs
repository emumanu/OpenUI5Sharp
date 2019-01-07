using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class events
			{
				[External]
				[Namespace(false)]
				[Name("sap.ui.events.ControlEvents")]
				public partial class ControlEvents
				{
					#region Fields

					/// <summary>
					/// List of DOM events that a UIArea automatically takes care of.
					/// 
					/// A control/element doesn't have to bind listeners for these events. It instead can implement an <code>on<i>event</i>(oEvent)</code> method for any of the following events that it wants to be notified about:
					/// 
					/// click, dblclick, contextmenu, focusin, focusout, keydown, keypress, keyup, mousedown, mouseout, mouseover, mouseup, select, selectstart, dragstart, dragenter, dragover, dragleave, dragend, drop, paste, cut, input, touchstart, touchend, touchmove, touchcancel, tap, swipe, swipeleft, swiperight, scrollstart, scrollstop
					/// 
					/// The mouse events and touch events are supported simultaneously on both desktop and mobile browsers. Do NOT create both onmouse* and ontouch* functions to avoid one event being handled twice on the same control.
					/// </summary>
					public static object events;

					#endregion

					#region Methods

					/// <summary>
					/// Binds all events for listening with the given callback function.
					/// </summary>
					/// <param name="fnCallback">Callback function</param>
					public extern static void bindAnyEvent(object fnCallback);

					/// <summary>
					/// Unbinds all events for listening with the given callback function.
					/// </summary>
					/// <param name="fnCallback">Callback function</param>
					public extern static void unbindAnyEvent(object fnCallback);

					#endregion

				}
			}
		}
	}
}
