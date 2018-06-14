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
			public static partial class layout
			{
				/// <summary>
				/// A layout container with a fixed and a flexible part. <h3>Overview</h3> The FixFlex control builds the container for a layout with a fixed and a flexible part. The flexible container adapts its size to the fix container. <h4>Guidelines:</h4> <ul> <li>The fix container can hold any number of controls, while the flexible container can hold only one</li> <li>In order for the FixFlex to stretch properly, the parent element, in which the control is placed, needs to have a specified height or needs to have an absolute position.</li> <li>Avoid nesting FixFlex in other flexbox-based layout controls ({@link sap.ui.layout.FixFlex FixFlex}, {@link sap.m.FlexBox FlexBox}, Hbox, Vbox). Otherwise, contents may be not accessible or multiple scrollbars can appear.</li> </ul> <h3>Structure</h3> The behavior of the FixFlex is controlled by the following properties: <ul> <li><code>fixContentSize</code> - The width/height of the fix part of the control</li> <li><code>fixFirst</code> - The ordering of the fix and flex part</li> <li><code>minFlexSize</code> - Scrolling inside the flex part, if its contents are large</li> <li><code>vertical</code> - Alignment of the FixFlex control</li> </ul> <h3>Responsive Behavior</h3> <ul> <li>If the child control of the flex or the fix container has width/height bigger than the container itself, the child control will be cropped in the view.</li> <li>If minFlexSize is set, then a scrollbar is shown in the flexible part, depending on the <code>vertical</code> property.</li> </ul>
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class FixFlex : sap.ui.core.Control
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
						/// Determines the direction of the layout of child elements. True for vertical and false for horizontal layout.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> vertical;

						/// <summary>
						/// Determines whether the fixed-size area should be on the beginning/top ( if the value is "true") or end/bottom ( if the value is "false").
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> fixFirst;

						/// <summary>
						/// Determines the height (if the vertical property is "true") or the width (if the vertical property is "false") of the fixed area. If left at the default value "auto", the fixed-size area will be as large as its content. In this case the content cannot use percentage sizes.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> fixContentSize;

						/// <summary>
						/// Enables scrolling inside the flexible part. The given size is calculated in "px". If the child control in the flexible part is larger than the available flexible size on the screen and if the available size for the flexible part is smaller or equal to the minFlexSize value, the scroll will be for the entire FixFlex control.
						/// </summary>
						public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> minFlexSize;

						/// <summary>
						/// Controls in the fixed part of the layout.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> fixContent;

						/// <summary>
						/// Control in the stretching part of the layout.
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> flexContent;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new FixFlex.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern FixFlex(string sId, sap.ui.layout.FixFlex.Settings mSettings);

					/// <summary>
					/// Constructor for a new FixFlex.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern FixFlex(string sId);

					/// <summary>
					/// Constructor for a new FixFlex.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern FixFlex();

					/// <summary>
					/// Constructor for a new FixFlex.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern FixFlex(sap.ui.layout.FixFlex.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property vertical

					/// <summary>
					/// Gets current value of property {@link #getVertical vertical}.
					/// 
					/// Determines the direction of the layout of child elements. True for vertical and false for horizontal layout.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>vertical</code></returns>
					public extern virtual bool getVertical();

					/// <summary>
					/// Sets a new value for property {@link #getVertical vertical}.
					/// 
					/// Determines the direction of the layout of child elements. True for vertical and false for horizontal layout.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVertical">New value for property <code>vertical</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.FixFlex setVertical(bool bVertical);

					#endregion

					#region Methods for Property fixFirst

					/// <summary>
					/// Gets current value of property {@link #getFixFirst fixFirst}.
					/// 
					/// Determines whether the fixed-size area should be on the beginning/top ( if the value is "true") or end/bottom ( if the value is "false").
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>fixFirst</code></returns>
					public extern virtual bool getFixFirst();

					/// <summary>
					/// Sets a new value for property {@link #getFixFirst fixFirst}.
					/// 
					/// Determines whether the fixed-size area should be on the beginning/top ( if the value is "true") or end/bottom ( if the value is "false").
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bFixFirst">New value for property <code>fixFirst</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.FixFlex setFixFirst(bool bFixFirst);

					#endregion

					#region Methods for Property fixContentSize

					/// <summary>
					/// Gets current value of property {@link #getFixContentSize fixContentSize}.
					/// 
					/// Determines the height (if the vertical property is "true") or the width (if the vertical property is "false") of the fixed area. If left at the default value "auto", the fixed-size area will be as large as its content. In this case the content cannot use percentage sizes.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <returns>Value of property <code>fixContentSize</code></returns>
					public extern virtual sap.ui.core.CSSSize getFixContentSize();

					/// <summary>
					/// Sets a new value for property {@link #getFixContentSize fixContentSize}.
					/// 
					/// Determines the height (if the vertical property is "true") or the width (if the vertical property is "false") of the fixed area. If left at the default value "auto", the fixed-size area will be as large as its content. In this case the content cannot use percentage sizes.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <param name="sFixContentSize">New value for property <code>fixContentSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.FixFlex setFixContentSize(sap.ui.core.CSSSize sFixContentSize);

					#endregion

					#region Methods for Property minFlexSize

					/// <summary>
					/// Gets current value of property {@link #getMinFlexSize minFlexSize}.
					/// 
					/// Enables scrolling inside the flexible part. The given size is calculated in "px". If the child control in the flexible part is larger than the available flexible size on the screen and if the available size for the flexible part is smaller or equal to the minFlexSize value, the scroll will be for the entire FixFlex control.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>minFlexSize</code></returns>
					public extern virtual int getMinFlexSize();

					/// <summary>
					/// Sets a new value for property {@link #getMinFlexSize minFlexSize}.
					/// 
					/// Enables scrolling inside the flexible part. The given size is calculated in "px". If the child control in the flexible part is larger than the available flexible size on the screen and if the available size for the flexible part is smaller or equal to the minFlexSize value, the scroll will be for the entire FixFlex control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iMinFlexSize">New value for property <code>minFlexSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.FixFlex setMinFlexSize(int iMinFlexSize);

					#endregion

					#region Methods for Aggregation fixContent

					/// <summary>
					/// Gets content of aggregation {@link #getFixContent fixContent}.
					/// 
					/// Controls in the fixed part of the layout.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getFixContent();

					/// <summary>
					/// Destroys all the fixContent in the aggregation {@link #getFixContent fixContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.FixFlex destroyFixContent();

					/// <summary>
					/// Inserts a fixContent into the aggregation {@link #getFixContent fixContent}.
					/// </summary>
					/// <param name="oFixContent">The fixContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the fixContent should be inserted at; for a negative value of <code>iIndex</code>, the fixContent is inserted at position 0; for a value greater than the current size of the aggregation, the fixContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.FixFlex insertFixContent(sap.ui.core.Control oFixContent, int iIndex);

					/// <summary>
					/// Adds some fixContent to the aggregation {@link #getFixContent fixContent}.
					/// </summary>
					/// <param name="oFixContent">The fixContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.FixFlex addFixContent(sap.ui.core.Control oFixContent);

					/// <summary>
					/// Removes a fixContent from the aggregation {@link #getFixContent fixContent}.
					/// </summary>
					/// <param name="vFixContent">The fixContent to remove or its index or id</param>
					/// <returns>The removed fixContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeFixContent(Union<int, string, sap.ui.core.Control> vFixContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getFixContent fixContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oFixContent">The fixContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfFixContent(sap.ui.core.Control oFixContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getFixContent fixContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllFixContent();

					#endregion

					#region Methods for Aggregation flexContent

					/// <summary>
					/// Gets content of aggregation {@link #getFlexContent flexContent}.
					/// 
					/// Control in the stretching part of the layout.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control getFlexContent();

					/// <summary>
					/// Destroys the flexContent in the aggregation {@link #getFlexContent flexContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.FixFlex destroyFlexContent();

					/// <summary>
					/// Sets the aggregated {@link #getFlexContent flexContent}.
					/// </summary>
					/// <param name="oFlexContent">The flexContent to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.FixFlex setFlexContent(sap.ui.core.Control oFlexContent);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.FixFlex with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.FixFlex with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.FixFlex with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.FixFlex.
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
