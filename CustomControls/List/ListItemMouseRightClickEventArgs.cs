using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace CustomControls
{
    public class ListItemMouseClickEventArgs : EventArgs
    {
        public Dictionary<string, object> Record { get; set; }
        public MouseEventArgs MouseClickEventArgs { get; set; }

    }
}
