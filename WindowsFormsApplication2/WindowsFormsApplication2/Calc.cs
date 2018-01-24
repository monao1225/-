using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Calc
    {
        public double calc(double x, double y, string opr)
        {
            double result = y;

            if (opr == "+") {
                result = x + y;
            }
            if (opr == "-") {
                result = x - y;
            }
            if (opr == "*") {
                result = x * y;
            }
            if (opr == "/") {
                result = x / y;
            }

            return result;
        }
    }
}
