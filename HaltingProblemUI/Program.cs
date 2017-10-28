using System;
using System.Windows.Forms;

namespace HaltingProblemUI
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

            var results = HaltingProblem.Core.HaltingProblem.GetResults();

            Application.Run(new Form1(results));
        }
    }
}