using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_ax_b_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti un numar A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("introduceti un numar B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("X din ecuatia A*x+B= ");
            double x =b / a;
            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}
