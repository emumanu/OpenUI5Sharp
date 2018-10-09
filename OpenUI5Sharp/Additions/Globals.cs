using System;
using Bridge;
using Retyped;

namespace UI5
{
    /// <summary>
    /// Global variables and functions
    /// </summary>
    [External]
    public static partial class Globals
    {
        /// <summary>This is used to handle document constant in sap.ui.core.Popup.open method</summary>
        [Template("document")]
        public const Union<string, sap.ui.core.Element, dom.HTMLElement, jQuery, jquery.JQuery.Event> document = null;

        /// <summary>
        /// Method to call bind with a different object as this
        /// </summary>
        /// <typeparam name="T">The return type</typeparam>
        /// <param name="obj">The object with the method to bind</param>
        /// <param name="func">The method name to bind</param>
        /// <param name="context">the new this object for the method</param>
        /// <returns></returns>
        [Template("{obj}.{func:raw}.bind({context})")]
        public extern static T BindMethod<T>(object obj, string func, object context);


        [Template("{obj}.{oldEventHandler:raw} = {newEventHandler}")]
        public extern static void RedefineJQueryEvent(object obj, string oldEventHandler, Action<jquery.JQuery.Event> newEventHandler);
    }
}

     