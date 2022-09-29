using PracticumLab2;
using System;

namespace PracticumLabs
{
    internal class Exam : IDateAndCopy
    {
        public string ExamTitle { get; private set; }
        public int Grade { get; private set; }
        public DateTime ExamDate { get; private set; }
        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Exam(string examTitle, int grade, DateTime examDate)
        {
            ExamTitle = examTitle;
            Grade = grade;
            ExamDate = examDate;
        }

        public Exam()
        {
            ExamTitle = default(string);
            Grade = 0;
            ExamDate = default(DateTime);
        }

        public override string ToString() => $"Exam {ExamTitle} was {ExamDate.ToShortDateString()} with Grade is {Grade}";

        public object DeepCopy() => new Exam(ExamTitle, Grade, ExamDate);
    }
}