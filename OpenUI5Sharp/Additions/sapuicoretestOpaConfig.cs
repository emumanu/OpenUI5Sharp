using System;
using Bridge;


namespace UI5
{
    public partial class sap
    {
        public static partial class ui
        {
            public static partial class test
            {
                /// <summary>
                /// The global Opa configuration class, that can be used to set the static member "config"
                /// </summary>
                [External]
                [ObjectLiteral]
                [Namespace(false)]
                public partial class OpaConfig
                {
                    /// <summary>
                    /// A new Opa instance
                    /// </summary>
                    public sap.ui.test.Opa arrangements;

                    /// <summary>
                    /// A new Opa instance
                    /// </summary>
                    public sap.ui.test.Opa actions;

                    /// <summary>
                    /// A new Opa instance
                    /// </summary>
                    public sap.ui.test.Opa assertions;

                    /// <summary>
                    /// 15 seconds, 0 for infinite timeout
                    /// </summary>
                    public int timeout;

                    /// <summary>
                    /// 400 milliseconds
                    /// </summary>
                    public int pollingInterval;

                    /// <summary>
                    /// 0 seconds, infinite timeout by default. This will be used instead of timeout if running in debug mode.
                    /// </summary>
                    public int debugTimeout;

                    /// <summary>
                    /// You can either directly manipulate the config, or extend it using {@link sap.ui.test.Opa.extendConfig}
                    /// </summary>
                    public bool asyncPolling;

                    /// <summary>
                    /// 0 or 50 (depending on the browser). The value is a number representing milliseconds.The executionDelay will slow down the execution of every single waitFor statement to be delayed by the number of milliseconds.This does not effect the polling interval it just adds an initial pause.Use this parameter to slow down OPA when you want to watch your test during development or checking the UI of your app.It is not recommended to use this parameter in any automated test executions.
                    /// </summary>
                    public int executionDelay;
                }

                /// <summary>
                /// The global Opa5 configuration class, that can be used to set the static member "config"
                /// </summary>
                [External]
                [ObjectLiteral]
                [Namespace(false)]
                public partial class Opa5Config : OpaConfig
                {
                    /// <summary>
                    /// Default value is empty
                    /// </summary>
                    public string viewNamespace;

                    /// <summary>
                    /// Default value is true
                    /// </summary>
                    public bool visible;

                    /// <summary>
                    /// Default value is false - since 1.42
                    /// </summary>
                    public bool autoWait;

                    /// <summary>
                    /// object with URI parameters for the tested app - since 1.48
                    /// </summary>
                    public object appParams;
                }
            }
        }
    }
}
