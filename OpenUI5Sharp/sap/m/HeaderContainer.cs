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
			/// The container that provides a horizontal layout. It provides a horizontal scrolling on the mobile devices. On the desktop, it provides scroll left and scroll right buttons. This control supports keyboard navigation. You can use left and right arrow keys to navigate through the inner content. The Home key puts focus on the first control and the End key puts focus on the last control. Use Enter or Space key to choose the control.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.HeaderContainer")]
			public partial class HeaderContainer : sap.ui.core.Control, sap.m.ObjectHeaderContainer
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
					/// Number of pixels to scroll when the user chooses Next or Previous buttons. Relevant only for desktop.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollStep;

					/// <summary>
					/// Number of items to scroll when the user chose Next or Previous buttons. Relevant only for desktop. Have priority over 'ScrollStep'. Have to be positive number.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollStepByItem;

					/// <summary>
					/// Scroll animation time in milliseconds.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollTime;

					/// <summary>
					/// Indicates whether the incomplete item on the edge of visible area is displayed or hidden.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showOverflowItem;

					/// <summary>
					/// If set to true, it shows dividers between the different content controls.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showDividers;

					/// <summary>
					/// The orientation of the HeaderContainer. There are two orientation modes: horizontal and vertical. In horizontal mode the content controls are displayed next to each other, in vertical mode the content controls are displayed on top of each other.
					/// </summary>
					public Union<sap.ui.core.Orientation, string, sap.ui.@base.ManagedObject.BindPropertyInfo> orientation;

					/// <summary>
					/// Specifies the background color of the content. The visualization of the different options depends on the used theme.
					/// </summary>
					public Union<sap.m.BackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

					/// <summary>
					/// The width of the whole HeaderContainer. If not specified, it is rendered as '100%' in horizontal orientation and as 'auto' in vertical orientation.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// The height of the whole HeaderContainer. If not specified, it is rendered as 'auto' in horizontal orientation and as '100%' in vertical orientation.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// Content to add to HeaderContainer.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for the new HeaderContainer control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern HeaderContainer(string sId, sap.m.HeaderContainer.Settings mSettings);

				/// <summary>
				/// Constructor for the new HeaderContainer control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no id is given</param>
				public extern HeaderContainer(string sId);

				/// <summary>
				/// Constructor for the new HeaderContainer control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern HeaderContainer();

				/// <summary>
				/// Constructor for the new HeaderContainer control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern HeaderContainer(sap.m.HeaderContainer.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property scrollStep

				/// <summary>
				/// Gets current value of property {@link #getScrollStep scrollStep}.
				/// 
				/// Number of pixels to scroll when the user chooses Next or Previous buttons. Relevant only for desktop.
				/// 
				/// Default value is <code>300</code>.
				/// </summary>
				/// <returns>Value of property <code>scrollStep</code></returns>
				public extern virtual int getScrollStep();

				/// <summary>
				/// Sets a new value for property {@link #getScrollStep scrollStep}.
				/// 
				/// Number of pixels to scroll when the user chooses Next or Previous buttons. Relevant only for desktop.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>300</code>.
				/// </summary>
				/// <param name="iScrollStep">New value for property <code>scrollStep</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer setScrollStep(int iScrollStep);

				#endregion

				#region Methods for Property scrollStepByItem

				/// <summary>
				/// Gets current value of property {@link #getScrollStepByItem scrollStepByItem}.
				/// 
				/// Number of items to scroll when the user chose Next or Previous buttons. Relevant only for desktop. Have priority over 'ScrollStep'. Have to be positive number.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>scrollStepByItem</code></returns>
				public extern virtual int getScrollStepByItem();

				/// <summary>
				/// Sets a new value for property {@link #getScrollStepByItem scrollStepByItem}.
				/// 
				/// Number of items to scroll when the user chose Next or Previous buttons. Relevant only for desktop. Have priority over 'ScrollStep'. Have to be positive number.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <param name="iScrollStepByItem">New value for property <code>scrollStepByItem</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer setScrollStepByItem(int iScrollStepByItem);

				#endregion

				#region Methods for Property scrollTime

				/// <summary>
				/// Gets current value of property {@link #getScrollTime scrollTime}.
				/// 
				/// Scroll animation time in milliseconds.
				/// 
				/// Default value is <code>500</code>.
				/// </summary>
				/// <returns>Value of property <code>scrollTime</code></returns>
				public extern virtual int getScrollTime();

				/// <summary>
				/// Sets a new value for property {@link #getScrollTime scrollTime}.
				/// 
				/// Scroll animation time in milliseconds.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>500</code>.
				/// </summary>
				/// <param name="iScrollTime">New value for property <code>scrollTime</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer setScrollTime(int iScrollTime);

				#endregion

				#region Methods for Property showOverflowItem

				/// <summary>
				/// Gets current value of property {@link #getShowOverflowItem showOverflowItem}.
				/// 
				/// Indicates whether the incomplete item on the edge of visible area is displayed or hidden.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showOverflowItem</code></returns>
				public extern virtual bool getShowOverflowItem();

				/// <summary>
				/// Sets a new value for property {@link #getShowOverflowItem showOverflowItem}.
				/// 
				/// Indicates whether the incomplete item on the edge of visible area is displayed or hidden.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowOverflowItem">New value for property <code>showOverflowItem</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer setShowOverflowItem(bool bShowOverflowItem);

				#endregion

				#region Methods for Property showDividers

				/// <summary>
				/// Gets current value of property {@link #getShowDividers showDividers}.
				/// 
				/// If set to true, it shows dividers between the different content controls.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showDividers</code></returns>
				public extern virtual bool getShowDividers();

				/// <summary>
				/// Sets a new value for property {@link #getShowDividers showDividers}.
				/// 
				/// If set to true, it shows dividers between the different content controls.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowDividers">New value for property <code>showDividers</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer setShowDividers(bool bShowDividers);

				#endregion

				#region Methods for Property orientation

				/// <summary>
				/// Gets current value of property {@link #getOrientation orientation}.
				/// 
				/// The orientation of the HeaderContainer. There are two orientation modes: horizontal and vertical. In horizontal mode the content controls are displayed next to each other, in vertical mode the content controls are displayed on top of each other.
				/// 
				/// Default value is <code>Horizontal</code>.
				/// </summary>
				/// <returns>Value of property <code>orientation</code></returns>
				public extern virtual sap.ui.core.Orientation getOrientation();

				/// <summary>
				/// Sets a new value for property {@link #getOrientation orientation}.
				/// 
				/// The orientation of the HeaderContainer. There are two orientation modes: horizontal and vertical. In horizontal mode the content controls are displayed next to each other, in vertical mode the content controls are displayed on top of each other.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Horizontal</code>.
				/// </summary>
				/// <param name="sOrientation">New value for property <code>orientation</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer setOrientation(sap.ui.core.Orientation sOrientation);

				#endregion

				#region Methods for Property backgroundDesign

				/// <summary>
				/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Specifies the background color of the content. The visualization of the different options depends on the used theme.
				/// 
				/// Default value is <code>Transparent</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundDesign</code></returns>
				public extern virtual sap.m.BackgroundDesign getBackgroundDesign();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Specifies the background color of the content. The visualization of the different options depends on the used theme.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Transparent</code>.
				/// </summary>
				/// <param name="sBackgroundDesign">New value for property <code>backgroundDesign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer setBackgroundDesign(sap.m.BackgroundDesign sBackgroundDesign);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// The width of the whole HeaderContainer. If not specified, it is rendered as '100%' in horizontal orientation and as 'auto' in vertical orientation.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// The width of the whole HeaderContainer. If not specified, it is rendered as '100%' in horizontal orientation and as 'auto' in vertical orientation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// The height of the whole HeaderContainer. If not specified, it is rendered as 'auto' in horizontal orientation and as '100%' in vertical orientation.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// The height of the whole HeaderContainer. If not specified, it is rendered as 'auto' in horizontal orientation and as '100%' in vertical orientation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// Content to add to HeaderContainer.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.HeaderContainer addContent(sap.ui.core.Control oContent);

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

				#region Methods for Aggregation _scrollContainer

				#endregion

				#region Methods for Aggregation _prevButton

				#endregion

				#region Methods for Aggregation _nextButton

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.HeaderContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.HeaderContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.HeaderContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.HeaderContainer.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
