// Անհրաժեշտ է ստեղծել Rectangle և Triangle struct տիպերը որը իր տիպին համապատասխան
// կունենա width, height կամ base, height դաշտերով։ Գրիր մեթոդ որը վերադարձնում է մակերեսը։

using System;
namespace Lesson_3
{
    
    
        struct Rectangle
        {
        public double Width;
        public double Height;
        public double GetArea()
        {
            return Width * Height;
        }
        }
    struct Triangle
    {
        public double Base;
        public double Height;

        public double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
    class Ex3
    {
        static void Main()
        {
          //For Rectangle
            Console.WriteLine("Please enter the rectangle’s width");
            double rw = double.Parse(Console.ReadLine());       
            Console.WriteLine("Please enter the rectangle’s height");
            double rh = double.Parse(Console.ReadLine());
            if (rw<=0 || rh<=0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }
            Rectangle r;
            r.Width = rw;
            r.Height = rh;
            double rectArea = r.GetArea();
            Console.WriteLine($"The rectangle area is {rectArea}");

          //For Triangle
            Console.WriteLine("Please enter the triangle’s base");
            double tb = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the triangle’s height");
            double th = double.Parse(Console.ReadLine());
            if (tb <= 0 || th <= 0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }
            Triangle t;
            t.Base = tb;
            t.Height = th;
            double triArea = t.GetArea();
            Console.WriteLine($"The triangle area is {triArea}");
        }
    }
}