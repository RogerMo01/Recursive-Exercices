using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    class Maths
    {
        public static int Fibonacci(int positionInSequence)
        {
            if (positionInSequence == 1) { return 0; }
            if (positionInSequence == 2) { return 1; }

            return Fibonacci(positionInSequence - 1) + Fibonacci(positionInSequence - 2);
        }
    }
}
