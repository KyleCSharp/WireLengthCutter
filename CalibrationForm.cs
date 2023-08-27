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
        private int initialNotches = 0; // Store the initial notch count
       

        public CalibrationForm(int initialNotches)
        {
            InitializeComponent();
            this.initialNotches = initialNotches;
        }

      

        public int GetInitialNotches()
        {
            return initialNotches;
        }
        public int GetNotchChange()
        {
            // Return the calculated notch change
            return totalNotches - initialNotches;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Close the CalibrationForm
            this.DialogResult = DialogResult.OK;
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            // Close the CalibrationForm without updating the notch change
            this.DialogResult = DialogResult.Cancel;
        }

        // Handle encoder movement and update totalNotches
        public void UpdateNotches(int currentNotches)
        {
            totalNotches = currentNotches;
            totalNotchesLabel.Text = totalNotches.ToString();
        }
    }
}