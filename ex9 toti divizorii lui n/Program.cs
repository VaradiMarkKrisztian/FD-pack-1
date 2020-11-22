using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9_toti_divizorii_lui_n
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Divizorii numarului sunt");
               for (int d = 2; d <= n / 2; d++)
               { if (n % d == 0) Console.Write(d+" "); }
            Console.ReadKey();
        }
    }
}
