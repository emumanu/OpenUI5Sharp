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
				/// Abstract class that can be extended in order to implement any extended tooltip. For example, RichTooltip Control is based on it. It provides the opening/closing behavior and the main "text" property.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.TooltipBase")]
				public abstract partial class TooltipBase : sap.ui.core.Control
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
						/// The text that is shown in the tooltip that extends the TooltipBase class, for example in RichTooltip.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Optional. Open Duration in milliseconds.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> openDuration;

						/// <summary>
						/// Optional. Close Duration in milliseconds.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> closeDuration;

						/// <summary>
						/// Optional. My position defines which position on the extended tooltip being positioned to align with the target control.
						/// </summary>
						public Union<sap.ui.core.Dock, string, sap.ui.@base.ManagedObject.BindPropertyInfo> myPosition;

						/// <summary>
						/// Optional. At position defines which position on the target control to align the positioned tooltip.
						/// </summary>
						public Union<sap.ui.core.Dock, string, sap.ui.@base.ManagedObject.BindPropertyInfo> atPosition;

						/// <summary>
						/// Optional. Offset adds these left-top values to the calculated position. Example: "10 3".
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> offset;

						/// <summary>
						/// Optional. Collision - when the positioned element overflows the window in some direction, move it to an alternative position.
						/// </summary>
						public Union<sap.ui.core.Collision, string, sap.ui.@base.ManagedObject.BindPropertyInfo> collision;

						/// <summary>
						/// Opening delay of the tooltip in milliseconds
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> openDelay;

						/// <summary>
						/// Closing delay of the tooltip in milliseconds
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> closeDelay;

						/// <summary>
						/// This event is fired when the Tooltip has been closed
						/// </summary>
						public sap.ui.@base.EventDelegate closed;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new TooltipBase.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TooltipBase(string sId, sap.ui.core.TooltipBase.Settings mSettings);

					/// <summary>
					/// Constructor for a new TooltipBase.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern TooltipBase(string sId);

					/// <summary>
					/// Constructor for a new TooltipBase.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern TooltipBase();

					/// <summary>
					/// Constructor for a new TooltipBase.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TooltipBase(sap.ui.core.TooltipBase.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// The text that is shown in the tooltip that extends the TooltipBase class, for example in RichTooltip.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// The text that is shown in the tooltip that extends the TooltipBase class, for example in RichTooltip.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase setText(string sText);

					#endregion

					#region Methods for Property openDuration

					/// <summary>
					/// Gets current value of property {@link #getOpenDuration openDuration}.
					/// 
					/// Optional. Open Duration in milliseconds.
					/// 
					/// Default value is <code>200</code>.
					/// </summary>
					/// <returns>Value of property <code>openDuration</code></returns>
					public extern virtual int getOpenDuration();

					/// <summary>
					/// Sets a new value for property {@link #getOpenDuration openDuration}.
					/// 
					/// Optional. Open Duration in milliseconds.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>200</code>.
					/// </summary>
					/// <param name="iOpenDuration">New value for property <code>openDuration</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase setOpenDuration(int iOpenDuration);

					#endregion

					#region Methods for Property closeDuration

					/// <summary>
					/// Gets current value of property {@link #getCloseDuration closeDuration}.
					/// 
					/// Optional. Close Duration in milliseconds.
					/// 
					/// Default value is <code>200</code>.
					/// </summary>
					/// <returns>Value of property <code>closeDuration</code></returns>
					public extern virtual int getCloseDuration();

					/// <summary>
					/// Sets a new value for property {@link #getCloseDuration closeDuration}.
					/// 
					/// Optional. Close Duration in milliseconds.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>200</code>.
					/// </summary>
					/// <param name="iCloseDuration">New value for property <code>closeDuration</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase setCloseDuration(int iCloseDuration);

					#endregion

					#region Methods for Property myPosition

					/// <summary>
					/// Gets current value of property {@link #getMyPosition myPosition}.
					/// 
					/// Optional. My position defines which position on the extended tooltip being positioned to align with the target control.
					/// 
					/// Default value is <code>begin top</code>.
					/// </summary>
					/// <returns>Value of property <code>myPosition</code></returns>
					public extern virtual sap.ui.core.Dock getMyPosition();

					/// <summary>
					/// Sets a new value for property {@link #getMyPosition myPosition}.
					/// 
					/// Optional. My position defines which position on the extended tooltip being positioned to align with the target control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>begin top</code>.
					/// </summary>
					/// <param name="sMyPosition">New value for property <code>myPosition</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase setMyPosition(sap.ui.core.Dock sMyPosition);

					#endregion

					#region Methods for Property atPosition

					/// <summary>
					/// Gets current value of property {@link #getAtPosition atPosition}.
					/// 
					/// Optional. At position defines which position on the target control to align the positioned tooltip.
					/// 
					/// Default value is <code>begin bottom</code>.
					/// </summary>
					/// <returns>Value of property <code>atPosition</code></returns>
					public extern virtual sap.ui.core.Dock getAtPosition();

					/// <summary>
					/// Sets a new value for property {@link #getAtPosition atPosition}.
					/// 
					/// Optional. At position defines which position on the target control to align the positioned tooltip.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>begin bottom</code>.
					/// </summary>
					/// <param name="sAtPosition">New value for property <code>atPosition</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase setAtPosition(sap.ui.core.Dock sAtPosition);

					#endregion

					#region Methods for Property offset

					/// <summary>
					/// Gets current value of property {@link #getOffset offset}.
					/// 
					/// Optional. Offset adds these left-top values to the calculated position. Example: "10 3".
					/// 
					/// Default value is <code>10 3</code>.
					/// </summary>
					/// <returns>Value of property <code>offset</code></returns>
					public extern virtual string getOffset();

					/// <summary>
					/// Sets a new value for property {@link #getOffset offset}.
					/// 
					/// Optional. Offset adds these left-top values to the calculated position. Example: "10 3".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>10 3</code>.
					/// </summary>
					/// <param name="sOffset">New value for property <code>offset</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase setOffset(string sOffset);

					#endregion

					#region Methods for Property collision

					/// <summary>
					/// Gets current value of property {@link #getCollision collision}.
					/// 
					/// Optional. Collision - when the positioned element overflows the window in some direction, move it to an alternative position.
					/// 
					/// Default value is <code>flip</code>.
					/// </summary>
					/// <returns>Value of property <code>collision</code></returns>
					public extern virtual sap.ui.core.Collision getCollision();

					/// <summary>
					/// Sets a new value for property {@link #getCollision collision}.
					/// 
					/// Optional. Collision - when the positioned element overflows the window in some direction, move it to an alternative position.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>flip</code>.
					/// </summary>
					/// <param name="sCollision">New value for property <code>collision</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase setCollision(sap.ui.core.Collision sCollision);

					#endregion

					#region Methods for Property openDelay

					/// <summary>
					/// Gets current value of property {@link #getOpenDelay openDelay}.
					/// 
					/// Opening delay of the tooltip in milliseconds
					/// 
					/// Default value is <code>500</code>.
					/// </summary>
					/// <returns>Value of property <code>openDelay</code></returns>
					public extern virtual int getOpenDelay();

					/// <summary>
					/// Sets a new value for property {@link #getOpenDelay openDelay}.
					/// 
					/// Opening delay of the tooltip in milliseconds
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>500</code>.
					/// </summary>
					/// <param name="iOpenDelay">New value for property <code>openDelay</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase setOpenDelay(int iOpenDelay);

					#endregion

					#region Methods for Property closeDelay

					/// <summary>
					/// Gets current value of property {@link #getCloseDelay closeDelay}.
					/// 
					/// Closing delay of the tooltip in milliseconds
					/// 
					/// Default value is <code>100</code>.
					/// </summary>
					/// <returns>Value of property <code>closeDelay</code></returns>
					public extern virtual int getCloseDelay();

					/// <summary>
					/// Sets a new value for property {@link #getCloseDelay closeDelay}.
					/// 
					/// Closing delay of the tooltip in milliseconds
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100</code>.
					/// </summary>
					/// <param name="iCloseDelay">New value for property <code>closeDelay</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase setCloseDelay(int iCloseDelay);

					#endregion

					#region Methods for Event closed

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.core.TooltipBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.TooltipBase</code> itself.
					/// 
					/// This event is fired when the Tooltip has been closed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.TooltipBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase attachClosed(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.core.TooltipBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.TooltipBase</code> itself.
					/// 
					/// This event is fired when the Tooltip has been closed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase attachClosed(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.core.TooltipBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.TooltipBase</code> itself.
					/// 
					/// This event is fired when the Tooltip has been closed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase attachClosed(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.core.TooltipBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.TooltipBase</code> itself.
					/// 
					/// This event is fired when the Tooltip has been closed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.TooltipBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase attachClosed(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:closed closed} event of this <code>sap.ui.core.TooltipBase</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase detachClosed(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase fireClosed(object mParameters);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.TooltipBase fireClosed();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.TooltipBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.TooltipBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.TooltipBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.TooltipBase.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					#endregion

					#endregion

				}
			}
		}
	}
}
