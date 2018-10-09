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
			public static partial class unified
			{
				/// <summary>
				/// The shell control is meant as root control (full-screen) of an application. It was build as root control of the Fiori Launchpad application and provides the basic capabilities for this purpose. Do not use this control within applications which run inside the Fiori Lauchpad and do not use it for other scenarios than the root control usecase.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.Shell")]
				[Obsolete("Deprecated since 1.44.0.")]
				public partial class Shell : sap.ui.unified.ShellLayout
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.unified.ShellLayout.Settings
					{
						/// <summary>
						/// The application icon. If a custom header is set this property has no effect.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Shows / Hides the curtain.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showCurtain;

						/// <summary>
						/// Shows / Hides the side pane on the curtain.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showCurtainPane;

						/// <summary>
						/// If set to false, the search area (aggregation 'search') is hidden. If a custom header is set this property has no effect.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> searchVisible;

						/// <summary>
						/// The content to appear in the curtain area.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> curtainContent;

						/// <summary>
						/// The content to appear in the pane area of the curtain.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> curtainPaneContent;

						/// <summary>
						/// The buttons shown in the begin (left in left-to-right case) of the Shell header. Currently max. 3 visible buttons are supported. If a custom header is set this aggregation has no effect.
						/// </summary>
						public Union<sap.ui.unified.ShellHeadItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> headItems;

						/// <summary>
						/// The buttons shown in the end (right in left-to-right case) of the Shell header. Currently max. 3 visible buttons are supported (when user is set only 1). If a custom header is set this aggregation has no effect.
						/// </summary>
						public Union<sap.ui.unified.ShellHeadItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> headEndItems;

						/// <summary>
						/// Experimental (This aggregation might change in future!): The search control which should be displayed in the shell header. If a custom header is set this aggregation has no effect.
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> search;

						/// <summary>
						/// The user item which is rendered in the shell header beside the items. If a custom header is set this aggregation has no effect.
						/// </summary>
						public Union<sap.ui.unified.ShellHeadUserItem, string, sap.ui.@base.ManagedObject.BindAggregationInfo> user;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Shell.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Shell(string sId, sap.ui.unified.Shell.Settings mSettings);

					/// <summary>
					/// Constructor for a new Shell.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Shell(string sId);

					/// <summary>
					/// Constructor for a new Shell.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Shell();

					/// <summary>
					/// Constructor for a new Shell.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Shell(sap.ui.unified.Shell.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// The application icon. If a custom header is set this property has no effect.
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// The application icon. If a custom header is set this property has no effect.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property showCurtain

					/// <summary>
					/// Gets current value of property {@link #getShowCurtain showCurtain}.
					/// 
					/// Shows / Hides the curtain.
					/// </summary>
					/// <returns>Value of property <code>showCurtain</code></returns>
					[Obsolete("Deprecated since 1.16.3. Curtain is deprecated and replaced by ShellOverlay mechanism.")]
					public extern virtual bool getShowCurtain();

					/// <summary>
					/// Sets a new value for property {@link #getShowCurtain showCurtain}.
					/// 
					/// Shows / Hides the curtain.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="bShowCurtain">New value for property <code>showCurtain</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.16.3. Curtain is deprecated and replaced by ShellOverlay mechanism.")]
					public extern virtual sap.ui.unified.Shell setShowCurtain(bool bShowCurtain);

					#endregion

					#region Methods for Property showCurtainPane

					/// <summary>
					/// Gets current value of property {@link #getShowCurtainPane showCurtainPane}.
					/// 
					/// Shows / Hides the side pane on the curtain.
					/// </summary>
					/// <returns>Value of property <code>showCurtainPane</code></returns>
					[Obsolete("Deprecated since 1.16.3. Curtain is deprecated and replaced by ShellOverlay mechanism.")]
					public extern virtual bool getShowCurtainPane();

					/// <summary>
					/// Sets a new value for property {@link #getShowCurtainPane showCurtainPane}.
					/// 
					/// Shows / Hides the side pane on the curtain.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="bShowCurtainPane">New value for property <code>showCurtainPane</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.16.3. Curtain is deprecated and replaced by ShellOverlay mechanism.")]
					public extern virtual sap.ui.unified.Shell setShowCurtainPane(bool bShowCurtainPane);

					#endregion

					#region Methods for Property searchVisible

					/// <summary>
					/// Gets current value of property {@link #getSearchVisible searchVisible}.
					/// 
					/// If set to false, the search area (aggregation 'search') is hidden. If a custom header is set this property has no effect.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>searchVisible</code></returns>
					public extern virtual bool getSearchVisible();

					/// <summary>
					/// Sets a new value for property {@link #getSearchVisible searchVisible}.
					/// 
					/// If set to false, the search area (aggregation 'search') is hidden. If a custom header is set this property has no effect.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bSearchVisible">New value for property <code>searchVisible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell setSearchVisible(bool bSearchVisible);

					#endregion

					#region Methods for Aggregation curtainContent

					/// <summary>
					/// Gets content of aggregation {@link #getCurtainContent curtainContent}.
					/// 
					/// The content to appear in the curtain area.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getCurtainContent();

					/// <summary>
					/// Destroys all the curtainContent in the aggregation {@link #getCurtainContent curtainContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell destroyCurtainContent();

					/// <summary>
					/// Inserts a curtainContent into the aggregation {@link #getCurtainContent curtainContent}.
					/// </summary>
					/// <param name="oCurtainContent">The curtainContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the curtainContent should be inserted at; for a negative value of <code>iIndex</code>, the curtainContent is inserted at position 0; for a value greater than the current size of the aggregation, the curtainContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell insertCurtainContent(sap.ui.core.Control oCurtainContent, int iIndex);

					/// <summary>
					/// Adds some curtainContent to the aggregation {@link #getCurtainContent curtainContent}.
					/// </summary>
					/// <param name="oCurtainContent">The curtainContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell addCurtainContent(sap.ui.core.Control oCurtainContent);

					/// <summary>
					/// Removes a curtainContent from the aggregation {@link #getCurtainContent curtainContent}.
					/// </summary>
					/// <param name="vCurtainContent">The curtainContent to remove or its index or id</param>
					/// <returns>The removed curtainContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeCurtainContent(Union<int, string, sap.ui.core.Control> vCurtainContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getCurtainContent curtainContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oCurtainContent">The curtainContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfCurtainContent(sap.ui.core.Control oCurtainContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getCurtainContent curtainContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllCurtainContent();

					#endregion

					#region Methods for Aggregation curtainPaneContent

					/// <summary>
					/// Gets content of aggregation {@link #getCurtainPaneContent curtainPaneContent}.
					/// 
					/// The content to appear in the pane area of the curtain.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getCurtainPaneContent();

					/// <summary>
					/// Destroys all the curtainPaneContent in the aggregation {@link #getCurtainPaneContent curtainPaneContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell destroyCurtainPaneContent();

					/// <summary>
					/// Inserts a curtainPaneContent into the aggregation {@link #getCurtainPaneContent curtainPaneContent}.
					/// </summary>
					/// <param name="oCurtainPaneContent">The curtainPaneContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the curtainPaneContent should be inserted at; for a negative value of <code>iIndex</code>, the curtainPaneContent is inserted at position 0; for a value greater than the current size of the aggregation, the curtainPaneContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell insertCurtainPaneContent(sap.ui.core.Control oCurtainPaneContent, int iIndex);

					/// <summary>
					/// Adds some curtainPaneContent to the aggregation {@link #getCurtainPaneContent curtainPaneContent}.
					/// </summary>
					/// <param name="oCurtainPaneContent">The curtainPaneContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell addCurtainPaneContent(sap.ui.core.Control oCurtainPaneContent);

					/// <summary>
					/// Removes a curtainPaneContent from the aggregation {@link #getCurtainPaneContent curtainPaneContent}.
					/// </summary>
					/// <param name="vCurtainPaneContent">The curtainPaneContent to remove or its index or id</param>
					/// <returns>The removed curtainPaneContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeCurtainPaneContent(Union<int, string, sap.ui.core.Control> vCurtainPaneContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getCurtainPaneContent curtainPaneContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oCurtainPaneContent">The curtainPaneContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfCurtainPaneContent(sap.ui.core.Control oCurtainPaneContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getCurtainPaneContent curtainPaneContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllCurtainPaneContent();

					#endregion

					#region Methods for Aggregation headItems

					/// <summary>
					/// Gets content of aggregation {@link #getHeadItems headItems}.
					/// 
					/// The buttons shown in the begin (left in left-to-right case) of the Shell header. Currently max. 3 visible buttons are supported. If a custom header is set this aggregation has no effect.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.ShellHeadItem[] getHeadItems();

					/// <summary>
					/// Destroys all the headItems in the aggregation {@link #getHeadItems headItems}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell destroyHeadItems();

					/// <summary>
					/// Inserts a headItem into the aggregation {@link #getHeadItems headItems}.
					/// </summary>
					/// <param name="oHeadItem">The headItem to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the headItem should be inserted at; for a negative value of <code>iIndex</code>, the headItem is inserted at position 0; for a value greater than the current size of the aggregation, the headItem is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell insertHeadItem(sap.ui.unified.ShellHeadItem oHeadItem, int iIndex);

					/// <summary>
					/// Adds some headItem to the aggregation {@link #getHeadItems headItems}.
					/// </summary>
					/// <param name="oHeadItem">The headItem to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell addHeadItem(sap.ui.unified.ShellHeadItem oHeadItem);

					/// <summary>
					/// Removes a headItem from the aggregation {@link #getHeadItems headItems}.
					/// </summary>
					/// <param name="vHeadItem">The headItem to remove or its index or id</param>
					/// <returns>The removed headItem or <code>null</code></returns>
					public extern virtual sap.ui.unified.ShellHeadItem removeHeadItem(Union<int, string, sap.ui.unified.ShellHeadItem> vHeadItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.unified.ShellHeadItem</code> in the aggregation {@link #getHeadItems headItems}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oHeadItem">The headItem whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfHeadItem(sap.ui.unified.ShellHeadItem oHeadItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getHeadItems headItems}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.unified.ShellHeadItem[] removeAllHeadItems();

					#endregion

					#region Methods for Aggregation headEndItems

					/// <summary>
					/// Gets content of aggregation {@link #getHeadEndItems headEndItems}.
					/// 
					/// The buttons shown in the end (right in left-to-right case) of the Shell header. Currently max. 3 visible buttons are supported (when user is set only 1). If a custom header is set this aggregation has no effect.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.ShellHeadItem[] getHeadEndItems();

					/// <summary>
					/// Destroys all the headEndItems in the aggregation {@link #getHeadEndItems headEndItems}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell destroyHeadEndItems();

					/// <summary>
					/// Inserts a headEndItem into the aggregation {@link #getHeadEndItems headEndItems}.
					/// </summary>
					/// <param name="oHeadEndItem">The headEndItem to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the headEndItem should be inserted at; for a negative value of <code>iIndex</code>, the headEndItem is inserted at position 0; for a value greater than the current size of the aggregation, the headEndItem is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell insertHeadEndItem(sap.ui.unified.ShellHeadItem oHeadEndItem, int iIndex);

					/// <summary>
					/// Adds some headEndItem to the aggregation {@link #getHeadEndItems headEndItems}.
					/// </summary>
					/// <param name="oHeadEndItem">The headEndItem to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell addHeadEndItem(sap.ui.unified.ShellHeadItem oHeadEndItem);

					/// <summary>
					/// Removes a headEndItem from the aggregation {@link #getHeadEndItems headEndItems}.
					/// </summary>
					/// <param name="vHeadEndItem">The headEndItem to remove or its index or id</param>
					/// <returns>The removed headEndItem or <code>null</code></returns>
					public extern virtual sap.ui.unified.ShellHeadItem removeHeadEndItem(Union<int, string, sap.ui.unified.ShellHeadItem> vHeadEndItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.unified.ShellHeadItem</code> in the aggregation {@link #getHeadEndItems headEndItems}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oHeadEndItem">The headEndItem whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfHeadEndItem(sap.ui.unified.ShellHeadItem oHeadEndItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getHeadEndItems headEndItems}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.unified.ShellHeadItem[] removeAllHeadEndItems();

					#endregion

					#region Methods for Aggregation search

					/// <summary>
					/// Gets content of aggregation {@link #getSearch search}.
					/// 
					/// Experimental (This aggregation might change in future!): The search control which should be displayed in the shell header. If a custom header is set this aggregation has no effect.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control getSearch();

					/// <summary>
					/// Destroys the search in the aggregation {@link #getSearch search}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell destroySearch();

					/// <summary>
					/// Sets the aggregated {@link #getSearch search}.
					/// </summary>
					/// <param name="oSearch">The search to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell setSearch(sap.ui.core.Control oSearch);

					#endregion

					#region Methods for Aggregation user

					/// <summary>
					/// Gets content of aggregation {@link #getUser user}.
					/// 
					/// The user item which is rendered in the shell header beside the items. If a custom header is set this aggregation has no effect.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.ShellHeadUserItem getUser();

					/// <summary>
					/// Destroys the user in the aggregation {@link #getUser user}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell destroyUser();

					/// <summary>
					/// Sets the aggregated {@link #getUser user}.
					/// </summary>
					/// <param name="oUser">The user to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell setUser(sap.ui.unified.ShellHeadUserItem oUser);

					#endregion

					#region Other methods

					/// <summary>
					/// Destroys the header in the aggregation named <code>header</code>, but only if a custom header is set. The default header can not be destroyed.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell destroyHeader();

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Shell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.ShellLayout.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Shell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.ShellLayout.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Shell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.ShellLayout.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.Shell.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Setter for the aggregated <code>header</code>.
					/// </summary>
					/// <param name="oHeader">The Control which should be rendered within the Shell header or <code>null</code> to render the default Shell header.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.unified.Shell setHeader(sap.ui.core.Control oHeader);

					#endregion

					#endregion

				}
			}
		}
	}
}
