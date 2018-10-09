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
			/// Represents the static part (header title) of the dynamic header of the {@link sap.uxap.ObjectPageLayout}.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>ObjectPageDynamicHeaderTitle</code> is used to represent the most important details of the displayed business object, such as the object title and actions that the user can perform.
			/// 
			/// <b>Note:</b> The <code>ObjectPageDynamicHeaderTitle</code> is meant to be used inside the <code>ObjectPageLayout</code> control. Any other usage is not supported and can lead to unexpected behavior.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageDynamicHeaderTitle")]
			public partial class ObjectPageDynamicHeaderTitle : sap.f.DynamicPageTitle, sap.uxap.IHeaderTitle
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.f.DynamicPageTitle.Settings
				{
				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectPageDynamicHeaderTitle</code>.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageDynamicHeaderTitle(string sId, sap.uxap.ObjectPageDynamicHeaderTitle.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectPageDynamicHeaderTitle</code>.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectPageDynamicHeaderTitle(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectPageDynamicHeaderTitle</code>.
				/// </summary>
				public extern ObjectPageDynamicHeaderTitle();

				/// <summary>
				/// Constructor for a new <code>ObjectPageDynamicHeaderTitle</code>.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageDynamicHeaderTitle(sap.uxap.ObjectPageDynamicHeaderTitle.Settings mSettings);

				#endregion

				#region Methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageDynamicHeaderTitle with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.DynamicPageTitle.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageDynamicHeaderTitle with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.DynamicPageTitle.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageDynamicHeaderTitle with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.DynamicPageTitle.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ObjectPageDynamicHeaderTitle.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

			}
		}
	}
}
