using System;
using System.Globalization;
using System.Text;

namespace MatrixApp
{
    public class MatrixPrinter
    {
        public static void Print(int[,] matrix, string title)
        {
            StringBuilder sb = new StringBuilder();
            if (!String.IsNullOrEmpty(title))
            {
                sb.AppendLine(title);
            }
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i=0;i<rows;i++)
            {
                for (int j=0;j<cols;j++)
                {
                    
                    sb.Append(matrix[i,j]);
                    if (j != cols - 1)
                    {
                        sb.Append(", ");
                    }                 
                    
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
