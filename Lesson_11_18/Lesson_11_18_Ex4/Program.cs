// Տրված է n×n չափանի ամբողջ թվերի մատրիցա։ Գտնել և վերադարձնել օժանդակ անկյունագծի
// (secondary diagonal) տակ գտնվող բոլոր էլեմենտների գումարը։

using System;
namespace Lesson_3
{
    class Ex4
    {
        static void Main()
        {
            Console.WriteLine("PLease enter a number");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("PLease enter a positive number");
                return;
            }
            int[,] matrix = new int[n, n];
            Random rnd = new Random();
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rnd.Next(1, 100);
                    Console.Write($"{matrix[row, col]}\t");
                }
                Console.WriteLine();
            }
            int sum = FindSum(matrix);
            Console.WriteLine($"The sum is {sum}");
        }
        static int FindSum(int[,] matrix)
        {
            int sum = 0;
            int n = matrix.GetLength(0);
            for (int row=0;row<n;row++)
            {
                for (int col=0;col<n;col++)
                {
                    if (row + col > n - 1)
                    {
                        sum += matrix[row, col];
                    }
                }
            }
            return sum;
        }

    }
}
