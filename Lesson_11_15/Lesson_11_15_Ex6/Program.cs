// Հաշվել 1ից մինչև 100 թվերի միջին թվաբանականը։
using System;
namespace lesson_2
{
    class ex6
    {
        static void Main()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            int count = 100;
            double mean = (double)sum / count;
            Console.WriteLine($"The mean is {mean}");
        }
    }
}