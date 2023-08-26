


using System;
using System.Windows.Forms;

namespace CarolinaPowerMCCutter
{
    public partial class MCCutterForm : Form
    {
        public MCCutterForm()
        {
            InitializeComponent();
            this.MouseWheel += MCCutterForm_MouseWheel;
        }

        int feetValue = 0;
        double inchesValue = 0;
        int countNumber = 0;
        private const int InchesPerFoot = 12;
        private const double InchesPerNotch = 0.125;
        private const double EncoderNotchesPerInch = 1.0 / InchesPerNotch; // Notches per inch

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
    }
}






