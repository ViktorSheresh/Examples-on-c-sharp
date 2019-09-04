using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunction
{
    class Program
    {
        static void RecursiveFunction(int n)
        {
            Console.WriteLine("Верхняя половина метода: {0}", n);

            if (n > 0)
                RecursiveFunction(n - 1);

            Console.WriteLine("Нижняя половина метода: {0}", n);
        }

        static void Main(string[] args)
        {
            RecursiveFunction(5);
            Console.ReadKey();
        }
    }
}
