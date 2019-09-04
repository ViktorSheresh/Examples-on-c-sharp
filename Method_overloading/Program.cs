using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading
{
    class Program
    {
        static int StringsSumLength(string s)
        {
            return s.Length;
        }
        static int StringsSumLength(string s1, string s2)
        {
            return s1.Length + s2.Length;
        }

        static void Main(string[] args)
        {
            int a = StringsSumLength("Hello");
            int b = StringsSumLength("Hi", "Hey");

            Console.WriteLine($"{a} and {b}");
        }
    }
}
