using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumComplexo z1 = new NumComplexo(1,1);
            NumComplexo z2 = new NumComplexo(3,-1);
            NumComplexo a = new NumComplexo();
            NumComplexo b = new NumComplexo();
            a = z1.soma(z2);
            Console.WriteLine("Soma: \n");
            a.imprimeFormaPolar();
            a = z1.vezes(z2);
            Console.WriteLine("Produto: \n");
            a.imprimeFormaPolar();
            Console.ReadLine();







        }
    }
}
