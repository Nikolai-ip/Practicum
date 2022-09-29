using System;
using System.Diagnostics;

namespace PracticumLabs
{
    public static class StopwatchExtension
    {
        public static void ShowTime(this Stopwatch sw, string nameObject) => Console.WriteLine($"process the {nameObject} spend {sw.ElapsedTicks} milliseconds");
    }
}