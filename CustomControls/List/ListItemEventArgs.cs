using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CustomControls
{
    public class ListItemEventArgs: EventArgs {
        public Dictionary<string, object> Record { get; set; }
    }
}
