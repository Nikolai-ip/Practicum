using PracticumLab3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PracticumLabs
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            StudentCollection students = new StudentCollection(Data.CreateStudentsArray().ToList());
            Console.WriteLine(students);
            students.SortBySurname();
            Console.WriteLine(students);
            students.SortByDateBorn();
            foreach (var student in students.AverageMarkGroup(3.5))
            {
                Console.WriteLine(student);
            }
            Console.WriteLine(Data.CreateStudentsArray().Average(s => s.AverageScore));
        }
    }
}