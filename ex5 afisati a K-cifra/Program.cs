using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_afisati_a_K_cifra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti pozitia cifrei");
            int k = int.Parse(Console.ReadLine());
            int c = 0;
            for(int i=1; i<=k;i++)
            {
                c = n % 10;
                n = n / 10;
            }
            Console.WriteLine($"Cifra numarului de pe pozitia ceruta K este {c}");
            Console.ReadKey();
        }
    }
}
