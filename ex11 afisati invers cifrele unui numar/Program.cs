using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_afisati_invers_cifrele_unui_numar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            int cifre;
            Console.WriteLine("Cifrele in ordine inversa sunt");
            while (n != 0)
            {
                cifre = n % 10;
                n = n / 10;
                Console.Write(cifre);
            }
            Console.ReadKey();
        }
    }
}
