namespace actor_pattern_example
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPrimes = new System.Windows.Forms.TextBox();
            this.gbProgress = new System.Windows.Forms.GroupBox();
            this.flProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.gbProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPrimes
            // 
            this.tbPrimes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrimes.Location = new System.Drawing.Point(12, 12);
            this.tbPrimes.Multiline = true;
            this.tbPrimes.Name = "tbPrimes";
            this.tbPrimes.ReadOnly = true;
            this.tbPrimes.Size = new System.Drawing.Size(613, 137);
            this.tbPrimes.TabIndex = 0;
            // 
            // gbProgress
            // 
            this.gbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbProgress.AutoSize = true;
            this.gbProgress.Controls.Add(this.flProgress);
            this.gbProgress.Location = new System.Drawing.Point(12, 155);
            this.gbProgress.Name = "gbProgress";
            this.gbProgress.Size = new System.Drawing.Size(211, 291);
            this.gbProgress.TabIndex = 1;
            this.gbProgress.TabStop = false;
            this.gbProgress.Text = "Actor Progress";
            // 
            // flProgress
            // 
            this.flProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flProgress.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flProgress.Location = new System.Drawing.Point(3, 16);
            this.flProgress.Name = "flProgress";
            this.flProgress.Size = new System.Drawing.Size(205, 272);
            this.flProgress.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 458);
            this.Controls.Add(this.gbProgress);
            this.Controls.Add(this.tbPrimes);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.gbProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrimes;
        private System.Windows.Forms.GroupBox gbProgress;
        private System.Windows.Forms.FlowLayoutPanel flProgress;
    }
}

