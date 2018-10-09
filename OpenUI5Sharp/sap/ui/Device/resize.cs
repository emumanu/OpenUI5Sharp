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
			public partial class Device
			{
				/// <summary>
				/// Common API for document window size change notifications across all platforms.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.Device.resize")]
				public partial class Resize
				{
					#region Fields

					/// <summary>
					/// The current height of the document's window in pixels.
					/// </summary>
					public int height;

					/// <summary>
					/// The current width of the document's window in pixels.
					/// </summary>
					public int width;

					#endregion

					#region Methods

					/// <summary>
					/// Registers the given event handler to resize change events of the document's window.
					/// 
					/// The event is fired whenever the document's window size changes.
					/// 
					/// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information: <ul> <li><code>mParams.height</code>: The height of the document's window in pixels.</li> <li><code>mParams.width</code>: The width of the document's window in pixels.</li> </ul>
					/// </summary>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the size is provided as a single argument to the handler (see details above).</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the <code>window</code>.</param>
					public extern virtual void attachHandler(object fnFunction, object oListener);

					/// <summary>
					/// Registers the given event handler to resize change events of the document's window.
					/// 
					/// The event is fired whenever the document's window size changes.
					/// 
					/// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information: <ul> <li><code>mParams.height</code>: The height of the document's window in pixels.</li> <li><code>mParams.width</code>: The width of the document's window in pixels.</li> </ul>
					/// </summary>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the size is provided as a single argument to the handler (see details above).</param>
					public extern virtual void attachHandler(object fnFunction);

					/// <summary>
					/// Removes a previously attached event handler from the resize events.
					/// 
					/// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
					/// </summary>
					/// <param name="fnFunction">The handler function to detach from the event</param>
					/// <param name="oListener">The object that wanted to be notified when the event occurred</param>
					public extern virtual void detachHandler(object fnFunction, object oListener);

					/// <summary>
					/// Removes a previously attached event handler from the resize events.
					/// 
					/// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
					/// </summary>
					/// <param name="fnFunction">The handler function to detach from the event</param>
					public extern virtual void detachHandler(object fnFunction);

					#endregion

				}
			}
		}
	}
}
