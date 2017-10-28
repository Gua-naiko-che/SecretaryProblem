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
                        BestApplicantPercentage = (result.Count(s => s == 100) / (double)numberOfExperiments),
                        AverageQuality = (result.Average())
                    };
                })
                .ToList();

            return results;
        }

        private static int GetBestApplicantyWithThreshold(double tolerance, int threshold)
        {
            var applicants = Enumerable.Range(1, 100).ToArray();
            RandomGenerator.Shuffle(applicants);
            var bestInExploration = applicants.Take(threshold).Max();
            var bestWithTolerance = bestInExploration * (1 - tolerance / 100.0);

            foreach (var applicant in applicants.Skip(threshold))
            {
                if (applicant > bestWithTolerance)
                {
                    return applicant;
                }
            }

            return applicants.Last();
        }
    }
}