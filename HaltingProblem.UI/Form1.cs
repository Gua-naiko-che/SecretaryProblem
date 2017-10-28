using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HaltingProblem.Core;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace HaltingProblem.UI
{
    public partial class Form1 : Form
    {
        public Form1(IReadOnlyCollection<Result> results)
        {
            InitializeComponent();
            var myModel = new PlotModel { Title = "Best % and average quality in function of tolerance" };
            myModel.Axes.Add(new LinearAxis { Title = "Tolerance", Position = AxisPosition.Bottom });

            var bestPercentageSeries = new LineSeries { Title = "Best percentage" };
            bestPercentageSeries.Points.AddRange(results.Select(r => new DataPoint(r.Tolerance, r.BestApplicantPercentage * 100)));

            var averageSeries = new LineSeries { Title = "Average" };
            averageSeries.Points.AddRange(results.Select(r => new DataPoint(r.Tolerance, r.AverageQuality)));

            myModel.Series.Add(bestPercentageSeries);
            myModel.Series.Add(averageSeries);
            plotView1.Model = myModel;
        }
    }
}