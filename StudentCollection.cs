using PracticumLabs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticumLab3
{
    internal class StudentCollection
    {
        private List<Student> _students;

        public double MaxAverageGrade
        {
            get
            {
                if (_students.Count == 0)
                {
                    return -1;
                }
                return _students.Max(student => student.AverageScore);
            }
        }
        public IEnumerable<Student> Specialists
        {
            get
            {
                return _students.Where(x => x.Education == Education.Specialist);
            }
        }
        public IEnumerable<Student> AverageMarkGroup(double value)
        {
            return _students.Where(s => s.AverageScore == value);
        }
        public void AddStudents(params Student[] newStudents)
        {
            foreach (var student in newStudents)
            {
                _students.Add(student);
            }
        }
        public override string ToString()
        {
            string str = "";
            foreach (var student in _students)
            {
                str += student.ToString() + "\n";
            }
            return str;
        }

        public string ToShortString()
        {
            string str = "";
            foreach (var student in _students)
            {
                str += student.ToShortString() + "\n";
            }
            return str;
        }
        public void SortBySurname()
        {
            _students.Sort((student1,student2) => student1.Person.Surname.CompareTo(student2.Person.Surname));
        }
        public void SortByDateBorn()
        {
            _students.Sort((x, y) => x.Person.BornDate.CompareTo(y.Person.BornDate));
        }
        public void SortByAverageGrade()
        {
            _students.Sort((x, y) => x.AverageScore.CompareTo(y.AverageScore));
        }
        public StudentCollection(List<Student> students)
        {
            _students = students;
        }
    }
}