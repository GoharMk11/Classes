//Ֆարենհեյթով արտահայտված ջերմաստիճանը վերածեք Ցելսիուսովարտահայտված ջերմաստիճանի
using System;
namespace lesson_2
{
    class ex4
    {
        static void Main()
        {
            Console.WriteLine("Please enter the value");
            string C = Console.ReadLine();
            float A = float.Parse(C);
            float B = (A - 32) * 5 / 9;
            Console.WriteLine("The answer is " + B);
        }
    }
}