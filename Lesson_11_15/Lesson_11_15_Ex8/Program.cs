//Հայտարարել մեթոդ,որը որպես պարամետրեր կընդունի x և a թվային արժեքները և կհաշվի հետևյալ ֆունկցիայի արդյունքը այդ կետում
using System;

namespace lesson_2
{
    class ex8
    {
        static void Main()
        {
            Console.WriteLine("Please enter the value for a:");
            string first = Console.ReadLine();
            double a = double.Parse(first);
            if (a == 0)
            {
                Console.WriteLine("a cannot be 0, the function is not defined.");
                return; 
            }
            Console.WriteLine("Please enter the value for x:");
            string second = Console.ReadLine();
            double x = double.Parse(second);
            double result = Function1(a, x);
            Console.WriteLine("The result is " + result);
        }
        static double Function1(double a, double x)
        {
            double y = (a * Math.Pow(x, 3)) + (Math.Pow(x,1.0 / a));
            return y;
        }
    }
}