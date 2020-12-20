using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    class Maths
    {
        public static List<int> RankBetween(int bottom, int top)
        {
            return FillArray(new List<int>(), bottom, top);
        }
        
        private static List<int> FillArray(List<int> list, int bottom, int top)
        {
            list.Add(bottom);
            return (bottom == top) ? list : FillArray(list, bottom + 1, top);
        }
    }
}
