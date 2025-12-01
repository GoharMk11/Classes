using System;

namespace StudentsModel
{
    struct Student
    {
        public string Name { get; set; }
        public int[] Scores { get; set; }
        public Student(string name,int[] scores)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name can't be empty.", nameof(name));
            if (scores == null || scores.Length == 0)
                throw new ArgumentException("Scores can't be empty.", nameof(scores));
            Name = name.Trim(); 
            Scores = scores;
        }
    }
}
