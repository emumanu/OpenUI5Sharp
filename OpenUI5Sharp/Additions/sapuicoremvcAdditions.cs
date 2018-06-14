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
                public static partial class mvc
                {
                    [External]
                    public partial class Controller
                    {
                        /// <summary>
						/// Returns an Element of the connected view with the given local ID.
						/// 
						/// Views automatically prepend their own ID as a prefix to created Elements to make the IDs unique even in the case of multiple view instances. This method helps to find an element by its local ID only.
						/// 
						/// If no view is connected or if the view doesn't contain an element with the given local ID, undefined is returned.
						/// </summary>
						/// <param name="sId">View-local ID</param>
						/// <returns>Element by its (view local) ID</returns>
						public extern virtual T byId<T>(string sId) where T : sap.ui.core.Element;

                        /// <summary>
						/// Gets the component of the controller's view
						/// 
						/// If there is no Component connected to the view or the view is not connected to the controller, undefined is returned.
						/// </summary>
						/// <returns>Component instance</returns>
                        public extern virtual T getOwnerComponent<T>() where T : sap.ui.core.Component;
                    }

                    [External]
                    public partial class View
                    {
                        /// <summary>
						/// Returns the view's Controller instance or null for a controller-less View.
						/// </summary>
						/// <returns>Controller of this view.</returns>
                        public extern virtual T getController<T>() where T : sap.ui.core.mvc.Controller;

                        /// <summary>
						/// Returns an element by its ID in the context of the view.
						/// </summary>
						/// <param name="sId">View local ID of the element</param>
						/// <returns>element by its ID or <code>undefined</code></returns>
                        public extern virtual T byId<T>(string sId) where T : sap.ui.core.Element;
                    }
                }
            }

        }
    }
}