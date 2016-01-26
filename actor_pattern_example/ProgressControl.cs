using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actor_pattern_example
{
    class ProgressControl : UserControl
    {
        private Label Caption;
        private ProgressBar Bar;

        public int Value { get { return this.Bar.Value; } set { this.Bar.Value = value; } }

        public ProgressControl(string caption)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Height = 35;

            this.Bar = new ProgressBar();
            this.Bar.Value = 95;
            this.Bar.Dock = DockStyle.Top;

            this.Controls.Add( Bar );

            this.Caption = new Label();
            this.Caption.Text = caption;
            //this.Caption.Anchor = AnchorStyles.Left;
            this.Caption.AutoSize = true;
            this.Caption.Dock = DockStyle.Top;

            this.Controls.Add( Caption );
        }
    }
}
