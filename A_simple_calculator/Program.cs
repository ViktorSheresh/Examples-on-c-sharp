using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static int ToCalculate(int firstOperand, int secondOperand, string sign)
        {
            if (sign == "+")
            {
                int sum = firstOperand + secondOperand;
                return sum;
            }
            else if (sign == "-")
            {
                int sub = firstOperand - secondOperand;
                return sub;
            }
            else if (sign == "/")
            {
                int div = firstOperand / secondOperand;
                return div;
            }
            else if (sign == "*")
            {
                int mul = firstOperand * secondOperand;
                return mul;
            }
            return 0;
        }
        static void Main(string[] args)
        {
        Label:
            Console.Write("Enter a sign: ");
            string sign = Console.ReadLine();

            if (sign == "+" || sign == "-" || sign == "/" || sign == "*")
            {
                Console.Write("Enter first number: ");
                int operand1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int operand2 = Convert.ToInt32(Console.ReadLine());

                int result = ToCalculate(operand1, operand2, sign);

                Console.WriteLine("The result is {0}{1}{2} = {3}", operand1, sign, operand2, result);
            }
            else
            {
                Console.WriteLine("Error, try");
                goto Label;
            }


        }
    }
}