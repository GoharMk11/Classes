//Տրված են a և b թվերը։ Հաշվեք դրանց միջին թվաբանականը։
using System;
namespace lesson_2
{
    class ex1
    {
        static void Main()
        {
            Console.WriteLine("Please enter the 1st value");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter the 2nd value");
            string second = Console.ReadLine();
            float a = float.Parse(first);
            float b = float.Parse(second);
            float c = (a + b) / 2;
            Console.WriteLine("The answer is " + c);
        }
    }
}