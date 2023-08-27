﻿using System;
using System.Windows.Forms;

namespace CarolinaPowerMCCutter
{
    public partial class CalibrationForm : Form
    {
        private int totalNotchesCounter = 0;
        private int initialNotches = 0;
        private int enteredNotchesValue = 5; // Default value

        public CalibrationForm(int initialNotches)
        {
            InitializeComponent();
            this.initialNotches = initialNotches;
        }

        public void IncrementNotchesCounter()
        {
            totalNotchesCounter++;
            totalNotchesLabel.Text = totalNotchesCounter.ToString();
        }

        public int GetTotalNotchesCounter()
        {
            return totalNotchesCounter;
        }

        public int GetEnteredNotchesValue()
        {
            return enteredNotchesValue;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(calibrationFormTextBox.Text, out int enteredValue))
            {
                enteredNotchesValue = enteredValue;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
