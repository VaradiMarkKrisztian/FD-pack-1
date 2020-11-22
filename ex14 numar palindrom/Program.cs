using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14_numar_palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            int aux = n, inversul = 0;
            while(aux!=0)
            {
                inversul = inversul * 10 + aux % 10;
                aux = aux / 10;
            }
            if (inversul == n) Console.WriteLine("Numarul introdus este palindrom");
            else Console.WriteLine("Numarul introdus nu este palindrom");
            Console.ReadKey();
        }
    }
}
