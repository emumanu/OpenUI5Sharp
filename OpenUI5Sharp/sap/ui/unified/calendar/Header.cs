using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class unified
			{
				public static partial class calendar
				{
					/// <summary>
					/// renders a calendar header
					/// 
					/// The calendar header consists of 3 buttons where the text can be set and a previous and a next button. In the normal calendar the first button contains the displayed day, the second button the displayed month and the third button the displayed year.
					/// 
					/// <b>Note:</b> This is used inside the calendar. Not for standalone usage
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class Header : sap.ui.core.Control
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
							/// Text of the first button (normally day)
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> textButton0;

							/// <summary>
							/// Additional text of the first button (normally day)
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> additionalTextButton0;

							/// <summary>
							/// aria-label of the first button (normally day)
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelButton0;

							/// <summary>
							/// If set, the first button will be displayed
							/// 
							/// <b>Note:</b> The default is set to false to be compatible to older versions
							/// </summary>
							public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visibleButton0;

							/// <summary>
							/// Text of the second button (normally month)
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> textButton1;

							/// <summary>
							/// Additional text of the second button (normally month)
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> additionalTextButton1;

							/// <summary>
							/// aria-label of the second button (normally month)
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelButton1;

							/// <summary>
							/// If set, the second button will be displayed
							/// </summary>
							public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visibleButton1;

							/// <summary>
							/// Text of the third button (normally year)
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> textButton2;

							/// <summary>
							/// Additional text of the third button (normally year)
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> additionalTextButton2;

							/// <summary>
							/// aria-label of the third button (normally year)
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelButton2;

							/// <summary>
							/// If set, the third button will be displayed
							/// </summary>
							public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visibleButton2;

							/// <summary>
							/// Enables the previous button
							/// </summary>
							public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enabledPrevious;

							/// <summary>
							/// Enables the Next button
							/// </summary>
							public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enabledNext;

							/// <summary>
							/// Previous button pressed
							/// </summary>
							public sap.ui.@base.EventDelegate pressPrevious;

							/// <summary>
							/// Next button pressed
							/// </summary>
							public sap.ui.@base.EventDelegate pressNext;

							/// <summary>
							/// First button pressed (normally day)
							/// </summary>
							public sap.ui.@base.EventDelegate pressButton0;

							/// <summary>
							/// Second button pressed (normally month)
							/// </summary>
							public sap.ui.@base.EventDelegate pressButton1;

							/// <summary>
							/// Third button pressed (normally year)
							/// </summary>
							public sap.ui.@base.EventDelegate pressButton2;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new Header.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern Header(string sId, sap.ui.unified.calendar.Header.Settings mSettings);

						/// <summary>
						/// Constructor for a new Header.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern Header(string sId);

						/// <summary>
						/// Constructor for a new Header.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern Header();

						/// <summary>
						/// Constructor for a new Header.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern Header(sap.ui.unified.calendar.Header.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property textButton0

						/// <summary>
						/// Gets current value of property {@link #getTextButton0 textButton0}.
						/// 
						/// Text of the first button (normally day)
						/// </summary>
						/// <returns>Value of property <code>textButton0</code></returns>
						public extern virtual string getTextButton0();

						/// <summary>
						/// Sets a new value for property {@link #getTextButton0 textButton0}.
						/// 
						/// Text of the first button (normally day)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sTextButton0">New value for property <code>textButton0</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setTextButton0(string sTextButton0);

						#endregion

						#region Methods for Property additionalTextButton0

						/// <summary>
						/// Gets current value of property {@link #getAdditionalTextButton0 additionalTextButton0}.
						/// 
						/// Additional text of the first button (normally day)
						/// </summary>
						/// <returns>Value of property <code>additionalTextButton0</code></returns>
						public extern virtual string getAdditionalTextButton0();

						/// <summary>
						/// Sets a new value for property {@link #getAdditionalTextButton0 additionalTextButton0}.
						/// 
						/// Additional text of the first button (normally day)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sAdditionalTextButton0">New value for property <code>additionalTextButton0</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setAdditionalTextButton0(string sAdditionalTextButton0);

						#endregion

						#region Methods for Property ariaLabelButton0

						/// <summary>
						/// Gets current value of property {@link #getAriaLabelButton0 ariaLabelButton0}.
						/// 
						/// aria-label of the first button (normally day)
						/// </summary>
						/// <returns>Value of property <code>ariaLabelButton0</code></returns>
						public extern virtual string getAriaLabelButton0();

						/// <summary>
						/// Sets a new value for property {@link #getAriaLabelButton0 ariaLabelButton0}.
						/// 
						/// aria-label of the first button (normally day)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sAriaLabelButton0">New value for property <code>ariaLabelButton0</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setAriaLabelButton0(string sAriaLabelButton0);

						#endregion

						#region Methods for Property visibleButton0

						/// <summary>
						/// Gets current value of property {@link #getVisibleButton0 visibleButton0}.
						/// 
						/// If set, the first button will be displayed
						/// 
						/// <b>Note:</b> The default is set to false to be compatible to older versions
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>visibleButton0</code></returns>
						public extern virtual bool getVisibleButton0();

						/// <summary>
						/// Sets a new value for property {@link #getVisibleButton0 visibleButton0}.
						/// 
						/// If set, the first button will be displayed
						/// 
						/// <b>Note:</b> The default is set to false to be compatible to older versions
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bVisibleButton0">New value for property <code>visibleButton0</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setVisibleButton0(bool bVisibleButton0);

						#endregion

						#region Methods for Property textButton1

						/// <summary>
						/// Gets current value of property {@link #getTextButton1 textButton1}.
						/// 
						/// Text of the second button (normally month)
						/// </summary>
						/// <returns>Value of property <code>textButton1</code></returns>
						public extern virtual string getTextButton1();

						/// <summary>
						/// Sets a new value for property {@link #getTextButton1 textButton1}.
						/// 
						/// Text of the second button (normally month)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sTextButton1">New value for property <code>textButton1</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setTextButton1(string sTextButton1);

						#endregion

						#region Methods for Property additionalTextButton1

						/// <summary>
						/// Gets current value of property {@link #getAdditionalTextButton1 additionalTextButton1}.
						/// 
						/// Additional text of the second button (normally month)
						/// </summary>
						/// <returns>Value of property <code>additionalTextButton1</code></returns>
						public extern virtual string getAdditionalTextButton1();

						/// <summary>
						/// Sets a new value for property {@link #getAdditionalTextButton1 additionalTextButton1}.
						/// 
						/// Additional text of the second button (normally month)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sAdditionalTextButton1">New value for property <code>additionalTextButton1</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setAdditionalTextButton1(string sAdditionalTextButton1);

						#endregion

						#region Methods for Property ariaLabelButton1

						/// <summary>
						/// Gets current value of property {@link #getAriaLabelButton1 ariaLabelButton1}.
						/// 
						/// aria-label of the second button (normally month)
						/// </summary>
						/// <returns>Value of property <code>ariaLabelButton1</code></returns>
						public extern virtual string getAriaLabelButton1();

						/// <summary>
						/// Sets a new value for property {@link #getAriaLabelButton1 ariaLabelButton1}.
						/// 
						/// aria-label of the second button (normally month)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sAriaLabelButton1">New value for property <code>ariaLabelButton1</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setAriaLabelButton1(string sAriaLabelButton1);

						#endregion

						#region Methods for Property visibleButton1

						/// <summary>
						/// Gets current value of property {@link #getVisibleButton1 visibleButton1}.
						/// 
						/// If set, the second button will be displayed
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>visibleButton1</code></returns>
						public extern virtual bool getVisibleButton1();

						/// <summary>
						/// Sets a new value for property {@link #getVisibleButton1 visibleButton1}.
						/// 
						/// If set, the second button will be displayed
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bVisibleButton1">New value for property <code>visibleButton1</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setVisibleButton1(bool bVisibleButton1);

						#endregion

						#region Methods for Property textButton2

						/// <summary>
						/// Gets current value of property {@link #getTextButton2 textButton2}.
						/// 
						/// Text of the third button (normally year)
						/// </summary>
						/// <returns>Value of property <code>textButton2</code></returns>
						public extern virtual string getTextButton2();

						/// <summary>
						/// Sets a new value for property {@link #getTextButton2 textButton2}.
						/// 
						/// Text of the third button (normally year)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sTextButton2">New value for property <code>textButton2</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setTextButton2(string sTextButton2);

						#endregion

						#region Methods for Property additionalTextButton2

						/// <summary>
						/// Gets current value of property {@link #getAdditionalTextButton2 additionalTextButton2}.
						/// 
						/// Additional text of the third button (normally year)
						/// </summary>
						/// <returns>Value of property <code>additionalTextButton2</code></returns>
						public extern virtual string getAdditionalTextButton2();

						/// <summary>
						/// Sets a new value for property {@link #getAdditionalTextButton2 additionalTextButton2}.
						/// 
						/// Additional text of the third button (normally year)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sAdditionalTextButton2">New value for property <code>additionalTextButton2</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setAdditionalTextButton2(string sAdditionalTextButton2);

						#endregion

						#region Methods for Property ariaLabelButton2

						/// <summary>
						/// Gets current value of property {@link #getAriaLabelButton2 ariaLabelButton2}.
						/// 
						/// aria-label of the third button (normally year)
						/// </summary>
						/// <returns>Value of property <code>ariaLabelButton2</code></returns>
						public extern virtual string getAriaLabelButton2();

						/// <summary>
						/// Sets a new value for property {@link #getAriaLabelButton2 ariaLabelButton2}.
						/// 
						/// aria-label of the third button (normally year)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sAriaLabelButton2">New value for property <code>ariaLabelButton2</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setAriaLabelButton2(string sAriaLabelButton2);

						#endregion

						#region Methods for Property visibleButton2

						/// <summary>
						/// Gets current value of property {@link #getVisibleButton2 visibleButton2}.
						/// 
						/// If set, the third button will be displayed
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>visibleButton2</code></returns>
						public extern virtual bool getVisibleButton2();

						/// <summary>
						/// Sets a new value for property {@link #getVisibleButton2 visibleButton2}.
						/// 
						/// If set, the third button will be displayed
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bVisibleButton2">New value for property <code>visibleButton2</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setVisibleButton2(bool bVisibleButton2);

						#endregion

						#region Methods for Property enabledPrevious

						/// <summary>
						/// Gets current value of property {@link #getEnabledPrevious enabledPrevious}.
						/// 
						/// Enables the previous button
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>enabledPrevious</code></returns>
						public extern virtual bool getEnabledPrevious();

						/// <summary>
						/// Sets a new value for property {@link #getEnabledPrevious enabledPrevious}.
						/// 
						/// Enables the previous button
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bEnabledPrevious">New value for property <code>enabledPrevious</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setEnabledPrevious(bool bEnabledPrevious);

						#endregion

						#region Methods for Property enabledNext

						/// <summary>
						/// Gets current value of property {@link #getEnabledNext enabledNext}.
						/// 
						/// Enables the Next button
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>enabledNext</code></returns>
						public extern virtual bool getEnabledNext();

						/// <summary>
						/// Sets a new value for property {@link #getEnabledNext enabledNext}.
						/// 
						/// Enables the Next button
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bEnabledNext">New value for property <code>enabledNext</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header setEnabledNext(bool bEnabledNext);

						#endregion

						#region Methods for Event pressPrevious

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressPrevious pressPrevious} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Previous button pressed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Header</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressPrevious(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressPrevious pressPrevious} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Previous button pressed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressPrevious(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressPrevious pressPrevious} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Previous button pressed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressPrevious(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressPrevious pressPrevious} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Previous button pressed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Header</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressPrevious(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:pressPrevious pressPrevious} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header detachPressPrevious(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:pressPrevious pressPrevious} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header firePressPrevious(object mParameters);

						/// <summary>
						/// Fires event {@link #event:pressPrevious pressPrevious} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header firePressPrevious();

						#endregion

						#region Methods for Event pressNext

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressNext pressNext} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Next button pressed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Header</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressNext(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressNext pressNext} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Next button pressed
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressNext(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressNext pressNext} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Next button pressed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressNext(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressNext pressNext} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Next button pressed
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Header</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressNext(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:pressNext pressNext} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header detachPressNext(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:pressNext pressNext} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header firePressNext(object mParameters);

						/// <summary>
						/// Fires event {@link #event:pressNext pressNext} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header firePressNext();

						#endregion

						#region Methods for Event pressButton0

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton0 pressButton0} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// First button pressed (normally day)
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Header</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton0(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton0 pressButton0} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// First button pressed (normally day)
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton0(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton0 pressButton0} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// First button pressed (normally day)
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton0(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton0 pressButton0} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// First button pressed (normally day)
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Header</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton0(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:pressButton0 pressButton0} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header detachPressButton0(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:pressButton0 pressButton0} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header firePressButton0(object mParameters);

						/// <summary>
						/// Fires event {@link #event:pressButton0 pressButton0} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header firePressButton0();

						#endregion

						#region Methods for Event pressButton1

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton1 pressButton1} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Second button pressed (normally month)
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Header</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton1(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton1 pressButton1} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Second button pressed (normally month)
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton1(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton1 pressButton1} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Second button pressed (normally month)
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton1(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton1 pressButton1} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Second button pressed (normally month)
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Header</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton1(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:pressButton1 pressButton1} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header detachPressButton1(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:pressButton1 pressButton1} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header firePressButton1(object mParameters);

						/// <summary>
						/// Fires event {@link #event:pressButton1 pressButton1} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header firePressButton1();

						#endregion

						#region Methods for Event pressButton2

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton2 pressButton2} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Third button pressed (normally year)
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Header</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton2(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton2 pressButton2} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Third button pressed (normally year)
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton2(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton2 pressButton2} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Third button pressed (normally year)
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton2(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:pressButton2 pressButton2} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.calendar.Header</code> itself.
						/// 
						/// Third button pressed (normally year)
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.calendar.Header</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header attachPressButton2(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:pressButton2 pressButton2} event of this <code>sap.ui.unified.calendar.Header</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header detachPressButton2(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:pressButton2 pressButton2} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header firePressButton2(object mParameters);

						/// <summary>
						/// Fires event {@link #event:pressButton2 pressButton2} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.unified.calendar.Header firePressButton2();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.Header with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.Header with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.unified.calendar.Header with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.unified.calendar.Header.
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
