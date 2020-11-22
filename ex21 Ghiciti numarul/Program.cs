using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex21_Ghiciti_numarul
{
    class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Numarul se afla intre 1 si 1024");
            
            int random = rng.Next(1025);
            Console.WriteLine("introduceti numere pentru a il ghici");
            int ok = 0;
            while (ok == 0)
            {
                int numar = int.Parse(Console.ReadLine());
                if (numar < random) Console.WriteLine("Incearca un numar mai mare");
                if (numar > random) Console.WriteLine("Incearca un numar mai mic");
                if (numar == random)
                {
                    Console.WriteLine($"Ai gasit numarul {random}");
                    ok = 1;
                }
            }
            Console.ReadKey();
        }
    }
}
