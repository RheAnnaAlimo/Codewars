using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadAtTheWrongEnd
{
    class FixTheHead
    {
        //You're at the zoo... all the meerkats look weird. 
        //Something has gone terribly wrong - someone has gone and switched their heads and tails around!
        //Save the animals by switching them back.
        //You will be given an array which will have three values(tail, body, head). 
        //It is your job to re-arrange the array so that the animal is the right way round(head, body, tail).
        public static string[] FixTheMeerkat(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Reverse(arr);
            }
            return arr;
        }
    }
}

