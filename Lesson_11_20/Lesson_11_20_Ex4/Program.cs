// Անհրաժեշտ է ստեղծել Point անունով struct տիպ, որը կունենա երկու դաշտ՝ X և Y։
// Այնուհետև պետք է ստեղծել 10 էլեմենտից բաղկացած զանգված այս struct տիպով և լցնել այն պատահական (Random) X և Y արժեքներով։
// Վերջում պետք է ստեղծել նոր զանգված,որտեղ Point-երը կլինեն դաս․ աճման կարգով՝ նախ ըստ X-ի,իսկ եթե X-երը հավասար են՝ ըստ Y-ի։

using System;
namespace Lesson_3
{
    struct Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    class Ex4
    {
        static void Main()
        {
            int count = 10;
            Point[] mainpoints= FillingPoint(count);
            Console.WriteLine("\n----- SORTED -----");
            Point[] sortedPoints = SortingPoints(mainpoints);
            PrintPoints(sortedPoints);
        }
        static Point[] SortingPoints(Point[] arr)
        {
            Point[] sorted = new Point[arr.Length];
            for (int i=0;i<arr.Length;i++)
            {
                sorted[i] = arr[i];
            }

            for (int i=0;i<sorted.Length;i++)
            {
                for (int j=0;j<sorted.Length-i-1;j++)
                {
                    if (sorted[j].X > sorted[j+1].X || sorted[j].X == sorted[j + 1].X && sorted[j].Y > sorted[j+1].Y)
                    {
                        Point temp = sorted[j];
                        sorted[j] = sorted[j+1];
                        sorted[j + 1] = temp;
                    }
                }

            }
            return sorted;
        }
        static void PrintPoints(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
                Console.WriteLine(points[i]); 
        }
        static Point[] FillingPoint(int count)
        {
            Point[] points = new Point[count];
            Random rdm = new Random();
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = rdm.Next(1, 101);
                points[i].Y = rdm.Next(1, 101);
                Console.WriteLine($"Point {i}: X = {points[i].X}, Y = {points[i].Y}");
            }

            return points;
        }
    }  
}
