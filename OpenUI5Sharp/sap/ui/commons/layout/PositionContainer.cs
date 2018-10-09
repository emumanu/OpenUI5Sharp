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
				public static partial class layout
				{
					/// <summary>
					/// Is used to specify the position of a control in the AbsoluteLayout
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.PositionContainer")]
					public partial class PositionContainer : sap.ui.core.Element
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.Element.Settings
						{
							/// <summary>
							/// Defines the distance to the top of the layout (as specified in HTML)
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> top;

							/// <summary>
							/// Defines the distance to the bottom of the layout (as specified in HTML)
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> bottom;

							/// <summary>
							/// Defines the distance to the left of the layout (as specified in HTML)
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> left;

							/// <summary>
							/// Defines the distance to the right of the layout (as specified in HTML)
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> right;

							/// <summary>
							/// Indicates whether this container shall be centered horizontally within the AbsoluteLayout area. The values of the attributes left and right are ignored when this feature is activated.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> centerHorizontally;

							/// <summary>
							/// Indicates whether this container should be centered vertically within the AbsoluteLayout area. The values of the attributes top and bottom are ignored when this feature is activated.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> centerVertically;

							/// <summary>
							/// Child control of the position container
							/// </summary>
							public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> control;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new layout/PositionContainer.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern PositionContainer(string sId, sap.ui.commons.layout.PositionContainer.Settings mSettings);

						/// <summary>
						/// Constructor for a new layout/PositionContainer.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern PositionContainer(string sId);

						/// <summary>
						/// Constructor for a new layout/PositionContainer.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern PositionContainer();

						/// <summary>
						/// Constructor for a new layout/PositionContainer.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern PositionContainer(sap.ui.commons.layout.PositionContainer.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property top

						/// <summary>
						/// Gets current value of property {@link #getTop top}.
						/// 
						/// Defines the distance to the top of the layout (as specified in HTML)
						/// </summary>
						/// <returns>Value of property <code>top</code></returns>
						public extern virtual sap.ui.core.CSSSize getTop();

						/// <summary>
						/// Sets a new value for property {@link #getTop top}.
						/// 
						/// Defines the distance to the top of the layout (as specified in HTML)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sTop">New value for property <code>top</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.PositionContainer setTop(sap.ui.core.CSSSize sTop);

						#endregion

						#region Methods for Property bottom

						/// <summary>
						/// Gets current value of property {@link #getBottom bottom}.
						/// 
						/// Defines the distance to the bottom of the layout (as specified in HTML)
						/// </summary>
						/// <returns>Value of property <code>bottom</code></returns>
						public extern virtual sap.ui.core.CSSSize getBottom();

						/// <summary>
						/// Sets a new value for property {@link #getBottom bottom}.
						/// 
						/// Defines the distance to the bottom of the layout (as specified in HTML)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sBottom">New value for property <code>bottom</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.PositionContainer setBottom(sap.ui.core.CSSSize sBottom);

						#endregion

						#region Methods for Property left

						/// <summary>
						/// Gets current value of property {@link #getLeft left}.
						/// 
						/// Defines the distance to the left of the layout (as specified in HTML)
						/// </summary>
						/// <returns>Value of property <code>left</code></returns>
						public extern virtual sap.ui.core.CSSSize getLeft();

						/// <summary>
						/// Sets a new value for property {@link #getLeft left}.
						/// 
						/// Defines the distance to the left of the layout (as specified in HTML)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sLeft">New value for property <code>left</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.PositionContainer setLeft(sap.ui.core.CSSSize sLeft);

						#endregion

						#region Methods for Property right

						/// <summary>
						/// Gets current value of property {@link #getRight right}.
						/// 
						/// Defines the distance to the right of the layout (as specified in HTML)
						/// </summary>
						/// <returns>Value of property <code>right</code></returns>
						public extern virtual sap.ui.core.CSSSize getRight();

						/// <summary>
						/// Sets a new value for property {@link #getRight right}.
						/// 
						/// Defines the distance to the right of the layout (as specified in HTML)
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sRight">New value for property <code>right</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.PositionContainer setRight(sap.ui.core.CSSSize sRight);

						#endregion

						#region Methods for Property centerHorizontally

						/// <summary>
						/// Gets current value of property {@link #getCenterHorizontally centerHorizontally}.
						/// 
						/// Indicates whether this container shall be centered horizontally within the AbsoluteLayout area. The values of the attributes left and right are ignored when this feature is activated.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>centerHorizontally</code></returns>
						public extern virtual bool getCenterHorizontally();

						/// <summary>
						/// Sets a new value for property {@link #getCenterHorizontally centerHorizontally}.
						/// 
						/// Indicates whether this container shall be centered horizontally within the AbsoluteLayout area. The values of the attributes left and right are ignored when this feature is activated.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bCenterHorizontally">New value for property <code>centerHorizontally</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.PositionContainer setCenterHorizontally(bool bCenterHorizontally);

						#endregion

						#region Methods for Property centerVertically

						/// <summary>
						/// Gets current value of property {@link #getCenterVertically centerVertically}.
						/// 
						/// Indicates whether this container should be centered vertically within the AbsoluteLayout area. The values of the attributes top and bottom are ignored when this feature is activated.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>centerVertically</code></returns>
						public extern virtual bool getCenterVertically();

						/// <summary>
						/// Sets a new value for property {@link #getCenterVertically centerVertically}.
						/// 
						/// Indicates whether this container should be centered vertically within the AbsoluteLayout area. The values of the attributes top and bottom are ignored when this feature is activated.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bCenterVertically">New value for property <code>centerVertically</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.PositionContainer setCenterVertically(bool bCenterVertically);

						#endregion

						#region Methods for Aggregation control

						/// <summary>
						/// Gets content of aggregation {@link #getControl control}.
						/// 
						/// Child control of the position container
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.Control getControl();

						/// <summary>
						/// Destroys the control in the aggregation {@link #getControl control}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.PositionContainer destroyControl();

						/// <summary>
						/// Sets the aggregated {@link #getControl control}.
						/// </summary>
						/// <param name="oControl">The control to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.PositionContainer setControl(sap.ui.core.Control oControl);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.PositionContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.PositionContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.PositionContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.layout.PositionContainer.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Updates the position properties of the container according to the given position in JSON style.
						/// </summary>
						/// <param name="oPos">JSON-like object which defines the position of the child control in the absolute layout. The object is expected to have one or more out of the attributes top, bottom, left, right (each with a value of type sap.ui.core.CSSSize). If no object is given, nothing is updated.</param>
						public extern virtual void updatePosition(object oPos);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
