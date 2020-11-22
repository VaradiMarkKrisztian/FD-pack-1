using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_An_Y_bisect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti un an Y");
            int y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0)) Console.WriteLine($"Anul {y} este an bisect");
            else Console.WriteLine($"Anul {y} nu este an bisect");
            Console.ReadKey();
        }
    }
}
