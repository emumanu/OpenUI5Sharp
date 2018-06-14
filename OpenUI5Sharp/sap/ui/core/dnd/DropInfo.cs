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
			public static partial class core
			{
				public static partial class dnd
				{
					/// <summary>
					/// Provides the configuration for drop operations.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class DropInfo : sap.ui.core.dnd.DragDropBase, sap.ui.core.dnd.IDropInfo
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
							/// The aggregation name in the drop target control which is the target of this drag-and-drop action. If undefined, the entire control is the target. This can be handy if the target control does not have any aggregations or if the drop position within the target does not matter.
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> targetAggregation;

							/// <summary>
							/// Defines the visual drop effect.
							/// </summary>
							public Union<sap.ui.core.dnd.DropEffect, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> dropEffect;

							/// <summary>
							/// Defines the position for the drop action, visualized by a rectangle.
							/// </summary>
							public Union<sap.ui.core.dnd.DropPosition, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> dropPosition;

							/// <summary>
							/// Defines the layout of the droppable controls if <code>dropPosition</code> is set to <code>Between</code> or <code>OnOrBetween</code>.
							/// </summary>
							public Union<sap.ui.core.dnd.DropLayout, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> dropLayout;

							/// <summary>
							/// This event is fired when a dragged element enters a drop target.
							/// </summary>
							public sap.ui.core.dnd.DragInfo.DragDelegate dragEnter;

							/// <summary>
							/// This event is fired when an element is being dragged over a valid drop target.
							/// </summary>
							public sap.ui.core.dnd.DropInfo.DragOverDelegate dragOver;

							/// <summary>
							/// This event is fired when an element is dropped on a valid drop target, as specified by the drag-and-drop info.
							/// </summary>
							public sap.ui.core.dnd.DropInfo.DropDelegate drop;

						}

						#endregion

						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class DragOverInfo
						{
							/// <summary>
							/// The target element on which the dragged element will be dropped
							/// </summary>
							public sap.ui.core.Element target;

							/// <summary>
							/// The UI5 <code>dragSession</code> object that exists only during drag and drop
							/// </summary>
							public object dragSession;

							/// <summary>
							/// The calculated position of the drop action relative to the <code>target</code>, possible values are <code>Before</code>, <code>On</code>, <code>After</code>
							/// </summary>
							public string dropPosition;

							/// <summary>
							/// The underlying browser event
							/// </summary>
							public dom.Event browserEvent;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class DropData
						{
							/// <summary>
							/// The UI5 <code>dragSession</code> object that exists only during drag and drop
							/// </summary>
							public object dragSession;

							/// <summary>
							/// The element being dragged
							/// </summary>
							public sap.ui.core.Element draggedControl;

							/// <summary>
							/// The element being dropped
							/// </summary>
							public sap.ui.core.Element droppedControl;

							/// <summary>
							/// The calculated position of the drop action relative to the <code>droppedControl</code>, possible values are <code>Before</code>, <code>On</code>, <code>After</code>
							/// </summary>
							public string dropPosition;

							/// <summary>
							/// The underlying browser event
							/// </summary>
							public dom.Event browserEvent;

						}

						#endregion

						#region Delegates

						public delegate void DragOverDelegate(sap.ui.@base.Event<sap.ui.core.dnd.DropInfo.DragOverInfo> oEvent, object oData);

						public delegate void DropDelegate(sap.ui.@base.Event<sap.ui.core.dnd.DropInfo.DropData> oEvent, object oData);

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new DropInfo.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new DropInfo, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the DropInfo</param>
						public extern DropInfo(string sId, sap.ui.core.dnd.DropInfo.Settings mSettings);

						/// <summary>
						/// Constructor for a new DropInfo.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new DropInfo, generated automatically if no ID is given</param>
						public extern DropInfo(string sId);

						/// <summary>
						/// Constructor for a new DropInfo.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern DropInfo();

						/// <summary>
						/// Constructor for a new DropInfo.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the DropInfo</param>
						public extern DropInfo(sap.ui.core.dnd.DropInfo.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property targetAggregation

						/// <summary>
						/// Gets current value of property {@link #getTargetAggregation targetAggregation}.
						/// 
						/// The aggregation name in the drop target control which is the target of this drag-and-drop action. If undefined, the entire control is the target. This can be handy if the target control does not have any aggregations or if the drop position within the target does not matter.
						/// </summary>
						/// <returns>Value of property <code>targetAggregation</code></returns>
						public extern virtual string getTargetAggregation();

						/// <summary>
						/// Sets a new value for property {@link #getTargetAggregation targetAggregation}.
						/// 
						/// The aggregation name in the drop target control which is the target of this drag-and-drop action. If undefined, the entire control is the target. This can be handy if the target control does not have any aggregations or if the drop position within the target does not matter.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sTargetAggregation">New value for property <code>targetAggregation</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo setTargetAggregation(string sTargetAggregation);

						#endregion

						#region Methods for Property dropEffect

						/// <summary>
						/// Gets current value of property {@link #getDropEffect dropEffect}.
						/// 
						/// Defines the visual drop effect.
						/// 
						/// Default value is <code>Move</code>.
						/// </summary>
						/// <returns>Value of property <code>dropEffect</code></returns>
						public extern virtual sap.ui.core.dnd.DropEffect getDropEffect();

						/// <summary>
						/// Sets a new value for property {@link #getDropEffect dropEffect}.
						/// 
						/// Defines the visual drop effect.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>Move</code>.
						/// </summary>
						/// <param name="sDropEffect">New value for property <code>dropEffect</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo setDropEffect(sap.ui.core.dnd.DropEffect sDropEffect);

						#endregion

						#region Methods for Property dropPosition

						/// <summary>
						/// Gets current value of property {@link #getDropPosition dropPosition}.
						/// 
						/// Defines the position for the drop action, visualized by a rectangle.
						/// 
						/// Default value is <code>On</code>.
						/// </summary>
						/// <returns>Value of property <code>dropPosition</code></returns>
						public extern virtual sap.ui.core.dnd.DropPosition getDropPosition();

						/// <summary>
						/// Sets a new value for property {@link #getDropPosition dropPosition}.
						/// 
						/// Defines the position for the drop action, visualized by a rectangle.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>On</code>.
						/// </summary>
						/// <param name="sDropPosition">New value for property <code>dropPosition</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo setDropPosition(sap.ui.core.dnd.DropPosition sDropPosition);

						#endregion

						#region Methods for Property dropLayout

						/// <summary>
						/// Gets current value of property {@link #getDropLayout dropLayout}.
						/// 
						/// Defines the layout of the droppable controls if <code>dropPosition</code> is set to <code>Between</code> or <code>OnOrBetween</code>.
						/// 
						/// Default value is <code>Vertical</code>.
						/// </summary>
						/// <returns>Value of property <code>dropLayout</code></returns>
						public extern virtual sap.ui.core.dnd.DropLayout getDropLayout();

						/// <summary>
						/// Sets a new value for property {@link #getDropLayout dropLayout}.
						/// 
						/// Defines the layout of the droppable controls if <code>dropPosition</code> is set to <code>Between</code> or <code>OnOrBetween</code>.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>Vertical</code>.
						/// </summary>
						/// <param name="sDropLayout">New value for property <code>dropLayout</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo setDropLayout(sap.ui.core.dnd.DropLayout sDropLayout);

						#endregion

						#region Methods for Event dragEnter

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragEnter dragEnter} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when a dragged element enters a drop target.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.dnd.DropInfo</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDragEnter(object oData, sap.ui.core.dnd.DragInfo.DragDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragEnter dragEnter} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when a dragged element enters a drop target.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDragEnter(object oData, sap.ui.core.dnd.DragInfo.DragDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragEnter dragEnter} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when a dragged element enters a drop target.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDragEnter(sap.ui.core.dnd.DragInfo.DragDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragEnter dragEnter} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when a dragged element enters a drop target.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.dnd.DropInfo</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDragEnter(sap.ui.core.dnd.DragInfo.DragDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:dragEnter dragEnter} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo detachDragEnter(sap.ui.core.dnd.DragInfo.DragDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:dragEnter dragEnter} to attached listeners.
						/// 
						/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Whether or not to prevent the default action</returns>
						public extern virtual bool fireDragEnter(sap.ui.core.dnd.DragInfo.DragData mParameters);

						/// <summary>
						/// Fires event {@link #event:dragEnter dragEnter} to attached listeners.
						/// 
						/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
						/// </summary>
						/// <returns>Whether or not to prevent the default action</returns>
						public extern virtual bool fireDragEnter();

						#endregion

						#region Methods for Event dragOver

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragOver dragOver} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when an element is being dragged over a valid drop target.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.dnd.DropInfo</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDragOver(object oData, sap.ui.core.dnd.DropInfo.DragOverDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragOver dragOver} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when an element is being dragged over a valid drop target.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDragOver(object oData, sap.ui.core.dnd.DropInfo.DragOverDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragOver dragOver} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when an element is being dragged over a valid drop target.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDragOver(sap.ui.core.dnd.DropInfo.DragOverDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:dragOver dragOver} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when an element is being dragged over a valid drop target.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.dnd.DropInfo</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDragOver(sap.ui.core.dnd.DropInfo.DragOverDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:dragOver dragOver} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo detachDragOver(sap.ui.core.dnd.DropInfo.DragOverDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:dragOver dragOver} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo fireDragOver(sap.ui.core.dnd.DropInfo.DragOverInfo mParameters);

						/// <summary>
						/// Fires event {@link #event:dragOver dragOver} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo fireDragOver();

						#endregion

						#region Methods for Event drop

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:drop drop} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when an element is dropped on a valid drop target, as specified by the drag-and-drop info.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.dnd.DropInfo</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDrop(object oData, sap.ui.core.dnd.DropInfo.DropDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:drop drop} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when an element is dropped on a valid drop target, as specified by the drag-and-drop info.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDrop(object oData, sap.ui.core.dnd.DropInfo.DropDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:drop drop} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when an element is dropped on a valid drop target, as specified by the drag-and-drop info.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDrop(sap.ui.core.dnd.DropInfo.DropDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:drop drop} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.dnd.DropInfo</code> itself.
						/// 
						/// This event is fired when an element is dropped on a valid drop target, as specified by the drag-and-drop info.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.dnd.DropInfo</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo attachDrop(sap.ui.core.dnd.DropInfo.DropDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:drop drop} event of this <code>sap.ui.core.dnd.DropInfo</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo detachDrop(sap.ui.core.dnd.DropInfo.DropDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:drop drop} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo fireDrop(sap.ui.core.dnd.DropInfo.DropData mParameters);

						/// <summary>
						/// Fires event {@link #event:drop drop} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DropInfo fireDrop();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.dnd.DropInfo with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.dnd.DragDropBase.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.dnd.DropInfo with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.dnd.DragDropBase.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.dnd.DropInfo with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.dnd.DragDropBase.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.dnd.DropInfo.
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
