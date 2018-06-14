using System;
using Bridge;
using OpenUI5Sharp;

namespace OpenUI5Sharp
{
    [External]
    public partial class jQuery
    {
        [External]
        public static partial class sap
        {
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