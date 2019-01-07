using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public abstract partial class jQuery
	{
		public static partial class sap
		{
			[External]
			[Namespace(false)]
			[Name("jQuery.sap.act")]
			[Obsolete("Deprecated since 1.58. use {@link module:sap/ui/util/ActivityDetection} instead")]
			public static partial class act
			{
				#region Methods

				/// <summary>
				/// Registers the given handler to the activity event, which is fired when an activity was detected after a certain period of inactivity.
				/// 
				/// The Event is not fired for Internet Explorer 8.
				/// </summary>
				/// <param name="fnFunction">The function to call, when an activity event occurs.</param>
				/// <param name="oListener">The 'this' context of the handler function.</param>
				public extern static void attachActivate(object fnFunction, object oListener);

				/// <summary>
				/// Registers the given handler to the activity event, which is fired when an activity was detected after a certain period of inactivity.
				/// 
				/// The Event is not fired for Internet Explorer 8.
				/// </summary>
				/// <param name="fnFunction">The function to call, when an activity event occurs.</param>
				public extern static void attachActivate(object fnFunction);

				/// <summary>
				/// Deregisters a previously registered handler from the activity event.
				/// </summary>
				/// <param name="fnFunction">The function to call, when an activity event occurs.</param>
				/// <param name="oListener">The 'this' context of the handler function.</param>
				public extern static void detachActivate(object fnFunction, object oListener);

				/// <summary>
				/// Deregisters a previously registered handler from the activity event.
				/// </summary>
				/// <param name="fnFunction">The function to call, when an activity event occurs.</param>
				public extern static void detachActivate(object fnFunction);

				/// <summary>
				/// Checks whether recently an activity was detected.
				/// </summary>
				/// <returns>true if recently an activity was detected, false otherwise</returns>
				public extern static void isActive();

				/// <summary>
				/// Reports an activity.
				/// </summary>
				public extern static void refresh();

				#endregion

			}
		}
	}
}
