using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums
{
    public class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
            var sum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
