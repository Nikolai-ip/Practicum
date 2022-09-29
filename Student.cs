using PracticumLab2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PracticumLabs
{
    internal class Student : IEnumerable, IComparer<Student>
    {
        public Person Person { get; private set; }
        private Education _education;
        private List<Test> _tests;
        private List<Exam> _exams;
        private int _groupNum;
        public int GroupNumber
        {
            get { return _groupNum; }
            set
            {
                if (value <= 100 || value > 599) throw new Exception("Permissible value of Group number is >100 and <599");
                _groupNum = value;
            }
        }

        public Education Education { get { return _education; } }
        public double AverageScore
        {
            get
            {
                double score = 0;
                foreach (var exam in _exams)
                    score += exam.Grade;
                return score / _exams.Count;
            }
        }

        public void AddExams(params Exam[] exams)
        {
            foreach (var exam in exams)
            {
                _exams.Add(exam);
            }
        }

        public bool this[Education education]
        {
            get { return _education == education; }
        }

        public override string ToString()
        {
            string outPut = ToShortString();
            outPut += "Exams: \n";
            foreach (var exam in _exams)
            {
                outPut += exam.ToString() + "\n";
            }
            outPut += "Tests: \n";
            foreach (var test in _tests)
            {
                outPut += test.ToString() + "\n";
            }
            return outPut;
        }

        public string ToShortString()
        {
            string outPut = Person.ToString() +
                 $"\nLearning on program {_education}\nGroup Number is {GroupNumber}\n";
            if (AverageScore != double.NaN)
                outPut += $"Average score is {AverageScore}" + "\n";
            return outPut;
        }

        public object DeepCopy()
        {
            return new Student(Person, _education, GroupNumber, new List<Exam>(_exams).ToArray() , new List<Test>(_tests).ToArray());
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var exam in _exams)
            {
                yield return exam;
            }
            foreach (var test in _tests)
            {
                yield return test;
            }
        }

        public IEnumerable GetExamsWithCond(Func<int, bool> gradeCond)
        {
            foreach (var exam in _exams)
            {
                if (gradeCond(exam.Grade))
                {
                    yield return exam;
                }
            }
        }

        public int Compare(Student x, Student y) => x.AverageScore.CompareTo(y.AverageScore);
        public Student(Person person, Education education, int groupNumber, Exam[] exams, Test[] tests)
        {
            Person = person;
            _education = education;
            GroupNumber = groupNumber;
            _exams = exams.ToList();
            _tests = tests.ToList();
        }

        public Student()
        {
            Person = new Person();
            GroupNumber = 101;
            _education = default(Education);
        }
    }
}