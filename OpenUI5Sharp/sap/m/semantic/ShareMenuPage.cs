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
				/// A ShareMenuPage is a {@link sap.m.semantic.SemanticPage} with support for "share" menu in the footer.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.m.semantic.ShareMenuPage")]
				public partial class ShareMenuPage : sap.m.semantic.SemanticPage
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.m.semantic.SemanticPage.Settings
					{
						/// <summary>
						/// Custom share menu buttons
						/// </summary>
						public Union<sap.m.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> customShareMenuContent;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ShareMenuPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ShareMenuPage(string sId, sap.m.semantic.ShareMenuPage.Settings mSettings);

					/// <summary>
					/// Constructor for a new ShareMenuPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ShareMenuPage(string sId);

					/// <summary>
					/// Constructor for a new ShareMenuPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ShareMenuPage();

					/// <summary>
					/// Constructor for a new ShareMenuPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ShareMenuPage(sap.m.semantic.ShareMenuPage.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Aggregation customShareMenuContent

					/// <summary>
					/// Gets content of aggregation {@link #getCustomShareMenuContent customShareMenuContent}.
					/// 
					/// Custom share menu buttons
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.Button[] getCustomShareMenuContent();

					/// <summary>
					/// Destroys all the customShareMenuContent in the aggregation {@link #getCustomShareMenuContent customShareMenuContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.ShareMenuPage destroyCustomShareMenuContent();

					/// <summary>
					/// Inserts a customShareMenuContent into the aggregation {@link #getCustomShareMenuContent customShareMenuContent}.
					/// </summary>
					/// <param name="oCustomShareMenuContent">The customShareMenuContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the customShareMenuContent should be inserted at; for a negative value of <code>iIndex</code>, the customShareMenuContent is inserted at position 0; for a value greater than the current size of the aggregation, the customShareMenuContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.ShareMenuPage insertCustomShareMenuContent(sap.m.Button oCustomShareMenuContent, int iIndex);

					/// <summary>
					/// Adds some customShareMenuContent to the aggregation {@link #getCustomShareMenuContent customShareMenuContent}.
					/// </summary>
					/// <param name="oCustomShareMenuContent">The customShareMenuContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.ShareMenuPage addCustomShareMenuContent(sap.m.Button oCustomShareMenuContent);

					/// <summary>
					/// Removes a customShareMenuContent from the aggregation {@link #getCustomShareMenuContent customShareMenuContent}.
					/// </summary>
					/// <param name="vCustomShareMenuContent">The customShareMenuContent to remove or its index or id</param>
					/// <returns>The removed customShareMenuContent or <code>null</code></returns>
					public extern virtual sap.m.Button removeCustomShareMenuContent(Union<int, string, sap.m.Button> vCustomShareMenuContent);

					/// <summary>
					/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getCustomShareMenuContent customShareMenuContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oCustomShareMenuContent">The customShareMenuContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfCustomShareMenuContent(sap.m.Button oCustomShareMenuContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getCustomShareMenuContent customShareMenuContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.m.Button[] removeAllCustomShareMenuContent();

					#endregion

					#region Methods for Aggregation _actionSheet

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.ShareMenuPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticPage.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.ShareMenuPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticPage.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.ShareMenuPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticPage.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.m.semantic.ShareMenuPage.
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
