// Հայտարարել մեթոդ, որը որպես պարամետր կստանա ամբողջ թիվ n և կվերադարձնի նրա թվանշանների գումարը։
using System;
namespace lesson_2
{
    class ex12
    {
        static void Main()
        {
            Console.WriteLine("PLease enter a number");
            string num = Console.ReadLine();
            int n = int.Parse(num);
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }
            else if (n<10)
            {
                Console.WriteLine("The sum is " + n);
                return;
            }
            int final = Fin_Sum(n);
            Console.WriteLine("Sum is " + final);

        }
        static int Fin_Sum(int n)
        {
            int sum = 0;
            int i = 1;
            while (n!=0)
            {
                int last = n % 10;
                sum = sum + last;
                n = n / 10;
            }
            return sum;
        }
    }
}

