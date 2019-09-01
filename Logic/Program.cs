using System;

namespace Logic
{
    class Program
    {
        static ulong Power (uint x, uint n)
        {
            ulong res = 1;
            for (int i = 0; i <= n; i++)
			{
                if (n == 0)
	            {           
                    return (ulong)Math.Pow(x,0);
	            }
                res = (ulong)Math.Pow(x,n);
			}
            return res;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Power(2,10));
        }
    }


}
