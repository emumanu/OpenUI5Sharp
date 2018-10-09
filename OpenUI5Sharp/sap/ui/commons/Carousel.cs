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
				/// <summary>
				/// Carousel holds multiple controls and displays them vertically or horizontally next to each other. You can define how many content items should be displayed at once or let the Carousel determine that for you. Navigation is done through buttons or keys.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Carousel")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Carousel</code> control.")]
				public partial class Carousel : sap.ui.core.Control
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
						/// Determines the orientation of the Carousel. Can be either "horizontal" or "vertical"
						/// </summary>
						public Union<sap.ui.commons.enums.Orientation, string, sap.ui.@base.ManagedObject.BindPropertyInfo> orientation;

						/// <summary>
						/// Determines the width of the Carousel
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Determines the height of the Carousel
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Default height of the item in a carousel if no height can be determined
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultItemHeight;

						/// <summary>
						/// Default width of the item in a carousel if no height can be determined
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultItemWidth;

						/// <summary>
						/// Duration for animation when navigating through the contents of the Carousel
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> animationDuration;

						/// <summary>
						/// If defined, the carousel displays the number of items defined. Items will be resized to fit the area.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleItems;

						/// <summary>
						/// Determines the size of the handle in pixels. (Height for vertical carousel, width for horizontal carousel)
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> handleSize;

						/// <summary>
						/// The index of the element in the content aggreation which is displayed first on rendering
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> firstVisibleIndex;

						/// <summary>
						/// Controls which are displayed inside the Carousel
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Carousel.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Carousel(string sId, sap.ui.commons.Carousel.Settings mSettings);

					/// <summary>
					/// Constructor for a new Carousel.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern Carousel(string sId);

					/// <summary>
					/// Constructor for a new Carousel.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Carousel();

					/// <summary>
					/// Constructor for a new Carousel.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Carousel(sap.ui.commons.Carousel.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property orientation

					/// <summary>
					/// Gets current value of property {@link #getOrientation orientation}.
					/// 
					/// Determines the orientation of the Carousel. Can be either "horizontal" or "vertical"
					/// 
					/// Default value is <code>horizontal</code>.
					/// </summary>
					/// <returns>Value of property <code>orientation</code></returns>
					public extern virtual sap.ui.commons.enums.Orientation getOrientation();

					/// <summary>
					/// Sets a new value for property {@link #getOrientation orientation}.
					/// 
					/// Determines the orientation of the Carousel. Can be either "horizontal" or "vertical"
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>horizontal</code>.
					/// </summary>
					/// <param name="sOrientation">New value for property <code>orientation</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel setOrientation(sap.ui.commons.enums.Orientation sOrientation);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Determines the width of the Carousel
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Determines the width of the Carousel
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Determines the height of the Carousel
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// Determines the height of the Carousel
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property defaultItemHeight

					/// <summary>
					/// Gets current value of property {@link #getDefaultItemHeight defaultItemHeight}.
					/// 
					/// Default height of the item in a carousel if no height can be determined
					/// 
					/// Default value is <code>150</code>.
					/// </summary>
					/// <returns>Value of property <code>defaultItemHeight</code></returns>
					public extern virtual int getDefaultItemHeight();

					/// <summary>
					/// Sets a new value for property {@link #getDefaultItemHeight defaultItemHeight}.
					/// 
					/// Default height of the item in a carousel if no height can be determined
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>150</code>.
					/// </summary>
					/// <param name="iDefaultItemHeight">New value for property <code>defaultItemHeight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel setDefaultItemHeight(int iDefaultItemHeight);

					#endregion

					#region Methods for Property defaultItemWidth

					/// <summary>
					/// Gets current value of property {@link #getDefaultItemWidth defaultItemWidth}.
					/// 
					/// Default width of the item in a carousel if no height can be determined
					/// 
					/// Default value is <code>150</code>.
					/// </summary>
					/// <returns>Value of property <code>defaultItemWidth</code></returns>
					public extern virtual int getDefaultItemWidth();

					/// <summary>
					/// Sets a new value for property {@link #getDefaultItemWidth defaultItemWidth}.
					/// 
					/// Default width of the item in a carousel if no height can be determined
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>150</code>.
					/// </summary>
					/// <param name="iDefaultItemWidth">New value for property <code>defaultItemWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel setDefaultItemWidth(int iDefaultItemWidth);

					#endregion

					#region Methods for Property animationDuration

					/// <summary>
					/// Gets current value of property {@link #getAnimationDuration animationDuration}.
					/// 
					/// Duration for animation when navigating through the contents of the Carousel
					/// 
					/// Default value is <code>500</code>.
					/// </summary>
					/// <returns>Value of property <code>animationDuration</code></returns>
					public extern virtual int getAnimationDuration();

					/// <summary>
					/// Sets a new value for property {@link #getAnimationDuration animationDuration}.
					/// 
					/// Duration for animation when navigating through the contents of the Carousel
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>500</code>.
					/// </summary>
					/// <param name="iAnimationDuration">New value for property <code>animationDuration</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel setAnimationDuration(int iAnimationDuration);

					#endregion

					#region Methods for Property visibleItems

					/// <summary>
					/// Gets current value of property {@link #getVisibleItems visibleItems}.
					/// 
					/// If defined, the carousel displays the number of items defined. Items will be resized to fit the area.
					/// </summary>
					/// <returns>Value of property <code>visibleItems</code></returns>
					public extern virtual int getVisibleItems();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleItems visibleItems}.
					/// 
					/// If defined, the carousel displays the number of items defined. Items will be resized to fit the area.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iVisibleItems">New value for property <code>visibleItems</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel setVisibleItems(int iVisibleItems);

					#endregion

					#region Methods for Property handleSize

					/// <summary>
					/// Gets current value of property {@link #getHandleSize handleSize}.
					/// 
					/// Determines the size of the handle in pixels. (Height for vertical carousel, width for horizontal carousel)
					/// 
					/// Default value is <code>22</code>.
					/// </summary>
					/// <returns>Value of property <code>handleSize</code></returns>
					public extern virtual int getHandleSize();

					/// <summary>
					/// Sets a new value for property {@link #getHandleSize handleSize}.
					/// 
					/// Determines the size of the handle in pixels. (Height for vertical carousel, width for horizontal carousel)
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>22</code>.
					/// </summary>
					/// <param name="iHandleSize">New value for property <code>handleSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel setHandleSize(int iHandleSize);

					#endregion

					#region Methods for Property firstVisibleIndex

					/// <summary>
					/// Gets current value of property {@link #getFirstVisibleIndex firstVisibleIndex}.
					/// 
					/// The index of the element in the content aggreation which is displayed first on rendering
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>firstVisibleIndex</code></returns>
					public extern virtual int getFirstVisibleIndex();

					/// <summary>
					/// Setter for property <code>firstVisibleIndex</code>.
					/// 
					/// Default value is <code>0</code>
					/// </summary>
					/// <param name="iFirstVisibleIndex">new value for property <code>firstVisibleIndex</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel setFirstVisibleIndex(int iFirstVisibleIndex);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// Controls which are displayed inside the Carousel
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel addContent(sap.ui.core.Control oContent);

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

					/// <summary>
					/// Binds aggregation {@link #getContent content} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel bindContent(object oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getContent content} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Carousel unbindContent();

					#endregion

					#region Other methods

					/// <summary>
					/// Calculates and sets the size of the carousel, its items and its buttons
					/// </summary>
					public extern virtual void calculateAndSetSize();

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Carousel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Carousel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Carousel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the focused DOM element
					/// </summary>
					/// <returns>The focused DOM element</returns>
					public extern virtual jQuery getFocusDomRef();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Carousel.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// If the device supports touch gestures and left swipe is triggered shows the next carousel item
					/// </summary>
					/// <param name="oEvent"></param>
					public extern virtual void onswipeleft(jquery.JQuery.Event oEvent);

					/// <summary>
					/// If the device supports touch gestures and right swipe is triggered shows the previous carousel item
					/// </summary>
					/// <param name="oEvent"></param>
					public extern virtual void onswiperight(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Shows the element with the specified Id. This can be only used after the component is rendered.
					/// </summary>
					/// <param name="sElementId">Id of the element to slide to.</param>
					public extern virtual void showElementWithId(string sElementId);

					/// <summary>
					/// Shows the next item in carousel. This can be only used after the component is rendered.
					/// </summary>
					public extern virtual void showNext();

					/// <summary>
					/// Shows the previous item in carousel. This can be only used after the component is rendered.
					/// </summary>
					public extern virtual void showPrevious();

					#endregion

					#endregion

				}
			}
		}
	}
}
