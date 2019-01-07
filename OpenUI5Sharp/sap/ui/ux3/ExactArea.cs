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
			public static partial class ux3
			{
				/// <summary>
				/// Consists of two sections: A tool bar and a content area where arbitrary controls can be added. The ExactArea is intended to be used for the Exact design approach but alternatively also in a stand alone version.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ExactArea")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class ExactArea : sap.ui.core.Control
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
						/// Specifies whether the tool bar shall be visible
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> toolbarVisible;

						/// <summary>
						/// Arbitrary child controls of the content area
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Tool bar items which shall be shown in the tool bar.
						/// </summary>
						public Union<sap.ui.commons.ToolbarItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> toolbarItems;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ExactArea.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ExactArea(string sId, sap.ui.ux3.ExactArea.Settings mSettings);

					/// <summary>
					/// Constructor for a new ExactArea.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ExactArea(string sId);

					/// <summary>
					/// Constructor for a new ExactArea.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ExactArea();

					/// <summary>
					/// Constructor for a new ExactArea.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ExactArea(sap.ui.ux3.ExactArea.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property toolbarVisible

					/// <summary>
					/// Gets current value of property {@link #getToolbarVisible toolbarVisible}.
					/// 
					/// Specifies whether the tool bar shall be visible
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>toolbarVisible</code></returns>
					public extern virtual bool getToolbarVisible();

					/// <summary>
					/// Sets a new value for property {@link #getToolbarVisible toolbarVisible}.
					/// 
					/// Specifies whether the tool bar shall be visible
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bToolbarVisible">New value for property <code>toolbarVisible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactArea setToolbarVisible(bool bToolbarVisible);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// Arbitrary child controls of the content area
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactArea destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactArea insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactArea addContent(sap.ui.core.Control oContent);

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

					#region Methods for Aggregation toolbarItems

					/// <summary>
					/// Gets content of aggregation {@link #getToolbarItems toolbarItems}.
					/// 
					/// Tool bar items which shall be shown in the tool bar.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.ToolbarItem[] getToolbarItems();

					/// <summary>
					/// Destroys all the toolbarItems in the aggregation {@link #getToolbarItems toolbarItems}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactArea destroyToolbarItems();

					/// <summary>
					/// Inserts a toolbarItem into the aggregation {@link #getToolbarItems toolbarItems}.
					/// </summary>
					/// <param name="oToolbarItem">The toolbarItem to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the toolbarItem should be inserted at; for a negative value of <code>iIndex</code>, the toolbarItem is inserted at position 0; for a value greater than the current size of the aggregation, the toolbarItem is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactArea insertToolbarItem(sap.ui.commons.ToolbarItem oToolbarItem, int iIndex);

					/// <summary>
					/// Adds some toolbarItem to the aggregation {@link #getToolbarItems toolbarItems}.
					/// </summary>
					/// <param name="oToolbarItem">The toolbarItem to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactArea addToolbarItem(sap.ui.commons.ToolbarItem oToolbarItem);

					/// <summary>
					/// Removes a toolbarItem from the aggregation {@link #getToolbarItems toolbarItems}.
					/// </summary>
					/// <param name="vToolbarItem">The toolbarItem to remove or its index or id</param>
					/// <returns>The removed toolbarItem or <code>null</code></returns>
					public extern virtual sap.ui.commons.ToolbarItem removeToolbarItem(Union<int, string, sap.ui.commons.ToolbarItem> vToolbarItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.ToolbarItem</code> in the aggregation {@link #getToolbarItems toolbarItems}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oToolbarItem">The toolbarItem whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfToolbarItem(sap.ui.commons.ToolbarItem oToolbarItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getToolbarItems toolbarItems}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.ToolbarItem[] removeAllToolbarItems();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ExactArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ExactArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ExactArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.ExactArea.
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
