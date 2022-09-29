using PracticumLab2;
using System;
using System.Collections.Generic;

namespace PracticumLabs
{
    internal class Person : IDateAndCopy, IComparable, IComparer<Person>
    {
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public DateTime BornDate { get; protected set; }
        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string ToString() => $"{Name}, {Surname}, born date is {BornDate.ToShortDateString()}";

        public virtual string ToShortString() => $"{Name}, {Surname}";

        public override bool Equals(object obj)
        {
            if (obj is Person == false) throw new Exception();
            var person2 = obj as Person;
            return Name == person2.Name && Surname == person2.Surname && BornDate.Equals(person2.BornDate);
        }

        public override int GetHashCode() => Name.GetHashCode() + Surname.GetHashCode() + BornDate.GetHashCode();

        public virtual object DeepCopy() => new Person(Name, Surname, BornDate);

        public int CompareTo(object obj)
        {
            if (obj is Person == false) throw new Exception();
            var person2 = obj as Person;
            return Surname.CompareTo(person2.Surname);
        }

        public int Compare(Person x, Person y) => x.BornDate.CompareTo(y.BornDate);

        public static bool operator ==(Person p1, Person p2) => p1.Equals(p2);

        public static bool operator !=(Person p1, Person p2) => !(p1 == p2);

        public Person(string name, string surname, DateTime bornDate)
        {
            Name = name;
            Surname = surname;
            BornDate = bornDate;
        }

        public Person()
        { }
    }
}