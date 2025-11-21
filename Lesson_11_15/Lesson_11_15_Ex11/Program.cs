// Հայտարարել մեթոդ, որը կստանա n թիվը և կվերադարձնի true/false՝ կախված նրանից, արդյոք թիվը պարզ է։
using System;
namespace lesson_2
{
    class ex11
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            string num = Console.ReadLine();
            int n = int.Parse(num);
            if (n <= 1 || n % 2 == 0)
            {
                Console.WriteLine("False");
                return;
            }
            else if (n == 2) 
            {
                Console.WriteLine("True");
                return;
            }
            bool finres = prime(n);
            Console.WriteLine(finres);
            

        }
        static bool prime(int n)
        {            
            for (int i=2;i<n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
               
            }
            return true;

        }
    }
}


