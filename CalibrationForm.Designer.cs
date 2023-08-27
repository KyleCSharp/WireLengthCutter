namespace CarolinaPowerMCCutter
{
    partial class CalibrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalibrationForm));
            this.button1 = new System.Windows.Forms.Button();
            this.totalNotchesLabel = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.calibrationFormTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.okButton_Click);
            // 
            // totalNotchesLabel
            // 
            this.totalNotchesLabel.AutoSize = true;
            this.totalNotchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNotchesLabel.Location = new System.Drawing.Point(354, 93);
            this.totalNotchesLabel.Name = "totalNotchesLabel";
            this.totalNotchesLabel.Size = new System.Drawing.Size(68, 73);
            this.totalNotchesLabel.TabIndex = 2;
            this.totalNotchesLabel.Text = "0";
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(393, 377);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(66, 37);
            this.Backbutton.TabIndex = 3;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.backToMainButton_Click);
            // 
            // calibrationFormTextBox
            // 
            this.calibrationFormTextBox.Location = new System.Drawing.Point(321, 351);
            this.calibrationFormTextBox.Name = "calibrationFormTextBox";
            this.calibrationFormTextBox.Size = new System.Drawing.Size(142, 20);
            this.calibrationFormTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(651, 144);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calibrationFormTextBox);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.totalNotchesLabel);
            this.Controls.Add(this.button1);
            this.Name = "CalibrationForm";
            this.Text = "CalibrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totalNotchesLabel;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.TextBox calibrationFormTextBox;
        private System.Windows.Forms.Label label2;
    }
}