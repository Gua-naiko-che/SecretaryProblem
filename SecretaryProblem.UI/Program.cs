using System;
using System.Windows.Forms;

namespace SecretaryProblem.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var results = Core.HaltingProblem.GetResults(0, 100, 37, 37, 10000);

            Application.Run(new Form1(results));
        }
    }
}