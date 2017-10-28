namespace HaltingProblem.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var minTolerance = GetInputParameter("Enter the minimum tolerance to try (default if empty = 0): ", 0);
            var maxTolerance = GetInputParameter("Enter the maximum tolerance to try (default if empty = 100): ", 100);
            var minThreshold = GetInputParameter("Enter the minimum threshold to try (default if empty = 1): ", 1);
            var maxThreshold = GetInputParameter("Enter the maximum threshold to try (default if empty = 37): ", 37);
            var numberOfExperiments = GetInputParameter("Enter the number of experiments for each simulation (default if empty = 10000): ", 10000);

            System.Console.WriteLine();
            System.Console.WriteLine("Calculating...");
            System.Console.WriteLine();

            var results = Core.HaltingProblem.GetResults(minTolerance, maxTolerance, minThreshold, maxThreshold, numberOfExperiments);

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
            System.Console.WriteLine($"The best percentage of getting the single best applicant is {bestPercentage}");
            System.Console.WriteLine($"It is obtained with a tolerance of {toleranceForBestPercentage} and threshold of {thresholdForBestPercentage}");
            System.Console.WriteLine();

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

            System.Console.WriteLine($"The best average quality is {bestAverage}");
            System.Console.WriteLine($"It is obtained with a tolerance of {toleranceForBestAverage} and threshold of {thresholdForBestAverage}");
            System.Console.WriteLine();

            System.Console.WriteLine("Press any key to end program");
            System.Console.ReadKey();
        }

        private static int GetInputParameter(string message, int defaultValue)
        {
            System.Console.Write(message);

            int result;
            if (int.TryParse(System.Console.ReadLine(), out result))
            {
                return result;
            }

            return defaultValue;
        }
    }
}