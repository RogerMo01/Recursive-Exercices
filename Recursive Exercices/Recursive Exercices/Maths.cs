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
    }
}
