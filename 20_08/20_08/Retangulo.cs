using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_08
{
    class Retangulo
    {
        //atributos
        private int basE;
        private int alturA;

        //metodos
        //construtor - metodo que cria objetos da classe
        public Retangulo()
        {
            basE = 10;
            alturA = 5;
        }
        public void imprime()
        {
            Console.WriteLine("Base = " + basE + "\nAltura=" + alturA + "\n");
        }
        public void setAltura(int a)
        {
            alturA = a;
        }
        
    }
}
