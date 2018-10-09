using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// The public facade of the {@link sap.m.SelectionDetails} control.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.SelectionDetailsFacade")]
			public partial class SelectionDetailsFacade
			{
				#region Constructor

				/// <summary>
				/// Describes the public facade of the {@link sap.m.SelectionDetails} control.
				/// </summary>
				public extern SelectionDetailsFacade();

				#endregion

				#region Methods

				/// <summary>
				/// Adds some action to the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails addAction(sap.ui.core.Item oAction);

				/// <summary>
				/// Adds some actionGroup to the aggregation {@link #getActionGroups actionGroups}.
				/// </summary>
				/// <param name="oActionGroup">The actionGroup to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails addActionGroup(sap.ui.core.Item oActionGroup);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionPress actionPress} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered when a custom action is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachActionPress(object oData, object fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionPress actionPress} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered when a custom action is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachActionPress(object oData, object fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionPress actionPress} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered when a custom action is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachActionPress(object fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachBeforeClose(object oData, object fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachBeforeClose(object oData, object fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachBeforeClose(object fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is open.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachBeforeOpen(object oData, object fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is open.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachBeforeOpen(object oData, object fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is open.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachBeforeOpen(object fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered after a list item of {@link sap.m.SelectionDetailsItem} is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachNavigate(object oData, object fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered after a list item of {@link sap.m.SelectionDetailsItem} is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachNavigate(object oData, object fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered after a list item of {@link sap.m.SelectionDetailsItem} is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails attachNavigate(object fnFunction);

				/// <summary>
				/// Closes SelectionDetails if open.
				/// </summary>
				/// <returns>To ensure method chaining, return the SelectionDetails.</returns>
				public extern virtual sap.m.SelectionDetails close();

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:actionPress actionPress} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails detachActionPress(object fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeClose beforeClose} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails detachBeforeClose(object fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails detachBeforeOpen(object fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:navigate navigate} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetails detachNavigate(object fnFunction, object oListener);

				/// <summary>
				/// Returns true if the SelectionDetails is enabled, otherwise false.
				/// </summary>
				/// <returns>True if the SelectionDetails contains items, otherwise false.</returns>
				public extern virtual bool isEnabled();

				/// <summary>
				/// Returns true if the SelectionDetails is open, otherwise false.
				/// </summary>
				/// <returns>True if the SelectionDetails is open, otherwise false.</returns>
				public extern virtual bool isOpen();

				/// <summary>
				/// Wraps the given content in {@link sap.m.Page page}, adds it to existing {@link sap.m.NavContainer NavContainer} and navigates to this newly created page. Has no effect if the SelectionDetails is closed. Lazily processes dependencies for the navigation event.
				/// </summary>
				/// <param name="title">The title property of the {@link sap.m.Page page} control to which the navigation should occur.</param>
				/// <param name="content">The content of the control to which the navigation should occur.</param>
				/// <returns>To ensure method chaining, return the SelectionDetails.</returns>
				public extern virtual sap.m.SelectionDetails navTo(string title, sap.ui.core.Control content);

				/// <summary>
				/// Removes a action from the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="vAction">The action to remove or its index or id</param>
				/// <returns>The removed action or <code>null</code></returns>
				public extern static sap.ui.core.Item removeAction(Union<int, string, sap.ui.core.Item> vAction);

				/// <summary>
				/// Removes a actionGroup from the aggregation {@link #getActionGroups actionGroups}.
				/// </summary>
				/// <param name="vActionGroup">The actionGroup to remove or its index or id</param>
				/// <returns>The removed actionGroup or <code>null</code></returns>
				public extern static sap.ui.core.Item removeActionGroup(Union<int, string, sap.ui.core.Item> vActionGroup);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getActionGroups actionGroups}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern static sap.ui.core.Item[] removeAllActionGroups();

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getActions actions}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern static sap.ui.core.Item[] removeAllActions();

				#endregion

			}
		}
	}
}
