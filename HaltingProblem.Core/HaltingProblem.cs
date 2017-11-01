using System;
using System.Collections.Generic;
using System.Linq;

namespace HaltingProblem.Core
{
    public static class HaltingProblem
    {
        private static readonly Random RandomGenerator = new Random();

        public static List<Result> GetResults(int minTolerance, int maxTolerance, int minThreshold, int maxThreshold, int numberOfExperiments)
        {
            var tolerances = Enumerable.Range(minTolerance, maxTolerance - minTolerance + 1);
            var thresholds = Enumerable.Range(minThreshold, maxThreshold - minThreshold + 1).ToList();
            var allCombinations = from tolerance in tolerances
                                  from threshold in thresholds
                                  select new { tolerance, threshold };

            var results = allCombinations
                .Select(combination =>
                {
                    var result = Enumerable
                        .Repeat(0, numberOfExperiments)
                        .Select(x => GetBestApplicantyWithThreshold(combination.tolerance, combination.threshold))
                        .ToList();

                    return new Result
                    {
                        Tolerance = combination.tolerance,
                        Threshold = combination.threshold,
                        BestApplicantPercentage = (result.Count(s => s.Item2) / (double)numberOfExperiments),
                        AverageQuality = (result.Select(r => r.Item1).Average())
                    };
                })
                .ToList();

            return results;
        }

        private static Tuple<double, bool> GetBestApplicantyWithThreshold(double tolerance, int threshold)
        {
            var applicants = Enumerable.Repeat(1, 100).Select(x => RandomGenerator.NextDouble()).ToList();
            var bestInExploration = applicants.Take(threshold).Max();
            var bestWithTolerance = bestInExploration * (1 - tolerance / 100.0);

            foreach (var applicant in applicants.Skip(threshold))
            {
                if (applicant > bestWithTolerance)
                {
                    return new Tuple<double, bool>(applicant, applicant == applicants.Max());
                }
            }

            return new Tuple<double, bool>(applicants.Last(), false);
        }
    }
}