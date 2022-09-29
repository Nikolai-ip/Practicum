using System.Collections.Generic;
using System.Linq;

namespace PracticumLabs
{
    internal static class ArrayExtension
    {
        public static Exam[] Add(this Exam[] originArr, params Exam[] addArr)
        {
            List<Exam> newArr = new List<Exam>();
            newArr = originArr.ToList();
            foreach (var item in addArr)
                newArr.Add(item);
            return newArr.ToArray();
        }
    }
}