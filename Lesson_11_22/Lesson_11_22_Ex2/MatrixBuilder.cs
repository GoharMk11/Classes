using System;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

/*

Ask: “Enter number of rows (n):”

Ask: “Enter number of columns (m):”

Validate:

if user types not-a - number → ask again

if n <= 0 or m <= 0 → ask again*/

namespace MatrixApp
{
    public class MatrixBuilder
    {
        public static int[,] CreateMatrix()
        {
            Console.WriteLine("Enter number of rows (n)");

            if (!int.TryParse(Console.ReadLine(), out int n)
                {
                    Console.WriteLine("Plese enter a number!")
                }
            Console.WriteLine("Enter number of columns (m)");
        }
    }
}
