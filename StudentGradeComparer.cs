using PracticumLabs;
using System.Collections.Generic;

namespace PracticumLab3
{
    internal class StudentGradeComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.AverageScore.CompareTo(y.AverageScore);
        }
    }
}