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
			public static partial class layout
			{
				/// <summary>
				/// The <code>Grid</code> control is a layout which positions its child controls in a 12 column flow layout. Its children can be specified to take on a variable amount of columns depending on available screen size. With this control it is possible to achieve flexible layouts and line-breaks for extra large-, large-, medium- and small-sized screens, such as large desktop, desktop, tablet, and mobile. The <code>Grid</code> control's width can be percentage- or pixel-based and the spacing between its columns can be set to various predefined values.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.layout.Grid")]
				public partial class Grid : sap.ui.core.Control
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
						/// Optional. Width of the Grid. If not specified, then 100%.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Optional. Vertical spacing between the rows in the Grid. In rem, allowed values are 0, 0.5, 1 and 2.
						/// </summary>
						public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> vSpacing;

						/// <summary>
						/// Optional. Horizontal spacing between the content in the Grid. In rem, allowed values are 0, 0.5 , 1 or 2.
						/// </summary>
						public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> hSpacing;

						/// <summary>
						/// Optional. Position of the Grid in the window or surrounding container. Possible values are "Center", "Left" and "Right".
						/// </summary>
						public Union<sap.ui.layout.GridPosition, string, sap.ui.@base.ManagedObject.BindPropertyInfo> position;

						/// <summary>
						/// Optional. A string type that represents Grid's default span values for large, medium and small screens for the whole Grid. Allowed values are separated by space Letters L, M or S followed by number of columns from 1 to 12 that the container has to take, for example: "L2 M4 S6", "M12", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
						/// </summary>
						public Union<sap.ui.layout.GridSpan, string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultSpan;

						/// <summary>
						/// Optional. Defines default for the whole Grid numbers of empty columns before the current span begins. It can be defined for large, medium and small screens. Allowed values are separated by space Letters L, M or S followed by number of columns from 0 to 11 that the container has to take, for example: "L2 M4 S6", "M11", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
						/// </summary>
						public Union<sap.ui.layout.GridIndent, string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultIndent;

						/// <summary>
						/// If true then not the media Query ( device screen size), but the size of the container surrounding the grid defines the current range (large, medium or small).
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> containerQuery;

						/// <summary>
						/// Controls that are placed into Grid layout.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Association to controls / IDs that label this control (see WAI-ARIA attribute <code>aria-labelledby</code>).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>Grid</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Grid(string sId, sap.ui.layout.Grid.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>Grid</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern Grid(string sId);

					/// <summary>
					/// Constructor for a new <code>Grid</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Grid();

					/// <summary>
					/// Constructor for a new <code>Grid</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Grid(sap.ui.layout.Grid.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Optional. Width of the Grid. If not specified, then 100%.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Optional. Width of the Grid. If not specified, then 100%.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Grid setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property vSpacing

					/// <summary>
					/// Gets current value of property {@link #getVSpacing vSpacing}.
					/// 
					/// Optional. Vertical spacing between the rows in the Grid. In rem, allowed values are 0, 0.5, 1 and 2.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>vSpacing</code></returns>
					public extern virtual float getVSpacing();

					/// <summary>
					/// Sets a new value for property {@link #getVSpacing vSpacing}.
					/// 
					/// Optional. Vertical spacing between the rows in the Grid. In rem, allowed values are 0, 0.5, 1 and 2.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="fVSpacing">New value for property <code>vSpacing</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Grid setVSpacing(float fVSpacing);

					#endregion

					#region Methods for Property hSpacing

					/// <summary>
					/// Gets current value of property {@link #getHSpacing hSpacing}.
					/// 
					/// Optional. Horizontal spacing between the content in the Grid. In rem, allowed values are 0, 0.5 , 1 or 2.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>hSpacing</code></returns>
					public extern virtual float getHSpacing();

					/// <summary>
					/// Sets a new value for property {@link #getHSpacing hSpacing}.
					/// 
					/// Optional. Horizontal spacing between the content in the Grid. In rem, allowed values are 0, 0.5 , 1 or 2.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="fHSpacing">New value for property <code>hSpacing</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Grid setHSpacing(float fHSpacing);

					#endregion

					#region Methods for Property position

					/// <summary>
					/// Gets current value of property {@link #getPosition position}.
					/// 
					/// Optional. Position of the Grid in the window or surrounding container. Possible values are "Center", "Left" and "Right".
					/// 
					/// Default value is <code>Left</code>.
					/// </summary>
					/// <returns>Value of property <code>position</code></returns>
					public extern virtual sap.ui.layout.GridPosition getPosition();

					/// <summary>
					/// Sets a new value for property {@link #getPosition position}.
					/// 
					/// Optional. Position of the Grid in the window or surrounding container. Possible values are "Center", "Left" and "Right".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Left</code>.
					/// </summary>
					/// <param name="sPosition">New value for property <code>position</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Grid setPosition(sap.ui.layout.GridPosition sPosition);

					#endregion

					#region Methods for Property defaultSpan

					/// <summary>
					/// Gets current value of property {@link #getDefaultSpan defaultSpan}.
					/// 
					/// Optional. A string type that represents Grid's default span values for large, medium and small screens for the whole Grid. Allowed values are separated by space Letters L, M or S followed by number of columns from 1 to 12 that the container has to take, for example: "L2 M4 S6", "M12", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
					/// 
					/// Default value is <code>XL3 L3 M6 S12</code>.
					/// </summary>
					/// <returns>Value of property <code>defaultSpan</code></returns>
					public extern virtual sap.ui.layout.GridSpan getDefaultSpan();

					/// <summary>
					/// Sets a new value for property {@link #getDefaultSpan defaultSpan}.
					/// 
					/// Optional. A string type that represents Grid's default span values for large, medium and small screens for the whole Grid. Allowed values are separated by space Letters L, M or S followed by number of columns from 1 to 12 that the container has to take, for example: "L2 M4 S6", "M12", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>XL3 L3 M6 S12</code>.
					/// </summary>
					/// <param name="sDefaultSpan">New value for property <code>defaultSpan</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Grid setDefaultSpan(sap.ui.layout.GridSpan sDefaultSpan);

					#endregion

					#region Methods for Property defaultIndent

					/// <summary>
					/// Gets current value of property {@link #getDefaultIndent defaultIndent}.
					/// 
					/// Optional. Defines default for the whole Grid numbers of empty columns before the current span begins. It can be defined for large, medium and small screens. Allowed values are separated by space Letters L, M or S followed by number of columns from 0 to 11 that the container has to take, for example: "L2 M4 S6", "M11", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
					/// 
					/// Default value is <code>XL0 L0 M0 S0</code>.
					/// </summary>
					/// <returns>Value of property <code>defaultIndent</code></returns>
					public extern virtual sap.ui.layout.GridIndent getDefaultIndent();

					/// <summary>
					/// Sets a new value for property {@link #getDefaultIndent defaultIndent}.
					/// 
					/// Optional. Defines default for the whole Grid numbers of empty columns before the current span begins. It can be defined for large, medium and small screens. Allowed values are separated by space Letters L, M or S followed by number of columns from 0 to 11 that the container has to take, for example: "L2 M4 S6", "M11", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>XL0 L0 M0 S0</code>.
					/// </summary>
					/// <param name="sDefaultIndent">New value for property <code>defaultIndent</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Grid setDefaultIndent(sap.ui.layout.GridIndent sDefaultIndent);

					#endregion

					#region Methods for Property containerQuery

					/// <summary>
					/// Gets current value of property {@link #getContainerQuery containerQuery}.
					/// 
					/// If true then not the media Query ( device screen size), but the size of the container surrounding the grid defines the current range (large, medium or small).
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>containerQuery</code></returns>
					public extern virtual bool getContainerQuery();

					/// <summary>
					/// Sets a new value for property {@link #getContainerQuery containerQuery}.
					/// 
					/// If true then not the media Query ( device screen size), but the size of the container surrounding the grid defines the current range (large, medium or small).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bContainerQuery">New value for property <code>containerQuery</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Grid setContainerQuery(bool bContainerQuery);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// Controls that are placed into Grid layout.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Grid destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Grid insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Grid addContent(sap.ui.core.Control oContent);

					/// <summary>
					/// Removes a content from the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="vContent">The content to remove or its index or id</param>
					/// <returns>The removed content or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oContent">The content whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfContent(sap.ui.core.Control oContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getContent content}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllContent();

					#endregion

					#region Methods for Association ariaLabelledBy

					/// <summary>
					/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID[] getAriaLabelledBy();

					/// <summary>
					/// Adds some ariaLabelledBy into the association {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <param name="vAriaLabelledBy">The ariaLabelledBy to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Grid addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

					/// <summary>
					/// Removes an ariaLabelledBy from the association named {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <param name="vAriaLabelledBy">The ariaLabelledBy to be removed or its index or ID</param>
					/// <returns>The removed ariaLabelledBy or <code>null</code></returns>
					public extern virtual sap.ui.core.ID removeAriaLabelledBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

					/// <summary>
					/// Removes all the controls in the association named {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ID[] removeAllAriaLabelledBy();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.Grid with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.Grid with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.Grid with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the <code>Grid</code> accessibility information.
					/// </summary>
					/// <returns>The <code>Grid</code> accessibility information</returns>
					public extern override object getAccessibilityInfo();

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.Grid.
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
