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
			public static partial class core
			{
				/// <summary>
				/// The resize handling API provides firing of resize events on all browsers by regularly checking the width and height of registered DOM elements or controls and firing events accordingly.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.ResizeHandler")]
				public partial class ResizeHandler : sap.ui.@base.Object
				{
					#region Methods

					/// <summary>
					/// Deregisters a previously registered handler for resize events with the given registration ID.
					/// </summary>
					/// <param name="sId">The registration ID of the handler to deregister. The ID was provided by function {@link sap.ui.core.ResizeHandler.register} when the handler was registered.</param>
					public extern static void deregister(string sId);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ResizeHandler with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ResizeHandler with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ResizeHandler with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.ResizeHandler.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Registers the given event handler for resize events on the given DOM element or control.
					/// 
					/// <b>Note:</b> This function must not be used before the UI5 framework is initialized. Please use the {@link sap.ui.core.Core#attachInit init event} of UI5 if you are not sure whether this is the case.
					/// 
					/// The resize handler periodically checks the dimensions of the registered reference. Whenever it detects changes, an event is fired. Be careful when changing dimensions within the event handler which might cause another resize event and so on.
					/// 
					/// The available parameters of the resize event are: <ul> <li><code>oEvent.target</code>: The DOM element of which the dimensions were checked</li> <li><code>oEvent.size.width</code>: The current width of the DOM element in pixels</li> <li><code>oEvent.size.height</code>: The current height of the DOM element in pixels</li> <li><code>oEvent.oldSize.width</code>: The previous width of the DOM element in pixels</li> <li><code>oEvent.oldSize.height</code>: The previous height of the DOM element in pixels</li> <li><code>oEvent.control</code>: The control which was given during registration of the event handler (if present)</li> </ul>
					/// </summary>
					/// <param name="oRef">The control or the DOM reference for which the given event handler should be registered (beside the window)</param>
					/// <param name="fHandler">The event handler which should be called whenever the size of the given reference is changed. The event object is passed as first argument to the event handler. See the description of this function for more details about the available parameters of this event.</param>
					/// <returns>A registration ID which can be used for deregistering the event handler, see {@link sap.ui.core.ResizeHandler.deregister}. If the UI5 framework is not yet initialized <code>null</code> is returned.</returns>
					public extern static string register(Union<Retyped.dom.HTMLElement, sap.ui.core.Control> oRef, object fHandler);

					#endregion

				}
			}
		}
	}
}
