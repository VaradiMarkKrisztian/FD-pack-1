using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15_3_numere_in_ordine_crescatoare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti 3 numere");
            int n = 3;
            int[] v = new int[n];
            for (int i = 0; i < n; i++) v[i] = int.Parse(Console.ReadLine());
            int aux = 0;
            for(int i=0; i< n-1; i++)
                for(int j = i + 1; j < n; j++) 
                {
                    if (v[i] > v[j]) 
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux; 
                    }
                }
            Console.WriteLine($"Elementele in ordine crescatoare sunt {v[0]} {v[1]} {v[2]}");
            Console.ReadKey();
        }
    }
}
