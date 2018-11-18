using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathOp
{
    public class Operations
    {
        //Your task is to create a function that does four basic mathematical operations.
        //The function should take three arguments - operation(string/char), value1(number), value2(number).
        //The function should return result of numbers after applying the chosen operation.
        public static double basicOp(char operation, double value1, double value2)
        {
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = value1 += value2;
                    break;
                case '-':
                    result = value1 -= value2;
                    break;
                case '*':
                    result = value1 *= value2;
                    break;
                case '/':
                    result = value1 /= value2;
                    break;
            }

            return result;
        }
    }
}