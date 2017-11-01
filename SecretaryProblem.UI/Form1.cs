using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using SecretaryProblem.Core;

namespace SecretaryProblem.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetLabels();
        }

        private void ToggleVariableParameter(object sender, EventArgs e)
        {
            SetLabels();
        }

        private void SetLabels()
        {
            if (rbThreshold.Checked)
            {
                lblFixedParameter.Text = "Tolerance";
                lblMinVariableParameter.Text = "Min threshold";
                lblMaxVariableParameter.Text = "Max threshold";
            }
            else
            {
                lblFixedParameter.Text = "Threshold";
                lblMinVariableParameter.Text = "Min tolerance";
                lblMaxVariableParameter.Text = "Max tolerance";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minTolerance = rbThreshold.Checked ? (int)nudFixedParameter.Value : (int)nudMinVariableParameter.Value;
            int maxTolerance = rbThreshold.Checked ? (int)nudFixedParameter.Value : (int)nudMaxVariableParameter.Value;
            int minThreshold = rbThreshold.Checked ? (int)nudMinVariableParameter.Value : (int)nudFixedParameter.Value;
            int maxThreshold = rbThreshold.Checked ? (int)nudMaxVariableParameter.Value : (int)nudFixedParameter.Value;
            int numberOfExperiments = (int)nudNbOfExperiments.Value;

            var errors = CheckInput(minTolerance, maxTolerance, minThreshold, maxThreshold);

            if (errors.Any())
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors));
                return;
            }

            CalculateAndPrintResults(minTolerance, maxTolerance, minThreshold, maxThreshold, numberOfExperiments);
        }

        private void CalculateAndPrintResults(int minTolerance, int maxTolerance, int minThreshold, int maxThreshold, int numberOfExperiments)
        {
            IReadOnlyCollection<Result> results
                            = HaltingProblem.GetResults(minTolerance, maxTolerance, minThreshold, maxThreshold, numberOfExperiments);

            string variableParameter = rbThreshold.Checked ? "threshold" : "tolerance";
            var myModel = new PlotModel { Title = $"Best % and average quality in function of {variableParameter}" };
            myModel.Axes.Add(new LinearAxis { Title = "Tolerance", Position = AxisPosition.Bottom });

            var bestPercentageSeries = new LineSeries { Title = "Best percentage" };
            bestPercentageSeries.Points.AddRange(rbThreshold.Checked
                ? results.Select(r => new DataPoint(r.Threshold, r.BestApplicantPercentage))
                : results.Select(r => new DataPoint(r.Tolerance, r.BestApplicantPercentage)));

            var averageSeries = new LineSeries { Title = "Average" };
            averageSeries.Points.AddRange(rbThreshold.Checked
                ? results.Select(r => new DataPoint(r.Threshold, r.AverageQuality))
                : results.Select(r => new DataPoint(r.Tolerance, r.AverageQuality)));

            myModel.Series.Add(bestPercentageSeries);
            myModel.Series.Add(averageSeries);
            plotView1.Model = myModel;
        }

        private static List<string> CheckInput(int minTolerance, int maxTolerance, int minThreshold, int maxThreshold)
        {
            var errors = new List<string>();
            if (maxTolerance < minTolerance)
            {
                errors.Add("Maximum tolerance should not be less that minimum tolerance");
            }
            if (maxThreshold < minThreshold)
            {
                errors.Add("Maximum threshold should not be less that minimum threshold");
            }
            if (minThreshold == 0)
            {
                errors.Add("The threshold should be at least 1");
            }

            return errors;
        }
    }
}