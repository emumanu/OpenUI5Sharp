using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class Device
			{
				/// <summary>
				/// Common API for orientation change notifications across all platforms.
				/// 
				/// For browsers or devices that do not provide native support for orientation change events the API simulates them based on the ratio of the document's width and height.
				/// </summary>
				[External]
				[Namespace(false)]
				public static partial class orientation
				{
					#region Fields

					/// <summary>
					/// If this flag is set to <code>true</code>, the screen is currently in landscape mode (the width is greater than the height).
					/// </summary>
					public static bool landscape;

					/// <summary>
					/// If this flag is set to <code>true</code>, the screen is currently in portrait mode (the height is greater than the width).
					/// </summary>
					public static bool portrait;

					#endregion

					#region Methods

					/// <summary>
					/// Registers the given event handler to orientation change events of the document's window.
					/// 
					/// The event is fired whenever the screen orientation changes and the width of the document's window becomes greater than its height or the other way round.
					/// 
					/// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information: <ul> <li><code>mParams.landscape</code>: If this flag is set to <code>true</code>, the screen is currently in landscape mode, otherwise in portrait mode.</li> </ul>
					/// </summary>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the orientation is provided as a single argument to the handler (see details above).</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the <code>window</code>.</param>
					public extern static void attachHandler(object fnFunction, object oListener);

					/// <summary>
					/// Registers the given event handler to orientation change events of the document's window.
					/// 
					/// The event is fired whenever the screen orientation changes and the width of the document's window becomes greater than its height or the other way round.
					/// 
					/// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information: <ul> <li><code>mParams.landscape</code>: If this flag is set to <code>true</code>, the screen is currently in landscape mode, otherwise in portrait mode.</li> </ul>
					/// </summary>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the orientation is provided as a single argument to the handler (see details above).</param>
					public extern static void attachHandler(object fnFunction);

					/// <summary>
					/// Removes a previously attached event handler from the orientation change events.
					/// 
					/// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
					/// </summary>
					/// <param name="fnFunction">The handler function to detach from the event</param>
					/// <param name="oListener">The object that wanted to be notified when the event occurred</param>
					public extern static void detachHandler(object fnFunction, object oListener);

					/// <summary>
					/// Removes a previously attached event handler from the orientation change events.
					/// 
					/// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
					/// </summary>
					/// <param name="fnFunction">The handler function to detach from the event</param>
					public extern static void detachHandler(object fnFunction);

					#endregion

				}
			}
		}
	}
}
