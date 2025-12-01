using System;
using System.Linq;

namespace StudentApp
    {
    static class StudentService
    {
        public static double AvgScore(int[] scores)
        {
            if (scores == null || scores.Length == 0)
                throw new ArgumentException("Scores can't be empty.", nameof(scores));

            if (scores.Any(s => s <= 0))
                throw new ArgumentException("All scores must be positive.", nameof(scores));

            double sum = scores.Sum();
            return sum / scores.Length;

        }
    }
}
