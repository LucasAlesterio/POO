using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor3D v1 = new Vetor3D();
            Vetor3D v2 = new Vetor3D();
            Vetor3D v3 = new Vetor3D();

            Console.WriteLine("Digite a componente x do primeiro vetor:");
            v1.setx(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a componente y do primeiro vetor:");
            v1.sety(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a componente z do primeiro vetor:");
            v1.setz(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a componente x do segundo vetor:");
            v2.setx(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a componente y do segundo vetor:");
            v2.sety(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a componente z do segundo vetor:");
            v2.setz(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Modulo do vetor 1: " + v1.modulo() + " \nModulo do vetor 2: " + v2.modulo());
            v3 = v2.pruduto(v1);
            Console.WriteLine("O vetor produto de 1 e 2 é: " + v3.getx() + "," + v3.gety() + "," + v3.getz() + "\n");
            Console.ReadLine();

        }
    }
}
