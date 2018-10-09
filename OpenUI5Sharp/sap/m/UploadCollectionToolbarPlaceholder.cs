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
			/// <summary>
			/// Used to create a customizable toolbar for the UploadCollection. A FileUploader instance is required in the toolbar and will be placed by the application.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.UploadCollectionToolbarPlaceholder")]
			public partial class UploadCollectionToolbarPlaceholder : sap.ui.core.Control
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Control.Settings
				{
				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new UploadCollectionToolbarPlaceholder.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.Control#constructor sap.ui.core.Control} can be used.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern UploadCollectionToolbarPlaceholder(string sId, sap.m.UploadCollectionToolbarPlaceholder.Settings mSettings);

				/// <summary>
				/// Constructor for a new UploadCollectionToolbarPlaceholder.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.Control#constructor sap.ui.core.Control} can be used.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern UploadCollectionToolbarPlaceholder(string sId);

				/// <summary>
				/// Constructor for a new UploadCollectionToolbarPlaceholder.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.Control#constructor sap.ui.core.Control} can be used.
				/// </summary>
				public extern UploadCollectionToolbarPlaceholder();

				/// <summary>
				/// Constructor for a new UploadCollectionToolbarPlaceholder.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.Control#constructor sap.ui.core.Control} can be used.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern UploadCollectionToolbarPlaceholder(sap.m.UploadCollectionToolbarPlaceholder.Settings mSettings);

				#endregion

				#region Methods

				/// <summary>
				/// Creates a new subclass of class sap.m.UploadCollectionToolbarPlaceholder with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.UploadCollectionToolbarPlaceholder with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.UploadCollectionToolbarPlaceholder with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.UploadCollectionToolbarPlaceholder.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

			}
		}
	}
}
