
using System;
using System.Windows.Forms;

namespace CarolinaPowerMCCutter
{
    public partial class MCCutterForm : Form
    {
        private CalibrationForm calibrationForm;
        public MCCutterForm(CalibrationForm calForm)
        {
            InitializeComponent();
            // Make the form fullscreen right from the constructor
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            Cursor.Show();
            this.MouseWheel += MCCutterForm_MouseWheel;
            this.calibrationForm = calForm;
            // Calibrate the encoder by measuring actual EncoderNotchesPerInch value
            CalibrateEncoder();
        }

        int feetValue = 0;
        double inchesValue = 0;
        int countNumber = 0;
        private const int InchesPerFoot = 12;
        private const double InchesPerNotch = 0.125;
        private double EncoderNotchesPerInch = 0.0; // Update with calibrated value

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
                double notchChange = delta / 120.0; // Normalize delta to encoder notches
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
                calibrationForm.UpdateTotalNotchesLabel((int)Math.Abs(notchChange)); // Pass the updated notch count
            }
           
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string emailAddress = "kyle.rigler@carolinapower.com";
            string subject = "MC Cutter help";

            // Generate the mailto URL
            string mailtoUrl = $"mailto:{emailAddress}?subject={subject}";
            System.Diagnostics.Process.Start(mailtoUrl);
        }

        private void UpdateCurrentLengthLabel()
        {
            currentLengthNumber.Text = $"{feetValue}' {inchesValue:F3}\"";
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.MouseWheel -= MCCutterForm_MouseWheel;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ToolStripMenuItem_Calibrate_Click(object sender, EventArgs e)
        {
            // Create and show the CalibrationForm
            using (CalibrationForm calibrationForm = new CalibrationForm())
            {
                DialogResult result = calibrationForm.ShowDialog();

                // Check if the user clicked OK or Back
                if (result == DialogResult.OK)
                {
                    EncoderNotchesPerInch = calibrationForm.GetCalibratedNotchesPerInch();
                }
                // Handle Back button scenario
                else if (result == DialogResult.Cancel)
                {
                    // No action needed, user clicked Back
                }
            }
        }
        private void CalibrateEncoder()
        {
            // Measure the encoder's actual resolution and update EncoderNotchesPerInch
            // For example: EncoderNotchesPerInch = measuredValue;
            // Measure the encoder's actual resolution and update EncoderNotchesPerInch
            double knownDistanceInInches = 1.0; // For example, you rotated the encoder 1 inch
            int totalNotchesTravelled = 120;    // For example, the encoder reported 120 notches

            double calculatedNotchesPerInch = (double)totalNotchesTravelled / knownDistanceInInches;
            EncoderNotchesPerInch = calculatedNotchesPerInch;
            // You need to replace the example value above with the actual measured value
            // based on your calibration process.
        }
    }
}


//using System;
//using System.Windows.Forms;

//namespace CarolinaPowerMCCutter
//{
//    public partial class MCCutterForm : Form
//    {
//        public MCCutterForm()
//        {

//            InitializeComponent();
//            // Make the form fullscreen right from the constructor
//            this.WindowState = FormWindowState.Maximized;
//            this.FormBorderStyle = FormBorderStyle.None;
//            this.StartPosition = FormStartPosition.CenterScreen;
//            Cursor.Show();
//            this.MouseWheel += MCCutterForm_MouseWheel;
//        }
//        int feetValue = 0;
//        double inchesValue = 0;
//        int countNumber = 0;
//        private const int InchesPerFoot = 12;
//        private const double InchesPerNotch = 0.125;
//        private const double EncoderNotchesPerInch = 1.0 / InchesPerNotch; // Notches per inch

//        private void zeroButton_Click(object sender, EventArgs e)
//        {
//            feetValue = 0;
//            inchesValue = 0;
//            countNumber = 0;

//            countNumberLabel.Text = countNumber.ToString();
//            UpdateCurrentLengthLabel();
//        }

//        private void cutButton_Click(object sender, EventArgs e)
//        {
//            countNumber++;
//            countNumberLabel.Text = countNumber.ToString();

//            feetValue = 0;
//            inchesValue = 0;
//            UpdateCurrentLengthLabel();
//        }

//        private void MCCutterForm_MouseWheel(object sender, MouseEventArgs e)
//        {
//            int delta = e.Delta;

//            if (delta != 0)
//            {
//                double notchChange = delta / 120.0; // Normalize delta to encoder notches
//                double inchesChange = notchChange / EncoderNotchesPerInch;

//                if (inchesChange > 0)
//                {
//                    inchesValue += inchesChange;
//                    if (inchesValue >= InchesPerFoot)
//                    {
//                        inchesValue -= InchesPerFoot;
//                        feetValue++;
//                    }
//                }
//                else if (inchesChange < 0)
//                {
//                    inchesValue += inchesChange;
//                    if (inchesValue < 0)
//                    {
//                        inchesValue += InchesPerFoot;
//                        feetValue--;
//                        if (feetValue < 0)
//                        {
//                            feetValue = 0;
//                            inchesValue = 0;
//                        }
//                    }
//                }

//                UpdateCurrentLengthLabel();
//            }
//        }

//        private void ToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            string emailAddress = "kyle.rigler@carolinapower.com";
//            string subject = "MC Cutter help";

//            // Generate the mailto URL
//            string mailtoUrl = $"mailto:{emailAddress}?subject={subject}";
//            System.Diagnostics.Process.Start(mailtoUrl);
//        }

//        private void UpdateCurrentLengthLabel()
//        {
//            currentLengthNumber.Text = $"{feetValue}' {inchesValue:F3}\"";
//        }

//        protected override void OnClosed(EventArgs e)
//        {
//            base.OnClosed(e);
//            this.MouseWheel -= MCCutterForm_MouseWheel;
//        }

//        private void exitButton_Click(object sender, EventArgs e)
//        {

//            this.Close();

//        }
//    }
//}






