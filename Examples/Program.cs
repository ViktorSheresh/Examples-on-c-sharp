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

        static void Main(string[] args)
        {
            Console.Write("Enter user name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, {0}, please, what is your favorite figure?", userName);

        LabelFigure:
            Console.Write("Rectangle or Triangle: ");
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "Rectangle":
                    Console.Write("Enter the stars number of Rectangle: ");
                    byte starsRectangle = Convert.ToByte(Console.ReadLine());
                    CreateRectangle(starsRectangle);
                    break;
                case "Triangle":
                    Console.Write("Enter the stars number of Triangle: ");
                    byte starsTriangle = Convert.ToByte(Console.ReadLine());
                    CreateTringle(starsTriangle);
                    break;
                default:
                    Console.WriteLine("Choose your your figure once again:");
                    goto LabelFigure;
            }

        }
    }
}
