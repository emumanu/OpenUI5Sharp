using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				public static partial class search
				{
					/// <summary>
					/// Abstract base class for all SearchProviders which can be e.g. attached to a SearchField. Do not create instances of this class, but use a concrete sub class instead.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class SearchProvider : sap.ui.core.Element
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
							/// Icon of the Search Provider
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> icon;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new search/SearchProvider.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern SearchProvider(string sId, sap.ui.core.search.SearchProvider.Settings mSettings);

						/// <summary>
						/// Constructor for a new search/SearchProvider.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern SearchProvider(string sId);

						/// <summary>
						/// Constructor for a new search/SearchProvider.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern SearchProvider();

						/// <summary>
						/// Constructor for a new search/SearchProvider.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern SearchProvider(sap.ui.core.search.SearchProvider.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property icon

						/// <summary>
						/// Gets current value of property {@link #getIcon icon}.
						/// 
						/// Icon of the Search Provider
						/// </summary>
						/// <returns>Value of property <code>icon</code></returns>
						public extern virtual string getIcon();

						/// <summary>
						/// Sets a new value for property {@link #getIcon icon}.
						/// 
						/// Icon of the Search Provider
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sIcon">New value for property <code>icon</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.search.SearchProvider setIcon(string sIcon);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.search.SearchProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.search.SearchProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.search.SearchProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.search.SearchProvider.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Call this function to get suggest values from the search provider. The given callback function is called with the suggest value (type 'string', 1st parameter) and an array of the suggestions (type '[string]', 2nd parameter).
						/// </summary>
						/// <param name="sValue">The value for which suggestions are requested.</param>
						/// <param name="fnCallback">The callback function which is called when the suggestions are available.</param>
						public extern virtual void suggest(string sValue, object fnCallback);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
