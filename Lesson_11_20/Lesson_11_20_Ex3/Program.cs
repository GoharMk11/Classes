// Անհրաժեշտ է ստեղծել Rectangle և Triangle struct տիպերը որը իր տիպին համապատասխան
// կունենա width, height կամ base, height դաշտերով։ Գրիր մեթոդ որը վերադարձնում է մակերեսը։

using System;
namespace Lesson_3
{
    
    
        struct Rectangle
        {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int width, int height)
        {
            if (width <= 0 || height <= 0) throw new ArgumentException("Width/Height must be positive.");

            Width = width;
            Height = height;
        }

        public int GetArea() => Width * Height;
        }
    struct Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double @base, double height)
        {
            if (@base <= 0 || height <= 0) throw new ArgumentException("Base/Height must be positive.");

            Base = @base;
            Height = height;
        }

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
            int rw = int.Parse(Console.ReadLine());       
            Console.WriteLine("Please enter the rectangle’s height");
            int rh = int.Parse(Console.ReadLine());

            Rectangle r = new Rectangle(rw, rh);
            int rectArea = r.GetArea();
            Console.WriteLine($"The rectangle area is {rectArea}");

          //For Triangle
            Console.WriteLine("Please enter the triangle’s base");
            double tb = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the triangle’s height");
            double th = double.Parse(Console.ReadLine());

            Triangle t= new Triangle(tb, th);
            double triArea = t.GetArea();
            Console.WriteLine($"The triangle area is {triArea}");
        }
    }
}