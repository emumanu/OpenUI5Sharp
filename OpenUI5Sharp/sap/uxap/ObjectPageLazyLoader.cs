using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class uxap
		{
			/// <summary>
			/// A helper element that enables a "stashed-based" lazy loading approach for the content of the {@link sap.uxap.ObjectPageSubSection} control.
			/// 
			/// <code>ObjectPageLazyLoader</code> is intended to be used in a declarative way only (for example, in a view) with the <code>stashed</code> property set to <code>true</code>, and is recommended to be used only once per subsection as its sole content.
			/// 
			/// <code>ObjectPageLazyLoader</code> utilizes UI5's stashing mechanism and is a lightweight alternative to the native block-based Lazy Loading of the <code>ObjectPageLayout</code>. Wrapping the content of a subsection in an <code>ObjectPageLazyLoader</code> with <code>stashed=true</code> will make the content unstash automatically as the user scrolls.
			/// 
			/// <b>Note:</b> Subsections are required to have an ID when used with <code>ObjectPageLazyLoader</code>.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageLazyLoader")]
			public partial class ObjectPageLazyLoader : sap.ui.core.Element
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Element.Settings
				{
					/// <summary>
					/// Controls to be displayed after this element is unstashed
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectPageLazyLoader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageLazyLoader(string sId, sap.uxap.ObjectPageLazyLoader.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectPageLazyLoader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectPageLazyLoader(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectPageLazyLoader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectPageLazyLoader();

				/// <summary>
				/// Constructor for a new <code>ObjectPageLazyLoader</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageLazyLoader(sap.uxap.ObjectPageLazyLoader.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// Controls to be displayed after this element is unstashed
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLazyLoader destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLazyLoader insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageLazyLoader addContent(sap.ui.core.Control oContent);

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

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageLazyLoader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageLazyLoader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageLazyLoader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ObjectPageLazyLoader.
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
