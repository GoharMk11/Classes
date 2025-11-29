// Անհրաժեշտ է գրել մեթոդը, որը ստանում է ամբողջ թվերի զանգված և
// ստեղծում է նոր string որի էլեմենտները ստորակետով բաժանված են:


using System;
using System.Text;
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
            string result = ArrayToString(ar);
            Console.WriteLine(result);

        }
        static string ArrayToString(int[] ar)
        {

            if (ar == null || ar.Length == 0)
                return "";
            StringBuilder sb = new StringBuilder();
            for (int i=0;i<ar.Length;i++)
            {
                if (i > 0) sb.Append(",");
                sb.Append(ar[i]);

            }
            return sb.ToString();
        }
    }
}