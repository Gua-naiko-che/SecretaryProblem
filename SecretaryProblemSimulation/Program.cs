using System;
using System.Linq;

namespace SecretaryProblemSimulation
{
    public class Program
    {
        private static readonly Random RandomGenerator = new Random();
        private const int NumberOfExperiments = 10000;

        private static void Main()
        {
            var tolerances = Enumerable.Range(0, 100);

            var results = tolerances
                .Select(t =>
                {
                    var a = Enumerable
                        .Repeat(0, NumberOfExperiments)
                        .Select(x => GetBestSecretaryWithThreshold(t, 37))
                        .ToList();

                    return new
                    {
                        Tolerance = t,
                        BestSecretaryPercentage = (a.Count(s => s == 100) / (double)NumberOfExperiments),
                        AverageQuality = (a.Average())
                    };
                })
                .ToList();

            var bestPercentage = 0.0;
            var toleranceForBestPercentage = 0;
            foreach (var result in results)
            {
                if (result.BestSecretaryPercentage > bestPercentage)
                {
                    bestPercentage = result.BestSecretaryPercentage;
                    toleranceForBestPercentage = result.Tolerance;
                }
            }

            var bestAverage = 0.0;
            var toleranceForBestAverage = 0;
            foreach (var result in results)
            {
                if (result.AverageQuality > bestAverage)
                {
                    bestAverage = result.AverageQuality;
                    toleranceForBestAverage = result.Tolerance;
                }
            }

            Console.ReadKey();
        }

        private static int GetBestSecretaryWithThreshold(double tolerance, int threshold)
        {
            var secretaries = Enumerable.Range(1, 100).ToArray();
            RandomGenerator.Shuffle(secretaries);
            var bestInExploration = secretaries.Take(threshold).Max();

            foreach (var secretary in secretaries.Skip(threshold))
            {
                if (secretary > bestInExploration * (1 - tolerance))
                {
                    return secretary;
                }
            }

            return secretaries.Last();
        }
    }
}