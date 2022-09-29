using PracticumLabs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PracticumLab3
{
    internal class TestCollection<Tkey, Tvalue> where Tkey : Person where Tvalue : Student
    {
        private  List<Tkey> _keyList;
        private  List<string> _stringList;
        private  Dictionary<Tkey, Tvalue> _dictionary;
        private  Dictionary<string, Tvalue> _dictionary2;

        public TestCollection(Tkey[] keys, Tvalue[] values, int stringListLenght)
        {
            _keyList = keys.ToList();
            _stringList = CreateStringList(stringListLenght);
            _dictionary = CreateDictionary(keys, values);
            _dictionary2 = CreateDictionary(values);
        }

        private List<string> CreateStringList(int lenght)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < lenght; i++)
            {
                list.Add(i.ToString());
            }
            return list;
        }

        private Dictionary<Tkey, Tvalue> CreateDictionary(Tkey[] keys, Tvalue[] values)
        {
            Dictionary<Tkey, Tvalue> dictionary = new Dictionary<Tkey, Tvalue>();
            if (keys.Length != values.Length)
                throw new Exception("keys[] length should be equals values[] length");
            for (int i = 0; i < values.Length; i++)
            {
                dictionary.Add(keys[i], values[i]);
            }
            return dictionary;
        }

        private Dictionary<string, Tvalue> CreateDictionary(Tvalue[] values)
        {
            Dictionary<string, Tvalue> dictionary = new Dictionary<string, Tvalue>();
            for (int i = 0; i < values.Length; i++)
            {
                dictionary.Add(i.ToString(), values[i]);
            }
            return dictionary;
        }
        public void ShowTime(int i,Person key)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            _keyList.Contains(key);
            stopwatch.Stop();
            stopwatch.ShowTime(_keyList.ToString());
            stopwatch.Restart();
            _stringList.Contains(i.ToString());
            stopwatch.Stop();
            stopwatch.ShowTime(_stringList.ToString());
            stopwatch.Restart();
            _dictionary.ContainsKey((Tkey)key);
            stopwatch.Stop();
            stopwatch.ShowTime(_dictionary.ToString());
            stopwatch.Restart();
            _dictionary2.ContainsKey(i.ToString());
            stopwatch.Stop();
            stopwatch.ShowTime(_dictionary2.ToString());
            Console.WriteLine();
        }
    }
}