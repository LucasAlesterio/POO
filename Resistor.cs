using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1_P1
{
    class Resistor
    {
        // atributos
        private double resistencia, potencia_max;

        //construtores
        public Resistor()
        {
            resistencia = 0.0;
            potencia_max = 0.0;
        }

        public Resistor(double _res, double _maxPot)
        {
            resistencia = _res;
            potencia_max = _maxPot;
        }
        

        //getters e setters
        public double getRes()
        {
            return resistencia;
        }

        public double getPot()
        {
            return potencia_max;
        }

        public void setRes(double _res)
        {
            resistencia = _res;
        }

        public void setPot(double _maxPot)
        {
            potencia_max = _maxPot;
        }
        //

        //métodos
        public void imprimeResistor()
        {
            Console.WriteLine("Valor da resistência: {0} Ohms", resistencia);
            Console.WriteLine("Potência Máxima: {0} W", potencia_max);
        }

        public Resistor resistorSerie(Resistor r2)
        {
            Resistor Req = new Resistor();

            Req.resistencia = r2.resistencia + this.resistencia;

            if (r2.potencia_max < this.potencia_max) Req.potencia_max = r2.potencia_max;
            else Req.potencia_max = this.potencia_max;

            return Req;
        }

        public Resistor resistorParalelo(Resistor r2)
        {
            Resistor Req = new Resistor();

            Req.resistencia = (r2.resistencia * this.resistencia) / (r2.resistencia + resistencia);

            if (r2.potencia_max < potencia_max) Req.potencia_max = r2.potencia_max;
            else Req.potencia_max = potencia_max;

            return Req;
        }
    }
}
