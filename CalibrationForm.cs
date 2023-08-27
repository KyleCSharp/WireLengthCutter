using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarolinaPowerMCCutter
{
    public partial class CalibrationForm : Form
    {
        private int totalNotches = 0;
        public CalibrationForm()
        {
            InitializeComponent();
        }
        public void UpdateTotalNotchesLabel(int value)
        {
            totalNotchesLabel.Text = value.ToString();
        }
        public int GetCalibratedNotchesPerInch()
        {
            return totalNotches;
        }

        public void UpdateTotalNotches(int notchChange)
        {
            totalNotches += notchChange;
            totalNotchesLabel.Text = totalNotches.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Parse and store the total notches value from the label
            if (int.TryParse(totalNotchesLabel.Text, out totalNotches))
            {
                MessageBox.Show($"Total Notches: {totalNotches}", "Debug Info");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid total notches value.", "Error");
            }
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            // Close the CalibrationForm without updating the EncoderNotchesPerInch
            this.DialogResult = DialogResult.Cancel;
        }
    }
}