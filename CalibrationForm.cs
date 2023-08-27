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

        private void okButton_Click(object sender, EventArgs e)
        {
            // Parse and store the total notches value from the label
            if (int.TryParse(totalNotchesLabel.Text, out totalNotches))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                // Display an error message if the parsing fails
                MessageBox.Show("Invalid total notches value.");
            }
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            // Close the CalibrationForm without updating the EncoderNotchesPerInch
            this.DialogResult = DialogResult.Cancel;
        }
    }
}