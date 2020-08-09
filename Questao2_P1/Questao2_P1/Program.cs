using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] s = new double[6];
            Pagtos[] vetor = new Pagtos[6];

            Saude f0 = new Saude(123, 123, 123, "jsdsa", 123);
            Saude f1 = new Saude(123, 123, 123, "asdahgai", 123);
            Alimentacao f2 = new Alimentacao(123, 1421, 154321, "jagkdsmsd", 12431);
            Saude f3 = new Saude(124, 12643, 458541, "jkmkdsç", 48452);
            Alimentacao f4 = new Alimentacao(12312, 54454, 485151, "jfklçkojlçs", 48512);
            Alimentacao f5 = new Alimentacao(515846, 48551, 64545, "asdjiag", 94645);
            vetor[0] = f0; vetor[1] = f1; vetor[2] = f2; vetor[3] = f3; vetor[4] = f4; vetor[5] = f5;
            for (int i = 0; i < 6; i++)
            {
                Console.Write(vetor[i].getCpf() + " " + vetor[i].getCode() + " "+ vetor[i].getValor() + " " );
                vetor[i].imprime();
                // s[i] = vetor[i].faturar();


            }
            Console.ReadLine();
        }
    }
}
