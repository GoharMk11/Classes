// Ստեղծել C# ստրուկտուրա Student, որը կունենա հետևյալ դաշտերը՝ Name — string Scores — ամբողջ թվերի զանգված (օր 3,5,1,2,9)
// Ներմուծել աշակերտների քանակը: Յուրաքանչյուր աշակերտից ընդունել՝ Անունը (Name) Գնահատականների զանգվածը (Scores)
// Լցնել բոլոր աշակերտների տվյալները հիմնական զանգվածում: Հաշվել և տպել յուրաքանչյուր աշակերտի միջին գնահատականը։

using StudentApp;
using System;

namespace Lesson_4
{
    class Ex1
    {
        static void Main()
        {
            int count = StudentsInput.ReadStudentCount();
            Student[] students = new Student[count];
            for (int i=0;i<count;i++)
            {
                string name = StudentsInput.ReadStudentName(i+1);
                int[] scores= StudentsInput.ReadStudentScores(i+1);
                students[i] = new Student(name, scores);

            }
            Console.WriteLine("-----Data entry finished-----");
            StudentsReport.PrintStudentsReport(students);
        }
    }
}


