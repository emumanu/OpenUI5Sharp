using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public abstract partial class jQuery
	{
		public static partial class sap
		{
			public static partial class util
			{
				/// <summary>
				/// Represents a collection of string properties (key/value pairs).
				/// 
				/// Each key and its corresponding value in the collection is a string, keys are case-sensitive.
				/// 
				/// Use {@link jQuery.sap.properties} to create an instance of <code>jQuery.sap.util.Properties</code>.
				/// 
				/// The {@link #getProperty} method can be used to retrieve a value from the collection, {@link #setProperty} to store or change a value for a key and {@link #getKeys} can be used to retrieve an array of all keys that are currently stored in the collection.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("jQuery.sap.util.Properties")]
				public partial interface Properties
				{
					#region Methods

					/// <summary>
					/// Creates and returns a clone of the property collection.
					/// </summary>
					/// <returns>A clone of the property collection</returns>
					jQuery.sap.util.Properties clone();

					/// <summary>
					/// Returns an array of all keys in the property collection.
					/// </summary>
					/// <returns>All keys in the property collection</returns>
					string[] getKeys();

					/// <summary>
					/// Returns the value for the given key or <code>null</code> if the collection has no value for the key.
					/// 
					/// Optionally, a default value can be given which will be returned if the collection does not contain a value for the key; only non-empty default values are supported.
					/// </summary>
					/// <param name="sKey">Key to return the value for</param>
					/// <param name="sDefaultValue">Optional, a default value that will be returned if the requested key is not in the collection</param>
					/// <returns>Value for the given key or the default value or <code>null</code> if no default value or a falsy default value was given</returns>
					string getProperty(string sKey, string sDefaultValue);

					/// <summary>
					/// Returns the value for the given key or <code>null</code> if the collection has no value for the key.
					/// 
					/// Optionally, a default value can be given which will be returned if the collection does not contain a value for the key; only non-empty default values are supported.
					/// </summary>
					/// <param name="sKey">Key to return the value for</param>
					/// <returns>Value for the given key or the default value or <code>null</code> if no default value or a falsy default value was given</returns>
					string getProperty(string sKey);

					/// <summary>
					/// Stores or changes the value for the given key in the collection.
					/// 
					/// If the given value is not a string, the collection won't be modified. The key is always cast to a string.
					/// </summary>
					/// <param name="sKey">Key of the property</param>
					/// <param name="sValue">String value for the key</param>
					void setProperty(string sKey, string sValue);

					#endregion

				}
			}
		}
	}
}
