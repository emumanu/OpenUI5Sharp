using System;
using System.Linq.Expressions;
using Bridge;

namespace UI5
{
    [External]
    public partial class sap
    {
        [External]
        public static partial class ui
        {
            [External]
            public static partial class model
            {
                [External]
                public partial class Context
                {
                    /// <summary>
					/// Gets the (model dependent) object the context points to or the object with the given relative binding path
					/// </summary>
					/// <param name="sPath">the binding path</param>
					/// <param name="mParameters">additional model specific parameters (optional)</param>
					/// <returns>the context object</returns>
					public extern virtual T getObject<T>(string sPath, object mParameters);

                    /// <summary>
                    /// Gets the (model dependent) object the context points to or the object with the given relative binding path
                    /// </summary>
                    /// <param name="sPath">the binding path</param>
                    /// <returns>the context object</returns>
                    public extern virtual T getObject<T>(string sPath);

                    /// <summary>
                    /// Gets the (model dependent) object the context points to or the object with the given relative binding path
                    /// </summary>
                    /// <returns>the context object</returns>
                    public extern virtual T getObject<T>();

                    /// <summary>
                    /// Gets the (model dependent) object the context points to or the object with the given relative binding path
                    /// </summary>
                    /// <param name="mParameters">additional model specific parameters (optional)</param>
                    /// <returns>the context object</returns>
                    public extern virtual T getObject<T>(object mParameters);

                    /// <summary>
                    /// Gets the property with the given relative binding path
                    /// </summary>
                    /// <param name="sPath">the binding path</param>
                    /// <returns>the property value</returns>
                    public extern virtual T getProperty<T>(string sPath);
                }

                [External]
                public partial class Model
                {
                    /// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to where to read the object</param>
					/// <param name="oContext">the context with which the path should be resolved</param>
					/// <param name="mParameters">additional model specific parameters</param>
                    /// <returns>The value for the given path/context or <code>undefined</code> if data or entity type could not be found or was incomplete</returns>
					public extern virtual T getObject<T>(string sPath, sap.ui.model.Context oContext, object mParameters);

                    /// <summary>
                    /// Implement in inheriting classes
                    /// </summary>
                    /// <param name="sPath">the path to where to read the object</param>
                    /// <param name="oContext">the context with which the path should be resolved</param>
                    /// <returns>The value for the given path/context or <code>undefined</code> if data or entity type could not be found or was incomplete</returns>
                    public extern virtual T getObject<T>(string sPath, sap.ui.model.Context oContext);

                    /// <summary>
                    /// Implement in inheriting classes
                    /// </summary>
                    /// <param name="sPath">the path to where to read the object</param>
                    /// <returns>The value for the given path/context or <code>undefined</code> if data or entity type could not be found or was incomplete</returns>
                    public extern virtual T getObject<T>(string sPath);

                    /// <summary>
					/// Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
					/// </summary>
					/// <param name="sPath">the path/name of the property</param>
					/// <param name="oContext">the context if available to access the property value</param>
					/// <returns>vValue the value of the property</returns>
					public extern virtual T getOriginalProperty<T>(string sPath, sap.ui.model.Context oContext);

                    /// <summary>
                    /// Returns the original value for the property with the given path and context. The original value is the value that was last responded by a server if using a server model implementation.
                    /// </summary>
                    /// <param name="sPath">the path/name of the property</param>
                    /// <returns>vValue the value of the property</returns>
                    public extern virtual T getOriginalProperty<T>(string sPath);

                    /// <summary>
					/// Implement in inheriting classes
					/// </summary>
					/// <param name="sPath">the path to where to read the attribute value</param>
					/// <param name="oContext">the context with which the path should be resolved</param>
                    /// <returns>Returns the value for the property with the given sPropertyName</returns>
					public extern virtual T getProperty<T>(string sPath, sap.ui.model.Context oContext);

                    /// <summary>
                    /// Implement in inheriting classes
                    /// </summary>
                    /// <param name="sPath">the path to where to read the attribute value</param>
                    /// <returns>Returns the value for the property with the given sPropertyName</returns>
                    public extern virtual T getProperty<T>(string sPath);

