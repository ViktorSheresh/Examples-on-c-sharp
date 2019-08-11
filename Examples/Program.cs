using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_creating_using_methods
{
    class Program
    {
        static void CreateRectangle(int starsRectangle)
        {
            for (int i = 1; i < starsRectangle; i++)
            {
                for (int j = 0; j < starsRectangle; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void CreateTringle(int starsTriangle)
        {
            for (int i = 1; i < starsTriangle; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void CreatePyramid(int starsPyramid)
        {
            for (int i = 0; i < starsPyramid; i++)
            {
                for (int j = 0; j < starsPyramid - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }

        static void CreateRhombus(int starsRhombus)
        {
            int i, k, count = 1;

            count = starsRhombus - 1;
            for (k = 1; k <= starsRhombus; k++)
            {
                for (i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            count = 1;
            for (k = 1; k <= starsRhombus - 1; k++)
            {
                for (i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count++;
                for (i = 1; i <= 2 * (starsRhombus - k) - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }


        static void Main(string[] args)
        {
            Console.Write("Enter user name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, {0}, please, what is your favorite figure?", userName);

        LabelFigure:
            Console.Write("Rectangle, Triangle, Pyramid or Rhombus: ");
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "Rectangle":
                    Console.Write("Enter the stars number of Rectangle: ");
                    int starsRectangle = Convert.ToByte(Console.ReadLine());
                    CreateRectangle(starsRectangle);
                    break;
                case "Triangle":
                    Console.Write("Enter the stars number of Triangle: ");
                    int starsTriangle = Convert.ToByte(Console.ReadLine());
                    CreateTringle(starsTriangle);
                    break;
                case "Pyramid":
                    Console.Write("Enter the stars number of Pyramid: ");
                    int starsPyramid = Convert.ToByte(Console.ReadLine());
                    CreatePyramid(starsPyramid);
                    break;
                case "Rhombus":
                    Console.Write("Enter the stars number of Rombus: ");
                    int starsRhombus = Convert.ToByte(Console.ReadLine());
                    CreateRhombus(starsRhombus);
                    break;
                default:
                    Console.WriteLine("Choose your your figure once again:");
                    goto LabelFigure;
            }

        }
    }
}
