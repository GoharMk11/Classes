using System.Collections.Generic;


namespace MatrixApp
{
    public class FloodFill
    {
        public static void FillQueue(int[,] matrix, int startX, int startY, int newValue)
        {

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (startX >= rows || startY >= cols ||startX<0 || startY<0)
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
            Queue<(int x, int y)> coordinatesQueue = new Queue<(int x, int y)>();
            coordinatesQueue.Enqueue((startX, startY));
            while (coordinatesQueue.Count > 0)
            {
                var (x, y) = coordinatesQueue.Dequeue();
                if (x < 0 || x >= rows || y < 0 || y >= cols)
                    continue;
                if (matrix[x, y] != oldValue)
                    continue;
                matrix[x, y] = newValue;
                coordinatesQueue.Enqueue((x - 1, y)); 
                coordinatesQueue.Enqueue((x + 1, y)); 
                coordinatesQueue.Enqueue((x, y - 1)); 
                coordinatesQueue.Enqueue((x, y + 1)); 

            }

        }
    }
}
