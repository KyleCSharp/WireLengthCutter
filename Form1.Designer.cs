namespace CarolinaPowerMCCutter
{
    partial class MCCutterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button zeroButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCCutterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentLengthLabel = new System.Windows.Forms.Label();
            this.currentLengthNumber = new System.Windows.Forms.Label();
            this.cutButton = new System.Windows.Forms.Button();
            this.countTextLabel = new System.Windows.Forms.Label();
            this.countNumberLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.httpswwwkyleriglercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createdByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kyleRiglerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zeroButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zeroButton
            // 
            zeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            zeroButton.BackColor = System.Drawing.Color.Black;
            zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zeroButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            zeroButton.Location = new System.Drawing.Point(1299, 851);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new System.Drawing.Size(171, 53);
            zeroButton.TabIndex = 1;
            zeroButton.Text = "Restart";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::CarolinaPowerMCCutter.Properties.Resources.carolinapower_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // currentLengthLabel
            // 
            this.currentLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentLengthLabel.AutoSize = true;
            this.currentLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLengthLabel.Location = new System.Drawing.Point(44, 311);
            this.currentLengthLabel.Name = "currentLengthLabel";
            this.currentLengthLabel.Size = new System.Drawing.Size(475, 73);
            this.currentLengthLabel.TabIndex = 2;
            this.currentLengthLabel.Text = "Current Length";
            this.currentLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentLengthNumber
            // 
            this.currentLengthNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentLengthNumber.AutoSize = true;
            this.currentLengthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLengthNumber.Location = new System.Drawing.Point(525, 311);
            this.currentLengthNumber.Name = "currentLengthNumber";
            this.currentLengthNumber.Size = new System.Drawing.Size(678, 73);
            this.currentLengthNumber.TabIndex = 3;
            this.currentLengthNumber.Text = "Get wire starting point\r\n";
            this.currentLengthNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // cutButton
            // 
            this.cutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cutButton.BackColor = System.Drawing.Color.Black;
            this.cutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cutButton.Location = new System.Drawing.Point(1476, 851);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(171, 53);
            this.cutButton.TabIndex = 4;
            this.cutButton.Text = "Cut";
            this.cutButton.UseVisualStyleBackColor = false;
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // countTextLabel
            // 
            this.countTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.countTextLabel.AutoSize = true;
            this.countTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTextLabel.Location = new System.Drawing.Point(44, 508);
            this.countTextLabel.Name = "countTextLabel";
            this.countTextLabel.Size = new System.Drawing.Size(209, 73);
            this.countTextLabel.TabIndex = 5;
            this.countTextLabel.Text = "Count";
            this.countTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countNumberLabel
            // 
            this.countNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.countNumberLabel.AutoSize = true;
            this.countNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countNumberLabel.Location = new System.Drawing.Point(340, 497);
            this.countNumberLabel.Name = "countNumberLabel";
            this.countNumberLabel.Size = new System.Drawing.Size(87, 73);
            this.countNumberLabel.TabIndex = 6;
            this.countNumberLabel.Text = " 0";
            this.countNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1659, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem,
            this.createdByToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpToolStripMenuItem.Text = "Support";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httpswwwkyleriglercomToolStripMenuItem});
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.emailToolStripMenuItem.Text = "Email ";
            // 
            // httpswwwkyleriglercomToolStripMenuItem
            // 
            this.httpswwwkyleriglercomToolStripMenuItem.Name = "httpswwwkyleriglercomToolStripMenuItem";
            this.httpswwwkyleriglercomToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.httpswwwkyleriglercomToolStripMenuItem.Text = "kyle.rigler@carolinapower.com";
            this.httpswwwkyleriglercomToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // createdByToolStripMenuItem
            // 
            this.createdByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kyleRiglerToolStripMenuItem});
            this.createdByToolStripMenuItem.Name = "createdByToolStripMenuItem";
            this.createdByToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.createdByToolStripMenuItem.Text = "Created by";
            // 
            // kyleRiglerToolStripMenuItem
            // 
            this.kyleRiglerToolStripMenuItem.Name = "kyleRiglerToolStripMenuItem";
            this.kyleRiglerToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.kyleRiglerToolStripMenuItem.Text = "Kyle Rigler";
            // 
            // MCCutterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1659, 916);
            this.Controls.Add(this.countNumberLabel);
            this.Controls.Add(this.countTextLabel);
            this.Controls.Add(this.cutButton);
            this.Controls.Add(this.currentLengthNumber);
            this.Controls.Add(this.currentLengthLabel);
            this.Controls.Add(zeroButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MCCutterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carolina Power MC Cutter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label currentLengthLabel;
        private System.Windows.Forms.Label currentLengthNumber;
        private System.Windows.Forms.Button cutButton;
        private System.Windows.Forms.Label countTextLabel;
        private System.Windows.Forms.Label countNumberLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem httpswwwkyleriglercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createdByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kyleRiglerToolStripMenuItem;
    }
}

