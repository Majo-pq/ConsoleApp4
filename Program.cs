using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto2D a;
            a = new Punto2D(1,1);
            Console.WriteLine(a.ToString());


            Punto2D b;
            b = new Punto2D(2,2);

            Console.WriteLine(b.ToString());

            double d = a.Distancia(b);
            Console.WriteLine("Distancia" + d);

           

            Console.ReadKey();

        }
    }
}
