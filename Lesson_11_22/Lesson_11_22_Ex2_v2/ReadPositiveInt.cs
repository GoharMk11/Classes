using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MatrixApp
{
    public static class ReadInt
    {
        public static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number) && number > 0)
                    return number;
                Console.WriteLine("Please enter a positive number.");
                return number;
            }
        }
        public static int ReadInRange(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Please enter a number.");
                    continue;
                }

                if (number < min || number > max)
                {
                    Console.WriteLine($"Please enter a number between {min} and {max}.");
                    continue;
                }

                return number;
            }
        }

    }
}
