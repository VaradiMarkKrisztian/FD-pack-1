using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7_swap_a_si_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti prima valoare");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti a doua valoare");
            int b = int.Parse(Console.ReadLine());
            int swap = 0;
            swap = a;
            a = b;
            b = swap;
            Console.WriteLine("elementele inversate sunt ");
            Console.Write(a+" ");
            Console.Write(b);
            Console.ReadKey();
        }
    }
}
