using System;
using Bridge;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace UI5.Extensions
{
    [Priority(1001)]
    [FileName("openui5sharp.js")]
    [Name("UI5.Extensions.ExpressionEvaluator")]
    public static partial class ExpressionEvaluator
    {
        public static string GetPath<T>(Expression<T> pathExpression, string separator = "/")
        {
            if (pathExpression == null) {
                throw new ArgumentNullException(nameof(pathExpression));
            }

            MemberExpression me;
            switch (pathExpression.Body.NodeType) {
                case ExpressionType.Convert:
                case ExpressionType.ConvertChecked:
                    var ue = pathExpression.Body as UnaryExpression;
                    me = ((ue != null) ? ue.Operand : null) as MemberExpression;
                    break;
                default:
                    me = pathExpression.Body as MemberExpression;
                    break;
            }

            List<string> path = new List<string>();

            while (me != null) {
                path.Add(me.Member.Name);
                me = me.Expression as MemberExpression;
            }

            path.Reverse();
            return String.Join(separator, path);
        }
    }
}
