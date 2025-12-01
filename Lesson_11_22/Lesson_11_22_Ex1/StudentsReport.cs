using System;

namespace StudentApp
{
    public static class StudentsReport
    {
        public static void PrintStudentsReport(Student[] students)
        {
            if (students == null || students.Length == 0)
                throw new ArgumentException("Students can't be empty.", nameof(students));
        }

    }
}
