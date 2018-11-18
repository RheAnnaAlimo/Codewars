using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheMiddleCharacter
{
    public class MiddleChar
    {
        //You are going to be given a word. 
        //Your job is to return the middle character of the word. 
        //If the word's length is odd, return the middle character. 
        //If the word's length is even, return the middle 2 characters.
        public static string GetMiddle(string s)
        {
            int center = s.Length / 2;

            if (s.Length % 2 == 0)
            {
                return "" + s[center - 1] + s[center];
            }

            else return "" + s[center];

        }
    }
}