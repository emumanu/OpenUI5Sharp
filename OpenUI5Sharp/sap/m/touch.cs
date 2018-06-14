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
			/// Touch helper.
			/// </summary>
			[External]
			[Namespace(false)]
			public static partial class touch
			{
				#region Methods

				/// <summary>
				/// Given a list of touches, count the number of touches related with the given element.
				/// </summary>
				/// <param name="oTouchList">The list of touch objects to search.</param>
				/// <param name="vElement">A jQuery element or an element reference or an element id.</param>
				/// <returns>The number of touches related with the given element.</returns>
				public extern static int countContained(object[] oTouchList, Union<jquery.JQuery<object>, dom.HTMLElement, string> vElement);

				/// <summary>
				/// Given a list of touch objects, find the touch that matches the given one.
				/// </summary>
				/// <param name="oTouchList">The list of touch objects to search.</param>
				/// <param name="oTouch">A touch object to find or a Touch.identifier that uniquely identifies the current finger in the touch session.</param>
				/// <returns>The touch matching if any.</returns>
				public extern static object find(object[] oTouchList, Union<object, int> oTouch);

				#endregion

			}
		}
	}
}
