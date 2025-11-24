// Անհրաժեշտ է ստեղծել Point անունով struct տիպ, որը կունենա երկու դաշտ՝ X և Y։
// Այնուհետև պետք է ստեղծել 10 էլեմենտից բաղկացած զանգված այս struct տիպով և լցնել
// այն պատահական (Random) X և Y արժեքներով։ Վերջում անհրաժեշտ է ստեղծել նոր զանգված,
// որտեղ Point-երը կլինեն դասակարգված աճման կարգով՝ նախ ըստ X-ի,իսկ եթե X-երը հավասար են՝ ըստ Y-ի։

using System;
namespace Lesson_3
{
    struct Point
    {
        public int X;
        public int Y;
    }


    class Ex4
    {
        static void Main()
        {
            Point[] points = new Point[10];
            Random rdm = new Random();
            Console.WriteLine("Original points:");
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = rdm.Next(1, 101);
                points[i].Y = rdm.Next(1, 101);
                Console.WriteLine($"Point {i}: X = {points[i].X}, Y = {points[i].Y}");
            }
            Point[] sortedPoints = new Point[10];
            for (int i = 0; i < points.Length; i++)
            {
                sortedPoints[i] = points[i];
            }
            for (int i = 0; i < sortedPoints.Length; i++)
            {
                for (int j = i + 1; j < sortedPoints.Length; j++)
                {
                    Point a = sortedPoints[i];
                    Point b = sortedPoints[j];

                    if (a.X > b.X || (a.X == b.X && a.Y > b.Y))
                    {
                        Point temp = sortedPoints[i];
                        sortedPoints[i] = sortedPoints[j];
                        sortedPoints[j] = temp;
                    }
                }
                
            }
            Console.WriteLine("Sorted points:");
            for (int i = 0; i < sortedPoints.Length; i++)
            {
                Console.WriteLine($"Point {i}: X = {sortedPoints[i].X}, Y = {sortedPoints[i].Y}");
            }

        }
    }
}
