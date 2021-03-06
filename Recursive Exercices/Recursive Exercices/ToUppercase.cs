﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    class ToUppercase
    {
        public static string ToUpperC(string word)
        {
            return Convert(word, "");
        }

        private static string Convert(string word, string result)
        {
            return (result.Count() == word.Count()) ? result : Convert(word, result.Insert(result.Count(), word.ElementAt(result.Count()).ToString().ToUpper()));
        }
    }
}
