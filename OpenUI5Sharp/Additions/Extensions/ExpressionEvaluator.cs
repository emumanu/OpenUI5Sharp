using System;
using Bridge;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace OpenUI5Sharp.Extensions
{
    [Priority(1001)]
    [Namespace(false)]
    [FileName("openui5sharp.js")]
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
