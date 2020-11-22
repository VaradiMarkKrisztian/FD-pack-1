using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17_cmmdc_si_cmmmc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti 2 numere");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            if (a >= b)
            {
                while (a != b) { a = a - b; }
                Console.WriteLine($"Cel mai mare divizor comun este {a} ");
            }
            else if(b>a)
            {
                while(b != a) { b = b - a; }
                Console.WriteLine($"Cel mai mare divizor comun este {a} ");
            }
            Console.ReadKey();
        }
    }
}
