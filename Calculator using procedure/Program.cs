using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    class Program
    {
        static void Add(int operand1, int operand2)
        {
            int result = operand1 + operand2;
            Console.WriteLine("The result is {0}", result);
        }
        static void Sub(int operand1, int operand2)
        {
            int result = operand1 - operand2;
            Console.WriteLine("The result is {0}", result);
        }
        static void Mul(int operand1, int operand2)
        {
            int result = operand1 * operand2;
            Console.WriteLine("The result is {0}", result);
        }
        static void Div(int operand1, int operand2)
        {
            int result = operand1 / operand2;
            Console.WriteLine("The result is {0}", result);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");

        LabelOperation:
            try
            {
                Console.Write("Number 1: ");
                string numberOne = Console.ReadLine();
                int number1 = Int32.Parse(numberOne);
                Console.Write("Number 2: ");
                string numberTwo = Console.ReadLine();
                int number2 = Int32.Parse(numberTwo);

                Console.WriteLine("Enter operation");
                Console.Write("Operations (-; +; /; *): ");

                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Add(number1, number2);
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            Div(number1, number2);
                        }
                        else
                        {
                            Console.WriteLine("You cannot divide by zero, please try again");
                            goto LabelOperation;
                        }
                        break;
                    case "*":
                        Mul(number1, number2);
                        break;
                    case "-":
                        Sub(number1, number2);
                        break;
                    default:
                        Console.WriteLine("You entered wrong operation, please try again");
                        goto LabelOperation;
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("It's NOT a number!!!!");
                goto LabelOperation;
            }

        }

    }
}
