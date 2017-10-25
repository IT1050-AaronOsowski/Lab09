using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09
{
    
    class MyMath
    {
        double result;
        double operand1;
        double operand2;


        public MyMath()
        {
        }


        public void Multiply(double operand1, double operand2, out string sign)
        {
            result = operand1 * operand2;
            sign = "*";

        }

        public void Divide(double operand1, double operand2, out string sign)
        {
            result = operand1 / operand2;
            sign = "/";
        }

        public void Subtract(double operand1, double operand2, out string sign)
        {
            result = operand1 - operand2;
            sign = "-";

        }

        public void Add(double operand1, double operand2, out string sign)
        {
            result = operand1 + operand2;
            sign = "+";

        }

        public double GetResult()
        {
            return result;
        }

    }
}
