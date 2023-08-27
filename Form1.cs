using System;
using System.Windows.Forms;

namespace CarolinaPowerMCCutter
{
    public partial class MCCutterForm : Form
    {
        private CalibrationForm calibrationForm;
        private int totalNotchesTravelled = 0;
        public event Action<int> NotchesUpdated;
        public MCCutterForm(CalibrationForm calForm)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            Cursor.Show();
            this.MouseWheel += MCCutterForm_MouseWheel;
            this.calibrationForm = calForm;
            CalibrateEncoder();
            calibrationForm = new CalibrationForm(0);
            NotchesUpdated += calibrationForm.OnNotchesUpdated;
        }

        int feetValue = 0;
        double inchesValue = 0;
        int countNumber = 0;
        private const int InchesPerFoot = 12;

        private double EncoderNotchesPerInch = 0.0;

        private void zeroButton_Click(object sender, EventArgs e)
        {
            feetValue = 0;
            inchesValue = 0;
            countNumber = 0;

            countNumberLabel.Text = countNumber.ToString();
            UpdateCurrentLengthLabel();
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            countNumber++;
            countNumberLabel.Text = countNumber.ToString();

            feetValue = 0;
            inchesValue = 0;
            UpdateCurrentLengthLabel();
        }

        private void MCCutterForm_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta;

            if (delta != 0)
            {
                double notchChange = delta / 120.0;
                double inchesChange = notchChange / EncoderNotchesPerInch;

                if (inchesChange > 0)
                {
                    inchesValue += inchesChange;
                    if (inchesValue >= InchesPerFoot)
                    {
                        inchesValue -= InchesPerFoot;
                        feetValue++;
                    }
                }
                else if (inchesChange < 0)
                {
                    inchesValue += inchesChange;
                    if (inchesValue < 0)
                    {
                        inchesValue += InchesPerFoot;
                        feetValue--;
                        if (feetValue < 0)
                        {
                            feetValue = 0;
                            inchesValue = 0;
                        }
                    }
                }

                UpdateCurrentLengthLabel();
                calibrationForm.IncrementNotchesCounter();
            }
            // Notify the event subscribers with the live notches value
            NotchesUpdated?.Invoke(totalNotchesTravelled);
    }

        private void ToolStripMenuItem_Calibrate_Click(object sender, EventArgs e)
        {
            int initialNotches = calibrationForm.GetTotalNotchesCounter();

            using (CalibrationForm calibrationForm = new CalibrationForm(initialNotches))
            {
                DialogResult result = calibrationForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int enteredNotches = calibrationForm.GetEnteredNotchesValue();
                    totalNotchesTravelled = enteredNotches; // Update the totalNotchesTravelled
                    EncoderNotchesPerInch = totalNotchesTravelled; // Update the EncoderNotchesPerInch
                }
            }
        }

        private void UpdateCurrentLengthLabel()
        {
            currentLengthNumber.Text = $"{feetValue}' {inchesValue:F3}\"";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalibrateEncoder()
        {
            double knownDistanceInInches = 1.0;
            int totalNotchesTravelled = 5; // Set an initial value
            double calculatedNotchesPerInch = (double)totalNotchesTravelled / knownDistanceInInches;
            EncoderNotchesPerInch = calculatedNotchesPerInch;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string emailAddress = "kyle.rigler@carolinapower.com";
            string subject = "MC Cutter help";

            string mailtoUrl = $"mailto:{emailAddress}?subject={subject}";
            System.Diagnostics.Process.Start(mailtoUrl);
        }
    }
}
