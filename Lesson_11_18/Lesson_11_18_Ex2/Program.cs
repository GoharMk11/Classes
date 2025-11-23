/* 1 չափանի զանգված - Տրված է դրական ամբողջ թվերի զանգված. Պետք է ստեղծել նոր զանգված,
   որտեղ ինդեքսը ցույց է տալիս թիվը, իսկ պարունակությունը՝ այդ թվի հանդիպումների քանակը։*/

using System;
using System.Buffers.Text;
namespace lesson_3
{
    class Ex2
    {
        static void Main()
        {
            Console.WriteLine("Please enter the length of the array");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }
            int[] old= new int[n];
            Random rdm = new Random();
            for (int i=0;i<n;i++)
            {
                old[i] = rdm.Next(1, 101);
            }
            Console.WriteLine("Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(old[i]);
                if (i != n - 1)
                {
                    Console.Write(", ");
                }
                else Console.Write(":");
            }
            int[] final = BuildFrequencyArray(old);


            Console.WriteLine("\nCounts (number -> times):");
            for (int i = 0; i < final.Length; i++)
            {
                if (final[i] > 0)
                {
                    Console.WriteLine($"{i} -> {final[i]}");
                }
            }



        }
        static int[] BuildFrequencyArray(int[] old)
        {
            int max = old[0];
            for (int i=1;i<old.Length;i++)
            {
                if (old[i]>max)
                {
                    max = old[i];
                }
            }
            int[] curr = new int[max+1];

            for (int i=0;i<old.Length;i++)
            {
                int x = old[i];
                curr[x]++;
                
            }
            return curr;

        }

    }
}





