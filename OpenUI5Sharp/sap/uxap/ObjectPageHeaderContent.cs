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
			/// Header content for the classic header of the {@link sap.uxap.ObjectPageLayout}.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>ObjectPageHeaderContent</code> represents the movable part of the <code>ObjectPageLayout</code>'s classic header. It can contain any control and scrolls along with the content of the page until it disappears (collapsed header). When scrolled back to the top it becomes visible again (expanded header). It contains all the additional information of the object.
			/// 
			/// Documentation links: <ul> <li>{@link topic:d2ef0099542d44dc868719d908e576d0 Object Page Headers}</li> <li>{@link topic:0fecbce45e39406aa939bd25e89823f4 Object Page Classic Header}</li> <li>{@link https://experience.sap.com/fiori-design-web/object-page/ UX Guidelines: Object Page}</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageHeaderContent")]
			public partial class ObjectPageHeaderContent : sap.ui.core.Control, sap.uxap.IHeaderContent
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
					/// Determines the design of the header - Light or Dark. <b>Note: </b>This property is deprecated. It will continue to work in the Blue Crystal theme, but it will not be taken into account for the Belize themes.
					/// </summary>
					public Union<sap.uxap.ObjectPageHeaderDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentDesign;

					/// <summary>
					/// The list of Objects of type sap.ui.core.Control.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderContent</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageHeaderContent(string sId, sap.uxap.ObjectPageHeaderContent.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderContent</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectPageHeaderContent(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderContent</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectPageHeaderContent();

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderContent</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageHeaderContent(sap.uxap.ObjectPageHeaderContent.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property contentDesign

				/// <summary>
				/// Gets current value of property {@link #getContentDesign contentDesign}.
				/// 
				/// Determines the design of the header - Light or Dark. <b>Note: </b>This property is deprecated. It will continue to work in the Blue Crystal theme, but it will not be taken into account for the Belize themes.
				/// 
				/// Default value is <code>Light</code>.
				/// </summary>
				/// <returns>Value of property <code>contentDesign</code></returns>
				[Obsolete("Deprecated since 1.40.1.")]
				public extern virtual sap.uxap.ObjectPageHeaderDesign getContentDesign();

				/// <summary>
				/// Sets a new value for property {@link #getContentDesign contentDesign}.
				/// 
				/// Determines the design of the header - Light or Dark. <b>Note: </b>This property is deprecated. It will continue to work in the Blue Crystal theme, but it will not be taken into account for the Belize themes.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Light</code>.
				/// </summary>
				/// <param name="sContentDesign">New value for property <code>contentDesign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.40.1.")]
				public extern virtual sap.uxap.ObjectPageHeaderContent setContentDesign(sap.uxap.ObjectPageHeaderDesign sContentDesign);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// The list of Objects of type sap.ui.core.Control.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderContent destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderContent insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderContent addContent(sap.ui.core.Control oContent);

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

				#region Methods for Aggregation _editHeaderButton

				#endregion

				#region Methods for Aggregation _objectImage

				#endregion

				#region Methods for Aggregation _placeholder

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeaderContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeaderContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeaderContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ObjectPageHeaderContent.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
