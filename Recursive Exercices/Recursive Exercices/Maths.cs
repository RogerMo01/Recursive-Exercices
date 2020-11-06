using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    class Maths
    {
        public static int SumTo(int top)
        {
            return (top == 1) ? 1 : top + SumTo(top - 1);
        }
    }
}
