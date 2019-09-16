using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("Enter the parol: ");
                string parol = Console.ReadLine();
                if (parol != "1234")
                {
                    Console.WriteLine("Enter the parol once again");                    
                }
                else
                {
                    Console.WriteLine("Congratulation, you are entered the right parol");
                    break;
                }

            }
        }
    }
}
