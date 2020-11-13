using System;
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
        }
    }
}
