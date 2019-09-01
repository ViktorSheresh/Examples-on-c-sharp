using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of array elements");

            int elementsNumber = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[elementsNumber];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;

                Console.WriteLine("Arrays elements {0}", array[i]);
            }
        }
    }
}
