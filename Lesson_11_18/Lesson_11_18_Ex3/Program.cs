// 2 չափանի զանգված - Տրված nxn երկարության զանգվածում գտնել հիմնական անկյունագծի գումարը և
// oժանդակ անկյունագծի գումարները, որից հետո գտնել այդ գումարների հարաբերությունը։

using System;
namespace Lesson_3
{
    class Ex3
    {
        static void Main()
        {
            Console.WriteLine("PLease enter a number");
            int n = int.Parse(Console.ReadLine());
            if (n<=0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }
            int[,] matrix = new int[n, n];
            Random rdm = new Random();
            for (int row = 0; row < n; row++) 
            {               
                for (int col = 0; col < n; col++) 
                {
                    matrix[row, col] = rdm.Next(1, 100);
                    Console.Write($"{matrix[row, col]}  ");
                }
                Console.WriteLine();
            }
            int mainsum;
            int secsum;
            FindDiagSums(matrix,out mainsum,out secsum);
            Console.WriteLine($"Sum of the main diagonal is {mainsum}");
            Console.WriteLine($"Sum of the secondary diagonal is {secsum}");
            if (secsum == 0)
            {
                Console.WriteLine("Cannot calculate the ratio: secondary diagonal sum is 0");
                return;
            }
                double ratio = (double)mainsum / secsum;
                Console.WriteLine($"Ratio is {ratio}");
            

        }
        static void FindDiagSums(int[,] matrix,out int mainsum,out int secsum)
        {
           
            int n = matrix.GetLength(0);
            mainsum = 0;
            secsum = 0;
            for (int i = 0; i < n; i++)
            {
                mainsum += matrix[i, i];
            }
            for (int i = 0; i < n;i++)
            {
                secsum += matrix[n-1-i,i];
            }
            
        }
    }
}