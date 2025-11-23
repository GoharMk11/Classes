// 2 չափանի զանգված - Տրված է n×m չափանի ամբողջ թվերի մատրիցա։ Գրել ծրագիր,
// որը տրված i և j ինդեքսներով էլեմենտի համար կգտնի նրա բոլոր հարևաններին
// (մինչև 8 հարևան՝ վերև, ներքև, ձախ, աջ, և 4 անկյունայիններ) և կհաշվի նրանց գումարը.

using System;
namespace Lesson_3
{
    class Ex5
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number for n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for m");
            int m = int.Parse(Console.ReadLine());
            if (n<=0 || m<=0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }
            int[,] matrix = new int[n, m];
            Random rnd = new Random();
            for (int row=0;row<n;row++)
            {
                for (int col=0;col<m;col++)
                {
                    matrix[row, col] = rnd.Next(1, 100);
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Please Enter row index i");
            int i = int.Parse(Console.ReadLine());
            if  (i<0 || i>=n)
            {
                Console.WriteLine("Please enter a valid index for i");
                return;
            }
            Console.WriteLine("Please Enter column index j");
            int j= int.Parse(Console.ReadLine());
            if (j < 0 || j >= m)
            {
                Console.WriteLine("Please enter a valid index for j");
                return;
            }
            int sum = FindSum(matrix, i, j);
            Console.WriteLine($"The sum is {sum}");

        }
        static int FindSum(int[,] matrix, int i, int j)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;
            for (int r=i-1;r<=i+1; r++)
            {
                for (int c = j - 1; c <= j + 1; c++)
                {
                    if (c < 0 || c >= cols || r < 0 || r >= rows)
                    {
                        continue;
                    }
                    if (c ==j && r==i)
                    {
                        continue;
                    }
                    sum += matrix[r, c];
                }
            }
            return sum;
        }

    }
}
