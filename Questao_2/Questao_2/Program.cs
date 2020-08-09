using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            
            int op;
            void menu()
            {
                Console.Clear();
                Console.WriteLine("1- Inserir _ 2-Remover _ 3-Imprimir _ 4-Sair");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        lista.Add(Convert.ToInt32(Console.ReadLine()));
                        lista.Sort();
                        menu();

                        break;
                    case 2:
                        lista.Remove(Convert.ToInt32(Console.ReadLine()));
                        lista.Sort();
                        menu();
                        break;
                    case 3:
                        String str = "";
                        foreach (int item in lista)
                        {
                            str = str + item + ",";

                        }

                        Console.WriteLine(str);
                        Console.ReadLine();
                        menu();
                        break;
                    case 4:
                        break;

                }
            }
            menu();
        }
    }
}
