using System;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            Random r = new Random();

            string message = "Ya done some math." +
                "\n" +
                "Your result is: ";
            string sign = "";

            double operand1 = r.Next(100);
            double operand2 = r.Next(100);

            Console.WriteLine("Your numbers are [{0}] and [{1}]\n", operand1, operand2);

            m.Multiply(operand1, operand2, out sign);
            Console.WriteLine("{0}{1}   [[{2} {3} {4}]]\n",message, m.GetResult(),
                operand1, sign, operand2);
            m.Divide(operand1, operand2, out sign);
            Console.WriteLine("{0}{1}   [[{2} {3} {4}]]\n", message, m.GetResult(),
                operand1, sign, operand2);
            m.Subtract(operand1, operand2, out sign);
            Console.WriteLine("{0}{1}   [[{2} {3} {4}]]\n", message, m.GetResult(),
                 operand1, sign, operand2);
            m.Add(operand1, operand2, out sign);
            Console.WriteLine("{0}{1}   [[{2} {3} {4}]]\n", message, m.GetResult(),
                operand1, sign, operand2);

            Console.ReadKey(true);
        }
    }
}
