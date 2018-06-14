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
			/// A control that is used for multi-line input of text. <h3>Overview</h3> The text area is used to enter multiple lines of text. When empty, it can hold a placeholder similar to an {@link sap.m.Input input}. You can define the height and width of the text area and also determine specific behavior when handling long texts. <h3>Structure</h3> Parameters that determine the size: <ul> <li><code>rows</code> - Number of visible text lines (overruled by <code>height</code>, if both are set)</li> <li><code>cols</code> - Number of visible characters per line line (overruled by <code>width</code>, if both are set)</li> <li><code>height</code> - Height of the control</li> <li><code>width</code> - Width of the control</li> </ul> Parameters that determine the behavior: <ul> <li><code>growing</code> - The text area adjusts its size based on the content</li> <li><code>growingMaxLines</code> - Threshold for the <code>growing</code> property (shouldn't exceed the screen size)</li> <li><code>maxLength</code> - Maximum number of characters that can be entered in a text area</li> <li><code>wrapping</code> - The way the entered text is wrapped by the control</li> <li><code>showExceededText</code> - Determines how text beyond the <code>maxLength</code> length is handled</li> </ul> <h3>Usage</h3> <h4>When to use</h4> <ul> <li>You want to enter multiple lines of text.</li> <li>Always provide labels for a text area.</li> <li>A placeholder does not substitute a label.</li> </ul> <h3>Responsive Behavior</h3> <ul> <li>On smaller screens, you can scroll down the text area to see the entire text. To indicate that the text continues, the control shows only half of the last line.</li> <li>If you have a growing text area, have in mind that its maximum height should not exceed the height of the screen. If that is the case, the screen height is used instead.</li> <li>If <code>showExceededText</code> is set to TRUE and you paste a longer text, all characters beyond the <code>maxLength</code> limit are automatically selected.</li> <li>If <code>showExceededText</code> is set to TRUE, the control will display a counter for the remaining characters.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class TextArea : sap.m.InputBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.InputBase.Settings
				{
					/// <summary>
					/// Defines the number of visible text lines for the control. <b>Note:</b> The <code>height</code> property wins over the <code>rows</code> property, if both are set.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> rows;

					/// <summary>
					/// Defines the visible width of the control, in average character widths. <b>Note:</b> The <code>width</code> property wins over the <code>cols</code> property, if both are set.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> cols;

					/// <summary>
					/// Defines the height of the control.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> height;

					/// <summary>
					/// Defines the maximum number of characters that the <code>value</code> can be.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> maxLength;

					/// <summary>
					/// Determines whether the characters, exceeding the maximum allowed character count, are visible in the input field.
					/// 
					/// If set to <code>false</code> the user is not allowed to enter more characters than what is set in the <code>maxLength</code> property. If set to <code>true</code> the characters exceeding the <code>maxLength</code> value are selected on paste and the counter below the input field displays their number.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showExceededText;

					/// <summary>
					/// Indicates how the control wraps the text, e.g. <code>Soft</code>, <code>Hard</code>, <code>Off</code>.
					/// </summary>
					public Union<sap.ui.core.Wrapping, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> wrapping;

					/// <summary>
					/// Indicates when the <code>value</code> property gets updated with the user changes. Setting it to <code>true</code> updates the <code>value</code> property whenever the user has modified the text shown on the text area.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> valueLiveUpdate;

					/// <summary>
					/// Indicates the ability of the control to automatically grow and shrink dynamically with its content. <b>Note:</b> The <code>height</code> property is ignored, if this property set to <code>true</code>.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> growing;

					/// <summary>
					/// Defines the maximum number of lines that the control can grow.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> growingMaxLines;

					/// <summary>
					/// Is fired whenever the user has modified the text shown on the text area.
					/// </summary>
					public sap.m.SubmitOrChangeDelegate liveChange;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new TextArea.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TextArea(string sId, sap.m.TextArea.Settings mSettings);

				/// <summary>
				/// Constructor for a new TextArea.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern TextArea(string sId);

				/// <summary>
				/// Constructor for a new TextArea.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern TextArea();

				/// <summary>
				/// Constructor for a new TextArea.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TextArea(sap.m.TextArea.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property rows

				/// <summary>
				/// Gets current value of property {@link #getRows rows}.
				/// 
				/// Defines the number of visible text lines for the control. <b>Note:</b> The <code>height</code> property wins over the <code>rows</code> property, if both are set.
				/// 
				/// Default value is <code>2</code>.
				/// </summary>
				/// <returns>Value of property <code>rows</code></returns>
				public extern virtual int getRows();

				/// <summary>
				/// Sets a new value for property {@link #getRows rows}.
				/// 
				/// Defines the number of visible text lines for the control. <b>Note:</b> The <code>height</code> property wins over the <code>rows</code> property, if both are set.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>2</code>.
				/// </summary>
				/// <param name="iRows">New value for property <code>rows</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea setRows(int iRows);

				#endregion

				#region Methods for Property cols

				/// <summary>
				/// Gets current value of property {@link #getCols cols}.
				/// 
				/// Defines the visible width of the control, in average character widths. <b>Note:</b> The <code>width</code> property wins over the <code>cols</code> property, if both are set.
				/// 
				/// Default value is <code>20</code>.
				/// </summary>
				/// <returns>Value of property <code>cols</code></returns>
				public extern virtual int getCols();

				/// <summary>
				/// Sets a new value for property {@link #getCols cols}.
				/// 
				/// Defines the visible width of the control, in average character widths. <b>Note:</b> The <code>width</code> property wins over the <code>cols</code> property, if both are set.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>20</code>.
				/// </summary>
				/// <param name="iCols">New value for property <code>cols</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea setCols(int iCols);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// Defines the height of the control.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// Defines the height of the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property maxLength

				/// <summary>
				/// Gets current value of property {@link #getMaxLength maxLength}.
				/// 
				/// Defines the maximum number of characters that the <code>value</code> can be.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>maxLength</code></returns>
				public extern virtual int getMaxLength();

				/// <summary>
				/// Sets a new value for property {@link #getMaxLength maxLength}.
				/// 
				/// Defines the maximum number of characters that the <code>value</code> can be.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="iMaxLength">New value for property <code>maxLength</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea setMaxLength(int iMaxLength);

				#endregion

				#region Methods for Property showExceededText

				/// <summary>
				/// Gets current value of property {@link #getShowExceededText showExceededText}.
				/// 
				/// Determines whether the characters, exceeding the maximum allowed character count, are visible in the input field.
				/// 
				/// If set to <code>false</code> the user is not allowed to enter more characters than what is set in the <code>maxLength</code> property. If set to <code>true</code> the characters exceeding the <code>maxLength</code> value are selected on paste and the counter below the input field displays their number.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showExceededText</code></returns>
				public extern virtual bool getShowExceededText();

				/// <summary>
				/// Sets a new value for property {@link #getShowExceededText showExceededText}.
				/// 
				/// Determines whether the characters, exceeding the maximum allowed character count, are visible in the input field.
				/// 
				/// If set to <code>false</code> the user is not allowed to enter more characters than what is set in the <code>maxLength</code> property. If set to <code>true</code> the characters exceeding the <code>maxLength</code> value are selected on paste and the counter below the input field displays their number.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowExceededText">New value for property <code>showExceededText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea setShowExceededText(bool bShowExceededText);

				#endregion

				#region Methods for Property wrapping

				/// <summary>
				/// Gets current value of property {@link #getWrapping wrapping}.
				/// 
				/// Indicates how the control wraps the text, e.g. <code>Soft</code>, <code>Hard</code>, <code>Off</code>.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>wrapping</code></returns>
				public extern virtual sap.ui.core.Wrapping getWrapping();

				/// <summary>
				/// Sets a new value for property {@link #getWrapping wrapping}.
				/// 
				/// Indicates how the control wraps the text, e.g. <code>Soft</code>, <code>Hard</code>, <code>Off</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sWrapping">New value for property <code>wrapping</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea setWrapping(sap.ui.core.Wrapping sWrapping);

				#endregion

				#region Methods for Property valueLiveUpdate

				/// <summary>
				/// Gets current value of property {@link #getValueLiveUpdate valueLiveUpdate}.
				/// 
				/// Indicates when the <code>value</code> property gets updated with the user changes. Setting it to <code>true</code> updates the <code>value</code> property whenever the user has modified the text shown on the text area.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>valueLiveUpdate</code></returns>
				public extern virtual bool getValueLiveUpdate();

				/// <summary>
				/// Sets a new value for property {@link #getValueLiveUpdate valueLiveUpdate}.
				/// 
				/// Indicates when the <code>value</code> property gets updated with the user changes. Setting it to <code>true</code> updates the <code>value</code> property whenever the user has modified the text shown on the text area.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bValueLiveUpdate">New value for property <code>valueLiveUpdate</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea setValueLiveUpdate(bool bValueLiveUpdate);

				#endregion

				#region Methods for Property growing

				/// <summary>
				/// Gets current value of property {@link #getGrowing growing}.
				/// 
				/// Indicates the ability of the control to automatically grow and shrink dynamically with its content. <b>Note:</b> The <code>height</code> property is ignored, if this property set to <code>true</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>growing</code></returns>
				public extern virtual bool getGrowing();

				/// <summary>
				/// Sets a new value for property {@link #getGrowing growing}.
				/// 
				/// Indicates the ability of the control to automatically grow and shrink dynamically with its content. <b>Note:</b> The <code>height</code> property is ignored, if this property set to <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bGrowing">New value for property <code>growing</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea setGrowing(bool bGrowing);

				#endregion

				#region Methods for Property growingMaxLines

				/// <summary>
				/// Gets current value of property {@link #getGrowingMaxLines growingMaxLines}.
				/// 
				/// Defines the maximum number of lines that the control can grow.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>growingMaxLines</code></returns>
				public extern virtual int getGrowingMaxLines();

				/// <summary>
				/// Sets a new value for property {@link #getGrowingMaxLines growingMaxLines}.
				/// 
				/// Defines the maximum number of lines that the control can grow.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="iGrowingMaxLines">New value for property <code>growingMaxLines</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea setGrowingMaxLines(int iGrowingMaxLines);

				#endregion

				#region Methods for Aggregation _counter

				#endregion

				#region Methods for Event liveChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.TextArea</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TextArea</code> itself.
				/// 
				/// Is fired whenever the user has modified the text shown on the text area.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TextArea</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea attachLiveChange(object oData, sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.TextArea</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TextArea</code> itself.
				/// 
				/// Is fired whenever the user has modified the text shown on the text area.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea attachLiveChange(object oData, sap.m.SubmitOrChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.TextArea</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TextArea</code> itself.
				/// 
				/// Is fired whenever the user has modified the text shown on the text area.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea attachLiveChange(sap.m.SubmitOrChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.TextArea</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TextArea</code> itself.
				/// 
				/// Is fired whenever the user has modified the text shown on the text area.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TextArea</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea attachLiveChange(sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.m.TextArea</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea detachLiveChange(sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea fireLiveChange(sap.m.SubmitOrChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TextArea fireLiveChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.TextArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TextArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TextArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.TextArea.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
