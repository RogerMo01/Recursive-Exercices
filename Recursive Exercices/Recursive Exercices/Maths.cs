using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    class Maths
    {
        public static int[] RankTo(int top)
        {
            return FillArray(top, new int[top + 1]);
        }
        private static int[] FillArray(int top, int[] list)
        {
            list[top] = top;

            if (top == 0)
            { return list; }

            return FillArray(top - 1, list);
        }
    }
}
