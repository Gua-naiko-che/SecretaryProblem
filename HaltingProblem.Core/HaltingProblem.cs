using System;
using System.Collections.Generic;
using System.Linq;

namespace HaltingProblem.Core
{
    public static class HaltingProblem
    {
        private static readonly Random RandomGenerator = new Random();
        private const int NumberOfExperiments = 10000;

        public static List<Result> GetResults()
        {
            var tolerances = Enumerable.Range(0, 100);
            var thresholds = Enumerable.Range(1, 37).ToList();

            var allCombinations = from tolerance in tolerances
                                  from threshold in thresholds
                                  select new { tolerance, threshold };

            var results = allCombinations
                .Select(combination =>
                {
                    var a = Enumerable
                        .Repeat(0, NumberOfExperiments)
                        .Select(x => GetBestSecretaryWithThreshold(combination.tolerance, combination.threshold))
                        .ToList();

                    return new Result
                    {
                        Tolerance = combination.tolerance,
                        Threshold = combination.threshold,
                        BestSecretaryPercentage = (a.Count(s => s == 100) / (double)NumberOfExperiments),
                        AverageQuality = (a.Average())
                    };
                })
                .ToList();

            return results;
        }

        private static int GetBestSecretaryWithThreshold(double tolerance, int threshold)
        {
            var secretaries = Enumerable.Range(1, 100).ToArray();
            RandomGenerator.Shuffle(secretaries);
            var bestInExploration = secretaries.Take(threshold).Max();

            foreach (var secretary in secretaries.Skip(threshold))
            {
                if (secretary > bestInExploration * (1 - tolerance / 100))
                {
                    return secretary;
                }
            }

            return secretaries.Last();
        }
    }

    public class Result
    {
        public int Tolerance { get; set; }
        public double BestSecretaryPercentage { get; set; }
        public double AverageQuality { get; set; }
        public int Threshold { get; set; }
    }
}