using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_N_se_divide_cu_K
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numar N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti un divizor K");
            int k = int.Parse(Console.ReadLine());
            if (n % k == 0) Console.WriteLine("K il divide pe N");
            else Console.WriteLine("K nu il divide pe N");
            Console.ReadKey();

        }
    }
}
