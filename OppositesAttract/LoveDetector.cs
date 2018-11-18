using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppositesAttract
{
    public class LoveDetector
    {
        //Timmy & Sarah think they are in love.
        //They will only know once they pick a flower each.
        //If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.
        //Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't
        public static bool lovefunc(int flower1, int flower2)
        {
            bool f1 = true;
            bool f2 = true;
            bool result = true;

            if (flower1 % 2 != 0)
                f1 = false;

            if (flower2 % 2 != 0)
                f2 = false;

            if (f1 == f2)
                result = false;

            return result;
        }
    }
}
