using System;

namespace StudentApp
{
    public static class StudentsReport
    {
        public static void PrintStudentsReport(Student[] students)
        {
            if (students == null || students.Length == 0)
                throw new ArgumentException("Students can't be empty.", nameof(students));
            Console.WriteLine("-----Students Report-----");
            for (int i=0;i<students.Length;i++)
            {
                double avg=StudentService.AvgScore(students[i].Scores);
                Console.WriteLine($"{i + 1}) {students[i].Name}: {avg:F2}");

            }
                    }
        

    }
}
