// Օգտագործելով StringBuilder՝ հավաքել string, որը ունի n կրկնվող pattern՝ օրինակ՝
// "ABC" pattern - ը կրկնել n անգամ առանց որևէ ժամանակավոր string ստեղծելու,
// Օրինակ n = 4 "ABCABCABCABC"

using System;
using System.Text;

namespace Lesson_3
{
    class Ex2
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            int n = int.Parse(Console.ReadLine());
            string text = BuildPattern(n);
            Console.WriteLine(text);

        }
        static string BuildPattern(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i=0;i<n;i++)
            {
              sb.Append("ABC");
            }
            return sb.ToString();

        }
    }
}