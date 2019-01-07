using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class @base
		{
			public static partial class util
			{
				/// <summary>
				/// Represents a collection of string properties (key/value pairs).
				/// 
				/// Each key and its corresponding value in the collection is a string, keys are case-sensitive.
				/// 
				/// Use {@link module:sap/base/util/Properties.create} to create an instance of {@link module:sap/base/util/Properties}.
				/// 
				/// The {@link #getProperty} method can be used to retrieve a value from the collection, {@link #setProperty} to store or change a value for a key and {@link #getKeys} can be used to retrieve an array of all keys that are currently stored in the collection.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.base.util.Properties")]
				public partial class Properties
				{
					#region Methods

					/// <summary>
					/// Creates and returns a clone of the property collection.
					/// </summary>
					/// <returns>A clone of the property collection</returns>
					public extern virtual sap.@base.util.Properties clone();

					/// <summary>
					/// Creates and returns a new instance of {@link sap.base.util.Properties}.
					/// 
					/// If option 'url' is passed, immediately a load request for the given target is triggered. A property file that is loaded can contain comments with a leading ! or #. The loaded property list does not contain any comments.
					/// </summary>
					/// <param name="mParams">Parameters used to initialize the property list</param>
					/// <returns>A new property collection (synchronous case) or <code>null</code> if the file could not be loaded and <code>returnNullIfMissing</code> was set; in case of asynchronous loading, always a Promise is returned, which resolves with the property collection or with <code>null</code> if the file could not be loaded and <code>returnNullIfMissing</code> was set to true</returns>
					public extern static Union<sap.@base.util.Properties, es5.Promise<object>> create(jQuery.Info mParams);

					/// <summary>
					/// Creates and returns a new instance of {@link sap.base.util.Properties}.
					/// 
					/// If option 'url' is passed, immediately a load request for the given target is triggered. A property file that is loaded can contain comments with a leading ! or #. The loaded property list does not contain any comments.
					/// </summary>
					/// <returns>A new property collection (synchronous case) or <code>null</code> if the file could not be loaded and <code>returnNullIfMissing</code> was set; in case of asynchronous loading, always a Promise is returned, which resolves with the property collection or with <code>null</code> if the file could not be loaded and <code>returnNullIfMissing</code> was set to true</returns>
					public extern static Union<sap.@base.util.Properties, es5.Promise<object>> create();

					/// <summary>
					/// Returns an array of all keys in the property collection.
					/// </summary>
					/// <returns>All keys in the property collection</returns>
					public extern virtual string[] getKeys();

					/// <summary>
					/// Returns the value for the given key or <code>null</code> if the collection has no value for the key.
					/// 
					/// Optionally, a default value can be given which will be returned if the collection does not contain a value for the key; only non-empty default values are supported.
					/// </summary>
					/// <param name="sKey">Key to return the value for</param>
					/// <param name="sDefaultValue">Optional, a default value that will be returned if the requested key is not in the collection</param>
					/// <returns>Value for the given key or the default value or <code>null</code> if no default value or a falsy default value was given</returns>
					public extern virtual string getProperty(string sKey, string sDefaultValue);

					/// <summary>
					/// Returns the value for the given key or <code>null</code> if the collection has no value for the key.
					/// 
					/// Optionally, a default value can be given which will be returned if the collection does not contain a value for the key; only non-empty default values are supported.
					/// </summary>
					/// <param name="sKey">Key to return the value for</param>
					/// <returns>Value for the given key or the default value or <code>null</code> if no default value or a falsy default value was given</returns>
					public extern virtual string getProperty(string sKey);

					/// <summary>
					/// Stores or changes the value for the given key in the collection.
					/// 
					/// If the given value is not a string, the collection won't be modified. The key is always cast to a string.
					/// </summary>
					/// <param name="sKey">Key of the property</param>
					/// <param name="sValue">String value for the key</param>
					public extern virtual void setProperty(string sKey, string sValue);

					#endregion

				}
			}
		}
	}
}
