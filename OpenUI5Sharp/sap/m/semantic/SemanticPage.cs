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
			public static partial class semantic
			{
				/// <summary>
				/// An enhanced {@link sap.m.Page}, that can contain controls with semantic meaning, see {@link sap.m.semantic.SemanticControl}.
				/// 
				/// <b>Note:</b> This control implements the SAP Fiori 1.0 design guidelines. For SAP Fiori 2.0, see the {@link sap.f.semantic.SemanticPage}.
				/// 
				/// <h3>Overview</h3>
				/// 
				/// The main functionality of the <code>SemanticPage</code> is to predefine the placement, behavior and styles of the page elements.
				/// 
				/// Content specified in the semantic aggregations will be automatically positioned in dedicated sections of the footer or the header of the page.
				/// 
				/// <h3>Structure</h3>
				/// 
				/// The semantics of the content are the following: <ul> <li>Visual properties (for example, <code>AddAction</code> will be styled as an icon button)</li> <li>Position in the page (UX guidelines specify that some buttons should be in the header only, while others are in the footer or the "share" menu, so we do the correct positioning)</li> <li>Sequence order (UX guidelines define a specific sequence order of semantic controls with respect to each other)</li> <li>Default localized tooltip for icon-only buttons</li> <li>Overflow behavior (UX guidelines define which buttons are allowed to go to the overflow of the toolbar when the screen gets narrower). For icon buttons, we ensure that the text label of the button appears when the button is in overflow, as specified by UX.</li> <li>Screen reader support (invisible text for reading the semantic type)</li> </ul>
				/// 
				/// In addition to the predefined semantic controls, the <code>SemanticPage</code> can host also custom app controls. It preserves most of the API of the {@link sap.m.Page} for specifying page content.
				/// 
				/// <h3>Usage</h3>
				/// 
				/// The app developer only has to specify the action type, and the required styling and positioning are automatically added.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.m.semantic.SemanticPage")]
				public abstract partial class SemanticPage : sap.ui.core.Control
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
						/// See {@link sap.m.Page#title}
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// See {@link sap.m.Page#titleLevel}
						/// </summary>
						public Union<sap.ui.core.TitleLevel, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleLevel;

						/// <summary>
						/// See {@link sap.m.Page#showNavButton}
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showNavButton;

						/// <summary>
						/// See {@link sap.m.Page#showSubHeader}
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSubHeader;

						/// <summary>
						/// See {@link sap.m.Page#enableScrolling}
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableScrolling;

						/// <summary>
						/// Hides or shows the page footer
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showFooter;

						/// <summary>
						/// Determines whether the floating footer behavior is enabled. If set to <code>true</code>, the content is visible when it's underneath the footer.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> floatingFooter;

						/// <summary>
						/// Declares the type of semantic ruleset that will govern the styling and positioning of semantic content.
						/// </summary>
						public Union<sap.m.semantic.SemanticRuleSetType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> semanticRuleSet;

						/// <summary>
						/// Determines the backgound color of the page. For more information, see {@link sap.m.Page#backgroundDesign}.
						/// </summary>
						public Union<sap.m.PageBackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

						/// <summary>
						/// See {@link sap.m.Page#subHeader}
						/// </summary>
						public Union<sap.m.IBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> subHeader;

						/// <summary>
						/// See {@link sap.m.Page#content}
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Custom header buttons
						/// </summary>
						public Union<sap.m.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> customHeaderContent;

						/// <summary>
						/// Custom footer buttons
						/// </summary>
						public Union<sap.m.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> customFooterContent;

						/// <summary>
						/// Accessible landmark settings to be applied to the containers of the <code>sap.m.Page</code> control.
						/// 
						/// If not set, no landmarks will be written.
						/// </summary>
						public Union<sap.m.PageAccessibleLandmarkInfo, string, sap.ui.@base.ManagedObject.BindAggregationInfo> landmarkInfo;

						/// <summary>
						/// See {@link sap.m.Page#navButtonPress}
						/// </summary>
						public sap.ui.@base.EventDelegate navButtonPress;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>SemanticPage</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern SemanticPage(string sId, sap.m.semantic.SemanticPage.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>SemanticPage</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern SemanticPage(string sId);

					/// <summary>
					/// Constructor for a new <code>SemanticPage</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern SemanticPage();

					/// <summary>
					/// Constructor for a new <code>SemanticPage</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern SemanticPage(sap.m.semantic.SemanticPage.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// See {@link sap.m.Page#title}
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// See {@link sap.m.Page#title}
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage setTitle(string sTitle);

					#endregion

					#region Methods for Property titleLevel

					/// <summary>
					/// Gets current value of property {@link #getTitleLevel titleLevel}.
					/// 
					/// See {@link sap.m.Page#titleLevel}
					/// 
					/// Default value is <code>Auto</code>.
					/// </summary>
					/// <returns>Value of property <code>titleLevel</code></returns>
					public extern virtual sap.ui.core.TitleLevel getTitleLevel();

					/// <summary>
					/// Sets a new value for property {@link #getTitleLevel titleLevel}.
					/// 
					/// See {@link sap.m.Page#titleLevel}
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Auto</code>.
					/// </summary>
					/// <param name="sTitleLevel">New value for property <code>titleLevel</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage setTitleLevel(sap.ui.core.TitleLevel sTitleLevel);

					#endregion

					#region Methods for Property showNavButton

					/// <summary>
					/// Gets current value of property {@link #getShowNavButton showNavButton}.
					/// 
					/// See {@link sap.m.Page#showNavButton}
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>showNavButton</code></returns>
					public extern virtual bool getShowNavButton();

					/// <summary>
					/// Sets a new value for property {@link #getShowNavButton showNavButton}.
					/// 
					/// See {@link sap.m.Page#showNavButton}
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShowNavButton">New value for property <code>showNavButton</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage setShowNavButton(bool bShowNavButton);

					#endregion

					#region Methods for Property showSubHeader

					/// <summary>
					/// Gets current value of property {@link #getShowSubHeader showSubHeader}.
					/// 
					/// See {@link sap.m.Page#showSubHeader}
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showSubHeader</code></returns>
					public extern virtual bool getShowSubHeader();

					/// <summary>
					/// Sets a new value for property {@link #getShowSubHeader showSubHeader}.
					/// 
					/// See {@link sap.m.Page#showSubHeader}
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowSubHeader">New value for property <code>showSubHeader</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage setShowSubHeader(bool bShowSubHeader);

					#endregion

					#region Methods for Property enableScrolling

					/// <summary>
					/// Gets current value of property {@link #getEnableScrolling enableScrolling}.
					/// 
					/// See {@link sap.m.Page#enableScrolling}
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableScrolling</code></returns>
					public extern virtual bool getEnableScrolling();

					/// <summary>
					/// Sets a new value for property {@link #getEnableScrolling enableScrolling}.
					/// 
					/// See {@link sap.m.Page#enableScrolling}
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableScrolling">New value for property <code>enableScrolling</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage setEnableScrolling(bool bEnableScrolling);

					#endregion

					#region Methods for Property showFooter

					/// <summary>
					/// Gets current value of property {@link #getShowFooter showFooter}.
					/// 
					/// Hides or shows the page footer
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showFooter</code></returns>
					public extern virtual bool getShowFooter();

					/// <summary>
					/// Sets a new value for property {@link #getShowFooter showFooter}.
					/// 
					/// Hides or shows the page footer
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowFooter">New value for property <code>showFooter</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage setShowFooter(bool bShowFooter);

					#endregion

					#region Methods for Property floatingFooter

					/// <summary>
					/// Gets current value of property {@link #getFloatingFooter floatingFooter}.
					/// 
					/// Determines whether the floating footer behavior is enabled. If set to <code>true</code>, the content is visible when it's underneath the footer.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>floatingFooter</code></returns>
					public extern virtual bool getFloatingFooter();

					/// <summary>
					/// Sets a new value for property {@link #getFloatingFooter floatingFooter}.
					/// 
					/// Determines whether the floating footer behavior is enabled. If set to <code>true</code>, the content is visible when it's underneath the footer.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bFloatingFooter">New value for property <code>floatingFooter</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage setFloatingFooter(bool bFloatingFooter);

					#endregion

					#region Methods for Property semanticRuleSet

					/// <summary>
					/// Gets current value of property {@link #getSemanticRuleSet semanticRuleSet}.
					/// 
					/// Declares the type of semantic ruleset that will govern the styling and positioning of semantic content.
					/// 
					/// Default value is <code>Classic</code>.
					/// </summary>
					/// <returns>Value of property <code>semanticRuleSet</code></returns>
					public extern virtual sap.m.semantic.SemanticRuleSetType getSemanticRuleSet();

					/// <summary>
					/// Sets a new value for property {@link #getSemanticRuleSet semanticRuleSet}.
					/// 
					/// Declares the type of semantic ruleset that will govern the styling and positioning of semantic content.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Classic</code>.
					/// </summary>
					/// <param name="sSemanticRuleSet">New value for property <code>semanticRuleSet</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage setSemanticRuleSet(sap.m.semantic.SemanticRuleSetType sSemanticRuleSet);

					#endregion

					#region Methods for Property backgroundDesign

					/// <summary>
					/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
					/// 
					/// Determines the backgound color of the page. For more information, see {@link sap.m.Page#backgroundDesign}.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <returns>Value of property <code>backgroundDesign</code></returns>
					public extern virtual sap.m.PageBackgroundDesign getBackgroundDesign();

					/// <summary>
					/// Sets a new value for property {@link #getBackgroundDesign backgroundDesign}.
					/// 
					/// Determines the backgound color of the page. For more information, see {@link sap.m.Page#backgroundDesign}.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <param name="sBackgroundDesign">New value for property <code>backgroundDesign</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage setBackgroundDesign(sap.m.PageBackgroundDesign sBackgroundDesign);

					#endregion

					#region Methods for Aggregation subHeader

					/// <summary>
					/// Gets content of aggregation {@link #getSubHeader subHeader}.
					/// 
					/// See {@link sap.m.Page#subHeader}
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.IBar getSubHeader();

					/// <summary>
					/// Destroys the subHeader in the aggregation {@link #getSubHeader subHeader}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage destroySubHeader();

					/// <summary>
					/// Sets the aggregated {@link #getSubHeader subHeader}.
					/// </summary>
					/// <param name="oSubHeader">The subHeader to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage setSubHeader(sap.m.IBar oSubHeader);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// See {@link sap.m.Page#content}
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage addContent(sap.ui.core.Control oContent);

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

					#region Methods for Aggregation customHeaderContent

					/// <summary>
					/// Gets content of aggregation {@link #getCustomHeaderContent customHeaderContent}.
					/// 
					/// Custom header buttons
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.Button[] getCustomHeaderContent();

					/// <summary>
					/// Destroys all the customHeaderContent in the aggregation {@link #getCustomHeaderContent customHeaderContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage destroyCustomHeaderContent();

					/// <summary>
					/// Inserts a customHeaderContent into the aggregation {@link #getCustomHeaderContent customHeaderContent}.
					/// </summary>
					/// <param name="oCustomHeaderContent">The customHeaderContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the customHeaderContent should be inserted at; for a negative value of <code>iIndex</code>, the customHeaderContent is inserted at position 0; for a value greater than the current size of the aggregation, the customHeaderContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage insertCustomHeaderContent(sap.m.Button oCustomHeaderContent, int iIndex);

					/// <summary>
					/// Adds some customHeaderContent to the aggregation {@link #getCustomHeaderContent customHeaderContent}.
					/// </summary>
					/// <param name="oCustomHeaderContent">The customHeaderContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage addCustomHeaderContent(sap.m.Button oCustomHeaderContent);

					/// <summary>
					/// Removes a customHeaderContent from the aggregation {@link #getCustomHeaderContent customHeaderContent}.
					/// </summary>
					/// <param name="vCustomHeaderContent">The customHeaderContent to remove or its index or id</param>
					/// <returns>The removed customHeaderContent or <code>null</code></returns>
					public extern virtual sap.m.Button removeCustomHeaderContent(Union<int, string, sap.m.Button> vCustomHeaderContent);

					/// <summary>
					/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getCustomHeaderContent customHeaderContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oCustomHeaderContent">The customHeaderContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfCustomHeaderContent(sap.m.Button oCustomHeaderContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getCustomHeaderContent customHeaderContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.m.Button[] removeAllCustomHeaderContent();

					#endregion

					#region Methods for Aggregation customFooterContent

					/// <summary>
					/// Gets content of aggregation {@link #getCustomFooterContent customFooterContent}.
					/// 
					/// Custom footer buttons
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.Button[] getCustomFooterContent();

					/// <summary>
					/// Destroys all the customFooterContent in the aggregation {@link #getCustomFooterContent customFooterContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage destroyCustomFooterContent();

					/// <summary>
					/// Inserts a customFooterContent into the aggregation {@link #getCustomFooterContent customFooterContent}.
					/// </summary>
					/// <param name="oCustomFooterContent">The customFooterContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the customFooterContent should be inserted at; for a negative value of <code>iIndex</code>, the customFooterContent is inserted at position 0; for a value greater than the current size of the aggregation, the customFooterContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage insertCustomFooterContent(sap.m.Button oCustomFooterContent, int iIndex);

					/// <summary>
					/// Adds some customFooterContent to the aggregation {@link #getCustomFooterContent customFooterContent}.
					/// </summary>
					/// <param name="oCustomFooterContent">The customFooterContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage addCustomFooterContent(sap.m.Button oCustomFooterContent);

					/// <summary>
					/// Removes a customFooterContent from the aggregation {@link #getCustomFooterContent customFooterContent}.
					/// </summary>
					/// <param name="vCustomFooterContent">The customFooterContent to remove or its index or id</param>
					/// <returns>The removed customFooterContent or <code>null</code></returns>
					public extern virtual sap.m.Button removeCustomFooterContent(Union<int, string, sap.m.Button> vCustomFooterContent);

					/// <summary>
					/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getCustomFooterContent customFooterContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oCustomFooterContent">The customFooterContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfCustomFooterContent(sap.m.Button oCustomFooterContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getCustomFooterContent customFooterContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.m.Button[] removeAllCustomFooterContent();

					#endregion

					#region Methods for Aggregation landmarkInfo

					/// <summary>
					/// Gets content of aggregation {@link #getLandmarkInfo landmarkInfo}.
					/// 
					/// Accessible landmark settings to be applied to the containers of the <code>sap.m.Page</code> control.
					/// 
					/// If not set, no landmarks will be written.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.PageAccessibleLandmarkInfo getLandmarkInfo();

					/// <summary>
					/// Destroys the landmarkInfo in the aggregation {@link #getLandmarkInfo landmarkInfo}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage destroyLandmarkInfo();

					/// <summary>
					/// Sets the aggregated {@link #getLandmarkInfo landmarkInfo}.
					/// </summary>
					/// <param name="oLandmarkInfo">The landmarkInfo to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage setLandmarkInfo(sap.m.PageAccessibleLandmarkInfo oLandmarkInfo);

					#endregion

					#region Methods for Aggregation _page

					#endregion

					#region Methods for Event navButtonPress

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.semantic.SemanticPage</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.semantic.SemanticPage</code> itself.
					/// 
					/// See {@link sap.m.Page#navButtonPress}
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.semantic.SemanticPage</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage attachNavButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.semantic.SemanticPage</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.semantic.SemanticPage</code> itself.
					/// 
					/// See {@link sap.m.Page#navButtonPress}
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage attachNavButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.semantic.SemanticPage</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.semantic.SemanticPage</code> itself.
					/// 
					/// See {@link sap.m.Page#navButtonPress}
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage attachNavButtonPress(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.semantic.SemanticPage</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.semantic.SemanticPage</code> itself.
					/// 
					/// See {@link sap.m.Page#navButtonPress}
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.semantic.SemanticPage</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage attachNavButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:navButtonPress navButtonPress} event of this <code>sap.m.semantic.SemanticPage</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage detachNavButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:navButtonPress navButtonPress} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage fireNavButtonPress(object mParameters);

					/// <summary>
					/// Fires event {@link #event:navButtonPress navButtonPress} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticPage fireNavButtonPress();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SemanticPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SemanticPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SemanticPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.m.semantic.SemanticPage.
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
