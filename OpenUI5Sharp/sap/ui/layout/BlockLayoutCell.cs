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
				/// The BlockLayoutCell is used as an aggregation of the BlockLayoutRow. It contains Controls. The BlockLayoutCell should be used only as aggregation of the BlockLayoutRow.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.layout.BlockLayoutCell")]
				public partial class BlockLayoutCell : sap.ui.core.Control
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
						/// Defines the title of the cell. <b>Note:</b> When the <code>titleLink</code> aggregation is provided, the title of the cell will be replaced with the text from the <code>titleLink</code>.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// Defines the alignment of the cell title
						/// </summary>
						public Union<sap.ui.core.HorizontalAlign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleAlignment;

						/// <summary>
						/// Defines the aria level of the title This information is e.g. used by assistive technologies like screenreaders to create a hierarchical site map for faster navigation.
						/// </summary>
						public Union<sap.ui.core.TitleLevel, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleLevel;

						/// <summary>
						/// Defines the width of the cell. Depending on the context of the cell - whether it's in scrollable, or non scrollable row, this property is interpreted in two different ways. If the cell is placed inside a scrollable row - this property defines the width of the cell in percentages. If no value is provided - the default is 40%. If the cell is placed inside a non scrollable row - this property defines the grow factor of the cell compared to the whole row. <b>For example:</b> If you have 2 cells, each with width of 1, this means that they should be of equal size, and they need to fill the whole row. This results in 50% width for each cell. If you have 2 cells, one with width of 1, the other with width of 3, this means that the whole row width is 4, so the first cell will have a width of 25%, the second - 75%. According to the visual guidelines, it is suggested that you only use 25%, 50%, 75% or 100% cells in you applications. For example, 12,5% width is not desirable (1 cell with width 1, and another with width 7)
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// The Background color set from which the background color will be selected. By using background colors from the predefined sets your colors could later be customized from the Theme Designer. <b>Note:</b> backgroundColorSet should be used only in combination with backgroundColorShade.
						/// </summary>
						public Union<sap.ui.layout.BlockLayoutCellColorSet, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundColorSet;

						/// <summary>
						/// The index of the background color in the color set from which the color will be selected. By using background colors from the predefined sets your colors could later be customized from the Theme Designer. <b>Note:</b> backgroundColorShade should be used only in combination with backgroundColorSet.
						/// </summary>
						public Union<sap.ui.layout.BlockLayoutCellColorShade, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundColorShade;

						/// <summary>
						/// The content to be included inside the cell
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// The link that will replace the title of the cell. <b>Note:</b> The only possible value is the <code>sap.m.Link</code> control.
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> titleLink;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new BlockLayoutCell.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern BlockLayoutCell(string sId, sap.ui.layout.BlockLayoutCell.Settings mSettings);

					/// <summary>
					/// Constructor for a new BlockLayoutCell.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern BlockLayoutCell(string sId);

					/// <summary>
					/// Constructor for a new BlockLayoutCell.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern BlockLayoutCell();

					/// <summary>
					/// Constructor for a new BlockLayoutCell.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern BlockLayoutCell(sap.ui.layout.BlockLayoutCell.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// Defines the title of the cell. <b>Note:</b> When the <code>titleLink</code> aggregation is provided, the title of the cell will be replaced with the text from the <code>titleLink</code>.
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// Defines the title of the cell. <b>Note:</b> When the <code>titleLink</code> aggregation is provided, the title of the cell will be replaced with the text from the <code>titleLink</code>.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell setTitle(string sTitle);

					#endregion

					#region Methods for Property titleAlignment

					/// <summary>
					/// Gets current value of property {@link #getTitleAlignment titleAlignment}.
					/// 
					/// Defines the alignment of the cell title
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <returns>Value of property <code>titleAlignment</code></returns>
					public extern virtual sap.ui.core.HorizontalAlign getTitleAlignment();

					/// <summary>
					/// Sets a new value for property {@link #getTitleAlignment titleAlignment}.
					/// 
					/// Defines the alignment of the cell title
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <param name="sTitleAlignment">New value for property <code>titleAlignment</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell setTitleAlignment(sap.ui.core.HorizontalAlign sTitleAlignment);

					#endregion

					#region Methods for Property titleLevel

					/// <summary>
					/// Gets current value of property {@link #getTitleLevel titleLevel}.
					/// 
					/// Defines the aria level of the title This information is e.g. used by assistive technologies like screenreaders to create a hierarchical site map for faster navigation.
					/// 
					/// Default value is <code>Auto</code>.
					/// </summary>
					/// <returns>Value of property <code>titleLevel</code></returns>
					public extern virtual sap.ui.core.TitleLevel getTitleLevel();

					/// <summary>
					/// Sets a new value for property {@link #getTitleLevel titleLevel}.
					/// 
					/// Defines the aria level of the title This information is e.g. used by assistive technologies like screenreaders to create a hierarchical site map for faster navigation.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Auto</code>.
					/// </summary>
					/// <param name="sTitleLevel">New value for property <code>titleLevel</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell setTitleLevel(sap.ui.core.TitleLevel sTitleLevel);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Defines the width of the cell. Depending on the context of the cell - whether it's in scrollable, or non scrollable row, this property is interpreted in two different ways. If the cell is placed inside a scrollable row - this property defines the width of the cell in percentages. If no value is provided - the default is 40%. If the cell is placed inside a non scrollable row - this property defines the grow factor of the cell compared to the whole row. <b>For example:</b> If you have 2 cells, each with width of 1, this means that they should be of equal size, and they need to fill the whole row. This results in 50% width for each cell. If you have 2 cells, one with width of 1, the other with width of 3, this means that the whole row width is 4, so the first cell will have a width of 25%, the second - 75%. According to the visual guidelines, it is suggested that you only use 25%, 50%, 75% or 100% cells in you applications. For example, 12,5% width is not desirable (1 cell with width 1, and another with width 7)
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual int getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Defines the width of the cell. Depending on the context of the cell - whether it's in scrollable, or non scrollable row, this property is interpreted in two different ways. If the cell is placed inside a scrollable row - this property defines the width of the cell in percentages. If no value is provided - the default is 40%. If the cell is placed inside a non scrollable row - this property defines the grow factor of the cell compared to the whole row. <b>For example:</b> If you have 2 cells, each with width of 1, this means that they should be of equal size, and they need to fill the whole row. This results in 50% width for each cell. If you have 2 cells, one with width of 1, the other with width of 3, this means that the whole row width is 4, so the first cell will have a width of 25%, the second - 75%. According to the visual guidelines, it is suggested that you only use 25%, 50%, 75% or 100% cells in you applications. For example, 12,5% width is not desirable (1 cell with width 1, and another with width 7)
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell setWidth(int iWidth);

					#endregion

					#region Methods for Property backgroundColorSet

					/// <summary>
					/// Gets current value of property {@link #getBackgroundColorSet backgroundColorSet}.
					/// 
					/// The Background color set from which the background color will be selected. By using background colors from the predefined sets your colors could later be customized from the Theme Designer. <b>Note:</b> backgroundColorSet should be used only in combination with backgroundColorShade.
					/// </summary>
					/// <returns>Value of property <code>backgroundColorSet</code></returns>
					public extern virtual sap.ui.layout.BlockLayoutCellColorSet getBackgroundColorSet();

					/// <summary>
					/// Sets a new value for property {@link #getBackgroundColorSet backgroundColorSet}.
					/// 
					/// The Background color set from which the background color will be selected. By using background colors from the predefined sets your colors could later be customized from the Theme Designer. <b>Note:</b> backgroundColorSet should be used only in combination with backgroundColorShade.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sBackgroundColorSet">New value for property <code>backgroundColorSet</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell setBackgroundColorSet(sap.ui.layout.BlockLayoutCellColorSet sBackgroundColorSet);

					#endregion

					#region Methods for Property backgroundColorShade

					/// <summary>
					/// Gets current value of property {@link #getBackgroundColorShade backgroundColorShade}.
					/// 
					/// The index of the background color in the color set from which the color will be selected. By using background colors from the predefined sets your colors could later be customized from the Theme Designer. <b>Note:</b> backgroundColorShade should be used only in combination with backgroundColorSet.
					/// </summary>
					/// <returns>Value of property <code>backgroundColorShade</code></returns>
					public extern virtual sap.ui.layout.BlockLayoutCellColorShade getBackgroundColorShade();

					/// <summary>
					/// Sets a new value for property {@link #getBackgroundColorShade backgroundColorShade}.
					/// 
					/// The index of the background color in the color set from which the color will be selected. By using background colors from the predefined sets your colors could later be customized from the Theme Designer. <b>Note:</b> backgroundColorShade should be used only in combination with backgroundColorSet.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sBackgroundColorShade">New value for property <code>backgroundColorShade</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell setBackgroundColorShade(sap.ui.layout.BlockLayoutCellColorShade sBackgroundColorShade);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// The content to be included inside the cell
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell addContent(sap.ui.core.Control oContent);

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

					#region Methods for Aggregation titleLink

					/// <summary>
					/// Gets content of aggregation {@link #getTitleLink titleLink}.
					/// 
					/// The link that will replace the title of the cell. <b>Note:</b> The only possible value is the <code>sap.m.Link</code> control.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control getTitleLink();

					/// <summary>
					/// Destroys the titleLink in the aggregation {@link #getTitleLink titleLink}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell destroyTitleLink();

					/// <summary>
					/// Sets the aggregated {@link #getTitleLink titleLink}.
					/// </summary>
					/// <param name="oTitleLink">The titleLink to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCell setTitleLink(sap.ui.core.Control oTitleLink);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayoutCell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayoutCell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayoutCell with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.BlockLayoutCell.
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
