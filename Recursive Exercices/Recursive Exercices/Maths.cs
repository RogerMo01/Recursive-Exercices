﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    class Maths
    {
        public static int Factorial(int number)
        {
            return (number == 0) ? 1 : number * Factorial(number - 1);
        {

        public static List<int> RemoveAll(List<int> list, int element)
        {
            return FillArray(list, element);
        }

        private static List<int> FillArray(List<int> list, int element, int indexer = 0)
        {
            if (indexer == list.Count)
            { return list; }

            if (list[indexer] == element)
            {
                list.RemoveAt(indexer);
            }

            return FillArray(list, element, indexer + 1);
        }

        public static int Fibonacci(int positionInSequence)
        {
            if (positionInSequence == 1) { return 0; }
            if (positionInSequence == 2) { return 1; }

            return Fibonacci(positionInSequence - 1) + Fibonacci(positionInSequence - 2);
        }

        public static string Sort(List<int> list)
        {
            if (list.Count == 1) { return list[0].ToString(); }

            int minor = FindMinor(list);
            list.Remove(minor);

            return $"{minor.ToString()}|{Sort(list)}";
        }

        private static int FindMinor(List<int> list)
        {
            int minor = list[0];

            foreach (var item in list)
            {
                if (item < minor) { minor = item; }
            }

            return minor;
        }
    }
}
