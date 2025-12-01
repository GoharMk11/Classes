using System;
namespace StudentInput 
{
  public class StudentsInput
    {

        public static int ReadStudentCount()
        {
            while (true)
            {
                Console.Write("How many students? ");

                if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
                    return count;

                Console.WriteLine("Please enter a positive number.");
            }
        }
        public static string ReadStudentName(int index)
        {
            while (true)
            {
                Console.Write($"Enter name for student #{index}: ");
                string name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                    return name.Trim();

                Console.WriteLine("Name can't be empty. Try again.");
            }
        }
        public static int[] ReadStudentScores(int index)
        {
            int count;

            while (true)
            {
                Console.Write($"How many grades for student #{index}? ");
                if (int.TryParse(Console.ReadLine(), out count) && count > 0)
                    break;

                Console.WriteLine("Please enter a positive number.");
            }

            int[] scores = new int[count];

            for (int i = 0; i < count; i++)
            {
                while (true)
                {
                    Console.Write($"Enter grade #{i + 1} for student #{index}: ");
                    if (int.TryParse(Console.ReadLine(), out int grade) && grade > 0)
                    {
                        scores[i] = grade;
                        break;
                    }

                    Console.WriteLine("Please enter a positive number.");
                }
            }

            return scores;
        }


    }
}
