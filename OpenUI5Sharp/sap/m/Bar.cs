using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// Used as a header, sub-header and a footer of a page.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>Bar</code> control consists of three areas to hold its content. It has the capability to center content, such as a title, while having other controls on the left and right side.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// With the use of the <code>design</code> property, you can set the style of the <code>Bar</code> to appear as a header, sub-header and footer.
			/// 
			/// <b>Note:</b> Do not place a <code>sap.m.Bar</code> inside another <code>sap.m.Bar</code> or inside any bar-like control. Doing so causes unpredictable behavior.
			/// 
			/// <h3>Responsive Behavior</h3>
			/// 
			/// The content in the middle area is centrally positioned if there is enough space. If the right or left content overlaps the middle content, the middle content will be centered in the space between.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Bar")]
			public partial class Bar : sap.ui.core.Control, sap.m.IBar
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
					/// If this flag is set to true, contentMiddle will be rendered as a HBox and layoutData can be used to allocate available space.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableFlexBox;

					/// <summary>
					/// Indicates whether the Bar is partially translucent. It is only applied for touch devices.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> translucent;

					/// <summary>
					/// Determines the design of the bar. If set to auto, it becomes dependent on the place where the bar is placed.
					/// </summary>
					public Union<sap.m.BarDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

					/// <summary>
					/// Represents the left content area, usually containing a button or an app icon. If it is overlapped by the right content, its content will disappear and the text will show an ellipsis.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> contentLeft;

					/// <summary>
					/// Represents the middle content area. Controls such as label, segmented buttons or select can be placed here. The content is centrally positioned if there is enough space. If the right or left content overlaps the middle content, the middle content will be centered in the space between the left and the right content.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> contentMiddle;

					/// <summary>
					/// Represents the right content area. Controls such as action buttons or search field can be placed here.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> contentRight;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>Bar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Bar(string sId, sap.m.Bar.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>Bar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Bar(string sId);

				/// <summary>
				/// Constructor for a new <code>Bar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Bar();

				/// <summary>
				/// Constructor for a new <code>Bar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Bar(sap.m.Bar.Settings mSettings);

				#endregion

				#region Fields

				/// <summary>
				/// Sets classes according to the context of the page. Possible contexts are header, footer and subheader.
				/// </summary>
				public object _applyContextClassFor;

				/// <summary>
				/// Sets HTML tag according to the context of the page. Possible contexts are header, footer and subheader.
				/// </summary>
				public object _applyTag;

				/// <summary>
				/// Sets classes and HTML tag according to the context of the page. Possible contexts are header, footer and subheader.
				/// </summary>
				public object applyTagAndContextClassFor;

				/// <summary>
				/// Gets the available Bar contexts.
				/// </summary>
				public object getContext;

				/// <summary>
				/// Gets the HTML tag of the root element.
				/// </summary>
				public object getHTMLTag;

				/// <summary>
				/// Determines whether the Bar is sensitive to the container context.
				/// 
				/// Implementation of the IBar interface.
				/// </summary>
				public object isContextSensitive;

				/// <summary>
				/// Sets the HTML tag of the root element.
				/// </summary>
				public object setHTMLTag;

				#endregion

				#region Methods

				#region Methods for Property enableFlexBox

				/// <summary>
				/// Gets current value of property {@link #getEnableFlexBox enableFlexBox}.
				/// 
				/// If this flag is set to true, contentMiddle will be rendered as a HBox and layoutData can be used to allocate available space.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableFlexBox</code></returns>
				[Obsolete("Deprecated since 1.16. replaced by <code>contentMiddle</code> aggregation. <code>contentMiddle</code> will always occupy of the 100% width when no <code>contentLeft</code> and <code>contentRight</code> are being set.")]
				public extern virtual bool getEnableFlexBox();

				/// <summary>
				/// Sets a new value for property {@link #getEnableFlexBox enableFlexBox}.
				/// 
				/// If this flag is set to true, contentMiddle will be rendered as a HBox and layoutData can be used to allocate available space.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableFlexBox">New value for property <code>enableFlexBox</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.16. replaced by <code>contentMiddle</code> aggregation. <code>contentMiddle</code> will always occupy of the 100% width when no <code>contentLeft</code> and <code>contentRight</code> are being set.")]
				public extern virtual sap.m.Bar setEnableFlexBox(bool bEnableFlexBox);

				#endregion

				#region Methods for Property translucent

				/// <summary>
				/// Gets current value of property {@link #getTranslucent translucent}.
				/// 
				/// Indicates whether the Bar is partially translucent. It is only applied for touch devices.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>translucent</code></returns>
				[Obsolete("Deprecated since 1.18.6. This property has no effect since release 1.18.6 and should not be used. Translucent bar may overlay an input and make it difficult to edit.")]
				public extern virtual bool getTranslucent();

				/// <summary>
				/// Sets a new value for property {@link #getTranslucent translucent}.
				/// 
				/// Indicates whether the Bar is partially translucent. It is only applied for touch devices.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bTranslucent">New value for property <code>translucent</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.6. This property has no effect since release 1.18.6 and should not be used. Translucent bar may overlay an input and make it difficult to edit.")]
				public extern virtual sap.m.Bar setTranslucent(bool bTranslucent);

				#endregion

				#region Methods for Property design

				/// <summary>
				/// Gets current value of property {@link #getDesign design}.
				/// 
				/// Determines the design of the bar. If set to auto, it becomes dependent on the place where the bar is placed.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>design</code></returns>
				public extern virtual sap.m.BarDesign getDesign();

				/// <summary>
				/// Sets a new value for property {@link #getDesign design}.
				/// 
				/// Determines the design of the bar. If set to auto, it becomes dependent on the place where the bar is placed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <param name="sDesign">New value for property <code>design</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Bar setDesign(sap.m.BarDesign sDesign);

				#endregion

				#region Methods for Aggregation contentLeft

				/// <summary>
				/// Gets content of aggregation {@link #getContentLeft contentLeft}.
				/// 
				/// Represents the left content area, usually containing a button or an app icon. If it is overlapped by the right content, its content will disappear and the text will show an ellipsis.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContentLeft();

				/// <summary>
				/// Destroys all the contentLeft in the aggregation {@link #getContentLeft contentLeft}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Bar destroyContentLeft();

				/// <summary>
				/// Inserts a contentLeft into the aggregation {@link #getContentLeft contentLeft}.
				/// </summary>
				/// <param name="oContentLeft">The contentLeft to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the contentLeft should be inserted at; for a negative value of <code>iIndex</code>, the contentLeft is inserted at position 0; for a value greater than the current size of the aggregation, the contentLeft is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Bar insertContentLeft(sap.ui.core.Control oContentLeft, int iIndex);

				/// <summary>
				/// Adds some contentLeft to the aggregation {@link #getContentLeft contentLeft}.
				/// </summary>
				/// <param name="oContentLeft">The contentLeft to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Bar addContentLeft(sap.ui.core.Control oContentLeft);

				/// <summary>
				/// Removes a contentLeft from the aggregation {@link #getContentLeft contentLeft}.
				/// </summary>
				/// <param name="vContentLeft">The contentLeft to remove or its index or id</param>
				/// <returns>The removed contentLeft or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeContentLeft(Union<int, string, sap.ui.core.Control> vContentLeft);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContentLeft contentLeft}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oContentLeft">The contentLeft whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfContentLeft(sap.ui.core.Control oContentLeft);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getContentLeft contentLeft}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllContentLeft();

				#endregion

				#region Methods for Aggregation contentMiddle

				/// <summary>
				/// Gets content of aggregation {@link #getContentMiddle contentMiddle}.
				/// 
				/// Represents the middle content area. Controls such as label, segmented buttons or select can be placed here. The content is centrally positioned if there is enough space. If the right or left content overlaps the middle content, the middle content will be centered in the space between the left and the right content.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContentMiddle();

				/// <summary>
				/// Destroys all the contentMiddle in the aggregation {@link #getContentMiddle contentMiddle}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Bar destroyContentMiddle();

				/// <summary>
				/// Inserts a contentMiddle into the aggregation {@link #getContentMiddle contentMiddle}.
				/// </summary>
				/// <param name="oContentMiddle">The contentMiddle to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the contentMiddle should be inserted at; for a negative value of <code>iIndex</code>, the contentMiddle is inserted at position 0; for a value greater than the current size of the aggregation, the contentMiddle is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Bar insertContentMiddle(sap.ui.core.Control oContentMiddle, int iIndex);

				/// <summary>
				/// Adds some contentMiddle to the aggregation {@link #getContentMiddle contentMiddle}.
				/// </summary>
				/// <param name="oContentMiddle">The contentMiddle to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Bar addContentMiddle(sap.ui.core.Control oContentMiddle);

				/// <summary>
				/// Removes a contentMiddle from the aggregation {@link #getContentMiddle contentMiddle}.
				/// </summary>
				/// <param name="vContentMiddle">The contentMiddle to remove or its index or id</param>
				/// <returns>The removed contentMiddle or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeContentMiddle(Union<int, string, sap.ui.core.Control> vContentMiddle);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContentMiddle contentMiddle}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oContentMiddle">The contentMiddle whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfContentMiddle(sap.ui.core.Control oContentMiddle);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getContentMiddle contentMiddle}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllContentMiddle();

				#endregion

				#region Methods for Aggregation contentRight

				/// <summary>
				/// Gets content of aggregation {@link #getContentRight contentRight}.
				/// 
				/// Represents the right content area. Controls such as action buttons or search field can be placed here.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContentRight();

				/// <summary>
				/// Destroys all the contentRight in the aggregation {@link #getContentRight contentRight}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Bar destroyContentRight();

				/// <summary>
				/// Inserts a contentRight into the aggregation {@link #getContentRight contentRight}.
				/// </summary>
				/// <param name="oContentRight">The contentRight to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the contentRight should be inserted at; for a negative value of <code>iIndex</code>, the contentRight is inserted at position 0; for a value greater than the current size of the aggregation, the contentRight is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Bar insertContentRight(sap.ui.core.Control oContentRight, int iIndex);

				/// <summary>
				/// Adds some contentRight to the aggregation {@link #getContentRight contentRight}.
				/// </summary>
				/// <param name="oContentRight">The contentRight to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Bar addContentRight(sap.ui.core.Control oContentRight);

				/// <summary>
				/// Removes a contentRight from the aggregation {@link #getContentRight contentRight}.
				/// </summary>
				/// <param name="vContentRight">The contentRight to remove or its index or id</param>
				/// <returns>The removed contentRight or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeContentRight(Union<int, string, sap.ui.core.Control> vContentRight);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContentRight contentRight}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oContentRight">The contentRight whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfContentRight(sap.ui.core.Control oContentRight);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getContentRight contentRight}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllContentRight();

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
				public extern virtual sap.m.Bar addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				/// Creates a new subclass of class sap.m.Bar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Bar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Bar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Bar.
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
