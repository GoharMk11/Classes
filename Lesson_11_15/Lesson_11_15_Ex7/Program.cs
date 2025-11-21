//Գտնել 1ից մինչև 100 միջակայքում կենտ թվերի քանակը։
using System;
namespace lesson_2
{
    class ex7
    {
        static void Main()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"The count is {count}");
        }
    }
}