using System;
using Bridge;

namespace UI5
{
    [External]
    public static partial class sap
    {
        [External]
        public static partial class m
        {
            [External]
            [Namespace(false)]
            public partial class IconTabBarSelectList
            {
            }
        }

        [External]
        public static partial class ui
        {
            [External]
            public static partial class test
            {
                [External]
                [Namespace(false)]
                public partial class qunit
                {
                }
            }
        }
    }
}