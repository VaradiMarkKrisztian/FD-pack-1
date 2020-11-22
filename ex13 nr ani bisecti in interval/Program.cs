using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13_nr_ani_bisecti_in_interval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti limita inferioara a intervalului");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti limita superioara a intervalului");
            int b = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = a; i <= b; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0)) nr++;
            }
            Console.WriteLine($"In intervalul {a} {b} sunt {nr} numere ani bisecti");
            Console.ReadKey();
        }
    }
}
