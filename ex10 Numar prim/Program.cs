using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10_Numar_prim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int d;
                for ( d = 2; d <= n / 2; d++)
                 if (n % d == 0) k = 1; 
            if (k == 0) Console.WriteLine("Numarul este prim");
            else  Console.WriteLine("Numarul nu este prim");
            Console.ReadKey();
        }
    }
}
