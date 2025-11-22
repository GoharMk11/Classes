// 1 չափանի զանգված - Տրված n երկարության զանգվածում գտնել առավելագույնը և նվազագույնը։

using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography;
namespace Lesson_3
{
    class Ex1
    {
        static void Main()
        {
            Console.WriteLine("Please enter the length of the array");
            int n = int.Parse(Console.ReadLine());
            if(n<=0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }
            int[] numbers = new int[n];
            Random rnd = new Random(); //Its random generator
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rnd.Next(0, 101);
             }
            Console.Write("Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i]);
                if (i != n - 1)
                {
                    Console.Write(", ");
                }
                else Console.Write(":");
            }
            Console.WriteLine();             
            int min;
            int max;
            FindMinMax(numbers, out min, out max);
            Console.WriteLine("Minimal value: " + min);
            Console.WriteLine("Maximal value: " + max);

        }


        static void FindMinMax(int[] numbers, out int min, out int max)
        {
             min = numbers[0];
             max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < i)
                {
                    min = numbers[i];
                }
                if (numbers[i] > i)
                {
                    max = numbers[i];
                }
            }

        }
    }
}

