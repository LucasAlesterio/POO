using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();
            Console.WriteLine("Hello world!");
            r1.imprime();
            r1.setAltura(20);
            r1.imprime();
            Retangulo r2 = new Retangulo();
            r2.imprime();
            Console.Read();

    }
}
}
