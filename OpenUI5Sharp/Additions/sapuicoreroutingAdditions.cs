using System;
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
            public static partial class core
            {
                [External]
                public static partial class routing
                {
                    [External]
                    public partial class Router
                    {
                        // this method was missing from the JSDoc classes as it is not marked as public
                        /// <summary>
						/// Returns a target by its name (if you pass myTarget: { view: "myView" }) in the config myTarget is the name. 
                        /// * See {@link sap.ui.core.routing.Targets#getTarget}
						/// </summary>
                        /// <param name="vName">the name of a single target or the name of multiple targets</param>
                        /// <returns>The target with the corresponding name or undefined. If an array way passed as name this will return an array with all found targets. Non existing targets will not be returned but will log an error.</returns>
                        public extern virtual Union<sap.ui.core.routing.Target, sap.ui.core.routing.Target[]> getTarget(Union<string,string[]> vName);
                    }
                }
            }
        }
    }
}