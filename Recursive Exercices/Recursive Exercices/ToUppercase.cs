using System;
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

        private static string Convert(string word, string returnWord)
        {
            if (returnWord.Count() == word.Count())
            {
                return returnWord;
            }

            return Convert(word, returnWord.Insert(returnWord.Count(), word.ElementAt(returnWord.Count()).ToString().ToUpper()));
        }
    }
}
