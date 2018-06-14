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
			/// Enables users to navigate between items/entities.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class PagingButton : sap.ui.core.Control
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Control.Settings
				{
					/// <summary>
					/// Determines the total count of items/entities that the control navigates through. The minimum number of items/entities is 1.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> count;

					/// <summary>
					/// Determines the current position in the items/entities that the control navigates through. Starting (minimum) number is 1.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> position;

					/// <summary>
					/// Determines the tooltip of the next button.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> nextButtonTooltip;

					/// <summary>
					/// Determines the tooltip of the previous button.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> previousButtonTooltip;

					/// <summary>
					/// Fired when the current position is changed.
					/// </summary>
					public sap.m.PagingButton.PositionChangeDelegate positionChange;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class PositionChangeInfo
				{
					/// <summary>
					/// The number of the new position.
					/// </summary>
					public int newPosition;

					/// <summary>
					/// The number of the old position.
					/// </summary>
					public int oldPosition;

				}

				#endregion

				#region Delegates

				public delegate void PositionChangeDelegate(sap.ui.@base.Event<sap.m.PagingButton.PositionChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new PagingButton.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern PagingButton(string sId, sap.m.PagingButton.Settings mSettings);

				/// <summary>
				/// Constructor for a new PagingButton.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern PagingButton(string sId);

				/// <summary>
				/// Constructor for a new PagingButton.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern PagingButton();

				/// <summary>
				/// Constructor for a new PagingButton.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern PagingButton(sap.m.PagingButton.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property count

				/// <summary>
				/// Gets current value of property {@link #getCount count}.
				/// 
				/// Determines the total count of items/entities that the control navigates through. The minimum number of items/entities is 1.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>count</code></returns>
				public extern virtual int getCount();

				/// <summary>
				/// Sets a new value for property {@link #getCount count}.
				/// 
				/// Determines the total count of items/entities that the control navigates through. The minimum number of items/entities is 1.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <param name="iCount">New value for property <code>count</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PagingButton setCount(int iCount);

				#endregion

				#region Methods for Property position

				/// <summary>
				/// Gets current value of property {@link #getPosition position}.
				/// 
				/// Determines the current position in the items/entities that the control navigates through. Starting (minimum) number is 1.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>position</code></returns>
				public extern virtual int getPosition();

				/// <summary>
				/// Sets a new value for property {@link #getPosition position}.
				/// 
				/// Determines the current position in the items/entities that the control navigates through. Starting (minimum) number is 1.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <param name="iPosition">New value for property <code>position</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PagingButton setPosition(int iPosition);

				#endregion

				#region Methods for Property nextButtonTooltip

				/// <summary>
				/// Gets current value of property {@link #getNextButtonTooltip nextButtonTooltip}.
				/// 
				/// Determines the tooltip of the next button.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>nextButtonTooltip</code></returns>
				public extern virtual string getNextButtonTooltip();

				/// <summary>
				/// Sets a new value for property {@link #getNextButtonTooltip nextButtonTooltip}.
				/// 
				/// Determines the tooltip of the next button.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sNextButtonTooltip">New value for property <code>nextButtonTooltip</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PagingButton setNextButtonTooltip(string sNextButtonTooltip);

				#endregion

				#region Methods for Property previousButtonTooltip

				/// <summary>
				/// Gets current value of property {@link #getPreviousButtonTooltip previousButtonTooltip}.
				/// 
				/// Determines the tooltip of the previous button.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>previousButtonTooltip</code></returns>
				public extern virtual string getPreviousButtonTooltip();

				/// <summary>
				/// Sets a new value for property {@link #getPreviousButtonTooltip previousButtonTooltip}.
				/// 
				/// Determines the tooltip of the previous button.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sPreviousButtonTooltip">New value for property <code>previousButtonTooltip</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PagingButton setPreviousButtonTooltip(string sPreviousButtonTooltip);

				#endregion

				#region Methods for Aggregation previousButton

				#endregion

				#region Methods for Aggregation nextButton

				#endregion

				#region Methods for Event positionChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:positionChange positionChange} event of this <code>sap.m.PagingButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PagingButton</code> itself.
				/// 
				/// Fired when the current position is changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PagingButton</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PagingButton attachPositionChange(object oData, sap.m.PagingButton.PositionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:positionChange positionChange} event of this <code>sap.m.PagingButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PagingButton</code> itself.
				/// 
				/// Fired when the current position is changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PagingButton attachPositionChange(object oData, sap.m.PagingButton.PositionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:positionChange positionChange} event of this <code>sap.m.PagingButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PagingButton</code> itself.
				/// 
				/// Fired when the current position is changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PagingButton attachPositionChange(sap.m.PagingButton.PositionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:positionChange positionChange} event of this <code>sap.m.PagingButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PagingButton</code> itself.
				/// 
				/// Fired when the current position is changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PagingButton</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PagingButton attachPositionChange(sap.m.PagingButton.PositionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:positionChange positionChange} event of this <code>sap.m.PagingButton</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PagingButton detachPositionChange(sap.m.PagingButton.PositionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:positionChange positionChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PagingButton firePositionChange(sap.m.PagingButton.PositionChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:positionChange positionChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PagingButton firePositionChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.PagingButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.PagingButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.PagingButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.PagingButton.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
