//Հայտարարել մեթոդ, որը կընդունի n թիվը և կվերադարձնի Ֆիբոնաչիի հաջորդականության n-րդ անդամը։
using System;
namespace lesson_2
{
    class ex10
        {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            string num = Console.ReadLine();
            int n = int.Parse(num);
            if(n<0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }
            else if (n<3)
            {
                Console.WriteLine("The Fibonacci number for " + n + " is 1");
                return;
            }
            int fin_num = fib(n);
            Console.WriteLine("The Fibonacci number for " + n + " is " + fin_num);

        }
        static int fib(int n)
        {
            int prev = 1;
            int curr = 1;            
            for (int i=3; i<=n;i++)
            {
                int next = prev + curr;
                prev = curr;
                curr = next;                
            }
            return curr;
        }
    }
}