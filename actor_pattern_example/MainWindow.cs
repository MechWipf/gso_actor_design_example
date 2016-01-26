using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actor_pattern_example
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            AddProgress();
        }

        public void AddProgress()
        {
            for (int i = 0; i < 5; i++)
            {
                var pp = new ProgressControl( "Worker " + i );
                this.flProgress.BorderStyle = BorderStyle.FixedSingle;
                this.flProgress.Controls.Add( pp );
            }
        }
    }
}
