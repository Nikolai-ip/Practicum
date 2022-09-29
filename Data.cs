using PracticumLab2;
using PracticumLabs;
using System;

namespace PracticumLab3
{
    internal static class Data
    {
        public static Exam[] CreateExamsArray()
        {
            Random r = new Random();

            return new Exam[]
            {
                new Exam("Programm",r.Next(2,5), new DateTime(2020, 1, 15)),
                new Exam("Math",  r.Next(), new DateTime(2020, 1, 25)),
                new Exam("Phisics", r.Next(), new DateTime(2020, 1, 15)),
                new Exam("English",  r.Next(), new DateTime(2020, 1, 20))
            };
        }

        public static Test[] CreateTestsArray()
        {
            return new Test[]
            {
                new Test("InternetProgramming",true),
                new Test("WebProgramming", true),
                new Test("Evm", false),
            };
        }

        public static Person[] CreatePersonsArray()
        {
            return new Person[]
            {
                new Person("Vladimir","Putin", new DateTime(1990,2,3)),
                new Person("Boris","Jonshon", new DateTime(1992,4,1)),
                new Person("Yarik","Kuznecov", new DateTime(2001,10,20)),
                new Person("Taras","Bubble", new DateTime(1995,5,12))
            };
        }

        public static Student[] CreateStudentsArray()
        {
            Student[] students = new Student[CreatePersonsArray().Length];
            Random random = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(CreatePersonsArray()[i], (Education)random.Next(0, 3), random.Next(101, 599), CreateExamsArray(), CreateTestsArray());
            }
            return students;
        }
    }
}