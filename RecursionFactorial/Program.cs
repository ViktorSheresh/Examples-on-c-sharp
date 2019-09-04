using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionFactorial
{
    class Program
    {
        static int Factorial(int a)
        {
            if (a == 0)
                return 1;
            else
                return a * Factorial(a - 1); 
        }

        static void Main(string[] args)
        {
            int res = Factorial(5);
            Console.WriteLine(res); 
        }
    }
}
