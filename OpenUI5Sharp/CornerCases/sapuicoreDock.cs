using System;
using Bridge;
using Retyped;

namespace UI5
{
    public partial class sap
    {
        public static partial class ui
        {
            public static partial class core
            {
                /// <summary>
                /// Docking position: horizontal/vertical.
                ///
                /// Defines a position on the element which is used for aligned positioning of another element(e.g.the left top corner of a popup is positioned at the left bottom corner of the input field). For the horizontal position possible values are "begin", "left", "center", "right" and "end", where left/right always are left and right, or begin/end which are dependent on the text direction.For the vertical position possible values are "top", "center" and "bottom". Examples: "left top", "end bottom", "center center".
                /// </summary>
                [External]
                [Namespace(false)]
                public partial class Dock : sap.ui.core.Popup.Dock
				{
					public extern static implicit operator string(Dock ts);
                    public extern static implicit operator Dock(string val);
                }
            }
        }
    }
}
