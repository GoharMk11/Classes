//Հայտարարել մեթոդ, որը որպես պարամետր կստանա n ամբողջ թիվը և կհաշվի այդ թվի ֆակտորիալը
using System;
namespace lesson_2
{
    class ex9
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            string input=Console.ReadLine();
            int n = int.Parse(input);
            if (n < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return;
            }
            else if (n < 2)
            {
                Console.WriteLine("Factorial for " + n + " is 1");
                return;
            }
            long fin_result =Factorial(n);
            Console.WriteLine("Factorial for " + n + " is " + fin_result);

        }
        static long Factorial(int n)
        {
            long result = 1;
            for (int i=2;i<=n;i++) 
            {                
                result = result * i;                
            }
            return result;
        }

    }
}