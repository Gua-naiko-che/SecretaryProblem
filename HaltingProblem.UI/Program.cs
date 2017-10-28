using System;
using System.Linq;
using System.Windows.Forms;

namespace HaltingProblem.UI
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

            var results = HaltingProblem.Core.HaltingProblem.GetResults(Enumerable.Range(0, 100), Enumerable.Range(37, 1).ToList(), 1000);

            Application.Run(new Form1(results));
        }
    }
}