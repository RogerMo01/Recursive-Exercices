using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    class Maths
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

        public static int AddN(int numberOfElements, List<int> list)
        {
            if (numberOfElements == 1)
            { return list[numberOfElements - 1]; }
            if (numberOfElements == 0)
            { return 0; }

            return list[numberOfElements - 1] + AddN(numberOfElements - 1, list);
        }
    }
}
