using System;
using System.Collections.Generic;
using System.Linq;

namespace HaltingProblem.Core
{
    public static class HaltingProblem
    {
        private static readonly Random RandomGenerator = new Random();

        public static List<Result> GetResults(IEnumerable<int> tolerances, List<int> thresholds, int numberOfExperiments)
        {
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

            foreach (var applicant in applicants.Skip(threshold))
            {
                if (applicant > bestInExploration * (1 - tolerance / 100))
                {
                    return applicant;
                }
            }

            return applicants.Last();
        }
    }
}