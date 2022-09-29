using System;

namespace PracticumLab2
{
    internal interface IDateAndCopy
    {
        object DeepCopy();

        DateTime Date { get; set; }
    }
}