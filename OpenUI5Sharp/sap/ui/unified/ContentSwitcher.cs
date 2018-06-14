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
				/// Switches between two control areas and animates it via CSS transitions
				/// </summary>
				[External]
				[Namespace(false)]
				[Obsolete("Deprecated since 1.44.0.")]
				public partial class ContentSwitcher : sap.ui.core.Control
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
						/// Set the used animation when changing content. This just sets a CSS-class named "sapUiUnifiedACSwitcherAnimation" + this value on the root element of the control. The animation has to be implemented in CSS. This also enables applications to implement their own animations via CSS by reacting to the parent class. See the types sap.ui.unified.ContentSwitcherAnimation for default implementations.
						/// </summary>
						public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> animation;

						/// <summary>
						/// The number of the currently active content (1 or 2).
						/// </summary>
						public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> activeContent;

						/// <summary>
						/// The controls that should be shown in the first content
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> content1;

						/// <summary>
						/// The controls that should be shown in the second content
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> content2;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ContentSwitcher.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ContentSwitcher(string sId, sap.ui.unified.ContentSwitcher.Settings mSettings);

					/// <summary>
					/// Constructor for a new ContentSwitcher.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ContentSwitcher(string sId);

					/// <summary>
					/// Constructor for a new ContentSwitcher.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ContentSwitcher();

					/// <summary>
					/// Constructor for a new ContentSwitcher.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ContentSwitcher(sap.ui.unified.ContentSwitcher.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property animation

					/// <summary>
					/// Gets current value of property {@link #getAnimation animation}.
					/// 
					/// Set the used animation when changing content. This just sets a CSS-class named "sapUiUnifiedACSwitcherAnimation" + this value on the root element of the control. The animation has to be implemented in CSS. This also enables applications to implement their own animations via CSS by reacting to the parent class. See the types sap.ui.unified.ContentSwitcherAnimation for default implementations.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>animation</code></returns>
					public extern virtual string getAnimation();

					/// <summary>
					/// Sets a new value for property {@link #getAnimation animation}.
					/// 
					/// Set the used animation when changing content. This just sets a CSS-class named "sapUiUnifiedACSwitcherAnimation" + this value on the root element of the control. The animation has to be implemented in CSS. This also enables applications to implement their own animations via CSS by reacting to the parent class. See the types sap.ui.unified.ContentSwitcherAnimation for default implementations.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sAnimation">New value for property <code>animation</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ContentSwitcher setAnimation(string sAnimation);

					#endregion

					#region Methods for Property activeContent

					/// <summary>
					/// Gets current value of property {@link #getActiveContent activeContent}.
					/// 
					/// The number of the currently active content (1 or 2).
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>activeContent</code></returns>
					public extern virtual int getActiveContent();

					/// <summary>
					/// Sets a new value for property {@link #getActiveContent activeContent}.
					/// 
					/// The number of the currently active content (1 or 2).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="iActiveContent">New value for property <code>activeContent</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ContentSwitcher setActiveContent(int iActiveContent);

					#endregion

					#region Methods for Aggregation content1

					/// <summary>
					/// Gets content of aggregation {@link #getContent1 content1}.
					/// 
					/// The controls that should be shown in the first content
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent1();

					/// <summary>
					/// Destroys all the content1 in the aggregation {@link #getContent1 content1}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ContentSwitcher destroyContent1();

					/// <summary>
					/// Inserts a content1 into the aggregation {@link #getContent1 content1}.
					/// </summary>
					/// <param name="oContent1">The content1 to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content1 should be inserted at; for a negative value of <code>iIndex</code>, the content1 is inserted at position 0; for a value greater than the current size of the aggregation, the content1 is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ContentSwitcher insertContent1(sap.ui.core.Control oContent1, int iIndex);

					/// <summary>
					/// Adds some content1 to the aggregation {@link #getContent1 content1}.
					/// </summary>
					/// <param name="oContent1">The content1 to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ContentSwitcher addContent1(sap.ui.core.Control oContent1);

					/// <summary>
					/// Removes a content1 from the aggregation {@link #getContent1 content1}.
					/// </summary>
					/// <param name="vContent1">The content1 to remove or its index or id</param>
					/// <returns>The removed content1 or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeContent1(Union<int, string, sap.ui.core.Control> vContent1);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent1 content1}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oContent1">The content1 whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfContent1(sap.ui.core.Control oContent1);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getContent1 content1}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllContent1();

					#endregion

					#region Methods for Aggregation content2

					/// <summary>
					/// Gets content of aggregation {@link #getContent2 content2}.
					/// 
					/// The controls that should be shown in the second content
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent2();

					/// <summary>
					/// Destroys all the content2 in the aggregation {@link #getContent2 content2}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ContentSwitcher destroyContent2();

					/// <summary>
					/// Inserts a content2 into the aggregation {@link #getContent2 content2}.
					/// </summary>
					/// <param name="oContent2">The content2 to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content2 should be inserted at; for a negative value of <code>iIndex</code>, the content2 is inserted at position 0; for a value greater than the current size of the aggregation, the content2 is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ContentSwitcher insertContent2(sap.ui.core.Control oContent2, int iIndex);

					/// <summary>
					/// Adds some content2 to the aggregation {@link #getContent2 content2}.
					/// </summary>
					/// <param name="oContent2">The content2 to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ContentSwitcher addContent2(sap.ui.core.Control oContent2);

					/// <summary>
					/// Removes a content2 from the aggregation {@link #getContent2 content2}.
					/// </summary>
					/// <param name="vContent2">The content2 to remove or its index or id</param>
					/// <returns>The removed content2 or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeContent2(Union<int, string, sap.ui.core.Control> vContent2);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent2 content2}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oContent2">The content2 whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfContent2(sap.ui.core.Control oContent2);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getContent2 content2}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllContent2();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ContentSwitcher with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ContentSwitcher with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ContentSwitcher with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.ContentSwitcher.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Changes the currently active content to the other one. If content 1 is active, content 2 will be activated and the other way around.
					/// </summary>
					public extern virtual void switchContent();

					#endregion

					#endregion

				}
			}
		}
	}
}
