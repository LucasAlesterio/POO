using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Vetor3D : Vetor2D
    {
        private double z;

        public Vetor3D() : base() => z = 0.0;
        public Vetor3D(double _z) => z = _z;

        public Vetor3D(double x, double y, double _z) : base(x, y)
        {
            z = _z;
        }
        public void setz(double _z) => z = _z;
        public double getz() => z;

        public double modulo()
        {
            double ans;
            ans = Math.Sqrt((x * x) + (y * y) + (z * z));
            return ans;
        }
        public Vetor3D pruduto(Vetor3D a)
        {
            Vetor3D b = new Vetor3D();
            b.x = (y * a.z) - (z * a.y);
            b.y = (z * a.x) - (x * a.z);
            b.z = (x * a.y) - (y * a.x);

            return b;
        }

    }
}