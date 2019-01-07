﻿using System;
using Bridge;

namespace UI5
{
    [External]
    public abstract partial class jQuery
    {
        [External]
        public static partial class sap
        {
            /// <summary>
            /// Returns an instance of jQuery.sap.storage.Storage, providing access to the storage of the given jQuery.sap.storage.Type or to the given HTML5 Storage object.
            /// </summary>
            /// <param name="storageType">The storage to access</param>
            /// <returns>An instance of jQuery.sap.storage.Storage</returns>
            [Name("storage")]
            public extern static jQuery.sap.storage.Storage storageFn(jQuery.sap.storage.Type storageType);

            [External]
            public static partial class util
            {
                [External]
                public partial interface UriParameters
                {
                    /// <summary>
                    /// Returns the value(s) of the URI parameter with the given name sName.
                    /// 
                    /// If the boolean parameter bAll is <code>true</code>, an array of string values of all occurrences of the URI parameter with the given name is returned. This array is empty if the URI parameter is not contained in the windows URL.
                    /// 
                    /// If the boolean parameter bAll is <code>false</code> or is not specified, the value of the first occurrence of the URI parameter with the given name is returned. Might be <code>null</code> if the URI parameter is not contained in the windows URL.
                    /// </summary>
                    /// <param name="sUri">The name of the URI parameter.</param>
                    /// <returns>The value(s) of the URI parameter with the given name</returns>
                    Union<T, object[]> get<T>(string sUri);
                }
            }

        }
    }
}