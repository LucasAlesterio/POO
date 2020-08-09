using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] s = new double[10];
            double somatotal = 0.0;
            double somaFunc = 0.0;
            double somaGrad = 0.0;
            double somaMedio = 0.0;
            double somaBasic = 0.0;
            funcionario[] vetor = new funcionario[10];
            medio f0 = new medio("Geraldo", "85231", "branca");
            medio f1 = new medio("Lucas", "12455", "rosa");
            funcionario f2 = new funcionario("Leticia", "12345");
            funcionario f3 = new funcionario("João", "88542");
            funcionario f4 = new funcionario("Sofia", "32548");
            basico f5 = new basico("José", "46123", "amarela");
            basico f6 = new basico("Rafael", "48514", "vermelha");
            basico f7 = new basico("Pedro", "69886", "branca");
            graduacao f8 = new graduacao("Elias", "745156", "UFG", "Economia");
            graduacao f9 = new graduacao("Maria", "548427", "UFMG", "Gastronomia");
            vetor[0] = f0; vetor[1] = f1; vetor[2] = f2; vetor[3] = f3; vetor[4] = f4; vetor[5] = f5; vetor[6] = f6; vetor[7] = f7; vetor[8] = f8; vetor[9] = f9;
            for (int i = 0; i < 10; i++)
            {
                s[i] = vetor[i].salario();
                somatotal += s[i];
                if (s[i] == 1000)
                {
                    somaFunc += s[i];
                }
                if (s[i] == 1100)
                {
                    somaBasic += s[i];
                }
                if (s[i] == 1500)
                {
                    somaMedio += s[i];
                }
                if (s[i] == 2000)
                {
                    somaGrad += s[i];
                }
            }
                Console.WriteLine("Custo com salarios total: " + somatotal + "\n" + "Soma salarios de ensino fundamental: " + somaFunc + "\n" +
                    "Soma salarios de ensino basico: " + somaBasic + "\n" + "Soma salarios de ensino Medio: " + somaMedio + "\n" +
                    "Soma salarios de ensino Superior: " + somaGrad + "\n");
                Console.ReadLine();
        }
    }
}
