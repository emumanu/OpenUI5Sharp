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
				/// <summary>
				/// Provides a main content and a secondary content area
				/// </summary>
				[External]
				[Namespace(false)]
				[Obsolete("Deprecated since 1.44.0.")]
				public partial class SplitContainer : sap.ui.core.Control
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
						/// Shows / Hides the secondary area.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showSecondaryContent;

						/// <summary>
						/// The width if the secondary content. The height is always 100%.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> secondaryContentSize;

						/// <summary>
						/// Do not use. Use secondaryContentSize instead.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> secondaryContentWidth;

						/// <summary>
						/// Whether to show the secondary content on the left ("Horizontal", default) or on the top ("Vertical").
						/// </summary>
						public Union<sap.ui.core.Orientation, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> orientation;

						/// <summary>
						/// The content to appear in the main area.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// The content to appear in the secondary area.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> secondaryContent;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new SplitContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern SplitContainer(string sId, sap.ui.unified.SplitContainer.Settings mSettings);

					/// <summary>
					/// Constructor for a new SplitContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern SplitContainer(string sId);

					/// <summary>
					/// Constructor for a new SplitContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern SplitContainer();

					/// <summary>
					/// Constructor for a new SplitContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern SplitContainer(sap.ui.unified.SplitContainer.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property showSecondaryContent

					/// <summary>
					/// Gets current value of property {@link #getShowSecondaryContent showSecondaryContent}.
					/// 
					/// Shows / Hides the secondary area.
					/// </summary>
					/// <returns>Value of property <code>showSecondaryContent</code></returns>
					public extern virtual bool getShowSecondaryContent();

					/// <summary>
					/// Sets a new value for property {@link #getShowSecondaryContent showSecondaryContent}.
					/// 
					/// Shows / Hides the secondary area.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="bShowSecondaryContent">New value for property <code>showSecondaryContent</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.SplitContainer setShowSecondaryContent(bool bShowSecondaryContent);

					#endregion

					#region Methods for Property secondaryContentSize

					/// <summary>
					/// Gets current value of property {@link #getSecondaryContentSize secondaryContentSize}.
					/// 
					/// The width if the secondary content. The height is always 100%.
					/// 
					/// Default value is <code>250px</code>.
					/// </summary>
					/// <returns>Value of property <code>secondaryContentSize</code></returns>
					public extern virtual sap.ui.core.CSSSize getSecondaryContentSize();

					/// <summary>
					/// Sets a new value for property {@link #getSecondaryContentSize secondaryContentSize}.
					/// 
					/// The width if the secondary content. The height is always 100%.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>250px</code>.
					/// </summary>
					/// <param name="sSecondaryContentSize">New value for property <code>secondaryContentSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.SplitContainer setSecondaryContentSize(sap.ui.core.CSSSize sSecondaryContentSize);

					#endregion

					#region Methods for Property secondaryContentWidth

					/// <summary>
					/// Gets current value of property {@link #getSecondaryContentWidth secondaryContentWidth}.
					/// 
					/// Do not use. Use secondaryContentSize instead.
					/// 
					/// Default value is <code>250px</code>.
					/// </summary>
					[Obsolete("Deprecated since 1.22. Only available for backwards compatibility.")]
					/// <returns>Value of property <code>secondaryContentWidth</code></returns>
					public extern virtual sap.ui.core.CSSSize getSecondaryContentWidth();

					/// <summary>
					/// Sets a new value for property {@link #getSecondaryContentWidth secondaryContentWidth}.
					/// 
					/// Do not use. Use secondaryContentSize instead.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>250px</code>.
					/// </summary>
					[Obsolete("Deprecated since 1.22. Only available for backwards compatibility.")]
					/// <param name="sSecondaryContentWidth">New value for property <code>secondaryContentWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.SplitContainer setSecondaryContentWidth(sap.ui.core.CSSSize sSecondaryContentWidth);

					#endregion

					#region Methods for Property orientation

					/// <summary>
					/// Gets current value of property {@link #getOrientation orientation}.
					/// 
					/// Whether to show the secondary content on the left ("Horizontal", default) or on the top ("Vertical").
					/// 
					/// Default value is <code>Horizontal</code>.
					/// </summary>
					/// <returns>Value of property <code>orientation</code></returns>
					public extern virtual sap.ui.core.Orientation getOrientation();

					/// <summary>
					/// Sets a new value for property {@link #getOrientation orientation}.
					/// 
					/// Whether to show the secondary content on the left ("Horizontal", default) or on the top ("Vertical").
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Horizontal</code>.
					/// </summary>
					/// <param name="sOrientation">New value for property <code>orientation</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.SplitContainer setOrientation(sap.ui.core.Orientation sOrientation);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// The content to appear in the main area.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.SplitContainer destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.SplitContainer insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.SplitContainer addContent(sap.ui.core.Control oContent);

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

					#region Methods for Aggregation secondaryContent

					/// <summary>
					/// Gets content of aggregation {@link #getSecondaryContent secondaryContent}.
					/// 
					/// The content to appear in the secondary area.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getSecondaryContent();

					/// <summary>
					/// Destroys all the secondaryContent in the aggregation {@link #getSecondaryContent secondaryContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.SplitContainer destroySecondaryContent();

					/// <summary>
					/// Inserts a secondaryContent into the aggregation {@link #getSecondaryContent secondaryContent}.
					/// </summary>
					/// <param name="oSecondaryContent">The secondaryContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the secondaryContent should be inserted at; for a negative value of <code>iIndex</code>, the secondaryContent is inserted at position 0; for a value greater than the current size of the aggregation, the secondaryContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.SplitContainer insertSecondaryContent(sap.ui.core.Control oSecondaryContent, int iIndex);

					/// <summary>
					/// Adds some secondaryContent to the aggregation {@link #getSecondaryContent secondaryContent}.
					/// </summary>
					/// <param name="oSecondaryContent">The secondaryContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.SplitContainer addSecondaryContent(sap.ui.core.Control oSecondaryContent);

					/// <summary>
					/// Removes a secondaryContent from the aggregation {@link #getSecondaryContent secondaryContent}.
					/// </summary>
					/// <param name="vSecondaryContent">The secondaryContent to remove or its index or id</param>
					/// <returns>The removed secondaryContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeSecondaryContent(Union<int, string, sap.ui.core.Control> vSecondaryContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getSecondaryContent secondaryContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oSecondaryContent">The secondaryContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfSecondaryContent(sap.ui.core.Control oSecondaryContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getSecondaryContent secondaryContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllSecondaryContent();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.SplitContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.SplitContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.SplitContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.SplitContainer.
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
