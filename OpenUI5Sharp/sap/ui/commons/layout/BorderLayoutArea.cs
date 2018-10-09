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
					/// The BorderLayoutArea represents one area of a BorderLayout
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.BorderLayoutArea")]
					[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Page</code> control.")]
					public partial class BorderLayoutArea : sap.ui.core.Element
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
							/// Defines which area the element represents: top, begin, center, end, bottom
							/// </summary>
							public Union<sap.ui.commons.layout.BorderLayoutAreaTypes, string, sap.ui.@base.ManagedObject.BindPropertyInfo> areaId;

							/// <summary>
							/// The overflow mode of the area in horizontal direction as CSS value
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> overflowX;

							/// <summary>
							/// The overflow mode of the area in vertical direction as CSS value
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> overflowY;

							/// <summary>
							/// The content alignment as CSS value
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentAlign;

							/// <summary>
							/// Defines the height or the width. Is not used when the area element is in Center.
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> size;

							/// <summary>
							/// Invisible controls are not rendered
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

							/// <summary>
							/// Controls within the area
							/// </summary>
							public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new layout/BorderLayoutArea.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern BorderLayoutArea(string sId, sap.ui.commons.layout.BorderLayoutArea.Settings mSettings);

						/// <summary>
						/// Constructor for a new layout/BorderLayoutArea.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern BorderLayoutArea(string sId);

						/// <summary>
						/// Constructor for a new layout/BorderLayoutArea.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern BorderLayoutArea();

						/// <summary>
						/// Constructor for a new layout/BorderLayoutArea.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern BorderLayoutArea(sap.ui.commons.layout.BorderLayoutArea.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property areaId

						/// <summary>
						/// Gets current value of property {@link #getAreaId areaId}.
						/// 
						/// Defines which area the element represents: top, begin, center, end, bottom
						/// 
						/// Default value is <code>top</code>.
						/// </summary>
						/// <returns>Value of property <code>areaId</code></returns>
						[Obsolete("Deprecated since 1.3.3. Redundant to the aggregation by the parent border layout.")]
						public extern virtual sap.ui.commons.layout.BorderLayoutAreaTypes getAreaId();

						/// <summary>
						/// Sets a new value for property {@link #getAreaId areaId}.
						/// 
						/// Defines which area the element represents: top, begin, center, end, bottom
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>top</code>.
						/// </summary>
						/// <param name="sAreaId">New value for property <code>areaId</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						[Obsolete("Deprecated since 1.3.3. Redundant to the aggregation by the parent border layout.")]
						public extern virtual sap.ui.commons.layout.BorderLayoutArea setAreaId(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId);

						#endregion

						#region Methods for Property overflowX

						/// <summary>
						/// Gets current value of property {@link #getOverflowX overflowX}.
						/// 
						/// The overflow mode of the area in horizontal direction as CSS value
						/// 
						/// Default value is <code>auto</code>.
						/// </summary>
						/// <returns>Value of property <code>overflowX</code></returns>
						public extern virtual string getOverflowX();

						/// <summary>
						/// Sets a new value for property {@link #getOverflowX overflowX}.
						/// 
						/// The overflow mode of the area in horizontal direction as CSS value
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>auto</code>.
						/// </summary>
						/// <param name="sOverflowX">New value for property <code>overflowX</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea setOverflowX(string sOverflowX);

						#endregion

						#region Methods for Property overflowY

						/// <summary>
						/// Gets current value of property {@link #getOverflowY overflowY}.
						/// 
						/// The overflow mode of the area in vertical direction as CSS value
						/// 
						/// Default value is <code>auto</code>.
						/// </summary>
						/// <returns>Value of property <code>overflowY</code></returns>
						public extern virtual string getOverflowY();

						/// <summary>
						/// Sets a new value for property {@link #getOverflowY overflowY}.
						/// 
						/// The overflow mode of the area in vertical direction as CSS value
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>auto</code>.
						/// </summary>
						/// <param name="sOverflowY">New value for property <code>overflowY</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea setOverflowY(string sOverflowY);

						#endregion

						#region Methods for Property contentAlign

						/// <summary>
						/// Gets current value of property {@link #getContentAlign contentAlign}.
						/// 
						/// The content alignment as CSS value
						/// 
						/// Default value is <code>left</code>.
						/// </summary>
						/// <returns>Value of property <code>contentAlign</code></returns>
						public extern virtual string getContentAlign();

						/// <summary>
						/// Sets a new value for property {@link #getContentAlign contentAlign}.
						/// 
						/// The content alignment as CSS value
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>left</code>.
						/// </summary>
						/// <param name="sContentAlign">New value for property <code>contentAlign</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea setContentAlign(string sContentAlign);

						#endregion

						#region Methods for Property size

						/// <summary>
						/// Gets current value of property {@link #getSize size}.
						/// 
						/// Defines the height or the width. Is not used when the area element is in Center.
						/// 
						/// Default value is <code>100px</code>.
						/// </summary>
						/// <returns>Value of property <code>size</code></returns>
						public extern virtual sap.ui.core.CSSSize getSize();

						/// <summary>
						/// Sets a new value for property {@link #getSize size}.
						/// 
						/// Defines the height or the width. Is not used when the area element is in Center.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>100px</code>.
						/// </summary>
						/// <param name="sSize">New value for property <code>size</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea setSize(sap.ui.core.CSSSize sSize);

						#endregion

						#region Methods for Property visible

						/// <summary>
						/// Gets current value of property {@link #getVisible visible}.
						/// 
						/// Invisible controls are not rendered
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>visible</code></returns>
						public extern virtual bool getVisible();

						/// <summary>
						/// Sets a new value for property {@link #getVisible visible}.
						/// 
						/// Invisible controls are not rendered
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bVisible">New value for property <code>visible</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea setVisible(bool bVisible);

						#endregion

						#region Methods for Aggregation content

						/// <summary>
						/// Gets content of aggregation {@link #getContent content}.
						/// 
						/// Controls within the area
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.Control[] getContent();

						/// <summary>
						/// Destroys all the content in the aggregation {@link #getContent content}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea destroyContent();

						/// <summary>
						/// Inserts a content into the aggregation {@link #getContent content}.
						/// </summary>
						/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea insertContent(sap.ui.core.Control oContent, int iIndex);

						/// <summary>
						/// Adds some content to the aggregation {@link #getContent content}.
						/// </summary>
						/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea addContent(sap.ui.core.Control oContent);

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

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.BorderLayoutArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.BorderLayoutArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.BorderLayoutArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.layout.BorderLayoutArea.
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
