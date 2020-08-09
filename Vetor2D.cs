using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Vetor2D
    {
        private double x;
        private double y;
        //Construtor:

        public Vetor2D()
        {
            x = 0;
            y = 0;
        }
        public Vetor2D(double x1,double y1)
        {
            x = x1;
            y = y1;

        }
        public void setx(double a)
        {
            x = a;
        }
        public void sety(double b)
        {
            y = b;
        }
        public double getx()
        {
            return this.x;
        }
        public double gety()
        {
            return this.y; 
        }
        public double escalar(Vetor2D a, Vetor2D b)
        {
            double produto;
            produto = ((a.x * b.x) + (a.y * b.y));
            return produto;

        }
        public double modulo(Vetor2D a)
        {
            double mod;
            mod = Math.Sqrt((a.x * a.x) + (a.y * a.y));
            return mod;
        }
        public double angulo(Vetor2D a, Vetor2D b)
        {
            double z = (((escalar(a, b)) / (modulo(b)*modulo(a))));
            double result = Math.to(Math.Acos(z));
            return result;
        }
        public Vetor2D projecao(Vetor2D a,Vetor2D b)
        {
            double proj = escalar(a, b) / (modulo(a)*modulo(a));
            double x1 = proj * a.x;
            double x2 = proj * a.y;
            Vetor2D vetorproj = new Vetor2D(x1, x2);
            return vetorproj;
        }







    }
}
