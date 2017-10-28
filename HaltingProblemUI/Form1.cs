using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HaltingProblem.Core;
using OxyPlot;
using OxyPlot.Series;

namespace HaltingProblemUI
{
    public partial class Form1 : Form
    {
        public Form1(List<Result> results)
        {
            InitializeComponent();
            var myModel = new PlotModel { Title = "Example 1" };

            var bestPercentage = new LineSeries();
            bestPercentage.Points.AddRange(results.Select(r => new DataPoint(r.Tolerance, r.BestSecretaryPercentage * 100)));
            bestPercentage.Title = "Best percentage";

            var average = new LineSeries();
            average.Points.AddRange(results.Select(r => new DataPoint(r.Tolerance, r.AverageQuality)));
            average.Title = "Average";

            myModel.Series.Add(bestPercentage);
            myModel.Series.Add(average);
            plotView1.Model = myModel;
        }
    }
}