using System;
using System.Windows.Forms;

namespace CarolinaPowerMCCutter
{
    public partial class CalibrationForm : Form
    {
        public int enteredNotchesValue = 5;
        public int notchCounter = 0;

        public CalibrationForm()
        {
            InitializeComponent();
            totalNotchesLabel.Text = "0"; // Initialize the label

            // Subscribe to the MouseWheel event of the form
            this.MouseWheel += CalibrationForm_MouseWheel;
        }

        private void CalibrationForm_MouseWheel(object sender, MouseEventArgs e)
        {
            // Check if the CTRL key is pressed while scrolling
            if (Control.ModifierKeys == Keys.Control)
            {
                // Increment or decrement notchCounter based on the scrolling direction
                int delta = e.Delta > 0 ? 1 : -1;
                UpdateNotchCounter(delta);
            }
        }

        public void UpdateNotchCounter(int delta)
        {
            notchCounter += delta;
            totalNotchesLabel.Text = notchCounter.ToString();
        }

        public int GetEnteredNotchesValue()
        {
            return enteredNotchesValue;
        }

        public void OnNotchesUpdated(int notches)
        {
            totalNotchesLabel.Text = notches.ToString();
        }

        public void okButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(calibrationFormTextBox.Text, out int enteredValue))
            {
                enteredNotchesValue = enteredValue;
            }

            this.DialogResult = DialogResult.OK;
        }

        public void backToMainButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
