//Տրված է a=60 , հաշվել y=2sin(a) արտահայտության արժեքը
using System;
namespace lesson_2
{
    class ex5
    {
        static void Main()
        {
            int a = 60;
            double radians = a * Math.PI / 180;
            double b = 2 * Math.Sin(radians);
            Console.WriteLine("The answer is " + b);
        }
    }
}