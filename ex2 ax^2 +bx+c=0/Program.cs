using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_ax_2__bx_c_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti numarul A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti numarul B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti numarul C");
            int c =int.Parse(Console.ReadLine());
            int delta = b ^ 2 - 4 * a * c;
            Console.WriteLine($"Delta ={delta} ");
            if (delta < 0) { Console.WriteLine("NU exista x1 si x2"); }
            else
            {
                Console.Write(delta);
                double x1 = (b * b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (b * b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1={x1} si x2={x2}");
            }
            Console.ReadKey();
        }
    }
}
