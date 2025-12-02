using System;

namespace MatrixApp
{
    public class MatrixBuilder
    {
        public static int[,] CreateMatrix()
        {
            int n=ReadInt.ReadPositiveInt("Enter number of rows (n): ");
            int m=ReadInt.ReadPositiveInt("Enter number of columns (m): ");
            int[,] matrix = new int[n, m];
            Random rnd = new Random();
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<m;j++)
                {
                    matrix[i,j]= rnd.Next(0, 10);
                }
            }

            return matrix;
        }
    }
}
