using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class f
		{
			/// <summary>
			/// Implements the master-detail-detail paradigm by displaying up to three pages in separate columns.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The control is logically similar to {@link sap.m.SplitContainer} with the difference that it capable of handling three columns (referred to as <code>Begin</code>, <code>Mid</code> and <code>End</code>) rather than two (<code>Master</code>, <code>Detail</code>). The width of the three columns is variable.
			/// 
			/// There are several possible layouts that can be changed either with the control's API, or by the user with the help of layout arrows.
			/// 
			/// Internally the control makes use of three instances of {@link sap.m.NavContainer}, thus forming the three columns.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// Use this control for applications that need to display several logical levels of related information side by side (e.g. list of items, item, sub-item, etc.). The control is flexible in a sense that the application can focus the user's attention on one particular column by making it larger or even fullscreen.
			/// 
			/// The columns are accessible with the <code>beginColumnPages</code>, <code>midColumnPages</code> and <code>endColumnPages</code> aggregations.
			/// 
			/// The relative sizes and the visibility of the three columns are determined based on the value of the {@link sap.f.LayoutType layout} property.
			/// 
			/// Changes to the layout due to user interaction are communicated to the app with the <code>stateChange</code> event.
			/// 
			/// <ul><b>Notes:</b> <li>To easily implement the recommended UX design of a <code>sap.f.FlexibleColumnLayout</code>-based app, you can use the <code>sap.f.FlexibleColumnLayoutSemanticHelper</code> class.</li> <li>To facilitate the navigation and view loading, you can use the {@link sap.f.routing.Router} </li></ul>
			/// 
			/// <h3>Responsive Behavior</h3>
			/// 
			/// The control automatically displays the maximum possible number of columns based on the device size and current <code>layout</code>. The app does not need to take into consideration the current device/screen size, but only to add content to the columns and change the value of the <code>layout</code> property.
			/// 
			/// For detailed information, see {@link sap.f.LayoutType LayoutType} enumeration.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.f.FlexibleColumnLayout")]
			public partial class FlexibleColumnLayout : sap.ui.core.Control
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
					/// Determines the layout of the control - number of visible columns and their relative sizes.
					/// 
					/// For more details, see {@link topic:3b9f760da5b64adf8db7f95247879086 Types of Layout} in the documentation.
					/// </summary>
					public Union<sap.f.LayoutType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> layout;

					/// <summary>
					/// Determines the type of the transition/animation to apply for the <code>Begin</code> column when <code>to()</code> is called without defining the transition to use. The default is <code>slide</code>, other options are <code>fade</code>, <code>flip</code>, <code>show</code>, and the names of any registered custom transitions.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultTransitionNameBeginColumn;

					/// <summary>
					/// Determines the type of the transition/animation to apply for the <code>Mid</code> column when <code>to()</code> is called without defining the transition to use. The default is <code>slide</code>, other options are <code>fade</code>, <code>flip</code>, <code>show</code>, and the names of any registered custom transitions.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultTransitionNameMidColumn;

					/// <summary>
					/// Determines the type of the transition/animation to apply for the <code>End</code> column when <code>to()</code> is called without defining the transition to use. The default is <code>slide</code>, other options are <code>fade</code>, <code>flip</code>, <code>show</code>, and the names of any registered custom transitions.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultTransitionNameEndColumn;

					/// <summary>
					/// Specifies the background color of the content. The visualization of the different options depends on the used theme.
					/// </summary>
					public Union<sap.m.BackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

					/// <summary>
					/// The content entities between which the <code>FlexibleColumnLayout</code> navigates in the <code>Begin</code> column.
					/// 
					/// These should be any control with page semantics. These aggregated controls will receive navigation events like {@link sap.m.NavContainerChild#beforeShow beforeShow}, they are documented in the pseudo interface {@link sap.m.NavContainerChild sap.m.NavContainerChild}.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> beginColumnPages;

					/// <summary>
					/// The content entities between which the <code>FlexibleColumnLayout</code> navigates in the <code>Mid</code> column.
					/// 
					/// These should be any control with page semantics. These aggregated controls will receive navigation events like {@link sap.m.NavContainerChild#beforeShow beforeShow}, they are documented in the pseudo interface {@link sap.m.NavContainerChild sap.m.NavContainerChild}.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> midColumnPages;

					/// <summary>
					/// The content entities between which the <code>FlexibleColumnLayout</code> navigates in the <code>End</code> column.
					/// 
					/// These should be any control with page semantics. These aggregated controls will receive navigation events like {@link sap.m.NavContainerChild#beforeShow beforeShow}, they are documented in the pseudo interface {@link sap.m.NavContainerChild sap.m.NavContainerChild}.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> endColumnPages;

					/// <summary>
					/// Sets the initial <code>Begin</code> column page, which is displayed on application launch.
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialBeginColumnPage;

					/// <summary>
					/// Sets the initial <code>Mid</code> column page, which is displayed on application launch.
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialMidColumnPage;

					/// <summary>
					/// Sets the initial <code>End</code> column page, which is displayed on application launch.
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialEndColumnPage;

					/// <summary>
					/// Fired when there is a change in the <code>layout</code> property or in the maximum number of columns that can be displayed at once. <br/></br> <ul>The interactions that may lead to a state change are: <li>the property <code>layout</code> was changed indirectly by the user clicking a layout arrow</li> <li>the user resized the browser beyond a breakpoint, thus changing the maximum number of columns that can be displayed at once.</li></ul> <br/><br/> <b>Note: </b>The event is suppressed while the control has zero width and will be fired the first time it gets a non-zero width
					/// </summary>
					public sap.f.FlexibleColumnLayout.StateChangeDelegate stateChange;

					/// <summary>
					/// Fires when navigation between two pages in the <code>Begin</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
					/// </summary>
					public sap.m.NavigateDelegate beginColumnNavigate;

					/// <summary>
					/// Fires when navigation between two pages in the <code>Begin</code> column has completed.
					/// 
					/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
					/// </summary>
					public sap.m.NavigateDelegate afterBeginColumnNavigate;

					/// <summary>
					/// Fires when navigation between two pages in the <code>Mid</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
					/// </summary>
					public sap.m.NavigateDelegate midColumnNavigate;

					/// <summary>
					/// Fires when navigation between two pages in the <code>Mid</code> column has completed.
					/// 
					/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
					/// </summary>
					public sap.m.NavigateDelegate afterMidColumnNavigate;

					/// <summary>
					/// Fires when navigation between two pages in the <code>End</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
					/// </summary>
					public sap.m.NavigateDelegate endColumnNavigate;

					/// <summary>
					/// Fires when navigation between two pages in the <code>End</code> column has completed.
					/// 
					/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
					/// </summary>
					public sap.m.NavigateDelegate afterEndColumnNavigate;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class StateChangeInfo
				{
					/// <summary>
					/// The value of the <code>layout</code> property
					/// </summary>
					public sap.f.LayoutType layout;

					/// <summary>
					/// The maximum number of columns that can be displayed at once based on the available screen size and control settings.
					/// 
					/// <ul>Possible values are: <li>3 for browser size of 1280px or more</li> <li>2 for browser size between 960px and 1280px</li> <li>1 for browser size less than 960px</li></ul>
					/// </summary>
					public int maxColumnsCount;

					/// <summary>
					/// Indicates whether the layout changed as a result of the user clicking a layout arrow
					/// </summary>
					public bool isNavigationArrow;

					/// <summary>
					/// Indicates whether the maximum number of columns that can be displayed at once changed
					/// </summary>
					public bool isResize;

				}

				#endregion

				#region Delegates

				public delegate void StateChangeDelegate(sap.ui.@base.Event<sap.f.FlexibleColumnLayout.StateChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern FlexibleColumnLayout(string sId, sap.f.FlexibleColumnLayout.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern FlexibleColumnLayout(string sId);

				/// <summary>
				/// Constructor for a new <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern FlexibleColumnLayout();

				/// <summary>
				/// Constructor for a new <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern FlexibleColumnLayout(sap.f.FlexibleColumnLayout.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property layout

				/// <summary>
				/// Gets current value of property {@link #getLayout layout}.
				/// 
				/// Determines the layout of the control - number of visible columns and their relative sizes.
				/// 
				/// For more details, see {@link topic:3b9f760da5b64adf8db7f95247879086 Types of Layout} in the documentation.
				/// 
				/// Default value is <code>OneColumn</code>.
				/// </summary>
				/// <returns>Value of property <code>layout</code></returns>
				public extern virtual sap.f.LayoutType getLayout();

				/// <summary>
				/// Sets a new value for property {@link #getLayout layout}.
				/// 
				/// Determines the layout of the control - number of visible columns and their relative sizes.
				/// 
				/// For more details, see {@link topic:3b9f760da5b64adf8db7f95247879086 Types of Layout} in the documentation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>OneColumn</code>.
				/// </summary>
				/// <param name="sLayout">New value for property <code>layout</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout setLayout(sap.f.LayoutType sLayout);

				#endregion

				#region Methods for Property defaultTransitionNameBeginColumn

				/// <summary>
				/// Gets current value of property {@link #getDefaultTransitionNameBeginColumn defaultTransitionNameBeginColumn}.
				/// 
				/// Determines the type of the transition/animation to apply for the <code>Begin</code> column when <code>to()</code> is called without defining the transition to use. The default is <code>slide</code>, other options are <code>fade</code>, <code>flip</code>, <code>show</code>, and the names of any registered custom transitions.
				/// 
				/// Default value is <code>slide</code>.
				/// </summary>
				/// <returns>Value of property <code>defaultTransitionNameBeginColumn</code></returns>
				public extern virtual string getDefaultTransitionNameBeginColumn();

				/// <summary>
				/// Sets a new value for property {@link #getDefaultTransitionNameBeginColumn defaultTransitionNameBeginColumn}.
				/// 
				/// Determines the type of the transition/animation to apply for the <code>Begin</code> column when <code>to()</code> is called without defining the transition to use. The default is <code>slide</code>, other options are <code>fade</code>, <code>flip</code>, <code>show</code>, and the names of any registered custom transitions.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>slide</code>.
				/// </summary>
				/// <param name="sDefaultTransitionNameBeginColumn">New value for property <code>defaultTransitionNameBeginColumn</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout setDefaultTransitionNameBeginColumn(string sDefaultTransitionNameBeginColumn);

				#endregion

				#region Methods for Property defaultTransitionNameMidColumn

				/// <summary>
				/// Gets current value of property {@link #getDefaultTransitionNameMidColumn defaultTransitionNameMidColumn}.
				/// 
				/// Determines the type of the transition/animation to apply for the <code>Mid</code> column when <code>to()</code> is called without defining the transition to use. The default is <code>slide</code>, other options are <code>fade</code>, <code>flip</code>, <code>show</code>, and the names of any registered custom transitions.
				/// 
				/// Default value is <code>slide</code>.
				/// </summary>
				/// <returns>Value of property <code>defaultTransitionNameMidColumn</code></returns>
				public extern virtual string getDefaultTransitionNameMidColumn();

				/// <summary>
				/// Sets a new value for property {@link #getDefaultTransitionNameMidColumn defaultTransitionNameMidColumn}.
				/// 
				/// Determines the type of the transition/animation to apply for the <code>Mid</code> column when <code>to()</code> is called without defining the transition to use. The default is <code>slide</code>, other options are <code>fade</code>, <code>flip</code>, <code>show</code>, and the names of any registered custom transitions.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>slide</code>.
				/// </summary>
				/// <param name="sDefaultTransitionNameMidColumn">New value for property <code>defaultTransitionNameMidColumn</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout setDefaultTransitionNameMidColumn(string sDefaultTransitionNameMidColumn);

				#endregion

				#region Methods for Property defaultTransitionNameEndColumn

				/// <summary>
				/// Gets current value of property {@link #getDefaultTransitionNameEndColumn defaultTransitionNameEndColumn}.
				/// 
				/// Determines the type of the transition/animation to apply for the <code>End</code> column when <code>to()</code> is called without defining the transition to use. The default is <code>slide</code>, other options are <code>fade</code>, <code>flip</code>, <code>show</code>, and the names of any registered custom transitions.
				/// 
				/// Default value is <code>slide</code>.
				/// </summary>
				/// <returns>Value of property <code>defaultTransitionNameEndColumn</code></returns>
				public extern virtual string getDefaultTransitionNameEndColumn();

				/// <summary>
				/// Sets a new value for property {@link #getDefaultTransitionNameEndColumn defaultTransitionNameEndColumn}.
				/// 
				/// Determines the type of the transition/animation to apply for the <code>End</code> column when <code>to()</code> is called without defining the transition to use. The default is <code>slide</code>, other options are <code>fade</code>, <code>flip</code>, <code>show</code>, and the names of any registered custom transitions.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>slide</code>.
				/// </summary>
				/// <param name="sDefaultTransitionNameEndColumn">New value for property <code>defaultTransitionNameEndColumn</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout setDefaultTransitionNameEndColumn(string sDefaultTransitionNameEndColumn);

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
				public extern virtual sap.f.FlexibleColumnLayout setBackgroundDesign(sap.m.BackgroundDesign sBackgroundDesign);

				#endregion

				#region Methods for Aggregation beginColumnPages

				/// <summary>
				/// Gets content of aggregation {@link #getBeginColumnPages beginColumnPages}.
				/// 
				/// The content entities between which the <code>FlexibleColumnLayout</code> navigates in the <code>Begin</code> column.
				/// 
				/// These should be any control with page semantics. These aggregated controls will receive navigation events like {@link sap.m.NavContainerChild#beforeShow beforeShow}, they are documented in the pseudo interface {@link sap.m.NavContainerChild sap.m.NavContainerChild}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getBeginColumnPages();

				/// <summary>
				/// Destroys all the beginColumnPages in the aggregation {@link #getBeginColumnPages beginColumnPages}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout destroyBeginColumnPages();

				/// <summary>
				/// Inserts a beginColumnPage into the aggregation {@link #getBeginColumnPages beginColumnPages}.
				/// </summary>
				/// <param name="oBeginColumnPage">The beginColumnPage to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the beginColumnPage should be inserted at; for a negative value of <code>iIndex</code>, the beginColumnPage is inserted at position 0; for a value greater than the current size of the aggregation, the beginColumnPage is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout insertBeginColumnPage(sap.ui.core.Control oBeginColumnPage, int iIndex);

				/// <summary>
				/// Adds some beginColumnPage to the aggregation {@link #getBeginColumnPages beginColumnPages}.
				/// </summary>
				/// <param name="oBeginColumnPage">The beginColumnPage to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout addBeginColumnPage(sap.ui.core.Control oBeginColumnPage);

				/// <summary>
				/// Removes a beginColumnPage from the aggregation {@link #getBeginColumnPages beginColumnPages}.
				/// </summary>
				/// <param name="vBeginColumnPage">The beginColumnPage to remove or its index or id</param>
				/// <returns>The removed beginColumnPage or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeBeginColumnPage(Union<int, string, sap.ui.core.Control> vBeginColumnPage);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getBeginColumnPages beginColumnPages}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oBeginColumnPage">The beginColumnPage whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfBeginColumnPage(sap.ui.core.Control oBeginColumnPage);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getBeginColumnPages beginColumnPages}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllBeginColumnPages();

				#endregion

				#region Methods for Aggregation midColumnPages

				/// <summary>
				/// Gets content of aggregation {@link #getMidColumnPages midColumnPages}.
				/// 
				/// The content entities between which the <code>FlexibleColumnLayout</code> navigates in the <code>Mid</code> column.
				/// 
				/// These should be any control with page semantics. These aggregated controls will receive navigation events like {@link sap.m.NavContainerChild#beforeShow beforeShow}, they are documented in the pseudo interface {@link sap.m.NavContainerChild sap.m.NavContainerChild}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getMidColumnPages();

				/// <summary>
				/// Destroys all the midColumnPages in the aggregation {@link #getMidColumnPages midColumnPages}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout destroyMidColumnPages();

				/// <summary>
				/// Inserts a midColumnPage into the aggregation {@link #getMidColumnPages midColumnPages}.
				/// </summary>
				/// <param name="oMidColumnPage">The midColumnPage to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the midColumnPage should be inserted at; for a negative value of <code>iIndex</code>, the midColumnPage is inserted at position 0; for a value greater than the current size of the aggregation, the midColumnPage is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout insertMidColumnPage(sap.ui.core.Control oMidColumnPage, int iIndex);

				/// <summary>
				/// Adds some midColumnPage to the aggregation {@link #getMidColumnPages midColumnPages}.
				/// </summary>
				/// <param name="oMidColumnPage">The midColumnPage to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout addMidColumnPage(sap.ui.core.Control oMidColumnPage);

				/// <summary>
				/// Removes a midColumnPage from the aggregation {@link #getMidColumnPages midColumnPages}.
				/// </summary>
				/// <param name="vMidColumnPage">The midColumnPage to remove or its index or id</param>
				/// <returns>The removed midColumnPage or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeMidColumnPage(Union<int, string, sap.ui.core.Control> vMidColumnPage);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getMidColumnPages midColumnPages}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oMidColumnPage">The midColumnPage whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfMidColumnPage(sap.ui.core.Control oMidColumnPage);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getMidColumnPages midColumnPages}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllMidColumnPages();

				#endregion

				#region Methods for Aggregation endColumnPages

				/// <summary>
				/// Gets content of aggregation {@link #getEndColumnPages endColumnPages}.
				/// 
				/// The content entities between which the <code>FlexibleColumnLayout</code> navigates in the <code>End</code> column.
				/// 
				/// These should be any control with page semantics. These aggregated controls will receive navigation events like {@link sap.m.NavContainerChild#beforeShow beforeShow}, they are documented in the pseudo interface {@link sap.m.NavContainerChild sap.m.NavContainerChild}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getEndColumnPages();

				/// <summary>
				/// Destroys all the endColumnPages in the aggregation {@link #getEndColumnPages endColumnPages}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout destroyEndColumnPages();

				/// <summary>
				/// Inserts a endColumnPage into the aggregation {@link #getEndColumnPages endColumnPages}.
				/// </summary>
				/// <param name="oEndColumnPage">The endColumnPage to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the endColumnPage should be inserted at; for a negative value of <code>iIndex</code>, the endColumnPage is inserted at position 0; for a value greater than the current size of the aggregation, the endColumnPage is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout insertEndColumnPage(sap.ui.core.Control oEndColumnPage, int iIndex);

				/// <summary>
				/// Adds some endColumnPage to the aggregation {@link #getEndColumnPages endColumnPages}.
				/// </summary>
				/// <param name="oEndColumnPage">The endColumnPage to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout addEndColumnPage(sap.ui.core.Control oEndColumnPage);

				/// <summary>
				/// Removes a endColumnPage from the aggregation {@link #getEndColumnPages endColumnPages}.
				/// </summary>
				/// <param name="vEndColumnPage">The endColumnPage to remove or its index or id</param>
				/// <returns>The removed endColumnPage or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeEndColumnPage(Union<int, string, sap.ui.core.Control> vEndColumnPage);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getEndColumnPages endColumnPages}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oEndColumnPage">The endColumnPage whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfEndColumnPage(sap.ui.core.Control oEndColumnPage);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getEndColumnPages endColumnPages}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllEndColumnPages();

				#endregion

				#region Methods for Aggregation _beginColumnNav

				#endregion

				#region Methods for Aggregation _midColumnNav

				#endregion

				#region Methods for Aggregation _endColumnNav

				#endregion

				#region Methods for Aggregation _beginColumnBackArrow

				#endregion

				#region Methods for Aggregation _midColumnForwardArrow

				#endregion

				#region Methods for Aggregation _midColumnBackArrow

				#endregion

				#region Methods for Aggregation _endColumnForwardArrow

				#endregion

				#region Methods for Association initialBeginColumnPage

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getInitialBeginColumnPage initialBeginColumnPage}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getInitialBeginColumnPage();

				/// <summary>
				/// Sets the associated {@link #getInitialBeginColumnPage initialBeginColumnPage}.
				/// </summary>
				/// <param name="oInitialBeginColumnPage">ID of an element which becomes the new target of this initialBeginColumnPage association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout setInitialBeginColumnPage(Union<sap.ui.core.ID, sap.ui.core.Control> oInitialBeginColumnPage);

				#endregion

				#region Methods for Association initialMidColumnPage

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getInitialMidColumnPage initialMidColumnPage}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getInitialMidColumnPage();

				/// <summary>
				/// Sets the associated {@link #getInitialMidColumnPage initialMidColumnPage}.
				/// </summary>
				/// <param name="oInitialMidColumnPage">ID of an element which becomes the new target of this initialMidColumnPage association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout setInitialMidColumnPage(Union<sap.ui.core.ID, sap.ui.core.Control> oInitialMidColumnPage);

				#endregion

				#region Methods for Association initialEndColumnPage

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getInitialEndColumnPage initialEndColumnPage}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getInitialEndColumnPage();

				/// <summary>
				/// Sets the associated {@link #getInitialEndColumnPage initialEndColumnPage}.
				/// </summary>
				/// <param name="oInitialEndColumnPage">ID of an element which becomes the new target of this initialEndColumnPage association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout setInitialEndColumnPage(Union<sap.ui.core.ID, sap.ui.core.Control> oInitialEndColumnPage);

				#endregion

				#region Methods for Event stateChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stateChange stateChange} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fired when there is a change in the <code>layout</code> property or in the maximum number of columns that can be displayed at once. <br/></br> <ul>The interactions that may lead to a state change are: <li>the property <code>layout</code> was changed indirectly by the user clicking a layout arrow</li> <li>the user resized the browser beyond a breakpoint, thus changing the maximum number of columns that can be displayed at once.</li></ul> <br/><br/> <b>Note: </b>The event is suppressed while the control has zero width and will be fired the first time it gets a non-zero width
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachStateChange(object oData, sap.f.FlexibleColumnLayout.StateChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stateChange stateChange} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fired when there is a change in the <code>layout</code> property or in the maximum number of columns that can be displayed at once. <br/></br> <ul>The interactions that may lead to a state change are: <li>the property <code>layout</code> was changed indirectly by the user clicking a layout arrow</li> <li>the user resized the browser beyond a breakpoint, thus changing the maximum number of columns that can be displayed at once.</li></ul> <br/><br/> <b>Note: </b>The event is suppressed while the control has zero width and will be fired the first time it gets a non-zero width
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachStateChange(object oData, sap.f.FlexibleColumnLayout.StateChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stateChange stateChange} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fired when there is a change in the <code>layout</code> property or in the maximum number of columns that can be displayed at once. <br/></br> <ul>The interactions that may lead to a state change are: <li>the property <code>layout</code> was changed indirectly by the user clicking a layout arrow</li> <li>the user resized the browser beyond a breakpoint, thus changing the maximum number of columns that can be displayed at once.</li></ul> <br/><br/> <b>Note: </b>The event is suppressed while the control has zero width and will be fired the first time it gets a non-zero width
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachStateChange(sap.f.FlexibleColumnLayout.StateChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stateChange stateChange} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fired when there is a change in the <code>layout</code> property or in the maximum number of columns that can be displayed at once. <br/></br> <ul>The interactions that may lead to a state change are: <li>the property <code>layout</code> was changed indirectly by the user clicking a layout arrow</li> <li>the user resized the browser beyond a breakpoint, thus changing the maximum number of columns that can be displayed at once.</li></ul> <br/><br/> <b>Note: </b>The event is suppressed while the control has zero width and will be fired the first time it gets a non-zero width
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachStateChange(sap.f.FlexibleColumnLayout.StateChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:stateChange stateChange} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout detachStateChange(sap.f.FlexibleColumnLayout.StateChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:stateChange stateChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout fireStateChange(sap.f.FlexibleColumnLayout.StateChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:stateChange stateChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout fireStateChange();

				#endregion

				#region Methods for Event beginColumnNavigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beginColumnNavigate beginColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Begin</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachBeginColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beginColumnNavigate beginColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Begin</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachBeginColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beginColumnNavigate beginColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Begin</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachBeginColumnNavigate(sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beginColumnNavigate beginColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Begin</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachBeginColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beginColumnNavigate beginColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout detachBeginColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beginColumnNavigate beginColumnNavigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireBeginColumnNavigate(sap.m.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beginColumnNavigate beginColumnNavigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireBeginColumnNavigate();

				#endregion

				#region Methods for Event afterBeginColumnNavigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterBeginColumnNavigate afterBeginColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Begin</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterBeginColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterBeginColumnNavigate afterBeginColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Begin</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterBeginColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterBeginColumnNavigate afterBeginColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Begin</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterBeginColumnNavigate(sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterBeginColumnNavigate afterBeginColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Begin</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterBeginColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterBeginColumnNavigate afterBeginColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout detachAfterBeginColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterBeginColumnNavigate afterBeginColumnNavigate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout fireAfterBeginColumnNavigate(sap.m.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterBeginColumnNavigate afterBeginColumnNavigate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout fireAfterBeginColumnNavigate();

				#endregion

				#region Methods for Event midColumnNavigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:midColumnNavigate midColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Mid</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachMidColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:midColumnNavigate midColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Mid</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachMidColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:midColumnNavigate midColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Mid</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachMidColumnNavigate(sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:midColumnNavigate midColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Mid</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachMidColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:midColumnNavigate midColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout detachMidColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:midColumnNavigate midColumnNavigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireMidColumnNavigate(sap.m.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:midColumnNavigate midColumnNavigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireMidColumnNavigate();

				#endregion

				#region Methods for Event afterMidColumnNavigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMidColumnNavigate afterMidColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Mid</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterMidColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMidColumnNavigate afterMidColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Mid</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterMidColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMidColumnNavigate afterMidColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Mid</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterMidColumnNavigate(sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterMidColumnNavigate afterMidColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>Mid</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterMidColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterMidColumnNavigate afterMidColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout detachAfterMidColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterMidColumnNavigate afterMidColumnNavigate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout fireAfterMidColumnNavigate(sap.m.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterMidColumnNavigate afterMidColumnNavigate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout fireAfterMidColumnNavigate();

				#endregion

				#region Methods for Event endColumnNavigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:endColumnNavigate endColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>End</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachEndColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:endColumnNavigate endColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>End</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachEndColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:endColumnNavigate endColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>End</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachEndColumnNavigate(sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:endColumnNavigate endColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>End</code> column has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachEndColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:endColumnNavigate endColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout detachEndColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:endColumnNavigate endColumnNavigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireEndColumnNavigate(sap.m.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:endColumnNavigate endColumnNavigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireEndColumnNavigate();

				#endregion

				#region Methods for Event afterEndColumnNavigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterEndColumnNavigate afterEndColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>End</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterEndColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterEndColumnNavigate afterEndColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>End</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterEndColumnNavigate(object oData, sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterEndColumnNavigate afterEndColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>End</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterEndColumnNavigate(sap.m.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterEndColumnNavigate afterEndColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.FlexibleColumnLayout</code> itself.
				/// 
				/// Fires when navigation between two pages in the <code>End</code> column has completed.
				/// 
				/// NOTE: In case of animated transitions this event is fired with some delay after the navigate event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.FlexibleColumnLayout</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout attachAfterEndColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterEndColumnNavigate afterEndColumnNavigate} event of this <code>sap.f.FlexibleColumnLayout</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout detachAfterEndColumnNavigate(sap.m.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterEndColumnNavigate afterEndColumnNavigate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout fireAfterEndColumnNavigate(sap.m.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterEndColumnNavigate afterEndColumnNavigate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.FlexibleColumnLayout fireAfterEndColumnNavigate();

				#endregion

				#region Other methods

				/// <summary>
				/// Navigates back to a page in the <code>FlexibleColumnLayout</code>. Columns are scanned for the page in the following order: <code>Begin</code>, <code>Mid</code>, <code>End</code>.
				/// 
				/// Calling this navigation method, first triggers the (cancelable) navigate event on the SplitContainer, then the beforeHide pseudo event on the source page, beforeFirstShow (if applicable), and beforeShow on the target page. Later, after the transition has completed, the afterShow pseudo event is triggered on the target page and afterHide - on the page, which has been left. The given backData object is available in the beforeFirstShow, beforeShow, and afterShow event objects as data property. The original "data" object from the "to" navigation is also available in these event objects.
				/// </summary>
				/// <param name="sPageId">The screen to which is being navigated to. The ID or the control itself can be given.</param>
				/// <param name="oBackData">This optional object can carry any payload data which should be made available to the target page of the back navigation. The event on the target page will contain this data object as backData property. (the original data from the to() navigation will still be available as data property).
				/// 
				/// In scenarios, where the entity triggering the navigation can't or shouldn't directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data. For back navigation this can be used, for example, when returning from a detail page to transfer any settings done there.
				/// 
				/// When the transitionParameters object is used, this data object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameters">This optional object can give additional information to the transition function, like the DOM element, which triggered the transition or the desired transition duration. The animation type can NOT be selected here - it is always the inverse of the "to" navigation.
				/// 
				/// In order to use the transitionParameters property, the data property must be used (at least "null" must be given) for a proper parameter order.
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition.</param>
				/// <returns>The <code>sap.f.FlexibleColumnLayout</code> instance</returns>
				public extern virtual sap.f.FlexibleColumnLayout backToPage(string sPageId, object oBackData, object oTransitionParameters);

				/// <summary>
				/// Navigates back to the initial/top level of Begin column (this is the element aggregated as "initialPage", or the first added element). NOTE: If already on the initial page, nothing happens. The transition effect which had been used to get to the current page is inverted and used for this navigation.
				/// </summary>
				/// <param name="oBackData">This optional object can carry any payload data which should be made available to the target page of the back navigation. The event on the target page will contain this data object as "backData" property. (The original data from the "to()" navigation will still be available as "data" property.)
				/// 
				/// In scenarios where the entity triggering the navigation can or should not directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data. For back navigation this can be used e.g. when returning from a detail page to transfer any settings done there.
				/// 
				/// When the "transitionParameters" object is used, this "data" object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameters">This optional object can give additional information to the transition function, like the DOM element which triggered the transition or the desired transition duration. The animation type can NOT be selected here - it is always the inverse of the "to" navigation.
				/// 
				/// In order to use the transitionParameters property, the data property must be used (at least "null" must be given) for a proper parameter order.
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition.</param>
				/// <returns>The <code>sap.f.FlexibleColumnLayout</code> instance</returns>
				public extern virtual sap.f.FlexibleColumnLayout backToTopBeginColumn(object oBackData, object oTransitionParameters);

				/// <summary>
				/// Navigates back to the initial/top level of End column (this is the element aggregated as "initialPage", or the first added element). NOTE: If already on the initial page, nothing happens. The transition effect which had been used to get to the current page is inverted and used for this navigation.
				/// </summary>
				/// <param name="oBackData">This optional object can carry any payload data which should be made available to the target page of the back navigation. The event on the target page will contain this data object as "backData" property. (The original data from the "to()" navigation will still be available as "data" property.)
				/// 
				/// In scenarios where the entity triggering the navigation can or should not directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data. For back navigation this can be used e.g. when returning from a detail page to transfer any settings done there.
				/// 
				/// When the "transitionParameters" object is used, this "data" object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameters">This optional object can give additional information to the transition function, like the DOM element which triggered the transition or the desired transition duration. The animation type can NOT be selected here - it is always the inverse of the "to" navigation.
				/// 
				/// In order to use the transitionParameters property, the data property must be used (at least "null" must be given) for a proper parameter order.
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition.</param>
				/// <returns>The <code>sap.f.FlexibleColumnLayout</code> instance</returns>
				public extern virtual sap.f.FlexibleColumnLayout backToTopEndColumn(object oBackData, object oTransitionParameters);

				/// <summary>
				/// Navigates back to the initial/top level of Mid column (this is the element aggregated as "initialPage", or the first added element). NOTE: If already on the initial page, nothing happens. The transition effect which had been used to get to the current page is inverted and used for this navigation.
				/// </summary>
				/// <param name="oBackData">This optional object can carry any payload data which should be made available to the target page of the back navigation. The event on the target page will contain this data object as "backData" property. (The original data from the "to()" navigation will still be available as "data" property.)
				/// 
				/// In scenarios where the entity triggering the navigation can or should not directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data. For back navigation this can be used e.g. when returning from a detail page to transfer any settings done there.
				/// 
				/// When the "transitionParameters" object is used, this "data" object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameters">This optional object can give additional information to the transition function, like the DOM element which triggered the transition or the desired transition duration. The animation type can NOT be selected here - it is always the inverse of the "to" navigation.
				/// 
				/// In order to use the transitionParameters property, the data property must be used (at least "null" must be given) for a proper parameter order.
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition.</param>
				/// <returns>The <code>sap.f.FlexibleColumnLayout</code> instance</returns>
				public extern virtual sap.f.FlexibleColumnLayout backToTopMidColumn(object oBackData, object oTransitionParameters);

				/// <summary>
				/// Creates a new subclass of class sap.f.FlexibleColumnLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.f.FlexibleColumnLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.f.FlexibleColumnLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns the currently displayed Begin column page.
				/// </summary>
				/// <returns>The UI5 control in the Begin column</returns>
				public extern virtual sap.ui.core.Control getCurrentBeginColumnPage();

				/// <summary>
				/// Returns the currently displayed End column page.
				/// </summary>
				/// <returns>The UI5 control in the End column</returns>
				public extern virtual sap.ui.core.Control getCurrentEndColumnPage();

				/// <summary>
				/// Returns the currently displayed Mid column page.
				/// </summary>
				/// <returns>The UI5 control in the Mid column</returns>
				public extern virtual sap.ui.core.Control getCurrentMidColumnPage();

				/// <summary>
				/// Returns the maximum number of columns that can be displayed at once based on the control width
				/// </summary>
				/// <returns>The maximum number of columns</returns>
				public extern virtual int getMaxColumnsCount();

				/// <summary>
				/// Returns a metadata object for class sap.f.FlexibleColumnLayout.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Navigates to the given page inside the FlexibleColumnLayout. Columns are scanned for the page in the following order: <code>Begin</code>, <code>Mid</code>, <code>End</code>.
				/// </summary>
				/// <param name="sPageId">The screen to which we are navigating to. The ID or the control itself can be given.</param>
				/// <param name="sTransitionName">The type of the transition/animation to apply. This parameter can be omitted; then the default value is "slide" (horizontal movement from the right). Other options are: "fade", "flip", and "show" and the names of any registered custom transitions.
				/// 
				/// None of the standard transitions is currently making use of any given transition parameters.</param>
				/// <param name="oData">This optional object can carry any payload data which should be made available to the target page. The beforeShow event on the target page will contain this data object as data property.
				/// 
				/// Use case: in scenarios where the entity triggering the navigation can or should not directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data.
				/// 
				/// When the transitionParameters object is used, this "data" object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameters">This optional object can contain additional information for the transition function, like the DOM element which triggered the transition or the desired transition duration.
				/// 
				/// For a proper parameter order, the "data" parameter must be given when the transitionParameters parameter is used (it can be given as "null").
				/// 
				/// NOTE: It depends on the transition function how the object should be structured and which parameters are actually used to influence the transition. The "show", "slide" and "fade" transitions do not use any parameter.</param>
				/// <returns>The <code>sap.f.FlexibleColumnLayout</code> instance</returns>
				public extern virtual sap.f.FlexibleColumnLayout to(string sPageId, string sTransitionName, object oData, object oTransitionParameters);

				/// <summary>
				/// Navigates to a given Begin column page.
				/// </summary>
				/// <param name="sPageId">The screen to which drilldown should happen. The ID or the control itself can be given.</param>
				/// <param name="sTransitionName">The type of the transition/animation to apply. This parameter can be omitted; then the default value is "slide" (horizontal movement from the right). Other options are: "fade", "flip", and "show" and the names of any registered custom transitions.
				/// 
				/// None of the standard transitions is currently making use of any given transition parameters.</param>
				/// <param name="oData">This optional object can carry any payload data which should be made available to the target page. The beforeShow event on the target page will contain this data object as data property.
				/// 
				/// Use case: in scenarios where the entity triggering the navigation can't or shouldn't directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data.
				/// 
				/// When the transitionParameters object is used, this data object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameters">This optional object can contain additional information for the transition function, like the DOM element, which triggered the transition or the desired transition duration.
				/// 
				/// For a proper parameter order, the data parameter must be given when the transitionParameters parameter is used (it can be given as "null").
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition. The "show", "slide" and "fade" transitions do not use any parameter.</param>
				/// <returns>The <code>sap.f.FlexibleColumnLayout</code> instance</returns>
				public extern virtual sap.f.FlexibleColumnLayout toBeginColumnPage(string sPageId, string sTransitionName, object oData, object oTransitionParameters);

				/// <summary>
				/// Navigates to a given End column page.
				/// </summary>
				/// <param name="sPageId">The screen to which drilldown should happen. The ID or the control itself can be given.</param>
				/// <param name="sTransitionName">The type of the transition/animation to apply. This parameter can be omitted; then the default value is "slide" (horizontal movement from the right). Other options are: "fade", "flip", and "show" and the names of any registered custom transitions.
				/// 
				/// None of the standard transitions is currently making use of any given transition parameters.</param>
				/// <param name="oData">This optional object can carry any payload data which should be made available to the target page. The beforeShow event on the target page will contain this data object as data property.
				/// 
				/// Use case: in scenarios where the entity triggering the navigation can't or shouldn't directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data.
				/// 
				/// When the transitionParameters object is used, this data object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameters">This optional object can contain additional information for the transition function, like the DOM element, which triggered the transition or the desired transition duration.
				/// 
				/// For a proper parameter order, the data parameter must be given when the transitionParameters parameter is used (it can be given as "null").
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition. The "show", "slide" and "fade" transitions do not use any parameter.</param>
				/// <returns>The <code>sap.f.FlexibleColumnLayout</code> instance</returns>
				public extern virtual sap.f.FlexibleColumnLayout toEndColumnPage(string sPageId, string sTransitionName, object oData, object oTransitionParameters);

				/// <summary>
				/// Navigates to a given Mid column page.
				/// </summary>
				/// <param name="sPageId">The screen to which drilldown should happen. The ID or the control itself can be given.</param>
				/// <param name="sTransitionName">The type of the transition/animation to apply. This parameter can be omitted; then the default value is "slide" (horizontal movement from the right). Other options are: "fade", "flip", and "show" and the names of any registered custom transitions.
				/// 
				/// None of the standard transitions is currently making use of any given transition parameters.</param>
				/// <param name="oData">This optional object can carry any payload data which should be made available to the target page. The beforeShow event on the target page will contain this data object as data property.
				/// 
				/// Use case: in scenarios where the entity triggering the navigation can't or shouldn't directly initialize the target page, it can fill this object and the target page itself (or a listener on it) can take over the initialization, using the given data.
				/// 
				/// When the transitionParameters object is used, this data object must also be given (either as object or as null) in order to have a proper parameter order.</param>
				/// <param name="oTransitionParameters">This optional object can contain additional information for the transition function, like the DOM element, which triggered the transition or the desired transition duration.
				/// 
				/// For a proper parameter order, the data parameter must be given when the transitionParameters parameter is used (it can be given as "null").
				/// 
				/// NOTE: it depends on the transition function how the object should be structured and which parameters are actually used to influence the transition. The "show", "slide" and "fade" transitions do not use any parameter.</param>
				/// <returns>The <code>sap.f.FlexibleColumnLayout</code> instance</returns>
				public extern virtual sap.f.FlexibleColumnLayout toMidColumnPage(string sPageId, string sTransitionName, object oData, object oTransitionParameters);

				#endregion

				#endregion

			}
		}
	}
}
