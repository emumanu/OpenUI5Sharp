using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				public static partial class @delegate
				{
					/// <summary>
					/// Delegate for touch scrolling on mobile devices
					/// 
					/// This delegate uses native scrolling of mobile and desktop browsers. Third party scrolling libraries are not supported.
					/// 
					/// Controls that implement ScrollEnablement should additionally provide the getScrollDelegate method that returns the current instance of this delegate object
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.delegate.ScrollEnablement")]
					public partial class ScrollEnablement : sap.ui.@base.Object
					{
						#region Constructor

						/// <summary>
						/// Creates a ScrollEnablement delegate that can be attached to Controls requiring capabilities for scrolling of a certain part of their DOM.
						/// </summary>
						/// <param name="oControl">the Control of which this Scroller is the delegate</param>
						/// <param name="sScrollContentDom">the Id of the element within the DOM of the Control which should be scrollable</param>
						/// <param name="oConfig">the configuration of the scroll delegate</param>
						public extern ScrollEnablement(sap.ui.core.Control oControl, string sScrollContentDom, object oConfig);

						#endregion

						#region Methods

						/// <summary>
						/// Destroys this Scrolling delegate.
						/// 
						/// This function must be called by the control which uses this delegate in the <code>exit</code> function.
						/// </summary>
						public extern override void destroy();

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.delegate.ScrollEnablement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.delegate.ScrollEnablement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.delegate.ScrollEnablement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Calculates scroll position of a child of a container.
						/// </summary>
						/// <param name="vElement">An element(DOM or jQuery) for which the scroll position will be calculated.</param>
						/// <returns>Position object.</returns>
						public extern virtual object getChildPosition(Union<Retyped.dom.HTMLElement, jQuery> vElement);

						/// <summary>
						/// Get current setting for horizontal scrolling.
						/// </summary>
						/// <returns>true if horizontal scrolling is enabled</returns>
						public extern virtual bool getHorizontal();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.delegate.ScrollEnablement.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Get current setting for vertical scrolling.
						/// </summary>
						/// <returns>true if vertical scrolling is enabled</returns>
						public extern virtual bool getVertical();

						/// <summary>
						/// Refreshes this Scrolling delegate.
						/// </summary>
						public extern virtual void refresh();

						/// <summary>
						/// Scrolls to an element within a container.
						/// </summary>
						/// <param name="oElement">A DOM element.</param>
						/// <param name="iTime">The duration of animated scrolling in milliseconds. To scroll immediately without animation, give 0 as value.</param>
						/// <param name="Specifies">the offset left and top for the DOM Element.</param>
						/// <returns></returns>
						public extern virtual sap.ui.core.@delegate.ScrollEnablement scrollToElement(Retyped.dom.HTMLElement oElement, int iTime, object[] Specifies);

						/// <summary>
						/// Setter for property <code>bounce</code>.
						/// </summary>
						/// <param name="bBounce">new value for property <code>bounce</code>.</param>
						[Obsolete("Deprecated since 1.42.")]
						public extern virtual void setBounce(bool bBounce);

						/// <summary>
						/// Sets GrowingList control to scroll container
						/// </summary>
						/// <param name="fnScrollLoadCallback">Scrolling callback</param>
						/// <param name="sScrollLoadDirection">Scrolling direction</param>
						public extern virtual void setGrowingList(object fnScrollLoadCallback, sap.m.ListGrowingDirection sScrollLoadDirection);

						/// <summary>
						/// Enable or disable horizontal scrolling.
						/// </summary>
						/// <param name="bHorizontal">set true to enable horizontal scrolling, false - to disable</param>
						public extern virtual void setHorizontal(bool bHorizontal);

						/// <summary>
						/// Sets IconTabBar control to scroll container
						/// </summary>
						/// <param name="oIconTabBar">instance</param>
						/// <param name="fnScrollEndCallback">callback function for the scroll end event</param>
						/// <param name="fnScrollStartCallback">callback function for the scroll start event</param>
						public extern virtual void setIconTabBar(sap.m.IconTabBar oIconTabBar, object fnScrollEndCallback, object fnScrollStartCallback);

						/// <summary>
						/// Set overflow control on top of scroll container.
						/// </summary>
						/// <param name="oControl">Top control that should be normally hidden over the top border of the scroll container (pull-down content).</param>
						public extern virtual void setPullDown(sap.ui.core.Control oControl);

						/// <summary>
						/// Enable or disable vertical scrolling.
						/// </summary>
						/// <param name="bVertical">set true to enable vertical scrolling, false - to disable</param>
						public extern virtual void setVertical(bool bVertical);

						#endregion

					}
				}
			}
		}
	}
}
