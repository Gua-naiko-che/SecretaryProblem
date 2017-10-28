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
            //var myModel = new PlotModel { Title = "Example 1" };

            //var bestPercentageSeries = new LineSeries { Title = "Best percentage" };
            //bestPercentageSeries.Points.AddRange(results.Select(r => new DataPoint(r.Tolerance, r.BestSecretaryPercentage * 100)));

            //var averageSeries = new LineSeries { Title = "Average" };
            //averageSeries.Points.AddRange(results.Select(r => new DataPoint(r.Tolerance, r.AverageQuality)));

            //myModel.Series.Add(bestPercentageSeries);
            //myModel.Series.Add(averageSeries);
            //plotView1.Model = myModel;

            var bestPercentage = 0.0;
            var toleranceForBestPercentage = 0;
            var thresholdForBestPercentage = 0;
            foreach (var result in results)
            {
                if (result.BestSecretaryPercentage > bestPercentage)
                {
                    bestPercentage = result.BestSecretaryPercentage;
                    toleranceForBestPercentage = result.Tolerance;
                    thresholdForBestPercentage = result.Threshold;
                }
            }

            var bestAverage = 0.0;
            var toleranceForBestAverage = 0;
            var thresholdForBestAverage = 0;
            foreach (var result in results)
            {
                if (result.AverageQuality > bestAverage)
                {
                    bestAverage = result.AverageQuality;
                    toleranceForBestAverage = result.Tolerance;
                    thresholdForBestAverage = result.Threshold;
                }
            }
        }
    }
}