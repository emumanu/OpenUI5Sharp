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
                public partial class Popup
                {
                    /// <summary>
                    /// Docking position: horizontal/vertical.
                    /// 
                    /// Defines a position on the element which is used for aligned positioning of another element (e.g. the left top corner of a popup is positioned at the left bottom corner of the input field). For the horizontal position possible values are "begin", "left", "center", "right" and "end", where left/right always are left and right, or begin/end which are dependent on the text direction. For the vertical position possible values are "top", "center" and "bottom". Examples: "left top", "end bottom", "center center".
                    /// </summary>
                    [External]
                    [Namespace(false)]
                    public partial class Dock
                    {
                        public const sap.ui.core.Dock BeginBottom = null;
                        public const sap.ui.core.Dock BeginCenter = null;
                        public const sap.ui.core.Dock BeginTop = null;
                        public const sap.ui.core.Dock CenterBottom = null;
                        public const sap.ui.core.Dock CenterCenter = null;
                        public const sap.ui.core.Dock CenterTop = null;
                        public const sap.ui.core.Dock EndBottom = null;
                        public const sap.ui.core.Dock EndCenter = null;
                        public const sap.ui.core.Dock EndTop = null;
                        public const sap.ui.core.Dock LeftBottom = null;
                        public const sap.ui.core.Dock LeftCenter = null;
                        public const sap.ui.core.Dock LeftTop = null;
                        public const sap.ui.core.Dock RightBottom = null;
                        public const sap.ui.core.Dock RightCenter = null;
                        public const sap.ui.core.Dock RightTop = null;
                    }
                }
            }
        }
    }
}
