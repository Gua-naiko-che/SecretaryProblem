﻿using System.Collections.Generic;
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
            myModel.Axes.Add(new LinearAxis {Title = "Tolerance", Position = AxisPosition.Bottom});

            var bestPercentageSeries = new LineSeries { Title = "Best percentage" };
            bestPercentageSeries.Points.AddRange(results.Select(r => new DataPoint(r.Tolerance, r.BestApplicantPercentage * 100)));

            var averageSeries = new LineSeries { Title = "Average" };
            averageSeries.Points.AddRange(results.Select(r => new DataPoint(r.Tolerance, r.AverageQuality)));

            myModel.Series.Add(bestPercentageSeries);
            myModel.Series.Add(averageSeries);
            plotView1.Model = myModel;

            var bestPercentage = 0.0;
            var toleranceForBestPercentage = 0;
            var thresholdForBestPercentage = 0;
            foreach (var result in results)
            {
                if (result.BestApplicantPercentage > bestPercentage)
                {
                    bestPercentage = result.BestApplicantPercentage;
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