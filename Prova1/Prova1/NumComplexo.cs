using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class NumComplexo
    {
        private double Re;
        private double Im;

        public NumComplexo()
        {
            Re = 0;
            Im = 0;
        }
        public NumComplexo(double x, double y)
        {
            Re = x;
            Im = y;
        }
        public void setRe(double x)
        {
            Re = x;

        }
        public void setIm(double x)
        {
            Im = x;

        }
        public NumComplexo soma(NumComplexo a)
        {
            NumComplexo somaim = new NumComplexo();
            somaim.Re = this.Re + a.Re;
            somaim.Im = this.Im + a.Im;
            return somaim;
        }
        public NumComplexo vezes(NumComplexo a)
        {
            NumComplexo prodim = new NumComplexo();
            prodim.Re = (this.Re * a.Re) - (this.Im * a.Im);
            prodim.Im = (this.Re * a.Im) + (this.Im * a.Re);
            return prodim;
        }
        public double modulo()
        {
            double mol;
            mol = Math.Sqrt((this.Re*this.Re)+(this.Im*this.Im));
            return mol;
        }
        public double argumento()
        {
            double angulo = 0;
            angulo = Math.Acos(this.Re / this.modulo());
            return angulo;
        }
        public void imprimeFormaPolar()
        {
            Console.WriteLine(this.modulo() + ".(cos(" + this.argumento() + ") + i.sen(" + this.argumento() + "))\n");
        }


    }
}
