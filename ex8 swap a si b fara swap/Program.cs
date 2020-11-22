using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_swap_a_si_b_fara_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti prima valoare");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti a doua valoare");
            int b = int.Parse(Console.ReadLine());
            if (a >= b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            else
            {
                b = b + a;
                a = b - a;
                b = b - a;
            }
            Console.WriteLine("Elementele dupa inversare sunt");
            Console.Write(a + " ");
            Console.Write(b);
            Console.ReadKey();
        }
    }
}
