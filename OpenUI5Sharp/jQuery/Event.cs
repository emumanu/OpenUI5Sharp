using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class jQuery
	{
		/// <summary>
		/// Check the jQuery.Event class documentation available under "http://www.jquery.com"<br/> and "http://api.jquery.com/category/events/event-object/" for details.
		/// </summary>
		[External]
		[Namespace(false)]
		public partial class Event
		{
			#region Constructor

			/// <summary>
			/// Constructor for a jQuery.Event object.<br/> See "http://www.jquery.com" and "http://api.jquery.com/category/events/event-object/".
			/// </summary>
			public extern Event();

			#endregion

			#region Methods

			/// <summary>
			/// Returns OffsetX of Event. In jQuery there is a bug. In IE the value is in offsetX, in FF in layerX
			/// </summary>
			/// <returns>offsetX</returns>
			public extern virtual int getOffsetX();

			/// <summary>
			/// Returns OffsetY of Event. In jQuery there is a bug. in IE the value is in offsetY, in FF in layerY.
			/// </summary>
			/// <returns>offsetY</returns>
			public extern virtual int getOffsetY();

			/// <summary>
			/// Returns an array of names (as strings) identifying {@link jQuery.sap.PseudoEvents} that are fulfilled by this very Event instance.
			/// </summary>
			/// <returns>Array of names identifying {@link jQuery.sap.PseudoEvents} that are fulfilled by this very Event instance.</returns>
			public extern virtual string[] getPseudoTypes();

			/// <summary>
			/// Checks whether this instance of {@link jQuery.Event} is of the given <code>sType</code> pseudo type.
			/// </summary>
			/// <param name="sType">The name of the pseudo type this event should be checked for.</param>
			/// <returns><code>true</code> if this instance of jQuery.Event is of the given sType, <code>false</code> otherwise.</returns>
			public extern virtual bool isPseudoType(string sType);

			#endregion

		}
	}
}
