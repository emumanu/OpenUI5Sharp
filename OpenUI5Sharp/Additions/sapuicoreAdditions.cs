using System;
using Bridge;
using OpenUI5Sharp;

namespace OpenUI5Sharp
{
    [External]
    public partial class sap
    {
        [External]
        public static partial class ui
        {
            [External]
            public static partial class core
            {
                [External]
                public partial class Core
                {
                    /// <summary>
					/// Returns the registered element for the given id, if any.
					/// </summary>
					/// <param name="sId"></param>
					/// <returns>the element for the given id</returns>
					public extern virtual T byId<T>(string sId) where T : sap.ui.core.Element;
                }

                [External]
                public partial class Element
                {
                    /// <summary>
					/// Attaches custom data to an <code>Element</code> or retrieves attached data.
					/// 
					/// Usage: <pre>
					///    data("myKey", myData)
					/// </pre> Attaches <code>myData</code> (which can be any JS data type, e.g. a number, a string, an object, or a function) to this element, under the given key "myKey". If the key already exists,the value will be updated.
					/// 
					/// <pre>
					///    data("myKey", myData, writeToDom)
					/// </pre> Attaches <code>myData</code> to this element, under the given key "myKey" and (if <code>writeToDom</code> is true) writes key and value to the HTML. If the key already exists,the value will be updated. While <code>oValue</code> can be any JS data type to be attached, it must be a string to be also written to DOM. The key must also be a valid HTML attribute name (it must conform to <code>sap.ui.core.ID</code> and may contain no colon) and may not start with "sap-ui". When written to HTML, the key is prefixed with "data-".
					/// 
					/// <pre>
					///    data("myKey")
					/// </pre> Retrieves whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data("myKey", null)
					/// </pre> Removes whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data(null)
					/// </pre> Removes all data
					/// 
					/// <pre>
					///    data()
					/// </pre> Returns all data, as a map
					/// </summary>
					/// <param name="sKey"></param>
					/// <param name="oData"></param>
					/// <param name="bWriteToDom"></param>
					/// <returns></returns>
					public extern virtual object data<T>(string sKey, T oData, bool bWriteToDom);

                    /// <summary>
                    /// Attaches custom data to an <code>Element</code> or retrieves attached data.
                    /// 
                    /// Usage: <pre>
                    ///    data("myKey", myData)
                    /// </pre> Attaches <code>myData</code> (which can be any JS data type, e.g. a number, a string, an object, or a function) to this element, under the given key "myKey". If the key already exists,the value will be updated.
                    /// 
                    /// <pre>
                    ///    data("myKey", myData, writeToDom)
                    /// </pre> Attaches <code>myData</code> to this element, under the given key "myKey" and (if <code>writeToDom</code> is true) writes key and value to the HTML. If the key already exists,the value will be updated. While <code>oValue</code> can be any JS data type to be attached, it must be a string to be also written to DOM. The key must also be a valid HTML attribute name (it must conform to <code>sap.ui.core.ID</code> and may contain no colon) and may not start with "sap-ui". When written to HTML, the key is prefixed with "data-".
                    /// 
                    /// <pre>
                    ///    data("myKey")
                    /// </pre> Retrieves whatever data has been attached to this element (using the key "myKey") before
                    /// 
                    /// <pre>
                    ///    data("myKey", null)
                    /// </pre> Removes whatever data has been attached to this element (using the key "myKey") before
                    /// 
                    /// <pre>
                    ///    data(null)
                    /// </pre> Removes all data
                    /// 
                    /// <pre>
                    ///    data()
                    /// </pre> Returns all data, as a map
                    /// </summary>
                    /// <param name="sKey"></param>
                    /// <param name="oData"></param>
                    /// <returns></returns>
                    public extern virtual object data<T>(string sKey, T oData);

                    /// <summary>
                    /// Attaches custom data to an <code>Element</code> or retrieves attached data.
                    /// 
                    /// Usage: <pre>
                    ///    data("myKey", myData)
                    /// </pre> Attaches <code>myData</code> (which can be any JS data type, e.g. a number, a string, an object, or a function) to this element, under the given key "myKey". If the key already exists,the value will be updated.
                    /// 
                    /// <pre>
                    ///    data("myKey", myData, writeToDom)
                    /// </pre> Attaches <code>myData</code> to this element, under the given key "myKey" and (if <code>writeToDom</code> is true) writes key and value to the HTML. If the key already exists,the value will be updated. While <code>oValue</code> can be any JS data type to be attached, it must be a string to be also written to DOM. The key must also be a valid HTML attribute name (it must conform to <code>sap.ui.core.ID</code> and may contain no colon) and may not start with "sap-ui". When written to HTML, the key is prefixed with "data-".
                    /// 
                    /// <pre>
                    ///    data("myKey")
                    /// </pre> Retrieves whatever data has been attached to this element (using the key "myKey") before
                    /// 
                    /// <pre>
                    ///    data("myKey", null)
                    /// </pre> Removes whatever data has been attached to this element (using the key "myKey") before
                    /// 
                    /// <pre>
                    ///    data(null)
                    /// </pre> Removes all data
                    /// 
                    /// <pre>
                    ///    data()
                    /// </pre> Returns all data, as a map
                    /// </summary>
                    /// <param name="sKey"></param>
                    /// <returns></returns>
                    public extern virtual T data<T>(string sKey);

                    /// <summary>
					/// Fires the given event and notifies all listeners. Listeners must not change the content of the event.
					/// </summary>
					/// <param name="sEventId">the event id</param>
					/// <param name="mParameters">the parameter map</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Element fireEvent<TParameter>(string sEventId, TParameter mParameters);
                }

                [External]
                public partial class UIComponent
                {
                    /// <summary>
					/// Returns an element by its ID in the context of the component.
					/// </summary>
					/// <param name="sId">Component local ID of the element</param>
					/// <returns>element by its ID or <code>undefined</code></returns>
					public extern virtual T byId<T>(string sId) where T : sap.ui.core.Element;

                    /// <summary>
                    /// Returns the content of {@link sap.ui.core.UIComponent#createContent}. If you specified a <code>rootView</code> in your metadata or in the descriptor file (manifest.json), you will get the instance of the root view. This getter will only return something if the {@link sap.ui.core.UIComponent#init} function was invoked. If <code>createContent</code> is not implemented, and there is no root view, it will return <code>null</code>. Here is an example: <code> <pre>
                    ///          var MyExtension = UIComponent.extend("my.Component", {
                    ///               metadata: {
                    ///                    rootView: "my.View"
                    ///               },
                    ///               init: function () {
                    ///                    this.getRootControl(); // returns null
                    ///                    UIComponent.prototype.init.apply(this, arguments);
                    ///                    this.getRootControl(); // returns the view "my.View"
                    ///               }
                    ///          });
                    ///     </pre> </code>
                    /// </summary>
                    /// <returns>the control created by {@link sap.ui.core.UIComponent#createContent}</returns>
                    public extern virtual T getRootControl<T>() where T : sap.ui.core.Control;
                }
            }
        }
    }
}