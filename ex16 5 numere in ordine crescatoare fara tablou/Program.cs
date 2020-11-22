using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16_5_numere_in_ordine_crescatoare_fara_tablou
{
    class Program
    {
        static void Main(string[] args)

        {   Console.WriteLine("introduceti 5 numere");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            //asezarea primelor 4 elemente
            int aux;
            if (a > b) { aux = a; a = b; b = aux; }
            if (c > d) { aux = c; c = d; d = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (b > d) { aux = b; b = d; d = aux; }
            if (b > c) { aux = b; b = c; c = aux; }
            //asezarea ultimului element
            if(e<a) { aux = a; a = e; e = aux;}
            if (a > b) { aux = a; a = b; b = aux; }
            if (c > d) { aux = c; c = d; d = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (b > d) { aux = b; b = d; d = aux; }
            if (b > c) { aux = b; b = c; c = aux; }
            
            if(e>=a && e<b) { aux = b; b = e; e = aux;}
            if (c > d) { aux = c; c = d; d = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (b > d) { aux = b; b = d; d = aux; }
            if (b > c) { aux = b; b = c; c = aux; }

            if(e>=b && e<c) { aux = c; c = e; e = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (b > d) { aux = b; b = d; d = aux; }
            if (b > c) { aux = b; b = c; c = aux; }

            if(e>=c && e<d) { aux = d; d = e; e = aux; }
            if (b > d) { aux = b; b = d; d = aux; }
            if (b > c) { aux = b; b = c; c = aux; } 
            Console.WriteLine($"numerele in ordine crescatoare sunt {a} {b} {c} {d} {e}");
            Console.ReadKey();
        }
    }
}
