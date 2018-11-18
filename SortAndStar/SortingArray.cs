using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndStar
{
    public class SortingArray
    {
        //You will be given an vector of strings.
        //You must sort it alphabetically and then return the first value.
        //The returned value must be a string, and have "***" between each of its letters.
        //You should not remove or add elements from/to the array.
        public static string TwoSort(string[] s)
        {
            Array.Sort(s, StringComparer.Ordinal);
            string str = s[0];
            string result = "";

            for (int i = 0; i < str.Length - 1; i++)
            {
                result += str[i] + "***";
            }
            result += str[str.Length - 1];

            return result;
        }
    }
}
