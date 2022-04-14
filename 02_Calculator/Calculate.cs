using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Calculator
{
    internal class Calculate
    {
        public static double DoCalc(double v1, double v2, string op)
        {
            double res = 0;
            switch (op)
            {
                case "/":
                    res = v1 / v2;
                    break;
                case "*":
                    res = v1 * v2;
                    break;
                case "-":
                    res = v1 - v2;
                    break;
                case "+":
                    res = v1 + v2;
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}
