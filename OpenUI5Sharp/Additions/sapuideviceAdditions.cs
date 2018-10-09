using System;
using System.Linq.Expressions;
using Bridge;

namespace UI5
{
    [External]
    public partial class sap
    {
        [External]
        public static partial class ui
        {
            [External]
            public partial class Device
            {
                /// <summary>
                /// To access to the single instance of the sap.ui.Device class
                /// </summary>
                /// <remarks>Originally this class was static but it is more useful for us to be non static</remarks>
                [Template("sap.ui.Device")]
                public static sap.ui.Device Singleton;

                [External]
                public partial class Media
                {
                    /// <summary>
                    /// Parameter to be used as Object Literal
                    /// </summary>
                    [External]
                    [ObjectLiteral]
                    public partial class MediaRangeChangeInfo
                    {
                        /// <summary>
                        /// The start value (inclusive) of the entered interval as a number
                        /// </summary>
                        public int from;

                        /// <summary>
                        /// The end value (exclusive) range of the entered interval as a number or undefined for the last interval (infinity)
                        /// </summary>
                        public int to;

                        /// <summary>
                        /// The unit used for the values above, e.g. "px"
                        /// </summary>
                        public string unit;

                        /// <summary>
                        /// The name of the entered interval, if available
                        /// </summary>
                        public string name;
                    }

                    public delegate void MediaRangeChangeDelegate(MediaRangeChangeInfo oDevice);

                    /// <summary>
                    /// Registers the given event handler to change events of the screen width based on the range set with the specified name.
                    /// 
                    /// The event is fired whenever the screen width changes and the current screen width is in a different interval of the given range set than before the width change.
                    /// 
                    /// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information about the entered interval: <ul> <li><code>mParams.from</code>: The start value (inclusive) of the entered interval as a number</li> <li><code>mParams.to</code>: The end value (exclusive) range of the entered interval as a number or undefined for the last interval (infinity)</li> <li><code>mParams.unit</code>: The unit used for the values above, e.g. <code>"px"</code></li> <li><code>mParams.name</code>: The name of the entered interval, if available</li> </ul>
                    /// </summary>
                    /// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the entered range set is provided as a single argument to the handler (see details above).</param>
                    /// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the <code>window</code>.</param>
                    /// <param name="sName">The name of the range set to listen to. The range set must be initialized beforehand ({@link sap.ui.Device.media.initRangeSet}). If no name is provided, the {@link sap.ui.Device.media.RANGESETS.SAP_STANDARD default range set} is used.</param>
                    public extern void attachHandler(MediaRangeChangeDelegate fnFunction, object oListener, string sName);

                    /// <summary>
                    /// Registers the given event handler to change events of the screen width based on the range set with the specified name.
                    /// 
                    /// The event is fired whenever the screen width changes and the current screen width is in a different interval of the given range set than before the width change.
                    /// 
                    /// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information about the entered interval: <ul> <li><code>mParams.from</code>: The start value (inclusive) of the entered interval as a number</li> <li><code>mParams.to</code>: The end value (exclusive) range of the entered interval as a number or undefined for the last interval (infinity)</li> <li><code>mParams.unit</code>: The unit used for the values above, e.g. <code>"px"</code></li> <li><code>mParams.name</code>: The name of the entered interval, if available</li> </ul>
                    /// </summary>
                    /// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the entered range set is provided as a single argument to the handler (see details above).</param>
                    /// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the <code>window</code>.</param>
                    public extern void attachHandler(MediaRangeChangeDelegate fnFunction, object oListener);

                    /// <summary>
                    /// Registers the given event handler to change events of the screen width based on the range set with the specified name.
                    /// 
                    /// The event is fired whenever the screen width changes and the current screen width is in a different interval of the given range set than before the width change.
                    /// 
                    /// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information about the entered interval: <ul> <li><code>mParams.from</code>: The start value (inclusive) of the entered interval as a number</li> <li><code>mParams.to</code>: The end value (exclusive) range of the entered interval as a number or undefined for the last interval (infinity)</li> <li><code>mParams.unit</code>: The unit used for the values above, e.g. <code>"px"</code></li> <li><code>mParams.name</code>: The name of the entered interval, if available</li> </ul>
                    /// </summary>
                    /// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the entered range set is provided as a single argument to the handler (see details above).</param>
                    public extern void attachHandler(MediaRangeChangeDelegate fnFunction);

                    /// <summary>
                    /// Removes a previously attached event handler from the change events of the screen width.
                    /// 
                    /// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
                    /// </summary>
                    /// <param name="fnFunction">The handler function to detach from the event</param>
                    /// <param name="oListener">The object that wanted to be notified when the event occurred</param>
                    /// <param name="sName">The name of the range set to listen to. If no name is provided, the {@link sap.ui.Device.media.RANGESETS.SAP_STANDARD default range set} is used.</param>
                    public extern void detachHandler(MediaRangeChangeDelegate fnFunction, object oListener, string sName);

