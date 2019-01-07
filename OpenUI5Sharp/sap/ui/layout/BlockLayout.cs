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
			public static partial class layout
			{
				/// <summary>
				/// The BlockLayout is used to display several objects in a section-based manner. <h3>Overview</h3> The BlockLayout uses horizontal and vertical subdivisions, and full-width banners to display a set of elements. By placing pictorial and textual elements side-by-side in different blocks, you can establish a visual connection between blocks and between similar elements. <h3>Structure</h3> The BlockLayout contains BlockLayout cells. Every cell consists of a title and content. The title can be text or a link.
				/// 
				/// The BlockLayout comes in five predefined types for background colors: <ul> <li>Layout only (default) - a layout scheme and no background colors</li> <li>Bright - a layout scheme with bright colors</li> <li>Accent - a layout scheme with four pre-defined color sets</li> <li>Dashboard - a layout scheme with additional borders and no background colors</li> <li>Mixed - a layout scheme with a mix of light and dark colors</li> </ul> Background colors are attached directly to the blocks of the layout.
				/// 
				/// Special full-width sections of the BlockLayout allow horizontal scrolling through a set of blocks.
				/// 
				/// <b>Note:</b> With version 1.48 colors can be set for each individual {@link sap.ui.layout.BlockLayoutCell cell}. There are 10 pre-defined color sets, each with 4 different shades. The main colors of the sets can be changed in Theme Designer. To change the background of a particular cell, set <code>backgroundColorSet</code> (main color) and <code>backgroundColorShade</code> (shade).
				/// 
				/// <b>Note:</b> Usage of disabled, emphasized or subtle links as titles is not recommended. Dark background designs, for example Accent, are not fully supported with regards to Аccessibility when used with links as titles.
				/// 
				/// <h3>Usage</h3> <h4>When to use</h4> <ul> <li>You want to create a catalogue-like page with sections of blocks.</li> <li>The BlockLayout is intended for developing administrative tools and applications.</li> </ul> <h4>When not to use</h4> <ul> <li>You want to display properties or features of one content item. Use a {@link sap.uxap.ObjectPageLayout object page} or {@link sap.f.DynamicPage dynamic page} instead.</li> </ul> <h3>Responsive Behavior</h3> <ul> <li>The breakpoints of the block layout react to the width of the control itself and not to the actual screen size.</li> <li> On small screens all blocks will wrap to a single scrollable column</li> </ul>
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.layout.BlockLayout")]
				public partial class BlockLayout : sap.ui.core.Control
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
						/// Determines the background used for the Layout
						/// </summary>
						public Union<sap.ui.layout.BlockBackgroundType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> background;

						/// <summary>
						/// Keeps the font-size of the contents as is, independent from the screen size.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> keepFontSize;

						/// <summary>
						/// The Rows to be included in the content of the control
						/// </summary>
						public Union<sap.ui.layout.BlockLayoutRow[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new BlockLayout.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern BlockLayout(string sId, sap.ui.layout.BlockLayout.Settings mSettings);

					/// <summary>
					/// Constructor for a new BlockLayout.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern BlockLayout(string sId);

					/// <summary>
					/// Constructor for a new BlockLayout.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern BlockLayout();

					/// <summary>
					/// Constructor for a new BlockLayout.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern BlockLayout(sap.ui.layout.BlockLayout.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property background

					/// <summary>
					/// Gets current value of property {@link #getBackground background}.
					/// 
					/// Determines the background used for the Layout
					/// 
					/// Default value is <code>Default</code>.
					/// </summary>
					/// <returns>Value of property <code>background</code></returns>
					public extern virtual sap.ui.layout.BlockBackgroundType getBackground();

					/// <summary>
					/// Changes background type
					/// </summary>
					/// <param name="sNewBackground">Background's style of type sap.ui.layout.BlockBackgroundType</param>
					/// <returns>BlockLayout instance. Allows method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayout setBackground(string sNewBackground);

					#endregion

					#region Methods for Property keepFontSize

					/// <summary>
					/// Gets current value of property {@link #getKeepFontSize keepFontSize}.
					/// 
					/// Keeps the font-size of the contents as is, independent from the screen size.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>keepFontSize</code></returns>
					public extern virtual bool getKeepFontSize();

					/// <summary>
					/// Sets a new value for property {@link #getKeepFontSize keepFontSize}.
					/// 
					/// Keeps the font-size of the contents as is, independent from the screen size.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bKeepFontSize">New value for property <code>keepFontSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayout setKeepFontSize(bool bKeepFontSize);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// The Rows to be included in the content of the control
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.layout.BlockLayoutRow[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayout destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayout insertContent(sap.ui.layout.BlockLayoutRow oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayout addContent(sap.ui.layout.BlockLayoutRow oContent);

					/// <summary>
					/// Removes a content from the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="vContent">The content to remove or its index or id</param>
					/// <returns>The removed content or <code>null</code></returns>
					public extern virtual sap.ui.layout.BlockLayoutRow removeContent(Union<int, string, sap.ui.layout.BlockLayoutRow> vContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.layout.BlockLayoutRow</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oContent">The content whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfContent(sap.ui.layout.BlockLayoutRow oContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getContent content}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.layout.BlockLayoutRow[] removeAllContent();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.BlockLayout.
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
}
