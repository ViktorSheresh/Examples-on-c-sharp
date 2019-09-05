using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    class Program
    {
        static int Reference (ref int value)
        {
            value = 999;
            return value;
        }

        static void Main(string[] args)
        {
            int b = 100;
            Console.WriteLine("b before ref modificator {0}", b);
            Reference(ref b);
            Console.WriteLine("b after ref modificator {0}", b);

        }
    }
}