                    /// <summary>
                    /// Removes a previously attached event handler from the change events of the screen width.
                    /// 
                    /// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
                    /// </summary>
                    /// <param name="fnFunction">The handler function to detach from the event</param>
                    /// <param name="oListener">The object that wanted to be notified when the event occurred</param>
                    public extern void detachHandler(MediaRangeChangeDelegate fnFunction, object oListener);

                    /// <summary>
                    /// Removes a previously attached event handler from the change events of the screen width.
                    /// 
                    /// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
                    /// </summary>
                    /// <param name="fnFunction">The handler function to detach from the event</param>
                    public extern void detachHandler(MediaRangeChangeDelegate fnFunction);
                }

                [External]
                public partial class Orientation
                {
                    /// <summary>
                    /// Parameter to be used as Object Literal
                    /// </summary>
                    [External]
                    [ObjectLiteral]
                    public partial class OrientationChangeInfo
                    {
                        /// <summary>
                        /// If this flag is set to true, the screen is currently in landscape mode, otherwise in portrait mode
                        /// </summary>
                        public bool landscape;
                    }

                    public delegate void OrientationChangeDelegate(OrientationChangeInfo oInfo);

                    /// <summary>
					/// Registers the given event handler to orientation change events of the document's window.
					/// 
					/// The event is fired whenever the screen orientation changes and the width of the document's window becomes greater than its height or the other way round.
					/// 
					/// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information: <ul> <li><code>mParams.landscape</code>: If this flag is set to <code>true</code>, the screen is currently in landscape mode, otherwise in portrait mode.</li> </ul>
					/// </summary>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the orientation is provided as a single argument to the handler (see details above).</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the <code>window</code>.</param>
					public extern void attachHandler(OrientationChangeDelegate fnFunction, object oListener);

                    /// <summary>
                    /// Registers the given event handler to orientation change events of the document's window.
                    /// 
                    /// The event is fired whenever the screen orientation changes and the width of the document's window becomes greater than its height or the other way round.
                    /// 
                    /// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information: <ul> <li><code>mParams.landscape</code>: If this flag is set to <code>true</code>, the screen is currently in landscape mode, otherwise in portrait mode.</li> </ul>
                    /// </summary>
                    /// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the orientation is provided as a single argument to the handler (see details above).</param>
                    public extern void attachHandler(OrientationChangeDelegate fnFunction);

                    /// <summary>
                    /// Removes a previously attached event handler from the orientation change events.
                    /// 
                    /// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
                    /// </summary>
                    /// <param name="fnFunction">The handler function to detach from the event</param>
                    /// <param name="oListener">The object that wanted to be notified when the event occurred</param>
                    public extern void detachHandler(OrientationChangeDelegate fnFunction, object oListener);

                    /// <summary>
                    /// Removes a previously attached event handler from the orientation change events.
                    /// 
                    /// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
                    /// </summary>
                    /// <param name="fnFunction">The handler function to detach from the event</param>
                    public extern void detachHandler(OrientationChangeDelegate fnFunction);
                }

                [External]
                public partial class Resize
                {
                    /// <summary>
                    /// Parameter to be used as Object Literal
                    /// </summary>
                    [External]
                    [ObjectLiteral]
                    public partial class SizeChangeInfo
                    {
                        /// <summary>
                        /// The height of the document's window in pixels
                        /// </summary>
                        public int height;

                        /// <summary>
                        /// The height of the document's window in pixels
                        /// </summary>
                        public int width;
                    }

                    public delegate void SizeChangeDelegate(SizeChangeInfo oInfo);

                    /// <summary>
					/// Registers the given event handler to resize change events of the document's window.
					/// 
					/// The event is fired whenever the document's window size changes.
					/// 
					/// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information: <ul> <li><code>mParams.height</code>: The height of the document's window in pixels.</li> <li><code>mParams.width</code>: The width of the document's window in pixels.</li> </ul>
					/// </summary>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the size is provided as a single argument to the handler (see details above).</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the <code>window</code>.</param>
					public extern void attachHandler(SizeChangeDelegate fnFunction, object oListener);

                    /// <summary>
                    /// Registers the given event handler to resize change events of the document's window.
                    /// 
                    /// The event is fired whenever the document's window size changes.
                    /// 
                    /// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information: <ul> <li><code>mParams.height</code>: The height of the document's window in pixels.</li> <li><code>mParams.width</code>: The width of the document's window in pixels.</li> </ul>
                    /// </summary>
                    /// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the size is provided as a single argument to the handler (see details above).</param>
                    public extern void attachHandler(SizeChangeDelegate fnFunction);

                    /// <summary>
                    /// Removes a previously attached event handler from the resize events.
                    /// 
                    /// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
                    /// </summary>
                    /// <param name="fnFunction">The handler function to detach from the event</param>
                    /// <param name="oListener">The object that wanted to be notified when the event occurred</param>
                    public extern void detachHandler(SizeChangeDelegate fnFunction, object oListener);

                    /// <summary>
                    /// Removes a previously attached event handler from the resize events.
                    /// 
                    /// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
                    /// </summary>
                    /// <param name="fnFunction">The handler function to detach from the event</param>
                    public extern void detachHandler(SizeChangeDelegate fnFunction);
                }
            }
        }
    }
}