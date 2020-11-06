using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    class Maths
    {
        public static LinkedList<int> RankTo(int top)
        {
            return FillArray(top, new LinkedList<int>());
        }
        private static LinkedList<int> FillArray(int top, LinkedList<int> list)
        {
            list.AddFirst(top);

            if (top == 0)
            { return list; }

            return FillArray(top - 1, list);
        }
    }
}
