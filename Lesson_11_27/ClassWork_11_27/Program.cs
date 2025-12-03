using System;
using System.ComponentModel;
using System.Xml;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *[1, 2,2,2,2, 3,3,3, 4, 5,6,6,7] // Length=13
             * [1,2,3,4,5,6,7] //Length=7
             */

        var array = new int[] { 1, 2, 2, 2, 2, 3, 3, 3, 4, 5, 6, 6, 7 };
            int[] unique = RemovingDup(array);
            Console.WriteLine("Original: " + string.Join(",", array));
            Console.WriteLine("Unique:   " + string.Join(",", unique));

        }
        public static int[] RemovingDup(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("The array is empty.");
            }
            if (array.Length == 1)
            {
                return new int[] { array[0] };
            }
            int[] temp = new int[array.Length];
            int idx = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                
                if (array[i] != array[i + 1])
                {
                    temp[idx] = array[i];
                    idx++;
                }

            }
            temp[idx] = array[array.Length - 1];
            idx++;
            int[] result = new int[idx];
            Array.Copy(temp, result, idx);

            return result;


        }
    }
}