                    /// <summary>
                    /// Sets a new value for the given property <code>sPropertyName</code> in the model. If the model value changed all interested parties are informed.
                    /// </summary>
                    /// <param name="sPath">path of the property to set</param>
                    /// <param name="oValue">value to set the property to</param>
                    /// <param name="oContext">the context which will be used to set the property</param>
                    /// <param name="bAsyncUpdate">whether to update other bindings dependent on this property asynchronously</param>
                    /// <returns>true if the value was set correctly and false if errors occurred like the entry was not found.</returns>
                    public extern virtual bool setProperty<T>(string sPath, T oValue, sap.ui.model.Context oContext, bool bAsyncUpdate);

                    /// <summary>
                    /// Sets a new value for the given property <code>sPropertyName</code> in the model. If the model value changed all interested parties are informed.
                    /// </summary>
                    /// <param name="sPath">path of the property to set</param>
                    /// <param name="oValue">value to set the property to</param>
                    /// <param name="oContext">the context which will be used to set the property</param>
                    /// <returns>true if the value was set correctly and false if errors occurred like the entry was not found.</returns>
                    public extern virtual bool setProperty<T>(string sPath, T oValue, sap.ui.model.Context oContext);

                    /// <summary>
                    /// Sets a new value for the given property <code>sPropertyName</code> in the model. If the model value changed all interested parties are informed.
                    /// </summary>
                    /// <param name="sPath">path of the property to set</param>
                    /// <param name="oValue">value to set the property to</param>
                    /// <returns>true if the value was set correctly and false if errors occurred like the entry was not found.</returns>
                    public extern virtual bool setProperty<T>(string sPath, T oValue);
                }

                [External]
                public partial class Sorter
                {
                    /// <summary>
                    /// Delefate for the function that calculates the group value out of the context
                    /// </summary>
                    /// <param name="oContext">the binding context</param>
                    /// <returns>a primitive type value as the group key or an object containing at least a "key" property</returns>
                    public delegate object CalculateGroupDelegate(sap.ui.model.Context oContext);
                }

                [External]
                public static partial class odata
                {
                    [External]
                    public partial class ODataModel
                    {
                        /// <summary>
						/// Returns the value for the property with the given <code>sPath</code>. If the path points to a navigation property which has been loaded via $expand then the <code>bIncludeExpandEntries</code> parameter determines if the navigation property should be included in the returned value or not. Please note that this currently works for 1..1 navigation properties only.
						/// </summary>
						/// <param name="sPath">the path/name of the property</param>
						/// <param name="oContext">the context if available to access the property value</param>
						/// <param name="bIncludeExpandEntries">This parameter should be set when a URI or custom parameter with a $expand System Query Option was used to retrieve associated entries embedded/inline. If true then the getProperty function returns a desired property value/entry and includes the associated expand entries (if any). If false the associated/expanded entry properties are removed and not included in the desired entry as properties at all. This is useful for performing updates on the base entry only. Note: A copy and not a reference of the entry will be returned.</param>
						/// <returns>the value of the property</returns>
						public extern virtual T getProperty<T>(string sPath, sap.ui.model.Context oContext, bool bIncludeExpandEntries);
                    }

                    [External]
                    public static partial class v2
                    {
                        [External]
                        public partial class ODataModel
                        {
                            /// <summary>
							/// Returns the value for the property with the given <code>sPath</code>.
							/// 
							/// If the path points to a navigation property which has been loaded via <code>$expand</code> then the <code>bIncludeExpandEntries</code> parameter determines if the navigation property should be included in the returned value or not. Please note that this currently works for 1..1 navigation properties only.
							/// </summary>
							/// <param name="sPath">Path/name of the property</param>
							/// <param name="oContext">Context if available to access the property value</param>
							/// <param name="bIncludeExpandEntries">@deprecated Please use {@link #getObject} function with select/expand parameters instead. This parameter should be set when a URI or custom parameter with a <code>$expand</code> system query option was used to retrieve associated entries embedded/inline. If true then the <code>getProperty</code> function returns a desired property value/entry and includes the associated expand entries (if any). Note: A copy and not a reference of the entry will be returned.</param>
							/// <returns>Value of the property</returns>
							public extern virtual T getProperty<T>(string sPath, sap.ui.model.Context oContext, bool bIncludeExpandEntries = false);
                        }
                    }
                }
            }
        }
    }
}