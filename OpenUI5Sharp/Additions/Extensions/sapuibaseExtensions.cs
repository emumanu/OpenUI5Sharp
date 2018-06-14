using System;
using System.Linq.Expressions;
using Bridge;
using OpenUI5Sharp;

namespace OpenUI5Sharp.Extensions
{
    [Namespace(false)]
    [FileName("openui5sharp.js")]
    public static class sapuibaseExtensions
    {
        /// <summary>
        /// Returns the value of the parameter with the given expression.
        /// </summary>
        /// <param name="event">the event to extend</param>
        /// <param name="pathExpression">the path/name of the property</param>
        /// <returns>The value for the parameter</returns>
        public static TValue getParameterFor<TParameter, TValue>(this sap.ui.@base.Event<TParameter> @event, Expression<Func<TParameter, TValue>> pathExpression)
        {
            string sPropertyName = ExpressionEvaluator.GetPath(pathExpression);
            return @event.getParameter<TValue>(sPropertyName);
        }

        /// <summary>
        /// Returns all parameter values of the event.
        /// </summary>
        /// <returns>All parameters of the event</returns>
        public static TParameter getParametersFor<TParameter>(this sap.ui.@base.Event<TParameter> @event)
        {
            return @event.getParameters<TParameter>();
        }
    }
}
