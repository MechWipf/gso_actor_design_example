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
        private Label lbCaption;
        private ProgressBar pbProgress;

        delegate void SetValueCallback(int value);

        public int Value
        {
            get { return this.pbProgress.Value; }
            set { this.pbProgress.Value = value; }
        }

        public void SetValue(int value)
        {
            if (this.pbProgress.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetValue);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                this.Value = value;
            }
        }

        public ProgressControl(string caption)
        {
            InitializeComponent();

            lbCaption.Text = caption;
        }

        private void InitializeComponent()
        {
            this.lbCaption = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbCaption
            // 
            this.lbCaption.AutoSize = true;
            this.lbCaption.Location = new System.Drawing.Point(3, 0);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(51, 13);
            this.lbCaption.TabIndex = 0;
            this.lbCaption.Text = "lbCaption";
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbProgress.Location = new System.Drawing.Point(3, 16);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(154, 23);
            this.pbProgress.TabIndex = 1;
            // 
            // ProgressControl
            // 
            this.AutoSize = true;
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lbCaption);
            this.Name = "ProgressControl";
            this.Size = new System.Drawing.Size(160, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
