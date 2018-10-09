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
					/// The Absolute Layout positions its child controls absolutely
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.AbsoluteLayout")]
					[Obsolete("Deprecated since 1.38.")]
					public partial class AbsoluteLayout : sap.ui.core.Control
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
							/// The overall width of the control. When not set, 100% is automatically set.
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

							/// <summary>
							/// The overall height of the control. When not set, 100% is automatically set.
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

							/// <summary>
							/// 'Auto', 'Scroll', 'Hidden', and 'None' are the available values for setting the vertical scrolling mode.
							/// </summary>
							public Union<sap.ui.core.Scrolling, string, sap.ui.@base.ManagedObject.BindPropertyInfo> verticalScrolling;

							/// <summary>
							/// 'Auto', 'Scroll', 'Hidden', and 'None' are the available values for setting the vertical scrolling mode.
							/// </summary>
							public Union<sap.ui.core.Scrolling, string, sap.ui.@base.ManagedObject.BindPropertyInfo> horizontalScrolling;

							/// <summary>
							/// Positioned child controls within the layout
							/// </summary>
							public Union<sap.ui.commons.layout.PositionContainer[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> positions;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new layout/AbsoluteLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern AbsoluteLayout(string sId, sap.ui.commons.layout.AbsoluteLayout.Settings mSettings);

						/// <summary>
						/// Constructor for a new layout/AbsoluteLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern AbsoluteLayout(string sId);

						/// <summary>
						/// Constructor for a new layout/AbsoluteLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern AbsoluteLayout();

						/// <summary>
						/// Constructor for a new layout/AbsoluteLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern AbsoluteLayout(sap.ui.commons.layout.AbsoluteLayout.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property width

						/// <summary>
						/// Gets current value of property {@link #getWidth width}.
						/// 
						/// The overall width of the control. When not set, 100% is automatically set.
						/// 
						/// Default value is <code>100%</code>.
						/// </summary>
						/// <returns>Value of property <code>width</code></returns>
						public extern virtual sap.ui.core.CSSSize getWidth();

						/// <summary>
						/// Sets the <code>width</code> property.
						/// </summary>
						/// <param name="sWidth">The passed width of the control.</param>
						/// <returns><code>this</code> Control reference for chaining.</returns>
						public extern virtual sap.ui.commons.layout.AbsoluteLayout setWidth(string sWidth);

						#endregion

						#region Methods for Property height

						/// <summary>
						/// Gets current value of property {@link #getHeight height}.
						/// 
						/// The overall height of the control. When not set, 100% is automatically set.
						/// 
						/// Default value is <code>100%</code>.
						/// </summary>
						/// <returns>Value of property <code>height</code></returns>
						public extern virtual sap.ui.core.CSSSize getHeight();

						/// <summary>
						/// Sets the <code>height</code> property.
						/// </summary>
						/// <param name="sHeight">The passed height of the control.</param>
						/// <returns><code>this</code> Control reference for chaining.</returns>
						public extern virtual sap.ui.commons.layout.AbsoluteLayout setHeight(string sHeight);

						#endregion

						#region Methods for Property verticalScrolling

						/// <summary>
						/// Gets current value of property {@link #getVerticalScrolling verticalScrolling}.
						/// 
						/// 'Auto', 'Scroll', 'Hidden', and 'None' are the available values for setting the vertical scrolling mode.
						/// 
						/// Default value is <code>Hidden</code>.
						/// </summary>
						/// <returns>Value of property <code>verticalScrolling</code></returns>
						public extern virtual sap.ui.core.Scrolling getVerticalScrolling();

						/// <summary>
						/// Sets the <code>verticalScrolling</code> property.
						/// </summary>
						/// <param name="oVerticalScrolling">Object that contains settings for Vertical scrolling.</param>
						/// <returns><code>this</code> Control reference for chaining.</returns>
						public extern virtual sap.ui.commons.layout.AbsoluteLayout setVerticalScrolling(object oVerticalScrolling);

						#endregion

						#region Methods for Property horizontalScrolling

						/// <summary>
						/// Gets current value of property {@link #getHorizontalScrolling horizontalScrolling}.
						/// 
						/// 'Auto', 'Scroll', 'Hidden', and 'None' are the available values for setting the vertical scrolling mode.
						/// 
						/// Default value is <code>Hidden</code>.
						/// </summary>
						/// <returns>Value of property <code>horizontalScrolling</code></returns>
						public extern virtual sap.ui.core.Scrolling getHorizontalScrolling();

						/// <summary>
						/// Sets the <code>horizontalScrolling</code> property.
						/// </summary>
						/// <param name="oHorizontalScrolling">Object that contains settings for Horizontal scrolling.</param>
						/// <returns><code>this</code> Control reference for chaining.</returns>
						public extern virtual sap.ui.commons.layout.AbsoluteLayout setHorizontalScrolling(object oHorizontalScrolling);

						#endregion

						#region Methods for Aggregation positions

						/// <summary>
						/// Gets content of aggregation {@link #getPositions positions}.
						/// 
						/// Positioned child controls within the layout
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.PositionContainer[] getPositions();

						/// <summary>
						/// Destroys all elements from the layout.
						/// </summary>
						/// <returns><code>this</code> Control reference for chaining.</returns>
						public extern virtual sap.ui.commons.layout.AbsoluteLayout destroyPositions();

						/// <summary>
						/// Inserts element to the layout on a specific index.
						/// </summary>
						/// <param name="oPosition">Element which must be positioned in the layout.</param>
						/// <param name="iIndex">Index of the element which is to be positioned.</param>
						/// <returns><code>this</code> Control reference for chaining.</returns>
						public extern virtual sap.ui.commons.layout.AbsoluteLayout insertPosition(object oPosition, int iIndex);

						/// <summary>
						/// Adds element to the layout.
						/// </summary>
						/// <param name="oPosition">Element which must be positioned in the layout.</param>
						/// <returns><code>this</code> Control reference for chaining.</returns>
						public extern virtual sap.ui.commons.layout.AbsoluteLayout addPosition(object oPosition);

						/// <summary>
						/// Removes element from the layout.
						/// </summary>
						/// <param name="vPosition">Element which must be removed from the positions element within the layout.</param>
						/// <returns>Removed element.</returns>
						public extern virtual object removePosition(object vPosition);

						/// <summary>
						/// Checks for the provided <code>sap.ui.commons.layout.PositionContainer</code> in the aggregation {@link #getPositions positions}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oPosition">The position whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfPosition(sap.ui.commons.layout.PositionContainer oPosition);

						/// <summary>
						/// Removes all elements from the layout.
						/// </summary>
						/// <returns>Removed elements.</returns>
						public extern virtual object removeAllPositions();

						#endregion

						#region Other methods

						/// <summary>
						/// Adds the given control and a corresponding position container into the aggregation named 'positions'. Returns 'this' to allow method chaining.
						/// </summary>
						/// <param name="oContent">The content to add; if empty, nothing is inserted.</param>
						/// <param name="oPos">JSON-like object which defines the position of the child control in the layout. The object is expected to have one or more from the attribute set top, bottom, left, right; each with a value of type sap.ui.core.CSSSize. If no object is given, the default is left=0px,right=0px</param>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.AbsoluteLayout addContent(sap.ui.core.Control oContent, object oPos);

						/// <summary>
						/// Destroys all aggregated position containers and their child controls. Returns 'this' to allow method chaining.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.AbsoluteLayout destroyContent();

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.AbsoluteLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.AbsoluteLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.AbsoluteLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns an array of the controls contained in the aggregated position containers (might be empty).
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.Control[] getContent();

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.layout.AbsoluteLayout.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Checks for the provided sap.ui.core.Control in the aggregated position containers, and returns the index of the container in the positions aggregation if found, or '-1' otherwise.
						/// </summary>
						/// <param name="oContent">The content of which the index is looked for</param>
						/// <returns></returns>
						public extern virtual int indexOfContent(sap.ui.core.Control oContent);

						/// <summary>
						/// Inserts the given control and a corresponding position container into the aggregation named 'positions'. Returns 'this' to allow method chaining.
						/// </summary>
						/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The '0'-based index where the content shall be inserted at. For a negative value of iIndex, the content is inserted at position '0'; for a value greater than the current size of the aggregation, the content is inserted at the last position.</param>
						/// <param name="oPos">JSON-like object which defines the position of the child control within the layout. The object is expected to have one or more from the attribute set top, bottom, left, right; each with a value of type sap.ui.core.CSSSize. If no object is given, the default is left=0px,right=0px.</param>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.AbsoluteLayout insertContent(sap.ui.core.Control oContent, int iIndex, object oPos);

						/// <summary>
						/// Removes all aggregated position containers. Returns an array of the controls contained in the removed position containers (might be empty).
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.Control[] removeAllContent();

						/// <summary>
						/// Removes the given control and its corresponding position container from the aggregation named 'positions'.
						/// </summary>
						/// <param name="oContent">The content control to remove, its ID, or the index of the corresponding position container in the 'positions' aggregation.</param>
						/// <returns></returns>
						public extern virtual sap.ui.core.Control removeContent(object oContent);

						/// <summary>
						/// Allows to set or change the position information of the given child control
						/// </summary>
						/// <param name="oControl">The child control for which to change the position information; if empty or not aggregated, nothing is changed</param>
						/// <param name="oPos">JSON-like object which defines the position of the child control. The object is expected to have one or more from the attribute set top, bottom, left, right; each with a value of type sap.ui.core.CSSSize. If no object is given, the default is used which is left=0px,right=0px.</param>
						/// <returns></returns>
						public extern virtual bool setPositionOfChild(sap.ui.core.Control oControl, object oPos);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
