using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out
{
    class Program
    {
        static void Function(out int value, out int value1)
        {
            value = 100;
            value1 = 200;
        }

        static void Main(string[] args)
        {
            int a;
            int b;
            //Console.WriteLine(a);
            Function(out a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
