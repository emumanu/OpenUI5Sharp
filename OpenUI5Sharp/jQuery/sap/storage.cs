using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class jQuery
	{
		public static partial class sap
		{
			/// <summary>
			/// Returns a {@link jQuery.sap.storage.Storage Storage} object for a given HTML5 storage (type) and, as a convenience, provides static functions to access the default (session) storage.
			/// 
			/// When called as a function, it returns an instance of {@link jQuery.sap.storage.Storage}, providing access to the storage of the given {@link jQuery.sap.storage.Type} or to the given HTML5 Storage object.
			/// 
			/// The default session storage can be easily accessed with methods {@link jQuery.sap.storage.get}, {@link jQuery.sap.storage.put}, {@link jQuery.sap.storage.remove}, {@link jQuery.sap.storage.clear}, {@link jQuery.sap.storage.getType} and {@link jQuery.sap.storage.removeAll}
			/// </summary>
			[External]
			[Namespace(false)]
			public static partial class storage
			{
				#region Methods

				/// <summary>
				/// Deletes all the entries saved in the session (Independent of the current Storage instance!).
				/// 
				/// CAUTION: This method should be called only in very particular situations, when a global erasing of data is required. Given that the method deletes the data saved under any ID, it should not be called when managing data for specific controls.
				/// </summary>
				/// <returns>true if execution of removal was successful or the data to remove doesn't exist, and false if the feature is unavailable or a problem occurred</returns>
				public extern static bool clear();

				/// <summary>
				/// Retrieves the state string stored in the session under the key sStorageKeyPrefix + sId.
				/// 
				/// sStorageKeyPrefix is the id prefix defined for the storage instance (@see jQuery.sap#storage)
				/// </summary>
				/// <param name="sId">Id for the state to retrieve</param>
				/// <returns>the string from the storage, if the retrieval was successful, and null otherwise</returns>
				public extern static string get(string sId);

				/// <summary>
				/// Returns the type of the storage.
				/// </summary>
				/// <returns>the type of the storage or "unknown"</returns>
				public extern static Union<jQuery.sap.storage.Type, string> getType();

				/// <summary>
				/// Returns whether the given storage is suppported.
				/// </summary>
				/// <returns>true if storage is supported, false otherwise (e.g. due to browser security settings)</returns>
				public extern static bool isSupported();

				/// <summary>
				/// Stores the passed state string in the session, under the key sStorageKeyPrefix + sId.
				/// 
				/// sStorageKeyPrefix is the id prefix defined for the storage instance (@see jQuery.sap#storage)
				/// </summary>
				/// <param name="sId">Id for the state to store</param>
				/// <param name="sStateToStore">content to store</param>
				/// <returns>true if the data were successfully stored, false otherwise</returns>
				public extern static bool put(string sId, string sStateToStore);

				/// <summary>
				/// Deletes the state string stored in the session under the key sStorageKeyPrefix + sId.s
				/// 
				/// sStorageKeyPrefix is the id prefix defined for the storage instance (@see jQuery.sap#storage)
				/// </summary>
				/// <param name="sId">Id for the state to delete</param>
				/// <returns>true if the deletion was successful or the data doesn't exist under the specified key, and false if the feature is unavailable or a problem occurred</returns>
				public extern static bool remove(string sId);

				/// <summary>
				/// Deletes all state strings stored in the session under the key prefix sStorageKeyPrefix + sIdPrefix.
				/// 
				/// sStorageKeyPrefix is the id prefix defined for the storage instance (@see jQuery.sap#storage)
				/// </summary>
				/// <param name="sIdPrefix">Id prefix for the states to delete</param>
				/// <returns>true if the deletion was successful or the data doesn't exist under the specified key, and false if the feature is unavailable or a problem occurred</returns>
				public extern static bool removeAll(string sIdPrefix);

				#endregion

				/// <summary>
				/// Enumeration of the storage types supported by {@link jQuery.sap.storage.Storage}
				/// </summary>
				[External]
				[Namespace(false)]
				public enum Type
				{
						/// <summary>
						/// Indicates usage of the browser's globalStorage feature
						/// </summary>
						global,
						/// <summary>
						/// Indicates usage of the browser's localStorage feature
						/// </summary>
						local,
						/// <summary>
						/// Indicates usage of the browser's sessionStorage feature
						/// </summary>
						session,
				}
				/// <summary>
				/// A Storage API for JavaScript.
				/// 
				/// Provides methods to store data on the client using Web Storage API support by the browser. The data received by this API must be already serialized, in string format. Similarly, the API returns the retrieved data in serialized string format, so it is the responsibility of the caller to de-serialize it, if applicable.
				/// 
				/// Attention: The Web Storage API stores the data on the client. Therefore do not use this API for confidential information.
				/// 
				/// One can get access to the 'default' storage by using {@link jQuery.sap.storage} directly or alternatively via factory functionality available as <code>jQuery.sap.storage(jQuery.sap.storage.Type.session)</code> returning an object implementing this interface.
				/// 
				/// A typical intended usage of this API is the storage of a string representing the state of a control. In such usage, the data is stored in the browser session, and the methods to be used are {@link #put} and {@link #get}. The method {@link #remove} can be used to delete the previously saved state.
				/// 
				/// In sake of completeness, the method {@link #clear} is available. However, it should be called only in very particular situations, when a global erasing of data is required. If only keys with certain prefix should be deleted the method {@link #removeAll} should be used.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial interface Storage
				{
					#region Methods

					/// <summary>
					/// Deletes all the entries saved in the session (Independent of the current Storage instance!).
					/// 
					/// CAUTION: This method should be called only in very particular situations, when a global erasing of data is required. Given that the method deletes the data saved under any ID, it should not be called when managing data for specific controls.
					/// </summary>
					/// <returns>true if execution of removal was successful or the data to remove doesn't exist, and false if the feature is unavailable or a problem occurred</returns>
					bool clear();

					/// <summary>
					/// Retrieves the state string stored in the session under the key sStorageKeyPrefix + sId.
					/// 
					/// sStorageKeyPrefix is the id prefix defined for the storage instance (@see jQuery.sap#storage)
					/// </summary>
					/// <param name="sId">Id for the state to retrieve</param>
					/// <returns>the string from the storage, if the retrieval was successful, and null otherwise</returns>
					string get(string sId);

					/// <summary>
					/// Returns the type of the storage.
					/// </summary>
					/// <returns>the type of the storage or "unknown"</returns>
					Union<jQuery.sap.storage.Type, string> getType();

					/// <summary>
					/// Returns whether the given storage is suppported.
					/// </summary>
					/// <returns>true if storage is supported, false otherwise (e.g. due to browser security settings)</returns>
					bool isSupported();

					/// <summary>
					/// Stores the passed state string in the session, under the key sStorageKeyPrefix + sId.
					/// 
					/// sStorageKeyPrefix is the id prefix defined for the storage instance (@see jQuery.sap#storage)
					/// </summary>
					/// <param name="sId">Id for the state to store</param>
					/// <param name="sStateToStore">content to store</param>
					/// <returns>true if the data were successfully stored, false otherwise</returns>
					bool put(string sId, string sStateToStore);

					/// <summary>
					/// Deletes the state string stored in the session under the key sStorageKeyPrefix + sId.s
					/// 
					/// sStorageKeyPrefix is the id prefix defined for the storage instance (@see jQuery.sap#storage)
					/// </summary>
					/// <param name="sId">Id for the state to delete</param>
					/// <returns>true if the deletion was successful or the data doesn't exist under the specified key, and false if the feature is unavailable or a problem occurred</returns>
					bool remove(string sId);

					/// <summary>
					/// Deletes all state strings stored in the session under the key prefix sStorageKeyPrefix + sIdPrefix.
					/// 
					/// sStorageKeyPrefix is the id prefix defined for the storage instance (@see jQuery.sap#storage)
					/// </summary>
					/// <param name="sIdPrefix">Id prefix for the states to delete</param>
					/// <returns>true if the deletion was successful or the data doesn't exist under the specified key, and false if the feature is unavailable or a problem occurred</returns>
					bool removeAll(string sIdPrefix);

					#endregion

				}
			}
		}
	}
}
