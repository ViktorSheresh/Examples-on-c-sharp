using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            byte b;
            checked
            {
            b = (byte)a;
            }
            Console.WriteLine(b);
        }
    }
}
