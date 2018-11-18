using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumMagic2
{
    public class TrueForAny
    {
        //Create a function that accepts an array and a block
        //returns true if the block returns true for any item in the array
        //If the array is empty, the function should return false.
        public static bool Any(int[] arr, Func<int, bool> fun)
        {
            bool state = false;
            if (arr.Length == 0) return false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (fun(arr[i]))
                {
                    state = true;
                    break;
                }
            }
            return state;
        }
    }
}
