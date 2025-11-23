// Անհրաժեշտ է գրել մեթոդը, որը ստանում է ամբողջ թվերի զանգված և
// ստեղծում է նոր string որի էլեմենտները ստորակետով բաժանված են:


using System;
namespace Lesson_3
{
    class Ex1
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            int n = int.Parse(Console.ReadLine());
            if (n<=0)
            {
                Console.WriteLine("PLease enter a positive number");
                return;
            }
            int[] ar = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                ar[i] = rnd.Next(0, 101);
            }
            string text = ArrayToString(ar);
            Console.WriteLine(text);

        }
        static string ArrayToString(int[] ar)
        {
            string result = "";
            for (int i=0;i<ar.Length;i++)
            {
                if (i>0)
                {
                    Console.Write(", ");
                    
                }
                Console.Write(ar[i]);
                if (i == ar.Length - 1)
                {
                    Console.Write(":");
                }
            }
            return result;
        }
    }
}