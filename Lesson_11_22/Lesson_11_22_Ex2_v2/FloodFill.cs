using System.Collections.Generic;


namespace MatrixApp
{
    public class FloodFill
    {
        public static void FillRecursive(int[,] matrix, int startX, int startY, int newValue)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (startX < 0 || startX >= rows || startY < 0 || startY >= cols)
            {
                Console.WriteLine("Invalid coordinates");
                return;
            }

            int oldValue = matrix[startX, startY];

            if (oldValue == newValue)
            {
                Console.WriteLine("Old value is the same as new value. No changes needed.");
                return;
            }

            FillRecursiveCore(matrix, startX, startY, oldValue, newValue);
        }

        private static void FillRecursiveCore(int[,] matrix, int x, int y, int oldValue, int newValue)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (x < 0 || x >= rows || y < 0 || y >= cols)
                return;

            if (matrix[x, y] != oldValue)
                return;

            matrix[x, y] = newValue;

            FillRecursiveCore(matrix, x - 1, y, oldValue, newValue);
            FillRecursiveCore(matrix, x + 1, y, oldValue, newValue);
            FillRecursiveCore(matrix, x, y - 1, oldValue, newValue);
            FillRecursiveCore(matrix, x, y + 1, oldValue, newValue);
        }


    }
}
}
