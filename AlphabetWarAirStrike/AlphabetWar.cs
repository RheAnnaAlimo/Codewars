using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetWarAirStrike
{
    public class AlphabetWar
    {
        //Write a function that accepts fight string consists of only small letters
        //* means a bomb drop place. 
        //Return who wins the fight after bombs are exploded. 
        //When the left side wins return Left side wins!
        //When the right side wins return Right side wins!
        //In other cases return Let's fight again!.
        
        public static string DropBombs(string fight)
        {
            char[] chars = fight.ToCharArray();
            int left = 0;
            int right = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (fight[i] == '*')
                {
                    if (i == 0)
                    {
                        chars[1] = '_';
                    }

                    else if (i == chars.Length - 1)
                    {
                        chars[chars.Length - 2] = '_';
                    }
                    else
                    {
                        chars[i - 1] = '_';
                        chars[i + 1] = '_';
                    }
                }
            }

            for (int i = 0; i < chars.Length; i++)
            {
                char letter = 'l';
                letter = chars[i];
                switch (letter)
                {
                    case 'w': left += 4; break;
                    case 'p': left += 3; break;
                    case 'b': left += 2; break;
                    case 's': left += 1; break;
                    case 'm': right += 4; break;
                    case 'q': right += 3; break;
                    case 'd': right += 2; break;
                    case 'z': right += 1; break;
                }
            }

            if (left > right)
                return "Left side wins!";

            else if (left < right)
                return "Right side wins!";

            else return "Let's fight again!";
        }
    }
}

