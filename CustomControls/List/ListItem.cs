using System.Collections.Generic;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class ListItem : UserControl
    {
        public Dictionary<string, object> Record { get; set; }
        public MouseEventArgs MouseClickEventArgs { get; set; }
        public List List { get; set; }

        public ListItem()
        {
            InitializeComponent();
        }


        public void AttachedListeners()
        {
            // Add listerners for main user control.
            MouseDoubleClick += (sender, args) => this.List.OnListItemDoubleClick(this, new ListItemEventArgs { Record = this.Record });
            MouseEnter += (sender, args) => this.List.OnListItemMouseEnter(this, new ListItemEventArgs { Record = this.Record });
            MouseLeave += (sender, args) => this.List.OnListItemMouseLeave(this, new ListItemEventArgs { Record = this.Record });
            MouseClick += (sender, args) => this.List.OnListItemMouseClick(this, new ListItemMouseClickEventArgs { Record = this.Record, MouseClickEventArgs = args });

            // Add listeners for each child control.
            foreach (Control control in this.Controls)
            {
                control.MouseDoubleClick += (sender, args) => this.List.OnListItemDoubleClick(this, new ListItemEventArgs { Record = this.Record });
                control.MouseEnter += (sender, args) => this.List.OnListItemMouseEnter(this, new ListItemEventArgs { Record = this.Record });
                control.MouseLeave += (sender, args) => this.List.OnListItemMouseLeave(this, new ListItemEventArgs { Record = this.Record });
                control.MouseClick += (sender, args) => this.List.OnListItemMouseClick(this, new ListItemMouseClickEventArgs { Record = this.Record, MouseClickEventArgs = args });

            }
        }

        public virtual void Process()
        {
        }
    }
}