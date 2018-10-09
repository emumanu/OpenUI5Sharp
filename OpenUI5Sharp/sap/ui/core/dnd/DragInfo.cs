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
				public static partial class dnd
				{
					/// <summary>
					/// Provides the configuration for drag operations. <b>Note:</b> This configuration might be ignored due to control {@link sap.ui.core.Element.extend metadata} restrictions.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.dnd.DragInfo")]
					public partial class DragInfo : sap.ui.core.dnd.DragDropBase, sap.ui.core.dnd.IDragInfo
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.dnd.DragDropBase.Settings
						{
							/// <summary>
							/// The name of the aggregation from which all children can be dragged. If undefined, the control itself can be dragged.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> sourceAggregation;

							/// <summary>
							/// This event is fired when the user starts dragging an element.
							/// </summary>
							public sap.ui.core.dnd.DragInfo.DragDelegate dragStart;

							/// <summary>
							/// This event is fired when a drag operation is being ended.
							/// </summary>
							public sap.ui.core.dnd.DragInfo.DragDelegate dragEnd;

						}

						#endregion

						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class DragData
						{
							/// <summary>
							/// The target element that will be dragged
							/// </summary>
							public sap.ui.core.Element target;

							/// <summary>
							/// The UI5 <code>dragSession</code> object that exists only during drag and drop
							/// </summary>
							public object dragSession;

							/// <summary>
							/// The underlying browser event
							/// </summary>
							public dom.Event browserEvent;

						}

						#endregion

						#region Delegates

						public delegate void DragDelegate(sap.ui.@base.Event<sap.ui.core.dnd.DragInfo.DragData> oEvent, object oData);

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new DragInfo.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new DragInfo, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the DragInfo</param>
						public extern DragInfo(string sId, sap.ui.core.dnd.DragInfo.Settings mSettings);

						/// <summary>
						/// Constructor for a new DragInfo.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new DragInfo, generated automatically if no ID is given</param>
						public extern DragInfo(string sId);

						/// <summary>
						/// Constructor for a new DragInfo.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern DragInfo();

						/// <summary>
						/// Constructor for a new DragInfo.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the DragInfo</param>
						public extern DragInfo(sap.ui.core.dnd.DragInfo.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property sourceAggregation

						/// <summary>
						/// Gets current value of property {@link #getSourceAggregation sourceAggregation}.
						/// 
						/// The name of the aggregation from which all children can be dragged. If undefined, the control itself can be dragged.
						/// </summary>
						/// <returns>Value of property <code>sourceAggregation</code></returns>
						public extern virtual string getSourceAggregation();

						/// <summary>
						/// Sets a new value for property {@link #getSourceAggregation sourceAggregation}.
						/// 
						/// The name of the aggregation from which all children can be dragged. If undefined, the control itself can be dragged.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sSourceAggregation">New value for property <code>sourceAggregation</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo setSourceAggregation(string sSourceAggregation);

						#endregion

						#region Methods for Event dragStart

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragStart dragStart} event of this <code>sap.ui.core.dnd.DragInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DragInfo</code> itself.
						/// 
						/// This event is fired when the user starts dragging an element.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.dnd.DragInfo</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo attachDragStart(object oData, sap.ui.core.dnd.DragInfo.DragDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragStart dragStart} event of this <code>sap.ui.core.dnd.DragInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DragInfo</code> itself.
						/// 
						/// This event is fired when the user starts dragging an element.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo attachDragStart(object oData, sap.ui.core.dnd.DragInfo.DragDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragStart dragStart} event of this <code>sap.ui.core.dnd.DragInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DragInfo</code> itself.
						/// 
						/// This event is fired when the user starts dragging an element.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo attachDragStart(sap.ui.core.dnd.DragInfo.DragDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragStart dragStart} event of this <code>sap.ui.core.dnd.DragInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DragInfo</code> itself.
						/// 
						/// This event is fired when the user starts dragging an element.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.dnd.DragInfo</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo attachDragStart(sap.ui.core.dnd.DragInfo.DragDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:dragStart dragStart} event of this <code>sap.ui.core.dnd.DragInfo</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo detachDragStart(sap.ui.core.dnd.DragInfo.DragDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:dragStart dragStart} to attached listeners.
						/// 
						/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Whether or not to prevent the default action</returns>
						public extern virtual bool fireDragStart(sap.ui.core.dnd.DragInfo.DragData mParameters);

						/// <summary>
						/// Fires event {@link #event:dragStart dragStart} to attached listeners.
						/// 
						/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
						/// </summary>
						/// <returns>Whether or not to prevent the default action</returns>
						public extern virtual bool fireDragStart();

						#endregion

						#region Methods for Event dragEnd

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragEnd dragEnd} event of this <code>sap.ui.core.dnd.DragInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DragInfo</code> itself.
						/// 
						/// This event is fired when a drag operation is being ended.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.dnd.DragInfo</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo attachDragEnd(object oData, sap.ui.core.dnd.DragInfo.DragDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragEnd dragEnd} event of this <code>sap.ui.core.dnd.DragInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DragInfo</code> itself.
						/// 
						/// This event is fired when a drag operation is being ended.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo attachDragEnd(object oData, sap.ui.core.dnd.DragInfo.DragDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragEnd dragEnd} event of this <code>sap.ui.core.dnd.DragInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DragInfo</code> itself.
						/// 
						/// This event is fired when a drag operation is being ended.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo attachDragEnd(sap.ui.core.dnd.DragInfo.DragDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragEnd dragEnd} event of this <code>sap.ui.core.dnd.DragInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DragInfo</code> itself.
						/// 
						/// This event is fired when a drag operation is being ended.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.dnd.DragInfo</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo attachDragEnd(sap.ui.core.dnd.DragInfo.DragDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:dragEnd dragEnd} event of this <code>sap.ui.core.dnd.DragInfo</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo detachDragEnd(sap.ui.core.dnd.DragInfo.DragDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:dragEnd dragEnd} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo fireDragEnd(sap.ui.core.dnd.DragInfo.DragData mParameters);

						/// <summary>
						/// Fires event {@link #event:dragEnd dragEnd} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragInfo fireDragEnd();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.dnd.DragInfo with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.dnd.DragDropBase.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.dnd.DragInfo with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.dnd.DragDropBase.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.dnd.DragInfo with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.dnd.DragDropBase.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.dnd.DragInfo.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
