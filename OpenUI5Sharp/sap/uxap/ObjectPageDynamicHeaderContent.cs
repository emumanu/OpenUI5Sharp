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
			/// Header content for the dynamic header of the {@link sap.uxap.ObjectPageLayout}.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>ObjectPageDynamicHeaderContent</code> represents the movable part of the <code>ObjectPageLayout</code>'s dynamic header. It can contain any control and scrolls along with the content of the page until it disappears (collapsed header). When scrolled back to the top it becomes visible again (expanded header). It contains all the additional information of the object.
			/// 
			/// Documentation links: <ul> <li>{@link topic:d2ef0099542d44dc868719d908e576d0 Object Page Headers}</li> <li>{@link topic:6e340c119ddd4c778b315f65a0432420 Object Page Dynamic Header}</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageDynamicHeaderContent")]
			public partial class ObjectPageDynamicHeaderContent : sap.f.DynamicPageHeader, sap.uxap.IHeaderContent
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.f.DynamicPageHeader.Settings
				{
				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectPageDynamicHeaderContent</code>.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageDynamicHeaderContent(string sId, sap.uxap.ObjectPageDynamicHeaderContent.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectPageDynamicHeaderContent</code>.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectPageDynamicHeaderContent(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectPageDynamicHeaderContent</code>.
				/// </summary>
				public extern ObjectPageDynamicHeaderContent();

				/// <summary>
				/// Constructor for a new <code>ObjectPageDynamicHeaderContent</code>.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageDynamicHeaderContent(sap.uxap.ObjectPageDynamicHeaderContent.Settings mSettings);

				#endregion

				#region Methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageDynamicHeaderContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.DynamicPageHeader.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageDynamicHeaderContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.DynamicPageHeader.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageDynamicHeaderContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.DynamicPageHeader.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ObjectPageDynamicHeaderContent.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				#endregion

			}
		}
	}
}
