namespace PracticumLab2
{
    internal class Test
    {
        public string ExamName { get; set; }
        public bool ExamIsPassed { get; set; }

        public Test(string examName, bool isPassed)
        {
            ExamName = examName;
            ExamIsPassed = isPassed;
        }

        public Test() : this(default(string), default(bool))
        {
        }

        public override string ToString() => $"Test name: {ExamName}\nIs passed:{ExamIsPassed}";
    }
}