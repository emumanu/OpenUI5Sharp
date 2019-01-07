using System;
using System.Linq.Expressions;
using Bridge;

namespace UI5
{
    [External]
    public partial class sap
    {
        [External]
        public static partial class m
        {
            [External]
            public static partial class MessageBox
            {
                #region Delegates

                public delegate void CloseDelegate(Union<sap.m.MessageBox.Action, string> oAction);

                #endregion
            }

            [External]
            [ObjectLiteral]
            public partial class P13nCondition
            {
                public bool exclude;
                public string key;
                public string keyField;
                public string operation;
                public bool showIfGrouped;
                public string text;
                public string value1;
                public string value2;
            }

            [External]
            [Namespace(false)]
            [Name("sap.m.P13nConditionOperation")]
            public enum P13nConditionOperation
            {
                // filter operations
                BT, // "BT",
                EQ, // "EQ",
                Contains, // "Contains",
                StartsWith, // "StartsWith",
                EndsWith, // "EndsWith",
                LT, // "LT",
                LE, // "LE",
                GT, // "GT",
                GE, // "GE",
                Initial, // "Initial",
                Empty, // "Empty",
                NotEmpty, // "NotEmpty",

                // sort operations
                Ascending, // "Ascending",
                Descending, // "Descending",

                // group operations
                GroupAscending, // "GroupAscending",
                GroupDescending, // "GroupDescending",

                // calculation operations
                Total, // "Total",
                Average, // "Average",
                Minimum, // "Minimum",
                Maximum, // "Maximum"
            }
        }
    }
}