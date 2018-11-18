using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouOnlyNeedOne
{
    public class CheckIt
    {
        //You will be given an array a and a value x.
        //All you need to do is check whether the provided array contains the value.
        //Array can contain numbers or strings.X can be either.
        //Return true if the array contains the value, false if not.
        
        public static bool Check(object[] a, object x)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i].Equals(x))
                {
                    return true;
                }
            }
            return false;
        }
    }
}