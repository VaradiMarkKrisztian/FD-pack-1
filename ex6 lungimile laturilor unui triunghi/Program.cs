using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_lungimile_laturilor_unui_triunghi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimile laturilor triunghiului");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a <= c && b <= c)
            {
                if (a * a + b * b == c * c) Console.WriteLine("cele 3 lungimi sunt laturile unui triunghi");
                else Console.WriteLine("cele 3 lungimi nu sunt laturile unui triunghi");
            }
            if (b <= a && c <= a)
            {
                if (b * b + c * c == a * a) Console.WriteLine("cele 3 lungimi sunt laturile unui triunghi");
                else Console.WriteLine("cele 3 lungimi nu sunt laturile unui triunghi");
            }
            if(a<=b && c<=b)
            {
                if(a*a+c*c==b*b) Console.WriteLine("cele 3 lungimi sunt laturile unui triunghi");
                else Console.WriteLine("cele 3 lungimi nu sunt laturile unui triunghi");
            }
            Console.ReadKey();
        }
    }
}
