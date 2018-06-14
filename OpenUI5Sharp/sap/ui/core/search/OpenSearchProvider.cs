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
					/// A SearchProvider which uses the OpenSearch protocol (either JSON or XML).
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class OpenSearchProvider : sap.ui.core.search.SearchProvider
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.search.SearchProvider.Settings
						{
							/// <summary>
							/// The URL for suggestions of the search provider. As placeholder for the concrete search queries '{searchTerms}' must be used. For cross domain requests maybe a proxy must be used.
							/// </summary>
							public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> suggestUrl;

							/// <summary>
							/// The type of data which is provided by the given suggestUrl: either 'json' or 'xml'.
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> suggestType;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new search/OpenSearchProvider.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern OpenSearchProvider(string sId, sap.ui.core.search.OpenSearchProvider.Settings mSettings);

						/// <summary>
						/// Constructor for a new search/OpenSearchProvider.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern OpenSearchProvider(string sId);

						/// <summary>
						/// Constructor for a new search/OpenSearchProvider.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern OpenSearchProvider();

						/// <summary>
						/// Constructor for a new search/OpenSearchProvider.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern OpenSearchProvider(sap.ui.core.search.OpenSearchProvider.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property suggestUrl

						/// <summary>
						/// Gets current value of property {@link #getSuggestUrl suggestUrl}.
						/// 
						/// The URL for suggestions of the search provider. As placeholder for the concrete search queries '{searchTerms}' must be used. For cross domain requests maybe a proxy must be used.
						/// </summary>
						/// <returns>Value of property <code>suggestUrl</code></returns>
						public extern virtual sap.ui.core.URI getSuggestUrl();

						/// <summary>
						/// Sets a new value for property {@link #getSuggestUrl suggestUrl}.
						/// 
						/// The URL for suggestions of the search provider. As placeholder for the concrete search queries '{searchTerms}' must be used. For cross domain requests maybe a proxy must be used.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sSuggestUrl">New value for property <code>suggestUrl</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.search.OpenSearchProvider setSuggestUrl(sap.ui.core.URI sSuggestUrl);

						#endregion

						#region Methods for Property suggestType

						/// <summary>
						/// Gets current value of property {@link #getSuggestType suggestType}.
						/// 
						/// The type of data which is provided by the given suggestUrl: either 'json' or 'xml'.
						/// 
						/// Default value is <code>json</code>.
						/// </summary>
						/// <returns>Value of property <code>suggestType</code></returns>
						public extern virtual string getSuggestType();

						/// <summary>
						/// Sets a new value for property {@link #getSuggestType suggestType}.
						/// 
						/// The type of data which is provided by the given suggestUrl: either 'json' or 'xml'.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>json</code>.
						/// </summary>
						/// <param name="sSuggestType">New value for property <code>suggestType</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.search.OpenSearchProvider setSuggestType(string sSuggestType);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.search.OpenSearchProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.search.SearchProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.search.OpenSearchProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.search.SearchProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.search.OpenSearchProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.search.SearchProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.search.OpenSearchProvider.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Call this function to get suggest values from the search provider. The given callback function is called with the suggest value (type 'string', 1st parameter) and an array of the suggestions (type '[string]', 2nd parameter).
						/// </summary>
						/// <param name="sValue">The value for which suggestions are requested.</param>
						/// <param name="fCallback">The callback function which is called when the suggestions are available.</param>
						public extern virtual void suggest(string sValue, object fCallback);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
