using System;

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
            }
        }
    }
}
