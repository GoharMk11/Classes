// Հայտարարել մեթոդ, որը որպես պարամետր կստանա ամբողջ թիվ n, և կվերադարձնի՝
// ● true, եթե նրա թվանշանները ձախից աջ գտնվում են խստորեն աճող կարգով,
// ● false՝ հակառակ դեպքում։

using System;
namespace lesson_2
{
    class ExAdd
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            string num = Console.ReadLine();
            int x = int.Parse(num);       
            bool Fin_Diff = Diff(x);
            Console.WriteLine(Fin_Diff);
        }
        static bool Diff(int x)
        {
            x = Math.Abs(x);
            if (x < 10)
                return true;

            int prev = x%10;
            x = x / 10;
            while (x>0)
            {
                int curr = x % 10;
                if (curr>prev)
                {
                    return false;
                }
                prev = curr;
                x = x / 10;
            }
            return true;
        }
    }
}
