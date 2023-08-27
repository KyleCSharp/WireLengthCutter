using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarolinaPowerMCCutter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CalibrationForm calibrationForm = new CalibrationForm();
            MCCutterForm mccutterForm = new MCCutterForm(calibrationForm);

            Application.Run(mccutterForm);
        }
    }
}
