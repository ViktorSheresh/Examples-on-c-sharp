using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte[] byte_array = new byte[4] { 2, 4, 7, 15 };
            //Console.WriteLine(byte_array[0]);
            //Console.WriteLine(byte_array[1]);
            //Console.WriteLine(byte_array[2]);
            //Console.WriteLine(byte_array[3]);

            int[,] array = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = i * j;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();

            }

        }
    }
}
