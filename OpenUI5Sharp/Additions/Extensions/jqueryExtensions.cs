using System;
using Bridge;
using Retyped;

namespace UI5.Extensions
{
    [External]
    public static class jQueryExtensions
    {
        /// <summary>
        /// Extends the standard JQuery object with UI5 extensions
        /// </summary>
        /// <typeparam name="T">the generic type</typeparam>
        /// <param name="typeToAugment">the retyped JQuery object</param>
        /// <returns>the jQuery object with UI5 extensions</returns>
        [Template("{0}")]
        public extern static jQuery UI5<T>(this jquery.JQueryStatic<T> typeToAugment);
    }
}
