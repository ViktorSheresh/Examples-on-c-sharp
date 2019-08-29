using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Recursion (int value)
        {
            value--;
            Console.WriteLine("Value {0}", value);

            if (value != 0)
                Recursion(value);
            Console.WriteLine("Value {0}", value);
        }

        static void Main(string[] args)
        {
            Recursion(10);
        }
    }
}
