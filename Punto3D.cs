using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Punto3D : Punto2D
    {
        protected double z;

        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }

        public Punto3D() : base()
        {
            z = 0;
        }

        public Punto3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public double Distancia(Punto3D p)
        {
            double d = 0;
            double dy = y - p.y;
            double dz = z - p.z;
            double dx = x - p.x;
            double cdz = Math.Pow(dz, 2);
            double cdy = Math.Pow(dy, 2);
            double cdx = Math.Pow(dx, 2);
            d = Math.Sqrt(cdz + cdy + cdx);

            return d;
        }

        public override string ToString()
        {
            return base.ToString() + "Z=" + z;
        }
    }
}
