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
            
            Punto3D e;
            e = new Punto3D(3, 8, 5.1);
            Console.WriteLine(e.ToString());

            Punto3D f;
            f = new Punto3D(6, 7, 4.2);
            Console.WriteLine(f.ToString());

            double d = e.Distancia(f);
            Console.WriteLine("Distancia" + d);
            Console.ReadKey();

        }
    }
}
