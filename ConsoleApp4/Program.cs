using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;

            for (double a = 1; a <= 6; a++)
            {
                for (double b = 1; b <= 8; b++)
                {
                    for (double c = 1; c <= 10; c++)
                    {
                        s += Log(a) + Log10(b) + Sqrt(c);
                    }
                }
            }

            Console.WriteLine($"{s:f2}");
        }
    }
}
