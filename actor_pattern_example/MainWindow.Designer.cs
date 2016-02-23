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
            this.pControls = new System.Windows.Forms.Panel();
            this.lbStart = new System.Windows.Forms.Label();
            this.tbActorCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.lbEnd = new System.Windows.Forms.Label();
            this.gbProgress.SuspendLayout();
            this.pControls.SuspendLayout();
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
            this.tbPrimes.Size = new System.Drawing.Size(495, 137);
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
            this.gbProgress.Size = new System.Drawing.Size(191, 291);
            this.gbProgress.TabIndex = 1;
            this.gbProgress.TabStop = false;
            this.gbProgress.Text = "Actor Progress";
            // 
            // flProgress
            // 
            this.flProgress.AutoScroll = true;
            this.flProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flProgress.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flProgress.Location = new System.Drawing.Point(3, 16);
            this.flProgress.Name = "flProgress";
            this.flProgress.Size = new System.Drawing.Size(185, 272);
            this.flProgress.TabIndex = 0;
            this.flProgress.WrapContents = false;
            // 
            // pControls
            // 
            this.pControls.Controls.Add(this.lbEnd);
            this.pControls.Controls.Add(this.tbEnd);
            this.pControls.Controls.Add(this.tbStart);
            this.pControls.Controls.Add(this.lbStart);
            this.pControls.Controls.Add(this.tbActorCount);
            this.pControls.Controls.Add(this.label1);
            this.pControls.Controls.Add(this.btnStop);
            this.pControls.Controls.Add(this.btnStart);
            this.pControls.Location = new System.Drawing.Point(209, 171);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(298, 272);
            this.pControls.TabIndex = 2;
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(6, 46);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(29, 13);
            this.lbStart.TabIndex = 4;
            this.lbStart.Text = "Start";
            // 
            // tbActorCount
            // 
            this.tbActorCount.Location = new System.Drawing.Point(3, 19);
            this.tbActorCount.MaxLength = 4;
            this.tbActorCount.Name = "tbActorCount";
            this.tbActorCount.Size = new System.Drawing.Size(125, 20);
            this.tbActorCount.TabIndex = 3;
            this.tbActorCount.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actor Count";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(220, 246);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(139, 246);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(3, 63);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(100, 20);
            this.tbStart.TabIndex = 5;
            this.tbStart.Text = "1";
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(139, 63);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(100, 20);
            this.tbEnd.TabIndex = 6;
            this.tbEnd.Text = "100";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(139, 46);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(26, 13);
            this.lbEnd.TabIndex = 7;
            this.lbEnd.Text = "End";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 458);
            this.Controls.Add(this.pControls);
            this.Controls.Add(this.gbProgress);
            this.Controls.Add(this.tbPrimes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 497);
            this.MinimumSize = new System.Drawing.Size(535, 497);
            this.Name = "MainWindow";
            this.Text = "Actor Pattern Example - CPU Burner";
            this.gbProgress.ResumeLayout(false);
            this.pControls.ResumeLayout(false);
            this.pControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrimes;
        private System.Windows.Forms.GroupBox gbProgress;
        private System.Windows.Forms.FlowLayoutPanel flProgress;
        private System.Windows.Forms.Panel pControls;
        private System.Windows.Forms.TextBox tbActorCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.TextBox tbStart;
    }
}

