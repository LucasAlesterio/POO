using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Vetor2D
    {
        public double x;
        public double y;
        //Construtor:

        public Vetor2D()
        {
            x = 0.0;
            y = 0.0;
        }
        public Vetor2D(double x1, double y1)
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
    }
}
