using System;
using System.Windows.Forms;

namespace CarolinaPowerMCCutter
{
    public partial class CalibrationForm : Form
    {
        public int totalNotchesCounter = 0;
        
        public int enteredNotchesValue = 5;

        public CalibrationForm()
        {
            InitializeComponent();
            totalNotchesLabel.Text = "0"; // Initialize the label
        }


        public int TotalNotchesTravelled
        {
            get { return totalNotchesCounter; }
        }
        public int GetTotalNotchesCounter()
        {
            return totalNotchesCounter;
        }

        public int GetEnteredNotchesValue()
        {
            return enteredNotchesValue;
        }
        public void OnNotchesUpdated(int notches)
        {
            totalNotchesLabel.Text = notches.ToString();
        }
        public void IncrementNotchesCounter()
        {
            totalNotchesCounter++;
            totalNotchesLabel.Text = totalNotchesCounter.ToString();
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
