using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor2D v1 = new Vetor2D();
            Vetor2D v2 = new Vetor2D();
            Vetor2D v3 = new Vetor2D();

            double x, y;
            Console.WriteLine("Digite a componente x do primeiro vetor:");
            v1.setx(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a componente y do primeiro vetor:");
            v1.sety(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a componente x do segundo vetor:");
            v2.setx(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a componente y do segundo vetor:");
            v2.sety(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Vetor 1: (" + v1.getx() + "," + v1.gety() + ")" + "\nVetor 2: (" + v2.getx() + "," + v2.gety() + ")\n");
            Console.WriteLine("Produto escalar dos vetores: " + v3.escalar(v1, v2) + "\n");
            Console.WriteLine("Modulo do vetor 1: " + v3.modulo(v1) + "\n");
            Console.WriteLine("Modulo do vetor 2: " + v3.modulo(v2) + "\n");
            Console.WriteLine("Angulo entre o vetor 1 e 2:(em radianos) " + v3.angulo(v1, v2) + "\n");
            v3 = v3.projecao(v1, v2);
            Console.WriteLine("Vetor projeção de 1 em 2: " + " (" + v3.getx() + ", " + v3.gety() + ")\n");
            Console.ReadLine();




        }
    }
}
