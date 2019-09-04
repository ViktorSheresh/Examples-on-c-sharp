using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp
{
    class Program
    {
        static ulong Power(uint x, uint n)
        {
            uint res = 1;
            for (int i = 1; i <= n; i++)
            {
                if (res == 0)
                {
                    return 1;
                }
                res *= x;
            }
            return res;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(Power(2, 3));
        }
    }
    class MyMathClass
    {
        ulong power(uint x, uint n)
        {
            if (n == 0) return 1;
            ulong res = x;
            for (int i = 2; i <= n; i++)
            {
                res *= x;
            }
            return res;
        }
    }
}
