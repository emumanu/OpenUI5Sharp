using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class commons
			{
				/// <summary>
				/// Is used to provide a container, which can show different content depending on its current width. It fires an event, whenever a new range is reached. In addition the content of the new range is automatically shown, if it is set.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ResponsiveContainer")]
				[Obsolete("Deprecated since 1.38. Use a container by choice from the {@link sap.m} library, instead.")]
				public partial class ResponsiveContainer : sap.ui.core.Control
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
						/// The width of the responsive container.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// The width of the responsive container.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// The ranges defined for this container
						/// </summary>
						public Union<sap.ui.commons.ResponsiveContainerRange[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> ranges;

						/// <summary>
						/// The default content to show, in case the range does not provide content
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultContent;

						/// <summary>
						/// The event is fired the width of the container reaches a new range.
						/// </summary>
						public sap.ui.commons.ResponsiveContainer.RangeSwitchDelegate rangeSwitch;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class RangeSwitchInfo
					{
						/// <summary>
						/// The current range
						/// </summary>
						public sap.ui.commons.ResponsiveContainerRange currentRange;

					}

					#endregion

					#region Delegates

					public delegate void RangeSwitchDelegate(sap.ui.@base.Event<sap.ui.commons.ResponsiveContainer.RangeSwitchInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ResponsiveContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ResponsiveContainer(string sId, sap.ui.commons.ResponsiveContainer.Settings mSettings);

					/// <summary>
					/// Constructor for a new ResponsiveContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ResponsiveContainer(string sId);

					/// <summary>
					/// Constructor for a new ResponsiveContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ResponsiveContainer();

					/// <summary>
					/// Constructor for a new ResponsiveContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ResponsiveContainer(sap.ui.commons.ResponsiveContainer.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// The width of the responsive container.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// The width of the responsive container.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// The width of the responsive container.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// The width of the responsive container.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Aggregation ranges

					/// <summary>
					/// Gets content of aggregation {@link #getRanges ranges}.
					/// 
					/// The ranges defined for this container
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.ResponsiveContainerRange[] getRanges();

					/// <summary>
					/// Destroys all the ranges in the aggregation {@link #getRanges ranges}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer destroyRanges();

					/// <summary>
					/// Inserts a range into the aggregation {@link #getRanges ranges}.
					/// </summary>
					/// <param name="oRange">The range to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the range should be inserted at; for a negative value of <code>iIndex</code>, the range is inserted at position 0; for a value greater than the current size of the aggregation, the range is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer insertRange(sap.ui.commons.ResponsiveContainerRange oRange, int iIndex);

					/// <summary>
					/// Adds some range to the aggregation {@link #getRanges ranges}.
					/// </summary>
					/// <param name="oRange">The range to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer addRange(sap.ui.commons.ResponsiveContainerRange oRange);

					/// <summary>
					/// Removes a range from the aggregation {@link #getRanges ranges}.
					/// </summary>
					/// <param name="vRange">The range to remove or its index or id</param>
					/// <returns>The removed range or <code>null</code></returns>
					public extern virtual sap.ui.commons.ResponsiveContainerRange removeRange(Union<int, string, sap.ui.commons.ResponsiveContainerRange> vRange);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.ResponsiveContainerRange</code> in the aggregation {@link #getRanges ranges}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oRange">The range whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfRange(sap.ui.commons.ResponsiveContainerRange oRange);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getRanges ranges}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.ResponsiveContainerRange[] removeAllRanges();

					#endregion

					#region Methods for Aggregation content

					#endregion

					#region Methods for Association defaultContent

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getDefaultContent defaultContent}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getDefaultContent();

					/// <summary>
					/// Sets the associated {@link #getDefaultContent defaultContent}.
					/// </summary>
					/// <param name="oDefaultContent">ID of an element which becomes the new target of this defaultContent association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer setDefaultContent(Union<sap.ui.core.ID, sap.ui.core.Control> oDefaultContent);

					#endregion

					#region Methods for Event rangeSwitch

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:rangeSwitch rangeSwitch} event of this <code>sap.ui.commons.ResponsiveContainer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ResponsiveContainer</code> itself.
					/// 
					/// The event is fired the width of the container reaches a new range.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.ResponsiveContainer</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer attachRangeSwitch(object oData, sap.ui.commons.ResponsiveContainer.RangeSwitchDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:rangeSwitch rangeSwitch} event of this <code>sap.ui.commons.ResponsiveContainer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ResponsiveContainer</code> itself.
					/// 
					/// The event is fired the width of the container reaches a new range.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer attachRangeSwitch(object oData, sap.ui.commons.ResponsiveContainer.RangeSwitchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:rangeSwitch rangeSwitch} event of this <code>sap.ui.commons.ResponsiveContainer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ResponsiveContainer</code> itself.
					/// 
					/// The event is fired the width of the container reaches a new range.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer attachRangeSwitch(sap.ui.commons.ResponsiveContainer.RangeSwitchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:rangeSwitch rangeSwitch} event of this <code>sap.ui.commons.ResponsiveContainer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ResponsiveContainer</code> itself.
					/// 
					/// The event is fired the width of the container reaches a new range.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.ResponsiveContainer</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer attachRangeSwitch(sap.ui.commons.ResponsiveContainer.RangeSwitchDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:rangeSwitch rangeSwitch} event of this <code>sap.ui.commons.ResponsiveContainer</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer detachRangeSwitch(sap.ui.commons.ResponsiveContainer.RangeSwitchDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:rangeSwitch rangeSwitch} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer fireRangeSwitch(sap.ui.commons.ResponsiveContainer.RangeSwitchInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:rangeSwitch rangeSwitch} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainer fireRangeSwitch();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ResponsiveContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ResponsiveContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ResponsiveContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.ResponsiveContainer.
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
